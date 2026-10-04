using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using HandyControl.Tools;
using JTIh7V5l65QV75A93Ly;
using log4net;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Floating;
using Quicker.Domain.Messages;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View;

public class FloatButtonWindow : Window, IComponentConnector, IFloatItemWindow
{
	internal enum wKtnDLuQ55YXkLVMT4N
	{

	}

	internal enum oh9xBButTgkjm9WGWqp
	{

	}

	internal struct XEx4lNux56IdksorQdS
	{
		public IntPtr F1BSKrnyYrp;

		public IntPtr vfaSKpEgOhK;

		public int x;

		public int VArSKBhXqYy;

		public int QQrSKQsuZNF;

		public int t0OSKjTOwTV;

		public int M7NSKnnBQpV;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public FloatButtonWindow FGuSK5cTlrr;

		public System.Drawing.Point? TGbSKDmy2aS;

		public bool GqySKdW5Ly3;

		internal static _003C_003Ec__DisplayClass23_0 ipbqE3W8Dc6RTCPqOaa4;

		internal void SHISK4dAsak(object sender, EventArgs e)
		{
			((HwndSource)PresentationSource.FromVisual((Window)sender)).AddHook(FGuSK5cTlrr.ayJgM1oT6og);
			FGuSK5cTlrr.PcggMUePN22 = FGuSK5cTlrr.Width / FGuSK5cTlrr.Height;
			IntPtr handle = new WindowInteropHelper(FGuSK5cTlrr).Handle;
			NativeMethods.SetWindowNoActivate(handle);
			NativeMethods.SetWindowNoMaximize(handle);
			NativeMethods.SetWindowPos(handle, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
			int num = 1;
			if (!mcR2xdW83aBnvAuN7BWF())
			{
				int num2 = default(int);
				num = num2;
			}
			int x = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!TGbSKDmy2aS.HasValue)
					{
						break;
					}
					FGuSK5cTlrr.WindowStartupLocation = WindowStartupLocation.Manual;
					int num3 = 0;
					if (!GqySKdW5Ly3)
					{
						x = TGbSKDmy2aS.Value.X;
						num = 0;
						if (ipbqE3W8Dc6RTCPqOaa4 == null)
						{
							continue;
						}
						goto default;
					}
					FGuSK5cTlrr.Left = TGbSKDmy2aS.Value.X;
					FGuSK5cTlrr.Top = TGbSKDmy2aS.Value.Y;
					break;
				}
				default:
				{
					int num3 = TGbSKDmy2aS.Value.Y;
					NativeMethods.SetWindowPos(handle, NativeMethods.HWND_TOPMOST, x, num3, 0, 0, SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOSIZE);
					break;
				}
				}
				break;
			}
			if (NativeMethods.IsOnWindows11())
			{
				DwmDropShadow.SetRoundCornerMode(FGuSK5cTlrr, 3);
			}
			FGuSK5cTlrr.UpdateNoResizeShadow();
		}

		internal static bool mcR2xdW83aBnvAuN7BWF()
		{
			return ipbqE3W8Dc6RTCPqOaa4 == null;
		}
	}

	private ActionItem ThmgMDrh8GA;

	[CompilerGenerated]
	private string HPXgMdkkLN6;

	[CompilerGenerated]
	private bool mHVgMoV3N77;

	private readonly AppServer tB4gMTsbZQS;

	private readonly ITinyMessengerHub fWggMMONObi;

	private readonly ActionEditMgr xqagMA3B9qv;

	private TinyMessageSubscriptionToken xdcgMOwI8SL;

	private TinyMessageSubscriptionToken DrogMFFxACP;

	private double PcggMUePN22;

	private bool? tIpgMlgm889;

	public const int WM_MOUSEACTIVATE = 33;

	public const int MA_NOACTIVATE = 3;

	private bool DeUgMippren;

	private readonly DataService GywgM3jnROT;

	private readonly FloatButtonAndPanelManager LUAgMfDhopo;

	private readonly bool EtcgMzc5sg9;

	private System.Windows.Point Rt6gAwWG5wc;

	private static readonly ILog fTJgAthlWC2;

	private bool pA1gAgiuq4g;

	private TouchDevice c6pgAL7toqM;

	private System.Windows.Point gYtgAvyuyCB;

	private NativeMethods.RECT yQggASb0WdW;

	internal MenuItem MenuClose;

	internal Border BackgroundBorder;

	internal Border ButtonBorder;

	internal ActionButton TheButton;

	private bool ei0gA2YnG6v;

	internal static FloatButtonWindow h3BSHZFcMUdkgZQorP7L;

	public ActionItem Action => ThmgMDrh8GA;

	public string BindingProcessName
	{
		[CompilerGenerated]
		get
		{
			return HPXgMdkkLN6;
		}
		[CompilerGenerated]
		set
		{
			HPXgMdkkLN6 = value;
		}
	}

	public bool EnableProcessBinding
	{
		[CompilerGenerated]
		get
		{
			return mHVgMoV3N77;
		}
		[CompilerGenerated]
		set
		{
			mHVgMoV3N77 = value;
		}
	}

	public double Right => base.Left + base.ActualWidth;

	public double Bottom => base.Top + base.ActualHeight;

	public System.Windows.Point TopRight => new System.Windows.Point(Right + 1.0, base.Top);

	public System.Windows.Point BottomLeft => new System.Windows.Point(base.Left, Bottom + 1.0);

	public System.Windows.Point BottomRight => new System.Windows.Point(Right + 1.0, Bottom + 1.0);

	public System.Windows.Point TopLeft => new System.Windows.Point(base.Left, base.Top);

	internal FloatButtonWindow(ActionItem action, System.Drawing.Point? position, AppServer appServer, ITinyMessengerHub hub, ActionEditMgr actionEditMgr, DataService dataService, FloatButtonAndPanelManager floatButtonAndPanelManager, bool useWpfPoint)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.TGbSKDmy2aS = position;
		_003C_003Ec__DisplayClass23_.GqySKdW5Ly3 = useWpfPoint;
		
		_003C_003Ec__DisplayClass23_.FGuSK5cTlrr = this;
		ThmgMDrh8GA = action;
		tB4gMTsbZQS = appServer;
		fWggMMONObi = hub;
		xqagMA3B9qv = actionEditMgr;
		GywgM3jnROT = dataService;
		LUAgMfDhopo = floatButtonAndPanelManager;
		InitializeComponent();
		if (!NativeMethods.IsOnWindows10OrLater())
		{
			ButtonBorder.BorderThickness = new Thickness(1.0);
		}
		base.SourceInitialized += _003C_003Ec__DisplayClass23_.SHISK4dAsak;
		TheButton.ActionItem = action;
		(bool, double, double) tuple = LUAgMfDhopo.AortWCpXK25();
		if (tuple.Item1 && tuple.Item2 > 0.0)
		{
			base.Width = (base.Height = tuple.Item2);
		}
		else
		{
			base.Width = (base.Height = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonSize);
		}
		base.Loaded += lX9gMXy95Y0;
		base.Closed += NyegM6ZmhvB;
		base.PreviewMouseWheel += LT6gMGSJXBR;
		base.StateChanged += QUNgMkaGVAh;
		base.SizeChanged += T6DgMWoTHED;
		xdcgMOwI8SL = hub.Subscribe<CloseAllFloatingActions>(rNugMb7wTEU);
		DrogMFFxACP = hub.Subscribe<ActionEditCompletedMessage>(UokgMsNgwvN);
		LUAgMfDhopo.sKqtWJA2GDn(this);
		UpdateUiSkin();
	}

	private void T6DgMWoTHED(object sender, SizeChangedEventArgs e)
	{
		if (base.WindowState == WindowState.Normal)
		{
			LUAgMfDhopo.OnItemSizeChanged(this);
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void QUNgMkaGVAh(object sender, EventArgs e)
	{
		if (base.WindowState == WindowState.Minimized)
		{
			base.WindowState = WindowState.Normal;
		}
	}

	private void LT6gMGSJXBR(object sender, MouseWheelEventArgs e)
	{
		if (Action != null && Action.AllowScrollTrigger)
		{
			fWggMMONObi.NotifyRunAction(this, Action.Id, false, false, ActionTrigger.ScrollOnButton, true, null, ActionHelper.GetScrollActionParam(e.Delta));
		}
	}

	private void UokgMsNgwvN(ActionEditCompletedMessage actionEditCompletedMessage_0)
	{
		if (actionEditCompletedMessage_0.ActionId == ThmgMDrh8GA.Id)
		{
			(ThmgMDrh8GA, _) = GywgM3jnROT.GetActionById(actionEditCompletedMessage_0.ActionId);
			base.Dispatcher.Invoke(G1xgMnjH0VD);
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool wOMgMHm9HcU(ref NativeMethods.WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_0);

	public static System.Windows.Point GetMousePosition()
	{
		NativeMethods.WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_ = default(NativeMethods.WMgqc8DPfO1vLRdX3NM);
		wOMgMHm9HcU(ref wmgqc8DPfO1vLRdX3NM_);
		return new System.Windows.Point(wmgqc8DPfO1vLRdX3NM_.X, wmgqc8DPfO1vLRdX3NM_.Y);
	}

	private IntPtr ayJgM1oT6og(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_4)
	{
		XEx4lNux56IdksorQdS structure;
		System.Windows.Point mousePosition = default(System.Windows.Point);
		double num = default(double);
		int num2;
		if (int_0 <= 70)
		{
			if (int_0 == 33)
			{
				bool_4 = true;
				goto IL_017c;
			}
			if (int_0 == 70)
			{
				structure = (XEx4lNux56IdksorQdS)Marshal.PtrToStructure(intptr_2, typeof(XEx4lNux56IdksorQdS));
				if ((structure.M7NSKnnBQpV & 2) != 0)
				{
					return IntPtr.Zero;
				}
				if ((Window)HwndSource.FromHwnd(intptr_0).RootVisual == null)
				{
					return IntPtr.Zero;
				}
				if (!tIpgMlgm889.HasValue)
				{
					mousePosition = GetMousePosition();
					num = Math.Min(Math.Abs(mousePosition.X - (double)structure.x), Math.Abs(mousePosition.X - (double)structure.x - (double)structure.QQrSKQsuZNF));
					num2 = 1;
					if (!aLseI0FcU8BdHjLvNIlb())
					{
						goto IL_00df;
					}
					goto IL_00e3;
				}
				goto IL_0141;
			}
		}
		else
		{
			switch (int_0)
			{
			case 562:
				tIpgMlgm889 = null;
				break;
			case 132:
				try
				{
					intptr_2.ToInt32();
				}
				catch (OverflowException)
				{
					bool_4 = true;
				}
				break;
			}
		}
		goto IL_01b5;
		IL_0141:
		if (!tIpgMlgm889.Value)
		{
			structure.QQrSKQsuZNF = (int)((double)structure.t0OSKjTOwTV * PcggMUePN22);
			num2 = 0;
			if (h3BSHZFcMUdkgZQorP7L != null)
			{
				goto IL_00df;
			}
			goto IL_00e3;
		}
		structure.t0OSKjTOwTV = (int)((double)structure.QQrSKQsuZNF / PcggMUePN22);
		goto IL_0168;
		IL_01b5:
		return IntPtr.Zero;
		IL_00e3:
		switch (num2)
		{
		case 1:
			break;
		default:
			goto IL_0168;
		case 2:
			goto IL_017c;
		}
		double num3 = Math.Min(Math.Abs(mousePosition.Y - (double)structure.VArSKBhXqYy), Math.Abs(mousePosition.Y - (double)structure.VArSKBhXqYy - (double)structure.t0OSKjTOwTV));
		tIpgMlgm889 = num3 > num;
		goto IL_0141;
		IL_00df:
		int num4 = default(int);
		num2 = num4;
		goto IL_00e3;
		IL_017c:
		return new IntPtr(3);
		IL_0168:
		Marshal.StructureToPtr(structure, intptr_2, true);
		bool_4 = true;
		goto IL_01b5;
	}

	private void rNugMb7wTEU(CloseAllFloatingActions closeAllFloatingActions_0)
	{
		Close();
	}

	private void NyegM6ZmhvB(object sender, EventArgs e)
	{
		if (xdcgMOwI8SL != null)
		{
			fWggMMONObi.Unsubscribe<CloseAllFloatingActions>(xdcgMOwI8SL);
			xdcgMOwI8SL = null;
		}
		if (DrogMFFxACP != null)
		{
			fWggMMONObi.Unsubscribe<ActionEditCompletedMessage>(DrogMFFxACP);
			DrogMFFxACP = null;
		}
		LUAgMfDhopo.UnRegister(this);
	}

	private void lX9gMXy95Y0(object sender, RoutedEventArgs e)
	{
	}

	public void UpdateUiSkin()
	{
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		bool canUseSkin = true;
		UIHelper.UpdateUiSkinCommon(this, uiSettings, canUseSkin);
		if (!string.IsNullOrEmpty(uiSettings.BackgroundColor))
		{
			System.Windows.Media.Color color = UIHelper.ColorFromString(uiSettings.BackgroundColor);
			if (color.A == 0)
			{
				color.A = 1;
			}
			BackgroundBorder.Background = color.GetBrush();
		}
	}

	private void TheButton_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
	{
		DeUgMippren = false;
		int num;
		ActionItem actionItem = default(ActionItem);
		ActionProfile profile = default(ActionProfile);
		ContextMenu contextMenu = default(ContextMenu);
		if (ThmgMDrh8GA == null)
		{
			fTJgAthlWC2.Warn("悬浮按钮触发：_action == null");
			num = 0;
			if (h3BSHZFcMUdkgZQorP7L != null)
			{
				goto IL_00b5;
			}
		}
		else
		{
			if (e.ChangedButton != MouseButton.Right)
			{
				goto IL_01fe;
			}
			(actionItem, profile) = GywgM3jnROT.GetActionById(ThmgMDrh8GA.Id);
			if (actionItem == null)
			{
				fTJgAthlWC2.Warn("悬浮按钮触发：未找到动作" + ThmgMDrh8GA.Id);
				AppHelper.ShowWarning("未找到动作！");
				return;
			}
			contextMenu = new ContextMenu();
			num = 1;
			if (!aLseI0FcU8BdHjLvNIlb())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
			goto IL_00c1;
		}
		goto IL_00b5;
		IL_00c1:
		AppHelper.AddMenuItem(contextMenu.Items, "关闭", "关闭悬浮窗", "fa:Light_Times:danger", eltgMKaGWkv);
		if (!string.IsNullOrEmpty(BindingProcessName))
		{
			AppHelper.AddMenuItem(contextMenu.Items, "关联到进程：" + BindingProcessName, "根据进程是否活动自动显示或隐藏悬浮按钮", "", DghgM4jBakA).IsChecked = EnableProcessBinding;
		}
		if (!string.Equals(BindingProcessName, AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase))
		{
			AppHelper.AddMenuItem(contextMenu.Items, "关联到当前进程：" + AppState.CurrentProcessName, "更改绑定进程到当前进程", "", uMjgM5jivc9);
		}
		contextMenu.Items.Add(new Separator());
		xqagMA3B9qv.CreateContextMenuForActionButton(contextMenu, actionItem, profile, actionItem.Row, actionItem.Col, this, ActionTrigger.FloatButton, false, false);
		base.ContextMenu = contextMenu;
		AppState.RegisterContextMenu(contextMenu);
		goto IL_01fe;
		IL_00b5:
		AppHelper.ShowWarning("动作为空！");
		return;
		IL_01fe:
		if (e.ChangedButton == MouseButton.Left)
		{
			Rt6gAwWG5wc = e.GetPosition(this);
		}
	}

	public void UpdateNoResizeShadow()
	{
		if (base.ResizeMode == ResizeMode.NoResize && NativeMethods.IsOnWindows10OrLater() && !NativeMethods.IsOnWindows11())
		{
			DwmDropShadow.DropShadowToWindow(this);
		}
	}

	private void u76gMmrfZ7w(object sender, MouseEventArgs e)
	{
		if (e.LeftButton != MouseButtonState.Pressed || pA1gAgiuq4g)
		{
			return;
		}
		if (h3BSHZFcMUdkgZQorP7L != null)
		{
			switch (0)
			{
			}
		}
		System.Windows.Point position = e.GetPosition(this);
		Vector vector = Rt6gAwWG5wc - position;
		if (!(Math.Abs(vector.X) > SystemParameters.MinimumHorizontalDragDistance) && !(Math.Abs(vector.Y) > SystemParameters.MinimumVerticalDragDistance))
		{
			return;
		}
		DeUgMippren = true;
		if (AppState.LockFloatButtonPosition && !Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			return;
		}
		LUAgMfDhopo.geptWaoGhSi(this);
		try
		{
			pA1gAgiuq4g = true;
			DragMove();
		}
		catch (Exception)
		{
			AppHelper.ShowWarning("拖动出错，请重试。");
		}
		finally
		{
			pA1gAgiuq4g = false;
			if (e.LeftButton == MouseButtonState.Released)
			{
				LUAgMfDhopo.TrQtW7ijKse(this);
			}
		}
	}

	private void TheButton_OnPreviewMouseUp(object sender, MouseButtonEventArgs e)
	{
		if (ThmgMDrh8GA == null || DeUgMippren)
		{
			return;
		}
		if (e.ChangedButton == MouseButton.Left)
		{
			if (Keyboard.Modifiers == ModifierKeys.Shift)
			{
				if (Keyboard.IsKeyDown(Key.LeftShift))
				{
					xqagMA3B9qv.EditActionById(ThmgMDrh8GA.Id);
				}
				else if (Keyboard.IsKeyDown(Key.RightShift))
				{
					fWggMMONObi.NotifyRunAction(this, ThmgMDrh8GA.Id, true, false, ActionTrigger.FloatButton, true);
					if (!aLseI0FcU8BdHjLvNIlb())
					{
						switch (0)
						{
						}
					}
				}
			}
			else
			{
				fWggMMONObi.NotifyRunAction(this, ThmgMDrh8GA.Id, false, false, ActionTrigger.FloatButton, true);
			}
		}
		else if (e.ChangedButton == MouseButton.Middle)
		{
			if (!AppState.HHxtaMaoqJr().DisableMiddleClickCloseFloat)
			{
				Close();
			}
		}
		else
		{
			MouseButton changedButton = e.ChangedButton;
		}
	}

	private void eltgMKaGWkv(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void COkgMx4sZSS(object sender, RoutedEventArgs e)
	{
		xqagMA3B9qv.EditActionById(ThmgMDrh8GA.Id);
	}

	public void DragMoveEnd()
	{
		LUAgMfDhopo.TrQtW7ijKse(this);
	}

	public FloatItemState GetState()
	{
		return new FloatItemState
		{
			Left = base.Left,
			Top = base.Top,
			Location = Quicker.Utilities.Win32.WindowHelper.GetWindowTopLeft(this.GetHandle()),
			Width = base.Width,
			Height = base.Height,
			BindProcessName = BindingProcessName,
			IsBindProcess = EnableProcessBinding,
			ItemType = FloatItemType.ActionButton,
			ItemId = Action.Id
		};
	}

	public void Refresh()
	{
		TheButton.RefreshAction();
	}

	private void EhygMrGAH4S(object sender, TouchEventArgs e)
	{
	}

	private void HNlgMpiuh6x(object sender, TouchEventArgs e)
	{
		e.TouchDevice.Capture(this);
		if (c6pgAL7toqM == null)
		{
			c6pgAL7toqM = e.TouchDevice;
			TouchPoint touchPoint = c6pgAL7toqM.GetTouchPoint(null);
			System.Windows.Point point = PointToScreen(new System.Windows.Point(touchPoint.Position.X, touchPoint.Position.Y));
			gYtgAvyuyCB = point;
			yQggASb0WdW = NativeMethods.GetWindowRect(new WindowInteropHelper(this).Handle);
		}
		e.Handled = true;
	}

	private void Uw4gMBUgAHw(object sender, TouchEventArgs e)
	{
		if (e.TouchDevice != c6pgAL7toqM)
		{
			return;
		}
		TouchPoint touchPoint = c6pgAL7toqM.GetTouchPoint(null);
		System.Windows.Point pt = PointToScreen(new System.Windows.Point(touchPoint.Position.X, touchPoint.Position.Y));
		if (AppHelper.IsFarThan(gYtgAvyuyCB, pt, 5))
		{
			if (!AppState.LockFloatButtonPosition)
			{
				IHNRIiikxBwJdYmHpM3.oc0vvlUGaGr(new WindowInteropHelper(this).Handle, yQggASb0WdW.Left - (int)(gYtgAvyuyCB.X - pt.X), yQggASb0WdW.Top - (int)(gYtgAvyuyCB.Y - pt.Y), true);
			}
			DeUgMippren = true;
		}
		e.Handled = true;
	}

	private void aBmgMQdUH9E(object sender, TouchEventArgs e)
	{
		if (e.TouchDevice == c6pgAL7toqM)
		{
			c6pgAL7toqM = null;
		}
		e.Handled = true;
	}

	internal void Ga3gMjZnk4W(System.Drawing.Point point_1)
	{
		NativeMethods.SetWindowPos(this.GetHandle(), IntPtr.Zero, point_1.X, point_1.Y, 0, 0, SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOREDRAW | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOZORDER);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ei0gA2YnG6v)
		{
			ei0gA2YnG6v = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/main/floatbuttonwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			ei0gA2YnG6v = true;
			break;
		case 1:
			((FloatButtonWindow)target).PreviewMouseMove += u76gMmrfZ7w;
			if (!aLseI0FcU8BdHjLvNIlb())
			{
				switch (0)
				{
				}
			}
			((FloatButtonWindow)target).TouchDown += HNlgMpiuh6x;
			((FloatButtonWindow)target).TouchLeave += aBmgMQdUH9E;
			((FloatButtonWindow)target).TouchMove += Uw4gMBUgAHw;
			((FloatButtonWindow)target).TouchUp += EhygMrGAH4S;
			break;
		case 2:
			MenuClose = (MenuItem)target;
			MenuClose.Click += eltgMKaGWkv;
			break;
		case 3:
			BackgroundBorder = (Border)target;
			break;
		case 4:
			ButtonBorder = (Border)target;
			break;
		case 5:
			TheButton = (ActionButton)target;
			break;
		}
	}

	static FloatButtonWindow()
	{
		fTJgAthlWC2 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void G1xgMnjH0VD()
	{
		TheButton.ActionItem = ThmgMDrh8GA;
		TheButton.RefreshAction();
	}

	[CompilerGenerated]
	private void DghgM4jBakA(object sender, RoutedEventArgs e)
	{
		EnableProcessBinding = !EnableProcessBinding;
		LUAgMfDhopo.dZMtWcP6ceZ(this);
	}

	[CompilerGenerated]
	private void uMjgM5jivc9(object sender, RoutedEventArgs e)
	{
		BindingProcessName = AppState.CurrentProcessName;
		EnableProcessBinding = true;
		LUAgMfDhopo.dZMtWcP6ceZ(this);
	}

	internal static bool aLseI0FcU8BdHjLvNIlb()
	{
		return h3BSHZFcMUdkgZQorP7L == null;
	}
}
