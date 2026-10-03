using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class ActiveProcessChangedMessage : TinyMessageBase
{
	[CompilerGenerated]
	private string AJWth6xodNS;

	internal static ActiveProcessChangedMessage EiBjAxQB6iCvMteFdwmN;

	public string CurrentProcessName
	{
		[CompilerGenerated]
		get
		{
			return AJWth6xodNS;
		}
		[CompilerGenerated]
		set
		{
			AJWth6xodNS = value;
		}
	}

	public ActiveProcessChangedMessage(object sender, string procName)
		: base(sender)
	{
		CurrentProcessName = procName;
	}

	internal static bool DeVo6GQBtSKJE902GBbA()
	{
		return EiBjAxQB6iCvMteFdwmN == null;
	}
}
