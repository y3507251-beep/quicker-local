using System;

namespace Quicker.Utilities.Ext;

public static class FileSizeHelper
{
	private static readonly string[] NCaLi6apC2j;

	private static object fouqPwFIr9XbOC2SiEoZ;

	public static string ToReadableSize(this long len)
	{
		int num = 0;
		double num2 = len;
		while (!(num2 < 1024.0) && num < NCaLi6apC2j.Length - 1)
		{
			num++;
			num2 /= 1024.0;
		}
		return $"{num2:0.##} {NCaLi6apC2j[num]}";
	}

	public static string BytesToString(long byteCount)
	{
		string[] array = new string[7] { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
		if (byteCount == 0L)
		{
			return "0" + array[0];
		}
		long num = Math.Abs(byteCount);
		int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
		double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
		return (double)Math.Sign(byteCount) * num3 + array[num2];
	}

	static FileSizeHelper()
	{
		NCaLi6apC2j = new string[5] { "B", "KB", "MB", "GB", "TB" };
	}

	internal static bool WCnTVQFINIQuaTakCmqv()
	{
		return fouqPwFIr9XbOC2SiEoZ == null;
	}

	internal static void D5twDYFIL3Gbadwjxbfq()
	{
	}
}
