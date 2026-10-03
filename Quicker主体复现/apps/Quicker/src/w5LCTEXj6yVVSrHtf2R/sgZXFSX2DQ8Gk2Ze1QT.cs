using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace w5LCTEXj6yVVSrHtf2R;

internal static class sgZXFSX2DQ8Gk2Ze1QT
{
	private static readonly HashSet<string> K8Pt1gjTwFc;

	internal static object CNWfZFQawmtegRaqUu9q;

	public static void IRAtHfKNUsU(string string_0, string string_1, object object_0, int int_0)
	{
		MemoryCache memoryCache = MemoryCache.Default;
		string text = string_0 + "_" + string_1;
		if (object_0 == null)
		{
			memoryCache.Remove(text);
			K8Pt1gjTwFc.Remove(text);
		}
		else
		{
			memoryCache.Set(text, object_0, DateTimeOffset.Now.AddSeconds(int_0));
			K8Pt1gjTwFc.Add(text);
		}
	}

	public static object YOAtHzKx8UL(string string_0, string string_1)
	{
		MemoryCache memoryCache = MemoryCache.Default;
		string text = string_0 + "_" + string_1;
		K8Pt1gjTwFc.Remove(text);
		return memoryCache.Remove(text);
	}

	public static void reLt1w0o395(string string_0)
	{
		MemoryCache memoryCache = MemoryCache.Default;
		foreach (string item in K8Pt1gjTwFc.ToList())
		{
			if (item.StartsWith(string_0))
			{
				K8Pt1gjTwFc.Remove(item);
				memoryCache.Remove(item);
			}
		}
	}

	public static object LMGt1tijCk4(string string_0, string string_1, object object_0 = null)
	{
		MemoryCache memoryCache = MemoryCache.Default;
		string text = string_0 + "_" + string_1;
		object obj = memoryCache.Get(text);
		if (obj == null)
		{
			K8Pt1gjTwFc.Remove(text);
			return object_0;
		}
		return obj;
	}

	static sgZXFSX2DQ8Gk2Ze1QT()
	{
		K8Pt1gjTwFc = new HashSet<string>();
	}

	internal static bool CxOaZRQaTOQCE1nbwe22()
	{
		return CNWfZFQawmtegRaqUu9q == null;
	}
}
