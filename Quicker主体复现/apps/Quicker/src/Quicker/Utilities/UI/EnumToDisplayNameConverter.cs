using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Public.Extensions;

namespace Quicker.Utilities.UI;

public class EnumToDisplayNameConverter : IValueConverter
{
	private static EnumToDisplayNameConverter dxpQEFF4w47J4Rsx817d;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return "";
		}
		if (value is string)
		{
			return value;
		}
		return ((Enum)value).GetEnumDisplayName();
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	internal static bool nFFVKNF4TwDpReho4SUZ()
	{
		return dxpQEFF4w47J4Rsx817d == null;
	}
}
