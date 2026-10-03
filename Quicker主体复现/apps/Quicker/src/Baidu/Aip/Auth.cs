using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Services;

namespace Baidu.Aip;

public class Auth
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LqgvECse45l;

		public static Func<KeyValuePair<string, string>, bool> nUovEPwNPuh;

		public static Func<KeyValuePair<string, string>, KeyValuePair<string, string>> S1AvEEcLZRj;

		public static Func<KeyValuePair<string, string>, string> ND7vEy4LtBL;

		public static Func<KeyValuePair<string, string>, string> YvevE81k4Th;

		public static Func<string, string, string> Vv3vEaE3TTt;

		internal static _003C_003Ec vPLiIBceVZbXZFjNSkcv;

		static _003C_003Ec()
		{
			LqgvECse45l = new _003C_003Ec();
		}

		internal bool jJcvE2eOjvo(KeyValuePair<string, string> pair)
		{
			return !pair.Key.Equals("authorization");
		}

		internal KeyValuePair<string, string> R9AvEuiCBlS(KeyValuePair<string, string> pair)
		{
			return new KeyValuePair<string, string>(Utils.UriEncode(pair.Key), Utils.UriEncode(pair.Value));
		}

		internal string WFXvENVsjK9(KeyValuePair<string, string> pair)
		{
			return pair.Key;
		}

		internal string hWKvEJBlFrq(KeyValuePair<string, string> pair)
		{
			return $"{pair.Key}={Utils.UriEncode(pair.Value, true)}";
		}

		internal string kn6vE0tsf45(string a, string b)
		{
			return a + "&" + b;
		}

		internal static bool BAqYcDceQUAfNt43tGqC()
		{
			return vPLiIBceVZbXZFjNSkcv == null;
		}
	}

	internal static Auth CCgOkg25WZGoMM2n6BY;

	private Auth()
	{
	}

	public static JObject OpenApiFetchToken(string ak, string sk, bool throws = false, bool debugLog = false)
	{
		Dictionary<string, string> querys = new Dictionary<string, string>
		{
			{ "grant_type", "client_credentials" },
			{ "client_id", ak },
			{ "client_secret", sk }
		};
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format("{0}?{1}", "https://aip.baidubce.com/oauth/2.0/token", Utils.ParseQueryString(querys)));
		JObject result;
		try
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				JObject jObject = JsonConvert.DeserializeObject(Utils.StreamToString(httpWebResponse.GetResponseStream(), Encoding.UTF8)) as JObject;
				if (jObject["access_token"] != null && jObject["expires_in"] != null)
				{
					result = jObject;
					if (CCgOkg25WZGoMM2n6BY != null)
					{
						switch (0)
						{
						}
					}
				}
				else
				{
					if (throws)
					{
						throw new AipException("Failed to request token. " + (string?)jObject["error_description"]);
					}
					result = null;
				}
				goto IL_0134;
			}
			if (throws)
			{
				throw new AipException("Failed to request token. " + httpWebResponse.StatusCode.ToString() + httpWebResponse.StatusDescription);
			}
		}
		catch (Exception ex)
		{
			if (throws)
			{
				throw new AipException("Failed to request token. " + ex.Message);
			}
			result = null;
			goto IL_0134;
		}
		return null;
		IL_0134:
		return result;
	}

	private static string mKFSsuqkZd(AipHttpRequest aipHttpRequest_0)
	{
		Uri uri = aipHttpRequest_0.Uri;
		string text = Utils.UriEncode(uri.AbsolutePath);
		int num = 0;
		if (!lN6v0o2YumCu5b2O4ur())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			string text2 = aipHttpRequest_0.Querys.Where(_003C_003Ec.nUovEPwNPuh ?? (_003C_003Ec.nUovEPwNPuh = _003C_003Ec.LqgvECse45l.jJcvE2eOjvo)).Select(_003C_003Ec.S1AvEEcLZRj ?? (_003C_003Ec.S1AvEEcLZRj = _003C_003Ec.LqgvECse45l.R9AvEuiCBlS)).ToList()
				.OrderBy(_003C_003Ec.ND7vEy4LtBL ?? (_003C_003Ec.ND7vEy4LtBL = _003C_003Ec.LqgvECse45l.WFXvENVsjK9))
				.Select(_003C_003Ec.YvevE81k4Th ?? (_003C_003Ec.YvevE81k4Th = _003C_003Ec.LqgvECse45l.hWKvEJBlFrq))
				.DefaultIfEmpty("")
				.Aggregate(_003C_003Ec.Vv3vEaE3TTt ?? (_003C_003Ec.Vv3vEaE3TTt = _003C_003Ec.LqgvECse45l.kn6vE0tsf45));
			string text3 = uri.Host;
			if ((!(uri.Scheme == "https") || uri.Port != 443) && (!(uri.Scheme == "http") || uri.Port != 80))
			{
				text3 = text3 + ":" + uri.Port;
			}
			string text4 = "content-type:" + Utils.UriEncode(aipHttpRequest_0.GeneratedRequest.ContentType, true) + "\nhost:" + Utils.UriEncode(text3);
			return $"{aipHttpRequest_0.Method}\n{text}\n{text2}\n{text4}";
		}
		}
	}

	public static void CloudRequest(AipHttpRequest aipReq, string ak, string sk)
	{
		DateTime now = DateTime.Now;
		int num = 1200;
		DateTime dateTime = now.ToUniversalTime();
		int num2 = 0;
		if (!lN6v0o2YumCu5b2O4ur())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		string text = dateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ssK");
		string text2 = "bce-auth-v1/" + ak + "/" + text + "/" + num;
		string s = zuRS1RHX3X(new HMACSHA256(Encoding.UTF8.GetBytes(sk)).ComputeHash(Encoding.UTF8.GetBytes(text2)));
		string s2 = mKFSsuqkZd(aipReq);
		string text3 = zuRS1RHX3X(new HMACSHA256(Encoding.UTF8.GetBytes(s)).ComputeHash(Encoding.UTF8.GetBytes(s2)));
		string value = text2 + "/content-type;host/" + text3;
		aipReq.GeneratedRequest.Headers.Add("x-bce-date", text);
		aipReq.GeneratedRequest.Headers.Add("Authorization", value);
	}

	internal static void F8CSH1nkFn(AipHttpRequest aipHttpRequest_0)
	{
		string text = DateTime.Now.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ssK");
		string string_ = mKFSsuqkZd(aipHttpRequest_0);
		ApiResult<BasicOcrRtn> result = aFIptTXYsUoTUF4v33R.j18tbPua2rS(text, string_, 1200).Result;
		if (CCgOkg25WZGoMM2n6BY != null)
		{
			switch (0)
			{
			}
		}
		if (!result.IsSuccess)
		{
			throw new InvalidDataException("OCR认证失败：" + result.Message);
		}
		string authorization = result.Data.Authorization;
		aipHttpRequest_0.GeneratedRequest.Headers.Add("x-bce-date", text);
		aipHttpRequest_0.GeneratedRequest.Headers.Add("Authorization", authorization);
	}

	private static string Authorization(string ak, string sk, string signDate, int expirationInSeconds, string canonicalRequestString)
	{
		string text = "bce-auth-v1/" + ak + "/" + signDate + "/" + expirationInSeconds;
		string s = zuRS1RHX3X(new HMACSHA256(Encoding.UTF8.GetBytes(sk)).ComputeHash(Encoding.UTF8.GetBytes(text)));
		string text2 = zuRS1RHX3X(new HMACSHA256(Encoding.UTF8.GetBytes(s)).ComputeHash(Encoding.UTF8.GetBytes(canonicalRequestString)));
		return text + "/content-type;host/" + text2;
	}

	private static string zuRS1RHX3X(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in byte_0)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	internal static bool lN6v0o2YumCu5b2O4ur()
	{
		return CCgOkg25WZGoMM2n6BY == null;
	}
}
