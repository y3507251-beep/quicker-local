using System;

namespace CW.Win32.Shell;

[Flags]
public enum TransferSourceFlags : uint
{
	Normal = 0u,
	FailExist = 0u,
	RenameExist = 1u,
	OverwriteExists = 2u,
	AllowDecryption = 4u,
	NoSecurity = 8u,
	CopyCreationTime = 0x10u,
	CopyWriteTime = 0x20u,
	UseFullAccess = 0x40u,
	DeleteRecycleIfPossible = 0x80u,
	CopyHardLink = 0x100u,
	CopyLocalizedName = 0x200u,
	MoveAsCopyDelete = 0x400u,
	SuspendShellEvents = 0x800u
}
