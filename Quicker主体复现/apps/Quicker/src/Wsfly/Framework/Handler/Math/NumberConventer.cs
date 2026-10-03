using System;
using System.Text.RegularExpressions;

namespace Wsfly.Framework.Handler.Math;

public class NumberConventer
{
	private static readonly string[] pfQLO9Vwwb;

	private static readonly string[] jOMLFUuYoQ;

	private static readonly string[] TCwLUcEyA9;

	private static readonly string[] H2FLlqpe3w;

	internal static NumberConventer IOR2tApJNJd27E8aSHw;

	public static string ArabToChn(decimal value, out string msg)
	{
		int num = 1;
		int num3 = default(int);
		long num5 = default(long);
		string text3 = default(string);
		string text4 = default(string);
		long num6 = default(long);
		string text5 = default(string);
		while (true)
		{
			string text = string.Empty;
			int num2 = 0;
			if (!ppTRA7pklMER5sFMI7S())
			{
				goto IL_027a;
			}
			goto IL_029a;
			IL_029a:
			switch (num2)
			{
			case 2:
				break;
			case 5:
				goto IL_0154;
			case 3:
				goto IL_0202;
			default:
				goto IL_027a;
			case 1:
				continue;
			case 4:
				goto end_IL_02b9;
			}
			goto IL_0128;
			IL_027a:
			text = ((value < 0m) ? "负" : "");
			goto IL_0202;
			IL_0128:
			num3++;
			goto IL_012e;
			IL_0154:
			int num4 = 0;
			num4 = Convert.ToInt32(num5 % 10000L);
			num5 /= 10000L;
			string text2 = text3;
			text3 = K5LLdbTc0m(num4);
			if (num3 == 0)
			{
				text4 = text3;
				text2 = text3;
			}
			if (num3 == 1)
			{
				if (text4 == "零")
				{
					text4 = string.Empty;
				}
				text4 = text3 + "万" + ((text2.IndexOf("千") != -1 || !(text2 != "零")) ? "" : "零") + text4;
			}
			if (num3 == 2)
			{
				if (text4.IndexOf("零万") != -1)
				{
					text4 = text4.Replace("零万", string.Empty);
				}
				text4 = text3 + "亿" + ((text2.IndexOf("千") != -1 || !(text2 != "零")) ? "" : "零") + text4;
			}
			if (num3 == 3)
			{
				if (text4.IndexOf("零亿") != -1)
				{
					text4 = text4.Replace("零亿", "亿");
				}
				text4 = text3 + "万" + ((text2.IndexOf("千") != -1 || !(text2 != "零")) ? "" : "零") + text4;
			}
			if (num3 != 4)
			{
				goto IL_0128;
			}
			if (text4.IndexOf("零万") != -1)
			{
				text4 = text4.Replace("零万", string.Empty);
			}
			text4 = text3 + "亿" + ((text2.IndexOf("千") != -1 || !(text2 != "零")) ? "" : "零") + text4;
			num2 = 2;
			if (!ppTRA7pklMER5sFMI7S())
			{
				num2 = num;
			}
			goto IL_029a;
			IL_012e:
			if (num3 > (num6.ToString().Length - 1) / 4)
			{
				text4 = text + text4 + text5;
				num = 4;
				break;
			}
			goto IL_0154;
			IL_0202:
			text4 = string.Empty;
			string[] array = value.ToString().Replace("-", string.Empty).Split('.');
			num5 = Convert.ToInt64(array[0]);
			num6 = num5;
			text5 = ((array.Length > 1) ? array[1] : string.Empty);
			if (array.Length > 1)
			{
				text5 = lM1LDl6k4A(text5);
			}
			text3 = string.Empty;
			text2 = string.Empty;
			num3 = 0;
			goto IL_012e;
			continue;
			end_IL_02b9:
			break;
		}
		msg = "成功转换！";
		return text4;
	}

	private static string lM1LDl6k4A(string string_4)
	{
		string text = "点";
		for (int i = 0; i < string_4.Length; i++)
		{
			text += jOMLFUuYoQ[Convert.ToInt32(string_4[i].ToString())];
		}
		for (int j = 0; j < text.Length; j++)
		{
			if (text[text.Length - j - 1].ToString() != "点")
			{
				if (text[text.Length - j - 1].ToString() != "零")
				{
					break;
				}
				if (ppTRA7pklMER5sFMI7S())
				{
					switch (0)
					{
					}
				}
			}
			text = text.Substring(0, text.Length - j - 1);
		}
		return text;
	}

