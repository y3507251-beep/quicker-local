using System;

namespace CW.Win32;

[Flags]
public enum HeaderItemMask : uint
{
	Width = 1u,
	Height = 1u,
	Text = 2u,
	Format = 4u,
	LParam = 8u,
	Bitmap = 0x10u,
	Image = 0x20u,
	DISetItem = 0x40u,
	Order = 0x80u,
	Filter = 0x100u,
	State = 0x200u
}
