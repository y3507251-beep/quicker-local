using Quicker.Common;
using Quicker.Domain.Actions.Runtime;

namespace Quicker.Domain.Actions.Runner;

public class OpenProfileActionRunner : ActionRunnerBase
{
	internal static OpenProfileActionRunner h4uf9GQo7mbBw7Q7Q3rT;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		string data = action.Data;
		if (data.StartsWith("exe:"))
		{
			string exeName = data.Substring("exe:".Length);
			AppState.AppServer.LoadExeProfilesAndLock(exeName, false, true);
		}
		else
		{
			server.RequestSwitchProfile(action.Data, false);
		}
		if (actionExecuteContext.ActionTrigger != ActionTrigger.App)
		{
			server.RequestShowPanel();
		}
	}

	internal static bool aiqPYCQo41qm8F7kIhyB()
	{
		return h4uf9GQo7mbBw7Q7Q3rT == null;
	}
}
