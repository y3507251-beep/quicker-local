using System;

namespace Linearstar.Windows.RawInput.Native;

[Flags]
public enum RawMouseButtonFlags : ushort
{
	None = 0,
	LeftButtonDown = 1,
	LeftButtonUp = 2,
	RightButtonDown = 4,
	RightButtonUp = 8,
	MiddleButtonDown = 0x10,
	MiddleButtonUp = 0x20,
	Button4Down = 0x40,
	Button4Up = 0x80,
	Button5Down = 0x100,
	Button5Up = 0x200,
	MouseWheel = 0x400,
	MouseHorizontalWheel = 0x800
}
