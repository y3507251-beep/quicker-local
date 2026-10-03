using System;

namespace SnipInsight.Util;

public class DpiScale : IEquatable<DpiScale>
{
	private readonly double gV6MyjmkW;

	private readonly double lkBAwuMnE;

	private static DpiScale t5HnOnWKxEl9BUyg15a;

	public double X => gV6MyjmkW;

	public double Y => lkBAwuMnE;

	public DpiScale()
		: this(1.0, 1.0)
	{
	}

	public DpiScale(double value)
		: this(value, value)
	{
	}

	public DpiScale(double x, double y)
	{
		if (!double.IsNaN(x) && x > 0.0)
		{
			if (double.IsNaN(y) || y <= 0.0)
			{
				throw new ArgumentOutOfRangeException("y");
			}
			gV6MyjmkW = x;
			lkBAwuMnE = y;
			return;
		}
		throw new ArgumentOutOfRangeException("x");
	}

	public override string ToString()
	{
		return "X=" + X.ToString("0.###") + ", Y=" + Y.ToString("0.###");
	}

	public sealed override bool Equals(object obj)
	{
		if (obj is DpiScale)
		{
			return Equals((DpiScale)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() + Y.GetHashCode() << 2;
	}

	public bool Equals(DpiScale other)
	{
		if (X.Equals(other.X))
		{
			return Y.Equals(other.Y);
		}
		return false;
	}

	internal static bool pforqHWBBfZ0fWuAH9P()
	{
		return t5HnOnWKxEl9BUyg15a == null;
	}

	internal static void rRNoc0Wdx5ixitxgSlm()
	{
	}
}
