using Quicker.Domain.PowerMouse;

namespace RjUv0gj94MtT9uEZCA0;

internal static class xZ3bFljcLr8VveAeAhc
{
	internal static object pgIci5QOHgfxfeje3L7E;

	public static int YgGtIk4fjI7(this MouseActionLocation mouseActionLocation_0)
	{
		int num;
		if (mouseActionLocation_0 <= MouseActionLocation.UpRight)
		{
			if (mouseActionLocation_0 > MouseActionLocation.TopBorder)
			{
				if (mouseActionLocation_0 <= MouseActionLocation.BottomBorder)
				{
					if (mouseActionLocation_0 != MouseActionLocation.BottomBorderLeft)
					{
						goto IL_013c;
					}
					goto IL_0170;
				}
				if (mouseActionLocation_0 == MouseActionLocation.TaskBar)
				{
					return 4;
				}
				if (mouseActionLocation_0 == MouseActionLocation.UpLeft || mouseActionLocation_0 == MouseActionLocation.UpRight)
				{
					goto IL_00cf;
				}
			}
			else if (mouseActionLocation_0 <= MouseActionLocation.CornerBottomRight)
			{
				if ((uint)(mouseActionLocation_0 - 1) <= 1u || mouseActionLocation_0 == MouseActionLocation.CornerBottomLeft || mouseActionLocation_0 == MouseActionLocation.CornerBottomRight)
				{
					return 1;
				}
			}
			else
			{
				if (mouseActionLocation_0 == MouseActionLocation.TopBorderLeft || mouseActionLocation_0 == MouseActionLocation.TopBorderRight)
				{
					goto IL_0170;
				}
				if (mouseActionLocation_0 == MouseActionLocation.TopBorder)
				{
					goto IL_016e;
				}
			}
		}
		else
		{
			if (mouseActionLocation_0 <= MouseActionLocation.Down)
			{
				if (mouseActionLocation_0 <= MouseActionLocation.Left)
				{
					if (mouseActionLocation_0 != MouseActionLocation.Up)
					{
						if (mouseActionLocation_0 == MouseActionLocation.DownLeft)
						{
							goto IL_00cf;
						}
						if (mouseActionLocation_0 != MouseActionLocation.Left)
						{
							goto IL_0168;
						}
					}
				}
				else
				{
					if (mouseActionLocation_0 == MouseActionLocation.DownRight)
					{
						goto IL_00cf;
					}
					if (mouseActionLocation_0 != MouseActionLocation.Right)
					{
						num = 1;
						if (pgIci5QOHgfxfeje3L7E != null)
						{
							goto IL_0119;
						}
						goto IL_0130;
					}
				}
				goto IL_013a;
			}
			if (mouseActionLocation_0 > MouseActionLocation.LeftBorderDown)
			{
				if (mouseActionLocation_0 > MouseActionLocation.RightBorderUp)
				{
					goto IL_0158;
				}
				if (mouseActionLocation_0 != MouseActionLocation.LeftBorder)
				{
					num = 3;
					if (!ifgyi9QOzMC3c383e5o4())
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_0119;
				}
				goto IL_016e;
			}
			if (mouseActionLocation_0 == MouseActionLocation.WorkingArea)
			{
				return 7;
			}
			if (mouseActionLocation_0 == MouseActionLocation.LeftBorderUp || mouseActionLocation_0 == MouseActionLocation.LeftBorderDown)
			{
				goto IL_0170;
			}
		}
		goto IL_0168;
		IL_013a:
		return 6;
		IL_014e:
		if (mouseActionLocation_0 != MouseActionLocation.RightBorderUp)
		{
			goto IL_0168;
		}
		goto IL_0170;
		IL_0158:
		if (mouseActionLocation_0 != MouseActionLocation.RightBorderDown)
		{
			if (mouseActionLocation_0 != MouseActionLocation.RightBorder)
			{
				goto IL_0168;
			}
			goto IL_016e;
		}
		goto IL_0170;
		IL_013c:
		if (mouseActionLocation_0 != MouseActionLocation.BottomBorderRight)
		{
			if (mouseActionLocation_0 != MouseActionLocation.BottomBorder)
			{
				goto IL_0168;
			}
			goto IL_016e;
		}
		goto IL_0170;
		IL_0170:
		return 2;
		IL_0168:
		return 1000;
		IL_016e:
		return 3;
		IL_00cf:
		return 5;
		IL_0130:
		if (mouseActionLocation_0 == MouseActionLocation.Down)
		{
			goto IL_013a;
		}
		goto IL_0168;
		IL_0119:
		switch (num)
		{
		case 1:
			break;
		case 2:
			goto IL_013c;
		case 3:
			goto IL_014e;
		default:
			goto IL_0158;
		}
		goto IL_0130;
	}

	internal static bool ifgyi9QOzMC3c383e5o4()
	{
		return pgIci5QOHgfxfeje3L7E == null;
	}
}
