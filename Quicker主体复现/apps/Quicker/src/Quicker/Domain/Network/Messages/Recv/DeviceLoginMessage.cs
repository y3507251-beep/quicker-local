using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Recv;

public class DeviceLoginMessage : MessageBase
{
	public const int MSG_TYPE = 200;

	[CompilerGenerated]
	private string LwjtchmG2BG;

	[CompilerGenerated]
	private string ViCtcebiGWU;

	[CompilerGenerated]
	private string RYItcY3OZou;

	private static DeviceLoginMessage vd8wgSQ0afLlrREkQFjN;

	public string ConnectionCode
	{
		[CompilerGenerated]
		get
		{
			return LwjtchmG2BG;
		}
		[CompilerGenerated]
		set
		{
			LwjtchmG2BG = value;
		}
	}

	public string Version
	{
		[CompilerGenerated]
		get
		{
			return ViCtcebiGWU;
		}
		[CompilerGenerated]
		set
		{
			ViCtcebiGWU = value;
		}
	}

	public string DeviceName
	{
		[CompilerGenerated]
		get
		{
			return RYItcY3OZou;
		}
		[CompilerGenerated]
		set
		{
			RYItcY3OZou = value;
		}
	}

	public override int MessageType => 200;

	internal static bool ACw2p9Q0rnwnldvXUXsj()
	{
		return vd8wgSQ0afLlrREkQFjN == null;
	}
}
