using System.Collections.Generic;
using NWgFv1fei1X1gnrcJmi;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.X.StepRunners;

public interface IStepRunningInfo
{
	[vfInGIfbsoYlQBMjtrM]
	IList<StepInParamDef> InputParams { get; }

	[vfInGIfbsoYlQBMjtrM]
	IList<StepOutParamDef> OutputParams { get; }

	bool ValidateParam(string paramData, out string message);

	void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId);

	string GetSummary(ActionStep step);
}
