using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quicker.Common.QuickActions;

namespace Quicker.Common.Entities;

public class UserSettings
{
	public string StartupTipText = "";

	public bool EnableExternScreenCapture;

	private UiSettings _uiSettings;

	public string GestureValidColor = "#FF00BFFF";

	public string GestureInvalidColor = "#FF808080";

	public bool ShowStartupTip { get; set; } = true;

	public bool IsAppEnabled { get; set; }

	public string ConnectionCode { get; set; } = "quicker";

	public bool ShowVoiceInputButtonOnTitleBar { get; set; }

	public int Port { get; set; } = 666;

	public bool IsAutoMinimize { get; set; }

	public bool RecvImageCopyToClipboard { get; set; } = true;

	public bool RecvImagePasteToWindow { get; set; }

	public bool RecvImageOpenFolder { get; set; } = true;

	public bool RecvImageOpenWithDefaultProgram { get; set; }

	public string RecvImageOpenWithProgram { get; set; }

	public string RecvFileFolder { get; set; }

	public bool ShowRunningCountOnTrayIcon { get; set; }

	public bool OpenPopWithMiddleClick { get; set; } = true;

	public bool OpenPopWithXButton1Click { get; set; }

	public bool OpenPopWithXButton2Click { get; set; }

	public bool OpenPopWithCtrlMiddleClick { get; set; }

	public bool OpenPopWithCtrlClick { get; set; }

	public bool OpenPopWithCtrlRightClick { get; set; }

	public bool OpenPopWithLongRightPress { get; set; } = true;

	public bool OpenPopWithLongMiddlePress { get; set; }

	public bool OpenPopWithRightPressMove { get; set; }

	public bool DisableAutoSwitchAfterPopup { get; set; }

	[Obsolete]
	public bool EnableCircleMenu { get; set; } = true;

	public int RightBtnPopupDelayMs { get; set; } = 200;

	public int MoveTriggerDistance { get; set; } = 5;

	public int DoubleClickInterval { get; set; } = 250;

	public bool EnableReleaseOnButtonTrigger { get; set; } = true;

	public bool OpenPopWithWheelLeft { get; set; }

	public string OpenWithGlobalHotkey { get; set; }

	public IList<SpecialExeItem> SpecialExeList { get; set; }

	[JsonProperty("ToMousePosWhenOpenByKeyboard")]
	public PopupLocationType ToMousePosWhenOpenByKeyboard { get; set; }

	public bool DisableOnFullscreenApp { get; set; }

	public string AllowedFullscreenProcesses { get; set; }

	public bool ActiveCursorPositionWindowWhenPopupWithKeyboard { get; set; } = true;

	public bool KeepActionLocalIconAndName { get; set; }

	public bool RememberLastConfigPage { get; set; }

	public bool EnableUiAutomation { get; set; }

	[Obsolete("不再切换大小写功能")]
	public bool ReplaceCapsToCtrlSpace { get; set; }

	public string RemapKeyCapsLock { get; set; }

	public string RemapKeyPauseBreak { get; set; }

	public string RemapKeyPrintScreen { get; set; }


	[Obsolete("不再支持切换桌面功能")]
	public bool EnableSwitchDesk { get; set; } = true;

	[Obsolete("不再支持切换桌面功能")]
	public bool EnableSwitchDeskOnScreenBottom { get; set; } = true;

	public bool EnableChangeVolume { get; set; }

	public bool EnableChangeVolumeOnScreenBottom { get; set; }

	public string ExternScreenCaptureHotkey { get; set; }

	public bool EnableAdjScreenBrightnessUseCtrlScroll { get; set; }

	public bool EnableSwitchVirtualDeskUseX1HScroll { get; set; }

	public bool EnableReverseVScroll { get; set; }

	public string CornerActionTopLeft { get; set; }

	public string CornerActionTopRight { get; set; }

	public string CornerActionBottomLeft { get; set; }

	public string CornerActionBottomRight { get; set; }

	public int CornerActionDelay { get; set; }

	[Obsolete]
	public bool CopyOrPasteWithLeftPlusRight { get; set; }

	[Obsolete]
	public bool ShowMessageAfterCopyPaste { get; set; }

