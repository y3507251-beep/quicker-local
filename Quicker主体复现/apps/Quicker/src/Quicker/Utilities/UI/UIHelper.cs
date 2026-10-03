using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using log4net;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View;
using Quicker.View.Controls;
using SnipInsight.Util;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Utilities.UI;

public static class UIHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec nGd2Ec0Immb;

		private static _003C_003Ec CTMQ9ayJxu4QJAmTM9WS;

		static _003C_003Ec()
		{
			nGd2Ec0Immb = new _003C_003Ec();
		}

		internal void E3a2EqM1NLL()
		{
		}

		internal static void Q7BJKYyJtRAckG7vXuaQ()
		{
		}

		internal static bool ndYeipyJIyHBBXrNEEle()
		{
			return CTMQ9ayJxu4QJAmTM9WS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public string mo72EZtK5xd;

		internal static _003C_003Ec__DisplayClass18_0 Snm6YwyJShuK3VmsHayu;

		internal bool mlW2EVAwtfx(SelectionItem x)
		{
			return x.Value == mo72EZtK5xd;
		}

		internal static bool FTCUbCyJwBV1aLkKC8N9()
		{
			return Snm6YwyJShuK3VmsHayu == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CEnumerateVisualChildren_003Ed__24 : IDisposable, IEnumerable, IEnumerator, IEnumerable<DependencyObject>, IEnumerator<DependencyObject>
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject dependencyObject;

		public DependencyObject _003C_003E3__dependencyObject;

		private int _003Ci_003E5__2;

		internal static _003CEnumerateVisualChildren_003Ed__24 i0N7rKyJm1kci0KwCaYL;

		DependencyObject IEnumerator<DependencyObject>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CEnumerateVisualChildren_003Ed__24(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			int num;
			while (true)
			{
				num = _003C_003E1__state;
				if (i0N7rKyJm1kci0KwCaYL == null)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				break;
			}
			switch (num)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				_003Ci_003E5__2++;
				break;
			case 0:
				_003C_003E1__state = -1;
				if (dependencyObject == null)
				{
					return false;
				}
				_003Ci_003E5__2 = 0;
				break;
			}
			if (_003Ci_003E5__2 < VisualTreeHelper.GetChildrenCount(dependencyObject))
			{
				_003C_003E2__current = VisualTreeHelper.GetChild(dependencyObject, _003Ci_003E5__2);
				_003C_003E1__state = 1;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<DependencyObject> IEnumerable<DependencyObject>.GetEnumerator()
		{
			_003CEnumerateVisualChildren_003Ed__24 _003CEnumerateVisualChildren_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CEnumerateVisualChildren_003Ed__ = this;
			}
			else
			{
				_003CEnumerateVisualChildren_003Ed__ = new _003CEnumerateVisualChildren_003Ed__24(0);
			}
			_003CEnumerateVisualChildren_003Ed__.dependencyObject = _003C_003E3__dependencyObject;
			return _003CEnumerateVisualChildren_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DependencyObject>)this).GetEnumerator();
		}

		internal static bool KMHOZdyJsbd9fStnC6yu()
		{
			return i0N7rKyJm1kci0KwCaYL == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CEnumerateVisualDescendents_003Ed__25 : IDisposable, IEnumerable, IEnumerator, IEnumerable<DependencyObject>, IEnumerator<DependencyObject>
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject dependencyObject;

		public DependencyObject _003C_003E3__dependencyObject;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

		private IEnumerator<DependencyObject> _003C_003E7__wrap2;

		internal static _003CEnumerateVisualDescendents_003Ed__25 yrLF7SyJ4tXVgNoG10ig;

		DependencyObject IEnumerator<DependencyObject>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CEnumerateVisualDescendents_003Ed__25(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || num == 2)
			{
				try
				{
					if (num == -4 || num == 2)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = null;
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num;
				DependencyObject current;
				DependencyObject current2;
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003C_003E2__current = dependencyObject;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = dependencyObject.EnumerateVisualChildren().GetEnumerator();
					_003C_003E1__state = -3;
					num = 1;
					if (!EOxyiqyJhDhYYle1ZQRd())
					{
						goto IL_00a4;
					}
					goto IL_00bd;
				case 2:
					{
						_003C_003E1__state = -4;
						goto IL_00f7;
					}
					IL_00bd:
					switch (num)
					{
					case 2:
						goto IL_010a;
					}
					goto IL_00a4;
					IL_00a4:
					if (!_003C_003E7__wrap1.MoveNext())
					{
						num = 1;
						if (yrLF7SyJ4tXVgNoG10ig != null)
						{
							goto IL_00bd;
						}
						goto IL_010a;
					}
					current = _003C_003E7__wrap1.Current;
					_003C_003E7__wrap2 = current.EnumerateVisualDescendents().GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_00f7;
					IL_010a:
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = null;
					return false;
					IL_00f7:
					if (!_003C_003E7__wrap2.MoveNext())
					{
						_003C_003Em__Finally2();
						_003C_003E7__wrap2 = null;
						num = 0;
						if (yrLF7SyJ4tXVgNoG10ig != null)
						{
							int num2 = default(int);
							num = num2;
						}
						goto IL_00bd;
					}
					current2 = _003C_003E7__wrap2.Current;
					_003C_003E2__current = current2;
					_003C_003E1__state = 2;
					return true;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<DependencyObject> IEnumerable<DependencyObject>.GetEnumerator()
		{
			_003CEnumerateVisualDescendents_003Ed__25 _003CEnumerateVisualDescendents_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CEnumerateVisualDescendents_003Ed__ = this;
			}
			else
			{
				_003CEnumerateVisualDescendents_003Ed__ = new _003CEnumerateVisualDescendents_003Ed__25(0);
			}
			_003CEnumerateVisualDescendents_003Ed__.dependencyObject = _003C_003E3__dependencyObject;
			return _003CEnumerateVisualDescendents_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DependencyObject>)this).GetEnumerator();
		}

		internal static bool EOxyiqyJhDhYYle1ZQRd()
		{
			return yrLF7SyJ4tXVgNoG10ig == null;
		}
	}

	private static readonly ILog DGIv2VFDd2S;

	private static readonly IntPtr OOev2ZUjkWL;

	private static Action DbGv29dtPAw;

	internal static object WBQGlLFHDSNCHimeeUx9;

	public static void TiggerClick(this System.Windows.Controls.Button button)
	{
		button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
	}

	public static System.Windows.Media.Color ColorFromString(string strColor)
	{
		if (string.IsNullOrEmpty(strColor))
		{
			return Colors.Black;
		}
		try
		{
			return (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(strColor);
		}
		catch
		{
			return Colors.Black;
		}
	}

	public static SolidColorBrush SolidColorBrushFromString(string strColor)
	{
		return ColorFromString(strColor).GetBrush();
	}

	public static void UpdateUiBgImage(FrameworkElement bgControl, UiSettings settings, Stretch stretch = Stretch.UniformToFill)
	{
		if (!string.IsNullOrEmpty(settings.BackgroundImage))
		{
			string backgroundImage = settings.BackgroundImage;
			if (backgroundImage.StartsWith("http", StringComparison.InvariantCultureIgnoreCase) || File.Exists(backgroundImage))
			{
				try
				{
					ImageBrush imageBrush = new ImageBrush();
					BitmapSource imageSource = ImageCache.GetImageSource(backgroundImage);
					imageBrush.ImageSource = imageSource;
					imageBrush.Stretch = stretch;
					imageBrush.Opacity = settings.BackgroundImageOpacity;
					imageBrush.TryFreeze();
					bgControl.SetValue(System.Windows.Controls.Panel.BackgroundProperty, imageBrush);
				}
				catch (Exception exception)
				{
					string message = "设置背景图出错（可能是Windows临时目录有问题，请尝试重启系统）：" + exception.GetMessageWithInner();
					DGIv2VFDd2S.Warn(message, exception);
					AppHelper.ShowWarning(message);
				}
			}
		}
		else
		{
			bgControl.SetValue(System.Windows.Controls.Panel.BackgroundProperty, System.Windows.Media.Color.FromArgb(1, 0, 0, 0).GetBrush());
		}
	}

	public static void UpdateUiSkinCommon(Window window, UiSettings settings, bool canUseSkin)
	{
		if (!string.IsNullOrEmpty(settings.ButtonBgColor))
		{
			window.SetValue(ActionButton.ButtonColorProperty, SolidColorBrushFromString(settings.ButtonBgColor));
		}
		if (!string.IsNullOrEmpty(settings.InvalidButtonBgColor))
		{
			window.SetValue(ActionButton.InvalidButtonColorProperty, SolidColorBrushFromString(settings.InvalidButtonBgColor));
		}
		window.SetValue(ActionButton.LabelColorProperty, ((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(settings.LabelColor)).GetBrush());
		AppState.SkinInfo.DefaultActionIconColor = settings.DefaultIconColor;
		window.SetValue(ActionButton.HoverColorProperty, ((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(settings.HoverColor)).GetBrush());
		window.SetValue(ActionButton.EmptyHoverColorProperty, ((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(settings.EmptyHoverColor)).GetBrush());
		if (WBQGlLFHDSNCHimeeUx9 == null)
		{
			switch (1)
			{
			case 1:
				break;
			default:
				goto IL_0201;
			}
		}
		window.SetValue(ActionButton.KeyTipColorProperty, ((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(settings.KeyTipColor)).GetBrush());
		window.SetValue(ActionButton.HideLabelIfHasIconProperty, settings.HideLabelIfHasIcon);
		window.SetValue(ActionButton.EnableZoomEffectProperty, settings.EnableZoomEffect);
		window.SetValue(ActionButton.EnableShadowProperty, settings.EnableShadow);
		window.SetValue(ActionButton.ShrinkTitleProperty, settings.EnableResizeFont);
		System.Windows.Media.Color color = ColorFromString(settings.ToolbarBtnColor);
		color.A = 60;
		window.SetValue(ProfileNavIndicator.DefaultColorProperty, color);
		System.Windows.Media.Color color2 = ColorFromString(settings.ToolbarBtnColor);
		window.SetValue(ProfileNavIndicator.ActiveColorProperty, color2);
		if (!canUseSkin)
		{
			return;
		}
		string text = (settings.FontFamily1 + "," + settings.FontFamily2).Trim(',');
		try
		{
			if (!string.IsNullOrEmpty(text))
			{
				window.FontFamily = new System.Windows.Media.FontFamily(text);
			}
			else
			{
				window.FontFamily = System.Windows.SystemFonts.CaptionFontFamily;
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("设置面板字体（" + text + "）失败：" + ex.Message);
		}
		goto IL_0201;
		IL_0201:
		window.FontSize = settings.FontSize;
		window.FontWeight = FontWeight.FromOpenTypeWeight(Math.Min(999, Math.Max(1, settings.FontWeight)));
	}

	public static void CreateUiBindings(Window window)
	{
		System.Windows.Data.Binding binding = new System.Windows.Data.Binding("DefaultActionIconColor");
		binding.Source = AppState.SkinInfo;
		BindingOperations.SetBinding(window, IconControl.DefaultIconColorProperty, binding);
	}

	public static (string icon, string title, string tooltip) ExtractIconAndTitle(string buttonName)
	{
		return CommonOperationItem.ExtractIconAndTitle(buttonName);
	}

	private static int uw9v2cyhDy0(string string_0)
	{
		int num = 1;
		int num2 = 1;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (string_0[num2] == '[')
				{
					num++;
				}
				else if (string_0[num2] == ']')
				{
					num--;
					if (num == 0)
					{
						break;
					}
				}
				num2++;
				continue;
			}
			return -1;
		}
		return num2;
	}

	public static (string icon, string title, string tooltip) ExtractIconAndTitle1(string buttonName)
	{
		return CommonOperationItem.ExtractIconAndTitle(buttonName);
	}

	public static (bool hasTooltip, string title, string tooltip) ParseTitleAndTooltip(string text)
	{
		return CommonOperationItem.ParseTitleAndTooltip(text);
	}

	public static object CreateButtonContent(string icon, string title, double iconSize = 14.0)
	{
		StackPanel stackPanel = new StackPanel
		{
			Orientation = System.Windows.Controls.Orientation.Horizontal,
			VerticalAlignment = VerticalAlignment.Center
		};
		IconControl iconControl = null;
		if (!string.IsNullOrEmpty(icon))
		{
			iconControl = new IconControl
			{
				Icon = icon,
				Width = iconSize - 2.0,
				Height = iconSize - 2.0,
				VerticalAlignment = VerticalAlignment.Center
			};
			stackPanel.Children.Add(iconControl);
		}
		if (string.IsNullOrEmpty(title))
		{
			if (iconControl != null)
			{
				iconControl.Height = iconSize;
				iconControl.Width = iconSize;
			}
		}
		else
		{
			AccessText accessText = new AccessText
			{
				Text = title,
				VerticalAlignment = VerticalAlignment.Center
			};
			stackPanel.Children.Add(accessText);
			int num = 0;
			if (WBQGlLFHDSNCHimeeUx9 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (stackPanel.Children.Count > 1)
			{
				accessText.Margin = new Thickness(3.0, 0.0, 0.0, 0.0);
			}
		}
		return stackPanel;
	}

	public static T GetDescendantByType<T>(this Visual element) where T : class
	{
		if (element == null)
		{
			return null;
		}
		if (element.GetType() == typeof(T))
		{
			return element as T;
		}
		T val = null;
		if (element is FrameworkElement)
		{
			(element as FrameworkElement).ApplyTemplate();
		}
		for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element); i++)
		{
			val = (VisualTreeHelper.GetChild(element, i) as Visual).GetDescendantByType<T>();
			if (val != null)
			{
				break;
			}
		}
		return val;
	}

	public static T FindParent<T>(DependencyObject child) where T : DependencyObject
	{
		DependencyObject parent = VisualTreeHelper.GetParent(child);
		if (parent == null)
		{
			return null;
		}
		if (parent is T result)
		{
			return result;
		}
		return FindParent<T>(parent);
	}

	public static T FindChild<T>(DependencyObject reference) where T : class
	{
		Queue<DependencyObject> queue = new Queue<DependencyObject>();
		queue.Enqueue(reference);
		T val;
		while (true)
		{
			if (queue.Count > 0)
			{
				DependencyObject dependencyObject = queue.Dequeue();
				val = dependencyObject as T;
				if (val != null)
				{
					break;
				}
				for (int i = 0; i < VisualTreeHelper.GetChildrenCount(dependencyObject); i++)
				{
					queue.Enqueue(VisualTreeHelper.GetChild(dependencyObject, i));
				}
				continue;
			}
			return null;
		}
		return val;
	}

	public static void AddExeOrProcess(System.Windows.Controls.TextBox textBox, string exeOrProcessName, IntPtr hWnd)
	{
		if (hWnd != IntPtr.Zero && exeOrProcessName.EqualsAny(true, "explorer", "explorer.exe"))
		{
			if (NativeMethods.IsOnDesktop(hWnd))
			{
				exeOrProcessName = "desktop";
			}
			else if (NativeMethods.IsOnTaskbar(hWnd))
			{
				exeOrProcessName = "taskbar";
			}
		}
		if (string.IsNullOrWhiteSpace(textBox.Text))
		{
			textBox.Text = exeOrProcessName;
			return;
		}
		textBox.Text = textBox.Text.TrimEnd(';') + ";" + exeOrProcessName;
		int num = 0;
		if (!UVqYZtFH3p4Rx9pI2GrM())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public static void TrySelectItem(System.Windows.Controls.ComboBox comboBox, object item, bool setToFirstIfFail)
	{
		try
		{
			comboBox.SelectedItem = item;
		}
		catch (Exception)
		{
			if (setToFirstIfFail && comboBox.Items.Count > 0)
			{
				comboBox.SelectedIndex = 0;
			}
		}
	}

	public static void TrySelectItemBySelectionItemValue(System.Windows.Controls.ComboBox comboBox, string value, bool setToFirstIfFail)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.mo72EZtK5xd = value;
		try
		{
			SelectionItem selectionItem = comboBox.Items.Cast<SelectionItem>()?.FirstOrDefault(_003C_003Ec__DisplayClass18_.mlW2EVAwtfx);
			if (selectionItem != null)
			{
				comboBox.SelectedItem = selectionItem;
			}
			else if (setToFirstIfFail && comboBox.Items.Count > 0)
			{
				comboBox.SelectedIndex = 0;
			}
		}
		catch (Exception)
		{
			if (setToFirstIfFail && comboBox.Items.Count > 0)
			{
				comboBox.SelectedIndex = 0;
			}
		}
	}

	public static void DisableWindowTooltip(Window window, bool disableTooltip)
	{
		try
		{
			if (disableTooltip)
			{
				if (UVqYZtFH3p4Rx9pI2GrM())
				{
					switch (0)
					{
					}
				}
				Style style = new Style(typeof(System.Windows.Controls.ToolTip));
				style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
				style.Seal();
				if (window.Resources.Contains(typeof(global::System.Windows.Controls.ToolTip)))
				{
					window.Resources.Remove(typeof(System.Windows.Controls.ToolTip));
				}
				window.Resources.Add(typeof(System.Windows.Controls.ToolTip), style);
			}
			else if (window.Resources.Contains(typeof(System.Windows.Controls.ToolTip)))
			{
				window.Resources.Remove(typeof(System.Windows.Controls.ToolTip));
			}
		}
		catch (Exception ex)
		{
			DGIv2VFDd2S.Warn("更新tooltip可见性出错。" + ex.Message, ex);
		}
	}

	public static void Refresh(this UIElement uiElement)
	{
		uiElement.Dispatcher.Invoke(DispatcherPriority.Render, DbGv29dtPAw);
	}

	public static bool IsMouseOverElement(UIElement element, System.Drawing.Point pt)
	{
		System.Windows.Point screenPoint = new System.Windows.Point(pt.X, pt.Y);
		return IsMouseOverElement(element, screenPoint);
	}

	public static bool IsMouseOverElement(UIElement element, System.Windows.Point screenPoint)
	{
		if (!element.IsMouseOver && !element.IsStylusOver)
		{
			System.Windows.Point point = element.PointFromScreen(screenPoint);
			return VisualTreeHelper.HitTest(element, point) != null;
		}
		return true;
	}

	[IteratorStateMachine(typeof(_003CEnumerateVisualChildren_003Ed__24))]
	public static IEnumerable<DependencyObject> EnumerateVisualChildren(this DependencyObject dependencyObject)
	{
		return new _003CEnumerateVisualChildren_003Ed__24(-2)
		{
			_003C_003E3__dependencyObject = dependencyObject
		};
	}

	[IteratorStateMachine(typeof(_003CEnumerateVisualDescendents_003Ed__25))]
	public static IEnumerable<DependencyObject> EnumerateVisualDescendents(this DependencyObject dependencyObject)
	{
		return new _003CEnumerateVisualDescendents_003Ed__25(-2)
		{
			_003C_003E3__dependencyObject = dependencyObject
		};
	}

	public static void ClearAllBindings(this DependencyObject dependencyObject)
	{
		if (dependencyObject == null)
		{
			return;
		}
		foreach (DependencyObject item in dependencyObject.EnumerateVisualDescendents())
		{
			if (item != null)
			{
				BindingOperations.ClearAllBindings(item);
			}
		}
	}

	public static void MaximizeWindowIfTooHigh(Window window)
	{
		Screen screen = Screen.FromPoint(Cursor.Position);
		double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint();
		if ((double)screen.WorkingArea.Height * dpiScaleByPoint < window.ActualHeight)
		{
			window.WindowState = WindowState.Maximized;
		}
	}

	static UIHelper()
	{
		DGIv2VFDd2S = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		OOev2ZUjkWL = new IntPtr(-1);
		DbGv29dtPAw = _003C_003Ec.nGd2Ec0Immb.E3a2EqM1NLL;
	}

	internal static bool UVqYZtFH3p4Rx9pI2GrM()
	{
		return WBQGlLFHDSNCHimeeUx9 == null;
	}
}
