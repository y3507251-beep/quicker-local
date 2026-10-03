using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Qiniu.Storage;

public class BatchInfo
{
	[CompilerGenerated]
	private int dEYebhVV8D;

	[CompilerGenerated]
	private BatchData kvGe6XZV3Z;

	private static BatchInfo m4vZIGLI6gBWF6Lg6jg;

	[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
	public int Code
	{
		[CompilerGenerated]
		get
		{
			return dEYebhVV8D;
		}
		[CompilerGenerated]
		set
		{
			dEYebhVV8D = value;
		}
	}

	[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
	public BatchData Data
	{
		[CompilerGenerated]
		get
		{
			return kvGe6XZV3Z;
		}
		[CompilerGenerated]
		set
		{
			kvGe6XZV3Z = value;
		}
	}

	internal static bool hdnY8dL6OoZgkHZ4t3V()
	{
		return m4vZIGLI6gBWF6Lg6jg == null;
	}
}
