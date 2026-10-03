using System;

namespace Quicker.Common.Vm.ExeActions;

public class ExeActionDto
{
	public Guid Id { get; set; }

	public int ExeFileId { get; set; }

	public Guid? CategoryId { get; set; }

	public int ListOrder { get; set; }

	public int UseCount { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string Title { get; set; }

	public string Icon { get; set; }

	public ActionItem ActionItem { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public string CreateUserId { get; set; }

	public bool IsDeleted { get; set; }

	public string AdminNote { get; set; }
}
