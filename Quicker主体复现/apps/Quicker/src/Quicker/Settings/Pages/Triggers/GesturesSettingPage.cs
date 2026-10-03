using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.Services;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.Hotkeys;
using Xceed.Wpf.Toolkit;

namespace Quicker.Settings.Pages.Triggers;

public class GesturesSettingPage : SettingPage, IComponentConnector
{
	internal StackPanel PnlGesture;

	internal ComboBox CbGestureTrigger;

	internal CheckBox ChkActivateGestureStartPositionWindow;

	internal CheckBox ChkShowGestureTrack;

	internal CheckBox ChkShowActionName;

	internal CheckBox ChkShowActionNameAtFixedPosition;

	internal CheckBox ChkEnableHideEffect;

	internal CheckBox ChkPlayback;

	internal CheckBox ChkEnableTriggerByKey;

	internal ColorPicker ClrPickerValid;

	internal ColorPicker ClrPickerInvalid;

	internal Slider SliderMinScore;

	internal Slider SliderStrokeThickness;

	internal Slider SliderGestureHintListDelayMs;

	internal HotkeyEditorControl KeyEditorForRepeat;

	private bool kNMoHxLpoy;

	internal static GesturesSettingPage DKM5xmCx0lNoQe51eMA;

	public GesturesSettingPage()
	{
		InitializeComponent();
		CbGestureTrigger.ItemsSource = new List<KeyButtonCombination>
		{
			KeyButtonCombination.NA,
			KeyButtonCombination.Middle,
			KeyButtonCombination.Right,
			KeyButtonCombination.X1,
			KeyButtonCombination.X2
		};
		CbGestureTrigger.SelectedIndex = 0;
	}

	protected override void LoadDataToUi(UserSettings userSettings)
	{
		CbGestureTrigger.SelectedItem = (KeyButtonCombination)userSettings.GestureTrigger;
		ChkShowGestureTrack.IsChecked = !userSettings.GestureHideTrack;
		ChkActivateGestureStartPositionWindow.IsChecked = userSettings.ActivateGestureStartPositionWindow;
		ChkShowActionName.IsChecked = userSettings.GestureShowActionName;
		ChkShowActionNameAtFixedPosition.IsChecked = userSettings.GestureShowActionNameAtFixedPosition;
		int num = 0;
		if (!H3NWswCI1xhU908MTL5())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ChkPlayback.IsChecked = userSettings.GesturePlaybackUnknownGesture;
		ClrPickerInvalid.SelectedColor = ColorHelper.StringToColor(userSettings.GestureInvalidColor);
		ClrPickerValid.SelectedColor = ColorHelper.StringToColor(userSettings.GestureValidColor);
		SliderStrokeThickness.Value = userSettings.GestureStrokeThickness;
		SliderMinScore.Value = userSettings.GestureMinScore;
		ChkEnableHideEffect.IsChecked = userSettings.GestureEnableHideEffect;
		SliderGestureHintListDelayMs.Value = userSettings.GestureHintListDelayMs;
		ChkEnableTriggerByKey.IsChecked = userSettings.GestureEnableTriggerByKey;
		if (userSettings.GestureRepeatKey > 0)
		{
			KeyEditorForRepeat.SetSingleKey(userSettings.GestureRepeatKey);
		}
	}

