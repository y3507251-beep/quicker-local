using System;

namespace Quicker.Native.ShellMenu;

public struct MENUINFO
{
	public uint cbSize;

	public MIM fMask;

	public uint dwStyle;

	public uint cyMax;

	public IntPtr hbrBack;

	public uint dwContextHelpID;

	public UIntPtr dwMenuData;
}
