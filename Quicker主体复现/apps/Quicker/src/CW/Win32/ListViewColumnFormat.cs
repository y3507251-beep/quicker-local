using System;

namespace CW.Win32;

[Flags]
public enum ListViewColumnFormat
{
	Left = 0,
	Right = 1,
	Center = 2,
	JustifyMark = 3,
	RightToLeftReading = 4,
	Bitmap = 0x2000,
	String = 0x4000,
	OwnerDraw = 0x8000,
	Image = 0x800,
	BitmapOnRight = 0x1000,
	SortUp = 0x400,
	SortDown = 0x200,
	CheckBox = 0x40,
	Checked = 0x80,
	FixedWidth = 0x100,
	SplitButton = 0x1000000
}
