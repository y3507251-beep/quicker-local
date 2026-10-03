using System;

namespace Quicker.Native.ShellMenu;

public struct MENUITEMINFO
{
	public uint cbSize;

	public MIIM fMask;

	public uint fType;

	public uint fState;

	public uint wID;

	public IntPtr hSubMenu;

	public IntPtr hbmpChecked;

	public IntPtr hbmpUnchecked;

	public IntPtr dwItemData;

	public IntPtr dwTypeData;

	public uint cch;

	public IntPtr hbmpItem;
}
