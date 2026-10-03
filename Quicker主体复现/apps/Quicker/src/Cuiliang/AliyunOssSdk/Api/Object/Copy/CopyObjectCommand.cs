using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Object.Copy;

public class CopyObjectCommand : BaseObjectCommand<CopyObjectResult>
{
	[CompilerGenerated]
	private IDictionary<string, string> bUquzyt6ld;

	[CompilerGenerated]
	private BucketInfo YPRNwK39nV;

	[CompilerGenerated]
	private string GCjNt6ko1R;

	internal static CopyObjectCommand gLXu5nD2VOHnb8J1hpJ;

	public IDictionary<string, string> ExtraHeaders
	{
		[CompilerGenerated]
		get
		{
			return bUquzyt6ld;
		}
		[CompilerGenerated]
		set
		{
			bUquzyt6ld = value;
		}
	}

	public BucketInfo SrcBucket
	{
		[CompilerGenerated]
		get
		{
			return YPRNwK39nV;
		}
		[CompilerGenerated]
		set
		{
			YPRNwK39nV = value;
		}
	}

	public string SrcObjectKey
	{
		[CompilerGenerated]
		get
		{
			return GCjNt6ko1R;
		}
		[CompilerGenerated]
		private set
		{
			GCjNt6ko1R = value;
		}
	}

	public CopyObjectCommand(RequestContext requestContext, BucketInfo targetBucket, string targetObjectKey, BucketInfo srcBucket, string srcObjectKey, IDictionary<string, string> extraHeaders)
		: base(requestContext, targetBucket, targetObjectKey)
	{
		SrcBucket = srcBucket;
		SrcObjectKey = srcObjectKey;
		ExtraHeaders = extraHeaders;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(base.Bucket, base.Key, HttpMethod.Put);
		serviceRequest.Headers.Add("x-oss-copy-source", SrcBucket.MakeResourcePathForSign(SrcObjectKey));
		if (ExtraHeaders != null)
		{
			foreach (KeyValuePair<string, string> extraHeader in ExtraHeaders)
			{
				serviceRequest.Headers.Add(extraHeader.Key, extraHeader.Value);
			}
		}
		return serviceRequest;
	}

	internal static bool F1LPaQDAMuQtBOACEJy()
	{
		return gLXu5nD2VOHnb8J1hpJ == null;
	}
}
