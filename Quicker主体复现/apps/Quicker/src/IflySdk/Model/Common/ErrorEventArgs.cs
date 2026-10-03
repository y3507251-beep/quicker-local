using System;
using System.Runtime.CompilerServices;
using IflySdk.Enum;

namespace IflySdk.Model.Common;

public class ErrorEventArgs
{
	[CompilerGenerated]
	private ResultCode NjLhrElSlv;

	[CompilerGenerated]
	private string mEihpDgV4L;

	[CompilerGenerated]
	private Exception gkxhBuoJ9C;

	private static ErrorEventArgs BXHkk6NCLGoyuaGCRq0;

	public ResultCode Code
	{
		[CompilerGenerated]
		get
		{
			return NjLhrElSlv;
		}
		[CompilerGenerated]
		set
		{
			NjLhrElSlv = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return mEihpDgV4L;
		}
		[CompilerGenerated]
		set
		{
			mEihpDgV4L = value;
		}
	}

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			return gkxhBuoJ9C;
		}
		[CompilerGenerated]
		set
		{
			gkxhBuoJ9C = value;
		}
	}

	static ErrorEventArgs()
	{
	}

	internal static bool iEGsssN7Jq3fMa36cf6()
	{
		return BXHkk6NCLGoyuaGCRq0 == null;
	}

	internal static void U3bGfXNhFuhQTIqeM0t()
	{
	}
}
