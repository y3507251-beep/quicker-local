using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.View.Hotkeys;

namespace Quicker.Settings.Pages.Triggers;

public class CircleMenuSettingPage : SettingPage, IComponentConnector
{
	private int URCoWSHopC;

	private bool mOAokYb7bl;

	internal ComboBox CbCircleMenuTrigger;

	internal Slider SliderCircleMenuSize;

	internal Slider SliderFontSize;

	internal Slider SliderCircleMenuTimeoutMs;

	internal CheckBox ChkEnableOutCircle16Actions;

	internal CheckBox ChkShowExternalWhenPopup;

	internal CheckBox ChkHideLabelIfHaveImage;

	internal CheckBox ChkShowLabelAtCenter;

	internal CheckBox ChkLimitInScreen;

	internal CheckBox ChkAutoMoveCursor;

	internal HotkeyEditorControl KeyEditorForRepeat;

	internal TextBlock ChkThemeColorHint;

	internal TabControl TabColors;

	internal CircleMenuColorSettingsControl DefaultColorSettingsControl;

	internal CircleMenuColorSettingsControl DarkColorSettingsControl;

	internal CheckBox ChkPenButton1;

	internal CheckBox ChkPenButton2;

	internal Button BtnRestore;

	internal Button BtnCopyUiData;

	internal Button BtnPasteUiData;

	internal Button BtnGoCircleMenuSettings;

	private bool ouIoG2ScAR;

	internal static CircleMenuSettingPage DR6BhSCZOW2dyDoOeCm;

	public CircleMenuSettingPage()
	{
		InitializeComponent();
		CbCircleMenuTrigger.ItemsSource = new List<KeyButtonCombination>
		{
			KeyButtonCombination.NA,
			KeyButtonCombination.Middle,
			KeyButtonCombination.Right,
			KeyButtonCombination.X1,
			KeyButtonCombination.X2
		};
		CbCircleMenuTrigger.SelectedIndex = 0;
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		CbCircleMenuTrigger.SelectedItem = (KeyButtonCombination)settings.CircleMenuTrigger;
		SliderCircleMenuSize.Value = settings.CircleMenuSize;
		SliderFontSize.Value = settings.CircleMenuFontSize;
		SliderCircleMenuTimeoutMs.Value = settings.CircleMenuTimeoutMs;
		ChkHideLabelIfHaveImage.IsChecked = settings.CircleMenuHideLabelIfHaveIcon;
		ChkShowLabelAtCenter.IsChecked = settings.CircleMenuShowLabelInCenterWhenHideLabel;
		ChkLimitInScreen.IsChecked = settings.CircleMenuLimitInScreen;
		ChkAutoMoveCursor.IsChecked = settings.CircleMenuAutoMoveCursor;
		ChkEnableOutCircle16Actions.IsChecked = settings.CirclemMenuCircle2ActionCount == 16;
		int num = 0;
		if (!QJsk2AC5DJi2svBcoMu())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ChkShowExternalWhenPopup.IsChecked = settings.CircleMenuShowExternalWhenPopup;
		URCoWSHopC = settings.CirclemMenuCircle2ActionCount;
		KeyEditorForRepeat.SetSingleKey(settings.CircleMenuRepeatKey);
		ChkEnableOutCircle16Actions.IsEnabled = AppState.DataService.Hb9tmk3OsJ7();
		ChkPenButton1.IsChecked = settings.PenButton1Action > 0;
		ChkPenButton2.IsChecked = settings.PenButton2Action > 0;
		EjFoVgcWt8(settings);
	}

