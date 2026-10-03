using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Vm;

public class ShareActionsVm
{
	[Required]
	public ActionProfile Profile { get; set; }

	[Required]
	public IList<int> Buttons { get; set; }
}
