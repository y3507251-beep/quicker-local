namespace Quicker.Common.QuickActions;

public interface IQuickActionItem
{
	QuickActionType ActionType { get; set; }

	string Data { get; set; }

	string ParamData { get; set; }

	string Message { get; set; }
}
