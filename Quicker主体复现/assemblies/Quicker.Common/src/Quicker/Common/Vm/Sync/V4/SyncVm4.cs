using System;
using System.Collections.Generic;

namespace Quicker.Common.Vm.Sync.V4;

public class SyncVm4
{
	public bool IsFirstSync { get; set; }

	public bool RequestFullData { get; set; }

	public DateTime? LastSuccessSyncTimeUtc { get; set; }

	public long? LastUserMessageId { get; set; }

	public string MachineName { get; set; }

	public string SoftVersion { get; set; }

	public bool IsProNow { get; set; }

	public DateTime? LocalTimeUtc { get; set; }

	public IList<UnchangedSyncItem4> UnchangedItems { get; set; } = new List<UnchangedSyncItem4>();

	public IList<SyncItem4> UpdatedItems { get; set; } = new List<SyncItem4>();

	public DateTime? LastTextCommandSyncTime { get; set; }

	public string TxBaffetId { get; set; }
}
