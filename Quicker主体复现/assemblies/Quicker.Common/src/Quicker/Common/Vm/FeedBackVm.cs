using Quicker.Common.Entities;

namespace Quicker.Common.Vm;

public class FeedBackVm
{
	public FeedbackType FeedbackType { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public string ExceptionStackTrace { get; set; }

	public string ExeVersion { get; set; }

	public string AppVersion { get; set; }

	public string OsVersion { get; set; }

	public string Email { get; set; }

	public string QQ { get; set; }

	public bool Is64Bit { get; set; }

	public long UsingMemory { get; set; }

	public long TotalMemory { get; set; }

	public string ProcessList { get; set; }
}
