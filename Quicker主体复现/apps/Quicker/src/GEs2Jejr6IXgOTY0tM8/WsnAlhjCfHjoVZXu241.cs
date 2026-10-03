using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using AeNud9jpLbfIkkEIprl;
using log4net;
using NamedPipeWrapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Entities;
using Quicker.Domain.Services;
using Quicker.Modules;
using Quicker.Modules.BrowserControl.Message;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Chrome;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.Win32;
using uP8FRk2Tr90LbRi42kA;

namespace GEs2Jejr6IXgOTY0tM8;

internal class WsnAlhjCfHjoVZXu241 : F58U3QjL5trN9txFOH0
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec S78vQB6jYKu;

		public static Func<KeyValuePair<string, NamedPipeConnection<string, string>>, int> t8xvQQbL7Qh;

		public static Func<ActionItem, bool> erAvQjhqGIG;

		public static Func<ActionItem, BrowserContextMenuItem> R1pvQn4DXXS;

		public static Func<ActionItem, string> dRuvQ4Vp1Em;

		public static Func<ActionItemToWeb, string> PGCvQ5sNYKo;

		internal static _003C_003Ec iQxt1UcsdFg9040WdYB2;

		static _003C_003Ec()
		{
			S78vQB6jYKu = new _003C_003Ec();
		}

		internal int nijvQmUBHpy(KeyValuePair<string, NamedPipeConnection<string, string>> x)
		{
			return Convert.ToInt32(x.Key.Split('-')[1]);
		}

		internal bool k45vQKSffBp(ActionItem x)
		{
			if (x.Association?.BrowserContextMenu != null)
			{
				return !x.Association.BrowserContextMenu.DocumentUrlPatterns.IsNullOrEmpty();
			}
			return false;
		}

		internal BrowserContextMenuItem iM8vQxyq04j(ActionItem x)
		{
			BrowserContextMenuBinding browserContextMenu = x.Association.BrowserContextMenu;
			return new BrowserContextMenuItem
			{
				Id = x.Id,
				Title = x.Title,
				Contexts = browserContextMenu.Contexts.SplitToListOrNull(),
				DocumentUrlPatterns = browserContextMenu.DocumentUrlPatterns.SplitToListOrNull(),
				TargetUrlPatterns = browserContextMenu.TargetUrlPatterns.SplitToListOrNull(),
				ParentId = "QUICKER_ROOT_MENU_ID"
			};
		}

		internal string lndvQrnRFBM(ActionItem x)
		{
			return x.Title;
		}

		internal string P4vvQpdItV8(ActionItemToWeb x)
		{
			if (x.Title.IsNullOrEmpty())
			{
				return "";
			}
			if (x.Title[0].IsChinese())
			{
				return "中" + PinyinHelper.GetPinyinFirstCharString(x.Title);
			}
			return x.Title.ToLower();
		}

		internal static bool DV4dhmcsOfTv31DmatNV()
		{
			return iQxt1UcsdFg9040WdYB2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public NamedPipeConnection<string, string> I5ovQdgxX2c;

		public Func<KeyValuePair<string, NamedPipeConnection<string, string>>, bool> ukrvQojTY1D;

		internal static _003C_003Ec__DisplayClass18_0 Gybx9ycsaV3YoGtO9SNx;

		internal bool pWqvQDZLyT2(KeyValuePair<string, NamedPipeConnection<string, string>> kvp)
		{
			return kvp.Value == I5ovQdgxX2c;
		}

		internal static void YHv7pMcs9VtjAdNq0d9D()
		{
		}

		internal static bool O1D5BKcsroUfsBClyMyA()
		{
			return Gybx9ycsaV3YoGtO9SNx == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public string browser;

		public IList<int> hCqvQOP2k59;

		private static _003C_003Ec__DisplayClass26_0 DOxph9csLUvJWF3puIKc;

		internal bool e5MvQTlZ1uc(KeyValuePair<string, NamedPipeConnection<string, string>> x)
		{
			return x.Key.StartsWith(browser.ToLower() + "-");
		}

		internal bool wvRvQMUIZVF(KeyValuePair<string, NamedPipeConnection<string, string>> x)
		{
			return x.Key.StartsWith(browser.ToLower() + "-");
		}

		internal bool aq6vQAWgj4X(KeyValuePair<IntPtr, string> x)
		{
			return hCqvQOP2k59.Contains(NativeMethods.GetWindowProcessId(x.Key));
		}

		internal static bool CQuxfNcsuWDPZTLQT6tF()
		{
			return DOxph9csLUvJWF3puIKc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public string browser;

		public int MCvvQU2nE37;

		internal static _003C_003Ec__DisplayClass27_0 oZ2fQucsfsHchNQUh6eG;

		internal bool W90vQFDE5HI(KeyValuePair<string, NamedPipeConnection<string, string>> x)
		{
			return string.Equals(x.Key, $"{browser}-{MCvvQU2nE37}", StringComparison.OrdinalIgnoreCase);
		}

		internal static bool RLLSXscsbaXKaxDsx89N()
		{
			return oZ2fQucsfsHchNQUh6eG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public string browser;

		private static _003C_003Ec__DisplayClass28_0 YdvvspcsiatxoX6xJ4s8;

		internal bool aDQvQlOnACn(KeyValuePair<string, NamedPipeConnection<string, string>> x)
		{
			return x.Key.StartsWith(browser + "-", StringComparison.OrdinalIgnoreCase);
		}

		internal static bool sekFe6csliqcipa5NdBr()
		{
			return YdvvspcsiatxoX6xJ4s8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public string hMOvQ3UFJH5;

		private static _003C_003Ec__DisplayClass8_0 hvcH8Qcs5rdG6G01YHGj;

		internal void zAUvQiS7OF8()
		{
			try
			{
				AppState.AppServer.ExecuteActionByIdOrName(hMOvQ3UFJH5, null, false, false, false, "", ActionTrigger.WebpageButton);
			}
			catch (Exception ex)
			{
				bQNtGOGv7vv.Warn("执行动作 " + hMOvQ3UFJH5 + " 出错：" + ex.Message, ex);
				AppHelper.ShowWarning("执行动作出错：" + ex.Message);
			}
		}

		internal static bool Tay9XBcsY5UcHYdfyDkT()
		{
			return hvcH8Qcs5rdG6G01YHGj == null;
		}
	}

	private static readonly ILog bQNtGOGv7vv;

	private IDictionary<string, NamedPipeConnection<string, string>> UWPtGFwa003 = new ConcurrentDictionary<string, NamedPipeConnection<string, string>>();

	private NamedPipeServer<string> MWttGUD94PK;

	public EventHandler<ActiveUrlChangedEventArgs> a4xtGlB9Stc;

	[CompilerGenerated]
	private bool cFptGiZMWxR;

	private int Xu2tG34Ky9s = 1;

	private ConcurrentDictionary<int, BrowserRespMessage<JToken>> kHytGf5cI1w = new ConcurrentDictionary<int, BrowserRespMessage<JToken>>();

	private ConcurrentDictionary<int, ManualResetEvent> tETtGzScpqs = new ConcurrentDictionary<int, ManualResetEvent>();

	private static JsonSerializerSettings Xd8tswFdJar;

	private static WsnAlhjCfHjoVZXu241 IyiQ3kQklvOcpb5lykS9;

	public bool IsRunning
	{
		[CompilerGenerated]
		get
		{
			return cFptGiZMWxR;
		}
		[CompilerGenerated]
		private set
		{
			cFptGiZMWxR = value;
		}
	}

	public WsnAlhjCfHjoVZXu241()
	{
		AppState.eHot72UTS83(this);
	}

	public void QYLM2voUeQh()
	{
		Stop();
		MWttGUD94PK = new NamedPipeServer<string>("quicker_browser_server", IpcServer.RrFtBgpaG2C());
		MWttGUD94PK.ClientConnected += VcHtGXSqfFl;
		MWttGUD94PK.ClientDisconnected += NXZtGbpOfhr;
		MWttGUD94PK.ClientMessage += JCBtG94asK0;
		MWttGUD94PK.Start();
		IsRunning = true;
	}

	private void JCBtG94asK0(NamedPipeConnection<string, string> namedPipeConnection_0, string string_0)
	{
		try
		{
			FhAtGhnnDMb(namedPipeConnection_0, string_0);
		}
		catch (Exception ex)
		{
			bQNtGOGv7vv.Error("处理浏览器代理消息出错：" + ex.Message + "，原始消息：" + string_0 + "  !!!将会断开连接。", ex);
			namedPipeConnection_0.Close();
		}
	}

	private void FhAtGhnnDMb(NamedPipeConnection<string, string> namedPipeConnection_0, string string_0)
	{
		BrowserRespMessage<JToken> browserRespMessage = JsonConvert.DeserializeObject<BrowserRespMessage<JToken>>(string_0);
		if (browserRespMessage == null)
		{
			throw new InvalidDataException("不是合法的json？");
		}
		switch (browserRespMessage.MessageType)
		{
		case 5:
		{
			IxjVQi20QpAKDpoySlu ixjVQi20QpAKDpoySlu = browserRespMessage.Data.ToObject<IxjVQi20QpAKDpoySlu>();
			if (namedPipeConnection_0.Tag is BrowserConnectionInfo browserConnectionInfo && ixjVQi20QpAKDpoySlu != null)
			{
				browserConnectionInfo.ActiveTab = ixjVQi20QpAKDpoySlu.TabId;
				browserConnectionInfo.ActiveTabUrl = ixjVQi20QpAKDpoySlu.Url;
				a4xtGlB9Stc?.Invoke(this, new ActiveUrlChangedEventArgs
				{
					Browser = browserConnectionInfo.BrowserProcName,
					ProcessId = browserConnectionInfo.BrowserProcId,
					TabId = ixjVQi20QpAKDpoySlu.TabId,
					Url = ixjVQi20QpAKDpoySlu.Url,
					IsActive = ixjVQi20QpAKDpoySlu.IsActive,
					EventType = ixjVQi20QpAKDpoySlu.EventType
				});
			}
			break;
		}
		case 7:
			f2RtGIn1hCC(namedPipeConnection_0, browserRespMessage);
			break;
		case 9:
			FSEtGYAQchw(browserRespMessage);
			break;
		case 1:
			xJ7tGGsavHD(namedPipeConnection_0, browserRespMessage);
			break;
		default:
			VkjtGs5O3DN(browserRespMessage, namedPipeConnection_0);
			break;
		case 23:
			ak1tGkEJxkg(namedPipeConnection_0, Convert.ToInt32(browserRespMessage.Data["tabId"]), null);
			break;
		case 22:
			J0ltGeN3WQQ(browserRespMessage);
			break;
		}
	}

	private void J0ltGeN3WQQ(BrowserRespMessage<JToken> browserRespMessage_0)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.hMOvQ3UFJH5 = browserRespMessage_0.Data["actionId"]?.ToString();
		if (!_003C_003Ec__DisplayClass8_.hMOvQ3UFJH5.IsNullOrEmpty())
		{
			Task.Run((Action)_003C_003Ec__DisplayClass8_.zAUvQiS7OF8);
		}
	}

	private void FSEtGYAQchw(BrowserRespMessage<JToken> browserRespMessage_0)
	{
		string text = browserRespMessage_0.Data["data"]?.ToString();
		if (!string.IsNullOrEmpty(text))
		{
			ClipboardHelper.SetText(text);
			AppHelper.ShowSuccess("已复制：" + text.ToShortString(20));
		}
		else
		{
			bQNtGOGv7vv.Warn("未找到要复制的内容。可能消息格式不正确。 原始数据：" + browserRespMessage_0.Data);
			AppHelper.ShowSuccess("没有找到要复制的内容。");
		}
	}

	private void f2RtGIn1hCC(NamedPipeConnection<string, string> namedPipeConnection_0, BrowserRespMessage<JToken> browserRespMessage_0)
	{
		BrowserMenuClickData browserMenuClickData = browserRespMessage_0.Data.ToObject<BrowserMenuClickData>();
		if (browserMenuClickData == null)
		{
			AppHelper.ShowWarning("消息内容为空。");
			return;
		}
		browserMenuClickData.BrowserInfo = namedPipeConnection_0.Tag as BrowserConnectionInfo;
		if (browserMenuClickData.Info.MenuItemId == "QUICKER_ROOT_MENU_ID")
		{
			return;
		}
		if (browserMenuClickData.Info.MenuItemId == "copy_selector")
		{
			cnktGWVvpdv(namedPipeConnection_0, browserMenuClickData);
			return;
		}
		(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(browserMenuClickData.Info.MenuItemId);
		if (actionById.Item1 == null)
		{
			AppHelper.ShowWarning("未找到动作 " + browserMenuClickData.Info.MenuItemId + "。");
			return;
		}
		BrowserContextMenuBinding browserContextMenu = actionById.Item1.Association.BrowserContextMenu;
		string inputParam = "";
		if (!string.IsNullOrEmpty(browserContextMenu?.ActionParam))
		{
			inputParam = browserContextMenu.ActionParam.Replace("%s", browserMenuClickData.Info.SelectionText);
		}
		AppState.AppServer.ExecuteAction(actionById.Item1, 0, null, false, false, false, inputParam, ActionTrigger.BrowserContextMenu, null, new ActionExtraContextData
		{
			BrowserMenuClickData = browserMenuClickData
		});
	}

	private void cnktGWVvpdv(NamedPipeConnection<string, string> namedPipeConnection_0, BrowserMenuClickData browserMenuClickData_0)
	{
		ak1tGkEJxkg(namedPipeConnection_0, browserMenuClickData_0.Tab.Id, null);
	}

	private static void ak1tGkEJxkg(NamedPipeConnection<string, string> namedPipeConnection_0, int? nullable_0, CancellationToken? nullable_1)
	{
		string text = AppHelper.ReadResourceText("pick.js");
		BrowserConnectionInfo obj = namedPipeConnection_0.Tag as BrowserConnectionInfo;
		string text2 = "// 开始选择元素\r\n//\r\nif (typeof _qk_picker !== 'undefined'){\r\n    try{\r\n        _qk_picker.close();\r\n        delete _qk_picker;\r\n    }catch(e){}\r\n}\r\n\r\nvar _qk_picker = new ElementPicker({\r\n    container: document.body,\r\n    selectors: \"*\",\r\n    background: \"rgba(153, 235, 255, 0.5)\",\r\n    borderWidth: 5,\r\n    transition: \"all 150ms ease\",\r\n    ignoreElements: [document.body],\r\n    action: {\r\n        trigger: 'click',\r\n        callback: (function (target) {\r\n            console.log('element selected:', target);\r\n            const selector = finder(target);\r\n            console.log('get selector:',selector);\r\n\r\n\r\n            _qk_picker.close();\r\n            delete _qk_picker;\r\n\r\n            // send to quicker\r\n            sendToQuicker({messageType:9, data:{data:selector}});\r\n        })\r\n    }\r\n});";
		string script = text + text2;
		ChromeControl.ExecuteTabScript(obj?.BrowserProcName, nullable_0, script, false, 1000, false, 0, false, nullable_1);
	}

	private void xJ7tGGsavHD(NamedPipeConnection<string, string> namedPipeConnection_0, BrowserRespMessage<JToken>? msg)
	{
		BrowserInfoData browserInfoData = msg.Data.ToObject<BrowserInfoData>();
		if (browserInfoData == null)
		{
			throw new InvalidDataException("BrowserInfoData为空。");
		}
		gCTtG1TmgSc(namedPipeConnection_0, browserInfoData);
		ChromeCommandMessage<BrowserInfoRespData> chromeCommandMessage = new ChromeCommandMessage<BrowserInfoRespData>
		{
			MessageType = 2,
			Data = new BrowserInfoRespData
			{
				QuickerVersion = AppHelper.GetCurrAppVersion()
			}
		};
		chromeCommandMessage.Serial = Xu2tG34Ky9s++;
		namedPipeConnection_0.PushMessage(chromeCommandMessage.ToJson(false, false, true));
		YyrtG5nkZFy(namedPipeConnection_0);
	}

	private void VkjtGs5O3DN(BrowserRespMessage<JToken> browserRespMessage_0, NamedPipeConnection<string, string> namedPipeConnection_0)
	{
		bool hasValue = browserRespMessage_0.ReplyTo.HasValue;
		int value = browserRespMessage_0.ReplyTo.Value;
		if (kHytGf5cI1w.ContainsKey(value))
		{
			kHytGf5cI1w[value] = browserRespMessage_0;
		}
		if (tETtGzScpqs.TryGetValue(value, out var value2))
		{
			value2.Set();
		}
	}

	private static string WoltGHEKjUj(string string_0, int int_1)
	{
		return string_0.ToLower() + "-" + int_1;
	}

	private void gCTtG1TmgSc(NamedPipeConnection<string, string> namedPipeConnection_0, BrowserInfoData browserInfoData_0)
	{
		namedPipeConnection_0.Tag = new BrowserConnectionInfo
		{
			BrowserProcId = browserInfoData_0.ProcessId,
			BrowserProcName = browserInfoData_0.ProcessName.ToLower(),
			MessageHostVersion = browserInfoData_0.MessageHostVersion,
			ExtensionVersion = browserInfoData_0.ExtensionVersion,
			ManifestVersion = browserInfoData_0.ManifestVersion
		};
		UWPtGFwa003[WoltGHEKjUj(browserInfoData_0.ProcessName, browserInfoData_0.ProcessId)] = namedPipeConnection_0;
	}

	private void NXZtGbpOfhr(NamedPipeConnection<string, string> namedPipeConnection_0)
	{
		bQNtGOGv7vv.Info("浏览器MessageHost已断开： " + namedPipeConnection_0.Name);
		ebDtG67v0iD(namedPipeConnection_0);
	}

	private void ebDtG67v0iD(NamedPipeConnection<string, string> namedPipeConnection_0)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.I5ovQdgxX2c = namedPipeConnection_0;
		foreach (KeyValuePair<string, NamedPipeConnection<string, string>> item in UWPtGFwa003.Where(_003C_003Ec__DisplayClass18_.ukrvQojTY1D ?? (_003C_003Ec__DisplayClass18_.ukrvQojTY1D = _003C_003Ec__DisplayClass18_.pWqvQDZLyT2)).ToList())
		{
			UWPtGFwa003.Remove(item.Key);
			bQNtGOGv7vv.Info("已移除连接信息： " + item.Key);
		}
	}

	private void VcHtGXSqfFl(NamedPipeConnection<string, string> namedPipeConnection_0)
	{
		bQNtGOGv7vv.Debug("浏览器客户端连接了:" + namedPipeConnection_0.Name);
	}

	public void Stop()
	{
		if (MWttGUD94PK != null)
		{
			MWttGUD94PK.Stop();
			MWttGUD94PK = null;
		}
		UWPtGFwa003.Clear();
		IsRunning = false;
	}

	public void woFM2c60JjB()
	{
	}

	public bool m8ItGmyxjPV(string string_0)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.browser = string_0;
		if (!UWPtGFwa003.Any(_003C_003Ec__DisplayClass26_.e5MvQTlZ1uc))
		{
			return false;
		}
		_003C_003Ec__DisplayClass26_.hCqvQOP2k59 = UWPtGFwa003.Where(_003C_003Ec__DisplayClass26_.wvRvQMUIZVF).Select(_003C_003Ec.t8xvQQbL7Qh ?? (_003C_003Ec.t8xvQQbL7Qh = _003C_003Ec.S78vQB6jYKu.nijvQmUBHpy)).ToList();
		if (_003C_003Ec__DisplayClass26_.hCqvQOP2k59.Count == 0)
		{
			return false;
		}
		return OpenWindowGetter.GetOpenWindows(true).Any(_003C_003Ec__DisplayClass26_.aq6vQAWgj4X);
	}

	public bool xSstGKB1AqB(string string_0, int int_1)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.browser = string_0;
		_003C_003Ec__DisplayClass27_.MCvvQU2nE37 = int_1;
		return UWPtGFwa003.Any(_003C_003Ec__DisplayClass27_.W90vQFDE5HI);
	}

	public NamedPipeConnection<string, string> fFCtGxElp5Z(string string_0, int int_1)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.browser = string_0;
		if (int_1 > 0 && UWPtGFwa003.TryGetValue(WoltGHEKjUj(_003C_003Ec__DisplayClass28_.browser, int_1), out var value))
		{
			return value;
		}
		KeyValuePair<string, NamedPipeConnection<string, string>> keyValuePair = UWPtGFwa003.FirstOrDefault(_003C_003Ec__DisplayClass28_.aDQvQlOnACn);
		if (keyValuePair.Key != null)
		{
			return keyValuePair.Value;
		}
		return null;
	}

	public bool cAftGrwyGHF(string string_0, int int_1)
	{
		if ((fFCtGxElp5Z(string_0, int_1) ?? throw new InvalidOperationException("浏览器 " + string_0 + " 未连接。")).Tag is BrowserConnectionInfo browserConnectionInfo)
		{
			return browserConnectionInfo.ManifestVersion == 3;
		}
		return false;
	}

	public BrowserRespMessage<JToken> lhttGp86IDv<ge2254jIojvCcoCgpWo>(ChromeCommandMessage<ge2254jIojvCcoCgpWo> chromeCommandMessage_0, string string_0, bool bool_1 = true, int int_1 = 3000, int int_2 = 0, CancellationToken? nullable_0 = null)
	{
		chromeCommandMessage_0.Serial = Xu2tG34Ky9s++;
		ManualResetEvent manualResetEvent = N3itGj12DOM(chromeCommandMessage_0, bool_1, string_0, int_2);
		if (manualResetEvent != null)
		{
			bool flag;
			try
			{
				WaitHandle[] obj;
				object obj2;
				if (nullable_0.HasValue)
				{
					obj = new WaitHandle[2] { manualResetEvent, null };
					if (!nullable_0.HasValue)
					{
						obj2 = null;
					}
					else
					{
						obj2 = nullable_0.GetValueOrDefault().WaitHandle;
						if (obj2 != null)
						{
							goto IL_006f;
						}
					}
					obj2 = CancellationToken.None.WaitHandle;
					goto IL_006f;
				}
				flag = manualResetEvent.WaitOne(int_1 + 1);
				goto end_IL_0029;
				IL_006f:
				obj[1] = (WaitHandle)obj2;
				int num = WaitHandle.WaitAny(obj, TimeSpan.FromMilliseconds(int_1 + 1));
				if (!(flag = num == 0))
				{
					if (num == 258)
					{
						throw new Exception("操作超时未响应(" + string_0 + ")。");
					}
					throw new Exception("用户取消(" + string_0 + ")。");
				}
				end_IL_0029:;
			}
			catch (OperationCanceledException)
			{
				throw new TimeoutException("用户取消。");
			}
			finally
			{
				tETtGzScpqs.TryRemove(chromeCommandMessage_0.Serial, out var value);
			}
			if (flag)
			{
				BrowserRespMessage<JToken> browserRespMessage = qoEtGnIl9N4(chromeCommandMessage_0.Serial);
				if (browserRespMessage != null)
				{
					return browserRespMessage;
				}
				throw new InvalidDataException("未成功获取浏览器响应数据(" + string_0 + ")。");
			}
			kHytGf5cI1w.TryRemove(chromeCommandMessage_0.Serial, out var value2);
			throw new TimeoutException("操作超时，未获得插件响应(" + string_0 + ")。");
		}
		return null;
	}

	private NamedPipeConnection<string, string> LtWtGB4BYHV(string string_0, int int_1)
	{
		return fFCtGxElp5Z(string_0, int_1) ?? throw new InvalidOperationException("浏览器 " + string_0 + " 未连接。");
	}

	public void QMutGQlWRPp(NamedPipeConnection<string, string> namedPipeConnection_0, int int_1, IList<ActionItem> ilist_0)
	{
		string script = "\r\nvar div=document.createElement('div'); \r\ndocument.body.appendChild(div); \r\ndiv.innerText='test123';\r\ndiv.style.backgroundColor = 'red';\r\ndiv.style.position = 'fixed';\r\ndiv.style.zIndex = 10000;\r\ndiv.style.top = 0;\r\ndiv.style.left = 0;\r\n\r\n";
		ChromeCommandMessage<object> chromeCommandMessage = new ChromeCommandMessage<object>
		{
			Cmd = "RunScript",
			TabId = int_1,
			Data = new _003C_003Ef__AnonymousType4<string, bool, int, bool>(script, false, 0, false)
		};
		namedPipeConnection_0.PushMessage(JsonConvert.SerializeObject(chromeCommandMessage, Formatting.None, Xd8tswFdJar).Replace("qk_msg_serial", chromeCommandMessage.Serial.ToString()));
	}

	private ManualResetEvent N3itGj12DOM<DhAdsujGmOcW5X0RIcU>(ChromeCommandMessage<DhAdsujGmOcW5X0RIcU> chromeCommandMessage_0, bool bool_1, string string_0, int int_1)
	{
		NamedPipeConnection<string, string> namedPipeConnection = LtWtGB4BYHV(string_0, int_1);
		ManualResetEvent manualResetEvent = null;
		if (bool_1)
		{
			kHytGf5cI1w[chromeCommandMessage_0.Serial] = null;
			manualResetEvent = new ManualResetEvent(false);
			tETtGzScpqs[chromeCommandMessage_0.Serial] = manualResetEvent;
		}
		namedPipeConnection.PushMessage(JsonConvert.SerializeObject(chromeCommandMessage_0, Formatting.None, Xd8tswFdJar).Replace("qk_msg_serial", chromeCommandMessage_0.Serial.ToString()));
		return manualResetEvent;
	}

	private BrowserRespMessage<JToken> qoEtGnIl9N4(int int_1)
	{
		if (kHytGf5cI1w.TryRemove(int_1, out var value) && value != null)
		{
			return value;
		}
		return null;
	}

	[SpecialName]
	public string jlntGMKVuJL()
	{
		return string.Join(" ", UWPtGFwa003.Keys);
	}

	public IList<string> k3itG4fRlwV()
	{
		return UWPtGFwa003.Keys.ToList();
	}

	public void YyrtG5nkZFy(NamedPipeConnection<string, string> namedPipeConnection_0)
	{
		TZ7tGDZ8IP5(namedPipeConnection_0);
		PushActions(namedPipeConnection_0);
	}

	public void TZ7tGDZ8IP5(NamedPipeConnection<string, string> namedPipeConnection_0)
	{
		IList<BrowserContextMenuItem> list = new List<BrowserContextMenuItem>();
		if (AppState.HHxtaMaoqJr().EnableBrowserContextMenu)
		{
			list = AppState.DataService.m8kt6U4wyce().Where(_003C_003Ec.erAvQjhqGIG ?? (_003C_003Ec.erAvQjhqGIG = _003C_003Ec.S78vQB6jYKu.k45vQKSffBp)).ToList()
				.Select(_003C_003Ec.R1pvQn4DXXS ?? (_003C_003Ec.R1pvQn4DXXS = _003C_003Ec.S78vQB6jYKu.iM8vQxyq04j))
				.ToList();
			list.Add(new BrowserContextMenuItem
			{
				Id = "dev_tools",
				Title = "开发工具",
				Contexts = new List<string> { "all" },
				DocumentUrlPatterns = null,
				TargetUrlPatterns = null,
				ParentId = "QUICKER_ROOT_MENU_ID"
			});
			list.Add(new BrowserContextMenuItem
			{
				Id = "copy_selector",
				Title = "获取CSS选择器",
				Contexts = new List<string> { "all" },
				DocumentUrlPatterns = null,
				TargetUrlPatterns = null,
				ParentId = "dev_tools"
			});
			if (list.Count > 0)
			{
				list.Insert(0, BrowserContextMenuItem.RootItem);
			}
		}
		ChromeCommandMessage<BrowserContextMenuData> chromeCommandMessage = new ChromeCommandMessage<BrowserContextMenuData>();
		chromeCommandMessage.MessageType = 6;
		chromeCommandMessage.Cmd = "RegisterContextMenus";
		chromeCommandMessage.Data = new BrowserContextMenuData
		{
			Items = list
		};
		chromeCommandMessage.Serial = Xu2tG34Ky9s++;
		if (namedPipeConnection_0 != null)
		{
			namedPipeConnection_0.PushMessage(JsonConvert.SerializeObject(chromeCommandMessage, Formatting.None, Xd8tswFdJar));
			return;
		}
		foreach (NamedPipeConnection<string, string> value in UWPtGFwa003.Values)
		{
			value.PushMessage(JsonConvert.SerializeObject(chromeCommandMessage, Formatting.None, Xd8tswFdJar));
		}
	}

	public void PushActions(NamedPipeConnection<string, string> currentConnection)
	{
		PushActionMessageData pushActionMessageData = new PushActionMessageData();
		pushActionMessageData.Groups = new List<ActionGroup>();
		pushActionMessageData.Actions = new List<ActionItemToWeb>();
		if (AppState.HHxtaMaoqJr().EnableWebPageActions)
		{
			List<ActionItemToWeb> list = new List<ActionItemToWeb>();
			if (AppState.HHxtaMaoqJr().EnableWebPageActionsForActionPage)
			{
				foreach (ExeSettings item in AppState.DataService.Q0ltmmbUTMB())
				{
					if (!item.Exe.StartsWith("@_") || string.IsNullOrEmpty(item.UrlPattern))
					{
						continue;
					}
					string urlPattern = IIktGok9Ors(item.UrlPattern);
					foreach (ActionProfile value in AppState.DataService.mP6tXA8VyNP().Values)
					{
						if (!(value.ExeFile == item.Exe) || !value.ActionItems.HasData())
						{
							continue;
						}
						foreach (ActionItem item2 in value.ActionItems.OrderBy(_003C_003Ec.dRuvQ4Vp1Em ?? (_003C_003Ec.dRuvQ4Vp1Em = _003C_003Ec.S78vQB6jYKu.lndvQrnRFBM)))
						{
							ActionItemToWeb actionItemToWeb = new ActionItemToWeb(item2);
							actionItemToWeb.UrlPattern = urlPattern;
							list.Add(actionItemToWeb);
						}
					}
				}
			}
			foreach (ActionProfile value2 in AppState.DataService.mP6tXA8VyNP().Values)
			{
				if (AppState.HHxtaMaoqJr().EnableWebPageActionsForActionPage && (value2.ExeFile == null || value2.ExeFile.StartsWith("@_")))
				{
					continue;
				}
				foreach (ActionItem actionItem in value2.ActionItems)
				{
					if (!string.IsNullOrEmpty(actionItem?.Association?.UrlPattern))
					{
						ActionItemToWeb actionItemToWeb2 = new ActionItemToWeb(actionItem);
						actionItemToWeb2.UrlPattern = IIktGok9Ors(actionItem?.Association?.UrlPattern);
						list.Add(actionItemToWeb2);
					}
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			pushActionMessageData.Actions = list.OrderBy(_003C_003Ec.PGCvQ5sNYKo ?? (_003C_003Ec.PGCvQ5sNYKo = _003C_003Ec.S78vQB6jYKu.P4vvQpdItV8)).ToList();
		}
		ChromeCommandMessage<PushActionMessageData> chromeCommandMessage = new ChromeCommandMessage<PushActionMessageData>();
		chromeCommandMessage.MessageType = 21;
		chromeCommandMessage.Cmd = "PushActions";
		chromeCommandMessage.Data = pushActionMessageData;
		chromeCommandMessage.Serial = Xu2tG34Ky9s++;
		if (currentConnection != null)
		{
			currentConnection.PushMessage(JsonConvert.SerializeObject(chromeCommandMessage, Formatting.None, Xd8tswFdJar));
			return;
		}
		foreach (NamedPipeConnection<string, string> value3 in UWPtGFwa003.Values)
		{
			value3.PushMessage(JsonConvert.SerializeObject(chromeCommandMessage, Formatting.None, Xd8tswFdJar));
		}
	}

	public static bool XRmtGdDumUX(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(string_0))
		{
			string pattern = IIktGok9Ors(string_1);
			return Regex.IsMatch(string_0, pattern, RegexOptions.IgnoreCase);
		}
		return false;
	}

	private static string IIktGok9Ors(string string_0)
	{
		if (string_0.StartsWith("regex:"))
		{
			return string_0.Substring("regex:".Length);
		}
		if (string_0.Contains(".*"))
		{
			return string_0;
		}
		return string_0.Replace(".", "\\.").Replace("?", "\\?").Replace("*", ".*");
	}

	static WsnAlhjCfHjoVZXu241()
	{
		bQNtGOGv7vv = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		Xd8tswFdJar = new JsonSerializerSettings
		{
			ContractResolver = new CamelCasePropertyNamesContractResolver(),
			NullValueHandling = NullValueHandling.Ignore
		};
	}

	internal static bool x2xnwVQkZTQNsgWEOMuD()
	{
		return IyiQ3kQklvOcpb5lykS9 == null;
	}
}
