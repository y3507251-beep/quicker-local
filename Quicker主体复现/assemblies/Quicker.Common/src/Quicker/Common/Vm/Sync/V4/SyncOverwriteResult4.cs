using System;
using System.Collections.Generic;

namespace Quicker.Common.Vm.Sync.V4;

public class SyncOverwriteResult4 : ISyncPc2ServerResult
{
	public ICollection<SyncItemResult4> Pc2ServerResults { get; set; } = new List<SyncItemResult4>();

	public ICollection<SyncItem4> ConflictItems { get; set; } = new List<SyncItem4>().AsReadOnly();

	public DateTime? LastSuccessSyncTimeUtc { get; set; }
}
