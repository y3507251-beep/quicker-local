using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.Speech;

public class Base : AipServiceBase
{
	internal static Base dlVkJr2hbQlOt0QSkCG;

	protected string Cuid => Utils.Md5(base.Token);

	public Base(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
		IsDev = true;
	}

	public Base(string appId, string apiKey, string secretKey)
		: base(appId, apiKey, secretKey)
	{
		IsDev = true;
	}

	protected override void DoAuthorization()
	{
		lock (AuthLock)
		{
			if (NeetAuth())
			{
				JObject jObject = Auth.OpenApiFetchToken(base.ApiKey, base.SecretKey, true);
				base.ExpireAt = DateTime.Now.AddSeconds((int)jObject["expires_in"] - 1);
				IsDev = true;
				base.Token = (string?)jObject["access_token"];
				HasDoneAuthoried = true;
			}
		}
	}

	protected override HttpWebRequest GenerateWebRequest(AipHttpRequest aipRequest)
	{
		return aipRequest.GenerateSpeechRequest(base.Timeout);
	}

	internal static bool sfluNK2H07SnKQqQP4J()
	{
		return dlVkJr2hbQlOt0QSkCG == null;
	}

	internal static void kP1vYBAV0oObEjBuOBG()
	{
	}
}
