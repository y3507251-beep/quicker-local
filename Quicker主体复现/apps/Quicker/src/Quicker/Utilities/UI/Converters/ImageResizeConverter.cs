using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Quicker.Utilities.Ext;

namespace Quicker.Utilities.UI.Converters;

public class ImageResizeConverter : IValueConverter
{
	[CompilerGenerated]
	private int Kesvu3RdXGK = 100;

	[CompilerGenerated]
	private int Pgfvuf0Vu4Z = 100;

	private static ImageResizeConverter ycVBC6cVEKGgqWggmEEc;

	public int DecodePixelWidth
	{
		[CompilerGenerated]
		get
		{
			return Kesvu3RdXGK;
		}
		[CompilerGenerated]
		set
		{
			Kesvu3RdXGK = value;
		}
	}

	public int DecodePixelHeight
	{
		[CompilerGenerated]
		get
		{
			return Pgfvuf0Vu4Z;
		}
		[CompilerGenerated]
		set
		{
			Pgfvuf0Vu4Z = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is string text && !string.IsNullOrEmpty(text))
		{
			try
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
				bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
				if (!AyKRMUcVGS3mjdoIaXM5())
				{
					switch (0)
					{
					}
				}
				bitmapImage.UriSource = new Uri(text, UriKind.RelativeOrAbsolute);
				bitmapImage.DecodePixelWidth = DecodePixelWidth;
				bitmapImage.DecodePixelHeight = DecodePixelHeight;
				bitmapImage.EndInit();
				if (bitmapImage.CanFreeze)
				{
					bitmapImage.TryFreeze();
				}
				return bitmapImage;
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	static ImageResizeConverter()
	{
	}

	internal static bool AyKRMUcVGS3mjdoIaXM5()
	{
		return ycVBC6cVEKGgqWggmEEc == null;
	}

	internal static void UPQqcAcV14soATCoq4Ji()
	{
	}
}
