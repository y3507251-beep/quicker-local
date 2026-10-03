using System;
using System.Runtime.CompilerServices;

namespace CW;

public struct Int32Size : IEquatable<Int32Size>
{
	public static readonly Int32Size Empty;

	[CompilerGenerated]
	private int C1T0ePLVq4;

	[CompilerGenerated]
	private int upT0Y9hWvW;

	internal static object KAJdvwEDTX9nGVxv5ok;

	public int Width
	{
		[CompilerGenerated]
		readonly get
		{
			return C1T0ePLVq4;
		}
		[CompilerGenerated]
		private set
		{
			C1T0ePLVq4 = value;
		}
	}

	public int Height
	{
		[CompilerGenerated]
		readonly get
		{
			return upT0Y9hWvW;
		}
		[CompilerGenerated]
		private set
		{
			upT0Y9hWvW = value;
		}
	}

	public Int32Size(int width, int height)
	{
		this = default(Int32Size);
		Width = width;
		Height = height;
	}

	public bool Equals(Int32Size size)
	{
		if (Width.Equals(size.Width))
		{
			return Height.Equals(size.Height);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is Int32Size)
		{
			return Equals((Int32Size)obj);
		}
		return false;
	}

	public static bool operator ==(Int32Size a, Int32Size b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Int32Size a, Int32Size b)
	{
		return !a.Equals(b);
	}

	public override int GetHashCode()
	{
		return Width.GetHashCode() ^ Height.GetHashCode();
	}

	internal static bool JAL38IE3LR2F47lGGtJ()
	{
		return KAJdvwEDTX9nGVxv5ok == null;
	}
}
