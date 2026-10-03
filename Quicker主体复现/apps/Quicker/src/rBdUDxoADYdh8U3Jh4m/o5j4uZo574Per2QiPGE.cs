using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using cF2s4eoj0xhjQv4UVon;
using Fuy7DkoWhCdS5kI9xhV;
using IgQBbvXMVdsN7GVNUxX;
using IHGJ4aXzANwCaRMsxRt;
using PpIbF8XpCC7OtfHsoeg;
using QCloud;
using QCloud.COS;

namespace rBdUDxoADYdh8U3Jh4m;

internal class o5j4uZo574Per2QiPGE : eco6AkXLfyZjRmP4RfT
{
	[CompilerGenerated]
	private string k3XgktU6tpg;

	[CompilerGenerated]
	private string T9Lgkgjtwe6;

	[CompilerGenerated]
	private string D57gkLlTsuj;

	[CompilerGenerated]
	private string PTVgkvsMGFM;

	[CompilerGenerated]
	private string JiJgkSmL6Cb;

	internal static o5j4uZo574Per2QiPGE xkO82ZQmdSqV9ZIakSNE;

	public string BucketName
	{
		[CompilerGenerated]
		get
		{
			return k3XgktU6tpg;
		}
		[CompilerGenerated]
		set
		{
			k3XgktU6tpg = value;
		}
	}

	public string Region
	{
		[CompilerGenerated]
		get
		{
			return T9Lgkgjtwe6;
		}
		[CompilerGenerated]
		set
		{
			T9Lgkgjtwe6 = value;
		}
	}

	public string AppId
	{
		[CompilerGenerated]
		get
		{
			return D57gkLlTsuj;
		}
		[CompilerGenerated]
		set
		{
			D57gkLlTsuj = value;
		}
	}

	public string SecretId
	{
		[CompilerGenerated]
		get
		{
			return PTVgkvsMGFM;
		}
		[CompilerGenerated]
		set
		{
			PTVgkvsMGFM = value;
		}
	}

	public string SecretKey
	{
		[CompilerGenerated]
		get
		{
			return JiJgkSmL6Cb;
		}
		[CompilerGenerated]
		set
		{
			JiJgkSmL6Cb = value;
		}
	}

	public void wGfMjLU4H76(IDictionary<string, string> idictionary_0)
	{
		BucketName = idictionary_0.kNjgWW5DqaP("BucketName");
		Region = idictionary_0.kNjgWW5DqaP("Region");
		AppId = idictionary_0.kNjgWW5DqaP("AppId");
		SecretId = idictionary_0.kNjgWW5DqaP("SecretId");
		SecretKey = idictionary_0.kNjgWW5DqaP("SecretKey");
	}

	public lKRt6fo20yPnP2ZloBB Upload(dqs3ZWowtqiy3yIfw7B request)
	{
		AppSettings conf = new AppSettings
		{
			AppId = AppId,
			SecretId = SecretId,
			SecretKey = SecretKey
		};
		using HttpClient backChannel = aFIptTXYsUoTUF4v33R.KtDt1YBndA5((int)(request.ExpireSeconds * 1000.0), false);
		Client client = new Client(conf, backChannel);
		string text = "https://" + BucketName + ".cos." + Region + ".myqcloud.com/" + request.nlTgkERQYHS();
		try
		{
			client.PutObjectAsync(text, request.Hitgkh0KOlt(), request.ContentType, request.zItgkI6Q4qG(), request.jDmgkVpsySE()).GetAwaiter().GetResult();
		}
		catch (RequestFailureException)
		{
			throw;
		}
		lKRt6fo20yPnP2ZloBB lKRt6fo20yPnP2ZloBB = new lKRt6fo20yPnP2ZloBB();
		lKRt6fo20yPnP2ZloBB.IsSuccess = true;
		lKRt6fo20yPnP2ZloBB.ErrorMessage = "";
		lKRt6fo20yPnP2ZloBB.H0JgkjiCUa2("");
		lKRt6fo20yPnP2ZloBB.sZkgkMvAYlF("");
		lKRt6fo20yPnP2ZloBB.l82gk5RYXIt(request.nlTgkERQYHS());
		lKRt6fo20yPnP2ZloBB.Url = text;
		return lKRt6fo20yPnP2ZloBB;
	}

	internal static bool yGK3ObQmOekE1j5HCdiU()
	{
		return xkO82ZQmdSqV9ZIakSNE == null;
	}
}
