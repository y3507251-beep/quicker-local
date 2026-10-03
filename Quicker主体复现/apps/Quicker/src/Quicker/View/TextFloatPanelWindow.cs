using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using FontAwesome5;
using FontAwesome5.WPF;
using JTIh7V5l65QV75A93Ly;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Messages;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View;

public class TextFloatPanelWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec SrgSXiKIAHd;

		public static Func<ActionProfile, string> xgBSX3yvfnM;

		internal static _003C_003Ec rCY9bKWZhUB4sb4ttQcS;

		static _003C_003Ec()
		{
			SrgSXiKIAHd = new _003C_003Ec();
		}

		internal string rauSXlraEKM(ActionProfile x)
		{
			return x.Id;
		}

		internal static bool UQGRcFWZHWcha6h61Iw6()
		{
			return rCY9bKWZhUB4sb4ttQcS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public ActionButtonEventArgs<MouseButtonEventArgs> KBISXzNauR9;

		private static _003C_003Ec__DisplayClass24_0 lbTramW5VBpavruORYTI;

		internal void KMgSXfs6Vw7(object sender, RoutedEventArgs e)
		{
			KBISXzNauR9.Button.ContextMenu = null;
		}

		internal static bool XVbjhmW5Qx4uMugg0cY0()
		{
			return lbTramW5VBpavruORYTI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public TextFloatPanelWindow ElXSmtoUVWn;

		public ActionEditCompletedMessage VeMSmgXmVdH;

		private static _003C_003Ec__DisplayClass27_0 ycxinlW5WYUp1Y2dPt7L;

		internal void wrKSmwnovgq()
		{
			ElXSmtoUVWn.ProfilePanelControl.ActionProfile = VeMSmgXmVdH.Profile;
			ElXSmtoUVWn.ProfilePanelControl.RefreshUi();
		}

		internal static bool MmtinkW5yLg9u1dTGKaO()
		{
			return ycxinlW5WYUp1Y2dPt7L == null;
		}
	}

	private readonly TextFloatPanelState hNIg5OayKP0;

	private readonly TextFloatPanelMgr f91g5FZ30ZH;

	private readonly ITinyMessengerHub agng5UwDyLs;

	private TinyMessageSubscriptionToken fLlg5l5TQON;

	private TinyMessageSubscriptionToken PDWg5iTXUuw;

	private readonly IList<ActionProfile> Nbtg53j78Hi = new List<ActionProfile>();

	private static readonly System.Windows.Media.Brush GUcg5f7XBAB;

	public static readonly DependencyProperty FloatButtonColorProperty;

	private static readonly System.Windows.Media.Brush Ukig5zIrcox;

	public static readonly DependencyProperty ButtonColorProperty;

	private DispatcherTimer qU2gDwxrLyj;

	private int NyJgDt2Es1q;

	private Timer bXdgDgicdDq;

	private readonly DataService EkLgDLknVdE;

	private readonly DebounceTimer zDhgDv3nOOu = new DebounceTimer();

	internal TextFloatPanelWindow TheWindow;

	internal Border FloatBtn;

	internal Grid ShadowBorder;

	internal Border BodyBg;

	internal Grid BodyGrid;

	internal Grid GridHeader;

	internal TextBlock LblProfileName;

	internal Button BtnMode;

	internal SvgAwesome IconFollowMode;

	internal Button BtnRemovePage;

	internal Button BtnClose;

	internal ProfileNavIndicator ProfileNavIndicator;

	internal ProfilePanelControl ProfilePanelControl;

	private bool YWpgDSDfSMU;

	internal static TextFloatPanelWindow QgoQrLFQMc199MvV8lG6;

	public System.Windows.Media.Brush FloatButtonColor
	{
		get
		{
			return (System.Windows.Media.Brush)GetValue(FloatButtonColorProperty);
		}
		set
		{
			SetValue(FloatButtonColorProperty, value);
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

	public TextFloatPanelWindow(TextFloatPanelMgr mgr, TextFloatPanelState state, ActionProfile defaultProfile, ITinyMessengerHub hub, DataService dataService)
	{
		hNIg5OayKP0 = state;
		f91g5FZ30ZH = mgr;
		agng5UwDyLs = hub;
		EkLgDLknVdE = dataService;
		InitializeComponent();
		base.SourceInitialized += EQbg55VqTCg;
		base.Loaded += Kv1g5HpN8NB;
		base.Closed += ly2g5sAa6qa;
		base.IsVisibleChanged += KdLg5IUg7fp;
		fLlg5l5TQON = hub.Subscribe<ActionEditCompletedMessage>(is4g5kwi3Sm);
		PDWg5iTXUuw = hub.Subscribe<ActionDeletedMessage>(wEug5efhp4K);
		ProfilePanelControl.EnableDragAction = false;
		foreach (string profile in hNIg5OayKP0.Profiles)
		{
			if (EkLgDLknVdE.mP6tXA8VyNP().TryGetValue(profile, out var value))
			{
				Nbtg53j78Hi.Add(value);
			}
		}
		if (Nbtg53j78Hi.Count == 0)
		{
			Nbtg53j78Hi.Add(defaultProfile);
		}
		if (!string.IsNullOrEmpty(hNIg5OayKP0.LastProfileId))
		{
			int num = Nbtg53j78Hi.IndexOf(TVgg5DjgwXl);
			if (num >= 0)
			{
				GoToPage(num);
			}
			else
			{
				GoToPage(0);
			}
		}
		else
		{
			GoToPage(0);
		}
		ProfilePanelControl.ActionButtonClicked += Jxxg5Wf9DkZ;
		ProfilePanelControl.ActionButtonWheeled += quig5YxgTIw;
	}

	private void wEug5efhp4K(ActionDeletedMessage actionDeletedMessage_0)
	{
		if (Nbtg53j78Hi != null && NyJgDt2Es1q < Nbtg53j78Hi.Count)
		{
			base.Dispatcher.InvokeAsync(TZug5die2Rf);
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

	private void quig5YxgTIw(object sender, ActionButtonEventArgs<MouseWheelEventArgs> e)
	{
		if (e.OriginAction != null && e.OriginAction.AllowScrollTrigger)
		{
			agng5UwDyLs.NotifyRunAction(this, e.OriginAction.Id, false, false, ActionTrigger.ScrollOnButton, true, null, ActionHelper.GetScrollActionParam(e.OriginArgs.Delta));
		}
	}

	private void KdLg5IUg7fp(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (!base.IsVisible)
		{
			qU2gDwxrLyj.Stop();
			return;
		}
		if (qU2gDwxrLyj == null)
		{
			qU2gDwxrLyj = new DispatcherTimer(new TimeSpan(0, 0, 2), DispatcherPriority.Normal, epcg5oaHuTn, Dispatcher.CurrentDispatcher);
		}
		qU2gDwxrLyj.Stop();
		qU2gDwxrLyj.Start();
	}

	public void GoToPage(int pageIndex)
	{
		if (Nbtg53j78Hi.Count > pageIndex)
		{
			NyJgDt2Es1q = pageIndex;
			ActionProfile actionProfile = Nbtg53j78Hi[pageIndex];
			ProfilePanelControl.ActionProfile = actionProfile;
			LblProfileName.Text = actionProfile.DisplayName;
		}
		SYng5mC1bBN();
		if (Bri3XTFQUXsP9VXlRAFS())
		{
			switch (0)
			{
			}
		}
		BtnRemovePage.Visibility = ((Nbtg53j78Hi.Count <= 1) ? Visibility.Collapsed : Visibility.Visible);
		hNIg5OayKP0.Profiles = Nbtg53j78Hi.Select(_003C_003Ec.xgBSX3yvfnM ?? (_003C_003Ec.xgBSX3yvfnM = _003C_003Ec.SrgSXiKIAHd.rauSXlraEKM)).ToList();
		hNIg5OayKP0.LastProfileId = Nbtg53j78Hi[pageIndex].Id;
		SaveState();
	}

	private void Jxxg5Wf9DkZ(object sender, ActionButtonEventArgs<MouseButtonEventArgs> e)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.KBISXzNauR9 = e;
		if (_003C_003Ec__DisplayClass24_.KBISXzNauR9.OriginArgs.ChangedButton == MouseButton.Left)
		{
			if (_003C_003Ec__DisplayClass24_.KBISXzNauR9.OriginAction != null)
			{
				agng5UwDyLs.NotifyRunAction(this, _003C_003Ec__DisplayClass24_.KBISXzNauR9.OriginAction.Id, false, false, ActionTrigger.FloatPanel, true);
				DoHideWindow();
				AppState.Lista4qx2wK().CountTextFloater();
			}
		}
		else if (_003C_003Ec__DisplayClass24_.KBISXzNauR9.OriginArgs.ChangedButton == MouseButton.Middle)
		{
			DoHideWindow();
		}
		else
		{
			if (_003C_003Ec__DisplayClass24_.KBISXzNauR9.OriginArgs.ChangedButton != MouseButton.Right || _003C_003Ec__DisplayClass24_.KBISXzNauR9.OriginAction == null)
			{
				return;
			}
			ActionItem originAction = _003C_003Ec__DisplayClass24_.KBISXzNauR9.OriginAction;
			if (originAction == null || originAction.ActionType != ActionType.GoParent)
			{
				ContextMenu contextMenu = new ContextMenu();
				AppState.lWutartRfUY().BuildMenuForActionButton(contextMenu, originAction, _003C_003Ec__DisplayClass24_.KBISXzNauR9.Profile, _003C_003Ec__DisplayClass24_.KBISXzNauR9.Row, _003C_003Ec__DisplayClass24_.KBISXzNauR9.Col, Window.GetWindow(this), ActionTrigger.Panel);
				if (contextMenu.Items.Count > 0)
				{
					_003C_003Ec__DisplayClass24_.KBISXzNauR9.Button.ContextMenu = contextMenu;
					contextMenu.IsOpen = true;
					contextMenu.Closed += _003C_003Ec__DisplayClass24_.KMgSXfs6Vw7;
					AppState.RegisterContextMenu(contextMenu);
				}
			}
		}
	}

	public void DoHideWindow()
	{
		ShadowBorder.Visibility = Visibility.Hidden;
		bXdgDgicdDq = new Timer(o4Zg5TeDQZs, null, 20, 0);
	}

	private void is4g5kwi3Sm(ActionEditCompletedMessage actionEditCompletedMessage_0)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.ElXSmtoUVWn = this;
		_003C_003Ec__DisplayClass27_.VeMSmgXmVdH = actionEditCompletedMessage_0;
		if (Nbtg53j78Hi != null && NyJgDt2Es1q < Nbtg53j78Hi.Count && _003C_003Ec__DisplayClass27_.VeMSmgXmVdH.Profile != null && _003C_003Ec__DisplayClass27_.VeMSmgXmVdH.Profile.Id == Nbtg53j78Hi[NyJgDt2Es1q].Id)
		{
			base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass27_.wrKSmwnovgq);
			int num = 0;
			if (QgoQrLFQMc199MvV8lG6 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RbKg5GxP2PK(ref NativeMethods.WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_0);

	public static System.Drawing.Point GetMousePosition()
	{
		NativeMethods.WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_ = default(NativeMethods.WMgqc8DPfO1vLRdX3NM);
		RbKg5GxP2PK(ref wmgqc8DPfO1vLRdX3NM_);
		return new System.Drawing.Point(wmgqc8DPfO1vLRdX3NM_.X, wmgqc8DPfO1vLRdX3NM_.Y);
	}

	private void ly2g5sAa6qa(object sender, EventArgs e)
	{
		if (fLlg5l5TQON != null)
		{
			agng5UwDyLs.Unsubscribe<ActionEditCompletedMessage>(fLlg5l5TQON);
			fLlg5l5TQON = null;
		}
		if (PDWg5iTXUuw != null)
		{
			agng5UwDyLs.Unsubscribe<ActionDeletedMessage>(PDWg5iTXUuw);
			PDWg5iTXUuw = null;
		}
	}

	private void Kv1g5HpN8NB(object sender, RoutedEventArgs e)
	{
		WVjg51uhoJ8();
		l2jg5nNpbTl();
	}

	private void WVjg51uhoJ8()
	{
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		bool flag = EkLgDLknVdE.FjftbTOtevj();
		UIHelper.UpdateUiSkinCommon(this, uiSettings, flag);
		ImageBrush imageBrush = default(ImageBrush);
		int num;
		System.Windows.Media.Color color = default(System.Windows.Media.Color);
		if (flag)
		{
			if (!string.IsNullOrEmpty(uiSettings.BackgroundImage))
			{
				string backgroundImage = uiSettings.BackgroundImage;
				if (!backgroundImage.StartsWith("http", StringComparison.InvariantCultureIgnoreCase) && !File.Exists(backgroundImage))
				{
					goto IL_0110;
				}
				imageBrush = new ImageBrush();
				BitmapSource imageSource = ImageCache.GetImageSource(backgroundImage);
				imageBrush.ImageSource = imageSource;
				imageBrush.Stretch = Stretch.UniformToFill;
				imageBrush.Opacity = uiSettings.BackgroundImageOpacity;
				num = 0;
				if (QgoQrLFQMc199MvV8lG6 == null)
				{
					goto IL_00fc;
				}
			}
			else
			{
				color = UIHelper.ColorFromString(uiSettings.BackgroundColor);
				color.A = byte.MaxValue;
				num = 1;
				if (!Bri3XTFQUXsP9VXlRAFS())
				{
					goto IL_00e7;
				}
			}
			goto IL_00eb;
		}
		goto IL_0110;
		IL_00e7:
		int num2 = default(int);
		num = num2;
		goto IL_00eb;
		IL_0110:
		if (!string.IsNullOrEmpty(uiSettings.BackgroundColor))
		{
			System.Windows.Media.Color color2 = UIHelper.ColorFromString(uiSettings.BackgroundColor);
			if (color2.A == 0)
			{
				color2.A = 1;
			}
			BodyGrid.Background = color2.GetBrush();
			ProfilePanelControl.GridBgColor = System.Windows.Media.Brushes.Transparent;
		}
		GridHeader.Background = UIHelper.SolidColorBrushFromString(uiSettings.ToolbarColor);
		ButtonColor = UIHelper.SolidColorBrushFromString(uiSettings.ToolbarBtnColor);
		return;
		IL_00eb:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				goto end_IL_00eb;
			case 2:
				goto IL_0110;
			}
			BodyBg.Background = color.GetBrush();
			num = 2;
			if (QgoQrLFQMc199MvV8lG6 == null)
			{
				continue;
			}
			goto IL_00e7;
			continue;
			end_IL_00eb:
			break;
		}
		goto IL_00fc;
		IL_00fc:
		imageBrush.TryFreeze();
		BodyBg.Background = imageBrush;
		goto IL_0110;
	}

	private void HgIg5bNUcQu(object sender, MouseEventArgs e)
	{
		if (e.LeftButton != MouseButtonState.Pressed)
		{
			return;
		}
		System.Drawing.Point mousePosition = GetMousePosition();
		ShadowBorder.Visibility = Visibility.Hidden;
		DragMove();
		System.Drawing.Point mousePosition2 = GetMousePosition();
		ShadowBorder.Visibility = Visibility.Visible;
		hNIg5OayKP0.OffsetX += mousePosition2.X - mousePosition.X;
		hNIg5OayKP0.OffsetY += mousePosition2.Y - mousePosition.Y;
		if (QgoQrLFQMc199MvV8lG6 != null)
		{
			switch (0)
			{
			}
		}
		SaveState();
	}

	private void iAEg56lUdky(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要停用文本悬浮功能么？\n确认：停用此功能。如需重新开启，请在托盘图标上右键菜单中启用。\n取消：隐藏悬浮窗。在其他位置点击鼠标也可隐藏。"))
		{
			Close();
		}
		else
		{
			DoHideWindow();
		}
	}

	private void NKLg5XHoA3j(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Middle)
		{
			DoHideWindow();
		}
	}

	public void AddProfile(ActionProfile profile)
	{
		int num = Nbtg53j78Hi.IndexOf(profile);
		if (num < 0)
		{
			Nbtg53j78Hi.Add(profile);
			GoToPage(Nbtg53j78Hi.Count - 1);
		}
		else
		{
			GoToPage(num);
		}
	}

	private void SYng5mC1bBN()
	{
		ProfileNavIndicator.Update(Nbtg53j78Hi.Count, NyJgDt2Es1q);
	}

	private void DPTg5KaanEt(object sender, MouseEventArgs e)
	{
		zDhgDv3nOOu.Debounce(200, LZbg5MgQemV);
	}

	private void fSfg5xBuVoj(object sender, MouseEventArgs e)
	{
		if (!base.IsMouseOver)
		{
			ShadowBorder.Visibility = Visibility.Hidden;
			LEXg5rFkSqH();
		}
	}

	private void LEXg5rFkSqH()
	{
		qU2gDwxrLyj?.Stop();
		qU2gDwxrLyj?.Start();
	}

	private void h6Gg5p8N0YA(object sender, MouseWheelEventArgs e)
	{
	}

	private void mKSg5B5uShE(object sender, RoutedEventArgs e)
	{
		if (Nbtg53j78Hi.Count <= 1)
		{
			AppHelper.ShowWarning("只有一页，不能再移除了。");
			return;
		}
		Nbtg53j78Hi.RemoveAt(NyJgDt2Es1q);
		if (NyJgDt2Es1q == Nbtg53j78Hi.Count)
		{
			GoToPage(NyJgDt2Es1q - 1);
		}
		else
		{
			GoToPage(NyJgDt2Es1q);
		}
	}

	public void UpdatePosition()
	{
		IHNRIiikxBwJdYmHpM3.p1AvvooEqum(this, ShowWindowLocation.ByOffset, hNIg5OayKP0.OffsetX, hNIg5OayKP0.OffsetY);
		LEXg5rFkSqH();
	}

	private void ProfileNavIndicator_OnPointClicked(object sender, PointClickedEventArgs e)
	{
		GoToPage(e.Index);
	}

	private void Qpyg5Qp0NmG(object sender, RoutedEventArgs e)
	{
		if (hNIg5OayKP0 != null)
		{
			hNIg5OayKP0.FollowMode = Q86g5jwvKxX();
			SaveState();
			l2jg5nNpbTl();
		}
	}

	private MouseFollowMode Q86g5jwvKxX()
	{
		List<MouseFollowMode> list = Enum.GetValues(typeof(MouseFollowMode)).Cast<MouseFollowMode>().ToList();
		int num = list.IndexOf(hNIg5OayKP0.FollowMode);
		num = ((num < list.Count - 1) ? (num + 1) : 0);
		return list[num];
	}

	private void SaveState()
	{
		f91g5FZ30ZH.SaveTextFloatPanelState(hNIg5OayKP0);
	}

	private void l2jg5nNpbTl()
	{
		switch (hNIg5OayKP0.FollowMode)
		{
		case MouseFollowMode.TextSelection:
			IconFollowMode.Icon = EFontAwesomeIcon.Regular_Circle;
			break;
		case MouseFollowMode.Text:
			IconFollowMode.Icon = EFontAwesomeIcon.Regular_DotCircle;
			break;
		case MouseFollowMode.Always:
			IconFollowMode.Icon = EFontAwesomeIcon.Solid_Circle;
			break;
		}
	}

	internal void Icyg54qpBt1(int int_1)
	{
		if (int_1 > 0)
		{
			if (NyJgDt2Es1q > 0)
			{
				GoToPage(NyJgDt2Es1q - 1);
			}
			else if (EkLgDLknVdE.CpItmVISR7P().EnableCyclePaging)
			{
				GoToPage(Nbtg53j78Hi.Count - 1);
			}
		}
		else if (NyJgDt2Es1q < Nbtg53j78Hi.Count - 1)
		{
			if (Bri3XTFQUXsP9VXlRAFS())
			{
				switch (0)
				{
				}
			}
			GoToPage(NyJgDt2Es1q + 1);
		}
		else if (EkLgDLknVdE.CpItmVISR7P().EnableCyclePaging)
		{
			GoToPage(0);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!YWpgDSDfSMU)
		{
			YWpgDSDfSMU = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/textfloatpanel/textfloatpanelwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			YWpgDSDfSMU = true;
			break;
		case 1:
			TheWindow = (TextFloatPanelWindow)target;
			TheWindow.MouseEnter += DPTg5KaanEt;
			TheWindow.MouseLeave += fSfg5xBuVoj;
			TheWindow.MouseMove += HgIg5bNUcQu;
			TheWindow.PreviewMouseDown += NKLg5XHoA3j;
			break;
		case 2:
			FloatBtn = (Border)target;
			break;
		case 3:
			ShadowBorder = (Grid)target;
			num = 1;
			if (Bri3XTFQUXsP9VXlRAFS())
			{
				break;
			}
			goto IL_010c;
		case 4:
			BodyBg = (Border)target;
			break;
		case 5:
			BodyGrid = (Grid)target;
			break;
		case 6:
			GridHeader = (Grid)target;
			num = 0;
			if (QgoQrLFQMc199MvV8lG6 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_010c;
		case 7:
			LblProfileName = (TextBlock)target;
			break;
		case 8:
			BtnMode = (Button)target;
			BtnMode.Click += Qpyg5Qp0NmG;
			break;
		case 9:
			IconFollowMode = (SvgAwesome)target;
			break;
		case 10:
			BtnRemovePage = (Button)target;
			BtnRemovePage.Click += mKSg5B5uShE;
			break;
		case 11:
			BtnClose = (Button)target;
			BtnClose.Click += iAEg56lUdky;
			break;
		case 12:
			ProfileNavIndicator = (ProfileNavIndicator)target;
			break;
		case 13:
			{
				ProfilePanelControl = (ProfilePanelControl)target;
				break;
			}
			IL_010c:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	static TextFloatPanelWindow()
	{
		GUcg5f7XBAB = System.Windows.Media.Brushes.DodgerBlue;
		FloatButtonColorProperty = DependencyProperty.RegisterAttached("FloatButtonColor", typeof(System.Windows.Media.Brush), typeof(TextFloatPanelWindow), new FrameworkPropertyMetadata(GUcg5f7XBAB, FrameworkPropertyMetadataOptions.Inherits, null));
		Ukig5zIrcox = System.Windows.Media.Color.FromArgb(byte.MaxValue, 0, 0, 0).GetBrush();
		ButtonColorProperty = DependencyProperty.RegisterAttached("ButtonColor", typeof(System.Windows.Media.Brush), typeof(TextFloatPanelWindow), new FrameworkPropertyMetadata(Ukig5zIrcox, FrameworkPropertyMetadataOptions.Inherits, null));
	}

	[CompilerGenerated]
	private void EQbg55VqTCg(object sender, EventArgs e)
	{
		NativeMethods.SetWindowNoActivate(this);
	}

	[CompilerGenerated]
	private bool TVgg5DjgwXl(ActionProfile actionProfile_0)
	{
		return actionProfile_0.Id == hNIg5OayKP0.LastProfileId;
	}

	[CompilerGenerated]
	private void TZug5die2Rf()
	{
		ProfilePanelControl.RefreshUi();
	}

	[CompilerGenerated]
	private void epcg5oaHuTn(object sender, EventArgs e)
	{
		if (!base.IsMouseOver)
		{
			Hide();
		}
	}

	[CompilerGenerated]
	private void o4Zg5TeDQZs(object object_0)
	{
		base.Dispatcher.Invoke(base.Hide);
	}

	[CompilerGenerated]
	private void LZbg5MgQemV(object object_0)
	{
		if (base.IsMouseOver)
		{
			base.Dispatcher.InvokeAsync(KN5g5ASmAKq);
		}
	}

	[CompilerGenerated]
	private void KN5g5ASmAKq()
	{
		ShadowBorder.Visibility = Visibility.Visible;
	}

	internal static bool Bri3XTFQUXsP9VXlRAFS()
	{
		return QgoQrLFQMc199MvV8lG6 == null;
	}

	internal static void TjOPtlFFcaYlJRiGcmrJ()
	{
	}
}
