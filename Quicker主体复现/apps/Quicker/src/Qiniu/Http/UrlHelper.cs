using System.Text.RegularExpressions;

namespace Qiniu.Http;

public class UrlHelper
{
	private static Regex bBVWlyQm3J;

	private static Regex sIJWiMe7NS;

	private static Regex pKFW3Oo3XD;

	internal static UrlHelper C9Io87bxDccyo5p2ySM;

	public static bool isValidUrl(string _url)
	{
		return bBVWlyQm3J.IsMatch(_url);
	}

	public static bool isNormalUrl(string _url)
	{
		return sIJWiMe7NS.IsMatch(_url);
	}

	public static bool isValidDir(string _dir)
	{
		return pKFW3Oo3XD.IsMatch(_dir);
	}

	public static string getNormalUrl(string _url)
	{
		return sIJWiMe7NS.Match(_url).Value;
	}

	public static void urlSplit(string url, out string host, out string path, out string file, out string query)
	{
		int num = 0;
		Regex regex = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+");
		host = regex.Match(url, 0).Value;
		num = 0 + host.Length;
		if (C9Io87bxDccyo5p2ySM == null)
		{
			switch (0)
			{
			}
		}
		Regex regex2 = new Regex("(/(\\w|\\-)*)+/");
		path = regex2.Match(url, num).Value;
		if (string.IsNullOrEmpty(path))
		{
			path = "/";
		}
		num += path.Length;
		int num2 = url.IndexOf('?', num);
		file = url.Substring(num, num2 - num);
		query = url.Substring(num2);
	}

	static UrlHelper()
	{
		bBVWlyQm3J = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,@?^=%&amp;:/~\\+#]*[\\w\\-\\@?^=%&amp;/~\\+#])?");
		sIJWiMe7NS = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,/~\\+#]*)?");
		pKFW3Oo3XD = new Regex("(http|https):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,/~\\+#]*)?/");
	}

	internal static bool ivHILJbIeregZvIpOst()
	{
		return C9Io87bxDccyo5p2ySM == null;
	}
}
