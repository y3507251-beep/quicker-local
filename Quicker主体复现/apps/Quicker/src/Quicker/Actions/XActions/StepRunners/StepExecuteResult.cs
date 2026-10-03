using System;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions;

namespace Quicker.Actions.XActions.StepRunners;

public class StepExecuteResult
{
	[CompilerGenerated]
	private bool DjcghUktXUB;

	[CompilerGenerated]
	private string TIighl3dYbq;

	[CompilerGenerated]
	private Exception Qwpghi3TNuy;

	[CompilerGenerated]
	private ActionStopFlag CjJgh3r2Yxa;

	[CompilerGenerated]
	private static readonly StepExecuteResult FkAghfL6DVI;

	private static StepExecuteResult f82BgoQwScaZGLX3uNye;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return DjcghUktXUB;
		}
		[CompilerGenerated]
		set
		{
			DjcghUktXUB = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return TIighl3dYbq;
		}
		[CompilerGenerated]
		set
		{
			TIighl3dYbq = value;
		}
	}

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			return Qwpghi3TNuy;
		}
		[CompilerGenerated]
		set
		{
			Qwpghi3TNuy = value;
		}
	}

	public ActionStopFlag StopFlag
	{
		[CompilerGenerated]
		get
		{
			return CjJgh3r2Yxa;
		}
		[CompilerGenerated]
		set
		{
			CjJgh3r2Yxa = value;
		}
	}

	public static StepExecuteResult Success
	{
		[CompilerGenerated]
		get
		{
			return FkAghfL6DVI;
		}
	}

	public static StepExecuteResult Failed(string message, Exception exception = null)
	{
		return new StepExecuteResult
		{
			IsSuccess = false,
			Message = message,
			Exception = exception,
			StopFlag = ActionStopFlag.OperationFailed
		};
	}

	public static StepExecuteResult UserCanceled(string message = "用户取消")
	{
		return new StepExecuteResult
		{
			IsSuccess = false,
			Message = message,
			StopFlag = ActionStopFlag.UserCancel
		};
	}

	static StepExecuteResult()
	{
		FkAghfL6DVI = new StepExecuteResult
		{
			IsSuccess = true,
			StopFlag = ActionStopFlag.NoStop
		};
	}

	internal static bool aeuNRyQwwrUSNTnBEQlc()
	{
		return f82BgoQwScaZGLX3uNye == null;
	}

	internal static void SQceawQwmsCiPydxXuFE()
	{
	}
}
