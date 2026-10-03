using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Settings.Pages.Tools;

public class AdvancedSettingsPage : UserControl, IComponentConnector
{
	private bool fJ146SXEGS;

	internal static AdvancedSettingsPage ySlClLmVTpa9dLHkZ5m;

	public AdvancedSettingsPage()
	{
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!fJ146SXEGS)
		{
			fJ146SXEGS = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/tools/advancedsettingspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		fJ146SXEGS = true;
	}

	internal static bool KH9EdomQKuIv7ycDu2L()
	{
		return ySlClLmVTpa9dLHkZ5m == null;
	}
}
