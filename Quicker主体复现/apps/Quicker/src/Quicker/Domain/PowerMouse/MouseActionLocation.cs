using System;
using System.ComponentModel.DataAnnotations;

namespace Quicker.Domain.PowerMouse;

[Flags]
public enum MouseActionLocation
{
	[Display(Name = "不限定")]
	NA = 0,
	[Display(Name = "屏幕左上角")]
	CornerTopLeft = 1,
	[Display(Name = "屏幕右上角")]
	CornerTopRight = 2,
	[Display(Name = "屏幕左下角")]
	CornerBottomLeft = 4,
	[Display(Name = "屏幕右下角")]
	CornerBottomRight = 8,
	[Display(Name = "屏幕顶边框左1/2")]
	TopBorderLeft = 0x10,
	[Display(Name = "屏幕顶边框右1/2")]
	TopBorderRight = 0x20,
	[Display(Name = "屏幕顶边框")]
	TopBorder = 0x30,
	[Display(Name = "屏幕底边框左1/2")]
	BottomBorderLeft = 0x40,
	[Display(Name = "屏幕底边框右1/2")]
	BottomBorderRight = 0x80,
	[Display(Name = "屏幕底边框")]
	BottomBorder = 0xC0,
	[Display(Name = "任务栏")]
	TaskBar = 0x100,
	[Display(Name = "工作区左上1/4")]
	UpLeft = 0x1000,
	[Display(Name = "工作区右上1/4")]
	UpRight = 0x2000,
	[Display(Name = "工作区左下1/4")]
	DownLeft = 0x4000,
	[Display(Name = "工作区右下1/4")]
	DownRight = 0x8000,
	[Display(Name = "工作区左1/2")]
	Left = 0x5000,
	[Display(Name = "工作区右1/2")]
	Right = 0xA000,
	[Display(Name = "工作区上1/2")]
	Up = 0x3000,
	[Display(Name = "工作区下1/2")]
	Down = 0xC000,
	[Display(Name = "工作区")]
	WorkingArea = 0xF000,
	[Display(Name = "屏幕左边框上1/2")]
	LeftBorderUp = 0x10000,
	[Display(Name = "屏幕左边框下1/2")]
	LeftBorderDown = 0x20000,
	[Display(Name = "屏幕左边框")]
	LeftBorder = 0x30000,
	[Display(Name = "屏幕右边框上1/2")]
	RightBorderUp = 0x40000,
	[Display(Name = "屏幕右边框下1/2")]
	RightBorderDown = 0x80000,
	[Display(Name = "屏幕右边框")]
	RightBorder = 0xC0000,
	[Display(Name = "整个屏幕")]
	FullScreen = 0xF1F0,
	[Display(Name = "窗口标题栏区域")]
	TitleBar = 0x1000000
}
