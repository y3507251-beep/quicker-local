using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
using FontAwesome5.WPF;
using JTIh7V5l65QV75A93Ly;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Floating;
using Quicker.Domain.Messages;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View;

public class FloatPanelWindow : Window, IComponentConnector, IFloatItemWindow
{
	internal enum zYRLo2uR6h02bi2RF1u
	{

	}

	internal enum bH4Mk4uZOoPeoAnsHVU
	{

	}

	internal struct vwqB2BuBog39ZFn6s6V
	{
		public IntPtr z2hSmLcFnYe;

		public IntPtr NWSSmvKRq7r;

		public int x;

		public int l4pSmSbnPDG;

		public int YpvSm2bao4g;

		public int mGVSmu3hZoU;

		public int QT2SmNsON6x;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec COwSmCMenhy;

		public static Func<PropertyInfo, string> vHBSmPuToG1;

		public static Func<PropertyInfo, Color> iafSmEQiEVN;

		private static _003C_003Ec LucuFuW5Gx40KB97M8Cr;

		static _003C_003Ec()
		{
			COwSmCMenhy = new _003C_003Ec();
		}

		internal string ufBSmJ5dTrC(PropertyInfo property)
		{
			return property.Name;
		}

		internal Color ht5Sm00BrpM(PropertyInfo property)
		{
			return (Color)property.GetValue(null, null);
		}

