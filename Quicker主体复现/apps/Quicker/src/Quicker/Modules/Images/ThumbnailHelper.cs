using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Quicker.Modules.Images;

public static class ThumbnailHelper
{
	public struct SHFILEINFO
	{
		public IntPtr hIcon;

		public IntPtr iIcon;

		public uint dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	public const uint SHGFI_ICON = 256u;

	public const uint SHGFI_LARGEICON = 0u;

	public const uint SHGFI_SMALLICON = 1u;

	internal static object QBQT1xQDzWJQsa3OlJIP;

	[DllImport("Shell32.dll")]
	public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

	public static ImageSource GetThumbnail(string filePath, bool smallIcon)
	{
		SHFILEINFO psfi = default(SHFILEINFO);
		uint uFlags = 0x100u | (smallIcon ? 1u : 0u);
		if (SHGetFileInfo(filePath, 0u, ref psfi, (uint)Marshal.SizeOf(psfi), uFlags) != IntPtr.Zero)
		{
			BitmapSource result = Imaging.CreateBitmapSourceFromHIcon(Icon.FromHandle(psfi.hIcon).Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
			QVRty0AUOJ9(psfi.hIcon);
			return result;
		}
		return null;
	}

	[DllImport("user32.dll", EntryPoint = "DestroyIcon", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool QVRty0AUOJ9(IntPtr intptr_0);

	internal static bool Y3J7uwQ3VTaHbiexlIqP()
	{
		return QBQT1xQDzWJQsa3OlJIP == null;
	}
}
