using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using hXDavOirme1AwsCgjN8;
using KQO9uLiG7YA2tI9UZIp;
using lJsvs7ip57bV5TNX85f;
using meIeTbizCbW99JOJhvl;
using s1H993mqNCkpDdM1vC5;

namespace Quicker.Utilities.Pinyin;

internal class Splitter
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass1_0
	{
		public short jG3289yGJNh;

		public CharType wpQ28hN4xYe;

		public List<IJ4vWZmlHsi92DoGSsc> b1s28eCoLyJ;
	}

	private static IDictionary<string, List<IJ4vWZmlHsi92DoGSsc>> d9FvJPAiXp9;

	internal static Splitter nQWYZXcQi6ReFSXxBrlX;

	public static IList<IJ4vWZmlHsi92DoGSsc> fEIvJJC9yN7(string string_0, StringCharInfo stringCharInfo_0, bool bool_0 = true)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_0_ = default(_003C_003Ec__DisplayClass1_0);
		if (bool_0 && d9FvJPAiXp9.TryGetValue(string_0, out _003C_003Ec__DisplayClass1_0_.b1s28eCoLyJ))
		{
			return _003C_003Ec__DisplayClass1_0_.b1s28eCoLyJ;
		}
		_003C_003Ec__DisplayClass1_0_.b1s28eCoLyJ = new List<IJ4vWZmlHsi92DoGSsc>(stringCharInfo_0.AllCn ? string_0.Length : (string_0.Length / 2));
		short num = 0;
		_003C_003Ec__DisplayClass1_0_.wpQ28hN4xYe = CharType.None;
		_003C_003Ec__DisplayClass1_0_.jG3289yGJNh = -1;
		while (num < string_0.Length)
		{
			CharType charType = F6PvJ0mTZy5(string_0[num]);
			switch (charType)
			{
			case CharType.Lower:
				if (_003C_003Ec__DisplayClass1_0_.wpQ28hN4xYe != CharType.Upper && _003C_003Ec__DisplayClass1_0_.wpQ28hN4xYe != CharType.Lower)
				{
					dpCvJCu5Aic(num, ref _003C_003Ec__DisplayClass1_0_);
					_003C_003Ec__DisplayClass1_0_.jG3289yGJNh = num;
				}
				break;
			case CharType.Upper:
				if (_003C_003Ec__DisplayClass1_0_.wpQ28hN4xYe != CharType.Upper)
				{
					dpCvJCu5Aic(num, ref _003C_003Ec__DisplayClass1_0_);
					_003C_003Ec__DisplayClass1_0_.jG3289yGJNh = num;
				}
				break;
			case CharType.Number:
				if (_003C_003Ec__DisplayClass1_0_.wpQ28hN4xYe != charType)
				{
					dpCvJCu5Aic(num, ref _003C_003Ec__DisplayClass1_0_);
					_003C_003Ec__DisplayClass1_0_.jG3289yGJNh = num;
				}
				break;
			case CharType.Cn:
				dpCvJCu5Aic(num, ref _003C_003Ec__DisplayClass1_0_);
				_003C_003Ec__DisplayClass1_0_.b1s28eCoLyJ.Add(new pO9W35iCY0iier0aptY(string_0, num));
				break;
			case CharType.Space:
				dpCvJCu5Aic(num, ref _003C_003Ec__DisplayClass1_0_);
				break;
			case CharType.Other:
				if (_003C_003Ec__DisplayClass1_0_.wpQ28hN4xYe != CharType.Other)
				{
					dpCvJCu5Aic(num, ref _003C_003Ec__DisplayClass1_0_);
					_003C_003Ec__DisplayClass1_0_.jG3289yGJNh = num;
				}
				break;
			}
			num++;
			_003C_003Ec__DisplayClass1_0_.wpQ28hN4xYe = charType;
		}
		dpCvJCu5Aic(num, ref _003C_003Ec__DisplayClass1_0_);
		if (bool_0)
		{
			d9FvJPAiXp9[string_0] = _003C_003Ec__DisplayClass1_0_.b1s28eCoLyJ;
		}
		return _003C_003Ec__DisplayClass1_0_.b1s28eCoLyJ;
	}

	public static CharType F6PvJ0mTZy5(char char_0)
	{
		if (char_0 >= 'a')
		{
			if (char_0 >= '㐀')
			{
				if (char_0 <= '龥')
				{
					return CharType.Cn;
				}
			}
			else if (char_0 <= 'z')
			{
				return CharType.Lower;
			}
		}
		else if (char_0 >= 'A')
		{
			if (char_0 <= 'Z')
			{
				return CharType.Upper;
			}
		}
		else if (char_0 >= '0')
		{
			if (char_0 <= '9')
			{
				return CharType.Number;
			}
		}
		else
		{
			if (char_0 == '\t' || char_0 == ' ')
			{
				return CharType.Space;
			}
			int num = 0;
			if (nQWYZXcQi6ReFSXxBrlX != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return CharType.Other;
	}

	static Splitter()
	{
		d9FvJPAiXp9 = new ConcurrentDictionary<string, List<IJ4vWZmlHsi92DoGSsc>>();
	}

	[CompilerGenerated]
	internal static void dpCvJCu5Aic(short short_0, ref _003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_0_0)
	{
		while (_003C_003Ec__DisplayClass1_0_0.jG3289yGJNh != -1)
		{
			if (DpjxpecQlHgfmLYkGdVK())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			IJ4vWZmlHsi92DoGSsc iJ4vWZmlHsi92DoGSsc = null;
			switch (_003C_003Ec__DisplayClass1_0_0.wpQ28hN4xYe)
			{
			case CharType.Lower:
			case CharType.Upper:
				iJ4vWZmlHsi92DoGSsc = new Fsoux9iadulW3v3wB1p(_003C_003Ec__DisplayClass1_0_0.jG3289yGJNh, (short)(short_0 - _003C_003Ec__DisplayClass1_0_0.jG3289yGJNh));
				break;
			case CharType.Number:
				iJ4vWZmlHsi92DoGSsc = new Yya5KtiICVV8386j0nE(_003C_003Ec__DisplayClass1_0_0.jG3289yGJNh, (short)(short_0 - _003C_003Ec__DisplayClass1_0_0.jG3289yGJNh));
				break;
			default:
				throw new InvalidDataException("不应该出现的字符类型。");
			case CharType.Other:
				iJ4vWZmlHsi92DoGSsc = new YBG0v3iLgdjLC2Y9pZR(_003C_003Ec__DisplayClass1_0_0.jG3289yGJNh, (short)(short_0 - _003C_003Ec__DisplayClass1_0_0.jG3289yGJNh));
				break;
			}
			_003C_003Ec__DisplayClass1_0_0.b1s28eCoLyJ.Add(iJ4vWZmlHsi92DoGSsc);
			_003C_003Ec__DisplayClass1_0_0.jG3289yGJNh = -1;
			break;
		}
	}

	internal static bool DpjxpecQlHgfmLYkGdVK()
	{
		return nQWYZXcQi6ReFSXxBrlX == null;
	}
}
