using System;

namespace Quicker.Common.Vm.ExeActions;

public class CreateExeActionVm
{
	public Guid? Id { get; set; }

	public int ExeFileId { get; set; }

	public Guid? CategoryId { get; set; }

	public int ListOrder { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string Title { get; set; }

	public string Icon { get; set; }

	public ActionItem ActionItem { get; set; }

	public string AdminNote { get; set; }
}
