using System.Net.Http;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Object.GetAcl;

public class GetObjectAclCommand : BaseObjectCommand<GetObjectAclResult>
{
	internal static GetObjectAclCommand YOZc1jjUVjiG2Lm2DWo;

	public GetObjectAclCommand(RequestContext requestContext, BucketInfo bucket, string key)
		: base(requestContext, bucket, key)
	{
	}

	public override ServiceRequest BuildRequest()
	{
		return new ServiceRequest(base.Bucket, base.Key, HttpMethod.Get)
		{
			Parameters = { { "acl", "" } }
		};
	}

	internal static bool bsumsfjxV9jHhMMLaBr()
	{
		return YOZc1jjUVjiG2Lm2DWo == null;
	}
}
