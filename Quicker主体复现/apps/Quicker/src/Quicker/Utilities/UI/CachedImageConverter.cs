using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class CachedImageConverter : IValueConverter
{
	private static CachedImageConverter UbEx9PFzQsMHZdilXKgy;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null && !string.IsNullOrEmpty(value.ToString()))
		{
			return ImageCache.GetImageSource(value.ToString());
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool AJeev0FzF6tLs7kAk7WJ()
	{
		return UbEx9PFzQsMHZdilXKgy == null;
	}

	internal static void ArgP1rFzWm6jKxwtGRG1()
	{
	}
}
