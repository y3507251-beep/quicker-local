using System;

namespace CW.Win32;

public struct HeaderItem
{
	public HeaderItemMask Mask;

	public int CXY;

	public string Text;

	public IntPtr Bitmap;

	public int TextMax;

	public ListViewColumnFormat Format;

	public int LParam;

	public int ImageIndex;

	public int OrderIndex;

	public uint Type;

	public IntPtr Filter;

	public uint State;
}
