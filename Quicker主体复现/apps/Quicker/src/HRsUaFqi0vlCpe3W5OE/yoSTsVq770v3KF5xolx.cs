using System;
using System.Runtime.CompilerServices;
using GFNWUBqDcrb64B51JaA;

namespace HRsUaFqi0vlCpe3W5OE;

internal static class yoSTsVq770v3KF5xolx
{
	private static readonly int[] fFEakvfsq2;

	private static readonly int[] jVmaG1q0oQ;

	private static readonly int[] GJ2as2R6Q7;

	private static object WuCHMgdP9RBFStOQDS5;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool WdSaVXAQKP(int int_3, int int_4, int int_5, int int_6, int int_7, int int_8)
	{
		if (int_3 != int_6)
		{
			return int_3 > int_6;
		}
		if (int_4 != int_7)
		{
			return int_4 > int_7;
		}
		if (int_8 != int_5)
		{
			return int_5 > int_8;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long OLraZ4wxK2(int int_3, int int_4, int int_5, int int_6, int int_7, int int_8)
	{
		int[] array = ((int_3 % 4 != 0 || (int_3 % 100 == 0 && int_3 % 400 != 0)) ? fFEakvfsq2 : jVmaG1q0oQ);
		int num = int_3 - 1;
		return (num * 365 + num / 4 - num / 100 + num / 400 + array[int_4 - 1] + int_5 - 1) * 864000000000L + (int_6 * 3600L + int_7 * 60L + int_8) * 10000000L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void mEPa9wRHJQ(long long_0, out int int_3, out int int_4, out int int_5, out int int_6, out int int_7, out int int_8)
	{
		int_3 = (int)(long_0 / 10000000L % 60L);
		if (long_0 % 10000000L != 0L)
		{
			int_3++;
		}
		int_4 = (int)(long_0 / 600000000L % 60L);
		int_5 = (int)(long_0 / 36000000000L % 24L);
		int num = 2;
		if (!KvbKHjdMiDw6iec1Nsl())
		{
			goto IL_008f;
		}
		goto IL_00bd;
		IL_00bd:
		int num3 = default(int);
		int num2 = default(int);
		do
		{
			IL_00bd_2:
			int num4;
			int num5;
			int num6;
			int[] array;
			switch (num)
			{
			case 2:
				break;
			case 1:
				num2 -= num3 * 146097;
				num4 = num2 / 36524;
				if (num4 == 4)
				{
					num = 0;
					if (!KvbKHjdMiDw6iec1Nsl())
					{
						goto IL_00bd_2;
					}
					goto default;
				}
				goto IL_00d4;
			default:
				{
					num4 = 3;
					goto IL_00d4;
				}
				IL_00d4:
				num2 -= num4 * 36524;
				num5 = num2 / 1461;
				num2 -= num5 * 1461;
				num6 = num2 / 365;
				if (num6 == 4)
				{
					num6 = 3;
				}
				int_8 = num3 * 400 + num4 * 100 + num5 * 4 + num6 + 1;
				num2 -= num6 * 365;
				array = ((num6 == 3 && (num5 != 24 || num4 == 3)) ? jVmaG1q0oQ : fFEakvfsq2);
				int_7 = (num2 >> 5) + 1;
				while (num2 >= array[int_7])
				{
					int_7++;
				}
				int_6 = num2 - array[int_7 - 1] + 1;
				return;
			}
			num2 = (int)(long_0 / 864000000000L);
			num3 = num2 / 146097;
			num = 1;
		}
		while (WuCHMgdP9RBFStOQDS5 == null);
		goto IL_008f;
		IL_008f:
		int num7 = default(int);
		num = num7;
		goto IL_00bd;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static DayOfWeek N6JahWMRji(int int_3, int int_4, int int_5)
	{
		int[] array = ((int_3 % 4 == 0 && (int_3 % 100 != 0 || int_3 % 400 == 0)) ? jVmaG1q0oQ : fFEakvfsq2);
		int num = int_3 - 1;
		return (DayOfWeek)((int)((num * 365 + num / 4 - num / 100 + num / 400 + array[int_4 - 1] + int_5 - 1) * 864000000000L / 864000000000L + 1L) % 7);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int cycae15GqA(int int_3, int int_4)
	{
		if (int_4 == 2 && int_3 % 4 == 0)
		{
			if (int_3 % 100 == 0 && int_3 % 400 != 0)
			{
				return 28;
			}
			return 29;
		}
		return GJ2as2R6Q7[int_4];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int mYsaY7BrCb(int int_3, int int_4, int int_5)
	{
		DayOfWeek dayOfWeek = N6JahWMRji(int_3, int_4, int_5);
		if (dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday)
		{
			return int_5;
		}
		if (dayOfWeek != DayOfWeek.Sunday)
		{
			if (int_5 != baoDAOquqn075oekDES.RL07r5DtNH.fIs7jDR3FN)
			{
				return int_5 - 1;
			}
			return int_5 + 2;
		}
		if (int_5 != cycae15GqA(int_3, int_4))
		{
			return int_5 + 1;
		}
		return int_5 - 2;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool gKPaIfRlUo(int int_3, int int_4)
	{
		if (int_3 - 7 * int_4 < baoDAOquqn075oekDES.RL07r5DtNH.fIs7jDR3FN)
		{
			return int_3 - 7 * (int_4 - 1) >= baoDAOquqn075oekDES.RL07r5DtNH.fIs7jDR3FN;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool x21aWR76b8(int int_3, int int_4, int int_5)
	{
		return int_5 + 7 > cycae15GqA(int_3, int_4);
	}

	static yoSTsVq770v3KF5xolx()
	{
		fFEakvfsq2 = new int[13]
		{
			0, 31, 59, 90, 120, 151, 181, 212, 243, 273,
			304, 334, 365
		};
		jVmaG1q0oQ = new int[13]
		{
			0, 31, 60, 91, 121, 152, 182, 213, 244, 274,
			305, 335, 366
		};
		GJ2as2R6Q7 = new int[13]
		{
			-1, 31, 28, 31, 30, 31, 30, 31, 31, 30,
			31, 30, 31
		};
	}

	internal static bool KvbKHjdMiDw6iec1Nsl()
	{
		return WuCHMgdP9RBFStOQDS5 == null;
	}
}
