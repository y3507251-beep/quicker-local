using System;

namespace CW.Win32.Shell;

[Flags]
public enum FileOperationOptions : ushort
{
	None = 0,
	MultiDestFiles = 1,
	ConfirmMouse = 2,
	Silent = 4,
	RenameOnCollision = 8,
	NoConfirmation = 0x10,
	WantMappingHandle = 0x20,
	AllowUndo = 0x40,
	FilesOnly = 0x80,
	SimpleProgress = 0x100,
	NoConfirmMakeDirectory = 0x200,
	NoErrorUI = 0x400,
	NoCopySecurityAttributes = 0x800,
	NoRecursion = 0x1000,
	NoConectedElements = 0x2000,
	WantNukeWarning = 0x4000,
	NoRecurseParsing = 0x8000
}
