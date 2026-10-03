using System;

namespace Linearstar.Windows.RawInput.Native;

[Flags]
public enum RawKeyboardFlags : ushort
{
	None = 0,
	Up = 1,
	KeyE0 = 2,
	KeyE1 = 4
}
