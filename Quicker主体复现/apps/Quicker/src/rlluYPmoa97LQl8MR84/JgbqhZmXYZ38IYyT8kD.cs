using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using OrK689mjOgCMk2cN05l;
using qgnh0JiJCUj4XCaowwH;
using Quicker.Pinyin.Fast1;
using Quicker.Utilities.Pinyin;

namespace rlluYPmoa97LQl8MR84;

internal static class JgbqhZmXYZ38IYyT8kD
{
	internal static object lcfEHKcFmVKA1bthVq6M;

	public static IMatchResult YnUv0hUKRnR(string string_0, string[] string_1)
	{
		if (string_1.Length == 1)
		{
			return mAZv0Ip0Lh7(string_0, string_1[0]);
		}
		if (!Hvsk6hm2aXU8RjHpcnC.Jmuv0qnh4NW(string_0, string_1))
		{
			return null;
		}
		FastMatchResult fastMatchResult = new FastMatchResult(string_0.Length);
		int num = 0;
		int num3 = default(int);
		while (true)
		{
			if (num < string_1.Length)
			{
				IMatchResult matchResult = lJ1v0kVGfTD(string_0, string_1[num], true);
				if (matchResult == null)
				{
					break;
				}
				fastMatchResult.MergePositions(matchResult);
				num++;
				continue;
			}
			int num2 = 0;
			if (!kTKJ4vcFsbdFISCsnuGH())
			{
				num2 = num3;
			}
			switch (num2)
			{
			default:
				Couv0GiTBX8(fastMatchResult, "", string_0);
				return fastMatchResult;
			}
		}
		return null;
	}

