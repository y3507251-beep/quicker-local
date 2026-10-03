using System;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.ContentCensor;

public class AntiPorn : Base
{
	public const string ANTI_PORN_URL = "https://aip.baidubce.com/rest/2.0/antiporn/v1/detect";

	public const string ANTI_PORN_GIF_URL = "https://aip.baidubce.com/rest/2.0/antiporn/v1/detect_gif";

	private static AntiPorn OaTbluAPQbVyb0iFM09;

	public AntiPorn(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	public JObject Detect(byte[] image)
	{
		CheckNotNull(image, "image");
		PreAction();
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/antiporn/v1/detect");
		aipHttpRequest.Bodys.Add("image", Convert.ToBase64String(image));
		return PostAction(aipHttpRequest);
	}

	public JObject DetectGif(byte[] image)
	{
		CheckNotNull(image, "image");
		PreAction();
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/antiporn/v1/detect_gif");
		aipHttpRequest.Bodys.Add("image", Convert.ToBase64String(image));
		return PostAction(aipHttpRequest);
	}

	internal static bool bcB6fMAMj3AG7nX7Ak6()
	{
		return OaTbluAPQbVyb0iFM09 == null;
	}
}
