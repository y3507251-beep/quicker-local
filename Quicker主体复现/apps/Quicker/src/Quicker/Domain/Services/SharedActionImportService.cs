using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Utilities;
using yyXIB9Yxgd6ACb7T4ig;

namespace Quicker.Domain.Services;

// 只由用户主动导入调用。启动、查看详情和运行已有动作不得调用此下载入口。
internal static class SharedActionImportService
{
    private const string ApiRoot = "https://api.getquicker.net/api";
    private static readonly Regex SharedReference = new Regex(
        @"^@@(?<id>[0-9a-fA-F-]{36})@(?<revision>\d+)@", RegexOptions.CultureInvariant);
    private static readonly Regex EmbeddedIcon = new Regex(
        @"https?://(?:files\.getquicker\.net|deskpad\.oss-cn-shanghai\.aliyuncs\.com)/_icons/[^\s\]\[\""'<>|\\]+",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

    internal static async Task<ApiResult<SharedActionDto>> ImportAsync(string source, bool subProgram = false)
    {
        try
        {
            source = (source ?? "").Trim();
            bool isUrl = Uri.TryCreate(source, UriKind.Absolute, out var uri) && !uri.IsFile;
            if (isUrl && ((uri.Scheme != Uri.UriSchemeHttps && uri.Scheme != Uri.UriSchemeHttp)
                || (!uri.Host.Equals("getquicker.net", StringComparison.OrdinalIgnoreCase)
                    && !uri.Host.Equals("www.getquicker.net", StringComparison.OrdinalIgnoreCase))))
                throw new InvalidDataException("请选择 Quicker 网站的动作分享链接，或本地动作 JSON 文件。");

            using var client = CreateDownloadClient();
            SharedActionDto action;
            if (!isUrl)
                action = LocalDataStore.ReadSharedActionFile(source);
            else if (subProgram)
            {
                var query = HttpUtility.ParseQueryString(uri.Query);
                if (!uri.AbsolutePath.TrimEnd('/').Equals("/subprogram", StringComparison.OrdinalIgnoreCase)
                    || !Guid.TryParse(query["id"], out var id))
                    throw new InvalidDataException("不是有效的子程序分享链接。");
                int? revision = null;
                string version = query["version"] ?? query["revision"];
                if (!string.IsNullOrEmpty(version))
                {
                    if (!int.TryParse(version, out int parsed) || parsed < 0)
                        throw new InvalidDataException("子程序版本号无效。");
                    revision = parsed;
                }
                action = await DownloadActionAsync(client, id, revision).ConfigureAwait(false);
            }
            else
                action = await ReadApiAsync(client, ApiRoot + "/profiles/GetSharedActionByLink?tick="
                    + DateTime.UtcNow.Ticks + "&url=" + Uri.EscapeDataString(source)
                    + "&softVersion=" + Uri.EscapeDataString(AppHelper.GetSoftVersion())).ConfigureAwait(false);

            var queue = new Queue<SharedActionDto>();
            var bodies = new Dictionary<string, SharedActionDto>(StringComparer.OrdinalIgnoreCase);
            var icons = new HashSet<string>(StringComparer.Ordinal);
            action = AddBody(action, queue, bodies);
            while (queue.Count > 0)
            {
                var body = queue.Dequeue();
                var references = new Dictionary<Guid, HashSet<int>>();
                FindResources(JObject.FromObject(body), references, icons);
                foreach (var dependency in references)
                foreach (int revision in dependency.Value)
                {
                    if (bodies.ContainsKey(Key(dependency.Key, revision))) continue;
                    var local = AppState.SQLDataMgr.p02trGElaNv(dependency.Key.ToString(), revision);
                    if (local == null && !isUrl)
                        throw new FileNotFoundException($"本地文件依赖的共享子程序或动作尚未导入：{dependency.Key}，版本 {revision}。请先导入该依赖，或主动使用网站分享链接下载。");
                    AddBody(local ?? await DownloadActionAsync(client, dependency.Key, revision).ConfigureAwait(false), queue, bodies);
                }
            }

            // 只新增动作正文缓存；不拉取账号、动作页或设置，也不覆盖已有同版本正文。
            foreach (var body in bodies.Values)
                AppState.SQLDataMgr.SaveSharedAction(body, overwrite: false);

            int missingIcons = 0;
            foreach (string icon in icons)
            {
                string path = j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(icon);
                if (File.Exists(path)) continue;
                if (!isUrl) { missingIcons++; continue; }
                try
                {
                    byte[] bytes = await client.GetByteArrayAsync(icon).ConfigureAwait(false);
                    if (bytes.Length == 0) throw new InvalidDataException("图标内容为空。");
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                    // 完整下载后才写入缓存；重复导入保留已有图标。
                    if (!File.Exists(path)) File.WriteAllBytes(path, bytes);
                }
                catch (Exception error) when (error is HttpRequestException || error is TaskCanceledException
                    || error is IOException || error is UnauthorizedAccessException)
                {
                    missingIcons++;
                }
            }
            return new ApiResult<SharedActionDto>
            {
                IsSuccess = true,
                Data = action,
                Message = missingIcons == 0 ? "" : $"动作正文及共享依赖已保存在本地；{missingIcons} 个图标未取得，可能显示为空白。可稍后重新导入补齐；启动和运行时不会自动下载。"
            };
        }
        catch (Exception error)
        {
            return ApiResult<SharedActionDto>.Error("导入失败：" + error.Message);
        }
    }

    private static HttpClient CreateDownloadClient()
    {
        var handler = new HttpClientHandler
        {
            SslProtocols = SslProtocols.Tls12,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            UseCookies = false,
            AllowAutoRedirect = false
        };
        AppHelper.ApplyProxy(handler);
        // 默认匿名。凭据仅在用户主动下载且官方 API 返回 401 时，附在单个官方请求上。
        return new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(30) };
    }

