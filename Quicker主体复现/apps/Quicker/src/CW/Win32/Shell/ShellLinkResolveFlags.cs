using System;

namespace CW.Win32.Shell;

[Flags]
public enum ShellLinkResolveFlags
{
	AnyMatch = 2,
	InvokeMsi = 0x80,
	NoLinkInfo = 0x40,
	NoUI = 1,
	NoUIWithMessagePump = 0x101,
	NoUpdate = 8,
	NoSearch = 0x10,
	NoTrack = 0x20,
	Update = 4
}
