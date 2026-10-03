using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Entities;

public enum ExplorerSoftware
{
	[Display(Name = "--默认--")]
	Na,
	[Display(Name = "Windows Explorer")]
	WindowsExplorer,
	[Display(Name = "Directory Opus")]
	DirectoryOpus,
	[Display(Name = "Total Commander")]
	TotalCommander,
	[Display(Name = "XYplorer")]
	XYplorer,
	[Display(Name = "OneCommander")]
	OneCommander
}