	private static string K5LLdbTc0m(int int_0)
	{
		if (int_0 == 0)
		{
			return "零";
		}
		string text = string.Empty;
		bool flag = false;
		bool flag2 = false;
		int num = int_0;
		int length = int_0.ToString().Length;
		for (int i = 0; i < length; i++)
		{
			int num2 = num % 10;
			num /= 10;
			int num3 = 0;
			if (IOR2tApJNJd27E8aSHw == null)
			{
				goto IL_0046;
			}
			goto IL_0080;
			IL_0080:
			switch (num3)
			{
			case 2:
				break;
			case 1:
				goto IL_0094;
			default:
				continue;
			}
			goto IL_0046;
			IL_0046:
			if (i == 0)
			{
				if (num2 != 0)
				{
					text = jOMLFUuYoQ[num2];
					continue;
				}
				num3 = 1;
				if (!ppTRA7pklMER5sFMI7S())
				{
					goto IL_0094;
				}
			}
			else
			{
				if (num2 != 0)
				{
					text = jOMLFUuYoQ[num2] + H2FLlqpe3w[i] + text;
					flag = false;
					flag2 = false;
					continue;
				}
				if (!flag)
				{
					if (!flag2)
					{
						text = jOMLFUuYoQ[num2] + text;
						flag2 = true;
					}
					continue;
				}
				if (flag2)
				{
					continue;
				}
				text = jOMLFUuYoQ[num2] + text;
				flag2 = true;
				num3 = 0;
				if (IOR2tApJNJd27E8aSHw != null)
				{
					continue;
				}
			}
			goto IL_0080;
			IL_0094:
			flag = true;
			flag2 = true;
		}
		return text;
	}

