using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using bEVZu13wruQIEh71Lv;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Utility;

namespace Cuiliang.AliyunOssSdk.Request;

public class PresignedUrlCreator
{
	[CompilerGenerated]
	private BucketInfo F4y2CVm0Ua;

	[CompilerGenerated]
	private string rmF2PYIFJ8;

	[CompilerGenerated]
	private DateTime LQl2EnsbFH = DateTime.UtcNow.AddSeconds(600.0);

	[CompilerGenerated]
	private string ffC2yt0F9s;

	[CompilerGenerated]
	private string QFx28f6fWs;

	[CompilerGenerated]
	private HttpMethod a3u2aOi1Qj = HttpMethod.Get;

	[CompilerGenerated]
	private ResponseHeaderOverrides SrH27A9xPk;

	[CompilerGenerated]
	private Dictionary<string, string> mfU2RrKMNm;

	private static PresignedUrlCreator W6EWD5eWTyGAFlkTLjm;

	public BucketInfo Bucket
	{
		[CompilerGenerated]
		get
		{
			return F4y2CVm0Ua;
		}
		[CompilerGenerated]
		set
		{
			F4y2CVm0Ua = value;
		}
	}

	public string ObjectKey
	{
		[CompilerGenerated]
		get
		{
			return rmF2PYIFJ8;
		}
		[CompilerGenerated]
		set
		{
			rmF2PYIFJ8 = value;
		}
	}

	public DateTime ExpireTime
	{
		[CompilerGenerated]
		get
		{
			return LQl2EnsbFH;
		}
		[CompilerGenerated]
		set
		{
			LQl2EnsbFH = value;
		}
	}

	public string ContentType
	{
		[CompilerGenerated]
		get
		{
			return ffC2yt0F9s;
		}
		[CompilerGenerated]
		set
		{
			ffC2yt0F9s = value;
		}
	}

	public string ContentMd5
	{
		[CompilerGenerated]
		get
		{
			return QFx28f6fWs;
		}
		[CompilerGenerated]
		set
		{
			QFx28f6fWs = value;
		}
	}

	public HttpMethod HttpMethod
	{
		[CompilerGenerated]
		get
		{
			return a3u2aOi1Qj;
		}
		[CompilerGenerated]
		set
		{
			a3u2aOi1Qj = value;
		}
	}

	public ResponseHeaderOverrides ResponseHeaderOverrides
	{
		[CompilerGenerated]
		get
		{
			return SrH27A9xPk;
		}
		[CompilerGenerated]
		set
		{
			SrH27A9xPk = value;
		}
	}

	public Dictionary<string, string> UserMetadata
	{
		[CompilerGenerated]
		get
		{
			return mfU2RrKMNm;
		}
		[CompilerGenerated]
		set
		{
			mfU2RrKMNm = value;
		}
	}

	public PresignedUrlCreator()
	{
	}

	public PresignedUrlCreator(BucketInfo bucket, string objectKey, int expireSeconds = 600)
	{
		Bucket = bucket;
		ObjectKey = objectKey;
		ExpireTime = DateTime.UtcNow.AddSeconds(expireSeconds);
	}

	public Uri Create(RequestContext requestContext)
	{
        string text = default;
        string httpMethod = default;
        Dictionary<string, string> dictionary = default;
		Ensure.ToBeTrue(ExpireTime > DateTime.UtcNow);
		int value;
		if (!(HttpMethod == HttpMethod.Get))
		{
			if (!hCnYXseyXS3knnWLUyo())
			{
				goto IL_010c;
			}
			switch (1)
			{
			case 1:
				break;
			default:
				goto IL_010c;
			case 2:
				goto IL_0200;
			}
			value = ((HttpMethod == HttpMethod.Put) ? 1 : 0);
		}
		else
		{
			value = 1;
		}
		Ensure.ToBeTrue((byte)value != 0, "不支持的http method");
		httpMethod = HttpMethod.ToString().ToUpperInvariant();
		text = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString();
		dictionary = new Dictionary<string, string>();
		if (UserMetadata != null)
		{
			foreach (KeyValuePair<string, string> userMetadatum in UserMetadata)
			{
				dictionary.Add("x-oss-meta-" + userMetadatum.Key, userMetadatum.Value);
			}
		}
		goto IL_010c;
		IL_0200:
		Dictionary<string, string> dictionary2 = default(Dictionary<string, string>);
		string text2 = bThfW9sYygwxKofgvb.gYvSAdEbM1(dictionary2);
		return new Uri(Bucket.GetObjectUrl(ObjectKey) + "?" + text2);
		IL_010c:
		string canonicalizedOSSHeaders = SignatureHelper.ComputeCanonicalizedOSSHeaders(dictionary);
		Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
		if (requestContext.OssCredential.UseToken)
		{
			dictionary3.Add("security-token", requestContext.OssCredential.SecurityToken);
		}
		ResponseHeaderOverrides?.ikf2twoHHM(dictionary3);
		string canonicalizedResource = SignatureHelper.BuildCanonicalizedResource(Bucket, ObjectKey, dictionary3);
		string value2 = SignatureHelper.HmacSha1Sign(requestContext.OssCredential.AccessKeySecret, httpMethod, ContentMd5, ContentType, text, canonicalizedOSSHeaders, canonicalizedResource);
		dictionary2 = new Dictionary<string, string>();
		dictionary2.Add("Expires", text);
		dictionary2.Add("OSSAccessKeyId", requestContext.OssCredential.AccessKeyId);
		dictionary2.Add("Signature", value2);
		foreach (KeyValuePair<string, string> item in dictionary3)
		{
			dictionary2.Add(item.Key, item.Value);
		}
		goto IL_0200;
	}

	internal static bool hCnYXseyXS3knnWLUyo()
	{
		return W6EWD5eWTyGAFlkTLjm == null;
	}
}
