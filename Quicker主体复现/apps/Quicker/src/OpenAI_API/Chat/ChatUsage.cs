using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Chat;

public class ChatUsage : Usage
{
	[CompilerGenerated]
	private int losVAE4kjm;

	private static ChatUsage jjjmktrVObJ3vTaeFRF;

	[JsonProperty("completion_tokens")]
	public int CompletionTokens
	{
		[CompilerGenerated]
		get
		{
			return losVAE4kjm;
		}
		[CompilerGenerated]
		set
		{
			losVAE4kjm = value;
		}
	}

	internal static bool EvBn66rQboAKulAwDru()
	{
		return jjjmktrVObJ3vTaeFRF == null;
	}
}
