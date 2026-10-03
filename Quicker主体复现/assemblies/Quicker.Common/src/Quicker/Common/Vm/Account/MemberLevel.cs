using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Vm.Account;

public enum MemberLevel
{
	[Display(Name = "免费版")]
	Free,
	[Display(Name = "免费版老用户")]
	OldFree,
	[Display(Name = "基础版")]
	Basic,
	[Display(Name = "专业版")]
	Pro
}
