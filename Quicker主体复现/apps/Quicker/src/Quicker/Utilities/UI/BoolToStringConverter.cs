using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class BoolToStringConverter : IValueConverter
{
	internal static BoolToStringConverter N346HQFsPPW3UiSKO1C3;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool flag)
		{
			if (parameter is string text)
			{
				string[] array = text.Split('|');
				if (array.Length == 2)
				{
					if (!flag)
					{
						return array[0];
					}
					return array[1];
				}
			}
			if (!flag)
			{
				return "False";
			}
			return "True";
		}
		return "False";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool UENi3qFsM6c5vm97ydkn()
	{
		return N346HQFsPPW3UiSKO1C3 == null;
	}
}
