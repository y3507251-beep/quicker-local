using System;
using System.Collections.Generic;
using Quicker.Utilities.Pinyin;

namespace HJvvK0iZqNxwASxx58L;

[Obsolete]
internal static class nGZCGaiRhIkQeak0rCa
{
	internal static object r7tZSNcQORfKV9Qdpf9f;

	public static bool k3xvNUjEfIi(string string_0, IList<string> ilist_0, bool bool_0)
	{
		if (bool_0)
		{
			int num = 0;
			while (true)
			{
				if (num < ilist_0.Count - 1)
				{
					if (string_0.IndexOf(ilist_0[num], StringComparison.OrdinalIgnoreCase) < 0)
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
		int num2 = 0;
		int i;
		for (i = 0; i < ilist_0.Count && num2 <= string_0.Length - ilist_0[i].Length; i++)
		{
			int num3 = string_0.IndexOf(ilist_0[i], num2, StringComparison.OrdinalIgnoreCase);
			if (num3 >= 0)
			{
				num2 = num3 + ilist_0[i].Length;
				continue;
			}
			return false;
		}
		if (i < ilist_0.Count)
		{
			return false;
		}
		return true;
	}

	public static MatchResult js1vNlijlc0(string string_0, IList<string> ilist_0, bool bool_0)
	{
		if (!string.IsNullOrEmpty(string_0) && ilist_0.Count != 0)
		{
			if (ilist_0.Count == 1)
			{
				return niEvN36QmKR(string_0, ilist_0[0]);
			}
			int num = string_0.IndexOf(ilist_0[0], StringComparison.OrdinalIgnoreCase);
			if (num < 0)
			{
				return null;
			}
			MatchResult matchResult = new MatchResult(string_0);
			matchResult.SetPositionRange(num, ilist_0[0].Length);
			if (bool_0)
			{
				int num2 = 1;
				while (true)
				{
					if (num2 < ilist_0.Count - 1)
					{
						int num3 = string_0.IndexOf(ilist_0[num2], StringComparison.OrdinalIgnoreCase);
						if (num3 < 0)
						{
							break;
						}
						matchResult.SetPositionRange(num3, ilist_0[num2].Length);
						num2++;
						continue;
					}
					matchResult.ComputeScore(ilist_0[0]);
					return matchResult;
				}
				return null;
			}
			int num4 = num + ilist_0[0].Length;
			int i;
			for (i = 1; i < ilist_0.Count && num4 <= string_0.Length - ilist_0[i].Length; i++)
			{
				int num5 = string_0.IndexOf(ilist_0[i], num4, StringComparison.OrdinalIgnoreCase);
				if (num5 >= 0)
				{
					num4 = num5 + ilist_0[i].Length;
					matchResult.SetPositionRange(num5, ilist_0[i].Length);
					continue;
				}
				return null;
			}
			if (i < ilist_0.Count)
			{
				return null;
			}
			matchResult.ComputeScore(ilist_0[0]);
			return matchResult;
		}
		return null;
	}

	public static MatchResult tECvNiwj10E(string string_0, string string_1, StringCharInfo stringCharInfo_0, bool bool_0)
	{
		if (stringCharInfo_0.HasMultiWords())
		{
			return js1vNlijlc0(string_0, stringCharInfo_0.Words, bool_0);
		}
		return niEvN36QmKR(string_0, string_1);
	}

	private static MatchResult niEvN36QmKR(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0) || string.IsNullOrEmpty(string_1))
		{
			return null;
		}
		int num = string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase);
		MatchResult matchResult;
		if (num >= 0)
		{
			matchResult = new MatchResult(string_0);
			if (num == 0)
			{
				if (r7tZSNcQORfKV9Qdpf9f == null)
				{
					switch (1)
					{
					case 1:
						break;
					default:
						goto IL_00e4;
					case 2:
						goto IL_0102;
					}
				}
				matchResult.SetMatchPositionsFromStart(string_1.Length);
				if (string_1.Length == string_0.Length)
				{
					if (string.Equals(string_0, string_1, StringComparison.Ordinal))
					{
						matchResult.Score = 1000;
					}
					else
					{
						matchResult.Score = 950;
					}
				}
				else
				{
					matchResult.Score = 800 + string_1.Length - string_0.Length;
				}
			}
			else
			{
				if (string_0[num - 1].IsLetter() && (!string_0[num].IsUpper() || !string_0[num - 1].IsLower()))
				{
					goto IL_00e4;
				}
				matchResult.SetMatchPositionsFromPosition(num, string_1.Length);
				matchResult.Score = 600 - num * 4 + string_1.Length - string_0.Length;
			}
			goto IL_0158;
		}
		return null;
		IL_0158:
		return matchResult;
		IL_00e4:
		int num2 = string_0.IndexOf(" " + string_1, num + 1, StringComparison.OrdinalIgnoreCase);
		if (num2 > 0)
		{
			num = num2 + 1;
		}
		goto IL_0102;
		IL_0102:
		matchResult.SetMatchPositionsFromPosition(num, string_1.Length);
		matchResult.Score = 300 - num * 4 + string_1.Length - string_0.Length;
		goto IL_0158;
	}

