using System.Collections.Generic;

namespace Quicker.Common.Vm.ExeActions;

public class ExeToolboxData
{
	public ExeDto Exe { get; set; }

	public IList<ExeActionCategoryDto> ActionCategories { get; set; }

	public IList<ExeActionDto> Actions { get; set; }

	public IList<SharedActionDto> SharedActions { get; set; }
}
