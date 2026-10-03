using System.Collections.Specialized;

namespace Qiniu.Util;

public class Auth
{
	private Signature zAgeCppDkN;

	public AuthOptions AuthOptions;

	private static Auth MT0Pvt9TtHinOEJo4CK;

	public Auth(Mac mac, AuthOptions authOptions = null)
	{
		zAgeCppDkN = new Signature(mac);
		AuthOptions = authOptions;
		if (AuthOptions == null)
		{
			AuthOptions = new AuthOptions();
		}
	}

	public string CreateManageToken(string url, byte[] body)
	{
		return $"QBox {zAgeCppDkN.SignRequest(url, body)}";
	}

	public string CreateManageToken(string url)
	{
		return CreateManageToken(url, null);
	}

	public string CreateUploadToken(string jsonStr)
	{
		return zAgeCppDkN.SignWithData(jsonStr);
	}

	public string CreateDownloadToken(string url)
	{
		return zAgeCppDkN.Sign(url);
	}

	public string CreateStreamPublishToken(string path)
	{
		return zAgeCppDkN.Sign(path);
	}

	public string CreateStreamManageToken(string data)
	{
		return $"Qiniu {zAgeCppDkN.SignWithData(data)}";
	}

	public static string CreateManageToken(Mac mac, string url, byte[] body)
	{
		Signature signature = new Signature(mac);
		return $"QBox {signature.SignRequest(url, body)}";
	}

	public static string CreateManageToken(Mac mac, string url)
	{
		return CreateManageToken(mac, url, null);
	}

	public string CreateManageTokenV2(string method, string url, StringDictionary headers, string body = "")
	{
		return $"Qiniu {zAgeCppDkN.SignRequestV2(method, url, headers, body)}";
	}

	public string CreateManageTokenV2(string method, string url, string body = "")
	{
		return CreateManageTokenV2(method, url, null, body);
	}

	public static string CreateManageTokenV2(Mac mac, string method, string url, StringDictionary headers, string body = "")
	{
		Signature signature = new Signature(mac);
		return $"Qiniu {signature.SignRequestV2(method, url, headers, body)}";
	}

	public static string CreateUploadToken(Mac mac, string jsonBody)
	{
		return new Signature(mac).SignWithData(jsonBody);
	}

	public static string CreateDownloadToken(Mac mac, string url)
	{
		return new Signature(mac).Sign(url);
	}

	public static string CreateStreamPublishToken(Mac mac, string path)
	{
		return new Signature(mac).Sign(path);
	}

	public static string CreateStreamManageToken(Mac mac, string data)
	{
		Signature signature = new Signature(mac);
		return $"Qiniu {signature.Sign(data)}";
	}

	internal static bool Pj1YqZ9mHctVDcEuXxl()
	{
		return MT0Pvt9TtHinOEJo4CK == null;
	}
}
