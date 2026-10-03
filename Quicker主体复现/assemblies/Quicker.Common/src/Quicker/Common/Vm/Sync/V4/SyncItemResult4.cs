using System;
using Quicker.Common.Vm.Sync.V3;

namespace Quicker.Common.Vm.Sync.V4;

public class SyncItemResult4
{
	public SyncItemType ItemType { get; set; }

	public string ItemId { get; set; }

	public string DisplayName { get; set; }

	public ItemSyncState4 SyncState { get; set; }

	public int? BaseRevision { get; set; }

	public DateTime? ServerLastUpdateTime { get; set; }

	public string ErrorMessage { get; set; }

	public SyncItemResult4()
	{
	}

	public SyncItemResult4(SyncItem4 syncItem)
	{
		ItemType = syncItem.ItemType;
		ItemId = syncItem.ItemId;
		DisplayName = syncItem.DisplayName;
	}
}
