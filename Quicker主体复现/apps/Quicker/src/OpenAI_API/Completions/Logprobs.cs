using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Completions;

public class Logprobs
{
	[CompilerGenerated]
	private List<string> NQEVu4emfF;

	[CompilerGenerated]
	private List<double?> h4yVNu9pMb;

	[CompilerGenerated]
	private IList<IDictionary<string, double>> MAuVJ7wEYg;

	[CompilerGenerated]
	private List<int> nK6V0HfUQU;

	internal static Logprobs JjZN19aqmZqJZeg8TNl;

	[JsonProperty("tokens")]
	public List<string> Tokens
	{
		[CompilerGenerated]
		get
		{
			return NQEVu4emfF;
		}
		[CompilerGenerated]
		set
		{
			NQEVu4emfF = value;
		}
	}

	[JsonProperty("token_logprobs")]
	public List<double?> TokenLogprobs
	{
		[CompilerGenerated]
		get
		{
			return h4yVNu9pMb;
		}
		[CompilerGenerated]
		set
		{
			h4yVNu9pMb = value;
		}
	}

	[JsonProperty("top_logprobs")]
	public IList<IDictionary<string, double>> TopLogprobs
	{
		[CompilerGenerated]
		get
		{
			return MAuVJ7wEYg;
		}
		[CompilerGenerated]
		set
		{
			MAuVJ7wEYg = value;
		}
	}

	[JsonProperty("text_offset")]
	public List<int> TextOffsets
	{
		[CompilerGenerated]
		get
		{
			return nK6V0HfUQU;
		}
		[CompilerGenerated]
		set
		{
			nK6V0HfUQU = value;
		}
	}

	internal static bool dFIA9aaiJBAmHGYVlAy()
	{
		return JjZN19aqmZqJZeg8TNl == null;
	}
}
