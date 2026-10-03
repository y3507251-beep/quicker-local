using System;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class ListToStringConverter : IValueConverter
{
	internal static ListToStringConverter v0Lx1HFsxpWRVeQyH5uW;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is IEnumerable enumerable && !(value is string))
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (object item in enumerable)
			{
				stringBuilder.Append(item.ToString());
				stringBuilder.Append(';');
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Length--;
			}
			return stringBuilder.ToString();
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool QvvWNlFsIHURm2yZHcYs()
	{
		return v0Lx1HFsxpWRVeQyH5uW == null;
	}
}
