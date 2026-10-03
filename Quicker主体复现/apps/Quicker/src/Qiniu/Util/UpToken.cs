using System;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Storage;

namespace Qiniu.Util;

public class UpToken
{
	internal static UpToken YL7JWaLicDLFi5ectXS;

	public static string GetAccessKeyFromUpToken(string upToken)
	{
		string result = null;
		string[] array = upToken.Split(':');
		if (array.Length == 3)
		{
			result = array[0];
		}
		return result;
	}

	public static string GetBucketFromUpToken(string upToken)
	{
		string result = null;
		string[] array = upToken.Split(':');
		if (array.Length == 3)
		{
			string text = array[2];
			try
			{
				string[] array2 = JsonConvert.DeserializeObject<PutPolicy>(Encoding.UTF8.GetString(Base64.UrlsafeBase64Decode(text))).Scope.Split(':');
				if (array2.Length >= 1)
				{
					result = array2[0];
				}
			}
			catch (Exception)
			{
			}
		}
		return result;
	}

	internal static bool tIq8kDLl5MGILR8Aj52()
	{
		return YL7JWaLicDLFi5ectXS == null;
	}
}
