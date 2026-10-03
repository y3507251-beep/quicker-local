using System;

namespace CW.Win32;

[Flags]
public enum AssociationInitializeOptions
{
	None = 0,
	ByExeName = 2,
	DefaultToStar = 4,
	DefaultToFolder = 8
}
