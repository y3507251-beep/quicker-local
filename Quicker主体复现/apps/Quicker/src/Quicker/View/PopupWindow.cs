using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using bpNbEZj0vTDod37Z02B;
using BSpkSC2BMVITn7dofh0;
using dkbgyyMixGueocCf9RC;
using EetOBeXoEKPaUQX04bS;
using FontAwesome5;
using FontAwesome5.WPF;
using JTIh7V5l65QV75A93Ly;
using log4net;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using mmcmHlAD3xkvwaQf2Ut;
using Ninject;
using PAhYUvY85RWX6ZQlKRb;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.BuiltinRunners.Images;
using Quicker.Domain.Entities;
using Quicker.Domain.Exe;
using Quicker.Domain.Extensions;
using Quicker.Domain.Floating;
using Quicker.Domain.Messages;
using Quicker.Domain.Network;
using Quicker.Domain.Profiles;
using Quicker.Domain.Push;
using Quicker.Domain.Services;
using Quicker.Modules.ExpressionTester;
using Quicker.Modules.VersionUpdate;
using Quicker.Public.Extensions;
using Quicker.Recorder.UI;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using Quicker.View.ProfileManagement;
using Quicker.View.Settings;
using Quicker.View.Tools;
using SnipInsight.Util;
using t8SGKhhgLWTgeqjGcrq;
using ToastNotifications;
using ToastNotifications.Core;
using ToastNotifications.Lifetime;
using ToastNotifications.Lifetime.Clear;
using ToastNotifications.Position;
using ViNASxihuuLY1Gg9m6p;
using WcdJQYXW9E2moeWW9Np;
using WindowsInput.Native;
using Yf8A0Tj55ce1jngb1h3;
using yvtPKofqpBDUbIJcBbI;

namespace Quicker.View;

