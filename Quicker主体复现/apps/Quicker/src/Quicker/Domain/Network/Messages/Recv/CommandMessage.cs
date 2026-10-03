using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Recv;

public class CommandMessage : MessageBase
{
	public const string OPEN_MAINWIN = "OPEN_MAINWIN";

	public const string START_VOICE_INPUT = "START_VOICE_INPUT";

	public const string RESEND_STATE = "RESEND_STATE";

	public const string LOCK_PANEL = "LOCK_PANEL";

	public const string CHANGE_PAGE = "CHANGE_PAGE";

	public const string DATA_PAGE_GLOBAL_LEFT = "DATA_GLOBAL_LEFT";

	public const string DATA_PAGE_GLOBAL_RIGHT = "DATA_GLOBAL_RIGHT";

	public const string DATA_PAGE_CONTEXT_LEFT = "DATA_CONTEXT_LEFT";

	public const string DATA_PAGE_CONTEXT_RIGHT = "DATA_CONTEXT_RIGHT";

	public const int MSG_TYPE = 110;

	[CompilerGenerated]
	private string PARtcZWVijt;

	[CompilerGenerated]
	private string CkItc9HbkZ4;

	internal static CommandMessage Mif1QxQ0O284SEKFXUyi;

	public string Command
	{
		[CompilerGenerated]
		get
		{
			return PARtcZWVijt;
		}
		[CompilerGenerated]
		set
		{
			PARtcZWVijt = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return CkItc9HbkZ4;
		}
		[CompilerGenerated]
		set
		{
			CkItc9HbkZ4 = value;
		}
	}

	public override int MessageType => 110;

	internal static bool vuUWNqQ0JLES9k9D6GkE()
	{
		return Mif1QxQ0O284SEKFXUyi == null;
	}
}
