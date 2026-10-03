using System;
using System.Runtime.CompilerServices;

namespace QCloud.COS;

public sealed class Bucket
{
	[CompilerGenerated]
	private readonly string JgUhUti92U;

	[CompilerGenerated]
	private readonly string KX5hlq3q2Y;

	[CompilerGenerated]
	private readonly string aKZhiKX6yN;

	private static Bucket tSxr8N9qwOA4fKoOTHV;

	public string AppId
	{
		[CompilerGenerated]
		get
		{
			return JgUhUti92U;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return KX5hlq3q2Y;
		}
	}

	public string Region
	{
		[CompilerGenerated]
		get
		{
			return aKZhiKX6yN;
		}
	}

	public string Url
	{
		get
		{
			if (string.IsNullOrEmpty(AppId))
			{
				throw new InvalidOperationException("AppId is null.");
			}
			if (string.IsNullOrEmpty(Name))
			{
				throw new InvalidOperationException("Name is null.");
			}
			if (string.IsNullOrEmpty(Region))
			{
				throw new InvalidOperationException("Region is null.");
			}
			return "https://" + Name + "-" + AppId + ".cos." + Region + ".myqcloud.com";
		}
	}

	public Bucket(string appId, string name, string region)
	{
		JgUhUti92U = appId;
		KX5hlq3q2Y = name;
		aKZhiKX6yN = region;
	}

	public override string ToString()
	{
		return Url;
	}

	public static Bucket ParseURL(string url)
	{
		string[] array = new Uri(url).Host.Split('.');
		if (array.Length != 5)
		{
			throw new ArgumentException("Invalid bucket url.", "url");
		}
		int num = array[0].LastIndexOf("-");
		return new Bucket(array[0].Substring(num + 1), array[0].Substring(0, num), array[2]);
	}

	internal static bool CW3Mrf9iJSdHTGZm4uH()
	{
		return tSxr8N9qwOA4fKoOTHV == null;
	}
}
