using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

[ValueConversion(typeof(Boolean), typeof(GridLength))]
public class BoolToGridRowHeightConverter : IValueConverter
{
	internal static BoolToGridRowHeightConverter fK1YvVFs87SGhmhv7wmC;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return ((bool)value) ? new GridLength(1.0, GridUnitType.Star) : new GridLength(0.0);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return null;
	}

	internal static bool LGjusXFsR8bIDxQGeWk9()
	{
		return fK1YvVFs87SGhmhv7wmC == null;
	}
}
