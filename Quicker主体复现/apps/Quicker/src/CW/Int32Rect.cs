using System;
using System.Runtime.CompilerServices;

namespace CW;

public struct Int32Rect : IEquatable<Int32Rect>
{
	[CompilerGenerated]
	private int NyS0qODjer;

	[CompilerGenerated]
	private int WX20cUUF94;

	[CompilerGenerated]
	private int Uxi0VNSBoP;

	[CompilerGenerated]
	private int Jxl0Zmh4oo;

	public static readonly Int32Rect Empty;

	internal static object ICLUCTEnssCovAWVyBa;

	public int X
	{
		[CompilerGenerated]
		readonly get
		{
			return NyS0qODjer;
		}
		[CompilerGenerated]
		private set
		{
			NyS0qODjer = value;
		}
	}

	public int Y
	{
		[CompilerGenerated]
		readonly get
		{
			return WX20cUUF94;
		}
		[CompilerGenerated]
		private set
		{
			WX20cUUF94 = value;
		}
	}

	public int Width
	{
		[CompilerGenerated]
		readonly get
		{
			return Uxi0VNSBoP;
		}
		[CompilerGenerated]
		private set
		{
			Uxi0VNSBoP = value;
		}
	}

	public int Height
	{
		[CompilerGenerated]
		readonly get
		{
			return Jxl0Zmh4oo;
		}
		[CompilerGenerated]
		private set
		{
			Jxl0Zmh4oo = value;
		}
	}

	public int Left => X;

	public int Top => Y;

	public int Right => X + Width;

	public int Bottom => Y + Height;

	public long Area => Width * Height;

	public bool IsEmpty => Empty.Equals(this);

	public Int32Rect(int x, int y, int width, int height)
	{
		this = default(Int32Rect);
		if (width < 0)
		{
			throw new ArgumentOutOfRangeException("width");
		}
		if (height < 0)
		{
			throw new ArgumentOutOfRangeException("height");
		}
		X = x;
		Y = y;
		Width = width;
		Height = height;
	}

	public bool Equals(Int32Rect rect)
	{
		if (X.Equals(rect.X) && Y.Equals(rect.Y) && Width.Equals(rect.Width))
		{
			return Height.Equals(Height);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is Int32Rect)
		{
			return Equals((Int32Rect)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode() ^ Width.GetHashCode() ^ Height.GetHashCode();
	}

	public static bool operator ==(Int32Rect a, Int32Rect b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Int32Rect a, Int32Rect b)
	{
		return !a.Equals(b);
	}

	public static Int32Rect operator +(Int32Rect a, Int32Vector v)
	{
		return new Int32Rect(a.Left + v.X, a.Top + v.Y, a.Width, a.Height);
	}

	public static Int32Rect operator +(Int32Vector v, Int32Rect a)
	{
		return new Int32Rect(a.Left + v.X, a.Top + v.Y, a.Width, a.Height);
	}

	public bool Contains(Int32Point pt)
	{
		return pY40yADIC1(pt.X, pt.Y);
	}

	public bool Contains(int x, int y)
	{
		return pY40yADIC1(x, y);
	}

	public bool Contains(Int32Rect rect)
	{
		if (X <= rect.X && Y <= rect.Y && X + Width >= rect.X + rect.Width)
		{
			return Y + Height >= rect.Y + rect.Height;
		}
		return false;
	}

	public bool IsIntersect(Int32Rect rect)
	{
		if (Left <= rect.Right && Right >= rect.Left && Top <= rect.Bottom)
		{
			return Bottom >= rect.Top;
		}
		return false;
	}

	public Int32Rect Intersect(Int32Rect rect)
	{
		if (Left <= rect.Right && Right >= rect.Left && Top <= rect.Bottom && Bottom >= rect.Top)
		{
			int num = Math.Max(Left, rect.Left);
			int num2 = Math.Max(Top, rect.Top);
			int num3 = Math.Min(Right, rect.Right);
			int num4 = Math.Min(Bottom, rect.Bottom);
			return new Int32Rect(num, num2, num4 - num2, num3 - num);
		}
		return Empty;
	}

	public Int32Rect Union(Int32Rect rect)
	{
		if (IsEmpty)
		{
			return rect;
		}
		if (!rect.IsEmpty)
		{
			int num = Math.Min(Left, rect.Left);
			int num2 = Math.Min(Top, rect.Top);
			int width = Math.Max(Math.Max(Right, rect.Right) - num, 0);
			int height = Math.Max(Math.Max(Bottom, rect.Bottom) - num2, 0);
			int y = num2;
			return new Int32Rect(num, y, width, height);
		}
		return rect;
	}

	private bool pY40yADIC1(int int_4, int int_5)
	{
		if (int_4 >= X && int_4 - Width <= X && int_5 >= Y)
		{
			return int_5 - Height <= Y;
		}
		return false;
	}

	internal static bool Igo7n7Ee6qComdrG8Sa()
	{
		return ICLUCTEnssCovAWVyBa == null;
	}
}
