using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Public.Extensions;

namespace Quicker.View.Controls;

public class ActionListItemControl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty ActionIdOrNameProperty;

	internal IconControl IconControl;

	internal TextBlock TxtLabel;

	private bool vCMLK22jC95;

	private static ActionListItemControl RxjXkOFL7kvMOmcpSHEq;

	public string ActionIdOrName
	{
		get
		{
			return (string)GetValue(ActionIdOrNameProperty);
		}
		set
		{
			SetValue(ActionIdOrNameProperty, value);
		}
	}

	public ActionListItemControl()
	{
		InitializeComponent();
	}

	private static void dm8LKSrra4w(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		(dependencyObject_0 as ActionListItemControl)?.UpdateIconInfo();
	}

	public void UpdateIconInfo()
	{
		(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(ActionIdOrName);
		if (tuple.Item1 != null)
		{
			IconControl.Icon = tuple.Item1.Icon;
			TxtLabel.Text = tuple.Item1.Title;
			int num = 0;
			if (RxjXkOFL7kvMOmcpSHEq != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			base.ToolTip = tuple.Item1.Description.OrNull();
		}
		else
		{
			IconControl.Icon = "";
			TxtLabel.Text = ActionIdOrName;
		}
		IconControl.Visibility = ((!IconControl.HasIcon) ? Visibility.Collapsed : Visibility.Visible);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!vCMLK22jC95)
		{
			vCMLK22jC95 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/actionlistitemcontrol.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			vCMLK22jC95 = true;
			break;
		case 2:
			TxtLabel = (TextBlock)target;
			break;
		case 1:
			IconControl = (IconControl)target;
			break;
		}
	}

	static ActionListItemControl()
	{
		ActionIdOrNameProperty = DependencyProperty.Register("ActionIdOrName", typeof(string), typeof(ActionListItemControl), new PropertyMetadata(null, dm8LKSrra4w));
	}

	internal static void xoTPtcFLHrsU5Zk9WiGq()
	{
	}

	internal static bool SyJgWSFL4FHklrpew9dV()
	{
		return RxjXkOFL7kvMOmcpSHEq == null;
	}
}
