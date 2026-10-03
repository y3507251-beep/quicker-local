using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Recv;

public class UpdateVolumeMessage : MessageBase
{
	public const int MSG_TYPE = 103;

	[CompilerGenerated]
	private int cdCtcsdj7na;

	internal static UpdateVolumeMessage rEeEJmQ0g57YoJ6PM9nB;

	public int MasterVolume
	{
		[CompilerGenerated]
		get
		{
			return cdCtcsdj7na;
		}
		[CompilerGenerated]
		set
		{
			cdCtcsdj7na = value;
		}
	}

	public override int MessageType => 103;

	internal static bool UlUTZoQ0P5f5v8JTVXWK()
	{
		return rEeEJmQ0g57YoJ6PM9nB == null;
	}
}
