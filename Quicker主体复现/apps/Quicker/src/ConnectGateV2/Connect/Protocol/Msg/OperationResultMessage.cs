using System.Runtime.CompilerServices;

namespace ConnectGateV2.Connect.Protocol.Msg;

public class OperationResultMessage : MessageBase
{
	[CompilerGenerated]
	private int Q66csILeI;

	[CompilerGenerated]
	private int WoAV0PBQj;

	[CompilerGenerated]
	private int NevZqssSh;

	[CompilerGenerated]
	private string PPn9WhmsO;

	private static OperationResultMessage nGwUkkcRykHcdJUMhPf;

	public int OriginSerial
	{
		[CompilerGenerated]
		get
		{
			return Q66csILeI;
		}
		[CompilerGenerated]
		set
		{
			Q66csILeI = value;
		}
	}

	public int OriginMessageType
	{
		[CompilerGenerated]
		get
		{
			return WoAV0PBQj;
		}
		[CompilerGenerated]
		set
		{
			WoAV0PBQj = value;
		}
	}

	public int ErrorCode
	{
		[CompilerGenerated]
		get
		{
			return NevZqssSh;
		}
		[CompilerGenerated]
		set
		{
			NevZqssSh = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return PPn9WhmsO;
		}
		[CompilerGenerated]
		set
		{
			PPn9WhmsO = value;
		}
	}

	public bool IsSuccess => ErrorCode == 0;

	public OperationResultMessage()
	{
		base.MessageType = 1001;
	}

	internal static bool uKNcT2cgLPZ07rA5krv()
	{
		return nGwUkkcRykHcdJUMhPf == null;
	}
}
