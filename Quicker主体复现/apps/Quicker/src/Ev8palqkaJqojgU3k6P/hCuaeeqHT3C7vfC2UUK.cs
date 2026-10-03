using System;

namespace Ev8palqkaJqojgU3k6P;

internal static class hCuaeeqHT3C7vfC2UUK
{
	internal static object ojbOUvOXmlh6NsN5rW7;

	public static bool reY7dXL7B1(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0)
	{
		return timeZoneInfo_0.IsAmbiguousTime(dateTime_0.AddTicks(1L));
	}

	public static TimeSpan Rqo7oY8Muh(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0)
	{
		TimeSpan[] array = eV47FG8BL7(timeZoneInfo_0, dateTime_0);
		TimeSpan baseUtcOffset = timeZoneInfo_0.BaseUtcOffset;
		if (array[0] != baseUtcOffset)
		{
			return array[0];
		}
		return array[1];
	}

	public static DateTimeOffset ycC7TeSpuo(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0)
	{
		DateTime dateTime = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, dateTime_0.Hour, dateTime_0.Minute, 0, 0, dateTime_0.Kind);
		while (timeZoneInfo_0.IsInvalidTime(dateTime))
		{
			dateTime = dateTime.AddMinutes(1.0);
		}
		TimeSpan utcOffset = timeZoneInfo_0.GetUtcOffset(dateTime);
		return new DateTimeOffset(dateTime, utcOffset);
	}

	public static DateTimeOffset mQJ7MquE92(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0, TimeSpan timeSpan_0)
	{
		return new DateTimeOffset(wcZ7Um00uK(timeZoneInfo_0, dateTime_0), timeSpan_0).ToOffset(timeZoneInfo_0.BaseUtcOffset);
	}

	public static DateTimeOffset soM7AAI83D(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0)
	{
		return new DateTimeOffset(wcZ7Um00uK(timeZoneInfo_0, dateTime_0), timeZoneInfo_0.BaseUtcOffset);
	}

	public static DateTimeOffset wY97OV0MHc(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0, TimeSpan timeSpan_0)
	{
		return new DateTimeOffset(wcZ7Um00uK(timeZoneInfo_0, dateTime_0).AddTicks(-1L), timeSpan_0);
	}

	private static TimeSpan[] eV47FG8BL7(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0)
	{
		return timeZoneInfo_0.GetAmbiguousTimeOffsets(dateTime_0.AddTicks(1L));
	}

	private static DateTime wcZ7Um00uK(TimeZoneInfo timeZoneInfo_0, DateTime dateTime_0)
	{
		DateTime dateTime = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, dateTime_0.Hour, dateTime_0.Minute, 0, 0, dateTime_0.Kind);
		while (timeZoneInfo_0.IsAmbiguousTime(dateTime))
		{
			dateTime = dateTime.AddMinutes(1.0);
		}
		return dateTime;
	}

	internal static bool poEfdsO296SfakyWU5B()
	{
		return ojbOUvOXmlh6NsN5rW7 == null;
	}
}
