using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Qiniu.Storage;

public class FileInfo
{
	[CompilerGenerated]
	private long rs3eznCCCU;

	[CompilerGenerated]
	private string wRoYwQLwBZ;

	[CompilerGenerated]
	private string lPZYtY2IBA;

	[CompilerGenerated]
	private long W1iYgMGLeC;

	[CompilerGenerated]
	private int dbWYLFOlLK;

	private static FileInfo oiMyPXux6TqwxYP9QgS;

	[JsonProperty("fsize")]
	public long Fsize
	{
		[CompilerGenerated]
		get
		{
			return rs3eznCCCU;
		}
		[CompilerGenerated]
		set
		{
			rs3eznCCCU = value;
		}
	}

	[JsonProperty("hash")]
	public string Hash
	{
		[CompilerGenerated]
		get
		{
			return wRoYwQLwBZ;
		}
		[CompilerGenerated]
		set
		{
			wRoYwQLwBZ = value;
		}
	}

	[JsonProperty("mimeType")]
	public string MimeType
	{
		[CompilerGenerated]
		get
		{
			return lPZYtY2IBA;
		}
		[CompilerGenerated]
		set
		{
			lPZYtY2IBA = value;
		}
	}

	[JsonProperty("putTime")]
	public long PutTime
	{
		[CompilerGenerated]
		get
		{
			return W1iYgMGLeC;
		}
		[CompilerGenerated]
		set
		{
			W1iYgMGLeC = value;
		}
	}

	[JsonProperty("type")]
	public int FileType
	{
		[CompilerGenerated]
		get
		{
			return dbWYLFOlLK;
		}
		[CompilerGenerated]
		set
		{
			dbWYLFOlLK = value;
		}
	}

	internal static bool srW3Q4uIt07FleRrqIf()
	{
		return oiMyPXux6TqwxYP9QgS == null;
	}
}
