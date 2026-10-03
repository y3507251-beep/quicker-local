using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;

namespace OpenAI_API.Audio;

public class TextToSpeechRequest
{
	public static class Voices
	{
		public const string Alloy = "alloy";

		public const string Echo = "echo";

		public const string Fable = "fable";

		public const string Onyx = "onyx";

		public const string Nova = "nova";

		public const string Shimmer = "shimmer";
	}

	public static class ResponseFormats
	{
		public const string MP3 = "mp3";

		public const string FLAC = "flac";

		public const string AAC = "aac";

		public const string OPUS = "opus";
	}

	[CompilerGenerated]
	private string yVkZC33wjs = OpenAI_API.Models.Model.DefaultTTSModel;

	[CompilerGenerated]
	private string PHFZP0LiBe;

	[CompilerGenerated]
	private string wxoZEE7y6E = "alloy";

	[CompilerGenerated]
	private string N0vZy83Ep2;

	[CompilerGenerated]
	private double? cueZ8igdgu;

	internal static TextToSpeechRequest vVQDcOrk9dICQQElrjW;

	[JsonProperty("model")]
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return yVkZC33wjs;
		}
		[CompilerGenerated]
		set
		{
			yVkZC33wjs = value;
		}
	}

	[JsonProperty("input")]
	public string Input
	{
		[CompilerGenerated]
		get
		{
			return PHFZP0LiBe;
		}
		[CompilerGenerated]
		set
		{
			PHFZP0LiBe = value;
		}
	}

	[JsonProperty("voice")]
	public string Voice
	{
		[CompilerGenerated]
		get
		{
			return wxoZEE7y6E;
		}
		[CompilerGenerated]
		set
		{
			wxoZEE7y6E = value;
		}
	}

	[JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ResponseFormat
	{
		[CompilerGenerated]
		get
		{
			return N0vZy83Ep2;
		}
		[CompilerGenerated]
		set
		{
			N0vZy83Ep2 = value;
		}
	}

	[JsonProperty("speed", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double? Speed
	{
		[CompilerGenerated]
		get
		{
			return cueZ8igdgu;
		}
		[CompilerGenerated]
		set
		{
			cueZ8igdgu = value;
		}
	}

	internal static bool Fv9SY6ram9MORZrEmlT()
	{
		return vVQDcOrk9dICQQElrjW == null;
	}
}
