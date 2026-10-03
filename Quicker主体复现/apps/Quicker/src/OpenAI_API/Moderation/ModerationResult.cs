using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Moderation;

public class ModerationResult : ApiResultBase
{
	[CompilerGenerated]
	private List<Result> MsPqWwOmBw;

	[CompilerGenerated]
	private string kt1qkDvOyh;

	private static ModerationResult w90ehHk2Tdb9lyux1mZ;

	[JsonProperty("results")]
	public List<Result> Results
	{
		[CompilerGenerated]
		get
		{
			return MsPqWwOmBw;
		}
		[CompilerGenerated]
		set
		{
			MsPqWwOmBw = value;
		}
	}

	[JsonProperty("id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return kt1qkDvOyh;
		}
		[CompilerGenerated]
		set
		{
			kt1qkDvOyh = value;
		}
	}

	public override string ToString()
	{
		return Results?.First()?.MainContentFlag;
	}

	static ModerationResult()
	{
	}

	internal static bool yuUoX5kA5hUVCs25Y9p()
	{
		return w90ehHk2Tdb9lyux1mZ == null;
	}

	internal static void yDKEQUkeGcMLodngnrn()
	{
	}
}
