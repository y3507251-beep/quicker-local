using System;
using System.Text.RegularExpressions;

namespace Qiniu.Util;

public class UrlHelper
{
	private static Regex CF4escQKIM;

	private static Regex xgaeHvHMgY;

	private static Regex cume1IB6BC;

	internal static UrlHelper yJHuXOLYvtWoS05PiPT;

	public static bool IsValidUrl(string _url)
	{
		return CF4escQKIM.IsMatch(_url);
	}

	public static bool IsNormalUrl(string _url)
	{
		return xgaeHvHMgY.IsMatch(_url);
	}

	public static bool IsValidDir(string _dir)
	{
		return cume1IB6BC.IsMatch(_dir);
	}

	public static string GetNormalUrl(string _url)
	{
		return xgaeHvHMgY.Match(_url).Value;
	}

	public static void UrlSplit(string url, out string host, out string path, out string file, out string query)
	{
		host = "";
		path = "";
		file = "";
		query = "";
		if (string.IsNullOrEmpty(url))
		{
			return;
		}
		int num = 0;
		try
		{
			Regex regex = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+");
			host = regex.Match(url, num).Value;
			num += host.Length;
			if (!mjlXDgL8GagQTNuRAiu())
			{
				switch (0)
				{
				}
			}
			Regex regex2 = new Regex("(/(\\w|\\-)*)+/");
			path = regex2.Match(url, num).Value;
			if (!string.IsNullOrEmpty(path))
			{
				num += path.Length;
			}
			int num2 = url.IndexOf('?', num);
			if (num2 > 0)
			{
				file = url.Substring(num, num2 - num);
				query = url.Substring(num2);
			}
			else
			{
				file = url.Substring(num);
				query = "";
			}
		}
		catch (Exception)
		{
		}
	}

	static UrlHelper()
	{
		CF4escQKIM = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,@?^=%&amp;:/~\\+#]*[\\w\\-\\@?^=%&amp;/~\\+#])?");
		xgaeHvHMgY = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,/~\\+#]*)?");
		cume1IB6BC = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,/~\\+#]*)?/");
	}

	internal static bool mjlXDgL8GagQTNuRAiu()
	{
		return yJHuXOLYvtWoS05PiPT == null;
	}
}
