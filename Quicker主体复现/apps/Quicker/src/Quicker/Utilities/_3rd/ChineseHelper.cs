namespace Quicker.Utilities._3rd;

public class ChineseHelper
{
	internal static ChineseHelper iANsH2FTkGm8qyB9MsUm;

	protected static long CharToNumber(char c)
	{
		int num;
		if ((uint)c <= 20061u)
		{
			if ((uint)c > 19968u)
			{
				if (c != '七')
				{
					num = 1;
					if (iANsH2FTkGm8qyB9MsUm != null)
					{
						goto IL_008b;
					}
					goto IL_009a;
				}
				return 7L;
			}
			switch (c)
			{
			case '一':
				return 1L;
			case '〇':
				return 0L;
			}
		}
		else
		{
			if ((uint)c <= 20843u)
			{
				if (c != '二')
				{
					if (c != '五')
					{
						if (c != '八')
						{
							num = 0;
							if (!wU9tcsFTaKTXhXZGrks0())
							{
								int num2 = default(int);
								num = num2;
							}
							goto IL_008b;
						}
						return 8L;
					}
					return 5L;
				}
				return 2L;
			}
			switch (c)
			{
			case '零':
				return 0L;
			case '四':
				return 4L;
			case '六':
				return 6L;
			}
		}
		goto IL_00f6;
		IL_009a:
		switch (c)
		{
		case '九':
			return 9L;
		case '三':
			return 3L;
		}
		goto IL_00f6;
		IL_008b:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00f6;
		}
		goto IL_009a;
		IL_00f6:
		return -1L;
	}

	protected static long CharToUnit(char c)
	{
		return c switch
		{
			'亿' => 100000000L, 
			'万' => 10000L, 
			'百' => 100L, 
			'千' => 1000L, 
			'十' => 10L, 
			_ => 1L, 
		};
	}

	public static long ParseCnToInt(string cnum)
	{
		int num = 2;
		long num2 = default(long);
		long num3 = default(long);
		long num5 = default(long);
		int num6 = default(int);
		long num4 = default(long);
		while (true)
		{
			if (!string.IsNullOrEmpty(cnum))
			{
				cnum = cnum.Trim();
				num2 = 1L;
				num3 = 1L;
				num4 = 1L;
				num5 = 0L;
				num6 = cnum.Length - 1;
				goto IL_00d1;
			}
			int num7 = 1;
			if (iANsH2FTkGm8qyB9MsUm != null)
			{
				break;
			}
			goto IL_0071;
			IL_00d1:
			if (num6 > -1)
			{
				num4 = CharToUnit(cnum[num6]);
				num7 = 0;
				if (!wU9tcsFTaKTXhXZGrks0())
				{
					num7 = num;
				}
				goto IL_0071;
			}
			return num5;
			IL_0071:
			switch (num7)
			{
			case 2:
				continue;
			case 1:
				goto end_IL_00e9;
			}
			if (num4 > num2)
			{
				num2 = num4;
				num3 = 1L;
				if (num6 == 0)
				{
					num5 += num2 * num3;
				}
			}
			else if (num4 > num3)
			{
				num3 = num4;
			}
			else
			{
				num5 += num2 * num3 * CharToNumber(cnum[num6]);
			}
			num6--;
			goto IL_00d1;
			continue;
			end_IL_00e9:
			break;
		}
		return 0L;
	}

	static ChineseHelper()
	{
	}

	internal static bool wU9tcsFTaKTXhXZGrks0()
	{
		return iANsH2FTkGm8qyB9MsUm == null;
	}

	internal static void SL3icwFTNwk1TT60A2Oo()
	{
	}

	internal static void upBmEaFT9ftwkAGuuEUc()
	{
	}
}
