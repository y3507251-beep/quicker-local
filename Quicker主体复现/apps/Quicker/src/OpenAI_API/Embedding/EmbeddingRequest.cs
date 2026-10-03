using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;

namespace OpenAI_API.Embedding;

public class EmbeddingRequest
{
	[CompilerGenerated]
	private string UVEcX6Kadh;

	[CompilerGenerated]
	private string j5IcmPVFIR;

	[CompilerGenerated]
	private int? xc2cKvObqU;

	internal static EmbeddingRequest hAGfaKaXYMvmmTnpGGo;

	[JsonProperty("model")]
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return UVEcX6Kadh;
		}
		[CompilerGenerated]
		set
		{
			UVEcX6Kadh = value;
		}
	}

	[JsonProperty("input")]
	public string Input
	{
		[CompilerGenerated]
		get
		{
			return j5IcmPVFIR;
		}
		[CompilerGenerated]
		set
		{
			j5IcmPVFIR = value;
		}
	}

	[JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
	public int? Dimensions
	{
		[CompilerGenerated]
		get
		{
			return xc2cKvObqU;
		}
		[CompilerGenerated]
		set
		{
			xc2cKvObqU = value;
		}
	}

	public EmbeddingRequest()
	{
	}

	public EmbeddingRequest(Model model, string input, int? dimensions = null)
	{
		Model = model;
		Input = input;
		Dimensions = dimensions;
	}

	public EmbeddingRequest(string input)
	{
		Model = OpenAI_API.Models.Model.DefaultEmbeddingModel;
		Input = input;
	}

	internal static bool nyyn3Ya2EJ3XlwpATrA()
	{
		return hAGfaKaXYMvmmTnpGGo == null;
	}
}
