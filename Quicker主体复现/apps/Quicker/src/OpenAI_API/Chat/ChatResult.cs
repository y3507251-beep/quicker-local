using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Chat;

public class ChatResult : ApiResultBase
{
	[CompilerGenerated]
	private string Tk4VnBcOPg;

	[CompilerGenerated]
	private IReadOnlyList<ChatChoice> Uu7V4beD0k;

	[CompilerGenerated]
	private ChatUsage cX5V5g4BQ2;

	[CompilerGenerated]
	private string deUVDI4OYV;

	internal static ChatResult stLLwyaC3WYnTrZs30r;

	[JsonProperty("id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return Tk4VnBcOPg;
		}
		[CompilerGenerated]
		set
		{
			Tk4VnBcOPg = value;
		}
	}

	[JsonProperty("choices")]
	public IReadOnlyList<ChatChoice> Choices
	{
		[CompilerGenerated]
		get
		{
			return Uu7V4beD0k;
		}
		[CompilerGenerated]
		set
		{
			Uu7V4beD0k = value;
		}
	}

	[JsonProperty("usage")]
	public ChatUsage Usage
	{
		[CompilerGenerated]
		get
		{
			return cX5V5g4BQ2;
		}
		[CompilerGenerated]
		set
		{
			cX5V5g4BQ2 = value;
		}
	}

	[JsonProperty("system_fingerprint")]
	public string SystemFingerprint
	{
		[CompilerGenerated]
		get
		{
			return deUVDI4OYV;
		}
		[CompilerGenerated]
		set
		{
			deUVDI4OYV = value;
		}
	}

	public override string ToString()
	{
		if (Choices != null && Choices.Count > 0)
		{
			return Choices[0].ToString();
		}
		return null;
	}

	internal static bool QlcWUHa7ex3ZPHK6Uey()
	{
		return stLLwyaC3WYnTrZs30r == null;
	}
}
