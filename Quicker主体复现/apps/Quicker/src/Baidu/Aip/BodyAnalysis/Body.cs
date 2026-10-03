using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.BodyAnalysis;

public class Body : AipServiceBase
{
	private static Body TJE4aunV7GfimVjlWQM;

	public Body(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Formed,
			ContentEncoding = Encoding.UTF8
		};
	}

	public JObject BodyAnalysis(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/body_analysis");
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

	public JObject BodyAttr(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/body_attr");
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

	public JObject BodyNum(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/body_num");
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

	public JObject Gesture(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/gesture");
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

	public JObject BodySeg(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/body_seg");
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

	public JObject DriverBehavior(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/driver_behavior");
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

	public JObject BodyTracking(byte[] image, string dynamic, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/body_tracking");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
		aipHttpRequest.Bodys["dynamic"] = dynamic;
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

	internal static bool fNpDX1nQxv0kXgNZM76()
	{
		return TJE4aunV7GfimVjlWQM == null;
	}
}
