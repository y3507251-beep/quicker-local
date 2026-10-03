using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using Quicker.Public.Extensions;

namespace Quicker.Utilities.Ext;

public static class StringExt
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Bp82NJ4ojSa;

		public static Func<string, int> en62N0jP6So;

		public static Func<string, bool> KiX2NCiIsfq;

		internal static _003C_003Ec fQkRi1yKHrV3vjZYwNBe;

		static _003C_003Ec()
		{
			Bp82NJ4ojSa = new _003C_003Ec();
		}

		internal int ko32NuhOP0M(string str)
		{
			return Convert.ToInt32(str.Trim());
		}

		internal bool O5G2NNZyny0(string x)
		{
			return !string.IsNullOrWhiteSpace(x);
		}

		internal static bool UbvS8iyKzh5KG7vprTDS()
		{
			return fQkRi1yKHrV3vjZYwNBe == null;
		}
	}

	internal static object UAVTp5FxRHRr54QDmtfZ;

	public static string ConvertInvisibleChars(this string input)
	{
		if (input == null)
		{
			return "*NULL*";
		}
		StringBuilder stringBuilder = new StringBuilder(input.Length + 10);
		int num = 0;
		while (num < input.Length)
		{
			char c = input[num];
			int num2;
			switch (c)
			{
			default:
				num2 = 1;
				if (UAVTp5FxRHRr54QDmtfZ != null)
				{
					goto IL_00e7;
				}
				goto IL_0108;
			case '\0':
				stringBuilder.Append("⍀0");
				goto IL_013e;
			case '\a':
				stringBuilder.Append("⍀a");
				goto IL_013e;
			case '\b':
				stringBuilder.Append("⍀b");
				goto IL_013e;
			case '\t':
				stringBuilder.Append("⍀t");
				goto IL_013e;
			case '\v':
				stringBuilder.Append("⍀v");
				goto IL_013e;
			case '\f':
				stringBuilder.Append("⍀f");
				goto IL_013e;
			case '\r':
				stringBuilder.Append("⍀r");
				goto IL_013e;
			case '\n':
				stringBuilder.Append("⍀n\n");
				goto IL_013e;
			case '\u0001':
			case '\u0002':
			case '\u0003':
			case '\u0004':
			case '\u0005':
			case '\u0006':
				goto IL_0108;
				IL_00e7:
				switch (num2)
				{
				case 1:
					break;
				case 2:
					goto IL_0108;
				default:
					goto end_IL_002a;
				}
				goto case '\n';
				IL_0108:
				if (char.GetUnicodeCategory(c) != UnicodeCategory.Control)
				{
					stringBuilder.Append(c);
				}
				else
				{
					stringBuilder.Append("⍀u");
					ushort num3 = c;
					stringBuilder.Append(num3.ToString("x4"));
				}
				goto IL_013e;
				IL_013e:
				num++;
				num2 = 0;
				if (UAVTp5FxRHRr54QDmtfZ != null)
				{
					break;
				}
				goto IL_00e7;
				end_IL_002a:
				break;
			}
		}
		return stringBuilder.ToString();
	}

	public static MemoryStream ToMemoryStream(this string str)
	{
		MemoryStream memoryStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(memoryStream);
		streamWriter.Write(str);
		streamWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream;
	}

	public static bool ListStringContains(this string listString, string seperator, string item, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
	{
		if (string.IsNullOrEmpty(listString))
		{
			return false;
		}
		if (!string.Equals(listString, item, stringComparison) && !listString.StartsWith(item + seperator, stringComparison) && !listString.EndsWith(seperator + item, stringComparison))
		{
			return listString.IndexOf(seperator + item + seperator, stringComparison) >= 0;
		}
		return true;
	}

	public static long CountLines(this string s)
	{
		if (string.IsNullOrWhiteSpace(s))
		{
			return 0L;
		}
		long num = 1L;
		int startIndex = 0;
		while ((startIndex = s.IndexOf('\n', startIndex)) != -1)
		{
			num++;
			startIndex++;
		}
		return num;
	}

	public static string ReduceLine(this string s, int maxLine)
	{
		if (string.IsNullOrWhiteSpace(s))
		{
			return s;
		}
		long num = 1L;
		int num2 = 0;
		do
		{
			if ((num2 = s.IndexOf('\n', num2)) != -1)
			{
				num++;
				num2++;
				continue;
			}
			return s;
		}
		while (num <= maxLine);
		return s.Substring(0, num2) + "...";
	}

	public static bool ContainedInAnyStrings(this string filter, IEnumerable<string> values)
	{
		if (string.IsNullOrEmpty(filter))
		{
			return true;
		}
		if (values == null)
		{
			return false;
		}
		foreach (string value in values)
		{
			if (!string.IsNullOrEmpty(value) && value.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1)
			{
				return true;
			}
		}
		return false;
	}

	public static bool ContainedInAny(this string filter, params string[] values)
	{
		return filter.ContainedInAnyStrings(values);
	}

	public static string RemoveNewLine(this string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return "";
		}
		return value.Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ");
	}

	public static IList<int> StringToIntList(this string value, params char[] splitter)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return new List<int>();
		}
		return value.Split(splitter).Select(_003C_003Ec.en62N0jP6So ?? (_003C_003Ec.en62N0jP6So = _003C_003Ec.Bp82NJ4ojSa.ko32NuhOP0M)).ToList();
	}

	public static string FirstNotEmptyString(params string[] strings)
	{
		return strings.FirstOrDefault(_003C_003Ec.KiX2NCiIsfq ?? (_003C_003Ec.KiX2NCiIsfq = _003C_003Ec.Bp82NJ4ojSa.O5G2NNZyny0)) ?? "";
	}

	public static bool OrdinalStartWith(this string value, string start, bool ignoreCase = false)
	{
		if (string.IsNullOrEmpty(value))
		{
			return false;
		}
		return value.StartsWith(start, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
	}

	public static string GetLastLine(this string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return string.Empty;
		}
		string[] array = text.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 0)
		{
			return array[array.Length - (1)];
		}
		return string.Empty;
	}

	public static string ToValidFileName(this string fileName)
	{
		if (!string.IsNullOrEmpty(fileName))
		{
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			return string.Join("_", fileName.Split(invalidFileNameChars, StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
		}
		return string.Empty;
	}

	public static Thickness ToThickness(this string str)
	{
		string[] array = str.Trim().SplitToList(',', '，');
		return array.Length switch
		{
			1 => new Thickness(Convert.ToDouble(array[0])), 
			2 => new Thickness(Convert.ToDouble(array[0]), Convert.ToDouble(array[1]), Convert.ToDouble(array[0]), Convert.ToDouble(array[1])), 
			3 => new Thickness(Convert.ToDouble(array[0]), Convert.ToDouble(array[1]), Convert.ToDouble(array[0]), Convert.ToDouble(array[2])), 
			4 => new Thickness(Convert.ToDouble(array[0]), Convert.ToDouble(array[1]), Convert.ToDouble(array[2]), Convert.ToDouble(array[3])), 
			_ => throw new ArgumentException("参数格式错误。当前值：" + str), 
		};
	}

	internal static bool lNnqsuFxgB9tNjNJIWdq()
	{
		return UAVTp5FxRHRr54QDmtfZ == null;
	}
}
