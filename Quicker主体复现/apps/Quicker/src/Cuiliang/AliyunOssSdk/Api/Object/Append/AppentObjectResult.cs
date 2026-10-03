using System.Runtime.CompilerServices;

namespace Cuiliang.AliyunOssSdk.Api.Object.Append;

public class AppentObjectResult
{
	[CompilerGenerated]
	private string uU9N2Ur8TT;

	[CompilerGenerated]
	private long V5gNuVwa21;

	[CompilerGenerated]
	private ulong DSpNNarLMx;

	internal static AppentObjectResult VD0SDyDvDrwntNIcjty;

	public string ETag
	{
		[CompilerGenerated]
		get
		{
			return uU9N2Ur8TT;
		}
		[CompilerGenerated]
		set
		{
			uU9N2Ur8TT = value;
		}
	}

	public long NextAppendPosition
	{
		[CompilerGenerated]
		get
		{
			return V5gNuVwa21;
		}
		[CompilerGenerated]
		set
		{
			V5gNuVwa21 = value;
		}
	}

	public ulong HashCrc64Ecma
	{
		[CompilerGenerated]
		get
		{
			return DSpNNarLMx;
		}
		[CompilerGenerated]
		set
		{
			DSpNNarLMx = value;
		}
	}

	internal static bool PhrV1mDdaarfBqtL5d5()
	{
		return VD0SDyDvDrwntNIcjty == null;
	}
}
