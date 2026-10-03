using System;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Utility;

namespace Cuiliang.AliyunOssSdk.Entites;

public class BucketInfo
{
	[CompilerGenerated]
	private bool puI2nJJwBT;

	[CompilerGenerated]
	private bool OH824ybh2E;

	[CompilerGenerated]
	private string BqF25kr76n;

	[CompilerGenerated]
	private Uri AVO2DpbLlS;

	[CompilerGenerated]
	private Uri xGR2d8a0X8;

	private static BucketInfo O84RFveNt3covFfLocR;

	public bool IsCname
	{
		[CompilerGenerated]
		get
		{
			return puI2nJJwBT;
		}
		[CompilerGenerated]
		private set
		{
			puI2nJJwBT = value;
		}
	}

	public bool IsHttps
	{
		[CompilerGenerated]
		get
		{
			return OH824ybh2E;
		}
		[CompilerGenerated]
		private set
		{
			OH824ybh2E = value;
		}
	}

	public string BucketName
	{
		[CompilerGenerated]
		get
		{
			return BqF25kr76n;
		}
		[CompilerGenerated]
		private set
		{
			BqF25kr76n = value;
		}
	}

	public Uri EndpointUri
	{
		[CompilerGenerated]
		get
		{
			return AVO2DpbLlS;
		}
		[CompilerGenerated]
		private set
		{
			AVO2DpbLlS = value;
		}
	}

	public Uri BucketUri
	{
		[CompilerGenerated]
		get
		{
			return xGR2d8a0X8;
		}
		[CompilerGenerated]
		private set
		{
			xGR2d8a0X8 = value;
		}
	}

	private BucketInfo()
	{
	}

	public static BucketInfo CreateByCname(Uri uri, string bucket)
	{
		return new BucketInfo
		{
			IsCname = true,
			IsHttps = (uri.Scheme.ToLower() == "https"),
			BucketName = bucket,
			EndpointUri = uri,
			BucketUri = uri
		};
	}

	public static BucketInfo CreateByRegion(string region, string bucketName, bool useHttps = false, bool useInternal = false)
	{
		UriBuilder uriBuilder = new UriBuilder();
		uriBuilder.Scheme = (useHttps ? "https" : "http");
		uriBuilder.Host = region + (useInternal ? "-internal.aliyuncs.com" : ".aliyuncs.com");
		BucketInfo bucketInfo = new BucketInfo
		{
			IsCname = false,
			BucketName = bucketName,
			IsHttps = useHttps,
			EndpointUri = uriBuilder.Uri
		};
		if (!SbuBGde9ixqebbonygU())
		{
			switch (0)
			{
			}
		}
		if (string.IsNullOrEmpty(bucketName))
		{
			bucketInfo.BucketUri = bucketInfo.EndpointUri;
		}
		else
		{
			uriBuilder.Host = bucketName + "." + uriBuilder.Host;
			bucketInfo.BucketUri = uriBuilder.Uri;
		}
		return bucketInfo;
	}

	public static BucketInfo Create(string endPoint, string bucketName)
	{
		Uri uri = new Uri(endPoint);
		UriBuilder uriBuilder = new UriBuilder();
		uriBuilder.Scheme = uri.Scheme;
		uriBuilder.Host = uri.Host;
		BucketInfo bucketInfo = new BucketInfo
		{
			IsCname = false,
			BucketName = bucketName,
			IsHttps = (uri.Scheme == "https"),
			EndpointUri = uri
		};
		if (string.IsNullOrEmpty(bucketName))
		{
			bucketInfo.BucketUri = bucketInfo.EndpointUri;
			int num = 0;
			if (O84RFveNt3covFfLocR != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			uriBuilder.Host = bucketName + "." + uriBuilder.Host;
			bucketInfo.BucketUri = uriBuilder.Uri;
		}
		return bucketInfo;
	}

	public string MakeResourcePathForSign(string key)
	{
		if (string.IsNullOrEmpty(BucketName))
		{
			return "/";
		}
		return "/" + BucketName + "/" + key;
	}

	public string GetObjectUrl(string objectKey)
	{
		string text = BucketUri.ToString();
		if (string.IsNullOrEmpty(objectKey))
		{
			return text;
		}
		if (text.EndsWith("/"))
		{
			return text + OssUtils.UrlEncodeKey(objectKey);
		}
		return text + "/" + OssUtils.UrlEncodeKey(objectKey);
	}

	internal static bool SbuBGde9ixqebbonygU()
	{
		return O84RFveNt3covFfLocR == null;
	}
}