    private static async Task<SharedActionDto> ReadApiAsync(HttpClient client, string url)
    {
        var response = await client.GetAsync(url).ConfigureAwait(false);
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            // 使用用户此前正常登录保留的凭据，不登录、不刷新令牌、不恢复后台同步。
            // 只允许固定官方 HTTPS API；客户端禁止重定向，图片请求永远不带此头。
            var user = AppState.SQLDataMgr.PP6trtaO3SY<UserInfo>("user_info");
            if (!string.IsNullOrEmpty(user?.Token) && new Uri(url).GetLeftPart(UriPartial.Authority) == "https://api.getquicker.net")
            {
                response.Dispose();
                using var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
                response = await client.SendAsync(request).ConfigureAwait(false);
            }
        }
        using (response)
        {
        if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden)
            throw new InvalidOperationException("网站要求该内容的访问权限，匿名或已有网站凭据无法下载。请从网站取得有权限的完整动作文件后本地导入；软件不会因此恢复账号登录或云同步。");
        response.EnsureSuccessStatusCode();
        var result = JsonConvert.DeserializeObject<ApiResult<SharedActionDto>>(
            await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        if (result == null || !result.IsSuccess || result.Data == null)
            throw new InvalidDataException(result?.Message ?? "网站没有返回完整动作内容。");
        return result.Data;
        }
    }

    private static async Task<SharedActionDto> DownloadActionAsync(HttpClient client, Guid id, int? revision)
    {
        var action = await ReadApiAsync(client, ApiRoot + "/SharedAction/Download?id=" + id
            + "&revision=" + revision?.ToString(CultureInfo.InvariantCulture)
            + "&softVersion=" + Uri.EscapeDataString(AppHelper.GetSoftVersion())
            + "&forPreview=false").ConfigureAwait(false);
        if (action.Id != id || (revision.HasValue && action.Revision != revision.Value))
            throw new InvalidDataException($"网站返回的动作编号或版本不匹配：{id}，请求版本 {revision}。");
        return action;
    }

    private static string Key(Guid id, int revision) => id + "@" + revision;

    private static SharedActionDto AddBody(SharedActionDto body, Queue<SharedActionDto> queue,
        IDictionary<string, SharedActionDto> bodies)
    {
        if (body == null || body.Id == Guid.Empty || body.Revision < 0)
            throw new InvalidDataException("动作缺少有效的编号或版本。");
        string key = Key(body.Id, body.Revision);
        if (bodies.TryGetValue(key, out var existing)) return existing;
        body = AppState.SQLDataMgr.p02trGElaNv(body.Id.ToString(), body.Revision) ?? body;
        bodies.Add(key, body);
        queue.Enqueue(body);
        return body;
    }

    private static void AddReference(IDictionary<Guid, HashSet<int>> references, string id, int revision)
    {
        if (!Guid.TryParse(id, out var parsed) || revision < 0) return;
        if (!references.TryGetValue(parsed, out var revisions)) references[parsed] = revisions = new HashSet<int>();
        revisions.Add(revision);
    }

    private static void FindResources(JToken token, IDictionary<Guid, HashSet<int>> references,
        ISet<string> icons, string property = "", int embeddedDepth = 0)
    {
        if (token is JObject obj)
        {
            if (obj.GetValue("Disabled", StringComparison.OrdinalIgnoreCase)?.Value<bool>() == true) return;
            if (obj.GetValue("UseTemplate", StringComparison.OrdinalIgnoreCase)?.Value<bool>() == true)
                AddReference(references, (string)obj.GetValue("TemplateId", StringComparison.OrdinalIgnoreCase),
                    (int?)obj.GetValue("TemplateRevision", StringComparison.OrdinalIgnoreCase) ?? 0);
            foreach (var item in obj.Properties())
                FindResources(item.Value, references, icons, item.Name, embeddedDepth);
        }
        else if (token is JArray array)
        {
            foreach (var item in array) FindResources(item, references, icons, property, embeddedDepth);
        }
        else if (token.Type == JTokenType.String)
        {
            string value = token.Value<string>() ?? "";
            var match = SharedReference.Match(value);
            if (match.Success && int.TryParse(match.Groups["revision"].Value, out int revision))
                AddReference(references, match.Groups["id"].Value, revision);
            if (property.IndexOf("icon", StringComparison.OrdinalIgnoreCase) >= 0
                && Uri.TryCreate(value, UriKind.Absolute, out var uri)
                && (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp))
                icons.Add(value);
            foreach (Match icon in EmbeddedIcon.Matches(value)) icons.Add(icon.Value);
            string json = value.TrimStart();
            if (embeddedDepth < 8 && (json.StartsWith("{") || json.StartsWith("[")))
            {
                JToken nested;
                try { nested = JToken.Parse(json); }
                catch (JsonReaderException) { return; }
                FindResources(nested, references, icons, property, embeddedDepth + 1);
            }
        }
    }
}
