using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Interop;
using Ci3RULiH5a8Cgg0fIS5;
using log4net;
using pIT49aoFdAW3SoSGw31;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Hotkeys;
using Quicker.Domain.Messages;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using Quicker.View.Hotkeys;

namespace HMdjedXPwaug8yh9mEq;

internal class brgW8EX9ZVfZExh7q9t
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec pRCvo17HjD6;

		public static Func<ActionHotKeyItem, bool> Ybavobv82an;

		public static Func<int, bool> rravo6LWkH9;

		public static Func<ActionHotKeyItem, bool> hFTvoXb0YYN;

		public static Func<ActionHotKeyItem, bool> adAvom7eSnf;

		public static Func<ActionHotKeyItem, int> ilIvoKHcRn7;

		public static Func<ActionHotKeyItem, string> rcJvoxPjA9n;

		private static _003C_003Ec kFbC7pWy8tB3AhlUoBOI;

		static _003C_003Ec()
		{
			pRCvo17HjD6 = new _003C_003Ec();
		}

		internal bool xYNvoIRZl5s(ActionHotKeyItem x)
		{
			if (!x.IsEnabled)
			{
				return false;
			}
			return AppState.DataService.QHmtXwg81eY(x.ActionId).action != null;
		}

		internal bool CRJvoW0BQKE(int x)
		{
			return x >= 9100;
		}

		internal bool j0cvok7O8NP(ActionHotKeyItem x)
		{
			return AppState.CurrentProcessName.IsProcessInBinding(x.BindingProcessName, false);
		}

		internal bool VDLvoG7M8kV(ActionHotKeyItem x)
		{
			return string.IsNullOrEmpty(x.BindingProcessName);
		}

		internal int DwKvoskYIGK(ActionHotKeyItem x)
		{
			int num = AppState.P7gt7BYmHZ0.RecentActions.IndexOf(x.ActionId);
			if (num >= 0)
			{
				return num;
			}
			return int.MaxValue;
		}

		internal string h25voH7oy1i(ActionHotKeyItem x)
		{
			return x.Title;
		}

		internal static bool rtKt3LWyRP2tNRQ8Av40()
		{
			return kFbC7pWy8tB3AhlUoBOI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public int s8uvopN4Cix;

		internal static _003C_003Ec__DisplayClass36_0 dy98WRWyPPCLG6dmeh45;

		internal bool xVAvorhHQPI(KeyValuePair<int, RegisteredHotkeyItem> x)
		{
			return x.Key == s8uvopN4Cix;
		}

		internal static bool GTlrtrWyMDOsgaW0si9g()
		{
			return dy98WRWyPPCLG6dmeh45 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public ActionHotKeyItem QiDvoQBfb21;

		internal static _003C_003Ec__DisplayClass38_0 WLfewnWyx8O7XlenRJg4;

		internal bool jhRvoBnKLFa(RegisteredHotkeyItem x)
		{
			if (x != null && x.HotkeyId >= 9100)
			{
				return x.KeyData == QiDvoQBfb21.Keys;
			}
			return false;
		}

		internal static bool kKKfnmWyIV3O5Cd99f8l()
		{
			return WLfewnWyx8O7XlenRJg4 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public IList<ActionHotKeyItem> YGKvojc7InW;

		public brgW8EX9ZVfZExh7q9t nJAvonl1xwN;

		private static _003C_003Ec__DisplayClass47_0 aNcWMuWyw552R90ssi8L;

		internal static bool ORmcXiWyTZCe7Sr7Pw19()
		{
			return aNcWMuWyw552R90ssi8L == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		public IntPtr hWKvo5Hlk7W;

		public _003C_003Ec__DisplayClass47_0 FyfvoD8hvgo;

		private static _003C_003Ec__DisplayClass47_1 UJeAIbWysjsEPvUNlwgE;

		internal void NpKvo4AOuga()
		{
			System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu
			{
				FontSize = 16.0
			};
			double num = 24.0;
			using (IEnumerator<ActionHotKeyItem> enumerator = FyfvoD8hvgo.YGKvojc7InW.GetEnumerator())
			{
				int num3 = default(int);
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass47_2 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_2();
					int num2 = 0;
					if (!gmmvfWWyCsn8Huwik9Iy())
					{
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Ec__DisplayClass47_.SxUvoTan9P6 = this;
					_003C_003Ec__DisplayClass47_.juLvook4sPh = enumerator.Current;
					(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(_003C_003Ec__DisplayClass47_.juLvook4sPh.ActionId);
					if (tuple.Item1 != null)
					{
						ActionItem item = tuple.Item1;
						ItemCollection items = contextMenu.Items;
						string title = item.Title;
						string description = item.Description;
						string icon = item.Icon;
						RoutedEventHandler handler = _003C_003Ec__DisplayClass47_.b6uvod1YvPH;
						double iconSize = num;
						AppHelper.AddMenuItem(items, title, description, icon, handler, null, null, null, iconSize);
					}
					else
					{
						AppHelper.ShowWarning(tuple.Item2 ?? "");
					}
				}
			}
			if (contextMenu.Items.Count > 0)
			{
				s9FQEkoVPmSwysv7kms.BqxgxCG0Fav(contextMenu, true);
			}
		}

		internal static bool gmmvfWWyCsn8Huwik9Iy()
		{
			return UJeAIbWysjsEPvUNlwgE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct F91nlRk1KuqonFXTQpn : IAsyncStateMachine
		{
			public int jCo2qDKI3Pn;

			public AsyncVoidMethodBuilder Cpb2qdvnlcb;

			public _003C_003Ec__DisplayClass47_2 Ccx2qoAjxAk;

			private TaskAwaiter tR32qT2TGNB;

			internal static object sO73cvyfnAhT3Fn2c9qm;

			private void MoveNext()
			{
				int num = jCo2qDKI3Pn;
				_003C_003Ec__DisplayClass47_2 _003C_003Ec__DisplayClass47_ = Ccx2qoAjxAk;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						NativeMethods.SetForegroundWindow(_003C_003Ec__DisplayClass47_.SxUvoTan9P6.hWKvo5Hlk7W);
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							jCo2qDKI3Pn = 0;
							tR32qT2TGNB = awaiter;
							Cpb2qdvnlcb.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = tR32qT2TGNB;
						tR32qT2TGNB = default(TaskAwaiter);
						num = -1;
						jCo2qDKI3Pn = -1;
					}
					awaiter.GetResult();
					_003C_003Ec__DisplayClass47_.SxUvoTan9P6.FyfvoD8hvgo.nJAvonl1xwN.J8ktppeKKp7.NotifyRunAction(_003C_003Ec__DisplayClass47_.SxUvoTan9P6.FyfvoD8hvgo.nJAvonl1xwN, _003C_003Ec__DisplayClass47_.juLvook4sPh.ActionId, false, false, ActionTrigger.Hotkey, false, null, _003C_003Ec__DisplayClass47_.juLvook4sPh.ActionParam);
				}
				catch (Exception exception)
				{
					jCo2qDKI3Pn = -2;
					Cpb2qdvnlcb.SetException(exception);
					return;
				}
				jCo2qDKI3Pn = -2;
				Cpb2qdvnlcb.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Cpb2qdvnlcb.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool pHue21yfei3jo5AgWUQL()
			{
				return sO73cvyfnAhT3Fn2c9qm == null;
			}
		}

		public ActionHotKeyItem juLvook4sPh;

		public _003C_003Ec__DisplayClass47_1 SxUvoTan9P6;

		internal static _003C_003Ec__DisplayClass47_2 mWEF7vWyhBLpBVaEp6Ff;

		[AsyncStateMachine(typeof(F91nlRk1KuqonFXTQpn))]
		internal void b6uvod1YvPH(object sender, RoutedEventArgs e)
		{
			F91nlRk1KuqonFXTQpn stateMachine = default(F91nlRk1KuqonFXTQpn);
			stateMachine.Cpb2qdvnlcb = AsyncVoidMethodBuilder.Create();
			stateMachine.Ccx2qoAjxAk = this;
			stateMachine.jCo2qDKI3Pn = -1;
			stateMachine.Cpb2qdvnlcb.Start(ref stateMachine);
		}

		static _003C_003Ec__DisplayClass47_2()
		{
		}

		internal static bool D5v70MWyHMUxqRceVNK5()
		{
			return mWEF7vWyhBLpBVaEp6Ff == null;
		}

		internal static void FX5S4xWpVI9AbwjCseFS()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_3
	{
		public ActionHotKeyItem WWqvoAsaKLt;

		public _003C_003Ec__DisplayClass47_0 KGgvoOjMIji;

		private static _003C_003Ec__DisplayClass47_3 HFuFO4WpQeeAZQpSyK2V;

		internal void IRFvoMiUMLB()
		{
			if (WWqvoAsaKLt.WaitKeyUp)
			{
				while (System.Windows.Forms.Control.ModifierKeys != Keys.None)
				{
					Thread.Sleep(20);
				}
			}
			KGgvoOjMIji.nJAvonl1xwN.J8ktppeKKp7.NotifyRunAction(KGgvoOjMIji.nJAvonl1xwN, WWqvoAsaKLt.ActionId, false, false, ActionTrigger.Hotkey, false, null, WWqvoAsaKLt.ActionParam);
		}

		internal static bool joYwKqWpFaIxE1YRE7op()
		{
			return HFuFO4WpQeeAZQpSyK2V == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public ActionItem YPCvoUQ0EHU;

		internal static _003C_003Ec__DisplayClass50_0 sHfLSaWpW8TmvvMrddJo;

		internal bool YHcvoF6fX2v(ActionHotKeyItem x)
		{
			return x.ActionId == YPCvoUQ0EHU.Id;
		}

		internal static void Ih4Mc6WpXWN36B82UGhI()
		{
		}

		internal static bool f01Cu2Wpy3VADylqYOif()
		{
			return sHfLSaWpW8TmvvMrddJo == null;
		}
	}

	private readonly PopupWindow LHMtprhEqwh;

	private readonly ITinyMessengerHub J8ktppeKKp7;

	private readonly DataService QLQtpBE5Ga6;

	private readonly UIy1pYiDsLcf2l4joSP b6htpQFCrg5;

	private readonly AppServer g27tpjgpRLE;

	private readonly PopupState UastpnRFPJu;

	private readonly TextFloatPanelMgr kUktp4foJW9;

	private HwndSource Rsktp55REkT;

	private readonly IDictionary<int, RegisteredHotkeyItem> uWgtpD5fYPf = new Dictionary<int, RegisteredHotkeyItem>();

	private static readonly ILog jCOtpdNjieK;

	private string SM0tpoXDWTS = string.Empty;

	private DebounceTimer OxStpTSl6C4 = new DebounceTimer();

	private IList<ActionHotKeyItem> v3WtpMVtU1F = new List<ActionHotKeyItem>();

	[CompilerGenerated]
	private readonly IList<string> dj5tpAY6xyR = new List<string>();

	private readonly IList<string> IIwtpO8JcSR = new List<string>();

	private static brgW8EX9ZVfZExh7q9t GtxsVlQ9fkwDBK35A5Cy;

	public brgW8EX9ZVfZExh7q9t(PopupWindow popupWindow_1, ITinyMessengerHub itinyMessengerHub_1, DataService dataService_1, UIy1pYiDsLcf2l4joSP uiy1pYiDsLcf2l4joSP_1, AppServer appServer_1, PopupState popupState_1, TextFloatPanelMgr textFloatPanelMgr_1)
	{
		LHMtprhEqwh = popupWindow_1;
		J8ktppeKKp7 = itinyMessengerHub_1;
		QLQtpBE5Ga6 = dataService_1;
		b6htpQFCrg5 = uiy1pYiDsLcf2l4joSP_1;
		g27tpjgpRLE = appServer_1;
		UastpnRFPJu = popupState_1;
		kUktp4foJW9 = textFloatPanelMgr_1;
		AppState.N6Ltao56yJF(this);
		J8ktppeKKp7.Subscribe<UserSettingsChangedMessage>(CKmtpyMS3ra);
		J8ktppeKKp7.Subscribe<ActiveProcessChangedMessage>(hobtpEZuL1r);
	}

	private void hobtpEZuL1r(ActiveProcessChangedMessage activeProcessChangedMessage_0)
	{
		if (UastpnRFPJu.IsEnabled)
		{
			OxStpTSl6C4.Debounce(100, IZhtpbRG9td);
		}
	}

	private void CKmtpyMS3ra(UserSettingsChangedMessage userSettingsChangedMessage_0)
	{
		System.Windows.Application.Current?.Dispatcher.InvokeAsync(DaGtpmbWfSu);
	}

	[SpecialName]
	[CompilerGenerated]
	public IList<string> C2JtpKqOOT9()
	{
		return dj5tpAY6xyR;
	}

	public void c8ptp8hF7GY()
	{
		IIwtpO8JcSR.Clear();
		YMStphQmLVw();
		nSWtpGlAkSY();
		C2JtpKqOOT9().Clear();
		string hotKeysData = QLQtpBE5Ga6.CpItmVISR7P().HotKeysData;
		int num = 1;
		if (GtxsVlQ9fkwDBK35A5Cy != null)
		{
			goto IL_015f;
		}
		goto IL_0163;
		IL_015f:
		int num2 = default(int);
		num = num2;
		goto IL_0163;
		IL_0163:
		HotKeySettings hotKeySettings = default(HotKeySettings);
		do
		{
			IList<ActionHotKeyItem> actionHotkeys;
			Func<ActionHotKeyItem, bool> predicate;
			switch (num)
			{
			case 1:
				if (rIbtp9MCkkJ(QLQtpBE5Ga6.CpItmVISR7P().OpenWithGlobalHotkey, 9000))
				{
					uWgtpD5fYPf.Add(9000, null);
				}
				if (!string.IsNullOrEmpty(hotKeysData))
				{
					hotKeySettings = HotKeySettings.FromData(hotKeysData);
					actionHotkeys = hotKeySettings.ActionHotkeys;
					predicate = _003C_003Ec.Ybavobv82an ?? (_003C_003Ec.Ybavobv82an = _003C_003Ec.pRCvo17HjD6.xYNvoIRZl5s);
					break;
				}
				return;
			default:
				cKstpZA7XAC(hotKeySettings.KeysForToggleTextFloatWindow, 9009);
				cKstpZA7XAC(hotKeySettings.KeysForOpenSettings, 9010);
				cKstpZA7XAC(hotKeySettings.KeysForExeSettings, 9011);
				igctpcINr9B();
				return;
			}
			v3WtpMVtU1F = actionHotkeys.Where(predicate).ToList();
			cKstpZA7XAC(hotKeySettings.KeysForPausePopup, 9001);
			cKstpZA7XAC(hotKeySettings.KeysForAppStartVoiceInput, 9002);
			cKstpZA7XAC(hotKeySettings.KeysForCancelRunningTasks, 9003);
			cKstpZA7XAC(hotKeySettings.KeysForCloseAllFloatButtons, 9004);
			cKstpZA7XAC(hotKeySettings.KeysForReloadMouseHook, 9005);
			cKstpZA7XAC(hotKeySettings.KeysForSearch, 9006);
			cKstpZA7XAC(hotKeySettings.KeysForRepeatLast, 9007);
			cKstpZA7XAC(hotKeySettings.KeysForDashboardWindow, 9008);
			num = 0;
		}
		while (c4uKZ3Q9bEh5SfmhlSHN());
		goto IL_015f;
	}

	private bool a3CtpaVEqAE(ActionHotKeyItem actionHotKeyItem_0)
	{
		if (actionHotKeyItem_0.IsEnabled)
		{
			return EhutpR97mio(actionHotKeyItem_0.BindingProcessName, actionHotKeyItem_0.BlackList, AppState.CurrentProcessName, true);
		}
		return false;
	}

	private bool Du6tp772OQW(ActionHotKeyItem actionHotKeyItem_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			if (actionHotKeyItem_0.IsEnabled && actionHotKeyItem_0.BindingProcessName.IsNullOrEmpty())
			{
				return actionHotKeyItem_0.BlackList.IsNullOrEmpty();
			}
			return false;
		}
		if (actionHotKeyItem_0.IsEnabled)
		{
			return EhutpR97mio(actionHotKeyItem_0.BindingProcessName, actionHotKeyItem_0.BlackList, string_1, true);
		}
		return false;
	}

	public static bool EhutpR97mio(string string_1, string string_2, string string_3, bool bool_0)
	{
		if (!string.IsNullOrEmpty(string_1))
		{
			return string_3.IsProcessInBinding(string_1, bool_0);
		}
		if (!string.IsNullOrWhiteSpace(string_2))
		{
			return !string_3.IsProcessInBinding(string_2, bool_0);
		}
		return bool_0;
	}

	public int L7WtpqmKBOJ()
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.s8uvopN4Cix = 9100;
		while (uWgtpD5fYPf.Any(_003C_003Ec__DisplayClass36_.xVAvorhHQPI))
		{
			_003C_003Ec__DisplayClass36_.s8uvopN4Cix++;
		}
		return _003C_003Ec__DisplayClass36_.s8uvopN4Cix;
	}

	public void igctpcINr9B()
	{
		if (!v3WtpMVtU1F.HasData())
		{
			return;
		}
		foreach (ActionHotKeyItem item in v3WtpMVtU1F)
		{
			if (a3CtpaVEqAE(item))
			{
				MH9tpVhsvio(item);
				continue;
			}
			foreach (KeyValuePair<int, RegisteredHotkeyItem> item2 in uWgtpD5fYPf)
			{
				if (item2.Key >= 9100 && item2.Value.ActionHotKeyItems.Contains(item))
				{
					item2.Value.ActionHotKeyItems.Remove(item);
				}
			}
		}
		foreach (int item3 in uWgtpD5fYPf.Keys.Where(_003C_003Ec.rravo6LWkH9 ?? (_003C_003Ec.rravo6LWkH9 = _003C_003Ec.pRCvo17HjD6.CRJvoW0BQKE)).ToList())
		{
			if (!uWgtpD5fYPf[item3].ActionHotKeyItems.HasData())
			{
				BYAtpsgV74r(item3);
			}
		}
	}

	private void MH9tpVhsvio(ActionHotKeyItem actionHotKeyItem_0)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		_003C_003Ec__DisplayClass38_.QiDvoQBfb21 = actionHotKeyItem_0;
		RegisteredHotkeyItem registeredHotkeyItem = uWgtpD5fYPf.Values.FirstOrDefault(_003C_003Ec__DisplayClass38_.jhRvoBnKLFa);
		if (registeredHotkeyItem != null)
		{
			if (registeredHotkeyItem.ActionHotKeyItems.Contains(_003C_003Ec__DisplayClass38_.QiDvoQBfb21))
			{
				return;
			}
			registeredHotkeyItem.ActionHotKeyItems.Add(_003C_003Ec__DisplayClass38_.QiDvoQBfb21);
			if (c4uKZ3Q9bEh5SfmhlSHN())
			{
				switch (0)
				{
				}
			}
		}
		else
		{
			int num = L7WtpqmKBOJ();
			registeredHotkeyItem = new RegisteredHotkeyItem(_003C_003Ec__DisplayClass38_.QiDvoQBfb21.Keys, num, _003C_003Ec__DisplayClass38_.QiDvoQBfb21);
			uWgtpD5fYPf[num] = registeredHotkeyItem;
			rIbtp9MCkkJ(_003C_003Ec__DisplayClass38_.QiDvoQBfb21.Keys, num);
		}
	}

	private void cKstpZA7XAC(string string_1, int int_0)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return;
		}
		if (rIbtp9MCkkJ(string_1, int_0))
		{
			if (!uWgtpD5fYPf.ContainsKey(int_0))
			{
				uWgtpD5fYPf.Add(int_0, null);
			}
		}
		else
		{
			C2JtpKqOOT9().Add(string_1);
		}
	}

	private bool rIbtp9MCkkJ(string string_1, int int_0)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return false;
		}
		string[] array = string_1.Split('|');
		if (array.Length != 2)
		{
			AppHelper.ShowWarning("快捷键参数不正确！");
			return false;
		}
		try
		{
			uint fsModifiers = Convert.ToUInt32(array[0], CultureInfo.InvariantCulture);
			uint vk = Convert.ToUInt32(array[1], CultureInfo.InvariantCulture);
			if (!NativeMethods.RegisterHotKey(new WindowInteropHelper(LHMtprhEqwh).Handle, int_0, fsModifiers, vk))
			{
				if (!IIwtpO8JcSR.Contains(string_1))
				{
					AppHelper.ShowWarning("注册快捷键失败：" + Hotkey.DataToString(string_1));
					IIwtpO8JcSR.Add(string_1);
				}
				return false;
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("注册快捷键失败：" + Hotkey.DataToString(string_1) + " 异常：" + ex.Message);
			return false;
		}
		return true;
	}

	private void YMStphQmLVw()
	{
		if (Rsktp55REkT == null)
		{
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(LHMtprhEqwh);
			Rsktp55REkT = HwndSource.FromHwnd(windowInteropHelper.Handle);
			Rsktp55REkT.AddHook(MAItpeAo1ha);
		}
	}

	private IntPtr MAItpeAo1ha(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_0)
	{
		if (int_0 == 786)
		{
			bool_0 = mcOtpY8Cnck(intptr_1.ToInt32());
		}
		else
		{
			bool_0 = false;
		}
		return IntPtr.Zero;
	}

	private bool mcOtpY8Cnck(int int_0)
	{
		int num;
		switch (int_0)
		{
		default:
			if (UastpnRFPJu.IsEnabled)
			{
				{
					num = 0;
					if (!c4uKZ3Q9bEh5SfmhlSHN())
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_0167;
				}

				goto IL_017f;
			}
			return false;
		case 9000:
			b6htpQFCrg5.CIUvg7dqbo6(true);
			return true;
		case 9001:
			g27tpjgpRLE.TogglePause();
			return true;
		case 9002:
			g27tpjgpRLE.StartVoiceInput();
			return true;
		case 9003:
			g27tpjgpRLE.StopAllRunningAction();
			return true;
		case 9004:
			g27tpjgpRLE.CloseAllFloatWindow();
			return true;
		case 9005:
			g27tpjgpRLE.RequestReinstallHook();
			return true;
		case 9006:
			g27tpjgpRLE.ShowSearchWindow(string.Empty, true);
			return true;
		case 9007:
			g27tpjgpRLE.RunLastAction(ActionTrigger.Hotkey);
			return true;
		case 9008:
			g27tpjgpRLE.ShowDashboardWindow(null);
			return true;
		case 9009:
			g27tpjgpRLE.ToggleTextFloatWindow();
			return true;
		case 9010:
			AppWindowManager.ShowSettingsWindow(null);
			return true;
		case 9011:
			{
				AppState.HS2taepcAbc().ShowExeSettingsWindow(null);
				num = 1;
				if (c4uKZ3Q9bEh5SfmhlSHN())
				{
					break;
				}
				goto IL_0167;
			}
			IL_0167:
			switch (num)
			{
			case 1:
				goto end_IL_0007;
			}
			if (!X2WtpW1VL1A(int_0))
			{
				return false;
			}
			goto IL_017f;
			IL_017f:
			return true;
			end_IL_0007:
			break;
		}
		return true;
	}

	private bool X2WtpW1VL1A(int int_0)
	{
		int num = 1;
		RegisteredHotkeyItem value;
		while (uWgtpD5fYPf.TryGetValue(int_0, out value))
		{
			int num2 = 0;
			if (GtxsVlQ9fkwDBK35A5Cy != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (value != null && value.ActionHotKeyItems.HasData())
			{
				AppState.Lista4qx2wK().CountHotkey();
				List<ActionHotKeyItem> list = value.ActionHotKeyItems.Where(_003C_003Ec.hFTvoXb0YYN ?? (_003C_003Ec.hFTvoXb0YYN = _003C_003Ec.pRCvo17HjD6.j0cvok7O8NP)).ToList();
				if (list.Any())
				{
					return RIGtpkYhVL1(list);
				}
				list = value.ActionHotKeyItems.Where(_003C_003Ec.adAvom7eSnf ?? (_003C_003Ec.adAvom7eSnf = _003C_003Ec.pRCvo17HjD6.VDLvoG7M8kV)).ToList();
				if (list.Any())
				{
					return RIGtpkYhVL1(list);
				}
				return false;
			}
			return false;
		}
		AppHelper.ShowWarning("未识别的快捷键：" + int_0);
		return true;
	}

	private bool RIGtpkYhVL1(IList<ActionHotKeyItem> ilist_3)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.YGKvojc7InW = ilist_3;
		_003C_003Ec__DisplayClass47_.nJAvonl1xwN = this;
		if (_003C_003Ec__DisplayClass47_.YGKvojc7InW.Count == 0)
		{
			return false;
		}
		if (_003C_003Ec__DisplayClass47_.YGKvojc7InW.Count > 1)
		{
			_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_2 = new _003C_003Ec__DisplayClass47_1();
			_003C_003Ec__DisplayClass47_2.FyfvoD8hvgo = _003C_003Ec__DisplayClass47_;
			_003C_003Ec__DisplayClass47_2.FyfvoD8hvgo.YGKvojc7InW = _003C_003Ec__DisplayClass47_2.FyfvoD8hvgo.YGKvojc7InW.OrderBy(_003C_003Ec.ilIvoKHcRn7 ?? (_003C_003Ec.ilIvoKHcRn7 = _003C_003Ec.pRCvo17HjD6.DwKvoskYIGK)).ThenBy(_003C_003Ec.rcJvoxPjA9n ?? (_003C_003Ec.rcJvoxPjA9n = _003C_003Ec.pRCvo17HjD6.h25voH7oy1i)).ToList();
			_003C_003Ec__DisplayClass47_2.hWKvo5Hlk7W = NativeMethods.GetForegroundWindow();
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass47_2.NpKvo4AOuga);
			return true;
		}
		_003C_003Ec__DisplayClass47_3 _003C_003Ec__DisplayClass47_3 = new _003C_003Ec__DisplayClass47_3();
		_003C_003Ec__DisplayClass47_3.KGgvoOjMIji = _003C_003Ec__DisplayClass47_;
		_003C_003Ec__DisplayClass47_3.WWqvoAsaKLt = _003C_003Ec__DisplayClass47_3.KGgvoOjMIji.YGKvojc7InW[0];
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_3.WWqvoAsaKLt.ActionId))
		{
			Task.Run((Action)_003C_003Ec__DisplayClass47_3.IRFvoMiUMLB);
			return true;
		}
		return false;
	}

	private void nSWtpGlAkSY()
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(LHMtprhEqwh);
		foreach (KeyValuePair<int, RegisteredHotkeyItem> item in uWgtpD5fYPf)
		{
			try
			{
				NativeMethods.UnregisterHotKey(windowInteropHelper.Handle, item.Key);
			}
			catch (Exception exception)
			{
				jCOtpdNjieK.Warn("释放热键异常", exception);
			}
		}
		uWgtpD5fYPf.Clear();
	}

	private void BYAtpsgV74r(int int_0)
	{
		NativeMethods.UnregisterHotKey(new WindowInteropHelper(LHMtprhEqwh).Handle, int_0);
		uWgtpD5fYPf.Remove(int_0);
	}

	public void UottpHVZVJE(ActionItem actionItem_0)
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.YPCvoUQ0EHU = actionItem_0;
		HotKeySettings hotKeySettings = HotKeySettings.FromData(QLQtpBE5Ga6.CpItmVISR7P().HotKeysData);
		if (!hotKeySettings.ActionHotkeys.HasData())
		{
			hotKeySettings.ActionHotkeys = new List<ActionHotKeyItem>();
		}
		ActionHotKeyItem actionHotKeyItem = hotKeySettings.ActionHotkeys.FirstOrDefault(_003C_003Ec__DisplayClass50_.YHcvoF6fX2v);
		if (actionHotKeyItem != null)
		{
			hotKeySettings.ActionHotkeys.Remove(actionHotKeyItem);
			QLQtpBE5Ga6.CpItmVISR7P().HotKeysData = hotKeySettings.ToData();
			QLQtpBE5Ga6.ydot6rVZAkW();
			J8ktppeKKp7.NotifyUserSettingsChange(this);
		}
	}

	public void fgdtp1kRYXX(bool bool_0)
	{
		if (!bool_0)
		{
			c8ptp8hF7GY();
			return;
		}
		if (AppState.HHxtaMaoqJr().HotkeyModeAfterPause == HotkeyModeAfterPause.ClearAll)
		{
			foreach (KeyValuePair<int, RegisteredHotkeyItem> item in uWgtpD5fYPf.ToList())
			{
				BYAtpsgV74r(item.Key);
			}
			return;
		}
		if (AppState.HHxtaMaoqJr().HotkeyModeAfterPause != HotkeyModeAfterPause.KeepTogglePause)
		{
			return;
		}
		int num = 0;
		if (!c4uKZ3Q9bEh5SfmhlSHN())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		foreach (KeyValuePair<int, RegisteredHotkeyItem> item2 in uWgtpD5fYPf.ToList())
		{
			if (item2.Key != 9001)
			{
				BYAtpsgV74r(item2.Key);
			}
		}
	}

	static brgW8EX9ZVfZExh7q9t()
	{
		jCOtpdNjieK = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void IZhtpbRG9td(object object_0)
	{
		if (AppState.CurrentProcessName != SM0tpoXDWTS && v3WtpMVtU1F.Any(yubtp6fVTa1))
		{
			AppHelper.RunOnUiThread(false, BvntpXvHCjH);
		}
	}

	[CompilerGenerated]
	private bool yubtp6fVTa1(ActionHotKeyItem actionHotKeyItem_0)
	{
		if (actionHotKeyItem_0.IsEnabled)
		{
			string bindingProcessName = actionHotKeyItem_0.BindingProcessName;
			if (bindingProcessName == null || bindingProcessName.IndexOf(SM0tpoXDWTS, StringComparison.OrdinalIgnoreCase) < 0)
			{
				string bindingProcessName2 = actionHotKeyItem_0.BindingProcessName;
				if (bindingProcessName2 == null || bindingProcessName2.IndexOf(AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase) < 0)
				{
					string blackList = actionHotKeyItem_0.BlackList;
					if (blackList == null || blackList.IndexOf(SM0tpoXDWTS, StringComparison.OrdinalIgnoreCase) < 0)
					{
						string blackList2 = actionHotKeyItem_0.BlackList;
						if (blackList2 == null)
						{
							return false;
						}
						return blackList2.IndexOf(AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase) >= 0;
					}
				}
			}
			return true;
		}
		return false;
	}

	[CompilerGenerated]
	private void BvntpXvHCjH()
	{
		if (AppState.CurrentProcessName != SM0tpoXDWTS)
		{
			SM0tpoXDWTS = AppState.CurrentProcessName;
			igctpcINr9B();
		}
	}

	[CompilerGenerated]
	private void DaGtpmbWfSu()
	{
		c8ptp8hF7GY();
	}

	internal static bool c4uKZ3Q9bEh5SfmhlSHN()
	{
		return GtxsVlQ9fkwDBK35A5Cy == null;
	}
}
