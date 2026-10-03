using System;

namespace Linearstar.Windows.RawInput.Native;

public struct RawInputDeviceHandle : IEquatable<RawInputDeviceHandle>
{
	private readonly IntPtr t6WshqFxbF;

	private static object hrfbaTlrvtaE97PuNEn;

	public static RawInputDeviceHandle Zero => new RawInputDeviceHandle(IntPtr.Zero);

	private RawInputDeviceHandle(IntPtr value)
	{
		t6WshqFxbF = value;
	}

	public static IntPtr GetRawValue(RawInputDeviceHandle handle)
	{
		return handle.t6WshqFxbF;
	}

	public static explicit operator RawInputDeviceHandle(IntPtr value)
	{
		return new RawInputDeviceHandle(value);
	}

	public static bool operator ==(RawInputDeviceHandle a, RawInputDeviceHandle b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(RawInputDeviceHandle a, RawInputDeviceHandle b)
	{
		return !a.Equals(b);
	}

	public bool Equals(RawInputDeviceHandle other)
	{
		return t6WshqFxbF.Equals(other.t6WshqFxbF);
	}

	public override bool Equals(object obj)
	{
		if (obj is RawInputDeviceHandle other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return t6WshqFxbF.GetHashCode();
	}

	public override string ToString()
	{
		return t6WshqFxbF.ToString();
	}

	internal static void KgZO9QlLlgyoaHkVGfJ()
	{
	}

	internal static bool pK7XTylN8gW6bX5dJsj()
	{
		return hrfbaTlrvtaE97PuNEn == null;
	}
}