		internal static bool rVvoNeW50N17XgBHokUN()
		{
			return LucuFuW5Gx40KB97M8Cr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionButtonEventArgs<MouseButtonEventArgs> o2WSm8moOGq;

		internal static _003C_003Ec__DisplayClass47_0 zc4qyKW5KNFXPP3RKD7o;

		internal void ImlSmyqW8gR(object sender, RoutedEventArgs e)
		{
			o2WSm8moOGq.Button.ContextMenu = null;
		}

		internal static bool HQwKKSW5BuuqAkwnIWqp()
		{
			return zc4qyKW5KNFXPP3RKD7o == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0
	{
		public FloatPanelWindow LYMSm7V8noe;

		public ActionEditCompletedMessage BIGSmRt5ub0;

		internal static _003C_003Ec__DisplayClass49_0 DMU7uPW5OEeXcXXEZCqj;

		internal void DLuSmaxZiWG()
		{
			LYMSm7V8noe.ProfilePanelControl.ActionProfile = BIGSmRt5ub0.Profile;
			LYMSm7V8noe.ProfilePanelControl.RefreshUi();
		}

		internal static void QlIBp6W5a0fLXlT4dAFO()
		{
		}

		internal static bool FWdhqUW5JZiv4CJYSC2D()
		{
			return DMU7uPW5OEeXcXXEZCqj == null;
		}
	}

	private readonly ActionProfile n9xgDIfF0JY;

	private readonly AppServer LA6gDWalZ1r;

	private readonly ITinyMessengerHub O9QgDk1KmmC;

	private readonly ActionEditMgr VcMgDGoBvLj;

	private TinyMessageSubscriptionToken TGDgDsDIiyS;

	private TinyMessageSubscriptionToken bjLgDHp6Evy;

	private double WbggD1wd75I;

	private bool? Fe7gDb3as6F;

	[CompilerGenerated]
	private bool PidgD6LdwE8;

	private static Color[] uEJgDXtVAOw;

	public static readonly DependencyProperty IsPinnedProperty;

	private static readonly Brush cepgDmtnJjZ;

	public static readonly DependencyProperty FloatButtonColorProperty;

	private static readonly Brush ugYgDKyThHC;

	public static readonly DependencyProperty ButtonColorProperty;

	private DataService LT9gDxgw3xC;

	private readonly FloatButtonAndPanelManager AO0gDrNHeEM;

	private DateTime eVngDpjwlmK = DateTime.MinValue;

	[CompilerGenerated]
	private string IatgDBMhBDh;

	[CompilerGenerated]
	private bool KkqgDQbvGm1;

	internal FloatPanelWindow TheWindow;

	internal MenuItem MenuClose;

	internal Border ShadowBorder;

	internal Border BodyBg;

	internal Grid BodyGrid;

	internal Grid GridHeader;

	internal TextBlock LblProfileName;

	internal Button BtnLink;

	internal SvgAwesome IconLink;

	internal Button BtnPin;

	internal SvgAwesome IconPin;

	internal Button BtnClose;

	internal ProfilePanelControl ProfilePanelControl;

	private bool HFPgDj1429y;

	private static FloatPanelWindow iCuUqRFFpFO5FiglISjU;

	public bool DoHideWhenClosing
	{
		[CompilerGenerated]
		get
		{
			return PidgD6LdwE8;
		}
		[CompilerGenerated]
		set
		{
			PidgD6LdwE8 = value;
		}
	}

	public bool IsPinned
	{
		get
		{
			return (bool)GetValue(IsPinnedProperty);
		}
		set
		{
			SetValue(IsPinnedProperty, value);
		}
	}

	public Brush FloatButtonColor
	{
		get
		{
			return (Brush)GetValue(FloatButtonColorProperty);
		}
		set
		{
			SetValue(FloatButtonColorProperty, value);
		}
	}

	public Brush ButtonColor
	{
		get
		{
			return (Brush)GetValue(ButtonColorProperty);
		}
		set
		{
			SetValue(ButtonColorProperty, value);
		}
	}

	public string BindingProcessName
	{
		[CompilerGenerated]
		get
		{
			return IatgDBMhBDh;
		}
		[CompilerGenerated]
		set
		{
			IatgDBMhBDh = value;
		}
	}

	public bool EnableProcessBinding
	{
		[CompilerGenerated]
		get
		{
			return KkqgDQbvGm1;
		}
		[CompilerGenerated]
		set
		{
			KkqgDQbvGm1 = value;
		}
	}

	public double Right => base.Left + base.ActualWidth;

	public double Bottom => base.Top + base.ActualHeight;

	public Point TopRight => new Point(Right + 1.0, base.Top);

	public Point BottomLeft => new Point(base.Left, Bottom + 1.0);

	public Point BottomRight => new Point(Right + 1.0, Bottom + 1.0);

	public Point TopLeft => new Point(base.Left, base.Top);

	public FloatPanelWindow(ActionProfile profile, Point? position, AppServer appServer, ITinyMessengerHub hub, ActionEditMgr actionEditMgr, DataService dataService, FloatButtonAndPanelManager floatButtonAndPanelManager, FloatItemState itemState = null, string bindingProcessName = null)
	{
		n9xgDIfF0JY = profile;
		LA6gDWalZ1r = appServer;
		O9QgDk1KmmC = hub;
		VcMgDGoBvLj = actionEditMgr;
		LT9gDxgw3xC = dataService;
		AO0gDrNHeEM = floatButtonAndPanelManager;
		base.SourceInitialized += lccgDhqEg7l;
		InitializeComponent();
		base.Loaded += wBPgD83GegA;
		base.Closed += gcNgDyH2EkZ;
		TGDgDsDIiyS = hub.Subscribe<CloseAllFloatingActions>(d5sgDE0SDVH);
		bjLgDHp6Evy = hub.Subscribe<ActionEditCompletedMessage>(SoTgD0RBRpv);
		if (itemState != null)
		{
			base.WindowStartupLocation = WindowStartupLocation.Manual;
			base.Left = itemState.Left;
			base.Top = itemState.Top;
			IsPinned = itemState.IsPined;
			BindingProcessName = itemState.BindProcessName;
			EnableProcessBinding = itemState.IsBindProcess;
			FloatButtonColor = ColorHelper.StringToColor(itemState.Color).GetBrush();
		}
		else
		{
			if (position.HasValue)
			{
				base.WindowStartupLocation = WindowStartupLocation.Manual;
				base.Left = position.Value.X;
				base.Top = position.Value.Y;
			}
			BindingProcessName = (string.IsNullOrEmpty(bindingProcessName) ? AppState.CurrentProcessName : bindingProcessName);
			EnableProcessBinding = AppState.DataService.CpItmVISR7P().FloatButtonBindProcessByDefault;
			KwVgDu7xo7h();
		}
		ShadowBorder.IsVisibleChanged += E4wgDeiEN35;
		ProfilePanelControl.EnableDragAction = false;
		ProfilePanelControl.ActionProfile = n9xgDIfF0JY;
		LblProfileName.Text = n9xgDIfF0JY.DisplayName;
		ProfilePanelControl.ActionButtonClicked += kGVgDNK2ngi;
		ProfilePanelControl.ActionButtonWheeled += aLggD20Xd9E;
		AO0gDrNHeEM.B5ttW0SUr1w(this);
		BtnLink.ToolTip = "关联到进程：" + BindingProcessName;
		ProfilePanelControl.UpdateButtonSize(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonSize, FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonSpace);
		SetValue(ActionButton.CornerRadiusProperty, new CornerRadius(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonCornerRadius));
		ProfilePanelControl.RefreshUi();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void aLggD20Xd9E(object sender, ActionButtonEventArgs<MouseWheelEventArgs> e)
	{
		if (e.OriginAction != null && e.OriginAction.AllowScrollTrigger)
		{
			O9QgDk1KmmC.NotifyRunAction(this, e.OriginAction.Id, false, false, ActionTrigger.ScrollOnButton, true, null, ActionHelper.GetScrollActionParam(e.OriginArgs.Delta));
			AppState.Lista4qx2wK().CountFloatProfile();
		}
	}

	public void RefreshAction(string actionId)
	{
		foreach (ActionButton allButton in ProfilePanelControl.AllButtons)
		{
			if (allButton?.ActionItem?.Id == actionId)
			{
				allButton.RefreshAction();
			}
		}
	}

	private void KwVgDu7xo7h()
	{
		List<Color> list = typeof(Colors).GetProperties().Cast<PropertyInfo>().OrderBy(_003C_003Ec.vHBSmPuToG1 ?? (_003C_003Ec.vHBSmPuToG1 = _003C_003Ec.COwSmCMenhy.ufBSmJ5dTrC))
			.Select(_003C_003Ec.iafSmEQiEVN ?? (_003C_003Ec.iafSmEQiEVN = _003C_003Ec.COwSmCMenhy.ht5Sm00BrpM))
			.Where(OqDgDYE6vC1)
			.ToList();
		FloatButtonColor = list[new Random().Next(list.Count)].GetBrush();
	}

	public double GetBrightness(Color color)
	{
		return 0.2126 * (double)(int)color.R + 0.7152 * (double)(int)color.G + 0.0722 * (double)(int)color.B;
	}

	private void kGVgDNK2ngi(object sender, ActionButtonEventArgs<MouseButtonEventArgs> e)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.o2WSm8moOGq = e;
		if ((DateTime.UtcNow - eVngDpjwlmK).TotalMilliseconds < 50.0)
		{
			return;
		}
		if (_003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginArgs.ChangedButton == MouseButton.Left)
		{
			if (_003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginAction == null)
			{
				return;
			}
			if (Keyboard.Modifiers == ModifierKeys.Shift)
			{
				if (Keyboard.IsKeyDown(Key.LeftShift))
				{
					VcMgDGoBvLj.EditActionById(_003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginAction.Id);
				}
				else if (Keyboard.IsKeyDown(Key.RightShift))
				{
					O9QgDk1KmmC.NotifyRunAction(this, _003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginAction.Id, true, false, ActionTrigger.FloatPanel, true);
				}
			}
			else
			{
				O9QgDk1KmmC.NotifyRunAction(this, _003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginAction.Id, false, false, ActionTrigger.FloatPanel, true);
			}
			if (DoHideWhenClosing)
			{
				JrNgDJ29rAi();
			}
		}
		else if (_003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginArgs.ChangedButton == MouseButton.Middle)
		{
			if (!AppState.HHxtaMaoqJr().DisableMiddleClickCloseFloat)
			{
				JrNgDJ29rAi();
			}
		}
		else
		{
			if (_003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginArgs.ChangedButton != MouseButton.Right || _003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginAction == null)
			{
				return;
			}
			ActionItem originAction = _003C_003Ec__DisplayClass47_.o2WSm8moOGq.OriginAction;
			if (originAction == null || originAction.ActionType != ActionType.GoParent)
			{
				ContextMenu contextMenu = new ContextMenu();
				VcMgDGoBvLj.BuildMenuForActionButton(contextMenu, originAction, _003C_003Ec__DisplayClass47_.o2WSm8moOGq.Profile, _003C_003Ec__DisplayClass47_.o2WSm8moOGq.Row, _003C_003Ec__DisplayClass47_.o2WSm8moOGq.Col, Window.GetWindow(this), ActionTrigger.Panel);
				if (contextMenu.Items.Count > 0)
				{
					_003C_003Ec__DisplayClass47_.o2WSm8moOGq.Button.ContextMenu = contextMenu;
					contextMenu.IsOpen = true;
					contextMenu.Closed += _003C_003Ec__DisplayClass47_.ImlSmyqW8gR;
					AppState.RegisterContextMenu(contextMenu);
				}
			}
		}
	}

	private void JrNgDJ29rAi()
	{
		if (DoHideWhenClosing)
		{
			Hide();
		}
		else
		{
			Close();
		}
	}

	private void SoTgD0RBRpv(ActionEditCompletedMessage actionEditCompletedMessage_0)
	{
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
		_003C_003Ec__DisplayClass49_.LYMSm7V8noe = this;
		_003C_003Ec__DisplayClass49_.BIGSmRt5ub0 = actionEditCompletedMessage_0;
		if (_003C_003Ec__DisplayClass49_.BIGSmRt5ub0.Profile.Id == n9xgDIfF0JY.Id)
		{
			base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass49_.DLuSmaxZiWG);
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool NZDgDCyvUHe(ref NativeMethods.WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_0);

	public static Point GetMousePosition()
	{
		NativeMethods.WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_ = default(NativeMethods.WMgqc8DPfO1vLRdX3NM);
		NZDgDCyvUHe(ref wmgqc8DPfO1vLRdX3NM_);
		return new Point(wmgqc8DPfO1vLRdX3NM_.X, wmgqc8DPfO1vLRdX3NM_.Y);
	}

	private IntPtr iZbgDPKPddM(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_3)
	{
		int num;
		vwqB2BuBog39ZFn6s6V structure = default(vwqB2BuBog39ZFn6s6V);
		double num2 = default(double);
		double num3 = default(double);
		if (int_0 != 70)
		{
			if (int_0 != 562)
			{
				goto IL_017e;
			}
			Fe7gDb3as6F = null;
			num = 1;
			if (!pQvNsmFFXp4OYJQgh4aP())
			{
				goto IL_0111;
			}
		}
		else
		{
			structure = (vwqB2BuBog39ZFn6s6V)Marshal.PtrToStructure(intptr_2, typeof(vwqB2BuBog39ZFn6s6V));
			if ((structure.QT2SmNsON6x & 2) != 0)
			{
				return IntPtr.Zero;
			}
			if ((Window)HwndSource.FromHwnd(intptr_0).RootVisual == null)
			{
				return IntPtr.Zero;
			}
			if (Fe7gDb3as6F.HasValue)
			{
				goto IL_0133;
			}
			Point mousePosition = GetMousePosition();
			num2 = Math.Min(Math.Abs(mousePosition.X - (double)structure.x), Math.Abs(mousePosition.X - (double)structure.x - (double)structure.YpvSm2bao4g));
			num3 = Math.Min(Math.Abs(mousePosition.Y - (double)structure.l4pSmSbnPDG), Math.Abs(mousePosition.Y - (double)structure.l4pSmSbnPDG - (double)structure.mGVSmu3hZoU));
			num = 0;
			if (iCuUqRFFpFO5FiglISjU != null)
			{
				goto IL_0111;
			}
		}
		goto IL_0115;
		IL_0115:
		switch (num)
		{
		case 1:
			goto IL_017e;
		}
		Fe7gDb3as6F = num3 > num2;
		goto IL_0133;
		IL_0111:
		int num4 = default(int);
		num = num4;
		goto IL_0115;
		IL_017e:
		return IntPtr.Zero;
		IL_0133:
		if (Fe7gDb3as6F.Value)
		{
			structure.mGVSmu3hZoU = (int)((double)structure.YpvSm2bao4g / WbggD1wd75I);
		}
		else
		{
			structure.YpvSm2bao4g = (int)((double)structure.mGVSmu3hZoU * WbggD1wd75I);
		}
		Marshal.StructureToPtr(structure, intptr_2, true);
		bool_3 = true;
		goto IL_017e;
	}

	private void d5sgDE0SDVH(CloseAllFloatingActions closeAllFloatingActions_0)
	{
		JrNgDJ29rAi();
	}

	private void gcNgDyH2EkZ(object sender, EventArgs e)
	{
		if (TGDgDsDIiyS != null)
		{
			O9QgDk1KmmC.Unsubscribe<CloseAllFloatingActions>(TGDgDsDIiyS);
			TGDgDsDIiyS = null;
		}
		if (bjLgDHp6Evy != null)
		{
			O9QgDk1KmmC.Unsubscribe<ActionEditCompletedMessage>(bjLgDHp6Evy);
			bjLgDHp6Evy = null;
		}
		AO0gDrNHeEM.UnRegister(this);
	}

	private void wBPgD83GegA(object sender, RoutedEventArgs e)
	{
		UpdateUiSkin();
		Fl5gD9cce1l();
	}

	public void UpdateUiSkin()
	{
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		bool flag = AppState.DataService.FjftbTOtevj();
		UIHelper.UpdateUiSkinCommon(this, uiSettings, flag);
		ImageBrush imageBrush = default(ImageBrush);
		int num;
		if (flag)
		{
			if (string.IsNullOrEmpty(uiSettings.BackgroundImage))
			{
				BodyBg.Background = Color.FromArgb(1, 0, 0, 0).GetBrush();
			}
			else
			{
				string backgroundImage = uiSettings.BackgroundImage;
				if (backgroundImage.StartsWith("http", StringComparison.InvariantCultureIgnoreCase) || File.Exists(backgroundImage))
				{
					imageBrush = new ImageBrush();
					imageBrush.ImageSource = ImageCache.GetImageSource(backgroundImage);
					imageBrush.Stretch = Stretch.UniformToFill;
					num = 0;
					if (!pQvNsmFFXp4OYJQgh4aP())
					{
						goto IL_00e0;
					}
					goto IL_00e4;
				}
			}
		}
		goto IL_0154;
		IL_00e0:
		int num2 = default(int);
		num = num2;
		goto IL_00e4;
		IL_0154:
		if (!string.IsNullOrEmpty(uiSettings.BackgroundColor))
		{
			Color color = UIHelper.ColorFromString(uiSettings.BackgroundColor);
			if (color.A == 0)
			{
				color.A = 1;
			}
			BodyGrid.Background = color.GetBrush();
			ProfilePanelControl.GridBgColor = Brushes.Transparent;
		}
		GridHeader.Background = UIHelper.SolidColorBrushFromString(uiSettings.ToolbarColor);
		ButtonColor = UIHelper.SolidColorBrushFromString(uiSettings.ToolbarBtnColor);
		num = 1;
		if (!pQvNsmFFXp4OYJQgh4aP())
		{
			goto IL_00e0;
		}
		goto IL_00e4;
		IL_00e4:
		switch (num)
		{
		case 1:
			return;
		}
		imageBrush.Opacity = uiSettings.BackgroundImageOpacity;
		BodyBg.Background = imageBrush;
		goto IL_0154;
	}

	private void TheButton_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
	{
	}

	private void dwcgDan47oI(object sender, MouseEventArgs e)
	{
		if (e.LeftButton == MouseButtonState.Pressed)
		{
			DragMove();
			WindowHelper.EnsureTopMost(this, true);
		}
	}

	private void TheButton_OnPreviewMouseUp(object sender, MouseButtonEventArgs e)
	{
	}

	private void dwUgD7sONEh(object sender, RoutedEventArgs e)
	{
		JrNgDJ29rAi();
	}

	private void asZgDRvvAmu(object sender, RoutedEventArgs e)
	{
	}

	public void DragMoveEnd()
	{
	}

	private void RbugDqubLqO(object sender, RoutedEventArgs e)
	{
		JrNgDJ29rAi();
	}

	private void eORgDc5hChR(object sender, RoutedEventArgs e)
	{
		IsPinned = !IsPinned;
	}

	private void eyygDVMmc29(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Middle && !AppState.HHxtaMaoqJr().DisableMiddleClickCloseFloat)
		{
			JrNgDJ29rAi();
		}
	}

	private void c1QgDZJrY94(object sender, RoutedEventArgs e)
	{
		EnableProcessBinding = !EnableProcessBinding;
		Fl5gD9cce1l();
	}

	private void Fl5gD9cce1l()
	{
		IconLink.Opacity = (EnableProcessBinding ? 1.0 : 0.3);
		BtnLink.ToolTip = (EnableProcessBinding ? "【已启用】" : "【未启用】") + "关联到进程：" + BindingProcessName;
	}

	public FloatItemState GetState()
	{
		return new FloatItemState
		{
			ItemType = FloatItemType.ActionPage,
			BindProcessName = BindingProcessName,
			IsBindProcess = EnableProcessBinding,
			Color = FloatButtonColor.ToString(),
			Left = base.Left,
			Top = base.Top,
			Location = WindowHelper.GetWindowTopLeft(new WindowInteropHelper(this).Handle),
			ItemId = n9xgDIfF0JY.Id,
			IsPined = IsPinned
		};
	}

	private void ProfilePanelControl_OnActionButtonClicked(object sender, ActionButtonEventArgs<MouseButtonEventArgs> e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!HFPgDj1429y)
		{
			HFPgDj1429y = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/main/floatpanelwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			HFPgDj1429y = true;
			break;
		case 1:
			TheWindow = (FloatPanelWindow)target;
			TheWindow.PreviewMouseDown += eyygDVMmc29;
			break;
		case 2:
			MenuClose = (MenuItem)target;
			MenuClose.Click += dwUgD7sONEh;
			break;
		case 3:
			ShadowBorder = (Border)target;
			break;
		case 4:
			BodyBg = (Border)target;
			break;
		case 5:
			((Border)target).MouseMove += dwcgDan47oI;
			num = 1;
			if (iCuUqRFFpFO5FiglISjU != null)
			{
				break;
			}
			goto IL_017c;
		case 6:
			BodyGrid = (Grid)target;
			break;
		case 7:
			GridHeader = (Grid)target;
			break;
		case 8:
			LblProfileName = (TextBlock)target;
			break;
		case 9:
			BtnLink = (Button)target;
			BtnLink.Click += c1QgDZJrY94;
			break;
		case 10:
			IconLink = (SvgAwesome)target;
			break;
		case 11:
			BtnPin = (Button)target;
			BtnPin.Click += eORgDc5hChR;
			break;
		case 12:
			IconPin = (SvgAwesome)target;
			break;
		case 13:
			BtnClose = (Button)target;
			num = 0;
			if (iCuUqRFFpFO5FiglISjU != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_017c;
		case 14:
			{
				ProfilePanelControl = (ProfilePanelControl)target;
				break;
			}
			IL_017c:
			switch (num)
			{
			default:
				BtnClose.Click += RbugDqubLqO;
				break;
			case 1:
				break;
			}
			break;
		}
	}

	static FloatPanelWindow()
	{
		uEJgDXtVAOw = new Color[0];
		IsPinnedProperty = DependencyProperty.RegisterAttached("IsPinned", typeof(bool), typeof(global::Quicker.View.FloatPanelWindow), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits, null));
		cepgDmtnJjZ = Brushes.DodgerBlue;
		FloatButtonColorProperty = DependencyProperty.RegisterAttached("FloatButtonColor", typeof(Brush), typeof(FloatPanelWindow), new FrameworkPropertyMetadata(cepgDmtnJjZ, FrameworkPropertyMetadataOptions.Inherits, null));
		ugYgDKyThHC = Color.FromArgb(byte.MaxValue, 0, 0, 0).GetBrush();
		ButtonColorProperty = DependencyProperty.RegisterAttached("ButtonColor", typeof(Brush), typeof(global::Quicker.View.FloatPanelWindow), new FrameworkPropertyMetadata(ugYgDKyThHC, FrameworkPropertyMetadataOptions.Inherits, null));
	}

	[CompilerGenerated]
	private void lccgDhqEg7l(object sender, EventArgs e)
	{
		((HwndSource)PresentationSource.FromVisual((Window)sender)).AddHook(iZbgDPKPddM);
		WbggD1wd75I = base.Width / base.Height;
		NativeMethods.SetWindowNoActivate(this);
	}

	[CompilerGenerated]
	private void E4wgDeiEN35(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (ShadowBorder.IsVisible)
		{
			eVngDpjwlmK = DateTime.UtcNow;
		}
	}

	[CompilerGenerated]
	private bool OqDgDYE6vC1(Color color_1)
	{
		return GetBrightness(color_1) < 128.0;
	}

	internal static bool pQvNsmFFXp4OYJQgh4aP()
	{
		return iCuUqRFFpFO5FiglISjU == null;
	}
}
