using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Quicker.Pinyin;

public static class SentenceSplitter
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass0_0
	{
		public string SET28IZkmhI;

		public int ysn28WjMbii;
	}

	internal static object EmyHZycFYwjER3e3AZki;

	public static IList<Word> SplitSentence(string text)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_0_ = default(_003C_003Ec__DisplayClass0_0);
		_003C_003Ec__DisplayClass0_0_.SET28IZkmhI = text;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass0_0_.SET28IZkmhI))
		{
			return Array.Empty<Word>();
		}
		IList<Word> list = new List<Word>(_003C_003Ec__DisplayClass0_0_.SET28IZkmhI.Length);
		int num = 0;
		_003C_003Ec__DisplayClass0_0_.ysn28WjMbii = Math.Min(_003C_003Ec__DisplayClass0_0_.SET28IZkmhI.Length, int.MaxValue);
		while (num < _003C_003Ec__DisplayClass0_0_.ysn28WjMbii)
		{
			switch (_003C_003Ec__DisplayClass0_0_.SET28IZkmhI[num].GetCharType())
			{
			default:
				num++;
				break;
			case CharType.LowerChar:
			{
				int num3 = XQsv02usmqC(num + 1, ref _003C_003Ec__DisplayClass0_0_) - num + 1;
				list.Add(new Word(num, num3, false, _003C_003Ec__DisplayClass0_0_.SET28IZkmhI));
				num += num3;
				break;
			}
			case CharType.UpperChar:
			{
				int num2 = srhv0uVjGlo(num + 1, ref _003C_003Ec__DisplayClass0_0_) - num + 1;
				list.Add(new Word(num, num2, false, _003C_003Ec__DisplayClass0_0_.SET28IZkmhI));
				num += num2;
				break;
			}
			case CharType.Cn:
				list.Add(new Word(num, 1, true, _003C_003Ec__DisplayClass0_0_.SET28IZkmhI));
				num++;
				break;
			}
		}
		return list;
	}

	public static CharType GetCharType(this char ch)
	{
		if (ch >= 'a' && ch <= 'z')
		{
			return CharType.LowerChar;
		}
		if (ch >= 'A' && ch <= 'Z')
		{
			return CharType.UpperChar;
		}
		if (ch >= '一' && ch <= '鿿')
		{
			return CharType.Cn;
		}
		return CharType.Na;
	}

	[CompilerGenerated]
	internal static int XQsv02usmqC(int int_0, ref _003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_0_0)
	{
		int i;
		for (i = int_0; i < _003C_003Ec__DisplayClass0_0_0.ysn28WjMbii && _003C_003Ec__DisplayClass0_0_0.SET28IZkmhI[i].GetCharType() == CharType.LowerChar; i++)
		{
		}
		return i - 1;
	}

	[CompilerGenerated]
	internal static int srhv0uVjGlo(int int_0, ref _003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_0_0)
	{
		bool flag = false;
		int i;
		for (i = int_0; i < _003C_003Ec__DisplayClass0_0_0.ysn28WjMbii; i++)
		{
			switch (_003C_003Ec__DisplayClass0_0_0.SET28IZkmhI[i].GetCharType())
			{
			case CharType.UpperChar:
				if (flag)
				{
					return i - 1;
				}
				break;
			case CharType.LowerChar:
				flag = true;
				if (sGmlS0cF8VDei1x02rxL())
				{
					switch (0)
					{
					}
				}
				break;
			default:
				return i - 1;
			}
		}
		return i - 1;
	}

	internal static bool sGmlS0cF8VDei1x02rxL()
	{
		return EmyHZycFYwjER3e3AZki == null;
	}
}
