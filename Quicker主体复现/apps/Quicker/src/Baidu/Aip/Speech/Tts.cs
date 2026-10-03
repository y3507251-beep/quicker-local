using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.Speech;

public class Tts : Base
{
	internal static Tts IObAu1AeTIx1330sonR;

	public Tts(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Formed
		};
	}

	public TtsResponse Synthesis(string text, Dictionary<string, object> options = null)
	{
		PreAction();
		CheckNotNull(text, "text");
		AipHttpRequest aipHttpRequest = DefaultRequest("http://tsn.baidu.com/text2audio");
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		if (!aipHttpRequest.Bodys.ContainsKey("cuid"))
		{
			aipHttpRequest.Bodys["cuid"] = base.Cuid;
		}
		if (!aipHttpRequest.Bodys.ContainsKey("lang"))
		{
			aipHttpRequest.Bodys["lan"] = "zh";
		}
		if (!aipHttpRequest.Bodys.ContainsKey("ctp"))
		{
			aipHttpRequest.Bodys["ctp"] = 1;
		}
		aipHttpRequest.Bodys["tok"] = base.Token;
		aipHttpRequest.Bodys["tex"] = text;
		return PostAction(aipHttpRequest);
	}

	protected new TtsResponse PostAction(AipHttpRequest aipReq)
	{
		TtsResponse ttsResponse = new TtsResponse();
		HttpWebResponse httpWebResponse = SendRequetRaw(aipReq);
		if (httpWebResponse.ContentType.ToLower() == "application/json")
		{
			string text = Utils.StreamToString(httpWebResponse.GetResponseStream(), Encoding.UTF8);
			try
			{
				JObject jObject = JsonConvert.DeserializeObject(text) as JObject;
				ttsResponse.ErrorCode = (int)jObject["err_no"];
				ttsResponse.ErrorMsg = (string?)jObject["err_msg"];
				if (jObject.TryGetValue("sn", out JToken value))
				{
					ttsResponse.Sn = value.ToString();
				}
				if (jObject.TryGetValue("idx", out value))
				{
					ttsResponse.Idx = int.Parse(value.ToString());
				}
			}
			catch (Exception ex)
			{
				throw new AipException(ex.Message + ": " + text);
			}
		}
		else
		{
			ttsResponse.ErrorCode = 0;
			ttsResponse.Data = Utils.StreamToBytes(httpWebResponse.GetResponseStream());
		}
		return ttsResponse;
	}

	internal static bool eb3ujeAjSDm0360IpYK()
	{
		return IObAu1AeTIx1330sonR == null;
	}
}
