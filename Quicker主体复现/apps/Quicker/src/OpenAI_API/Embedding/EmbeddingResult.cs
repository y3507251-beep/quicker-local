using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Embedding;

public class EmbeddingResult : ApiResultBase
{
	[CompilerGenerated]
	private List<Data> RwlcxoekuM;

	[CompilerGenerated]
	private Usage gfOcrKEXLY;

	internal static EmbeddingResult OEM1XganYscVeUxrG6S;

	[JsonProperty("data")]
	public List<Data> Data
	{
		[CompilerGenerated]
		get
		{
			return RwlcxoekuM;
		}
		[CompilerGenerated]
		set
		{
			RwlcxoekuM = value;
		}
	}

	[JsonProperty("usage")]
	public Usage Usage
	{
		[CompilerGenerated]
		get
		{
			return gfOcrKEXLY;
		}
		[CompilerGenerated]
		set
		{
			gfOcrKEXLY = value;
		}
	}

	public static implicit operator float[](EmbeddingResult embeddingResult)
	{
		return embeddingResult.Data.FirstOrDefault()?.Embedding;
	}

	internal static bool uRSd0XaemURSj25VDmW()
	{
		return OEM1XganYscVeUxrG6S == null;
	}
}
