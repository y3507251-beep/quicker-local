using System;
using System.Runtime.CompilerServices;

namespace Linearstar.Windows.RawInput;

public struct HidUsageAndPage : IEquatable<HidUsageAndPage>
{
	public static readonly HidUsageAndPage Mouse;

	public static readonly HidUsageAndPage Joystick;

	public static readonly HidUsageAndPage GamePad;

	public static readonly HidUsageAndPage Keyboard;

	public static readonly HidUsageAndPage Pen;

	public static readonly HidUsageAndPage TouchScreen;

	public static readonly HidUsageAndPage TouchPad;

	[CompilerGenerated]
	private readonly ushort vrOkT8XCYF;

	[CompilerGenerated]
	private readonly ushort NDTkMsOqAq;

	internal static object Svvjc6qrAAC3L32Mgwb;

	public readonly ushort Usage
	{
		[CompilerGenerated]
		get
		{
			return vrOkT8XCYF;
		}
	}

	public readonly ushort UsagePage
	{
		[CompilerGenerated]
		get
		{
			return NDTkMsOqAq;
		}
	}

	public HidUsageAndPage(ushort usagePage, ushort usage)
	{
		NDTkMsOqAq = usagePage;
		vrOkT8XCYF = usage;
	}

	public static bool operator ==(HidUsageAndPage a, HidUsageAndPage b)
	{
		if (a.UsagePage == b.UsagePage)
		{
			return a.Usage == b.Usage;
		}
		return false;
	}

	public static bool operator !=(HidUsageAndPage a, HidUsageAndPage b)
	{
		if (a.UsagePage == b.UsagePage)
		{
			return a.Usage != b.Usage;
		}
		return true;
	}

	public bool Equals(HidUsageAndPage other)
	{
		return GetHashCode() == other.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj is HidUsageAndPage other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return UsagePage << 16 + Usage;
	}

	public override string ToString()
	{
		return $"{UsagePage:X2}:{Usage:X2}";
	}

	static HidUsageAndPage()
	{
		Mouse = new HidUsageAndPage(1, 2);
		Joystick = new HidUsageAndPage(1, 4);
		GamePad = new HidUsageAndPage(1, 5);
		Keyboard = new HidUsageAndPage(1, 6);
		Pen = new HidUsageAndPage(13, 2);
		TouchScreen = new HidUsageAndPage(13, 4);
		TouchPad = new HidUsageAndPage(13, 5);
	}

	internal static bool EFpIW0qN7Qi3KEI6nIy()
	{
		return Svvjc6qrAAC3L32Mgwb == null;
	}
}
