using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;

namespace OpenAI_API.Moderation;

public class ModerationRequest
{
	[CompilerGenerated]
	private string G0SqYTDoKB;

	[CompilerGenerated]
	private string[] obpqITyWWk;

	private static ModerationRequest KZY4Yrky4r0uQgMD00Y;

	[JsonProperty("model")]
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return G0SqYTDoKB;
		}
		[CompilerGenerated]
		set
		{
			G0SqYTDoKB = value;
		}
	}

	[JsonIgnore]
	public string Input
	{
		get
		{
			if (Inputs == null)
			{
				return null;
			}
			return Inputs.FirstOrDefault();
		}
		set
		{
			Inputs = new string[1] { value };
		}
	}

	[JsonProperty("input")]
	public string[] Inputs
	{
		[CompilerGenerated]
		get
		{
			return obpqITyWWk;
		}
		[CompilerGenerated]
		set
		{
			obpqITyWWk = value;
		}
	}

	public ModerationRequest()
	{
	}

	public ModerationRequest(string input, Model model)
	{
		Model = model;
		Input = input;
	}

	public ModerationRequest(string[] inputs, Model model)
	{
		Model = model;
		Inputs = inputs;
	}

	public ModerationRequest(params string[] input)
	{
		Model = OpenAI_API.Models.Model.TextModerationLatest;
		Inputs = input;
	}

	internal static bool SnscKnkpb9ydCejNPfX()
	{
		return KZY4Yrky4r0uQgMD00Y == null;
	}
}