	protected override bool SaveDataFromUi(UserSettings userSettings)
	{
		if (userSettings.OpenPopWithMiddleClick && (KeyButtonCombination)CbCircleMenuTrigger.SelectedItem == KeyButtonCombination.Middle)
		{
			AppHelper.ShowWarning("中键用于激活面板时，不可用于触发轮盘或手势。");
			return false;
		}
		if (userSettings.OpenPopWithRightPressMove && (KeyButtonCombination)CbCircleMenuTrigger.SelectedItem == KeyButtonCombination.Right)
		{
			AppHelper.ShowWarning("按右键移动激活面板时，不可用于触发轮盘。");
			return false;
		}
		userSettings.CircleMenuTrigger = (int)((CbCircleMenuTrigger.SelectedItem != null) ? ((KeyButtonCombination)CbCircleMenuTrigger.SelectedItem) : KeyButtonCombination.NA);
		int num = 1;
		if (DR6BhSCZOW2dyDoOeCm == null)
		{
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 2:
					MBRoZOMGIs(userSettings);
					num = 0;
					if (DR6BhSCZOW2dyDoOeCm != null)
					{
						num = num3;
					}
					continue;
				case 1:
				{
					userSettings.CircleMenuSize = SliderCircleMenuSize.Value;
					userSettings.CircleMenuFontSize = SliderFontSize.Value;
					userSettings.CircleMenuTimeoutMs = (int)SliderCircleMenuTimeoutMs.Value;
					userSettings.CircleMenuHideLabelIfHaveIcon = ChkHideLabelIfHaveImage.IsChecked == true;
					userSettings.CircleMenuShowLabelInCenterWhenHideLabel = ChkShowLabelAtCenter.IsChecked == true;
					userSettings.CircleMenuLimitInScreen = ChkLimitInScreen.IsChecked == true;
					userSettings.CircleMenuAutoMoveCursor = ChkAutoMoveCursor.IsChecked == true;
					userSettings.CircleMenuShowExternalWhenPopup = ChkShowExternalWhenPopup.IsChecked == true;
					int num2 = ((ChkEnableOutCircle16Actions.IsChecked != true || !AppState.DataService.Hb9tmk3OsJ7()) ? 8 : 16);
					if (userSettings.CirclemMenuCircle2ActionCount != num2)
					{
						AppState.v5FtaQ4hQfg().G1XvtA8WXBn();
					}
					userSettings.CirclemMenuCircle2ActionCount = num2;
					userSettings.CircleMenuRepeatKey = KeyEditorForRepeat.GetSingleKey();
					goto case 2;
				}
				}
				break;
			}
		}
		userSettings.PenButton1Action = ((ChkPenButton1.IsChecked == true) ? 21 : 0);
		userSettings.PenButton2Action = ((ChkPenButton2.IsChecked == true) ? 21 : 0);
		return true;
	}

	private void EjFoVgcWt8(UserSettings userSettings_0)
	{
		UiSettings uiSettings = userSettings_0.UiSettings;
		DefaultColorSettingsControl.SetData(uiSettings);
		mOAokYb7bl = AppState.DataService.Hb9tmk3OsJ7() && AppState.HHxtaMaoqJr().SwitchUiSettingsBasedOnTheme;
		if (!mOAokYb7bl)
		{
			(TabColors.Items[1] as TabItem).Visibility = Visibility.Collapsed;
			if (AppState.DataService.Hb9tmk3OsJ7())
			{
				ChkThemeColorHint.Visibility = Visibility.Visible;
				int num = 0;
				if (!QJsk2AC5DJi2svBcoMu())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		else
		{
			if (userSettings_0.DarkUiSettings == null)
			{
				userSettings_0.DarkUiSettings = AppHelper.Clone(userSettings_0.UiSettings);
			}
			DarkColorSettingsControl.SetData(userSettings_0.DarkUiSettings);
			if (App.Current.n991yfUy4r())
			{
				TabColors.SelectedIndex = 1;
			}
		}
	}

	private void MBRoZOMGIs(UserSettings userSettings_0)
	{
		UiSettings uiSettings = userSettings_0.UiSettings;
		DefaultColorSettingsControl.SaveData(uiSettings);
		if (mOAokYb7bl)
		{
			if (userSettings_0.DarkUiSettings == null)
			{
				userSettings_0.DarkUiSettings = AppHelper.Clone(uiSettings);
			}
			DarkColorSettingsControl.SaveData(userSettings_0.DarkUiSettings);
		}
	}

	private void MVlo9vh9Zv(object sender, RoutedEventArgs e)
	{
		if (TabColors.SelectedIndex == 0)
		{
			AppState.HHxtaMaoqJr().UiSettings.ResetCircleMenuUiSettings(new CircleMenuUiSettings());
		}
		else if (AppState.HHxtaMaoqJr().DarkUiSettings == null)
		{
			AppHelper.ShowWarning("");
		}
		else
		{
			string value = "{\r\n  \"LabelColor\": \"#FFD0D0D0\",\r\n  \"ButtonBgColor\": \"#00000000\",\r\n  \"ButtonHoverColor\": \"#755C5C5C\",\r\n  \"ButtonSpaceColor\": \"#33575757\",\r\n  \"IndicateLineColor\": \"#FFFF9E9E\",\r\n  \"DefaultIconColor\": \"#FFF3F3F3\",\r\n  \"BgOpacity\": 0.93,\r\n  \"BgFill\": \"#333\",\r\n  \"BgOverlyOpacity\": 0.0,\r\n  \"BgOverlyFill\": \"#FFFFFFFF\",\r\n  \"ShowShadow\": false\r\n}";
			int num = 0;
			if (DR6BhSCZOW2dyDoOeCm != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppState.HHxtaMaoqJr().DarkUiSettings.ResetCircleMenuUiSettings(JsonConvert.DeserializeObject<CircleMenuUiSettings>(value) ?? new CircleMenuUiSettings());
		}
		EjFoVgcWt8(AppState.HHxtaMaoqJr());
	}

	private void hwkoho3CEJ(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.CircleMenuSettingPage);
	}

	private void YcXoeF7Tdb(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.UISettingsPage);
	}

	private void B6HoYaQDSE(object sender, RoutedEventArgs e)
	{
		if (TabColors.SelectedIndex == 0)
		{
			AppHelper.TryCopy(AppState.HHxtaMaoqJr().UiSettings.CircleMenu.ToJson(true), true);
		}
		else
		{
			AppHelper.TryCopy(AppState.HHxtaMaoqJr().DarkUiSettings.CircleMenu.ToJson(true), true);
		}
	}

	private void FnmoIkhTFC(object sender, RoutedEventArgs e)
	{
		string text = Clipboard.GetText();
		if (string.IsNullOrEmpty(text))
		{
			AppHelper.ShowWarning("剪贴板没有轮盘外观数据。");
			return;
		}
		try
		{
			CircleMenuUiSettings circleMenuUiSettings = JsonConvert.DeserializeObject<CircleMenuUiSettings>(text.Trim());
			if (circleMenuUiSettings == null)
			{
				if (DR6BhSCZOW2dyDoOeCm != null)
				{
					switch (0)
					{
					}
				}
				AppHelper.ShowWarning("剪贴板没有轮盘外观数据。");
			}
			else
			{
				if (TabColors.SelectedIndex == 0)
				{
					AppState.HHxtaMaoqJr().UiSettings.ResetCircleMenuUiSettings(circleMenuUiSettings);
				}
				else
				{
					AppState.HHxtaMaoqJr().DarkUiSettings.ResetCircleMenuUiSettings(circleMenuUiSettings);
				}
				EjFoVgcWt8(AppState.HHxtaMaoqJr());
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!ouIoG2ScAR)
		{
			ouIoG2ScAR = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/circlemenusettingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 19:
				BtnCopyUiData = (Button)target;
				BtnCopyUiData.Click += B6HoYaQDSE;
				num2 = 2;
				if (DR6BhSCZOW2dyDoOeCm != null)
				{
					goto IL_003b;
				}
				goto IL_003f;
			default:
				num2 = 0;
				if (!QJsk2AC5DJi2svBcoMu())
				{
					goto IL_003b;
				}
				goto IL_003f;
			case 1:
				CbCircleMenuTrigger = (ComboBox)target;
				return;
			case 2:
				SliderCircleMenuSize = (Slider)target;
				return;
			case 3:
				SliderFontSize = (Slider)target;
				return;
			case 4:
				SliderCircleMenuTimeoutMs = (Slider)target;
				return;
			case 5:
				ChkEnableOutCircle16Actions = (CheckBox)target;
				return;
			case 6:
				ChkShowExternalWhenPopup = (CheckBox)target;
				return;
			case 7:
				ChkHideLabelIfHaveImage = (CheckBox)target;
				return;
			case 8:
				ChkShowLabelAtCenter = (CheckBox)target;
				return;
			case 9:
				ChkLimitInScreen = (CheckBox)target;
				return;
			case 10:
				ChkAutoMoveCursor = (CheckBox)target;
				return;
			case 11:
				KeyEditorForRepeat = (HotkeyEditorControl)target;
				return;
			case 12:
				ChkThemeColorHint = (TextBlock)target;
				return;
			case 13:
				TabColors = (TabControl)target;
				return;
			case 14:
				DefaultColorSettingsControl = (CircleMenuColorSettingsControl)target;
				return;
			case 15:
				DarkColorSettingsControl = (CircleMenuColorSettingsControl)target;
				return;
			case 16:
				ChkPenButton1 = (CheckBox)target;
				return;
			case 17:
				ChkPenButton2 = (CheckBox)target;
				return;
			case 18:
				BtnRestore = (Button)target;
				BtnRestore.Click += MVlo9vh9Zv;
				return;
			case 20:
				BtnPasteUiData = (Button)target;
				BtnPasteUiData.Click += FnmoIkhTFC;
				return;
			case 21:
				{
					BtnGoCircleMenuSettings = (Button)target;
					BtnGoCircleMenuSettings.Click += YcXoeF7Tdb;
					return;
				}
				IL_003b:
				num2 = num;
				goto IL_003f;
				IL_003f:
				switch (num2)
				{
				case 1:
					break;
				default:
					ouIoG2ScAR = true;
					return;
				case 2:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	static CircleMenuSettingPage()
	{
	}

	internal static bool QJsk2AC5DJi2svBcoMu()
	{
		return DR6BhSCZOW2dyDoOeCm == null;
	}

	internal static void KRZ2QJCUjH3NSA0eWt6()
	{
	}
}
