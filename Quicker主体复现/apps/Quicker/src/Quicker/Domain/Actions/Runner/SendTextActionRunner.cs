using System;
using System.Threading;
using Quicker.Common;

namespace Quicker.Domain.Actions.Runner;

public class SendTextActionRunner : ActionRunnerBase
{
	internal static SendTextActionRunner fanlA8QfQ2Py96YHrGkw;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		string data = action.Data;
		bool useCopyPaste = string.Equals(action.Data3, "true", StringComparison.OrdinalIgnoreCase);
		bool sendReturn = string.Equals(action.Data2, "true", StringComparison.OrdinalIgnoreCase);
		CancellationToken? cancellationToken = actionExecuteContext?.CancellationToken;
		ActionHelper.SendTextToWindow(data, useCopyPaste, sendReturn, 100, 100, 0, null, cancellationToken);
	}

	internal static bool lcdYCBQfFWSe4I10E47m()
	{
		return fanlA8QfQ2Py96YHrGkw == null;
	}
}