	public static IMatchResult uLlv0e2kYKg(string string_0, string[] string_1)
	{
		FastMatchResult fastMatchResult = new FastMatchResult(string_0.Length);
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				IMatchResult matchResult = D4Iv015Oj1g(string_0, string_1[num], true);
				if (matchResult == null)
				{
					break;
				}
				fastMatchResult.MergePositions(matchResult);
				num++;
				continue;
			}
			Couv0GiTBX8(fastMatchResult, "", string_0);
			if (fastMatchResult.Score <= 0)
			{
				fastMatchResult.Score = 1;
			}
			return fastMatchResult;
		}
		return null;
	}

	public static IMatchResult udTv0YIJNUQ(string string_0, string string_1)
	{
		return D4Iv015Oj1g(string_0, string_1, true);
	}

	public static IMatchResult mAZv0Ip0Lh7(string string_0, string string_1)
	{
		if (!Hvsk6hm2aXU8RjHpcnC.KoUv0ctUxLH(string_0, string_1))
		{
			return null;
		}
		if (string_0.Length >= string_1.Length)
		{
			IMatchResult matchResult = D4Iv015Oj1g(string_0, string_1, true);
			if (matchResult != null)
			{
				return matchResult;
			}
		}
		IMatchResult matchResult2 = lJ1v0kVGfTD(string_0, string_1, true);
		if (matchResult2 != null)
		{
			Couv0GiTBX8(matchResult2, string_1, string_0);
			return matchResult2;
		}
		return null;
	}

	public static IMatchResult NrSv0WXIyvf(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			if (Hvsk6hm2aXU8RjHpcnC.rvfv0ZEO9SI(string_0[0], string_1[0]))
			{
				FastMatchResult fastMatchResult = new FastMatchResult(string_0.Length);
				fastMatchResult.Score = 801 - string_0.Length;
				fastMatchResult.SetPosition(0);
				return fastMatchResult;
			}
			return null;
		}
		return null;
	}

	public static bool IsMatch(string text, string pattern)
	{
		if (!Hvsk6hm2aXU8RjHpcnC.KoUv0ctUxLH(text, pattern))
		{
			return false;
		}
		return lJ1v0kVGfTD(text, pattern, false) != null;
	}

	public static bool IsMatch(string text, string[] patterns)
	{
		if (!Hvsk6hm2aXU8RjHpcnC.Jmuv0qnh4NW(text, patterns))
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < patterns.Length)
			{
				if (lJ1v0kVGfTD(text, patterns[num], false) == null)
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

	private static IMatchResult lJ1v0kVGfTD(string string_0, string string_1, bool bool_0)
	{
		int num = 1;
		char c = default(char);
		int num3 = default(int);
		int i = default(int);
		IMatchResult matchResult3 = default(IMatchResult);
		string[] array = default(string[]);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			IMatchResult matchResult2;
			IMatchResult matchResult;
			if (bool_0)
			{
				matchResult = new FastMatchResult(string_0.Length);
				matchResult2 = matchResult;
				goto IL_019d;
			}
			int num2 = 0;
			if (kTKJ4vcFsbdFISCsnuGH())
			{
				goto IL_016a;
			}
			goto IL_0194;
			IL_0022:
			c = string_0[num3];
			goto IL_002c;
			IL_002c:
			if (string_1[i] == ' ')
			{
				for (i++; i < string_1.Length && string_1[i] == ' '; i++)
				{
				}
				if (i >= string_1.Length)
				{
					return matchResult3;
				}
			}
			int num4;
			if (!D16v0HfI1IH(string_1[i]))
			{
				if (c == string_1[i])
				{
					i++;
					matchResult3.SetPosition(num3);
					if (i == string_1.Length)
					{
						return matchResult3;
					}
				}
			}
			else
			{
				array = ((c <= '\u007f') ? null : XRlL56iKFaTMc4ji9eS.bjDvN5ExdKB(string_0, num3));
				if (array != null)
				{
					num4 = 0;
					num5 = 0;
					goto IL_011d;
				}
				if (Hvsk6hm2aXU8RjHpcnC.rvfv0ZEO9SI(string_0[num3], string_1[i]))
				{
					i++;
					matchResult3.SetPosition(num3);
					if (i >= string_1.Length)
					{
						return matchResult3;
					}
				}
			}
			goto IL_0147;
			IL_019d:
			matchResult3 = matchResult2;
			i = 0;
			num6 = Math.Min(string_0.Length, 128);
			num3 = 0;
			goto IL_0189;
			IL_0189:
			if (num3 < num6)
			{
				goto IL_0022;
			}
			if (i < string_1.Length)
			{
				num2 = 2;
				if (lcfEHKcFmVKA1bthVq6M != null)
				{
					num2 = num;
				}
				goto IL_016a;
			}
			return matchResult3;
			IL_0147:
			num3++;
			goto IL_0189;
			IL_0117:
			num5++;
			goto IL_011d;
			IL_0113:
			num4 = num7;
			goto IL_0117;
			IL_016a:
			switch (num2)
			{
			case 4:
				break;
			case 5:
				goto IL_002c;
			case 3:
				goto IL_0113;
			default:
				goto IL_0194;
			case 1:
				continue;
			case 2:
				return null;
			}
			goto IL_0022;
			IL_0194:
			matchResult = new FastMatchResultNoPosition();
			matchResult2 = matchResult;
			goto IL_019d;
			IL_011d:
			if (num5 < array.Length)
			{
				num7 = v9sv0sAVZDC(array[num5], string_1, i);
				if (num7 > num4)
				{
					goto IL_0113;
				}
				goto IL_0117;
			}
			if (num4 > 0)
			{
				matchResult3.SetPosition(num3);
				i += num4;
				if (i >= string_1.Length)
				{
					break;
				}
			}
			goto IL_0147;
		}
		return matchResult3;
	}

	private static void Couv0GiTBX8(IMatchResult imatchResult_0, string string_0, string string_1)
	{
		IList<int> matchPositions = imatchResult_0.GetMatchPositions();
		int num;
		if (matchPositions.Count == 0)
		{
			imatchResult_0.Score = 0;
			num = 1;
			if (lcfEHKcFmVKA1bthVq6M != null)
			{
				return;
			}
		}
		else
		{
			int num2 = 0;
			for (int i = 1; i < matchPositions.Count; i++)
			{
				int num3 = matchPositions[i] - matchPositions[i - 1] - 1;
				if (num3 > 0)
				{
					num2 += num3 * 8 + i * 2;
				}
			}
			if (num2 != 0)
			{
				imatchResult_0.Score = 500 - matchPositions[0] * 8 - num2;
				return;
			}
			if (matchPositions[0] == 0)
			{
				if (matchPositions.Count == string_1.Length)
				{
					imatchResult_0.Score = 950 + string_0.Length - string_1.Length;
				}
				else
				{
					imatchResult_0.Score = 800 + string_0.Length - string_1.Length;
				}
				return;
			}
			imatchResult_0.Score = 600 - matchPositions[0] * 4 + string_0.Length - string_1.Length;
			num = 0;
			if (lcfEHKcFmVKA1bthVq6M != null)
			{
				int num4 = default(int);
				num = num4;
			}
		}
		switch (num)
		{
		case 1:
			break;
		}
	}

	private static int v9sv0sAVZDC(string string_0, string string_1, int int_0)
	{
		int num = 1;
		char char_ = default(char);
		int i = default(int);
		while (true)
		{
			int num2 = 0;
			int num3 = 0;
			if (lcfEHKcFmVKA1bthVq6M != null)
			{
				goto IL_0092;
			}
			goto IL_00e8;
			IL_00e8:
			while (true)
			{
				switch (num3)
				{
				case 2:
					break;
				default:
					goto IL_0098;
				case 1:
					goto end_IL_00e8;
				case 3:
					for (; i < string_0.Length && i < string_1.Length - int_0 && Hvsk6hm2aXU8RjHpcnC.NbUv09ly3qy(string_0[i], string_1[int_0 + i - 1]); i++)
					{
					}
					return i;
				}
				goto IL_000e;
				IL_0098:
				for (num2 = 0; num2 < string_0.Length && num2 < string_1.Length - int_0 && Hvsk6hm2aXU8RjHpcnC.NbUv09ly3qy(string_0[num2], string_1[int_0 + num2]); num2++)
				{
				}
				if (num2 <= 0)
				{
					char_ = string_1[int_0];
					num2 = 1;
					goto IL_000e;
				}
				return num2;
				IL_000e:
				if (num2 < string_0.Length && num2 <= int_0)
				{
					if (Hvsk6hm2aXU8RjHpcnC.NbUv09ly3qy(string_0[num2], char_))
					{
						int num4 = num2 - 1;
						while (num4 >= 0)
						{
							if (Hvsk6hm2aXU8RjHpcnC.NbUv09ly3qy(string_0[num4], string_1[int_0 - num2 + num4]))
							{
								num4--;
								continue;
							}
							return 0;
						}
						i = num2;
						i = num2 + 1;
						num3 = 3;
						if (lcfEHKcFmVKA1bthVq6M == null)
						{
							continue;
						}
					}
					else
					{
						num2++;
						num3 = 2;
						if (lcfEHKcFmVKA1bthVq6M == null)
						{
							continue;
						}
					}
					goto IL_0092;
				}
				return 0;
				continue;
				end_IL_00e8:
				break;
			}
			continue;
			IL_0092:
			num3 = num;
			goto IL_00e8;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool D16v0HfI1IH(char char_0)
	{
		if (char_0 >= 'a' && char_0 <= 'z')
		{
			return true;
		}
		if (char_0 >= 'A')
		{
			return char_0 <= 'Z';
		}
		return false;
	}

	private static IMatchResult D4Iv015Oj1g(string string_0, string string_1, bool bool_0)
	{
        IMatchResult matchResult3 = default;
		int num = string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase);
		int num2;
		if (num < 0)
		{
			num2 = 0;
			if (!kTKJ4vcFsbdFISCsnuGH())
			{
				goto IL_009e;
			}
			goto IL_00b4;
		}
		IMatchResult matchResult2;
		if (!bool_0)
		{
			IMatchResult matchResult = new FastMatchResultNoPosition();
			matchResult2 = matchResult;
		}
		else
		{
			IMatchResult matchResult = new FastMatchResult(string_0.Length);
			matchResult2 = matchResult;
		}
		matchResult3 = matchResult2;
		if (num == 0)
		{
			matchResult3.SetPositionRange(0, string_1.Length);
			if (string_1.Length == string_0.Length)
			{
				if (!string.Equals(string_0, string_1, StringComparison.Ordinal))
				{
					matchResult3.Score = 950;
					num2 = 0;
					if (!kTKJ4vcFsbdFISCsnuGH())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_009e;
				}
				matchResult3.Score = 1000;
			}
			else
			{
				matchResult3.Score = 800 + string_1.Length - string_0.Length;
			}
		}
		else
		{
			if (string_0[num - 1].IsLetter() && (!string_0[num].IsUpper() || !string_0[num - 1].IsLower()))
			{
				goto IL_0106;
			}
			matchResult3.SetPositionRange(num, string_1.Length);
			matchResult3.Score = 600 - num * 4 + string_1.Length - string_0.Length;
		}
		goto IL_0187;
		IL_00b4:
		return null;
		IL_009e:
		switch (num2)
		{
		case 1:
			break;
		case 2:
			goto IL_0106;
		default:
			goto IL_0187;
		}
		goto IL_00b4;
		IL_0106:
		int num4 = string_0.IndexOf(" " + string_1, num + 1, StringComparison.OrdinalIgnoreCase);
		if (num4 > 0)
		{
			num = num4 + 1;
		}
		matchResult3.SetPositionRange(num, string_1.Length);
		matchResult3.Score = 300 - num * 4 + string_1.Length - string_0.Length;
		goto IL_0187;
		IL_0187:
		if (matchResult3.Score <= 0)
		{
			matchResult3.Score = 1;
		}
		return matchResult3;
	}

	internal static bool kTKJ4vcFsbdFISCsnuGH()
	{
		return lcfEHKcFmVKA1bthVq6M == null;
	}
}
