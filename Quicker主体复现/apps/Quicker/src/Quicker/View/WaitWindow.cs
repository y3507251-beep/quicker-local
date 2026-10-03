using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class WaitWindow : Window, IComponentConnector
{
	internal TextBlock LblInfo;

	private bool PMDgz41Ie0o;

	internal static WaitWindow cjyAcVFXdHE100BpZaSq;

	public string InfoText
	{
		get
		{
			return LblInfo.Text;
		}
		set
		{
			LblInfo.Text = value;
		}
	}

	public WaitWindow()
	{
		InitializeComponent();
		base.Loaded += U2ZgznFp4kp;
	}

	private void U2ZgznFp4kp(object sender, RoutedEventArgs e)
	{
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new FakeWindowsPeer(this);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!PMDgz41Ie0o)
		{
			PMDgz41Ie0o = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/waitwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			LblInfo = (TextBlock)target;
		}
		else
		{
			PMDgz41Ie0o = true;
		}
	}

	internal static bool QXk2daFXOMJ8kLsqLZRp()
	{
		return cjyAcVFXdHE100BpZaSq == null;
	}
}
