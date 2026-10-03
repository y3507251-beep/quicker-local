using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Modules.Wizard.Steps;

public class PanelSettingsStep : UserControl, IComponentConnector
{
	private bool XTHOki4yF0;

	private static PanelSettingsStep CZfjIOzeR3ng2Ab2nGw;

	public PanelSettingsStep()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!XTHOki4yF0)
		{
			XTHOki4yF0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/wizard/steps/panelsettingsstep.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		XTHOki4yF0 = true;
	}

	internal static bool VcAuXSzjo1Th9WlEJdS()
	{
		return CZfjIOzeR3ng2Ab2nGw == null;
	}
}
