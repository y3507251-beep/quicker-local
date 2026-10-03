using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Completions;

public class Choice
{
	[CompilerGenerated]
	private string d85czFs5Jv;

	[CompilerGenerated]
	private int FjDVwy1Vvy;

	[CompilerGenerated]
	private Logprobs XuAVtE7qjM;

	[CompilerGenerated]
	private string kqoVgNLYpP;

	private static Choice o5Vo7Nakg6yeY0igKCn;

	[JsonProperty("text")]
	public string Text
	{
		[CompilerGenerated]
		get
		{
			return d85czFs5Jv;
		}
		[CompilerGenerated]
		set
		{
			d85czFs5Jv = value;
		}
	}

	[JsonProperty("index")]
	public int Index
	{
		[CompilerGenerated]
		get
		{
			return FjDVwy1Vvy;
		}
		[CompilerGenerated]
		set
		{
			FjDVwy1Vvy = value;
		}
	}

	[JsonProperty("logprobs")]
	public Logprobs Logprobs
	{
		[CompilerGenerated]
		get
		{
			return XuAVtE7qjM;
		}
		[CompilerGenerated]
		set
		{
			XuAVtE7qjM = value;
		}
	}

	[JsonProperty("finish_reason")]
	public string FinishReason
	{
		[CompilerGenerated]
		get
		{
			return kqoVgNLYpP;
		}
		[CompilerGenerated]
		set
		{
			kqoVgNLYpP = value;
		}
	}

	public override string ToString()
	{
		return Text;
	}

	internal static bool zmAk1qaaGLanU3hJi82()
	{
		return o5Vo7Nakg6yeY0igKCn == null;
	}
}
