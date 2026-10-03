using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Quicker.Utilities.Images;

public static class ImageProcessingHelper
{
	private static object kKluQGcV4PPsnVZ0ibcS;

	public unsafe static bool Invert(Bitmap b)
	{
		BitmapData bitmapData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
		int stride = bitmapData.Stride;
		byte* ptr = (byte*)(void*)bitmapData.Scan0;
		int num = stride - b.Width * 3;
		int num2 = b.Width * 3;
		for (int i = 0; i < b.Height; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				*ptr = (byte)(255 - *ptr);
				ptr++;
			}
			ptr += num;
		}
		int num3 = 0;
		if (!m6RrAwcVh9sMcrLgO0Jj())
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
			b.UnlockBits(bitmapData);
			return true;
		}
	}

	public unsafe static bool GrayScale(Bitmap b)
	{
		BitmapData bitmapData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
		int stride = bitmapData.Stride;
		byte* ptr = (byte*)(void*)bitmapData.Scan0;
		int num = stride - b.Width * 3;
		for (int i = 0; i < b.Height; i++)
		{
			for (int j = 0; j < b.Width; j++)
			{
				byte b2 = *ptr;
				byte b3 = ptr[1];
				byte b4 = ptr[2];
				*ptr = (ptr[1] = (ptr[2] = (byte)(0.299 * (double)(int)b4 + 0.587 * (double)(int)b3 + 0.114 * (double)(int)b2)));
				if (m6RrAwcVh9sMcrLgO0Jj())
				{
					switch (0)
					{
					}
				}
				ptr += 3;
			}
			ptr += num;
		}
		b.UnlockBits(bitmapData);
		return true;
	}

	public unsafe static bool Brightness(Bitmap b, int nBrightness)
	{
        int num6 = default;
		BitmapData bitmapData = default(BitmapData);
		byte* ptr = default(byte*);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5;
		int num = default(int);
		if (nBrightness >= -255)
		{
			if (nBrightness <= 255)
			{
				bitmapData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
				int stride = bitmapData.Stride;
				IntPtr scan = bitmapData.Scan0;
				num = 0;
				ptr = (byte*)(void*)scan;
				num2 = stride - b.Width * 3;
				num3 = b.Width * 3;
				num4 = 0;
				goto IL_00e1;
			}
			num5 = 0;
			if (kKluQGcV4PPsnVZ0ibcS != null)
			{
				goto IL_009d;
			}
		}
		goto IL_00f5;
		IL_00f5:
		return false;
		IL_00ce:
		num6 = default(int);
		if (num6 < num3)
		{
			num = *ptr + nBrightness;
			if (num < 0)
			{
				num = 0;
				num5 = 1;
				if (!m6RrAwcVh9sMcrLgO0Jj())
				{
					int num7 = default(int);
					num5 = num7;
				}
				goto IL_009d;
			}
			goto IL_00ac;
		}
		ptr += num2;
		num4++;
		goto IL_00e1;
		IL_00e1:
		if (num4 < b.Height)
		{
			num6 = 0;
			goto IL_00ce;
		}
		b.UnlockBits(bitmapData);
		return true;
		IL_009d:
		switch (num5)
		{
		case 1:
			break;
		default:
			goto IL_00f5;
		}
		goto IL_00ac;
		IL_00ac:
		if (num > 255)
		{
			num = 255;
		}
		*ptr = (byte)num;
		ptr++;
		num6++;
		goto IL_00ce;
	}

	public unsafe static bool Contrast(Bitmap b, sbyte nContrast)
	{
		if (nContrast < -100)
		{
			return false;
		}
		if (nContrast > 100)
		{
			return false;
		}
		double num = 0.0;
		int num2 = 0;
		if (kKluQGcV4PPsnVZ0ibcS != null)
		{
			goto IL_01f6;
		}
		goto IL_0252;
		IL_0252:
		BitmapData bitmapData = default(BitmapData);
		byte* ptr = default(byte*);
		int num5 = default(int);
		int num6 = default(int);
		int num4 = default(int);
		double num3 = default(double);
		do
		{
			byte num7;
			byte num8;
			switch (num2)
			{
			case 2:
			{
				int stride = bitmapData.Stride;
				ptr = (byte*)(void*)bitmapData.Scan0;
				num5 = stride - b.Width * 3;
				num6 = 0;
				goto IL_006d;
			}
			case 1:
				ptr += 3;
				num4++;
				goto IL_0056;
			default:
				{
					num3 = (100.0 + (double)nContrast) / 100.0;
					num3 *= num3;
					bitmapData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
					goto case 2;
				}
				IL_006d:
				if (num6 < b.Height)
				{
					num4 = 0;
					goto IL_0056;
				}
				b.UnlockBits(bitmapData);
				return true;
				IL_0056:
				if (num4 >= b.Width)
				{
					ptr += num5;
					num6++;
					goto IL_006d;
				}
				num7 = *ptr;
				num8 = ptr[1];
				num = (double)(int)ptr[2] / 255.0;
				num -= 0.5;
				num *= num3;
				num += 0.5;
				num *= 255.0;
				if (num < 0.0)
				{
					num = 0.0;
				}
				if (num > 255.0)
				{
					num = 255.0;
				}
				ptr[2] = (byte)num;
				num = (double)(int)num8 / 255.0;
				num -= 0.5;
				num *= num3;
				num += 0.5;
				num *= 255.0;
				if (num < 0.0)
				{
					num = 0.0;
				}
				if (num > 255.0)
				{
					num = 255.0;
				}
				ptr[1] = (byte)num;
				num = (double)(int)num7 / 255.0;
				num -= 0.5;
				num *= num3;
				num += 0.5;
				num *= 255.0;
				if (num < 0.0)
				{
					num = 0.0;
				}
				if (num > 255.0)
				{
					num = 255.0;
				}
				break;
			}
			*ptr = (byte)num;
			num2 = 1;
		}
		while (kKluQGcV4PPsnVZ0ibcS == null);
		goto IL_01f6;
		IL_01f6:
		int num9 = default(int);
		num2 = num9;
		goto IL_0252;
	}

	public unsafe static bool Gamma(Bitmap b, double red, double green, double blue)
	{
		if (!(red < 0.2) && red <= 5.0)
		{
			if (!(green < 0.2) && green <= 5.0)
			{
				if (!(blue < 0.2) && blue <= 5.0)
				{
					byte[] array = new byte[256];
					byte[] array2 = new byte[256];
					int num = 2;
					if (kKluQGcV4PPsnVZ0ibcS != null)
					{
						int num2 = default(int);
						num = num2;
					}
					byte[] array3 = default(byte[]);
					BitmapData bitmapData = default(BitmapData);
					byte* ptr = default(byte*);
					int num3 = default(int);
					int num4 = default(int);
					int num5 = default(int);
					while (true)
					{
						switch (num)
						{
						case 2:
						{
							array3 = new byte[256];
							for (int i = 0; i < 256; i++)
							{
								array[i] = (byte)Math.Min(255, (int)(255.0 * Math.Pow((double)i / 255.0, 1.0 / red) + 0.5));
								array2[i] = (byte)Math.Min(255, (int)(255.0 * Math.Pow((double)i / 255.0, 1.0 / green) + 0.5));
								array3[i] = (byte)Math.Min(255, (int)(255.0 * Math.Pow((double)i / 255.0, 1.0 / blue) + 0.5));
							}
							bitmapData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
							int stride = bitmapData.Stride;
							ptr = (byte*)(void*)bitmapData.Scan0;
							num3 = stride - b.Width * 3;
							num4 = 0;
							goto default;
						}
						case 1:
							while (num5 < b.Width)
							{
								ptr[2] = array[ptr[2]];
								ptr[1] = array2[ptr[1]];
								*ptr = array3[*ptr];
								ptr += 3;
								num5++;
								num = 0;
								if (kKluQGcV4PPsnVZ0ibcS != null)
								{
									goto end_IL_022e;
								}
							}
							ptr += num3;
							num4++;
							num = 0;
							if (kKluQGcV4PPsnVZ0ibcS != null)
							{
								break;
							}
							goto default;
						default:
							{
								if (num4 < b.Height)
								{
									num5 = 0;
									goto case 1;
								}
								b.UnlockBits(bitmapData);
								return true;
							}
							end_IL_022e:
							break;
						}
					}
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public unsafe static bool Color(Bitmap b, int red, int green, int blue)
	{
		if (red >= -255 && red <= 255)
		{
			if (green >= -255 && green <= 255)
			{
				if (blue >= -255 && blue <= 255)
				{
					BitmapData bitmapData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
					int stride = bitmapData.Stride;
					byte* ptr = (byte*)(void*)bitmapData.Scan0;
					int num = stride - b.Width * 3;
					int num4 = default(int);
					for (int i = 0; i < b.Height; i++)
					{
						for (int num2 = 0; num2 < b.Width; num2++)
						{
							int val = ptr[2] + red;
							val = Math.Max(val, 0);
							ptr[2] = (byte)Math.Min(255, val);
							val = ptr[1] + green;
							int num3 = 1;
							if (!m6RrAwcVh9sMcrLgO0Jj())
							{
								goto IL_00f9;
							}
							goto IL_011f;
							IL_00f9:
							num3 = num4;
							goto IL_011f;
							IL_011f:
							while (true)
							{
								switch (num3)
								{
								case 1:
									val = Math.Max(val, 0);
									ptr[1] = (byte)Math.Min(255, val);
									num3 = 0;
									if (kKluQGcV4PPsnVZ0ibcS == null)
									{
										continue;
									}
									break;
								default:
									val = *ptr + blue;
									val = Math.Max(val, 0);
									num3 = 2;
									if (kKluQGcV4PPsnVZ0ibcS == null)
									{
										continue;
									}
									break;
								case 2:
									goto end_IL_011f;
								}
								goto IL_00f9;
								continue;
								end_IL_011f:
								break;
							}
							*ptr = (byte)Math.Min(255, val);
							ptr += 3;
						}
						ptr += num;
					}
					b.UnlockBits(bitmapData);
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static Bitmap ResizeByMaxWidthOrHeight(Bitmap bmpSrc, int maxWidth, int maxHeight)
	{
		double num;
		while (true)
		{
			num = 1.0;
			if (kKluQGcV4PPsnVZ0ibcS != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (maxWidth > 0)
		{
			num = (double)maxWidth / (double)bmpSrc.Width;
		}
		if (maxHeight > 0)
		{
			double num2 = (double)maxHeight / (double)bmpSrc.Height;
			num = ((num > num2) ? num2 : num);
		}
		if (num <= 0.0)
		{
			AppHelper.ShowWarning("图片缩放比例不正确。");
		}
		return ResizeByPercent(bmpSrc, num);
	}

	public static Bitmap ResizeByPercent(Bitmap bmpSrc, double ratio)
	{
		int width = (int)((double)bmpSrc.Width * ratio);
		int height = (int)((double)bmpSrc.Height * ratio);
		Bitmap bitmap = new Bitmap(width, height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		using ImageAttributes imageAttributes = new ImageAttributes();
		imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
		graphics.DrawImage(bmpSrc, new Rectangle(0, 0, width, height), 0, 0, bmpSrc.Width, bmpSrc.Height, GraphicsUnit.Pixel, imageAttributes);
		return bitmap;
	}

	internal static bool m6RrAwcVh9sMcrLgO0Jj()
	{
		return kKluQGcV4PPsnVZ0ibcS == null;
	}
}
