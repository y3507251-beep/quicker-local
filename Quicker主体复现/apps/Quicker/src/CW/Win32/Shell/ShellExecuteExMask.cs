using System;

namespace CW.Win32.Shell;

[Flags]
public enum ShellExecuteExMask
{
	None = 0,
	ClassName = 1,
	ClassKey = 3,
	IDList = 4,
	InvokeIDList = 0xC,
	Icon = 0x10,
	Hotkey = 0x20,
	NoCloseProcess = 0x40,
	ConnectNetDrive = 0x80,
	FlagDDEWait = 0x100,
	DoEnvironmentSubstring = 0x200,
	FlagNoUI = 0x400,
	Unicode = 0x4000,
	NoConsole = 0x8000,
	HMonitor = 0x200000,
	FlagLogUsage = 0x4000000
}
