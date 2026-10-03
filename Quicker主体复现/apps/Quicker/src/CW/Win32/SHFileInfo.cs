using System;
using System.Runtime.InteropServices;

namespace CW.Win32;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
public struct SHFileInfo
{
	public IntPtr hIcon;

	public int iIcon;

	public uint dwAttributes;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	public string szDisplayName;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
	public string szTypeName;
}
