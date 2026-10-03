using System;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.Debugging;

public class NopActionLogger : IActionLogger
{
	internal static NopActionLogger onAw5YQftgCKfZrK6J0m;

	public void BeginFile()
	{
	}

	public void EndFile()
	{
	}

	public void BeginStepGroup(string note, int childCount)
	{
	}

	public void EndStepGroup()
	{
	}

	public void BeginStep(ActionStep step, string stepId)
	{
	}

	public void EndStep()
	{
	}

	public void LogInput(StepInParamDef inputParam, object paramValue, string paramExpression, ActionStep step)
	{
	}

	public void LogOutput(StepOutParamDef outputParam, string varName, object paramValue)
	{
	}

	public void LogInfo(string message)
	{
	}

	public void LogFileName()
	{
	}

	public void LogWarning(string message)
	{
	}

	public void LogError(string message)
	{
	}

	public void LogError(string message, Exception exception)
	{
	}

	public void Flush()
	{
	}

	public void OpenLogFile()
	{
	}

	public void BeginRepeat(string note)
	{
	}

	public void EndRepeat()
	{
	}

	public void AddRawContent(string contentHtml)
	{
	}

	public void LogLoadState(string varKey, string value)
	{
	}

	internal static bool HHLCHYQfSUjRKuwGnA2s()
	{
		return onAw5YQftgCKfZrK6J0m == null;
	}
}
