using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Common.Vm.Backup;
using Quicker.Common.Vm.ExeActions;
using Quicker.Common.Vm.Note;
using Quicker.Common.Vm.Share;
using Quicker.Common.Vm.Expression;
using Quicker.Public.Actions;
using Quicker.Domain.Extensions;

namespace Quicker.Domain.Services;

// 原来必须调用账号 API 的数据操作，直接落在工作区 SQLite 中。
internal static class LocalDataStore
{
    private static readonly object Gate = new object();
    private static SQLDataMgr Database => AppState.SQLDataMgr;

    internal static Task<ApiResult<T>> Execute<T>(Func<T> operation)
    {
        try { lock (Gate) return Task.FromResult(ApiResult<T>.Success(operation())); }
        catch (Exception error) { return Task.FromResult(ApiResult<T>.Error("本地操作失败：" + error.Message)); }
    }

    internal static List<T> ReadList<T>(string key) => Database.PP6trtaO3SY<List<T>>(key) ?? new List<T>();
    private static void Save(string key, object value) => Database.SaveCommonDataObjectFromLocal(key, value, true);

    internal static T Require<T>(string key) where T : class => Database.PP6trtaO3SY<T>(key)
        ?? throw new FileNotFoundException("本地没有该内容，请先导入完整文件：" + key);

    internal static SharedActionDto GetSharedAction(Guid id, int? revision)
    {
        // 指定版本必须精确匹配，不能静默使用其它版本的动作。
        int? selected = revision ?? Database.EHLtrsqXGsM(id.ToString()).Select(x => (int?)x.Revision).Max();
        var action = selected.HasValue ? Database.p02trGElaNv(id.ToString(), selected.Value) : null;
        return action ?? throw new FileNotFoundException($"本地缺少动作正文：{id}，版本 {revision?.ToString() ?? "未指定"}。当前仅有动作引用，请导入包含正文的动作文件或备份；不会连接原厂服务器下载。");
    }

    internal static SharedActionDto ReadSharedActionFile(string source)
    {
        if (Uri.TryCreate(source, UriKind.Absolute, out var uri))
        {
            if (!uri.IsFile) throw new InvalidOperationException("此处仅读取本地文件；网站链接请使用主动导入入口。");
            source = uri.LocalPath;
        }
        if (!File.Exists(source)) throw new FileNotFoundException("本地动作文件不存在。", source);
        var action = JsonConvert.DeserializeObject<SharedActionDto>(File.ReadAllText(source));
        if (action == null || action.Id == Guid.Empty) throw new InvalidDataException("文件不是包含动作标识的完整共享动作 JSON。");
        return action;
    }

    internal static string BackupAction(ActionItem action, bool manual, string note, string systemNote, DateTime? expires)
    {
        // 引用动作先补入本地正文；本地缺失时报告缺失，不能把引用当作完整备份。
        var copy = action.Clone(false);
        if (copy.UseTemplate && !string.IsNullOrEmpty(copy.TemplateId))
        {
            var body = GetSharedAction(Guid.Parse(copy.TemplateId), copy.TemplateRevision);
            copy.Data = body.Data;
            copy.Data2 = body.Data2;
            copy.Data3 = body.Data3;
            copy.Children = body.Children;
            copy.UseTemplate = false;
        }
        return SaveBackup(new BackupItemVm { ObjectType = UserObjectType.Action, ObjectId = copy.Id,
            DisplayName = copy.Title, ObjectIcon = copy.Icon, Data = JsonConvert.SerializeObject(copy),
            IsManualSave = manual, UserNote = note, SystemNote = systemNote, CreateTimeUtc = DateTime.UtcNow,
            ExpireTimeUtc = expires, MachineName = Environment.MachineName });
    }

    internal static string IncrementCount(string key)
    {
        lock (Gate)
        {
            var counts = Database.PP6trtaO3SY<Dictionary<string, int>>("local_library_usage") ?? new Dictionary<string, int>();
            counts.TryGetValue(key, out int count);
            counts[key] = count + 1;
            Save("local_library_usage", counts);
        }
        return "已记录到本地。";
    }

