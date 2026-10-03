using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.Messaging;
using FontAwesome5.WPF;
using JTIh7V5l65QV75A93Ly;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Theme;
using Quicker.Utilities.UI;

namespace Quicker.View.Controls;

public class ActionUIEditor : UserControl, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CBtnPreview_OnPreviewMouseDown_003Eb__18_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionUIEditor _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object xCTbBuyp4tWmvZB3YNOm;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionUIEditor actionUIEditor = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_017d;
				}
				if (num == 1)
				{
					goto IL_00b0;
				}
				if (!ClipboardHelper.IsClipboardHasIconUrl())
				{
					goto IL_005e;
				}
				string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
				if (oQrRRJyphFCroxldLPZU())
				{
					switch (1)
					{
					default:
						goto end_IL_000e;
					case 1:
						break;
					case 0:
						goto end_IL_000e;
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					goto IL_005e;
				}
				actionUIEditor.hQFLj3DTacF(text);
				goto end_IL_000e;
				IL_00b0:
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_014c;
					}
					string text2 = IconHelper.WriteClipboardImageToTempFile();
					if (!string.IsNullOrEmpty(text2))
					{
						awaiter = actionUIEditor.YexLjifWy57(text2).ConfigureAwait(true).GetAwaiter();
						int num2 = 0;
						if (xCTbBuyp4tWmvZB3YNOm != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_014c;
					}
					AppHelper.ShowWarning("没有要粘贴的图标。");
					goto end_IL_00b0;
					IL_014c:
					awaiter.GetResult();
					end_IL_00b0:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("粘贴图标出错。" + ex);
				}
				goto end_IL_000e;
				IL_017d:
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						string string_ = ClipboardHelper.GetFileDropList()[0];
						awaiter = actionUIEditor.YexLjifWy57(string_).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							if (!oQrRRJyphFCroxldLPZU())
							{
								int num5 = default(int);
								num4 = num5;
							}
							switch (num4)
							{
							}
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning("粘贴图标出错。" + ex2.Message);
				}
				goto end_IL_000e;
				IL_005e:
				BitmapSource image = ClipboardHelper.GetImage();
				if (image == null)
				{
					if (ClipboardHelper.IsClipboardHasIconFile())
					{
						goto IL_017d;
					}
					AppHelper.ShowWarning("没有要粘贴的图标。");
				}
				else
				{
					if (image.PixelWidth <= 256 && image.PixelHeight <= 256)
					{
						goto IL_00b0;
					}
					AppHelper.ShowWarning("要粘贴的图片太大了。");
				}
				end_IL_000e:;
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

		internal static bool oQrRRJyphFCroxldLPZU()
		{
			return xCTbBuyp4tWmvZB3YNOm == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnPreview_OnDrop_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DragEventArgs e;

		public ActionUIEditor _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object wKaastyXQtZRvSHjpyWL;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionUIEditor actionUIEditor = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					e.Data.GetFormats();
					num2 = 0;
					if (!uAIfupyXF9B87tbIRCYt())
					{
						goto IL_0089;
					}
					goto IL_008d;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0123;
				IL_0123:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_008d:
				string[] array = default(string[]);
				while (true)
				{
					switch (num2)
					{
					default:
						if (e.Data.GetDataPresent(DataFormats.FileDrop))
						{
							array = (string[])e.Data.GetData(DataFormats.FileDrop);
							if (array == null || array.Length == 0)
							{
								goto end_IL_008d;
							}
							goto IL_007c;
						}
						goto end_IL_008d;
					case 1:
					{
						string text = array[0];
						if (text.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || text.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
						{
							awaiter = actionUIEditor.YexLjifWy57(text).ConfigureAwait(true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto end_IL_008d;
					}
					}
					goto IL_0123;
					IL_007c:
					num2 = 1;
					if (uAIfupyXF9B87tbIRCYt())
					{
						continue;
					}
					goto IL_0089;
					continue;
					end_IL_008d:
					break;
				}
				goto end_IL_0010;
				IL_0089:
				int num3 = default(int);
				num2 = num3;
				goto IL_008d;
				end_IL_0010:;
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

		internal static bool uAIfupyXF9B87tbIRCYt()
		{
			return wKaastyXQtZRvSHjpyWL == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetIconAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionUIEditor _003C_003E4__this;

		public string filename;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object xgIawwyXyD1tx7erSFye;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionUIEditor actionUIEditor = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = actionUIEditor.IconManager.UploadIconImageFileAsync(filename).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					string result = awaiter.GetResult();
					actionUIEditor.hQFLj3DTacF(result);
					int num2 = 0;
					if (xgIawwyXyD1tx7erSFye != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("无法设置图标！" + ex.Message);
				}
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

		internal static bool DQSohEyXpSTSb45rm6Nl()
		{
			return xgIawwyXyD1tx7erSFye == null;
		}
	}

	[CompilerGenerated]
	private readonly ActionItem S6lLnqBjiQd = new ActionItem();

	[CompilerGenerated]
	private IconManager KCgLncghTZG;

	internal Grid BtnUiGrid;

	internal StackPanel PreviewBtnBg;

	internal Border PreviewBtnWrapper;

	internal ActionButton BtnPreview;

	internal Button BtnImgIcon;

	internal Button BtnFaIcon;

	internal Button BtnSelectColor;

	internal SvgAwesome IconEditColor;

	internal Button BtnUseDefaultSkinColor;

	internal SvgAwesome IconDefaultColor;

	internal Button BtnRemoveIcon;

	internal TextBox TxtActionTitle;

	internal TextBox TxtActionDescription;

	internal TextBox TxtRepeat;

	private bool SSWLnVSORW4;

	internal static ActionUIEditor jBYsMfFqYXL4NgMKX718;

	public IconManager IconManager
	{
		[CompilerGenerated]
		get
		{
			return KCgLncghTZG;
		}
		[CompilerGenerated]
		private set
		{
			KCgLncghTZG = value;
		}
	}

	public string ActionTitle => TxtActionTitle.Text;

	[SpecialName]
	[CompilerGenerated]
	private ActionItem nOiLna8s8rg()
	{
		return S6lLnqBjiQd;
	}

	public ActionUIEditor()
	{
		IconManager = AppState.dAntabrFWrV().Get<IconManager>(Array.Empty<IParameter>());
		InitializeComponent();
		IconDefaultColor.Foreground = UIHelper.SolidColorBrushFromString(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColor);
		base.Loaded += DnaLjU5FwCW;
		base.Unloaded += ownLjFA57E1;
	}

	private void ownLjFA57E1(object sender, RoutedEventArgs e)
	{
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
	}

	private void DnaLjU5FwCW(object sender, RoutedEventArgs e)
	{
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, ajQLnESmQeD);
	}

	public void SetUiData(string title, string description, string icon)
	{
		nOiLna8s8rg().Title = title;
		nOiLna8s8rg().Description = description;
		nOiLna8s8rg().Icon = icon;
		TxtActionTitle.Text = nOiLna8s8rg().Title;
		TxtActionDescription.Text = nOiLna8s8rg().Description;
		hQFLj3DTacF(nOiLna8s8rg()?.Icon);
		PDaLjlw3wnx();
	}

	private void PDaLjlw3wnx()
	{
		BtnPreview.ButtonColor = UIHelper.SolidColorBrushFromString(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonBgColor);
		BtnPreview.LabelColor = UIHelper.SolidColorBrushFromString(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().LabelColor);
		BtnPreview.HoverColor = UIHelper.SolidColorBrushFromString(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().HoverColor);
		BtnPreview.EmptyHoverColor = UIHelper.SolidColorBrushFromString(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().EmptyHoverColor);
		PreviewBtnWrapper.Background = UIHelper.SolidColorBrushFromString(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().BackgroundColor);
		UIHelper.UpdateUiBgImage(PreviewBtnBg, FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6(), Stretch.None);
	}

	public void SetUiData(ActionItem action)
	{
		if (action != null)
		{
			SetUiData(action.Title, action.Description, action.Icon);
		}
	}

	public void SaveToAction(ActionItem action)
	{
		action.Title = TxtActionTitle.Text;
		action.Description = TxtActionDescription.Text;
		action.Icon = nOiLna8s8rg().Icon;
	}

	public bool IfHasData()
	{
		if (string.IsNullOrEmpty(TxtActionTitle.Text))
		{
			return !string.IsNullOrEmpty(nOiLna8s8rg().Icon);
		}
		return true;
	}

	[AsyncStateMachine(typeof(_003CBtnPreview_OnDrop_003Ed__15))]
	private void BtnPreview_OnDrop(object sender, DragEventArgs e)
	{
		_003CBtnPreview_OnDrop_003Ed__15 stateMachine = default(_003CBtnPreview_OnDrop_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CSetIconAsync_003Ed__16))]
	private Task YexLjifWy57(string string_0)
	{
		_003CSetIconAsync_003Ed__16 stateMachine = default(_003CSetIconAsync_003Ed__16);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.filename = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void hQFLj3DTacF(string string_0)
	{
		nOiLna8s8rg().Icon = string_0;
		BtnPreview.SetAction(nOiLna8s8rg());
		BtnSelectColor.IsEnabled = !string.IsNullOrEmpty(string_0) && string_0.StartsWith("fa:");
		BtnUseDefaultSkinColor.IsEnabled = !string.IsNullOrEmpty(string_0) && string_0.StartsWith("fa:") && string_0.Contains(":#");
	}

	private void BtnPreview_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left)
		{
			HhbLjfy9cTi();
			return;
		}
		ContextMenu contextMenu;
		if (e.ChangedButton == MouseButton.Right)
		{
			contextMenu = new ContextMenu();
			if (!string.IsNullOrEmpty(nOiLna8s8rg().Icon))
			{
				AppHelper.AddMenuItem(contextMenu.Items, "复制图标网址", "复制图标网址", "fa:Light_Copy", y9bLnyDNnPn);
			}
			if (!ClipboardHelper.IsClipboardHasIconUrl() && !ClipboardHelper.ContainsImage())
			{
				goto IL_0080;
			}
			goto IL_0087;
		}
		return;
		IL_00dc:
		(sender as ActionButton).ContextMenu = contextMenu;
		contextMenu.IsOpen = true;
		return;
		IL_0080:
		if (ClipboardHelper.IsClipboardHasIconFile())
		{
			goto IL_0087;
		}
		goto IL_00dc;
		IL_0087:
		MenuItem menuItem = new MenuItem();
		menuItem.Header = "粘贴图标";
		menuItem.Click += QZdLn81ATQI;
		contextMenu.Items.Add(menuItem);
		int num = 1;
		if (jBYsMfFqYXL4NgMKX718 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			goto IL_00dc;
		}
		goto IL_0080;
	}

	private void HhbLjfy9cTi()
	{
		IconSelectorWindow iconSelectorWindow = new IconSelectorWindow();
		iconSelectorWindow.Owner = Window.GetWindow(this);
		if (iconSelectorWindow.ShowDialog() == true)
		{
			hQFLj3DTacF(iconSelectorWindow.SelectedIconUrl);
		}
	}

	private void KApLjzHybsI(object sender, RoutedEventArgs e)
	{
		hQFLj3DTacF(null);
	}

	private void V8ELnwv90yg(object sender, TextChangedEventArgs e)
	{
		if (nOiLna8s8rg() != null && nOiLna8s8rg().Title != TxtActionTitle.Text)
		{
			nOiLna8s8rg().Title = TxtActionTitle.Text;
			BtnPreview.SetAction(nOiLna8s8rg());
		}
	}

	private void prGLntFW9Hp(object sender, TextChangedEventArgs e)
	{
	}

	public void FocusTitle()
	{
		TxtActionTitle.Focus();
	}

	private void cAQLngEW8dM(object sender, RoutedEventArgs e)
	{
		y0jLnLXtWjA();
	}

	private void y0jLnLXtWjA()
	{
		FaIconSelectorWindow faIconSelectorWindow = new FaIconSelectorWindow();
		faIconSelectorWindow.Owner = Window.GetWindow(this);
		bool flag = true;
		string text = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColor;
		if (!string.IsNullOrEmpty(nOiLna8s8rg().Icon) && nOiLna8s8rg().Icon.StartsWith("fa:") && nOiLna8s8rg().Icon.Contains(":#"))
		{
			text = nOiLna8s8rg().Icon.Split(':')[2];
			flag = false;
		}
		faIconSelectorWindow.IconColor = text;
		faIconSelectorWindow.PanelColor = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().BackgroundColor;
		faIconSelectorWindow.ButtonColor = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonBgColor;
		faIconSelectorWindow.LabelColor = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().LabelColor;
		if (faIconSelectorWindow.ShowDialog() == true)
		{
			hQFLj3DTacF("fa:" + faIconSelectorWindow.SelectedIcon.ToString() + (flag ? "" : (":" + text)));
			int num = 0;
			if (!T0bLdLFq8iqLTA5tP4R9())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void XDSLnvQPxJ7(object sender, RoutedEventArgs e)
	{
		HhbLjfy9cTi();
	}

	private void zulLnSyGkYI(object sender, RoutedEventArgs e)
	{
		r1ILn2sHh5c();
	}

	private void r1ILn2sHh5c()
	{
		try
		{
			string icon = nOiLna8s8rg().Icon;
			if (!icon.StartsWith("fa:"))
			{
				AppHelper.ShowWarning("仅内置矢量图标可以设置颜色。");
				return;
			}
			string value = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColor;
			string[] array = icon.Split(':');
			if (array.Length == 3)
			{
				int num = 0;
				if (!T0bLdLFq8iqLTA5tP4R9())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				value = array[2];
			}
			ColorSelectorWindow colorSelectorWindow = new ColorSelectorWindow((Color?)ColorConverter.ConvertFromString(value));
			colorSelectorWindow.Owner = Window.GetWindow(this);
			colorSelectorWindow.ShowDialog();
			if (colorSelectorWindow.SelectedColor.HasValue)
			{
				hQFLj3DTacF(array[0] + ":" + array[1] + ":" + colorSelectorWindow.SelectedColor?.ToString());
			}
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("错误：" + exception.GetMessageWithInner());
		}
	}

	private void NJJLnumnJR2(object sender, RoutedEventArgs e)
	{
		pyQLnNxrYgw();
	}

	private void pyQLnNxrYgw()
	{
		string icon = nOiLna8s8rg().Icon;
		if (string.IsNullOrEmpty(icon))
		{
			AppHelper.ShowWarning("请先选择矢量图标。");
			return;
		}
		if (!icon.StartsWith("fa:"))
		{
			AppHelper.ShowWarning("仅内置矢量图标可以设置颜色。");
			return;
		}
		string[] array = icon.Split(':');
		hQFLj3DTacF(array[0] + ":" + array[1]);
	}

	private void j3SLnJGs1yb(object sender, RoutedEventArgs e)
	{
		r1ILn2sHh5c();
	}

	private void ulcLn0uRywV(object sender, RoutedEventArgs e)
	{
		pyQLnNxrYgw();
	}

	private void W4ILnCCMrc2(object sender, RoutedEventArgs e)
	{
		y0jLnLXtWjA();
	}

	private void CIhLnPoSNOG(object sender, RoutedEventArgs e)
	{
		HhbLjfy9cTi();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!SSWLnVSORW4)
		{
			SSWLnVSORW4 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/actionuieditor.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			SSWLnVSORW4 = true;
			break;
		case 1:
			BtnUiGrid = (Grid)target;
			break;
		case 2:
			PreviewBtnBg = (StackPanel)target;
			break;
		case 3:
			PreviewBtnWrapper = (Border)target;
			break;
		case 4:
			BtnPreview = (ActionButton)target;
			break;
		case 5:
			BtnImgIcon = (Button)target;
			BtnImgIcon.Click += CIhLnPoSNOG;
			num = 1;
			if (jBYsMfFqYXL4NgMKX718 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00cd;
		case 6:
			BtnFaIcon = (Button)target;
			num = 0;
			if (jBYsMfFqYXL4NgMKX718 != null)
			{
				goto IL_00cd;
			}
			goto IL_00da;
		case 7:
			BtnSelectColor = (Button)target;
			BtnSelectColor.Click += j3SLnJGs1yb;
			break;
		case 8:
			IconEditColor = (SvgAwesome)target;
			break;
		case 9:
			BtnUseDefaultSkinColor = (Button)target;
			BtnUseDefaultSkinColor.Click += ulcLn0uRywV;
			break;
		case 10:
			IconDefaultColor = (SvgAwesome)target;
			break;
		case 11:
			BtnRemoveIcon = (Button)target;
			BtnRemoveIcon.Click += KApLjzHybsI;
			break;
		case 12:
			TxtActionTitle = (TextBox)target;
			TxtActionTitle.TextChanged += V8ELnwv90yg;
			break;
		case 13:
			TxtActionDescription = (TextBox)target;
			TxtActionDescription.TextChanged += prGLntFW9Hp;
			break;
		case 14:
			{
				TxtRepeat = (TextBox)target;
				break;
			}
			IL_00cd:
			switch (num)
			{
			case 1:
				return;
			}
			goto IL_00da;
			IL_00da:
			BtnFaIcon.Click += W4ILnCCMrc2;
			break;
		}
	}

	[CompilerGenerated]
	private void ajQLnESmQeD(object object_0, ThemeChangedMessage themeChangedMessage_0)
	{
		PDaLjlw3wnx();
	}

	[CompilerGenerated]
	private void y9bLnyDNnPn(object sender, RoutedEventArgs e)
	{
		try
		{
			ClipboardHelper.SetText(nOiLna8s8rg().Icon);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("错误：" + ex.Message);
		}
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CBtnPreview_OnPreviewMouseDown_003Eb__18_1_003Ed))]
	private void QZdLn81ATQI(object sender, RoutedEventArgs e)
	{
		_003C_003CBtnPreview_OnPreviewMouseDown_003Eb__18_1_003Ed stateMachine = default(_003C_003CBtnPreview_OnPreviewMouseDown_003Eb__18_1_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	internal static bool T0bLdLFq8iqLTA5tP4R9()
	{
		return jBYsMfFqYXL4NgMKX718 == null;
	}
}
