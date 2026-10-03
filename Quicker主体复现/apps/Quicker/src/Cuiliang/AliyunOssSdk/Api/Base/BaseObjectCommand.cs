using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Api.Base;

public abstract class BaseObjectCommand<TResult> : BaseOssCommand<TResult>
{
	[CompilerGenerated]
	private BucketInfo v6RNOwtBU6;

	[CompilerGenerated]
	private string FAmNF9xFn8;

	private static object KQffgMDHcCGIOWKc8iI;

	public BucketInfo Bucket
	{
		[CompilerGenerated]
		get
		{
			return v6RNOwtBU6;
		}
		[CompilerGenerated]
		set
		{
			v6RNOwtBU6 = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return FAmNF9xFn8;
		}
		[CompilerGenerated]
		set
		{
			FAmNF9xFn8 = value;
		}
	}

	public BaseObjectCommand(RequestContext requestContext, BucketInfo bucket, string key)
		: base(requestContext)
	{
		Bucket = bucket;
		Key = key;
	}

	internal static bool HBIgELDzwkbSfRKm2hy()
	{
		return KQffgMDHcCGIOWKc8iI == null;
	}
}
