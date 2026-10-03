using System;
using System.Runtime.CompilerServices;

namespace Cuiliang.AliyunOssSdk.Api;

public class OssResult<TResult>
{
	[CompilerGenerated]
	private bool P2suRAHIQU;

	[CompilerGenerated]
	private string FBQuqrD0Bi;

	[CompilerGenerated]
	private Exception xu8ucvEDPP;

	[CompilerGenerated]
	private TResult Os0uVITawn;

	[CompilerGenerated]
	private ErrorResult LZCuZjXAQF;

	internal static object deYvZKeCkWRhdN68A00;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return P2suRAHIQU;
		}
		[CompilerGenerated]
		set
		{
			P2suRAHIQU = value;
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return FBQuqrD0Bi;
		}
		[CompilerGenerated]
		set
		{
			FBQuqrD0Bi = value;
		}
	}

	public Exception InnerException
	{
		[CompilerGenerated]
		get
		{
			return xu8ucvEDPP;
		}
		[CompilerGenerated]
		set
		{
			xu8ucvEDPP = value;
		}
	}

	public TResult SuccessResult
	{
		[CompilerGenerated]
		get
		{
			return Os0uVITawn;
		}
		[CompilerGenerated]
		set
		{
			Os0uVITawn = value;
		}
	}

	public ErrorResult ErrorResult
	{
		[CompilerGenerated]
		get
		{
			return LZCuZjXAQF;
		}
		[CompilerGenerated]
		set
		{
			LZCuZjXAQF = value;
		}
	}

	public OssResult()
	{
	}

	public OssResult(TResult result)
	{
		IsSuccess = true;
		SuccessResult = result;
	}

	public OssResult(bool success)
	{
		IsSuccess = success;
	}

	internal static bool cHH9QMe7m20yHGTCmwo()
	{
		return deYvZKeCkWRhdN68A00 == null;
	}
}
