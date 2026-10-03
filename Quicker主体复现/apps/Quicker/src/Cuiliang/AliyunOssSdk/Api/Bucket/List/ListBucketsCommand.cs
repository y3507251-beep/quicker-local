using System.Net.Http;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Bucket.List;

public class ListBucketsCommand : BaseOssCommand<ListBucketsResult>
{
	private ListBucketsRequest kgHN8CrJ8F;

	private string nWkNan1R4A;

	internal static ListBucketsCommand nZEiLtD5LpIeknvCpCg;

	public ListBucketsCommand(RequestContext requestContext, string region, ListBucketsRequest request)
		: base(requestContext)
	{
		kgHN8CrJ8F = request;
		nWkNan1R4A = region;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(BucketInfo.CreateByRegion(nWkNan1R4A, ""), "", HttpMethod.Get);
		serviceRequest.AddParameter("prefix", kgHN8CrJ8F.Prefix);
		serviceRequest.AddParameter("marker", kgHN8CrJ8F.Marker);
		serviceRequest.AddParameter("max-keys", kgHN8CrJ8F.MaxKeys?.ToString());
		return serviceRequest;
	}

	internal static bool C0UcpLDYgivX1y1GdiL()
	{
		return nZEiLtD5LpIeknvCpCg == null;
	}
}
