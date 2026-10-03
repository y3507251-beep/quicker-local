using System;
using System.Collections;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class NullOrEmptyCollectionToVisibilityConverter : IValueConverter
{
	internal static NullOrEmptyCollectionToVisibilityConverter BwkJMrF4UvU7fQQ58hDC;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return Visibility.Collapsed;
		}
		return (value is ICollection collection) ? ((collection.Count == 0) ? Visibility.Collapsed : Visibility.Visible) : Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool BsPd4ZF4xfFh8e9HGBB9()
	{
		return BwkJMrF4UvU7fQQ58hDC == null;
	}
}
