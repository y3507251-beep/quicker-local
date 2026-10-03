using System.Net.Http;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Object.GetMeta;

public class GetObjectMetaCommand : BaseObjectCommand<GetObjectMetaResult>
{
	private static GetObjectMetaCommand d3mdvijYy5pNuBSinQ9;

	public GetObjectMetaCommand(RequestContext requestContext, BucketInfo bucket, string key)
		: base(requestContext, bucket, key)
	{
	}

	public override ServiceRequest BuildRequest()
	{
		return new ServiceRequest(base.Bucket, base.Key, HttpMethod.Get)
		{
			Parameters = { { "objectMeta", "" } }
		};
	}

	public override Task<OssResult<GetObjectMetaResult>> ParseResultAsync(HttpResponseMessage response)
	{
		return Task.FromResult(new OssResult<GetObjectMetaResult>(new GetObjectMetaResult
		{
			Headers = response.Headers
		}));
	}

	internal static bool eo3ayjj8L1jEWsI35JR()
	{
		return d3mdvijYy5pNuBSinQ9 == null;
	}
}
