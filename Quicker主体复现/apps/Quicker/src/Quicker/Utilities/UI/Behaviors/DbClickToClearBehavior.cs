using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Quicker.Utilities.UI.Behaviors;

public static class DbClickToClearBehavior
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static MouseButtonEventHandler S8828wNlLrJ;

		public static RoutedEventHandler AUQ28t2nb86;
	}

	public static readonly DependencyProperty IsEnabledlProperty;

	internal static object YWfKHOcVNtCpgMCCjshF;

	public static bool GetIsEnabled(DependencyObject obj)
	{
		return (bool)obj.GetValue(IsEnabledlProperty);
	}

	public static void SetIsEnabled(DependencyObject obj, bool value)
	{
		obj.SetValue(IsEnabledlProperty, value);
	}

	private static void PDrvN2BAUMs(object sender, DependencyPropertyChangedEventArgs e)
	{
		TextBox textBox = sender as TextBox;
		if ((bool)e.NewValue)
		{
			textBox.PreviewMouseDoubleClick += _003C_003EO.S8828wNlLrJ ?? (_003C_003EO.S8828wNlLrJ = WvBvNNjvSV1);
			textBox.Unloaded += _003C_003EO.AUQ28t2nb86 ?? (_003C_003EO.AUQ28t2nb86 = qtLvNucBnwF);
		}
		else
		{
			textBox.Unloaded -= _003C_003EO.AUQ28t2nb86 ?? (_003C_003EO.AUQ28t2nb86 = qtLvNucBnwF);
			textBox.PreviewMouseDoubleClick -= _003C_003EO.S8828wNlLrJ ?? (_003C_003EO.S8828wNlLrJ = WvBvNNjvSV1);
		}
	}

	private static void qtLvNucBnwF(object sender, RoutedEventArgs e)
	{
		(sender as TextBox).Unloaded -= _003C_003EO.AUQ28t2nb86 ?? (_003C_003EO.AUQ28t2nb86 = qtLvNucBnwF);
		(sender as TextBox).PreviewMouseDoubleClick -= _003C_003EO.S8828wNlLrJ ?? (_003C_003EO.S8828wNlLrJ = WvBvNNjvSV1);
	}

	private static void WvBvNNjvSV1(object sender, MouseButtonEventArgs e)
	{
		TextBox textBox = sender as TextBox;
		if (GetIsEnabled(textBox))
		{
			textBox.Text = "";
		}
	}

	static DbClickToClearBehavior()
	{
		IsEnabledlProperty = DependencyProperty.RegisterAttached("IsDoubleClickClearTextEnabled", typeof(bool), typeof(TextBox), new UIPropertyMetadata(false, PDrvN2BAUMs));
	}

	internal static bool KBk5vHcV9fo0BctCdf10()
	{
		return YWfKHOcVNtCpgMCCjshF == null;
	}
}
