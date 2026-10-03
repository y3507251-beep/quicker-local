using System;
using System.Globalization;
using System.Windows.Data;

namespace FindReplace;

public class BoolToInt : IValueConverter
{
	private static BoolToInt XOP0jt2e7v2kKgyP2QJ;

	object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if ((bool)value)
		{
			return 1;
		}
		return 0;
	}

	object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	internal static bool KYm1po2jN29otSvg43F()
	{
		return XOP0jt2e7v2kKgyP2QJ == null;
	}
}
