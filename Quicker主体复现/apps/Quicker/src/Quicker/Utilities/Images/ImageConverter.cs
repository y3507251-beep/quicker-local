using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace Quicker.Utilities.Images;

public static class ImageConverter
{
	internal static object QFngqPcQEVl9UvnoiTEp;

	public static Bitmap ToBitmap(object src)
	{
		if (src is Bitmap)
		{
			return (Bitmap)src;
		}
		if (src is Image)
		{
			return new Bitmap(src as Image);
		}
		if (src is BitmapSource)
		{
			return BitmapSourceToBitmap2(src as BitmapSource);
		}
		return null;
	}

	public static Bitmap BitmapSourceToBitmap2(BitmapSource srs)
	{
		int pixelWidth = srs.PixelWidth;
		int pixelHeight = srs.PixelHeight;
		int num = pixelWidth * ((srs.Format.BitsPerPixel + 7) / 8);
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.AllocHGlobal(pixelHeight * num);
			srs.CopyPixels(new Int32Rect(0, 0, pixelWidth, pixelHeight), intPtr, pixelHeight * num, num);
			using Bitmap original = new Bitmap(pixelWidth, pixelHeight, num, PixelFormat.Format1bppIndexed, intPtr);
			return new Bitmap(original);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	public static Bitmap GetBitmap(BitmapSource source)
	{
		Bitmap bitmap = new Bitmap(source.PixelWidth, source.PixelHeight, PixelFormat.Format24bppRgb);
		BitmapData bitmapData = bitmap.LockBits(new Rectangle(System.Drawing.Point.Empty, bitmap.Size), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
		source.CopyPixels(Int32Rect.Empty, bitmapData.Scan0, bitmapData.Height * bitmapData.Stride, bitmapData.Stride);
		bitmap.UnlockBits(bitmapData);
		return bitmap;
	}

	public static BitmapSource ConvertBitmap(Bitmap source)
	{
		return Imaging.CreateBitmapSourceFromHBitmap(source.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
	}

	public static Bitmap BitmapFromSource(BitmapSource bitmapsource)
	{
		using MemoryStream stream = new MemoryStream();
		BmpBitmapEncoder bmpBitmapEncoder = new BmpBitmapEncoder();
		bmpBitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapsource));
		bmpBitmapEncoder.Save(stream);
		using Bitmap original = new Bitmap(stream);
		return new Bitmap(original);
	}

	internal static bool VkfhJ6cQG6SeqmEMfM8l()
	{
		return QFngqPcQEVl9UvnoiTEp == null;
	}
}
