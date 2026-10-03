using System;
using System.Globalization;
using System.Windows.Data;

namespace FindReplace;

public class SearchScopeToInt : IValueConverter
{
	internal static SearchScopeToInt InRgpT22sTcFY6S0i2o;

	object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (int)value;
	}

	object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (FindReplaceMgr.SearchScope)value;
	}

	internal static bool Oskimb2AGIuCJh8mfh5()
	{
		return InRgpT22sTcFY6S0i2o == null;
	}
}
