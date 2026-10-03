using System;
using System.Runtime.CompilerServices;
using qgnh0JiJCUj4XCaowwH;

namespace OrK689mjOgCMk2cN05l;

internal static class Hvsk6hm2aXU8RjHpcnC
{
	internal static object FfqPtscFSKGmVKjDvhGy;

	public static bool Jmuv0qnh4NW(string string_0, string[] string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				if (!KoUv0ctUxLH(string_0, string_1[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool KoUv0ctUxLH(string string_0, string string_1)
	{
        int num2 = default;
        int num3 = default;
		int i;
		int length;
		int num;
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			i = 0;
			length = string_1.Length;
			num = 0;
			if (TkkKmwcFwJdO9YAvhEBY())
			{
				goto IL_0031;
			}
			goto IL_0173;
		}
		return false;
		IL_0173:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
				goto IL_007b;
			case 1:
				i++;
				if (i < length)
				{
					goto IL_0137;
				}
				num = 0;
				if (!TkkKmwcFwJdO9YAvhEBY())
				{
					continue;
				}
				goto default;
			default:
				return true;
			}
			break;
		}
		goto IL_0031;
		IL_0137:
		num2 = num2 + 1;
		goto IL_013d;
		IL_007b:
		if (i >= length)
		{
			return true;
		}
		goto IL_0137;
		IL_0031:
		num3 = Math.Min(string_0.Length, 128);
		num2 = 0;
		goto IL_013d;
		IL_013d:
		if (num2 < num3)
		{
			int num4 = default(int);
			if (string_1[i] > 'z')
			{
				if (string_0[num2] == string_1[i])
				{
					i++;
					num4 = 2;
					goto IL_007b;
				}
			}
			else
			{
				if (string_1[i] == ' ')
				{
					for (i++; i < length && string_1[i] == ' '; i++)
					{
					}
					if (i >= length)
					{
						return true;
					}
				}
				string[] array = ((string_0[num2] >= '\u007f') ? XRlL56iKFaTMc4ji9eS.qX1vN4saiJ7(string_0[num2]) : null);
				if (array == null)
				{
					if (rvfv0ZEO9SI(string_0[num2], string_1[i]))
					{
						num = 1;
						if (FfqPtscFSKGmVKjDvhGy != null)
						{
							num = num4;
						}
						goto IL_0173;
					}
				}
				else
				{
					int num5 = 0;
					for (int j = 0; j < array.Length; j++)
					{
						int num6 = a5Yv0VqiDaY(array[j], string_1, i);
						if (num6 > num5)
						{
							num5 = num6;
						}
					}
					i += num5;
					if (i >= length)
					{
						return true;
					}
				}
			}
			goto IL_0137;
		}
		return false;
	}

	private static int a5Yv0VqiDaY(string string_0, string string_1, int int_0)
	{
		int num = 0;
		int num2 = int_0;
		int num3 = 0;
		while (true)
		{
			if (num3 < string_0.Length)
			{
				if (!NbUv09ly3qy(string_0[num3], string_1[num2]))
				{
					if (num > 0)
					{
						return num;
					}
				}
				else
				{
					num++;
					num2 = int_0 + num;
					if (num2 == string_1.Length)
					{
						break;
					}
				}
				num3++;
				continue;
			}
			return num;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool rvfv0ZEO9SI(char char_0, char char_1)
	{
		int num = char_0 - char_1;
		if (num != 0 && num != 32 && num != -32)
		{
			return false;
		}
		return true;
	}

	internal static bool NbUv09ly3qy(char char_0, char char_1)
	{
		int num = char_0 - char_1;
		if (num != 0)
		{
			return num == 32;
		}
		return true;
	}

	internal static bool TkkKmwcFwJdO9YAvhEBY()
	{
		return FfqPtscFSKGmVKjDvhGy == null;
	}
}
