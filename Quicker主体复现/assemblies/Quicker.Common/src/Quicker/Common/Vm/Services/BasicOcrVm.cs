using System.Collections.Generic;

namespace Quicker.Common.Vm.Services;

public class BasicOcrVm
{
	public string Provider { get; set; }

	public IDictionary<string, string> Params { get; set; }

	public bool AllowUseQBean { get; set; }
}
