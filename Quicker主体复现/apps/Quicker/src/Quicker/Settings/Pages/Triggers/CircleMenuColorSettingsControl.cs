using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using EOqy55MyMeuU2apYyog;
using Quicker.Common.Entities;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View;
using Xceed.Wpf.Toolkit;

namespace Quicker.Settings.Pages.Triggers;

public class CircleMenuColorSettingsControl : UserControl, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSelectColor_OnClick_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CircleMenuColorSettingsControl _003C_003E4__this;

		private ColorSelectorWindow _003CcolorSelectWindow_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object Au7na6coanyA17FpFmQH;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CircleMenuColorSettingsControl circleMenuColorSettingsControl = _003C_003E4__this;
			try
			{
				Color value;
				int num2;
				if (num != 0)
				{
					value = Colors.White;
					if (!string.IsNullOrEmpty(circleMenuColorSettingsControl.TxtCircleMenuBgFill.Text) && circleMenuColorSettingsControl.TxtCircleMenuBgFill.Text.StartsWith("#"))
					{
						value = ColorHelper.StringToColor(circleMenuColorSettingsControl.TxtCircleMenuBgFill.Text);
						num2 = 0;
						if (Au7na6coanyA17FpFmQH != null)
						{
							goto IL_0078;
						}
						goto IL_007c;
					}
					goto IL_0089;
				}
				TaskAwaiter<bool?> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0109;
				IL_007c:
				switch (num2)
				{
				case 1:
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0089;
				IL_0078:
				int num3 = default(int);
				num2 = num3;
				goto IL_007c;
				IL_0109:
				awaiter.GetResult();
				if (_003CcolorSelectWindow_003E5__2.SelectedColor.HasValue)
				{
					circleMenuColorSettingsControl.TxtCircleMenuBgFill.Text = _003CcolorSelectWindow_003E5__2.SelectedColor.ToString();
				}
				goto end_IL_0010;
				IL_0089:
				_003CcolorSelectWindow_003E5__2 = new ColorSelectorWindow(value)
				{
					Owner = Window.GetWindow(circleMenuColorSettingsControl)
				};
				awaiter = _003CcolorSelectWindow_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num2 = 1;
					if (Au7na6coanyA17FpFmQH != null)
					{
						goto IL_0078;
					}
					goto IL_007c;
				}
				goto IL_0109;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CcolorSelectWindow_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CcolorSelectWindow_003E5__2 = null;
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

		internal static bool Vohajscor2MnAxqQoMvf()
		{
			return Au7na6coanyA17FpFmQH == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnUpload_OnClick_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CircleMenuColorSettingsControl _003C_003E4__this;

		private TaskAwaiter<(bool isSuccess, string urlOrMessage)> _003C_003Eu__1;

		private static object geoZ7Acou9nIH5QDAJgY;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CircleMenuColorSettingsControl circleMenuColorSettingsControl = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<(bool, string)> awaiter;
					if (num != 0)
					{
						circleMenuColorSettingsControl.BtnUpload.IsEnabled = false;
						awaiter = AppHelper.UploadImageAsync(circleMenuColorSettingsControl.TxtCircleMenuBgFill.Text, UserFileType.CircleMenuBackground).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
						num = -1;
						_003C_003E1__state = -1;
						int num2 = 0;
						if (geoZ7Acou9nIH5QDAJgY != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
					}
					(bool, string) result = awaiter.GetResult();
					if (result.Item1)
					{
						circleMenuColorSettingsControl.TxtCircleMenuBgFill.Text = result.Item2;
					}
					else
					{
						AppHelper.ShowWarning(result.Item2);
					}
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("上传失败。" + exception.GetMessageWithInner());
				}
				finally
				{
					if (num < 0)
					{
						circleMenuColorSettingsControl.BtnUpload.IsEnabled = true;
					}
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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

		internal static bool vkrMPFcooOGa8h7iif46()
		{
			return geoZ7Acou9nIH5QDAJgY == null;
		}
	}

	internal ColorPicker ClrPickerCircleMenuLabelColor;

	internal ColorPicker ClrPickerCircleMenuIconColor;

	internal ColorPicker ClrPickerCircleMenuButtonBgColor;

	internal ColorPicker ClrPickerCircleMenuButtonHoverColor;

	internal ColorPicker ClrPickerCircleMenuButtonSpaceColor;

	internal ColorPicker ClrPickerCircleMenuIndicateLineColor;

	internal CheckBox ChkCircleMenuShowShadow;

	internal TextBox TxtCircleMenuBgFill;

	internal Button BtnSelectFile;

	internal Button BtnUpload;

	internal Button BtnSelectColor;

	internal Slider SliderCircleMenuOpacity;

	internal ColorPicker ClrPickerCircleMenuBgOverlay;

	internal Slider SliderCircleMenuBgOverlayOpacity;

	private bool mq0dcSLldw;

	private static CircleMenuColorSettingsControl ejFFBHsPGYmCM5eV7tI;

	public CircleMenuColorSettingsControl()
	{
		InitializeComponent();
	}

	public void SetData(UiSettings uiSettings)
	{
		ClrPickerCircleMenuLabelColor.SelectedColor = ColorHelper.StringToColor(uiSettings.CircleMenu.LabelColor);
		ClrPickerCircleMenuIconColor.SelectedColor = ColorHelper.StringToColor(uiSettings.CircleMenu.DefaultIconColor);
		int num = 0;
		if (ejFFBHsPGYmCM5eV7tI != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ClrPickerCircleMenuButtonBgColor.SelectedColor = ColorHelper.StringToColor(uiSettings.CircleMenu.ButtonBgColor);
		ClrPickerCircleMenuButtonHoverColor.SelectedColor = ColorHelper.StringToColor(uiSettings.CircleMenu.ButtonHoverColor);
		ClrPickerCircleMenuButtonSpaceColor.SelectedColor = ColorHelper.StringToColor(uiSettings.CircleMenu.ButtonSpaceColor);
		ClrPickerCircleMenuIndicateLineColor.SelectedColor = ColorHelper.StringToColor(uiSettings.CircleMenu.IndicateLineColor);
		SliderCircleMenuOpacity.Value = uiSettings.CircleMenu.BgOpacity;
		TxtCircleMenuBgFill.Text = uiSettings.CircleMenu.BgFill;
		SliderCircleMenuBgOverlayOpacity.Value = uiSettings.CircleMenu.BgOverlyOpacity;
		ClrPickerCircleMenuBgOverlay.SelectedColor = ColorHelper.StringToColor(uiSettings.CircleMenu.BgOverlyFill);
		ChkCircleMenuShowShadow.IsChecked = uiSettings.CircleMenu.ShowShadow;
	}

	public void SaveData(UiSettings uiSettings)
	{
		while (true)
		{
			uiSettings.CircleMenu.LabelColor = ClrPickerCircleMenuLabelColor.SelectedColor.ToString();
			if (ejFFBHsPGYmCM5eV7tI == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		uiSettings.CircleMenu.ButtonHoverColor = ClrPickerCircleMenuButtonHoverColor.SelectedColor.ToString();
		uiSettings.CircleMenu.DefaultIconColor = ClrPickerCircleMenuIconColor.SelectedColor.ToString();
		uiSettings.CircleMenu.ButtonBgColor = ClrPickerCircleMenuButtonBgColor.SelectedColor.ToString();
		uiSettings.CircleMenu.ButtonSpaceColor = ClrPickerCircleMenuButtonSpaceColor.SelectedColor.ToString();
		uiSettings.CircleMenu.IndicateLineColor = ClrPickerCircleMenuIndicateLineColor.SelectedColor.ToString();
		uiSettings.CircleMenu.BgOpacity = SliderCircleMenuOpacity.Value;
		uiSettings.CircleMenu.BgFill = TxtCircleMenuBgFill.Text;
		uiSettings.CircleMenu.BgOverlyOpacity = SliderCircleMenuBgOverlayOpacity.Value;
		uiSettings.CircleMenu.BgOverlyFill = ClrPickerCircleMenuBgOverlay.SelectedColor.ToString();
		uiSettings.CircleMenu.ShowShadow = ChkCircleMenuShowShadow.IsChecked == true;
	}

	private void D1Qdar6vwW(object sender, TextChangedEventArgs e)
	{
		string text = TxtCircleMenuBgFill.Text;
		bool flag = !string.IsNullOrEmpty(text) && !text.StartsWith("#", StringComparison.Ordinal) && !text.StartsWith("http", StringComparison.OrdinalIgnoreCase) && File.Exists(text);
		BtnUpload.Visibility = ((!flag) ? Visibility.Collapsed : Visibility.Visible);
	}

	[AsyncStateMachine(typeof(_003CBtnUpload_OnClick_003Ed__4))]
	private void HFvd72itdl(object sender, RoutedEventArgs e)
	{
		_003CBtnUpload_OnClick_003Ed__4 stateMachine = default(_003CBtnUpload_OnClick_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Ro4dRKlhST(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSelectFileDialog("图片文件(*.jpg,*.png)|*.jpg;*.png;", "", "", "", "选择背景图片");
		if (tuple.Item1)
		{
			TxtCircleMenuBgFill.Text = tuple.Item2;
		}
	}

	[AsyncStateMachine(typeof(_003CBtnSelectColor_OnClick_003Ed__6))]
	private void uLldqphYiH(object sender, RoutedEventArgs e)
	{
		_003CBtnSelectColor_OnClick_003Ed__6 stateMachine = default(_003CBtnSelectColor_OnClick_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!mq0dcSLldw)
		{
			mq0dcSLldw = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/circlemenucolorsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			mq0dcSLldw = true;
			break;
		case 1:
			ClrPickerCircleMenuLabelColor = (ColorPicker)target;
			break;
		case 2:
			ClrPickerCircleMenuIconColor = (ColorPicker)target;
			num = 1;
			if (!Ue0IjJsMbvPZhx3Fl4f())
			{
				goto IL_013c;
			}
			goto IL_0140;
		case 3:
			ClrPickerCircleMenuButtonBgColor = (ColorPicker)target;
			break;
		case 4:
			ClrPickerCircleMenuButtonHoverColor = (ColorPicker)target;
			break;
		case 5:
			ClrPickerCircleMenuButtonSpaceColor = (ColorPicker)target;
			break;
		case 6:
			ClrPickerCircleMenuIndicateLineColor = (ColorPicker)target;
			break;
		case 7:
			ChkCircleMenuShowShadow = (CheckBox)target;
			break;
		case 8:
			TxtCircleMenuBgFill = (TextBox)target;
			TxtCircleMenuBgFill.TextChanged += D1Qdar6vwW;
			break;
		case 9:
			BtnSelectFile = (Button)target;
			BtnSelectFile.Click += Ro4dRKlhST;
			break;
		case 10:
			BtnUpload = (Button)target;
			BtnUpload.Click += HFvd72itdl;
			break;
		case 11:
			BtnSelectColor = (Button)target;
			num = 0;
			if (ejFFBHsPGYmCM5eV7tI != null)
			{
				goto IL_013c;
			}
			goto IL_0140;
		case 12:
			SliderCircleMenuOpacity = (Slider)target;
			break;
		case 13:
			ClrPickerCircleMenuBgOverlay = (ColorPicker)target;
			break;
		case 14:
			{
				SliderCircleMenuBgOverlayOpacity = (Slider)target;
				break;
			}
			IL_013c:
			num = num2;
			goto IL_0140;
			IL_0140:
			switch (num)
			{
			default:
				BtnSelectColor.Click += uLldqphYiH;
				break;
			case 1:
				break;
			}
			break;
		}
	}

	internal static bool Ue0IjJsMbvPZhx3Fl4f()
	{
		return ejFFBHsPGYmCM5eV7tI == null;
	}
}
