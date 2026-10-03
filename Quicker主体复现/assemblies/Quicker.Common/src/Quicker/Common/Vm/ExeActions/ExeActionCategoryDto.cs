using System;

namespace Quicker.Common.Vm.ExeActions;

public class ExeActionCategoryDto
{
	public Guid Id { get; set; }

	public int ExeFileId { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public int ListOrder { get; set; } = 1000;

	public DateTime CreateTimeUtc { get; set; }

	public string UserId { get; set; }

	public bool IsDeleted { get; set; }
}