	protected override bool SaveDataFromUi(UserSettings userSettings)
	{
		int num = 1;
		while (true)
		{
			int num2;
			if (userSettings.OpenPopWithMiddleClick)
			{
				num2 = 0;
				if (DKM5xmCx0lNoQe51eMA != null)
				{
					goto IL_0062;
				}
				goto IL_0063;
			}
			goto IL_00a1;
			IL_0063:
			switch (num2)
			{
			case 1:
				continue;
			case 2:
				userSettings.ActivateGestureStartPositionWindow = ChkActivateGestureStartPositionWindow.IsChecked == true;
				userSettings.GestureShowActionName = ChkShowActionName.IsChecked == true;
				userSettings.GestureShowActionNameAtFixedPosition = ChkShowActionNameAtFixedPosition.IsChecked == true;
				userSettings.GestureInvalidColor = ClrPickerInvalid.SelectedColor.ToString();
				userSettings.GestureValidColor = ClrPickerValid.SelectedColor.ToString();
				userSettings.GestureStrokeThickness = SliderStrokeThickness.Value;
				userSettings.GestureMinScore = (float)SliderMinScore.Value;
				userSettings.GestureEnableHideEffect = ChkEnableHideEffect.IsChecked == true;
				userSettings.GestureHintListDelayMs = (int)SliderGestureHintListDelayMs.Value;
				userSettings.GestureEnableTriggerByKey = ChkEnableTriggerByKey.IsChecked == true;
				userSettings.GesturePlaybackUnknownGesture = ChkPlayback.IsChecked == true;
				userSettings.GestureRepeatKey = KeyEditorForRepeat.GetSingleKey();
				return true;
			}
			if ((KeyButtonCombination)CbGestureTrigger.SelectedItem == KeyButtonCombination.Middle)
			{
				break;
			}
			goto IL_00a1;
			IL_00a1:
			if (!userSettings.OpenPopWithRightPressMove || (KeyButtonCombination)CbGestureTrigger.SelectedItem != KeyButtonCombination.Right)
			{
				userSettings.GestureTrigger = (int)((CbGestureTrigger.SelectedItem != null) ? ((KeyButtonCombination)CbGestureTrigger.SelectedItem) : KeyButtonCombination.NA);
				userSettings.GestureHideTrack = ChkShowGestureTrack.IsChecked == false;
				num2 = 2;
				if (DKM5xmCx0lNoQe51eMA != null)
				{
					goto IL_0062;
				}
				goto IL_0063;
			}
			AppHelper.ShowWarning("按右键移动激活面板时，不可用于触发轮盘。");
			return false;
			IL_0062:
			num2 = num;
			goto IL_0063;
		}
		AppHelper.ShowWarning("中键用于激活面板时，不可用于触发轮盘或手势。");
		return false;
	}

	private void VhNoshq4GC(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.GesturesManagePage);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!kNMoHxLpoy)
		{
			kNMoHxLpoy = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/gesturessettingpage.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				PnlGesture = (StackPanel)target;
				return;
			case 2:
				CbGestureTrigger = (ComboBox)target;
				return;
			case 3:
				ChkActivateGestureStartPositionWindow = (CheckBox)target;
				return;
			case 4:
				ChkShowGestureTrack = (CheckBox)target;
				return;
			case 5:
				ChkShowActionName = (CheckBox)target;
				return;
			case 6:
				ChkShowActionNameAtFixedPosition = (CheckBox)target;
				return;
			case 7:
				ChkEnableHideEffect = (CheckBox)target;
				return;
			case 8:
				ChkPlayback = (CheckBox)target;
				return;
			case 9:
				ChkEnableTriggerByKey = (CheckBox)target;
				return;
			case 10:
				ClrPickerValid = (ColorPicker)target;
				return;
			case 11:
				ClrPickerInvalid = (ColorPicker)target;
				return;
			case 12:
				SliderMinScore = (Slider)target;
				return;
			case 13:
				SliderStrokeThickness = (Slider)target;
				return;
			case 14:
				SliderGestureHintListDelayMs = (Slider)target;
				return;
			case 15:
				KeyEditorForRepeat = (HotkeyEditorControl)target;
				return;
			}
			int num = 0;
			if (DKM5xmCx0lNoQe51eMA == null)
			{
				goto IL_0010;
			}
			goto IL_0023;
			IL_0023:
			switch (num)
			{
			case 1:
				continue;
			case 2:
				return;
			}
			goto IL_0010;
			IL_0010:
			kNMoHxLpoy = true;
			num = 2;
			if (H3NWswCI1xhU908MTL5())
			{
				return;
			}
			goto IL_0023;
		}
	}

	internal static bool H3NWswCI1xhU908MTL5()
	{
		return DKM5xmCx0lNoQe51eMA == null;
	}
}
