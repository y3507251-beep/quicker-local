using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using MTvu7H59xFIE4dJJH9K;
using Quicker.ScreenSelectLib.Tools;
using XAK0Gv5H9h6VY926piI;

namespace ssVc8F5V5BPQdafyZEi;

internal static class uVl3oF5gw329ne6sMi2
{
	internal static object cMG0GC6Wu3grtddCcji;

	public static Bitmap zigr4uD9ct(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3)
	{
		Bitmap bitmap = null;
		DpiScale dpiScale = bxlYjy5DCfnONDuA8Y4.AtUxu8OsQY();
		if (int_2 > 0 && int_3 > 0)
		{
			IntPtr intptr_1 = lTX1EJ5crAHPVuUbPH8.Uc7rNqNWee(intptr_0);
			bitmap = new Bitmap(int_2, int_3, PixelFormat.Format32bppRgb);
			if (cMG0GC6Wu3grtddCcji == null)
			{
				switch (0)
				{
				}
			}
			bitmap.MakeTransparent();
			Graphics graphics = Graphics.FromImage(bitmap);
			lTX1EJ5crAHPVuUbPH8.OTTrWPsFSA(graphics.GetHdc(), 0, 0, int_2, int_3, intptr_1, int_0, int_1, (lTX1EJ5crAHPVuUbPH8.UVZRfnuYSiFXmr8tIZE)1087111200u);
			bitmap.SetResolution((float)(96.0 * dpiScale.X), (float)(96.0 * dpiScale.Y));
			graphics.ReleaseHdc();
			lTX1EJ5crAHPVuUbPH8.f2arE69QQ8(IntPtr.Zero, intptr_1);
			graphics.Dispose();
		}
		return bitmap;
	}

	public static Bitmap abfr5jOZBg(Bitmap bitmap_0, Rectangle rectangle_0, DpiScale dpiScale_0 = null)
	{
		Bitmap bitmap = hFIrDWrudu(bitmap_0, rectangle_0);
		if (dpiScale_0 != null && dpiScale_0.X > 0.0 && dpiScale_0.Y > 0.0)
		{
			bitmap.SetResolution((float)(96.0 * dpiScale_0.X), (float)(96.0 * dpiScale_0.Y));
		}
		return bitmap;
	}

	public static Bitmap hFIrDWrudu(Bitmap bitmap_0, Rectangle rectangle_0)
	{
		try
		{
			Bitmap bitmap = new Bitmap(rectangle_0.Width, rectangle_0.Height, PixelFormat.Format24bppRgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(bitmap_0, -rectangle_0.X, -rectangle_0.Y);
			}
			return bitmap;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static Bitmap kJMrdD7rve(Bitmap bitmap_0, int int_0, int int_1)
	{
		Bitmap bitmap = new Bitmap(int_0, int_1);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.DrawImage(bitmap_0, new Rectangle(0, 0, int_0, int_1));
		return bitmap;
	}

	internal static bool LLdCFK6y4fGL4DQY2ev()
	{
		return cMG0GC6Wu3grtddCcji == null;
	}
}
