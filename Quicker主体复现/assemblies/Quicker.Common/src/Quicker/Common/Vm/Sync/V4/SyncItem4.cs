using System;
using Quicker.Common.Vm.Sync.V3;

namespace Quicker.Common.Vm.Sync.V4;

public class SyncItem4
{
	public SyncItemType ItemType { get; set; }

	public string ItemId { get; set; }

	public string DisplayName { get; set; }

	public string SubType { get; set; }

	public string Data { get; set; }

	public DateTime LastUpdateTimeUtc { get; set; }

	public bool IsDeleted { get; set; }

	public DateTime? DeleteTimeUtc { get; set; }

	public int? BaseRevision { get; set; }
}
