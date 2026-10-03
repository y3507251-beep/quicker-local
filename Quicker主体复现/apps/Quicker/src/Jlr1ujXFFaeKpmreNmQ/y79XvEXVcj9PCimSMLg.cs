using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities._3rd.Chrome;

namespace Jlr1ujXFFaeKpmreNmQ;

internal class y79XvEXVcj9PCimSMLg : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec cEYviPW9yPQ;

		public static Func<JToken, bool> HmvviEwVG4W;

		public static Func<object> z1SviyTF28r;

		public static Func<object> bpQvi8eSCiX;

		public static Func<object> XZ0viaHU6jq;

		public static Func<object> vXovi7tMaOd;

		public static Func<JToken, string> dAGviRgQwBP;

		internal static _003C_003Ec YjN3Z2WjjRCHOw2AS2J1;

		static _003C_003Ec()
		{
			cEYviPW9yPQ = new _003C_003Ec();
		}

		internal bool QiTvi2LKOyT(JToken x)
		{
			if (x != null && x is JArray jArray)
			{
				return jArray.Count > 0;
			}
			return false;
		}

		internal object vPEviuwktCy()
		{
			return "";
		}

		internal object xBlviNwnTJd()
		{
			return new List<string>();
		}

		internal object UiRviJZ7X6t()
		{
			return "";
		}

		internal object sLwvi0WPs5g()
		{
			return new List<string>();
		}

		internal string o8WviCmT1cQ(JToken x)
		{
			return x.ToString();
		}

		internal static void HDXOMoWjEF02ftGJlong()
		{
		}

		internal static bool ECYW3ZWjDTydQRRxOWap()
		{
			return YjN3Z2WjjRCHOw2AS2J1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_0
	{
		public ActionStep Ad1vicaKx8L;

		public ActionExecuteContext iyTviVH8nqX;

		public y79XvEXVcj9PCimSMLg EhSviZ25a4B;

		public XAction zIcvi98km15;

		internal static _003C_003Ec__DisplayClass104_0 pPHfUtWjGKnPNajLxB3u;

		internal (bool isSuccess, string message, ActionStopFlag failReason) lXJviq4qs51()
		{
			string textParamValue = XActionHelper.GetTextParamValue(tAetTLuHgoa, Ad1vicaKx8L, iyTviVH8nqX);
			int num = (int)XActionHelper.GetIntegerParamValue(UjMtTq3mdGQ, Ad1vicaKx8L, iyTviVH8nqX);
			int? num2 = null;
			string textParamValue2 = XActionHelper.GetTextParamValue(Im1tT2athjL, Ad1vicaKx8L, iyTviVH8nqX);
			if (!string.IsNullOrWhiteSpace(textParamValue2))
			{
				num2 = Convert.ToInt32(textParamValue2);
			}
			if (textParamValue == "SetBrowser")
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(xXKtThtMPKE, Ad1vicaKx8L, iyTviVH8nqX);
				iyTviVH8nqX.Browser = textParamValue3.ToLower();
			}
			if (string.IsNullOrEmpty(iyTviVH8nqX.Browser) || iyTviVH8nqX.Browser == "auto")
			{
				string text = Path.GetFileNameWithoutExtension(AppState.CurrentExeName).ToLower();
				if (AppState.vjAt7Seco0Y().m8ItGmyxjPV(text))
				{
					iyTviVH8nqX.Browser = text;
				}
				else
				{
					iyTviVH8nqX.Browser = AppState.DataService.CpItmVISR7P().DefaultBrowser;
					if (string.IsNullOrWhiteSpace(iyTviVH8nqX.Browser))
					{
						iyTviVH8nqX.Browser = "chrome";
					}
				}
			}
			if (iyTviVH8nqX.IsDebugging)
			{
				iyTviVH8nqX.ActionLogger.LogInfo("连接的浏览器：" + iyTviVH8nqX.Browser);
			}
			bool flag = true;
			int num3 = 0;
			if (textParamValue.IsEither(fPNtTcY6g1t.ValidForList))
			{
				string text2 = XActionHelper.GetTextParamValue(fPNtTcY6g1t, Ad1vicaKx8L, iyTviVH8nqX).Trim();
				if (!(flag = string.Equals(text2, "all", StringComparison.InvariantCultureIgnoreCase)))
				{
					num3 = Convert.ToInt32(text2);
				}
			}
			_003C_003Ec__DisplayClass104_2 _003C_003Ec__DisplayClass104_4;
			string textParamValue4;
			switch (textParamValue)
			{
			case "Wait":
				EhSviZ25a4B.oDatoA0PXg1(num2, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15, num);
				break;
			case "OpenUrl":
				EhSviZ25a4B.OpenUrl(Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15, num);
				break;
			case "CloseTab":
			{
				_003C_003Ec__DisplayClass104_3 _003C_003Ec__DisplayClass104_2 = new _003C_003Ec__DisplayClass104_3
				{
					U3qvi5h8Ow8 = ChromeControl.SendMessageToBrowser(new ChromeCommandMessage<object>
					{
						Cmd = "CloseTab",
						TabId = num2
					}, iyTviVH8nqX.Browser, true, 3000, 0, iyTviVH8nqX.CancellationToken)
				};
				if (!_003C_003Ec__DisplayClass104_2.U3qvi5h8Ow8.IsSuccess)
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass104_2.U3qvi5h8Ow8.Message, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass104_2.UuEvi4Dm6vr, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				break;
			}
			case "RunScript":
			{
				_003C_003Ec__DisplayClass104_4 _003C_003Ec__DisplayClass104_5 = new _003C_003Ec__DisplayClass104_4();
				string textParamValue5 = XActionHelper.GetTextParamValue(oMetT8hq2Fl, Ad1vicaKx8L, iyTviVH8nqX);
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(PsmtTZD3AIk, Ad1vicaKx8L, iyTviVH8nqX);
				string textParamValue6 = XActionHelper.GetTextParamValue(LiStTVskdJU, Ad1vicaKx8L, iyTviVH8nqX);
				_003C_003Ec__DisplayClass104_5.LqovidOVH7J = ChromeControl.ExecuteTabScript(iyTviVH8nqX.Browser, num2, textParamValue5, true, num, flag, num3, booleanParamValue, iyTviVH8nqX.CancellationToken, textParamValue6);
				if (!_003C_003Ec__DisplayClass104_5.LqovidOVH7J.IsSuccess)
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass104_5.LqovidOVH7J.Message, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass104_5.C3wviDOO9J0, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				break;
			}
			case "GetTabInfo":
			{
				_003C_003Ec__DisplayClass104_1 _003C_003Ec__DisplayClass104_6 = new _003C_003Ec__DisplayClass104_1
				{
					wY3vibhYE30 = GetTabInfo(num2, iyTviVH8nqX, num, iyTviVH8nqX.CancellationToken)
				};
				if (!_003C_003Ec__DisplayClass104_6.wY3vibhYE30.IsSuccess)
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass104_6.wY3vibhYE30.Message, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResultIfNeeded(SHmtTsqsoZo, _003C_003Ec__DisplayClass104_6.uWqvihS4w4v, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(pb4tTG6oOao, _003C_003Ec__DisplayClass104_6.GCAvie3RZZg, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(fWJtT16q7P2, _003C_003Ec__DisplayClass104_6.df1viYjANr6, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(myFtTba9nj7, _003C_003Ec__DisplayClass104_6.GwMviIBP8lr, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(tX6tT6MODsP, _003C_003Ec__DisplayClass104_6.zP4viWrGVJe, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass104_6.JPqvikqsABG, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(GUAtTKH6O8h, _003C_003Ec__DisplayClass104_6.mE8viGZKN04, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(IvctTxfFlGg, _003C_003Ec__DisplayClass104_6.iPevisA4Vlt, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(dk5tTrv5aRI, _003C_003Ec__DisplayClass104_6.ChKviHFGJWy, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(JuYtTHojTkL, _003C_003Ec__DisplayClass104_6.RXlvi1EaQhZ, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				break;
			}
			case "PickElement":
			{
				_003C_003Ec__DisplayClass104_5 _003C_003Ec__DisplayClass104_3 = new _003C_003Ec__DisplayClass104_5();
				string text3 = AppHelper.ReadResourceText("pick.js");
				string text4 = "// 开始选择元素\r\n//\r\nif (typeof _qk_picker !== 'undefined'){\r\n    try{\r\n        _qk_picker.close();\r\n        delete _qk_picker;\r\n    }catch(e){}\r\n}\r\n\r\n\r\nvar _qk_picker = new ElementPicker({\r\n        container: document.body,\r\n        selectors: \"*\",\r\n        background: \"rgba(153, 235, 255, 0.5)\",\r\n        borderWidth: 5,\r\n        transition: \"all 150ms ease\",\r\n        ignoreElements: [document.body],\r\n        action: {\r\n            trigger: 'click',\r\n            callback: (function (target) {\r\n                console.log('element selected:', target);\r\n                const selector = finder(target);\r\n                console.log('get selector:',selector);\r\n\r\n\r\n                _qk_picker.close();\r\n                delete _qk_picker;\r\n\r\n                // send to quicker\r\n                //sendToQuicker({messageType:9, data:{data:selector}});\r\n                sendReplyToQuicker(true, '', {'selector':selector}, qk_msg_serial) \r\n            })\r\n        }\r\n    });\r\n";
				string script = text3 + text4;
				_003C_003Ec__DisplayClass104_3.iAMviMd1LcZ = ChromeControl.ExecuteTabScriptOrCommand(iyTviVH8nqX.Browser, num2, script, "pick_element_selector", null, true, num, flag, num3, true, iyTviVH8nqX.CancellationToken);
				if (!_003C_003Ec__DisplayClass104_3.iAMviMd1LcZ.IsSuccess)
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass104_3.iAMviMd1LcZ.Message, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResultIfNeeded(JIctTpYkfIS, _003C_003Ec__DisplayClass104_3.shsvioKnSEW, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass104_3.qqlviTasYNt, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				break;
			}
			case "ActivateTab":
				_003C_003Ec__DisplayClass104_4 = new _003C_003Ec__DisplayClass104_2();
				textParamValue4 = XActionHelper.GetTextParamValue(ujHtTvGWr0x, Ad1vicaKx8L, iyTviVH8nqX);
				if (string.IsNullOrEmpty(textParamValue4))
				{
					if (num2.HasValue)
					{
						int? num5 = num2;
						int num6 = 0;
						if (!((num5.GetValueOrDefault() == 0) & num5.HasValue))
						{
							goto IL_0776;
						}
					}
					throw new Exception("需要指定标签页id或网址匹配模版");
				}
				goto IL_0776;
			case "TriggerEvent":
				EhSviZ25a4B.TriggerEvent(num2, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15, num, flag, num3);
				break;
			case "UpdateElement":
				EhSviZ25a4B.knGtoi6AdLd(num2, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15, num, flag, num3);
				break;
			case "GetElementInfo":
				EhSviZ25a4B.GetElementInfo(num2, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15, num, flag, num3);
				break;
			case "WaitTabComplete":
			{
				long num4 = AppHelper.fLiLTj0x4QY() + num;
				bool flag2 = false;
				while (AppHelper.fLiLTj0x4QY() < num4 && !flag2 && !iyTviVH8nqX.IsShouldStopAction())
				{
					_003C_003Ec__DisplayClass104_6 _003C_003Ec__DisplayClass104_ = new _003C_003Ec__DisplayClass104_6
					{
						ElKviO97ieW = GetTabInfo(num2, iyTviVH8nqX, 1000, iyTviVH8nqX.CancellationToken)
					};
					if (_003C_003Ec__DisplayClass104_.ElKviO97ieW.IsSuccess && _003C_003Ec__DisplayClass104_.ElKviO97ieW.Data["status"]?.ToObject<string>() == "complete")
					{
						flag2 = true;
						XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass104_.T01viATWjTh, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
					}
					Thread.Sleep(250);
				}
				if (!flag2)
				{
					throw new InvalidDataException($"等待网页加载完成超时({num}ms)。");
				}
				break;
			}
			case "BackgroundScript":
				EhSviZ25a4B.geAtoOl5sFH(Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15, num);
				break;
			case "BackgroundCommand":
				{
					EhSviZ25a4B.rP5toFwlQrq(Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15, num);
					break;
				}
				IL_0776:
				_003C_003Ec__DisplayClass104_4.WtFvinIQptS = ActivateTab(num2, textParamValue4, iyTviVH8nqX, num, iyTviVH8nqX.CancellationToken);
				if (!_003C_003Ec__DisplayClass104_4.WtFvinIQptS.IsSuccess)
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass104_4.WtFvinIQptS.Message, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResultIfNeeded(SHmtTsqsoZo, _003C_003Ec__DisplayClass104_4.d5rvi6EAnrX, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(pb4tTG6oOao, _003C_003Ec__DisplayClass104_4.NmDviXU3oYn, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(fWJtT16q7P2, _003C_003Ec__DisplayClass104_4.Vf2vimka7WS, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(myFtTba9nj7, _003C_003Ec__DisplayClass104_4.cdCviKsAstu, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(tX6tT6MODsP, _003C_003Ec__DisplayClass104_4.xpNvixBrMUM, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass104_4.sdlvirGjxFs, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(GUAtTKH6O8h, _003C_003Ec__DisplayClass104_4.eQFvipb6adF, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(IvctTxfFlGg, _003C_003Ec__DisplayClass104_4.BjrviBLeAEY, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(dk5tTrv5aRI, _003C_003Ec__DisplayClass104_4.rmTviQbQw4D, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				XActionHelper.OutputResultIfNeeded(JuYtTHojTkL, _003C_003Ec__DisplayClass104_4.QdfvijH5Djj, Ad1vicaKx8L, iyTviVH8nqX, zIcvi98km15);
				break;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool rPEfdoWj0o5PJ2FbCZH2()
		{
			return pPHfUtWjGKnPNajLxB3u == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_1
	{
		public BrowserRespMessage<JToken> wY3vibhYE30;

		internal static _003C_003Ec__DisplayClass104_1 kRp7lBWjKsQNVI6cpDgs;

		internal object uWqvihS4w4v()
		{
			return wY3vibhYE30.Data["windowId"]?.ToObject<int>() ?? 0;
		}

		internal object GCAvie3RZZg()
		{
			return wY3vibhYE30.Data["id"]?.ToObject<int>() ?? 0;
		}

		internal object df1viYjANr6()
		{
			JToken? jToken = wY3vibhYE30.Data["url"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken.ToObject<string>();
				if (obj != null)
				{
					goto IL_004f;
				}
			}
			JToken? jToken2 = wY3vibhYE30.Data["pendingUrl"];
			if (jToken2 == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken2.ToObject<string>();
				if (obj != null)
				{
					goto IL_004f;
				}
			}
			obj = "";
			goto IL_004f;
			IL_004f:
			return obj;
		}

		internal object GwMviIBP8lr()
		{
			JToken? jToken = wY3vibhYE30.Data["title"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken.ToObject<string>();
				if (obj != null)
				{
					goto IL_002a;
				}
			}
			obj = "";
			goto IL_002a;
			IL_002a:
			return obj;
		}

		internal object zP4viWrGVJe()
		{
			JToken? jToken = wY3vibhYE30.Data["favIconUrl"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken.ToObject<string>();
				if (obj != null)
				{
					goto IL_002a;
				}
			}
			obj = "";
			goto IL_002a;
			IL_002a:
			return obj;
		}

		internal object JPqvikqsABG()
		{
			return wY3vibhYE30.Data;
		}

		internal object mE8viGZKN04()
		{
			return wY3vibhYE30.Browser;
		}

		internal object iPevisA4Vlt()
		{
			return wY3vibhYE30.Version;
		}

		internal object ChKviHFGJWy()
		{
			return wY3vibhYE30.ManifestVersion.Or(2);
		}

		internal object RXlvi1EaQhZ()
		{
			return wY3vibhYE30.Data["groupId"]?.ToObject<int>() ?? 0;
		}

		internal static bool duAUb0WjB2CCPYg9TKlr()
		{
			return kRp7lBWjKsQNVI6cpDgs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_2
	{
		public BrowserRespMessage<JToken> WtFvinIQptS;

		internal static _003C_003Ec__DisplayClass104_2 x9FUIVWjdaI3puicNX5B;

		internal object d5rvi6EAnrX()
		{
			return WtFvinIQptS.Data["windowId"]?.ToObject<int>() ?? 0;
		}

		internal object NmDviXU3oYn()
		{
			return WtFvinIQptS.Data["id"]?.ToObject<int>() ?? 0;
		}

		internal object Vf2vimka7WS()
		{
			JToken? jToken = WtFvinIQptS.Data["url"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken.ToObject<string>();
				if (obj != null)
				{
					goto IL_004f;
				}
			}
			JToken? jToken2 = WtFvinIQptS.Data["pendingUrl"];
			if (jToken2 == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken2.ToObject<string>();
				if (obj != null)
				{
					goto IL_004f;
				}
			}
			obj = "";
			goto IL_004f;
			IL_004f:
			return obj;
		}

		internal object cdCviKsAstu()
		{
			JToken? jToken = WtFvinIQptS.Data["title"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken.ToObject<string>();
				if (obj != null)
				{
					goto IL_002a;
				}
			}
			obj = "";
			goto IL_002a;
			IL_002a:
			return obj;
		}

		internal object xpNvixBrMUM()
		{
			JToken? jToken = WtFvinIQptS.Data["favIconUrl"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken.ToObject<string>();
				if (obj != null)
				{
					goto IL_002a;
				}
			}
			obj = "";
			goto IL_002a;
			IL_002a:
			return obj;
		}

		internal object sdlvirGjxFs()
		{
			return WtFvinIQptS.Data;
		}

		internal object eQFvipb6adF()
		{
			return WtFvinIQptS.Browser;
		}

		internal object BjrviBLeAEY()
		{
			return WtFvinIQptS.Version;
		}

		internal object rmTviQbQw4D()
		{
			return WtFvinIQptS.ManifestVersion.Or(2);
		}

		internal object QdfvijH5Djj()
		{
			return WtFvinIQptS.Data["groupId"]?.ToObject<int>() ?? 0;
		}

		internal static bool RJDM9YWjOluts7A2EmX6()
		{
			return x9FUIVWjdaI3puicNX5B == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_3
	{
		public BrowserRespMessage<JToken> U3qvi5h8Ow8;

		internal static _003C_003Ec__DisplayClass104_3 ixFCDsWjaRb4w8hJ009v;

		internal object UuEvi4Dm6vr()
		{
			return U3qvi5h8Ow8.Data;
		}

		internal static bool ppZ558WjrvFQGuFKYGNc()
		{
			return ixFCDsWjaRb4w8hJ009v == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_4
	{
		public BrowserRespMessage<JToken> LqovidOVH7J;

		private static _003C_003Ec__DisplayClass104_4 MRqA9vWj92MD7hnMm2NT;

		internal object C3wviDOO9J0()
		{
			return LqovidOVH7J.Data;
		}

		internal static bool QnON5aWjL4Wr7CpccgtD()
		{
			return MRqA9vWj92MD7hnMm2NT == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_5
	{
		public BrowserRespMessage<JToken> iAMviMd1LcZ;

		internal static _003C_003Ec__DisplayClass104_5 NMEO1yWjoWLrRyIi0dn1;

		internal object shsvioKnSEW()
		{
			return iAMviMd1LcZ.Data["selector"]?.ToObject<string>();
		}

		internal object qqlviTasYNt()
		{
			return iAMviMd1LcZ.Data;
		}

		internal static bool V2bxy9WjfuwoDwAZGS1i()
		{
			return NMEO1yWjoWLrRyIi0dn1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_6
	{
		public BrowserRespMessage<JToken> ElKviO97ieW;

		private static _003C_003Ec__DisplayClass104_6 zQwMVRWjq9QCl7DaorsZ;

		internal object T01viATWjTh()
		{
			return ElKviO97ieW.Data;
		}

		internal static bool UPcm8FWjiQK73kabiBvU()
		{
			return zQwMVRWjq9QCl7DaorsZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass106_0
	{
		public BrowserRespMessage<JToken> ATMviUHpp5i;

		private static _003C_003Ec__DisplayClass106_0 aKu7cIWjZyDqWBrDial8;

		internal object qPGviFiCwod()
		{
			return ATMviUHpp5i.Data;
		}

		internal static bool GAdtbeWj5hoML3ymQjec()
		{
			return aKu7cIWjZyDqWBrDial8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass107_0
	{
		public BrowserRespMessage<JToken> WVtviiuSiIQ;

		private static _003C_003Ec__DisplayClass107_0 AyR4MmWj8y7Tldm5QVJj;

		internal object XTUvilnptBZ()
		{
			return WVtviiuSiIQ.Data;
		}

		internal static bool rcKvnBWjR8I3Q8H7spH2()
		{
			return AyR4MmWj8y7Tldm5QVJj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass109_0
	{
		public BrowserRespMessage<JToken> j12vifVtap4;

		internal static _003C_003Ec__DisplayClass109_0 JdbjPOWjPUaNCSfgaHeK;

		internal object vctvi3eHnst()
		{
			return j12vifVtap4.Data;
		}

		internal static void J3AtIsWjxAfBt25KDav9()
		{
		}

		internal static bool wLtqh7WjMVtF1mjVVJ0o()
		{
			return JdbjPOWjPUaNCSfgaHeK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass111_0
	{
		public BrowserRespMessage<JToken> QT3v3wC1ILl;

		internal static _003C_003Ec__DisplayClass111_0 OUV7oWWjIJJYgLpVF6XK;

		internal object dWsvizGsi7A()
		{
			return QT3v3wC1ILl.Data;
		}

		internal static bool GuOCsNWj63mt1gI0rfug()
		{
			return OUV7oWWjIJJYgLpVF6XK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass114_0
	{
		public BrowserRespMessage<JToken> Yp9v3gA0nYw;

		internal static _003C_003Ec__DisplayClass114_0 AQi9t1WjSTy4dIInJ1mW;

		internal object k4sv3tklLxO()
		{
			return Yp9v3gA0nYw.Data;
		}

		internal static bool aUPLGpWjwWS2Y9nn1Few()
		{
			return AQi9t1WjSTy4dIInJ1mW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass114_1
	{
		public JArray MCpv3SdP2Pd;

		private static _003C_003Ec__DisplayClass114_1 PUkShZWjmVorpDrkGVfb;

		internal object agdv3LmpRx5()
		{
			return MCpv3SdP2Pd[0].ToString();
		}

		internal object kqDv3velBeB()
		{
			return MCpv3SdP2Pd.Select<JToken, string>(_003C_003Ec.dAGviRgQwBP ?? (_003C_003Ec.dAGviRgQwBP = _003C_003Ec.cEYviPW9yPQ.o8WviCmT1cQ)).ToList();
		}

		internal static bool PslwKGWjsFsH8ayRPVoA()
		{
			return PUkShZWjmVorpDrkGVfb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass116_0
	{
		public BrowserRespMessage<JToken> qnqv3u2ugiZ;

		internal static _003C_003Ec__DisplayClass116_0 P94Vm1Wj7TAjyqF4JmwG;

		internal object AGyv32sMW5Y()
		{
			return qnqv3u2ugiZ.Data;
		}

		internal static bool XiopBHWj48Z5C0OA8nHm()
		{
			return P94Vm1Wj7TAjyqF4JmwG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass116_1
	{
		public int? MVmv308Z0Wb;

		public int? wTwv3CZYLcn;

		internal static _003C_003Ec__DisplayClass116_1 dcp0NqWjH2AtquTbROin;

		internal object wODv3NTRgPu()
		{
			return MVmv308Z0Wb.GetValueOrDefault();
		}

		internal object ojjv3JM7X0Y()
		{
			return wTwv3CZYLcn.GetValueOrDefault();
		}

		internal static void O6uZ93WDQIsbSxxXfW3i()
		{
		}

		internal static bool aZhRjxWjzV3CHNMSRgyM()
		{
			return dcp0NqWjH2AtquTbROin == null;
		}
	}

	[CompilerGenerated]
	private readonly string GBltTw4ZJOw = $"fa:{EFontAwesomeIcon.Brands_Chrome}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> b3DtTtnbqtc;

	[CompilerGenerated]
	private readonly string qUItTgCMXI7 = "https://getquicker.net/KC/Help/Doc/chromecontrol";

	public static StepInParamDef tAetTLuHgoa;

	private static readonly StepInParamDef ujHtTvGWr0x;

	private static readonly StepInParamDef UL5tTSVaaiB;

	private static readonly StepInParamDef Im1tT2athjL;

	private static readonly StepInParamDef bjRtTupRsuP;

	private static readonly StepInParamDef cGxtTNIjTMl;

	private static readonly StepInParamDef eYDtTJWL0PC;

	private static readonly StepInParamDef XgHtT01DqS5;

	private static readonly StepInParamDef JoctTCWjclT;

	private static readonly StepInParamDef EmYtTPQR851;

	private static readonly StepInParamDef G2HtTEtsAbH;

	private static readonly StepInParamDef GqttTy0Z4QG;

	private static readonly StepInParamDef oMetT8hq2Fl;

	private static readonly StepInParamDef mBqtTaen5LM;

	private static readonly StepInParamDef HxbtT7MDfx0;

	private static readonly StepInParamDef XR0tTRWQv0b;

	private static readonly StepInParamDef UjMtTq3mdGQ;

	private static readonly StepInParamDef fPNtTcY6g1t;

	private static readonly StepInParamDef LiStTVskdJU;

	private static readonly StepInParamDef PsmtTZD3AIk;

	private static readonly StepInParamDef O0OtT92V0X7;

	private static readonly StepInParamDef xXKtThtMPKE;

	private static readonly StepInParamDef GZQtTeNPhSH;

	private static readonly StepInParamDef iDLtTYKuBxo;

	private static readonly StepInParamDef gRLtTIWrU8I;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> RwmtTWdj9Ji = new List<StepInParamDef>
	{
		tAetTLuHgoa, UL5tTSVaaiB, Im1tT2athjL, ujHtTvGWr0x, bjRtTupRsuP, cGxtTNIjTMl, iDLtTYKuBxo, eYDtTJWL0PC, XgHtT01DqS5, G2HtTEtsAbH,
		EmYtTPQR851, JoctTCWjclT, GqttTy0Z4QG, oMetT8hq2Fl, mBqtTaen5LM, HxbtT7MDfx0, XR0tTRWQv0b, gRLtTIWrU8I, O0OtT92V0X7, UjMtTq3mdGQ,
		fPNtTcY6g1t, LiStTVskdJU, PsmtTZD3AIk, xXKtThtMPKE, GZQtTeNPhSH
	};

	private static readonly StepOutParamDef OiAtTkcNfZR;

	private static readonly StepOutParamDef pb4tTG6oOao;

	private static readonly StepOutParamDef SHmtTsqsoZo;

	private static readonly StepOutParamDef JuYtTHojTkL;

	private static readonly StepOutParamDef fWJtT16q7P2;

	private static readonly StepOutParamDef myFtTba9nj7;

	private static readonly StepOutParamDef tX6tT6MODsP;

	private static readonly StepOutParamDef CngtTX4E0S4;

	private static readonly StepOutParamDef ziwtTm2ldaq;

	private static readonly StepOutParamDef GUAtTKH6O8h;

	private static readonly StepOutParamDef IvctTxfFlGg;

	private static readonly StepOutParamDef dk5tTrv5aRI;

	private static readonly StepOutParamDef JIctTpYkfIS;

	private static readonly StepOutParamDef wSVtTBcqNMU;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> puBtTQdMJLV = new List<StepOutParamDef>
	{
		OiAtTkcNfZR, pb4tTG6oOao, SHmtTsqsoZo, JuYtTHojTkL, fWJtT16q7P2, myFtTba9nj7, tX6tT6MODsP, CngtTX4E0S4, ziwtTm2ldaq, GUAtTKH6O8h,
		IvctTxfFlGg, dk5tTrv5aRI, JIctTpYkfIS, wSVtTBcqNMU
	};

	internal static y79XvEXVcj9PCimSMLg s1v9SRQiD7WmSrDyIiHU;

	public string Key => "sys:chromecontrol";

	public string Name => "浏览器控制";

	public IEnumerable<string> KeyWords => new string[4] { "llq", "chrome", "firefox", "edge" };

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return GBltTw4ZJOw;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.SoftInteraction;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return b3DtTtnbqtc;
		}
	}

	public string Description => "与Chrome/Edge/Firefox等浏览器通信，控制网页或浏览器。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return qUItTgCMXI7;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return RwmtTWdj9Ji;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return puBtTQdMJLV;
		}
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass104_0 _003C_003Ec__DisplayClass104_ = new _003C_003Ec__DisplayClass104_0();
		_003C_003Ec__DisplayClass104_.Ad1vicaKx8L = step;
		_003C_003Ec__DisplayClass104_.iyTviVH8nqX = context;
		_003C_003Ec__DisplayClass104_.EhSviZ25a4B = this;
		_003C_003Ec__DisplayClass104_.zIcvi98km15 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass104_.iyTviVH8nqX, _003C_003Ec__DisplayClass104_.Ad1vicaKx8L, _003C_003Ec__DisplayClass104_.zIcvi98km15, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass104_.lXJviq4qs51, (Action)null, (Action)null, GZQtTeNPhSH, OiAtTkcNfZR);
	}

	private void oDatoA0PXg1(int? nullable_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, int int_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(iDLtTYKuBxo, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(gRLtTIWrU8I, actionStep_0, actionExecuteContext_0);
		BrowserRespMessage<JToken> browserRespMessage = ChromeControl.ExecuteTabCommand(actionExecuteContext_0.Browser, nullable_0, "wait", new _003C_003Ef__AnonymousType10<string, string, int, string>(textParamValue, XActionHelper.GetTextParamValue(bjRtTupRsuP, actionStep_0, actionExecuteContext_0), int_0, textParamValue2), true, int_0, false, 0, false, actionExecuteContext_0.CancellationToken, null);
		if (!browserRespMessage.IsSuccess)
		{
			throw new InvalidDataException("等待事件失败！" + browserRespMessage.Message);
		}
	}

	private void geAtoOl5sFH(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, int int_0)
	{
		_003C_003Ec__DisplayClass106_0 _003C_003Ec__DisplayClass106_ = new _003C_003Ec__DisplayClass106_0();
		string textParamValue = XActionHelper.GetTextParamValue(oMetT8hq2Fl, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue;
		if (!(booleanParamValue = XActionHelper.GetBooleanParamValue(O0OtT92V0X7, actionStep_0, actionExecuteContext_0)) && XActionHelper.IsOutputParamSetted(wSVtTBcqNMU.Key, actionStep_0))
		{
			throw new Exception("需要设置等待操作完成才能返回数据。");
		}
		BrowserConnectionInfo obj = ChromeControl.GetConnectionInfo(actionExecuteContext_0.Browser, 0) ?? throw new Exception("未找到浏览器扩展连接");
		_003C_003Ec__DisplayClass106_.ATMviUHpp5i = null;
		if (obj.ManifestVersion == 3)
		{
			actionExecuteContext_0.ActionLogger.LogWarning("使用兼容模式运行后台脚本。浏览器：" + actionExecuteContext_0.Browser);
			_003C_003Ec__DisplayClass106_.ATMviUHpp5i = ChromeControl.RunBackgroundScriptForMV3(actionExecuteContext_0.Browser, textParamValue, booleanParamValue, int_0, 0, actionExecuteContext_0.CancellationToken);
		}
		else
		{
			_003C_003Ec__DisplayClass106_.ATMviUHpp5i = ChromeControl.RunBackgroundScript(actionExecuteContext_0.Browser, textParamValue, booleanParamValue, int_0);
		}
		if (_003C_003Ec__DisplayClass106_.ATMviUHpp5i != null)
		{
			XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass106_.qPGviFiCwod, actionStep_0, actionExecuteContext_0, xaction_0);
			if (!_003C_003Ec__DisplayClass106_.ATMviUHpp5i.IsSuccess)
			{
				throw new InvalidDataException("后台脚本返回失败！" + _003C_003Ec__DisplayClass106_.ATMviUHpp5i.Message + _003C_003Ec__DisplayClass106_.ATMviUHpp5i.Data);
			}
		}
		else if (booleanParamValue)
		{
			throw new InvalidDataException("返回的结果为空！");
		}
	}

	private void rP5toFwlQrq(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, int int_0)
	{
		_003C_003Ec__DisplayClass107_0 _003C_003Ec__DisplayClass107_ = new _003C_003Ec__DisplayClass107_0();
		string textParamValue = XActionHelper.GetTextParamValue(mBqtTaen5LM, actionStep_0, actionExecuteContext_0);
		int num;
		object obj = default(object);
		string textParamValue2 = default(string);
		bool booleanParamValue = default(bool);
		if ((ChromeControl.GetConnectionInfo(actionExecuteContext_0.Browser, 0) ?? throw new Exception("未找到浏览器扩展连接")).ManifestVersion != 3)
		{
			num = 0;
			if (s1v9SRQiD7WmSrDyIiHU != null)
			{
				int num2 = default(int);
				num = num2;
			}
		}
		else
		{
			object paramValue = XActionHelper.GetParamValue(HxbtT7MDfx0, actionStep_0, actionExecuteContext_0);
			obj = null;
			obj = ((!(paramValue is string text)) ? paramValue : (string.IsNullOrEmpty(text.Trim()) ? null : VariableHelper.ConvertToDict(text)));
			textParamValue2 = XActionHelper.GetTextParamValue(XR0tTRWQv0b, actionStep_0, actionExecuteContext_0);
			if (booleanParamValue = XActionHelper.GetBooleanParamValue(O0OtT92V0X7, actionStep_0, actionExecuteContext_0))
			{
				goto IL_00f0;
			}
			num = 1;
			if (s1v9SRQiD7WmSrDyIiHU == null)
			{
				goto IL_00d3;
			}
		}
		switch (num)
		{
		default:
			throw new Exception("后台脚本命令仅支持MV3版本浏览器扩展。");
		case 1:
			break;
		}
		goto IL_00d3;
		IL_00f0:
		_003C_003Ec__DisplayClass107_.WVtviiuSiIQ = ChromeControl.RunBackgroundCommand(actionExecuteContext_0.Browser, textParamValue, obj, booleanParamValue, int_0, 0, textParamValue2, actionExecuteContext_0.CancellationToken);
		if (_003C_003Ec__DisplayClass107_.WVtviiuSiIQ != null)
		{
			XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass107_.XTUvilnptBZ, actionStep_0, actionExecuteContext_0, xaction_0);
			if (!_003C_003Ec__DisplayClass107_.WVtviiuSiIQ.IsSuccess)
			{
				throw new InvalidDataException("后台脚本返回失败！" + _003C_003Ec__DisplayClass107_.WVtviiuSiIQ.Message + _003C_003Ec__DisplayClass107_.WVtviiuSiIQ.Data);
			}
		}
		else if (booleanParamValue)
		{
			throw new InvalidDataException("返回的结果为空！");
		}
		return;
		IL_00d3:
		if (XActionHelper.IsOutputParamSetted(wSVtTBcqNMU.Key, actionStep_0))
		{
			throw new Exception("需要设置等待操作完成才能返回数据。");
		}
		goto IL_00f0;
	}

	private string LCntoUKOQie(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(bjRtTupRsuP, actionStep_0, actionExecuteContext_0);
		if (ChromeControl.GetConnectionInfo(actionExecuteContext_0.Browser, 0).ManifestVersion == 3)
		{
			return textParamValue;
		}
		string textParamValue2 = XActionHelper.GetTextParamValue(cGxtTNIjTMl, actionStep_0, actionExecuteContext_0);
		textParamValue = zNqtolyFET2(textParamValue, textParamValue2);
		return hXCto3klK07(textParamValue);
	}

	private void TriggerEvent(int? tabId, ActionStep step, ActionExecuteContext context, XAction action, int timeoutMs, bool allFrames, int frameId)
	{
		_003C_003Ec__DisplayClass109_0 _003C_003Ec__DisplayClass109_ = new _003C_003Ec__DisplayClass109_0();
		string textParamValue = XActionHelper.GetTextParamValue(JoctTCWjclT, step, context);
		string text = LCntoUKOQie(context, step);
		string text2 = "";
		text2 = ((textParamValue == "click") ? (text + "[0].click();") : ((textParamValue == "change") ? (text + "[0].dispatchEvent( new Event('change') );") : ((!textParamValue.StartsWith("native.")) ? (text + ".trigger('" + textParamValue + "');") : (text + "[0].dispatchEvent( new Event('" + textParamValue.Substring("native.".Length) + "') );"))));
		_003C_003Ec__DisplayClass109_.j12vifVtap4 = ChromeControl.ExecuteTabScriptOrCommand(context.Browser, tabId, text2, "trigger_event", new _003C_003Ef__AnonymousType11<string, string, object>(text, textParamValue, null), true, timeoutMs, allFrames, frameId, false, context.CancellationToken);
		if (!_003C_003Ec__DisplayClass109_.j12vifVtap4.IsSuccess)
		{
			throw new InvalidOperationException(_003C_003Ec__DisplayClass109_.j12vifVtap4.Message);
		}
		XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass109_.vctvi3eHnst, step, context, action);
	}

	private static string zNqtolyFET2(string string_2, string string_3)
	{
		if (!string.IsNullOrEmpty(string_2))
		{
			switch (string_3)
			{
			default:
				if (string_3.Length != 0)
				{
					if (XP10M3Qi3YJRIM8PkbNX())
					{
						switch (0)
						{
						}
					}
					goto case null;
				}
				goto case "auto";
			case null:
				if (!(string_3 == "replaceBackslash"))
				{
					throw new InvalidOperationException("不支持此操作:" + string_3 + "，请升级Quicker版本。");
				}
				return string_2.Replace("\\", "\\\\");
			case "auto":
				if (string_2.Contains("\\") && string_2.Replace("\\\\", "__").Contains("\\"))
				{
					return string_2.Replace("\\", "\\\\");
				}
				return string_2;
			case "noFix":
				return string_2;
			}
		}
		return string_2;
	}

	private void knGtoi6AdLd(int? nullable_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, int int_0, bool bool_0, int int_1)
	{
		_003C_003Ec__DisplayClass111_0 _003C_003Ec__DisplayClass111_ = new _003C_003Ec__DisplayClass111_0();
		string text = LCntoUKOQie(actionExecuteContext_0, actionStep_0);
		string textParamValue = XActionHelper.GetTextParamValue(XgHtT01DqS5, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(G2HtTEtsAbH, actionStep_0, actionExecuteContext_0);
		string textParamValue3 = XActionHelper.GetTextParamValue(EmYtTPQR851, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass111_.QT3v3wC1ILl = ChromeControl.ExecuteTabScriptOrCommand(actionExecuteContext_0.Browser, nullable_0, rTPtoftfRk1(text, textParamValue, textParamValue2, textParamValue3), "update_element_info", new _003C_003Ef__AnonymousType12<string, string, string, string>(text, textParamValue, textParamValue2, textParamValue3), true, int_0, bool_0, int_1, false, actionExecuteContext_0.CancellationToken);
		if (!_003C_003Ec__DisplayClass111_.QT3v3wC1ILl.IsSuccess)
		{
			throw new InvalidOperationException(_003C_003Ec__DisplayClass111_.QT3v3wC1ILl.Message);
		}
		XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass111_.dWsvizGsi7A, actionStep_0, actionExecuteContext_0, xaction_0);
	}

	private static string hXCto3klK07(string string_2)
	{
		if (string_2.StartsWith("xpath:"))
		{
			return "$(_x('" + string_2.Substring("xpath:".Length).Replace("'", "\"") + "'))";
		}
		return "$('" + string_2 + "')";
	}

	private string rTPtoftfRk1(string string_2, string string_3, string string_4, string string_5)
	{
		string text = "\r\nfunction htmlDecode(input){\r\n  var e = document.createElement('textarea');\r\n  e.innerHTML = input;\r\n  // handle case of empty input\r\n  return e.childNodes.length === 0 ? '' : e.childNodes[0].nodeValue;\r\n}\r\n";
		string text2 = Uri.EscapeDataString(string_5);
		string text3 = (text2.IsEither("true", "false") ? text2 : ("decodeURIComponent(`" + text2 + "`)"));
		string text4 = "";
		switch (string_3)
		{
		default:
			throw new InvalidDataException("不支持的网页元素信息类型：" + string_3);
		case "InnerHtml":
			text4 = string_2 + ".html(decodeURIComponent(`" + text2 + "`));";
			text4 = text4 + "\r\n                        var input = " + string_2 + "[0];\r\n                        var event = new Event('change', { bubbles: true });\r\n                        input.dispatchEvent(event);";
			break;
		case "Property":
			text4 = string_2 + ".prop('" + string_4 + "'," + text3 + ");";
			text4 = text4 + "\r\n                        var input = " + string_2 + "[0];\r\n                        var event = new Event('change', { bubbles: true });\r\n                        input.dispatchEvent(event);";
			break;
		case "ArrayValue":
			text4 = "var txt = decodeURIComponent(`\\" + text2 + "`);var arr = txt.startsWith('[') ? JSON.parse(txt) : txt.split(/\\r?\\n|\\r/);";
			text4 = text4 + string_2 + ".val(arr);";
			text4 = text4 + "\r\n                        var input = " + string_2 + "[0];\r\n                        event = new Event('change', { bubbles: true });\r\n                        input.dispatchEvent(event);\r\n";
			if (s1v9SRQiD7WmSrDyIiHU == null)
			{
				switch (1)
				{
				case 2:
					goto IL_01a3;
				case 1:
					goto end_IL_0051;
				}
			}
			goto case "Attribute";
		case "Attribute":
			text4 = string_2 + ".attr('" + string_4 + "'," + text3 + ");";
			break;
		case "InnerText":
			goto IL_01a3;
		case "Value":
			{
				text4 = string_2 + ".val(decodeURIComponent(`" + text2 + "`));";
				text4 = text4 + "\r\nvar input = " + string_2 + ".get(0);\r\nif (input){\r\n    //console.log('input:',input);\r\n    var event = new Event('input', { bubbles: true });\r\n    var tracker = input._valueTracker;\r\n    if (tracker) {\r\n        tracker.setValue(lastValue);\r\n    }\r\n    input.dispatchEvent(event);\r\n    event = new Event('change', { bubbles: true });\r\n    input.dispatchEvent(event);\r\n}else{\r\n    //ignore\r\n    console.log('input not found');\r\n}\r\n";
				break;
			}
			IL_01a3:
			text4 = string_2 + ".text(decodeURIComponent(`" + text2 + "`));";
			text4 = text4 + "\r\n                        var input = " + string_2 + "[0];\r\n                        var event = new Event('change', { bubbles: true });\r\n                        input.dispatchEvent(event);";
			break;
			end_IL_0051:
			break;
		}
		return text + text4;
	}

	private void GetElementInfo(int? tabId, ActionStep step, ActionExecuteContext context, XAction action, int timeoutMs, bool allFrame, int frameId)
	{
		_003C_003Ec__DisplayClass114_0 _003C_003Ec__DisplayClass114_ = new _003C_003Ec__DisplayClass114_0();
		string text = LCntoUKOQie(context, step);
		string textParamValue = XActionHelper.GetTextParamValue(eYDtTJWL0PC, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(G2HtTEtsAbH, step, context);
		_003C_003Ec__DisplayClass114_.Yp9v3gA0nYw = ChromeControl.ExecuteTabScriptOrCommand(context.Browser, tabId, N4LtozBucER(text, textParamValue, textParamValue2), "get_element_info", new _003C_003Ef__AnonymousType13<string, string, string>(text, textParamValue, textParamValue2), true, timeoutMs, allFrame, frameId, false, context.CancellationToken);
		if (!_003C_003Ec__DisplayClass114_.Yp9v3gA0nYw.IsSuccess)
		{
			throw new InvalidOperationException(_003C_003Ec__DisplayClass114_.Yp9v3gA0nYw.Message);
		}
		XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass114_.k4sv3tklLxO, step, context, action);
		if (_003C_003Ec__DisplayClass114_.Yp9v3gA0nYw.Data is JArray source)
		{
			_003C_003Ec__DisplayClass114_1 _003C_003Ec__DisplayClass114_2 = new _003C_003Ec__DisplayClass114_1();
			JToken jToken = source.FirstOrDefault<JToken>(_003C_003Ec.HmvviEwVG4W ?? (_003C_003Ec.HmvviEwVG4W = _003C_003Ec.cEYviPW9yPQ.QiTvi2LKOyT));
			if (jToken != null && jToken.Any())
			{
				_003C_003Ec__DisplayClass114_2.MCpv3SdP2Pd = jToken as JArray;
				if (_003C_003Ec__DisplayClass114_2.MCpv3SdP2Pd == null)
				{
					throw new InvalidDataException("结果值类型不是数组！");
				}
				if (!_003C_003Ec__DisplayClass114_2.MCpv3SdP2Pd.Any())
				{
					XActionHelper.OutputResultIfNeeded(CngtTX4E0S4, _003C_003Ec.XZ0viaHU6jq ?? (_003C_003Ec.XZ0viaHU6jq = _003C_003Ec.cEYviPW9yPQ.UiRviJZ7X6t), step, context, action);
					XActionHelper.OutputResultIfNeeded(ziwtTm2ldaq, _003C_003Ec.vXovi7tMaOd ?? (_003C_003Ec.vXovi7tMaOd = _003C_003Ec.cEYviPW9yPQ.sLwvi0WPs5g), step, context, action);
					throw new InvalidDataException("返回的结果为空！");
				}
				XActionHelper.OutputResultIfNeeded(CngtTX4E0S4, _003C_003Ec__DisplayClass114_2.agdv3LmpRx5, step, context, action);
				XActionHelper.OutputResultIfNeeded(ziwtTm2ldaq, _003C_003Ec__DisplayClass114_2.kqDv3velBeB, step, context, action);
				return;
			}
			XActionHelper.OutputResultIfNeeded(CngtTX4E0S4, _003C_003Ec.z1SviyTF28r ?? (_003C_003Ec.z1SviyTF28r = _003C_003Ec.cEYviPW9yPQ.vPEviuwktCy), step, context, action);
			XActionHelper.OutputResultIfNeeded(ziwtTm2ldaq, _003C_003Ec.bpQvi8eSCiX ?? (_003C_003Ec.bpQvi8eSCiX = _003C_003Ec.cEYviPW9yPQ.xBlviNwnTJd), step, context, action);
			throw new InvalidDataException("返回的结果为空！");
		}
		throw new InvalidDataException("返回的结果不是数组。");
	}

	private string N4LtozBucER(string string_2, string string_3, string string_4)
	{
		return string_3 switch
		{
			"OuterHtml" => string_2 + ".map(function(i,v){ return this.outerHTML; }).toArray();", 
			"InnerHtml" => string_2 + ".map(function(i,v){ return $(this).html(); }).toArray();", 
			"InnerText" => string_2 + ".map(function(i,v){ return $(this).text(); }).toArray();", 
			"Property" => string_2 + ".map(function(i,v){ return $(this).prop('" + string_4 + "'); }).toArray();", 
			"Attribute" => string_2 + ".map(function(i,v){ return $(this).attr('" + string_4 + "'); }).toArray();", 
			"Value" => string_2 + ".map(function(i,v){ return $(this).val(); }).toArray();", 
			_ => throw new InvalidDataException("不支持的网页元素信息类型：" + string_3), 
		};
	}

	private void OpenUrl(ActionStep step, ActionExecuteContext context, XAction action, long timeoutMs)
	{
        object windowInfo = default;
        _003C_003Ec__DisplayClass116_1 _003C_003Ec__DisplayClass116_2 = default;
        bool flag = default;
        long num3 = default;
		_003C_003Ec__DisplayClass116_0 _003C_003Ec__DisplayClass116_ = new _003C_003Ec__DisplayClass116_0();
		string textParamValue = XActionHelper.GetTextParamValue(UL5tTSVaaiB, step, context);
		string text = XActionHelper.GetTextParamValue(ujHtTvGWr0x, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(GqttTy0Z4QG, step, context);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(O0OtT92V0X7, step, context);
		int num = 1;
		if (s1v9SRQiD7WmSrDyIiHU == null)
		{
			goto IL_0048;
		}
		goto IL_00b8;
		IL_0048:
		if (!text.Contains(":"))
		{
			text = "https://" + text.TrimStart();
			context.ActionLogger.LogWarning("网址不完整。已自动增加https://，结果网址：" + text);
		}
		windowInfo = null;
		if (!string.IsNullOrWhiteSpace(textParamValue2))
		{
			windowInfo = JsonConvert.DeserializeObject(textParamValue2);
		}
		if (!AppState.vjAt7Seco0Y().m8ItGmyxjPV(context.Browser))
		{
			num = 0;
			if (s1v9SRQiD7WmSrDyIiHU != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00b8;
		}
		goto IL_012e;
		IL_035c:
		flag = default(bool);
		if (!flag)
		{
			throw new InvalidDataException($"等待网页加载完成超时({timeoutMs}ms)。");
		}
		return;
		IL_034c:
		Thread.Sleep(250);
		goto IL_030a;
		IL_02e0:
		BrowserRespMessage<JToken> tabInfo = default(BrowserRespMessage<JToken>);
		if (tabInfo.Data["status"]?.ToObject<string>() == "complete")
		{
			flag = true;
		}
		goto IL_034c;
		IL_012e:
		if (!AppState.vjAt7Seco0Y().m8ItGmyxjPV(context.Browser))
		{
			throw new InvalidOperationException("浏览器扩展未连接到Quicker。");
		}
		ChromeCommandMessage<object> msg = new ChromeCommandMessage<object>
		{
			Cmd = "OpenUrl",
			WaitComplete = booleanParamValue,
			TimeoutMs = (int)timeoutMs,
			Data = new _003C_003Ef__AnonymousType14<string, string, object>(text, textParamValue, windowInfo)
		};
		_003C_003Ec__DisplayClass116_.qnqv3u2ugiZ = ChromeControl.SendMessageToBrowser(msg, context.Browser, true, (int)timeoutMs, 0, context.CancellationToken);
		if (!_003C_003Ec__DisplayClass116_.qnqv3u2ugiZ.IsSuccess)
		{
			throw new InvalidDataException("Chrome插件返回失败：" + _003C_003Ec__DisplayClass116_.qnqv3u2ugiZ.Message);
		}
		_003C_003Ec__DisplayClass116_2 = new _003C_003Ec__DisplayClass116_1();
		_003C_003Ec__DisplayClass116_2.MVmv308Z0Wb = _003C_003Ec__DisplayClass116_.qnqv3u2ugiZ.Data["windowId"]?.ToObject<int>();
		_003C_003Ec__DisplayClass116_2.wTwv3CZYLcn = _003C_003Ec__DisplayClass116_.qnqv3u2ugiZ.Data["tabId"]?.ToObject<int>();
		if (_003C_003Ec__DisplayClass116_2.MVmv308Z0Wb.HasValue && _003C_003Ec__DisplayClass116_2.wTwv3CZYLcn.HasValue)
		{
			XActionHelper.OutputResultIfNeeded(SHmtTsqsoZo, _003C_003Ec__DisplayClass116_2.wODv3NTRgPu, step, context, action);
			XActionHelper.OutputResultIfNeeded(pb4tTG6oOao, _003C_003Ec__DisplayClass116_2.ojjv3JM7X0Y, step, context, action);
			XActionHelper.OutputResultIfNeeded(wSVtTBcqNMU, _003C_003Ec__DisplayClass116_.AGyv32sMW5Y, step, context, action);
			int num2 = 2;
			goto IL_02ae;
		}
		throw new InvalidDataException();
		IL_02ae:
		num3 = default(long);
		if (_003C_003Ec__DisplayClass116_2.wTwv3CZYLcn > 0 && booleanParamValue)
		{
			num3 = AppHelper.fLiLTj0x4QY() + timeoutMs;
			flag = false;
			goto IL_030a;
		}
		return;
		IL_030a:
		if (AppHelper.fLiLTj0x4QY() < num3 && !flag && !context.IsShouldStopAction())
		{
			tabInfo = GetTabInfo(_003C_003Ec__DisplayClass116_2.wTwv3CZYLcn.Value, context, 1000, context.CancellationToken);
			if (tabInfo.IsSuccess)
			{
				goto IL_02e0;
			}
			goto IL_034c;
		}
		goto IL_035c;
		IL_00b8:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00d2;
		case 2:
			goto IL_02ae;
		case 4:
			goto IL_02e0;
		case 3:
			goto IL_035c;
		}
		goto IL_0048;
		IL_00d2:
		try
		{
			Process.Start(context.Browser);
		}
		catch (Exception ex)
		{
			throw new Exception("未能成功启动浏览器" + context.Browser + "," + ex.Message);
		}
		for (int i = 0; i < 40; i++)
		{
			if (AppState.vjAt7Seco0Y().m8ItGmyxjPV(context.Browser))
			{
				break;
			}
			Thread.Sleep(100);
		}
		goto IL_012e;
	}

	public static BrowserRespMessage<JToken> GetTabInfo(int? tabId, ActionExecuteContext context, int timeoutMs, CancellationToken? cancellationToken)
	{
		return GetTabInfo(tabId, context.Browser, timeoutMs, context.CancellationToken);
	}

	public static BrowserRespMessage<JToken> GetTabInfo(int? tabId, string browser, int timeoutMs, CancellationToken? cancellationToken)
	{
		return ChromeControl.SendMessageToBrowser(new ChromeCommandMessage<object>
		{
			Cmd = "GetTabInfo",
			TabId = tabId
		}, browser, true, timeoutMs, 0, cancellationToken);
	}

	public static BrowserRespMessage<JToken> ActivateTab(int? tabId, string urlPattern, ActionExecuteContext context, int timeoutMs, CancellationToken? cancellationToken)
	{
		return ChromeControl.RunBackgroundCommand(context.Browser, "qk_activate_tab", new _003C_003Ef__AnonymousType15<int?, string>(tabId, urlPattern), true, timeoutMs, 0, null, cancellationToken);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(tAetTLuHgoa, step) + "  " + XActionHelper.GetParamDirectValue(bjRtTupRsuP, step) + " ";
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	static y79XvEXVcj9PCimSMLg()
	{
		tAetTLuHgoa = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("OpenUrl", "打开网址"),
				new SelectionItem("WaitTabComplete", "等待加载完成"),
				new SelectionItem("ActivateTab", "激活标签页"),
				new SelectionItem("CloseTab", "关闭标签页"),
				new SelectionItem("GetTabInfo", "获得标签页信息"),
				new SelectionItem("RunScript", "对标签页运行脚本 (浏览器需开启开发者模式)"),
				new SelectionItem("PickElement", "选择元素 (返回CSS选择器)"),
				new SelectionItem("GetElementInfo", "获取元素信息"),
				new SelectionItem("UpdateElement", "更新元素信息"),
				new SelectionItem("TriggerEvent", "触发事件"),
				new SelectionItem("Wait", "等待网页变化 (MV3版扩展)"),
				new SelectionItem("SetBrowser", "浏览器：设置连接的浏览器"),
				new SelectionItem("BackgroundScript", "浏览器：运行后台脚本 (MV2版扩展，将过期)"),
				new SelectionItem("BackgroundCommand", "浏览器：运行后台命令 (MV3版扩展)")
			},
			IsControlField = true
		};
		ujHtTvGWr0x = new StepInParamDef
		{
			Key = "url",
			Name = "网址",
			DefaultValue = "",
			Description = "要打开的网页地址。激活标签页时有多种使用方法，请参考模块文档。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "OpenUrl", "ActivateTab" }
		};
		UL5tTSVaaiB = new StepInParamDef
		{
			Key = "windowId",
			Name = "窗口Id",
			Description = "使用哪个窗口打开网址。可以使用选项或指定窗口id。",
			IsRequired = true,
			IsMultiLine = false,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Current", "当前窗口"),
				new SelectionItem("New", "新窗口")
			},
			IsControlField = false,
			ValidForList = new List<string> { "OpenUrl" }
		};
		Im1tT2athjL = new StepInParamDef
		{
			Key = "tabId",
			Name = "标签页Id",
			Description = "留空表示当前活动标签页。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsControlField = false,
			ValidForList = new List<string> { "GetTabInfo", "CloseTab", "RunScript", "WaitTabComplete", "GetElementInfo", "UpdateElement", "TriggerEvent", "PickElement", "Wait", "ActivateTab" }
		};
		bjRtTupRsuP = new StepInParamDef
		{
			Key = "selector",
			Name = "选择器",
			Description = "要操作的元素选择器，请参考文档。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsControlField = false,
			ValidForList = new List<string> { "GetElementInfo", "UpdateElement", "TriggerEvent", "Wait" },
			TextTools = new List<TextToolType> { TextToolType.SelectWebElementSelector }
		};
		cGxtTNIjTMl = new StepInParamDef
		{
			Key = "fixSelector",
			Name = "修正选择器文本",
			Description = "仅MV2版本扩展有效。",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "auto",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("auto", "自动"),
				new SelectionItem("noFix", "不修正"),
				new SelectionItem("replaceBackslash", "\\替换为\\\\")
			},
			IsControlField = false,
			AllowInput = false,
			ValidForList = new List<string> { "GetElementInfo", "UpdateElement", "TriggerEvent" },
			IsAdvanced = true
		};
		eYDtTJWL0PC = new StepInParamDef
		{
			Key = "elementInfo",
			Name = "元素信息类型",
			Description = "",
			IsRequired = true,
			IsMultiLine = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "Value",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Value", "值"),
				new SelectionItem("Attribute", "某Attribute属性"),
				new SelectionItem("Property", "某Property属性"),
				new SelectionItem("InnerText", "innerText 内部文本"),
				new SelectionItem("InnerHtml", "innerHTML 内部HTML"),
				new SelectionItem("OuterHtml", "outerHTML 全部HTML")
			},
			IsControlField = false,
			AllowInput = false,
			ValidForList = new List<string> { "GetElementInfo" }
		};
		XgHtT01DqS5 = new StepInParamDef
		{
			Key = "updateElementInfo",
			Name = "元素信息类型",
			Description = "",
			IsRequired = true,
			IsMultiLine = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "Value",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Value", "值"),
				new SelectionItem("ArrayValue", "数组值"),
				new SelectionItem("Attribute", "某Attribute属性"),
				new SelectionItem("Property", "某Property属性"),
				new SelectionItem("InnerText", "InnerText 内部文本"),
				new SelectionItem("InnerHtml", "InnerHtml 内部HTML")
			},
			IsControlField = false,
			AllowInput = false,
			ValidForList = new List<string> { "UpdateElement" }
		};
		JoctTCWjclT = new StepInParamDef
		{
			Key = "triggerEventType",
			Name = "触发事件类型",
			Description = "",
			IsRequired = true,
			IsMultiLine = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "click",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("click", "点击"),
				new SelectionItem("submit", "提交表单"),
				new SelectionItem("focus", "获得焦点"),
				new SelectionItem("blur", "失去焦点"),
				new SelectionItem("dblclick", "双击"),
				new SelectionItem("change", "值改变")
			},
			IsControlField = false,
			ValidForList = new List<string> { "TriggerEvent" }
		};
		EmYtTPQR851 = new StepInParamDef
		{
			Key = "updateElementValue",
			Name = "值",
			Description = "要更新的元素信息值",
			IsRequired = true,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "UpdateElement" }
		};
		G2HtTEtsAbH = new StepInParamDef
		{
			Key = "attrName",
			Name = "属性名",
			Description = "设置或读取Attribute属性/Property属性时，置顶Attribute或Property的名称。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsControlField = false,
			ValidForList = new List<string> { "GetElementInfo", "UpdateElement" },
			VisibleExpression = "$= updateElementInfo == \"Attribute\" || updateElementInfo == \"Property\""
		};
		GqttTy0Z4QG = new StepInParamDef
		{
			Key = "windowInfo",
			Name = "窗口/标签参数",
			Description = "创建窗口或标签时的额外参数（json格式）。",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "OpenUrl" }
		};
		oMetT8hq2Fl = new StepInParamDef
		{
			Key = "script",
			Name = "脚本内容",
			Description = "",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "//.js \r\n",
			ValidForList = new List<string> { "RunScript", "BackgroundScript" },
			DefaultHighlightType = "JavaScript"
		};
		mBqtTaen5LM = new StepInParamDef
		{
			Key = "command",
			Name = "命令",
			Description = "请参考模块文档获取支持的命令列表。需MV3版浏览器扩展与Chrome135+版本。",
			IsRequired = false,
			IsMultiLine = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "BackgroundCommand" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("api_bookmarks_getTree", "API: 获取书签树"),
				new SelectionItem("api_bookmarks_get", "API: 获取指定ID的书签"),
				new SelectionItem("api_bookmarks_getChildren", "API: 获取指定ID的书签的子书签"),
				new SelectionItem("api_bookmarks_getRecent", "API: 获取最近添加的书签"),
				new SelectionItem("api_bookmarks_search", "API: 搜索书签"),
				new SelectionItem("api_bookmarks_create", "API: 创建书签"),
				new SelectionItem("api_bookmarks_move", "API: 移动书签"),
				new SelectionItem("api_bookmarks_update", "API: 更新书签"),
				new SelectionItem("api_bookmarks_remove", "API: 删除书签"),
				new SelectionItem("api_bookmarks_removeTree", "API: 删除书签文件夹及其内容"),
				new SelectionItem("api_browsingData_remove", "API: 删除浏览数据"),
				new SelectionItem("api_browsingData_removeAppcache", "API: 删除应用缓存"),
				new SelectionItem("api_browsingData_removeCache", "API: 删除缓存"),
				new SelectionItem("api_browsingData_removeCookies", "API: 删除Cookie"),
				new SelectionItem("api_browsingData_removeDownloads", "API: 删除下载记录"),
				new SelectionItem("api_browsingData_removeFileSystems", "API: 删除文件系统"),
				new SelectionItem("api_browsingData_removeFormData", "API: 删除表单数据"),
				new SelectionItem("api_browsingData_removeHistory", "API: 删除历史记录"),
				new SelectionItem("api_browsingData_removeIndexedDB", "API: 删除IndexedDB"),
				new SelectionItem("api_browsingData_removeLocalStorage", "API: 删除本地存储"),
				new SelectionItem("api_browsingData_removePasswords", "API: 删除密码"),
				new SelectionItem("api_browsingData_removePluginData", "API: 删除插件数据"),
				new SelectionItem("api_browsingData_removeServiceWorkers", "API: 删除Service Workers"),
				new SelectionItem("api_browsingData_removeWebSQL", "API: 删除WebSQL"),
				new SelectionItem("api_browsingData_settings", "API: 浏览数据设置"),
				new SelectionItem("api_cookies_get", "API: 获取Cookie"),
				new SelectionItem("api_cookies_getAll", "API: 获取所有Cookie"),
				new SelectionItem("api_cookies_set", "API: 设置Cookie"),
				new SelectionItem("api_cookies_remove", "API: 删除Cookie"),
				new SelectionItem("api_cookies_getAllCookieStores", "API: 获取所有Cookie存储"),
				new SelectionItem("api_debugger_attach", "API: 附加调试器"),
				new SelectionItem("api_debugger_detach", "API: 分离调试器"),
				new SelectionItem("api_debugger_sendCommand", "API: 发送调试命令"),
				new SelectionItem("api_debugger_getTargets", "API: 获取调试目标"),
				new SelectionItem("api_downloads_download", "API: 下载文件"),
				new SelectionItem("api_downloads_search", "API: 搜索下载"),
				new SelectionItem("api_downloads_pause", "API: 暂停下载"),
				new SelectionItem("api_downloads_resume", "API: 恢复下载"),
				new SelectionItem("api_downloads_cancel", "API: 取消下载"),
				new SelectionItem("api_downloads_erase", "API: 清除下载记录"),
				new SelectionItem("api_downloads_removeFile", "API: 删除下载文件"),
				new SelectionItem("api_downloads_open", "API: 打开下载文件"),
				new SelectionItem("api_downloads_show", "API: 显示下载文件"),
				new SelectionItem("api_downloads_showDefaultFolder", "API: 显示默认下载文件夹"),
				new SelectionItem("api_downloads_getFileIcon", "API: 获取文件图标"),
				new SelectionItem("api_downloads_setShelfEnabled", "API: 设置下载栏启用状态"),
				new SelectionItem("api_history_search", "API: 搜索历史记录"),
				new SelectionItem("api_history_getVisits", "API: 获取访问记录"),
				new SelectionItem("api_history_addUrl", "API: 添加URL到历史记录"),
				new SelectionItem("api_history_deleteUrl", "API: 从历史记录删除URL"),
				new SelectionItem("api_history_deleteRange", "API: 删除时间范围内的历史记录"),
				new SelectionItem("api_history_deleteAll", "API: 删除所有历史记录"),
				new SelectionItem("api_pageCapture_saveAsMHTML", "API: 保存为MHTML"),
				new SelectionItem("api_readingList_add", "API: 添加到阅读列表"),
				new SelectionItem("api_readingList_query", "API: 查询阅读列表条目"),
				new SelectionItem("api_readingList_remove", "API: 从阅读列表移除"),
				new SelectionItem("api_readingList_update", "API: 更新阅读列表条目"),
				new SelectionItem("api_tabGroups_get", "API: 获取标签组"),
				new SelectionItem("api_tabGroups_update", "API: 更新标签组"),
				new SelectionItem("api_tabGroups_move", "API: 移动标签组"),
				new SelectionItem("api_tabGroups_query", "API: 查询标签组"),
				new SelectionItem("api_tabs_captureVisibleTab", "API: 捕获可见标签页"),
				new SelectionItem("api_tabs_create", "API: 创建标签页"),
				new SelectionItem("api_tabs_detectLanguage", "API: 检测标签页语言"),
				new SelectionItem("api_tabs_discard", "API: 丢弃标签页"),
				new SelectionItem("api_tabs_duplicate", "API: 复制标签页"),
				new SelectionItem("api_tabs_get", "API: 获取标签页"),
				new SelectionItem("api_tabs_getCurrent", "API: 获取当前标签页"),
				new SelectionItem("api_tabs_getZoom", "API: 获取缩放级别"),
				new SelectionItem("api_tabs_getZoomSettings", "API: 获取缩放设置"),
				new SelectionItem("api_tabs_goBack", "API: 后退"),
				new SelectionItem("api_tabs_goForward", "API: 前进"),
				new SelectionItem("api_tabs_group", "API: 组合标签页"),
				new SelectionItem("api_tabs_highlight", "API: 高亮标签页"),
				new SelectionItem("api_tabs_move", "API: 移动标签页"),
				new SelectionItem("api_tabs_query", "API: 查询标签页"),
				new SelectionItem("api_tabs_reload", "API: 重新加载标签页"),
				new SelectionItem("api_tabs_remove", "API: 删除标签页"),
				new SelectionItem("api_tabs_sendMessage", "API: 发送消息到标签页"),
				new SelectionItem("api_tabs_setZoom", "API: 设置缩放级别"),
				new SelectionItem("api_tabs_setZoomSettings", "API: 设置缩放设置"),
				new SelectionItem("api_tabs_toggleMuteState", "API: 切换静音状态"),
				new SelectionItem("api_tabs_ungroup", "API: 取消标签页组合"),
				new SelectionItem("api_tabs_update", "API: 更新标签页"),
				new SelectionItem("api_sessions_getRecentlyClosed", "API: 获取最近关闭的标签页和窗口"),
				new SelectionItem("api_sessions_getDevices", "API: 获取连接的设备及其会话信息"),
				new SelectionItem("api_sessions_restore", "API: 恢复已关闭的标签页或窗口"),
				new SelectionItem("api_tts_speak", "API: 朗读文本"),
				new SelectionItem("api_tts_stop", "API: 停止朗读"),
				new SelectionItem("api_tts_pause", "API: 暂停朗读"),
				new SelectionItem("api_tts_resume", "API: 恢复朗读"),
				new SelectionItem("api_tts_isSpeaking", "API: 是否正在朗读"),
				new SelectionItem("api_tts_getVoices", "API: 获取语音列表"),
				new SelectionItem("api_windows_create", "API: 创建窗口"),
				new SelectionItem("api_windows_get", "API: 获取窗口"),
				new SelectionItem("api_windows_getAll", "API: 获取所有窗口"),
				new SelectionItem("api_windows_getCurrent", "API: 获取当前窗口"),
				new SelectionItem("api_windows_getLastFocused", "API: 获取最后聚焦的窗口"),
				new SelectionItem("api_windows_remove", "API: 删除窗口"),
				new SelectionItem("api_windows_update", "API: 更新窗口"),
				new SelectionItem("scripts_closeOtherTabs", "脚本: 关闭其他标签页"),
				new SelectionItem("scripts_closeLeftTabs", "脚本: 关闭左侧标签页"),
				new SelectionItem("scripts_closeRightTabs", "脚本: 关闭右侧标签页"),
				new SelectionItem("scripts_closeDuplicateTabs", "脚本: 关闭重复标签页"),
				new SelectionItem("scripts_switchToLeftTab", "脚本: 切换到左侧标签页"),
				new SelectionItem("scripts_switchToRightTab", "脚本: 切换到右侧标签页"),
				new SelectionItem("scripts_switchToFirstTab", "脚本: 切换到第一个标签页"),
				new SelectionItem("scripts_switchToLastTab", "脚本: 切换到最后一个标签页"),
				new SelectionItem("scripts_moveTabToStart", "脚本: 移动标签页到开头"),
				new SelectionItem("scripts_moveTabToEnd", "脚本: 移动标签页到末尾"),
				new SelectionItem("scripts_moveTabRight", "脚本: 向右移动标签页"),
				new SelectionItem("scripts_moveTabLeft", "脚本: 向左移动标签页"),
				new SelectionItem("scripts_toggleTabMute", "脚本: 切换标签页静音状态"),
				new SelectionItem("scripts_toggleTabPin", "脚本: 切换标签页固定状态"),
				new SelectionItem("scripts_pinCurrentTab", "脚本: 固定当前标签页"),
				new SelectionItem("scripts_addBookmarkForCurrentTab", "脚本: 为当前标签页添加书签"),
				new SelectionItem("scripts_removeBookmarkForCurrentTab", "脚本: 删除当前标签页的书签"),
				new SelectionItem("scripts_goToParentDirectory", "脚本: 转到父目录"),
				new SelectionItem("scripts_scrollUp", "脚本: 向上滚动"),
				new SelectionItem("scripts_scrollDown", "脚本: 向下滚动"),
				new SelectionItem("scripts_scrollToTop", "脚本: 滚动到顶部"),
				new SelectionItem("scripts_scrollToBottom", "脚本: 滚动到底部"),
				new SelectionItem("scripts_scrollLeft", "脚本: 向左滚动"),
				new SelectionItem("scripts_scrollRight", "脚本: 向右滚动"),
				new SelectionItem("scripts_reloadTab", "脚本: 重新加载标签页"),
				new SelectionItem("scripts_forceReloadTab", "脚本: 强制重新加载标签页"),
				new SelectionItem("scripts_reloadAllTabs", "脚本: 重新加载所有标签页"),
				new SelectionItem("scripts_reopenClosedTab", "脚本: 重新打开关闭的标签页"),
				new SelectionItem("scripts_createNewTab", "脚本: 创建新标签页"),
				new SelectionItem("scripts_duplicateCurrentTab", "脚本: 复制当前标签页"),
				new SelectionItem("scripts_detachCurrentTab", "脚本: 分离当前标签页"),
				new SelectionItem("scripts_createNewWindow", "脚本: 创建新窗口"),
				new SelectionItem("scripts_createNewIncognitoWindow", "脚本: 创建新隐身窗口"),
				new SelectionItem("scripts_createNewWindowWithUrls", "脚本: 使用URL创建新窗口"),
				new SelectionItem("scripts_closeOtherWindows", "脚本: 关闭其他窗口"),
				new SelectionItem("scripts_mergeAllWindows", "脚本: 合并所有窗口"),
				new SelectionItem("scripts_closeLastFocusedWindow", "脚本: 关闭最后聚焦的窗口"),
				new SelectionItem("scripts_closeAllWindows", "脚本: 关闭所有窗口"),
				new SelectionItem("scripts_toggleFullscreen", "脚本: 切换全屏模式"),
				new SelectionItem("scripts_closeCurrentTabAndActivateLeft", "脚本: 关闭当前标签页并激活左侧"),
				new SelectionItem("scripts_openCurrentTabInIncognito", "脚本: 在隐身模式打开当前标签页"),
				new SelectionItem("scripts_pageZoomIn", "脚本: 页面放大"),
				new SelectionItem("scripts_pageZoomOut", "脚本: 页面缩小"),
				new SelectionItem("scripts_openDownloadsFolder", "脚本: 打开下载文件夹"),
				new SelectionItem("scripts_showLastDownloadedFile", "脚本: 显示最后下载的文件"),
				new SelectionItem("scripts_openHistoryPage", "脚本: 打开历史记录页面"),
				new SelectionItem("scripts_openDownloadsPage", "脚本: 打开下载页面"),
				new SelectionItem("scripts_openExtensionsPage", "脚本: 打开扩展页面"),
				new SelectionItem("scripts_openSettingsPage", "脚本: 打开设置页面"),
				new SelectionItem("scripts_openBookmarksPage", "脚本: 打开书签页面"),
				new SelectionItem("scripts_openFlagsPage", "脚本: 打开实验功能页面"),
				new SelectionItem("scripts_openAboutPage", "脚本: 打开关于页面"),
				new SelectionItem("scripts_openVersionPage", "脚本: 打开版本页面"),
				new SelectionItem("scripts_openBlankPage", "脚本: 打开空白页面"),
				new SelectionItem("scripts_groupTabsByDomain", "脚本: 按域名分组标签页"),
				new SelectionItem("scripts_dismissGroup", "脚本: 解散当前标签页所属分组"),
				new SelectionItem("scripts_dismissAllGroupsInCurrentWindow", "脚本: 解散当前窗口的所有分组"),
				new SelectionItem("scripts_moveSameDomainTabsToCurrentWindow", "脚本: 将相同域名网页移动到当前窗口"),
				new SelectionItem("scripts_moveSameDomainTabsToNewWindow", "脚本: 将相同域名网页移动到新建窗口"),
				new SelectionItem("scripts_createOrRestoreGroup", "脚本: 创建或恢复分组"),
				new SelectionItem("scripts_captureVisibleTab", "脚本: 截图可见标签页视口"),
				new SelectionItem("scripts_captureSpecificTabView", "脚本: 截图特定标签页视口"),
				new SelectionItem("scripts_captureElement", "脚本: 截图指定元素"),
				new SelectionItem("scripts_captureFullPage", "脚本: 截图整页")
			}
		};
		HxbtT7MDfx0 = new StepInParamDef
		{
			Key = "commandParams",
			Name = "命令参数",
			Description = "后台脚本命令的参数。每个命令参数不同，详情请参考模块文档。",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Object,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "BackgroundCommand" },
			DefaultHighlightType = "JavaScript"
		};
		XR0tTRWQv0b = new StepInParamDef
		{
			Key = "valueFilter",
			Name = "返回值过滤器",
			Description = "用于从API返回的结果中提取单个属性。格式为属性名，多个时使用分号隔开。",
			IsRequired = false,
			IsMultiLine = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "BackgroundCommand" },
			DefaultHighlightType = "JavaScript"
		};
		UjMtTq3mdGQ = new StepInParamDef
		{
			Key = "timeoutMs",
			Name = "超时时间(ms)",
			DefaultValue = 3000,
			Description = "超时等待时间，毫秒数",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string>
			{
				"OpenUrl", "WaitTabComplete", "BackgroundScript", "GetTabInfo", "RunScript", "GetElementInfo", "UpdateElement", "TriggerEvent", "PickElement", "BackgroundCommand",
				"Wait"
			},
			IsAdvanced = false
		};
		fPNtTcY6g1t = new StepInParamDef
		{
			Key = "frame",
			Name = "运行脚本的框架",
			DefaultValue = "all",
			Description = "all:所有框架，0：顶层框架，其它数字：框架id",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "RunScript", "GetElementInfo", "UpdateElement", "TriggerEvent" },
			IsAdvanced = false,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("all", "全部框架"),
				new SelectionItem("0", "顶层框架")
			}
		};
		LiStTVskdJU = new StepInParamDef
		{
			Key = "executionWorld",
			Name = "执行环境",
			DefaultValue = "",
			Description = "自定义脚本的执行环境(ExecutionWorld)，默认为USER_SCRIPT。MAIN表示网页自身的执行环境。仅MV3版本扩展支持。",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "RunScript" },
			IsAdvanced = false,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("USER_SCRIPT", "USER_SCRIPT"),
				new SelectionItem("MAIN", "MAIN")
			}
		};
		PsmtTZD3AIk = new StepInParamDef
		{
			Key = "waitManualReturn",
			Name = "从脚本手动返回数据",
			DefaultValue = false,
			Description = "在脚本中使用sendReplyToQuicker函数手动返回数据",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "RunScript" }
		};
		O0OtT92V0X7 = new StepInParamDef
		{
			Key = "waitComplete",
			Name = "等待操作完成或返回数据",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "OpenUrl", "BackgroundScript", "BackgroundCommand" }
		};
		xXKtThtMPKE = new StepInParamDef
		{
			Key = "browser",
			Name = "浏览器",
			Description = "设置本动作连接的浏览器进程名（需安装Quicker浏览器扩展）",
			IsRequired = true,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "auto",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("auto", "自动"),
				new SelectionItem("chrome", "谷歌Chrome"),
				new SelectionItem("msedge", "微软Edge"),
				new SelectionItem("firefox", "Firefox"),
				new SelectionItem("vivaldi")
			},
			IsControlField = false,
			AllowInput = false,
			ValidForList = new List<string> { "SetBrowser" }
		};
		GZQtTeNPhSH = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		iDLtTYKuBxo = new StepInParamDef
		{
			Key = "waitEventType",
			Name = "事件类型",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("elementExists", "元素存在"),
				new SelectionItem("elementNotExists", "元素不存在"),
				new SelectionItem("elementVisible", "元素在网页可见"),
				new SelectionItem("elementNotVisible", "元素在网页不可见"),
				new SelectionItem("elementClickable", "元素可点击"),
				new SelectionItem("elementNotClickable", "元素不可点击"),
				new SelectionItem("textContains", "包含文本"),
				new SelectionItem("textNotContains", "不包含文本"),
				new SelectionItem("textMatches", "文本匹配表达式"),
				new SelectionItem("textNotMatches", "文本不匹配表达式"),
				new SelectionItem("urlMatches", "网址匹配表达式(PWA应用)"),
				new SelectionItem("urlNotMatches", "网址不匹配表达式(PWA应用)"),
				new SelectionItem("titleMatches", "标题匹配表达式(PWA应用)"),
				new SelectionItem("titleNotMatches", "标题不匹配表达式(PWA应用)"),
				new SelectionItem("attributeMatches", "属性匹配表达式"),
				new SelectionItem("attributeNotMatches", "属性不匹配表达式"),
				new SelectionItem("elementHasClass", "元素包含类名"),
				new SelectionItem("elementNotHasClass", "元素不包含类名"),
				new SelectionItem("elementHasAttribute", "元素包含属性"),
				new SelectionItem("elementNotHasAttribute", "元素不包含属性"),
				new SelectionItem("elementCountGt", "元素数量大于"),
				new SelectionItem("elementCountLt", "元素数量小于"),
				new SelectionItem("elementCountEq", "元素数量等于"),
				new SelectionItem("elementEvent", "元素事件触发")
			},
			ValidForList = new List<string>(1) { "Wait" }
		};
		gRLtTIWrU8I = new StepInParamDef
		{
			Key = "waitEventParams",
			Name = "参数",
			Description = "不同事件的参数不同，请参考模块文档。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string>(1) { "Wait" }
		};
		OiAtTkcNfZR = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		pb4tTG6oOao = new StepOutParamDef
		{
			Key = "tabId",
			Name = "标签页ID",
			Type = VarType.Integer,
			Description = "网页所在标签页ID",
			ValidForList = new List<string> { "OpenUrl", "GetTabInfo", "ActivateTab" }
		};
		SHmtTsqsoZo = new StepOutParamDef
		{
			Key = "windowId",
			Name = "窗口ID",
			Type = VarType.Integer,
			Description = "网页所在窗口的ID",
			ValidForList = new List<string> { "OpenUrl", "GetTabInfo", "ActivateTab" }
		};
		JuYtTHojTkL = new StepOutParamDef
		{
			Key = "groupId",
			Name = "分组ID",
			Type = VarType.Integer,
			Description = "标签页所属分组ID",
			ValidForList = new List<string> { "GetTabInfo", "ActivateTab" }
		};
		fWJtT16q7P2 = new StepOutParamDef
		{
			Key = "url",
			Name = "网址",
			Type = VarType.Text,
			Description = "标签页当前网址",
			ValidForList = new List<string> { "GetTabInfo", "ActivateTab" }
		};
		myFtTba9nj7 = new StepOutParamDef
		{
			Key = "title",
			Name = "网页标题",
			Type = VarType.Text,
			Description = "标签页网页标题",
			ValidForList = new List<string> { "GetTabInfo", "ActivateTab" }
		};
		tX6tT6MODsP = new StepOutParamDef
		{
			Key = "favicon",
			Name = "Favicon图标网址",
			Type = VarType.Text,
			Description = "标签页网页图标网址",
			ValidForList = new List<string> { "GetTabInfo", "ActivateTab" }
		};
		CngtTX4E0S4 = new StepOutParamDef
		{
			Key = "firstValue",
			Name = "第一个值",
			Type = VarType.Text,
			Description = "获取的第一个元素的信息结果",
			ValidForList = new List<string> { "GetElementInfo" }
		};
		ziwtTm2ldaq = new StepOutParamDef
		{
			Key = "allValues",
			Name = "所有值的列表",
			Type = VarType.List,
			Description = "所有元素信息结果的列表",
			ValidForList = new List<string> { "GetElementInfo" }
		};
		GUAtTKH6O8h = new StepOutParamDef
		{
			Key = "browser",
			Name = "浏览器",
			Type = VarType.Text,
			Description = "当前访问的浏览器",
			ValidForList = new List<string> { "GetTabInfo" }
		};
		IvctTxfFlGg = new StepOutParamDef
		{
			Key = "extVersion",
			Name = "插件版本",
			Type = VarType.Text,
			Description = "浏览器插件版本号",
			ValidForList = new List<string> { "GetTabInfo" }
		};
		dk5tTrv5aRI = new StepOutParamDef
		{
			Key = "manifestVersion",
			Name = "Manifest版本",
			Type = VarType.Integer,
			Description = "浏览器插件的Manifest版本号",
			ValidForList = new List<string> { "GetTabInfo" }
		};
		JIctTpYkfIS = new StepOutParamDef
		{
			Key = "selector",
			Name = "CSS选择器",
			Type = VarType.Text,
			Description = "所选择元素的CSS选择器",
			ValidForList = new string[1] { "PickElement" }
		};
		wSVtTBcqNMU = new StepOutParamDef
		{
			Key = "rawResponse",
			Name = "原始返回结果",
			Type = VarType.Any,
			Description = "从插件返回的原始jToken对象"
		};
	}

	internal static bool XP10M3Qi3YJRIM8PkbNX()
	{
		return s1v9SRQiD7WmSrDyIiHU == null;
	}
}
