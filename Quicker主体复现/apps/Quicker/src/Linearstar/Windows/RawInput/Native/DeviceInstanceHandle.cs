using System;

namespace Linearstar.Windows.RawInput.Native;

public struct DeviceInstanceHandle : IEquatable<DeviceInstanceHandle>
{
	private readonly IntPtr SrAG4Pgkik;

	private static object Yx5y7PigdEdV4uGJtLI;

	public static DeviceInstanceHandle Zero => new DeviceInstanceHandle(IntPtr.Zero);

	private DeviceInstanceHandle(IntPtr value)
	{
		SrAG4Pgkik = value;
	}

	public static IntPtr GetRawValue(DeviceInstanceHandle handle)
	{
		return handle.SrAG4Pgkik;
	}

	public static explicit operator DeviceInstanceHandle(IntPtr value)
	{
		return new DeviceInstanceHandle(value);
	}

	public static bool operator ==(DeviceInstanceHandle a, DeviceInstanceHandle b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(DeviceInstanceHandle a, DeviceInstanceHandle b)
	{
		return !a.Equals(b);
	}

	public bool Equals(DeviceInstanceHandle other)
	{
		return SrAG4Pgkik.Equals(other.SrAG4Pgkik);
	}

	public override bool Equals(object obj)
	{
		if (obj is DeviceInstanceHandle other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return SrAG4Pgkik.GetHashCode();
	}

	public override string ToString()
	{
		return SrAG4Pgkik.ToString();
	}

	internal static bool IpqWE0iPBviAWvGS0XE()
	{
		return Yx5y7PigdEdV4uGJtLI == null;
	}
}
