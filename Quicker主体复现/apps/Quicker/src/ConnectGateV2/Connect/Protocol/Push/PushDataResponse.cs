using System.Runtime.CompilerServices;

namespace ConnectGateV2.Connect.Protocol.Push;

public class PushDataResponse : MessageBase
{
	[CompilerGenerated]
	private int FjQ7VMohY;

	[CompilerGenerated]
	private bool LbdRTBBxY;

	[CompilerGenerated]
	private string ydbqhB5us;

	internal static PushDataResponse JhJeRGc5M1YMxbU8XoS;

	public int ReplyTo
	{
		[CompilerGenerated]
		get
		{
			return FjQ7VMohY;
		}
		[CompilerGenerated]
		set
		{
			FjQ7VMohY = value;
		}
	}

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return LbdRTBBxY;
		}
		[CompilerGenerated]
		set
		{
			LbdRTBBxY = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return ydbqhB5us;
		}
		[CompilerGenerated]
		set
		{
			ydbqhB5us = value;
		}
	}

	public PushDataResponse()
	{
		base.MessageType = 4;
	}

	internal static bool jC9tyqcYu8rTG16psDo()
	{
		return JhJeRGc5M1YMxbU8XoS == null;
	}
}
