using System;
using System.Collections.Generic;

namespace Quicker.Common.Vm;

public class CheckActionUpdatesVm
{
	public IList<Guid> SharedActions { get; set; } = new List<Guid>();
}
