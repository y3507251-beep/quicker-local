using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Common.Entities;

namespace Quicker.Settings.Pages.Tools;

public class PowerKeysSettingsPage : SettingPage, IComponentConnector
{
	internal NumericUpDown TxtDelayBeforeCtrlKey;

	internal NumericUpDown TxtContinuousInputCheckTime;

	internal NumericUpDown TxtHintWindowDelay;

	internal NumericUpDown TxtCancelLongPressKeyDelayMs;

	internal CheckBox ChkIgnoreAllInjectedKeys;

	internal CheckBox ChkIgnoreUnknownKeys;

	internal CheckBox ChkAllowLeftSysKeys;

	private bool r0qDSABWFd;

	internal static PowerKeysSettingsPage XmL0FkmPNnM2bTMmp6q;

	public PowerKeysSettingsPage()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings userSettings)
	{
		TxtDelayBeforeCtrlKey.Value = userSettings.PowerKeys_DelayBeforeCtrlKey;
		TxtContinuousInputCheckTime.Value = userSettings.PowerKeys_ContinuousInputCheckTime;
		TxtHintWindowDelay.Value = userSettings.PowerKeys_HintWindowDelay;
		TxtCancelLongPressKeyDelayMs.Value = userSettings.PowerKeys_CancelLongPressKeyDelayMs;
		ChkIgnoreAllInjectedKeys.IsChecked = userSettings.PowerKeys_IgnoreAllInjectedKeys;
		ChkIgnoreUnknownKeys.IsChecked = userSettings.PowerKeys_IgnoreUnknownKey;
		ChkAllowLeftSysKeys.IsChecked = userSettings.PowerKeys_AllowLeftSysKeys;
	}

	protected override bool SaveDataFromUi(UserSettings userSettings)
	{
		userSettings.PowerKeys_DelayBeforeCtrlKey = (int)TxtDelayBeforeCtrlKey.Value;
		userSettings.PowerKeys_ContinuousInputCheckTime = (int)TxtContinuousInputCheckTime.Value;
		userSettings.PowerKeys_HintWindowDelay = (int)TxtHintWindowDelay.Value;
		userSettings.PowerKeys_CancelLongPressKeyDelayMs = (int)TxtCancelLongPressKeyDelayMs.Value;
		userSettings.PowerKeys_IgnoreAllInjectedKeys = ChkIgnoreAllInjectedKeys.IsChecked == true;
		userSettings.PowerKeys_IgnoreUnknownKey = ChkIgnoreUnknownKeys.IsChecked == true;
		userSettings.PowerKeys_AllowLeftSysKeys = ChkAllowLeftSysKeys.IsChecked == true;
		return true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!r0qDSABWFd)
		{
			r0qDSABWFd = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/powerkeyssettingspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			r0qDSABWFd = true;
			break;
		case 1:
			TxtDelayBeforeCtrlKey = (NumericUpDown)target;
			break;
		case 2:
			TxtContinuousInputCheckTime = (NumericUpDown)target;
			break;
		case 3:
		{
			TxtHintWindowDelay = (NumericUpDown)target;
			int num = 0;
			if (!rTaEMdmMjaWlorWfUqv())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 4:
			TxtCancelLongPressKeyDelayMs = (NumericUpDown)target;
			break;
		case 5:
			ChkIgnoreAllInjectedKeys = (CheckBox)target;
			break;
		case 6:
			ChkIgnoreUnknownKeys = (CheckBox)target;
			break;
		case 7:
			ChkAllowLeftSysKeys = (CheckBox)target;
			break;
		}
	}

	static PowerKeysSettingsPage()
	{
	}

	internal static void DTSwgqmxuGjNT6w2qdP()
	{
	}

	internal static bool rTaEMdmMjaWlorWfUqv()
	{
		return XmL0FkmPNnM2bTMmp6q == null;
	}

	internal static void FhindxmtnjsO4sDVLed()
	{
	}
}
