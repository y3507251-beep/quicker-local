using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.ContentCensor;

public class Solution : Base
{
	public const string ComboUrl = "https://aip.baidubce.com/api/v1/solution/direct/img_censor";

	public const string FaceAuditUri = "https://aip.baidubce.com/rest/2.0/solution/v1/face_audit";

	private static Solution xSBbK7ACf59HnAt6iBB;

	public Solution(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected new AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Json
		};
	}

	private JObject xnLSpNF5uD(AipHttpRequest aipHttpRequest_0, string[] string_5, Dictionary<string, object> dictionary_0)
	{
		aipHttpRequest_0.Bodys.Add("scenes", string_5);
		if (dictionary_0 != null)
		{
			dictionary_0.Remove("image");
			dictionary_0.Remove("imageUrl");
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (KeyValuePair<string, object> item in dictionary_0)
			{
				if (item.Value is string)
				{
					dictionary.Add(item.Key, item.Value);
				}
				else
				{
					dictionary.Add(item.Key, JsonConvert.SerializeObject(item.Value));
				}
			}
			aipHttpRequest_0.Bodys.Add("scenesConf", dictionary);
		}
		return PostAction(aipHttpRequest_0);
	}

	public JObject Combo(string imageUrl, string[] scenes, Dictionary<string, object> options = null)
	{
		CheckNotNull(imageUrl, "imageUrl");
		PreAction();
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/api/v1/solution/direct/img_censor");
		aipHttpRequest.Bodys.Add("imgUrl", imageUrl);
		return xnLSpNF5uD(aipHttpRequest, scenes, options);
	}

	public JObject Combo(byte[] image, string[] scenes, Dictionary<string, object> options = null)
	{
		CheckNotNull(image, "image");
		PreAction();
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/api/v1/solution/direct/img_censor");
		aipHttpRequest.Bodys.Add("image", Convert.ToBase64String(image));
		return xnLSpNF5uD(aipHttpRequest, scenes, options);
	}

	public JObject FaceAudit(byte[][] images, long? configId = null)
	{
		CheckNotNull(images, "images");
		PreAction();
		AipHttpRequest aipHttpRequest = new AipHttpRequest("https://aip.baidubce.com/rest/2.0/solution/v1/face_audit")
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Formed
		};
		if (configId.HasValue)
		{
			aipHttpRequest.Bodys.Add("configId", configId);
		}
		aipHttpRequest.Bodys.Add("images", ImagesToParams(images));
		return PostAction(aipHttpRequest);
	}

	public JObject FaceAudit(string[] images, long? configId = null)
	{
		CheckNotNull(images, "images");
		PreAction();
		AipHttpRequest aipHttpRequest = new AipHttpRequest("https://aip.baidubce.com/rest/2.0/solution/v1/face_audit")
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Formed
		};
		if (configId.HasValue)
		{
			aipHttpRequest.Bodys.Add("configId", configId);
		}
		aipHttpRequest.Bodys.Add("imgUrls", StrJoin(images));
		return PostAction(aipHttpRequest);
	}

	internal static bool HdPAqTA76M0kNvuqVq9()
	{
		return xSBbK7ACf59HnAt6iBB == null;
	}
}
