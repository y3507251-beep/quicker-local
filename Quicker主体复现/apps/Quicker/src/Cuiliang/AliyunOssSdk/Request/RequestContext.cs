using System;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Entites;

namespace Cuiliang.AliyunOssSdk.Request;

public class RequestContext
{
	[CompilerGenerated]
	private ClientConfiguration mfA2qvrlfu;

	[CompilerGenerated]
	private OssCredential Uxe2cHgjV5;

	private static RequestContext PGeBF8ejdHXN4MnYWFY;

	public ClientConfiguration ClientConfiguration
	{
		[CompilerGenerated]
		get
		{
			return mfA2qvrlfu;
		}
		[CompilerGenerated]
		set
		{
			mfA2qvrlfu = value;
		}
	}

	public OssCredential OssCredential
	{
		[CompilerGenerated]
		get
		{
			return Uxe2cHgjV5;
		}
		[CompilerGenerated]
		set
		{
			Uxe2cHgjV5 = value;
		}
	}

	public RequestContext(OssCredential credentialOptions, ClientConfiguration config)
	{
		OssCredential = credentialOptions;
		ClientConfiguration = config;
		if (string.IsNullOrWhiteSpace(OssCredential.AccessKeyId))
		{
			throw new ArgumentNullException("AccessKeyId");
		}
		if (string.IsNullOrWhiteSpace(OssCredential.AccessKeySecret))
		{
			throw new ArgumentNullException("AccessKeySecret");
		}
	}

	internal static bool eJHBoveD0fiHQFpiW8l()
	{
		return PGeBF8ejdHXN4MnYWFY == null;
	}
}
