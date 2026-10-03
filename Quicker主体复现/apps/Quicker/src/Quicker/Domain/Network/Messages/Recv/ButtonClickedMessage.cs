using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Recv;

public class ButtonClickedMessage : MessageBase
{
	public const int MSG_TYPE = 101;

	[CompilerGenerated]
	private int tj3tcVj94Kr;

	internal static ButtonClickedMessage Ux0dTWQ0BB4iOZIDYLAq;

	public int ButtonIndex
	{
		[CompilerGenerated]
		get
		{
			return tj3tcVj94Kr;
		}
		[CompilerGenerated]
		set
		{
			tj3tcVj94Kr = value;
		}
	}

	public override int MessageType => 101;

	internal static bool OBJmh4Q0v4hV3cIr5A62()
	{
		return Ux0dTWQ0BB4iOZIDYLAq == null;
	}
}
