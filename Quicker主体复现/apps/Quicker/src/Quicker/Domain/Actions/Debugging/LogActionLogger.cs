using System;
using System.Reflection;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.Debugging;

public class LogActionLogger : IActionLogger
{
	private static readonly ILog Dajt5U4SNTo;

	internal static LogActionLogger hfDNlmQfTjJVgCNZI8mr;

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
		Dajt5U4SNTo.Info("开始步骤：" + step.StepRunnerName);
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
		Dajt5U4SNTo.Info("--警告消息：" + message);
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

	static LogActionLogger()
	{
		Dajt5U4SNTo = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool ukC1s9QfmThbjlgRaoBA()
	{
		return hfDNlmQfTjJVgCNZI8mr == null;
	}
}
