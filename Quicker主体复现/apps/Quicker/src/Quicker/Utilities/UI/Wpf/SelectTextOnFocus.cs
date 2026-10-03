using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Utilities.UI.Wpf;

public class SelectTextOnFocus : DependencyObject
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static KeyboardFocusChangedEventHandler KZG2y3kCxBk;

		public static MouseButtonEventHandler A3l2yfpPhWT;

		public static RoutedEventHandler AM92yz4wlOo;
	}

	public static readonly DependencyProperty ActiveProperty;

	private static TextBox qaNvuDeAgbt;

	private static SelectTextOnFocus OIBXpkcVyY9gUkQl04Hk;

	private static void CCTvuQ2Fsvl(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (!(dependencyObject_0 is TextBox))
		{
			return;
		}
		TextBox textBox = dependencyObject_0 as TextBox;
		if (OIBXpkcVyY9gUkQl04Hk != null)
		{
			switch (0)
			{
			}
		}
		if ((dependencyPropertyChangedEventArgs_0.NewValue as bool?) ?? false)
		{
			textBox.GotKeyboardFocus += _003C_003EO.KZG2y3kCxBk ?? (_003C_003EO.KZG2y3kCxBk = fvxvu5TnNWw);
			textBox.PreviewMouseLeftButtonDown += _003C_003EO.A3l2yfpPhWT ?? (_003C_003EO.A3l2yfpPhWT = aOkvunXNYOg);
			textBox.Unloaded += _003C_003EO.AM92yz4wlOo ?? (_003C_003EO.AM92yz4wlOo = IjtvujGq84c);
		}
		else
		{
			textBox.GotKeyboardFocus -= _003C_003EO.KZG2y3kCxBk ?? (_003C_003EO.KZG2y3kCxBk = fvxvu5TnNWw);
			textBox.PreviewMouseLeftButtonDown -= _003C_003EO.A3l2yfpPhWT ?? (_003C_003EO.A3l2yfpPhWT = aOkvunXNYOg);
		}
	}

	private static void IjtvujGq84c(object sender, RoutedEventArgs e)
	{
		if (sender is TextBox textBox)
		{
			textBox.GotKeyboardFocus -= _003C_003EO.KZG2y3kCxBk ?? (_003C_003EO.KZG2y3kCxBk = fvxvu5TnNWw);
			textBox.PreviewMouseLeftButtonDown -= _003C_003EO.A3l2yfpPhWT ?? (_003C_003EO.A3l2yfpPhWT = aOkvunXNYOg);
			textBox.Unloaded -= _003C_003EO.AM92yz4wlOo ?? (_003C_003EO.AM92yz4wlOo = IjtvujGq84c);
		}
		qaNvuDeAgbt = null;
	}

	private static void aOkvunXNYOg(object sender, MouseButtonEventArgs e)
	{
		DependencyObject dependencyObject = SCnvu48X91m(e.OriginalSource);
		if (dependencyObject != null && dependencyObject is TextBox textBox)
		{
			qaNvuDeAgbt = textBox;
		}
	}

	private static DependencyObject SCnvu48X91m(object object_0)
	{
		DependencyObject dependencyObject = object_0 as UIElement;
		while (dependencyObject != null && !(dependencyObject is TextBox))
		{
			dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
		}
		return dependencyObject;
	}

	private static void fvxvu5TnNWw(object sender, KeyboardFocusChangedEventArgs e)
	{
		if (e.OriginalSource is TextBox textBox && qaNvuDeAgbt != textBox)
		{
			string selectedText = textBox.SelectedText;
			if (selectedText != null && selectedText.Length == 0)
			{
				textBox.SelectAll();
			}
		}
	}

	[AttachedPropertyBrowsableForType(typeof(TextBox))]
	[AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
	public static bool GetActive(DependencyObject @object)
	{
		return (bool)@object.GetValue(ActiveProperty);
	}

	public static void SetActive(DependencyObject @object, bool value)
	{
		@object.SetValue(ActiveProperty, value);
	}

	static SelectTextOnFocus()
	{
		ActiveProperty = DependencyProperty.RegisterAttached("Active", typeof(bool), typeof(global::Quicker.Utilities.UI.Wpf.SelectTextOnFocus), new PropertyMetadata(false, CCTvuQ2Fsvl));
		qaNvuDeAgbt = null;
	}

	internal static bool emXfaFcVpYcX1QQBoNyN()
	{
		return OIBXpkcVyY9gUkQl04Hk == null;
	}

	internal static void BE2ICMcVAf6NnthvuAPG()
	{
	}
}
