using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

[ValueConversion(typeof(String), typeof(Visibility))]
public class ObjectToVisibilityConverter : IValueConverter
{
	internal static ObjectToVisibilityConverter dghjAVF7hd5jp9qPdoLL;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		bool flag = false;
		if (parameter is string value2 && bool.TryParse(value2, out var result))
		{
			flag = result;
		}
		if (value == null)
		{
			if (flag)
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
		if (flag)
		{
			return Visibility.Collapsed;
		}
		return Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool oBkdVRF7HlDAo7pQUtLs()
	{
		return dghjAVF7hd5jp9qPdoLL == null;
	}
}
