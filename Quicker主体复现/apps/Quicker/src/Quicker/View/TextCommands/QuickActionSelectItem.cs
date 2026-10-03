using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Common.QuickActions;
using Quicker.Domain.PowerMouse;
using Quicker.Public.Extensions;

namespace Quicker.View.TextCommands;

public class QuickActionSelectItem
{
	[CompilerGenerated]
	private QuickActionType dphLSMstrwN;

	[CompilerGenerated]
	private string JeGLSAZ8TeA;

	[CompilerGenerated]
	private string OPoLSOaEspM;

	[CompilerGenerated]
	private bool hXULSFk5mNC;

	[CompilerGenerated]
	private bool UkTLSUU0r2b;

	[CompilerGenerated]
	private MouseOperationType q19LSluHN20 = MouseOperationType.QuickAction;

	[CompilerGenerated]
	private static IList<QuickActionSelectItem> VRtLSiJA6EY;

	private static QuickActionSelectItem UL8YyGFeJQDf67j6W0bA;

	public QuickActionType ActionType
	{
		[CompilerGenerated]
		get
		{
			return dphLSMstrwN;
		}
		[CompilerGenerated]
		set
		{
			dphLSMstrwN = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return JeGLSAZ8TeA;
		}
		[CompilerGenerated]
		set
		{
			JeGLSAZ8TeA = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return OPoLSOaEspM;
		}
		[CompilerGenerated]
		set
		{
			OPoLSOaEspM = value;
		}
	}

	public bool IsBasicOperation
	{
		[CompilerGenerated]
		get
		{
			return hXULSFk5mNC;
		}
		[CompilerGenerated]
		set
		{
			hXULSFk5mNC = value;
		}
	}

	public bool RequireDrag
	{
		[CompilerGenerated]
		get
		{
			return UkTLSUU0r2b;
		}
		[CompilerGenerated]
		set
		{
			UkTLSUU0r2b = value;
		}
	}

	public MouseOperationType MouseOperationType
	{
		[CompilerGenerated]
		get
		{
			return q19LSluHN20;
		}
		[CompilerGenerated]
		set
		{
			q19LSluHN20 = value;
		}
	}

	public static IList<QuickActionSelectItem> AllQuickActionSelectItems
	{
		[CompilerGenerated]
		get
		{
			return VRtLSiJA6EY;
		}
		[CompilerGenerated]
		set
		{
			VRtLSiJA6EY = value;
		}
	}

	static QuickActionSelectItem()
	{
		VRtLSiJA6EY = new List<QuickActionSelectItem>
		{
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.None,
				Name = QuickActionType.None.GetEnumDisplayName(),
				Description = "不执行任何操作"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.Keystroke,
				Name = QuickActionType.Keystroke.GetEnumDisplayName(),
				Description = "模拟键盘按键。"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.SendKeys,
				Name = QuickActionType.SendKeys.GetEnumDisplayName(),
				Description = "使用模拟按键B语法输入内容或快捷键。"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.InputText,
				Name = QuickActionType.InputText.GetEnumDisplayName(),
				Description = "模拟输入文本内容。"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.PasteText,
				Name = QuickActionType.PasteText.GetEnumDisplayName(),
				Description = "将内容写入剪贴板后进行粘贴。"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.PasteHtml,
				Name = QuickActionType.PasteHtml.GetEnumDisplayName(),
				Description = "将内容以Html格式发送。"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.InputScript,
				Name = QuickActionType.InputScript.GetEnumDisplayName(),
				Description = "多步骤按键输入序列。"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.QuickerOperation,
				Name = QuickActionType.QuickerOperation.GetEnumDisplayName(),
				Description = "常用快速操作"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.QuickerAction,
				Name = QuickActionType.QuickerAction.GetEnumDisplayName(),
				Description = "执行指定的Quicker动作"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.RunOrOpen,
				Name = QuickActionType.RunOrOpen.GetEnumDisplayName(),
				Description = "打开或运行文件、文件夹、命令、网址等"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.PlayKeyMouseData,
				Name = QuickActionType.PlayKeyMouseData.GetEnumDisplayName(),
				Description = "重放键鼠录制数据"
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.StartCircleMenu,
				Name = QuickActionType.StartCircleMenu.GetEnumDisplayName(),
				Description = "内置：触发轮盘菜单功能",
				IsBasicOperation = true,
				RequireDrag = true,
				MouseOperationType = MouseOperationType.ShowCircleMenu
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.StartMouseGesture,
				Name = QuickActionType.StartMouseGesture.GetEnumDisplayName(),
				Description = "内置：开始绘制鼠标手势",
				IsBasicOperation = true,
				RequireDrag = true,
				MouseOperationType = MouseOperationType.DrawGestures
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.QuickCapture,
				Name = QuickActionType.QuickCapture.GetEnumDisplayName(),
				Description = "内置：快速截图",
				IsBasicOperation = true,
				RequireDrag = true,
				MouseOperationType = MouseOperationType.ScreenCapture
			},
			new QuickActionSelectItem
			{
				ActionType = QuickActionType.InheritGlobal,
				Name = QuickActionType.InheritGlobal.GetEnumDisplayName(),
				Description = "继承全局设置"
			}
		};
	}

	internal static bool tOgpZjFekPA5YLDjIxDP()
	{
		return UL8YyGFeJQDf67j6W0bA == null;
	}
}
