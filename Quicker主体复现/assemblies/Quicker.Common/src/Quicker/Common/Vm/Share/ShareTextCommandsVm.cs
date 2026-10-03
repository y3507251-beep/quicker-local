using System;

namespace Quicker.Common.Vm.Share;

public class ShareTextCommandsVm
{
	public Guid? Id { get; set; }

	public string UserId { get; set; }

	public string ForExe { get; set; }

	public string Title { get; set; }

	public string Keywords { get; set; }

	public string Description { get; set; }

	public int ItemCount { get; set; }

	public string Data { get; set; }

	public bool IsDisabled { get; set; }
}
