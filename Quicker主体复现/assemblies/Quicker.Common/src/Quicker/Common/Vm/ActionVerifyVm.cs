using System;

namespace Quicker.Common.Vm;

public class ActionVerifyVm
{
	public Guid SharedActionId { get; set; }

	public int Revision { get; set; }

	public bool IsSuccess { get; set; }

	public int RetryCount { get; set; }

	public string Content { get; set; }

	public string QuickerVersion { get; set; }
}
