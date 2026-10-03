using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Public.Actions;

namespace Quicker.Utilities.UI;

public class VarTypeToIconConverter : IValueConverter
{
	private static VarTypeToIconConverter CW8glVF4VO2UnJnUxJMn;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return "";
		}
		if (value is VarType type)
		{
			return AppHelper.GetVarTypeIconStr(type);
		}
		return "";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	static VarTypeToIconConverter()
	{
	}

	internal static bool V04SpfF4QjISmBXF4u8c()
	{
		return CW8glVF4VO2UnJnUxJMn == null;
	}

	internal static void DHr9fyF4c3vVx07uyNQB()
	{
	}
}
