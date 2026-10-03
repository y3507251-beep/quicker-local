using System.Runtime.InteropServices;

namespace Linearstar.Windows.RawInput.Native;

[StructLayout(LayoutKind.Explicit)]
public struct RawInputDeviceInfo
{
	[FieldOffset(0)]
	private readonly int txJsefJr9g;

	[FieldOffset(4)]
	private readonly RawInputDeviceType aJSsYC9ZDy;

	[FieldOffset(8)]
	private readonly RawInputMouseInfo bltsIHEVmg;

	[FieldOffset(8)]
	private readonly RawInputKeyboardInfo QF2sWiXUIG;

	[FieldOffset(8)]
	private readonly RawInputHidInfo MKnskuFlAH;

	public RawInputDeviceType Type => aJSsYC9ZDy;

	public RawInputMouseInfo Mouse => bltsIHEVmg;

	public RawInputKeyboardInfo Keyboard => QF2sWiXUIG;

	public RawInputHidInfo Hid => MKnskuFlAH;
}
