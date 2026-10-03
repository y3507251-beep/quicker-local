using System.Threading;
using Quicker.Common;

namespace Quicker.Domain.Actions.Runner;

public class WaitTimeActionRunner : ActionRunnerBase
{
	private static WaitTimeActionRunner AwGwM9Qf9YicR249pN5K;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		if (!string.IsNullOrEmpty(action.Data))
		{
			int result = 0;
			if (!int.TryParse(action.Data, out result))
			{
				throw new ActionException("不合法的等待时间参数。", action);
			}
			Thread.Sleep(result);
		}
	}

	internal static bool L9hq75QfLKXR1tRrTMp9()
	{
		return AwGwM9Qf9YicR249pN5K == null;
	}
}
