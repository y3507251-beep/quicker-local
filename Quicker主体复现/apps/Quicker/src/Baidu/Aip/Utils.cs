using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Baidu.Aip;

public class Utils
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec pyOvEq6wssq;

		public static Func<KeyValuePair<string, string>, string> BDCvEc8cwcm;

		public static Func<string, string, string> pJxvEVIvKDg;

		internal static _003C_003Ec vGbWCocecKRVd6ofWth4;

		static _003C_003Ec()
		{
			pyOvEq6wssq = new _003C_003Ec();
		}

		internal string CVCvE7FYc87(KeyValuePair<string, string> pair)
		{
			return pair.Key + "=" + pair.Value;
		}

		internal string QNTvER3a6PO(string a, string b)
		{
			return a + "&" + b;
		}

		internal static bool iEKtcCceWepCialsAjAE()
		{
			return vGbWCocecKRVd6ofWth4 == null;
		}
	}

	private static Utils qcbHct2xdALcYc5T99k;

	public static string StreamToString(Stream ss, Encoding enc)
	{
		string result;
		using (StreamReader streamReader = new StreamReader(ss, enc))
		{
			result = streamReader.ReadToEnd();
		}
		ss.Close();
		return result;
	}

	public static string ParseQueryString(Dictionary<string, string> querys)
	{
		if (querys.Count == 0)
		{
			return "";
		}
		return querys.Select(_003C_003Ec.BDCvEc8cwcm ?? (_003C_003Ec.BDCvEc8cwcm = _003C_003Ec.pyOvEq6wssq.CVCvE7FYc87)).Aggregate(_003C_003Ec.pJxvEVIvKDg ?? (_003C_003Ec.pJxvEVIvKDg = _003C_003Ec.pyOvEq6wssq.QNTvER3a6PO));
	}

	public static string UriEncode(string input, bool encodeSlash = false)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		int num = 2;
		if (!cLxT5Q2IxDThTnvXDBw())
		{
			int num2 = default(int);
			num = num2;
		}
		int num3 = default(int);
		byte b = default(byte);
		while (true)
		{
			switch (num)
			{
			case 2:
				num3 = 0;
				goto case 1;
			default:
				stringBuilder.Append((char)b);
				goto IL_00c5;
			case 1:
				{
					if (num3 < bytes.Length)
					{
						b = bytes[num3];
						if ((b < 97 || b > 122) && (b < 65 || b > 90) && (b < 48 || b > 57) && b != 95 && b != 45 && b != 126 && b != 46)
						{
							if (b == 47)
							{
								if (!encodeSlash)
								{
									goto default;
								}
								stringBuilder.Append("%2F");
							}
							else
							{
								stringBuilder.Append('%').Append(b.ToString("X2"));
							}
						}
						else
						{
							stringBuilder.Append((char)b);
						}
						goto IL_00c5;
					}
					return stringBuilder.ToString();
				}
				IL_00c5:
				num3++;
				num = 1;
				if (cLxT5Q2IxDThTnvXDBw())
				{
					break;
				}
				goto case 1;
			}
		}
	}

	public static string Md5(string text)
	{
		byte[] bytes = Encoding.Default.GetBytes(text);
		return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(bytes)).ToUpper();
	}

	public static byte[] StreamToBytes(Stream input)
	{
		byte[] array = new byte[16384];
		using MemoryStream memoryStream = new MemoryStream();
		int count;
		while ((count = input.Read(array, 0, array.Length)) > 0)
		{
			memoryStream.Write(array, 0, count);
		}
		return memoryStream.ToArray();
	}

	public static long UnixTimestamp()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
	}

	internal static bool cLxT5Q2IxDThTnvXDBw()
	{
		return qcbHct2xdALcYc5T99k == null;
	}
}