    internal static SharedExpressionDto SaveExpression(ShareExpressionVm source)
    {
        var expressions = ReadList<SharedExpressionDto>("local_expressions");
        var expression = JObject.FromObject(source).ToObject<SharedExpressionDto>();
        expression.Id = source.Id ?? Guid.NewGuid();
        expressions.RemoveAll(x => x.Id == expression.Id);
        expressions.Add(expression);
        Save("local_expressions", expressions);
        return expression;
    }

    internal static IList<SharedExpressionDto> FindExpressions(string keyword, VarType? input, VarType? result, int skip, int take) =>
        ReadList<SharedExpressionDto>("local_expressions").Where(x => (!input.HasValue || x.ForVarType == input)
            && (!result.HasValue || x.ResultType == result) && (string.IsNullOrEmpty(keyword)
            || ((x.Title ?? "") + " " + (x.Expression ?? "")).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0))
            .Skip(Math.Max(0, skip)).Take(Math.Max(0, take)).ToList();

    internal static IList<TextCommand> GetTextCommands() => ReadList<TextCommand>("user_textCommands");

    internal static IList<TextCommand> SaveTextCommands(IList<TextCommand> changes, bool create)
    {
        var commands = ReadList<TextCommand>("user_textCommands");
        foreach (var command in changes)
        {
            if (command.Id == Guid.Empty) command.Id = Guid.NewGuid();
            int index = commands.FindIndex(c => c.Id == command.Id);
            if (!create && index < 0) throw new InvalidOperationException("文本指令不存在。");
            command.LastUpdateTimeUtc = DateTime.UtcNow;
            if (index >= 0) commands[index] = command; else commands.Add(command);
        }
        Save("user_textCommands", commands);
        return changes;
    }

    internal static string DeleteTextCommands(IEnumerable<Guid> ids)
    {
        var selected = new HashSet<Guid>(ids);
        var commands = ReadList<TextCommand>("user_textCommands");
        commands.RemoveAll(c => selected.Contains(c.Id));
        Save("user_textCommands", commands);
        return "已从本地删除。";
    }

    internal static string UpdateTextCommandGroup(UpdateTextCommandGroupVm change)
    {
        var commands = ReadList<TextCommand>("user_textCommands");
        foreach (var command in commands.Where(c => change.IdList.Contains(c.Id)))
        {
            command.Group = change.Group;
            command.LastUpdateTimeUtc = DateTime.UtcNow;
        }
        Save("user_textCommands", commands);
        return "已保存到本地。";
    }

    internal static string BatchUpdateTextCommands(BatchUpdateTextCommandsVm change)
    {
        var commands = ReadList<TextCommand>("user_textCommands");
        foreach (var command in commands.Where(c => change.IdList.Contains(c.Id)))
        {
            if (change.UpdateIgnoreCase) command.IgnoreCase = change.IgnoreCase;
            if (change.UpdateTriggerKey) command.TriggerKey = change.TriggerKey;
            command.LastUpdateTimeUtc = DateTime.UtcNow;
        }
        Save("user_textCommands", commands);
        return "已保存到本地。";
    }

    internal static string SaveImage(string name, Image image)
    {
        using var stream = new MemoryStream();
        image.Save(stream, ImageFormat.Png);
        // PNG 内容直接保存在动作和图标库中，导出动作时不用再下载图标。
        return AddIcon(name, "data:image/png;base64," + Convert.ToBase64String(stream.ToArray()));
    }

    internal static string SaveIcon(string name, Icon icon)
    {
        using var bitmap = icon.ToBitmap();
        return SaveImage(name, bitmap);
    }

    internal static string SaveSvg(string sourcePath)
    {
        var directory = Path.Combine(AppPathProvider.LocalDataRoot, "icons");
        Directory.CreateDirectory(directory);
        var destination = Path.Combine(directory, Guid.NewGuid().ToString("N") + ".svg");
        File.Copy(sourcePath, destination);
        return AddIcon(Path.GetFileName(sourcePath), destination);
    }

    private static string AddIcon(string name, string source)
    {
        var icons = ReadList<IconFileDto>("local_icons");
        if (icons.Any(icon => icon.Url == source)) return source;
        int limit = UserLimitation.Free.MaxIconCount;
        if (limit > 0 && icons.Count >= limit) throw new InvalidOperationException("已达到本地图标数量设置。");
        icons.Add(new IconFileDto(source, Path.GetFileName(name), Guid.NewGuid()));
        Save("local_icons", icons);
        return source;
    }

