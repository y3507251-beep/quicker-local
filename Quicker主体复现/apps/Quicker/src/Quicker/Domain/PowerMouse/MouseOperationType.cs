using System.ComponentModel.DataAnnotations;

namespace Quicker.Domain.PowerMouse;

public enum MouseOperationType
{
	[Display(Name = "无")]
	None,
	[Display(Name = "弹出面板")]
	ShowPanel,
	[Display(Name = "显示轮盘菜单")]
	ShowCircleMenu,
	[Display(Name = "开始绘制手势")]
	DrawGestures,
	[Display(Name = "自定义操作")]
	QuickAction,
	[Display(Name = "快速截图")]
	ScreenCapture
}
