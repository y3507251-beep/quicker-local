using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip;

public abstract class AipServiceBase
{
	public class Type
	{
		[CompilerGenerated]
		private string r89vP3BAryt;

		internal static Type joXZCEcntY2BWS3knmTl;

		public string Url
		{
			[CompilerGenerated]
			get
			{
				return r89vP3BAryt;
			}
			[CompilerGenerated]
			set
			{
				r89vP3BAryt = value;
			}
		}

		public Type(string url)
		{
			Url = url;
		}

		internal static bool su7An7cnSIcWsDvPc3Z9()
		{
			return joXZCEcntY2BWS3knmTl == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<byte[], string> RKbvPffM2EU;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BZ1vEtV2Tti;

		public static Predicate<string> gVlvEgGUUkZ;

		public static Func<string, string, string> yY5vELrhQXE;

		internal static _003C_003Ec QBfLTBcnCLIfnnkVIVC3;

		static _003C_003Ec()
		{
			BZ1vEtV2Tti = new _003C_003Ec();
		}

		internal bool uQ5vPzM8DN5(string v)
		{
			return Consts.AipScopes.Contains(v);
		}

		internal string zmJvEwncCqY(string a, string b)
		{
			return a + "," + b;
		}

		internal static bool e6EKhMcn7sns9xLs41m9()
		{
			return QBfLTBcnCLIfnnkVIVC3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public string J70vES2Gmp2;

		private static _003C_003Ec__DisplayClass50_0 YuKqyocnhHNJ3NQlVBMW;

		internal string fX6vEvwguLb(string a, string b)
		{
			return a + J70vES2Gmp2 + b;
		}

		internal static bool coqSYucnH31rpNAVWtZw()
		{
			return YuKqyocnhHNJ3NQlVBMW == null;
		}
	}

	protected readonly object AuthLock = new object();

	protected volatile bool HasDoneAuthoried;

	protected volatile bool IsDev;

	[CompilerGenerated]
	private string cr2SZWX6Td;

	[CompilerGenerated]
	private DateTime t4PS9wu70E;

	[CompilerGenerated]
	private string kbWShEmV83;

	[CompilerGenerated]
	private string GLuSerTX6k;

	[CompilerGenerated]
	private string fEuSYldLhj;

	[CompilerGenerated]
	private bool cQYSIhdo1L;

	[CompilerGenerated]
	private bool diJSWvTZ5e;

	[CompilerGenerated]
	private string nSwSkZCWSm;

	[CompilerGenerated]
	private int GhKSGGDi9X;

	internal static AipServiceBase TOPpXZ2qB4OQIYw3Ev5;

	protected string Token
	{
		[CompilerGenerated]
		get
		{
			return cr2SZWX6Td;
		}
		[CompilerGenerated]
		set
		{
			cr2SZWX6Td = value;
		}
	}

	protected DateTime ExpireAt
	{
		[CompilerGenerated]
		get
		{
			return t4PS9wu70E;
		}
		[CompilerGenerated]
		set
		{
			t4PS9wu70E = value;
		}
	}

	public string AppId
	{
		[CompilerGenerated]
		get
		{
			return kbWShEmV83;
		}
		[CompilerGenerated]
		set
		{
			kbWShEmV83 = value;
		}
	}

	public string ApiKey
	{
		[CompilerGenerated]
		get
		{
			return GLuSerTX6k;
		}
		[CompilerGenerated]
		set
		{
			GLuSerTX6k = value;
		}
	}

	public string SecretKey
	{
		[CompilerGenerated]
		get
		{
			return fEuSYldLhj;
		}
		[CompilerGenerated]
		set
		{
			fEuSYldLhj = value;
		}
	}

	public bool DebugLog
	{
		[CompilerGenerated]
		get
		{
			return cQYSIhdo1L;
		}
		[CompilerGenerated]
		set
		{
			cQYSIhdo1L = value;
		}
	}

	public bool UserServerAuth
	{
		[CompilerGenerated]
		get
		{
			return diJSWvTZ5e;
		}
		[CompilerGenerated]
		set
		{
			diJSWvTZ5e = value;
		}
	}

	public string RawResult
	{
		[CompilerGenerated]
		get
		{
			return nSwSkZCWSm;
		}
		[CompilerGenerated]
		protected set
		{
			nSwSkZCWSm = value;
		}
	}

	public int Timeout
	{
		[CompilerGenerated]
		get
		{
			return GhKSGGDi9X;
		}
		[CompilerGenerated]
		set
		{
			GhKSGGDi9X = value;
		}
	}

	protected AipServiceBase(string apiKey, string secretKey)
		: this("", apiKey, secretKey)
	{
	}

	protected AipServiceBase(string appId, string apiKey, string secretKey)
	{
		AppId = appId;
		ApiKey = apiKey;
		SecretKey = secretKey;
		ExpireAt = DateTime.Now;
		DebugLog = false;
		Timeout = 60000;
	}

	protected virtual void DoAuthorization()
	{
		lock (AuthLock)
		{
			if (!NeetAuth())
			{
				return;
			}
			JObject jObject = Auth.OpenApiFetchToken(ApiKey, SecretKey);
			if (jObject != null)
			{
				ExpireAt = DateTime.Now.AddSeconds((int)jObject["expires_in"] - 1);
				int num = 0;
				if (TOPpXZ2qB4OQIYw3Ev5 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (jObject["scope"].ToString().Split(' ').ToList()
					.Exists(_003C_003Ec.gVlvEgGUUkZ ?? (_003C_003Ec.gVlvEgGUUkZ = _003C_003Ec.BZ1vEtV2Tti.uQ5vPzM8DN5)))
				{
					IsDev = true;
					Token = (string?)jObject["access_token"];
				}
			}
			HasDoneAuthoried = true;
		}
	}

	protected virtual bool NeetAuth()
	{
		if (HasDoneAuthoried)
		{
			if (!IsDev)
			{
				return false;
			}
			return DateTime.Now >= ExpireAt;
		}
		return true;
	}

	protected void PreAction()
	{
		if (!UserServerAuth)
		{
			DoAuthorization();
		}
	}

	protected virtual JObject PostAction(AipHttpRequest aipReq)
	{
		RawResult = "";
		string text = (RawResult = SendRequet(aipReq));
		JObject jObject;
		try
		{
			jObject = JsonConvert.DeserializeObject(text) as JObject;
		}
		catch (Exception ex)
		{
			throw new AipException(ex.Message + ": " + text);
		}
		if (jObject == null)
		{
			throw new AipException("Empty response, please check input");
		}
		return jObject;
	}

	protected virtual HttpWebRequest GenerateWebRequest(AipHttpRequest aipRequest)
	{
		if (!IsDev)
		{
			if (!UserServerAuth)
			{
				return aipRequest.GenerateCloudRequest(ApiKey, SecretKey, Timeout);
			}
			return aipRequest.GenerateCloudRequestWithServerAuth(Timeout);
		}
		return aipRequest.GenerateDevWebRequest(Token, Timeout);
	}

	protected string SendRequet(AipHttpRequest aipRequest)
	{
		return Utils.StreamToString(SendRequetRaw(aipRequest).GetResponseStream(), aipRequest.ContentEncoding);
	}

	protected HttpWebResponse SendRequetRaw(AipHttpRequest aipRequest)
	{
		HttpWebRequest httpWebRequest = GenerateWebRequest(aipRequest);
		Log(httpWebRequest.RequestUri.ToString());
		HttpWebResponse httpWebResponse;
		try
		{
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			throw new AipException((int)ex.Status, ex.Message);
		}
		if (httpWebResponse.StatusCode != HttpStatusCode.OK)
		{
			throw new AipException((int)httpWebResponse.StatusCode, "Server response code：" + (int)httpWebResponse.StatusCode);
		}
		return httpWebResponse;
	}

	protected void CheckNotNull(object obj, string name)
	{
		if (obj == null)
		{
			throw new AipException(name + " cannot be null.");
		}
	}

	protected string ImagesToParams(IEnumerable<byte[]> images)
	{
		return images.Select(_003C_003EO.RKbvPffM2EU ?? (_003C_003EO.RKbvPffM2EU = Convert.ToBase64String)).Aggregate(_003C_003Ec.yY5vELrhQXE ?? (_003C_003Ec.yY5vELrhQXE = _003C_003Ec.BZ1vEtV2Tti.zmJvEwncCqY));
	}

	protected string StrJoin(IEnumerable<string> data, string sep = ",")
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.J70vES2Gmp2 = sep;
		return data.Aggregate(_003C_003Ec__DisplayClass50_.fX6vEvwguLb);
	}

	protected virtual void Log(string msg)
	{
		if (DebugLog)
		{
			DateTime.Now.ToString("[yyyyMMdd HH:mm:ss]");
		}
	}

	public JObject Report(IEnumerable<Dictionary<string, object>> data)
	{
		AipHttpRequest aipHttpRequest = new AipHttpRequest("https://aip.baidubce.com/rpc/2.0/feedback/v1/report")
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Json
		};
		CheckNotNull(data, "data");
		aipHttpRequest.Bodys["feedback"] = data;
		PreAction();
		return PostAction(aipHttpRequest);
	}

	internal static void E89vCT2Z4Z0FEkNnm2W()
	{
	}

	internal static bool GnKFxY2iSVJOwePlUHh()
	{
		return TOPpXZ2qB4OQIYw3Ev5 == null;
	}
}
