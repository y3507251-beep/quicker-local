using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain.PowerMouse;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Basic;

public class QuickScreenCaptureSettings : SettingPage, IComponentConnector
{
	internal ToggleButton ChkEnable;

	internal HotkeyEditorControl AdornKeyEditor;

	internal ComboBox CbTrigger;

	internal ToggleButton ChkPinImage;

	internal ToggleButton ChkShowMenu;

	internal ToggleButton ChkAutoCopy;

	internal ToggleButton ChkAutoSave;

	internal ActionSelector AutoRunActionSelector;

	private bool XSbTl6GaDp;

	internal static QuickScreenCaptureSettings ebbAPG4bb3VBudO1Fmh;

	public QuickScreenCaptureSettings()
	{
		InitializeComponent();
		CbTrigger.ItemsSource = new List<KeyButtonCombination>
		{
			KeyButtonCombination.NA,
			KeyButtonCombination.Middle,
			KeyButtonCombination.Right,
			KeyButtonCombination.X1,
			KeyButtonCombination.X2
		};
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ScreenShotSettings screenShotSettings = settings.ScreenShotSettings ?? new ScreenShotSettings();
		ChkEnable.IsChecked = screenShotSettings.IsEnabled;
		CbTrigger.SelectedItem = (KeyButtonCombination)screenShotSettings.Trigger;
		AdornKeyEditor.Hotkey = ((screenShotSettings.AdornKey > 0) ? new Hotkey((VirtualKeyCode)screenShotSettings.AdornKey.Value, ModifierKeys.None) : null);
		ChkPinImage.IsChecked = screenShotSettings.PinImage;
		ChkAutoCopy.IsChecked = screenShotSettings.AutoCopy;
		ChkShowMenu.IsChecked = screenShotSettings.AutoShowMenu;
		int num = 0;
		if (!MVZQgM4qqnkWCJqvKT1())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ChkAutoSave.IsChecked = screenShotSettings.AutoSave;
		AutoRunActionSelector.ActionIdOrName = screenShotSettings.AutoRunAction;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.ScreenShotSettings = new ScreenShotSettings
		{
			IsEnabled = (ChkEnable.IsChecked == true),
			Trigger = (int)CbTrigger.SelectedItem,
			AdornKey = ((AdornKeyEditor.Hotkey == null) ? ((int?)null) : new int?((int)AdornKeyEditor.Hotkey.Key)),
			AutoCopy = (ChkAutoCopy.IsChecked == true),
			AutoSave = (ChkAutoSave.IsChecked == true),
			PinImage = (ChkPinImage.IsChecked == true),
			AutoRunAction = AutoRunActionSelector.ActionIdOrName,
			AutoShowMenu = (ChkShowMenu.IsChecked == true)
		};
		return true;
	}

	private void AdornKeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!XSbTl6GaDp)
		{
			XSbTl6GaDp = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/quickscreencapturesettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			XSbTl6GaDp = true;
			break;
		case 1:
			ChkEnable = (ToggleButton)target;
			if (MVZQgM4qqnkWCJqvKT1())
			{
				switch (0)
				{
				}
			}
			break;
		case 2:
			AdornKeyEditor = (HotkeyEditorControl)target;
			break;
		case 3:
			CbTrigger = (ComboBox)target;
			break;
		case 4:
			ChkPinImage = (ToggleButton)target;
			break;
		case 5:
			ChkShowMenu = (ToggleButton)target;
			break;
		case 6:
			ChkAutoCopy = (ToggleButton)target;
			break;
		case 7:
			ChkAutoSave = (ToggleButton)target;
			break;
		case 8:
			AutoRunActionSelector = (ActionSelector)target;
			break;
		}
	}

	internal static bool MVZQgM4qqnkWCJqvKT1()
	{
		return ebbAPG4bb3VBudO1Fmh == null;
	}
}
