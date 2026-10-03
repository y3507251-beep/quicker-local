using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using dkbgyyMixGueocCf9RC;
using HandyControl.Controls;
using log4net;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Modules.VersionUpdate;
using Quicker.Properties;
using Quicker.Settings.Controls;
using Quicker.Settings.Pages.Basic;
using Quicker.Utilities;
using Quicker.Utilities.App;
using Quicker.Utilities.Ext;

namespace Quicker.Settings.Pages;

public class BasicSettings : SettingPage, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnCheckVersion_OnClick_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object Nvx79ec93D2gNMHeFqbq;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = SoftVersionHelper.ShowUpdateVersionWindow().ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (Nvx79ec93D2gNMHeFqbq == null)
						{
							switch (0)
							{
							}
						}
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool PLH61Zc9EKVQNDE7y4SD()
		{
			return Nvx79ec93D2gNMHeFqbq == null;
		}
	}

	private static readonly ILog ooXnXfsYBI;

	internal BooleanSettingControl AutoStartToggle;

	internal BooleanSettingControl ToggleShowStartupTip;

	internal ProxySettingsControl ProxySettingsControl;

	internal BooleanSettingControl ToggleSyncIgnoreNetworkState;

	internal BooleanSettingControl ToggleShowActionNewVersionTip;

	internal BooleanSettingControl ToggleEnableCyclePaging;

	internal BooleanSettingControl ToggleShowNewExeSettingTips;

	internal BooleanSettingControl ToggleShowMenuWhenLeftClickEmptyButton;

	internal BooleanSettingControl ToggleHideContextProcessIcon;

	internal BooleanSettingControl ToggleHidePanelToolTip;

	internal NumericUpDown TxtMoveTriggerDistance;

	internal NumericUpDown TxtRightBtnPopupDelayMs;

	internal NumericUpDown TxtDbClickIntervalMs;

	internal BooleanSettingControl ToggleAutoDetectHook;

	internal BooleanSettingControl ToggleAutoResetKeyboardState;

	internal BooleanSettingControl ToggleRestoreOriginEventIfMouseDownTimeout;

	internal BooleanSettingControl ChkFloatUseLeftButtonOnPanel;

	internal BooleanSettingControl ChkLoadFloatButtonState;

	internal BooleanSettingControl ChkFloatButtonBindProcessByDefault;

	internal BooleanSettingControl ChkDisableMiddleClickCloseFloat;

	internal BooleanSettingControl ChkDisableResizeFloatButton;

	internal BooleanSettingControl ChkShowTextFloatPanel;

	internal CheckBox ChkMatchSpaceAsWildcard;

	internal CheckBox ChkMatchUpperCaseEqual;

	internal System.Windows.Controls.ComboBox CbTrayIconType;

	internal BooleanSettingControl ToggleShowRunningCountOnTrayIcon;

	internal BooleanSettingControl ToggleKeepActionLocalIconAndName;

	internal BooleanSettingControl ToggleRememberLastConfigPage;

	internal BooleanSettingControl ToggleDisableUiAutomation;

	internal TextBlock LblVersion;

	internal Button BtnCheckVersion;

	internal RadioButton RbChannelSlow;

	internal RadioButton RbChannelFast;

	internal RadioButton RbChannelPreview;

	private bool DaunmLh3ap;

	internal static BasicSettings KmkBCwwg2Wkd5NOFTD0;

	public BasicSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		AutoStartToggle.IsChecked = AutoStartHelper.IsAutoStart();
		LblVersion.Text = AppHelper.GetCurrAppShortVersion();
		RbChannelFast.IsChecked = Quicker.Properties.Settings.Default.Channel == "fast";
		RbChannelSlow.IsChecked = !RbChannelFast.IsChecked;
		ToggleShowStartupTip.IsChecked = settings.ShowStartupTip;
		ToggleShowActionNewVersionTip.IsChecked = settings.ShowActionNewVersionTip;
		ToggleEnableCyclePaging.IsChecked = settings.EnableCyclePaging;
		int num = 2;
		if (!I2wGvYwPSoqK9w0boRo())
		{
			goto IL_0177;
		}
		goto IL_0265;
		IL_0265:
		do
		{
			IL_0265_2:
			switch (num)
			{
			case 3:
				ChkDisableMiddleClickCloseFloat.IsChecked = settings.DisableMiddleClickCloseFloat;
				ChkDisableResizeFloatButton.IsChecked = settings.FixFloatButtonSize != 0;
				ToggleSyncIgnoreNetworkState.IsChecked = settings.SyncIgnoreNetworkState;
				ToggleRestoreOriginEventIfMouseDownTimeout.IsChecked = settings.RestoreOriginEventIfMouseDownTimeout;
				CbTrayIconType.SelectedIndex = settings.TrayIconType;
				goto case 1;
			case 2:
				ToggleShowNewExeSettingTips.IsChecked = settings.ShowNewExeSettingTips;
				ToggleShowMenuWhenLeftClickEmptyButton.IsChecked = settings.ShowMenuWhenLeftClickEmptyButton;
				ToggleHideContextProcessIcon.IsChecked = settings.HideContextProcessIcon;
				ToggleHidePanelToolTip.IsChecked = settings.HidePanelToolTip;
				TxtMoveTriggerDistance.Value = settings.MoveTriggerDistance;
				TxtRightBtnPopupDelayMs.Value = settings.RightBtnPopupDelayMs;
				TxtDbClickIntervalMs.Value = settings.DoubleClickInterval;
				ToggleAutoDetectHook.IsChecked = settings.EnableHookDetector;
				ToggleAutoResetKeyboardState.IsChecked = settings.PowerKeys_AutoResetKeyboardState;
				ChkFloatUseLeftButtonOnPanel.IsChecked = settings.FloatUseLeftButtonOnPanel;
				ChkFloatButtonBindProcessByDefault.IsChecked = settings.FloatButtonBindProcessByDefault;
				ChkLoadFloatButtonState.IsChecked = settings.LoadFloatButtonState;
				ChkShowTextFloatPanel.IsChecked = settings.EnableTextFloatingPanel;
				goto case 3;
			case 1:
				ToggleKeepActionLocalIconAndName.IsChecked = settings.KeepActionLocalIconAndName;
				ToggleRememberLastConfigPage.IsChecked = settings.RememberLastConfigPage;
				ChkMatchSpaceAsWildcard.IsChecked = settings.MatchSpaceAsWildcard;
				ChkMatchUpperCaseEqual.IsChecked = settings.MatchUpperCaseEqual;
				ProxySettingsControl.SetData(AO7eLUM7kJyEdiOQu2O.w7cLMa3s1jT());
				ToggleDisableUiAutomation.IsChecked = !settings.EnableUiAutomation;
				ToggleShowRunningCountOnTrayIcon.IsChecked = settings.ShowRunningCountOnTrayIcon;
				return;
			}
			CbTrayIconType.ToolTip = null;
			CbTrayIconType.IsEnabled = true;
			num = 1;
		}
		while (I2wGvYwPSoqK9w0boRo());
		goto IL_0177;
		IL_0177:
		int num2 = default(int);
		num = num2;
		goto IL_0265;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.ShowStartupTip = ToggleShowStartupTip.IsChecked;
		settings.ShowActionNewVersionTip = ToggleShowActionNewVersionTip.IsChecked;
		settings.EnableCyclePaging = ToggleEnableCyclePaging.IsChecked;
		settings.ShowNewExeSettingTips = ToggleShowNewExeSettingTips.IsChecked;
		int num2 = default(int);
		while (true)
		{
			settings.ShowMenuWhenLeftClickEmptyButton = ToggleShowMenuWhenLeftClickEmptyButton.IsChecked;
			settings.HideContextProcessIcon = ToggleHideContextProcessIcon.IsChecked;
			int num = 0;
			if (KmkBCwwg2Wkd5NOFTD0 != null)
			{
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					settings.HidePanelToolTip = ToggleHidePanelToolTip.IsChecked;
					settings.MoveTriggerDistance = (int)TxtMoveTriggerDistance.Value;
					settings.RightBtnPopupDelayMs = (int)TxtRightBtnPopupDelayMs.Value;
					settings.DoubleClickInterval = (int)TxtDbClickIntervalMs.Value;
					settings.EnableHookDetector = ToggleAutoDetectHook.IsChecked;
					settings.PowerKeys_AutoResetKeyboardState = ToggleAutoResetKeyboardState.IsChecked;
					settings.FloatButtonBindProcessByDefault = ChkFloatButtonBindProcessByDefault.IsChecked;
					settings.LoadFloatButtonState = ChkLoadFloatButtonState.IsChecked;
					settings.EnableTextFloatingPanel = ChkShowTextFloatPanel.IsChecked;
					num = 1;
					if (I2wGvYwPSoqK9w0boRo())
					{
						continue;
					}
					goto case 1;
				case 2:
					break;
				case 1:
					settings.DisableMiddleClickCloseFloat = ChkDisableMiddleClickCloseFloat.IsChecked;
					settings.FloatUseLeftButtonOnPanel = ChkFloatUseLeftButtonOnPanel.IsChecked;
					settings.FixFloatButtonSize = (ChkDisableResizeFloatButton.IsChecked ? (-1) : 0);
					settings.SyncIgnoreNetworkState = ToggleSyncIgnoreNetworkState.IsChecked;
					settings.TrayIconType = ((CbTrayIconType.SelectedIndex >= 0) ? CbTrayIconType.SelectedIndex : 0);
					settings.KeepActionLocalIconAndName = ToggleKeepActionLocalIconAndName.IsChecked;
					settings.RememberLastConfigPage = ToggleRememberLastConfigPage.IsChecked;
					settings.RestoreOriginEventIfMouseDownTimeout = ToggleRestoreOriginEventIfMouseDownTimeout.IsChecked;
					settings.MatchSpaceAsWildcard = ChkMatchSpaceAsWildcard.IsChecked == true;
					settings.MatchUpperCaseEqual = ChkMatchUpperCaseEqual.IsChecked == true;
					settings.EnableUiAutomation = !ToggleDisableUiAutomation.IsChecked;
					settings.ShowRunningCountOnTrayIcon = ToggleShowRunningCountOnTrayIcon.IsChecked;
					return true;
				}
				break;
			}
		}
	}

	private void AutoStartToggle_OnToggled(object sender, RoutedEventArgs e)
	{
		if (base.IsDataLoaded)
		{
			AutoStartHelper.SetAutoStart(AutoStartToggle.IsChecked);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnCheckVersion_OnClick_003Ed__5))]
	private void eTpnH0Bkv3(object sender, RoutedEventArgs e)
	{
		_003CBtnCheckVersion_OnClick_003Ed__5 stateMachine = default(_003CBtnCheckVersion_OnClick_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void uDrn15XO9N()
	{
		try
		{
			Quicker.Properties.Settings.Default.Channel = ((RbChannelFast.IsChecked == true) ? "fast" : "slow");
			Quicker.Properties.Settings.Default.Save();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("保存失败！" + ex.Message, true);
		}
	}

	private void JGxnbkxIEh(object sender, RoutedEventArgs e)
	{
		if (base.IsDataLoaded)
		{
			uDrn15XO9N();
		}
	}

	private void eF4n6EgZnY(object sender, RoutedEventArgs e)
	{
		if (base.IsDataLoaded)
		{
			uDrn15XO9N();
		}
	}

	private void ProxySettingsControl_OnProxySettingsChanged(object sender, EventArgs e)
	{
		AO7eLUM7kJyEdiOQu2O.I4ULM7Vyvra(ProxySettingsControl.ProxySettings);
		try
		{
			AppHelper.UpdateProxySettings();
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("更新设置失败！" + exception.GetMessageWithInner());
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!DaunmLh3ap)
		{
			DaunmLh3ap = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/basicsettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 2;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 30:
				LblVersion = (TextBlock)target;
				num2 = 0;
				if (!I2wGvYwPSoqK9w0boRo())
				{
					goto IL_0024;
				}
				goto IL_0028;
			default:
				num2 = 1;
				if (KmkBCwwg2Wkd5NOFTD0 != null)
				{
					goto IL_0024;
				}
				goto IL_0028;
			case 1:
				AutoStartToggle = (BooleanSettingControl)target;
				return;
			case 2:
				ToggleShowStartupTip = (BooleanSettingControl)target;
				return;
			case 3:
				ProxySettingsControl = (ProxySettingsControl)target;
				return;
			case 4:
				ToggleSyncIgnoreNetworkState = (BooleanSettingControl)target;
				return;
			case 5:
				ToggleShowActionNewVersionTip = (BooleanSettingControl)target;
				return;
			case 6:
				ToggleEnableCyclePaging = (BooleanSettingControl)target;
				return;
			case 7:
				ToggleShowNewExeSettingTips = (BooleanSettingControl)target;
				return;
			case 8:
				ToggleShowMenuWhenLeftClickEmptyButton = (BooleanSettingControl)target;
				return;
			case 9:
				ToggleHideContextProcessIcon = (BooleanSettingControl)target;
				return;
			case 10:
				ToggleHidePanelToolTip = (BooleanSettingControl)target;
				return;
			case 11:
				TxtMoveTriggerDistance = (NumericUpDown)target;
				return;
			case 12:
				TxtRightBtnPopupDelayMs = (NumericUpDown)target;
				return;
			case 13:
				TxtDbClickIntervalMs = (NumericUpDown)target;
				return;
			case 14:
				ToggleAutoDetectHook = (BooleanSettingControl)target;
				return;
			case 15:
				ToggleAutoResetKeyboardState = (BooleanSettingControl)target;
				return;
			case 16:
				ToggleRestoreOriginEventIfMouseDownTimeout = (BooleanSettingControl)target;
				return;
			case 17:
				ChkFloatUseLeftButtonOnPanel = (BooleanSettingControl)target;
				return;
			case 18:
				ChkLoadFloatButtonState = (BooleanSettingControl)target;
				return;
			case 19:
				ChkFloatButtonBindProcessByDefault = (BooleanSettingControl)target;
				return;
			case 20:
				ChkDisableMiddleClickCloseFloat = (BooleanSettingControl)target;
				return;
			case 21:
				ChkDisableResizeFloatButton = (BooleanSettingControl)target;
				return;
			case 22:
				ChkShowTextFloatPanel = (BooleanSettingControl)target;
				return;
			case 23:
				ChkMatchSpaceAsWildcard = (CheckBox)target;
				return;
			case 24:
				ChkMatchUpperCaseEqual = (CheckBox)target;
				return;
			case 25:
				CbTrayIconType = (System.Windows.Controls.ComboBox)target;
				return;
			case 26:
				ToggleShowRunningCountOnTrayIcon = (BooleanSettingControl)target;
				return;
			case 27:
				ToggleKeepActionLocalIconAndName = (BooleanSettingControl)target;
				return;
			case 28:
				ToggleRememberLastConfigPage = (BooleanSettingControl)target;
				return;
			case 29:
				ToggleDisableUiAutomation = (BooleanSettingControl)target;
				return;
			case 31:
				BtnCheckVersion = (Button)target;
				BtnCheckVersion.Click += eTpnH0Bkv3;
				return;
			case 32:
				RbChannelSlow = (RadioButton)target;
				RbChannelSlow.Checked += JGxnbkxIEh;
				return;
			case 33:
				RbChannelFast = (RadioButton)target;
				goto IL_02c5;
			case 34:
				{
					RbChannelPreview = (RadioButton)target;
					RbChannelPreview.Checked += eF4n6EgZnY;
					return;
				}
				IL_0024:
				num2 = num;
				goto IL_0028;
				IL_0028:
				switch (num2)
				{
				default:
					return;
				case 2:
					goto end_IL_0058;
				case 0:
					return;
				case 1:
					DaunmLh3ap = true;
					return;
				case 4:
					return;
				case 3:
					break;
				}
				goto IL_02c5;
				IL_02c5:
				RbChannelFast.Checked += eF4n6EgZnY;
				return;
				end_IL_0058:
				break;
			}
		}
	}

	static BasicSettings()
	{
		ooXnXfsYBI = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool I2wGvYwPSoqK9w0boRo()
	{
		return KmkBCwwg2Wkd5NOFTD0 == null;
	}

	internal static void giwpbMw4HhrDXwAdjQq()
	{
	}
}
