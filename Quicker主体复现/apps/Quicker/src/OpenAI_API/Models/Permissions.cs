using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Models;

public class Permissions
{
	[CompilerGenerated]
	private string iJKqfNLWYM;

	[CompilerGenerated]
	private string MssqzkaWR7;

	[CompilerGenerated]
	private long QUQcw5iyLm;

	[CompilerGenerated]
	private bool xVoctWiRUE;

	[CompilerGenerated]
	private bool GxIcgbrDwm;

	[CompilerGenerated]
	private bool Vk9cLQHHqG;

	[CompilerGenerated]
	private bool UitcvLhi2E;

	[CompilerGenerated]
	private bool sy7cSOCiF7;

	[CompilerGenerated]
	private bool UVBc2JTLJs;

	[CompilerGenerated]
	private string cuhcuNAYQC;

	[CompilerGenerated]
	private string EWucNH8w6f;

	[CompilerGenerated]
	private bool nuHcJKW8Mf;

	private static Permissions WIyfMlk91jabq3FJxjQ;

	[JsonProperty("id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return iJKqfNLWYM;
		}
		[CompilerGenerated]
		set
		{
			iJKqfNLWYM = value;
		}
	}

	[JsonProperty("object")]
	public string Object
	{
		[CompilerGenerated]
		get
		{
			return MssqzkaWR7;
		}
		[CompilerGenerated]
		set
		{
			MssqzkaWR7 = value;
		}
	}

	[JsonIgnore]
	public DateTime Created => DateTimeOffset.FromUnixTimeSeconds(CreatedUnixTime).DateTime;

	[JsonProperty("created")]
	public long CreatedUnixTime
	{
		[CompilerGenerated]
		get
		{
			return QUQcw5iyLm;
		}
		[CompilerGenerated]
		set
		{
			QUQcw5iyLm = value;
		}
	}

	[JsonProperty("allow_create_engine")]
	public bool AllowCreateEngine
	{
		[CompilerGenerated]
		get
		{
			return xVoctWiRUE;
		}
		[CompilerGenerated]
		set
		{
			xVoctWiRUE = value;
		}
	}

	[JsonProperty("allow_sampling")]
	public bool AllowSampling
	{
		[CompilerGenerated]
		get
		{
			return GxIcgbrDwm;
		}
		[CompilerGenerated]
		set
		{
			GxIcgbrDwm = value;
		}
	}

	[JsonProperty("allow_logprobs")]
	public bool AllowLogProbs
	{
		[CompilerGenerated]
		get
		{
			return Vk9cLQHHqG;
		}
		[CompilerGenerated]
		set
		{
			Vk9cLQHHqG = value;
		}
	}

	[JsonProperty("allow_search_indices")]
	public bool AllowSearchIndices
	{
		[CompilerGenerated]
		get
		{
			return UitcvLhi2E;
		}
		[CompilerGenerated]
		set
		{
			UitcvLhi2E = value;
		}
	}

	[JsonProperty("allow_view")]
	public bool AllowView
	{
		[CompilerGenerated]
		get
		{
			return sy7cSOCiF7;
		}
		[CompilerGenerated]
		set
		{
			sy7cSOCiF7 = value;
		}
	}

	[JsonProperty("allow_fine_tuning")]
	public bool AllowFineTuning
	{
		[CompilerGenerated]
		get
		{
			return UVBc2JTLJs;
		}
		[CompilerGenerated]
		set
		{
			UVBc2JTLJs = value;
		}
	}

	[JsonProperty("organization")]
	public string Organization
	{
		[CompilerGenerated]
		get
		{
			return cuhcuNAYQC;
		}
		[CompilerGenerated]
		set
		{
			cuhcuNAYQC = value;
		}
	}

	[JsonProperty("group")]
	public string Group
	{
		[CompilerGenerated]
		get
		{
			return EWucNH8w6f;
		}
		[CompilerGenerated]
		set
		{
			EWucNH8w6f = value;
		}
	}

	[JsonProperty("is_blocking")]
	public bool IsBlocking
	{
		[CompilerGenerated]
		get
		{
			return nuHcJKW8Mf;
		}
		[CompilerGenerated]
		set
		{
			nuHcJKW8Mf = value;
		}
	}

	internal static bool MLZhDVkL3nPwhbtwn3C()
	{
		return WIyfMlk91jabq3FJxjQ == null;
	}
}
