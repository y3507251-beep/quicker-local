using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Services;
using Quicker.Public.Actions;

namespace soLGR8XA95f82ljopSU;

// 保留旧动作接口，本地保存数据与临时文件，不上传，不产生公共网址。
internal static class oHyR5LX5l5qeapYlxI6
{
    private static readonly object Gate = new object();

    public static Task PmftHLHo6Ui(string key, string value, double timeoutSeconds, ActionExecuteContext context)
    {
        try
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("本地数据键不能为空。");
            lock (Gate)
            {
                var values = AppState.SQLDataMgr.PP6trtaO3SY<Dictionary<string, string>>("local_action_state") ?? new Dictionary<string, string>();
                if (value == "*NULL*") values.Remove(key); else values[key] = value ?? "";
                AppState.SQLDataMgr.SaveCommonDataObjectFromLocal("local_action_state", values, true);
            }
            return Task.CompletedTask;
        }
        catch (Exception error) { return Task.FromException(error); }
    }

    public static Task<(bool isSuccess, string dataOrErrMessage, string errorCode)> zustHvQuASd(string key, double timeoutSeconds)
    {
        try
        {
            lock (Gate)
            {
                var values = AppState.SQLDataMgr.PP6trtaO3SY<Dictionary<string, string>>("local_action_state");
                return Task.FromResult(values != null && values.TryGetValue(key, out var value)
                    ? (true, value, "") : (false, "本地没有该数据：" + key, "NoSuchKey"));
            }
        }
        catch (Exception error) { return Task.FromResult((false, error.Message, "LocalReadError")); }
    }

    private static string NewFile(string name)
    {
        var directory = Path.Combine(AppPathProvider.LocalDataRoot, "exports", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);
        return Path.Combine(directory, Path.GetFileName(name));
    }

    internal static Task<string> tTotHJ83KgW(string value, double timeoutSeconds)
    {
        try
        {
            var file = NewFile("text.txt");
            File.WriteAllText(file, value ?? "", System.Text.Encoding.UTF8);
            return Task.FromResult(new Uri(file).AbsoluteUri);
        }
        catch (Exception error) { return Task.FromException<string>(error); }
    }

    internal static Task<string> xHQtH0Hp41R(Image image, double timeoutSeconds)
    {
        try
        {
            if (image == null) throw new ArgumentNullException(nameof(image));
            var file = NewFile("image.png");
            image.Save(file, ImageFormat.Png);
            return Task.FromResult(new Uri(file).AbsoluteUri);
        }
        catch (Exception error) { return Task.FromException<string>(error); }
    }

    internal static Task<string> kaBtHCjYysN(string source, double timeoutSeconds, bool keepFileName)
    {
        try
        {
            if (!File.Exists(source)) throw new FileNotFoundException("需要导出的本地文件不存在。", source);
            var file = NewFile(keepFileName ? Path.GetFileName(source) : "file" + Path.GetExtension(source));
            File.Copy(source, file);
            return Task.FromResult(new Uri(file).AbsoluteUri);
        }
        catch (Exception error) { return Task.FromException<string>(error); }
    }
}
