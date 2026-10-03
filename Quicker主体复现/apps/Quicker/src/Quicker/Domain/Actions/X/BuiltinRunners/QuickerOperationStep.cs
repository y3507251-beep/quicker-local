using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using BSpkSC2BMVITn7dofh0;
using FontAwesome5;
using JTIh7V5l65QV75A93Ly;
using Quicker.Common;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.ContextMenus;
using Quicker.Domain.Floating;
using Quicker.Domain.Push;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.UI;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class QuickerOperationStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec f9Uv3HW5Xxt;

		public static Action ktAv313OnQd;

		public static Action qtKv3bYshV1;

		public static Func<ActionProfile, IEnumerable<ActionItem>> dWJv36DFXbq;

		public static Func<ActionItem, string> amQv3XF1214;

		internal static _003C_003Ec Dh6qQ8WDEZVMYEI2KUVU;

		static _003C_003Ec()
		{
			f9Uv3HW5Xxt = new _003C_003Ec();
		}

		internal void EsAv3WMXJU4()
		{
			AppHelper.RestartQuicker();
			AppHelper.ExitApplication();
		}

		internal void YJsv3knWqeB()
		{
			AppHelper.ExitApplication();
		}

		internal IEnumerable<ActionItem> Bn8v3GmHMvw(ActionProfile x)
		{
			return x.ActionItems;
		}

		internal string SqBv3sW51yb(ActionItem x)
		{
			return "[action:" + x.Id + "]" + x.Title.Replace("\r\n", " ") + "(" + x.Description.Replace("\r\n", " ") + ")|" + x.Id;
		}

		internal static bool fnAkyRWDGXtWW3DfsUfl()
		{
			return Dh6qQ8WDEZVMYEI2KUVU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_0
	{
		public ActionStep iSov3xNELvc;

		public ActionExecuteContext Gd6v3r6Bj6u;

		public XAction ywfv3p9g5cN;

		public Action kSnv3BAhnGr;

		internal static _003C_003Ec__DisplayClass82_0 ahktMrWDKvEoOlgTIIWQ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) pT0v3m0KB9L()
		{
			_003C_003Ec__DisplayClass82_1 _003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_1
			{
				UKxv3nupHFU = this
			};
			string textParamValue = XActionHelper.GetTextParamValue(nhEtMAN98vU, iSov3xNELvc, Gd6v3r6Bj6u);
			_003C_003Ec__DisplayClass82_.ftTv3jYeXlW = "";
			if (textParamValue.IsEither("showSearch", "StartSearchWithAction", "SearchWithCertainAction"))
			{
				_003C_003Ec__DisplayClass82_.ftTv3jYeXlW = XActionHelper.GetTextParamValue(YVQtAthlgdn, iSov3xNELvc, Gd6v3r6Bj6u);
			}
			_003C_003Ec__DisplayClass82_2 _003C_003Ec__DisplayClass82_2 = new _003C_003Ec__DisplayClass82_2
			{
				qTcv358SJHK = _003C_003Ec__DisplayClass82_
			};
			switch (textParamValue)
			{
			case "LoadSkin":
			{
				_003C_003Ec__DisplayClass82_6 _003C_003Ec__DisplayClass82_5 = new _003C_003Ec__DisplayClass82_6();
				_003C_003Ec__DisplayClass82_5.WNdv3lRTSe6 = XActionHelper.GetTextParamValue(ej4tMfIf1UN, iSov3xNELvc, Gd6v3r6Bj6u);
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass82_5.WNdv3lRTSe6))
				{
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass82_5.l0Av3UJwwqn);
				}
				string textParamValue4 = XActionHelper.GetTextParamValue(CRstM3kHfdD, iSov3xNELvc, Gd6v3r6Bj6u);
				if (!string.IsNullOrEmpty(textParamValue4))
				{
					if (!Guid.TryParse(textParamValue4, out var result) || result == Guid.Empty)
					{
						return (isSuccess: false, message: "外观ID不正确。", failReason: ActionStopFlag.OperationFailed);
					}
					Gd6v3r6Bj6u.AppServer.LoadSkin(result, true, false, false);
				}
				goto IL_0d65;
			}
			case "showPanel":
			{
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(KgFtMOFZvfY, iSov3xNELvc, Gd6v3r6Bj6u);
				bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(TK5tMF4HkRJ, iSov3xNELvc, Gd6v3r6Bj6u);
				Gd6v3r6Bj6u.AppServer.RequestShowPanel(booleanParamValue, PopupSource.Action, booleanParamValue2);
				goto IL_0d65;
			}
			case "showSearch":
				Gd6v3r6Bj6u.AppServer.ShowSearchWindow(_003C_003Ec__DisplayClass82_2.qTcv358SJHK.ftTv3jYeXlW, false);
				goto IL_0d65;
			case "editAction":
			{
				string textParamValue12 = XActionHelper.GetTextParamValue(rqEtMl8Hl1O, iSov3xNELvc, Gd6v3r6Bj6u);
				if (string.IsNullOrEmpty(textParamValue12))
				{
					return (isSuccess: false, message: "未指定动作ID或名称", failReason: ActionStopFlag.OperationFailed);
				}
				if (textParamValue12.StartsWith("%%"))
				{
					_003C_003Ec__DisplayClass82_3 _003C_003Ec__DisplayClass82_6 = new _003C_003Ec__DisplayClass82_3
					{
						QOUv3dZnJwb = AppState.DataService.GetGlobalSubProgram(textParamValue12.Substring(2))
					};
					if (_003C_003Ec__DisplayClass82_6.QOUv3dZnJwb != null)
					{
						AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass82_6.yDCv3Dob9xD);
						return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
					}
				}
				(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(textParamValue12);
				if (tuple.Item1 == null)
				{
					return (isSuccess: false, message: tuple.Item2, failReason: ActionStopFlag.OperationFailed);
				}
				Gd6v3r6Bj6u.AppServer.EditActionById(tuple.Item1.Id);
				goto IL_0d65;
			}
			case "FloatAction":
			{
				_003C_003Ec__DisplayClass82_4 _003C_003Ec__DisplayClass82_4 = new _003C_003Ec__DisplayClass82_4();
				string textParamValue3 = XActionHelper.GetTextParamValue(rqEtMl8Hl1O, iSov3xNELvc, Gd6v3r6Bj6u);
				if (string.IsNullOrEmpty(textParamValue3))
				{
					return (isSuccess: false, message: "未指定动作ID或名称", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass82_4.Qe9v3TN26Wb = AppState.DataService.QHmtXwg81eY(textParamValue3);
				if (_003C_003Ec__DisplayClass82_4.Qe9v3TN26Wb.action == null)
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass82_4.Qe9v3TN26Wb.message, failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass82_4.r7Kv3MsCS00 = XActionHelper.GetTextParamValue(KBYtMiKxwED, iSov3xNELvc, Gd6v3r6Bj6u);
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass82_4.YPcv3o6aYHL);
				goto IL_0d65;
			}
			case "ExitQuicker":
				AppHelper.RunOnUiThread(true, _003C_003Ec.qtKv3bYshV1 ?? (_003C_003Ec.qtKv3bYshV1 = _003C_003Ec.f9Uv3HW5Xxt.YJsv3knWqeB));
				goto IL_0d65;
			case "togglePause":
				Gd6v3r6Bj6u.AppServer.TogglePause();
				goto IL_0d65;
			case "loadProfile":
			{
				if (Gd6v3r6Bj6u.ActionTrigger != ActionTrigger.App)
				{
					Gd6v3r6Bj6u.AppServer.RequestShowPanel();
				}
				string textParamValue8 = XActionHelper.GetTextParamValue(I91tMUyIokB, iSov3xNELvc, Gd6v3r6Bj6u);
				Gd6v3r6Bj6u.AppServer.RequestSwitchProfile(textParamValue8, false);
				goto IL_0d65;
			}
			case "closeSearch":
				Gd6v3r6Bj6u.AppServer.CloseSearch();
				goto IL_0d65;
			case "RemoveAction":
				if (string.IsNullOrEmpty(Gd6v3r6Bj6u.ActionId))
				{
					return (isSuccess: false, message: "动作不存在", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass82_2.XRev34Igahc = AppState.DataService.GetActionById(Gd6v3r6Bj6u.ActionId);
				if (_003C_003Ec__DisplayClass82_2.XRev34Igahc.profile != null)
				{
					_003C_003Ec__DisplayClass82_7 _003C_003Ec__DisplayClass82_7 = new _003C_003Ec__DisplayClass82_7
					{
						Y4vv3zAHxlP = _003C_003Ec__DisplayClass82_2,
						pipv3f32Xyd = new ManualResetEventSlim(false),
						klYv33wQT24 = false
					};
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass82_7.CLvv3i9u8wf);
					_003C_003Ec__DisplayClass82_7.pipv3f32Xyd.Wait();
					if (_003C_003Ec__DisplayClass82_7.klYv33wQT24)
					{
						AppState.lWutartRfUY().DeleteAction(_003C_003Ec__DisplayClass82_7.Y4vv3zAHxlP.XRev34Igahc.profile, _003C_003Ec__DisplayClass82_7.Y4vv3zAHxlP.XRev34Igahc.action, false, false);
					}
				}
				goto IL_0d65;
			case "GetActionList":
				return (isSuccess: false, message: "不支持此功能", failReason: ActionStopFlag.OperationFailed);
			case "GetActionInfo":
			{
				string textParamValue11 = XActionHelper.GetTextParamValue(rqEtMl8Hl1O, iSov3xNELvc, Gd6v3r6Bj6u);
				if (string.IsNullOrEmpty(textParamValue11))
				{
					return (isSuccess: false, message: "未指定动作ID或名称", failReason: ActionStopFlag.OperationFailed);
				}
				(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(textParamValue11);
				if (actionById.Item1 == null)
				{
					return (isSuccess: false, message: "未能根据ID找到动作,ID=" + textParamValue11, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResult(m9rtAvxV1Qk, iSov3xNELvc, Gd6v3r6Bj6u, actionById.Item1.Title, ywfv3p9g5cN);
				XActionHelper.OutputResult(iW1tAS0s5aw, iSov3xNELvc, Gd6v3r6Bj6u, actionById.Item1.Icon, ywfv3p9g5cN);
				goto IL_0d65;
			}
			case "runLastAction":
				Gd6v3r6Bj6u.AppServer.RunLastAction(Gd6v3r6Bj6u.ActionTrigger);
				goto IL_0d65;
			case "ResetKeyboard":
				AppHelper.HP0LT5LCDOi();
				goto IL_0d65;
			case "stopAllActions":
				Gd6v3r6Bj6u.AppServer.StopAllRunningAction();
				goto IL_0d65;
			case "showCircleMenu":
				AppHelper.ShowCircleMenu(XActionHelper.GetTextParamValue(r5ftAwMq8ZZ, iSov3xNELvc, Gd6v3r6Bj6u));
				goto IL_0d65;
			case "RestartQuicker":
				AppHelper.RunOnUiThread(false, _003C_003Ec.ktAv313OnQd ?? (_003C_003Ec.ktAv313OnQd = _003C_003Ec.f9Uv3HW5Xxt.EsAv3WMXJU4));
				goto IL_0d65;
			case "loadExeProfiles":
			{
				string textParamValue6 = XActionHelper.GetTextParamValue(r5ftAwMq8ZZ, iSov3xNELvc, Gd6v3r6Bj6u);
				Gd6v3r6Bj6u.AppServer.LoadExeProfilesAndLock(textParamValue6, true, true);
				if (Gd6v3r6Bj6u.ActionTrigger != ActionTrigger.App)
				{
					Gd6v3r6Bj6u.AppServer.RequestShowPanel();
				}
				goto IL_0d65;
			}
			case "ToggleLockPanel":
				AppHelper.RunOnUiThread(false, kSnv3BAhnGr ?? (kSnv3BAhnGr = iFTv3KtHeGl));
				goto IL_0d65;
			case "showConfigWindow":
				Gd6v3r6Bj6u.AppServer.ShowConfigWindow();
				goto IL_0d65;
			case "startAppVoiceInput":
				Gd6v3r6Bj6u.AppServer.StartVoiceInput();
				goto IL_0d65;
			case "reinstallMouseHook":
				Gd6v3r6Bj6u.AppServer.RequestReinstallHook();
				goto IL_0d65;
			case "ToggleFloatButtons":
			{
				string textParamValue10 = XActionHelper.GetTextParamValue(Tf3tMzG8FCI, iSov3xNELvc, Gd6v3r6Bj6u);
				if (string.IsNullOrEmpty(textParamValue10))
				{
					return (isSuccess: false, message: "未指定显示状态", failReason: ActionStopFlag.OperationFailed);
				}
				if (Enum.TryParse<ViewMode>(textParamValue10, true, out var result2))
				{
					AppState.TKStaiOMyPb().SetButtonViewMode(result2);
				}
				else
				{
					if (!(textParamValue10.ToLower() == "togglehideandauto"))
					{
						return (isSuccess: false, message: "不支持的悬浮按钮显示状态", failReason: ActionStopFlag.OperationFailed);
					}
					if (AppState.TKStaiOMyPb().FloatViewMode == ViewMode.HideAll)
					{
						AppState.TKStaiOMyPb().SetButtonViewMode(ViewMode.ByProcess);
					}
					else
					{
						AppState.TKStaiOMyPb().SetButtonViewMode(ViewMode.HideAll);
					}
				}
				goto IL_0d65;
			}
			case "showDashboardWindow":
			{
				string textParamValue9 = XActionHelper.GetTextParamValue(r5ftAwMq8ZZ, iSov3xNELvc, Gd6v3r6Bj6u);
				Gd6v3r6Bj6u.AppServer.ShowDashboardWindow(textParamValue9);
				goto IL_0d65;
			}
			case "closeAllFloatWindow":
				Gd6v3r6Bj6u.AppServer.CloseAllFloatWindow();
				goto IL_0d65;
			case "SetPushActiveClient":
			{
				PushClient pushClient = AppState.PushClient;
				if (pushClient.IsConnected())
				{
					if (pushClient.State == PushConnectionState.ConnectedInactive)
					{
						pushClient.RequestActive();
						for (int i = 0; i < 20; i++)
						{
							Thread.Sleep(50);
							if (pushClient.State == PushConnectionState.ConnectedActive || Gd6v3r6Bj6u.IsShouldStopAction())
							{
								break;
							}
						}
						if (pushClient.State != PushConnectionState.ConnectedActive)
						{
							return (isSuccess: false, message: "未成功更新未活动客户端", failReason: ActionStopFlag.OperationFailed);
						}
					}
					goto IL_0d65;
				}
				return (isSuccess: false, message: "", failReason: ActionStopFlag.OperationFailed);
			}
			case "showExeSettingWindow":
			{
				string textParamValue7 = XActionHelper.GetTextParamValue(r5ftAwMq8ZZ, iSov3xNELvc, Gd6v3r6Bj6u);
				Gd6v3r6Bj6u.AppServer.ShowExeSettingsWindow(textParamValue7);
				goto IL_0d65;
			}
			case "ShowHideImageWindows":
				Gd6v3r6Bj6u.AppServer.ShowOrHideAllImageWindows(null);
				goto IL_0d65;
			case "toggleTextFloatWindow":
				Gd6v3r6Bj6u.AppServer.ToggleTextFloatWindow();
				goto IL_0d65;
			case "loadExeProfilesNoLock":
			{
				string textParamValue5 = XActionHelper.GetTextParamValue(r5ftAwMq8ZZ, iSov3xNELvc, Gd6v3r6Bj6u);
				Gd6v3r6Bj6u.AppServer.LoadExeProfilesAndLock(textParamValue5, false, true);
				if (Gd6v3r6Bj6u.ActionTrigger != ActionTrigger.App)
				{
					Gd6v3r6Bj6u.AppServer.RequestShowPanel();
				}
				goto IL_0d65;
			}
			case "StartSearchWithAction":
				if (Gd6v3r6Bj6u.ActionTrigger != ActionTrigger.SearchInput)
				{
					AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass82_2.qTcv358SJHK.e8Vv3QhW2MO);
				}
				goto IL_0d65;
			case "SearchWithCertainAction":
				if (Gd6v3r6Bj6u.ActionTrigger != ActionTrigger.SearchInput)
				{
					_003C_003Ec__DisplayClass82_5 _003C_003Ec__DisplayClass82_3 = new _003C_003Ec__DisplayClass82_5
					{
						UIjv3FUUJEJ = _003C_003Ec__DisplayClass82_2
					};
					string textParamValue2 = XActionHelper.GetTextParamValue(rqEtMl8Hl1O, iSov3xNELvc, Gd6v3r6Bj6u);
					if (string.IsNullOrEmpty(textParamValue2))
					{
						return (isSuccess: false, message: "未指定动作ID或名称", failReason: ActionStopFlag.OperationFailed);
					}
					_003C_003Ec__DisplayClass82_3.MV3v3Ou4CWI = AppState.DataService.QHmtXwg81eY(textParamValue2);
					if (_003C_003Ec__DisplayClass82_3.MV3v3Ou4CWI.action == null)
					{
						return (isSuccess: false, message: _003C_003Ec__DisplayClass82_3.MV3v3Ou4CWI.message, failReason: ActionStopFlag.OperationFailed);
					}
					AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass82_3.Kw9v3AGMRpi);
				}
				goto IL_0d65;
			case "operation_show_context_menu":
				ContentContextMenuService.ShowClipboardContextMenu();
				goto IL_0d65;
			default:
				{
					return (isSuccess: false, message: "不支持此操作(" + textParamValue + ")，可能您使用的Quicker版本过低。", failReason: ActionStopFlag.OperationFailed);
				}
				IL_0d65:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal void iFTv3KtHeGl()
		{
			Gd6v3r6Bj6u.AppServer.ToggleLockPanel(null);
		}

		internal static bool LturAkWDBq9gS8mPWQxZ()
		{
			return ahktMrWDKvEoOlgTIIWQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_1
	{
		public string ftTv3jYeXlW;

		public _003C_003Ec__DisplayClass82_0 UKxv3nupHFU;

		private static _003C_003Ec__DisplayClass82_1 MkJXA0WDdYl68wtSoIKt;

		internal void e8Vv3QhW2MO()
		{
			AppState.HS2taepcAbc().ShowSearch(UKxv3nupHFU.Gd6v3r6Bj6u.Action, ftTv3jYeXlW);
		}

		internal static bool nFDREWWDO0Q1Z9ZUKWZg()
		{
			return MkJXA0WDdYl68wtSoIKt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_2
	{
		public (ActionItem action, ActionProfile profile) XRev34Igahc;

		public _003C_003Ec__DisplayClass82_1 qTcv358SJHK;

		internal static _003C_003Ec__DisplayClass82_2 QnrN4fWDkKHhdiiP3tpp;

		internal static void J1lhPdWDNwMAoqPXR13h()
		{
		}

		internal static bool pribfoWDa992ITec3bFa()
		{
			return QnrN4fWDkKHhdiiP3tpp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_3
	{
		public SubProgram QOUv3dZnJwb;

		private static _003C_003Ec__DisplayClass82_3 tuNHORWD9H7yQqOhtR9M;

		internal void yDCv3Dob9xD()
		{
			AppState.lWutartRfUY().CreateOrEditGlobalSubProgram(QOUv3dZnJwb);
		}

		static _003C_003Ec__DisplayClass82_3()
		{
		}

		internal static void es643bWDoayrU2y7hAf9()
		{
		}

		internal static bool PlrOd6WDLbbN8kyOwjNa()
		{
			return tuNHORWD9H7yQqOhtR9M == null;
		}

		internal static void bREjhWWDf29IndnFRqLf()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_4
	{
		public (ActionItem action, string message) Qe9v3TN26Wb;

		public string r7Kv3MsCS00;

		internal static _003C_003Ec__DisplayClass82_4 C1QmOEWDbH1QEKYWlmIB;

		internal void YPcv3o6aYHL()
		{
			try
			{
				khuggB2ZntAfW2CDU1r.FloatAction(Qe9v3TN26Wb.action, PointExt.FromValue(r7Kv3MsCS00), AppState.AppServer, AppState.Y2RtaqSv0AQ(), AppState.lWutartRfUY(), AppState.DataService, AppState.TKStaiOMyPb());
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("悬浮动作失败：" + ex.Message);
			}
		}

		internal static bool vhNWUMWDqm411Qq5ytRG()
		{
			return C1QmOEWDbH1QEKYWlmIB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_5
	{
		public (ActionItem action, string message) MV3v3Ou4CWI;

		public _003C_003Ec__DisplayClass82_2 UIjv3FUUJEJ;

		internal static _003C_003Ec__DisplayClass82_5 yMklTdWDlLbv3bkDatyK;

		internal void Kw9v3AGMRpi()
		{
			AppState.HS2taepcAbc().ShowSearch(MV3v3Ou4CWI.action, UIjv3FUUJEJ.qTcv358SJHK.ftTv3jYeXlW);
		}

		internal static bool fda6YtWDZMxTP8h1lwwV()
		{
			return yMklTdWDlLbv3bkDatyK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_6
	{
		public string WNdv3lRTSe6;

		internal static _003C_003Ec__DisplayClass82_6 rsRwcFWDYGW6PR0KuX6t;

		internal void l0Av3UJwwqn()
		{
			string text = WNdv3lRTSe6.ToLower();
			switch (text)
			{
			case "auto":
				FMP9ONqzXcgZ6r3WmZZ.bocHcD7FL8("auto");
				return;
			case "dark":
				FMP9ONqzXcgZ6r3WmZZ.bocHcD7FL8("dark");
				return;
			case "default":
			case "light":
				FMP9ONqzXcgZ6r3WmZZ.bocHcD7FL8("light");
				return;
			}
			int num = 0;
			if (!B2F0pHWD8OMpln1dNIIJ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!(text == "toggle"))
			{
				AppHelper.ShowWarning("不支持的主题设置：" + WNdv3lRTSe6);
			}
			else
			{
				FMP9ONqzXcgZ6r3WmZZ.epJHVfvYYD();
			}
		}

		internal static bool B2F0pHWD8OMpln1dNIIJ()
		{
			return rsRwcFWDYGW6PR0KuX6t == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_7
	{
		[StructLayout(LayoutKind.Auto)]
		private struct bf6Mumk9yOPjGsvrqWa : IAsyncStateMachine
		{
			public int iU32qlMsSq1;

			public AsyncVoidMethodBuilder DSs2qiIOd1h;

			public _003C_003Ec__DisplayClass82_7 qJW2q3OPiL6;

			private TaskAwaiter<(bool isSuccess, string button)> RtL2qfqQZHm;

			private static object HuU45gyf1Vai60cal1Ub;

			private void MoveNext()
			{
				int num = iU32qlMsSq1;
				_003C_003Ec__DisplayClass82_7 _003C_003Ec__DisplayClass82_ = qJW2q3OPiL6;
				try
				{
					TaskAwaiter<(bool, string)> awaiter;
					if (num != 0)
					{
						awaiter = ConfirmDialog.jQyL0Wq9wU6(null, "删除动作", _003C_003Ec__DisplayClass82_.Y4vv3zAHxlP.qTcv358SJHK.UKxv3nupHFU.Gd6v3r6Bj6u.Action?.Icon, "您确认要删除动作 “" + _003C_003Ec__DisplayClass82_.Y4vv3zAHxlP.XRev34Igahc.action.Title + "” 么？", "Warning", "删除(_Y)|Yes\r\n不删除(_N)|No", "No").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							if (HuU45gyf1Vai60cal1Ub != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = 0;
							iU32qlMsSq1 = 0;
							RtL2qfqQZHm = awaiter;
							DSs2qiIOd1h.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = RtL2qfqQZHm;
						RtL2qfqQZHm = default(TaskAwaiter<(bool, string)>);
						num = -1;
						iU32qlMsSq1 = -1;
					}
					_003C_003Ec__DisplayClass82_.klYv33wQT24 = string.Equals("Yes", awaiter.GetResult().Item2 ?? "");
					_003C_003Ec__DisplayClass82_.pipv3f32Xyd.Set();
				}
				catch (Exception exception)
				{
					iU32qlMsSq1 = -2;
					DSs2qiIOd1h.SetException(exception);
					return;
				}
				iU32qlMsSq1 = -2;
				DSs2qiIOd1h.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				DSs2qiIOd1h.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool ly7XBeyfKZFKXPDJ1VQ0()
			{
				return HuU45gyf1Vai60cal1Ub == null;
			}
		}

		public bool klYv33wQT24;

		public ManualResetEventSlim pipv3f32Xyd;

		public _003C_003Ec__DisplayClass82_2 Y4vv3zAHxlP;

		private static _003C_003Ec__DisplayClass82_7 k35v8mWDM2EDSGFYh8ap;

		[AsyncStateMachine(typeof(bf6Mumk9yOPjGsvrqWa))]
		internal void CLvv3i9u8wf()
		{
			bf6Mumk9yOPjGsvrqWa stateMachine = default(bf6Mumk9yOPjGsvrqWa);
			stateMachine.DSs2qiIOd1h = AsyncVoidMethodBuilder.Create();
			stateMachine.qJW2q3OPiL6 = this;
			stateMachine.iU32qlMsSq1 = -1;
			stateMachine.DSs2qiIOd1h.Start(ref stateMachine);
		}

		internal static void jH77yXWDId7qNWFecoIa()
		{
		}

		internal static bool FAY248WDUaxAvSGBKOgn()
		{
			return k35v8mWDM2EDSGFYh8ap == null;
		}
	}

	public const string TYPE_LoadExeProfilesNoLock = "loadExeProfilesNoLock";

	public const string StepKey = "sys:quickeroperations";

	private static List<string> IZMtMDvegiS;

	[CompilerGenerated]
	private readonly string kKHtMdrsyWa = $"fa:{EFontAwesomeIcon.Light_Cog}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> nZptMoYyXw6;

	[CompilerGenerated]
	private readonly string wyntMT7XSUU = "https://getquicker.net/KC/Help/Doc/quickeroperations";

	[CompilerGenerated]
	private readonly bool uAdtMMZ8OZl;

	private static readonly StepInParamDef nhEtMAN98vU;

	private static readonly StepInParamDef KgFtMOFZvfY;

	private static readonly StepInParamDef TK5tMF4HkRJ;

	private static readonly StepInParamDef I91tMUyIokB;

	private static readonly StepInParamDef rqEtMl8Hl1O;

	private static readonly StepInParamDef KBYtMiKxwED;

	private static readonly StepInParamDef CRstM3kHfdD;

	private static readonly StepInParamDef ej4tMfIf1UN;

	private static readonly StepInParamDef Tf3tMzG8FCI;

	private static readonly StepInParamDef r5ftAwMq8ZZ;

	private static readonly StepInParamDef YVQtAthlgdn;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> wNOtAgAwuTB = new List<StepInParamDef>
	{
		nhEtMAN98vU,
		I91tMUyIokB,
		rqEtMl8Hl1O,
		KBYtMiKxwED,
		r5ftAwMq8ZZ,
		KgFtMOFZvfY,
		TK5tMF4HkRJ,
		YVQtAthlgdn,
		CRstM3kHfdD,
		ej4tMfIf1UN,
		Tf3tMzG8FCI,
		StepInParamDef.StopIfFailParam
	};

	private static readonly StepOutParamDef keDtALCdZ7Y;

	private static readonly StepOutParamDef m9rtAvxV1Qk;

	private static readonly StepOutParamDef iW1tAS0s5aw;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> sMUtA2RGrpF = new List<StepOutParamDef>
	{
		StepOutParamDef.IsSuccessOutputParam,
		keDtALCdZ7Y,
		m9rtAvxV1Qk,
		iW1tAS0s5aw
	};

	private static QuickerOperationStep pH9fvPQi4wZWhlaJ0F5w;

	public string Key => "sys:quickeroperations";

	public string Name => "Quicker操作";

	public IEnumerable<string> KeyWords => IZMtMDvegiS;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return kKHtMdrsyWa;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return nZptMoYyXw6;
		}
	}

	public string Description => "调用Quicker的某个功能";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return wyntMT7XSUU;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return uAdtMMZ8OZl;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return wNOtAgAwuTB;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return sMUtA2RGrpF;
		}
	}

	static QuickerOperationStep()
	{
		IZMtMDvegiS = new List<string>();
		nhEtMAN98vU = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "showPanel",
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("showPanel", "显示面板"),
				new SelectionItem("showSearch", "显示搜索框"),
				new SelectionItem("closeSearch", "关闭搜索框"),
				new SelectionItem("showCircleMenu", "显示轮盘菜单 (点击)"),
				new SelectionItem("togglePause", "禁用/启用"),
				new SelectionItem("runLastAction", "运行最后使用的动作"),
				new SelectionItem("startAppVoiceInput", "启动App语音输入"),
				new SelectionItem("stopAllActions", "停止运行中的动作"),
				new SelectionItem("reinstallMouseHook", "重新加载键鼠挂钩"),
				new SelectionItem("ResetKeyboard", "重置键盘状态"),
				new SelectionItem("showDashboardWindow", "显示仪表盘窗口"),
				new SelectionItem("toggleTextFloatWindow", "开启/关闭文本悬浮窗功能"),
				new SelectionItem("showConfigWindow", "显示设置窗口"),
				new SelectionItem("showExeSettingWindow", "显示场景与动作管理窗口"),
				new SelectionItem("closeAllFloatWindow", "关闭所有悬浮按钮"),
				new SelectionItem("loadProfile", "加载动作页"),
				new SelectionItem("loadExeProfiles", "加载指定应用程序的所有动作页（锁定切换）"),
				new SelectionItem("loadExeProfilesNoLock", "加载指定应用程序的所有动作页（不锁定切换）"),
				new SelectionItem("ToggleLockPanel", "锁定/解锁 动作页自动切换"),
				new SelectionItem("editAction", "编辑动作"),
				new SelectionItem("RestartQuicker", "重启Quicker"),
				new SelectionItem("SetPushActiveClient", "推送服务：设置为活动客户端"),
				new SelectionItem("StartSearchWithAction", "使用当前动作进行实时搜索"),
				new SelectionItem("SearchWithCertainAction", "使用指定动作进行实时搜索"),
				new SelectionItem("operation_show_context_menu", "显示剪贴板上下文菜单"),
				new SelectionItem("LoadSkin", "加载外观/切换主题"),
				new SelectionItem("ExitQuicker", "退出Quicker"),
				new SelectionItem("FloatAction", "悬浮动作"),
				new SelectionItem("ToggleFloatButtons", "切换所有悬浮按钮显示"),
				new SelectionItem("ShowHideImageWindows", "显示或隐藏所有图片窗口"),
				new SelectionItem("RemoveAction", "删除当前动作"),
				new SelectionItem("GetActionInfo", "根据ID获取动作信息")
			},
			IsControlField = true
		};
		KgFtMOFZvfY = new StepInParamDef
		{
			Key = "activatePointWindow",
			Name = "自动激活鼠标位置窗口",
			Type = VarType.Boolean,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "showPanel" }
		};
		TK5tMF4HkRJ = new StepInParamDef
		{
			Key = "followMousePosition",
			Name = "跟随鼠标位置",
			Type = VarType.Boolean,
			DefaultValue = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "showPanel" }
		};
		I91tMUyIokB = new StepInParamDef
		{
			Key = "profileId",
			Name = "动作页ID",
			Description = "请在场景与动作管理中，查看动作页信息获取ID。",
			DefaultValue = "",
			ValidForList = new List<string> { "loadProfile" },
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		rqEtMl8Hl1O = new StepInParamDef
		{
			Key = "actionId",
			Name = "动作ID或名称",
			Description = "在动作上点右键->信息可以查看动作信息。使用名称时不能有重名动作。获取动作信息时仅可填写动作Id。编辑动作时，使用%%id或%%name格式，可用于编辑公共子程序。",
			DefaultValue = "",
			ValidForList = new List<string> { "editAction", "SearchWithCertainAction", "FloatAction", "GetActionInfo" },
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		KBYtMiKxwED = new StepInParamDef
		{
			Key = "position",
			Name = "位置",
			Description = "坐标，格式为：left,top",
			DefaultValue = "200,200",
			ValidForList = new List<string> { "FloatAction" },
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationPoint }
		};
		CRstM3kHfdD = new StepInParamDef
		{
			Key = "skinId",
			Name = "外观ID",
			Description = "请在外观网页中复制外观ID",
			DefaultValue = "",
			ValidForList = new List<string> { "LoadSkin" },
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		ej4tMfIf1UN = new StepInParamDef
		{
			Key = "theme",
			Name = "主题模式",
			Description = "可选切换为浅色或暗色模式",
			DefaultValue = "",
			ValidForList = new List<string> { "LoadSkin" },
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("", "不改变"),
				new SelectionItem("auto", "跟随Windows"),
				new SelectionItem("light", "浅色"),
				new SelectionItem("dark", "暗色"),
				new SelectionItem("toggle", "切换浅色和暗色")
			},
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		Tf3tMzG8FCI = new StepInParamDef
		{
			Key = "viewMode",
			Name = "显示状态",
			Description = "",
			DefaultValue = ViewMode.ByProcess.ToString(),
			ValidForList = new List<string> { "ToggleFloatButtons" },
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(ViewMode.HideAll.ToString(), "隐藏全部"),
				new SelectionItem(ViewMode.ByProcess.ToString(), "自动(按关联进程切换)"),
				new SelectionItem(ViewMode.ShowAll.ToString(), "显示全部"),
				new SelectionItem("ToggleHideAndAuto", "切换隐藏和自动")
			},
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		r5ftAwMq8ZZ = new StepInParamDef
		{
			Key = "exe",
			Name = "场景标识",
			Description = "场景关联的exe文件名。请参考场景与动作管理窗口左侧应用列表。",
			DefaultValue = "",
			ValidForList = new List<string> { "loadExeProfiles", "loadExeProfilesNoLock", "showCircleMenu", "GetActionList", "showExeSettingWindow", "showDashboardWindow" },
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectProfileExe }
		};
		YVQtAthlgdn = new StepInParamDef
		{
			Key = "searchText",
			Name = "预置的搜索内容",
			Description = "预先放入搜索框的内容",
			ValidForList = new List<string> { "StartSearchWithAction", "showSearch", "SearchWithCertainAction" },
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		keDtALCdZ7Y = new StepOutParamDef
		{
			Key = "actionList",
			Name = "动作列表",
			Type = VarType.List,
			ValidForList = new string[1] { "GetActionList" }
		};
		m9rtAvxV1Qk = new StepOutParamDef
		{
			Key = "actionTitle",
			Name = "动作标题",
			Type = VarType.Text,
			ValidForList = new string[1] { "GetActionInfo" }
		};
		iW1tAS0s5aw = new StepOutParamDef
		{
			Key = "actionIcon",
			Name = "动作图标",
			Type = VarType.Text,
			ValidForList = new string[1] { "GetActionInfo" }
		};
		foreach (SelectionItem selectionItem in nhEtMAN98vU.SelectionItems)
		{
			IZMtMDvegiS.Add(selectionItem.Name);
			IZMtMDvegiS.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass82_0 _003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_0();
		_003C_003Ec__DisplayClass82_.iSov3xNELvc = step;
		_003C_003Ec__DisplayClass82_.Gd6v3r6Bj6u = context;
		_003C_003Ec__DisplayClass82_.ywfv3p9g5cN = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass82_.Gd6v3r6Bj6u, _003C_003Ec__DisplayClass82_.iSov3xNELvc, _003C_003Ec__DisplayClass82_.ywfv3p9g5cN, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass82_.pT0v3m0KB9L, (Action)null, (Action)null, StepInParamDef.StopIfFailParam, StepOutParamDef.IsSuccessOutputParam);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(nhEtMAN98vU, step);
	}

	internal static bool kR6P37Qihbpv5Qg1yUg7()
	{
		return pH9fvPQi4wZWhlaJ0F5w == null;
	}
}
