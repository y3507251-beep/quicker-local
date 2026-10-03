using System;
using System.Text.RegularExpressions;

namespace Wsfly.Framework.Handler.Math;

public class RegexHandler
{
	internal static RegexHandler HSRZZXpuh2O8BvfjZvB;

	public static bool IsValidByte(string value, int minSize, int maxSize)
	{
		return Regex.IsMatch(value, "^[a-zA-Z0-9_]{" + minSize + "," + maxSize + "}$");
	}

	public static bool IsValidPostfix(string value)
	{
		return Regex.IsMatch(value, "\\.(?i:gif|jpg|png|bmp|icon)$", RegexOptions.IgnoreCase);
	}

	public static bool NoneSpecialChar(string source)
	{
		return Regex.IsMatch(source, "^[a-zA-Z0-9]+$");
	}

	public static bool IsColor(string source)
	{
		return Regex.IsMatch(source, "^#?([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$");
	}

	public static bool IsInt(object val)
	{
		try
		{
			string text = val.ToString();
			if (!string.IsNullOrEmpty(text))
			{
				int num = 0;
				if (HSRZZXpuh2O8BvfjZvB != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (!string.IsNullOrEmpty(text.Trim()))
				{
					if (new Regex("^[+|-]{0,1}\\d+$").Match(text).Success)
					{
						if (long.Parse(text) <= 2147483647L && long.Parse(text) >= -2147483648L)
						{
							return true;
						}
						return false;
					}
					return false;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool IsNumber(string source)
	{
		try
		{
			return Regex.IsMatch(source, "^\\d+$");
		}
		catch
		{
			return false;
		}
	}

	public static bool HasNumber(string source)
	{
		try
		{
			return Regex.IsMatch(source, "\\d+");
		}
		catch
		{
			return false;
		}
	}

	public static bool IsFloat(string value)
	{
		try
		{
			return Regex.IsMatch(value, "^[+|-]?\\d*\\.?\\d*$");
		}
		catch
		{
			return false;
		}
	}

	public static bool IsEmail(string source)
	{
		return Regex.IsMatch(source, "^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A-Za-z]{2,})$", RegexOptions.IgnoreCase);
	}

	public static bool HasEmail(string source)
	{
		return Regex.IsMatch(source, "[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A-Za-z]{2,})", RegexOptions.IgnoreCase);
	}

	public static bool IsUrl(string source)
	{
		return Regex.IsMatch(source, "^(((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp)://)|(www\\.))+(([a-zA-Z0-9\\._-]+\\.[a-zA-Z]{2,6})|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(/[a-zA-Z0-9\\&amp;%_\\./-~-]*)?$", RegexOptions.IgnoreCase);
	}

	public static bool HasUrl(string source)
	{
		return Regex.IsMatch(source, "(((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp)://)|(www\\.))+(([a-zA-Z0-9\\._-]+\\.[a-zA-Z]{2,6})|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(/[a-zA-Z0-9\\&amp;%_\\./-~-]*)?", RegexOptions.IgnoreCase);
	}

	public static bool IsDateTime(string source)
	{
		return Regex.IsMatch(source, "^2\\d{3}-(?:0?[1-9]|1[0-2])-(?:0?[1-9]|[1-2]\\d|3[0-1])\\s+(?:0?[1-9]|1\\d|2[0-3]):(?:0?[1-9]|[1-5]\\d):(?:0?[1-9]|[1-5]\\d)$");
	}

	public static bool IsValidDateTime(string source)
	{
		return Regex.IsMatch(source, "^(19|20)\\d{2}[/\\s\\-\\.]*(0[1-9]|1[0-2]|[1-9])[/\\s\\-\\.]*(0[1-9]|3[01]|[12][0-9]|[1-9])[\\s] *(2[0-3]|[01]?\\d)(:[0-5]\\d){0,2}$");
	}

	public static bool IsDate(string source)
	{
		return Regex.IsMatch(source, "^((((1[6-9]|[2-9]\\d)\\d{2})[-|/]+(0?[13578]|1[02])[-|/]+(0?[1-9]|[12]\\d|3[01]))|(((1[6-9]|[2-9]\\d)\\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\\d|30))|(((1[6-9]|[2-9]\\d)\\d{2})-0?2-(0?[1-9]|1\\d|2[0-8]))|(((1[6-9]|[2-9]\\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");
	}

	public static bool IsTime(string source)
	{
		return Regex.IsMatch(source, "^((20|21|22|23|[0-1]?\\d):[0-5]?\\d:[0-5]?\\d)$");
	}

	public static bool IsTel(string source)
	{
		return Regex.IsMatch(source, "(^([\\+]*86\\-)*(\\d{3,4}-)?\\d{7,8}$|^([\\+]*86\\-)*(1[3458][0-9]{9})$)");
	}

	public static bool IsMobile(string source)
	{
		return Regex.IsMatch(source, "^([\\+]*86\\-)*1[3458][0-9]{9}$", RegexOptions.IgnoreCase);
	}

	public static bool IsCn(string source)
	{
		return Regex.IsMatch(source, "^[\\u4e00-\\u9fa5]+$", RegexOptions.IgnoreCase);
	}

	public static bool HasCn(string source)
	{
		return Regex.IsMatch(source, "[\\u4e00-\\u9fa5]+", RegexOptions.IgnoreCase);
	}

	public static bool IsIP(string source)
	{
		return Regex.IsMatch(source, "^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$", RegexOptions.IgnoreCase);
	}

	public static bool HasIP(string source)
	{
		return Regex.IsMatch(source, "(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])", RegexOptions.IgnoreCase);
	}

	public static bool IsValidIP(string value)
	{
		return Regex.IsMatch(value, "^(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])$");
	}

	public static bool IsPort(string value)
	{
		string pattern = "^((\\d{0,4})|([1-5]\\d{1,4})|(6[0-4]\\d{1,3})|(65[0-4]\\d{1,2})|(655[0-2]\\d)|(6553[0-5]))$";
		return Regex.IsMatch(value, pattern);
	}

	public static bool IsIDCard(string Id)
	{
		if (Id.Length == 18)
		{
			return gGXLiVvLOk(Id);
		}
		if (Id.Length == 15)
		{
			return fZyL3r9J5e(Id);
		}
		return false;
	}

	private static bool gGXLiVvLOk(string string_0)
	{
		long result = 0L;
		int num;
		if (long.TryParse(string_0.Remove(17), out result))
		{
			num = 0;
			if (HSRZZXpuh2O8BvfjZvB == null)
			{
				goto IL_002c;
			}
			goto IL_0078;
		}
		goto IL_0172;
		IL_0172:
		return false;
		IL_002c:
		if (!((double)result < System.Math.Pow(10.0, 16.0)))
		{
			if (!long.TryParse(string_0.Replace('x', '0').Replace('X', '0'), out result))
			{
				num = 0;
				if (!HljEiIposGkBZWO2lym())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0078;
			}
			if ("11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91".IndexOf(string_0.Remove(2)) == -1)
			{
				return false;
			}
			string s = string_0.Substring(6, 8).Insert(6, "-").Insert(4, "-");
			DateTime result2 = default(DateTime);
			if (!DateTime.TryParse(s, out result2))
			{
				return false;
			}
			string[] array = "1,0,x,9,8,7,6,5,4,3,2".Split(',');
			string[] array2 = "7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2".Split(',');
			char[] array3 = string_0.Remove(17).ToCharArray();
			int num3 = 0;
			for (int i = 0; i < 17; i++)
			{
				num3 += int.Parse(array2[i]) * int.Parse(array3[i].ToString());
			}
			int result3 = -1;
			System.Math.DivRem(num3, 11, out result3);
			if (array[result3] != string_0.Substring(17, 1).ToLower())
			{
				return false;
			}
			return true;
		}
		goto IL_0172;
		IL_0078:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0172;
		}
		goto IL_002c;
	}

	private static bool fZyL3r9J5e(string string_0)
	{
		long result = 0L;
		if (long.TryParse(string_0, out result) && (double)result >= System.Math.Pow(10.0, 14.0))
		{
			if ("11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91".IndexOf(string_0.Remove(2)) == -1)
			{
				return false;
			}
			string s = string_0.Substring(6, 6).Insert(4, "-").Insert(2, "-");
			DateTime result2 = default(DateTime);
			if (!DateTime.TryParse(s, out result2))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool IsValidID(string id)
	{
		bool result = true;
		string pattern = "^(\\d{15}$|^\\d{18}$|^\\d{17}(\\d|X|x))$";
		if (!Regex.Match(id, pattern).Success)
		{
			result = false;
		}
		return result;
	}

	public static bool IsLengthStr(string source, int begin, int end)
	{
		int length = Regex.Replace(source, "[^\\x00-\\xff]", "OK").Length;
		if (length <= begin && length >= end)
		{
			return false;
		}
		return true;
	}

	public static bool IsPostCode(string source)
	{
		return Regex.IsMatch(source, "^\\d{6}$", RegexOptions.IgnoreCase);
	}

	public static bool IsNormalChar(string source)
	{
		if (HasCn(source))
		{
			return false;
		}
		return Regex.IsMatch(source, "[\\w\\d_]+", RegexOptions.IgnoreCase);
	}

	public static bool HasSpecialChar(string domain)
	{
		if (HasCn(domain))
		{
			return false;
		}
		return new Regex("[`~!@#$%^&*()+=|{}':;',//\"\\[\\].<>/?~！@#￥%……&*（）——+|{}【】‘；：”“’。，、？]").IsMatch(domain);
	}

	public static bool IsEnDomain(string domain)
	{
		return new Regex("^[a-zA-Z0-9][-a-zA-Z0-9]{1,62}(\\.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+\\.?").IsMatch(domain);
	}

	public static bool IsCnDomain(string domain)
	{
		return new Regex("[\\u4e00-\\u9fa5][a-zA-Z0-9][-a-zA-Z0-9]{1,20}(\\.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+\\.?").IsMatch(domain);
	}

	public static string GetCharSet(string source)
	{
		return Regex.Match(source, "<meta([^<]*)charset=([^<]*)\"", RegexOptions.IgnoreCase | RegexOptions.Multiline).Groups[2].Value.Trim();
	}

	public static string GetDomain(string domain)
	{
		domain = new Regex("(www.)?(?<value>[a-zA-Z0-9][-a-zA-Z0-9]{1,62})", RegexOptions.IgnoreCase).Match(domain).Groups["value"].Value.ToString().Trim();
		return domain;
	}

	internal static bool HljEiIposGkBZWO2lym()
	{
		return HSRZZXpuh2O8BvfjZvB == null;
	}
}
