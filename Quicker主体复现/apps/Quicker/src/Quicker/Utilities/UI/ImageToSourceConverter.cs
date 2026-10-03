using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class ImageToSourceConverter : IValueConverter
{
	private static ImageToSourceConverter T2gH9uFzrwCJ6yXlgnPE;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is Image img)
		{
			return IconHelper.ImageToImageSource(img);
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool dovOZVFzNm8VtcDU0PXV()
	{
		return T2gH9uFzrwCJ6yXlgnPE == null;
	}
}
