using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Quicker.Utilities.UI;

[ValueConversion(typeof(String), typeof(String))]
public class RatioConverter : MarkupExtension, IValueConverter
{
	private static RatioConverter GRGv2h7MGTw;

	internal static RatioConverter rOasSsFHbK9RunykiM14;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (System.Convert.ToDouble(value, CultureInfo.InvariantCulture) * System.Convert.ToDouble(parameter, CultureInfo.InvariantCulture)).ToString("G0", CultureInfo.InvariantCulture);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return GRGv2h7MGTw ?? (GRGv2h7MGTw = new RatioConverter());
	}

	internal static bool TC4YX6FHqEtKtYBvDq8W()
	{
		return rOasSsFHbK9RunykiM14 == null;
	}
}
