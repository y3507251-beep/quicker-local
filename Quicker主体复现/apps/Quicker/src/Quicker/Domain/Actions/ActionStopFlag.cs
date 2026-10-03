namespace Quicker.Domain.Actions;

public enum ActionStopFlag
{
	NoStop,
	OperationFailed,
	UserCancel,
	ForceStop,
	StopFromCode
}
