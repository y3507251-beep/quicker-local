using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Entities;

public enum ActionUserLimitation
{
	[Display(Name = "-未设置-")]
	None,
	[Display(Name = "可自己使用或修改，不可再分享")]
	NoShareToActionStore,
	[Display(Name = "只读，不可再分享")]
	ReadOnly
}
