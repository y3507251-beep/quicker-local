namespace Quicker.Actions.XActions.StepRunners;

public interface IMultiOperationStep
{
	StepOperation GetStepOperation(string operation);
}
