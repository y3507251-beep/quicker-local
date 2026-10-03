using System;
using System.Runtime.CompilerServices;

namespace CW.Win32;

public class ScreenInfo : IEquatable<ScreenInfo>
{
	[CompilerGenerated]
	private Int32Rect WaJCOHp2ID;

	[CompilerGenerated]
	private Int32Rect sgUCF05Rt2;

	[CompilerGenerated]
	private string UmACUsawSO;

	private static ScreenInfo fc3lPa1E9B5eUTc8DPh;

	public Int32Rect ScreenArea
	{
		[CompilerGenerated]
		get
		{
			return WaJCOHp2ID;
		}
		[CompilerGenerated]
		private set
		{
			WaJCOHp2ID = value;
		}
	}

	public Int32Rect WorkingArea
	{
		[CompilerGenerated]
		get
		{
			return sgUCF05Rt2;
		}
		[CompilerGenerated]
		private set
		{
			sgUCF05Rt2 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return UmACUsawSO;
		}
		[CompilerGenerated]
		private set
		{
			UmACUsawSO = value;
		}
	}

	internal ScreenInfo(Screen.mu1DCmdfaEny33ihLQa info)
	{
		ScreenArea = new Int32Rect(info.vYovyr96Q7n.Left, info.vYovyr96Q7n.Top, info.vYovyr96Q7n.Right - info.vYovyr96Q7n.Left, info.vYovyr96Q7n.Bottom - info.vYovyr96Q7n.Top);
		WorkingArea = new Int32Rect(info.IsovypLqSPq.Left, info.IsovypLqSPq.Top, info.IsovypLqSPq.Right - info.IsovypLqSPq.Left, info.IsovypLqSPq.Bottom - info.IsovypLqSPq.Top);
		Name = info.J2AvyQdH5ke;
	}

	public bool Equals(ScreenInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (ScreenArea == other.ScreenArea && WorkingArea == other.WorkingArea)
		{
			return Name == other.Name;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		return Equals(obj as ScreenInfo);
	}

	public override int GetHashCode()
	{
		return ScreenArea.GetHashCode() ^ WorkingArea.GetHashCode() ^ Name.GetHashCode();
	}

	public static bool operator ==(ScreenInfo a, ScreenInfo b)
	{
		if ((object)a == b)
		{
			return true;
		}
		return a?.Equals(b) ?? false;
	}

	public static bool operator !=(ScreenInfo a, ScreenInfo b)
	{
		return !(a == b);
	}

	internal static bool yoh8Nx1Gm76K1osXpRa()
	{
		return (object)fc3lPa1E9B5eUTc8DPh == null;
	}
}
