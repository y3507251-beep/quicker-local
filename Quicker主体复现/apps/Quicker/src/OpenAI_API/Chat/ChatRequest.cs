using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;

namespace OpenAI_API.Chat;

public class ChatRequest
{
	public static class ResponseFormats
	{
		public const string Text = "text";

		public const string JsonObject = "json_object";
	}

	[CompilerGenerated]
	private string ssVVsAnwa7 = OpenAI_API.Models.Model.DefaultChatModel;

	[CompilerGenerated]
	private IList<ChatMessage> oPRVHQVgv3;

	[CompilerGenerated]
	private double? fOtV1w98GO;

	[CompilerGenerated]
	private double? rhbVbSNIAn;

	[CompilerGenerated]
	private int? XooV6YHTj2;

	[CompilerGenerated]
	private bool tWHVXSBALn;

	[CompilerGenerated]
	private string[] XSCVmuxw2G;

	[CompilerGenerated]
	private int? EpRVK4QZRO;

	[CompilerGenerated]
	private double? nPjVxjnLHL;

	[CompilerGenerated]
	private double? L8hVr55VW6;

	[CompilerGenerated]
	private IReadOnlyDictionary<string, float> stuVph3olx;

	[CompilerGenerated]
	private string dOIVBQEbxm;

	[CompilerGenerated]
	private string HmUVQjErMg = "text";

	[CompilerGenerated]
	private int? jGDVjnnZq8;

	internal static ChatRequest EAuHNfaTi77v6h7X454;

	[JsonProperty("model")]
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return ssVVsAnwa7;
		}
		[CompilerGenerated]
		set
		{
			ssVVsAnwa7 = value;
		}
	}

	[JsonProperty("messages")]
	public IList<ChatMessage> Messages
	{
		[CompilerGenerated]
		get
		{
			return oPRVHQVgv3;
		}
		[CompilerGenerated]
		set
		{
			oPRVHQVgv3 = value;
		}
	}

	[JsonProperty("temperature")]
	public double? Temperature
	{
		[CompilerGenerated]
		get
		{
			return fOtV1w98GO;
		}
		[CompilerGenerated]
		set
		{
			fOtV1w98GO = value;
		}
	}

	[JsonProperty("top_p")]
	public double? TopP
	{
		[CompilerGenerated]
		get
		{
			return rhbVbSNIAn;
		}
		[CompilerGenerated]
		set
		{
			rhbVbSNIAn = value;
		}
	}

	[JsonProperty("n")]
	public int? NumChoicesPerMessage
	{
		[CompilerGenerated]
		get
		{
			return XooV6YHTj2;
		}
		[CompilerGenerated]
		set
		{
			XooV6YHTj2 = value;
		}
	}

	[JsonProperty("stream")]
	public bool Stream
	{
		[CompilerGenerated]
		get
		{
			return tWHVXSBALn;
		}
		[CompilerGenerated]
		internal set
		{
			tWHVXSBALn = value;
		}
	}

	[JsonProperty("stop")]
	internal object p1AVWKTpyL
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
			return XSCVmuxw2G;
		}
		[CompilerGenerated]
		set
		{
			XSCVmuxw2G = value;
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

	[JsonProperty("max_tokens")]
	public int? MaxTokens
	{
		[CompilerGenerated]
		get
		{
			return EpRVK4QZRO;
		}
		[CompilerGenerated]
		set
		{
			EpRVK4QZRO = value;
		}
	}

	[JsonProperty("frequency_penalty")]
	public double? FrequencyPenalty
	{
		[CompilerGenerated]
		get
		{
			return nPjVxjnLHL;
		}
		[CompilerGenerated]
		set
		{
			nPjVxjnLHL = value;
		}
	}

	[JsonProperty("presence_penalty")]
	public double? PresencePenalty
	{
		[CompilerGenerated]
		get
		{
			return L8hVr55VW6;
		}
		[CompilerGenerated]
		set
		{
			L8hVr55VW6 = value;
		}
	}

	[JsonProperty("logit_bias")]
	public IReadOnlyDictionary<string, float> LogitBias
	{
		[CompilerGenerated]
		get
		{
			return stuVph3olx;
		}
		[CompilerGenerated]
		set
		{
			stuVph3olx = value;
		}
	}

	[JsonProperty("user")]
	public string user
	{
		[CompilerGenerated]
		get
		{
			return dOIVBQEbxm;
		}
		[CompilerGenerated]
		set
		{
			dOIVBQEbxm = value;
		}
	}

	[JsonIgnore]
	public string ResponseFormat
	{
		[CompilerGenerated]
		get
		{
			return HmUVQjErMg;
		}
		[CompilerGenerated]
		set
		{
			HmUVQjErMg = value;
		}
	}

	[JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Ignore)]
	internal Dictionary<string, object> Bd9VGFI5Y3
	{
		get
		{
			if (!string.IsNullOrEmpty(ResponseFormat) && !(ResponseFormat == "text"))
			{
				if (ResponseFormat.Trim().StartsWith("{"))
				{
					return JsonConvert.DeserializeObject<Dictionary<string, object>>(ResponseFormat);
				}
				return new Dictionary<string, object> { { "type", ResponseFormat } };
			}
			return null;
		}
	}

	[JsonProperty("seed", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? Seed
	{
		[CompilerGenerated]
		get
		{
			return jGDVjnnZq8;
		}
		[CompilerGenerated]
		set
		{
			jGDVjnnZq8 = value;
		}
	}

	public ChatRequest()
	{
	}

	public ChatRequest(ChatRequest basedOn)
	{
		if (basedOn != null)
		{
			Model = basedOn.Model;
			Messages = basedOn.Messages;
			Temperature = basedOn.Temperature;
			TopP = basedOn.TopP;
			NumChoicesPerMessage = basedOn.NumChoicesPerMessage;
			MultipleStopSequences = basedOn.MultipleStopSequences;
			MaxTokens = basedOn.MaxTokens;
			FrequencyPenalty = basedOn.FrequencyPenalty;
			PresencePenalty = basedOn.PresencePenalty;
			LogitBias = basedOn.LogitBias;
			ResponseFormat = basedOn.ResponseFormat;
			Seed = basedOn.Seed;
			user = basedOn.user;
			Stream = basedOn.Stream;
		}
	}

	internal static bool tnyGSoamPfCoU1NX6c5()
	{
		return EAuHNfaTi77v6h7X454 == null;
	}
}
