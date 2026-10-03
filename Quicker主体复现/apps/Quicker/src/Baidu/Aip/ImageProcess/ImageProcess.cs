using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.ImageProcess;

public class ImageProcess : AipServiceBase
{
	internal static ImageProcess Qd6pxUAucdcOWEtQZnR;

	public ImageProcess(string apiKey, string secretKey)
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

	public JObject ImageQualityEnhance(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-process/v1/image_quality_enhance");
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

	public JObject Dehaze(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-process/v1/dehaze");
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

	public JObject ContrastEnhance(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-process/v1/contrast_enhance");
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

	public JObject Colourize(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-process/v1/colourize");
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

	public JObject StretchRestore(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-process/v1/stretch_restore");
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

	internal static bool dQaIMsAovrw8OF5QeMv()
	{
		return Qd6pxUAucdcOWEtQZnR == null;
	}
}
