using System;
using System.Collections.Generic;

namespace Quicker.Common.Vm.Share;

public class BatchUpdateTextCommandsVm
{
	public IList<Guid> IdList { get; set; }

	public bool UpdateIgnoreCase { get; set; }

	public bool IgnoreCase { get; set; }

	public bool UpdateTriggerKey { get; set; }

	public int? TriggerKey { get; set; }
}
