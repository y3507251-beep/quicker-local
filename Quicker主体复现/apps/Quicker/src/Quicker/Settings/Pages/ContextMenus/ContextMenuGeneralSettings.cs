using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Common.Entities;

namespace Quicker.Settings.Pages.ContextMenus;

public class ContextMenuGeneralSettings : SettingPage, IComponentConnector
{
	internal ToggleButton ToggleEnableCtrlLongCTrigger;

	internal NumericUpDown TxtTriggerInterval;

	internal ToggleButton ToggleEnableLongPressRightButton;

	private bool jiV49Ddijb;

	private static ContextMenuGeneralSettings a7Rjx8Tgk7yYm93jHaL;

	public ContextMenuGeneralSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ContextMenuSettings contextMenuSettings = settings.ContextMenuSettings ?? new ContextMenuSettings();
		ToggleEnableCtrlLongCTrigger.IsChecked = contextMenuSettings.EnableControlLongCTrigger;
		TxtTriggerInterval.Value = contextMenuSettings.TriggerIntervalMs;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		ContextMenuSettings contextMenuSettings = settings.ContextMenuSettings ?? new ContextMenuSettings();
		contextMenuSettings.EnableControlLongCTrigger = ToggleEnableCtrlLongCTrigger.IsChecked == true;
		contextMenuSettings.TriggerIntervalMs = (int)TxtTriggerInterval.Value;
		settings.ContextMenuSettings = contextMenuSettings;
		return true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!jiV49Ddijb)
		{
			jiV49Ddijb = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/contextmenus/contextmenugeneralsettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			jiV49Ddijb = true;
			break;
		case 1:
			ToggleEnableCtrlLongCTrigger = (ToggleButton)target;
			break;
		case 2:
			TxtTriggerInterval = (NumericUpDown)target;
			break;
		case 3:
			ToggleEnableLongPressRightButton = (ToggleButton)target;
			break;
		}
	}

	internal static bool loeF90TPWoxByXcP7QJ()
	{
		return a7Rjx8Tgk7yYm93jHaL == null;
	}
}