public class PopupWindow : Window, IComponentConnector, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec WwOSm6GOS4m;

		public static EventHandler<TouchEventArgs> KVNSmX5cApW;

		public static EventHandler<TouchEventArgs> AA7SmmH3lpL;

		public static Func<Window, bool> gppSmKZ34Cs;

		public static Func<PanelUpdateMessage, bool> VwBSmxRI1EI;

		public static Func<UserSettingsChangedMessage, bool> aG7SmrFLFTY;

		public static Func<SyncStateMessage, bool> B0gSmp21v0E;

		public static Func<RequestShowPanelMessage, bool> FG7SmBf99Bi;

		public static Func<ActionEditCompletedMessage, bool> UcdSmQU3WR2;

		public static Func<ActionUpdatedMessage, bool> UdJSmjH0xOh;

		public static Func<TogglePausePopupMessage, bool> VFASmnbybY1;

		public static Func<StateChangedMessage, bool> IwlSm41XQDD;

		public static Func<ActionEditBeginMessage, bool> DTVSm5O0GcM;

		public static Action<NotifierConfiguration> yxISmDgNcBU;

		public static Action<int, ActionButton> bYPSmdL8pIL;

		public static Func<ActionProfile, string> OMcSmoK4VMD;

		public static Func<ActionProfile, string> JPpSmTnoWww;

		internal static _003C_003Ec lVNnmCW5rgyZddGuIaVU;

		static _003C_003Ec()
		{
			WwOSm6GOS4m = new _003C_003Ec();
		}

		internal void JBESmq0V8Ql(object sender, TouchEventArgs e)
		{
		}

		internal void wn3SmcegKfC(object sender, TouchEventArgs e)
		{
		}

		internal bool iGySmVrxhRA(Window w)
		{
			return w is WindowInfoWindow;
		}

		internal bool fKxSmZ83QxO(PanelUpdateMessage x)
		{
			return true;
		}

		internal bool easSm96W2l1(UserSettingsChangedMessage x)
		{
			return true;
		}

		internal bool d9WSmhlIXox(SyncStateMessage x)
		{
			return true;
		}

		internal bool r6ISmeDIikS(RequestShowPanelMessage x)
		{
			return true;
		}

		internal bool EniSmYiD6t9(ActionEditCompletedMessage x)
		{
			return true;
		}

		internal bool FOUSmIQlFMK(ActionUpdatedMessage x)
		{
			return true;
		}

		internal bool t4ESmWopIf0(TogglePausePopupMessage x)
		{
			return true;
		}

		internal bool Fp0SmkG3BsC(StateChangedMessage x)
		{
			return true;
		}

		internal bool qMrSmGwrWfP(ActionEditBeginMessage x)
		{
			return true;
		}

		internal void i3TSmsvaDDt(NotifierConfiguration cfg)
		{
			cfg.PositionProvider = new PrimaryScreenPositionProvider(Corner.BottomCenter, 10.0, 10.0);
			cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(TimeSpan.FromSeconds(3.0), MaximumNotificationCount.FromCount(5));
			cfg.Dispatcher = System.Windows.Application.Current.Dispatcher;
			cfg.DisplayOptions.Width = 400.0;
			cfg.DisplayOptions.TopMost = true;
		}

		internal void JxhSmHQv5qt(int i, ActionButton button)
		{
			button.KeyTip = null;
		}

		internal string th9Sm1aw1di(ActionProfile x)
		{
			return x.ExeFile;
		}

		internal string QO0Smb5xWW3(ActionProfile x)
		{
			return x.ExeFile.ToLower();
		}

		internal static bool viPuNPW5NW6CDDnLKrCR()
		{
			return lVNnmCW5rgyZddGuIaVU == null;
		}

		internal static void KDo3v0W5LW6pdogSrpPO()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public PopupWindow wlnSmOJIK9L;

		public Style uqeSmF5Q4rV;

		internal static _003C_003Ec__DisplayClass0_0 pKLwxvW5ui9oBRuXta3T;

		internal void xvNSmM9qUDA(ActionButton btn)
		{
			wlnSmOJIK9L.idtgD4i0iZE(btn, uqeSmF5Q4rV);
		}

		internal void L5wSmAugCeZ(ActionButton btn)
		{
			wlnSmOJIK9L.idtgD4i0iZE(btn, uqeSmF5Q4rV);
		}

		internal static bool yohm9jW5osu3URNmY6aC()
		{
			return pKLwxvW5ui9oBRuXta3T == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass118_0
	{
		public PopupWindow gMkSml7k84x;

		public ActionUpdatedMessage rffSmiATK7R;

		internal static _003C_003Ec__DisplayClass118_0 NceyfbW5bTJMaiJQThUL;

		internal void VsQSmUIBeqq(int btnIndex)
		{
			ActionItem action = gMkSml7k84x.kNxgT9fV6dX.GetAction(btnIndex);
			if (action != null && action.Id == rffSmiATK7R.ActionId)
			{
				gMkSml7k84x.SetButtonAction(btnIndex, action);
			}
		}

		internal static bool gIQsIwW5qgqP2fd8H3GR()
		{
			return NceyfbW5bTJMaiJQThUL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public PopupWindow himSmfvPy4N;

		public int xcuSmzK9VXX;

		public PointTargetInfo PXPSKwJDp4l;

		public ActionTrigger r2ySKtoMnUk;

		public bool vvxSKg5s09g;

		internal static _003C_003Ec__DisplayClass12_0 ymBRtlW5lBTRkj5TIli2;

		internal void AyvSm3dhL5m()
		{
			himSmfvPy4N.Q2GgTZX1xMq.NotifyButtonClick(himSmfvPy4N, xcuSmzK9VXX, himSmfvPy4N.IsPinned ? null : PXPSKwJDp4l, r2ySKtoMnUk, vvxSKg5s09g);
		}

		internal static bool RWV9OwW5Z2Bf3v5v2gUb()
		{
			return ymBRtlW5lBTRkj5TIli2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass142_0
	{
		public PopupWindow YiMSKvHUDXr;

		public int lp2SKSVFLtW;

		internal static _003C_003Ec__DisplayClass142_0 bgXWZ7W5YLPddcIJOmPt;

		internal void n1qSKL0tvpT()
		{
			YiMSKvHUDXr.SetButtonAction(lp2SKSVFLtW, YiMSKvHUDXr.kNxgT9fV6dX.GetAction(lp2SKSVFLtW));
		}

		internal static bool UISRlnW584kkj9KgZlr9()
		{
			return bgXWZ7W5YLPddcIJOmPt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass164_0
	{
		public PopupWindow kG5SKumnxlH;

		public bool rHaSKN5Zjvk;

		internal static _003C_003Ec__DisplayClass164_0 d81e5IW5g8uKRwyXbVC0;

		internal void pxASK2IIZP3(object sender, EventArgs e)
		{
			kG5SKumnxlH.dn0gTiKcfHo = false;
			kG5SKumnxlH.r5wgTU44PvQ = null;
			kG5SKumnxlH.Y63gTlKn23g = false;
			if (rHaSKN5Zjvk)
			{
				kG5SKumnxlH.zhBgThuh0yr.ToggleLockPanel(false);
			}
		}

		internal static bool kmnseFW5PyhNs2T4OW5a()
		{
			return d81e5IW5g8uKRwyXbVC0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public PopupWindow f1ESKPSKmxL;

		public ActionButton L3dSKE2dO7g;

		internal static _003C_003Ec__DisplayClass1_0 lT1u4nW5UFw7eWATemtQ;

		internal void em9SKJqvU0g(object sender, StylusEventArgs e)
		{
			if (f1ESKPSKmxL.jE6gTjBld5Z.KxCtqDqNIbU())
			{
				f1ESKPSKmxL.jE6gTjBld5Z.ueNtq4hCqtu(f1ESKPSKmxL);
			}
		}

		internal void QrTSK0ghdiJ(object sender, StylusEventArgs e)
		{
			if (f1ESKPSKmxL.jE6gTjBld5Z.KxCtqDqNIbU())
			{
				f1ESKPSKmxL.jE6gTjBld5Z.GTntqnJGe6L();
			}
			if (L3dSKE2dO7g.IsStylusCaptured)
			{
				L3dSKE2dO7g.ReleaseStylusCapture();
			}
		}

		internal void cjcSKCSXNXn(object sender, StylusSystemGestureEventArgs e)
		{
			if (e.SystemGesture == SystemGesture.Tap)
			{
				if (L3dSKE2dO7g.ActionItem != null)
				{
					f1ESKPSKmxL.ExecuteButton((int)L3dSKE2dO7g.Tag, ActionTrigger.Panel, false);
					e.Handled = true;
				}
			}
			else if (e.SystemGesture == SystemGesture.RightTap)
			{
				f1ESKPSKmxL.K0NgDAeAv08(L3dSKE2dO7g);
				e.Handled = true;
			}
			else
			{
				if (e.SystemGesture != SystemGesture.RightDrag || !f1ESKPSKmxL.g7OgTVU3nuu.hfGtbAvJrRQ(true))
				{
					return;
				}
				if (!f1ESKPSKmxL.jE6gTjBld5Z.KxCtqDqNIbU())
				{
					ActionItem actionItem = L3dSKE2dO7g.ActionItem;
					int num = 0;
					if (!GmVjbiW5xNOAa0t2CCc7())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					if (actionItem != null && actionItem.XBttcfC2xjC())
					{
						f1ESKPSKmxL.jE6gTjBld5Z.S0utq5GWhlA(actionItem, f1ESKPSKmxL, e.GetPosition(L3dSKE2dO7g), f1ESKPSKmxL.zhBgThuh0yr, f1ESKPSKmxL.Q2GgTZX1xMq, f1ESKPSKmxL.bmIgTGywI3A, f1ESKPSKmxL.g7OgTVU3nuu, f1ESKPSKmxL.NWFgTfXdknO);
					}
				}
				L3dSKE2dO7g.CaptureStylus();
				e.Handled = true;
			}
		}

		internal static void EuSQsGW56wgndRO6KUoR()
		{
		}

		internal static bool GmVjbiW5xNOAa0t2CCc7()
		{
			return lT1u4nW5UFw7eWATemtQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public ActionProfile DHMSK8eR7eV;

		public PopupWindow hUJSKaQLxiL;

		internal static _003C_003Ec__DisplayClass20_0 iWQqX4W5wW6YYb5oZajr;

		internal void WopSKyu5Tml(object sender, RoutedEventArgs e)
		{
			hUJSKaQLxiL.pqLgT1i3kQh.RequestSwitchProfile(DHMSK8eR7eV.Id, false);
		}

		internal static bool uM3je1W5Tq9UABhyOSEC()
		{
			return iWQqX4W5wW6YYb5oZajr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_1
	{
		public ActionProfile XRlSKRSMrHA;

		public PopupWindow H9FSKql3J0Y;

		internal static _003C_003Ec__DisplayClass20_1 drIlyPW5sxuR7uV6JV3v;

		internal void e4kSK7aLPa0(object sender, RoutedEventArgs e)
		{
			H9FSKql3J0Y.pqLgT1i3kQh.RequestSwitchProfile(XRlSKRSMrHA.Id, false);
		}

		internal static bool l3Mh2MW5CU1p7y5PswyR()
		{
			return drIlyPW5sxuR7uV6JV3v == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass210_0
	{
		public PopupWindow i95SKV6Ci8d;

		public System.Windows.Controls.ContextMenu MhlSKZFkomY;

		internal static _003C_003Ec__DisplayClass210_0 WQT8MoW542aODQJFiKNP;

		internal void Mj5SKcGot1R(object sender, RoutedEventArgs e)
		{
			if (i95SKV6Ci8d.BtnToggleLock.ContextMenu == MhlSKZFkomY)
			{
				i95SKV6Ci8d.BtnToggleLock.ContextMenu = null;
			}
		}

		internal static bool jtPs4LW5h1SyZSw4GoIs()
		{
			return WQT8MoW542aODQJFiKNP == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass214_0
	{
		public string nRJSKhb93kr;

		private static _003C_003Ec__DisplayClass214_0 QBr0itWYV2yF0q2xoxHu;

		internal bool jmdSK9ewQuR(SpecialExeItem x)
		{
			return string.Equals(x.ExeName, nRJSKhb93kr, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool y9jkoqWYQPIPRUNUfALE()
		{
			return QBr0itWYV2yF0q2xoxHu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass214_1
	{
		public string Yt7SKY4ERYc;

		private static _003C_003Ec__DisplayClass214_1 w1LN2XWYcGpREgyshpBk;

		internal bool DZTSKeEyIln(SpecialExeItem x)
		{
			return string.Equals(x.ExeName, Yt7SKY4ERYc, StringComparison.OrdinalIgnoreCase);
		}

		static _003C_003Ec__DisplayClass214_1()
		{
		}

		internal static bool QRFaodWYWjeLnRs6WH22()
		{
			return w1LN2XWYcGpREgyshpBk == null;
		}

		internal static void o5NGiTWYpU1RyuFUm3Ap()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public PopupWindow lpISKWmtqy9;

		public PopupSource qKnSKkYmCCf;

		public bool? Jq1SKG1ixe3;

		private static _003C_003Ec__DisplayClass28_0 urqgJkWYXsgB3PrsursH;

		internal void QN0SKIuPgcQ()
		{
			lpISKWmtqy9.EnableKeyTrigger = (qKnSKkYmCCf.IsEither(PopupSource.Keyboard) || (qKnSKkYmCCf == PopupSource.Action && lpISKWmtqy9.g7OgTVU3nuu.CpItmVISR7P().EnableKeyTriggerWhenPopupByMouse) || (qKnSKkYmCCf == PopupSource.Mouse && lpISKWmtqy9.g7OgTVU3nuu.CpItmVISR7P().EnableKeyTriggerWhenPopupByMouse)) && lpISKWmtqy9.CanCloseWindow();
			lpISKWmtqy9.AdjustWindowPosition(qKnSKkYmCCf, Jq1SKG1ixe3);
			int num = 0;
			if (urqgJkWYXsgB3PrsursH != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (qKnSKkYmCCf != PopupSource.Action)
			{
				lpISKWmtqy9.PhNgTejR2Z6.RaiseOne(true);
			}
			lpISKWmtqy9.yDTgd9BT63o(true, true);
			lpISKWmtqy9.ShowActivated = false;
			lpISKWmtqy9.Show();
			lpISKWmtqy9.dkRgTIAHVjG.CountPopup();
			lpISKWmtqy9._isFirstShow = false;
		}

		internal static bool LKAirjWY2AehMyN6gWhJ()
		{
			return urqgJkWYXsgB3PrsursH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public PopupWindow m2RSKHESm1Y;

		public bool? uDNSK13gEDt;

		internal static _003C_003Ec__DisplayClass40_0 jfJwbfWYD8Dv4BJuvOAg;

		internal void u3hSKsLED2i()
		{
			m2RSKHESm1Y.AdjustWindowPosition(PopupSource.Mouse, uDNSK13gEDt);
		}

		static _003C_003Ec__DisplayClass40_0()
		{
		}

		internal static bool HYTP7QWY30HCdwW6G8lf()
		{
			return jfJwbfWYD8Dv4BJuvOAg == null;
		}

		internal static void j7u7ROWYG9hZLTpIDO3I()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CActionButton_Drop_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public PopupWindow _003C_003E4__this;

		public System.Windows.DragEventArgs e;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object K20yjlWY0qyyTaQMsMKv;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
				int num2;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					ActionButton actionButton = (ActionButton)sender;
					if (actionButton.IsSelected)
					{
						num2 = 1;
						if (!GICY0tWY1yEIPYyV2D3c())
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_0101;
					}
					int num4 = (int)actionButton.Tag;
					ActionProfile profileByButtonIndex = popupWindow.kNxgT9fV6dX.GetProfileByButtonIndex(num4);
					(bool, int, int) buttonLocation = AppHelper.GetButtonLocation(num4);
					awaiter = popupWindow.bmIgTGywI3A.OnActionButtonDrop(profileByButtonIndex, buttonLocation.Item2, buttonLocation.Item3, e, popupWindow).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				num2 = 0;
				if (GICY0tWY1yEIPYyV2D3c())
				{
					goto IL_0101;
				}
				goto end_IL_0010;
				IL_0101:
				switch (num2)
				{
				case 1:
					AppHelper.ShowWarning("动作正在编辑。");
					break;
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool GICY0tWY1yEIPYyV2D3c()
		{
			return K20yjlWY0qyyTaQMsMKv == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnClose_OnDrop_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public System.Windows.DragEventArgs e;

		public PopupWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object OvgeyVWYBKZUaEVBB2aR;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0111;
				}
				if (e.Data.GetDataPresent("quicker-action-drag-item"))
				{
					ActionItemDragObject actionItemDragObject = (ActionItemDragObject)e.Data.GetData("quicker-action-drag-item");
					int num2 = 1;
					if (OvgeyVWYBKZUaEVBB2aR != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							if (actionItemDragObject != null)
							{
								ActionProfile profileById = popupWindow.NgEgTYG5V1w.GetProfileById(actionItemDragObject.ProfileId);
								awaiter = AppState.lWutartRfUY().DeleteAction(profileById, actionItemDragObject.Action, false, false).ConfigureAwait(true)
									.GetAwaiter();
								if (awaiter.IsCompleted)
								{
									break;
								}
								num = 0;
								_003C_003E1__state = 0;
								num2 = 0;
								if (OvgeyVWYBKZUaEVBB2aR != null)
								{
									continue;
								}
								goto default;
							}
							AppHelper.ShowWarning("请将动作托到此按钮上将其删除。");
							goto end_IL_00be;
						default:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0111;
						continue;
						end_IL_00be:
						break;
					}
				}
				goto end_IL_0010;
				IL_0111:
				awaiter.GetResult();
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool LakNvAWYvhXRUhjkUySW()
		{
			return OvgeyVWYBKZUaEVBB2aR == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLblCreateProfileForApp_OnPreviewMouseDown_003Ed__154 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public PopupWindow _003C_003E4__this;

		private string _003CfilePathName_003E5__2;

		private ExeSettings _003CexeSettings_003E5__3;

		private ConfiguredTaskAwaitable<ExeFileVersionDto>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object TK2Z8qWYrIdq5lDTq6Nc;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
        NewExeSettingsWindow newExeSettingsWindow = default;
				if (num == 0)
				{
					goto IL_01b2;
				}
				_003CfilePathName_003E5__2 = (sender as TextBlock)?.Tag as string;
				int num2;
				newExeSettingsWindow = default(NewExeSettingsWindow);
				if (string.IsNullOrEmpty(_003CfilePathName_003E5__2))
				{
					AppHelper.ShowWarning("应用程序文件名无效。");
				}
				else
				{
					popupWindow.LblCreateProfileForApp.Visibility = Visibility.Collapsed;
					if (CommonExeInfo.IsCommonExe(_003CfilePathName_003E5__2))
					{
						CreateProfileDto dto = new CreateProfileDto
						{
							ExeFilePathName = _003CfilePathName_003E5__2,
							ProfileName = CommonExeInfo.GetCommonExeName(_003CfilePathName_003E5__2)
						};
						popupWindow.zhBgThuh0yr.AddProfile(dto);
						popupWindow.pqLgT1i3kQh.ChangeExe(_003CfilePathName_003E5__2);
						num2 = 2;
						if (TK2Z8qWYrIdq5lDTq6Nc != null)
						{
							goto IL_0278;
						}
					}
					else
					{
						if (popupWindow.g7OgTVU3nuu.Hb9tmk3OsJ7() || popupWindow.g7OgTVU3nuu.LDPtXifl4Ca() < 10)
						{
							newExeSettingsWindow = new NewExeSettingsWindow(popupWindow.g7OgTVU3nuu.mP6tXA8VyNP().Values.Select(_003C_003Ec.OMcSmoK4VMD ?? (_003C_003Ec.OMcSmoK4VMD = _003C_003Ec.WwOSm6GOS4m.th9Sm1aw1di)).Distinct().ToList(), popupWindow.g7OgTVU3nuu, _003CfilePathName_003E5__2)
							{
								Owner = popupWindow,
								ShowCustomItem = false
							};
							popupWindow.IsDialogOpen = true;
							if (newExeSettingsWindow.ShowDialog() == true)
							{
								_003CexeSettings_003E5__3 = new ExeSettings
								{
									Exe = newExeSettingsWindow.LoweredExeFileName,
									Path = newExeSettingsWindow.ExePathName,
									Name = newExeSettingsWindow.ExeName,
									AliasExeList = newExeSettingsWindow.AliasExeList,
									UrlPattern = newExeSettingsWindow.UrlPattern
								};
								goto IL_01b2;
							}
							goto IL_02fe;
						}
						AppHelper.ShowWarning("免费版可创建10个应用程序场景，已达到限额。请购买专业版后再使用此功能。");
					}
				}
				goto end_IL_000e;
				IL_028b:
				popupWindow.g7OgTVU3nuu.a65t6APblky(_003CexeSettings_003E5__3);
				CreateProfileDto dto2 = new CreateProfileDto
				{
					ExeFilePathName = _003CexeSettings_003E5__3.Path,
					ProfileName = _003CexeSettings_003E5__3.Name
				};
				popupWindow.zhBgThuh0yr.AddProfile(dto2);
				popupWindow.pqLgT1i3kQh.ChangeExe(_003CfilePathName_003E5__2);
				_003CexeSettings_003E5__3 = null;
				num2 = 0;
				if (TK2Z8qWYrIdq5lDTq6Nc != null)
				{
					goto IL_0278;
				}
				goto IL_02fe;
				IL_0278:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_02fe;
				case 2:
					goto end_IL_000e;
				}
				goto IL_028b;
				IL_02fe:
				popupWindow.IsDialogOpen = false;
				goto end_IL_000e;
				IL_01b2:
				try
				{
					ConfiguredTaskAwaitable<ExeFileVersionDto>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = popupWindow.zhBgThuh0yr.SaveFileVersionInfo(newExeSettingsWindow.ExePathName).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							if (TK2Z8qWYrIdq5lDTq6Nc != null)
							{
								switch (0)
								{
								}
							}
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ExeFileVersionDto>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ExeFileVersionDto result = awaiter.GetResult();
					if (result != null)
					{
						_003CexeSettings_003E5__3.IconUrl = result.FileIconUrl;
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("无法保存应用程序信息。" + ex.Message);
					goto end_IL_000e;
				}
				goto IL_028b;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CfilePathName_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CfilePathName_003E5__2 = null;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool TJhO0HWYNPk0ofMsyms7()
		{
			return TK2Z8qWYrIdq5lDTq6Nc == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuCheckUpdate_OnClick_003Ed__240 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PopupWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object t6v3XWWYbs1J4GeqXvd3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					popupWindow.RequestHide();
					awaiter = SoftVersionHelper.ShowUpdateVersionWindow().ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (!lXNw2eWYqTKELJ7QFb5N())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool lXNw2eWYqTKELJ7QFb5N()
		{
			return t6v3XWWYbs1J4GeqXvd3 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuMaintainTools_OnClick_003Ed__243 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PopupWindow _003C_003E4__this;

		private static object IMlOWhWYlxg3rJGSYXrY;

		private void MoveNext()
		{
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
				popupWindow.RequestHide();
				AppHelper.ShrinkDbFile();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool BdsZofWYZidjfggyBORv()
		{
			return IMlOWhWYlxg3rJGSYXrY == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuOpenGuide_OnClick_003Ed__227 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PopupWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object xYxiaOWYYxmhvaL60cDl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					popupWindow.RequestHide();
					awaiter = krvQ8AAu3nWMBowhIM6.cm6Ow5ljga().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				int num2 = 0;
				if (!VWJXhDWY8Pbb7o5jfKKV())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool VWJXhDWY8Pbb7o5jfKKV()
		{
			return xYxiaOWYYxmhvaL60cDl == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuPushToPc_OnClick_003Ed__248 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PopupWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object CKykqFWYgEKN9m5TBBFo;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = AppHelper.tNBLTbaIvty("/member/pushtools").ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						if (!X5QImSWYPFhW5ftnbd0L())
						{
							switch (0)
							{
							}
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				popupWindow.RequestHide();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool X5QImSWYPFhW5ftnbd0L()
		{
			return CKykqFWYgEKN9m5TBBFo == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuUpdateVersion_OnClick_003Ed__231 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PopupWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object ILVifOWYtoJ2vnD0vroA;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					popupWindow.RequestHide();
					ConfiguredTaskAwaitable configuredTaskAwaitable = SoftVersionHelper.ShowUpdateVersionWindow().ConfigureAwait(true);
					int num2 = 0;
					if (ILVifOWYtoJ2vnD0vroA != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					awaiter = configuredTaskAwaitable.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool wHS4H5WYSZDjDd2uec6h()
		{
			return ILVifOWYtoJ2vnD0vroA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWindow_OnLoaded_003Ed__131 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PopupWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Qo7R4qWYmRbc7bNktTFQ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PopupWindow popupWindow = _003C_003E4__this;
			try
			{
        ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
				if (num != 0)
				{
					goto IL_00e8;
				}
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_01a3;
				IL_00d1:
				int num2;
				switch (num2)
				{
				case 2:
					goto IL_00e8;
				case 1:
					goto IL_01af;
				case 3:
					goto IL_0267;
				}
				goto IL_00bb;
				IL_01a3:
				awaiter.GetResult();
				goto IL_0035;
				IL_0035:
				popupWindow.UpdateUIAppearence(AppState.DataService.CpItmVISR7P());
				popupWindow.ShowCreateActionIcon = AppState.HHxtaMaoqJr().ShowMenuWhenLeftClickEmptyButton;
				popupWindow.MenuSyncNow.Visibility = (popupWindow.g7OgTVU3nuu.JTftmqIPFYx() ? Visibility.Collapsed : Visibility.Visible);
				popupWindow.OCHgdTAct0q();
				popupWindow.dkRgTIAHVjG.loDt8lkCi0B();
				popupWindow.sIXgd7d5gV3();
				num2 = 0;
				if (Qo7R4qWYmRbc7bNktTFQ != null)
				{
					goto IL_00bb;
				}
				goto IL_00d1;
				IL_00e8:
				popupWindow.Loaded -= popupWindow.KTqgdeBwCr9;
				OperatingSystem oSVersion = Environment.OSVersion;
				xI5gTmj2IYG.Info($"Windows 版本:{oSVersion.Version.Major}_{oSVersion.Version.Minor}");
				popupWindow.NgIgTrSZ9xe = new NotifyIconWrapper(popupWindow, popupWindow.TsTgTsR7sUb, popupWindow.CF9gTzcAI6X);
				if (!AppState.DataService.CpItmVISR7P().IsAutoMinimize)
				{
					goto IL_0035;
				}
				awaiter = Task.Delay(100).ContinueWith(popupWindow.hDcgolFjkPK, TaskScheduler.Current).ConfigureAwait(true)
					.GetAwaiter();
				if (awaiter.IsCompleted)
				{
					goto IL_01a3;
				}
				num = 0;
				_003C_003E1__state = 0;
				_003C_003Eu__1 = awaiter;
				goto IL_0267;
				IL_01ba:
				popupWindow.I52gogjXQrb();
				popupWindow.gvNgdVE3CQb();
				popupWindow.MenuOpenUserHome.Header = "本地数据文件夹";
                popupWindow.MenuSyncNow.Header = "保存到本地";
                popupWindow.BtnSync.ToolTip = "保存到本地";
                popupWindow.MenuCheckUpdate.Header = "手动更新说明";
				Task.Run((Action)popupWindow.Xa7go3quBlb);
				popupWindow.yGCgT6Atain = new SystemEventsWatcher();
				popupWindow.yGCgT6Atain.Start();
				AppState.StGta80AIo8();
				goto end_IL_000e;
				IL_01af:
				popupWindow.CF9gTzcAI6X.Start();
				goto IL_01ba;
				IL_00bb:
				while (AppState.DataService.CpItmVISR7P().EnableTextFloatingPanel)
				{
					num2 = 1;
					if (!ebLpDjWYsjYU9S3084cS())
					{
						continue;
					}
					goto IL_00d1;
				}
				goto IL_01ba;
				IL_0267:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool ebLpDjWYsjYU9S3084cS()
		{
			return Qo7R4qWYmRbc7bNktTFQ == null;
		}
	}

	public static readonly DependencyProperty ShowCreateActionIconProperty;

	[CompilerGenerated]
	private DateTime R8HgTR8UvCh = DateTime.MinValue;

	public bool _isFirstShow = true;

	private bool h9kgTqgGkZm;

	private readonly IKernel ItFgTcDUDd5;

	private readonly DataService g7OgTVU3nuu;

	private readonly ITinyMessengerHub Q2GgTZX1xMq;

	private readonly PanelState kNxgT9fV6dX;

	private readonly AppServer zhBgThuh0yr;

	private readonly ActiveWindowHook PhNgTejR2Z6;

	private readonly ProfileManager NgEgTYG5V1w;

	private readonly UsageCounter dkRgTIAHVjG;

	private readonly PopupState RYsgTWmiFr7;

	private readonly IconManager vYrgTkN08tx;

	private readonly ActionEditMgr bmIgTGywI3A;

	private readonly RunningActionMgr TsTgTsR7sUb;

	private readonly SQLDataMgr ReYgTHIbpgu;

	private readonly ProfileSwitcher pqLgT1i3kQh;

	private readonly AutoRunService PjxgTbSvqdK;

	private SystemEventsWatcher yGCgT6Atain;

	private static readonly System.Windows.Media.Brush mThgTXnjjlO;

	public static readonly DependencyProperty ButtonColorProperty;

	private static readonly ILog xI5gTmj2IYG;

	private IDictionary<int, ActionButton> KtigTKfrjpl;

	[CompilerGenerated]
	private bool v9VgTxNXR72;

	public static readonly DependencyProperty EnableSimpleModeProperty;

	private NotifyIconWrapper NgIgTrSZ9xe;

	private bool th0gTpxuApB;

	private bool LK5gTBqEdCZ;

	private Notifier zyagTQA9eBD;

	private readonly khuggB2ZntAfW2CDU1r jE6gTjBld5Z = new khuggB2ZntAfW2CDU1r();

	[CompilerGenerated]
	private PointTargetInfo omugTnFhDXn;

	private bool VnfgT4Q88CR;

	[CompilerGenerated]
	private PopupSource YJwgT5woCHv;

	private static uint V36gTD6CTD9;

	public const int WM_DISPLAYCHANGE = 126;

	private double ek1gTdHbRXY;

	private double y4PgToqFZls;

	private readonly double j18gTTjg6Cx = 40.0;

	private int EVjgTMjDIXs;

	private System.Windows.Point x8TgTAbpce6;

	private ActionButton iIGgTOgxv7L;

	private ExeSettingsWindow X1LgTFW6ma1;

	private ToolboxWindow2 r5wgTU44PvQ;

	private bool Y63gTlKn23g;

	private bool dn0gTiKcfHo;

	private SearchWindow wYegT3agQwi;

	private readonly FloatButtonAndPanelManager NWFgTfXdknO;

	private readonly TextFloatPanelMgr CF9gTzcAI6X;

	private readonly PushClient UNDgMw2Nanh;

	[CompilerGenerated]
	private DashboardWindow BqOgMtRDh1Z;

	private RecorderWindow PiigMgST5vU;

	private FaIconSelectorWindow ltIgML7eYpt;

	internal PopupWindow TheWindow;

	internal Border BorderBody;

	internal Grid GridBody;

	internal Border GridHeader;

	internal System.Windows.Controls.Label LblAppTitle;

	internal System.Windows.Controls.Button BtnSettingsNew;

	internal System.Windows.Controls.Button BtnStartVoiceInput;

	internal DropDownButton BtnMenu;

	internal SvgAwesome SettingMenuStatusIcon;

	internal System.Windows.Controls.ContextMenu MainContextMenu1;

	internal System.Windows.Controls.MenuItem MenuOpenSettings;

	internal System.Windows.Controls.MenuItem MenuProfileManage;

	internal System.Windows.Controls.MenuItem MenuPowerKeys;

	internal System.Windows.Controls.MenuItem MenuTextCommand;

	internal System.Windows.Controls.MenuItem MenuLeftButtonPlus;

	internal System.Windows.Controls.MenuItem MenuMouseSettings;

	internal System.Windows.Controls.MenuItem MenuSync;

	internal System.Windows.Controls.MenuItem MenuSyncNow;

	internal System.Windows.Controls.MenuItem MenuSyncHistory;

	internal System.Windows.Controls.MenuItem MenuCheckUpdate;

	internal System.Windows.Controls.MenuItem MenuCheckActionUpdate;

	internal System.Windows.Controls.MenuItem MenuActionRecycleBin;

	internal System.Windows.Controls.MenuItem MenuExportActionsCsv;

	internal System.Windows.Controls.MenuItem MenuMaintainTools;

	internal System.Windows.Controls.MenuItem MenuResetTextFloatPanelState;

	internal System.Windows.Controls.MenuItem MenuKeyboardState;

	internal System.Windows.Controls.MenuItem MenuRegisterChromeAgent;

	internal System.Windows.Controls.MenuItem MenuShowFloatTrigger;

	internal System.Windows.Controls.MenuItem MenuInstallEdge;

	internal System.Windows.Controls.MenuItem MenuOpenGuide;

	internal System.Windows.Controls.MenuItem MenuOpenHelp;

	internal System.Windows.Controls.MenuItem MenuSendFeedback;

	internal System.Windows.Controls.MenuItem MenuViewUsage;

	internal System.Windows.Controls.MenuItem MenuUpdateVersion;

	internal System.Windows.Controls.Button BtnSync;

	internal SyncStateControl SyncStateControl;

	internal DropDownButton MenuUser;

	internal SvgAwesome ConnectionStatusIcon;

	internal System.Windows.Controls.ContextMenu MainContextMenuUser;

	internal System.Windows.Controls.MenuItem MenuOpenUserHome;

	internal SvgAwesome iconPushState;

	internal TextBlock txtPushState;

	internal System.Windows.Controls.MenuItem MenuConnectPushServer;

	internal System.Windows.Controls.MenuItem MenuDisconnectPushServer;

	internal System.Windows.Controls.MenuItem MenuSetActiveClient;

	internal System.Windows.Controls.MenuItem MenuPushToPc;

	internal System.Windows.Controls.MenuItem BtnClientConnection;

	internal System.Windows.Controls.Button BtnPin;

	internal SvgAwesome IconPin;

	internal System.Windows.Controls.Button BtnClose;

	internal Canvas GlobalBtnCanvas;

	internal Grid GridMiddleToolbar;

	internal IconControl ImgProfileExeIcon;

	internal TextBlock LblProfile;

	internal System.Windows.Controls.Button BtnSearch;

	internal System.Windows.Controls.Button BtnToggleLock;

	internal SvgAwesome IconLock;

	internal DropDownButton BtnToolboxMenu;

	internal System.Windows.Controls.ContextMenu MenuToolbox;

	internal System.Windows.Controls.MenuItem MenuShowToolbox;

	internal System.Windows.Controls.MenuItem MenuShowAppSelector;

	internal System.Windows.Controls.MenuItem MenuOpenShareBase;

	internal System.Windows.Controls.MenuItem MenuOpenFaIconSelector;

	internal ProfileNavIndicator GlobalProfileNavIndicator;

	internal ProfileNavIndicator ProfileNavIndicator;

	internal Canvas ContextBtnCanvas;

	internal TextBlock LblCreateProfileForApp;

	internal System.Windows.Controls.Button BtnOpenProcessFolder;

	internal System.Windows.Controls.Button BtnBlockCreateProfileHint;

	internal System.Windows.Controls.Button BtnAddToBlockList;

	private bool SMQgMv3kH06;

	internal static PopupWindow KFAA56FF0QDLtiRxUqXm;

	public bool ShowCreateActionIcon
	{
		get
		{
			return (bool)GetValue(ShowCreateActionIconProperty);
		}
		set
		{
			SetValue(ShowCreateActionIconProperty, value);
		}
	}

	public DateTime PopupWindowShowTime
	{
		[CompilerGenerated]
		get
		{
			return R8HgTR8UvCh;
		}
		[CompilerGenerated]
		private set
		{
			R8HgTR8UvCh = value;
		}
	}

	public bool EnableKeyTrigger
	{
		get
		{
			return h9kgTqgGkZm;
		}
		set
		{
			h9kgTqgGkZm = value;
			SetValue(ActionButton.ShowKeyTipProperty, value);
		}
	}

	public System.Windows.Media.Brush ButtonColor
	{
		get
		{
			return (System.Windows.Media.Brush)GetValue(ButtonColorProperty);
		}
		set
		{
			SetValue(ButtonColorProperty, value);
		}
	}

	public bool EnableSimpleMode
	{
		get
		{
			return (bool)GetValue(EnableSimpleModeProperty);
		}
		set
		{
			SetValue(EnableSimpleModeProperty, value);
		}
	}

	public bool IsDialogOpen
	{
		get
		{
			return th0gTpxuApB;
		}
		private set
		{
			th0gTpxuApB = value;
			base.ShowInTaskbar = th0gTpxuApB;
			if (th0gTpxuApB)
			{
				EnableKeyTrigger = false;
			}
		}
	}

	public bool IsPinned
	{
		get
		{
			return ls6gTJ8FOku();
		}
		set
		{
			D38gT0DoXMr(value);
			IconPin.Icon = (ls6gTJ8FOku() ? EFontAwesomeIcon.Solid_Thumbtack : EFontAwesomeIcon.Light_Thumbtack);
			IconPin.Rotation = ((!ls6gTJ8FOku()) ? 45 : 0);
		}
	}

	public PointTargetInfo TargetInfo
	{
		[CompilerGenerated]
		get
		{
			return omugTnFhDXn;
		}
		[CompilerGenerated]
		private set
		{
			omugTnFhDXn = value;
		}
	}

	public PopupSource PopupSource
	{
		[CompilerGenerated]
		get
		{
			return YJwgT5woCHv;
		}
		[CompilerGenerated]
		private set
		{
			YJwgT5woCHv = value;
		}
	}

	public DashboardWindow DashboardWindow
	{
		[CompilerGenerated]
		get
		{
			return BqOgMtRDh1Z;
		}
		[CompilerGenerated]
		private set
		{
			BqOgMtRDh1Z = value;
		}
	}

	private void e0ggDnVA3UN()
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.wlnSmOJIK9L = this;
		KtigTKfrjpl = new Dictionary<int, ActionButton>();
		_003C_003Ec__DisplayClass0_.uqeSmF5Q4rV = FindResource("ScaleButton") as Style;
		double buttonSize = g7OgTVU3nuu.CpItmVISR7P().UiSettings.ButtonSize;
		double buttonSpace = g7OgTVU3nuu.CpItmVISR7P().UiSettings.ButtonSpace;
		int num = 0;
		if (!fWVT2mFF1RiQemAUASaA())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		double num3 = ((g7OgTVU3nuu.CpItmVISR7P().UiSettings.ButtonCornerRadius > 0.0) ? buttonSpace : 0.0);
		GlobalBtnCanvas.Width = buttonSize * 4.0 + buttonSpace * 3.0;
		GlobalBtnCanvas.Height = buttonSize * 3.0 + buttonSpace * 4.0;
		ContextBtnCanvas.Width = buttonSize * 4.0 + buttonSpace * 3.0;
		ContextBtnCanvas.Height = buttonSize * 4.0 + buttonSpace * 3.0 + num3;
		AppHelper.CreateButtonsOnCanvas(GlobalBtnCanvas, 3, 4, true, buttonSize, buttonSpace, KtigTKfrjpl, num3, _003C_003Ec__DisplayClass0_.xvNSmM9qUDA);
		AppHelper.CreateButtonsOnCanvas(ContextBtnCanvas, 4, 4, false, buttonSize, buttonSpace, KtigTKfrjpl, num3, _003C_003Ec__DisplayClass0_.L5wSmAugCeZ);
	}

	private void idtgD4i0iZE(ActionButton actionButton_1, Style style_0)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.f1ESKPSKmxL = this;
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g = actionButton_1;
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.Style = style_0;
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.PreviewMouseUp += EVUgDob8Rg0;
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.PreviewMouseMove += bAogDT4H8fn;
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.Drop += JaSgDMrhJ7y;
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.PreviewMouseWheel += ijPgDdKaF0e;
		if (fWVT2mFF1RiQemAUASaA())
		{
			switch (0)
			{
			}
		}
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.PreviewMouseDown += S0TgDDyG41x;
		_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.PreviewMouseWheel += VspgD5fq5BP;
		if (VnfgT4Q88CR)
		{
			_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.TouchUp += _003C_003Ec.KVNSmX5cApW ?? (_003C_003Ec.KVNSmX5cApW = _003C_003Ec.WwOSm6GOS4m.JBESmq0V8Ql);
			_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.PreviewTouchMove += _003C_003Ec.AA7SmmH3lpL ?? (_003C_003Ec.AA7SmmH3lpL = _003C_003Ec.WwOSm6GOS4m.wn3SmcegKfC);
			_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.StylusMove += _003C_003Ec__DisplayClass1_.em9SKJqvU0g;
			_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.StylusUp += _003C_003Ec__DisplayClass1_.QrTSK0ghdiJ;
			_003C_003Ec__DisplayClass1_.L3dSKE2dO7g.StylusSystemGesture += _003C_003Ec__DisplayClass1_.cjcSKCSXNXn;
		}
	}

	private void VspgD5fq5BP(object sender, MouseWheelEventArgs e)
	{
	}

	private void S0TgDDyG41x(object sender, MouseButtonEventArgs e)
	{
		iIGgTOgxv7L = sender as ActionButton;
		x8TgTAbpce6 = e.GetPosition(iIGgTOgxv7L);
		jE6gTjBld5Z.GTntqnJGe6L();
	}

	private void ijPgDdKaF0e(object sender, MouseWheelEventArgs e)
	{
		ActionButton actionButton = sender as ActionButton;
		if (actionButton.ActionItem != null && actionButton.ActionItem.AllowScrollTrigger)
		{
			Q2GgTZX1xMq.NotifyRunAction(this, actionButton.ActionItem.Id, false, false, ActionTrigger.ScrollOnButton, false, TargetInfo, ActionHelper.GetScrollActionParam(e.Delta));
		}
	}

	public bool IsMouseMovedAfterPopup()
	{
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		if (RYsgTWmiFr7.MouseDownTargetInfo == null)
		{
			return true;
		}
		if (AppHelper.IsFarThan(mousePosition, RYsgTWmiFr7.MouseDownTargetInfo.Point, 10))
		{
			return true;
		}
		return false;
	}

	private void EVUgDob8Rg0(object sender, MouseButtonEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		int btnIndex = (int)actionButton.Tag;
		x8TgTAbpce6.X = -1.0;
		x8TgTAbpce6.Y = -1.0;
		int num;
		if (!actionButton.IsMouseCaptured || !jE6gTjBld5Z.KxCtqDqNIbU())
		{
			if (e.ChangedButton != MouseButton.Left && e.ChangedButton != MouseButton.Middle)
			{
				if (e.ChangedButton != MouseButton.Right)
				{
					goto IL_011c;
				}
				num = 1;
				if (fWVT2mFF1RiQemAUASaA())
				{
					goto IL_00f8;
				}
				goto IL_0134;
			}
			goto IL_0167;
		}
		goto IL_01f4;
		IL_0167:
		if (e.ChangedButton == MouseButton.Right)
		{
			AppHelper.ShowWarning("右键MouseUp触发动作！");
			Q2GgTZX1xMq.RequestReinstallHook(this);
		}
		if (!IsDialogOpen && !IsPinned && PopupSource == PopupSource.Mouse && !IsMouseMovedAfterPopup())
		{
			return;
		}
		ActionItem action = kNxgT9fV6dX.GetAction(btnIndex);
		if (action != null)
		{
			if (Keyboard.Modifiers == ModifierKeys.Shift)
			{
				if (!Keyboard.IsKeyDown(Key.LeftShift))
				{
					if (Keyboard.IsKeyDown(Key.RightShift))
					{
						ExecuteButton(btnIndex, ActionTrigger.Panel, true);
						num = 0;
						if (KFAA56FF0QDLtiRxUqXm == null)
						{
							return;
						}
						goto IL_0134;
					}
					return;
				}
				bmIgTGywI3A.EditActionByButtonIndex(btnIndex, action, Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl));
				return;
			}
			ExecuteButton(btnIndex, ActionTrigger.Panel, false);
			return;
		}
		if (Keyboard.Modifiers == ModifierKeys.None)
		{
			if (g7OgTVU3nuu.CpItmVISR7P().ShowMenuWhenLeftClickEmptyButton)
			{
				K0NgDAeAv08(actionButton);
			}
		}
		else if (Keyboard.Modifiers == ModifierKeys.Shift)
		{
			bmIgTGywI3A.CreateActionByButtonIndex(btnIndex, ActionType.XAction);
		}
		return;
		IL_0179:
		if (Keyboard.Modifiers == ModifierKeys.None)
		{
			K0NgDAeAv08((ActionButton)sender);
		}
		else if (Keyboard.Modifiers == ModifierKeys.Control && g7OgTVU3nuu.hfGtbAvJrRQ(true))
		{
			RequestHide();
			FloatPanelWindow floatPanelWindow = new FloatPanelWindow(kNxgT9fV6dX.GetProfileByButtonIndex(btnIndex), null, zhBgThuh0yr, Q2GgTZX1xMq, bmIgTGywI3A, g7OgTVU3nuu, NWFgTfXdknO);
			floatPanelWindow.Show();
			IHNRIiikxBwJdYmHpM3.p1AvvooEqum(floatPanelWindow, ShowWindowLocation.WithMouse1);
		}
		return;
		IL_0134:
		switch (num)
		{
		case 2:
			break;
		default:
			return;
		case 0:
			return;
		case 1:
			goto IL_0179;
		case 3:
			goto IL_01f4;
		}
		goto IL_00f8;
		IL_011c:
		if (e.ChangedButton == MouseButton.Right)
		{
			num = 0;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				goto IL_0134;
			}
			goto IL_0179;
		}
		return;
		IL_01f4:
		jE6gTjBld5Z.GTntqnJGe6L();
		e.Handled = true;
		actionButton.ReleaseMouseCapture();
		return;
		IL_00f8:
		if (!RYsgTWmiFr7.IsMouseDownCaptured(MouseButtons.Right) || !g7OgTVU3nuu.CpItmVISR7P().EnableReleaseOnButtonTrigger)
		{
			goto IL_011c;
		}
		goto IL_0167;
	}

	private void bAogDT4H8fn(object sender, System.Windows.Input.MouseEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		if (actionButton.IsMouseCaptured && jE6gTjBld5Z.KxCtqDqNIbU())
		{
			jE6gTjBld5Z.ueNtq4hCqtu(this);
			return;
		}
		if (actionButton != iIGgTOgxv7L)
		{
			return;
		}
		int num = (int)actionButton.Tag;
		int num2 = 2;
		if (!fWVT2mFF1RiQemAUASaA())
		{
			goto IL_01c3;
		}
		goto IL_0204;
		IL_01c3:
		int num3 = default(int);
		num2 = num3;
		goto IL_0204;
		IL_0204:
		ActionItem action = default(ActionItem);
		ActionProfile profileByButtonIndex = default(ActionProfile);
		while (true)
		{
			switch (num2)
			{
			case 4:
				break;
			case 2:
				action = kNxgT9fV6dX.GetAction(num);
				if (action != null)
				{
					profileByButtonIndex = kNxgT9fV6dX.GetProfileByButtonIndex(num);
					if (e.LeftButton == MouseButtonState.Pressed && !LK5gTBqEdCZ)
					{
						break;
					}
					if (System.Windows.Input.Mouse.RightButton == MouseButtonState.Pressed && !jE6gTjBld5Z.KxCtqDqNIbU())
					{
						System.Windows.Point position = e.GetPosition(actionButton);
						if (x8TgTAbpce6.X > 0.0 && (Math.Abs(position.X - x8TgTAbpce6.X) > SystemParameters.MinimumHorizontalDragDistance * 2.0 || Math.Abs(position.Y - x8TgTAbpce6.Y) > SystemParameters.MinimumVerticalDragDistance * 2.0) && g7OgTVU3nuu.hfGtbAvJrRQ(true))
						{
							int int_ = (int)actionButton.Tag;
							if (!g7OgTVU3nuu.Gont6sBnlpf(int_) && Keyboard.Modifiers == ModifierKeys.None && !jE6gTjBld5Z.KxCtqDqNIbU())
							{
								goto case 3;
							}
							return;
						}
						return;
					}
					return;
				}
				return;
			default:
				return;
			case 1:
				jE6gTjBld5Z.S0utq5GWhlA(action, this, x8TgTAbpce6, zhBgThuh0yr, Q2GgTZX1xMq, bmIgTGywI3A, g7OgTVU3nuu, NWFgTfXdknO);
				actionButton.CaptureMouse();
				return;
			case 3:
				if (action != null && action.XBttcfC2xjC())
				{
					jE6gTjBld5Z.S0utq5GWhlA(action, this, x8TgTAbpce6, zhBgThuh0yr, Q2GgTZX1xMq, bmIgTGywI3A, g7OgTVU3nuu, NWFgTfXdknO);
					actionButton.CaptureMouse();
				}
				return;
			case 6:
				jE6gTjBld5Z.S0utq5GWhlA(action, this, x8TgTAbpce6, zhBgThuh0yr, Q2GgTZX1xMq, bmIgTGywI3A, g7OgTVU3nuu, NWFgTfXdknO);
				actionButton.CaptureMouse();
				return;
			case 5:
				return;
			}
			System.Windows.Point position2 = e.GetPosition(actionButton);
			if (!(x8TgTAbpce6.X > 0.0) || (!(Math.Abs(position2.X - x8TgTAbpce6.X) > SystemParameters.MinimumHorizontalDragDistance) && !(Math.Abs(position2.Y - x8TgTAbpce6.Y) > SystemParameters.MinimumVerticalDragDistance)))
			{
				return;
			}
			if (AppState.HHxtaMaoqJr().FloatUseLeftButtonOnPanel)
			{
				if (Keyboard.Modifiers == ModifierKeys.None)
				{
					if (g7OgTVU3nuu.hfGtbAvJrRQ(true) && !jE6gTjBld5Z.KxCtqDqNIbU() && action != null && action.XBttcfC2xjC())
					{
						num2 = 6;
						if (!fWVT2mFF1RiQemAUASaA())
						{
							break;
						}
						continue;
					}
					return;
				}
				if (g7OgTVU3nuu.Gont6sBnlpf(num) || actionButton.IsSelected)
				{
					return;
				}
				(bool, int, int) buttonLocation = AppHelper.GetButtonLocation(num);
				if (action != null && action.ActionType != ActionType.GoParent && (num != 0 || action.ActionType != ActionType.GoParent))
				{
					System.Windows.DataObject data = new System.Windows.DataObject("quicker-action-drag-item", new ActionItemDragObject(profileByButtonIndex.Id, action, buttonLocation.Item2, buttonLocation.Item3));
					LK5gTBqEdCZ = true;
					try
					{
						AppHelper.DoDragDropWrap(actionButton, data, System.Windows.DragDropEffects.Copy | System.Windows.DragDropEffects.Move);
					}
					catch (Exception ex)
					{
						xI5gTmj2IYG.Error("DoDragDrop异常", ex);
						AppHelper.ShowWarning("无法启动拖动：" + ex.Message);
					}
					LK5gTBqEdCZ = false;
				}
				return;
			}
			if (g7OgTVU3nuu.Gont6sBnlpf(num))
			{
				return;
			}
			if (g7OgTVU3nuu.hfGtbAvJrRQ(false) && Keyboard.Modifiers == ModifierKeys.Alt && !jE6gTjBld5Z.KxCtqDqNIbU())
			{
				if (action != null && action.XBttcfC2xjC())
				{
					num2 = 1;
					if (KFAA56FF0QDLtiRxUqXm != null)
					{
						break;
					}
					continue;
				}
				return;
			}
			(bool, int, int) buttonLocation2 = AppHelper.GetButtonLocation(num);
			if (action == null || action.ActionType == ActionType.GoParent || (num == 0 && action.ActionType == ActionType.GoParent))
			{
				return;
			}
			if (actionButton.IsSelected)
			{
				num2 = 0;
				if (KFAA56FF0QDLtiRxUqXm != null)
				{
					break;
				}
				continue;
			}
			System.Windows.DataObject data2 = new System.Windows.DataObject("quicker-action-drag-item", new ActionItemDragObject(profileByButtonIndex.Id, action, buttonLocation2.Item2, buttonLocation2.Item3));
			LK5gTBqEdCZ = true;
			try
			{
				AppHelper.DoDragDropWrap(actionButton, data2, System.Windows.DragDropEffects.Copy | System.Windows.DragDropEffects.Move);
			}
			catch (Exception ex2)
			{
				xI5gTmj2IYG.Error("DoDragDrop异常", ex2);
				AppHelper.ShowWarning("无法启动拖动：" + ex2.Message);
			}
			LK5gTBqEdCZ = false;
			return;
		}
		goto IL_01c3;
	}

	public void ExecuteButton(int btnIndex, ActionTrigger actionTrigger, bool debug)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.himSmfvPy4N = this;
		_003C_003Ec__DisplayClass12_.xcuSmzK9VXX = btnIndex;
		_003C_003Ec__DisplayClass12_.r2ySKtoMnUk = actionTrigger;
		_003C_003Ec__DisplayClass12_.vvxSKg5s09g = debug;
		ActionItem actionItem = kNxgT9fV6dX.GetAction(_003C_003Ec__DisplayClass12_.xcuSmzK9VXX);
		int num = 0;
		if (!fWVT2mFF1RiQemAUASaA())
		{
			goto IL_0072;
		}
		goto IL_0076;
		IL_0072:
		int num2 = default(int);
		num = num2;
		goto IL_0076;
		IL_0076:
		do
		{
			switch (num)
			{
			default:
				if (actionItem != null)
				{
					_003C_003Ec__DisplayClass12_.PXPSKwJDp4l = TargetInfo;
					if (actionItem.ActionType != ActionType.LinkAction)
					{
						break;
					}
					goto IL_0065;
				}
				AppHelper.ShowWarning("要执行的动作为空。");
				return;
			case 1:
				actionItem = zhBgThuh0yr.VuctRxC7icX(actionItem);
				if (actionItem == null)
				{
					AppHelper.ShowWarning("链接到的动作不存在。");
					return;
				}
				break;
			}
			if (actionItem.ActionType != ActionType.Folder && actionItem.ActionType != ActionType.GoParent && actionItem.ActionType != ActionType.OpenProfile && actionItem.DoNotClosePanel != true)
			{
				EnableKeyTrigger = false;
				RequestHide();
			}
			DebugHelper.LogExecuteTime(_003C_003Ec__DisplayClass12_.AyvSm3dhL5m, "执行动作");
			return;
			IL_0065:
			num = 1;
		}
		while (KFAA56FF0QDLtiRxUqXm == null);
		goto IL_0072;
	}

	[AsyncStateMachine(typeof(_003CActionButton_Drop_003Ed__13))]
	private void JaSgDMrhJ7y(object sender, System.Windows.DragEventArgs e)
	{
		_003CActionButton_Drop_003Ed__13 stateMachine = default(_003CActionButton_Drop_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void K0NgDAeAv08(ActionButton actionButton_1)
	{
		int num;
		while (true)
		{
			num = (int)actionButton_1.Tag;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (g7OgTVU3nuu.Gont6sBnlpf(num))
		{
			AppHelper.ShowVersionLimitInfo("编辑右上角按钮");
			return;
		}
		ActionItem action = kNxgT9fV6dX.GetAction(num);
		if (action == null || action.ActionType != ActionType.GoParent)
		{
			System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu
			{
				PlacementTarget = this
			};
			ActionProfile profileByButtonIndex = kNxgT9fV6dX.GetProfileByButtonIndex(num);
			(bool, int, int) buttonLocation = AppHelper.GetButtonLocation(num);
			bmIgTGywI3A.BuildMenuForActionButton(contextMenu, action, profileByButtonIndex, buttonLocation.Item2, buttonLocation.Item3, this, ActionTrigger.Panel, !actionButton_1.IsSelected);
			if (contextMenu.Items.Count > 0)
			{
				contextMenu.IsOpen = true;
			}
		}
	}

	public static DependencyObject GetRoot(DependencyObject element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		DependencyObject dependencyObject = element;
		while (VisualTreeHelper.GetParent(dependencyObject) != null)
		{
			dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
		}
		return dependencyObject;
	}

	private void dolgDOknRCs(UiSettings uiSettings_0)
	{
		double buttonSize = uiSettings_0.ButtonSize;
		double buttonSpace = uiSettings_0.ButtonSpace;
		double num = ((uiSettings_0.ButtonCornerRadius > 0.0) ? buttonSpace : 0.0);
		GlobalBtnCanvas.Width = buttonSize * 4.0 + buttonSpace * 3.0;
		GlobalBtnCanvas.Height = buttonSize * 3.0 + buttonSpace * 2.0 + 2.0 * num;
		int num2 = 0;
		if (!fWVT2mFF1RiQemAUASaA())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		ContextBtnCanvas.Width = buttonSize * 4.0 + buttonSpace * 3.0;
		ContextBtnCanvas.Height = buttonSize * 4.0 + buttonSpace * 3.0 + num;
		UpdateButtonSizeAndPosition(3, 4, true, buttonSize, buttonSpace, KtigTKfrjpl, num);
		UpdateButtonSizeAndPosition(4, 4, false, buttonSize, buttonSpace, KtigTKfrjpl, num);
	}

	public static void UpdateButtonSizeAndPosition(int rowCount, int colCount, bool isGlobal, double buttonSize, double space, IDictionary<int, ActionButton> buttonDict, double topspace)
	{
		for (int i = 0; i < rowCount; i++)
		{
			for (int j = 0; j < colCount; j++)
			{
				int buttonIndex = AppHelper.GetButtonIndex(isGlobal, i, j);
				ActionButton actionButton = buttonDict[buttonIndex];
				actionButton.Height = buttonSize;
				actionButton.Width = buttonSize;
				Canvas.SetLeft(actionButton, (double)j * (buttonSize + space));
				Canvas.SetTop(actionButton, (double)i * (buttonSize + space) + topspace);
			}
		}
	}

	private void YT8gDFY1c8Q(object sender, RoutedEventArgs e)
	{
		Q2GgTZX1xMq.RequestReinstallHook(this);
	}

	private void gtPgDURYQ0S(object sender, EventArgs e)
	{
		if (base.WindowState != WindowState.Normal)
		{
			base.WindowState = WindowState.Normal;
		}
	}

	private void sovgDlTXSJJ(object sender, MouseButtonEventArgs e)
	{
		System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu
		{
			PlacementTarget = this
		};
		if (pqLgT1i3kQh.AllGlobalProfiles.Count > 3)
		{
			System.Windows.Controls.MenuItem menuItem = AppHelper.AddMenuItem(contextMenu.Items, "全局", "选择全局动作页", "", null);
			using IEnumerator<ActionProfile> enumerator = pqLgT1i3kQh.AllGlobalProfiles.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				_003C_003Ec__DisplayClass20_.hUJSKaQLxiL = this;
				_003C_003Ec__DisplayClass20_.DHMSK8eR7eV = enumerator.Current;
				AppHelper.AddMenuItem(menuItem.Items, _003C_003Ec__DisplayClass20_.DHMSK8eR7eV.Name, "", "", _003C_003Ec__DisplayClass20_.WopSKyu5Tml);
			}
		}
		System.Windows.Controls.MenuItem menuItem2 = AppHelper.AddMenuItem(contextMenu.Items, "上下文", "选择动作页", "", null);
		using (IEnumerator<ActionProfile> enumerator = pqLgT1i3kQh.AllContextProfiles.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass20_1 _003C_003Ec__DisplayClass20_2 = new _003C_003Ec__DisplayClass20_1();
				_003C_003Ec__DisplayClass20_2.H9FSKql3J0Y = this;
				_003C_003Ec__DisplayClass20_2.XRlSKRSMrHA = enumerator.Current;
				AppHelper.AddMenuItem(menuItem2.Items, _003C_003Ec__DisplayClass20_2.XRlSKRSMrHA.Name, "", "", _003C_003Ec__DisplayClass20_2.e4kSK7aLPa0);
			}
		}
		contextMenu.IsOpen = true;
		e.Handled = true;
	}

	private void ftDgDiUtLcC(object sender, RoutedEventArgs e)
	{
		Window window = System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault(_003C_003Ec.gppSmKZ34Cs ?? (_003C_003Ec.gppSmKZ34Cs = _003C_003Ec.WwOSm6GOS4m.iGySmVrxhRA));
		if (window != null && window.IsLoaded)
		{
			window.Show();
			window.Activate();
		}
		else
		{
			window = new WindowInfoWindow();
			window.Show();
		}
	}

	public void TogglePopupWindow(PopupSource source, PointTargetInfo targetInfo)
	{
		if (base.IsVisible)
		{
			RequestHide();
		}
		else
		{
			PH9gD3pr5HJ(source, targetInfo, null);
		}
	}

	private void PH9gD3pr5HJ(PopupSource popupSource_1, PointTargetInfo pointTargetInfo_1, bool? nullable_0)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.lpISKWmtqy9 = this;
		_003C_003Ec__DisplayClass28_.qKnSKkYmCCf = popupSource_1;
		_003C_003Ec__DisplayClass28_.Jq1SKG1ixe3 = nullable_0;
		PopupSource = _003C_003Ec__DisplayClass28_.qKnSKkYmCCf;
		TargetInfo = pointTargetInfo_1;
		PopupWindowShowTime = DateTime.Now;
		base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass28_.QN0SKIuPgcQ);
	}

	public void RequestHide()
	{
		TargetInfo = null;
		RYsgTWmiFr7.MouseDownTargetInfo = null;
		base.Dispatcher.InvokeAsync(EvWgooOIXA3);
	}

	public void HideWindowIfClickOutside()
	{
		if (base.IsVisible && !ls6gTJ8FOku() && !IsPointOnWindow())
		{
			RequestHide();
		}
	}

	public bool IsPointOnWindow()
	{
		if (!base.IsVisible)
		{
			return false;
		}
		NativeMethods.GetWindowThreadProcessId(NativeMethods.WindowFromPoint(NativeMethods.GetMousePosition()), out uint processId);
		return processId == AppState.QuickerProcessId;
	}

	public bool CanCloseWindow()
	{
		if (!IsPinned && !IsDialogOpen)
		{
			return base.OwnedWindows.Count == 0;
		}
		return false;
	}

	private void JfygDfxSije()
	{
		AppState.LogTriggerWindowHideTime();
		TargetInfo = null;
		Hide();
		kosgdQTRoqI();
		if (!kNxgT9fV6dX.LockContextPanel)
		{
			NPBgDzO5dsB();
		}
	}

	private void NPBgDzO5dsB()
	{
		ExeSettings exeSettings = g7OgTVU3nuu.yQWt6ownR4Z("_global");
		if (exeSettings != null)
		{
			if (fWVT2mFF1RiQemAUASaA())
			{
				switch (0)
				{
				}
			}
			if (exeSettings.ReturnToFirstPage)
			{
				pqLgT1i3kQh.GlobalGoToPage(0, false);
			}
		}
		ExeSettings exeSettings2 = g7OgTVU3nuu.yQWt6ownR4Z(pqLgT1i3kQh.CurrentExe);
		if (exeSettings2 != null && exeSettings2.ReturnToFirstPage)
		{
			pqLgT1i3kQh.ContextGoToPage(0);
		}
	}

	public void AdjustWindowPosition(PopupSource popupSource, bool? followMouse)
	{
		int num;
		if (!followMouse.HasValue)
		{
			switch (popupSource)
			{
			case PopupSource.Keyboard:
				num = ((g7OgTVU3nuu.CpItmVISR7P().ToMousePosWhenOpenByKeyboard == PopupLocationType.WithMouse) ? 1 : 0);
				break;
			default:
				num = 0;
				break;
			case PopupSource.Mouse:
			case PopupSource.TriggerFloatButton:
				num = 1;
				break;
			}
		}
		else
		{
			num = (followMouse.Value ? 1 : 0);
		}
		bool flag = popupSource == PopupSource.Keyboard && g7OgTVU3nuu.CpItmVISR7P().ToMousePosWhenOpenByKeyboard == PopupLocationType.Previous && !_isFirstShow;
		System.Drawing.Point point = ((num == 0 || RYsgTWmiFr7.MouseDownTargetInfo == null) ? NativeMethods.GetMousePosition() : RYsgTWmiFr7.MouseDownTargetInfo.Point);
		Screen screen = Screen.FromPoint(point);
		double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint(point);
		Rectangle workingArea = screen.WorkingArea;
		if (num != 0)
		{
			double num2 = base.ActualWidth / dpiScaleByPoint;
			double num3 = base.ActualHeight / dpiScaleByPoint;
			double num4 = (double)point.X - num2 / 2.0;
			double buttonSize = g7OgTVU3nuu.CpItmVISR7P().UiSettings.ButtonSize;
			double buttonSpace = g7OgTVU3nuu.CpItmVISR7P().UiSettings.ButtonSpace;
			double num5 = (double)point.Y - (44.0 + GlobalBtnCanvas.Height) / dpiScaleByPoint;
			if (num4 < (double)workingArea.Left)
			{
				num4 = workingArea.Left;
			}
			else if (num4 > (double)workingArea.Right - num2)
			{
				num4 = (double)workingArea.Right - num2;
			}
			if (num5 < (double)workingArea.Top)
			{
				num5 = workingArea.Top;
			}
			else if (num5 > (double)workingArea.Bottom - num3)
			{
				num5 = (double)workingArea.Bottom - num3;
			}
			IHNRIiikxBwJdYmHpM3.oc0vvlUGaGr(AppState.MainWinHandle, (int)num4, (int)num5, true);
		}
		else if (!flag)
		{
			double num6 = (double)workingArea.Left + ((double)workingArea.Width - base.ActualWidth / dpiScaleByPoint) / 2.0;
			double num7 = (double)workingArea.Top + ((double)workingArea.Height - base.ActualHeight / dpiScaleByPoint) / 2.0;
			IHNRIiikxBwJdYmHpM3.oc0vvlUGaGr(AppState.MainWinHandle, (int)num6, (int)num7, true);
		}
	}

	public bool ShowOrMovePopupToPoint(PopupSource source, PointTargetInfo targetInfo, bool? followMouse)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.m2RSKHESm1Y = this;
		_003C_003Ec__DisplayClass40_.uDNSK13gEDt = followMouse;
		if (!EnsureNotEditing())
		{
			return false;
		}
		if (!base.IsVisible)
		{
			PH9gD3pr5HJ(source, targetInfo, _003C_003Ec__DisplayClass40_.uDNSK13gEDt);
			return true;
		}
		if (!IsPinned && !IsDialogOpen && _003C_003Ec__DisplayClass40_.uDNSK13gEDt != false && !targetInfo.IsOnQuicker)
		{
			base.Dispatcher.Invoke(_003C_003Ec__DisplayClass40_.u3hSKsLED2i);
			return true;
		}
		return false;
	}

	public bool EnsureNotEditing()
	{
		if (IsDialogOpen)
		{
			AppHelper.ShowWarning("Quicker处于编辑状态中...");
			return false;
		}
		return true;
	}

	private void Vdfgdwx0VaK(object sender, RoutedEventArgs e)
	{
		TogglePause();
	}

	private void NF6gdt1FjsP(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton != MouseButton.Left)
		{
			EnableKeyTrigger = false;
		}
		RYsgTWmiFr7.Reset();
	}

	[AsyncStateMachine(typeof(_003CBtnClose_OnDrop_003Ed__44))]
	private void Ff3gdgnwDwW(object sender, System.Windows.DragEventArgs e)
	{
		_003CBtnClose_OnDrop_003Ed__44 stateMachine = default(_003CBtnClose_OnDrop_003Ed__44);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void pBFgdLBC6ma(object sender, MouseButtonEventArgs e)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private bool ls6gTJ8FOku()
	{
		return v9VgTxNXR72;
	}

	[SpecialName]
	[CompilerGenerated]
	private void D38gT0DoXMr(bool value)
	{
		v9VgTxNXR72 = value;
	}

	[SpecialName]
	internal bool ksKgTEQWlfo()
	{
		return RYsgTWmiFr7.IsEnabled;
	}

	public void ClearMessages()
	{
		zyagTQA9eBD?.ClearMessages(new ClearAll());
	}

	public PopupWindow(IKernel container, DataService dataService, ITinyMessengerHub hub, PanelState panelState, AppServer appServer, ActiveWindowHook activeWindowWatcher, ProfileManager profileManager, UsageCounter usageCounter, PopupState popupState, IconManager iconManager, ActionEditMgr actionEditMgr, RunningActionMgr runningActionMgr, SQLDataMgr sqlDataMgr, ProfileSwitcher profileSwitcher, AutoRunService autoRunService, FloatButtonAndPanelManager floatButtonAndPanelManager, TextFloatPanelMgr textFloatPanelMgr, PushClient pushClient)
	{
		ItFgTcDUDd5 = container;
		g7OgTVU3nuu = dataService;
		Q2GgTZX1xMq = hub;
		kNxgT9fV6dX = panelState;
		zhBgThuh0yr = appServer;
		PhNgTejR2Z6 = activeWindowWatcher;
		NgEgTYG5V1w = profileManager;
		dkRgTIAHVjG = usageCounter;
		RYsgTWmiFr7 = popupState;
		vYrgTkN08tx = iconManager;
		bmIgTGywI3A = actionEditMgr;
		TsTgTsR7sUb = runningActionMgr;
		ReYgTHIbpgu = sqlDataMgr;
		pqLgT1i3kQh = profileSwitcher;
		PjxgTbSvqdK = autoRunService;
		NWFgTfXdknO = floatButtonAndPanelManager;
		CF9gTzcAI6X = textFloatPanelMgr;
		UNDgMw2Nanh = pushClient;
		base.DataContext = this;
		InitializeComponent();
		MainContextMenu1.DataContext = this;
		EnableSimpleMode = AO7eLUM7kJyEdiOQu2O.EnableSimpleMode;
		DispatcherTinyMessageProxy proxy = new DispatcherTinyMessageProxy(base.Dispatcher);
		Q2GgTZX1xMq.Subscribe(JHUgdZej6w0, _003C_003Ec.VwBSmxRI1EI ?? (_003C_003Ec.VwBSmxRI1EI = _003C_003Ec.WwOSm6GOS4m.fKxSmZ83QxO), proxy);
		Q2GgTZX1xMq.Subscribe(u0ZgdR1mF8I, _003C_003Ec.aG7SmrFLFTY ?? (_003C_003Ec.aG7SmrFLFTY = _003C_003Ec.WwOSm6GOS4m.easSm96W2l1), proxy);
		Q2GgTZX1xMq.Subscribe(kAxgdaYwVZ8, _003C_003Ec.B0gSmp21v0E ?? (_003C_003Ec.B0gSmp21v0E = _003C_003Ec.WwOSm6GOS4m.d9WSmhlIXox), proxy);
		Q2GgTZX1xMq.Subscribe(nd2gd8cOAiF, _003C_003Ec.FG7SmBf99Bi ?? (_003C_003Ec.FG7SmBf99Bi = _003C_003Ec.WwOSm6GOS4m.r6ISmeDIikS), proxy);
		Q2GgTZX1xMq.Subscribe(GIvgdEneMOg, _003C_003Ec.UcdSmQU3WR2 ?? (_003C_003Ec.UcdSmQU3WR2 = _003C_003Ec.WwOSm6GOS4m.EniSmYiD6t9), proxy);
		Q2GgTZX1xMq.Subscribe(ocjgdyX7Gtw, _003C_003Ec.UdJSmjH0xOh ?? (_003C_003Ec.UdJSmjH0xOh = _003C_003Ec.WwOSm6GOS4m.FOUSmIQlFMK), proxy);
		Q2GgTZX1xMq.Subscribe(w5EgdPfEHea, _003C_003Ec.VFASmnbybY1 ?? (_003C_003Ec.VFASmnbybY1 = _003C_003Ec.WwOSm6GOS4m.t4ESmWopIf0), proxy);
		Q2GgTZX1xMq.Subscribe(VKogdCAbi8d, _003C_003Ec.IwlSm41XQDD ?? (_003C_003Ec.IwlSm41XQDD = _003C_003Ec.WwOSm6GOS4m.Fp0SmkG3BsC), proxy);
		Q2GgTZX1xMq.Subscribe(NY7gd0y2aQV, _003C_003Ec.DTVSm5O0GcM ?? (_003C_003Ec.DTVSm5O0GcM = _003C_003Ec.WwOSm6GOS4m.qMrSmGwrWfP), proxy);
		AppState.c2BtaYRb15y(this);
		zyagTQA9eBD = new Notifier(_003C_003Ec.yxISmDgNcBU ?? (_003C_003Ec.yxISmDgNcBU = _003C_003Ec.WwOSm6GOS4m.i3TSmsvaDDt));
		AppState.i5yta9e2I0t(zyagTQA9eBD);
		AppState.xgStac0L3cP(Q2GgTZX1xMq);
		VnfgT4Q88CR = COxgdJhLMyx();
		base.SourceInitialized += dlDgoThhluW;
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		GridBody.Margin = new Thickness(uiSettings.FrameBorderWidth, 0.0, uiSettings.FrameBorderWidth, uiSettings.FrameBorderWidth);
		GridHeader.Margin = new Thickness(0.0 - uiSettings.FrameBorderWidth, 0.0, 0.0 - uiSettings.FrameBorderWidth, 0.0);
		if (!string.IsNullOrEmpty(uiSettings.BackgroundColor))
		{
			System.Windows.Media.Color color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(uiSettings.BackgroundColor);
			base.Background = color.GetBrush();
		}
		if (!string.IsNullOrEmpty(uiSettings.ButtonBgColor))
		{
			System.Windows.Media.Color color2 = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(uiSettings.ButtonBgColor);
			SetValue(ActionButton.ButtonColorProperty, color2.GetBrush());
		}
		e0ggDnVA3UN();
		base.Loaded += KTqgdeBwCr9;
		base.Closing += xougdkrdiAC;
		base.Closed += kQBgdYoqQBZ;
		base.MouseDown += RQZgdWVexLO;
		base.IsVisibleChanged += h3RgdIOrors;
		base.MouseLeave += Ag3gdSCbsdq;
		base.LocationChanged += PZBgdhhqiLu;
		if (VnfgT4Q88CR)
		{
			HQWgdN08G7c();
		}
		PushClient uNDgMw2Nanh = UNDgMw2Nanh;
		uNDgMw2Nanh.StatusChanged = (EventHandler<ConnectionStatusChangedEventArgs>)Delegate.Combine(uNDgMw2Nanh.StatusChanged, new EventHandler<ConnectionStatusChangedEventArgs>(vv7gotYUkXE));
		SystemParameters.StaticPropertyChanged += tOOgd2AlC3T;
	}

	private IntPtr XHugdvYZOWX(IntPtr intptr_0, int int_1, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_8)
	{
		if (int_1 == 74)
		{
			Marshal.PtrToStringUni(Marshal.PtrToStructure<CopyData>(intptr_2).lpData);
		}
		else if (int_1 == V36gTD6CTD9)
		{
			AppState.NotifyIconWrapper.RefreshIcon();
		}
		else if (int_1 == WEh2cFflZcNKgNsYJEP.xqJLUFgYj50().X0oLUfw3xOA())
		{
			WEh2cFflZcNKgNsYJEP.xqJLUFgYj50().YkoLUOZymWL(intptr_1, intptr_2);
		}
		else if (int_1 == 536)
		{
			Ax9qOtYhE8UFQqEXJI0.Jr2LR9tI1hH(intptr_1, intptr_2);
			int num = 0;
			if (!fWVT2mFF1RiQemAUASaA())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return IntPtr.Zero;
	}

	private void Ag3gdSCbsdq(object sender, System.Windows.Input.MouseEventArgs e)
	{
		if (PopupSource == PopupSource.TriggerFloatButton && !IsPointOnWindow())
		{
			RequestHide();
		}
	}

	private void tOOgd2AlC3T(object sender, PropertyChangedEventArgs e)
	{
		if (e.PropertyName == "WindowGlassColor" || e.PropertyName == "IsGlassEnabled" || e.PropertyName == "WindowResizeBorderThickness")
		{
			try
			{
			}
			catch (Exception ex)
			{
				xI5gTmj2IYG.Warn(ex.Message, ex);
			}
		}
	}

	private static void kbVgduNtmFH()
	{
	}

	private void HQWgdN08G7c()
	{
		GlobalBtnCanvas.IsManipulationEnabled = true;
		ContextBtnCanvas.IsManipulationEnabled = true;
		GlobalBtnCanvas.ManipulationStarted += zLSgoAp2S9P;
		GlobalBtnCanvas.ManipulationDelta += lvagoOuin0s;
		ContextBtnCanvas.ManipulationStarted += R4VgoF6hG9V;
		ContextBtnCanvas.ManipulationDelta += VEQgoUDbjtw;
	}

	private static bool COxgdJhLMyx()
	{
		try
		{
			bool result = false;
			foreach (TabletDevice item in (IEnumerable)Tablet.TabletDevices)
			{
				if (item.Type == TabletDeviceType.Touch)
				{
					result = true;
				}
			}
			return result;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private void NY7gd0y2aQV(ActionEditBeginMessage actionEditBeginMessage_0)
	{
		if (kNxgT9fV6dX.CurrentGlobalProfile == actionEditBeginMessage_0.EditingActionInfo.Profile)
		{
			UpdateButton(AppHelper.GetButtonIndex(true, actionEditBeginMessage_0.EditingActionInfo.Row, actionEditBeginMessage_0.EditingActionInfo.Col));
		}
		else if (kNxgT9fV6dX.CurrentContextProfile == actionEditBeginMessage_0.EditingActionInfo.Profile)
		{
			UpdateButton(AppHelper.GetButtonIndex(false, actionEditBeginMessage_0.EditingActionInfo.Row, actionEditBeginMessage_0.EditingActionInfo.Col));
		}
	}

	private void ClipboardChanged(object sender, EventArgs e)
	{
		AppState.ClipboardSequenceNumber++;
	}

	private void VKogdCAbi8d(StateChangedMessage stateChangedMessage_0)
	{
		if (stateChangedMessage_0.StateType == ChangedStateType.LockPanel)
		{
			OCHgdTAct0q();
		}
	}

	private void w5EgdPfEHea(TogglePausePopupMessage togglePausePopupMessage_0)
	{
		TogglePause();
	}

	public bool TogglePause()
	{
		RYsgTWmiFr7.IsEnabled = !RYsgTWmiFr7.IsEnabled;
		if (RYsgTWmiFr7.IsEnabled)
		{
			AppState.v5FtaQ4hQfg().k01vg2nHa1p();
			AppHelper.ShowSuccess("Quicker已恢复");
		}
		else
		{
			AppHelper.ShowInformation("Quicker已暂停");
			if (base.IsVisible)
			{
				RequestHide();
			}
		}
		NgIgTrSZ9xe.UpdatePopupState(RYsgTWmiFr7.IsEnabled);
		if (AppState.HHxtaMaoqJr().HotkeyModeAfterPause != HotkeyModeAfterPause.KeepAll)
		{
			int num = 0;
			if (!fWVT2mFF1RiQemAUASaA())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				AppState.aXRtadMEfsj().fgdtp1kRYXX(!RYsgTWmiFr7.IsEnabled);
			}
			catch (Exception ex)
			{
				xI5gTmj2IYG.Warn("更新快捷键出错：" + ex.Message, ex);
				AppHelper.ShowWarning(ex.Message);
			}
		}
		return RYsgTWmiFr7.IsEnabled;
	}

	private void GIvgdEneMOg(ActionEditCompletedMessage actionEditCompletedMessage_0)
	{
		if (actionEditCompletedMessage_0.Profile == kNxgT9fV6dX.CurrentContextProfile)
		{
			oBXgdGVXq8w();
		}
		else if (actionEditCompletedMessage_0.Profile == kNxgT9fV6dX.CurrentGlobalProfile)
		{
			ntjgds1TVuV();
		}
	}

	private void ocjgdyX7Gtw(ActionUpdatedMessage actionUpdatedMessage_0)
	{
		_003C_003Ec__DisplayClass118_0 _003C_003Ec__DisplayClass118_ = new _003C_003Ec__DisplayClass118_0();
		_003C_003Ec__DisplayClass118_.gMkSml7k84x = this;
		_003C_003Ec__DisplayClass118_.rffSmiATK7R = actionUpdatedMessage_0;
		AppHelper.ForEachButton(true, true, 4, _003C_003Ec__DisplayClass118_.VsQSmUIBeqq);
	}

	private void nd2gd8cOAiF(RequestShowPanelMessage requestShowPanelMessage_0)
	{
		if (!base.IsVisible)
		{
			TogglePopupWindow(requestShowPanelMessage_0.Source, null);
		}
	}

	private void kAxgdaYwVZ8(SyncStateMessage syncStateMessage_0)
	{
		sIXgd7d5gV3();
	}

	private void sIXgd7d5gV3()
	{
		SyncStateControl.SyncState = g7OgTVU3nuu.SyncState;
		BtnSync.Visibility = ((g7OgTVU3nuu.SyncState == QuickerSyncState.Idle) ? Visibility.Hidden : Visibility.Visible);
	}

	private void u0ZgdR1mF8I(UserSettingsChangedMessage userSettingsChangedMessage_0)
	{
		aBigdqFLPOv();
	}

	private void aBigdqFLPOv()
	{
		int num = 1;
		while (true)
		{
			UpdateUIAppearence(AppState.DataService.CpItmVISR7P());
			int num2 = 0;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			ReloadAutoRun(false);
			zhBgThuh0yr.UpdatePushConnection();
			NgIgTrSZ9xe.SetIconMode(AppState.HHxtaMaoqJr().TrayIconType);
			ShowCreateActionIcon = AppState.HHxtaMaoqJr().ShowMenuWhenLeftClickEmptyButton;
			AppState.v5FtaQ4hQfg().fXrvtFE0ogm();
			int gestureTrigger = AppState.DataService.CpItmVISR7P().GestureTrigger;
			gIh8AyjqAySmmxFMtv4.GdNteY7DhPE();
			gvNgdVE3CQb();
			AppState.TKStaiOMyPb()?.UpdateButtonResizeMode();
			return;
		}
	}

	internal void AtHgdcjcbLT(int int_1)
	{
		NgIgTrSZ9xe.SetIconMode(int_1);
	}

	private void gvNgdVE3CQb()
	{
		UIHelper.DisableWindowTooltip(this, AppState.HHxtaMaoqJr().HidePanelToolTip);
	}

	public void ReloadAutoRun(bool isAppStart)
	{
		PjxgTbSvqdK.Start(isAppStart);
	}

	private void JHUgdZej6w0(PanelUpdateMessage panelUpdateMessage_0)
	{
		EVjgTMjDIXs++;
		if (base.IsVisible || EVjgTMjDIXs <= 1)
		{
			yDTgd9BT63o(panelUpdateMessage_0.UpdateGlobal, panelUpdateMessage_0.UpdateContext);
		}
	}

	private void yDTgd9BT63o(bool bool_8, bool bool_9)
	{
		if (bool_8)
		{
			ntjgds1TVuV();
			GlobalProfileNavIndicator.Update(kNxgT9fV6dX.GlobalProfileCount, kNxgT9fV6dX.GlobalProfileIndex);
		}
		if (bool_9)
		{
			oBXgdGVXq8w();
			UpdateContextProfileInfo(kNxgT9fV6dX.CurrentContextProfile);
			ProfileNavIndicator.Update(kNxgT9fV6dX.ContextProfileCount, kNxgT9fV6dX.ContextProfileIndex);
		}
	}

	private void PZBgdhhqiLu(object sender, EventArgs e)
	{
		if (dn0gTiKcfHo && r5wgTU44PvQ != null)
		{
			r5wgTU44PvQ.Left = base.Left + base.ActualWidth;
			r5wgTU44PvQ.Top = base.Top;
		}
	}

	[AsyncStateMachine(typeof(_003CWindow_OnLoaded_003Ed__131))]
	private void KTqgdeBwCr9(object sender, RoutedEventArgs e)
	{
		_003CWindow_OnLoaded_003Ed__131 stateMachine = default(_003CWindow_OnLoaded_003Ed__131);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	public void UpdateUIAppearence(UserSettings userSettings, bool updateButtonSize = true)
	{
		try
		{
        bool flag = default;
        UiSettings uiSettings = default;
			BtnStartVoiceInput.Visibility = ((!userSettings.IsAppEnabled || !userSettings.ShowVoiceInputButtonOnTitleBar) ? Visibility.Collapsed : Visibility.Visible);
			BtnClientConnection.Visibility = ((!userSettings.IsAppEnabled) ? Visibility.Collapsed : Visibility.Visible);
			KtigTKfrjpl.ForEachButton(true, true, _003C_003Ec.bYPSmdL8pIL ?? (_003C_003Ec.bYPSmdL8pIL = _003C_003Ec.WwOSm6GOS4m.JxhSmHQv5qt));
			int num;
			if (userSettings.KeyTriggers == null)
			{
				num = 3;
				if (!fWVT2mFF1RiQemAUASaA())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_014b;
			}
			if (userSettings.KeyTriggers.Count > 0)
			{
				Dictionary<int, VirtualKeyCode> dictionary = new Dictionary<int, VirtualKeyCode>();
				foreach (KeyValuePair<int, int> keyTrigger in userSettings.KeyTriggers)
				{
					if (!dictionary.ContainsKey(keyTrigger.Value))
					{
						dictionary.Add(keyTrigger.Value, (VirtualKeyCode)keyTrigger.Key);
					}
				}
				foreach (KeyValuePair<int, VirtualKeyCode> item in dictionary)
				{
					KtigTKfrjpl[item.Key].KeyTip = KeyboardHelper.GetKeyName(item.Value);
				}
			}
			goto IL_0162;
			IL_017d:
			if (NativeMethods.IsSupportArcylic() && NativeMethods.DwmIsCompositionEnabled())
			{
				try
				{
					uint blurOpacity = uiSettings.BlurOpacity;
					NativeMethods.EnableBlur(this, blurOpacity, 10066329u, uiSettings.BlurMode);
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("设置模糊出错：" + ex.Message);
				}
			}
			goto IL_01c4;
			IL_014b:
			switch (num)
			{
			case 3:
				break;
			default:
				goto IL_017d;
			case 2:
				goto IL_01c4;
			case 1:
				goto IL_0252;
			}
			goto IL_0162;
			IL_01c4:
			GridBody.Margin = new Thickness(uiSettings.FrameBorderWidth, 0.0, uiSettings.FrameBorderWidth, uiSettings.FrameBorderWidth);
			GridHeader.Margin = new Thickness(0.0 - uiSettings.FrameBorderWidth, 0.0, 0.0 - uiSettings.FrameBorderWidth, 0.0);
			GridMiddleToolbar.Margin = new Thickness(0.0 - uiSettings.FrameBorderWidth, 0.0, 0.0 - uiSettings.FrameBorderWidth, 0.0);
			if (updateButtonSize)
			{
				goto IL_0252;
			}
			goto IL_027e;
			IL_0252:
			dolgDOknRCs(uiSettings);
			LblCreateProfileForApp.Width = uiSettings.ButtonSize * 4.0 - 75.0;
			goto IL_027e;
			IL_0162:
			uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
			flag = AppState.DataService.FjftbTOtevj();
			if (NativeMethods.IsOnWindows10OrLater())
			{
				num = 0;
				if (KFAA56FF0QDLtiRxUqXm != null)
				{
					goto IL_014b;
				}
				goto IL_017d;
			}
			goto IL_01c4;
			IL_027e:
			SetValue(ActionButton.CornerRadiusProperty, new CornerRadius(uiSettings.ButtonCornerRadius));
			if (flag)
			{
				UIHelper.UpdateUiBgImage(this, uiSettings);
			}
			UIHelper.UpdateUiSkinCommon(this, uiSettings, flag);
			if (NativeMethods.IsOnWindows11())
			{
				DwmDropShadow.SetRoundCornerMode(this, (uiSettings.RoundCornerMode == 0) ? 2 : uiSettings.RoundCornerMode);
			}
			if (!string.IsNullOrEmpty(uiSettings.BackgroundColor))
			{
				System.Windows.Media.Color color = UIHelper.ColorFromString(uiSettings.BackgroundColor);
				if (color.A == 0)
				{
					color.A = 1;
				}
				BorderBody.Background = color.GetBrush();
			}
			Grid gridMiddleToolbar = GridMiddleToolbar;
			System.Windows.Media.Brush background = (GridHeader.Background = UIHelper.SolidColorBrushFromString(uiSettings.ToolbarColor));
			gridMiddleToolbar.Background = background;
			ButtonColor = UIHelper.SolidColorBrushFromString(uiSettings.ToolbarBtnColor);
			OCHgdTAct0q();
			NWFgTfXdknO.UpdateUiSkin();
		}
		catch (Exception ex2)
		{
			xI5gTmj2IYG.Error("设置外观异常：" + ex2.Message, ex2);
			AppHelper.ShowWarning("更新外观异常！" + ex2.Message);
		}
	}

	private void kQBgdYoqQBZ(object sender, EventArgs e)
	{
		NgIgTrSZ9xe?.Release();
		zyagTQA9eBD?.Dispose();
		PjxgTbSvqdK.StopAll();
		Ax9qOtYhE8UFQqEXJI0.GFNLRZ3jPo2();
	}

	private void h3RgdIOrors(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (!base.IsVisible)
		{
			BtnMenu.IsChecked = false;
			BtnToolboxMenu.IsChecked = false;
		}
	}

	private void RQZgdWVexLO(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left && e.ButtonState == MouseButtonState.Pressed)
		{
			DragMove();
			if (PopupSource != PopupSource.TriggerFloatButton)
			{
				return;
			}
			if (KFAA56FF0QDLtiRxUqXm == null)
			{
				switch (0)
				{
				}
			}
			if (!IsPinned)
			{
				RequestHide();
				FloatTriggerButtonHelper.MoveToCursorPosition();
			}
		}
		else if (e.ChangedButton == MouseButton.Middle || (e.ChangedButton == MouseButton.XButton1 && AppState.DataService.CpItmVISR7P().OpenPopWithXButton1Click) || (e.ChangedButton == MouseButton.XButton2 && AppState.DataService.CpItmVISR7P().OpenPopWithXButton2Click))
		{
			RequestHide();
		}
	}

	private void xougdkrdiAC(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
		JfygDfxSije();
	}

	public void ShowCreateProfileLink(string fileName, string filePathName, string fileDesc)
	{
		if (!g7OgTVU3nuu.CpItmVISR7P().ShowNewExeSettingTips || HostedProcessHelper.IsHostProcessExe(fileName) || BlackListMgr.IsInBlackList(fileName, filePathName) || dDh7g7Xw7JyQPUTbYwJ.FJLtH9XuchQ(fileName))
		{
			return;
		}
		try
		{
			LblCreateProfileForApp.Text = "为 \"" + AppHelper.GetShorterString(fileDesc, 12) + "\" 添加场景设置？";
			LblCreateProfileForApp.Tag = (CommonExeInfo.IsCommonExe(fileName) ? fileName : filePathName);
			LblCreateProfileForApp.Visibility = Visibility.Visible;
			if (string.Equals(fileName, "taskbar", StringComparison.OrdinalIgnoreCase) && !IsPinned)
			{
				base.Top -= 25.0;
			}
		}
		catch (Exception exception)
		{
			xI5gTmj2IYG.Error("获取当前进程信息失败！", exception);
		}
	}

	public void HideCreateProfileLink()
	{
		LblCreateProfileForApp.Visibility = Visibility.Collapsed;
	}

	private void oBXgdGVXq8w()
	{
		base.Dispatcher.Invoke(j8CgofZQ03i);
	}

	private void ntjgds1TVuV()
	{
		base.Dispatcher.Invoke(wfbgoz1Mkcp);
	}

	public void UpdateButton(int buttonIndex)
	{
		_003C_003Ec__DisplayClass142_0 _003C_003Ec__DisplayClass142_ = new _003C_003Ec__DisplayClass142_0();
		_003C_003Ec__DisplayClass142_.YiMSKvHUDXr = this;
		_003C_003Ec__DisplayClass142_.lp2SKSVFLtW = buttonIndex;
		base.Dispatcher.Invoke(_003C_003Ec__DisplayClass142_.n1qSKL0tvpT);
	}

	public void SetButtonAction(int btnIndex, ActionItem action)
	{
		if (KtigTKfrjpl == null)
		{
			xI5gTmj2IYG.Error($"在尚未创建的按钮上设置动作 btnIndex={btnIndex}");
			return;
		}
		KtigTKfrjpl[btnIndex].SetAction(action);
		uivgdHTr8bl(btnIndex);
	}

	private void uivgdHTr8bl(int int_1)
	{
		KtigTKfrjpl[int_1].IsSelected = bmIgTGywI3A.IsButtonEditing(int_1);
	}

	public void UpdateContextProfileInfo(ActionProfile profile)
	{
		LblProfile.Text = profile?.DisplayName;
		LblProfile.ToolTip = profile?.DisplayName;
		string text = string.Empty;
		try
		{
			text = PhNgTejR2Z6.ExeFilePath ?? string.Empty;
		}
		catch (Exception)
		{
		}
		if (profile != null && !string.IsNullOrEmpty(profile.ExeFile))
		{
			int num = 0;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (profile.ExeFile.EndsWith(".exe", StringComparison.InvariantCultureIgnoreCase) && text.EndsWith(profile.ExeFile, StringComparison.InvariantCultureIgnoreCase))
			{
				try
				{
					ImgProfileExeIcon.Icon = IconHelper.GetExeIconImageStr(text);
				}
				catch (Exception)
				{
					ImgProfileExeIcon.Icon = null;
				}
				goto IL_00dd;
			}
		}
		ImgProfileExeIcon.Icon = IconHelper.GetExeIconImageStr(profile?.ExeFullpath);
		goto IL_00dd;
		IL_00dd:
		ImgProfileExeIcon.Visibility = ((AppState.HHxtaMaoqJr().HideContextProcessIcon || ImgProfileExeIcon.Icon == null) ? Visibility.Collapsed : Visibility.Visible);
	}

	private void pW9gd1ayoa1(object sender, RoutedEventArgs e)
	{
		if (!IsDialogOpen)
		{
			JfygDfxSije();
			if (PopupSource == PopupSource.TriggerFloatButton)
			{
				FloatTriggerButtonHelper.CloseFloatButton();
			}
		}
		else
		{
			AppHelper.ShowWarning("请先关闭工具窗口。");
		}
	}

	private void XQ3gdbOpuru(object sender, RoutedEventArgs e)
	{
		IsPinned = !IsPinned;
	}

	
	private void ziIgd66MnkI(object sender, RoutedEventArgs e)
	{ AppHelper.TryOpenUrlOrFile(AppHelper.GetUserDataDir(null)); }

	private void fTDgdXIXwpA(object sender, RoutedEventArgs e)
	{
		AppHelper.OpenMainSite();
	}

	private void DrZgdmnK22q(object sender, RoutedEventArgs e)
	{
		string userDataDir = AppHelper.GetUserDataDir(null);
		try
		{
			Process.Start(userDataDir);
		}
		catch (Exception ex)
		{
			xI5gTmj2IYG.Warn("无法打开程序数据目录。", ex);
			AppHelper.ShowWarning("无法打开目录。" + ex.Message);
		}
		RequestHide();
	}

	private void ooEgdKx5BYn(object sender, RoutedEventArgs e)
	{
		ClientConnectionWindow obj = new ClientConnectionWindow
		{
			Owner = this
		};
		IsDialogOpen = true;
		obj.ShowDialog();
		IsDialogOpen = false;
	}

	[AsyncStateMachine(typeof(_003CLblCreateProfileForApp_OnPreviewMouseDown_003Ed__154))]
	private void p23gdxLgCQe(object sender, MouseButtonEventArgs e)
	{
		_003CLblCreateProfileForApp_OnPreviewMouseDown_003Ed__154 stateMachine = default(_003CLblCreateProfileForApp_OnPreviewMouseDown_003Ed__154);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void pbxgdr4fIEs(object sender, RoutedEventArgs e)
	{
		ShowExeSettingsWindow(null);
	}

	public void ShowExeSettingsWindow(string exe = null)
	{
		if (string.IsNullOrEmpty(exe))
		{
			exe = pqLgT1i3kQh.CurrentContextProfile?.ExeFile.Or(AppState.CurrentExeName);
		}
		ExeSettingsWindow x1LgTFW6ma = X1LgTFW6ma1;
		if (x1LgTFW6ma != null && x1LgTFW6ma.IsLoaded)
		{
			if (X1LgTFW6ma1.WindowState == WindowState.Minimized)
			{
				X1LgTFW6ma1.WindowState = WindowState.Normal;
				int num = 0;
				if (!fWVT2mFF1RiQemAUASaA())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			X1LgTFW6ma1.SwitchExe(exe);
			X1LgTFW6ma1.Show();
			X1LgTFW6ma1.Activate();
			RequestHide();
		}
		else
		{
			try
			{
				X1LgTFW6ma1 = new ExeSettingsWindow(g7OgTVU3nuu, Q2GgTZX1xMq, zhBgThuh0yr, NgEgTYG5V1w, bmIgTGywI3A, exe);
				X1LgTFW6ma1.Show();
				X1LgTFW6ma1.Activate();
				RequestHide();
			}
			catch (Exception ex)
			{
				xI5gTmj2IYG.Warn("打开场景设置窗口出错：" + ex.Message, ex);
				AppHelper.ShowWarning("打开场景设置窗口出错：" + ex.Message + "\n如果问题持续出现，请联系我们获得帮助。", true);
			}
			X1LgTFW6ma1.Closed += j2XgdpIGso3;
		}
	}

	private void j2XgdpIGso3(object sender, EventArgs e)
	{
		if (X1LgTFW6ma1 != null)
		{
			X1LgTFW6ma1.Closed -= j2XgdpIGso3;
			X1LgTFW6ma1 = null;
		}
		if (dn0gTiKcfHo && Y63gTlKn23g)
		{
			r5wgTU44PvQ?.Close();
		}
		pqLgT1i3kQh.ReloadAll();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			zyagTQA9eBD?.Dispose();
			if (NgIgTrSZ9xe != null)
			{
				NgIgTrSZ9xe.Dispose();
				NgIgTrSZ9xe = null;
			}
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	private void rOCgdBtidVs(bool bool_8, bool bool_9)
	{
		_003C_003Ec__DisplayClass164_0 _003C_003Ec__DisplayClass164_ = new _003C_003Ec__DisplayClass164_0();
		_003C_003Ec__DisplayClass164_.kG5SKumnxlH = this;
		_003C_003Ec__DisplayClass164_.rHaSKN5Zjvk = bool_9;
		if (dn0gTiKcfHo && r5wgTU44PvQ != null)
		{
			r5wgTU44PvQ.Show();
			return;
		}
		Y63gTlKn23g = bool_8;
		int num = 0;
		if (!fWVT2mFF1RiQemAUASaA())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		r5wgTU44PvQ = new ToolboxWindow2(zhBgThuh0yr.GetCurrentContextProfile().ExeFile, ImgProfileExeIcon.Icon as string)
		{
			Owner = this,
			Height = base.Height + 8.0,
			Left = base.Left + base.ActualWidth,
			Top = base.Top
		};
		r5wgTU44PvQ.Closed += _003C_003Ec__DisplayClass164_.pxASK2IIZP3;
		dn0gTiKcfHo = true;
		r5wgTU44PvQ.Show();
	}

	private void kosgdQTRoqI()
	{
		if (dn0gTiKcfHo)
		{
			r5wgTU44PvQ?.Close();
		}
	}

	private void WHKgdjSwNeU(object sender, RoutedEventArgs e)
	{
		if (!dn0gTiKcfHo)
		{
			EnableKeyTrigger = false;
			bool bool_ = false;
			if (!kNxgT9fV6dX.LockContextPanel)
			{
				zhBgThuh0yr.ToggleLockPanel(true);
				int num = 0;
				if (!fWVT2mFF1RiQemAUASaA())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				AppHelper.ShowInformation("已锁定动作页自动切换。");
				bool_ = true;
			}
			rOCgdBtidVs(false, bool_);
		}
		else
		{
			kosgdQTRoqI();
		}
	}

	private void JF9gdnaKNvX(object sender, RoutedEventArgs e)
	{
		try
		{
			Process.Start("https://getquicker.net/Share/Exe/" + zhBgThuh0yr.GetCurrentContextProfile().ExeFile);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法打开网址。" + ex.Message);
		}
	}

	private void pQpgd4sZiWt(object sender, RoutedEventArgs e)
	{
		if (zhBgThuh0yr.StartVoiceInput())
		{
			RequestHide();
		}
	}

	private void yqLgd5W0cfk(object sender, MouseButtonEventArgs e)
	{
		try
		{
			string text = zhBgThuh0yr.GetCurrentContextProfile().ExeFile;
			if (string.IsNullOrEmpty(text))
			{
				text = "common";
			}
			Process.Start("https://getquicker.net/Share/Exe/" + text);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法打开网址。" + ex.Message);
		}
	}

	private void bEMgdDVfsJa(object sender, RoutedEventArgs e)
	{ g7OgTVU3nuu.CbQt6821R73(true); }

	private void mG1gddFiKf0()
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.SyncSettingPage);
	}

	private void xDWgdoMlbkk(object sender, RoutedEventArgs e)
	{
		Q2GgTZX1xMq.ToggleLockPanel(this);
	}

	private void OCHgdTAct0q()
	{
		if (kNxgT9fV6dX.LockContextPanel)
		{
			IconLock.Icon = EFontAwesomeIcon.Solid_Lock;
			if (!BtnToggleLock.IsVisible)
			{
				BtnToggleLock.Visibility = Visibility.Visible;
			}
		}
		else
		{
			IconLock.Icon = EFontAwesomeIcon.Light_Unlock;
		}
	}

	private void GeYgdMRVrQu(object sender, MouseWheelEventArgs e)
	{
		if (e.Delta > 0)
		{
			Q2GgTZX1xMq.RequestChangePage(this, true, true);
		}
		else
		{
			Q2GgTZX1xMq.RequestChangePage(this, true, false);
		}
	}

	public bool CanSwitchProfileByActiveProcess()
	{
		if (IsDialogOpen)
		{
			return false;
		}
		if (kNxgT9fV6dX.LockContextPanel)
		{
			return false;
		}
		if (!BjxbsJXXKfq9q6nXgXg.Tlst1LYYL1V())
		{
			return false;
		}
		if (AppState.HHxtaMaoqJr().DisableAutoSwitchAfterPopup && !kNxgT9fV6dX.LockContextPanel && base.IsVisible && !IsPinned)
		{
			return false;
		}
		return true;
	}

	private void fr7gdAIYvEK(object sender, RoutedEventArgs e)
	{
		if (TsTgTsR7sUb.Count() == 0)
		{
			AppHelper.ShowInformation("没有运行中的动作。");
		}
		else
		{
			TsTgTsR7sUb.StopAll();
		}
	}

	private void sONgdOe08Tf(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要清除所有悬浮动作或动作页么？"))
		{
			Q2GgTZX1xMq.CloseFloatingButtons(this);
		}
	}

	private void kwmgdFekkVf(object sender, RoutedEventArgs e)
	{
		ActionEditMgr.ShowAppSelectorWindow(this);
	}

	private void NslgdUVhNhS(object sender, RoutedEventArgs e)
	{
		AppServer.OpenShareBase(pqLgT1i3kQh.CurrentExe);
		RequestHide();
	}

	private void loCgdlCibpC(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppHelper.ExportActionsCsv();
	}

	private void jG0gdiSV5Ua(object sender, RoutedEventArgs e)
	{
		RequestHide();
		zhBgThuh0yr.ShowSearchWindow(string.Empty, true);
	}

	public void ShowSearch(ActionItem startSearchWithAction = null, string searchText = "")
	{
		RequestHide();
		if (!g7OgTVU3nuu.FQDtbMSLp7P() && startSearchWithAction == null)
		{
			AppHelper.ShowVersionLimitInfo(null, "了解 “搜索” 功能", "https://getquicker.net/KC/Help/Doc/searching");
			return;
		}
		if (wYegT3agQwi == null)
		{
			wYegT3agQwi = new SearchWindow(g7OgTVU3nuu, Q2GgTZX1xMq, bmIgTGywI3A);
		}
		else if (wYegT3agQwi.IsVisible && startSearchWithAction == null)
		{
			wYegT3agQwi.RequestHide();
			return;
		}
		wYegT3agQwi.ActiveWindowBeforeShow = AppState.r4itaWBnyVQ().CurrentForegroundWindow;
		wYegT3agQwi.ActiveProcessBeforeShow = AppState.CurrentProcessName;
		wYegT3agQwi.CurrentExeBeforeShow = pqLgT1i3kQh.CurrentExe;
		int num = 0;
		if (KFAA56FF0QDLtiRxUqXm != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		wYegT3agQwi.RequestShow(startSearchWithAction, searchText);
	}

	public void CloseSearch()
	{
		if (wYegT3agQwi != null)
		{
			AppHelper.RunOnUiThread(true, viIgTtFFBVI);
		}
	}

	private void GlobalProfileNavIndicator_OnPointClicked(object sender, PointClickedEventArgs e)
	{
		pqLgT1i3kQh.GlobalGoToPage(e.Index);
	}

	private void ProfileNavIndicator_OnPointClicked(object sender, PointClickedEventArgs e)
	{
		pqLgT1i3kQh.ContextGoToPage(e.Index);
	}

	public string CaptureToTempFile()
	{
		try
		{
			NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(AppState.MainWinHandle);
			Bitmap bitmap = CaptureStep.CaptureArea(new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top));
			string text = Path.Combine(Path.GetTempPath(), "quicker_capture_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
			bitmap.Save(text);
			return text;
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("保存截图出错了，如果您的系统做过什么更改，可以重启Quicker再试试。\n" + ex.Message);
			return "";
		}
	}

	public void ShowDashboardWindow(string exe)
	{
		RequestHide();
		PointTargetInfo pointTargetInfo = AppHelper.GetPointTargetInfo(null);
		try
		{
			if (DashboardWindow == null)
			{
				DashboardWindow = new DashboardWindow(zhBgThuh0yr, Q2GgTZX1xMq, bmIgTGywI3A, g7OgTVU3nuu, pqLgT1i3kQh, exe)
				{
					PointTargetInfo = pointTargetInfo
				};
				if (fWVT2mFF1RiQemAUASaA())
				{
					switch (0)
					{
					}
				}
				DashboardWindow.Show();
				DashboardWindow.Closed += B9igTghJNTU;
			}
			else if (DashboardWindow.IsVisible)
			{
				DashboardWindow.Close();
			}
			else
			{
				DashboardWindow.Show();
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("处理异常：" + ex.Message + " 可能是操作太快了。");
		}
	}

	private void MN2gd355yLQ(object sender, RoutedEventArgs e)
	{
		CF9gTzcAI6X.Toggle();
	}

	private void w1Igdff45Qy(object sender, MouseButtonEventArgs e)
	{
		try
		{
			string text = LblCreateProfileForApp?.Tag as string;
			if (!string.IsNullOrEmpty(text) && File.Exists(text))
			{
				NativeMethods.OpenFolderAndSelectItem(Path.GetDirectoryName(text), Path.GetFileName(text));
			}
			else
			{
				AppHelper.ShowWarning("目录为空或不存在。");
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("操作出错：" + ex.Message);
		}
		RequestHide();
	}

	private void C4ngdzgAe0H(object sender, RoutedEventArgs e)
	{
		FaFgowjP8Gr();
	}

	internal void FaFgowjP8Gr()
	{
		if (PiigMgST5vU != null)
		{
			PiigMgST5vU.Show();
			PiigMgST5vU.Activate();
			return;
		}
		PiigMgST5vU = new RecorderWindow(false, false, true);
		PiigMgST5vU.Closed += gU0gTLkmZup;
		PiigMgST5vU.Show();
		PiigMgST5vU.Activate();
	}

	private void vv7gotYUkXE(object sender, ConnectionStatusChangedEventArgs e)
	{
		AppHelper.RunOnUiThread(false, DUygTvHmGRe);
	}

	private void I52gogjXQrb()
	{
		ConnectionStatusIcon.ToolTip = "连接状态：" + UNDgMw2Nanh.State;
		string text = UNDgMw2Nanh.StateDesc;
		if (UNDgMw2Nanh.State == PushConnectionState.WaitingReconnect && UNDgMw2Nanh.LastTryConnectTime.HasValue)
		{
			text = text + "(上次尝试:" + UNDgMw2Nanh.LastTryConnectTime.Value.ToString("HH:mm:ss") + ")";
		}
		txtPushState.Text = text;
		txtPushState.ToolTip = (UNDgMw2Nanh.State.IsEither(PushConnectionState.ConnectedActive, PushConnectionState.ConnectedInactive) ? $"连接时间：{UNDgMw2Nanh.LastConnectedTime:HH:mm:ss}" : UNDgMw2Nanh.ErrorMessage);
		int num;
		switch (UNDgMw2Nanh.State)
		{
		case PushConnectionState.NotEnabled:
			ConnectionStatusIcon.Foreground = ButtonColor;
			goto IL_0181;
		case PushConnectionState.ConnectedInactive:
			ConnectionStatusIcon.Foreground = System.Windows.Media.Brushes.DimGray;
			goto IL_0181;
		default:
			ConnectionStatusIcon.Foreground = System.Windows.Media.Brushes.DarkOrange;
			goto IL_0181;
		case PushConnectionState.Error:
			ConnectionStatusIcon.Foreground = (TryFindResource("TextDangerBrush") as System.Windows.Media.Brush) ?? System.Windows.Media.Brushes.Green;
			goto IL_0181;
		case PushConnectionState.ConnectedActive:
			{
				ConnectionStatusIcon.Foreground = (TryFindResource("TextSuccessBrush") as System.Windows.Media.Brush) ?? System.Windows.Media.Brushes.Green;
				goto IL_0181;
			}
			IL_0181:
			iconPushState.Foreground = ConnectionStatusIcon.Foreground;
			ConnectionStatusIcon.Visibility = Y2EgoLkYhM1(UNDgMw2Nanh.State != PushConnectionState.NotEnabled);
			MenuConnectPushServer.Visibility = Y2EgoLkYhM1(!UNDgMw2Nanh.IsStarted);
			num = 0;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				MenuDisconnectPushServer.Visibility = Y2EgoLkYhM1(UNDgMw2Nanh.IsStarted);
				MenuSetActiveClient.Visibility = Y2EgoLkYhM1(UNDgMw2Nanh.State == PushConnectionState.ConnectedInactive);
				return;
			}
			goto case PushConnectionState.ConnectedActive;
		}
	}

	private Visibility Y2EgoLkYhM1(bool bool_8)
	{
		if (!bool_8)
		{
			return Visibility.Collapsed;
		}
		return Visibility.Visible;
	}

	private void pW6govY3dB2(object sender, RoutedEventArgs e)
	{
		AO7eLUM7kJyEdiOQu2O.EnableConnection = true;
		zhBgThuh0yr.UpdatePushConnection();
	}

	private void jKMgoSVHmDx(object sender, RoutedEventArgs e)
	{
		AO7eLUM7kJyEdiOQu2O.EnableConnection = false;
		zhBgThuh0yr.UpdatePushConnection();
	}

	private void MIBgo2Zmmqd(object sender, RoutedEventArgs e)
	{
		try
		{
			UNDgMw2Nanh.RequestActive();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("操作失败！" + ex.Message);
		}
	}

	private void vlNgouduSKm(object sender, RoutedEventArgs e)
	{
		AppHelper.RestartQuicker();
		AppHelper.ExitApplication();
	}

	private void E36goNPQMoL(object sender, RoutedEventArgs e)
	{
		if (ltIgML7eYpt == null)
		{
			ltIgML7eYpt = new FaIconSelectorWindow();
			ltIgML7eYpt.Closed += CSqgTSbprpD;
		}
		ltIgML7eYpt.IconColor = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColorForOtherUi;
		ltIgML7eYpt.PanelColor = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().BackgroundColor;
		ltIgML7eYpt.ButtonColor = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonBgColor;
		ltIgML7eYpt.LabelColor = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().LabelColor;
		ltIgML7eYpt.Top = base.Top;
		ltIgML7eYpt.Left = base.Left + base.ActualWidth;
		ltIgML7eYpt.Height = base.Height + 7.0;
		ltIgML7eYpt.Show();
		if (fWVT2mFF1RiQemAUASaA())
		{
			switch (0)
			{
			}
		}
		ltIgML7eYpt.Activate();
	}

	private void wjGgoJ8qC5H(object sender, MouseButtonEventArgs e)
	{
		_003C_003Ec__DisplayClass210_0 _003C_003Ec__DisplayClass210_ = new _003C_003Ec__DisplayClass210_0();
		_003C_003Ec__DisplayClass210_.i95SKV6Ci8d = this;
		_003C_003Ec__DisplayClass210_.MhlSKZFkomY = new System.Windows.Controls.ContextMenu();
		IList<ExeInfo> list = g7OgTVU3nuu.Vo4tXXBRrsb(false);
		List<string> list2 = g7OgTVU3nuu.mP6tXA8VyNP().Values.Select(_003C_003Ec.JPpSmTnoWww ?? (_003C_003Ec.JPpSmTnoWww = _003C_003Ec.WwOSm6GOS4m.QO0Smb5xWW3)).Distinct().ToList();
		foreach (ExeInfo item in list)
		{
			if (list2.Contains(item.Exe.ToLower()))
			{
				System.Windows.Controls.MenuItem menuItem = AppHelper.AddMenuItem(_003C_003Ec__DisplayClass210_.MhlSKZFkomY.Items, fq2gT2uF5T0(item), item.Exe, null, Rs6go07fZto);
				menuItem.Icon = new IconControl
				{
					Icon = item.IconStr,
					Width = 16.0,
					Height = 16.0
				};
				menuItem.Tag = item;
			}
		}
		_003C_003Ec__DisplayClass210_.MhlSKZFkomY.Closed += _003C_003Ec__DisplayClass210_.Mj5SKcGot1R;
		AppState.RegisterContextMenu(_003C_003Ec__DisplayClass210_.MhlSKZFkomY);
		BtnToggleLock.ContextMenu = _003C_003Ec__DisplayClass210_.MhlSKZFkomY;
	}

	private void Rs6go07fZto(object sender, RoutedEventArgs e)
	{
		ExeInfo exeInfo = (sender as System.Windows.Controls.MenuItem).Tag as ExeInfo;
		zhBgThuh0yr.LoadExeProfilesAndLock(exeInfo.Exe, true);
	}

	private void VIugoCNHJ3u(object sender, RoutedEventArgs e)
	{
		RequestHide();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();
		AppHelper.ShowInformation("操作完成。");
	}

	private void BTUgoPX5WF6(object sender, RoutedEventArgs e)
	{
		RequestHide();
		BrowserExtHelpWindow browserExtHelpWindow = AppHelper.FindRootWindow<BrowserExtHelpWindow>();
		if (browserExtHelpWindow != null)
		{
			browserExtHelpWindow.Show();
			browserExtHelpWindow.Activate();
		}
		else
		{
			browserExtHelpWindow = new BrowserExtHelpWindow();
			browserExtHelpWindow.Show();
			browserExtHelpWindow.Activate();
		}
	}

	private void giZgoEO6Lwj(object sender, MouseButtonEventArgs e)
	{
		try
		{
			_003C_003Ec__DisplayClass214_0 _003C_003Ec__DisplayClass214_ = new _003C_003Ec__DisplayClass214_0();
			string path = LblCreateProfileForApp?.Tag as string;
			int num = 0;
			if (!fWVT2mFF1RiQemAUASaA())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				_003C_003Ec__DisplayClass214_.nRJSKhb93kr = Path.GetFileName(path);
				IList<string> relatedExes = RelatedExeHelper.GetRelatedExes(_003C_003Ec__DisplayClass214_.nRJSKhb93kr);
				if (relatedExes.HasData())
				{
					if (!AppHelper.Confirm("您确认要将 " + _003C_003Ec__DisplayClass214_.nRJSKhb93kr + " 及其关联进程加入到黑名单中么？\n黑名单应用的窗口上将无法使用鼠标方式激活Quicker。", MessageBoxImage.Exclamation))
					{
						break;
					}
					using (IEnumerator<string> enumerator = relatedExes.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							_003C_003Ec__DisplayClass214_1 _003C_003Ec__DisplayClass214_2 = new _003C_003Ec__DisplayClass214_1();
							_003C_003Ec__DisplayClass214_2.Yt7SKY4ERYc = enumerator.Current;
							if (!AppState.DataService.CpItmVISR7P().SpecialExeList.Any(_003C_003Ec__DisplayClass214_2.DZTSKeEyIln))
							{
								AppState.DataService.CpItmVISR7P().SpecialExeList.Add(new SpecialExeItem
								{
									ExeName = _003C_003Ec__DisplayClass214_2.Yt7SKY4ERYc,
									Description = "",
									Icon = ""
								});
							}
						}
					}
					AppState.DataService.ydot6rVZAkW();
				}
				else if (AppHelper.Confirm("您确认要将 " + _003C_003Ec__DisplayClass214_.nRJSKhb93kr + " 加入到黑名单中么？\n黑名单应用的窗口上将无法使用鼠标方式激活Quicker。", MessageBoxImage.Exclamation))
				{
					if (!AppState.DataService.CpItmVISR7P().SpecialExeList.Any(_003C_003Ec__DisplayClass214_.jmdSK9ewQuR))
					{
						AppState.DataService.CpItmVISR7P().SpecialExeList.Add(new SpecialExeItem
						{
							ExeName = _003C_003Ec__DisplayClass214_.nRJSKhb93kr,
							Description = "",
							Icon = ""
						});
					}
					AppState.DataService.ydot6rVZAkW();
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			xI5gTmj2IYG.Warn("添加黑名单出错：" + ex.Message, ex);
			AppHelper.ShowWarning("操作出错：" + ex.Message);
		}
		RequestHide();
	}

	private void eq6goy8uiuP(object sender, RoutedEventArgs e)
	{
		dDh7g7Xw7JyQPUTbYwJ.csttHZWbl6L(Path.GetFileName(LblCreateProfileForApp?.Tag as string));
		LblCreateProfileForApp.Visibility = Visibility.Collapsed;
	}

	private void pDego867vs4(object sender, MouseButtonEventArgs e)
	{
		RequestHide();
		if (e.ChangedButton == MouseButton.Right)
		{
			long num = AppHelper.ForceGCAndCompact();
			AppHelper.ShowSuccess($"托管内存占用：{num / 1024L / 1024L}Mib");
		}
		else
		{
			AppWindowManager.ShowSettingsWindow(null);
		}
	}

	public void ShowNewVersionTip()
	{
		SettingMenuStatusIcon.Visibility = Visibility.Visible;
		SettingMenuStatusIcon.ToolTip = "Quicker有新版本可以升级。";
		MenuUpdateVersion.Visibility = Visibility.Visible;
	}

	private void f3mgoaQ2Cry(object sender, MouseButtonEventArgs e)
	{
		RequestHide();
		FloatTriggerButtonHelper.ShowPanelFloatButton();
		e.Handled = true;
	}

	private void equgo7W0Lxm(object sender, RoutedEventArgs e)
	{
		AppHelper.HP0LT5LCDOi();
		AppHelper.ShowSuccess("键盘状态已重置。");
	}

	private void VwWgoRfRjm4(object sender, RoutedEventArgs e)
	{
		RequestHide();
		QuickTextEditorWindow quickTextEditorWindow = AppHelper.FindRootWindow<QuickTextEditorWindow>();
		if (quickTextEditorWindow != null)
		{
			quickTextEditorWindow.Show();
			quickTextEditorWindow.Activate();
		}
		else
		{
			quickTextEditorWindow = new QuickTextEditorWindow(null);
			quickTextEditorWindow.Show();
			quickTextEditorWindow.Activate();
		}
	}

	private void f8QgoqblNi3(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(null);
	}

	private void yXugoc7d6rJ(object sender, RoutedEventArgs e)
	{
		bool flag = (sender as System.Windows.Controls.MenuItem)?.Tag?.ToString() == "1";
		if (EnableSimpleMode != flag)
		{
			EnableSimpleMode = flag;
			AO7eLUM7kJyEdiOQu2O.EnableSimpleMode = flag;
			AppHelper.ShowSuccess("已切换为 " + (flag ? "简洁模式" : "标准模式"));
		}
	}

	private void YWngoVm2Ywu(object sender, RoutedEventArgs e)
	{
		App.Current.scE1uhLPsV();
	}

	private void ImgProfileExeIcon_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
	{
		pbxgdr4fIEs(sender, e);
	}

	private void pdVgoZ0C0H3(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile("https://github.com/cuiliang/Quicker/issues");
		RequestHide();
	}

	private void iYxgo9jk0BJ(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile("https://getquicker.net/KC/Help");
		RequestHide();
	}

	[AsyncStateMachine(typeof(_003CMenuOpenGuide_OnClick_003Ed__227))]
	private void bCUgohs4st0(object sender, RoutedEventArgs e)
	{
		_003CMenuOpenGuide_OnClick_003Ed__227 stateMachine = default(_003CMenuOpenGuide_OnClick_003Ed__227);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void hEjgoeTmMG6(object sender, RoutedEventArgs e)
	{
		AppHelper.ExitApplication();
	}

	private void DiDgoIWTUuq(object sender, RoutedEventArgs e)
	{
		TogglePopupWindow(PopupSource.Menu, null);
	}

	[AsyncStateMachine(typeof(_003CMenuUpdateVersion_OnClick_003Ed__231))]
	private void FJDgoWxAe2j(object sender, RoutedEventArgs e)
	{
		_003CMenuUpdateVersion_OnClick_003Ed__231 stateMachine = default(_003CMenuUpdateVersion_OnClick_003Ed__231);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Cc6gokD9Svf(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.AboutSettingPage);
	}

	private void eCSgoGOCncF(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.UsageStatisticsInfoPage);
	}

	private void TJ9gosjXidx(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.TextCommandManagePage);
	}

	private void da0goHdByV1(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.PowerKeysManagementPage);
	}

	private void t2ngo13a8T3(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.LeftButtonPlusSettingPage);
	}

	private void E1Tgoba5i16(object sender, RoutedEventArgs e)
	{
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.MouseActionManagePage);
	}

	
	private void dvHgo6MfL2c(object sender, RoutedEventArgs e)
	{ g7OgTVU3nuu.CbQt6821R73(true); }

	private void c3VgoXUoanx(object sender, RoutedEventArgs e)
	{
		mG1gddFiKf0();
	}

	[AsyncStateMachine(typeof(_003CMenuCheckUpdate_OnClick_003Ed__240))]
	private void Eusgom7uLtP(object sender, RoutedEventArgs e)
	{
		_003CMenuCheckUpdate_OnClick_003Ed__240 stateMachine = default(_003CMenuCheckUpdate_OnClick_003Ed__240);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void j65goKqmfln(object sender, RoutedEventArgs e)
	{
		if (bmIgTGywI3A.IsEditing())
		{
			AppHelper.ShowWarning("请先关闭所有动作编辑窗口。", true);
			return;
		}
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.UpdateActionsPage);
	}

	private void BWAgoxq0TJI(object sender, RoutedEventArgs e)
	{
		if (!g7OgTVU3nuu.IKjtbU9GGtP())
		{
			AppHelper.ShowVersionLimitInfo(null, "了解 “动作回收站” 功能", "https://getquicker.net/KC/Help/Doc/action-recyclebin");
			return;
		}
		RequestHide();
		AppWindowManager.ShowSettingsWindow(SettingPageId.ActionRecycleBinSettingPage);
	}

	[AsyncStateMachine(typeof(_003CMenuMaintainTools_OnClick_003Ed__243))]
	private void avagorWP4BY(object sender, RoutedEventArgs e)
	{
		_003CMenuMaintainTools_OnClick_003Ed__243 stateMachine = default(_003CMenuMaintainTools_OnClick_003Ed__243);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void EpSgopZ65XW(object sender, RoutedEventArgs e)
	{
		CF9gTzcAI6X.ResetState();
		AppHelper.ShowInformation("已重置！");
		RequestHide();
	}

	private void RvbgoBAC5yS(object sender, RoutedEventArgs e)
	{
		RequestHide();
		if (Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			AppState.EnableDetailedLogging = true;
			AppHelper.ShowInformation("已开启扩展热键日志记录。");
			return;
		}
		KeyboardStateWindow keyboardStateWindow = AppHelper.FindRootWindow<KeyboardStateWindow>();
		if (keyboardStateWindow != null && keyboardStateWindow.IsLoaded)
		{
			int num = 0;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			keyboardStateWindow.Show();
			keyboardStateWindow.Activate();
		}
		else
		{
			keyboardStateWindow = new KeyboardStateWindow();
			keyboardStateWindow.Show();
			keyboardStateWindow.Activate();
		}
	}

	private void NprgoQDG5kQ(object sender, RoutedEventArgs e)
	{
		RequestHide();
		FloatTriggerButtonHelper.ShowPanelFloatButton();
	}

	private void vQ6gojKJn3h(object sender, RoutedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003CMenuPushToPc_OnClick_003Ed__248))]
	private void GQqgonkxdL3(object sender, RoutedEventArgs e)
	{
		_003CMenuPushToPc_OnClick_003Ed__248 stateMachine = default(_003CMenuPushToPc_OnClick_003Ed__248);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void rZigo4ryjLA(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(null);
		RequestHide();
	}

	private void Mqxgo5Oum0F(object sender, RoutedEventArgs e)
	{
		ShowExeSettingsWindow(null);
		RequestHide();
	}

	private void yAigoDp0LT1(object sender, RoutedEventArgs e)
	{
		RequestHide();
		string text = null;
		try
		{
			text = CoreWebView2Environment.GetAvailableBrowserVersionString(null, null);
		}
		catch (Exception exception)
		{
			xI5gTmj2IYG.Warn("检测WebView出错：" + exception.GetMessageWithInner());
		}
		if (!string.IsNullOrEmpty(text))
		{
			AppHelper.ShowInformation("您的电脑已有WebView2运行时(版本：" + text + ")，不需要再进行安装了。", true);
		}
		else
		{
			AppWindowManager.ShowWebViewInstaller();
		}
	}

	private void TWRgodOS0c3(object sender, RoutedEventArgs e)
	{
		RequestHide();
		ExpressionTesterWindow expressionTesterWindow = new ExpressionTesterWindow(null);
		expressionTesterWindow.Show();
		expressionTesterWindow.Activate();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!SMQgMv3kH06)
		{
			SMQgMv3kH06 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/main/popupwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			SMQgMv3kH06 = true;
			break;
		case 1:
			TheWindow = (PopupWindow)target;
			TheWindow.PreviewMouseDown += NF6gdt1FjsP;
			TheWindow.StateChanged += gtPgDURYQ0S;
			break;
		case 2:
			((System.Windows.Controls.MenuItem)target).Click += DiDgoIWTUuq;
			break;
		case 3:
			((System.Windows.Controls.MenuItem)target).Click += rZigo4ryjLA;
			break;
		case 4:
			((System.Windows.Controls.MenuItem)target).Click += Mqxgo5Oum0F;
			break;
		case 5:
			((System.Windows.Controls.MenuItem)target).Click += Vdfgdwx0VaK;
			break;
		case 6:
			((System.Windows.Controls.MenuItem)target).Click += MN2gd355yLQ;
			break;
		case 7:
			((System.Windows.Controls.MenuItem)target).Click += sONgdOe08Tf;
			break;
		case 8:
			((System.Windows.Controls.MenuItem)target).Click += C4ngdzgAe0H;
			break;
		case 9:
			((System.Windows.Controls.MenuItem)target).Click += ftDgDiUtLcC;
			break;
		case 10:
			((System.Windows.Controls.MenuItem)target).Click += YT8gDFY1c8Q;
			break;
		case 11:
			((System.Windows.Controls.MenuItem)target).Click += equgo7W0Lxm;
			break;
		case 12:
			((System.Windows.Controls.MenuItem)target).Click += YWngoVm2Ywu;
			break;
		case 13:
			((System.Windows.Controls.MenuItem)target).Click += vlNgouduSKm;
			break;
		case 14:
			((System.Windows.Controls.MenuItem)target).Click += hEjgoeTmMG6;
			break;
		case 15:
			BorderBody = (Border)target;
			break;
		case 16:
			GridBody = (Grid)target;
			break;
		case 17:
			GridHeader = (Border)target;
			break;
		case 18:
			LblAppTitle = (System.Windows.Controls.Label)target;
			goto IL_0a31;
		case 19:
			BtnSettingsNew = (System.Windows.Controls.Button)target;
			BtnSettingsNew.PreviewMouseUp += pDego867vs4;
			break;
		case 20:
			BtnStartVoiceInput = (System.Windows.Controls.Button)target;
			BtnStartVoiceInput.PreviewMouseUp += pQpgd4sZiWt;
			break;
		case 21:
			BtnMenu = (DropDownButton)target;
			break;
		case 22:
			SettingMenuStatusIcon = (SvgAwesome)target;
			break;
		case 23:
			MainContextMenu1 = (System.Windows.Controls.ContextMenu)target;
			break;
		case 24:
			MenuOpenSettings = (System.Windows.Controls.MenuItem)target;
			MenuOpenSettings.Click += f8QgoqblNi3;
			break;
		case 25:
			MenuProfileManage = (System.Windows.Controls.MenuItem)target;
			goto IL_0b21;
		case 26:
			MenuPowerKeys = (System.Windows.Controls.MenuItem)target;
			num = 8;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				goto IL_09e6;
			}
			goto IL_09ea;
		case 27:
			MenuTextCommand = (System.Windows.Controls.MenuItem)target;
			MenuTextCommand.Click += TJ9gosjXidx;
			break;
		case 28:
			MenuLeftButtonPlus = (System.Windows.Controls.MenuItem)target;
			num = 10;
			if (!fWVT2mFF1RiQemAUASaA())
			{
				goto IL_09e6;
			}
			goto IL_09ea;
		case 29:
			MenuMouseSettings = (System.Windows.Controls.MenuItem)target;
			MenuMouseSettings.Click += E1Tgoba5i16;
			break;
		case 30:
			MenuSync = (System.Windows.Controls.MenuItem)target;
			break;
		case 31:
			MenuSyncNow = (System.Windows.Controls.MenuItem)target;
			MenuSyncNow.Click += dvHgo6MfL2c;
			break;
		case 32:
			MenuSyncHistory = (System.Windows.Controls.MenuItem)target;
			MenuSyncHistory.Click += c3VgoXUoanx;
			break;
		case 33:
			MenuCheckUpdate = (System.Windows.Controls.MenuItem)target;
			MenuCheckUpdate.Click += Eusgom7uLtP;
			break;
		case 34:
			MenuCheckActionUpdate = (System.Windows.Controls.MenuItem)target;
			MenuCheckActionUpdate.Click += j65goKqmfln;
			break;
		case 35:
			((System.Windows.Controls.MenuItem)target).Click += DrZgdmnK22q;
			num = 5;
			if (KFAA56FF0QDLtiRxUqXm == null)
			{
				goto IL_09ea;
			}
			goto IL_0a4a;
		case 36:
			MenuActionRecycleBin = (System.Windows.Controls.MenuItem)target;
			MenuActionRecycleBin.Click += BWAgoxq0TJI;
			break;
		case 37:
			MenuExportActionsCsv = (System.Windows.Controls.MenuItem)target;
			goto IL_0a4a;
		case 38:
			MenuMaintainTools = (System.Windows.Controls.MenuItem)target;
			MenuMaintainTools.Click += avagorWP4BY;
			break;
		case 39:
			MenuResetTextFloatPanelState = (System.Windows.Controls.MenuItem)target;
			MenuResetTextFloatPanelState.Click += EpSgopZ65XW;
			break;
		case 40:
			MenuKeyboardState = (System.Windows.Controls.MenuItem)target;
			MenuKeyboardState.Click += RvbgoBAC5yS;
			break;
		case 41:
			MenuRegisterChromeAgent = (System.Windows.Controls.MenuItem)target;
			MenuRegisterChromeAgent.Click += BTUgoPX5WF6;
			break;
		case 42:
			MenuShowFloatTrigger = (System.Windows.Controls.MenuItem)target;
			goto IL_0a63;
		case 43:
			MenuInstallEdge = (System.Windows.Controls.MenuItem)target;
			MenuInstallEdge.Click += yAigoDp0LT1;
			break;
		case 44:
			MenuOpenGuide = (System.Windows.Controls.MenuItem)target;
			MenuOpenGuide.Click += bCUgohs4st0;
			break;
		case 45:
			MenuOpenHelp = (System.Windows.Controls.MenuItem)target;
			MenuOpenHelp.Click += iYxgo9jk0BJ;
			break;
		case 46:
			MenuSendFeedback = (System.Windows.Controls.MenuItem)target;
			MenuSendFeedback.Click += pdVgoZ0C0H3;
			break;
		case 47:
			MenuViewUsage = (System.Windows.Controls.MenuItem)target;
			MenuViewUsage.Click += eCSgoGOCncF;
			break;
		case 48:
			((System.Windows.Controls.MenuItem)target).Click += Cc6gokD9Svf;
			break;
		case 49:
			MenuUpdateVersion = (System.Windows.Controls.MenuItem)target;
			MenuUpdateVersion.Click += FJDgoWxAe2j;
			break;
		case 50:
			((System.Windows.Controls.MenuItem)target).Click += hEjgoeTmMG6;
			break;
		case 52:
			BtnSync = (System.Windows.Controls.Button)target;
			BtnSync.Click += bEMgdDVfsJa;
			break;
		case 53:
			SyncStateControl = (SyncStateControl)target;
			break;
		case 54:
			MenuUser = (DropDownButton)target;
			break;
		case 55:
			ConnectionStatusIcon = (SvgAwesome)target;
			break;
		case 56:
			MainContextMenuUser = (System.Windows.Controls.ContextMenu)target;
			break;
		case 57:
			MenuOpenUserHome = (System.Windows.Controls.MenuItem)target;
			MenuOpenUserHome.Click += ziIgd66MnkI;
			num = 0;
			if (!fWVT2mFF1RiQemAUASaA())
			{
				goto IL_09e6;
			}
			goto IL_09ea;
		case 58:
			((System.Windows.Controls.MenuItem)target).Click += vQ6gojKJn3h;
			break;
		case 59:
			iconPushState = (SvgAwesome)target;
			break;
		case 60:
			txtPushState = (TextBlock)target;
			break;
		case 61:
			MenuConnectPushServer = (System.Windows.Controls.MenuItem)target;
			MenuConnectPushServer.Click += pW6govY3dB2;
			break;
		case 62:
			MenuDisconnectPushServer = (System.Windows.Controls.MenuItem)target;
			MenuDisconnectPushServer.Click += jKMgoSVHmDx;
			break;
		case 63:
			MenuSetActiveClient = (System.Windows.Controls.MenuItem)target;
			MenuSetActiveClient.Click += MIBgo2Zmmqd;
			break;
		case 64:
			MenuPushToPc = (System.Windows.Controls.MenuItem)target;
			MenuPushToPc.Click += GQqgonkxdL3;
			break;
		case 65:
			BtnClientConnection = (System.Windows.Controls.MenuItem)target;
			BtnClientConnection.Click += ooEgdKx5BYn;
			break;
		case 66:
			BtnPin = (System.Windows.Controls.Button)target;
			goto IL_0a7b;
		case 67:
			IconPin = (SvgAwesome)target;
			break;
		case 68:
			BtnClose = (System.Windows.Controls.Button)target;
			BtnClose.Click += pW9gd1ayoa1;
			BtnClose.Drop += Ff3gdgnwDwW;
			break;
		case 69:
			GlobalBtnCanvas = (Canvas)target;
			break;
		case 70:
			GridMiddleToolbar = (Grid)target;
			break;
		case 71:
			((StackPanel)target).PreviewMouseRightButtonDown += sovgDlTXSJJ;
			break;
		case 72:
			ImgProfileExeIcon = (IconControl)target;
			break;
		case 73:
			LblProfile = (TextBlock)target;
			LblProfile.PreviewMouseDown += pbxgdr4fIEs;
			break;
		case 74:
			BtnSearch = (System.Windows.Controls.Button)target;
			BtnSearch.Click += jG0gdiSV5Ua;
			break;
		case 75:
			BtnToggleLock = (System.Windows.Controls.Button)target;
			goto IL_0af2;
		case 76:
			IconLock = (SvgAwesome)target;
			num = 3;
			if (fWVT2mFF1RiQemAUASaA())
			{
				goto IL_09ea;
			}
			goto IL_0a31;
		case 77:
			BtnToolboxMenu = (DropDownButton)target;
			num = 14;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				goto IL_09e6;
			}
			goto IL_09ea;
		case 78:
			MenuToolbox = (System.Windows.Controls.ContextMenu)target;
			break;
		case 79:
			MenuShowToolbox = (System.Windows.Controls.MenuItem)target;
			goto IL_09c2;
		case 80:
			MenuShowAppSelector = (System.Windows.Controls.MenuItem)target;
			MenuShowAppSelector.Click += kwmgdFekkVf;
			break;
		case 81:
			MenuOpenShareBase = (System.Windows.Controls.MenuItem)target;
			MenuOpenShareBase.Click += NslgdUVhNhS;
			break;
		case 82:
			MenuOpenFaIconSelector = (System.Windows.Controls.MenuItem)target;
			MenuOpenFaIconSelector.Click += E36goNPQMoL;
			break;
		case 83:
			GlobalProfileNavIndicator = (ProfileNavIndicator)target;
			break;
		case 84:
			ProfileNavIndicator = (ProfileNavIndicator)target;
			break;
		case 85:
			ContextBtnCanvas = (Canvas)target;
			break;
		case 86:
			LblCreateProfileForApp = (TextBlock)target;
			LblCreateProfileForApp.PreviewMouseDown += p23gdxLgCQe;
			break;
		case 87:
			BtnOpenProcessFolder = (System.Windows.Controls.Button)target;
			BtnOpenProcessFolder.PreviewMouseUp += w1Igdff45Qy;
			break;
		case 88:
			BtnBlockCreateProfileHint = (System.Windows.Controls.Button)target;
			BtnBlockCreateProfileHint.Click += eq6goy8uiuP;
			break;
		case 89:
			{
				BtnAddToBlockList = (System.Windows.Controls.Button)target;
				BtnAddToBlockList.PreviewMouseUp += giZgoEO6Lwj;
				break;
			}
			IL_09ea:
			switch (num)
			{
			case 12:
				break;
			default:
				return;
			case 1:
				return;
			case 2:
				goto IL_0a31;
			case 3:
				return;
			case 4:
				goto IL_0a4a;
			case 5:
				return;
			case 6:
				goto IL_0a63;
			case 7:
				goto IL_0a7b;
			case 8:
				MenuPowerKeys.Click += da0goHdByV1;
				return;
			case 10:
				MenuLeftButtonPlus.Click += t2ngo13a8T3;
				return;
			case 11:
				goto IL_0af2;
			case 13:
				goto IL_0b21;
			case 14:
				return;
			case 15:
				return;
			}
			goto IL_09c2;
			IL_0af2:
			BtnToggleLock.Click += xDWgdoMlbkk;
			BtnToggleLock.MouseRightButtonUp += wjGgoJ8qC5H;
			break;
			IL_0a7b:
			BtnPin.Click += XQ3gdbOpuru;
			BtnPin.PreviewMouseRightButtonDown += f3mgoaQ2Cry;
			break;
			IL_0a63:
			MenuShowFloatTrigger.Click += NprgoQDG5kQ;
			break;
			IL_0a4a:
			MenuExportActionsCsv.Click += loCgdlCibpC;
			break;
			IL_09c2:
			MenuShowToolbox.Click += WHKgdjSwNeU;
			num = 1;
			if (!fWVT2mFF1RiQemAUASaA())
			{
				goto IL_09e6;
			}
			goto IL_09ea;
			IL_09e6:
			num = num2;
			goto IL_09ea;
			IL_0b21:
			MenuProfileManage.Click += pbxgdr4fIEs;
			break;
			IL_0a31:
			LblAppTitle.PreviewMouseDown += pBFgdLBC6ma;
			break;
		}
	}

	static PopupWindow()
	{
		ShowCreateActionIconProperty = DependencyProperty.Register("ShowCreateActionIcon", typeof(bool), typeof(global::Quicker.View.PopupWindow), new PropertyMetadata(false));
		mThgTXnjjlO = System.Windows.Media.Color.FromArgb(byte.MaxValue, 0, 0, 0).GetBrush();
		ButtonColorProperty = DependencyProperty.RegisterAttached("ButtonColor", typeof(System.Windows.Media.Brush), typeof(PopupWindow), new FrameworkPropertyMetadata(mThgTXnjjlO, FrameworkPropertyMetadataOptions.Inherits, null));
		xI5gTmj2IYG = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		EnableSimpleModeProperty = DependencyProperty.Register("EnableSimpleMode", typeof(bool), typeof(global::Quicker.View.PopupWindow), new PropertyMetadata(true));
		V36gTD6CTD9 = NativeMethods.RegisterWindowMessage("TaskbarCreated");
	}

	[CompilerGenerated]
	private void EvWgooOIXA3()
	{
		MainContextMenuUser.IsOpen = false;
		if (CanCloseWindow())
		{
			JfygDfxSije();
		}
	}

	[CompilerGenerated]
	private void dlDgoThhluW(object sender, EventArgs e)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
		AppState.MainWinHandle = windowInteropHelper.Handle;
		int windowLong = NativeMethods.GetWindowLong(windowInteropHelper.Handle, -20);
		if (NativeMethods.SetWindowLong(windowInteropHelper.Handle, -20, (int)(windowLong | 0x80L | 0x8000000L)) != 0)
		{
			NativeMethods.GetLastError();
		}
		ClipboardManager.Instance.ClipboardChanged += ClipboardChanged;
		HwndSource.FromHwnd(windowInteropHelper.Handle).AddHook(XHugdvYZOWX);
		WEh2cFflZcNKgNsYJEP.xqJLUFgYj50().rDrLUA0dkhn(this, true);
		Ax9qOtYhE8UFQqEXJI0.YH9LRVwBjhw(windowInteropHelper.Handle);
	}

	[CompilerGenerated]
	internal static bool DnXgoM8FbHr()
	{
		try
		{
			return Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\DWM", "ColorPrevalence", "0").ToString().Equals("1");
		}
		catch (Exception)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private void zLSgoAp2S9P(object sender, ManipulationStartedEventArgs e)
	{
		e.Handled = true;
		ek1gTdHbRXY = 0.0;
	}

	[CompilerGenerated]
	private void lvagoOuin0s(object sender, ManipulationDeltaEventArgs e)
	{
		double num = e.CumulativeManipulation.Translation.X - ek1gTdHbRXY;
		if (!(num < 0.0 - j18gTTjg6Cx) && !(num > j18gTTjg6Cx))
		{
			return;
		}
		ek1gTdHbRXY = e.CumulativeManipulation.Translation.X;
		if (num < 0.0 - j18gTTjg6Cx)
		{
			pqLgT1i3kQh.GlobalGoRight();
			int num2 = 0;
			if (!fWVT2mFF1RiQemAUASaA())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		else if (num > j18gTTjg6Cx)
		{
			pqLgT1i3kQh.GlobalGoLeft();
		}
	}

	[CompilerGenerated]
	private void R4VgoF6hG9V(object sender, ManipulationStartedEventArgs e)
	{
		e.Handled = true;
		y4PgToqFZls = 0.0;
	}

	[CompilerGenerated]
	private void VEQgoUDbjtw(object sender, ManipulationDeltaEventArgs e)
	{
		double num = e.CumulativeManipulation.Translation.X - y4PgToqFZls;
		if (!(num < 0.0 - j18gTTjg6Cx) && !(num > j18gTTjg6Cx))
		{
			return;
		}
		y4PgToqFZls = e.CumulativeManipulation.Translation.X;
		if (num < 0.0 - j18gTTjg6Cx)
		{
			pqLgT1i3kQh.GoRight();
		}
		else if (num > j18gTTjg6Cx)
		{
			pqLgT1i3kQh.GoLeft();
			int num2 = 0;
			if (KFAA56FF0QDLtiRxUqXm != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
	}

	[CompilerGenerated]
	private void hDcgolFjkPK(Task task_0)
	{
		base.Dispatcher.Invoke(gJugoiE5EqO);
	}

	[CompilerGenerated]
	private void gJugoiE5EqO()
	{
		Hide();
	}

	[CompilerGenerated]
	private void Xa7go3quBlb()
	{
		string text = "c:\\qk_disable_auto.txt";
		if (File.Exists(text))
		{
			MessageBoxHelper.Show(Window.GetWindow(this), "已停止自动运行动作。如需恢复，请删除文件" + text + "。");
		}
		else
		{
			Thread.Sleep(500);
			ReloadAutoRun(true);
		}
		if (AppState.IsGpuDisabled)
		{
			AppHelper.ShowWarning("已禁用GPU加速。\r\n如需取消请删除C:\\qk_disable_gpu.txt。");
		}
	}

	[CompilerGenerated]
	private void j8CgofZQ03i()
	{
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				int buttonIndex = AppHelper.GetButtonIndex(false, i, j);
				SetButtonAction(buttonIndex, kNxgT9fV6dX.GetAction(buttonIndex));
			}
		}
	}

	[CompilerGenerated]
	private void wfbgoz1Mkcp()
	{
		AppHelper.ForEachButton(true, false, 4, sBCgTwBm4W8);
	}

	[CompilerGenerated]
	private void sBCgTwBm4W8(int int_1)
	{
		ActionItem action = kNxgT9fV6dX.GetAction(int_1);
		SetButtonAction(int_1, action);
	}

	[CompilerGenerated]
	private void viIgTtFFBVI()
	{
		wYegT3agQwi.RequestHide();
	}

	[CompilerGenerated]
	private void B9igTghJNTU(object sender, EventArgs e)
	{
		DashboardWindow = null;
	}

	[CompilerGenerated]
	private void gU0gTLkmZup(object sender, EventArgs e)
	{
		PiigMgST5vU = null;
	}

	[CompilerGenerated]
	private void DUygTvHmGRe()
	{
		I52gogjXQrb();
	}

	[CompilerGenerated]
	private void CSqgTSbprpD(object sender, EventArgs e)
	{
		ltIgML7eYpt = null;
	}

	[CompilerGenerated]
	internal static string fq2gT2uF5T0(ExeInfo exeInfo_0)
	{
		return exeInfo_0.Name ?? "";
	}

	[CompilerGenerated]
	private void E01gTu3MtGr()
	{
		g7OgTVU3nuu.xdNt6mQNakh(true, true, true);
	}

	internal static bool fWVT2mFF1RiQemAUASaA()
	{
		return KFAA56FF0QDLtiRxUqXm == null;
	}
}
