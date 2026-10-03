using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SnipInsight.Util;

public class StringToVisibility : IValueConverter
{
	private static StringToVisibility vmWkZDWHtR20uLyZLfk;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (!(value is string) || string.IsNullOrEmpty((string)value)) ? Visibility.Collapsed : Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool NS1JcAWz79rgSTcTWJW()
	{
		return vmWkZDWHtR20uLyZLfk == null;
	}
}
