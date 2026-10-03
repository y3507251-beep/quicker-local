using System;

namespace CW.Win32;

[Flags]
public enum SetWindowPosOptions : uint
{
	NoSize = 1u,
	NoMove = 2u,
	NoZOrder = 4u,
	NoRedraw = 8u,
	NoActivate = 0x10u,
	FrameChanged = 0x20u,
	ShowWindow = 0x40u,
	HideWindow = 0x80u,
	NoCopyBits = 0x100u,
	NoOwnerZOrder = 0x200u,
	NoSendChanging = 0x400u,
	DrawFrane = 0x20u,
	NoReposition = 0x200u,
	Defererase = 0x2000u,
	AsyncWindowPosition = 0x4000u
}
