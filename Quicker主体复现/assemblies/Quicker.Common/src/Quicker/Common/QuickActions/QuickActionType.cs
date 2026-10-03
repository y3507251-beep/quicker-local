using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.QuickActions;

public enum QuickActionType
{
	[Display(Name = "-无-")]
	None = 0,
	[Display(Name = "发送快捷键")]
	Keystroke = 1,
	[Display(Name = "键入内容(支持模拟按键B语法)")]
	SendKeys = 2,
	[Display(Name = "键入纯文本")]
	InputText = 6,
	[Display(Name = "多步骤输入")]
	InputScript = 7,
	[Display(Name = "粘贴纯文本")]
	PasteText = 3,
	[Display(Name = "粘贴Html内容")]
	PasteHtml = 4,
	[Display(Name = "打开或运行(文件/目录/命令/网址等)")]
	RunOrOpen = 5,
	[Display(Name = "常用功能(快速操作)")]
	QuickerOperation = 11,
	[Display(Name = "运行Quicker动作")]
	QuickerAction = 12,
	[Display(Name = "键鼠控制")]
	PlayKeyMouseData = 13,
	[Display(Name = "显示轮盘菜单 (滑动)")]
	StartCircleMenu = 21,
	[Display(Name = "绘制鼠标手势")]
	StartMouseGesture = 22,
	[Display(Name = "显示面板窗口")]
	ShowPanel = 23,
	[Display(Name = "快速截图")]
	QuickCapture = 24,
	[Display(Name = "移动窗口")]
	MoveWindow = 25,
	[Display(Name = "-继承全局-")]
	InheritGlobal = 100
}
