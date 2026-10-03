using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

[ValueConversion(typeof(String), typeof(Visibility))]
public class PathToVisibilityConverter : IValueConverter
{
	internal static PathToVisibilityConverter Fk5awKFsw9P71IlmBldJ;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		bool flag = false;
		if (parameter != null)
		{
			flag = bool.Parse(parameter.ToString());
		}
		string text = value as string;
		if (!string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (!xhRwuaFsTHY93Ri4uYfY())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (File.Exists(text) || Directory.Exists(text))
			{
				return flag ? Visibility.Collapsed : Visibility.Visible;
			}
		}
		return (!flag) ? Visibility.Collapsed : Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool xhRwuaFsTHY93Ri4uYfY()
	{
		return Fk5awKFsw9P71IlmBldJ == null;
	}
}
