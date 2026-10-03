namespace Quicker.Common.QuickActions;

public class TempQuickActionItem : IQuickActionItem
{
	public QuickActionType ActionType { get; set; }

	public string Data { get; set; }

	public string ParamData { get; set; }

	public string Message { get; set; }
}
