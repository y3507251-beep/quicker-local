using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Object.Head;

public class HeadObjectCommand : BaseObjectCommand<HeadObjectResult>
{
	[CompilerGenerated]
	private HeadObjectParams V3FuIO1Btr;

	private static HeadObjectCommand O8OLG8jj2E4GVNBZPSp;

	public HeadObjectParams Parameters
	{
		[CompilerGenerated]
		get
		{
			return V3FuIO1Btr;
		}
		[CompilerGenerated]
		set
		{
			V3FuIO1Btr = value;
		}
	}

	public HeadObjectCommand(RequestContext requestContext, BucketInfo bucket, string key, HeadObjectParams parameters)
		: base(requestContext, bucket, key)
	{
		Parameters = parameters;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(base.Bucket, base.Key, HttpMethod.Head);
		Parameters?.SetupRequest(serviceRequest);
		return serviceRequest;
	}

	public override Task<OssResult<HeadObjectResult>> ParseResultAsync(HttpResponseMessage response)
	{
		return Task.FromResult(new OssResult<HeadObjectResult>(new HeadObjectResult
		{
			Headers = response.Headers
		}));
	}

	internal static bool hd7xV0jDZL0FcuuFvY9()
	{
		return O8OLG8jj2E4GVNBZPSp == null;
	}
}
