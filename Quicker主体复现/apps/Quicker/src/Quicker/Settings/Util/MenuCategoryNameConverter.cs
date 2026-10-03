using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;

namespace Quicker.Settings.Util;

public class MenuCategoryNameConverter : IValueConverter
{
	private static MenuCategoryNameConverter YPseXLSqS3D0kOQrTMw;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return value;
		}
		if (value is Enum enumValue)
		{
			return enumValue.GetEnumDisplayName();
		}
		string value2 = value as string;
		if (!string.IsNullOrEmpty(value2))
		{
			return ((SettingMenuCategory)Enum.Parse(typeof(SettingMenuCategory), value2)).GetEnumDisplayName();
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool g65IlbSiv4Pdv9yvFgP()
	{
		return YPseXLSqS3D0kOQrTMw == null;
	}
}
