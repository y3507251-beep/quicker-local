using System;
using System.Globalization;
using Quicker.Common;
using Quicker.Domain.Actions.SubPrograms;
using Quicker.Properties;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.Runner;

public class SubProgramActionRunner : ActionRunnerBase
{
	private static SubProgramActionRunner lhO9RYQfvbCT7uNKtgUp;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		string data = action.Data;
		if (!OldSubProgramMgr.ContainsAction(data))
		{
			string text = string.Format(CultureInfo.InvariantCulture, CommonStrings.SubProgramActionRunner_ExecuteAction_Err_SubProgramUnknown, data);
			AppHelper.ShowWarning(text);
			actionExecuteContext.StopAction(ActionStopFlag.OperationFailed, text);
			return;
		}
		try
		{
			OldSubProgramMgr.Run(data, action.Data2, actionExecuteContext);
		}
		catch (Exception ex)
		{
			string text2 = "操作异常：" + ex.Message;
			AppHelper.ShowWarning(text2);
			actionExecuteContext.StopAction(ActionStopFlag.OperationFailed, text2);
		}
	}

	internal static bool dM6ymAQfdtvdiO03Gdya()
	{
		return lhO9RYQfvbCT7uNKtgUp == null;
	}
}
