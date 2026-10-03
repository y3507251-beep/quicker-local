using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Newtonsoft.Json;
using Quicker.Public.Extensions;
using Wsfly.Framework.Handler.Math;

namespace Quicker.Utilities.Texting;

public static class InternalTextProcessor
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec tjw2viT3uJg;

		public static Func<string, string> ONj2v3uakp0;

		public static Func<string, string> Oca2vfmHoV3;

		public static MatchEvaluator n0W2vzdDEig;

		public static MatchEvaluator Hxw2SweHOgG;

		private static _003C_003Ec KlPcbry3ZkorXOyCxWox;

		static _003C_003Ec()
		{
			tjw2viT3uJg = new _003C_003Ec();
		}

		internal string fnn2vOZ8BZC(string x)
		{
			return x.Trim();
		}

		internal string K2h2vF0FVj0(string x)
		{
			return x.Trim();
		}

		internal string yc92vU7bJq1(Match m)
		{
			if (!short.TryParse(m.Groups[1].Value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result))
			{
				return m.Value;
			}
			return ((char)result).ToString() ?? "";
		}

		internal string pZn2vl1mZJ5(Match m)
		{
			return "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[m.Value[0] - 45].ToString(CultureInfo.InvariantCulture);
		}

		internal static bool SoHggTy35VoMImZWd441()
		{
			return KlPcbry3ZkorXOyCxWox == null;
		}
	}

	private static readonly Regex cuHLORlNkB3;

	private static object Tg1MGHFgwRXridYig7pC;

	public static string ProcessText(string method, string data, string param)
	{
		string result = "";
		string text = method.ToUpperInvariant();
		if (text != null)
		{
			string[] source = default(string[]);
			int num2 = default(int);
			while (true)
			{
				int num;
				char c;
				switch (text.Length)
				{
				case 9:
					c = text[3];
					if (c != 'D')
					{
						if (c != 'E')
						{
							num = 1;
							if (Tg1MGHFgwRXridYig7pC != null)
							{
								goto IL_0080;
							}
						}
						else
						{
							if (text == "URLENCODE")
							{
								result = HttpUtility.UrlEncode(data);
								goto IL_075d;
							}
							num = 4;
							if (Tg1MGHFgwRXridYig7pC != null)
							{
								goto IL_0080;
							}
						}
						goto IL_0084;
					}
					if (!(text == "URLDECODE"))
					{
						break;
					}
					result = HttpUtility.UrlDecode(data);
					goto IL_075d;
				case 12:
					goto IL_00ec;
				case 7:
					c = text[2];
					if ((uint)c > 73u)
					{
						if (c != 'L')
						{
							if (c == 'U')
							{
								if (!(text == "TOUPPER"))
								{
									break;
								}
								result = data.ToUpperInvariant();
								num = 3;
								if (!QlbthkFgTtLh41Igu4m4())
								{
									goto IL_0080;
								}
								goto IL_0084;
							}
							if (c != 'V' || !(text == "REVERSE"))
							{
								break;
							}
							goto IL_04d5;
						}
						if (!(text == "TOLOWER"))
						{
							break;
						}
						result = data.ToLowerInvariant();
					}
					else if (c != 'C')
					{
						if (c != 'I' || !(text == "TRIMEND"))
						{
							break;
						}
						result = data.TrimEnd();
					}
					else
					{
						if (!(text == "TOCNNUM"))
						{
							break;
						}
						result = LItLOPdR3bN(double.Parse(data, CultureInfo.InvariantCulture));
					}
					goto IL_075d;
				case 3:
					if (!(text == "MD5"))
					{
						break;
					}
					result = ComputeMd5Hash(data);
					goto IL_075d;
				case 4:
					if (!(text == "TRIM"))
					{
						break;
					}
					goto IL_0500;
				case 6:
					c = text[0];
					if (c == 'C')
					{
						goto IL_04b7;
					}
					if (c != 'N')
					{
						break;
					}
					goto IL_04e2;
				case 8:
					if (!(text == "SHA1HASH"))
					{
						break;
					}
					result = FXlLOEcm1fn(data);
					goto IL_075d;
				case 10:
					switch (text[4])
					{
					case 'P':
						break;
					case 'A':
						goto IL_0338;
					case 'D':
						goto IL_0356;
					case 'E':
						goto IL_0374;
					case '5':
						goto IL_0392;
					default:
						goto end_IL_0166;
					}
					if (!(text == "ESCAPEJSON"))
					{
						break;
					}
					result = WOvLOJpykXX(data);
					goto IL_075d;
				case 11:
					if (!(text == "TOTITLECASE"))
					{
						break;
					}
					result = new CultureInfo("en-US", false).TextInfo.ToTitleCase(data);
					goto IL_075d;
				case 13:
					c = text[0];
					if (c != 'D')
					{
						if (c != 'S' || !(text == "SORTLINESDESC"))
						{
							break;
						}
						source = data.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
						goto IL_05e2;
					}
					goto IL_0619;
				case 14:
					if (!(text == "MERGEEMPTYLINE"))
					{
						break;
					}
					result = ((!data.Contains("\r\r")) ? Regex.Replace(data, "((\\r?\\n)|(\\r)){3,}", "\r\n\r\n") : Regex.Replace(data, "(\\r){3,}", "\r\r"));
					goto IL_075d;
				case 15:
					if (!(text == "REMOVEEMPTYLINE"))
					{
						break;
					}
					result = ((data.Length >= 100000) ? Regex.Replace(data, "^\\s*[\\r\\n]+", "", RegexOptions.Multiline) : string.Join("\r\n", data.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)));
					goto IL_075d;
				case 20:
				{
					if (!(text == "REMOVEZEROWIDTHCHARS"))
					{
						break;
					}
					string pattern = "[\\u200B-\\u200D\\u2060-\\u206B\\uFEFF\\u202A-\\u202E]";
					result = Regex.Replace(data, pattern, string.Empty);
					goto IL_075d;
				}
				case 21:
					if (!(text == "INTERCAPPEDTOSENTENCE"))
					{
						break;
					}
					result = Regex.Replace(data, "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", "$1 ");
					goto IL_075d;
				case 26:
					{
						if (!(text == "EXPANDENVIRONMENTVARIABLES"))
						{
							break;
						}
						result = Environment.ExpandEnvironmentVariables(data);
						goto IL_075d;
					}
					IL_04b7:
					if (!(text == "CN2NUM"))
					{
						break;
					}
					result = kKRLOCA6I8n(data);
					goto IL_075d;
					IL_04d5:
					result = Reverse(data);
					goto IL_075d;
					IL_0619:
					if (!(text == "DECODEUNICODE"))
					{
						break;
					}
					result = DecodeUnicode(data);
					goto IL_075d;
					IL_05e2:
					result = string.Join("\n", source.OrderByDescending(_003C_003Ec.Oca2vfmHoV3 ?? (_003C_003Ec.Oca2vfmHoV3 = _003C_003Ec.tjw2viT3uJg.K2h2vF0FVj0)));
					goto IL_075d;
					IL_04e2:
					if (!(text == "NUM2CN"))
					{
						break;
					}
					result = iw8LO0JsmLD(data);
					goto IL_075d;
					IL_00d6:
					if (!(text == "REVERSELINES"))
					{
						num = 7;
						if (Tg1MGHFgwRXridYig7pC == null)
						{
							goto IL_0084;
						}
					}
					else
					{
						string[] source2 = data.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
						result = string.Join("\r\n", source2.Reverse());
					}
					goto IL_075d;
					IL_00ec:
					c = text[0];
					if (c != 'B')
					{
						if (c == 'R')
						{
							goto IL_00d6;
						}
						if (c != 'S' || !(text == "SORTLINESASC"))
						{
							break;
						}
						string[] source3 = data.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
						result = string.Join("\n", source3.OrderBy(_003C_003Ec.ONj2v3uakp0 ?? (_003C_003Ec.ONj2v3uakp0 = _003C_003Ec.tjw2viT3uJg.fnn2vOZ8BZC)));
					}
					else if (!(text == "BASE64ENCODE"))
					{
						if (!(text == "BASE64DECODE"))
						{
							break;
						}
						result = data.DecodeBase64String();
					}
					else
					{
						result = Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
					}
					goto IL_075d;
					IL_0392:
					if (!(text == "SHA256HASH"))
					{
						break;
					}
					result = VGVLOyqoVLK(data);
					goto IL_075d;
					IL_0080:
					num = num2;
					goto IL_0084;
					IL_0374:
					if (!(text == "HTMLENCODE"))
					{
						break;
					}
					result = HttpUtility.HtmlEncode(data);
					goto IL_075d;
					IL_0500:
					result = data.Trim();
					goto IL_075d;
					IL_0356:
					if (!(text == "HTMLDECODE"))
					{
						break;
					}
					result = HttpUtility.HtmlDecode(data);
					goto IL_075d;
					IL_0084:
					switch (num)
					{
					case 15:
						goto IL_00d6;
					case 2:
						goto IL_00ec;
					case 8:
						continue;
					case 1:
						if (c != 'M' || !(text == "TRIMSTART"))
						{
							goto end_IL_0166;
						}
						result = data.TrimStart();
						goto IL_075d;
					case 13:
						goto IL_04b7;
					case 14:
						goto IL_04d5;
					case 16:
						goto IL_04e2;
					case 17:
						goto IL_0500;
					case 6:
						goto IL_05e2;
					case 10:
						goto IL_0619;
					case 4:
					case 5:
					case 7:
					case 9:
					case 12:
						goto end_IL_0166;
					case 3:
					case 11:
						goto IL_075d;
					}
					goto case 9;
					IL_0338:
					if (!(text == "FORMATJSON"))
					{
						break;
					}
					result = CNaLO7QaZrT(data);
					goto IL_075d;
					IL_075d:
					return result;
					end_IL_0166:
					break;
				}
				break;
			}
		}
		throw new InvalidOperationException("不支持的操作类型：" + method);
	}

	public static string DecodeUnicode(string s)
	{
		return cuHLORlNkB3.Replace(s, _003C_003Ec.n0W2vzdDEig ?? (_003C_003Ec.n0W2vzdDEig = _003C_003Ec.tjw2viT3uJg.yc92vU7bJq1));
	}

	private static string WOvLOJpykXX(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return string_0;
		}
		return HttpUtility.JavaScriptStringEncode(string_0);
	}

	internal static string iw8LO0JsmLD(string string_0)
	{
		string msg;
		return NumberConventer.ArabToChn(Convert.ToDecimal(string_0, CultureInfo.InvariantCulture), out msg);
	}

	private static string kKRLOCA6I8n(string string_0)
	{
		return NumberConventer.ChnToArab(string_0).ToString(CultureInfo.InvariantCulture);
	}

	public static string Reverse(string s)
	{
		char[] array = s.Replace("\r\n", "\n").ToCharArray();
		Array.Reverse(array);
		return new string(array).Replace("\n", "\r\n");
	}

	internal static string LItLOPdR3bN(double double_0)
	{
		return Regex.Replace(Regex.Replace(double_0.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A", CultureInfo.InvariantCulture), "((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\\.]|$))))", "${b}${z}"), ".", _003C_003Ec.Hxw2SweHOgG ?? (_003C_003Ec.Hxw2SweHOgG = _003C_003Ec.tjw2viT3uJg.pZn2vl1mZJ5));
	}

	private static string FXlLOEcm1fn(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		using SHA1 hashAlgorithm_ = SHA1.Create();
		return GDnLO8wQVdd(hashAlgorithm_, string_0);
	}

	private static string VGVLOyqoVLK(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		using SHA256 hashAlgorithm_ = SHA256.Create();
		return GDnLO8wQVdd(hashAlgorithm_, string_0);
	}

	private static string GDnLO8wQVdd(HashAlgorithm hashAlgorithm_0, string string_0)
	{
		byte[] array = hashAlgorithm_0.ComputeHash(Encoding.UTF8.GetBytes(string_0));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2", CultureInfo.InvariantCulture));
		}
		return stringBuilder.ToString();
	}

	public static string ComputeMd5Hash(string input)
	{
		if (!string.IsNullOrEmpty(input))
		{
			using (MD5 md5_ = MD5.Create())
			{
				return NOALOacPpiN(md5_, input);
			}
		}
		return "";
	}

	private static string NOALOacPpiN(MD5 md5_0, string string_0)
	{
		byte[] array = md5_0.ComputeHash(Encoding.UTF8.GetBytes(string_0));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2", CultureInfo.InvariantCulture));
		}
		return stringBuilder.ToString();
	}

	private static string CNaLO7QaZrT(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return "";
		}
		return JsonConvert.DeserializeObject(string_0, new JsonSerializerSettings
		{
			FloatParseHandling = FloatParseHandling.Decimal,
			Formatting = Formatting.Indented
		}).ToString();
	}

	static InternalTextProcessor()
	{
		cuHLORlNkB3 = new Regex("\\\\u([0-9a-fA-F]{4})", RegexOptions.Compiled);
	}

	internal static bool QlbthkFgTtLh41Igu4m4()
	{
		return Tg1MGHFgwRXridYig7pC == null;
	}

	internal static void yZDlEiFPFLA53A56VJK1()
	{
	}
}
