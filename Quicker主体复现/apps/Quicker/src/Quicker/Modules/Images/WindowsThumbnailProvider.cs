using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using log4net;
using MgMK3G2EJyNCHpByVx9;

namespace Quicker.Modules.Images;

public static class WindowsThumbnailProvider
{
	internal enum wl51vjuOY1ycFmpv4UP
	{
		False = 1
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bcc18b79-ba16-442f-80c4-8a59c30c463b")]
	internal interface IShellItemImageFactory
	{
		[PreserveSig]
		wl51vjuOY1ycFmpv4UP GetImage([In][MarshalAs(UnmanagedType.Struct)] CVpYodusKGY8YKrdWTg size, [In] ThumbnailOptions flags, out IntPtr phbm);
	}

	internal struct CVpYodusKGY8YKrdWTg
	{
		private int f8Vv6dftZXq;

		private int nGgv6oCkhxJ;

		internal static object EfktmVcIoJGpcZ7dmARX;

		public int Width
		{
			set
			{
				f8Vv6dftZXq = value;
			}
		}

		public int Height
		{
			set
			{
				nGgv6oCkhxJ = value;
			}
		}

		internal static bool qB5nOBcIfqAKPq6uloR2()
		{
			return EfktmVcIoJGpcZ7dmARX == null;
		}
	}

	private static readonly ILog zbntye5P8dN;

	internal static object gQphQBQ3kvL6yUCaxeMe;

	public static BitmapSource GetThumbnail(string fileName, int width, int height, ThumbnailOptions options)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = IDwtyh6ki1u(fileName, width, height, options);
			BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(intPtr, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
			if (bitmapSource != null && bitmapSource.CanFreeze)
			{
				bitmapSource.Freeze();
			}
			return bitmapSource;
		}
		catch (Exception)
		{
			zbntye5P8dN.Warn("加载图标出错：");
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				RyPCTu23ZmbRr8rrmqQ.TqBty9uMDd0(intPtr);
			}
		}
		return null;
	}

	private static IntPtr IDwtyh6ki1u(string string_0, int int_0, int int_1, ThumbnailOptions thumbnailOptions_0)
	{
		Guid guid_ = new Guid("7E9FB0D3-919F-4307-AB2E-9B1860310C93");
		IShellItem ishellItem_;
		int num = RyPCTu23ZmbRr8rrmqQ.trwtyZsWRAD(string_0, IntPtr.Zero, ref guid_, out ishellItem_);
		if (num != 0)
		{
			throw Marshal.GetExceptionForHR(num);
		}
		CVpYodusKGY8YKrdWTg size = new CVpYodusKGY8YKrdWTg
		{
			Width = int_0,
			Height = int_1
		};
		IntPtr phbm;
		wl51vjuOY1ycFmpv4UP image = ((IShellItemImageFactory)ishellItem_).GetImage(size, thumbnailOptions_0, out phbm);
		if (thumbnailOptions_0 == ThumbnailOptions.ThumbnailOnly && image == (wl51vjuOY1ycFmpv4UP)(-2147175936))
		{
			int num2 = 0;
			if (gQphQBQ3kvL6yUCaxeMe != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			image = ((IShellItemImageFactory)ishellItem_).GetImage(size, ThumbnailOptions.IconOnly, out phbm);
		}
		Marshal.ReleaseComObject(ishellItem_);
		if (image != 0)
		{
			throw new InvalidComObjectException("Error while extracting thumbnail for " + string_0, Marshal.GetExceptionForHR((int)image));
		}
		return phbm;
	}

	static WindowsThumbnailProvider()
	{
		zbntye5P8dN = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool Reo1crQ3aUsPGuu0Dkca()
	{
		return gQphQBQ3kvL6yUCaxeMe == null;
	}
}
