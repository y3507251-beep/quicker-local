using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Settings.Pages.Basic;

public class PushServiceSettings : UserControl, IComponentConnector
{
	private bool njQTUJqHca;

	internal static PushServiceSettings W5LWIa4ux08SkEF9m4b;

	public PushServiceSettings()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!njQTUJqHca)
		{
			njQTUJqHca = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/pushservicesettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		njQTUJqHca = true;
	}

	internal static bool dN0Ubh4oiaETRhBEAUL()
	{
		return W5LWIa4ux08SkEF9m4b == null;
	}
}
