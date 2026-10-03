using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Vm.Account;

public class ChangePasswordVm
{
	[Required]
	public string OldPassword { get; set; }

	[Required]
	public string NewPassword { get; set; }
}
