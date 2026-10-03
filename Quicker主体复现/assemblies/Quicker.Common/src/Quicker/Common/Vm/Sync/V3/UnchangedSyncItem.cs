using System;

namespace Quicker.Common.Vm.Sync.V3;

public class UnchangedSyncItem
{
	public SyncItemType ItemType { get; set; }

	public string ItemId { get; set; }

	public int BaseRevision { get; set; }

	public DateTime LastUpdateTimeUtc { get; set; }
}