	public static MatchResult zDvvNfjfl2F(string string_0, string string_1, bool bool_0 = false)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			if (string_0.Length > 64)
			{
				string_0 = string_0.Substring(0, 64);
			}
			MatchResult matchResult = QUDvJtGZb6B(string_0, string_1);
			if (matchResult == null)
			{
				if (!IiXd3icQJrQh4tIvpu9U())
				{
					switch (0)
					{
					}
				}
				return null;
			}
			if (!bool_0)
			{
				MatchResult matchResult2 = niEvN36QmKR(string_0, string_1);
				if (matchResult2 != null)
				{
					return matchResult2;
				}
			}
			MatchResult matchResult3 = PKMvNzHXmS4(string_0, string_1);
			if (matchResult3 != null && matchResult3.IsMatch)
			{
				return matchResult3;
			}
			matchResult.UpdateSimpleMatchScore(string_1);
			return matchResult;
		}
		return null;
	}

	private static MatchResult PKMvNzHXmS4(string string_0, string string_1)
	{
        MatchResult matchResult = default;
		int i = 0;
		int num = 0;
		int num2 = 0;
		if (IiXd3icQJrQh4tIvpu9U())
		{
			goto IL_0016;
		}
		goto IL_00b2;
		IL_0016:
		matchResult = new MatchResult(string_0);
		goto IL_0032;
		IL_0032:
		while (true)
		{
			if (num < string_1.Length)
			{
				if (string_1[num] == ' ')
				{
					num++;
					continue;
				}
				for (; i < string_0.Length; i++)
				{
					if (WiLvJwOu759(string_0, i) && Helper.IsSameOrUpper(string_0[i], string_1[num]))
					{
						matchResult.SetPosition(i);
						i++;
						num++;
						break;
					}
				}
				if (num < string_1.Length)
				{
					break;
				}
			}
			matchResult.ComputeScoreAcronym(string_1);
			return matchResult;
		}
		num2 = 0;
		if (r7tZSNcQORfKV9Qdpf9f != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		goto IL_00b2;
		IL_00b2:
		switch (num2)
		{
		case 1:
			break;
		default:
			goto IL_00a6;
		}
		goto IL_0016;
		IL_00a6:
		if (i >= string_0.Length)
		{
			return null;
		}
		goto IL_0032;
	}

	private static bool WiLvJwOu759(string string_0, int int_0)
	{
		if (int_0 == 0)
		{
			return true;
		}
		if (int_0 > string_0.Length - 1)
		{
			return false;
		}
		char c = string_0[int_0];
		if (!char.IsLetter(c))
		{
			if (!PinyinConverter.IsValidCnChar(c))
			{
				return false;
			}
			return true;
		}
		char c2 = string_0[int_0 - 1];
		if (!char.IsLetter(c2))
		{
			int num = 0;
			if (!IiXd3icQJrQh4tIvpu9U())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => true, 
			};
		}
		if (char.IsUpper(c) && !char.IsUpper(c2))
		{
			return true;
		}
		return false;
	}

	public static MatchResult QUDvJtGZb6B(string string_0, string string_1)
	{
		int num = 0;
		int num2 = 0;
		MatchResult matchResult = new MatchResult(string_0);
		while (num < string_1.Length && num2 < string_0.Length)
		{
			if (string_1[num] == ' ')
			{
				num++;
			}
			else if (Helper.IsSameOrUpper(string_0[num2], string_1[num]))
			{
				matchResult.SetPosition(num2);
				num2++;
				num++;
			}
			else
			{
				num2++;
			}
		}
		if (num == string_1.Length)
		{
			if (r7tZSNcQORfKV9Qdpf9f == null)
			{
				switch (0)
				{
				}
			}
			matchResult.Score = 200;
			return matchResult;
		}
		return null;
	}

	internal static bool IiXd3icQJrQh4tIvpu9U()
	{
		return r7tZSNcQORfKV9Qdpf9f == null;
	}
}