	[Obsolete]
	public bool PasteWithLeftPlusX { get; set; }

	public UiSettings UiSettings
	{
		get
		{
			if (_uiSettings == null)
			{
				_uiSettings = new UiSettings();
			}
			return _uiSettings;
		}
		set
		{
			_uiSettings = value;
		}
	}

	public bool SwitchUiSettingsBasedOnTheme { get; set; }

	public UiSettings DarkUiSettings { get; set; }

	[Obsolete]
	public bool EnablePinFunc { get; set; }

	[Obsolete]
	public bool ShowCopyPasteButton { get; set; } = true;

	[Obsolete]
	public bool ShowLockProfileButton { get; set; } = true;

	public bool ShowMenuWhenLeftClickEmptyButton { get; set; } = true;

	public bool HideContextProcessIcon { get; set; }

	public bool HidePanelToolTip { get; set; }

	public bool EnableTextCommand { get; set; }

	public bool TextCommandTriggerAfterDelimiter { get; set; } = true;

	public string TextCommandDelimiterChars { get; set; } = " \t\n;";

	public int? TextCommandTriggerKey { get; set; }

	public bool TextCommandAutoDisableIme { get; set; } = true;

	public string TextCommandBlackList { get; set; }

	public IDictionary<int, int> KeyTriggers { get; set; }

	public string HotKeysData { get; set; }

	public bool OpenPopupWithCircle { get; set; }

	[Obsolete("不再支持画Z激活")]
	public bool OpenPopupWithZ { get; set; }

	[Obsolete]
	public bool AutoFreeMemory { get; set; }

	[Obsolete("AutoRunTaskList")]
	public string AutoRunTasks { get; set; }

	public IList<AutoRunTask> AutoRunTaskList { get; set; }

	public IList<CommonTriggerTask> TriggerTasks { get; set; }

	public bool EnableKeyTriggerWhenPopupByMouse { get; set; }

	public bool EnableTextFloatingPanel { get; set; }

	public bool EnableCyclePaging { get; set; }

	public int CircleMenuTrigger { get; set; }

	public int GestureTrigger { get; set; }

	public bool GestureHideTrack { get; set; }

	public float GestureMinScore { get; set; } = 80f;

	public bool ActivateGestureStartPositionWindow { get; set; } = true;

	public double GestureStrokeThickness { get; set; } = 2.0;

	public bool GestureEnableHideEffect { get; set; }

	public bool GestureShowActionName { get; set; } = true;

	public bool GestureShowActionNameAtFixedPosition { get; set; }

	public bool GestureEnableMouseEffect { get; set; }

	public int GestureHintListDelayMs { get; set; } = 1200;

	public bool GestureEnableTriggerByKey { get; set; }

	public bool GesturePlaybackUnknownGesture { get; set; }

	public int GestureRepeatKey { get; set; }

	public double CircleMenuSize { get; set; } = 420.0;

	public double CircleMenuFontSize { get; set; } = 11.0;

	public int CirclemMenuCircle2ActionCount { get; set; } = 8;

	public bool CircleMenuHideLabelIfHaveIcon { get; set; }

	public bool CircleMenuShowLabelInCenterWhenHideLabel { get; set; }

	public bool CircleMenuLimitInScreen { get; set; } = true;

	public bool CircleMenuAutoMoveCursor { get; set; } = true;

	public bool CircleMenuShowExternalWhenPopup { get; set; } = true;

	public int CircleMenuRepeatKey { get; set; }

	public int CircleMenuTimeoutMs { get; set; } = 20000;

	public string CtrlInsertProcesses { get; set; } = "cmd";

	// 本地版不提示服务器上的动作新版本；导入旧设置也保持关闭。
	public bool ShowActionNewVersionTip
	{
		get => false;
		set { }
	}

	public bool ShowNewExeSettingTips { get; set; } = true;

	public bool EnableHookDetector { get; set; }

	public bool RestoreOriginEventIfMouseDownTimeout { get; set; } = true;

	public int TrayIconType { get; set; }

	public IList<QuickRunItem> QuickRunItems { get; set; }

	public bool LoadFloatButtonState { get; set; }

