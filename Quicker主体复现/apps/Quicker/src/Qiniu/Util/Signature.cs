using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Qiniu.Util;

public class Signature
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec bbqv79OZGvh;

		public static Func<string, bool> iwiv7hQkctZ;

		private static _003C_003Ec f48DUdcd9CdIyLC9cTKY;

		static _003C_003Ec()
		{
			bbqv79OZGvh = new _003C_003Ec();
		}

		internal bool jydv7Zes9Hq(string k)
		{
			if (k.StartsWith("X-Qiniu-"))
			{
				return k.Length > "X-Qiniu-".Length;
			}
			return false;
		}

		internal static bool rO0113cdLSYQnUPBImPQ()
		{
			return f48DUdcd9CdIyLC9cTKY == null;
		}
	}

	private Mac HWceIwsk0H;

	internal static Signature FnIq8FLKh3UK6UT7OMq;

	public Signature(Mac mac)
	{
		HWceIwsk0H = mac;
	}

	private string EJuee5XcKY(byte[] byte_0)
	{
		return Base64.UrlSafeBase64Encode(new HMACSHA1(Encoding.UTF8.GetBytes(HWceIwsk0H.SecretKey)).ComputeHash(byte_0));
	}

	private string rygeYrV6rq(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return EJuee5XcKY(bytes);
	}

	public string Sign(byte[] data)
	{
		return $"{HWceIwsk0H.AccessKey}:{EJuee5XcKY(data)}";
	}

	public string Sign(string str)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		return Sign(bytes);
	}

	public string SignWithData(byte[] data)
	{
		string text = Base64.UrlSafeBase64Encode(data);
		return $"{HWceIwsk0H.AccessKey}:{rygeYrV6rq(text)}:{text}";
	}

	public string SignWithData(string str)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		return SignWithData(bytes);
	}

	public string SignRequest(string url, byte[] body)
	{
		string pathAndQuery = new Uri(url).PathAndQuery;
		byte[] bytes = Encoding.UTF8.GetBytes(pathAndQuery);
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(bytes, 0, bytes.Length);
		memoryStream.WriteByte(10);
		if (body != null && body.Length != 0)
		{
			memoryStream.Write(body, 0, body.Length);
		}
		string arg = Base64.UrlSafeBase64Encode(new HMACSHA1(Encoding.UTF8.GetBytes(HWceIwsk0H.SecretKey)).ComputeHash(memoryStream.ToArray()));
		return $"{HWceIwsk0H.AccessKey}:{arg}";
	}

	public string SignRequest(string url, string body)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(body);
		return SignRequest(url, bytes);
	}

	public string SignRequestV2(string method, string url, StringDictionary headers, string body)
	{
		int num = 1;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			int num2 = 0;
			if (FnIq8FLKh3UK6UT7OMq != null)
			{
				goto IL_000e;
			}
			goto IL_0196;
			IL_0196:
			switch (num2)
			{
			case 1:
				continue;
			case 2:
				goto IL_01c5;
			}
			goto IL_000e;
			IL_01c5:
			stringBuilder.Append(body);
			break;
			IL_000e:
			if (headers != null)
			{
				foreach (string key in headers.Keys)
				{
					dictionary.Add(StringHelper.CanonicalMimeHeaderKey(key), headers[key]);
				}
			}
			Uri uri = new Uri(url);
			stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} {1}", method.ToUpper(), uri.PathAndQuery);
			stringBuilder.AppendFormat("\nHost: {0}", uri.Host);
			if (dictionary.ContainsKey("Content-Type"))
			{
				stringBuilder.AppendFormat("\nContent-Type: {0}", dictionary["Content-Type"]);
			}
			if (dictionary.Count > 0)
			{
				List<string> list = dictionary.Keys.ToList().Where(_003C_003Ec.iwiv7hQkctZ ?? (_003C_003Ec.iwiv7hQkctZ = _003C_003Ec.bbqv79OZGvh.jydv7Zes9Hq)).ToList();
				list.Sort();
				foreach (string item in list)
				{
					stringBuilder.AppendFormat("\n{0}: {1}", item, dictionary[item]);
				}
			}
			stringBuilder.Append("\n\n");
			if (!dictionary.ContainsKey("Content-Type") || !(dictionary["Content-Type"] != "application/octet-stream"))
			{
				break;
			}
			num2 = 2;
			if (FnIq8FLKh3UK6UT7OMq != null)
			{
				num2 = num;
			}
			goto IL_0196;
		}
		string arg = Base64.UrlSafeBase64Encode(new HMACSHA1(Encoding.UTF8.GetBytes(HWceIwsk0H.SecretKey)).ComputeHash(Encoding.UTF8.GetBytes(stringBuilder.ToString())));
		return $"{HWceIwsk0H.AccessKey}:{arg}";
	}

	public string SignRequestV2(string method, string url, StringDictionary headers, byte[] body)
	{
		return SignRequestV2(method, url, headers, Encoding.UTF8.GetString(body));
	}

	internal static bool BmZiqFLBqnTtSg8vs9i()
	{
		return FnIq8FLKh3UK6UT7OMq == null;
	}
}
