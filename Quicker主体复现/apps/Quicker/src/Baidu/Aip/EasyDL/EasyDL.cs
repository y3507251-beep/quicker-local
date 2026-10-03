using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.EasyDL;

public class EasyDL : AipServiceBase
{
	private static EasyDL ng0jQrAYmpCuGqScl29;

	public EasyDL(string appId, string apiKey, string secretKey)
		: base(appId, apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Json,
			ContentEncoding = Encoding.UTF8
		};
	}

	public JObject requestImage(string fullurl, byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest(fullurl);
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject requestSound(string fullurl, byte[] sound, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest(fullurl);
		aipHttpRequest.Bodys["sound"] = Convert.ToBase64String(sound);
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	internal static void MUCJRLAgIjnFvJ10CnS()
	{
	}

	internal static bool lBlikeA8IR9H95xe5iO()
	{
		return ng0jQrAYmpCuGqScl29 == null;
	}
}
