using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;

namespace OpenAI_API.Audio;

public class AudioRequest
{
	public static class ResponseFormats
	{
		public const string JSON = "json";

		public const string Text = "text";

		public const string SRT = "srt";

		public const string VerboseJson = "verbose_json";

		public const string VTT = "vtt";

		static ResponseFormats()
		{
		}

		internal static void rgngAPcBEpNStkC3bZVP()
		{
		}
	}

	[CompilerGenerated]
	private string HTLZwlVAed = OpenAI_API.Models.Model.DefaultTranscriptionModel;

	[CompilerGenerated]
	private string kMEZtBHZqK;

	[CompilerGenerated]
	private string AJUZgQ3Vtp;

	[CompilerGenerated]
	private string wxQZLFlsPW;

	[CompilerGenerated]
	private double zBfZv27mbR;

	private static AudioRequest Dsj4CBrnuKDgIeg8tJR;

	[JsonProperty("model")]
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return HTLZwlVAed;
		}
		[CompilerGenerated]
		set
		{
			HTLZwlVAed = value;
		}
	}

	[JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Prompt
	{
		[CompilerGenerated]
		get
		{
			return kMEZtBHZqK;
		}
		[CompilerGenerated]
		set
		{
			kMEZtBHZqK = value;
		}
	}

	[JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Language
	{
		[CompilerGenerated]
		get
		{
			return AJUZgQ3Vtp;
		}
		[CompilerGenerated]
		set
		{
			AJUZgQ3Vtp = value;
		}
	}

	[JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ResponseFormat
	{
		[CompilerGenerated]
		get
		{
			return wxQZLFlsPW;
		}
		[CompilerGenerated]
		set
		{
			wxQZLFlsPW = value;
		}
	}

	[JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Temperature
	{
		[CompilerGenerated]
		get
		{
			return zBfZv27mbR;
		}
		[CompilerGenerated]
		set
		{
			zBfZv27mbR = value;
		}
	}

	internal static bool NdbYFwrexPJebd0uSel()
	{
		return Dsj4CBrnuKDgIeg8tJR == null;
	}
}
