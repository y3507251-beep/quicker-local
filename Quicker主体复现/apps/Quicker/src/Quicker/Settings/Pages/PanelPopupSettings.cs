using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.View.Hotkeys;

namespace Quicker.Settings.Pages;

public class PanelPopupSettings : SettingPage, IComponentConnector
{
	internal CheckBox ChkMiddleClickOpenPanel;

	internal CheckBox ChkXButton1ClickOpenPanel;

	internal CheckBox ChkXButton2ClickOpenPanel;

	internal CheckBox ChkCtrlMiddleClickOpenPanel;

	internal CheckBox ChkCtrlRightClickOpenPanel;

	internal CheckBox ChkOpenPopWithLongMiddlePress;

	internal CheckBox ChkOpenPopWithLongRightPress;

	internal CheckBox ChkOpenPopWithRightPressMove;

	internal CheckBox ChkOpenPopWithCircle;

	internal CheckBox ChkOpenPopWithWheelLeft;

	internal CheckBox ChkEnableReleaseOnButtonTrigger;

	internal CheckBox ChkCtrlKeyOpenPanel;

	internal HotkeyEditorControl HotkeyEditor;

	internal ComboBox CbPopupLocation;

	internal CheckBox ChkActiveCursorPositionWindowWhenPopupWithKeyboard;

	internal CheckBox ChkDisableAutoSwitchAfterPopup;

	internal Button BtnTestMouseButton;

	private bool fj8nsEXtAS;

	internal static PanelPopupSettings FswTaBwqw5qHtEsFBNX;

	public PanelPopupSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		if (settings.EnableCircleMenu && settings.OpenPopWithRightPressMove)
		{
			settings.CircleMenuTrigger = 4;
			settings.OpenPopWithRightPressMove = false;
		}
		ChkMiddleClickOpenPanel.IsChecked = settings.OpenPopWithMiddleClick;
		ChkXButton1ClickOpenPanel.IsChecked = settings.OpenPopWithXButton1Click;
		ChkXButton2ClickOpenPanel.IsChecked = settings.OpenPopWithXButton2Click;
		int num = 0;
		if (nZ84PFwiJZiR3wL8VRJ())
		{
			goto IL_0070;
		}
		goto IL_011b;
		IL_0070:
		ChkCtrlMiddleClickOpenPanel.IsChecked = settings.OpenPopWithCtrlMiddleClick;
		ChkCtrlRightClickOpenPanel.IsChecked = settings.OpenPopWithCtrlRightClick;
		ChkCtrlKeyOpenPanel.IsChecked = settings.OpenPopWithCtrlClick;
		ChkOpenPopWithLongRightPress.IsChecked = settings.OpenPopWithLongRightPress;
		ChkOpenPopWithLongMiddlePress.IsChecked = settings.OpenPopWithLongMiddlePress;
		ChkOpenPopWithWheelLeft.IsChecked = settings.OpenPopWithWheelLeft;
		ChkOpenPopWithCircle.IsChecked = settings.OpenPopupWithCircle;
		num = 1;
		if (FswTaBwqw5qHtEsFBNX != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_011b;
		IL_011b:
		switch (num)
		{
		case 1:
			HotkeyEditor.SetData(settings.OpenWithGlobalHotkey);
			ChkEnableReleaseOnButtonTrigger.IsChecked = settings.EnableReleaseOnButtonTrigger;
			ChkOpenPopWithRightPressMove.IsChecked = settings.OpenPopWithRightPressMove;
			ChkDisableAutoSwitchAfterPopup.IsChecked = settings.DisableAutoSwitchAfterPopup;
			foreach (ComboBoxItem item in CbPopupLocation.Items.Cast<ComboBoxItem>())
			{
				if (Convert.ToInt32(item.Tag) == (int)settings.ToMousePosWhenOpenByKeyboard)
				{
					CbPopupLocation.SelectedItem = item;
					break;
				}
			}
			ChkActiveCursorPositionWindowWhenPopupWithKeyboard.IsChecked = settings.ActiveCursorPositionWindowWhenPopupWithKeyboard;
			return;
		}
		goto IL_0070;
	}

