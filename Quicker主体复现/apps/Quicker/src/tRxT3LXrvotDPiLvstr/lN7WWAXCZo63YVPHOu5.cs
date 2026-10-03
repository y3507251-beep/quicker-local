using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using cF2s4eoj0xhjQv4UVon;
using Cuiliang.AliyunOssSdk;
using Cuiliang.AliyunOssSdk.Api;
using Cuiliang.AliyunOssSdk.Api.Object.Put;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;
using Fuy7DkoWhCdS5kI9xhV;
using IgQBbvXMVdsN7GVNUxX;
using IHGJ4aXzANwCaRMsxRt;
using PpIbF8XpCC7OtfHsoeg;

namespace tRxT3LXrvotDPiLvstr;

internal class lN7WWAXCZo63YVPHOu5 : eco6AkXLfyZjRmP4RfT
{
	[CompilerGenerated]
	private string F4MgIzrcBXy;

	[CompilerGenerated]
	private string h3HgWwM1sdW;

	[CompilerGenerated]
	private string p6qgWtDAkmo;

	[CompilerGenerated]
	private string vJFgWgM7y4a;

	private static lN7WWAXCZo63YVPHOu5 DlhvqVQTT5cEGkm8Meqg;

	public string Endpoint
	{
		[CompilerGenerated]
		get
		{
			return F4MgIzrcBXy;
		}
		[CompilerGenerated]
		set
		{
			F4MgIzrcBXy = value;
		}
	}

	public string AccessKey
	{
		[CompilerGenerated]
		get
		{
			return h3HgWwM1sdW;
		}
		[CompilerGenerated]
		set
		{
			h3HgWwM1sdW = value;
		}
	}

	public string AccessKeySecret
	{
		[CompilerGenerated]
		get
		{
			return p6qgWtDAkmo;
		}
		[CompilerGenerated]
		set
		{
			p6qgWtDAkmo = value;
		}
	}

	public string BucketName
	{
		[CompilerGenerated]
		get
		{
			return vJFgWgM7y4a;
		}
		[CompilerGenerated]
		set
		{
			vJFgWgM7y4a = value;
		}
	}

	public void wGfMjLU4H76(IDictionary<string, string> idictionary_0)
	{
		Endpoint = idictionary_0.kNjgWW5DqaP("Endpoint");
		AccessKey = idictionary_0.kNjgWW5DqaP("AccessKey");
		AccessKeySecret = idictionary_0.kNjgWW5DqaP("AccessKeySecret");
		BucketName = idictionary_0.kNjgWW5DqaP("BucketName");
	}

	public lKRt6fo20yPnP2ZloBB Upload(dqs3ZWowtqiy3yIfw7B request)
	{
		OssCredential ossCredential = new OssCredential();
		ossCredential.AccessKeyId = AccessKey;
		ossCredential.AccessKeySecret = AccessKeySecret;
		using HttpClient client = aFIptTXYsUoTUF4v33R.KtDt1YBndA5((int)(request.ExpireSeconds * 1000.0), false);
		OssClient ossClient = new OssClient(client, new RequestContext(ossCredential, ClientConfiguration.Default));
		BucketInfo bucketInfo = BucketInfo.Create(Endpoint, BucketName);
		string text = request.ContentType;
		if (!string.IsNullOrEmpty(request.zItgkI6Q4qG()))
		{
			text = text + "; charset=" + request.zItgkI6Q4qG();
		}
		OssResult<PutObjectResult> result = ossClient.PutObjectAsync(bucketInfo, request.nlTgkERQYHS(), request.Hitgkh0KOlt(), text, null, request.jDmgkVpsySE()).GetAwaiter().GetResult();
		lKRt6fo20yPnP2ZloBB lKRt6fo20yPnP2ZloBB = new lKRt6fo20yPnP2ZloBB();
		lKRt6fo20yPnP2ZloBB.IsSuccess = result.IsSuccess;
		lKRt6fo20yPnP2ZloBB.ErrorMessage = result.ErrorMessage;
		lKRt6fo20yPnP2ZloBB.H0JgkjiCUa2(result?.ErrorResult?.Code);
		lKRt6fo20yPnP2ZloBB.sZkgkMvAYlF("");
		lKRt6fo20yPnP2ZloBB.l82gk5RYXIt(request.nlTgkERQYHS());
		lKRt6fo20yPnP2ZloBB.Url = bucketInfo.GetObjectUrl(request.nlTgkERQYHS());
		return lKRt6fo20yPnP2ZloBB;
	}

	internal static bool KXmnkgQTmbW8AcXdX8yx()
	{
		return DlhvqVQTT5cEGkm8Meqg == null;
	}
}
