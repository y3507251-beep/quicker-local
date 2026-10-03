using System.Net.Http;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Object.Delete;

public class DeleteObjectCommand : BaseObjectCommand<DeleteObjectResult>
{
	private static DeleteObjectCommand b83WAjjwGo6LZfWwOMV;

	public DeleteObjectCommand(RequestContext requestContext, BucketInfo bucket, string key)
		: base(requestContext, bucket, key)
	{
	}

	public override ServiceRequest BuildRequest()
	{
		return new ServiceRequest(base.Bucket, base.Key, HttpMethod.Delete);
	}

	public override Task<OssResult<DeleteObjectResult>> ParseResultAsync(HttpResponseMessage response)
	{
		return Task.FromResult(new OssResult<DeleteObjectResult>(new DeleteObjectResult()));
	}

	static DeleteObjectCommand()
	{
	}

	internal static bool kIECb2jTp54mOLtAXEp()
	{
		return b83WAjjwGo6LZfWwOMV == null;
	}

	internal static void VtbFqijsVIXyDr0n5S6()
	{
	}
}
