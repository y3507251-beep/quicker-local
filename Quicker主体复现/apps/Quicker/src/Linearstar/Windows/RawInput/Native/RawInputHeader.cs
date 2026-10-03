using System;

namespace Linearstar.Windows.RawInput.Native;

public struct RawInputHeader
{
	private readonly RawInputDeviceType sugs1Yw09s;

	private readonly int nhqsbvLneX;

	private readonly RawInputDeviceHandle P7rs6PiFPk;

	private readonly IntPtr zcCsXeEgME;

	private static object WaQX7mlgjn2Jlv8Ehno;

	public RawInputDeviceType Type => sugs1Yw09s;

	public int Size => nhqsbvLneX;

	public RawInputDeviceHandle DeviceHandle => P7rs6PiFPk;

	public IntPtr WParam => zcCsXeEgME;

	public override string ToString()
	{
		return $"{{{Type}: {DeviceHandle}, WParam: {WParam}}}";
	}

	internal static bool XGMmgllPy0B41ToPvhC()
	{
		return WaQX7mlgjn2Jlv8Ehno == null;
	}
}
