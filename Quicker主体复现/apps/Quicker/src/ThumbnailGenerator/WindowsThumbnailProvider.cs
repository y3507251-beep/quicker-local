using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace ThumbnailGenerator;

public class WindowsThumbnailProvider
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("43826d1e-e718-42ee-bc55-a1e261c37bfe")]
	internal interface IShellItem
	{
		void BindToHandler(IntPtr pbc, [MarshalAs(UnmanagedType.LPStruct)] Guid bhid, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);

		void GetParent(out IShellItem ppsi);

		void GetDisplayName(fJgTvadmSx4Cyct3Mnw sigdnName, out IntPtr ppszName);

		void GetAttributes(uint sfgaoMask, out uint psfgaoAttribs);

		void Compare(IShellItem psi, uint hint, out int piOrder);
	}

	internal enum fJgTvadmSx4Cyct3Mnw : uint
	{

	}

	internal enum kaFA2QddGYeiXJmaZ8s
	{
		False = 1
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bcc18b79-ba16-442f-80c4-8a59c30c463b")]
	internal interface IShellItemImageFactory
	{
		[PreserveSig]
		kaFA2QddGYeiXJmaZ8s GetImage([In][MarshalAs(UnmanagedType.Struct)] HO7RLaduIEbLyQYSXOn size, [In] ThumbnailOptions flags, out IntPtr phbm);
	}

	internal struct HO7RLaduIEbLyQYSXOn
	{
		private int rHEv8mOshEV;

		private int kmwv8Ks7XYk;

		internal static object tf2vUtc0WOBlKR9y53fl;

		public int Width
		{
			set
			{
				rHEv8mOshEV = value;
			}
		}

		public int Height
		{
			set
			{
				kmwv8Ks7XYk = value;
			}
		}

		internal static bool qDSuyLc0ysTTpn6fSEuL()
		{
			return tf2vUtc0WOBlKR9y53fl == null;
		}
	}

	public struct RGBQUAD
	{
		public byte rgbBlue;

		public byte rgbGreen;

		public byte rgbRed;

		public byte rgbReserved;
	}

	private static WindowsThumbnailProvider Sa9uHXJ2g7FHgL9Bd03;

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode, EntryPoint = "SHCreateItemFromParsingName", SetLastError = true)]
	internal static extern int EZLR7iUayB([MarshalAs(UnmanagedType.LPWStr)] string string_0, IntPtr intptr_0, ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] out IShellItem ishellItem_0);

	[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool wQwRRMnnMl(IntPtr intptr_0);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	public unsafe static extern IntPtr memcpy(void* dst, void* src, UIntPtr count);

	public static Bitmap GetThumbnail(string fileName, int width, int height, ThumbnailOptions options)
	{
		IntPtr intPtr = a2dRqAMdCr(Path.GetFullPath(fileName), width, height, options);
		try
		{
			return GetBitmapFromHBitmap(intPtr);
		}
		finally
		{
			wQwRRMnnMl(intPtr);
		}
	}

	public static Bitmap GetBitmapFromHBitmap(IntPtr nativeHBitmap)
	{
		return Image.FromHbitmap(nativeHBitmap);
	}

	public unsafe static Bitmap CreateAlphaBitmap(Bitmap srcBitmap, PixelFormat targetPixelFormat)
	{
		Bitmap bitmap = new Bitmap(srcBitmap.Width, srcBitmap.Height, targetPixelFormat);
		Rectangle rect = new Rectangle(0, 0, srcBitmap.Width, srcBitmap.Height);
		BitmapData bitmapData = srcBitmap.LockBits(rect, ImageLockMode.ReadOnly, srcBitmap.PixelFormat);
		BitmapData bitmapData2 = bitmap.LockBits(rect, ImageLockMode.ReadOnly, targetPixelFormat);
		byte* ptr = (byte*)(void*)bitmapData.Scan0;
		byte* ptr2 = (byte*)(void*)bitmapData2.Scan0;
		try
		{
			for (int i = 0; i <= bitmapData.Height - 1; i++)
			{
				for (int j = 0; j <= bitmapData.Width - 1; j++)
				{
					int num = bitmapData.Stride * i + 4 * j;
					int num2 = bitmapData2.Stride * i + 4 * j;
					memcpy(ptr2 + num2, ptr + num, (UIntPtr)4uL);
				}
			}
			if (Sa9uHXJ2g7FHgL9Bd03 == null)
			{
				switch (0)
				{
				}
			}
		}
		finally
		{
			srcBitmap.UnlockBits(bitmapData);
			bitmap.UnlockBits(bitmapData2);
		}
		return bitmap;
	}

	private static IntPtr a2dRqAMdCr(string string_0, int int_0, int int_1, ThumbnailOptions thumbnailOptions_0)
	{
		Guid guid_ = new Guid("7E9FB0D3-919F-4307-AB2E-9B1860310C93");
		IShellItem ishellItem_;
		int num = EZLR7iUayB(string_0, IntPtr.Zero, ref guid_, out ishellItem_);
		if (num != 0)
		{
			throw Marshal.GetExceptionForHR(num);
		}
		HO7RLaduIEbLyQYSXOn size = default(HO7RLaduIEbLyQYSXOn);
		int num2 = 0;
		if (!uObjAaJAr1bGgUCjgp6())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
		{
			size.Width = int_0;
			size.Height = int_1;
			IntPtr phbm;
			kaFA2QddGYeiXJmaZ8s image = ((IShellItemImageFactory)ishellItem_).GetImage(size, thumbnailOptions_0, out phbm);
			Marshal.ReleaseComObject(ishellItem_);
			if (image != 0)
			{
				throw Marshal.GetExceptionForHR((int)image);
			}
			return phbm;
		}
		}
	}

	internal static bool uObjAaJAr1bGgUCjgp6()
	{
		return Sa9uHXJ2g7FHgL9Bd03 == null;
	}
}
