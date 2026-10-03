using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.View.Controls;

internal class RadialMenuItemToArrowPosition : IMultiValueConverter
{
	internal static RadialMenuItemToArrowPosition mRXHwFFfi5INUmDnLuD7;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values.Length != 5)
		{
			throw new ArgumentException("RadialMenuItemToArrowPosition converter needs 7 values (double centerX, double centerY, double arrowWidth, double arrowHeight, double arrowRadius) !", "values");
		}
		if (parameter == null)
		{
			throw new ArgumentNullException("parameter", "RadialMenuItemToArrowPosition converter needs the parameter (string axis) !");
		}
		string text = (string)parameter;
		if (text != "X" && text != "Y")
		{
			throw new ArgumentException("RadialMenuItemToArrowPosition parameter needs to be 'X' or 'Y' !", "parameter");
		}
		double num = (double)values[0];
		if (MIhog5FflOcYdOdhUjJ5())
		{
			switch (0)
			{
			}
		}
		double num2 = (double)values[1];
		double num3 = (double)values[2];
		double num4 = (double)values[3];
		double num5 = (double)values[4];
		if (text == "X")
		{
			return num - num3 / 2.0;
		}
		return num2 - num5 - num4 / 2.0;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new InvalidOperationException("RadialMenuItemToArrowPosition is a One-Way converter only !");
	}

	private static Point bkILBE1lqlA(Point point_0, double double_0, double double_1)
	{
		double num = Math.PI / 180.0 * (double_0 - 90.0);
		double num2 = double_1 * Math.Cos(num);
		double num3 = double_1 * Math.Sin(num);
		return new Point(num2 + point_0.X, num3 + point_0.Y);
	}

	static RadialMenuItemToArrowPosition()
	{
	}

	internal static bool MIhog5FflOcYdOdhUjJ5()
	{
		return mRXHwFFfi5INUmDnLuD7 == null;
	}

	internal static void YduioSFf58x9220C2Vt5()
	{
	}
}
