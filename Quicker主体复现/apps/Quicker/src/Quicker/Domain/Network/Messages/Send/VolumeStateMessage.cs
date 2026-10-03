using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Send;

public class VolumeStateMessage : MessageBase
{
	public const int MSG_TYPE = 2;

	[CompilerGenerated]
	private bool x7Htcqs508G;

	[CompilerGenerated]
	private int Qv5tccCqYvl;

	private static VolumeStateMessage F28AeiQ00XFaUOuTd8UH;

	public override int MessageType => 2;

	public bool Mute
	{
		[CompilerGenerated]
		get
		{
			return x7Htcqs508G;
		}
		[CompilerGenerated]
		set
		{
			x7Htcqs508G = value;
		}
	}

	public int MasterVolume
	{
		[CompilerGenerated]
		get
		{
			return Qv5tccCqYvl;
		}
		[CompilerGenerated]
		set
		{
			Qv5tccCqYvl = value;
		}
	}

	internal static bool bsYlQAQ01CMDCRNHSBYf()
	{
		return F28AeiQ00XFaUOuTd8UH == null;
	}
}
