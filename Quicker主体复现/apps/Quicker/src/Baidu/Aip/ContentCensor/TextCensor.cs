using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.ContentCensor;

public class TextCensor : AipServiceBase
{
	private static TextCensor RBNdaAAhAN5GmAvoIQ9;

	public TextCensor(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Formed,
			ContentEncoding = Encoding.GetEncoding("UTF-8")
		};
	}

	[Obsolete("AntiSpam is deprecated.")]
	public JObject AntiSpam(string content, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/antispam/v2/spam");
		aipHttpRequest.Bodys["content"] = content;
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

	public JObject TextCensorUserDefined(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/solution/v1/text_censor/v2/user_defined");
		aipHttpRequest.Bodys["text"] = text;
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

	internal static bool z9kQ4JAHGVLoHdZJsr6()
	{
		return RBNdaAAhAN5GmAvoIQ9 == null;
	}
}
