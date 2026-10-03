using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using gNDpGkYZYbhLdMnAyKv;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Utilities.Images;

namespace Quicker.Utilities;

public static class ImageClipboardHelper
{
	public class ClipboardFunctions
	{
		private static ClipboardFunctions kVpUinyAxMGO2cyPUMpu;

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern bool OpenClipboard(IntPtr hWnd);

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern bool EmptyClipboard();

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr SetClipboardData(int uFormat, IntPtr hWnd);

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern bool CloseClipboard();

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetClipboardData(int uFormat);

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern short IsClipboardFormatAvailable(int uFormat);

		internal static bool pgWYDnyAItqeyHAI6oQO()
		{
			return kVpUinyAxMGO2cyPUMpu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public Bitmap gmRSzarBdc3;

		internal static _003C_003Ec__DisplayClass9_0 cLX0n4yAt5JNG64Ak9pn;

		internal void PYsSz8s8uUS()
		{
			if (kWsP1bYRVsfaicfjr67.tfwL5WeF6q7() is DataObject dataObject_)
			{
				gmRSzarBdc3 = TSALdS2ulpS(dataObject_);
			}
		}

		internal static bool VtZubuyASYZneISUZfmP()
		{
			return cLX0n4yAt5JNG64Ak9pn == null;
		}
	}

	internal static object hwnmsYFZvPA1X57xrHyZ;

	public static void SetImage(Image image)
	{
		if (!image.RawFormat.Equals(ImageFormat.Gif))
		{
			hObLDzYYjhS(image, null, null);
			return;
		}
		string text = ImageHelper.SaveToTempFile(image);
		string[] data = new string[1] { text };
		DataObject dataObject = new DataObject();
		((IDataObject)dataObject).SetData(DataFormats.FileDrop, (object)data, false);
		((IDataObject)dataObject).SetData(DataFormats.Bitmap, (object)image, true);
		kWsP1bYRVsfaicfjr67.AoML5mTBA4V(dataObject, true);
	}

	public static void SetImageFromFile(string imageFile)
	{
		if (imageFile.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
		{
			string[] data = new string[1] { imageFile };
			DataObject dataObject = new DataObject();
			((IDataObject)dataObject).SetData(DataFormats.FileDrop, (object)data, false);
			Image data2 = ImageHelper.ReadImageFromFileWithoutLock(imageFile);
			((IDataObject)dataObject).SetData(DataFormats.Bitmap, (object)data2, true);
			kWsP1bYRVsfaicfjr67.AoML5mTBA4V(dataObject, true);
		}
		else
		{
			hObLDzYYjhS(ImageHelper.ReadImageFromFileWithoutLock(imageFile), null, null);
		}
	}

	private static void hObLDzYYjhS(Image image_0, Image image_1, DataObject dataObject_0)
	{
		if (dataObject_0 == null)
		{
			dataObject_0 = new DataObject();
		}
		if (image_1 == null)
		{
			image_1 = image_0;
		}
		using MemoryStream memoryStream = new MemoryStream();
		using MemoryStream memoryStream2 = new MemoryStream();
		dataObject_0.SetData(DataFormats.Bitmap, image_1, true);
		image_0.Save(memoryStream, ImageFormat.Png);
		dataObject_0.SetData("PNG", memoryStream, false);
		byte[] array = f2WLdwknsNK(image_0);
		memoryStream2.Write(array, 0, array.Length);
		dataObject_0.SetData(DataFormats.Dib, memoryStream2, false);
		kWsP1bYRVsfaicfjr67.AoML5mTBA4V(dataObject_0, true);
	}

	private static byte[] f2WLdwknsNK(Image image_0)
	{
		int width = image_0.Width;
		int height = image_0.Height;
		byte[] array;
		using (Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height, PixelFormat.Format32bppArgb))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(image_0, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
			}
			bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
			array = m9XLdvdhEJx(bitmap, out var int_);
		}
		int num = 40;
		byte[] array2 = new byte[52 + array.Length];
		BXpLdtHWOpS(array2, 0, 4, true, 40u);
		BXpLdtHWOpS(array2, 4, 4, true, (uint)width);
		BXpLdtHWOpS(array2, 8, 4, true, (uint)height);
		BXpLdtHWOpS(array2, 12, 2, true, 1u);
		BXpLdtHWOpS(array2, 14, 2, true, 32u);
		BXpLdtHWOpS(array2, 16, 4, true, 3u);
		BXpLdtHWOpS(array2, 20, 4, true, (uint)array.Length);
		int num2 = 0;
		if (hwnmsYFZvPA1X57xrHyZ != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
			BXpLdtHWOpS(array2, num, 4, true, 16711680u);
			BXpLdtHWOpS(array2, num + 4, 4, true, 65280u);
			BXpLdtHWOpS(array2, num + 8, 4, true, 255u);
			Array.Copy(array, 0, array2, num + 12, array.Length);
			return array2;
		}
	}

