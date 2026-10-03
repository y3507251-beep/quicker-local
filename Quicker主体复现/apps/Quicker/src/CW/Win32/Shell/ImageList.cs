using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using t8SGKhhgLWTgeqjGcrq;

namespace CW.Win32.Shell;

public class ImageList : ComObject<IImageList>
{
	private ImageListSize DtkPUxMEtW;

	private static Guid TcTPlo923R;

	private Lazy<Int32Size> jP6Pi6Baq0;

	private static ImageList RPBWOHB2r7bEwnemAVE;

	public ImageListSize Size => DtkPUxMEtW;

	public int Width => jP6Pi6Baq0.Value.Width;

	public int Height => jP6Pi6Baq0.Value.Height;

	public IntPtr Handle => Marshal.GetIUnknownForObject(base.Interface);

	public static ImageListSize MaxSize
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				if (Environment.OSVersion.Version.Major >= 6)
				{
					return ImageListSize.Jumbo;
				}
				return ImageListSize.ExtraLarge;
			}
			return ImageListSize.Jumbo;
		}
	}

	public ImageList(ImageListSize size)
		: base(FuYPA5j1X5(size))
	{
		DtkPUxMEtW = size;
		jP6Pi6Baq0 = new Lazy<Int32Size>(j5HPOcpFqr);
	}

	private static IImageList FuYPA5j1X5(ImageListSize imageListSize_1)
	{
		Marshal.ThrowExceptionForHR(Shell32.SHGetImageList(imageListSize_1, ref TcTPlo923R, out var ppv));
		return ppv;
	}

	public int GetIconIndex(string path)
	{
		SHFileInfo psfi = default(SHFileInfo);
		int cbSizeFileInfo = Marshal.SizeOf(psfi.GetType());
		IntPtr intPtr = Shell32.SHGetFileInfo(path, FileAttributes.Normal, ref psfi, cbSizeFileInfo, SHGetFileInfoOptions.SysIconIndex);
		if (psfi.hIcon != IntPtr.Zero)
		{
			User32.DestroyIcon(psfi.hIcon);
		}
		if (intPtr.Equals(IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return psfi.iIcon;
	}

	public int GetIconIndexWithOverlay(string path, out int overlayIndex)
	{
		SHFileInfo psfi = default(SHFileInfo);
		int cbSizeFileInfo = Marshal.SizeOf(typeof(global::CW.Win32.SHFileInfo));
		IntPtr intPtr = Shell32.SHGetFileInfo(path, FileAttributes.Normal, ref psfi, cbSizeFileInfo, SHGetFileInfoOptions.Icon | SHGetFileInfoOptions.SysIconIndex | SHGetFileInfoOptions.OverlayIndex);
		if (psfi.hIcon != IntPtr.Zero)
		{
			User32.DestroyIcon(psfi.hIcon);
		}
		if (intPtr.Equals(IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		overlayIndex = psfi.iIcon >> 24;
		return psfi.iIcon & 0xFFFFFF;
	}

	public Icon GetIcon(int index)
	{
		return GetIcon(index, ImageListDrawOptions.Normal);
	}

	public Icon GetIcon(int index, ImageListDrawOptions options)
	{
		Marshal.ThrowExceptionForHR(base.Interface.GetIcon(index, options, out var picon));
		if (!(picon != IntPtr.Zero))
		{
			throw new Win32Exception();
		}
		return Icon.FromHandle(picon);
	}

	public Icon GetIcon(string path)
	{
		return GetIcon(path, ImageListDrawOptions.Normal);
	}

	public Icon GetIcon(string path, ImageListDrawOptions options)
	{
		return GetIcon(GetIconIndex(path), options);
	}

	private Int32Size j5HPOcpFqr()
	{
		Marshal.ThrowExceptionForHR(base.Interface.GetIconSize(out var cx, out var cy));
		return new Int32Size(cx, cy);
	}

	public Bitmap Draw(int index, int overlayIndex, ImageListDrawOptions options)
	{
		return LLiPFGFx4h(index, overlayIndex, options, ImageListDrawStates.Normal, 0);
	}

	private Bitmap LLiPFGFx4h(int int_0, int int_1, ImageListDrawOptions imageListDrawOptions_0, ImageListDrawStates imageListDrawStates_0, int int_2)
	{
		Bitmap bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
		using Graphics graphics = Graphics.FromImage(bitmap);
		IMAGELISTDRAWPARAMS pimldp = default(IMAGELISTDRAWPARAMS);
		pimldp.cbSize = Marshal.SizeOf(pimldp);
		pimldp.himl = Handle;
		pimldp.hdcDst = graphics.GetHdc();
		pimldp.i = int_0;
		pimldp.cy = 0;
		pimldp.cx = 0;
		int num = 0;
		if (!lLWEoEBA2DhcpMmWPL5())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			pimldp.fStyle = (int)imageListDrawOptions_0 | (int_1 << 8);
			pimldp.fState = imageListDrawStates_0;
			pimldp.Frame = int_2;
			Marshal.ThrowExceptionForHR(base.Interface.Draw(ref pimldp));
			return bitmap;
		}
	}

	public int GetIndexOfOverlay(int overlayIndex)
	{
		Marshal.ThrowExceptionForHR(base.Interface.GetOverlayImage(overlayIndex, out var piIndex));
		return piIndex;
	}

	static ImageList()
	{
		TcTPlo923R = new Guid("46EB5926-582E-4017-9FDF-E8998DAA0950");
	}

	internal static bool lLWEoEBA2DhcpMmWPL5()
	{
		return RPBWOHB2r7bEwnemAVE == null;
	}
}
