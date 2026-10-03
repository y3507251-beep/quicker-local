using System;

namespace Quicker.Common.Vm.SubPrograms;

public class ShareSubProgramVm
{
	public Guid? Id { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string Tags { get; set; }

	public string DataJson { get; set; }

	public string InternalId { get; set; }

	public string SourceSubprogramId { get; set; }

	public string ChangeLog { get; set; }

	public bool IsPublic { get; set; }
}
