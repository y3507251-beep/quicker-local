using System;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.Debugging;

public interface IActionLogger
{
	void BeginFile();

	void EndFile();

	void BeginStepGroup(string note, int childCount);

	void EndStepGroup();

	void BeginStep(ActionStep step, string stepId);

	void EndStep();

	void LogInput(StepInParamDef inputParam, object paramValue, string paramExpression, ActionStep step);

	void LogOutput(StepOutParamDef outputParam, string varName, object paramValue);

	void LogInfo(string message);

	void LogFileName();

	void LogWarning(string message);

	void LogError(string message);

	void LogError(string message, Exception exception);

	void Flush();

	void OpenLogFile();

	void BeginRepeat(string note);

	void EndRepeat();

	void AddRawContent(string contentHtml);

	void LogLoadState(string varKey, string value);
}
