using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace SnipInsight.ImageCapture;

public class RectangleConverter : MarkupExtension, IMultiValueConverter
{
	private static RectangleConverter cnsLPVo793;

	private static RectangleConverter ACPMEnyt34YurRjNjKZ;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values.Length == 2)
		{
			double width = System.Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			double height = System.Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			return new Rect(0.0, 0.0, width, height);
		}
		return null;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return cnsLPVo793 ?? (cnsLPVo793 = new RectangleConverter());
	}

	internal static bool dtqo2TyS4ptiysTpYHE()
	{
		return ACPMEnyt34YurRjNjKZ == null;
	}
}