	protected override bool SaveDataFromUi(UserSettings UserSettings)
	{
		AppState.EndTestingMouse();
		if (ChkOpenPopWithLongMiddlePress.IsChecked != true)
		{
			goto IL_007f;
		}
		int num = 1;
		if (FswTaBwqw5qHtEsFBNX == null)
		{
			goto IL_002d;
		}
		goto IL_00f7;
		IL_007f:
		UserSettings.OpenPopWithMiddleClick = ChkMiddleClickOpenPanel.IsChecked == true;
		UserSettings.OpenPopWithXButton1Click = ChkXButton1ClickOpenPanel.IsChecked == true;
		UserSettings.OpenPopWithXButton2Click = ChkXButton2ClickOpenPanel.IsChecked == true;
		UserSettings.OpenPopWithCtrlMiddleClick = ChkCtrlMiddleClickOpenPanel.IsChecked == true;
		num = 0;
		if (FswTaBwqw5qHtEsFBNX == null)
		{
			goto IL_002d;
		}
		goto IL_00f7;
		IL_00f7:
		int num2 = default(int);
		num = num2;
		goto IL_002d;
		IL_002d:
		switch (num)
		{
		case 1:
			break;
		default:
			UserSettings.OpenPopWithCtrlRightClick = ChkCtrlRightClickOpenPanel.IsChecked == true;
			UserSettings.OpenPopWithCtrlClick = ChkCtrlKeyOpenPanel.IsChecked == true;
			UserSettings.EnableReleaseOnButtonTrigger = ChkEnableReleaseOnButtonTrigger.IsChecked == true;
			UserSettings.OpenPopWithLongRightPress = ChkOpenPopWithLongRightPress.IsChecked == true;
			UserSettings.OpenPopWithLongMiddlePress = ChkOpenPopWithLongMiddlePress.IsChecked == true;
			UserSettings.OpenPopWithWheelLeft = ChkOpenPopWithWheelLeft.IsChecked == true;
			UserSettings.OpenPopupWithCircle = ChkOpenPopWithCircle.IsChecked == true;
			UserSettings.OpenWithGlobalHotkey = HotkeyEditor.GetKeyData();
			UserSettings.OpenPopWithRightPressMove = ChkOpenPopWithRightPressMove.IsChecked == true;
			UserSettings.EnableCircleMenu = false;
			UserSettings.ToMousePosWhenOpenByKeyboard = ((CbPopupLocation.SelectedItem != null) ? ((PopupLocationType)Convert.ToInt32((CbPopupLocation.SelectedItem as ComboBoxItem).Tag)) : PopupLocationType.NA);
			UserSettings.ActiveCursorPositionWindowWhenPopupWithKeyboard = ChkActiveCursorPositionWindowWhenPopupWithKeyboard.IsChecked == true;
			UserSettings.DisableAutoSwitchAfterPopup = ChkDisableAutoSwitchAfterPopup.IsChecked == true;
			return true;
		}
		if (ChkOpenPopWithLongMiddlePress.IsChecked == ChkMiddleClickOpenPanel.IsChecked)
		{
			AppHelper.ShowWarning("不能同时使用按下中键和长按中键激活面板选项。");
			return false;
		}
		goto IL_007f;
	}

	private void nyEnWM77cS(object sender, MouseButtonEventArgs e)
	{
		string content = e.ChangedButton.ToString();
		switch (e.ChangedButton)
		{
		default:
		{
			int num = 0;
			if (FswTaBwqw5qHtEsFBNX != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case MouseButton.Left:
			content = "左键";
			break;
		case MouseButton.Middle:
			content = "中键";
			break;
		case MouseButton.Right:
			content = "右键";
			break;
		case MouseButton.XButton1:
			content = "X1键";
			break;
		case MouseButton.XButton2:
			content = "X2键";
			break;
		}
		BtnTestMouseButton.Content = content;
	}

	private void nUXnkVjRvP(object sender, MouseEventArgs e)
	{
		AppState.BeginTestingMouse();
	}

	private void lLFnGnvly0(object sender, MouseEventArgs e)
	{
		AppState.EndTestingMouse();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!fj8nsEXtAS)
		{
			fj8nsEXtAS = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/panel/panelpopupsettings.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			fj8nsEXtAS = true;
			break;
		case 1:
			ChkMiddleClickOpenPanel = (CheckBox)target;
			break;
		case 2:
			ChkXButton1ClickOpenPanel = (CheckBox)target;
			num = 1;
			if (!nZ84PFwiJZiR3wL8VRJ())
			{
				break;
			}
			goto IL_013b;
		case 3:
			ChkXButton2ClickOpenPanel = (CheckBox)target;
			break;
		case 4:
			ChkCtrlMiddleClickOpenPanel = (CheckBox)target;
			break;
		case 5:
			ChkCtrlRightClickOpenPanel = (CheckBox)target;
			break;
		case 6:
			ChkOpenPopWithLongMiddlePress = (CheckBox)target;
			break;
		case 7:
			ChkOpenPopWithLongRightPress = (CheckBox)target;
			break;
		case 8:
			ChkOpenPopWithRightPressMove = (CheckBox)target;
			break;
		case 9:
			ChkOpenPopWithCircle = (CheckBox)target;
			break;
		case 10:
			ChkOpenPopWithWheelLeft = (CheckBox)target;
			break;
		case 11:
			ChkEnableReleaseOnButtonTrigger = (CheckBox)target;
			break;
		case 12:
			ChkCtrlKeyOpenPanel = (CheckBox)target;
			break;
		case 13:
			HotkeyEditor = (HotkeyEditorControl)target;
			break;
		case 14:
			CbPopupLocation = (ComboBox)target;
			break;
		case 15:
			ChkActiveCursorPositionWindowWhenPopupWithKeyboard = (CheckBox)target;
			num = 0;
			if (!nZ84PFwiJZiR3wL8VRJ())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_013b;
		case 16:
			ChkDisableAutoSwitchAfterPopup = (CheckBox)target;
			break;
		case 17:
			{
				BtnTestMouseButton = (Button)target;
				BtnTestMouseButton.MouseEnter += nUXnkVjRvP;
				BtnTestMouseButton.MouseLeave += lLFnGnvly0;
				BtnTestMouseButton.PreviewMouseDown += nyEnWM77cS;
				break;
			}
			IL_013b:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	internal static bool nZ84PFwiJZiR3wL8VRJ()
	{
		return FswTaBwqw5qHtEsFBNX == null;
	}
}
