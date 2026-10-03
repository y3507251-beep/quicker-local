using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Vm.Sync.V3;

public enum SyncItemType
{
	NA,
	[Display(Name = "通用")]
	CommonData,
	[Display(Name = "动作页")]
	Profile
}
