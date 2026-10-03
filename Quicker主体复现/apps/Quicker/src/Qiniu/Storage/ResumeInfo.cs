using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Qiniu.Storage;

public class ResumeInfo
{
	[CompilerGenerated]
	private long GnOI5exDsK;

	[CompilerGenerated]
	private long nJUID76K3R;

	[CompilerGenerated]
	private string[] LbAIdH1h8D;

	[CompilerGenerated]
	private long[] B38Iooc5iK;

	[CompilerGenerated]
	private long YsrIT6ykNj;

	[CompilerGenerated]
	private Dictionary<string, object>[] IPkIMcDFaQ;

	[CompilerGenerated]
	private string NPIIAiCvTJ;

	[CompilerGenerated]
	private long k6aIOYAcN6;

	internal static ResumeInfo ED9BymfE4QL6NhqYar7;

	[JsonProperty("fileSize")]
	public long FileSize
	{
		[CompilerGenerated]
		get
		{
			return GnOI5exDsK;
		}
		[CompilerGenerated]
		set
		{
			GnOI5exDsK = value;
		}
	}

	[JsonProperty("blockCount")]
	public long BlockCount
	{
		[CompilerGenerated]
		get
		{
			return nJUID76K3R;
		}
		[CompilerGenerated]
		set
		{
			nJUID76K3R = value;
		}
	}

	[JsonProperty("contexts")]
	public string[] Contexts
	{
		[CompilerGenerated]
		get
		{
			return LbAIdH1h8D;
		}
		[CompilerGenerated]
		set
		{
			LbAIdH1h8D = value;
		}
	}

	[JsonProperty("contextsExpiredAt")]
	public long[] ContextsExpiredAt
	{
		[CompilerGenerated]
		get
		{
			return B38Iooc5iK;
		}
		[CompilerGenerated]
		set
		{
			B38Iooc5iK = value;
		}
	}

	[JsonProperty("expiredAt")]
	public long ExpiredAt
	{
		[CompilerGenerated]
		get
		{
			return YsrIT6ykNj;
		}
		[CompilerGenerated]
		set
		{
			YsrIT6ykNj = value;
		}
	}

	[JsonProperty("etags")]
	public Dictionary<string, object>[] Etags
	{
		[CompilerGenerated]
		get
		{
			return IPkIMcDFaQ;
		}
		[CompilerGenerated]
		set
		{
			IPkIMcDFaQ = value;
		}
	}

	[JsonProperty("uploadId")]
	public string UploadId
	{
		[CompilerGenerated]
		get
		{
			return NPIIAiCvTJ;
		}
		[CompilerGenerated]
		set
		{
			NPIIAiCvTJ = value;
		}
	}

	[JsonProperty("uploaded")]
	public long Uploaded
	{
		[CompilerGenerated]
		get
		{
			return k6aIOYAcN6;
		}
		[CompilerGenerated]
		set
		{
			k6aIOYAcN6 = value;
		}
	}

	public string ToJsonStr()
	{
		return JsonConvert.SerializeObject(this);
	}

	internal static bool IUsFj7fGK1mgZNSYQKG()
	{
		return ED9BymfE4QL6NhqYar7 == null;
	}
}
