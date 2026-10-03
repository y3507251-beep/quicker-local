using System;

namespace CW.Win32;

[Flags]
public enum GetMenuDefaultItemOptions : uint
{
	Normal = 0u,
	UseDisabled = 1u,
	GoIntoPopups = 2u
}
