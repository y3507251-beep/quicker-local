namespace Quicker.Common.Utils.Extensions;

public static class StringExtensions
{
	public static bool HasCn(this string text)
	{
		foreach (char c in text)
		{
			if (c >= '一' && c <= '龻')
			{
				return true;
			}
		}
		return false;
	}

	public static bool HasNonEnChar(this string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] >= 'က')
			{
				return true;
			}
		}
		return false;
	}
}
