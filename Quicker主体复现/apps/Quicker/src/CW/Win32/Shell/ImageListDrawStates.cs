using System;

namespace CW.Win32.Shell;

[Flags]
public enum ImageListDrawStates
{
	Normal = 0,
	Glow = 1,
	Shadow = 2,
	Saturates = 4,
	Alpha = 8
}
