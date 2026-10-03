using System;

namespace Linearstar.Windows.RawInput.Native;

public struct DevicePropertyKey
{
	public static readonly DevicePropertyKey Name;

	public static readonly DevicePropertyKey DeviceManufacturer;

	public static readonly DevicePropertyKey DeviceFriendlyName;

	private readonly Guid dX8G5891tN;

	private readonly int RI3GDGwW40;

	private static object LRFx9WiUsLVtSnI6sa2;

	public DevicePropertyKey(uint l, ushort w1, ushort w2, byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7, byte b8, int pid)
	{
		dX8G5891tN = new Guid((int)l, (short)w1, (short)w2, b1, b2, b3, b4, b5, b6, b7, b8);
		RI3GDGwW40 = pid;
	}

	static DevicePropertyKey()
	{
		Name = new DevicePropertyKey(3072717104u, 18415, 4122, 165, 241, 2, 96, 140, 158, 235, 172, 10);
		DeviceManufacturer = new DevicePropertyKey(2757502286u, 57116, 20221, 128, 32, 103, 209, 70, 168, 80, 224, 13);
		DeviceFriendlyName = new DevicePropertyKey(2757502286u, 57116, 20221, 128, 32, 103, 209, 70, 168, 80, 224, 14);
	}

	internal static bool DKEAFmix6D7DNn1VUbJ()
	{
		return LRFx9WiUsLVtSnI6sa2 == null;
	}
}
