using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using ViNASxihuuLY1Gg9m6p;
using WpfAppBar;

namespace Quicker.Modules.AppBar;

public class AppBarWindow : WpfAppBar.AppBarWindow, IComponentConnector
{
	private bool V4UA30giDZ;

	internal static AppBarWindow U1NRt9HP9Pkk94N9tuk;

	public AppBarWindow()
	{
		InitializeComponent();
		base.SourceInitialized += vvXAiOtlIS;
	}

	private void vvXAiOtlIS(object sender, EventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.GWHvvUGmjWL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!V4UA30giDZ)
		{
			V4UA30giDZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/appbar/appbarwindow.xaml", UriKind.Relative);
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
		V4UA30giDZ = true;
	}

	internal static bool RjQygeHMTUpbWl8wFwK()
	{
		return U1NRt9HP9Pkk94N9tuk == null;
	}
}
