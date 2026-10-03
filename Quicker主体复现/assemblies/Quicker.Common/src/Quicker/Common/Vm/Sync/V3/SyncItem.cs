using System;

namespace Quicker.Common.Vm.Sync.V3;

public class SyncItem
{
	public SyncItemType ItemType { get; set; }

	public string ItemId { get; set; }

	public string Data { get; set; }

	public int BaseRevision { get; set; }

	public DateTime LastUpdateTimeUtc { get; set; }

	public bool IsDeleted { get; set; }

	public DateTime? DeleteTimeUtc { get; set; }
}
