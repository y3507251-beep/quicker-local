using System;

namespace CW.Win32;

[Flags]
public enum TrackPopupMenuOptions : uint
{
	LeftButton = 0u,
	RightButton = 2u,
	LeftAlign = 0u,
	CenterAlign = 4u,
	RightAlign = 8u,
	TopAlign = 0u,
	VCenterAlign = 0x10u,
	BottomAlign = 0x20u,
	Horizontal = 0u,
	Vertical = 0x40u,
	Monotify = 0x80u,
	ReturnCommand = 0x100u
}
