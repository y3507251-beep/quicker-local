using System;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runner;

namespace tRpvUuYAvZDSs0CG8ap;

internal class WOuuwRY5ykJRSxIVgu6 : ActionRunnerBase
{
	internal static WOuuwRY5ykJRSxIVgu6 w97QdXQzvBWdNFXIMfUF;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		string data = action.Data;
		(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(data);
		if (actionById.Item1 == null)
		{
			throw new Exception($"链接到的动作不存在：{actionById.Item1}");
		}
		throw new InvalidOperationException("不应该执行到这里哦。直接找到目标动作执行。");
	}

	internal static bool PqjBmrQzddaIgSi07Goq()
	{
		return w97QdXQzvBWdNFXIMfUF == null;
	}
}