	private static void BXpLdtHWOpS(byte[] byte_0, int int_0, int int_1, bool bool_0, uint uint_0)
	{
		int num = int_1 - 1;
		if (byte_0.Length < int_0 + int_1)
		{
			throw new ArgumentOutOfRangeException("startIndex", "Data array is too small to write a " + int_1 + "-byte value at offset " + int_0 + ".");
		}
		for (int i = 0; i < int_1; i++)
		{
			int num2 = int_0 + (bool_0 ? i : (num - i));
			byte_0[num2] = (byte)((uint_0 >> 8 * i) & 0xFF);
		}
	}

	private static uint dQtLdgG5QS8(byte[] byte_0, int int_0, int int_1, bool bool_0)
	{
		int num = int_1 - 1;
		if (byte_0.Length < int_0 + int_1)
		{
			throw new ArgumentOutOfRangeException("startIndex", "Data array is too small to read a " + int_1 + "-byte value at offset " + int_0 + ".");
		}
		uint num2 = 0u;
		int num3 = 0;
		if (hwnmsYFZvPA1X57xrHyZ != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
		{
			for (int i = 0; i < int_1; i++)
			{
				int num5 = int_0 + (bool_0 ? i : (num - i));
				num2 += (uint)(byte_0[num5] << 8 * i);
			}
			return num2;
		}
		}
	}

