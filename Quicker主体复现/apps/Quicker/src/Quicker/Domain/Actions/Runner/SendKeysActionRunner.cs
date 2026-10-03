using System.Collections.Generic;
using System.Threading;
using Quicker.Common;
using Quicker.View.KeyInput;
using WindowsInput;

namespace Quicker.Domain.Actions.Runner;

public class SendKeysActionRunner : ActionRunnerBase
{
	internal static SendKeysActionRunner dyvW4qQoHYXxW0Hqqtc5;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		if (string.IsNullOrEmpty(action.Data))
		{
			return;
		}
		IList<KeyInputItem> list = KeyInputItem.ParseLines(action.Data);
		int num = 0;
		KeyInputItem keyInputItem = null;
		foreach (KeyInputItem item in list)
		{
			if (num > 0 && keyInputItem != null && keyInputItem.ItemType != KeyInputItemType.Sleep)
			{
				Thread.Sleep(30);
			}
			num++;
			item.Execute(InputSimulator.Instance);
			keyInputItem = item;
		}
	}

	internal static bool jcemjLQozNvsgaGExBw0()
	{
		return dyvW4qQoHYXxW0Hqqtc5 == null;
	}
}
