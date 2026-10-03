using System.Collections.Generic;
using Newtonsoft.Json;
using Quicker.Common;

namespace Quicker.Domain.Actions.Runner;

public class CompositeActionRunner : ActionRunnerBase
{
	internal static CompositeActionRunner jOeUe7QoZOJ0qHsoR2x7;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		if (string.IsNullOrEmpty(action.Data))
		{
			return;
		}
		foreach (ActionItem item in JsonConvert.DeserializeObject<IList<ActionItem>>(action.Data))
		{
			ActionTypeManager.RunAction(item, -1, server, actionExecuteContext);
			if (actionExecuteContext.IsShouldStopAction())
			{
				break;
			}
		}
	}

	internal static bool NjghyHQo5acm9MmnR8bj()
	{
		return jOeUe7QoZOJ0qHsoR2x7 == null;
	}
}
