using System.Collections.Generic;

namespace Quicker.Common.Vm.Sync.V4;

public class SyncOverwriteVm4
{
	public string MachineName { get; set; }

	public IList<SyncItem4> UpdatedItems { get; set; } = new List<SyncItem4>();
}
