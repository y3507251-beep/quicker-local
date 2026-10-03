using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using log4net;
using Microsoft.WindowsAPICodePack.Shell;
using Quicker.Utilities.Ext;

namespace Quicker.Utilities.Icons;

public static class FileSystemIconHelper
{
	[Flags]
	private enum ROc2GOHloBX0pMcJgIi
	{

	}

	public struct SHFILEINFO
	{
		public IntPtr hIcon;

		public int iIcon;

		public uint dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	private static readonly ILog b0OLianoet4;

	public const int ILD_IMAGE = 32;

	public const uint SHGFI_ICON = 256u;

	public const uint SHGFI_LARGEICON = 0u;

	public const int FILE_ATTRIBUTE_NORMAL = 128;

	internal static object jUbM3PFxdmX9c7WTgrkI;

	private static ImageSource yXALiJsNWxm(IntPtr intptr_0)
	{
		try
		{
			BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHIcon(intptr_0, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
			bitmapSource.TryFreeze();
			return bitmapSource;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static IntPtr TCILi0g6HYj(string string_0, bool bool_0 = true)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return IntPtr.Zero;
		}
		try
		{
			if (IsDllIconPath(string_0))
			{
				return mPOLiCCiLff(string_0);
			}
			if (bool_0 && string_0.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
			{
				int num = 0;
				if (!HPJf6TFxOv25FBJbpVDK())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (string_0.Length > 4)
				{
					return oQ3LiPhyvt0(string_0);
				}
			}
			SHFILEINFO psfi = default(SHFILEINFO);
			uint num3 = 256u;
			if (!Directory.Exists(string_0))
			{
				num3 |= 0x10;
			}
			SHGetFileInfo(string_0, 128u, ref psfi, (uint)Marshal.SizeOf(psfi), num3);
			return psfi.hIcon;
		}
		catch (Exception ex)
		{
			b0OLianoet4.Warn("获取文件" + string_0 + "图标失败。" + ex.Message, ex);
			return IntPtr.Zero;
		}
	}

	public static bool IsDllIconPath(string path)
	{
		int num = path.LastIndexOf(",", StringComparison.Ordinal);
		if (num > 0 && path.IndexOf('.', num + 1) < 0)
		{
			return true;
		}
		return false;
	}

	private static IntPtr mPOLiCCiLff(string string_0)
	{
		int num = string_0.LastIndexOf(",", StringComparison.Ordinal);
		string string_1 = string_0.Substring(0, num);
		int int_ = Convert.ToInt32(string_0.Substring(num + 1).Trim());
		return jVCLiEg2Ec1(string_1, int_, true);
	}

	public static Icon GetIconFromPath(string path)
	{
		IntPtr intPtr = TCILi0g6HYj(path);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			using Icon icon = Icon.FromHandle(intPtr);
			return (Icon)icon.Clone();
		}
		finally
		{
			bJALi8SwCLX(intPtr);
		}
	}

	public static ImageSource GetIconImageFromPath(string path)
	{
		if (path.StartsWith("::"))
		{
			ShellObject shellObject = null;
			try
			{
				shellObject = ShellObject.FromParsingName(path);
				if (shellObject == null)
				{
					return null;
				}
				BitmapSource mediumBitmapSource = shellObject.Thumbnail.MediumBitmapSource;
				mediumBitmapSource?.TryFreeze();
				return mediumBitmapSource;
			}
			catch (Exception ex)
			{
				b0OLianoet4.Warn("无法获取图标，path=" + path + " 错误：" + ex.Message);
				return null;
			}
			finally
			{
				if (shellObject != null)
				{
					try
					{
						shellObject.Dispose();
					}
					catch (Exception ex2)
					{
						b0OLianoet4.Warn("释放 ShellObject 失败：" + ex2.Message);
					}
				}
			}
		}
		IntPtr intPtr = TCILi0g6HYj(path);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			return yXALiJsNWxm(intPtr);
		}
		finally
		{
			bJALi8SwCLX(intPtr);
		}
	}

	public static Icon GetFileLnkIcon(string lnkFile)
	{
		IntPtr intPtr = oQ3LiPhyvt0(lnkFile);
		if (intPtr != IntPtr.Zero)
		{
			using (Icon icon = Icon.FromHandle(intPtr))
			{
				Icon result = (Icon)icon.Clone();
				bJALi8SwCLX(intPtr);
				return result;
			}
		}
		return null;
	}

	private static IntPtr oQ3LiPhyvt0(string string_0)
	{
		SHFILEINFO psfi = default(SHFILEINFO);
		IntPtr intPtr = SHGetFileInfo(string_0, 128u, ref psfi, (uint)Marshal.SizeOf(psfi), 16384u);
		if (intPtr != IntPtr.Zero)
		{
			IntPtr intPtr2 = ImageList_GetIcon(intPtr, psfi.iIcon, 32u);
			if (intPtr2 != IntPtr.Zero)
			{
				return intPtr2;
			}
		}
		return IntPtr.Zero;
	}

	[DllImport("Shell32.dll")]
	public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

	[DllImport("Comctl32.dll")]
	public static extern IntPtr ImageList_GetIcon(IntPtr himl, int i, uint flags);

	public static Icon Extract(string file, int number, bool largeIcon)
	{
		SBSLiyrsiev(file, number, out var intptr_, out var intptr_2, 1);
		try
		{
			using Icon icon = Icon.FromHandle(largeIcon ? intptr_ : intptr_2);
			Icon result = (Icon)icon.Clone();
			bJALi8SwCLX(intptr_);
			bJALi8SwCLX(intptr_2);
			return result;
		}
		catch
		{
			return null;
		}
	}

	private static IntPtr jVCLiEg2Ec1(string string_0, int int_0, bool bool_0)
	{
		SBSLiyrsiev(string_0, int_0, out var intptr_, out var intptr_2, 1);
		if (bool_0)
		{
			bJALi8SwCLX(intptr_2);
			return intptr_;
		}
		bJALi8SwCLX(intptr_);
		return intptr_2;
	}

	[DllImport("Shell32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "ExtractIconExW", ExactSpelling = true)]
	private static extern int SBSLiyrsiev(string string_0, int int_0, out IntPtr intptr_0, out IntPtr intptr_1, int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "DestroyIcon")]
	private static extern bool bJALi8SwCLX(IntPtr intptr_0);

	static FileSystemIconHelper()
	{
		b0OLianoet4 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool HPJf6TFxOv25FBJbpVDK()
	{
		return jUbM3PFxdmX9c7WTgrkI == null;
	}

	internal static void Yo6NMvFxokrfpyhLOpop()
	{
	}
}
