using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Api.Base;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;
using Cuiliang.AliyunOssSdk.Utility;

namespace Cuiliang.AliyunOssSdk.Api.Object.DeleteMultiple;

public class DeleteMultipleObjectsCommand : BaseOssCommand<DeleteMultipleObjectsResult>
{
	[CompilerGenerated]
	private BucketInfo nqKuM7aU9I;

	[CompilerGenerated]
	private IList<string> XcNuASCQOk;

	[CompilerGenerated]
	private string oQZuOycv2A;

	[CompilerGenerated]
	private bool htyuFOB53L;

	internal static DeleteMultipleObjectsCommand aQY1RJjh77k9exrEmAX;

	public BucketInfo Bucket
	{
		[CompilerGenerated]
		get
		{
			return nqKuM7aU9I;
		}
		[CompilerGenerated]
		set
		{
			nqKuM7aU9I = value;
		}
	}

	public IList<string> Keys
	{
		[CompilerGenerated]
		get
		{
			return XcNuASCQOk;
		}
		[CompilerGenerated]
		set
		{
			XcNuASCQOk = value;
		}
	}

	public string EncodingType
	{
		[CompilerGenerated]
		get
		{
			return oQZuOycv2A;
		}
		[CompilerGenerated]
		set
		{
			oQZuOycv2A = value;
		}
	}

	public bool Quiet
	{
		[CompilerGenerated]
		get
		{
			return htyuFOB53L;
		}
		[CompilerGenerated]
		set
		{
			htyuFOB53L = value;
		}
	}

	public DeleteMultipleObjectsCommand(RequestContext requestContext, BucketInfo bucket, IList<string> keys, bool quiet = false, string encodingType = "")
		: base(requestContext)
	{
		Bucket = bucket;
		Keys = keys;
		EncodingType = encodingType;
		Quiet = quiet;
	}

	public override ServiceRequest BuildRequest()
	{
		ServiceRequest serviceRequest = new ServiceRequest(Bucket, "", HttpMethod.Post);
		string text = SerializeHelper.Serialize(new DeleteObjectsRequestModel(Quiet, Keys));
		serviceRequest.ContentMd5 = OssUtils.ComputeContentMd5(text);
		serviceRequest.SetContent(text, "application/xml");
		serviceRequest.Parameters.Add("delete", "");
		if (!string.IsNullOrEmpty(EncodingType))
		{
			serviceRequest.Parameters.Add("encoding-type", EncodingType);
		}
		return serviceRequest;
	}

	internal static bool JLCIi0jH8DBenlSAAkC()
	{
		return aQY1RJjh77k9exrEmAX == null;
	}
}
