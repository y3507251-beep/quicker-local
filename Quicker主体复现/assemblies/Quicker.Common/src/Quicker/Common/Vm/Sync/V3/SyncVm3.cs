using System;
using System.Collections.Generic;

namespace Quicker.Common.Vm.Sync.V3;

public class SyncVm3
{
	public string MachineId { get; set; }

	public string MachineName { get; set; }

	public string SoftVersion { get; set; }

	public bool IsFirstSync { get; set; }

	public string UserInfoHash { get; set; }

	public DateTime? LocalTimeUtc { get; set; }

	public IList<UnchangedSyncItem> UnchangedItems { get; set; } = new List<UnchangedSyncItem>();

	public IList<SyncItem> UpdatedItems { get; set; } = new List<SyncItem>();

	public DateTime? LastTextCommandSyncTime { get; set; }

	public string LastUserMessageId { get; set; }
}