	public static decimal ChnToArab(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return -1m;
		}
		decimal result = default(decimal);
		string text = value;
		int num3 = default(int);
		decimal num2 = default(decimal);
		string text3 = default(string);
		int num7 = default(int);
		while (true)
		{
			bool flag = false;
			string text2 = "";
			for (int i = 0; i < TCwLUcEyA9.Length; i++)
			{
				value = value.Replace(TCwLUcEyA9[i], jOMLFUuYoQ[i]);
			}
			int num = 0;
			if (!ppTRA7pklMER5sFMI7S())
			{
				goto IL_018c;
			}
			goto IL_01ad;
			IL_01ad:
			while (true)
			{
				switch (num)
				{
				case 3:
					num3 = 0;
					goto IL_0080;
				case 2:
					text2 = text2.Replace(jOMLFUuYoQ[num3], pfQLO9Vwwb[num3]);
					num3++;
					goto IL_0080;
				default:
					text = value;
					if (Regex.IsMatch(value, "^[零|一|二|三|四|五|六|七|八|九]*$"))
					{
						text2 = value;
						goto case 3;
					}
					goto IL_0092;
				case 4:
					break;
				case 1:
				{
					string[] array = text3.Split(',');
					return (decimal)((!flag) ? 1 : (-1)) * (JtfLoJsbnu(array[0]) * 10000000000000000m + JtfLoJsbnu(array[1]) * 100000000m + JtfLoJsbnu(array[2])) + num2;
				}
				case 5:
					goto IL_02ce;
					IL_0080:
					if (num3 < 10)
					{
						goto case 2;
					}
					if (RegexHandler.IsNumber(text2))
					{
						return decimal.Parse(text2);
					}
					goto IL_0092;
				}
				break;
				IL_02ce:
				int num4 = 1;
				goto IL_02cf;
				IL_0092:
				if (value.IndexOf("负") != -1)
				{
					flag = true;
					text = text.Replace("负", string.Empty);
				}
				text3 = string.Empty;
				text = text.Replace("点", ".");
				string[] array2 = text.Split('.');
				text3 = array2[0];
				num2 = default(decimal);
				if (array2.Length > 1)
				{
					num2 = dx1LTfcIA9(array2[1]);
				}
				int num5 = 0;
				int num6 = 0;
				while (num6 < text3.Length && text3.IndexOf("亿", num6) != -1)
				{
					num5++;
					num6 = text3.IndexOf("亿", num6) + 1;
				}
				if (num5 == 2)
				{
					text3 = text3.Replace("亿", ",");
					num = 1;
					if (ppTRA7pklMER5sFMI7S())
					{
						continue;
					}
				}
				else
				{
					if (num5 == 1)
					{
						text3 = text3.Replace("亿", ",");
						string[] array3 = text3.Split(',');
						return (decimal)((!flag) ? 1 : (-1)) * (JtfLoJsbnu(array3[0]) * 100000000m + JtfLoJsbnu(array3[1])) + num2;
					}
					if (num5 != 0)
					{
						return result;
					}
					if (flag)
					{
						num4 = -1;
						goto IL_02cf;
					}
					num = 5;
					if (IOR2tApJNJd27E8aSHw == null)
					{
						continue;
					}
				}
				goto IL_018c;
				IL_02cf:
				return (decimal)num4 * JtfLoJsbnu(text3) + num2;
			}
			continue;
			IL_018c:
			num = num7;
			goto IL_01ad;
		}
	}

	private static decimal JtfLoJsbnu(string string_4)
	{
		decimal result = default(decimal);
		string[] array = string_4.Replace("万", ",").Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			result += Convert.ToDecimal(HNBLM2r8Qb(array[array.Length - i - 1])) * Convert.ToDecimal(System.Math.Pow(10000.0, Convert.ToDouble(i)));
		}
		return result;
	}

	private static decimal dx1LTfcIA9(string string_4)
	{
		string text = "0.";
		for (int i = 0; i < string_4.Length; i++)
		{
			text += jB5LAm7YBT(string_4[i].ToString());
		}
		return Convert.ToDecimal(text);
	}

	private static int HNBLM2r8Qb(string string_4)
	{
		int num = 1;
		while (true)
		{
			string text = string_4;
			int num2 = 0;
			if (!ppTRA7pklMER5sFMI7S())
			{
				goto IL_0034;
			}
			goto IL_0038;
			IL_0038:
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				default:
					if (!(text == "零"))
					{
						if (text != string.Empty)
						{
							goto IL_0027;
						}
						goto IL_008a;
					}
					return 0;
				case 1:
					break;
				case 2:
					{
						if (text[0].ToString() == "十")
						{
							text = "一" + text;
						}
						goto IL_008a;
					}
					IL_008a:
					text = text.Replace("零", string.Empty);
					num3 = 0;
					num4 = text.IndexOf("千");
					if (num4 != -1)
					{
						num3 += jB5LAm7YBT(text.Substring(0, num4)) * 1000;
						text = text.Remove(0, num4 + 1);
					}
					num4 = text.IndexOf("百");
					if (num4 != -1)
					{
						num3 += jB5LAm7YBT(text.Substring(0, num4)) * 100;
						text = text.Remove(0, num4 + 1);
					}
					num4 = text.IndexOf("十");
					if (num4 != -1)
					{
						num3 += jB5LAm7YBT(text.Substring(0, num4)) * 10;
						text = text.Remove(0, num4 + 1);
					}
					if (text != string.Empty)
					{
						num3 += jB5LAm7YBT(text);
					}
					return num3;
				}
				break;
				IL_0027:
				num2 = 2;
				if (IOR2tApJNJd27E8aSHw == null)
				{
					continue;
				}
				goto IL_0034;
			}
			continue;
			IL_0034:
			num2 = num;
			goto IL_0038;
		}
	}

	private static int jB5LAm7YBT(string string_4)
	{
		if (string_4 != null)
		{
			int length = string_4.Length;
			if (length == 1)
			{
				int num = 1;
				if (!ppTRA7pklMER5sFMI7S())
				{
					int num2 = default(int);
					num = num2;
				}
				char c = default(char);
				switch (num)
				{
				case 1:
					c = string_4[0];
					if ((uint)c <= 20108u)
					{
						switch (c)
						{
						case '二':
							return 2;
						case '九':
							return 9;
						case '三':
							return 3;
						case '七':
							return 7;
						case '一':
							return 1;
						}
						break;
					}
					goto default;
				default:
					switch (c)
					{
					case '八':
						return 8;
					case '五':
						return 5;
					case '零':
						return 0;
					case '四':
						return 4;
					case '六':
						return 6;
					}
					break;
				}
			}
		}
		return -1;
	}

	static NumberConventer()
	{
		pfQLO9Vwwb = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
		jOMLFUuYoQ = new string[15]
		{
			"零", "一", "二", "三", "四", "五", "六", "七", "八", "九",
			"十", "百", "千", "万", "亿"
		};
		TCwLUcEyA9 = new string[15]
		{
			"零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖",
			"拾", "佰", "仟", "萬", "亿"
		};
		H2FLlqpe3w = new string[4] { "", "十", "百", "千" };
	}

	internal static bool ppTRA7pklMER5sFMI7S()
	{
		return IOR2tApJNJd27E8aSHw == null;
	}

	internal static void kZPucXpLKYdEHklk0SN()
	{
	}
}
