using System;

namespace Linearstar.Windows.RawInput.Native;

public struct HidPreparsedData : IEquatable<HidPreparsedData>
{
	private readonly IntPtr PxOsNokyXa;

	private static object dffHVIl2XHJL60CuA65;

	public static HidPreparsedData Zero => new HidPreparsedData(IntPtr.Zero);

	private HidPreparsedData(IntPtr value)
	{
		PxOsNokyXa = value;
	}

	public static IntPtr GetRawValue(HidPreparsedData handle)
	{
		return handle.PxOsNokyXa;
	}

	public static explicit operator HidPreparsedData(IntPtr value)
	{
		return new HidPreparsedData(value);
	}

	public static bool operator ==(HidPreparsedData a, HidPreparsedData b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(HidPreparsedData a, HidPreparsedData b)
	{
		return !a.Equals(b);
	}

	public bool Equals(HidPreparsedData other)
	{
		return PxOsNokyXa.Equals(other.PxOsNokyXa);
	}

	public override bool Equals(object obj)
	{
		if (obj is HidPreparsedData other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return PxOsNokyXa.GetHashCode();
	}

	public override string ToString()
	{
		return PxOsNokyXa.ToString();
	}

	internal static bool OYIN8flAgJsjMeZ8cKa()
	{
		return dffHVIl2XHJL60CuA65 == null;
	}
}
