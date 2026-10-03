using System;

namespace CW.Win32;

[Flags]
public enum HotKeyModifiers
{
	Alt = 1,
	Control = 2,
	Shift = 4,
	Windows = 8
}
