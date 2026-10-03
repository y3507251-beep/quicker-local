using System.Runtime.CompilerServices;

namespace Quicker.Utilities.Pinyin;

public static class Helper
{
	internal static object OqUMQYcQfjOqjl0Q2Vxv;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUpper(this char c)
	{
		if (c >= 'A')
		{
			return c <= 'Z';
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsLower(this char c)
	{
		if (c >= 'a')
		{
			return c <= 'z';
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsLetter(this char c)
	{
		if (!c.IsLower())
		{
			return c.IsUpper();
		}
		return true;
	}

	public static string FasterToLower(this string str)
	{
		char[] array = str.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			char c = array[i];
			if (!g8ZInUcQbDQAQyrGwof6())
			{
				switch (0)
				{
				}
			}
			if (c >= 'A' && c <= 'Z')
			{
				array[i] = (char)(c + 32);
			}
		}
		return new string(array);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsSameOrUpper(char chText, char chPattern)
	{
		if (chText != chPattern)
		{
			if (char.IsUpper(chText))
			{
				return chPattern - chText == 32;
			}
			return false;
		}
		return true;
	}

	internal static bool g8ZInUcQbDQAQyrGwof6()
	{
		return OqUMQYcQfjOqjl0Q2Vxv == null;
	}
}
