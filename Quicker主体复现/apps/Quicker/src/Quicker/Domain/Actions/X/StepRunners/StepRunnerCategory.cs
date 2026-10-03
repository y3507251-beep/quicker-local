using System.ComponentModel.DataAnnotations;

namespace Quicker.Domain.Actions.X.StepRunners;

public enum StepRunnerCategory
{
	[Display(Name = "基础")]
	Basic = 0,
	[Display(Name = "文本处理")]
	Text = 1,
	[Display(Name = "图片处理")]
	Image = 2,
	[Display(Name = "剪贴板操作")]
	Clipboard = 3,
	[Display(Name = "程序流程")]
	Flow = 4,
	[Display(Name = "Windows系统")]
	System = 5,
	[Display(Name = "系统操作")]
	Files = 6,
	[Display(Name = "计算与比较")]
	Compute = 7,
	[Display(Name = "网络服务")]
	Network = 8,
	[Display(Name = "界面组件")]
	Ui = 9,
	[Display(Name = "第三方软件交互")]
	SoftInteraction = 10,
	[Display(Name = "键鼠输入")]
	Input = 11,
	Favor = 99
}
