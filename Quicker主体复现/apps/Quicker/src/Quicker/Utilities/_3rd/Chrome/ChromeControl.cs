using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using dBXBBy2KXw2vkJFHSpA;
using log4net;
using NamedPipeWrapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Annotations;
using Quicker.Domain;
using Quicker.Modules.BrowserControl.BrowserServer.BackgroundScriptMV3;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities._3rd.Chrome;

public static class ChromeControl
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public string browser;

		public int rRH2JEevbPG;

		public CancellationToken? zHc2JyR1eNP;

		public bool pFy2J8o4kYG;

		public string GSY2JaaX6FD;

		public object D422J7Z8Kxq;

		public ManualResetEvent CBS2JRtwdA6;

		internal static _003C_003Ec__DisplayClass10_0 eH9t1Kyv9uFoHLCTgZgL;

		internal BrowserRespMessage<JToken> DTk2JCGTSED(string commandName, object commandParam, bool waitResp, int timeoutMs)
		{
			return RunBackgroundCommand(browser, commandName, commandParam, waitResp, timeoutMs, rRH2JEevbPG, null, zHc2JyR1eNP);
		}

		internal void dKn2JPWqVVZ(bool success, string message, object data, int msgSerial)
		{
			pFy2J8o4kYG = success;
			GSY2JaaX6FD = message;
			D422J7Z8Kxq = data;
			if (CBS2JRtwdA6 != null)
			{
				CBS2JRtwdA6.Set();
			}
		}

		internal static bool uouEUuyvLP8v6pFc45v0()
		{
			return eH9t1Kyv9uFoHLCTgZgL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public ConcurrentBag<BrowserTabInfo> HmN2Jc3PMO8;

		internal static _003C_003Ec__DisplayClass18_0 pkWOwvyvoPbam9HR0pHI;

		internal void dxN2JqxY6Dw(string browser)
		{
			string[] array = browser.SplitToList('-');
			string text = array[0];
			int num = array[1].TryConvertToInt();
			string script = "\r\nchrome.tabs.query({}, function(tabs) {\r\n    var rtn = [];\r\n    for (var i = 0; i < tabs.length; i++) {\r\n        var tab = tabs[i];\r\n        rtn.push({\r\n            'tabId': tab.id,\r\n            'url': tab.url,\r\n            'title': tab.title,\r\n            'favIconUrl': tab.favIconUrl,\r\n            'status': tab.status,\r\n            'incognito': tab.incognito,\r\n            'index': tab.index,\r\n            'windowId': tab.windowId\r\n        });\r\n    }\r\n    sendReplyToQuicker(true, 'ok', rtn, qk_msg_serial);\r\n});";
			string command = "qk_get_tabs";
			_003C_003Ef__AnonymousType22 commandParams = new _003C_003Ef__AnonymousType22();
			if (pkWOwvyvoPbam9HR0pHI == null)
			{
				switch (0)
				{
				}
			}
			BrowserRespMessage<JToken> browserRespMessage = RunBackgroundScriptOrCommand(text, script, command, commandParams, true, 500, num);
			if (!browserRespMessage.IsSuccess)
			{
				return;
			}
			IList<BrowserTabInfo> list = browserRespMessage.Data.ToObject<IList<BrowserTabInfo>>();
			if (list == null)
			{
				return;
			}
			foreach (BrowserTabInfo item in list)
			{
				item.BrowserProcName = text;
				item.BrowserProcId = num;
				HmN2Jc3PMO8.Add(item);
			}
		}

		internal static bool v7Z0S9yvfjZkCYj29ERU()
		{
			return pkWOwvyvoPbam9HR0pHI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public IList<string> RPu2J9ZZ9ik;

		public string GRL2JhFy5xn;

		public string GbU2JetrejT;

		public _003C_003Ef__AnonymousType22 WDQ2JYK1yDe;

		public IDictionary<string, IList<BookmarkInfo>> NyE2JItoslV;

		internal static _003C_003Ec__DisplayClass21_0 oMO3DyyvlY6mMegKA3Af;

		internal bool zh82JVUpiSS(string x)
		{
			_003C_003Ec__DisplayClass21_1 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_1
			{
				x = x
			};
			return RPu2J9ZZ9ik.Any(_003C_003Ec__DisplayClass21_.bZS2JWv3O8q);
		}

		internal void B6k2JZbbqOv(string browser)
		{
			string[] array = browser.SplitToList('-');
			string text = array[0];
			int num = array[1].TryConvertToInt();
			try
			{
				BrowserRespMessage<JToken> browserRespMessage = RunBackgroundScriptOrCommand(text, GRL2JhFy5xn, GbU2JetrejT, WDQ2JYK1yDe, true, 1000, num);
				if (browserRespMessage.IsSuccess)
				{
					IList<BookmarkInfo> list = browserRespMessage.Data.ToObject<IList<BookmarkInfo>>();
					if (list == null)
					{
						return;
					}
					IEnumerator<BookmarkInfo> enumerator = list.GetEnumerator();
					int num2 = 0;
					if (oMO3DyyvlY6mMegKA3Af != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					try
					{
						while (enumerator.MoveNext())
						{
							BookmarkInfo current = enumerator.Current;
							current.BrowserProcName = text;
							current.BrowserProcId = num;
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					NyE2JItoslV[browser] = list;
				}
				else
				{
					gZDvwLtmOtY.Warn("获取浏览器" + browser + "书签失败：" + browserRespMessage.Message);
				}
			}
			catch (Exception ex)
			{
				gZDvwLtmOtY.Warn("获取浏览器" + browser + "书签失败：" + ex.Message, ex);
			}
		}

		internal static bool nvLQXxyvZeaKSEZ9lwaP()
		{
			return oMO3DyyvlY6mMegKA3Af == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_1
	{
		public string x;

		private static _003C_003Ec__DisplayClass21_1 YQXgf7yv8y2x3Xl6Eceb;

		internal bool bZS2JWv3O8q(string allowed)
		{
			return x.StartsWith(allowed + "-", StringComparison.OrdinalIgnoreCase);
		}

		static _003C_003Ec__DisplayClass21_1()
		{
		}

		internal static bool jAn4SjyvRmf76xPuCmHw()
		{
			return YQXgf7yv8y2x3Xl6Eceb == null;
		}

		internal static void jUOfUJyvP5JYYuY0i7ya()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		public string BeS2JGaGluR;

		public string hOA2JsMiGlo;

		public object cQA2JHwUXTy;

		public ConcurrentBag<BrowserHistoryItem> RYm2J1dOxkF;

		internal static _003C_003Ec__DisplayClass22_0 jLS8R4yvM9kETGX5yA4d;

		internal void KBb2JkSEB9O(string browser)
		{
			string[] array = browser.SplitToList('-');
			string text = array[0];
			int num = array[1].TryConvertToInt();
			try
			{
				BrowserRespMessage<JToken> browserRespMessage = RunBackgroundScriptOrCommand(text, BeS2JGaGluR, hOA2JsMiGlo, cQA2JHwUXTy, true, 500, num);
				if (!browserRespMessage.IsSuccess)
				{
					return;
				}
				IList<BrowserHistoryItem> list = browserRespMessage.Data.ToObject<IList<BrowserHistoryItem>>();
				if (list == null)
				{
					return;
				}
				foreach (BrowserHistoryItem item in list)
				{
					item.BrowserProcName = text;
					item.BrowserProcId = num;
					RYm2J1dOxkF.Add(item);
				}
			}
			catch (Exception ex)
			{
				gZDvwLtmOtY.Warn("获取浏览器" + browser + "历史记录出错：" + ex.Message);
			}
		}

		internal static void ipHMwWyvIgeNJRKd6ajp()
		{
		}

		internal static bool Scn4NFyvU00KM1Ftmn6r()
		{
			return jLS8R4yvM9kETGX5yA4d == null;
		}
	}

	public const string CMD_BackgroundScript = "BackgroundScript";

	public const string CMD_BackgroundCommand = "BackgroundCommand";

	public const string Cmd_RunTabScript = "RunScript";

	public const string Cmd_TabCommand = "TabCommand";

	private static readonly ILog gZDvwLtmOtY;

	internal static object WhewmsFmgeaSfeBEoxVd;

	private static int qYTvww4bq13(string string_0)
	{
		if (string.Equals(string_0, AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase))
		{
			return ProcessHelper.GetBrowserMainProcess(AppState.CurrentProcessId, AppState.CurrentProcessName);
		}
		return 0;
	}

	public static bool IsBrowserConnected(string browser, int pid)
	{
		if (AppState.vjAt7Seco0Y() != null)
		{
			return AppState.vjAt7Seco0Y().xSstGKB1AqB(browser, pid);
		}
		return false;
	}

	public static BrowserRespMessage<JToken> SendMessageToBrowser<T>(ChromeCommandMessage<T> msg, string browser, bool waitResponse = true, int timeoutMs = 3000, int procId = 0, CancellationToken? cancellationToken = null)
	{
		if (AppState.vjAt7Seco0Y() == null)
		{
			throw new InvalidOperationException("浏览器服务尚未初始化.");
		}
		return AppState.vjAt7Seco0Y().lhttGp86IDv(msg, browser, waitResponse, timeoutMs, (procId == 0) ? qYTvww4bq13(browser) : procId, cancellationToken);
	}

	public static BrowserConnectionInfo GetConnectionInfo(string browser, int procId)
	{
		if (procId == 0)
		{
			procId = qYTvww4bq13(browser);
		}
		NamedPipeConnection<string, string> namedPipeConnection = AppState.vjAt7Seco0Y().fFCtGxElp5Z(browser, procId);
		if (namedPipeConnection == null)
		{
			return null;
		}
		return namedPipeConnection.Tag as BrowserConnectionInfo;
	}

	public static BrowserRespMessage<JToken> RunBackgroundScript(string browser, string script, bool waitResponse, int timeoutMs, int mainProcId = 0, CancellationToken? cancellationToken = null)
	{
		return SendMessageToBrowser(new ChromeCommandMessage<object>
		{
			Cmd = "BackgroundScript",
			Data = new _003C_003Ef__AnonymousType17<string>(script)
		}, browser, waitResponse, timeoutMs, mainProcId, cancellationToken);
	}

	public static BrowserRespMessage<JToken> RunBackgroundCommand(string browser, string backgroundCommand, object commandParams, bool waitResponse, int timeoutMs, int mainProcId = 0, string valueFilter = null, CancellationToken? cancellationToken = null)
	{
		return SendMessageToBrowser(new ChromeCommandMessage<object>
		{
			Cmd = "BackgroundCommand",
			Data = new _003C_003Ef__AnonymousType18<string, object, string>(backgroundCommand, commandParams, valueFilter)
		}, browser, waitResponse, timeoutMs, mainProcId, cancellationToken);
	}

	public static BrowserRespMessage<JToken> RunBackgroundScriptForMV3(string browser, string script, bool waitResponse, int timeoutMs, int mainProcId = 0, CancellationToken? cancellationToken = null)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.browser = browser;
		_003C_003Ec__DisplayClass10_.rRH2JEevbPG = mainProcId;
		_003C_003Ec__DisplayClass10_.zHc2JyR1eNP = cancellationToken;
		Func<string, object, bool, int, BrowserRespMessage<JToken>> func_ = _003C_003Ec__DisplayClass10_.DTk2JCGTSED;
		ScriptEngineWrapper scriptEngineWrapper = new ScriptEngineWrapper();
		new Mdvh4G2SO9YiK9OWrrI(scriptEngineWrapper, func_, timeoutMs, _003C_003Ec__DisplayClass10_.zHc2JyR1eNP);
		_003C_003Ec__DisplayClass10_.CBS2JRtwdA6 = null;
		_003C_003Ec__DisplayClass10_.pFy2J8o4kYG = false;
		_003C_003Ec__DisplayClass10_.GSY2JaaX6FD = "";
		_003C_003Ec__DisplayClass10_.D422J7Z8Kxq = null;
		if (waitResponse)
		{
			_003C_003Ec__DisplayClass10_.CBS2JRtwdA6 = new ManualResetEvent(false);
			if (!script.Contains("sendReplyToQuicker"))
			{
				throw new Exception("代码中缺少sendReplyToQuicker调用");
			}
		}
		scriptEngineWrapper.InjectFunction("sendReplyToQuicker", new Action<bool, string, object, int>(_003C_003Ec__DisplayClass10_.dKn2JPWqVVZ));
		scriptEngineWrapper.Execute(script.Replace("qk_msg_serial", "0"));
		if (waitResponse)
		{
			try
			{
				bool flag = false;
				WaitHandle[] obj;
				object obj2;
				if (_003C_003Ec__DisplayClass10_.zHc2JyR1eNP.HasValue)
				{
					obj = new WaitHandle[2] { _003C_003Ec__DisplayClass10_.CBS2JRtwdA6, null };
					ref CancellationToken? reference = ref _003C_003Ec__DisplayClass10_.zHc2JyR1eNP;
					if (!reference.HasValue)
					{
						obj2 = null;
					}
					else
					{
						obj2 = reference.GetValueOrDefault().WaitHandle;
						if (obj2 != null)
						{
							goto IL_010a;
						}
					}
					obj2 = CancellationToken.None.WaitHandle;
					goto IL_010a;
				}
				flag = _003C_003Ec__DisplayClass10_.CBS2JRtwdA6.WaitOne(timeoutMs + 1);
				goto IL_014f;
				IL_010a:
				obj[1] = (WaitHandle)obj2;
				int num = WaitHandle.WaitAny(obj, TimeSpan.FromMilliseconds(timeoutMs + 1));
				if (!(flag = num == 0))
				{
					if (num == 258)
					{
						throw new Exception("操作超时未响应。");
					}
					throw new Exception("用户取消。");
				}
				goto IL_014f;
				IL_014f:
				if (!flag)
				{
					throw new Exception("操作超时未响应。");
				}
				return new BrowserRespMessage<JToken>
				{
					IsSuccess = _003C_003Ec__DisplayClass10_.pFy2J8o4kYG,
					Message = _003C_003Ec__DisplayClass10_.GSY2JaaX6FD,
					Data = JToken.FromObject(_003C_003Ec__DisplayClass10_.D422J7Z8Kxq)
				};
			}
			catch (OperationCanceledException)
			{
				throw new TimeoutException("用户取消。");
			}
		}
		return null;
	}

	public static BrowserRespMessage<JToken> RunBackgroundScriptOrCommand(string browser, string script, string command, object commandParams, bool waitResponse, int timeoutMs, int mainProcId = 0, CancellationToken? cancellationToken = null)
	{
		if (AppState.vjAt7Seco0Y().cAftGrwyGHF(browser, mainProcId))
		{
			return RunBackgroundCommand(browser, command, commandParams, waitResponse, timeoutMs, mainProcId, null, cancellationToken);
		}
		return RunBackgroundScript(browser, script, waitResponse, timeoutMs, mainProcId, cancellationToken);
	}

	public static BrowserRespMessage<JToken> OpenUrl(string browser, string url, bool waitResponse, int timeoutMs, int mainProcId = 0)
	{
		string script = "chrome.tabs.create({\r\n                url: '@url',\r\n                active: true\r\n            }, function(tab){\r\n                if(!tab) {\r\n                    // Probably, there was no active window\r\n                    chrome.windows.create({url: '@url', focused:true});\r\n                  } else {\r\n                    chrome.windows.update(tab.windowId, {focused: true});\r\n                  }\r\n                \r\n            });".Replace("@url", url);
		string command = "qk_open_url";
		_003C_003Ef__AnonymousType19<string> commandParams = new _003C_003Ef__AnonymousType19<string>(url);
		return RunBackgroundScriptOrCommand(browser, script, command, commandParams, waitResponse, timeoutMs, mainProcId);
	}

	internal static void R83vwtdpW8O(string string_0, string string_1, int int_0 = 0, int int_1 = 3000)
	{
		try
		{
			if (AppState.vjAt7Seco0Y().xSstGKB1AqB(string_0, int_0))
			{
				OpenUrl(string_0, string_1, false, int_1, int_0);
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			Process.Start(string_0, string_1);
		}
		catch (Exception ex2)
		{
			AppHelper.ShowWarning("无法使用" + string_0 + "打开网址" + string_1 + "。" + ex2.Message);
			Process.Start(string_1);
		}
	}

	public static BrowserRespMessage<JToken> ExecuteTabScript(string browser, int? tabId, string script, bool waitResponse, int timeoutMs, bool allFrames, int frameId, bool waitManualReturn, CancellationToken? cancellationToken, [CanBeNull] string executionWorld = null)
	{
		return SendMessageToBrowser(new ChromeCommandMessage<object>
		{
			Cmd = "RunScript",
			TabId = tabId,
			Data = new _003C_003Ef__AnonymousType20<string, bool, int?, bool, string>(script, allFrames, allFrames ? ((int?)null) : new int?(frameId), waitManualReturn, executionWorld)
		}, browser, waitResponse, timeoutMs, 0, cancellationToken);
	}

	public static BrowserRespMessage<JToken> ExecuteTabScriptOrCommand(string browser, int? tabId, string script, string command, object commandArgs, bool waitResponse, int timeoutMs, bool allFrames, int frameId, bool waitManualReturn, CancellationToken? cancellationToken, [CanBeNull] string executionWorld = null)
	{
		BrowserConnectionInfo connectionInfo = GetConnectionInfo(browser, 0);
		if (connectionInfo == null)
		{
			throw new Exception("未找到浏览器扩展连接：" + browser);
		}
		if (connectionInfo.ManifestVersion == 2)
		{
			return SendMessageToBrowser(new ChromeCommandMessage<object>
			{
				Cmd = "RunScript",
				TabId = tabId,
				Data = new _003C_003Ef__AnonymousType20<string, bool, int?, bool, string>(script, allFrames, allFrames ? ((int?)null) : new int?(frameId), waitManualReturn, executionWorld)
			}, browser, waitResponse, timeoutMs, 0, cancellationToken);
		}
		if (connectionInfo.ManifestVersion != 3)
		{
			throw new Exception($"浏览器 {browser} 的ManifestVersion不正确：{connectionInfo.ManifestVersion}");
		}
		return ExecuteTabCommand(browser, tabId, command, commandArgs, waitResponse, timeoutMs, allFrames, frameId, waitManualReturn, cancellationToken, executionWorld);
	}

	public static BrowserRespMessage<JToken> ExecuteTabCommand(string browser, int? tabId, string command, object commandArgs, bool waitResponse, int timeoutMs, bool allFrames, int frameId, bool waitManualReturn, CancellationToken? cancellationToken, string executionWorld)
	{
		return SendMessageToBrowser(new ChromeCommandMessage<object>
		{
			Cmd = "TabCommand",
			TabId = tabId,
			Data = new _003C_003Ef__AnonymousType21<string, object, bool, int?, bool, string, int>(command, commandArgs, allFrames, allFrames ? ((int?)null) : new int?(frameId), waitManualReturn, executionWorld, Math.Max(timeoutMs - 50, 1))
		}, browser, waitResponse, timeoutMs, 0, cancellationToken);
	}

	internal static string uktvwgsaRp5(string string_0, int? nullable_0, CancellationToken? nullable_1)
	{
		string text = AppHelper.ReadResourceText("pick.js");
		string text2 = "// 开始选择元素\r\n//\r\nif (typeof _qk_picker !== 'undefined'){\r\n    try{\r\n        _qk_picker.close();\r\n        delete _qk_picker;\r\n    }catch(e){}\r\n}\r\n\r\nvar _qk_picker = new ElementPicker({\r\n    container: document.body,\r\n    selectors: \"*\",\r\n    background: \"rgba(153, 235, 255, 0.5)\",\r\n    borderWidth: 5,\r\n    transition: \"all 150ms ease\",\r\n    ignoreElements: [document.body],\r\n    action: {\r\n        trigger: 'click',\r\n        callback: (function (target) {\r\n            console.log('element selected:', target);\r\n            const selector = finder(target);\r\n            console.log('get selector:',selector);\r\n\r\n\r\n            _qk_picker.close();\r\n            delete _qk_picker;\r\n\r\n            // send to quicker\r\n            //sendToQuicker({messageType:9, data:{data:selector}});\r\n            sendReplyToQuicker(true, '', {'selector':selector}, qk_msg_serial) \r\n        })\r\n    }\r\n});";
		string script = text + text2;
		BrowserRespMessage<JToken> browserRespMessage = ExecuteTabScript(string_0, nullable_0, script, true, 30000, true, 0, true, nullable_1);
		if (!browserRespMessage.IsSuccess)
		{
			AppHelper.ShowWarning("未能成功获取选择器。" + browserRespMessage.Message);
			return "";
		}
		return browserRespMessage.Data["selector"]?.ToObject<string>();
	}

	public static IList<BrowserTabInfo> GetCurrentTabs()
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		IList<string> source = AppState.vjAt7Seco0Y().k3itG4fRlwV();
		_003C_003Ec__DisplayClass18_.HmN2Jc3PMO8 = new ConcurrentBag<BrowserTabInfo>();
		Parallel.ForEach(source, _003C_003Ec__DisplayClass18_.dxN2JqxY6Dw);
		return _003C_003Ec__DisplayClass18_.HmN2Jc3PMO8.ToList();
	}

	public static void ShowTab(BrowserTabInfo tabInfo)
	{
		string script = "chrome.windows.update(@windowId, {focused: true}, (window) => {\r\n                chrome.tabs.update(@tabId, {active: true})\r\n            })".Replace("@windowId", tabInfo.WindowId.ToString()).Replace("@tabId", tabInfo.TabId.ToString());
		string command = "qk_show_tab";
		_003C_003Ef__AnonymousType23<int, int> commandParams = new _003C_003Ef__AnonymousType23<int, int>(tabInfo.WindowId, tabInfo.TabId);
		RunBackgroundScriptOrCommand(tabInfo.BrowserProcName, script, command, commandParams, false, 3000, tabInfo.BrowserProcId);
	}

	public static IDictionary<string, IList<BookmarkInfo>> GetBookmarks(IList<string> allowedBrowsers)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.RPu2J9ZZ9ik = allowedBrowsers;
		IList<string> source = AppState.vjAt7Seco0Y().k3itG4fRlwV();
		if (_003C_003Ec__DisplayClass21_.RPu2J9ZZ9ik.HasData())
		{
			source = source.Where(_003C_003Ec__DisplayClass21_.zh82JVUpiSS).ToList();
		}
		_003C_003Ec__DisplayClass21_.NyE2JItoslV = new ConcurrentDictionary<string, IList<BookmarkInfo>>();
		_003C_003Ec__DisplayClass21_.GRL2JhFy5xn = "function processNode(node, bag) {\r\n    // recursively process child nodes\r\n    if(node.children) {\r\n        node.children.forEach(function(child) { processNode(child, bag); });\r\n    }\r\n\r\n    // print leaf nodes URLs to console\r\n    if(node.url) { bag.push(node); }\r\n}\r\nvar bag = [];\r\ntry{\r\n    chrome.bookmarks.getTree(function(nodes){\r\n        nodes.forEach(function(item){\r\n            processNode(item, bag);\r\n        });\r\n        sendReplyToQuicker(true, 'ok', bag, qk_msg_serial);\r\n    });\r\n    \r\n}catch(e){\r\n    console.error('Failed to get bookmarks', e);\r\n    sendReplyToQuicker(false, e.message, bag, qk_msg_serial);\r\n}\r\n";
		_003C_003Ec__DisplayClass21_.GbU2JetrejT = "qk_get_bookmarks";
		_003C_003Ec__DisplayClass21_.WDQ2JYK1yDe = new _003C_003Ef__AnonymousType22();
		Parallel.ForEach(source, _003C_003Ec__DisplayClass21_.B6k2JZbbqOv);
		return _003C_003Ec__DisplayClass21_.NyE2JItoslV;
	}

	public static IList<BrowserHistoryItem> GetHistory(string text, int maxResults = 30, double? maxDays = 4.0)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		IList<string> source = AppState.vjAt7Seco0Y().k3itG4fRlwV();
		_003C_003Ec__DisplayClass22_.RYm2J1dOxkF = new ConcurrentBag<BrowserHistoryItem>();
		string arg = "";
		if (maxDays.HasValue)
		{
			arg = $", startTime:{DateTime.UtcNow.AddDays(maxDays.Value * -1.0).ToUnixTimeMilliseconds()}";
		}
		_003C_003Ec__DisplayClass22_.BeS2JGaGluR = string.Format("\r\n            try {{\r\n                chrome.history.search({{text: `{0}`, maxResults: {1}{2}}}, function(items) {{        \r\n                    sendReplyToQuicker(true, 'ok', items, qk_msg_serial);\r\n                }});\r\n            }} catch (e) {{\r\n                console.error('Failed to get history', e);\r\n                sendReplyToQuicker(false, e.message, null, qk_msg_serial);\r\n            }}\r\n            ", text.Or(""), maxResults, arg);
		_003C_003Ec__DisplayClass22_.hOA2JsMiGlo = "qk_query_history";
		_003C_003Ec__DisplayClass22_.cQA2JHwUXTy = new _003C_003Ef__AnonymousType24<string, int, long?>(text ?? "", maxResults, maxDays.HasValue ? new long?(DateTime.UtcNow.AddDays(maxDays.Value * -1.0).ToUnixTimeMilliseconds()) : ((long?)null));
		Parallel.ForEach(source, _003C_003Ec__DisplayClass22_.KBb2JkSEB9O);
		return _003C_003Ec__DisplayClass22_.RYm2J1dOxkF.ToList();
	}

	public static bool TryDeleteBookmark(BookmarkInfo bookmark)
	{
		try
		{
			if (AppState.vjAt7Seco0Y().fFCtGxElp5Z(bookmark.BrowserProcName, bookmark.BrowserProcId) == null)
			{
				AppHelper.ShowWarning("浏览器 " + bookmark.BrowserProcName + " 未连接。");
			}
			string script = "\r\nchrome.bookmarks.get('@id', function(nodes){{\r\n    if (nodes.length == 1){\r\n        if (nodes[0].url === '@url'){\r\n            chrome.bookmarks.remove('@id', function(){\r\n                sendReplyToQuicker(true, 'ok', '', qk_msg_serial);\r\n            });\r\n        }else{\r\n            sendReplyToQuicker(false, '未找到书签（网址不匹配）。', '', qk_msg_serial);\r\n        }\r\n    }\r\n}});\r\n".Replace("@id", bookmark.Id).Replace("@url", bookmark.Url);
			string command = "qk_delete_bookmark";
			_003C_003Ef__AnonymousType25<string, string> commandParams = new _003C_003Ef__AnonymousType25<string, string>(bookmark.Id, bookmark.Url);
			BrowserRespMessage<JToken> browserRespMessage = RunBackgroundScriptOrCommand(bookmark.BrowserProcName, script, command, commandParams, true, 500, bookmark.BrowserProcId);
			if (browserRespMessage.IsSuccess)
			{
				int num = 0;
				if (!Neiv0rFmP4Gi4XNPgShu())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					AppHelper.ShowSuccess("删除书签成功。");
					return true;
				}
			}
			gZDvwLtmOtY.Warn("删除书签出错：" + JsonConvert.SerializeObject(browserRespMessage));
			AppHelper.ShowWarning("删除书签失败。");
		}
		catch (Exception ex)
		{
			AppHelper.ShowSuccess("操作出错了。" + ex.Message);
		}
		return false;
	}

	static ChromeControl()
	{
		gZDvwLtmOtY = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool Neiv0rFmP4Gi4XNPgShu()
	{
		return WhewmsFmgeaSfeBEoxVd == null;
	}
}
