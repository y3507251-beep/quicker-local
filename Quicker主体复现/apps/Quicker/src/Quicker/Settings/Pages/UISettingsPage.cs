using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Skin;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Settings.Code;
using Quicker.Settings.Pages.Basic.UI;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View;

namespace Quicker.Settings.Pages;

public class UISettingsPage : SettingPage, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnShare_OnClick_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UISettingsPage _003C_003E4__this;

		private WaitWindow _003CwaitDialog_003E5__2;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__1;

		private TaskAwaiter<ApiResult<Guid>> _003C_003Eu__2;

		private static object EyUQbnc9BO6wBOrAD33n;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UISettingsPage uISettingsPage = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					if (AppState.DataService.BV9tm7kpqII())
					{
						AppHelper.ShowWarning("演示帐号不支持此功能。");
					}
					else if (!AppState.DataService.Hb9tmk3OsJ7())
					{
						AppHelper.ShowWarning("免费版不支持此功能。");
					}
					else
					{
						UiSettings uiSettings = (uISettingsPage.IsShouldShareDarkUiSettings() ? uISettingsPage.o554w18RLo.DarkUiSettings : uISettingsPage.o554w18RLo.UiSettings);
						if (!string.IsNullOrEmpty(uiSettings.BackgroundImage) && !uiSettings.BackgroundImage.StartsWith("http", StringComparison.OrdinalIgnoreCase))
						{
							AppHelper.ShowWarning("请先上传背景图（将其转换为网络图片）后再分享。");
						}
						else
						{
							new ShareUiWindow(uiSettings).Show();
						}
					}
				}
				else
				{
					try
					{
						TaskAwaiter<ApiResult<string>> awaiter;
						int num2;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0126;
							}
							string string_ = default(string);
							awaiter = aFIptTXYsUoTUF4v33R.GlYtbJkn8Qq(string_, UserFileType.SkinPreview).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								num2 = 0;
								if (EyUQbnc9BO6wBOrAD33n != null)
								{
									goto IL_00e9;
								}
								goto IL_010e;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<ApiResult<string>>);
							num = -1;
							_003C_003E1__state = -1;
						}
						ApiResult<string> result = awaiter.GetResult();
						TaskAwaiter<ApiResult<Guid>> awaiter2;
						if (result.IsSuccess)
						{
							string name = default(string);
							awaiter2 = aFIptTXYsUoTUF4v33R.y7itb0LejF6(new ShareSkinVm
							{
								Name = name,
								PrevImageUrl = result.Data,
								UiSettingsDataJson = JsonConvert.SerializeObject(uISettingsPage.o554w18RLo.UiSettings)
							}).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01bc;
						}
						AppHelper.ShowWarning("上传预览图失败！" + result.Message, true);
						goto end_IL_00af;
						IL_01bc:
						ApiResult<Guid> result2 = awaiter2.GetResult();
						if (result2.IsSuccess)
						{
							AppHelper.ShowSuccess("分享成功！");
							AppHelper.TryOpenUrlOrFile("https://getquicker.net/skins");
						}
						else
						{
							AppHelper.ShowWarning("分享失败！" + result2.Message, true);
						}
						goto end_IL_00af;
						IL_010e:
						switch (num2)
						{
						case 1:
							return;
						case 2:
							goto IL_0126;
						}
						goto IL_00e9;
						IL_00e9:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 1;
						if (EyUQbnc9BO6wBOrAD33n != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_010e;
						IL_0126:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ApiResult<Guid>>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_01bc;
						end_IL_00af:;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("分享遇到异常！" + ex.Message, true);
					}
					finally
					{
						if (num < 0 && _003CwaitDialog_003E5__2.IsVisible)
						{
							_003CwaitDialog_003E5__2.Close();
						}
					}
					_003CwaitDialog_003E5__2 = null;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CwaitDialog_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CwaitDialog_003E5__2 = null;
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

		static _003CBtnShare_OnClick_003Ed__17()
		{
		}

		internal static bool dUpSM9c9v4hxf7ZrUoxi()
		{
			return EyUQbnc9BO6wBOrAD33n == null;
		}

		internal static void BSbIysc9krajcwNyHfWY()
		{
		}
	}

	private bool EOTn3144cw;

	private UiSettings y17nfb7XZr;

	private UiSettings IEDnzp6o6Q;

	private UserSettings o554w18RLo;

	[CompilerGenerated]
	private static readonly IList<KeyValuePair<string, UiSettings>> MfI4t8P4yC;

	private bool z8o4gIXsBK;

	private readonly DebounceDispatcher pxD4LYlyfY = new DebounceDispatcher();

	internal CheckBox ChkSwitchUiSettingsBasedOnTheme;

	internal TabControl TabColors;

	internal UiColorSettingsControl DefaultColorSettingsControl;

	internal UiColorSettingsControl DarkColorSettingsControl;

	internal ContextMenu SampleUiMenu;

	internal Button BtnShare;

	internal Button BtnMyShare;

	internal Button BtnSkinLib;

	internal Button BtnGoCircleMenuSettings;

	internal Button BtnRestore;

	private bool lFj4v96QBY;

	internal static UISettingsPage Uyq4X9TQKbSZrKi25xb;

	public UISettingsPage()
	{
		InitializeComponent();
		k93nQZgq24();
		BtnShare.IsEnabled = (ChkSwitchUiSettingsBasedOnTheme.IsEnabled = AppState.DataService.FjftbTOtevj());
	}

	[SpecialName]
	private UiColorSettingsControl eOsnFhHVpA()
	{
		if (TabColors.SelectedIndex != 0)
		{
			return DarkColorSettingsControl;
		}
		return DefaultColorSettingsControl;
	}

	private static Rect rlSnBAe9ko(Window window_0)
	{
		return new Rect
		{
			X = window_0.Left,
			Y = window_0.Top,
			Width = window_0.ActualWidth,
			Height = window_0.ActualHeight
		};
	}

	private void k93nQZgq24()
	{
		foreach (KeyValuePair<string, UiSettings> item in MfI4t8P4yC)
		{
			MenuItem menuItem = new MenuItem
			{
				Header = item.Key,
				Tag = item.Value
			};
			menuItem.Click += UxEnjNkRLY;
			SampleUiMenu.Items.Add(menuItem);
		}
	}

	private void UxEnjNkRLY(object sender, RoutedEventArgs e)
	{
		if (!((sender as MenuItem)?.Tag is UiSettings data))
		{
			AppHelper.ShowWarning("设置数据为空！不应该发生，请反馈");
			return;
		}
		z8o4gIXsBK = true;
		try
		{
			eOsnFhHVpA().SetData(data);
		}
		finally
		{
			z8o4gIXsBK = false;
			S3kn5LeYgH();
		}
	}

	private static IList<KeyValuePair<string, UiSettings>> H0fnnWjn6w()
	{
		return new List<KeyValuePair<string, UiSettings>>
		{
			new KeyValuePair<string, UiSettings>("原始", new UiSettings
			{
				BackgroundColor = "#99B0B0B0",
				ButtonSize = 79.0,
				ButtonSpace = 1.0,
				FrameBorderWidth = 10.0,
				HideLabelIfHasIcon = false,
				ButtonBgColor = "#FFFFFFFF",
				InvalidButtonBgColor = "#32c8c8c8",
				BlurMode = 3,
				BlurOpacity = 0u,
				HoverColor = "#FFB2F2FF",
				LabelColor = "#FF000000"
			}),
			new KeyValuePair<string, UiSettings>("小白", new UiSettings
			{
				BackgroundColor = "#C5CCCCCC",
				ButtonSize = 72.0,
				ButtonSpace = 0.2,
				FrameBorderWidth = 0.0,
				HideLabelIfHasIcon = false,
				ButtonBgColor = "#FFFFFFFF",
				InvalidButtonBgColor = "#32c8c8c8",
				BlurMode = 3,
				BlurOpacity = 89u,
				HoverColor = "#59B2F2FF",
				LabelColor = "#FF000000"
			}),
			new KeyValuePair<string, UiSettings>("半透", new UiSettings
			{
				BackgroundColor = "#60FFFFFF",
				ButtonSize = 72.0,
				ButtonSpace = 0.0,
				FrameBorderWidth = 0.0,
				HideLabelIfHasIcon = false,
				ButtonBgColor = "#9DFFFFFF",
				InvalidButtonBgColor = "#32c8c8c8",
				BlurMode = 3,
				BlurOpacity = 89u,
				HoverColor = "#59B2F2FF",
				LabelColor = "#FF000000"
			}),
			new KeyValuePair<string, UiSettings>("深色", new UiSettings
			{
				BackgroundColor = "#C5737373",
				ButtonSize = 72.0,
				ButtonSpace = 0.5,
				FrameBorderWidth = 0.0,
				HideLabelIfHasIcon = false,
				ButtonBgColor = "#31000000",
				InvalidButtonBgColor = "#38000000",
				ToolbarBtnColor = "#FF000000",
				BlurMode = 3,
				BlurOpacity = 0u,
				HoverColor = "#59D7D7D7",
				LabelColor = "#FFFFFFFF",
				DefaultIconColor = "#F0F0F0"
			}),
			new KeyValuePair<string, UiSettings>("深色半透", new UiSettings
			{
				BackgroundColor = "#355E5E5E",
				ButtonSize = 72.0,
				ButtonSpace = 0.0,
				FrameBorderWidth = 0.0,
				HideLabelIfHasIcon = false,
				ButtonBgColor = "#31000000",
				InvalidButtonBgColor = "#38000000",
				ToolbarBtnColor = "#AA000000",
				BlurMode = 3,
				BlurOpacity = 0u,
				HoverColor = "#59D7D7D7",
				LabelColor = "#FFFFFFFF",
				DefaultIconColor = "#F0F0F0"
			})
		};
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		o554w18RLo = settings;
		y17nfb7XZr = JsonConvert.DeserializeObject<UiSettings>(JsonConvert.SerializeObject(settings.UiSettings));
		DefaultColorSettingsControl.SetData(settings.UiSettings);
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			ChkSwitchUiSettingsBasedOnTheme.Visibility = Visibility.Collapsed;
			(TabColors.Items[1] as TabItem).Visibility = Visibility.Collapsed;
		}
		else
		{
			ChkSwitchUiSettingsBasedOnTheme.IsChecked = AppState.DataService.Hb9tmk3OsJ7() && settings.SwitchUiSettingsBasedOnTheme;
			if (IEDnzp6o6Q == null)
			{
				IEDnzp6o6Q = ((settings.DarkUiSettings == null) ? AppHelper.Clone(settings.UiSettings) : AppHelper.Clone(settings.DarkUiSettings));
			}
			DarkColorSettingsControl.SetData(IEDnzp6o6Q);
			int num = 0;
			if (Uyq4X9TQKbSZrKi25xb != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (settings.SwitchUiSettingsBasedOnTheme && App.Current.n991yfUy4r())
			{
				TabColors.SelectedIndex = 1;
			}
		}
		EOTn3144cw = true;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		if (EOTn3144cw)
		{
			settings.SwitchUiSettingsBasedOnTheme = ChkSwitchUiSettingsBasedOnTheme.IsChecked == true && AppState.DataService.Hb9tmk3OsJ7();
			DefaultColorSettingsControl.SaveData(settings.UiSettings);
			if (settings.DarkUiSettings == null)
			{
				settings.DarkUiSettings = AppHelper.Clone(settings.UiSettings);
			}
			DarkColorSettingsControl.SaveData(settings.DarkUiSettings);
		}
		return true;
	}

	public bool IsShouldShareDarkUiSettings()
	{
		if (App.Current.n991yfUy4r())
		{
			return ChkSwitchUiSettingsBasedOnTheme.IsChecked == true;
		}
		return false;
	}

	[AsyncStateMachine(typeof(_003CBtnShare_OnClick_003Ed__17))]
	private void hHtn4034Ye(object sender, RoutedEventArgs e)
	{
		_003CBtnShare_OnClick_003Ed__17 stateMachine = default(_003CBtnShare_OnClick_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void S3kn5LeYgH()
	{
		if (EOTn3144cw && !z8o4gIXsBK)
		{
			pxD4LYlyfY.Throttle(300, jgMnONnLow);
		}
	}

	private void DefaultColorSettingsControl_OnColorChanged(object sender, EventArgs e)
	{
		S3kn5LeYgH();
	}

	private void DarkColorSettingsControl_OnColorChanged(object sender, EventArgs e)
	{
		S3kn5LeYgH();
	}

	private void AuInDLP48l(object sender, RoutedEventArgs e)
	{
		DefaultColorSettingsControl.SetData(y17nfb7XZr);
		if (IEDnzp6o6Q != null)
		{
			DarkColorSettingsControl.SetData(IEDnzp6o6Q);
		}
		S3kn5LeYgH();
	}

	private bool bWIndB7w7D()
	{
		if (!string.Equals(JsonConvert.SerializeObject(y17nfb7XZr), JsonConvert.SerializeObject(o554w18RLo.UiSettings), StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		if (IEDnzp6o6Q != null)
		{
			return !string.Equals(JsonConvert.SerializeObject(IEDnzp6o6Q), JsonConvert.SerializeObject(o554w18RLo.DarkUiSettings));
		}
		return false;
	}

	private void PHwnoITFXd(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile("https://getquicker.net/Skins");
	}

	private void RbynTemOl3(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile("https://getquicker.net/Skins/MySkins");
	}

	private void sxbnMeQolK(object sender, RoutedEventArgs e)
	{
		if (ChkSwitchUiSettingsBasedOnTheme.IsChecked != true)
		{
			TabColors.SelectedIndex = 0;
		}
		S3kn5LeYgH();
	}

	private void eA7nAMcD2X(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.CircleMenuSettingPage);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!lFj4v96QBY)
		{
			lFj4v96QBY = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/ui/uisettingspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 8:
				BtnSkinLib = (Button)target;
				BtnSkinLib.Click += PHwnoITFXd;
				num2 = 2;
				if (!IvF7D9TFdHUMn4fxab1())
				{
					num2 = num;
				}
				goto IL_003f;
			default:
				num2 = 0;
				if (Uyq4X9TQKbSZrKi25xb != null)
				{
					goto IL_003f;
				}
				goto IL_0152;
			case 1:
				ChkSwitchUiSettingsBasedOnTheme = (CheckBox)target;
				ChkSwitchUiSettingsBasedOnTheme.Checked += sxbnMeQolK;
				ChkSwitchUiSettingsBasedOnTheme.Unchecked += sxbnMeQolK;
				return;
			case 2:
				TabColors = (TabControl)target;
				return;
			case 3:
				DefaultColorSettingsControl = (UiColorSettingsControl)target;
				return;
			case 4:
				DarkColorSettingsControl = (UiColorSettingsControl)target;
				return;
			case 5:
				SampleUiMenu = (ContextMenu)target;
				return;
			case 6:
				BtnShare = (Button)target;
				BtnShare.Click += hHtn4034Ye;
				return;
			case 7:
				BtnMyShare = (Button)target;
				BtnMyShare.Click += RbynTemOl3;
				return;
			case 9:
				BtnGoCircleMenuSettings = (Button)target;
				BtnGoCircleMenuSettings.Click += eA7nAMcD2X;
				return;
			case 10:
				{
					BtnRestore = (Button)target;
					BtnRestore.Click += AuInDLP48l;
					return;
				}
				IL_0152:
				lFj4v96QBY = true;
				return;
				IL_003f:
				switch (num2)
				{
				case 1:
					goto end_IL_0066;
				case 2:
					return;
				}
				goto IL_0152;
				end_IL_0066:
				break;
			}
		}
	}

	static UISettingsPage()
	{
		MfI4t8P4yC = H0fnnWjn6w();
	}

	[CompilerGenerated]
	private void jgMnONnLow(object object_0)
	{
		if (SaveDataFromUi(o554w18RLo))
		{
			AppState.HS2taepcAbc().UpdateUIAppearence(o554w18RLo);
		}
		if (!bWIndB7w7D())
		{
			BtnRestore.Visibility = Visibility.Collapsed;
		}
		else
		{
			BtnRestore.Visibility = Visibility.Visible;
		}
	}

	internal static void rl9ejjTWGC3eqKxhAa2()
	{
	}

	internal static bool IvF7D9TFdHUMn4fxab1()
	{
		return Uyq4X9TQKbSZrKi25xb == null;
	}
}
