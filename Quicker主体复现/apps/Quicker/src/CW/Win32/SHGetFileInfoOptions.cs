using System;

namespace CW.Win32;

[Flags]
public enum SHGetFileInfoOptions : uint
{
	Icon = 0x100u,
	DisplayName = 0x200u,
	TypeName = 0x400u,
	Attributes = 0x800u,
	IconLocation = 0x1000u,
	ExeType = 0x2000u,
	SysIconIndex = 0x4000u,
	LinkOverlay = 0x8000u,
	Selected = 0x10000u,
	SpecifiedAttributes = 0x20000u,
	LargeIcon = 0u,
	SmallIcon = 1u,
	OpenIcon = 2u,
	ShellIconSize = 4u,
	Pidl = 8u,
	UseFileAttributes = 0x10u,
	AddOverlays = 0x20u,
	OverlayIndex = 0x40u
}
