namespace Quicker.Common.QuickActions;

public class PowerKeyActionItem : IQuickActionItem
{
	public int? SecondaryKey { get; set; }

	public int? AdornKey { get; set; }

	public bool Shift { get; set; }

	public bool Control { get; set; }

	public bool Alt { get; set; }

	public string BindingProcessName { get; set; }

	public string Title { get; set; }

	public QuickActionType ActionType { get; set; }

	public string Data { get; set; }

	public string ParamData { get; set; }

	public string Message { get; set; }

	public QuickActionType LongPressActionType { get; set; }

	public string LongPressData { get; set; }

	public string LongPressNotification { get; set; }

	public bool IsDisabled { get; set; }

	public string Group { get; set; }

	public TempQuickActionItem CreateLongPressTempItem()
	{
		return new TempQuickActionItem
		{
			ActionType = LongPressActionType,
			Data = LongPressData,
			Message = LongPressNotification
		};
	}
}
