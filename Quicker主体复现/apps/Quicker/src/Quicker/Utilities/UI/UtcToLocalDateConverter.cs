using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class UtcToLocalDateConverter : IValueConverter
{
	private static UtcToLocalDateConverter P3Pu0kFziT8m4FA6kycE;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is DateTime dateTime)
		{
			return dateTime.ToLocalTime().ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
		}
		return DateTime.Parse(value?.ToString(), CultureInfo.InvariantCulture).ToLocalTime().ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool uO2EkeFzlgL4hjBeLtM7()
	{
		return P3Pu0kFziT8m4FA6kycE == null;
	}
}
