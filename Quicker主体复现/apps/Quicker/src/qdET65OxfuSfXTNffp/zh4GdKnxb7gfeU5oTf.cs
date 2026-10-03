using System;
using System.Globalization;

namespace qdET65OxfuSfXTNffp;

internal static class zh4GdKnxb7gfeU5oTf
{
	internal static object TkGpB3naMxUGPwdIIST;

	public static string YoHSowUI1T(DateTime dateTime_0)
	{
		return dateTime_0.ToUniversalTime().ToString("ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T", CultureInfo.InvariantCulture);
	}

	public static DateTime cf4ST5pSMC(string string_0)
	{
		return DateTime.SpecifyKind(DateTime.ParseExact(string_0, "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T", CultureInfo.InvariantCulture), DateTimeKind.Utc);
	}

	public static string PV8SMtmG9e(DateTime dateTime_0)
	{
		return dateTime_0.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.CurrentCulture);
	}

	internal static bool EUy9GXnrtEvvc770IKu()
	{
		return TkGpB3naMxUGPwdIIST == null;
	}
}
