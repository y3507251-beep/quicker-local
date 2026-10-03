using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Settings.Pages.UI;

public class UiAutoSwitchSettings : UserControl, IComponentConnector
{
	private bool vNv42Ppmic;

	private static UiAutoSwitchSettings QI5D6STK4daxAlo6s6I;

	public UiAutoSwitchSettings()
	{
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!vNv42Ppmic)
		{
			vNv42Ppmic = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/ui/uiautoswitchsettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		vNv42Ppmic = true;
	}

	internal static bool dk2IB4TBcoJji0Hj5KM()
	{
		return QI5D6STK4daxAlo6s6I == null;
	}
}
