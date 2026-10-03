using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Chat;

public class ChatChoice
{
	[CompilerGenerated]
	private int ovxVdZlLl0;

	[CompilerGenerated]
	private ChatMessage AgAVoPQicH;

	[CompilerGenerated]
	private string guAVTrr7nF;

	[CompilerGenerated]
	private ChatMessage GWaVMvUnMY;

	private static ChatChoice lnCKGJahjZoYStsEQDe;

	[JsonProperty("index")]
	public int Index
	{
		[CompilerGenerated]
		get
		{
			return ovxVdZlLl0;
		}
		[CompilerGenerated]
		set
		{
			ovxVdZlLl0 = value;
		}
	}

	[JsonProperty("message")]
	public ChatMessage Message
	{
		[CompilerGenerated]
		get
		{
			return AgAVoPQicH;
		}
		[CompilerGenerated]
		set
		{
			AgAVoPQicH = value;
		}
	}

	[JsonProperty("finish_reason")]
	public string FinishReason
	{
		[CompilerGenerated]
		get
		{
			return guAVTrr7nF;
		}
		[CompilerGenerated]
		set
		{
			guAVTrr7nF = value;
		}
	}

	[JsonProperty("delta")]
	public ChatMessage Delta
	{
		[CompilerGenerated]
		get
		{
			return GWaVMvUnMY;
		}
		[CompilerGenerated]
		set
		{
			GWaVMvUnMY = value;
		}
	}

	public override string ToString()
	{
		if (Message == null && Delta != null)
		{
			return Delta.TextContent;
		}
		return Message.TextContent;
	}

	internal static bool Mn0gJRaHE8UWUyVJ1iJ()
	{
		return lnCKGJahjZoYStsEQDe == null;
	}
}
