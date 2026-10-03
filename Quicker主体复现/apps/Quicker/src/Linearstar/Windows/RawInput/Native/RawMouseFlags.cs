using System;

namespace Linearstar.Windows.RawInput.Native;

[Flags]
public enum RawMouseFlags : ushort
{
	None = 0,
	MoveAbsolute = 1,
	VirtualDesktop = 2,
	AttributesChanged = 4
}
