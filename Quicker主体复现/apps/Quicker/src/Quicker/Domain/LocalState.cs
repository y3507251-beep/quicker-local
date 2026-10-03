using System;
using System.Runtime.CompilerServices;

namespace Quicker.Domain;

public class LocalState
{
	[CompilerGenerated]
	private DateTime? DPOt8jrVTNZ;

	[CompilerGenerated]
	private string ltat8nYyqS1;

	private static LocalState WxkBUNQEiZU5Trh5rgiZ;

	public DateTime? LastTextCommandSyncTime
	{
		[CompilerGenerated]
		get
		{
			return DPOt8jrVTNZ;
		}
		[CompilerGenerated]
		set
		{
			DPOt8jrVTNZ = value;
		}
	}

	public string LastReceivedMessageId
	{
		[CompilerGenerated]
		get
		{
			return ltat8nYyqS1;
		}
		[CompilerGenerated]
		set
		{
			ltat8nYyqS1 = value;
		}
	}

	internal static bool wLBvseQElS55GnyokLw6()
	{
		return WxkBUNQEiZU5Trh5rgiZ == null;
	}
}