	public bool FloatButtonBindProcessByDefault { get; set; }

	public bool FloatUseLeftButtonOnPanel { get; set; }

	public bool DisableMiddleClickCloseFloat { get; set; }

	public int FixFloatButtonSize { get; set; }

	public int PowerKeys_DelayBeforeCtrlKey { get; set; } = 500;

	public int PowerKeys_ContinuousInputCheckTime { get; set; } = 100;

	public int PowerKeys_HintWindowDelay { get; set; } = 2000;

	public int PowerKeys_CancelLongPressKeyDelayMs { get; set; } = 1500;

	public bool PowerKeys_IgnoreAllInjectedKeys { get; set; } = true;

	public bool PowerKeys_IgnoreUnknownKey { get; set; }

	public bool PowerKeys_AllowLeftSysKeys { get; set; }

	public bool PowerKeys_EnableBlackList { get; set; }

	public bool PowerKeys_AutoResetKeyboardState { get; set; }

	public string DefaultBrowser { get; set; } = "chrome";

	public bool EnableBrowserContextMenu { get; set; } = true;

	public bool EnableWebPageActions { get; set; } = true;

	public bool EnableWebPageActionsForActionPage { get; set; } = true;

	public bool TryUseUIAutomationGetSelectedText { get; set; }

	public bool EnableLeftButtonPlus { get; set; }

	public int LeftButtonLongPressExpireTime { get; set; } = 1000;

	public string LeftButtonPlusBlackList { get; set; }

	public IList<PowerKeyActionItem> LeftButtonPlusActions { get; set; }

	public IList<PowerKeyActionItem> X1ButtonPlusActions { get; set; }

	public IList<PowerKeyActionItem> X2ButtonPlusActions { get; set; }

	public IList<PowerKeyActionItem> RightButtonPlusActions { get; set; }

	public bool EnableAutoBackupActions { get; set; }

	public bool EnableAutoBackupActionsWhenEditing { get; set; }

	public bool? EnableActionStateBackup { get; set; }

	public ScreenShotSettings ScreenShotSettings { get; set; } = new ScreenShotSettings();

	public ContextMenuSettings ContextMenuSettings { get; set; } = new ContextMenuSettings();

	public bool SyncIgnoreNetworkState { get; set; }

	public SearchSettings SearchSettings { get; set; } = new SearchSettings();

	public int DefaultModifiedKeyDownDelay { get; set; } = 1;

	public string ToolboxSearchImeState { get; set; } = "NO_CONTROL";

	public int AfterEditRunningAction { get; set; } = 1;

	public ActionMenuLayout ActionMenuLayout { get; set; }

	public bool EnableTreeTools { get; set; }

	public bool ShowParamDescAsToolTip { get; set; }

	public bool AutoExpandAdvancedParams { get; set; }

	public bool EnableExpressionCompletion { get; set; } = true;

	public bool EnableExpressionValidation { get; set; } = true;

	public string NewActionDefaultIcon { get; set; } = "auto";

	public string ImeToEnHotkey { get; set; }

	public string ImeToZhHotkey { get; set; }

	public int PenButton1Action { get; set; }

	public int PenButton2Action { get; set; }

	public ExplorerSoftware DefaultExplorerSoftware { get; set; } = ExplorerSoftware.WindowsExplorer;

	public bool AlwaysUseClipboardToGetSelectedFiles { get; set; }

	public string CustomSelectInExplorerCommand { get; set; }

	public string CustomOpenFolderCommand { get; set; }

	public BasicOcrSettings BasicOcrSettings { get; set; } = new BasicOcrSettings();

	public HotkeyModeAfterPause HotkeyModeAfterPause { get; set; }

	public WebsocketServerSettings WebsocketServerSettings { get; set; }

	public bool HideAllEmptyWaitKeyNotifyWindow { get; set; }

	public bool DisableCloseTextWindowByEsc { get; set; }

	public bool MatchSpaceAsWildcard { get; set; }

	public bool MatchUpperCaseEqual { get; set; }

	public int CustomPanelWindowDbClickAction { get; set; }

	public IDictionary<string, string> GlobalSettings { get; set; }
}
