using System.Windows;

namespace Quicker.Domain.Skining;

public class SkinInfo : DependencyObject
{
	public static readonly DependencyProperty DefaultActionIconColorProperty;

	private static SkinInfo yfBRMrQKn8ig2eC2NnNg;

	public string DefaultActionIconColor
	{
		get
		{
			return (string)GetValue(DefaultActionIconColorProperty);
		}
		set
		{
			SetValue(DefaultActionIconColorProperty, value);
		}
	}

	static SkinInfo()
	{
		DefaultActionIconColorProperty = DependencyProperty.Register("DefaultActionIconColor", typeof(string), typeof(SkinInfo), new PropertyMetadata("darkgray"));
	}

	internal static bool vHhWdrQKemdxIhsH7hvu()
	{
		return yfBRMrQKn8ig2eC2NnNg == null;
	}
}
