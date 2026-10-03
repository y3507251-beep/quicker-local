using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Modules.Gesture.Manage;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.Ext;
using Quicker.View.Mouse;
using Quicker.View.UI;

namespace Quicker.View.ProfileManagement.ExeSettingControls;

public class ExeGesturesSettingsControl : UserControl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec cOcSn9pgLCG;

		public static Func<Gesture, string> jq6SnhP0vhO;

		public static Func<ExeSettings, string> oGVSneuFPO0;

		private static _003C_003Ec CoWYGwW6sk2C9qwMubjb;

		static _003C_003Ec()
		{
			cOcSn9pgLCG = new _003C_003Ec();
		}

		internal string SiWSnVpTGUm(Gesture x)
		{
			return x.Name;
		}

		internal string xtySnZTtI1I(ExeSettings x)
		{
			return x.Exe.ToLower();
		}

		internal static void pkSykHW64X9hotqimodO()
		{
		}

		internal static bool O4Pi1wW6CRR1VJNogL3m()
		{
			return CoWYGwW6sk2C9qwMubjb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public GestureItem ETxSnWwfTxl;

		internal static _003C_003Ec__DisplayClass18_0 j31G67W6hADe6jKAAKGa;

		internal bool LPTSnYm8vHn(GestureAction ga)
		{
			return ga.GestureId == ETxSnWwfTxl.Gesture.Id;
		}

		internal bool Nj3SnIsA4ou(GestureAction ga)
		{
			return ga.GestureId == ETxSnWwfTxl.Gesture.Id;
		}

		internal static bool O9k2TPW6HZnZj9XgEvsj()
		{
			return j31G67W6hADe6jKAAKGa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public GestureItem Pi7SnsxV7sw;

		public Func<GestureAction, bool> C3SSnHP01PO;

		private static _003C_003Ec__DisplayClass19_0 TtlqQDWtVJlSkfadXrh1;

		internal bool MLjSnkOwUvN(GestureAction x)
		{
			return x.GestureId == Pi7SnsxV7sw.Gesture.Id;
		}

		internal bool jJcSnGmBKpC(Gesture x)
		{
			return x.Id == Pi7SnsxV7sw.Gesture.Id;
		}

		internal static bool tsCjOJWtQoF75Uq131tS()
		{
			return TtlqQDWtVJlSkfadXrh1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public GestureItem ja0SnbyoW6k;

		internal static _003C_003Ec__DisplayClass20_0 hgQYoYWtW64nMataRrXn;

		internal bool FHjSn1bPWTH(GestureAction ga)
		{
			return ga.GestureId == ja0SnbyoW6k.Gesture.Id;
		}

		internal static bool WsA4TIWtyjjYmNAyXi6k()
		{
			return hgQYoYWtW64nMataRrXn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		public GestureItem OyGSnX52A7j;

		internal static _003C_003Ec__DisplayClass22_0 EPikXtWtXcSlU2JP7EiM;

		internal bool WXjSn6JGrl3(GestureAction x)
		{
			return x.GestureId == OyGSnX52A7j.Gesture.Id;
		}

		internal static bool LwqVWjWt2icViAMx2bTk()
		{
			return EPikXtWtXcSlU2JP7EiM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public GestureItem GrYSnxF2yvo;

		private static _003C_003Ec__DisplayClass24_0 VQYB5HWtnSF1VMpSliEZ;

		internal bool I4hSnmwEUqX(GestureAction x)
		{
			return x.GestureId == GrYSnxF2yvo.Gesture.Id;
		}

		internal bool p62SnKuqXda(GestureAction x)
		{
			return x.GestureId == GrYSnxF2yvo.Gesture.Id;
		}

		static _003C_003Ec__DisplayClass24_0()
		{
		}

		internal static void x65rlkWtDyADjl5geHbj()
		{
		}

		internal static bool qL7godWteqGVwG1OUYHa()
		{
			return VQYB5HWtnSF1VMpSliEZ == null;
		}

		internal static void yn1pqcWt3Is2sfrCFpGV()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_1
	{
		public GestureItem Ho6SnjXypYZ;

		internal static _003C_003Ec__DisplayClass24_1 cqRq96WtEIncV3bFNsY7;

		internal bool aJbSnrbIT0i(GestureAction x)
		{
			return x.GestureId == Ho6SnjXypYZ.Gesture.Id;
		}

		internal bool UHFSnpx8m6C(GestureAction x)
		{
			return x.GestureId == Ho6SnjXypYZ.Gesture.Id;
		}

		internal bool ePaSnBNfkO1(GestureAction x)
		{
			return x.GestureId == Ho6SnjXypYZ.Gesture.Id;
		}

		internal bool gsYSnQm8KrY(GestureAction x)
		{
			return x.GestureId == Ho6SnjXypYZ.Gesture.Id;
		}

		internal static void vGUVnPWt1O8rAIvqvyPV()
		{
		}

		internal static bool ViFXSpWtGFKOJ2IG4f17()
		{
			return cqRq96WtEIncV3bFNsY7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public RedrawGestureWindow kNTSn4T8OWi;

		private static _003C_003Ec__DisplayClass26_0 aIE5DKWtKtsQHuofFOoC;

		internal bool ltjSnnoky2O(Gesture x)
		{
			return x.Id == kNTSn4T8OWi.Result.Id;
		}

		internal static bool nNtoVaWtBGN8tS5l0pud()
		{
			return aIE5DKWtKtsQHuofFOoC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public GestureItem oXcSndCe1lm;

		public ActionItem tClSnojGYxN;

		private static _003C_003Ec__DisplayClass27_0 GuAjanWtOTLZ50n8DZL3;

		internal bool HbUSn5JSAHn(GestureAction x)
		{
			return x.GestureId == oXcSndCe1lm.Gesture.Id;
		}

		internal void UFoSnDGlcGZ(object sender, RoutedEventArgs e)
		{
			AppState.lWutartRfUY().EditActionById(tClSnojGYxN.Id);
		}

		internal static bool vRDOpEWtJvnxaWyVRMQN()
		{
			return GuAjanWtOTLZ50n8DZL3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public GestureItem xqmSnMkKbZL;

		private static _003C_003Ec__DisplayClass29_0 eT7XseWtaBtrKxsnvcs6;

		internal bool hxCSnT3CV6k(GestureAction x)
		{
			return x.GestureId == xqmSnMkKbZL.Gesture.Id;
		}

		internal static bool FWYW4nWtre3g0AdAv7GG()
		{
			return eT7XseWtaBtrKxsnvcs6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		public GestureItem eomSnOxgT8o;

		internal static _003C_003Ec__DisplayClass30_0 bUfpRYWt95dQ5urd9gp7;

		internal bool JPeSnAZY937(GestureAction x)
		{
			return x.GestureId == eomSnOxgT8o.Gesture.Id;
		}

		internal static bool Oct41pWtLBkN0vqtVaYd()
		{
			return bUfpRYWt95dQ5urd9gp7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnClearAll_OnClick_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExeGesturesSettingsControl _003C_003E4__this;

		private TaskAwaiter<(bool isSuccess, string button)> _003C_003Eu__1;

		internal static object qgURuKWtoqoTRdc9XC3h;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExeGesturesSettingsControl exeGesturesSettingsControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<(bool, string)> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c1;
				}
				int num2;
				if (exeGesturesSettingsControl.CurrentExeSettings.GestureActions.HasData())
				{
					awaiter = ConfirmDialog.jQyL0Wq9wU6(Window.GetWindow(exeGesturesSettingsControl), "清空设置", "", "本操作将会清空本场景中所有手势轨迹的动作设置，您确认要继续么？", "Warning", "[fa:Solid_ExclamationCircle:#FF0000]清空设置(_Y)|Yes\r\n取消(_C)|Cancel", "Cancel").GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_00c1;
					}
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					num2 = 1;
					if (qgURuKWtoqoTRdc9XC3h != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_00f5;
				}
				AppHelper.ShowWarning("没有需要清空的数据。");
				goto end_IL_0010;
				IL_0102:
				exeGesturesSettingsControl.CurrentExeSettings.GestureActions = new List<GestureAction>();
				exeGesturesSettingsControl.Save();
				exeGesturesSettingsControl.dIjLN3YNTrl();
				goto end_IL_0010;
				IL_00c1:
				(bool, string) result = awaiter.GetResult();
				if (result.Item1 && result.Item2 == "Yes")
				{
					num2 = 0;
					if (mXETvPWtfOV1kuHJnNJb())
					{
						goto IL_00f5;
					}
					goto IL_0102;
				}
				goto end_IL_0010;
				IL_00f5:
				switch (num2)
				{
				case 1:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0102;
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

		internal static bool mXETvPWtfOV1kuHJnNJb()
		{
			return qgURuKWtoqoTRdc9XC3h == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnPaste_OnClick_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExeGesturesSettingsControl _003C_003E4__this;

		private List<GestureAction> _003CactionsToPaste_003E5__2;

		private TaskAwaiter<(bool isSuccess, string button)> _003C_003Eu__1;

		private static object wDKUsFWtiv8aR2Qnx6iD;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExeGesturesSettingsControl exeGesturesSettingsControl = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<(bool, string)> awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0147;
					}
					int num2;
					if (!ClipboardHelper.ContainsData("quicker-gesture-config"))
					{
						AppHelper.ShowWarning("没有要粘贴的规则。请先从其它场景中复制规则后再粘贴。");
					}
					else
					{
						string value = ClipboardHelper.GetData("quicker-gesture-config") as string;
						if (string.IsNullOrEmpty(value))
						{
							AppHelper.ShowWarning("剪贴板中读取的手势动作数据为空。");
						}
						else
						{
							_003CactionsToPaste_003E5__2 = JsonConvert.DeserializeObject<List<GestureAction>>(value);
							if (_003CactionsToPaste_003E5__2.HasData())
							{
								awaiter = ConfirmDialog.jQyL0Wq9wU6(Window.GetWindow(exeGesturesSettingsControl), "粘贴手势规则", "", "将会覆盖当前场景设置中的所有手势规则，确认要继续么？", "Warning", "粘贴(_Y)|Yes\r\n取消(_C)|Cancel", "").GetAwaiter();
								num2 = 1;
								if (wDKUsFWtiv8aR2Qnx6iD != null)
								{
									goto IL_0127;
								}
								goto IL_012b;
							}
							AppHelper.ShowWarning("剪贴板中读取的手势动作数据格式不合法。");
						}
					}
					goto end_IL_0011;
					IL_0127:
					int num3 = default(int);
					num2 = num3;
					goto IL_012b;
					IL_018d:
					_003CactionsToPaste_003E5__2 = null;
					goto end_IL_0011;
					IL_012b:
					switch (num2)
					{
					case 1:
						break;
					default:
						exeGesturesSettingsControl.Save();
						exeGesturesSettingsControl.dIjLN3YNTrl();
						goto IL_018d;
					case 2:
						goto IL_018d;
					}
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0147;
					IL_0147:
					(bool, string) result = awaiter.GetResult();
					if (result.Item1 && result.Item2 == "Yes")
					{
						exeGesturesSettingsControl.CurrentExeSettings.GestureActions = _003CactionsToPaste_003E5__2;
						num2 = 0;
						if (wDKUsFWtiv8aR2Qnx6iD != null)
						{
							goto IL_0127;
						}
						goto IL_012b;
					}
					goto IL_018d;
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					GpVLJEvGSW4.Warn(ex.Message, ex);
					AppHelper.ShowWarning("粘贴出错：" + ex.Message);
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

		internal static bool WZ7tRrWtl94QesnyY5WE()
		{
			return wDKUsFWtiv8aR2Qnx6iD == null;
		}
	}

	[CompilerGenerated]
	private EventHandler m_DataChanged;

	private DataService pCuLJJDQfb6;

	private ObservableCollection<GestureItem> RVkLJ01FH7H = new ObservableCollection<GestureItem>();

	[CompilerGenerated]
	private ExeSettings HpCLJCenauC;

	[CompilerGenerated]
	private ExeSettings QgxLJPMk3GC;

	private static readonly ILog GpVLJEvGSW4;

	internal CheckBox ChkDisableGesture;

	internal Button BtnAddGesture;

	internal Label LblSetDefaultAction;

	internal ListBox LbGestures;

	internal Button BtnCopyAll;

	internal Button BtnPaste;

	internal Button BtnClearAll;

	private bool eSpLJypON4d;

	private static ExeGesturesSettingsControl yVcHaeFD1OmiAqLhqll9;

	public ExeSettings CurrentExeSettings
	{
		[CompilerGenerated]
		get
		{
			return HpCLJCenauC;
		}
		[CompilerGenerated]
		private set
		{
			HpCLJCenauC = value;
		}
	}

	public ExeSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return QgxLJPMk3GC;
		}
		[CompilerGenerated]
		private set
		{
			QgxLJPMk3GC = value;
		}
	}

	public event EventHandler DataChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ExeGesturesSettingsControl()
	{
		InitializeComponent();
	}

	public void Init(DataService dataService)
	{
		pCuLJJDQfb6 = dataService;
		foreach (Gesture item in pCuLJJDQfb6.Y0Etm2L8Pto().OrderBy(_003C_003Ec.jq6SnhP0vhO ?? (_003C_003Ec.jq6SnhP0vhO = _003C_003Ec.cOcSn9pgLCG.SiWSnVpTGUm)))
		{
			RVkLJ01FH7H.Add(new GestureItem
			{
				Gesture = item,
				HasExeAction = false
			});
		}
		LbGestures.ItemsSource = RVkLJ01FH7H;
	}

	public void SetExe(ExeSettings exeSettings, ExeSettings defaultSettings)
	{
		CurrentExeSettings = exeSettings;
		DefaultSettings = defaultSettings;
		dIjLN3YNTrl();
		try
		{
			BtnPaste.Visibility = ClipboardHelper.ContainsData("quicker-gesture-config").ToVisibility();
		}
		catch (Exception)
		{
		}
	}

	private void eJ4LNOAItnv(object sender, RoutedEventArgs e)
	{
		CurrentExeSettings.DisableGesture = ChkDisableGesture.IsChecked == true;
		Save();
	}

	private void YEFLNFeEO3K(object sender, RoutedEventArgs e)
	{
		int num = 1;
		AddGestureWindow addGestureWindow = new AddGestureWindow(pCuLJJDQfb6);
		addGestureWindow.Owner = Window.GetWindow(this);
		if (addGestureWindow.ShowDialog() != true)
		{
			return;
		}
		foreach (Gesture item in addGestureWindow.Result)
		{
			pCuLJJDQfb6.Y0Etm2L8Pto().Add(item);
			{
				RVkLJ01FH7H.Add(new GestureItem
				{
					Gesture = item,
					HasDefaultAction = false,
					HasExeAction = false
				});
				continue;
			}
			break;
		}
		LbGestures.Items.Refresh();
		pCuLJJDQfb6.kRatXavVWw7();
	}

	private void RFuLNUuwLkQ(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.ETxSnWwfTxl = (sender as FrameworkElement).Tag as GestureItem;
		if (_003C_003Ec__DisplayClass18_.ETxSnWwfTxl == null || CurrentExeSettings == null || CurrentExeSettings.GestureActions == null || !CurrentExeSettings.GestureActions.Any(_003C_003Ec__DisplayClass18_.LPTSnYm8vHn))
		{
			return;
		}
		GestureAction item = CurrentExeSettings.GestureActions.FirstOrDefault(_003C_003Ec__DisplayClass18_.Nj3SnIsA4ou);
		if (yVcHaeFD1OmiAqLhqll9 == null)
		{
			switch (0)
			{
			}
		}
		CurrentExeSettings.GestureActions.Remove(item);
		Save();
		dIjLN3YNTrl();
	}

	private void qlBLNlV4HtP(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.Pi7SnsxV7sw = (sender as FrameworkElement).Tag as GestureItem;
		if (_003C_003Ec__DisplayClass19_.Pi7SnsxV7sw == null)
		{
			AppHelper.ShowWarning("gestureItem 为 NULL，这可能是一个程序BUG，请反馈。");
			return;
		}
		List<ExeSettings> list = pCuLJJDQfb6.TxrtXFmcoEV().Values.OrderBy(_003C_003Ec.oGVSneuFPO0 ?? (_003C_003Ec.oGVSneuFPO0 = _003C_003Ec.cOcSn9pgLCG.xtySnZTtI1I)).ToList();
		bool flag = false;
		string text = "";
		using (List<ExeSettings>.Enumerator enumerator = list.GetEnumerator())
		{
			int num2 = default(int);
			while (true)
			{
				if (enumerator.MoveNext())
				{
					ExeSettings current = enumerator.Current;
					if (current != null && current.GestureActions?.Any(_003C_003Ec__DisplayClass19_.C3SSnHP01PO ?? (_003C_003Ec__DisplayClass19_.C3SSnHP01PO = _003C_003Ec__DisplayClass19_.MLjSnkOwUvN)) == true)
					{
						flag = true;
						text = current.Exe;
						break;
					}
					continue;
				}
				int num = 0;
				if (!UgFlk3FDKOY7PQf0RS3r())
				{
					num = num2;
				}
				switch (num)
				{
				}
				break;
			}
		}
		if (flag)
		{
			AppHelper.ShowWarning("此手势有关联的动作(" + text + ")。为避免误删除，请先去除手势动作。", true);
			int num3 = 0;
			if (yVcHaeFD1OmiAqLhqll9 != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
		}
		else
		{
			RVkLJ01FH7H.Remove(_003C_003Ec__DisplayClass19_.Pi7SnsxV7sw);
			Gesture gesture = pCuLJJDQfb6.Y0Etm2L8Pto().FirstOrDefault(_003C_003Ec__DisplayClass19_.jJcSnGmBKpC);
			if (gesture != null)
			{
				pCuLJJDQfb6.Y0Etm2L8Pto().Remove(gesture);
				pCuLJJDQfb6.kRatXavVWw7();
			}
		}
	}

	private void Gesture_OnDrop(object sender, DragEventArgs e)
	{
        GestureAction item2 = default;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		ActionItemDragObject actionItemDragObject;
		int num;
		if (CurrentExeSettings != null)
		{
			_003C_003Ec__DisplayClass20_.ja0SnbyoW6k = (sender as FrameworkElement).Tag as GestureItem;
			if (e.Data.GetDataPresent("quicker-action-drag-item"))
			{
				actionItemDragObject = (ActionItemDragObject)e.Data.GetData("quicker-action-drag-item");
				num = 0;
				if (yVcHaeFD1OmiAqLhqll9 == null)
				{
					goto IL_0065;
				}
				goto IL_0133;
			}
			AppHelper.ShowWarning("请从动作页拖放动作到这里。");
			return;
		}
		return;
		IL_0065:
		item2 = default(GestureAction);
		if (actionItemDragObject != null)
		{
			ActionItem action = actionItemDragObject.Action;
			if (_003C_003Ec__DisplayClass20_.ja0SnbyoW6k.HasExeAction)
			{
				if (!AppHelper.Confirm("手势已有关联动作，是否覆盖？"))
				{
					return;
				}
				GestureAction item = CurrentExeSettings.GestureActions.FirstOrDefault(_003C_003Ec__DisplayClass20_.FHjSn1bPWTH);
				CurrentExeSettings.GestureActions.Remove(item);
			}
			item2 = new GestureAction
			{
				GestureId = _003C_003Ec__DisplayClass20_.ja0SnbyoW6k.Gesture.Id,
				ActionType = QuickActionType.QuickerAction,
				Data = action.Id,
				Description = action.Title,
				Id = Guid.NewGuid().ToString()
			};
			num = 0;
			if (!UgFlk3FDKOY7PQf0RS3r())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0133;
		}
		AppHelper.ShowWarning("获得的拖动对象为空。");
		return;
		IL_0133:
		switch (num)
		{
		case 1:
			break;
		default:
			if (CurrentExeSettings.GestureActions == null)
			{
				CurrentExeSettings.GestureActions = new List<GestureAction>();
			}
			CurrentExeSettings.GestureActions.Add(item2);
			Save();
			dIjLN3YNTrl();
			return;
		}
		goto IL_0065;
	}

	private void Gesture_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		if (CurrentExeSettings != null)
		{
			GestureItem gestureItem_ = (sender as GesturePreviewControl).Tag as GestureItem;
			S8ULNiCglfv(gestureItem_);
		}
	}

	private void S8ULNiCglfv(GestureItem gestureItem_0)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		_003C_003Ec__DisplayClass22_.OyGSnX52A7j = gestureItem_0;
		if (CurrentExeSettings == null)
		{
			AppHelper.ShowWarning("数据为空，这可能是一个程序bug，欢迎反馈。");
			return;
		}
		IList<GestureAction> list = CurrentExeSettings.GestureActions ?? new List<GestureAction>();
		GestureAction gestureAction = list.FirstOrDefault(_003C_003Ec__DisplayClass22_.WXjSn6JGrl3);
		GestureActionEditWindow gestureActionEditWindow = new GestureActionEditWindow(pCuLJJDQfb6, _003C_003Ec__DisplayClass22_.OyGSnX52A7j.Gesture, gestureAction, string.Equals("_global", CurrentExeSettings.Exe));
		gestureActionEditWindow.Owner = Window.GetWindow(this);
		if (gestureActionEditWindow.ShowDialog() == true)
		{
			if (gestureAction != null)
			{
				list.Remove(gestureAction);
			}
			list.Add(gestureActionEditWindow.Result);
		}
		CurrentExeSettings.GestureActions = list;
		Save();
		int num = 0;
		if (yVcHaeFD1OmiAqLhqll9 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		dIjLN3YNTrl();
	}

	private void Save()
	{
		this.m_DataChanged?.Invoke(this, EventArgs.Empty);
	}

	private void dIjLN3YNTrl()
	{
		if (CurrentExeSettings == null)
		{
			LbGestures.IsEnabled = false;
			int num = 0;
			if (yVcHaeFD1OmiAqLhqll9 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			return;
		}
		LbGestures.IsEnabled = true;
		ChkDisableGesture.IsChecked = CurrentExeSettings.DisableGesture;
		if (CurrentExeSettings.Exe == "_global")
		{
			ChkDisableGesture.Content = "默认禁用手势（除非在特定软件下开启）";
			LblSetDefaultAction.Visibility = Visibility.Visible;
			using IEnumerator<GestureItem> enumerator = RVkLJ01FH7H.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				_003C_003Ec__DisplayClass24_.GrYSnxF2yvo = enumerator.Current;
				_003C_003Ec__DisplayClass24_.GrYSnxF2yvo.GestureAction = null;
				_003C_003Ec__DisplayClass24_.GrYSnxF2yvo.HasDefaultAction = false;
				_003C_003Ec__DisplayClass24_.GrYSnxF2yvo.HasExeAction = CurrentExeSettings.GestureActions.HasData() && CurrentExeSettings.GestureActions.Any(_003C_003Ec__DisplayClass24_.I4hSnmwEUqX);
				_003C_003Ec__DisplayClass24_.GrYSnxF2yvo.GestureAction = CurrentExeSettings.GestureActions?.FirstOrDefault(_003C_003Ec__DisplayClass24_.p62SnKuqXda);
			}
		}
		else
		{
			ChkDisableGesture.Content = "在此软件下禁用手势";
			LblSetDefaultAction.Visibility = Visibility.Collapsed;
			ExeSettings exeSettings = pCuLJJDQfb6.yQWt6ownR4Z("_global");
			using IEnumerator<GestureItem> enumerator = RVkLJ01FH7H.GetEnumerator();
			int num4 = default(int);
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass24_1 _003C_003Ec__DisplayClass24_2 = new _003C_003Ec__DisplayClass24_1();
				_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ = enumerator.Current;
				_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.GestureAction = null;
				_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.HasExeAction = CurrentExeSettings.GestureActions.HasData() && CurrentExeSettings.GestureActions.Any(_003C_003Ec__DisplayClass24_2.aJbSnrbIT0i);
				if (_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.HasExeAction)
				{
					_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.GestureAction = CurrentExeSettings.GestureActions?.FirstOrDefault(_003C_003Ec__DisplayClass24_2.UHFSnpx8m6C);
					int num3 = 0;
					if (yVcHaeFD1OmiAqLhqll9 != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
				}
				_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.HasDefaultAction = exeSettings?.GestureActions?.HasData() == true && exeSettings.GestureActions.Any(_003C_003Ec__DisplayClass24_2.ePaSnBNfkO1);
				if (_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.HasDefaultAction && !_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.HasExeAction)
				{
					_003C_003Ec__DisplayClass24_2.Ho6SnjXypYZ.GestureAction = exeSettings?.GestureActions?.FirstOrDefault(_003C_003Ec__DisplayClass24_2.gsYSnQm8KrY);
				}
			}
		}
		LbGestures.UpdateLayout();
	}

	private void UbgLNfTB7Yi(object sender, RoutedEventArgs e)
	{
		if (CurrentExeSettings != null)
		{
			GestureItem gestureItem_ = (sender as MenuItem).Tag as GestureItem;
			S8ULNiCglfv(gestureItem_);
		}
	}

	private void c3mLNzS8hLD(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		GestureItem gestureItem = (sender as MenuItem).Tag as GestureItem;
		int num = 0;
		if (yVcHaeFD1OmiAqLhqll9 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (gestureItem == null)
		{
			AppHelper.ShowWarning("gestureItem为NULL，这可能是一个程序BUG，请反馈。");
			return;
		}
		_003C_003Ec__DisplayClass26_.kNTSn4T8OWi = new RedrawGestureWindow(gestureItem.Gesture)
		{
			Owner = Window.GetWindow(this)
		};
		if (_003C_003Ec__DisplayClass26_.kNTSn4T8OWi.ShowDialog() == true)
		{
			Gesture gesture = AppState.DataService.Y0Etm2L8Pto().FirstOrDefault(_003C_003Ec__DisplayClass26_.ltjSnnoky2O);
			if (gesture != null)
			{
				gesture.Name = _003C_003Ec__DisplayClass26_.kNTSn4T8OWi.Result.Name;
				gesture.Points = _003C_003Ec__DisplayClass26_.kNTSn4T8OWi.Result.Points;
				gesture.ResetWindowsPoints();
				pCuLJJDQfb6.kRatXavVWw7();
				LbGestures.Items.Refresh();
				dIjLN3YNTrl();
				AppState.v5FtaQ4hQfg().HqXvLww9gVP();
			}
		}
	}

	private void cFhLJwQPdtE(object sender, ContextMenuEventArgs e)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		FrameworkElement frameworkElement = sender as FrameworkElement;
		ContextMenu contextMenu = frameworkElement.ContextMenu;
		if (contextMenu.Items.Count > 2 && (contextMenu.Items[1] as MenuItem).Tag == "EDIT_ACTION")
		{
			contextMenu.Items.RemoveAt(1);
		}
		_003C_003Ec__DisplayClass27_.oXcSndCe1lm = frameworkElement.Tag as GestureItem;
		if (_003C_003Ec__DisplayClass27_.oXcSndCe1lm == null)
		{
			return;
		}
		GestureAction gestureAction = (CurrentExeSettings.GestureActions ?? new List<GestureAction>()).FirstOrDefault(_003C_003Ec__DisplayClass27_.HbUSn5JSAHn);
		bool value = gestureAction == null && ClipboardHelper.ContainsData("quicker-gesture-action");
		IEnumerator enumerator = ((IEnumerable)contextMenu.Items).GetEnumerator();
		int num = 1;
		if (UgFlk3FDKOY7PQf0RS3r())
		{
			goto IL_00c9;
		}
		goto IL_019c;
		IL_019c:
		switch (num)
		{
		case 1:
			break;
		default:
			return;
		}
		goto IL_00c9;
		IL_00c9:
		try
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current is MenuItem menuItem && string.Equals(menuItem.Name, "MenuItemPasteAction"))
				{
					menuItem.Visibility = value.ToVisibility();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		_003C_003Ec__DisplayClass27_.tClSnojGYxN = gestureAction.GetAction();
		if (_003C_003Ec__DisplayClass27_.tClSnojGYxN != null)
		{
			AppHelper.AddMenuItem(contextMenu.Items, "编辑动作：" + _003C_003Ec__DisplayClass27_.tClSnojGYxN.Title, "编辑手势所引用的Quicker动作", "fa:Light_Edit", _003C_003Ec__DisplayClass27_.UFoSnDGlcGZ, 1).Tag = "EDIT_ACTION";
			num = 0;
			if (yVcHaeFD1OmiAqLhqll9 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_019c;
		}
	}

	private void W1bLJtsRrRy(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.GesturesSettingPage);
	}

	private void vdWLJgxeh1T(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (true)
		{
			_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
			int num2 = 0;
			if (yVcHaeFD1OmiAqLhqll9 != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (CurrentExeSettings == null)
			{
				return;
			}
			_003C_003Ec__DisplayClass29_.xqmSnMkKbZL = (sender as MenuItem)?.Tag as GestureItem;
			if (_003C_003Ec__DisplayClass29_.xqmSnMkKbZL == null)
			{
				AppHelper.ShowWarning("数据为空。");
				return;
			}
			GestureAction gestureAction = (CurrentExeSettings.GestureActions ?? new List<GestureAction>()).FirstOrDefault(_003C_003Ec__DisplayClass29_.hxCSnT3CV6k);
			if (gestureAction == null)
			{
				AppHelper.ShowWarning("规则数据为空。");
				return;
			}
			try
			{
				ClipboardHelper.SetData("quicker-gesture-action", gestureAction.ToJson(true));
				return;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("复制出错了：" + ex.Message);
				return;
			}
		}
	}

	private void JiILJL0u0ll(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		if (CurrentExeSettings == null)
		{
			return;
		}
		_003C_003Ec__DisplayClass30_.eomSnOxgT8o = (sender as MenuItem)?.Tag as GestureItem;
		if (_003C_003Ec__DisplayClass30_.eomSnOxgT8o == null)
		{
			AppHelper.ShowWarning("GestureItem为空。");
			return;
		}
		if (!ClipboardHelper.ContainsData("quicker-gesture-action"))
		{
			int num = 0;
			if (!UgFlk3FDKOY7PQf0RS3r())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.ShowWarning("剪贴板中没有手势动作数据。");
			return;
		}
		try
		{
			string value = ClipboardHelper.GetData("quicker-gesture-action") as string;
			if (string.IsNullOrEmpty(value))
			{
				AppHelper.ShowWarning("剪贴板中读取的手势动作数据为空。");
				return;
			}
			GestureAction gestureAction = JsonConvert.DeserializeObject<GestureAction>(value);
			if (gestureAction == null)
			{
				AppHelper.ShowWarning("剪贴板中读取的手势动作数据格式不合法。");
				return;
			}
			gestureAction.GestureId = _003C_003Ec__DisplayClass30_.eomSnOxgT8o.Gesture.Id;
			IList<GestureAction> list = CurrentExeSettings.GestureActions ?? new List<GestureAction>();
			GestureAction gestureAction2 = list.FirstOrDefault(_003C_003Ec__DisplayClass30_.JPeSnAZY937);
			if (gestureAction2 == null)
			{
				goto IL_012b;
			}
			list.Remove(gestureAction2);
			int num3 = 0;
			if (yVcHaeFD1OmiAqLhqll9 == null)
			{
				goto IL_011e;
			}
			goto IL_014e;
			IL_014e:
			int num4 = default(int);
			num3 = num4;
			goto IL_011e;
			IL_011e:
			switch (num3)
			{
			case 1:
				Save();
				dIjLN3YNTrl();
				return;
			}
			goto IL_012b;
			IL_012b:
			list.Add(gestureAction);
			CurrentExeSettings.GestureActions = list;
			num3 = 1;
			if (UgFlk3FDKOY7PQf0RS3r())
			{
				goto IL_011e;
			}
			goto IL_014e;
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void e5TLJvBhGGd(object sender, RoutedEventArgs e)
	{
		IList<GestureAction> gestureActions = CurrentExeSettings.GestureActions;
		if (!gestureActions.HasData())
		{
			AppHelper.ShowWarning("没有可以复制的手势动作。");
			return;
		}
		try
		{
			ClipboardHelper.SetData("quicker-gesture-config", JsonConvert.SerializeObject(gestureActions));
			AppHelper.ShowSuccess($"已复制{gestureActions.Count}条规则。");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("复制出错了：" + ex.Message);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnPaste_OnClick_003Ed__33))]
	private void nbdLJSP3JAK(object sender, RoutedEventArgs e)
	{
		_003CBtnPaste_OnClick_003Ed__33 stateMachine = default(_003CBtnPaste_OnClick_003Ed__33);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnClearAll_OnClick_003Ed__34))]
	private void NggLJ2M7AQs(object sender, RoutedEventArgs e)
	{
		_003CBtnClearAll_OnClick_003Ed__34 stateMachine = default(_003CBtnClearAll_OnClick_003Ed__34);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!eSpLJypON4d)
		{
			eSpLJypON4d = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/exesettingcontrols/exegesturessettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			eSpLJypON4d = true;
			break;
		case 12:
			BtnCopyAll = (Button)target;
			BtnCopyAll.Click += e5TLJvBhGGd;
			break;
		case 13:
			BtnPaste = (Button)target;
			BtnPaste.Click += nbdLJSP3JAK;
			break;
		case 14:
			BtnClearAll = (Button)target;
			if (yVcHaeFD1OmiAqLhqll9 != null)
			{
				switch (0)
				{
				}
			}
			BtnClearAll.Click += NggLJ2M7AQs;
			break;
		case 1:
			ChkDisableGesture = (CheckBox)target;
			ChkDisableGesture.Click += eJ4LNOAItnv;
			break;
		case 2:
			BtnAddGesture = (Button)target;
			BtnAddGesture.Click += YEFLNFeEO3K;
			break;
		case 3:
			LblSetDefaultAction = (Label)target;
			break;
		case 4:
			LbGestures = (ListBox)target;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 5:
			((StackPanel)target).ContextMenuOpening += cFhLJwQPdtE;
			break;
		case 6:
			((MenuItem)target).Click += UbgLNfTB7Yi;
			break;
		case 7:
			((MenuItem)target).Click += JiILJL0u0ll;
			break;
		case 8:
			((MenuItem)target).Click += vdWLJgxeh1T;
			break;
		case 9:
			((MenuItem)target).Click += RFuLNUuwLkQ;
			break;
		case 10:
			((MenuItem)target).Click += c3mLNzS8hLD;
			break;
		case 11:
			((MenuItem)target).Click += qlBLNlV4HtP;
			break;
		}
	}

	static ExeGesturesSettingsControl()
	{
		GpVLJEvGSW4 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool UgFlk3FDKOY7PQf0RS3r()
	{
		return yVcHaeFD1OmiAqLhqll9 == null;
	}

	internal static void Pbos6DFDuWCqE7YnGVwR()
	{
	}
}
