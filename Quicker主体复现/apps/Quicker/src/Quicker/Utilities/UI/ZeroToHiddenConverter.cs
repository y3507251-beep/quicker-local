using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class ZeroToHiddenConverter : IValueConverter
{
	private static ZeroToHiddenConverter H0Y4i8FhT3srlXgU50ky;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if ((int)value == 0)
		{
			return Visibility.Hidden;
		}
		return Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool opaYOxFhmEIaAdqmEIVX()
	{
		return H0Y4i8FhT3srlXgU50ky == null;
	}

	internal static void s6SucYFhCc4cQk29CJwn()
	{
	}
}
