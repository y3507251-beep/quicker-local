using System;
using Quicker.Common.Vm.Sync.V3;

namespace Quicker.Common.Vm.Sync.V4;

public class UnchangedSyncItem4
{
	public SyncItemType ItemType { get; set; }

	public string ItemId { get; set; }

	public int? BaseRevision { get; set; }

	public DateTime LastUpdateTimeUtc { get; set; }
}
