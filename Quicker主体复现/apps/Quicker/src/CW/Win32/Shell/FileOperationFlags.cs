using System;

namespace CW.Win32.Shell;

[Flags]
public enum FileOperationFlags : uint
{
	None = 0u,
	MultiDestFiles = 1u,
	ConfirmMouse = 2u,
	Silent = 4u,
	RenameOnCollision = 8u,
	NoConfirmation = 0x10u,
	WantMappingHandle = 0x20u,
	AllowUndo = 0x40u,
	FilesOnly = 0x80u,
	SimpleProgress = 0x100u,
	NoConfirmMakeDirectory = 0x200u,
	NoErrorUI = 0x400u,
	NoCopySecurityAttributes = 0x800u,
	NoRecursion = 0x1000u,
	NoConectedElements = 0x2000u,
	WantNukeWarning = 0x4000u,
	NoRecurseParsing = 0x8000u,
	NoSkipJunktions = 0x10000u,
	PreferHardLink = 0x20000u,
	ShowElevationPrompt = 0x40000u,
	EarlyFailture = 0x100000u,
	PreserveFileExtensions = 0x200000u,
	KeepNewerFiles = 0x400000u,
	NoCopyHooks = 0x800000u,
	NoMinimizeBox = 0x1000000u,
	MoveClsAcrossVolume = 0x2000000u,
	DontDisplaySourcePath = 0x4000000u,
	DontDisplayDestPath = 0x8000000u
}
