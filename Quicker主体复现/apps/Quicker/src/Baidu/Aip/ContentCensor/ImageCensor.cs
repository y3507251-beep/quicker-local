using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.ContentCensor;

public class ImageCensor : Base
{
	public const string USER_DEFINED = "https://aip.baidubce.com/rest/2.0/solution/v1/img_censor/v2/user_defined";

	private static ImageCensor D9fu8IATwZoQU8UXcex;

	public ImageCensor(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	public JObject UserDefined(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/solution/v1/img_censor/v2/user_defined");
		CheckNotNull(image, "image");
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

	public JObject UserDefinedUrl(string imageUrl, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/solution/v1/img_censor/v2/user_defined");
		CheckNotNull(imageUrl, "imageUrl");
		aipHttpRequest.Bodys["imgUrl"] = imageUrl;
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

	internal static bool pFnVvxAmEarBwYjNt1E()
	{
		return D9fu8IATwZoQU8UXcex == null;
	}
}