	private static Bitmap GupLdLic64r(byte[] byte_0, int int_0, int int_1, int int_2, PixelFormat pixelFormat_0, Color[] color_0, Color? nullable_0)
	{
		Bitmap bitmap = new Bitmap(int_0, int_1, pixelFormat_0);
		BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, int_0, int_1), ImageLockMode.WriteOnly, bitmap.PixelFormat);
		int length = (Image.GetPixelFormatSize(pixelFormat_0) * int_0 + 7) / 8;
		bool flag = int_2 < 0;
		int_2 = Math.Abs(int_2);
		int stride = bitmapData.Stride;
		long num = bitmapData.Scan0.ToInt64();
		for (int i = 0; i < int_1; i++)
		{
			Marshal.Copy(byte_0, i * int_2, new IntPtr(num + i * stride), length);
		}
		bitmap.UnlockBits(bitmapData);
		if (flag)
		{
			bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
		}
		if ((pixelFormat_0 & PixelFormat.Indexed) != PixelFormat.Undefined && color_0 != null)
		{
			ColorPalette palette = bitmap.Palette;
			for (int j = 0; j < palette.Entries.Length; j++)
			{
				if (j < color_0.Length)
				{
					palette.Entries[j] = color_0[j];
					continue;
				}
				if (!nullable_0.HasValue)
				{
					break;
				}
				palette.Entries[j] = nullable_0.Value;
			}
			bitmap.Palette = palette;
		}
		return bitmap;
	}

	private static byte[] m9XLdvdhEJx(Bitmap bitmap_0, out int int_0)
	{
		BitmapData bitmapData = bitmap_0.LockBits(new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), ImageLockMode.ReadOnly, bitmap_0.PixelFormat);
		int_0 = bitmapData.Stride;
		byte[] array = new byte[int_0 * bitmap_0.Height];
		Marshal.Copy(bitmapData.Scan0, array, 0, array.Length);
		bitmap_0.UnlockBits(bitmapData);
		return array;
	}

	public static Bitmap GetImageFromClipboard()
	{
		try
		{
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
			_003C_003Ec__DisplayClass9_.gmRSzarBdc3 = null;
			Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(_003C_003Ec__DisplayClass9_.PYsSz8s8uUS);
			return _003C_003Ec__DisplayClass9_.gmRSzarBdc3;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static Bitmap TSALdS2ulpS(DataObject dataObject_0)
	{
		Bitmap bitmap = null;
		if (dataObject_0.GetDataPresent("PNG") && dataObject_0.GetData("PNG") is MemoryStream stream)
		{
			using Bitmap bitmap_ = new Bitmap(stream);
			bitmap = U4nLd2EBKqB(bitmap_);
		}
		if (bitmap == null && dataObject_0.GetDataPresent(DataFormats.Dib) && dataObject_0.GetData(DataFormats.Dib) is MemoryStream memoryStream)
		{
			bitmap = qsSLduFwcf2(memoryStream.ToArray());
		}
		if (bitmap == null && dataObject_0.GetDataPresent(DataFormats.Bitmap))
		{
			bitmap = new Bitmap(dataObject_0.GetData(DataFormats.Bitmap) as Image);
		}
		if (bitmap == null)
		{
			int num = 0;
			if (hwnmsYFZvPA1X57xrHyZ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (dataObject_0.GetDataPresent(typeof(Image)))
			{
				bitmap = new Bitmap(dataObject_0.GetData(typeof(Image)) as Image);
			}
		}
		return bitmap;
	}

	private static Bitmap U4nLd2EBKqB(Bitmap bitmap_0)
	{
		int int_;
		return GupLdLic64r(m9XLdvdhEJx(bitmap_0, out int_), bitmap_0.Width, bitmap_0.Height, int_, bitmap_0.PixelFormat, null, null);
	}

	private static Bitmap qsSLduFwcf2(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length >= 4)
		{
			try
			{
				int num = (int)dQtLdgG5QS8(byte_0, 0, 4, true);
				if (num == 40)
				{
					byte[] array = new byte[40];
					Array.Copy(byte_0, array, 40);
					int num2 = 2;
					PixelFormat pixelFormat_ = default(PixelFormat);
					short num10 = default(short);
					int num6 = default(int);
					byte[] array2 = default(byte[]);
					int int_2 = default(int);
					while (true)
					{
						int num3 = num;
						int num4 = (int)dQtLdgG5QS8(array, 4, 4, true);
						int int_ = (int)dQtLdgG5QS8(array, 8, 4, true);
						int num5 = 0;
						if (hwnmsYFZvPA1X57xrHyZ != null)
						{
							goto IL_00a1;
						}
						goto IL_0103;
						IL_0103:
						while (true)
						{
							switch (num5)
							{
							case 4:
								pixelFormat_ = PixelFormat.Format16bppRgb555;
								goto IL_0051;
							case 1:
								if (num10 == 16)
								{
									goto case 4;
								}
								if (num10 != 24)
								{
									if (num10 != 32)
									{
										return null;
									}
									pixelFormat_ = PixelFormat.Format32bppRgb;
								}
								else
								{
									pixelFormat_ = PixelFormat.Format24bppRgb;
								}
								goto IL_0051;
							default:
							{
								short num11 = (short)dQtLdgG5QS8(array, 12, 2, true);
								num10 = (short)dQtLdgG5QS8(array, 14, 2, true);
								num6 = (int)dQtLdgG5QS8(array, 16, 4, true);
								if (num11 != 1 || (num6 != 0 && num6 != 3))
								{
									return null;
								}
								goto case 1;
							}
							case 2:
								break;
							case 3:
								{
									if (num6 == 3)
									{
										uint num7 = dQtLdgG5QS8(byte_0, num, 4, true);
										uint num8 = dQtLdgG5QS8(byte_0, num + 4, 4, true);
										uint num9 = dQtLdgG5QS8(byte_0, num + 8, 4, true);
										if (num10 != 32 || num7 != 16711680 || num8 != 65280 || num9 != 255)
										{
											return null;
										}
										for (int i = 3; i < array2.Length; i += 4)
										{
											if (array2[i] != 0)
											{
												pixelFormat_ = PixelFormat.Format32bppPArgb;
												break;
											}
										}
									}
									Bitmap bitmap = GupLdLic64r(array2, num4, int_, int_2, pixelFormat_, null, null);
									bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
									return bitmap;
								}
								IL_0051:
								if (num6 == 3)
								{
									num3 += 12;
								}
								if (byte_0.Length < num3)
								{
									return null;
								}
								goto IL_0067;
							}
							break;
							IL_0067:
							array2 = new byte[byte_0.Length - num3];
							Array.Copy(byte_0, num3, array2, 0, array2.Length);
							int_2 = ((num10 * num4 + 7) / 8 + 3) / 4 * 4;
							num5 = 3;
							if (nusbunFZdv1YPkeMOwlh())
							{
								continue;
							}
							goto IL_00a1;
						}
						continue;
						IL_00a1:
						num5 = num2;
						goto IL_0103;
					}
				}
				return null;
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	internal static bool nusbunFZdv1YPkeMOwlh()
	{
		return hwnmsYFZvPA1X57xrHyZ == null;
	}
}
