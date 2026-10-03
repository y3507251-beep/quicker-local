using System;

namespace Cuiliang.AliyunOssSdk.Utility;

public class Ensure
{
	internal static Ensure VYC065n9ct5twuLGZA5;

	public static void NotNull(object argValue, string argName)
	{
		if (argValue == null)
		{
			throw new ArgumentNullException(argName + " 不应为空！");
		}
	}

	public static void NotEqZero(long argValue, string argName)
	{
		if (argValue == 0L)
		{
			throw new ArgumentNullException(argName + " 不应为0！");
		}
	}

	public static void ToBeTrue(bool value, string message = null)
	{
		if (!value)
		{
			throw new ArgumentException(string.IsNullOrWhiteSpace(message) ? "数据不符合要求" : message);
		}
	}

	public static void NotEmpty(string value, string paramName)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new ArgumentOutOfRangeException("参数 " + paramName + " 不应该为空.");
		}
	}

	public static void UriNotEmpty(Uri uri, string paramName)
	{
		if (uri == null || string.IsNullOrEmpty(uri.Host))
		{
			throw new ArgumentOutOfRangeException("参数 " + paramName + " 不应该为空.");
		}
	}

	internal static bool gcbuCKnLg3UV9nkAxm5()
	{
		return VYC065n9ct5twuLGZA5 == null;
	}
}
