using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Completions;

public class CompletionUsage : Usage
{
	[CompilerGenerated]
	private short joQVLY1gjF;

	private static CompletionUsage giKYYVaNY57icBqu8gA;

	[JsonProperty("completion_tokens")]
	public short CompletionTokens
	{
		[CompilerGenerated]
		get
		{
			return joQVLY1gjF;
		}
		[CompilerGenerated]
		set
		{
			joQVLY1gjF = value;
		}
	}

	internal static bool z3RxS8a9iOPSgweX8hI()
	{
		return giKYYVaNY57icBqu8gA == null;
	}
}
