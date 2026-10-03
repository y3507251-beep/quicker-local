using System.ComponentModel.DataAnnotations;

namespace Quicker.Domain.PowerMouse;

public enum MouseActionType
{
	NA = 0,
	[Display(Name = "单击鼠标键（短按）")]
	Click = 3,
	[Display(Name = "按下鼠标键")]
	Down = 4,
	[Display(Name = "长按鼠标键（不移动）")]
	LongPress = 5,
	[Display(Name = "双击鼠标键")]
	DoubleClick = 6,
	[Display(Name = "划动鼠标（按下鼠标键并立即移动）")]
	Drag = 7,
	[Display(Name = "向前滚动（远离用户）")]
	WheelUp = 11,
	[Display(Name = "向后滚动（朝向用户）")]
	WheelDown = 12,
	[Display(Name = "向左滚动（需鼠标支持）")]
	WheelLeft = 13,
	[Display(Name = "向右滚动（需鼠标支持）")]
	WheelRight = 14,
	[Display(Name = "移动指针到屏幕角落")]
	MoveToCorner = 21,
	[Display(Name = "摩擦屏幕边界")]
	Scratch = 22
}
