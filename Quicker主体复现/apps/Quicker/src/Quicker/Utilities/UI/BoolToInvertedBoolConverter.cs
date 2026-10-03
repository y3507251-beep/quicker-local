using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class BoolToInvertedBoolConverter : IValueConverter
{
	private static BoolToInvertedBoolConverter RHFus6F7PQ6bL3UvHoKM;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool)
		{
			return !(bool)value;
		}
		return false;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool)
		{
			return !(bool)value;
		}
		return false;
	}

	internal static bool Jc9mQkF7MYImiiGXR9tQ()
	{
		return RHFus6F7PQ6bL3UvHoKM == null;
	}
}
