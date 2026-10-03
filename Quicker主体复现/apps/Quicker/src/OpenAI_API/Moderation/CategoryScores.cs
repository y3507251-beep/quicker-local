using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Moderation;

public class CategoryScores
{
	[CompilerGenerated]
	private double ShiqpJOGMU;

	[CompilerGenerated]
	private double uSDqBHWIjq;

	[CompilerGenerated]
	private double TDuqQ7NpNR;

	[CompilerGenerated]
	private double Skvqj1Z4Yr;

	[CompilerGenerated]
	private double fuxqnFn5Be;

	[CompilerGenerated]
	private double KSkq480V8M;

	[CompilerGenerated]
	private double n3Aq5aZdWF;

	internal static CategoryScores jKMvrJkKLTpWAIAVkQF;

	[JsonProperty("hate")]
	public double Hate
	{
		[CompilerGenerated]
		get
		{
			return ShiqpJOGMU;
		}
		[CompilerGenerated]
		set
		{
			ShiqpJOGMU = value;
		}
	}

	[JsonProperty("hate/threatening")]
	public double HateThreatening
	{
		[CompilerGenerated]
		get
		{
			return uSDqBHWIjq;
		}
		[CompilerGenerated]
		set
		{
			uSDqBHWIjq = value;
		}
	}

	[JsonProperty("self-harm")]
	public double SelfHarm
	{
		[CompilerGenerated]
		get
		{
			return TDuqQ7NpNR;
		}
		[CompilerGenerated]
		set
		{
			TDuqQ7NpNR = value;
		}
	}

	[JsonProperty("sexual")]
	public double Sexual
	{
		[CompilerGenerated]
		get
		{
			return Skvqj1Z4Yr;
		}
		[CompilerGenerated]
		set
		{
			Skvqj1Z4Yr = value;
		}
	}

	[JsonProperty("sexual/minors")]
	public double SexualMinors
	{
		[CompilerGenerated]
		get
		{
			return fuxqnFn5Be;
		}
		[CompilerGenerated]
		set
		{
			fuxqnFn5Be = value;
		}
	}

	[JsonProperty("violence")]
	public double Violence
	{
		[CompilerGenerated]
		get
		{
			return KSkq480V8M;
		}
		[CompilerGenerated]
		set
		{
			KSkq480V8M = value;
		}
	}

	[JsonProperty("violence/graphic")]
	public double ViolenceGraphic
	{
		[CompilerGenerated]
		get
		{
			return n3Aq5aZdWF;
		}
		[CompilerGenerated]
		set
		{
			n3Aq5aZdWF = value;
		}
	}

	internal static bool hPO55OkB13gMyOmVkAV()
	{
		return jKMvrJkKLTpWAIAVkQF == null;
	}
}
