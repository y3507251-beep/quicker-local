using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;

namespace OpenAI_API.Completions;

public class CompletionRequest
{
	[CompilerGenerated]
	private string rAic46mMlo = OpenAI_API.Models.Model.DefaultModel;

	[CompilerGenerated]
	private string[] rp5c5jJFNa;

	[CompilerGenerated]
	private string rBycDGLABl;

	[CompilerGenerated]
	private int? hAKcdNRI7D;

	[CompilerGenerated]
	private double? JQHcoZ9NUW;

	[CompilerGenerated]
	private double? egDcTFstFF;

	[CompilerGenerated]
	private double? K7KcMQev4C;

	[CompilerGenerated]
	private double? f2NcAalj36;

	[CompilerGenerated]
	private int? LGQcOyb3yF;

	[CompilerGenerated]
	private bool abvcFV9ECq;

	[CompilerGenerated]
	private int? BqtcUd7BXZ;

	[CompilerGenerated]
	private bool? LCgclwPGaj;

	[CompilerGenerated]
	private string[] LpLci5lElD;

	[CompilerGenerated]
	private int? pATc3D0CGd;

	[CompilerGenerated]
	private string bXrcfogP1g;

	private static CompletionRequest b3XAcSadlaC29PrSDMc;

	[JsonProperty("model")]
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return rAic46mMlo;
		}
		[CompilerGenerated]
		set
		{
			rAic46mMlo = value;
		}
	}

	[JsonProperty("prompt")]
	public object CompiledPrompt
	{
		get
		{
			string[] multiplePrompts = MultiplePrompts;
			if (multiplePrompts != null && multiplePrompts.Length == 1)
			{
				return Prompt;
			}
			return MultiplePrompts;
		}
	}

	[JsonIgnore]
	public string[] MultiplePrompts
	{
		[CompilerGenerated]
		get
		{
			return rp5c5jJFNa;
		}
		[CompilerGenerated]
		set
		{
			rp5c5jJFNa = value;
		}
	}

	[JsonIgnore]
	public string Prompt
	{
		get
		{
			return MultiplePrompts.FirstOrDefault();
		}
		set
		{
			MultiplePrompts = new string[1] { value };
		}
	}

	[JsonProperty("suffix")]
	public string Suffix
	{
		[CompilerGenerated]
		get
		{
			return rBycDGLABl;
		}
		[CompilerGenerated]
		set
		{
			rBycDGLABl = value;
		}
	}

	[JsonProperty("max_tokens")]
	public int? MaxTokens
	{
		[CompilerGenerated]
		get
		{
			return hAKcdNRI7D;
		}
		[CompilerGenerated]
		set
		{
			hAKcdNRI7D = value;
		}
	}

	[JsonProperty("temperature")]
	public double? Temperature
	{
		[CompilerGenerated]
		get
		{
			return JQHcoZ9NUW;
		}
		[CompilerGenerated]
		set
		{
			JQHcoZ9NUW = value;
		}
	}

	[JsonProperty("top_p")]
	public double? TopP
	{
		[CompilerGenerated]
		get
		{
			return egDcTFstFF;
		}
		[CompilerGenerated]
		set
		{
			egDcTFstFF = value;
		}
	}

	[JsonProperty("presence_penalty")]
	public double? PresencePenalty
	{
		[CompilerGenerated]
		get
		{
			return K7KcMQev4C;
		}
		[CompilerGenerated]
		set
		{
			K7KcMQev4C = value;
		}
	}

	[JsonProperty("frequency_penalty")]
	public double? FrequencyPenalty
	{
		[CompilerGenerated]
		get
		{
			return f2NcAalj36;
		}
		[CompilerGenerated]
		set
		{
			f2NcAalj36 = value;
		}
	}

	[JsonProperty("n")]
	public int? NumChoicesPerPrompt
	{
		[CompilerGenerated]
		get
		{
			return LGQcOyb3yF;
		}
		[CompilerGenerated]
		set
		{
			LGQcOyb3yF = value;
		}
	}

	[JsonProperty("stream")]
	public bool Stream
	{
		[CompilerGenerated]
		get
		{
			return abvcFV9ECq;
		}
		[CompilerGenerated]
		internal set
		{
			abvcFV9ECq = value;
		}
	}

	[JsonProperty("logprobs")]
	public int? Logprobs
	{
		[CompilerGenerated]
		get
		{
			return BqtcUd7BXZ;
		}
		[CompilerGenerated]
		set
		{
			BqtcUd7BXZ = value;
		}
	}

	[JsonProperty("echo")]
	public bool? Echo
	{
		[CompilerGenerated]
		get
		{
			return LCgclwPGaj;
		}
		[CompilerGenerated]
		set
		{
			LCgclwPGaj = value;
		}
	}

	[JsonProperty("stop")]
	public object CompiledStop
	{
		get
		{
			string[] multipleStopSequences = MultipleStopSequences;
			if (multipleStopSequences != null && multipleStopSequences.Length == 1)
			{
				return StopSequence;
			}
			string[] multipleStopSequences2 = MultipleStopSequences;
			if (multipleStopSequences2 != null && multipleStopSequences2.Length != 0)
			{
				return MultipleStopSequences;
			}
			return null;
		}
	}

	[JsonIgnore]
	public string[] MultipleStopSequences
	{
		[CompilerGenerated]
		get
		{
			return LpLci5lElD;
		}
		[CompilerGenerated]
		set
		{
			LpLci5lElD = value;
		}
	}

	[JsonIgnore]
	public string StopSequence
	{
		get
		{
			string[] multipleStopSequences = MultipleStopSequences;
			object obj;
			if (multipleStopSequences == null)
			{
				obj = null;
			}
			else
			{
				obj = multipleStopSequences.FirstOrDefault();
				if (obj != null)
				{
					goto IL_0017;
				}
			}
			obj = null;
			goto IL_0017;
			IL_0017:
			return (string)obj;
		}
		set
		{
			if (value != null)
			{
				MultipleStopSequences = new string[1] { value };
			}
		}
	}

	[JsonProperty("best_of")]
	public int? BestOf
	{
		[CompilerGenerated]
		get
		{
			return pATc3D0CGd;
		}
		[CompilerGenerated]
		set
		{
			pATc3D0CGd = value;
		}
	}

	[JsonProperty("user")]
	public string user
	{
		[CompilerGenerated]
		get
		{
			return bXrcfogP1g;
		}
		[CompilerGenerated]
		set
		{
			bXrcfogP1g = value;
		}
	}

	public CompletionRequest()
	{
		Model = OpenAI_API.Models.Model.DefaultModel;
	}

	public CompletionRequest(CompletionRequest basedOn)
	{
		Model = basedOn.Model;
		MultiplePrompts = basedOn.MultiplePrompts;
		MaxTokens = basedOn.MaxTokens;
		Temperature = basedOn.Temperature;
		TopP = basedOn.TopP;
		NumChoicesPerPrompt = basedOn.NumChoicesPerPrompt;
		PresencePenalty = basedOn.PresencePenalty;
		FrequencyPenalty = basedOn.FrequencyPenalty;
		Logprobs = basedOn.Logprobs;
		Echo = basedOn.Echo;
		MultipleStopSequences = basedOn.MultipleStopSequences;
		BestOf = basedOn.BestOf;
		user = basedOn.user;
		Suffix = basedOn.Suffix;
	}

	public CompletionRequest(params string[] prompts)
	{
		MultiplePrompts = prompts;
	}

	public CompletionRequest(string prompt, Model model = null, int? max_tokens = null, double? temperature = null, string suffix = null, double? top_p = null, int? numOutputs = null, double? presencePenalty = null, double? frequencyPenalty = null, int? logProbs = null, bool? echo = null, params string[] stopSequences)
	{
		Model = model;
		Prompt = prompt;
		MaxTokens = max_tokens;
		Temperature = temperature;
		Suffix = suffix;
		TopP = top_p;
		NumChoicesPerPrompt = numOutputs;
		PresencePenalty = presencePenalty;
		FrequencyPenalty = frequencyPenalty;
		Logprobs = logProbs;
		Echo = echo;
		MultipleStopSequences = stopSequences;
	}

	internal static bool hOhDTbaOgQjUhRk3JJp()
	{
		return b3XAcSadlaC29PrSDMc == null;
	}
}
