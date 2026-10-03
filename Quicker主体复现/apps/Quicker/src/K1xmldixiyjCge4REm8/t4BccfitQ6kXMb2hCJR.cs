using System;
using System.Collections.Generic;
using System.Linq;
using HJvvK0iZqNxwASxx58L;
using hXDavOirme1AwsCgjN8;
using NDyVL2iQCoEgScBbqCd;
using OrK689mjOgCMk2cN05l;
using qgnh0JiJCUj4XCaowwH;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.Pinyin.CnChar;
using s1H993mqNCkpDdM1vC5;

namespace K1xmldixiyjCge4REm8;

[Obsolete("请使用Quicker.Pinyin.Fast1.FastMatcher")]
internal static class t4BccfitQ6kXMb2hCJR
{
	internal static object M6M2XZcQRtsCY5QnA7K8;

	public static MatchResult suevJEug37x(string string_0, string string_1, bool bool_0, StringCharInfo stringCharInfo_0 = null, bool bool_1 = true, bool bool_2 = false)
	{
        bool bool_3 = default;
        bool flag = default;
        IList<IJ4vWZmlHsi92DoGSsc> ilist_ = default;
		if (string.IsNullOrEmpty(string_0) || string.IsNullOrEmpty(string_1))
		{
			return null;
		}
		if (!Hvsk6hm2aXU8RjHpcnC.KoUv0ctUxLH(string_0, string_1))
		{
			return null;
		}
		if (stringCharInfo_0 != null)
		{
			goto IL_0041;
		}
		stringCharInfo_0 = new StringCharInfo(string_1);
		int num = 3;
		if (M6M2XZcQRtsCY5QnA7K8 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_01d2;
		IL_025b:
		return null;
		IL_0276:
		return null;
		IL_019e:
		StringCharInfo info = default(StringCharInfo);
		if (info.HasCn)
		{
			goto IL_0080;
		}
		goto IL_025b;
		IL_0041:
		bool_3 = false;
		flag = stringCharInfo_0.HasMultiWords();
		if (string_0.Length > 64)
		{
			MatchResult matchResult = nGZCGaiRhIkQeak0rCa.tECvNiwj10E(string_0, string_1, stringCharInfo_0, bool_2);
			if (matchResult != null)
			{
				return matchResult;
			}
			bool_3 = true;
			string_0 = string_0.Substring(0, 64);
		}
		info = StringCharInfo.GetInfo(string_0);
		if (!stringCharInfo_0.HasUpperLetter || info.HasUpperLetter)
		{
			if (!stringCharInfo_0.HasCn)
			{
				goto IL_0080;
			}
			goto IL_019e;
		}
		goto IL_025b;
		IL_0080:
		ilist_ = default(IList<IJ4vWZmlHsi92DoGSsc>);
		if (!info.AllEn && !stringCharInfo_0.AllCn)
		{
			if (info.IsMixed && !flag)
			{
				int num3 = string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase);
				if (num3 >= 0)
				{
					MatchResult matchResult2 = new MatchResult(string_0);
					matchResult2.Score = ((num3 != 0) ? (600 - num3 * 4 + string_1.Length - string_0.Length) : ((string_1.Length == string_0.Length) ? 950 : (800 + string_1.Length - string_0.Length)));
					matchResult2.SetMatchPositionsFromPosition(num3, string_1.Length);
					return matchResult2;
				}
			}
			ilist_ = Splitter.fEIvJJC9yN7(string_0, info, bool_1);
			if (info.AllCn)
			{
				if (stringCharInfo_0.HasUpperLetter)
				{
					return null;
				}
				if (bool_0)
				{
					int num2 = 4;
					goto IL_0120;
				}
			}
			if (flag && bool_2)
			{
				MatchResult matchResult3 = yejvJySSyjE(string_0, stringCharInfo_0.Words[0], ilist_, bool_0);
				if (matchResult3 == null)
				{
					num = 0;
					if (LArkIFcQg0RxRjgXAV6p())
					{
						goto IL_01d2;
					}
					goto IL_0276;
				}
				int num4 = 1;
				while (true)
				{
					if (num4 <= stringCharInfo_0.Words.Count - 1)
					{
						MatchResult matchResult4 = yejvJySSyjE(string_0, stringCharInfo_0.Words[num4], ilist_, bool_0);
						if (matchResult4 == null)
						{
							break;
						}
						matchResult3.CombinePositions(matchResult4);
						num4++;
						continue;
					}
					matchResult3.ComputeScore(stringCharInfo_0.Words[0]);
					return matchResult3;
				}
				return null;
			}
			return yejvJySSyjE(string_0, string_1, ilist_, bool_0);
		}
		if (flag && bool_2)
		{
			return nGZCGaiRhIkQeak0rCa.js1vNlijlc0(string_0, stringCharInfo_0.Words, bool_2);
		}
		return nGZCGaiRhIkQeak0rCa.zDvvNfjfl2F(string_0, string_1, bool_3);
		IL_01d2:
		switch (num)
		{
		case 3:
			break;
		case 4:
			goto IL_0120;
		case 1:
			goto IL_0186;
		case 2:
			goto IL_019e;
		default:
			goto IL_0276;
		}
		goto IL_0041;
		IL_0186:
		MatchResult matchResult5 = default(MatchResult);
		MatchResult matchResult6 = default(MatchResult);
		int num5 = default(int);
		if (matchResult5 != null)
		{
			matchResult6.CombinePositions(matchResult5);
			num5++;
			goto IL_014a;
		}
		return null;
		IL_014a:
		if (num5 <= stringCharInfo_0.Words.Count - 1)
		{
			matchResult5 = r8MvJ7FVe03(string_0, stringCharInfo_0.Words[num5], ilist_);
			num = 1;
			if (M6M2XZcQRtsCY5QnA7K8 == null)
			{
				goto IL_01d2;
			}
			goto IL_0276;
		}
		matchResult6.ComputeScore(stringCharInfo_0.Words[0]);
		return matchResult6;
		IL_0120:
		if (flag && bool_2)
		{
			matchResult6 = r8MvJ7FVe03(string_0, stringCharInfo_0.Words[0], ilist_);
			if (matchResult6 != null)
			{
				num5 = 1;
				goto IL_014a;
			}
			return null;
		}
		return r8MvJ7FVe03(string_0, string_1, ilist_);
	}

