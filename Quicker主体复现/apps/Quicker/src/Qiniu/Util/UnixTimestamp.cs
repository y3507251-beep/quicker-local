using System;

namespace Qiniu.Util;

public class UnixTimestamp
{
	private static DateTime FoyeGNSFRv;

	internal static UnixTimestamp JgAJhPLoDOcIWemOT5S;

	public static long GetUnixTimestamp(long secondsAfterNow)
	{
		return DateTime.Now.AddSeconds(secondsAfterNow).ToLocalTime().Subtract(FoyeGNSFRv)
			.Ticks / 10000000L;
	}

	public static long ConvertToTimestamp(DateTime dt)
	{
		return dt.Subtract(FoyeGNSFRv).Ticks / 10000000L;
	}

	public static DateTime ConvertToDateTime(string timestamp)
	{
		long value = long.Parse(timestamp) * 10000000L;
		return FoyeGNSFRv.AddTicks(value);
	}

	public static DateTime ConvertToDateTime(long timestamp)
	{
		long value = timestamp * 10000000L;
		return FoyeGNSFRv.AddTicks(value);
	}

	public static bool IsContextExpired(long expiredAt)
	{
		if (expiredAt == 0L)
		{
			return false;
		}
		bool result = false;
		if (ConvertToTimestamp(DateTime.Now.AddDays(1.0)) > expiredAt)
		{
			result = true;
		}
		return result;
	}

	static UnixTimestamp()
	{
		FoyeGNSFRv = new DateTime(1970, 1, 1).ToLocalTime();
	}

	internal static bool wJWgZLLfhPE0aINa4F9()
	{
		return JgAJhPLoDOcIWemOT5S == null;
	}
}
