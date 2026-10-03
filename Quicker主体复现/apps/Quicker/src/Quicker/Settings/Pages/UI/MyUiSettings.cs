using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Settings.Pages.UI;

public class MyUiSettings : UserControl, IComponentConnector
{
	private bool s7A4StRfi7;

	internal static MyUiSettings k606DGT3GKFnVLdfHLG;

	public MyUiSettings()
	{
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!s7A4StRfi7)
		{
			s7A4StRfi7 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/ui/myuisettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		s7A4StRfi7 = true;
	}

	static MyUiSettings()
	{
	}

	internal static bool HOaxVdTEvSTBrsrV45g()
	{
		return k606DGT3GKFnVLdfHLG == null;
	}

	internal static void TVlU5AT1P2uV3FjLJiO()
	{
	}
}