	private static MatchResult yejvJySSyjE(string string_0, string string_1, IList<IJ4vWZmlHsi92DoGSsc> ilist_0, bool bool_0)
	{
		MatchResult matchResult = null;
		int i = 0;
		int num = 0;
		if (string_1.Length >= 3 && !qhEvJ8XC1yD(string_0, string_1, ilist_0, bool_0))
		{
			return null;
		}
		while (num < ilist_0.Count)
		{
			for (; i < string_1.Length && string_1[i] == ' '; i++)
			{
			}
			if (i >= string_1.Length)
			{
				break;
			}
			int int_;
			int int_2;
			e1YYLUiBPWxe4nF4maA e1YYLUiBPWxe4nF4maA = AtdvJaorNCo(string_0, ilist_0, num, string_1, i, bool_0, out int_, out int_2);
			if (e1YYLUiBPWxe4nF4maA != null)
			{
				i = int_;
				num = int_2 + 1;
				if (e1YYLUiBPWxe4nF4maA != e1YYLUiBPWxe4nF4maA.Empty)
				{
					if (matchResult == null)
					{
						matchResult = new MatchResult(string_0);
						matchResult.SetPositions(e1YYLUiBPWxe4nF4maA.QC1vJNCNW8Y);
					}
					else
					{
						matchResult.CombinePositions(e1YYLUiBPWxe4nF4maA.QC1vJNCNW8Y);
					}
					if (i >= string_1.Length)
					{
						break;
					}
				}
			}
			else
			{
				num++;
			}
		}
		if (matchResult != null && i >= string_1.Length)
		{
			matchResult.ComputeScore(string_1);
			return matchResult;
		}
		return null;
	}

