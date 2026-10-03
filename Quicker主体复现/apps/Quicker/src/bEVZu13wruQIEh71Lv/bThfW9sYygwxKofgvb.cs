using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace bEVZu13wruQIEh71Lv;

internal static class bThfW9sYygwxKofgvb
{
	private static IDictionary<string, string> n8USixVDky;

	internal static object nUtmqUnbHBM6dqu7FxW;

	public static string gYvSAdEbM1(IEnumerable<KeyValuePair<string, string>> ienumerable_0)
	{
		bool flag = true;
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, string> item in ienumerable_0)
		{
			if (!flag)
			{
				stringBuilder.Append("&");
			}
			flag = false;
			stringBuilder.Append(item.Key);
			if (!string.IsNullOrEmpty(item.Value))
			{
				stringBuilder.Append("=").Append(RxiSOGgt5P(item.Value, "utf-8"));
			}
		}
		return stringBuilder.ToString();
	}

	public static string RxiSOGgt5P(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(string_0.Length * 2);
		byte[] bytes = Encoding.GetEncoding(string_1).GetBytes(string_0);
		int num = 0;
		int num3 = default(int);
		while (num < bytes.Length)
		{
			byte b = bytes[num];
			char value = (char)b;
			if ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~".IndexOf(value) != -1)
			{
				stringBuilder.Append(value);
			}
			else
			{
				stringBuilder.Append("%").Append(string.Format(CultureInfo.InvariantCulture, "{0:X2}", (int)b));
			}
			num++;
			int num2 = 0;
			if (nUtmqUnbHBM6dqu7FxW != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return stringBuilder.ToString();
	}

	public static string i1NSFKMiqH(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			string_0 = string_0.Replace("+", " ");
			return Uri.UnescapeDataString(string_0);
		}
		return string.Empty;
	}

	public static string HL3SU7I8wV(string string_0, string string_1, string string_2)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		byte[] bytes = Encoding.GetEncoding(string_1).GetBytes(string_0);
		return Encoding.GetEncoding(string_2).GetString(bytes);
	}

	public static string wmwSlvuarn(string string_0, string string_1)
	{
		string text = "";
		if (string_1 != null)
		{
			text = Path.GetExtension(string_1);
		}
		else if (string_0 != null)
		{
			text = Path.GetExtension(string_0);
		}
		text = text.Trim().TrimStart('.');
		if (n8USixVDky.ContainsKey(text))
		{
			return n8USixVDky[text];
		}
		return "application/octet-stream";
	}

	static bThfW9sYygwxKofgvb()
	{
		n8USixVDky = new Dictionary<string, string>();
	}

	internal static bool FZc7IZnqBSmD1hJN3aU()
	{
		return nUtmqUnbHBM6dqu7FxW == null;
	}
}
