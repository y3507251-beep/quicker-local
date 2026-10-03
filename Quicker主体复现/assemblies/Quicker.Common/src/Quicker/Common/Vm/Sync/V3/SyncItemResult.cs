namespace Quicker.Common.Vm.Sync.V3;

public class SyncItemResult
{
	public SyncItemType ItemType { get; set; }

	public string ItemId { get; set; }

	public bool IsSuccess { get; set; }

	public int ResultRevision { get; set; }

	public int ErrorCode { get; set; }

	public string ErrorMessage { get; set; }
}
