using System;
using System.Text;

namespace Qiniu.Util;

public class Base64
{
	private static Base64 LQUCTp9CeNDgA1JkNbT;

	public static string UrlSafeBase64Encode(string text)
	{
		return UrlSafeBase64Encode(Encoding.UTF8.GetBytes(text));
	}

	public static string UrlSafeBase64Encode(byte[] data)
	{
		return Convert.ToBase64String(data).Replace('+', '-').Replace('/', '_');
	}

	public static string UrlSafeBase64Encode(string bucket, string key)
	{
		return UrlSafeBase64Encode(bucket + ":" + key);
	}

	public static byte[] UrlsafeBase64Decode(string text)
	{
		return Convert.FromBase64String(text.Replace('-', '+').Replace('_', '/'));
	}

	public static string GetEncodedObjectName(string key)
	{
		string result = "~";
		if (key != null)
		{
			result = UrlSafeBase64Encode(key);
		}
		return result;
	}

	internal static bool WW3FiS97VBRyjSmeOm2()
	{
		return LQUCTp9CeNDgA1JkNbT == null;
	}
}
