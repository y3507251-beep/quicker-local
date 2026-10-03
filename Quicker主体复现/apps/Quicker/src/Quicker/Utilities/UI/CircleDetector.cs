using System;
using System.Collections.Generic;
using System.Drawing;

namespace Quicker.Utilities.UI;

public static class CircleDetector
{
	private static readonly IList<Point> yTov2gtCQXu;

	private static DateTime puvv2LOMdp5;

	private static Point x8Pv2vNuRiZ;

	private static Point EZLv2STjWe7;

	private static object YwSJUSFh5WcfeEPyp9J4;

	public static bool CheckMouseMove(Point point)
	{
		if ((DateTime.UtcNow - puvv2LOMdp5).TotalMilliseconds > 30.0)
		{
			yTov2gtCQXu.Clear();
			yTov2gtCQXu.Add(point);
		}
		else if (yTov2gtCQXu.Count == 0 || Math.Abs(point.X - yTov2gtCQXu[yTov2gtCQXu.Count - 1].X) > 2 || Math.Abs(point.X - yTov2gtCQXu[yTov2gtCQXu.Count - 1].X) > 2)
		{
			yTov2gtCQXu.Add(point);
		}
		if (yTov2gtCQXu.Count == 1)
		{
			x8Pv2vNuRiZ = yTov2gtCQXu[0];
		}
		puvv2LOMdp5 = DateTime.UtcNow;
		EZLv2STjWe7 = point;
		if (hXOv2wtgroN())
		{
			yTov2gtCQXu.Clear();
			return true;
		}
		if (yTov2gtCQXu.Count > 100)
		{
			yTov2gtCQXu.Clear();
		}
		return false;
	}

	public static Point GetBasePoint()
	{
		return x8Pv2vNuRiZ;
	}

	private static bool hXOv2wtgroN()
	{
		if (yTov2gtCQXu.Count < 5)
		{
			return false;
		}
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		int num7 = default(int);
		while (true)
		{
			if (num3 < yTov2gtCQXu.Count - 2)
			{
				while (true)
				{
					double num4 = Math.Atan2(yTov2gtCQXu[num3 + 1].Y - yTov2gtCQXu[num3].Y, yTov2gtCQXu[num3 + 1].X - yTov2gtCQXu[num3].X) * 180.0 / Math.PI;
					if (num3 != 0)
					{
						double num5 = num4 - num2;
						if (num5 >= -180.0)
						{
							if (num5 > 180.0)
							{
								int num6 = 0;
								if (YwSJUSFh5WcfeEPyp9J4 != null)
								{
									num6 = num7;
								}
								switch (num6)
								{
								case 1:
									continue;
								}
								num5 -= 360.0;
							}
						}
						else
						{
							num5 += 360.0;
						}
						num += num5;
						num2 = num4;
					}
					else
					{
						num2 = num4;
					}
					break;
				}
				if ((num > 450.0 || num < -450.0) && cROv2tuLabA(num3))
				{
					break;
				}
				num3++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool cROv2tuLabA(int int_0)
	{
		double? num = null;
		double? num2 = null;
		double? num3 = null;
		double? num4 = null;
		int num5 = 0;
		int num7 = default(int);
		foreach (Point item in yTov2gtCQXu)
		{
			num = Math.Max(num ?? ((double)item.X), item.X);
			int num6 = 0;
			if (YwSJUSFh5WcfeEPyp9J4 != null)
			{
				goto IL_0126;
			}
			goto IL_0128;
			IL_0126:
			num6 = num7;
			goto IL_0128;
			IL_0128:
			while (true)
			{
				double val;
				switch (num6)
				{
				default:
					num2 = Math.Min(num2 ?? ((double)item.X), item.X);
					num3 = Math.Max(num3 ?? ((double)item.Y), item.Y);
					val = num4 ?? ((double)item.Y);
					goto IL_0100;
				case 1:
					break;
				}
				break;
				IL_0100:
				num4 = Math.Min(val, item.Y);
				num5++;
				num6 = 1;
				if (YwSJUSFh5WcfeEPyp9J4 == null)
				{
					continue;
				}
				goto IL_0126;
			}
			if (num5 >= int_0)
			{
				break;
			}
		}
		double num8 = num.Value - num2.Value;
		double num9 = num3.Value - num4.Value;
		if (YwSJUSFh5WcfeEPyp9J4 == null)
		{
			switch (0)
			{
			}
		}
		if (num8 > num9 / 2.0 && num8 < 2.0 * num9 && num8 < 500.0 && num9 < 500.0 && num8 > 20.0 && num9 > 20.0)
		{
			return true;
		}
		return false;
	}

	static CircleDetector()
	{
		yTov2gtCQXu = new List<Point>(150);
		puvv2LOMdp5 = DateTime.MinValue;
	}

	internal static bool ePZ9isFhY1gmcs4KPMuF()
	{
		return YwSJUSFh5WcfeEPyp9J4 == null;
	}
}
