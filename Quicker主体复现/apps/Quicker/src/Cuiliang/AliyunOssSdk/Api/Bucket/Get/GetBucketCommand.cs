using System.Net.Http;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Bucket.Get;

public class GetBucketCommand : BaseOssCommand<GetBucketResult>
{
	private readonly BucketInfo nFyNHiEuy0;

	private readonly string Rv2N1NAd32;

	private readonly string pPhNblgACO;

	private readonly int Ab6N6mG8Tx;

	private readonly string fccNXd5IOr;

	private readonly string nb0Nm5TH8L;

	internal static GetBucketCommand qUyFwMDSfO8xa0upbgT;

	public GetBucketCommand(RequestContext requestContext, BucketInfo bucketInfo, string prefix, string marker, int maxKeys, string delimiter, string encodingType)
		: base(requestContext)
	{
		nFyNHiEuy0 = bucketInfo;
		Rv2N1NAd32 = prefix;
		pPhNblgACO = marker;
		Ab6N6mG8Tx = maxKeys;
		fccNXd5IOr = delimiter;
		nb0Nm5TH8L = encodingType;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(nFyNHiEuy0, "", HttpMethod.Get);
		serviceRequest.AddParameter("delimiter", fccNXd5IOr);
		serviceRequest.AddParameter("marker", pPhNblgACO);
		serviceRequest.AddParameter("max-keys", Ab6N6mG8Tx.ToString());
		serviceRequest.AddParameter("prefix", Rv2N1NAd32);
		serviceRequest.AddParameter("encoding-type", nb0Nm5TH8L);
		return serviceRequest;
	}

	internal static bool QEpoxoDwxiTP4ekTwaQ()
	{
		return qUyFwMDSfO8xa0upbgT == null;
	}
}
