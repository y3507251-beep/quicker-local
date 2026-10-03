using System.Runtime.CompilerServices;
using Quicker.Domain.Network;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class SyncStateMessage : TinyMessageBase
{
	[CompilerGenerated]
	private QuickerSyncState a5pteuY8AeB;

	internal static SyncStateMessage cYDxApQd2VrgxcquZRFl;

	public QuickerSyncState SyncState
	{
		[CompilerGenerated]
		get
		{
			return a5pteuY8AeB;
		}
		[CompilerGenerated]
		set
		{
			a5pteuY8AeB = value;
		}
	}

	public SyncStateMessage(object sender, QuickerSyncState syncState)
		: base(sender)
	{
		SyncState = syncState;
	}

	internal static bool gK6tP8QdAZH10sH8713R()
	{
		return cYDxApQd2VrgxcquZRFl == null;
	}
}
