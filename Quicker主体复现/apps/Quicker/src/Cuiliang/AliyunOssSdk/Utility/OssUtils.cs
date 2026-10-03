using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using bEVZu13wruQIEh71Lv;

namespace Cuiliang.AliyunOssSdk.Utility;

public static class OssUtils
{
	public const long MaxFileSize = 5368709120L;

	public const int MaxPrefixStringSize = 1024;

	public const int MaxMarkerStringSize = 1024;

	public const int MaxDelimiterStringSize = 1024;

	public const int MaxReturnedKeys = 1000;

	public const int DeleteObjectsUpperLimit = 1000;

	public const int BucketCorsRuleLimit = 10;

	public const int LifecycleRuleLimit = 1000;

	public const int ObjectNameLengthLimit = 1023;

	public const int PartNumberUpperLimit = 10000;

	public const long DefaultPartSize = 8388608L;

	public const long PartSizeLowerLimit = 102400L;

	internal static object TjNf19nRWNU5b1L3GH4;

	public static bool IsBucketNameValid(string bucketName)
	{
		if (string.IsNullOrEmpty(bucketName))
		{
			return false;
		}
		return new Regex("^[a-z0-9][a-z0-9\\-]{1,61}[a-z0-9]$").Match(bucketName).Success;
	}

	public static bool IsObjectKeyValid(string key)
	{
		if (!string.IsNullOrEmpty(key) && !key.StartsWith("/") && !key.StartsWith("\\"))
		{
			return Encoding.GetEncoding("utf-8").GetByteCount(key) <= 1023;
		}
		return false;
	}

	public static string UrlEncodeKey(string key)
	{
		string[] array = key.Split('/');
		StringBuilder stringBuilder = new StringBuilder();
		if (!HrH9Ekngn0fnmqMqorN())
		{
			switch (0)
			{
			}
		}
		stringBuilder.Append(bThfW9sYygwxKofgvb.RxiSOGgt5P(array[0], "utf-8"));
		for (int i = 1; i < array.Length; i++)
		{
			stringBuilder.Append('/').Append(bThfW9sYygwxKofgvb.RxiSOGgt5P(array[i], "utf-8"));
		}
		if (key.EndsWith('/'.ToString()))
		{
			for (int j = 0; j < key.Length && key[j] == '/'; j++)
			{
				stringBuilder.Append('/');
			}
		}
		return stringBuilder.ToString();
	}

	public static string TrimQuotes(string eTag)
	{
		return eTag?.Trim('"');
	}

	public static string ComputeContentMd5(Stream input, long partSize)
	{
		using MD5 mD = MD5.Create();
		int num = (int)partSize;
		long position = input.Position;
		byte[] buffer = new byte[num];
		num = input.Read(buffer, 0, num);
		byte[] array = mD.ComputeHash(buffer, 0, num);
		char[] array2 = "0123456789ABCDEF".ToCharArray();
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array3 = array;
		int num3 = default(int);
		foreach (byte b in array3)
		{
			int num2 = 0;
			if (TjNf19nRWNU5b1L3GH4 != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			stringBuilder.Append(array2[b >> 4]);
			stringBuilder.Append(array2[b & 0xF]);
		}
		input.Seek(position, SeekOrigin.Begin);
		return Convert.ToBase64String(array);
	}

	public static byte[] ComputeContentMd5(string content)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(content);
		return mD.ComputeHash(bytes);
	}

	public static bool IsWebpageValid(string webpage)
	{
		if (!string.IsNullOrEmpty(webpage) && webpage.EndsWith(".html"))
		{
			return webpage.Length > ".html".Length;
		}
		return false;
	}

	public static bool IsLoggingPrefixValid(string loggingPrefix)
	{
		if (string.IsNullOrEmpty(loggingPrefix))
		{
			return true;
		}
		return new Regex("^[a-zA-Z][a-zA-Z0-9\\-]{0,31}$").Match(loggingPrefix).Success;
	}

	internal static string eMJS3BGHKE(string string_0, string string_1)
	{
		return "/" + string_0 + "/" + UrlEncodeKey(string_1);
	}

	internal static string b6cSfpteLx(string string_0, string string_1)
	{
		return "/" + string_0 + "/" + UrlEncodeKey(string_1);
	}

	internal static bool bUGSz0DtiY(int? nullable_0)
	{
		if (nullable_0.HasValue && nullable_0 > 0)
		{
			return nullable_0 <= 10000;
		}
		return false;
	}

	internal static string I7l2wDmAua(IEnumerable<string> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (string item in ienumerable_0)
		{
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(item);
			flag = false;
		}
		return stringBuilder.ToString();
	}

	public static string TrimETag(string eTag)
	{
		return eTag?.Trim('"');
	}

	internal static bool HrH9Ekngn0fnmqMqorN()
	{
		return TjNf19nRWNU5b1L3GH4 == null;
	}
}
