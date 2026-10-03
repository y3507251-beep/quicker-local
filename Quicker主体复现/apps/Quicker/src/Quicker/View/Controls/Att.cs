using System.Windows;

namespace Quicker.View.Controls;

public class Att
{
	public static readonly DependencyProperty ActionProperty;

	private static Att NItpH4FuQYW6mGqCblr1;

	public static void SetAction(DependencyObject element, string value)
	{
		element.SetValue(ActionProperty, value);
	}

	public static string GetAction(DependencyObject element)
	{
		return (string)element.GetValue(ActionProperty);
	}

	static Att()
	{
		ActionProperty = DependencyProperty.RegisterAttached("Action", typeof(string), typeof(Att), new PropertyMetadata((object)null));
	}

	internal static bool CU81qEFuF4sQB4EXUaE3()
	{
		return NItpH4FuQYW6mGqCblr1 == null;
	}
}
