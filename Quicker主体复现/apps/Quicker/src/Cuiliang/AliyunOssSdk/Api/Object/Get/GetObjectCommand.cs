using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;
using Cuiliang.AliyunOssSdk.Utility;
using qdET65OxfuSfXTNffp;

namespace Cuiliang.AliyunOssSdk.Api.Object.Get;

public class GetObjectCommand : BaseObjectCommand<GetObjectResult>
{
	[CompilerGenerated]
	private GetObjectParams SK8u61SmH7;

	private static GetObjectCommand cCNdhsjd1Z9lq7bD7IS;

	public GetObjectParams Params
	{
		[CompilerGenerated]
		get
		{
			return SK8u61SmH7;
		}
		[CompilerGenerated]
		set
		{
			SK8u61SmH7 = value;
		}
	}

	public GetObjectCommand(RequestContext requestContext, BucketInfo bucket, string key, GetObjectParams parameters)
		: base(requestContext, bucket, key)
	{
		Params = parameters;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(base.Bucket, base.Key, HttpMethod.Get);
		Params?.SetupRequest(serviceRequest);
		return serviceRequest;
	}

	public override Task<OssResult<GetObjectResult>> ParseResultAsync(HttpResponseMessage response)
	{
		GetObjectResult getObjectResult = new GetObjectResult();
		getObjectResult.Headers = response.Headers;
		getObjectResult.Content = response.Content;
		getObjectResult.Metadata = YsdubZ7BAc(response);
		return Task.FromResult(new OssResult<GetObjectResult>
		{
			IsSuccess = true,
			SuccessResult = getObjectResult
		});
	}

	private ObjectMetadata YsdubZ7BAc(HttpResponseMessage httpResponseMessage_0)
	{
		ObjectMetadata objectMetadata = new ObjectMetadata();
		foreach (KeyValuePair<string, IEnumerable<string>> header in httpResponseMessage_0.Headers)
		{
			if (header.Key.StartsWith("x-oss-meta-", false, CultureInfo.InvariantCulture))
			{
				objectMetadata.UserMetadata.Add(header.Key.Substring("x-oss-meta-".Length), header.Value.FirstOrDefault());
			}
			else if (string.Equals(header.Key, "Content-Length", StringComparison.InvariantCultureIgnoreCase))
			{
				objectMetadata.ContentLength = long.Parse(header.Value.FirstOrDefault(), CultureInfo.InvariantCulture);
			}
			else if (string.Equals(header.Key, "ETag", StringComparison.InvariantCultureIgnoreCase))
			{
				objectMetadata.ETag = OssUtils.TrimETag(header.Value.FirstOrDefault());
			}
			else if (string.Equals(header.Key, "Last-Modified", StringComparison.InvariantCultureIgnoreCase))
			{
				objectMetadata.LastModified = zh4GdKnxb7gfeU5oTf.cf4ST5pSMC(header.Value.FirstOrDefault());
				if (!AYnHPbjO0xZBU2GlowT())
				{
					switch (0)
					{
					}
				}
			}
			else
			{
				objectMetadata.AddHeader(header.Key, header.Value);
			}
		}
		return objectMetadata;
	}

	internal static bool AYnHPbjO0xZBU2GlowT()
	{
		return cCNdhsjd1Z9lq7bD7IS == null;
	}
}
