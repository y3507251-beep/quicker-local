using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Xceed.Wpf.Toolkit;

namespace Quicker.Settings.Pages.Basic.UI;

public class UiColorSettingsControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec cGKvhihgZKN;

		public static Func<string, string> lEqvh3Wg2PV;

		private static _003C_003Ec bwgDkwcbqe7G1rsS86yu;

		static _003C_003Ec()
		{
			cGKvhihgZKN = new _003C_003Ec();
		}

		internal string a1XvhlsL9VV(string x)
		{
			return x;
		}

		internal static bool ek0ywacbiukUHLN4vi4a()
		{
			return bwgDkwcbqe7G1rsS86yu == null;
		}

		internal static void R12VjvcbZW1wNm6dcGLM()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public UiSettings rTivewimHHM;

		internal static _003C_003Ec__DisplayClass9_0 RMZOshcb5jAVIpX7U7YT;

		internal bool cP9vhf6IovR(SelectionItem x)
		{
			return x.Value == rTivewimHHM.BlurMode.ToString(CultureInfo.InvariantCulture);
		}

		internal bool DQWvhz6TXYM(SelectionItem x)
		{
			return x.Value == rTivewimHHM.RoundCornerMode.ToString();
		}

		internal static bool sKPZI0cbYQVf8gPnx6j0()
		{
			return RMZOshcb5jAVIpX7U7YT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnUpload_OnClick_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UiColorSettingsControl _003C_003E4__this;

		private TaskAwaiter<(bool isSuccess, string urlOrMessage)> _003C_003Eu__1;

		private static object IAtxOjcbRyrpolSCtC23;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UiColorSettingsControl uiColorSettingsControl = _003C_003E4__this;
			try
			{
				if (num != 0 && !AppState.DataService.Hb9tmk3OsJ7())
				{
					AppHelper.ShowWarning("上传背景图需专业版。");
				}
				else
				{
					try
					{
						TaskAwaiter<(bool, string)> awaiter;
						if (num != 0)
						{
							uiColorSettingsControl.BtnUpload.IsEnabled = false;
							awaiter = AppHelper.UploadImageAsync(uiColorSettingsControl.TxtBackgroundImagePath.Text, UserFileType.PanelBackground).GetAwaiter();
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
						}
						(bool, string) result = awaiter.GetResult();
						if (result.Item1)
						{
							if (!uJuSYkcbgYjqJvO9aeE3())
							{
								switch (0)
								{
								}
							}
							uiColorSettingsControl.TxtBackgroundImagePath.Text = result.Item2;
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
							uiColorSettingsControl.BtnUpload.IsEnabled = true;
						}
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

		internal static bool uJuSYkcbgYjqJvO9aeE3()
		{
			return IAtxOjcbRyrpolSCtC23 == null;
		}
	}

	private bool tPMM3hO8rB;

	private readonly IList<SelectionItem> GqAMfD71ST = new ObservableCollection<SelectionItem>
	{
		new SelectionItem("0", "无"),
		new SelectionItem("3", "毛玻璃"),
		new SelectionItem("1", "无 (去除窗口阴影)")
	};

	private readonly IList<SelectionItem> mZHMzf5RTG = new ObservableCollection<SelectionItem>
	{
		new SelectionItem("0", "默认"),
		new SelectionItem("1", "无"),
		new SelectionItem("2", "圆角"),
		new SelectionItem("3", "小圆角")
	};

	private readonly SmartCollection<string> x69AwFr9Eu = new SmartCollection<string>();

	[CompilerGenerated]
	private EventHandler m_SettingsChanged;

	private readonly int z9LAtMPssY = 310000;

	internal Slider SliderButtonSize;

	internal Slider SliderButtonSpace;

	internal Slider SliderFrameBorderWidth;

	internal Slider SliderCornerRadius;

	internal ColorPicker ColorPickerBg;

	internal ColorPicker ColorPickerToolbar;

	internal ColorPicker ColorPickerToolbarBtn;

	internal ColorPicker ColorPickerButton;

	internal ColorPicker ColorPickerHover;

	internal ColorPicker ColorPickerInvalidButton;

	internal ColorPicker ColorPickerEmptyHover;

	internal ColorPicker ColorPickerLabel;

	internal ColorPicker ColorPickerIcon;

	internal ColorPicker ColorPickerKeyTip;

	internal ColorPicker ColorPickerIconForOtherUi;

	internal StackPanel PnlAdvanced;

	internal ComboBox CbFontEng;

	internal ComboBox CbFontChn;

	internal Slider SliderFontSize;

	internal ComboBox CbFontWeight;

	internal TextBox TxtBackgroundImagePath;

	internal Button BtnRemoveBackgroundImage;

	internal Button BtnSelectBackgroundImage;

	internal Button BtnUpload;

	internal Slider SliderBackgroundImageOpacity;

	internal ComboBox CbBlur;

	internal ComboBox CbRoundCorner;

	internal CheckBox ChkEnableResizeFont;

	internal CheckBox ChkEnableZoomEffect;

	internal CheckBox ChkHideLabelIfHasIcon;

	internal CheckBox ChkEnableShadow;

	private bool X92AgQdjyL;

	internal static UiColorSettingsControl YYfm9lhljU2ArtpReLj;

	public event EventHandler SettingsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_SettingsChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SettingsChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_SettingsChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SettingsChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public UiColorSettingsControl()
	{
		InitializeComponent();
		UTrMButxYh();
	}

	private void UTrMButxYh()
	{
		CbBlur.ItemsSource = GqAMfD71ST;
		CbRoundCorner.ItemsSource = mZHMzf5RTG;
		x69AwFr9Eu.Add("");
		try
		{
			XmlLanguage language = XmlLanguage.GetLanguage("zh-cn");
			foreach (FontFamily systemFontFamily in Fonts.SystemFontFamilies)
			{
				string item = systemFontFamily.Source;
				if (systemFontFamily.FamilyNames.ContainsKey(language))
				{
					item = systemFontFamily.FamilyNames[language];
				}
				x69AwFr9Eu.Add(item);
			}
			x69AwFr9Eu.Reset(x69AwFr9Eu.OrderBy(_003C_003Ec.lEqvh3Wg2PV ?? (_003C_003Ec.lEqvh3Wg2PV = _003C_003Ec.cGKvhihgZKN.a1XvhlsL9VV)).ToList());
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("枚举系统字体异常：" + ex.Message);
		}
		CbFontEng.ItemsSource = x69AwFr9Eu;
		CbFontChn.ItemsSource = x69AwFr9Eu;
		CbFontWeight.ItemsSource = new List<int> { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
		PnlAdvanced.IsEnabled = AppState.DataService.FjftbTOtevj();
	}

	public void SetData(UiSettings settings)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.rTivewimHHM = settings;
		ColorPickerButton.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.ButtonBgColor);
		ColorPickerInvalidButton.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.InvalidButtonBgColor);
		ColorPickerToolbar.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.ToolbarColor);
		ColorPickerBg.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.BackgroundColor);
		ColorPickerToolbarBtn.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.ToolbarBtnColor);
		ColorPickerIcon.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.DefaultIconColor);
		ColorPickerKeyTip.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.KeyTipColor);
		int num = 1;
		if (!X9pX83hZmqfy4nT08ME())
		{
			int num2 = default(int);
			num = num2;
		}
		do
		{
			switch (num)
			{
			case 2:
				goto IL_0116;
			case 1:
				ColorPickerIconForOtherUi.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.DefaultIconColorForOtherUi);
				ColorPickerLabel.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.LabelColor);
				ColorPickerHover.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.HoverColor);
				ColorPickerEmptyHover.SelectedColor = xKCMiZyXR3(_003C_003Ec__DisplayClass9_.rTivewimHHM.EmptyHoverColor);
				goto IL_0116;
			}
			break;
			IL_0116:
			SliderButtonSize.Value = _003C_003Ec__DisplayClass9_.rTivewimHHM.ButtonSize;
			SliderButtonSpace.Value = _003C_003Ec__DisplayClass9_.rTivewimHHM.ButtonSpace;
			SliderCornerRadius.Value = _003C_003Ec__DisplayClass9_.rTivewimHHM.ButtonCornerRadius;
			ChkHideLabelIfHasIcon.IsChecked = _003C_003Ec__DisplayClass9_.rTivewimHHM.HideLabelIfHasIcon;
			SliderFrameBorderWidth.Value = _003C_003Ec__DisplayClass9_.rTivewimHHM.FrameBorderWidth;
			SelectionItem selectedItem = GqAMfD71ST.FirstOrDefault(_003C_003Ec__DisplayClass9_.cP9vhf6IovR);
			CbBlur.SelectedItem = selectedItem;
			num = 0;
		}
		while (X9pX83hZmqfy4nT08ME());
		SelectionItem selectedItem2 = mZHMzf5RTG.FirstOrDefault(_003C_003Ec__DisplayClass9_.DQWvhz6TXYM);
		CbRoundCorner.SelectedItem = selectedItem2;
		ChkEnableZoomEffect.IsChecked = _003C_003Ec__DisplayClass9_.rTivewimHHM.EnableZoomEffect;
		TxtBackgroundImagePath.Text = _003C_003Ec__DisplayClass9_.rTivewimHHM.BackgroundImage;
		SliderBackgroundImageOpacity.Value = _003C_003Ec__DisplayClass9_.rTivewimHHM.BackgroundImageOpacity;
		CbFontEng.SelectedValue = _003C_003Ec__DisplayClass9_.rTivewimHHM.FontFamily1;
		CbFontChn.SelectedValue = _003C_003Ec__DisplayClass9_.rTivewimHHM.FontFamily2;
		CbFontWeight.SelectedValue = _003C_003Ec__DisplayClass9_.rTivewimHHM.FontWeight;
		SliderFontSize.Value = _003C_003Ec__DisplayClass9_.rTivewimHHM.FontSize;
		ChkEnableShadow.IsChecked = _003C_003Ec__DisplayClass9_.rTivewimHHM.EnableShadow;
		ChkEnableResizeFont.IsChecked = _003C_003Ec__DisplayClass9_.rTivewimHHM.EnableResizeFont;
		XE8MUKyE0d();
	}

	public void SaveData(UiSettings uiSettings)
	{
		uiSettings.BackgroundColor = ColorPickerBg.SelectedColor.ToString();
		uiSettings.ToolbarColor = ColorPickerToolbar.SelectedColor.ToString();
		uiSettings.ToolbarBtnColor = ColorPickerToolbarBtn.SelectedColor.ToString();
		uiSettings.ButtonBgColor = ColorPickerButton.SelectedColor.ToString();
		uiSettings.InvalidButtonBgColor = ColorPickerInvalidButton.SelectedColor.ToString();
		uiSettings.HoverColor = ColorPickerHover.SelectedColor.ToString();
		uiSettings.EmptyHoverColor = ColorPickerEmptyHover.SelectedColor.ToString();
		uiSettings.LabelColor = ColorPickerLabel.SelectedColor.ToString();
		uiSettings.DefaultIconColor = ColorPickerIcon.SelectedColor.ToString();
		uiSettings.DefaultIconColorForOtherUi = ColorPickerIconForOtherUi.SelectedColor.ToString();
		uiSettings.KeyTipColor = ColorPickerKeyTip.SelectedColor.ToString();
		uiSettings.HideLabelIfHasIcon = ChkHideLabelIfHasIcon.IsChecked == true;
		uiSettings.ButtonSize = SliderButtonSize.Value;
		uiSettings.ButtonSpace = SliderButtonSpace.Value;
		int num = 1;
		if (X9pX83hZmqfy4nT08ME())
		{
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					uiSettings.ButtonCornerRadius = SliderCornerRadius.Value;
					uiSettings.FrameBorderWidth = SliderFrameBorderWidth.Value;
					uiSettings.BlurMode = ((CbBlur.SelectedItem == null) ? 3 : Convert.ToInt32((CbBlur.SelectedItem as SelectionItem).Value, CultureInfo.InvariantCulture));
					num = 0;
					if (YYfm9lhljU2ArtpReLj != null)
					{
						num = num2;
					}
					continue;
				case 2:
					goto IL_02ab;
				}
				break;
			}
		}
		uiSettings.RoundCornerMode = ((CbRoundCorner.SelectedItem != null) ? Convert.ToInt32((CbRoundCorner.SelectedItem as SelectionItem).Value, CultureInfo.InvariantCulture) : 0);
		uiSettings.EnableZoomEffect = ChkEnableZoomEffect.IsChecked == true;
		uiSettings.BackgroundImage = TxtBackgroundImagePath.Text;
		uiSettings.BackgroundImageOpacity = SliderBackgroundImageOpacity.Value;
		uiSettings.FontFamily1 = Convert.ToString(CbFontEng.SelectedValue);
		goto IL_02ab;
		IL_02ab:
		uiSettings.FontFamily2 = Convert.ToString(CbFontChn.SelectedValue);
		uiSettings.FontWeight = Convert.ToInt32(CbFontWeight.SelectedValue);
		uiSettings.FontSize = SliderFontSize.Value;
		uiSettings.EnableShadow = ChkEnableShadow.IsChecked == true;
		uiSettings.EnableResizeFont = ChkEnableResizeFont.IsChecked == true;
	}

	private void NmLMQ5Tr5H(object sender, RoutedPropertyChangedEventArgs<Color?> e)
	{
		oTUMjv9tAe();
	}

	private void oTUMjv9tAe()
	{
		this.m_SettingsChanged?.Invoke(this, EventArgs.Empty);
	}

	private void OCEMnLaVQ9(object sender, RoutedPropertyChangedEventArgs<Color?> e)
	{
		oTUMjv9tAe();
	}

	private void eRbM4gtVx6(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		oTUMjv9tAe();
	}

	private void sfAM5uXwlt(object sender, RoutedEventArgs e)
	{
		oTUMjv9tAe();
	}

	private void tdBMDVKe6w(object sender, SelectionChangedEventArgs e)
	{
		oTUMjv9tAe();
	}

	private void gYWMdr6bSl(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		oTUMjv9tAe();
	}

	private void LxNMofaS72(object sender, SelectionChangedEventArgs e)
	{
		oTUMjv9tAe();
	}

	private void pSyMTKo56n(object sender, SelectionChangedEventArgs e)
	{
		oTUMjv9tAe();
	}

	private void X5RMM5g98m(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSelectFileDialog("图片文件(*.jpg,*.png)|*.jpg;*.png;", "", "", "", "选择面板背景图片");
		if (tuple.Item1)
		{
			TxtBackgroundImagePath.Text = tuple.Item2;
			oTUMjv9tAe();
		}
	}

	[AsyncStateMachine(typeof(_003CBtnUpload_OnClick_003Ed__22))]
	private void RsUMAA7Xb5(object sender, RoutedEventArgs e)
	{
		_003CBtnUpload_OnClick_003Ed__22 stateMachine = default(_003CBtnUpload_OnClick_003Ed__22);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void XHRMOeJrFt(object sender, RoutedEventArgs e)
	{
		TxtBackgroundImagePath.Text = "";
		oTUMjv9tAe();
	}

	private void IksMFPYds3(object sender, TextChangedEventArgs e)
	{
		XE8MUKyE0d();
		oTUMjv9tAe();
	}

	private void XE8MUKyE0d()
	{
		BtnUpload.Visibility = ((!File.Exists(TxtBackgroundImagePath.Text)) ? Visibility.Collapsed : Visibility.Visible);
		BtnRemoveBackgroundImage.Visibility = (string.IsNullOrEmpty(TxtBackgroundImagePath.Text) ? Visibility.Collapsed : Visibility.Visible);
	}

	private void AkgMlWg3qy(object sender, RoutedEventArgs e)
	{
		oTUMjv9tAe();
	}

	private Color xKCMiZyXR3(string string_0)
	{
		return ColorHelper.StringToColor(string_0);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!X92AgQdjyL)
		{
			X92AgQdjyL = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/ui/uicolorsettingscontrol.xaml", UriKind.Relative);
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
			X92AgQdjyL = true;
			break;
		case 1:
			SliderButtonSize = (Slider)target;
			SliderButtonSize.ValueChanged += eRbM4gtVx6;
			break;
		case 2:
			SliderButtonSpace = (Slider)target;
			SliderButtonSpace.ValueChanged += eRbM4gtVx6;
			break;
		case 3:
			SliderFrameBorderWidth = (Slider)target;
			SliderFrameBorderWidth.ValueChanged += eRbM4gtVx6;
			break;
		case 4:
			SliderCornerRadius = (Slider)target;
			num = 1;
			if (YYfm9lhljU2ArtpReLj != null)
			{
				goto IL_03fa;
			}
			goto IL_03fe;
		case 5:
			ColorPickerBg = (ColorPicker)target;
			ColorPickerBg.SelectedColorChanged += OCEMnLaVQ9;
			break;
		case 6:
			ColorPickerToolbar = (ColorPicker)target;
			ColorPickerToolbar.SelectedColorChanged += OCEMnLaVQ9;
			break;
		case 7:
			ColorPickerToolbarBtn = (ColorPicker)target;
			num = 5;
			if (YYfm9lhljU2ArtpReLj != null)
			{
				goto IL_03fa;
			}
			goto IL_03fe;
		case 8:
			ColorPickerButton = (ColorPicker)target;
			goto IL_0480;
		case 9:
			ColorPickerHover = (ColorPicker)target;
			ColorPickerHover.SelectedColorChanged += NmLMQ5Tr5H;
			break;
		case 10:
			ColorPickerInvalidButton = (ColorPicker)target;
			num = 0;
			if (YYfm9lhljU2ArtpReLj == null)
			{
				goto IL_03fe;
			}
			goto IL_041f;
		case 11:
			ColorPickerEmptyHover = (ColorPicker)target;
			ColorPickerEmptyHover.SelectedColorChanged += NmLMQ5Tr5H;
			break;
		case 12:
			ColorPickerLabel = (ColorPicker)target;
			ColorPickerLabel.SelectedColorChanged += NmLMQ5Tr5H;
			break;
		case 13:
			ColorPickerIcon = (ColorPicker)target;
			ColorPickerIcon.SelectedColorChanged += NmLMQ5Tr5H;
			break;
		case 14:
			ColorPickerKeyTip = (ColorPicker)target;
			ColorPickerKeyTip.SelectedColorChanged += NmLMQ5Tr5H;
			break;
		case 15:
			ColorPickerIconForOtherUi = (ColorPicker)target;
			ColorPickerIconForOtherUi.SelectedColorChanged += NmLMQ5Tr5H;
			break;
		case 16:
			PnlAdvanced = (StackPanel)target;
			break;
		case 17:
			CbFontEng = (ComboBox)target;
			CbFontEng.SelectionChanged += LxNMofaS72;
			break;
		case 18:
			CbFontChn = (ComboBox)target;
			CbFontChn.SelectionChanged += LxNMofaS72;
			break;
		case 19:
			SliderFontSize = (Slider)target;
			SliderFontSize.ValueChanged += gYWMdr6bSl;
			break;
		case 20:
			CbFontWeight = (ComboBox)target;
			CbFontWeight.SelectionChanged += pSyMTKo56n;
			break;
		case 21:
			TxtBackgroundImagePath = (TextBox)target;
			TxtBackgroundImagePath.TextChanged += IksMFPYds3;
			break;
		case 22:
			BtnRemoveBackgroundImage = (Button)target;
			BtnRemoveBackgroundImage.Click += XHRMOeJrFt;
			break;
		case 23:
			BtnSelectBackgroundImage = (Button)target;
			BtnSelectBackgroundImage.Click += X5RMM5g98m;
			break;
		case 24:
			BtnUpload = (Button)target;
			BtnUpload.Click += RsUMAA7Xb5;
			break;
		case 25:
			SliderBackgroundImageOpacity = (Slider)target;
			SliderBackgroundImageOpacity.ValueChanged += gYWMdr6bSl;
			break;
		case 26:
			CbBlur = (ComboBox)target;
			num = 4;
			if (!X9pX83hZmqfy4nT08ME())
			{
				goto IL_03fa;
			}
			goto IL_03fe;
		case 27:
			CbRoundCorner = (ComboBox)target;
			CbRoundCorner.SelectionChanged += tdBMDVKe6w;
			break;
		case 28:
			ChkEnableResizeFont = (CheckBox)target;
			ChkEnableResizeFont.Click += AkgMlWg3qy;
			break;
		case 29:
			ChkEnableZoomEffect = (CheckBox)target;
			ChkEnableZoomEffect.Click += sfAM5uXwlt;
			break;
		case 30:
			ChkHideLabelIfHasIcon = (CheckBox)target;
			ChkHideLabelIfHasIcon.Click += sfAM5uXwlt;
			break;
		case 31:
			{
				ChkEnableShadow = (CheckBox)target;
				ChkEnableShadow.Click += sfAM5uXwlt;
				break;
			}
			IL_03fa:
			num = num2;
			goto IL_03fe;
			IL_03fe:
			switch (num)
			{
			case 1:
				SliderCornerRadius.ValueChanged += eRbM4gtVx6;
				return;
			case 3:
				return;
			case 4:
				CbBlur.SelectionChanged += tdBMDVKe6w;
				return;
			case 2:
				return;
			case 5:
				ColorPickerToolbarBtn.SelectedColorChanged += OCEMnLaVQ9;
				return;
			case 6:
				goto IL_0480;
			}
			goto IL_041f;
			IL_0480:
			ColorPickerButton.SelectedColorChanged += NmLMQ5Tr5H;
			break;
			IL_041f:
			ColorPickerInvalidButton.SelectedColorChanged += NmLMQ5Tr5H;
			break;
		}
	}

	internal static bool X9pX83hZmqfy4nT08ME()
	{
		return YYfm9lhljU2ArtpReLj == null;
	}
}
