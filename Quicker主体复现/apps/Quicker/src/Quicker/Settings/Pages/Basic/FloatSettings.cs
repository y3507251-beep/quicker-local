using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Quicker.Common.Entities;

namespace Quicker.Settings.Pages.Basic;

public class FloatSettings : SettingPage, IComponentConnector
{
	internal ToggleButton ChkLoadFloatButtonState;

	internal ToggleButton ChkFloatButtonBindProcessByDefault;

	internal ToggleButton ChkShowTextFloatPanel;

	private bool hMCT42T1gB;

	internal static FloatSettings pkCxKA4euD179VJH0I0;

	public FloatSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ChkFloatButtonBindProcessByDefault.IsChecked = settings.FloatButtonBindProcessByDefault;
		ChkLoadFloatButtonState.IsChecked = settings.LoadFloatButtonState;
		ChkShowTextFloatPanel.IsChecked = settings.EnableTextFloatingPanel;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.FloatButtonBindProcessByDefault = ChkFloatButtonBindProcessByDefault.IsChecked == true;
		settings.LoadFloatButtonState = ChkLoadFloatButtonState.IsChecked == true;
		settings.EnableTextFloatingPanel = ChkShowTextFloatPanel.IsChecked == true;
		return true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!hMCT42T1gB)
		{
			hMCT42T1gB = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/floatsettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			hMCT42T1gB = true;
			break;
		case 1:
			ChkLoadFloatButtonState = (ToggleButton)target;
			break;
		case 2:
			ChkFloatButtonBindProcessByDefault = (ToggleButton)target;
			break;
		case 3:
			ChkShowTextFloatPanel = (ToggleButton)target;
			break;
		}
	}

	internal static bool zsSMqP4jwcu8mQaDmuA()
	{
		return pkCxKA4euD179VJH0I0 == null;
	}
}
