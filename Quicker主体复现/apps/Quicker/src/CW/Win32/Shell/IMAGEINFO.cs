using System;

namespace CW.Win32.Shell;

public struct IMAGEINFO
{
	public IntPtr hbmImage;

	public IntPtr hbmMask;

	public int Unused1;

	public int Unused2;

	public Rectangle rcImage;
}
