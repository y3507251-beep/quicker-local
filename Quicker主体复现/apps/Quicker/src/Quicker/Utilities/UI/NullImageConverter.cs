using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class NullImageConverter : IValueConverter
{
	internal static NullImageConverter XQtp4ZFHuTeNw4w4VOdE;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return DependencyProperty.UnsetValue;
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return Binding.DoNothing;
	}

	internal static bool w3Y8nkFHomI8dy7nfwUf()
	{
		return XQtp4ZFHuTeNw4w4VOdE == null;
	}
}
