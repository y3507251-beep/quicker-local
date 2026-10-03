using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Quicker.Modules.BrowserControl.BrowserServer.BackgroundScriptMV3;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Chrome;

namespace dBXBBy2KXw2vkJFHSpA;

internal class Mdvh4G2SO9YiK9OWrrI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec wDcv6FFNnwv;

		public static Action<string> Nbwv6Uc2jQF;

		private static _003C_003Ec UeyMQGcIZikbX6xlva0W;

		static _003C_003Ec()
		{
			wDcv6FFNnwv = new _003C_003Ec();
		}

		internal void DbAv6O6FRYr(string message)
		{
		}

		internal static bool RGvBZNcI5Z6YgrOdSI03()
		{
			return UeyMQGcIZikbX6xlva0W == null;
		}
	}

	private readonly ScriptEngineWrapper OobtyzBrvgK;

	private readonly Func<string, object, bool, int, BrowserRespMessage<JToken>> vqBt8wQTuJS;

	private readonly int mQTt8tHUWFr;

	private readonly CancellationToken? pl2t8gQXk2K;

	public static string FtFt8LisaNp;

	private static Mdvh4G2SO9YiK9OWrrI sWkHbBQ3SYtnYXE6GBgm;

	public Mdvh4G2SO9YiK9OWrrI(ScriptEngineWrapper scriptEngineWrapper_0, Func<string, object, bool, int, BrowserRespMessage<JToken>> func_1, int int_1, CancellationToken? nullable_1)
	{
		OobtyzBrvgK = scriptEngineWrapper_0 ?? throw new ArgumentNullException("scriptEngine");
		vqBt8wQTuJS = func_1;
		mQTt8tHUWFr = int_1;
		pl2t8gQXk2K = nullable_1;
		OobtyzBrvgK.InjectFunction("_nativeApiCall", new Func<string, object, bool, JToken>(EA3tyfZAhpo));
		OobtyzBrvgK.InjectObject("log", _003C_003Ec.Nbwv6Uc2jQF ?? (_003C_003Ec.Nbwv6Uc2jQF = _003C_003Ec.wDcv6FFNnwv.DbAv6O6FRYr));
		OobtyzBrvgK.Execute(FtFt8LisaNp);
	}

	private JToken rCBty3n3RAs(string string_1, object object_0, bool bool_0)
	{
		ref readonly CancellationToken? reference = ref pl2t8gQXk2K;
		if (reference.HasValue && reference.GetValueOrDefault().IsCancellationRequested)
		{
			throw new TaskCanceledException("已取消任务");
		}
		try
		{
			BrowserRespMessage<JToken> browserRespMessage = vqBt8wQTuJS(string_1, object_0, bool_0, mQTt8tHUWFr);
			if (browserRespMessage != null)
			{
				if (browserRespMessage.IsSuccess)
				{
					return browserRespMessage.Data;
				}
				return new JObject { ["error"] = browserRespMessage.Message };
			}
			return new JObject();
		}
		catch (Exception ex)
		{
			return new JObject { ["error"] = ex.Message };
		}
	}

	static Mdvh4G2SO9YiK9OWrrI()
	{
		FtFt8LisaNp = "// 创建chrome对象\r\nif (typeof chrome === 'undefined') {\r\n    chrome = {};\r\n}\r\n\r\n// API调用函数，处理回调\r\nfunction _callApi(apiName, params, callback) {\r\n    try {\r\n        // 确保参数是对象\r\n        params = params || {};\r\n        \r\n        // 调用.NET原生API\r\n        var result = _nativeApiCall(apiName, params, callback !== undefined);\r\n        \r\n        // 处理回调\r\n        if (typeof callback === 'function') {\r\n            // 直接调用回调函数\r\n            try {\r\n                callback(result);\r\n                console.log('[JS] 已执行回调');\r\n            } catch (err) {\r\n                console.log('[JS] 回调执行错误: ' + err);\r\n            }\r\n        }\r\n        \r\n        return result;\r\n    } catch (err) {\r\n        console.log('[JS] API调用错误: ' + err);\r\n        return { error: err.toString() };\r\n    }\r\n}\r\n\r\n// 定义tabs API\r\nchrome.tabs = {\r\n    // 基本方法\r\n    query: function(queryInfo, callback) { return _callApi('api_tabs_query', queryInfo || {}, callback); },\r\n    get: function(tabId, callback) { return _callApi('api_tabs_get', { tabId: tabId }, callback); },\r\n    create: function(createProperties, callback) { return _callApi('api_tabs_create', createProperties || {}, callback); },\r\n    \r\n    // 扩展方法\r\n    captureVisibleTab: function(windowId, options, callback) { return _callApi('api_tabs_captureVisibleTab', {windowId: windowId, options: options}, callback); },\r\n    detectLanguage: function(tabId, callback) { return _callApi('api_tabs_detectLanguage', {tabId: tabId}, callback); },\r\n    discard: function(tabId, callback) { return _callApi('api_tabs_discard', {tabId: tabId}, callback); },\r\n    duplicate: function(tabId, callback) { return _callApi('api_tabs_duplicate', {tabId: tabId}, callback); },\r\n    getCurrent: function(callback) { return _callApi('api_tabs_getCurrent', {}, callback); },\r\n    getZoom: function(tabId, callback) { return _callApi('api_tabs_getZoom', {tabId: tabId}, callback); },\r\n    getZoomSettings: function(tabId, callback) { return _callApi('api_tabs_getZoomSettings', {tabId: tabId}, callback); },\r\n    goBack: function(tabId, callback) { return _callApi('api_tabs_goBack', {tabId: tabId}, callback); },\r\n    goForward: function(tabId, callback) { return _callApi('api_tabs_goForward', {tabId: tabId}, callback); },\r\n    group: function(options, callback) { return _callApi('api_tabs_group', options, callback); },\r\n    highlight: function(highlightInfo, callback) { return _callApi('api_tabs_highlight', highlightInfo, callback); },\r\n    move: function(tabIds, moveProperties, callback) { return _callApi('api_tabs_move', {tabIds: tabIds, moveProperties: moveProperties}, callback); },\r\n    reload: function(tabId, reloadProperties, callback) { return _callApi('api_tabs_reload', {tabId: tabId, reloadProperties: reloadProperties}, callback); },\r\n    remove: function(tabIds, callback) { return _callApi('api_tabs_remove', {tabIds: tabIds}, callback); },\r\n    sendMessage: function(tabId, message, options, callback) { return _callApi('api_tabs_sendMessage', {tabId: tabId, message: message, options: options}, callback); },\r\n    setZoom: function(tabId, zoomFactor, callback) { return _callApi('api_tabs_setZoom', {tabId: tabId, zoomFactor: zoomFactor}, callback); },\r\n    setZoomSettings: function(tabId, zoomSettings, callback) { return _callApi('api_tabs_setZoomSettings', {tabId: tabId, zoomSettings: zoomSettings}, callback); },\r\n    toggleMuteState: function(tabId, callback) { return _callApi('api_tabs_toggleMuteState', {tabId: tabId}, callback); },\r\n    ungroup: function(tabIds, callback) { return _callApi('api_tabs_ungroup', {tabIds: tabIds}, callback); },\r\n    update: function(tabId, updateProperties, callback) { return _callApi('api_tabs_update', {tabId: tabId, updateProperties: updateProperties}, callback); }\r\n};\r\n\r\n// windows API\r\nchrome.windows = {\r\n    create: function(createData, callback) { return _callApi('api_windows_create', createData, callback); },\r\n    get: function(windowId, getInfo, callback) { return _callApi('api_windows_get', {windowId: windowId, getInfo: getInfo}, callback); },\r\n    getAll: function(getInfo, callback) { return _callApi('api_windows_getAll', getInfo, callback); },\r\n    getCurrent: function(getInfo, callback) { return _callApi('api_windows_getCurrent', getInfo, callback); },\r\n    getLastFocused: function(getInfo, callback) { return _callApi('api_windows_getLastFocused', getInfo, callback); },\r\n    remove: function(windowId, callback) { return _callApi('api_windows_remove', {windowId: windowId}, callback); },\r\n    update: function(windowId, updateInfo, callback) { return _callApi('api_windows_update', {windowId: windowId, updateInfo: updateInfo}, callback); }\r\n};\r\n\r\n// bookmarks API\r\nchrome.bookmarks = {\r\n    create: function(bookmark, callback) { return _callApi('api_bookmarks_create', bookmark, callback); },\r\n    get: function(idOrIdList, callback) { return _callApi('api_bookmarks_get', {id: idOrIdList}, callback); },\r\n    getChildren: function(id, callback) { return _callApi('api_bookmarks_getChildren', {id: id}, callback); },\r\n    getRecent: function(numberOfItems, callback) { return _callApi('api_bookmarks_getRecent', {numberOfItems: numberOfItems}, callback); },\r\n    getTree: function(callback) { return _callApi('api_bookmarks_getTree', {}, callback); },\r\n    move: function(id, destination, callback) { return _callApi('api_bookmarks_move', {id: id, destination: destination}, callback); },\r\n    remove: function(id, callback) { return _callApi('api_bookmarks_remove', {id: id}, callback); },\r\n    removeTree: function(id, callback) { return _callApi('api_bookmarks_removeTree', {id: id}, callback); },\r\n    search: function(query, callback) { return _callApi('api_bookmarks_search', query, callback); },\r\n    update: function(id, changes, callback) { return _callApi('api_bookmarks_update', {id: id, changes: changes}, callback); }\r\n};\r\n\r\n// browsingData API\r\nchrome.browsingData = {\r\n    remove: function(options, dataToRemove, callback) { return _callApi('api_browsingData_remove', {options: options, dataToRemove: dataToRemove}, callback); },\r\n    removeAppcache: function(options, callback) { return _callApi('api_browsingData_removeAppcache', options, callback); },\r\n    removeCache: function(options, callback) { return _callApi('api_browsingData_removeCache', options, callback); },\r\n    removeCookies: function(options, callback) { return _callApi('api_browsingData_removeCookies', options, callback); },\r\n    removeDownloads: function(options, callback) { return _callApi('api_browsingData_removeDownloads', options, callback); },\r\n    removeFileSystems: function(options, callback) { return _callApi('api_browsingData_removeFileSystems', options, callback); },\r\n    removeFormData: function(options, callback) { return _callApi('api_browsingData_removeFormData', options, callback); },\r\n    removeHistory: function(options, callback) { return _callApi('api_browsingData_removeHistory', options, callback); },\r\n    removeIndexedDB: function(options, callback) { return _callApi('api_browsingData_removeIndexedDB', options, callback); },\r\n    removeLocalStorage: function(options, callback) { return _callApi('api_browsingData_removeLocalStorage', options, callback); },\r\n    removePasswords: function(options, callback) { return _callApi('api_browsingData_removePasswords', options, callback); },\r\n    removePluginData: function(options, callback) { return _callApi('api_browsingData_removePluginData', options, callback); },\r\n    removeServiceWorkers: function(options, callback) { return _callApi('api_browsingData_removeServiceWorkers', options, callback); },\r\n    removeWebSQL: function(options, callback) { return _callApi('api_browsingData_removeWebSQL', options, callback); },\r\n    settings: function(callback) { return _callApi('api_browsingData_settings', {}, callback); }\r\n};\r\n\r\n// cookies API\r\nchrome.cookies = {\r\n    get: function(details, callback) { return _callApi('api_cookies_get', details, callback); },\r\n    getAll: function(details, callback) { return _callApi('api_cookies_getAll', details, callback); },\r\n    set: function(details, callback) { return _callApi('api_cookies_set', details, callback); },\r\n    remove: function(details, callback) { return _callApi('api_cookies_remove', details, callback); },\r\n    getAllCookieStores: function(callback) { return _callApi('api_cookies_getAllCookieStores', {}, callback); }\r\n};\r\n\r\n// debugger API\r\nchrome.debugger = {\r\n    attach: function(target, requiredVersion, callback) { return _callApi('api_debugger_attach', {target: target, requiredVersion: requiredVersion}, callback); },\r\n    detach: function(target, callback) { return _callApi('api_debugger_detach', {target: target}, callback); },\r\n    sendCommand: function(target, method, commandParams, callback) { return _callApi('api_debugger_sendCommand', {target: target, method: method, commandParams: commandParams}, callback); },\r\n    getTargets: function(callback) { return _callApi('api_debugger_getTargets', {}, callback); }\r\n};\r\n\r\n// downloads API\r\nchrome.downloads = {\r\n    download: function(options, callback) { return _callApi('api_downloads_download', options, callback); },\r\n    search: function(query, callback) { return _callApi('api_downloads_search', query, callback); },\r\n    pause: function(downloadId, callback) { return _callApi('api_downloads_pause', {downloadId: downloadId}, callback); },\r\n    resume: function(downloadId, callback) { return _callApi('api_downloads_resume', {downloadId: downloadId}, callback); },\r\n    cancel: function(downloadId, callback) { return _callApi('api_downloads_cancel', {downloadId: downloadId}, callback); },\r\n    erase: function(query, callback) { return _callApi('api_downloads_erase', query, callback); },\r\n    removeFile: function(downloadId, callback) { return _callApi('api_downloads_removeFile', {downloadId: downloadId}, callback); },\r\n    open: function(downloadId, callback) { return _callApi('api_downloads_open', {downloadId: downloadId}, callback); },\r\n    show: function(downloadId, callback) { return _callApi('api_downloads_show', {downloadId: downloadId}, callback); },\r\n    showDefaultFolder: function(callback) { return _callApi('api_downloads_showDefaultFolder', {}, callback); },\r\n    getFileIcon: function(downloadId, options, callback) { return _callApi('api_downloads_getFileIcon', {downloadId: downloadId, options: options}, callback); },\r\n    setShelfEnabled: function(enabled) { return _callApi('api_downloads_setShelfEnabled', {enabled: enabled}); }\r\n};\r\n\r\n// history API\r\nchrome.history = {\r\n    search: function(query, callback) { return _callApi('api_history_search', query, callback); },\r\n    getVisits: function(details, callback) { return _callApi('api_history_getVisits', details, callback); },\r\n    addUrl: function(details, callback) { return _callApi('api_history_addUrl', details, callback); },\r\n    deleteUrl: function(details, callback) { return _callApi('api_history_deleteUrl', details, callback); },\r\n    deleteRange: function(range, callback) { return _callApi('api_history_deleteRange', range, callback); },\r\n    deleteAll: function(callback) { return _callApi('api_history_deleteAll', {}, callback); }\r\n};\r\n\r\n// pageCapture API\r\nchrome.pageCapture = {\r\n    saveAsMHTML: function(details, callback) { return _callApi('api_pageCapture_saveAsMHTML', details, callback); }\r\n};\r\n\r\n// readingList API\r\nchrome.readingList = {\r\n    add: function(addOptions, callback) { return _callApi('api_readingList_add', addOptions, callback); },\r\n    getEntries: function(options, callback) { return _callApi('api_readingList_getEntries', options, callback); },\r\n    remove: function(entryId, callback) { return _callApi('api_readingList_remove', {entryId: entryId}, callback); },\r\n    update: function(entryId, updateOptions, callback) { return _callApi('api_readingList_update', {entryId: entryId, updateOptions: updateOptions}, callback); }\r\n};\r\n\r\n// tabGroups API\r\nchrome.tabGroups = {\r\n    get: function(groupId, callback) { return _callApi('api_tabGroups_get', {groupId: groupId}, callback); },\r\n    update: function(groupId, updateProperties, callback) { return _callApi('api_tabGroups_update', {groupId: groupId, updateProperties: updateProperties}, callback); },\r\n    move: function(groupId, moveProperties, callback) { return _callApi('api_tabGroups_move', {groupId: groupId, moveProperties: moveProperties}, callback); },\r\n    query: function(queryInfo, callback) { return _callApi('api_tabGroups_query', queryInfo, callback); }\r\n};\r\n\r\n// tts API\r\nchrome.tts = {\r\n    speak: function(utterance, options, callback) { return _callApi('api_tts_speak', {utterance: utterance, options: options}, callback); },\r\n    stop: function() { return _callApi('api_tts_stop', {}); },\r\n    pause: function() { return _callApi('api_tts_pause', {}); },\r\n    resume: function() { return _callApi('api_tts_resume', {}); },\r\n    isSpeaking: function(callback) { return _callApi('api_tts_isSpeaking', {}, callback); },\r\n    getVoices: function(callback) { return _callApi('api_tts_getVoices', {}, callback); }\r\n};\r\n\r\n// 日志函数\r\nif (typeof console === 'undefined') {\r\n    console = { log: function(msg) { log(msg); } };\r\n}\r\n\r\nconsole.log('[JS] Chrome API 初始化完成'); ";
	}

	[CompilerGenerated]
	private JToken EA3tyfZAhpo(string string_1, object object_0, bool bool_0)
	{
		try
		{
			return rCBty3n3RAs(string_1, object_0, bool_0);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("[ChromeBridgeMVP] API调用异常: " + ex.Message);
			return new JObject { ["error"] = ex.Message };
		}
	}

	internal static bool TK9Y7qQ3wCvGCyvyHnLZ()
	{
		return sWkHbBQ3SYtnYXE6GBgm == null;
	}
}
