using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;
using Cuiliang.AliyunOssSdk.Utility;

namespace Cuiliang.AliyunOssSdk.Api.Object.Put;

public class PutObjectCommand : BaseObjectCommand<PutObjectResult>
{
	[CompilerGenerated]
	private IDictionary<string, string> q4Gu9S5IZC;

	[CompilerGenerated]
	private RequestContent n8buhZ8RBZ;

	private static PutObjectCommand WhUkmkjVDAOCvdvoMIG;

	public IDictionary<string, string> ExtraHeaders
	{
		[CompilerGenerated]
		get
		{
			return q4Gu9S5IZC;
		}
		[CompilerGenerated]
		set
		{
			q4Gu9S5IZC = value;
		}
	}

	public RequestContent RequestContent
	{
		[CompilerGenerated]
		get
		{
			return n8buhZ8RBZ;
		}
		[CompilerGenerated]
		set
		{
			n8buhZ8RBZ = value;
		}
	}

	public PutObjectCommand(RequestContext requestContext, BucketInfo bucketInfo, string key, RequestContent requestContent, IDictionary<string, string> extraHeaders)
		: base(requestContext, bucketInfo, key)
	{
		base.Bucket = bucketInfo;
		RequestContent = requestContent;
		ExtraHeaders = extraHeaders;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(base.Bucket, base.Key, HttpMethod.Put);
		if (ExtraHeaders != null)
		{
			foreach (KeyValuePair<string, string> extraHeader in ExtraHeaders)
			{
				serviceRequest.Headers.Add(extraHeader);
			}
		}
		RequestContent.Metadata?.Qikuwm7sBm(serviceRequest.Headers);
		serviceRequest.ContentMd5 = RequestContent.ContentMd5;
		if (RequestContent.ContentType == RequestContentType.Stream)
		{
			serviceRequest.SetContent(RequestContent.StreamContent, RequestContent.MimeType);
		}
		else
		{
			if (RequestContent.ContentType != RequestContentType.String)
			{
				throw new ArgumentException("错误的内容类型");
			}
			serviceRequest.SetContent(RequestContent.StringContent, RequestContent.MimeType);
			int num = 0;
			if (WhUkmkjVDAOCvdvoMIG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return serviceRequest;
	}

	public override Task<OssResult<PutObjectResult>> ParseResultAsync(HttpResponseMessage response)
	{
		PutObjectResult putObjectResult = new PutObjectResult();
		if (response.Headers.Contains("ETag"))
		{
			putObjectResult.ETag = OssUtils.TrimQuotes(response.Headers.ETag.ToString());
		}
		return Task.FromResult(new OssResult<PutObjectResult>
		{
			IsSuccess = true,
			SuccessResult = putObjectResult
		});
	}

	internal static bool YtdOFCjQIe00uqfEbwS()
	{
		return WhUkmkjVDAOCvdvoMIG == null;
	}
}
