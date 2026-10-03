using System;

namespace CW.Win32;

public struct NMListView
{
	public IntPtr Hdr;

	public int IDForm;

	public int Code;

	public int Item;

	public int SubItem;

	public uint NewState;

	public uint OldState;

	public uint Changed;

	public GDIPoint Action;

	public IntPtr LParam;
}
