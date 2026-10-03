using System;

namespace Linearstar.Windows.RawInput;

[Flags]
public enum RawInputDeviceFlags
{
	None = 0,
	Remove = 1,
	Exclude = 0x10,
	PageOnly = 0x20,
	NoLegacy = 0x30,
	InputSink = 0x100,
	CaptureMouse = 0x200,
	NoHotKeys = 0x200,
	AppKeys = 0x400,
	ExInputSink = 0x1000,
	DevNotify = 0x2000
}
