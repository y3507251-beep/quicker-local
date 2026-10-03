using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Hotkeys;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;

namespace Quicker.Settings.Pages.Basic;

public class FunctionHotkeySettings : SettingPage, IComponentConnector
{
	private IList<SelectionItem> cyOTolMelP = new SmartCollection<SelectionItem>
	{
		new SelectionItem(0.ToString(), "保留所有快捷键"),
		new SelectionItem(1.ToString(), "仅保留 暂停/恢复 快捷键"),
		new SelectionItem(2.ToString(), "清除所有快捷键")
	};

	private bool p33TTZbZbO;

	internal HotkeyEditorControl HotkeyEditorForCancelRunningActions;

	internal TextBlock LblWarningForCancelRunningHotkey;

	internal HotkeyEditorControl HotkeyEditorForPausePopup;

	internal HotkeyEditorControl HotkeyEditorForSearch;

	internal HotkeyEditorControl HotkeyEditorForOpenConfig;

	internal HotkeyEditorControl HotkeyEditorForExeSettings;

	internal HotkeyEditorControl HotkeyEditorForRepeatLast;

	internal HotkeyEditorControl HotkeyEditorForDashboardWindow;

	internal HotkeyEditorControl HotkeyEditorForCloseFloatingActions;

	internal HotkeyEditorControl HotkeyEditorForReinstallMouseHook;

	internal HotkeyEditorControl HotkeyEditorForToggleTextFloatPanel;

	internal HotkeyEditorControl HotkeyEditorForAppStartVoiceInput;

	internal SelectionItemComboBox CbHotkeyModeAfterPause;

	private bool QFcTMRWksw;

	internal static FunctionHotkeySettings oglOkY4E9oHfafUoJx1;

	public FunctionHotkeySettings()
	{
		InitializeComponent();
		base.Loaded += ij1T52pAV2;
		CbHotkeyModeAfterPause.ItemSource = cyOTolMelP;
	}

	private void ij1T52pAV2(object sender, RoutedEventArgs e)
	{
		DebugHelper.LogExecuteTime(IVvTdIMSup, "Load耗时");
		p33TTZbZbO = true;
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		CbHotkeyModeAfterPause.SelectedValue = ((int)settings.HotkeyModeAfterPause).ToString();
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.HotkeyModeAfterPause = (HotkeyModeAfterPause)Enum.ToObject(typeof(HotkeyModeAfterPause), Convert.ToInt32(CbHotkeyModeAfterPause.SelectedValue.Or("0")));
		return true;
	}

