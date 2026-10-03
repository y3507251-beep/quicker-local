using System.Collections.Generic;

namespace Quicker.Common.Vm.Sync.V4;

public interface ISyncPc2ServerResult
{
	ICollection<SyncItemResult4> Pc2ServerResults { get; set; }

	ICollection<SyncItem4> ConflictItems { get; set; }
}
