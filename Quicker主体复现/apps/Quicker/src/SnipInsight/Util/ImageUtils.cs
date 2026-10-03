using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Media.Imaging;
using oXbLLb78vvxM0SkZwm;

namespace SnipInsight.Util;

public static class ImageUtils
{
	private static object O82647WZxM0isYPueGh;

	public static string OverlayImageWithPlayButton(BitmapSource source, out int outputWidth, out int outputHeight)
	{
		try
		{
			string text = Path.Combine(Path.GetTempPath(), string.Format("cNImage{0}.png", DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss")));
			string text2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Play_360x200.png");
			using (MemoryStream l7FxjamKuWxNGpNrA = new MemoryStream())
			{
				using Image image = new Bitmap(MQBHPX6oKQF3tv4OI5.EBhgJHPKjL(source, l7FxjamKuWxNGpNrA));
				double num = (double)image.Width / (double)image.Height;
				if (O82647WZxM0isYPueGh != null)
				{
					switch (0)
					{
					}
				}
				if (num > 1.0)
				{
					outputWidth = 320;
					outputHeight = (int)(320.0 / num);
				}
				else
				{
					outputHeight = 240;
					outputWidth = (int)(240.0 * num);
				}
				int num2 = outputHeight;
				int num3 = outputWidth;
				if (outputWidth < 150)
				{
					outputWidth = 150;
				}
				if (outputHeight < 150)
				{
					outputHeight = 150;
				}
				using Bitmap bitmap = new Bitmap(outputWidth, outputHeight);
				using Graphics graphics = Graphics.FromImage(bitmap);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(image, new Rectangle((outputWidth - num3) / 2, (outputHeight - num2) / 2, num3, num2), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
				if (File.Exists(text2))
				{
					int x = (int)((double)(outputWidth - 128) / 2.0);
					int num4 = 0;
					if (O82647WZxM0isYPueGh != null)
					{
						int num5 = default(int);
						num4 = num5;
					}
					switch (num4)
					{
					}
					int y = (int)((double)(outputHeight - 128) / 2.0);
					using Image image2 = Image.FromFile(text2);
					graphics.DrawImage(image2, new Rectangle(x, y, 128, 128));
				}
				graphics.Save();
				bitmap.Save(text, ImageFormat.Png);
			}
			return text;
		}
		catch (Exception)
		{
			outputWidth = 340;
			outputHeight = 240;
			return null;
		}
	}

	static ImageUtils()
	{
	}

	internal static bool StrbvqW54XGvqLuOw0N()
	{
		return O82647WZxM0isYPueGh == null;
	}

	internal static void atLFT1WPnYEio06o55s()
	{
	}
}
