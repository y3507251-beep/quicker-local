using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Qiniu.Storage;

public class FetchInfo
{
	[CompilerGenerated]
	private string avgelB6GsJ;

	[CompilerGenerated]
	private long L8Oei0RK0l;

	[CompilerGenerated]
	private string pf7e3VlsSI;

	[CompilerGenerated]
	private string MhFef9gxGA;

	internal static FetchInfo dBJBaTu8eqjjiV0IOlF;

	[JsonProperty("key")]
	public string Key
	{
		[CompilerGenerated]
		get
		{
			return avgelB6GsJ;
		}
		[CompilerGenerated]
		set
		{
			avgelB6GsJ = value;
		}
	}

	[JsonProperty("fsize")]
	public long Fsize
	{
		[CompilerGenerated]
		get
		{
			return L8Oei0RK0l;
		}
		[CompilerGenerated]
		set
		{
			L8Oei0RK0l = value;
		}
	}

	[JsonProperty("hash")]
	public string Hash
	{
		[CompilerGenerated]
		get
		{
			return pf7e3VlsSI;
		}
		[CompilerGenerated]
		set
		{
			pf7e3VlsSI = value;
		}
	}

	[JsonProperty("mimeType")]
	public string MimeType
	{
		[CompilerGenerated]
		get
		{
			return MhFef9gxGA;
		}
		[CompilerGenerated]
		set
		{
			MhFef9gxGA = value;
		}
	}

	internal static bool NUnHGjuR9u5ZYPrA4a3()
	{
		return dBJBaTu8eqjjiV0IOlF == null;
	}
}
