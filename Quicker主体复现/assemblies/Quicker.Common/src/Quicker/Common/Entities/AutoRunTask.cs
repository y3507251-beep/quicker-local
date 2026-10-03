namespace Quicker.Common.Entities;

public class AutoRunTask
{
	public AutoRunTaskType TaskType { get; set; }

	public string Data { get; set; }

	public string ActionIdOrName { get; set; }

	public string ActionParam { get; set; }

	public string Note { get; set; }

	public bool IsEnabled { get; set; } = true;

	public string ValidForMachines { get; set; }

	public int DelaySeconds { get; set; }

	public bool OnlyFirstStartInSameDay { get; set; }

	public bool OnlyAutoRunQuicker { get; set; }
}
