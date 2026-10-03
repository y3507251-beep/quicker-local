using System;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Actions.X.SubPrograms;

public class SubProgramFailedException : Exception
{
	[CompilerGenerated]
	private ActionStopFlag T9ptdqLgM8h;

	private static SubProgramFailedException lLn17TQqJcL3JW2lR6dp;

	public ActionStopFlag StopFlag
	{
		[CompilerGenerated]
		get
		{
			return T9ptdqLgM8h;
		}
		[CompilerGenerated]
		set
		{
			T9ptdqLgM8h = value;
		}
	}

	public SubProgramFailedException(string message, ActionExecuteContext context, Exception innerException = null)
		: base(message, innerException)
	{
		StopFlag = context.StopFlag;
	}

	internal static bool eh0rQMQqkLyln3EiDcmt()
	{
		return lLn17TQqJcL3JW2lR6dp == null;
	}
}
