using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

[ValueConversion(typeof(Boolean), typeof(Visibility))]
public class InvertedBooleanToVisibilityConverter : IValueConverter
{
	private static InvertedBooleanToVisibilityConverter ne9yV9F7tcevU3jpBe0g;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return ((bool)value) ? Visibility.Collapsed : Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return null;
	}

	internal static bool hGNE3AF7S8VsSVMWIv8e()
	{
		return ne9yV9F7tcevU3jpBe0g == null;
	}
}
