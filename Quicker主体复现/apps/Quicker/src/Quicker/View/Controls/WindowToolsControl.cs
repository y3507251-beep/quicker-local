using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.View.Controls;

public class WindowToolsControl : UserControl, IComponentConnector
{
	private bool v0aLp4XG7e1;

	private static WindowToolsControl aHswRFFfXSoUAofcRGP3;

	public WindowToolsControl()
	{
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!v0aLp4XG7e1)
		{
			v0aLp4XG7e1 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/windowtoolscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		v0aLp4XG7e1 = true;
	}

	internal static bool XsKIhBFf2e4my2REaPOC()
	{
		return aHswRFFfXSoUAofcRGP3 == null;
	}
}
