using System;
using yADxuyq6eyZRBn9ENUn;

namespace ROyF57qMbQ7TBunLAQ1;

internal class uiNYvdqYlcc0O7o4d4I
{
	internal static int oKk8R9x1TM;

	internal static uiNYvdqYlcc0O7o4d4I tmu9kedeAc1oqTwgqXZ;

	internal static int uLT8uWb1YQ(byte[] byte_0, int int_1, int int_2)
	{
		int[] array = PhR8NoALEK(byte_0, int_1, int_2);
		if (array == null)
		{
			return 0;
		}
		int[] array2 = new int[int_2 / 2 + 2];
		int[] array3 = new int[int_2 / 2 + 1];
		int num = iZc8Jm0X9b(array2, array3, array, int_2);
		if (num <= 0)
		{
			return oKk8R9x1TM;
		}
		int[] array4 = new int[num];
		int num2 = 0;
		if (!Cy37XJdjZ7dXoKyAnH3())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
			if (!F9980BK3ae(array4, int_1, num, array2))
			{
				return oKk8R9x1TM;
			}
			alU8CAAD8y(byte_0, int_1, num, array4, array2, array3);
			return num;
		}
	}

	internal static int[] PhR8NoALEK(byte[] byte_0, int int_1, int int_2)
	{
		int[] array = new int[int_2];
		bool flag = false;
		int num = byte_0[0];
		int num2 = 1;
		int num4 = default(int);
		while (true)
		{
			int num3;
			if (num2 < int_1)
			{
				num = byte_0[num2] ^ num;
				num3 = 0;
				if (tmu9kedeAc1oqTwgqXZ == null)
				{
					goto IL_0079;
				}
				goto IL_006a;
			}
			array[0] = num;
			if (num != 0)
			{
				flag = true;
			}
			num4 = 1;
			goto IL_004f;
			IL_006a:
			switch (num3)
			{
			case 1:
				goto IL_0079;
			}
			goto IL_0065;
			IL_004f:
			if (num4 >= int_2)
			{
				break;
			}
			num = byte_0[0];
			num3 = 0;
			if (!Cy37XJdjZ7dXoKyAnH3())
			{
				goto IL_0065;
			}
			goto IL_006a;
			IL_0065:
			for (int i = 1; i < int_1; i++)
			{
				num = byte_0[i] ^ X4v8yjeycu(num, num4);
			}
			array[num4] = num;
			if (num != 0)
			{
				flag = true;
			}
			num4++;
			goto IL_004f;
			IL_0079:
			num2++;
		}
		if (!flag)
		{
			return null;
		}
		return array;
	}

	internal static int iZc8Jm0X9b(int[] int_1, int[] int_2, int[] int_3, int int_4)
	{
        int num5 = default;
        int[] array3 = default;
		int[] array = new int[int_4];
		int[] array2 = new int[int_4];
		array[1] = 1;
		array2[0] = 1;
		int num = 1;
		int num2 = 0;
		int num3 = -1;
		int num4 = 2;
		if (!Cy37XJdjZ7dXoKyAnH3())
		{
			goto IL_0079;
		}
		goto IL_0162;
		IL_0079:
		num5 = 0;
		goto IL_007c;
		IL_007c:
		array3 = default(int[]);
		if (num5 < int_4)
		{
			int num6 = int_3[num5];
			for (int i = 1; i <= num2; i++)
			{
				num6 ^= fco8EaNauZ(array2[i], int_3[num5 - i]);
			}
			if (num6 == 0)
			{
				goto IL_003d;
			}
			int int_5 = kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[num6];
			array3 = new int[int_4];
			for (int j = 0; j <= num5; j++)
			{
				array3[j] = array2[j] ^ X4v8yjeycu(array[j], int_5);
			}
			int num7 = num5 - num3;
			if (num7 <= num2)
			{
				goto IL_0039;
			}
			num3 = num5 - num2;
			num2 = num7;
			if (num2 > int_4 / 2)
			{
				num4 = 1;
				if (tmu9kedeAc1oqTwgqXZ != null)
				{
					goto IL_0070;
				}
			}
			else
			{
				for (int k = 0; k <= num; k++)
				{
					array[k] = nxm8akStxY(array2[k], int_5);
				}
				num4 = 2;
				if (Cy37XJdjZ7dXoKyAnH3())
				{
					goto IL_0035;
				}
			}
			goto IL_0162;
		}
		TuS87A8KwX(int_2, array2, int_3);
		Array.Copy(array2, 0, int_1, 0, Math.Min(array2.Length, int_1.Length));
		return num2;
		IL_003d:
		Array.Copy(array, 0, array, 1, Math.Min(array.Length - 1, num));
		array[0] = 0;
		num++;
		num4 = 0;
		if (!Cy37XJdjZ7dXoKyAnH3())
		{
			goto IL_0070;
		}
		goto IL_0162;
		IL_0162:
		switch (num4)
		{
		case 3:
			break;
		case 2:
			goto IL_0079;
		default:
			goto IL_0157;
		case 1:
			return oKk8R9x1TM;
		}
		goto IL_0035;
		IL_0157:
		num5++;
		goto IL_007c;
		IL_0039:
		array2 = array3;
		goto IL_003d;
		IL_0035:
		num = num2;
		goto IL_0039;
		IL_0070:
		int num8 = default(int);
		num4 = num8;
		goto IL_0162;
	}

	private static bool F9980BK3ae(int[] int_1, int int_2, int int_3, int[] int_4)
	{
        int num7 = default;
        int num5 = default;
        int num9 = default;
        int num6 = default;
        int num4 = default;
		int num = int_4[1];
		if (int_3 == 1)
		{
			if (kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[num] >= int_2)
			{
				return false;
			}
			int_1[0] = num;
			int num2 = 1;
			if (!Cy37XJdjZ7dXoKyAnH3())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			case 1:
				return true;
			}
			goto IL_008b;
		}
		num4 = int_3 - 1;
		num5 = 0;
		goto IL_0045;
		IL_005a:
		num6 = default(int);
		num7 = default(int);
		if (num6 > int_3)
		{
			if (num7 == 0)
			{
				int num8 = kABJLxqfUqMnVsvsSHh.W4Y8Ubm5SO[num5];
				num ^= num8;
				int_1[num4--] = num8;
				if (num4 == 0)
				{
					if (kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[num] >= int_2)
					{
						return false;
					}
					int_1[0] = num;
					return true;
				}
			}
			num5++;
			goto IL_0045;
		}
		goto IL_008b;
		IL_0045:
		num9 = default(int);
		if (num5 < int_2)
		{
			num9 = 255 - num5;
			num7 = 1;
			num6 = 1;
			goto IL_005a;
		}
		return false;
		IL_008b:
		num7 ^= X4v8yjeycu(int_4[num6], num9 * num6 % 255);
		num6++;
		goto IL_005a;
	}

	private static void alU8CAAD8y(byte[] byte_0, int int_1, int int_2, int[] int_3, int[] int_4, int[] int_5)
	{
		int num = 0;
		while (num < int_2)
		{
			int num2 = int_3[num];
			int num3 = 255 - kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[num2];
			int num4 = int_5[0];
			int i = 1;
			int num5 = 0;
			if (tmu9kedeAc1oqTwgqXZ == null)
			{
				goto IL_0052;
			}
			goto IL_0063;
			IL_0073:
			int num6 = int_4[1];
			for (int j = 2; j < int_2; j += 2)
			{
				num6 ^= X4v8yjeycu(int_4[j + 1], num3 * j % 255);
			}
			byte_0[int_1 - 1 - kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[num2]] ^= (byte)b4588Wu1He(num2, num4, num6);
			num++;
			continue;
			IL_0063:
			switch (num5)
			{
			case 1:
				break;
			default:
				goto IL_0073;
			}
			goto IL_0052;
			IL_0052:
			for (; i < int_2; i++)
			{
				num4 ^= X4v8yjeycu(int_5[i], num3 * i % 255);
			}
			num5 = 0;
			if (tmu9kedeAc1oqTwgqXZ != null)
			{
				goto IL_0063;
			}
			goto IL_0073;
		}
	}

	internal static void f2p8PeL1e9(byte[] byte_0, int int_1, byte[] byte_1, int int_2)
	{
		int num = int_1 - int_2;
		int num4 = default(int);
		for (int i = 0; i < num; i++)
		{
			if (byte_0[i] != 0)
			{
				int num2 = kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[byte_0[i]];
				int j = 0;
				int num3 = 0;
				if (!Cy37XJdjZ7dXoKyAnH3())
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
				for (; j < int_2; j++)
				{
					byte_0[i + 1 + j] = (byte)(byte_0[i + 1 + j] ^ kABJLxqfUqMnVsvsSHh.W4Y8Ubm5SO[byte_1[j] + num2]);
				}
			}
		}
	}

	internal static int fco8EaNauZ(int int_1, int int_2)
	{
		if (int_1 != 0 && int_2 != 0)
		{
			return kABJLxqfUqMnVsvsSHh.W4Y8Ubm5SO[kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_1] + kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_2]];
		}
		return 0;
	}

	internal static int X4v8yjeycu(int int_1, int int_2)
	{
		if (int_1 != 0)
		{
			return kABJLxqfUqMnVsvsSHh.W4Y8Ubm5SO[kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_1] + int_2];
		}
		return 0;
	}

	internal static int b4588Wu1He(int int_1, int int_2, int int_3)
	{
		if (int_1 != 0 && int_2 != 0)
		{
			return kABJLxqfUqMnVsvsSHh.W4Y8Ubm5SO[(kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_1] + kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_2] - kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_3] + 255) % 255];
		}
		return 0;
	}

	internal static int nxm8akStxY(int int_1, int int_2)
	{
		if (int_1 != 0)
		{
			return kABJLxqfUqMnVsvsSHh.W4Y8Ubm5SO[kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_1] - int_2 + 255];
		}
		return 0;
	}

	internal static void TuS87A8KwX(int[] int_1, int[] int_2, int[] int_3)
	{
		Array.Clear(int_1, 0, int_1.Length);
		int num2 = default(int);
		for (int i = 0; i < int_2.Length; i++)
		{
			if (int_2[i] == 0)
			{
				continue;
			}
			int num = 0;
			if (!Cy37XJdjZ7dXoKyAnH3())
			{
				num = num2;
			}
			switch (num)
			{
			}
			int num3 = kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_2[i]];
			int num4 = Math.Min(int_3.Length, int_1.Length - i);
			for (int j = 0; j < num4; j++)
			{
				if (int_3[j] != 0)
				{
					int_1[i + j] ^= kABJLxqfUqMnVsvsSHh.W4Y8Ubm5SO[num3 + kABJLxqfUqMnVsvsSHh.dlH8lOmuoR[int_3[j]]];
				}
			}
		}
	}

	static uiNYvdqYlcc0O7o4d4I()
	{
		oKk8R9x1TM = -1;
	}

	internal static bool Cy37XJdjZ7dXoKyAnH3()
	{
		return tmu9kedeAc1oqTwgqXZ == null;
	}

	internal static void Pxxv1gdGGva61G34JeQ()
	{
	}
}
