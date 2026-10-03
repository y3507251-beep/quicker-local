using Quicker.Common;
using Quicker.Properties;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.Runner;

public class GoParentActionRunner : ActionRunnerBase
{
	private static GoParentActionRunner oEARXOQoIjfgaJdLYxgc;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		AppHelper.ShowWarning(CommonStrings.FolderActionRunner_ExecuteAction_NotSupportedActionType + $"{action.ActionType}", true);
	}

	internal static bool Xa5dqVQo6BXNEQZ5Ik2E()
	{
		return oEARXOQoIjfgaJdLYxgc == null;
	}
}
