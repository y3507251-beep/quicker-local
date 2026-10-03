using System;
using System.Runtime.CompilerServices;

namespace CW;

public struct Int32Vector : IEquatable<Int32Vector>
{
	public static readonly Int32Vector Empty;

	[CompilerGenerated]
	private int f6q0kU6Zmw;

	[CompilerGenerated]
	private int YsP0GPnbJP;

	internal static object MKeROxEGKNOqSBWW6Qb;

	public int X
	{
		[CompilerGenerated]
		readonly get
		{
			return f6q0kU6Zmw;
		}
		[CompilerGenerated]
		private set
		{
			f6q0kU6Zmw = value;
		}
	}

	public int Y
	{
		[CompilerGenerated]
		readonly get
		{
			return YsP0GPnbJP;
		}
		[CompilerGenerated]
		private set
		{
			YsP0GPnbJP = value;
		}
	}

	public Int32Vector(int x, int y)
	{
		this = default(Int32Vector);
		X = x;
		Y = y;
	}

	public bool Equals(Int32Vector point)
	{
		if (X.Equals(point.X))
		{
			return Y.Equals(point.Y);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj != null)
		{
			if (obj is Int32Vector)
			{
				return Equals((Int32Vector)obj);
			}
			return false;
		}
		return false;
	}

	public static bool operator ==(Int32Vector a, Int32Vector b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Int32Vector a, Int32Vector b)
	{
		return !a.Equals(b);
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode();
	}

	public static Int32Vector operator +(Int32Vector a, Int32Vector b)
	{
		return new Int32Vector(a.X + b.X, a.Y + b.Y);
	}

	public static Int32Vector operator -(Int32Vector a, Int32Vector b)
	{
		return new Int32Vector(a.X - b.X, a.Y - b.Y);
	}

	public static Int32Vector operator *(Int32Vector a, Int32Vector b)
	{
		return new Int32Vector(a.X * b.X, a.Y * b.Y);
	}

	public static Int32Vector operator /(Int32Vector a, Int32Vector b)
	{
		return new Int32Vector(a.X / b.X, a.Y / b.Y);
	}

	public static Int32Vector operator %(Int32Vector a, Int32Vector b)
	{
		return new Int32Vector(a.X % b.X, a.Y % b.Y);
	}

	internal static bool HUKgdiE0bBD0iQGnukZ()
	{
		return MKeROxEGKNOqSBWW6Qb == null;
	}
}
