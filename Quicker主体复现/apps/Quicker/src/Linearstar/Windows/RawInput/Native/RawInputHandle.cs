using System;

namespace Linearstar.Windows.RawInput.Native;

public struct RawInputHandle : IEquatable<RawInputHandle>
{
	private readonly IntPtr S8GsHHIfXL;

	internal static object vaIZIblYUM3edfVklAW;

	public static RawInputHandle Zero => new RawInputHandle(IntPtr.Zero);

	private RawInputHandle(IntPtr value)
	{
		S8GsHHIfXL = value;
	}

	public static IntPtr GetRawValue(RawInputHandle handle)
	{
		return handle.S8GsHHIfXL;
	}

	public static explicit operator RawInputHandle(IntPtr value)
	{
		return new RawInputHandle(value);
	}

	public static bool operator ==(RawInputHandle a, RawInputHandle b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(RawInputHandle a, RawInputHandle b)
	{
		return !a.Equals(b);
	}

	public bool Equals(RawInputHandle other)
	{
		return S8GsHHIfXL.Equals(other.S8GsHHIfXL);
	}

	public override bool Equals(object obj)
	{
		if (obj is RawInputHandle other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return S8GsHHIfXL.GetHashCode();
	}

	public override string ToString()
	{
		return S8GsHHIfXL.ToString();
	}

	internal static bool xf9s35l8o0RTvngRB1N()
	{
		return vaIZIblYUM3edfVklAW == null;
	}
}
