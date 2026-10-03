using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class IsNullConverter : IValueConverter
{
	internal static IsNullConverter FigfEjFzLwAykljDdWE7;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return true;
		}
		if (value is string)
		{
			return string.IsNullOrEmpty(value as string);
		}
		return false;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new InvalidOperationException("IsNullConverter can only be used OneWay.");
	}

	internal static bool iOwMxGFzuxy4dbBb54R5()
	{
		return FigfEjFzLwAykljDdWE7 == null;
	}
}
