using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class FileIconConverter : IValueConverter
{
	internal static FileIconConverter OR0p9fFzAZHm5a0KGXEU;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null && !string.IsNullOrEmpty(value.ToString()))
		{
			string text = value.ToString();
			if (File.Exists(text))
			{
				try
				{
					return IconHelper.IconToImageSource(Icon.ExtractAssociatedIcon(text));
				}
				catch
				{
					return null;
				}
			}
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool udcDMqFznOEr5AGoPuUK()
	{
		return OR0p9fFzAZHm5a0KGXEU == null;
	}
}