	private void OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
		if (!p33TTZbZbO)
		{
			return;
		}
		HotKeySettings hotKeySettings = HotKeySettings.FromData(AppState.DataService.CpItmVISR7P().HotKeysData);
		hotKeySettings.KeysForPausePopup = HotkeyEditorForPausePopup.GetKeyData();
		hotKeySettings.KeysForAppStartVoiceInput = HotkeyEditorForAppStartVoiceInput.GetKeyData();
		hotKeySettings.KeysForCancelRunningTasks = HotkeyEditorForCancelRunningActions.GetKeyData();
		hotKeySettings.KeysForCloseAllFloatButtons = HotkeyEditorForCloseFloatingActions.GetKeyData();
		int num = 1;
		if (exqqrp4GHg9HyCEZ1y6())
		{
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					hotKeySettings.KeysForReloadMouseHook = HotkeyEditorForReinstallMouseHook.GetKeyData();
					hotKeySettings.KeysForSearch = HotkeyEditorForSearch.GetKeyData();
					hotKeySettings.KeysForRepeatLast = HotkeyEditorForRepeatLast.GetKeyData();
					hotKeySettings.KeysForDashboardWindow = HotkeyEditorForDashboardWindow.GetKeyData();
					hotKeySettings.KeysForToggleTextFloatWindow = HotkeyEditorForToggleTextFloatPanel.GetKeyData();
					hotKeySettings.KeysForOpenSettings = HotkeyEditorForOpenConfig.GetKeyData();
					hotKeySettings.KeysForExeSettings = HotkeyEditorForExeSettings.GetKeyData();
					AppState.DataService.CpItmVISR7P().HotKeysData = hotKeySettings.ToData();
					AppState.DataService.ydot6rVZAkW();
					num = 0;
					if (oglOkY4E9oHfafUoJx1 != null)
					{
						num = num2;
					}
					continue;
				}
				break;
			}
		}
		AppState.aXRtadMEfsj().c8ptp8hF7GY();
		if (sender is HotkeyEditorControl hotkeyEditorControl)
		{
			hotkeyEditorControl.UpdateValidState();
		}
		bpqTDm6LA9();
	}

	private void bpqTDm6LA9()
	{
		LblWarningForCancelRunningHotkey.Visibility = ((!string.IsNullOrEmpty(HotkeyEditorForCancelRunningActions.GetKeyData())) ? Visibility.Collapsed : Visibility.Visible);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!QFcTMRWksw)
		{
			QFcTMRWksw = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/functionhotkeysettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
			QFcTMRWksw = true;
			break;
		case 1:
			HotkeyEditorForCancelRunningActions = (HotkeyEditorControl)target;
			break;
		case 2:
			LblWarningForCancelRunningHotkey = (TextBlock)target;
			break;
		case 3:
			HotkeyEditorForPausePopup = (HotkeyEditorControl)target;
			break;
		case 4:
			HotkeyEditorForSearch = (HotkeyEditorControl)target;
			break;
		case 5:
			HotkeyEditorForOpenConfig = (HotkeyEditorControl)target;
			break;
		case 6:
			HotkeyEditorForExeSettings = (HotkeyEditorControl)target;
			break;
		case 7:
			HotkeyEditorForRepeatLast = (HotkeyEditorControl)target;
			break;
		case 8:
			HotkeyEditorForDashboardWindow = (HotkeyEditorControl)target;
			break;
		case 9:
			HotkeyEditorForCloseFloatingActions = (HotkeyEditorControl)target;
			break;
		case 10:
			HotkeyEditorForReinstallMouseHook = (HotkeyEditorControl)target;
			break;
		case 11:
			HotkeyEditorForToggleTextFloatPanel = (HotkeyEditorControl)target;
			break;
		case 12:
			HotkeyEditorForAppStartVoiceInput = (HotkeyEditorControl)target;
			break;
		case 13:
		{
			CbHotkeyModeAfterPause = (SelectionItemComboBox)target;
			int num = 0;
			if (!exqqrp4GHg9HyCEZ1y6())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
	}

	[CompilerGenerated]
	private void IVvTdIMSup()
	{
		HotKeySettings hotKeySettings = HotKeySettings.FromData(AppState.DataService.CpItmVISR7P().HotKeysData);
		HotkeyEditorForPausePopup.SetData(hotKeySettings.KeysForPausePopup, true);
		HotkeyEditorForAppStartVoiceInput.SetData(hotKeySettings.KeysForAppStartVoiceInput, true);
		HotkeyEditorForCancelRunningActions.SetData(hotKeySettings.KeysForCancelRunningTasks, true);
		HotkeyEditorForCloseFloatingActions.SetData(hotKeySettings.KeysForCloseAllFloatButtons, true);
		HotkeyEditorForReinstallMouseHook.SetData(hotKeySettings.KeysForReloadMouseHook, true);
		HotkeyEditorForSearch.SetData(hotKeySettings.KeysForSearch, true);
		HotkeyEditorForRepeatLast.SetData(hotKeySettings.KeysForRepeatLast, true);
		HotkeyEditorForDashboardWindow.SetData(hotKeySettings.KeysForDashboardWindow, true);
		HotkeyEditorForToggleTextFloatPanel.SetData(hotKeySettings.KeysForToggleTextFloatWindow, true);
		HotkeyEditorForOpenConfig.SetData(hotKeySettings.KeysForOpenSettings, true);
		if (exqqrp4GHg9HyCEZ1y6())
		{
			switch (0)
			{
			}
		}
		HotkeyEditorForExeSettings.SetData(hotKeySettings.KeysForExeSettings, true);
		bpqTDm6LA9();
	}

	static FunctionHotkeySettings()
	{
	}

	internal static bool exqqrp4GHg9HyCEZ1y6()
	{
		return oglOkY4E9oHfafUoJx1 == null;
	}

	internal static void tWCVZ84O4jFDbHMcVq9()
	{
	}
}
