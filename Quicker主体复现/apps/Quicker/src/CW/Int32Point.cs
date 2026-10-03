using System;
using System.Runtime.CompilerServices;

namespace CW;

public struct Int32Point : IEquatable<Int32Point>
{
	public static readonly Int32Point Empty;

	[CompilerGenerated]
	private int c7l0PJv2aZ;

	[CompilerGenerated]
	private int fVL0Ee8d8C;

	private static object u94PfbEXP1rYqd89Fod;

	public int X
	{
		[CompilerGenerated]
		readonly get
		{
			return c7l0PJv2aZ;
		}
		[CompilerGenerated]
		private set
		{
			c7l0PJv2aZ = value;
		}
	}

	public int Y
	{
		[CompilerGenerated]
		readonly get
		{
			return fVL0Ee8d8C;
		}
		[CompilerGenerated]
		private set
		{
			fVL0Ee8d8C = value;
		}
	}

	public Int32Point(int x, int y)
	{
		this = default(Int32Point);
		X = x;
		Y = y;
	}

	public bool Equals(Int32Point point)
	{
		if (X.Equals(point.X))
		{
			return Y.Equals(point.Y);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is Int32Point)
		{
			return Equals((Int32Point)obj);
		}
		return false;
	}

	public static bool operator ==(Int32Point a, Int32Point b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Int32Point a, Int32Point b)
	{
		return !a.Equals(b);
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode();
	}

	public static Int32Point operator +(Int32Point a, Int32Point b)
	{
		return new Int32Point(a.X + b.X, a.Y + b.Y);
	}

	public static Int32Point operator -(Int32Point a, Int32Point b)
	{
		return new Int32Point(a.X - b.X, a.Y - b.Y);
	}

	public static Int32Point operator *(Int32Point a, Int32Point b)
	{
		return new Int32Point(a.X * b.X, a.Y * b.Y);
	}

	public static Int32Point operator /(Int32Point a, Int32Point b)
	{
		return new Int32Point(a.X / b.X, a.Y / b.Y);
	}

	public static Int32Point operator %(Int32Point a, Int32Point b)
	{
		return new Int32Point(a.X % b.X, a.Y % b.Y);
	}

	public static Int32Point operator +(Int32Point a, Int32Vector b)
	{
		return new Int32Point(a.X + b.X, a.Y + b.Y);
	}

	public static Int32Point operator -(Int32Point a, Int32Vector b)
	{
		return new Int32Point(a.X - b.X, a.Y - b.Y);
	}

	public static Int32Point operator *(Int32Point a, Int32Vector b)
	{
		return new Int32Point(a.X * b.X, a.Y * b.Y);
	}

	public static Int32Point operator /(Int32Point a, Int32Vector b)
	{
		return new Int32Point(a.X / b.X, a.Y / b.Y);
	}

	public static Int32Point operator %(Int32Point a, Int32Vector b)
	{
		return new Int32Point(a.X % b.X, a.Y % b.Y);
	}

	internal static bool Pl7OyBE2E0QE6G0cfdD()
	{
		return u94PfbEXP1rYqd89Fod == null;
	}
}
