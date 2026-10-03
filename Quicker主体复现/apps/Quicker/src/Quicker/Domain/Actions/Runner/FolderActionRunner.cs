using Quicker.Common;
using Quicker.Properties;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.Runner;

public class FolderActionRunner : ActionRunnerBase
{
	internal static FolderActionRunner AM8UrbQoPnOJ62bsUG2T;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		AppHelper.ShowWarning(CommonStrings.FolderActionRunner_ExecuteAction_NotSupportedActionType + $"{action.ActionType}", true);
	}

	internal static bool H2SqdOQoMbPC3bOTvtOd()
	{
		return AM8UrbQoPnOJ62bsUG2T == null;
	}
}
