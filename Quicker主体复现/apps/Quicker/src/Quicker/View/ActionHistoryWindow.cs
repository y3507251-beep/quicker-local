using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Markup;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities.UI;
using Quicker.View.Actions.ActionHistoryControls;

namespace Quicker.View;

public class ActionHistoryWindow : Window, IComponentConnector
{
	private readonly SQLDataMgr RvdgQdgRDyY;

	private readonly string s1IgQoNP6ci;

	[CompilerGenerated]
	private ActionItem nUvgQTMfPuu;

	internal LocalBackupItemsControl LocalBackupItemsControl;

	internal NetworkManualBackupItemsControl NetworkManualBackupItemsControl;

	internal NetworkAutoBackupItemsControl NetworkAutoBackupItemsControl;

	private bool NEJgQMip6TF;

	private static ActionHistoryWindow cLf4DHQzY345p2uur1nW;

	public ActionItem RestoreItem
	{
		[CompilerGenerated]
		get
		{
			return nUvgQTMfPuu;
		}
		[CompilerGenerated]
		private set
		{
			nUvgQTMfPuu = value;
		}
	}

	public ActionHistoryWindow(SQLDataMgr sqlDataMgr, string actionId)
	{
		RvdgQdgRDyY = sqlDataMgr;
		s1IgQoNP6ci = actionId;
		InitializeComponent();
		base.Loaded += XAkgQ568w0p;
		NetworkManualBackupItemsControl.ActionId = actionId;
		NetworkAutoBackupItemsControl.ActionId = actionId;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void XAkgQ568w0p(object sender, RoutedEventArgs e)
	{
		LocalBackupItemsControl.Load(RvdgQdgRDyY, s1IgQoNP6ci);
	}

	public void SelectItem(ActionItem restoredItem)
	{
		RestoreItem = restoredItem;
		base.DialogResult = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!NEJgQMip6TF)
		{
			NEJgQMip6TF = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/actions/actionhistorywindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			NEJgQMip6TF = true;
			break;
		case 1:
			LocalBackupItemsControl = (LocalBackupItemsControl)target;
			break;
		case 2:
			NetworkManualBackupItemsControl = (NetworkManualBackupItemsControl)target;
			break;
		case 3:
			NetworkAutoBackupItemsControl = (NetworkAutoBackupItemsControl)target;
			break;
		}
	}

	static ActionHistoryWindow()
	{
	}

	internal static bool r9ZrE0Qz8mUqGpefyuqQ()
	{
		return cLf4DHQzY345p2uur1nW == null;
	}

	internal static void rZXOxVQzMwrBww0Ze4Xs()
	{
	}
}
