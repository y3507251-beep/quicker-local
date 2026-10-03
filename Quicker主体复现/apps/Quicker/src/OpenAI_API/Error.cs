using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API;

public class Error
{
	[CompilerGenerated]
	private string? PE2Ri9fCLC;

	[CompilerGenerated]
	private string? zcTR3k4LvT;

	[CompilerGenerated]
	private string? v99Rfw8Bbp;

	[CompilerGenerated]
	private string? xHIRzjpRiH;

	internal static Error? kXHompJgxnOCTAcswNA;

	[JsonProperty("code")]
	public string? Code
	{
		[CompilerGenerated]
		get
		{
			return PE2Ri9fCLC;
		}
		[CompilerGenerated]
		set
		{
			PE2Ri9fCLC = value;
		}
	}

	[JsonProperty("message")]
	public string? Message
	{
		[CompilerGenerated]
		get
		{
			return zcTR3k4LvT;
		}
		[CompilerGenerated]
		set
		{
			zcTR3k4LvT = value;
		}
	}

	[JsonProperty("param")]
	public string? Param
	{
		[CompilerGenerated]
		get
		{
			return v99Rfw8Bbp;
		}
		[CompilerGenerated]
		set
		{
			v99Rfw8Bbp = value;
		}
	}

	[JsonProperty("type")]
	public string? Type
	{
		[CompilerGenerated]
		get
		{
			return xHIRzjpRiH;
		}
		[CompilerGenerated]
		set
		{
			xHIRzjpRiH = value;
		}
	}

	internal static bool FhwEx5JPi11PZvWOSq7()
	{
		return kXHompJgxnOCTAcswNA == null;
	}
}
