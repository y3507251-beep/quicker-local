using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class AdjustDoubleConverter : IValueConverter
{
	internal static AdjustDoubleConverter GclxAdF7lIBRVEMmYvLl;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		try
		{
			double num = System.Convert.ToDouble(value);
			double num2 = System.Convert.ToDouble(parameter);
			return num + num2;
		}
		catch (Exception)
		{
			return value;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool PBZm3vF7ZFiaKudVpiS4()
	{
		return GclxAdF7lIBRVEMmYvLl == null;
	}
}
