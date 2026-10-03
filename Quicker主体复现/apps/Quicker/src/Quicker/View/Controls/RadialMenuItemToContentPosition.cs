using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.View.Controls;

internal class RadialMenuItemToContentPosition : IMultiValueConverter
{
	private static RadialMenuItemToContentPosition Cm71DYFfYZgHBQuOvx02;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values.Length != 6)
		{
			throw new ArgumentException("RadialMenuItemToContentPosition converter needs 6 values (double angle, double centerX, double centerY, double contentWidth, double contentHeight, double contentRadius) !", "values");
		}
		if (parameter != null)
		{
			int num = 0;
			if (!NOMsreFf8k8IAmns93pK())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				string text = (string)parameter;
				if (text != "X" && text != "Y")
				{
					throw new ArgumentException("RadialMenuItemToContentPosition parameter needs to be 'X' or 'Y' !", "parameter");
				}
				double double_ = (double)values[0];
				double x = (double)values[1];
				double y = (double)values[2];
				double num3 = (double)values[3];
				double num4 = (double)values[4];
				double double_2 = (double)values[5];
				Point point = OIVLByh1ome(new Point(x, y), double_, double_2);
				if (text == "X")
				{
					return point.X - num3 / 2.0;
				}
				return point.Y - num4 / 2.0;
			}
			}
		}
		throw new ArgumentNullException("parameter", "RadialMenuItemToContentPosition converter needs the parameter (string axis) !");
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new InvalidOperationException("RadialMenuItemToContentPosition is a One-Way converter only !");
	}

	private static Point OIVLByh1ome(Point point_0, double double_0, double double_1)
	{
		double num = Math.PI / 180.0 * (double_0 - 90.0);
		double num2 = double_1 * Math.Cos(num);
		double num3 = double_1 * Math.Sin(num);
		return new Point(num2 + point_0.X, num3 + point_0.Y);
	}

	internal static bool NOMsreFf8k8IAmns93pK()
	{
		return Cm71DYFfYZgHBQuOvx02 == null;
	}
}
