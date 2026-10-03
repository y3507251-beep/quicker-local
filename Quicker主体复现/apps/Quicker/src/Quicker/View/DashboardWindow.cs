using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using HandyControl.Tools;
using JTIh7V5l65QV75A93Ly;
using PInvoke;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Messages;
using Quicker.Domain.Profiles;
using Quicker.Domain.Services;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.CommonControls;
using Quicker.View.Controls;

namespace Quicker.View;

public class DashboardWindow : Window, IComponentConnector
{
	private readonly AppServer QLDg4V2fU7G;

	private readonly ITinyMessengerHub JAlg4Z91SH6;

	private readonly ActionEditMgr jkng49vTgaE;

	private readonly DataService SsTg4h4bxI0;

	private readonly ProfileSwitcher HDUg4eoXbTC;

	private readonly string YwIg4YsXTb4;

	[CompilerGenerated]
	private PointTargetInfo xgyg4I9KGkO;

	internal AlignableWrapPanel GridGlobal;

	internal AlignableWrapPanel GridContext;

	private bool xufg4WGrZLD;

	internal static DashboardWindow FyV521FQp5cnrZYXIfPm;

	public PointTargetInfo PointTargetInfo
	{
		[CompilerGenerated]
		get
		{
			return xgyg4I9KGkO;
		}
		[CompilerGenerated]
		set
		{
			xgyg4I9KGkO = value;
		}
	}

	public DashboardWindow(AppServer appServer, ITinyMessengerHub hub, ActionEditMgr actionEditMgr, DataService dataService, ProfileSwitcher profileSwitcher, string forExe = null)
	{
		QLDg4V2fU7G = appServer;
		JAlg4Z91SH6 = hub;
		jkng49vTgaE = actionEditMgr;
		SsTg4h4bxI0 = dataService;
		HDUg4eoXbTC = profileSwitcher;
		YwIg4YsXTb4 = forExe;
		InitializeComponent();
		base.Loaded += Xpgg48N8TUe;
		base.SourceInitialized += sHog4cRvhqP;
		if (AppState.DataService.Hb9tmk3OsJ7())
		{
			UiSettings settings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
			bool canUseSkin = AppState.DataService.FjftbTOtevj();
			UIHelper.UpdateUiSkinCommon(this, settings, canUseSkin);
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (!AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return new FakeWindowsPeer(this);
		}
		return base.OnCreateAutomationPeer();
	}

	private void Xpgg48N8TUe(object sender, RoutedEventArgs e)
	{
		SetValue(ActionButton.ShrinkTitleProperty, SsTg4h4bxI0.CpItmVISR7P().UiSettings.EnableResizeFont);
		SolidColorBrush gridBgColor = (App.Current.n991yfUy4r() ? "#404040".GetBrush() : Brushes.White);
		if (!string.IsNullOrEmpty(YwIg4YsXTb4))
		{
			using IEnumerator<ActionProfile> enumerator = AppState.B2BtasP38AU().GetAllProfilesByExe(YwIg4YsXTb4, true).GetEnumerator();
			while (enumerator.MoveNext())
			{
				ActionProfile current = enumerator.Current;
				ProfilePanelControl profilePanelControl = new ProfilePanelControl(SsTg4h4bxI0.CpItmVISR7P().UiSettings.ButtonSize);
				profilePanelControl.ActionProfile = current;
				profilePanelControl.ActionButtonClicked += i5eg47id5V7;
				profilePanelControl.Margin = new Thickness(8.0);
				profilePanelControl.GridBgColor = gridBgColor;
				GridGlobal.Children.Add(profilePanelControl);
			}
			if (UfHUuSFQXZ3MIVVEEZQa())
			{
				switch (0)
				{
				}
			}
		}
		else
		{
			int num2 = default(int);
			foreach (ActionProfile allGlobalProfile in HDUg4eoXbTC.AllGlobalProfiles)
			{
				ProfilePanelControl profilePanelControl2 = new ProfilePanelControl(SsTg4h4bxI0.CpItmVISR7P().UiSettings.ButtonSize);
				int num = 0;
				if (!UfHUuSFQXZ3MIVVEEZQa())
				{
					num = num2;
				}
				switch (num)
				{
				}
				profilePanelControl2.ActionProfile = allGlobalProfile;
				profilePanelControl2.ActionButtonClicked += i5eg47id5V7;
				profilePanelControl2.Margin = new Thickness(8.0);
				profilePanelControl2.GridBgColor = gridBgColor;
				GridGlobal.Children.Add(profilePanelControl2);
			}
			using IEnumerator<ActionProfile> enumerator = HDUg4eoXbTC.AllContextProfiles.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ActionProfile current3 = enumerator.Current;
				ProfilePanelControl profilePanelControl3 = new ProfilePanelControl(SsTg4h4bxI0.CpItmVISR7P().UiSettings.ButtonSize);
				profilePanelControl3.ActionProfile = current3;
				profilePanelControl3.Margin = new Thickness(8.0);
				profilePanelControl3.GridBgColor = gridBgColor;
				profilePanelControl3.ActionButtonClicked += i5eg47id5V7;
				GridContext.Children.Add(profilePanelControl3);
			}
			if (UfHUuSFQXZ3MIVVEEZQa())
			{
				switch (0)
				{
				}
			}
		}
		uhfg4aWktYv();
	}

	private void uhfg4aWktYv()
	{
		Screen screen = Screen.FromPoint(NativeMethods.GetMousePosition());
		User32.SetWindowPos(this.GetHandle(), NativeMethods.HWND_TOP, screen.Bounds.Left, screen.Bounds.Top, screen.Bounds.Width, screen.Bounds.Height, User32.SetWindowPosFlags.SWP_SHOWWINDOW);
	}

	private void i5eg47id5V7(object sender, ActionButtonEventArgs<MouseButtonEventArgs> e)
	{
		if (e.OriginArgs.ChangedButton == MouseButton.Left && e.OriginAction != null)
		{
			JAlg4Z91SH6.NotifyRunAction(this, e.OriginAction.Id, false, false, ActionTrigger.DashboardWindow, true, PointTargetInfo);
			Close();
		}
	}

	private void wRVg4RTwbnt(object sender, MouseButtonEventArgs e)
	{
		Close();
	}

	private void HQbg4qCWDpL(object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			Close();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!xufg4WGrZLD)
		{
			xufg4WGrZLD = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/main/dashboardwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			xufg4WGrZLD = true;
			break;
		case 1:
			((DashboardWindow)target).MouseUp += wRVg4RTwbnt;
			((DashboardWindow)target).PreviewKeyDown += HQbg4qCWDpL;
			break;
		case 2:
			GridGlobal = (AlignableWrapPanel)target;
			break;
		case 3:
			GridContext = (AlignableWrapPanel)target;
			break;
		}
	}

	[CompilerGenerated]
	private void sHog4cRvhqP(object sender, EventArgs e)
	{
		NativeMethods.SetWindowNoActivate(this);
	}

	static DashboardWindow()
	{
	}

	internal static bool UfHUuSFQXZ3MIVVEEZQa()
	{
		return FyV521FQp5cnrZYXIfPm == null;
	}

	internal static void EoKDs1FQ3OihTi7wJ4ZK()
	{
	}
}
