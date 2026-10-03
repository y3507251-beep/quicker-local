using System;

namespace CW.Win32;

[Flags]
public enum SHEmptyRecycleBinOptions
{
	None = 0,
	NoConfirmation = 1,
	NoProgressUI = 2,
	NoSound = 4
}
