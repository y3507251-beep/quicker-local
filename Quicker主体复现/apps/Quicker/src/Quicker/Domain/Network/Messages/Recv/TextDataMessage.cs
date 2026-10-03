using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Recv;

public class TextDataMessage : MessageBase
{
	public const int MSG_TYPE = 104;

	[CompilerGenerated]
	private TextDataMessageType ekmtckPl8em;

	[CompilerGenerated]
	private string YCYtcGVRZVn;

	internal static TextDataMessage vP0J7eQ0idDjSatoN0Tg;

	public TextDataMessageType DataType
	{
		[CompilerGenerated]
		get
		{
			return ekmtckPl8em;
		}
		[CompilerGenerated]
		set
		{
			ekmtckPl8em = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return YCYtcGVRZVn;
		}
		[CompilerGenerated]
		set
		{
			YCYtcGVRZVn = value;
		}
	}

	public override int MessageType => 104;

	internal static bool PHWlSXQ0lRuIAapbKPkL()
	{
		return vP0J7eQ0idDjSatoN0Tg == null;
	}

	internal static void hfo6eAQ05ubuVMQcaTUM()
	{
	}
}
