using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Common.Entities;
using Quicker.Domain.Services;
using Quicker.Settings.Code;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Basic;

public class HelperFunctionsSettingPage : SettingPage, IComponentConnector
{
	internal CheckBox ChkEnableChangeVolume;

	internal CheckBox ChkEnableChangeVolumeOnScreenBottom;

	internal StackPanel PnlAdv;

	internal HotkeyEditorControl HotkeyCornerTopLeft;

	internal HotkeyEditorControl HotkeyCornerTopRight;

	internal HotkeyEditorControl HotkeyCornerBottomLeft;

	internal HotkeyEditorControl HotkeyCornerBottomRight;

	internal NumericUpDown TxtConnerTriggerDelayMs;

	internal Button BtnSetDefaultCornerActions;

	internal CheckBox ChkChangeBrightnessWithCtrlScroll;

	internal CheckBox ChkEnableChangeVirtualDeskWithX1HScroll;

	internal CheckBox ChkEnableReverseVScroll;

	internal Button BtnAdvMouseAction;

	internal HotkeyEditorControl HotkeyRemapCapsLock;

	internal HotkeyEditorControl HotkeyRemapPauseBreak;

	internal Hyperlink LnkGoToAdvMouseActions;

	private bool iAJTF40rsq;

	private static HelperFunctionsSettingPage URxTSq4JpCBF25wXeBv;

	public HelperFunctionsSettingPage()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ChkEnableChangeVolume.IsChecked = settings.EnableChangeVolume;
		ChkEnableChangeVolumeOnScreenBottom.IsChecked = settings.EnableChangeVolumeOnScreenBottom;
		HotkeyRemapCapsLock.SetData(settings.RemapKeyCapsLock);
		if (URxTSq4JpCBF25wXeBv != null)
		{
			switch (0)
			{
			}
		}
		HotkeyRemapPauseBreak.SetData(settings.RemapKeyPauseBreak);
		ChkChangeBrightnessWithCtrlScroll.IsChecked = settings.EnableAdjScreenBrightnessUseCtrlScroll;
		ChkEnableChangeVirtualDeskWithX1HScroll.IsChecked = settings.EnableSwitchVirtualDeskUseX1HScroll;
		ChkEnableReverseVScroll.IsChecked = settings.EnableReverseVScroll;
		HotkeyCornerTopLeft.SetData(settings.CornerActionTopLeft);
		HotkeyCornerTopRight.SetData(settings.CornerActionTopRight);
		HotkeyCornerBottomLeft.SetData(settings.CornerActionBottomLeft);
		HotkeyCornerBottomRight.SetData(settings.CornerActionBottomRight);
		TxtConnerTriggerDelayMs.Value = settings.CornerActionDelay;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.EnableChangeVolume = ChkEnableChangeVolume.IsChecked == true;
		settings.EnableChangeVolumeOnScreenBottom = ChkEnableChangeVolumeOnScreenBottom.IsChecked == true;
		settings.RemapKeyCapsLock = HotkeyRemapCapsLock.GetKeyData();
		settings.RemapKeyPauseBreak = HotkeyRemapPauseBreak.GetKeyData();
		settings.EnableAdjScreenBrightnessUseCtrlScroll = ChkChangeBrightnessWithCtrlScroll.IsChecked == true;
		settings.EnableSwitchVirtualDeskUseX1HScroll = ChkEnableChangeVirtualDeskWithX1HScroll.IsChecked == true;
		settings.EnableReverseVScroll = ChkEnableReverseVScroll.IsChecked == true;
		settings.CornerActionTopLeft = HotkeyCornerTopLeft.GetKeyData();
		settings.CornerActionTopRight = HotkeyCornerTopRight.GetKeyData();
		settings.CornerActionBottomLeft = HotkeyCornerBottomLeft.GetKeyData();
		settings.CornerActionBottomRight = HotkeyCornerBottomRight.GetKeyData();
		int num = 0;
		if (URxTSq4JpCBF25wXeBv != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			settings.CornerActionDelay = (int)TxtConnerTriggerDelayMs.Value;
			return true;
		}
	}

	private void lsSTA3jM47(object sender, RoutedEventArgs e)
	{
		HotkeyCornerTopLeft.SetData(new Hotkey(VirtualKeyCode.TAB, ModifierKeys.Windows).ToData());
		HotkeyCornerBottomLeft.SetData(new Hotkey(VirtualKeyCode.LWIN, ModifierKeys.None).ToData());
		HotkeyCornerBottomRight.SetData(new Hotkey(VirtualKeyCode.VK_D, ModifierKeys.Windows).ToData());
	}

	private void oWMTOpoMh3(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.MouseActionManagePage);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!iAJTF40rsq)
		{
			iAJTF40rsq = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/helperfunctionssettingpage.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			iAJTF40rsq = true;
			break;
		case 1:
			ChkEnableChangeVolume = (CheckBox)target;
			break;
		case 2:
			ChkEnableChangeVolumeOnScreenBottom = (CheckBox)target;
			break;
		case 3:
			PnlAdv = (StackPanel)target;
			break;
		case 4:
			HotkeyCornerTopLeft = (HotkeyEditorControl)target;
			break;
		case 5:
			HotkeyCornerTopRight = (HotkeyEditorControl)target;
			break;
		case 6:
			HotkeyCornerBottomLeft = (HotkeyEditorControl)target;
			break;
		case 7:
			HotkeyCornerBottomRight = (HotkeyEditorControl)target;
			break;
		case 8:
			TxtConnerTriggerDelayMs = (NumericUpDown)target;
			break;
		case 9:
			BtnSetDefaultCornerActions = (Button)target;
			BtnSetDefaultCornerActions.Click += lsSTA3jM47;
			break;
		case 10:
			ChkChangeBrightnessWithCtrlScroll = (CheckBox)target;
			num = 1;
			if (!blj6XG4kT8pNWlxBFlX())
			{
				break;
			}
			goto IL_0121;
		case 11:
			ChkEnableChangeVirtualDeskWithX1HScroll = (CheckBox)target;
			break;
		case 12:
			ChkEnableReverseVScroll = (CheckBox)target;
			num = 0;
			if (!blj6XG4kT8pNWlxBFlX())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0121;
		case 13:
			BtnAdvMouseAction = (Button)target;
			break;
		case 14:
			HotkeyRemapCapsLock = (HotkeyEditorControl)target;
			break;
		case 15:
			HotkeyRemapPauseBreak = (HotkeyEditorControl)target;
			break;
		case 16:
			{
				LnkGoToAdvMouseActions = (Hyperlink)target;
				LnkGoToAdvMouseActions.Click += oWMTOpoMh3;
				break;
			}
			IL_0121:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	internal static bool blj6XG4kT8pNWlxBFlX()
	{
		return URxTSq4JpCBF25wXeBv == null;
	}
}
