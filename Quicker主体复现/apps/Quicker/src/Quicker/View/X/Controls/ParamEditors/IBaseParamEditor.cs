using System;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.View.X.Controls.ParamEditors;

public interface IBaseParamEditor
{
	StepInParamDef ParamDef { get; }

	event EventHandler ValueChanged;

	void NotifyValueChange();

	ActionStepParam GetParamValue();
}
