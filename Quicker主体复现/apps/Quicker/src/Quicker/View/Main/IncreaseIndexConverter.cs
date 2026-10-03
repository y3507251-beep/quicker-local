using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.View.Main;

public class IncreaseIndexConverter : IValueConverter
{
	internal static IncreaseIndexConverter J4rF5iF0s9XBhq93eFyP;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return -1;
		}
		if (value is int num)
		{
			return num + 1;
		}
		try
		{
			int num2 = System.Convert.ToInt32(value);
			return num2++;
		}
		catch
		{
			return -1;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool QWbp9lF0C3TDiyx7EJMI()
	{
		return J4rF5iF0s9XBhq93eFyP == null;
	}
}
