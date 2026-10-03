using System;

namespace Quicker.ScreenSelectLib.Tools;

public class DpiScale : IEquatable<DpiScale>
{
	private readonly double R2lxgFStAX;

	private readonly double ODVxLgXs1c;

	internal static DpiScale EoRjEVIoaQibFTHsD4N;

	public double X => R2lxgFStAX;

	public double Y => ODVxLgXs1c;

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
			R2lxgFStAX = x;
			ODVxLgXs1c = y;
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

	internal static bool LZ14rIIff4bZGnrcCHI()
	{
		return EoRjEVIoaQibFTHsD4N == null;
	}

	internal static void FTAn6gIqTWoDHRoyOHp()
	{
	}
}
