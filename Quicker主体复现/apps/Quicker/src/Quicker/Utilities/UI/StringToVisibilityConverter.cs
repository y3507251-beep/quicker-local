using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

[ValueConversion(typeof(String), typeof(Visibility))]
public class StringToVisibilityConverter : IValueConverter
{
	internal static StringToVisibilityConverter qTRWwhFzfpoCeCb7lDIf;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		bool flag = false;
		if (parameter != null)
		{
			flag = bool.Parse(parameter.ToString());
		}
		if (string.IsNullOrEmpty((string)value))
		{
			return (!flag) ? Visibility.Collapsed : Visibility.Visible;
		}
		return flag ? Visibility.Collapsed : Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool JdyIEKFzbKFGHCtRqXdD()
	{
		return qTRWwhFzfpoCeCb7lDIf == null;
	}
}
