using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class EmptyToNullConverter : IValueConverter
{
	internal static EmptyToNullConverter Yf9V9iF46x6DfjZEHuIQ;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null && value is string value2 && string.IsNullOrWhiteSpace(value2))
		{
			return null;
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool CV1SvBF4tUY7ndvQkbQi()
	{
		return Yf9V9iF46x6DfjZEHuIQ == null;
	}
}
