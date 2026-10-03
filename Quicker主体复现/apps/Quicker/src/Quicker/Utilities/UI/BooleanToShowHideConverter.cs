using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class BooleanToShowHideConverter : IValueConverter
{
	internal static BooleanToShowHideConverter cFLF6hF7Yh8lh1iBLmK6;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool)
		{
			return (!(bool)value) ? Visibility.Hidden : Visibility.Visible;
		}
		return Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	static BooleanToShowHideConverter()
	{
	}

	internal static bool KK0qw3F78E68N3dnNCmt()
	{
		return cFLF6hF7Yh8lh1iBLmK6 == null;
	}

	internal static void SA7lFVF7g1G6vAUWZsuX()
	{
	}
}
