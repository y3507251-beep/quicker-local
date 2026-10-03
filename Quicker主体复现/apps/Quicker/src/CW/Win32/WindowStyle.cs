using System;

namespace CW.Win32;

[Flags]
public enum WindowStyle : uint
{
	Overlapped = 0u,
	Popup = 0x80000000u,
	Child = 0x40000000u,
	Minimize = 0x20000000u,
	Visible = 0x10000000u,
	Disabled = 0x8000000u,
	ClipSiblings = 0x4000000u,
	ClipChildren = 0x2000000u,
	Maximize = 0x1000000u,
	Caption = 0xC00000u,
	Border = 0x800000u,
	DialogFrame = 0x400000u,
	VScroll = 0x200000u,
	HScroll = 0x100000u,
	SystemMenu = 0x80000u,
	ThickFrame = 0x40000u,
	Group = 0x20000u,
	TabStop = 0x10000u,
	MinimizeBox = 0x20000u,
	MaximizeBox = 0x10000u,
	Tiled = 0u,
	Iconic = 0x20000000u,
	SizeBox = 0x40000u,
	TiledWindows = 0xCF0000u,
	OverlappedWindow = 0xCF0000u,
	PopupWindow = 0x80880000u,
	ChildWindow = 0x40000000u
}
