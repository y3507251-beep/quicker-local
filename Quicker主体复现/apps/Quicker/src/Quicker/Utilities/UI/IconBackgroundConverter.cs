using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;

namespace Quicker.Utilities.UI;

public class IconBackgroundConverter : IValueConverter
{
	internal static IconBackgroundConverter Hyspk1FzKY7uckuj1rO4;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null && !string.IsNullOrEmpty(value.ToString()))
		{
			string text = value.ToString();
			if (text.StartsWith("StoreApp:", StringComparison.OrdinalIgnoreCase))
			{
				string appIconBackgroundColor = UWPHelper2.GetAppIconBackgroundColor(text.Substring("StoreApp:".Length));
				try
				{
					if (appIconBackgroundColor.Equals("transparent", StringComparison.OrdinalIgnoreCase))
					{
						return Color.FromRgb(90, 90, 90).GetBrush();
					}
					return new SolidColorBrush((Color)ColorConverter.ConvertFromString(appIconBackgroundColor));
				}
				catch (Exception)
				{
					return Color.FromRgb(90, 90, 90).GetBrush();
				}
			}
			File.Exists(text);
			return null;
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool C5eWShFzBiSEyafOAwsM()
	{
		return Hyspk1FzKY7uckuj1rO4 == null;
	}

	internal static void Uw5WcnFzOj26XnChP0u9()
	{
	}
}
