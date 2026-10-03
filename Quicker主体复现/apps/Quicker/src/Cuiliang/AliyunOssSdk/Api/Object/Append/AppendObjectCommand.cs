using System;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Object.Append;

public class AppendObjectCommand : BaseObjectCommand<AppentObjectResult>
{
	[CompilerGenerated]
	private long I8ZNvTcLMU;

	[CompilerGenerated]
	private RequestContent dJHNSLIUjU;

	private static AppendObjectCommand DKdTRtDE9J3JKWYjC9N;

	public long Position
	{
		[CompilerGenerated]
		get
		{
			return I8ZNvTcLMU;
		}
		[CompilerGenerated]
		set
		{
			I8ZNvTcLMU = value;
		}
	}

	public RequestContent RequestContent
	{
		[CompilerGenerated]
		get
		{
			return dJHNSLIUjU;
		}
		[CompilerGenerated]
		set
		{
			dJHNSLIUjU = value;
		}
	}

	public AppendObjectCommand(RequestContext requestContext, BucketInfo bucket, string key, long position, RequestContent objectInfo)
		: base(requestContext, bucket, key)
	{
		Position = position;
		RequestContent = objectInfo;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(base.Bucket, base.Key, HttpMethod.Post);
		RequestContent.Metadata?.Qikuwm7sBm(serviceRequest.Headers);
		serviceRequest.Parameters.Add("append", "");
		serviceRequest.Parameters.Add("position", Position.ToString());
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
			int num = 0;
			if (DKdTRtDE9J3JKWYjC9N != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			serviceRequest.SetContent(RequestContent.StringContent, RequestContent.MimeType);
		}
		return serviceRequest;
	}

	public override Task<OssResult<AppentObjectResult>> ParseResultAsync(HttpResponseMessage response)
	{
		AppentObjectResult appentObjectResult = new AppentObjectResult();
		appentObjectResult.ETag = response.Headers.ETag?.ToString();
		if (response.Headers.Contains("x-oss-next-append-position"))
		{
			appentObjectResult.NextAppendPosition = Convert.ToInt64(response.Headers.GetValues("x-oss-next-append-position").First());
		}
		if (response.Headers.Contains("x-oss-hash-crc64ecma"))
		{
			appentObjectResult.HashCrc64Ecma = Convert.ToUInt64(response.Headers.GetValues("x-oss-hash-crc64ecma").FirstOrDefault());
		}
		return Task.FromResult(new OssResult<AppentObjectResult>(appentObjectResult));
	}

	internal static void g4sC1GD1gW1TbAVMdq1()
	{
	}

	internal static bool x2n6nPDGWvuFOjIYEOW()
	{
		return DKdTRtDE9J3JKWYjC9N == null;
	}
}
