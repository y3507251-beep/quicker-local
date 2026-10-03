using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Quicker.Utilities.UI;

[Obsolete("不再使用了，效果不理想")]
public static class ZMoveDetector
{
	private static readonly IList<Point> KwKvS33bA4Y;

	private static DateTime sCovSfh4B13;

	private static Point hfjvSzf6sSf;

	private static object MeqYQ8FhqQbwkn05mewx;

	public static bool CheckMouseMove(Point point)
	{
		if ((DateTime.Now - sCovSfh4B13).TotalMilliseconds > 40.0)
		{
			KwKvS33bA4Y.Clear();
			int num = 0;
			if (MeqYQ8FhqQbwkn05mewx != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			KwKvS33bA4Y.Add(point);
		}
		else if (KwKvS33bA4Y.Count == 0 || Math.Abs(point.X - KwKvS33bA4Y[KwKvS33bA4Y.Count - 1].X) > 2 || Math.Abs(point.X - KwKvS33bA4Y[KwKvS33bA4Y.Count - 1].X) > 2)
		{
			KwKvS33bA4Y.Add(point);
		}
		if (KwKvS33bA4Y.Count == 1)
		{
			hfjvSzf6sSf = KwKvS33bA4Y[0];
		}
		sCovSfh4B13 = DateTime.Now;
		if (pE0vSlyC7GW())
		{
			Reset();
			return true;
		}
		if (KwKvS33bA4Y.Count > 100)
		{
			KwKvS33bA4Y.Clear();
		}
		return false;
	}

	public static Point GetBasePoint()
	{
		return hfjvSzf6sSf;
	}

	private static bool pE0vSlyC7GW()
	{
		int num = 2;
		Point point = default(Point);
		Point point2 = default(Point);
		Point? point3 = default(Point?);
		Point? point4 = default(Point?);
		int num2 = default(int);
		while (true)
		{
			if (KwKvS33bA4Y.Count >= 5)
			{
				point = KwKvS33bA4Y.Last();
				point2 = KwKvS33bA4Y.First();
				if (point.X - point2.X >= 50)
				{
					point3 = null;
					point4 = null;
					num2 = 1;
					goto IL_00f4;
				}
				return false;
			}
			int num3 = 1;
			if (!gCPfhuFhiTEnW1UrL0hA())
			{
				goto IL_00ba;
			}
			goto IL_0205;
			IL_0205:
			return false;
			IL_00ee:
			num2++;
			goto IL_00f4;
			IL_0187:
			if (point3.HasValue && point4.HasValue)
			{
				if ((double)(point.X - point4.Value.X) > (double)(point3.Value.X - point2.X) * 0.66 && point.X - point4.Value.X > 50)
				{
					break;
				}
				return false;
			}
			return false;
			IL_00f4:
			if (num2 < KwKvS33bA4Y.Count - 2)
			{
				Point point5 = KwKvS33bA4Y[num2];
				Point value = KwKvS33bA4Y[num2 - 1];
				if (point3.HasValue)
				{
					if (point5.X > value.X)
					{
						point4 = value;
						if (point4.Value.X > point3.Value.X - 20 || point4.Value.Y < point3.Value.Y + 20)
						{
							Reset();
							return false;
						}
						goto IL_0187;
					}
				}
				else if (point5.X < value.X)
				{
					point3 = value;
					num3 = 0;
					if (MeqYQ8FhqQbwkn05mewx != null)
					{
						num3 = num;
					}
					goto IL_00ba;
				}
				goto IL_00ee;
			}
			goto IL_0187;
			IL_00ba:
			switch (num3)
			{
			case 2:
				continue;
			case 1:
				goto IL_0205;
			case 3:
				goto end_IL_0117;
			}
			if (point3.Value.X - point2.X < 20)
			{
				Reset();
				return false;
			}
			goto IL_00ee;
			continue;
			end_IL_0117:
			break;
		}
		return true;
	}

	private static void Reset()
	{
		KwKvS33bA4Y.Clear();
	}

	private static double QP6vSiSnHUC(Point point_1, Point point_2)
	{
		return Math.Sqrt((point_2.X - point_1.X) * (point_2.X - point_1.X) + (point_2.Y - point_1.Y) * (point_2.Y - point_1.Y));
	}

	static ZMoveDetector()
	{
		KwKvS33bA4Y = new List<Point>(150);
		sCovSfh4B13 = DateTime.MinValue;
	}

	internal static bool gCPfhuFhiTEnW1UrL0hA()
	{
		return MeqYQ8FhqQbwkn05mewx == null;
	}
}
