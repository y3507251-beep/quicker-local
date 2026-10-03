using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API;

public class Usage
{
	[CompilerGenerated]
	private int Kbsq9NXalE;

	[CompilerGenerated]
	private int OhyqhlbcxT;

	internal static Usage oAMSGsJ7H2BQYUwfQny;

	[JsonProperty("prompt_tokens")]
	public int PromptTokens
	{
		[CompilerGenerated]
		get
		{
			return Kbsq9NXalE;
		}
		[CompilerGenerated]
		set
		{
			Kbsq9NXalE = value;
		}
	}

	[JsonProperty("total_tokens")]
	public int TotalTokens
	{
		[CompilerGenerated]
		get
		{
			return OhyqhlbcxT;
		}
		[CompilerGenerated]
		set
		{
			OhyqhlbcxT = value;
		}
	}

	internal static bool J9vY3vJ4S8aIScNgH47()
	{
		return oAMSGsJ7H2BQYUwfQny == null;
	}
}
