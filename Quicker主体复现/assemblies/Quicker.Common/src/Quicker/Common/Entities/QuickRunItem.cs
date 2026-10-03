using Quicker.Common.QuickActions;

namespace Quicker.Common.Entities;

public class QuickRunItem : IQuickActionItem
{
	public string CmdText { get; set; }

	public string Description { get; set; }

	public bool IsDisabled { get; set; }

	public QuickActionType ActionType { get; set; }

	public string Data { get; set; }

	public string ParamData { get; set; }

	public string Message { get; set; }
}
