using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Modules.Wizard.Steps;

public class FunctionHotkeysStep : UserControl, IComponentConnector
{
	private bool mJ7OWHPs8v;

	private static FunctionHotkeysStep caJGyHz2l08brae0PfW;

	public FunctionHotkeysStep()
	{
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!mJ7OWHPs8v)
		{
			mJ7OWHPs8v = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/wizard/steps/functionhotkeysstep.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		mJ7OWHPs8v = true;
	}

	internal static bool IR4e3BzAH8kThygLAix()
	{
		return caJGyHz2l08brae0PfW == null;
	}
}
