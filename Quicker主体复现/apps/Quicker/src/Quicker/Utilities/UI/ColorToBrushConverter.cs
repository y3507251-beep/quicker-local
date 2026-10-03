using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Quicker.Utilities.UI;

public class ColorToBrushConverter : IValueConverter
{
	private static ColorToBrushConverter p6Ane0F7xikhwNLMZXBZ;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null)
		{
			return new SolidColorBrush((Color)value);
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (value as SolidColorBrush)?.Color;
	}

	internal static bool txtSiCF7IsHrw1SjZ2eX()
	{
		return p6Ane0F7xikhwNLMZXBZ == null;
	}
}
