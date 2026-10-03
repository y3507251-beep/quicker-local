using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

namespace Baidu.Aip;

public class AipHttpRequest
{
	public enum BodyFormat
	{
		Formed,
		Json,
		JsonRaw
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ACnvPUNPNEi;

		public static Func<KeyValuePair<string, object>, string> msPvPlny0NM;

		public static Func<string, string, string> RaBvPigXg0K;

		private static _003C_003Ec nWYbMwcnxXFUVcebaHjD;

		static _003C_003Ec()
		{
			ACnvPUNPNEi = new _003C_003Ec();
		}

		internal string mgGvPOvstBQ(KeyValuePair<string, object> pair)
		{
			return pair.Key + "=" + Utils.UriEncode(pair.Value.ToString());
		}

		internal string zb0vPF8mqgU(string a, string b)
		{
			return a + "&" + b;
		}

		internal static bool CXYu7gcnIkpOYNG8GaWO()
		{
			return nWYbMwcnxXFUVcebaHjD == null;
		}
	}

	public const string BodyFormatJsonRawKey = "RAw";

	public Dictionary<string, object> Bodys;

	public BodyFormat BodyType;

	public Encoding ContentEncoding;

	public Dictionary<string, string> Headers;

	public string Method;

	public Dictionary<string, string> Querys;

	public Uri Uri;

	[CompilerGenerated]
	private HttpWebRequest Sv7SVOav7D;

	internal static AipHttpRequest WlPsHA2reTEcbASUnV6;

	public HttpWebRequest GeneratedRequest
	{
		[CompilerGenerated]
		get
		{
			return Sv7SVOav7D;
		}
		[CompilerGenerated]
		private set
		{
			Sv7SVOav7D = value;
		}
	}

	public string UriWithQuery
	{
		get
		{
			string text = Utils.ParseQueryString(Querys);
			return Uri?.ToString() + "?" + text;
		}
	}

	private AipHttpRequest()
	{
		Headers = new Dictionary<string, string>();
		Querys = new Dictionary<string, string> { { "aipSdk", "CSharp" } };
		Bodys = new Dictionary<string, object>();
		Method = "GET";
		BodyType = BodyFormat.Formed;
		ContentEncoding = Encoding.UTF8;
		ServicePointManager.Expect100Continue = false;
	}

	public AipHttpRequest(string uri)
		: this()
	{
		Uri = new Uri(uri);
	}

	public byte[] ProcessHttpRequest(HttpWebRequest webRequest)
	{
		webRequest.Method = Method;
		webRequest.ReadWriteTimeout = 30000;
		foreach (KeyValuePair<string, string> header in Headers)
		{
			webRequest.Headers.Add(header.Key, header.Value);
		}
		GeneratedRequest = webRequest;
		switch (BodyType)
		{
		default:
		{
			int num = 0;
			if (WlPsHA2reTEcbASUnV6 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => null, 
			};
		}
		case BodyFormat.Formed:
		{
			string s3 = Bodys.Select(_003C_003Ec.msPvPlny0NM ?? (_003C_003Ec.msPvPlny0NM = _003C_003Ec.ACnvPUNPNEi.mgGvPOvstBQ)).DefaultIfEmpty("").Aggregate(_003C_003Ec.RaBvPigXg0K ?? (_003C_003Ec.RaBvPigXg0K = _003C_003Ec.ACnvPUNPNEi.zb0vPF8mqgU));
			webRequest.ContentType = "application/x-www-form-urlencoded";
			return ContentEncoding.GetBytes(s3);
		}
		case BodyFormat.Json:
		{
			string s2 = JsonConvert.SerializeObject(Bodys);
			webRequest.ContentType = "application/json";
			return ContentEncoding.GetBytes(s2);
		}
		case BodyFormat.JsonRaw:
		{
			string s = JsonConvert.SerializeObject(Bodys["RAw"]);
			webRequest.ContentType = "application/json";
			return ContentEncoding.GetBytes(s);
		}
		}
	}

	public HttpWebRequest GenerateDevWebRequest(string token, int timeout)
	{
		Querys.Add("access_token", token);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(UriWithQuery);
		httpWebRequest.ReadWriteTimeout = timeout;
		httpWebRequest.Timeout = timeout;
		byte[] array = ProcessHttpRequest(httpWebRequest);
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		return httpWebRequest;
	}

	public HttpWebRequest GenerateCloudRequest(string ak, string sk, int timeout)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(UriWithQuery);
		httpWebRequest.ReadWriteTimeout = timeout;
		httpWebRequest.Timeout = timeout;
		byte[] array = ProcessHttpRequest(httpWebRequest);
		Auth.CloudRequest(this, ak, sk);
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		return httpWebRequest;
	}

	public HttpWebRequest GenerateCloudRequestWithServerAuth(int timeout)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(UriWithQuery);
		httpWebRequest.ReadWriteTimeout = timeout;
		httpWebRequest.Timeout = timeout;
		byte[] array = ProcessHttpRequest(httpWebRequest);
		Auth.F8CSH1nkFn(this);
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		return httpWebRequest;
	}

	public HttpWebRequest GenerateSpeechRequest(int timeout)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Uri);
		httpWebRequest.ReadWriteTimeout = timeout;
		httpWebRequest.Timeout = timeout;
		byte[] array = ProcessHttpRequest(httpWebRequest);
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		return httpWebRequest;
	}

	internal static bool m5VqUZ2NmtN3l3kITTn()
	{
		return WlPsHA2reTEcbASUnV6 == null;
	}
}
