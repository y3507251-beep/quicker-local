using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Entities;

public enum PopupLocationType
{
	[Display(Name = "默认")]
	NA,
	[Display(Name = "跟随鼠标")]
	WithMouse,
	[Display(Name = "屏幕中心")]
	CenterScreen,
	[Display(Name = "上次弹出位置")]
	Previous
}
