using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Entities;

public enum AutoRunTaskType
{
	NA,
	[Display(Name = "启动后")]
	Start,
	[Display(Name = "定时")]
	Timer
}