    internal static IList<IconFileDto> GetIcons(string keyword, int skip, int take) => ReadList<IconFileDto>("local_icons")
        .Where(i => string.IsNullOrEmpty(keyword) || (i.FileName ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
        .Skip(Math.Max(0, skip)).Take(Math.Max(0, take)).ToList();

    internal static string DeleteIcon(Guid id)
    {
        var icons = ReadList<IconFileDto>("local_icons");
        // 移除图标库条目；已被动作引用的本地资源仍保留。
        icons.RemoveAll(icon => icon.FileId == id);
        Save("local_icons", icons);
        return "已从本地图标库移除。";
    }

    internal static ExeFileVersionDto SaveExeInfo(ExeFileVersionVm source)
    {
        var items = ReadList<ExeFileVersionDto>("local_executables");
        var existing = items.FirstOrDefault(i => i.FilePath == source.FilePath && i.Sha1Hash == source.Sha1Hash);
        var item = source.FileVersionInfo == null ? new ExeFileVersionDto() : JObject.FromObject(source.FileVersionInfo).ToObject<ExeFileVersionDto>();
        item.Id = existing?.Id ?? (items.Count == 0 ? 1 : items.Max(i => i.Id) + 1);
        item.ExeFileName = source.ExeFileName;
        item.FilePath = source.FilePath;
        item.FileSize = source.FileSize;
        item.Platform = source.Platform;
        item.Sha1Hash = source.Sha1Hash;
        item.FileIconUrl = source.FileIconUrl;
        items.RemoveAll(i => i.Id == item.Id);
        items.Add(item);
        Save("local_executables", items);
        return item;
    }

    internal static IList<ExeDto> GetExeInfo(string[] names) => ReadList<ExeFileVersionDto>("local_executables")
        .Where(i => names.Contains(i.ExeFileName, StringComparer.OrdinalIgnoreCase))
        .Select(i => new ExeDto { Id = i.Id, ExeFileName = i.ExeFileName, Description = i.FileDescription, Company = i.CompanyName, Icon = i.FileIconUrl }).ToList();

    internal static string SaveBackup(BackupItemVm source)
    {
        var items = ReadList<BackupItemDetailDto>("local_backups");
        var item = JObject.FromObject(source).ToObject<BackupItemDetailDto>();
        item.Id = Math.Max(DateTime.UtcNow.Ticks, items.Count == 0 ? 1 : items.Max(i => i.Id) + 1);
        items.Add(item);
        Save("local_backups", items);
        return item.Id.ToString();
    }

    internal static IList<BackupItemListDto> GetBackups(UserObjectType type, string id, bool manual) => ReadList<BackupItemDetailDto>("local_backups")
        .Where(i => i.ObjectType == type && i.ObjectId == id && i.IsManualSave == manual)
        .OrderByDescending(i => i.CreateTimeUtc).Select(i => JObject.FromObject(i).ToObject<BackupItemListDto>()).ToList();

    internal static BackupItemDetailDto GetBackup(UserObjectType type, string id, long backupId) => ReadList<BackupItemDetailDto>("local_backups")
        .FirstOrDefault(i => i.ObjectType == type && i.ObjectId == id && i.Id == backupId) ?? throw new FileNotFoundException("本地备份不存在。");

    internal static string DeleteBackups(UserObjectType type, IList<long> ids)
    {
        var items = ReadList<BackupItemDetailDto>("local_backups");
        items.RemoveAll(i => i.ObjectType == type && ids.Contains(i.Id));
        Save("local_backups", items);
        return "已从本地备份列表删除。";
    }

    internal static string SaveNote(ActionItem action, string note)
    {
        Save("local_note:" + action.Id, new UserNoteDto { ObjectId = action.Id, ObjectType = UserObjectType.Action,
            DisplayName = action.Title, Note = note, LastEditTimeUtc = DateTime.UtcNow });
        return "已保存到本地。";
    }

    internal static UserNoteDto GetNote(string id) => Database.PP6trtaO3SY<UserNoteDto>("local_note:" + id)
        ?? new UserNoteDto { ObjectId = id, ObjectType = UserObjectType.Action, Note = "" };
}
