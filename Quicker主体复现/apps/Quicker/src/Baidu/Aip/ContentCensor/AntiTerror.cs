using System;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.ContentCensor;

public class AntiTerror : Base
{
	public const string ANTI_TERROR = "https://aip.baidubce.com/rest/2.0/antiterror/v1/detect";

	private static AntiTerror ovRCkBAxqDsORiwA7Ky;

	public AntiTerror(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	public JObject Detect(byte[] image)
	{
		CheckNotNull(image, "image");
		PreAction();
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/antiterror/v1/detect");
		aipHttpRequest.Bodys.Add("image", Convert.ToBase64String(image));
		return PostAction(aipHttpRequest);
	}

	internal static bool Whio7nAIPUny51SYuHW()
	{
		return ovRCkBAxqDsORiwA7Ky == null;
	}
}
