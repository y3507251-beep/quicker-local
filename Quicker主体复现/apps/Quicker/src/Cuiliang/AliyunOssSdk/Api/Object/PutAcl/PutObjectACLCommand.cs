using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Object.PutAcl;

public class PutObjectACLCommand : BaseObjectCommand<EmptyResult>
{
	[CompilerGenerated]
	private string HueuYpdJld;

	internal static PutObjectACLCommand r7oM8Vj2WwRZWlGJJy6;

	public string AclType
	{
		[CompilerGenerated]
		get
		{
			return HueuYpdJld;
		}
		[CompilerGenerated]
		set
		{
			HueuYpdJld = value;
		}
	}

	public PutObjectACLCommand(RequestContext requestContext, BucketInfo bucket, string key, string aclType)
		: base(requestContext, bucket, key)
	{
		AclType = aclType;
	}

	public override ServiceRequest BuildRequest()
	{
		return new ServiceRequest(base.Bucket, base.Key, HttpMethod.Put)
		{
			Parameters = { { "acl", "" } },
			Headers = { { "x-oss-object-acl", AclType } }
		};
	}

	public override Task<OssResult<EmptyResult>> ParseResultAsync(HttpResponseMessage response)
	{
		return Task.FromResult(new OssResult<EmptyResult>(new EmptyResult()));
	}

	internal static bool XySLfJjAWCKBgPYvNum()
	{
		return r7oM8Vj2WwRZWlGJJy6 == null;
	}

	internal static void CcjBbBjemT9I5vhYHfX()
	{
	}
}
