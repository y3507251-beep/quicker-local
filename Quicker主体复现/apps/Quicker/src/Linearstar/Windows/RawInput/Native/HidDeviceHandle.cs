using System;

namespace Linearstar.Windows.RawInput.Native;

public struct HidDeviceHandle : IEquatable<HidDeviceHandle>
{
	private readonly IntPtr WETGOJk5hO;

	internal static object n82SF4iwvSKTrJ8Wt0r;

	public static HidDeviceHandle Zero => new HidDeviceHandle(IntPtr.Zero);

	private HidDeviceHandle(IntPtr value)
	{
		WETGOJk5hO = value;
	}

	public static IntPtr GetRawValue(HidDeviceHandle handle)
	{
		return handle.WETGOJk5hO;
	}

	public static explicit operator HidDeviceHandle(IntPtr value)
	{
		return new HidDeviceHandle(value);
	}

	public static bool operator ==(HidDeviceHandle a, HidDeviceHandle b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(HidDeviceHandle a, HidDeviceHandle b)
	{
		return !a.Equals(b);
	}

	public bool Equals(HidDeviceHandle other)
	{
		return WETGOJk5hO.Equals(other.WETGOJk5hO);
	}

	public override bool Equals(object obj)
	{
		if (obj is HidDeviceHandle other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return WETGOJk5hO.GetHashCode();
	}

	public override string ToString()
	{
		return WETGOJk5hO.ToString();
	}

	internal static bool gYcxNfiTAOQEd68imuN()
	{
		return n82SF4iwvSKTrJ8Wt0r == null;
	}
}
