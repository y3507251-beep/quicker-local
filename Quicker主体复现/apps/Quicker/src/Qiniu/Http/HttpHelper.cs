using System;
using Qiniu.Util;

namespace Qiniu.Http;

public class HttpHelper
{
	public static string CONTENT_TYPE_TEXT_PLAIN;

	public static string CONTENT_TYPE_APP_JSON;

	public static string CONTENT_TYPE_APP_OCTET;

	public static string CONTENT_TYPE_WWW_FORM;

	public static string CONTENT_TYPE_MULTIPART;

	public static int STATUS_CODE_OK;

	public static int STATUS_CODE_PARTLY_OK;

	public static int STATUS_CODE_UNDEF;

	public static int STATUS_CODE_USER_CANCELED;

	public static int STATUS_CODE_USER_PAUSED;

	public static int STATUS_CODE_USER_RESUMED;

	public static int STATUS_CODE_NEED_RETRY;

	public static int STATUS_CODE_EXCEPTION;

	internal static HttpHelper pF7JG8bFUmrovD3IIer;

	public static string getUserAgent()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string arg = Environment.MachineName + "; " + oSVersion.Platform.ToString() + "; " + oSVersion.Version;
		return string.Format("{0}/{1} ({2})", "QiniuCSharpSDK", "8.3.0", arg);
	}

	public static string createFormDataBoundary()
	{
		string str = DateTime.UtcNow.Ticks.ToString();
		return string.Format("-------{0}Boundary{1}", "QiniuCSharpSDK", Hashing.CalcMD5(str));
	}

	static HttpHelper()
	{
		CONTENT_TYPE_TEXT_PLAIN = "text/plain";
		CONTENT_TYPE_APP_JSON = "application/json";
		CONTENT_TYPE_APP_OCTET = "application/octet-stream";
		CONTENT_TYPE_WWW_FORM = "application/x-www-form-urlencoded";
		CONTENT_TYPE_MULTIPART = "multipart/form-data";
		STATUS_CODE_OK = 200;
		STATUS_CODE_PARTLY_OK = 298;
		STATUS_CODE_UNDEF = -256;
		STATUS_CODE_USER_CANCELED = -255;
		STATUS_CODE_USER_PAUSED = -254;
		STATUS_CODE_USER_RESUMED = -253;
		STATUS_CODE_NEED_RETRY = -252;
		STATUS_CODE_EXCEPTION = -252;
	}

	internal static bool CKTNftbcuTm4gDFvlfV()
	{
		return pF7JG8bFUmrovD3IIer == null;
	}
}