	private static bool qhEvJ8XC1yD(string string_0, string string_1, IList<IJ4vWZmlHsi92DoGSsc> ilist_0, bool bool_0)
	{
		int num = string_1.Length - 1;
		int num2 = ilist_0.Count - 1;
		while (num2 >= 0 && num >= 0)
		{
			while (num >= 0 && string_1[num] == ' ')
			{
				num--;
			}
			if (num <= 0)
			{
				break;
			}
			int num3 = ilist_0[num2].UKQMIPtUO33(string_0, string_1, num, bool_0);
			num -= num3;
			num2--;
		}
		if (num <= 0)
		{
			return true;
		}
		return false;
	}

	private static e1YYLUiBPWxe4nF4maA AtdvJaorNCo(string string_0, IList<IJ4vWZmlHsi92DoGSsc> ilist_0, int int_0, string string_1, int int_1, bool bool_0, out int int_2, out int int_3)
	{
		foreach (e1YYLUiBPWxe4nF4maA item in ilist_0[int_0].TryMatch(string_0, string_1, int_1, bool_0))
		{
			int num = int_1 + item.aCYvJLJy6LE();
			if (num < string_1.Length && string_1[num] != ' ')
			{
				if (int_0 < ilist_0.Count - 1)
				{
					e1YYLUiBPWxe4nF4maA e1YYLUiBPWxe4nF4maA = AtdvJaorNCo(string_0, ilist_0, int_0 + 1, string_1, num, bool_0, out int_2, out int_3);
					if (e1YYLUiBPWxe4nF4maA != null)
					{
						item.cfNvJgfI6BL(e1YYLUiBPWxe4nF4maA);
						return item;
					}
				}
				continue;
			}
			int_2 = num;
			int_3 = int_0;
			return item;
		}
		int_2 = 0;
		int_3 = 0;
		return null;
	}

	private static MatchResult r8MvJ7FVe03(string string_0, string string_1, IList<IJ4vWZmlHsi92DoGSsc> ilist_0)
	{
		MatchResult matchResult = new MatchResult(string_0);
		int num = 0;
		int num2 = 0;
		int i;
		do
		{
			if (num2 < ilist_0.Count - 1)
			{
				for (i = num; i < string_1.Length; i++)
				{
					int num3 = i - num;
					char c = string_1[i];
					if (c != ' ')
					{
						if (num2 + num3 < ilist_0.Count)
						{
							if (!(ilist_0[num2 + num3] is pO9W35iCY0iier0aptY pO9W35iCY0iier0aptY) || !pO9W35iCY0iier0aptY.DwpvJGSiqoD(c))
							{
								num2++;
								break;
							}
							continue;
						}
						return null;
					}
					for (int j = num2; j < num3 + num2; j++)
					{
						matchResult.SetPosition((ilist_0[j] as pO9W35iCY0iier0aptY).JncvJbVan3F());
					}
					num += num3 + 1;
					num2 += num3;
					break;
				}
				continue;
			}
			return null;
		}
		while (i < string_1.Length);
		int num4 = i - num;
		for (int k = num2; k < num4 + num2; k++)
		{
			matchResult.SetPosition((ilist_0[k] as pO9W35iCY0iier0aptY).JncvJbVan3F());
		}
		matchResult.ComputeScore(string_1);
		return matchResult;
	}

	public static MatchResult R3MvJRni1Tk(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return null;
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		if (char.ToLowerInvariant(string_0[0]) != char.ToLowerInvariant(string_1[0]) && (!XRlL56iKFaTMc4ji9eS.EQHvNr1vadg(string_0[0]) || !CnCharProvider.GetCnChar(string_0[0]).FirstChars.Contains(char.ToLowerInvariant(string_1[0]))))
		{
			return null;
		}
		MatchResult matchResult = new MatchResult(string_0);
		matchResult.Score = 801 - string_0.Length;
		matchResult.SetMatchPositionsFromStart(1);
		return matchResult;
	}

	internal static bool LArkIFcQg0RxRjgXAV6p()
	{
		return M6M2XZcQRtsCY5QnA7K8 == null;
	}
}
