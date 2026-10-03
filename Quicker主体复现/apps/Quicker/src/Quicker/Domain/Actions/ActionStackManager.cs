using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Quicker.Domain.Actions;

public class ActionStackManager
{
	[CompilerGenerated]
	private IList<ActionStackItem> M5otn25qIie = new List<ActionStackItem>();

	[CompilerGenerated]
	private ActionStackItem OHktnu0odWR;

	private static ActionStackManager IJ5bKqQuvvYwrJVIXOwE;

	private IList<ActionStackItem> Stack
	{
		[CompilerGenerated]
		get
		{
			return M5otn25qIie;
		}
		[CompilerGenerated]
		set
		{
			M5otn25qIie = value;
		}
	}

	public ActionStackItem CurrentState => Stack[Stack.Count - 1];

	public ActionStackItem ExistedLevelState
	{
		[CompilerGenerated]
		get
		{
			return OHktnu0odWR;
		}
		[CompilerGenerated]
		private set
		{
			OHktnu0odWR = value;
		}
	}

	public int Level => Stack.Count - 1;

	public ActionStackItem NewLevel()
	{
		ActionStackItem actionStackItem = new ActionStackItem();
		Stack.Add(actionStackItem);
		return actionStackItem;
	}

	public ActionStackItem ExitLevel()
	{
		ExistedLevelState = CurrentState;
		Stack.RemoveAt(Stack.Count - 1);
		return ExistedLevelState;
	}

	public string GetLineNumber()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (ActionStackItem item in Stack)
		{
			stringBuilder.Append(item.StepIndex);
			stringBuilder.Append(".");
		}
		return stringBuilder.ToString();
	}

	internal static bool jAbalOQudltmV64Thth8()
	{
		return IJ5bKqQuvvYwrJVIXOwE == null;
	}
}
