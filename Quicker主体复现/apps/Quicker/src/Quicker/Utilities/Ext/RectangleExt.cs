using System.Drawing;

namespace Quicker.Utilities.Ext;

public static class RectangleExt
{
	private static object YpGQHOFx57wxTgTGBUN2;

	public static bool IsOnBottomBorder(this Rectangle rect, Point point)
	{
		return point.Y == rect.Bottom - 1;
	}

	public static bool IsOnTopBorder(this Rectangle rect, Point point)
	{
		return point.Y == rect.Top;
	}

	public static bool IsOnLeftBorder(this Rectangle rect, Point point)
	{
		return point.X == rect.Left;
	}

	public static bool IsOnRightBorder(this Rectangle rect, Point point)
	{
		return point.X == rect.Right - 1;
	}

	public static bool IsOnLeftHalf(this Rectangle rect, Point point)
	{
		if (point.X >= rect.Left && point.X < (rect.Right + rect.Left) / 2)
		{
			return rect.Contains(point);
		}
		return false;
	}

	public static bool IsOnRightHalf(this Rectangle rect, Point point)
	{
		if (point.X < rect.Right && point.X >= (rect.Right + rect.Left) / 2)
		{
			return rect.Contains(point);
		}
		return false;
	}

	public static bool IsOnTopHalf(this Rectangle rect, Point point)
	{
		if (point.Y >= rect.Top && point.Y < (rect.Bottom + rect.Top) / 2)
		{
			return rect.Contains(point);
		}
		return false;
	}

	public static bool IsOnBottomHalf(this Rectangle rect, Point point)
	{
		if (point.Y < rect.Bottom && point.Y >= (rect.Bottom + rect.Top) / 2)
		{
			return rect.Contains(point);
		}
		return false;
	}

	public static bool IsCornerTopLeft(this Rectangle rect, Point point)
	{
		if (point.X == rect.Left)
		{
			return point.Y == rect.Top;
		}
		return false;
	}

	public static bool IsCornerTopRight(this Rectangle rect, Point point)
	{
		if (point.X == rect.Right - 1)
		{
			return point.Y == rect.Top;
		}
		return false;
	}

	public static bool IsCornerBottomLeft(this Rectangle rect, Point point)
	{
		if (point.X == rect.Left)
		{
			return point.Y == rect.Bottom - 1;
		}
		return false;
	}

	public static bool IsCornerBottomRight(this Rectangle rect, Point point)
	{
		if (point.X == rect.Right - 1)
		{
			return point.Y == rect.Bottom - 1;
		}
		return false;
	}

	internal static bool YiKphVFxY6Ee53JSo13L()
	{
		return YpGQHOFx57wxTgTGBUN2 == null;
	}
}
