using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.View;

public class FollowWeiXin : Window, IComponentConnector
{
	private bool BHrgihq90io;

	internal static FollowWeiXin Mxlx84FpQ18BPqsB7cXa;

	public FollowWeiXin()
	{
		InitializeComponent();
	}

	private void DWCgi9upIXq(object sender, RoutedEventArgs e)
	{
		base.DialogResult = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!BHrgihq90io)
		{
			BHrgihq90io = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/account/followweixin.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			((Button)target).Click += DWCgi9upIXq;
		}
		else
		{
			BHrgihq90io = true;
		}
	}

	internal static bool wYj4hxFpFjN2c2Ztvvdo()
	{
		return Mxlx84FpQ18BPqsB7cXa == null;
	}
}
