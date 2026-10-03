using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Completions;

public class CompletionResult : ApiResultBase
{
	[CompilerGenerated]
	private string IdrVvb6CXC;

	[CompilerGenerated]
	private List<Choice> jQZVS8tpKM;

	[CompilerGenerated]
	private CompletionUsage DO4V2cctQe;

	internal static CompletionResult EscyGgauQZw8egPWUOu;

	[JsonProperty("id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return IdrVvb6CXC;
		}
		[CompilerGenerated]
		set
		{
			IdrVvb6CXC = value;
		}
	}

	[JsonProperty("choices")]
	public List<Choice> Completions
	{
		[CompilerGenerated]
		get
		{
			return jQZVS8tpKM;
		}
		[CompilerGenerated]
		set
		{
			jQZVS8tpKM = value;
		}
	}

	[JsonProperty("usage")]
	public CompletionUsage Usage
	{
		[CompilerGenerated]
		get
		{
			return DO4V2cctQe;
		}
		[CompilerGenerated]
		set
		{
			DO4V2cctQe = value;
		}
	}

	public override string ToString()
	{
		if (Completions != null && Completions.Count > 0)
		{
			return Completions[0].ToString();
		}
		return "CompletionResult " + Id + " has no valid output";
	}

	internal static bool OPkgHTaovFTiNkUwHRy()
	{
		return EscyGgauQZw8egPWUOu == null;
	}
}
