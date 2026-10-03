using System;

namespace CW.Win32;

[Flags]
public enum AssociationOptions
{
	None = 0,
	NoUserSettings = 0x10,
	NoTruncated = 0x20,
	Verify = 0x40,
	RemapRunDll = 0x80,
	NoFixups = 0x100,
	IgnoreBassClass = 0x200
}
