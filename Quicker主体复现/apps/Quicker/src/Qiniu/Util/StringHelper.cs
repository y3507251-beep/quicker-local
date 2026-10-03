using System;
using System.Collections.Generic;
using System.Text;

namespace Qiniu.Util;

public class StringHelper
{
	private static readonly Dictionary<char, bool> FoYekugqSd;

	internal static StringHelper X9s8Z1LaZF9CxFla3OJ;

	public static string UrlEncode(string text)
	{
		return Uri.EscapeDataString(text);
	}

	public static string UrlFormEncode(Dictionary<string, string> values)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, string> value in values)
		{
			stringBuilder.AppendFormat("{0}={1}&", Uri.EscapeDataString(value.Key), Uri.EscapeDataString(value.Value));
		}
		string text = stringBuilder.ToString();
		return text.Substring(0, text.Length - 1);
	}

	private static bool Jk6eW997vh(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				char key = string_0[num];
				if (!FoYekugqSd.ContainsKey(key))
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

	public static string CanonicalMimeHeaderKey(string fieldName)
	{
		if (!Jk6eW997vh(fieldName))
		{
			return fieldName;
		}
		string text = "";
		bool flag = true;
		char c;
		int num2 = default(int);
		for (int i = 0; i < fieldName.Length; flag = c == '-', i++)
		{
			c = fieldName[i];
			if (flag)
			{
				if ('a' > c)
				{
					goto IL_009a;
				}
				int num = 1;
				if (!bueWuKLrvx3MXbgBcmO())
				{
					num = num2;
				}
				switch (num)
				{
				case 1:
					goto IL_0079;
				}
			}
			if ('A' <= c && c <= 'Z')
			{
				text += char.ToLower(c);
				continue;
			}
			goto IL_009a;
			IL_009a:
			text += c;
			continue;
			IL_0079:
			if (c <= 'z')
			{
				text += char.ToUpper(c);
				continue;
			}
			goto IL_009a;
		}
		return text;
	}

	static StringHelper()
	{
		FoYekugqSd = new Dictionary<char, bool>
		{
			{ '!', true },
			{ '#', true },
			{ '$', true },
			{ '%', true },
			{ '&', true },
			{ '\\', true },
			{ '*', true },
			{ '+', true },
			{ '-', true },
			{ '.', true },
			{ '0', true },
			{ '1', true },
			{ '2', true },
			{ '3', true },
			{ '4', true },
			{ '5', true },
			{ '6', true },
			{ '7', true },
			{ '8', true },
			{ '9', true },
			{ 'A', true },
			{ 'B', true },
			{ 'C', true },
			{ 'D', true },
			{ 'E', true },
			{ 'F', true },
			{ 'G', true },
			{ 'H', true },
			{ 'I', true },
			{ 'J', true },
			{ 'K', true },
			{ 'L', true },
			{ 'M', true },
			{ 'N', true },
			{ 'O', true },
			{ 'P', true },
			{ 'Q', true },
			{ 'R', true },
			{ 'S', true },
			{ 'T', true },
			{ 'U', true },
			{ 'W', true },
			{ 'V', true },
			{ 'X', true },
			{ 'Y', true },
			{ 'Z', true },
			{ '^', true },
			{ '_', true },
			{ '`', true },
			{ 'a', true },
			{ 'b', true },
			{ 'c', true },
			{ 'd', true },
			{ 'e', true },
			{ 'f', true },
			{ 'g', true },
			{ 'h', true },
			{ 'i', true },
			{ 'j', true },
			{ 'k', true },
			{ 'l', true },
			{ 'm', true },
			{ 'n', true },
			{ 'o', true },
			{ 'p', true },
			{ 'q', true },
			{ 'r', true },
			{ 's', true },
			{ 't', true },
			{ 'u', true },
			{ 'v', true },
			{ 'w', true },
			{ 'x', true },
			{ 'y', true },
			{ 'z', true },
			{ '|', true },
			{ '~', true }
		};
	}

	internal static bool bueWuKLrvx3MXbgBcmO()
	{
		return X9s8Z1LaZF9CxFla3OJ == null;
	}

	internal static void nktC7sLujpcYJIVJRdF()
	{
	}
}
