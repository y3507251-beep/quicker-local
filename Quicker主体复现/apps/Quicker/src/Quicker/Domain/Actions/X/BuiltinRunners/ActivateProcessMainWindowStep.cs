using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class ActivateProcessMainWindowStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec nWRSLAcfnt6;

		public static Func<Process, int> GxySLOti7ev;

		public static Func<Process, int> Ck9SLFi6hmV;

		internal static _003C_003Ec bgrsKxW0bZFyShFnhBOR;

		static _003C_003Ec()
		{
			nWRSLAcfnt6 = new _003C_003Ec();
		}

		internal int ixlSLTa3jvi(Process x)
		{
			return x.Id;
		}

		internal int U0GSLM8Zgqj(Process x)
		{
			return x.Id;
		}

		internal static bool IyIpHbW0qvUIlQUpmAOr()
		{
			return bgrsKxW0bZFyShFnhBOR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep TuASLluClZq;

		public ActionExecuteContext AW1SLiKC9pj;

		public ActivateProcessMainWindowStep PaDSL3qCLxJ;

		public XAction raTSLfwDepj;

		internal static _003C_003Ec__DisplayClass42_0 IKMPDbW0lBrdGkryYAwL;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Fi2SLUykCRq()
		{
			string text = XActionHelper.GetTextParamValue(tTLgwjKfyJe, TuASLluClZq, AW1SLiKC9pj);
			string textParamValue = XActionHelper.GetTextParamValue(MlBgw4jpUJB, TuASLluClZq, AW1SLiKC9pj);
			string textParamValue2 = XActionHelper.GetTextParamValue(SlUgw5OZMvm, TuASLluClZq, AW1SLiKC9pj);
			string textParamValue3 = XActionHelper.GetTextParamValue(UuRgwnmOypt, TuASLluClZq, AW1SLiKC9pj);
			string textParamValue4 = XActionHelper.GetTextParamValue(GrggwDhQ9Le, TuASLluClZq, AW1SLiKC9pj);
			if (string.IsNullOrEmpty(text))
			{
				string item = AW1SLiKC9pj.ActionTitle + ": 要激活窗口的进程名称为空。";
				return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
			}
			if (string.Equals("quicker", text, StringComparison.OrdinalIgnoreCase))
			{
				return (isSuccess: false, message: "不支持激活Quicker进程主窗口", failReason: ActionStopFlag.OperationFailed);
			}
			Process[] array = Array.Empty<Process>();
			int? nullable_ = null;
			if (int.TryParse(text, out var result))
			{
				AW1SLiKC9pj.ActionLogger?.LogInfo($"是数字，根据pid查找进程。pid={result}");
				if (result == AppState.CurrentProcessId)
				{
					return (isSuccess: false, message: $"不支持激活Quicker进程主窗口(pid:{result})", failReason: ActionStopFlag.OperationFailed);
				}
				try
				{
					Process processById = Process.GetProcessById(result);
					array = new Process[1] { processById };
					text = processById.ProcessName;
					nullable_ = result;
				}
				catch (Exception ex)
				{
					AW1SLiKC9pj.ActionLogger?.LogWarning("根据pid未找到进程。" + ex.Message);
				}
			}
			if (!array.HasData())
			{
				array = Process.GetProcessesByName(text);
			}
			if (array.Length == 0)
			{
				AW1SLiKC9pj.ActionLogger?.LogInfo("进程" + text + "不存在。");
				if (string.IsNullOrEmpty(textParamValue4))
				{
					string item2 = "进程 " + text + " 尚未运行。请先运行后再执行本操作。";
					return (isSuccess: false, message: item2, failReason: ActionStopFlag.OperationFailed);
				}
				AW1SLiKC9pj.ActionLogger?.LogInfo("尝试启动程序：" + textParamValue4);
				Process process = ActionHelper.StartProcess(textParamValue4, null, "", "", false, false, "");
				if (process == null)
				{
					array = Process.GetProcessesByName(text);
					if (array.Length == 0)
					{
						return (isSuccess: false, message: "无法启动程序。", failReason: ActionStopFlag.OperationFailed);
					}
					process = array[0];
				}
				try
				{
					process.WaitForInputIdle(5000);
				}
				catch (Exception ex2)
				{
					AW1SLiKC9pj.ActionLogger?.LogWarning("WaitForInputIdle失败，可能进程没有图形界面。" + ex2.Message);
				}
				as0gwXeuYkx(text, 2000);
				array = new Process[1] { process };
			}
			if (!array.HasData())
			{
				return (isSuccess: false, message: "未找到进程，也未能启动进程。", failReason: ActionStopFlag.OperationFailed);
			}
			IntPtr intptr_ = IntPtr.Zero;
			if (eJYgwKIsTgK(text, nullable_, out intptr_))
			{
				AW1SLiKC9pj.ActionLogger?.LogInfo("窗口已经是前台窗口。");
				PaDSL3qCLxJ.LMHgwmD4yTI(intptr_, TuASLluClZq, AW1SLiKC9pj, raTSLfwDepj);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			if (!string.IsNullOrEmpty(textParamValue3))
			{
				SendKeys.SendWait(textParamValue3);
				as0gwXeuYkx(text, 1000);
				if (eJYgwKIsTgK(text, nullable_, out intptr_))
				{
					AW1SLiKC9pj.ActionLogger?.LogInfo("使用快捷键激活了窗口");
					PaDSL3qCLxJ.LMHgwmD4yTI(intptr_, TuASLluClZq, AW1SLiKC9pj, raTSLfwDepj);
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				AW1SLiKC9pj.ActionLogger?.LogInfo("快捷键激活窗口失败。");
			}
			if (string.IsNullOrEmpty(textParamValue) && string.IsNullOrEmpty(textParamValue2))
			{
				Process[] array2 = array;
				int num = 0;
				while (true)
				{
					if (num < array2.Length)
					{
						Process process2 = array2[num];
						if (process2.MainWindowHandle != IntPtr.Zero)
						{
							if (WindowHelper.IKlLFQNEaTx(process2.MainWindowHandle, out var size_))
							{
								NativeMethods.BringProcessMainWindowToFront(process2.MainWindowHandle);
								if (eJYgwKIsTgK(text, nullable_, out intptr_))
								{
									break;
								}
								AW1SLiKC9pj.ActionLogger?.LogInfo("使用MainWinHandle未能激活窗口");
							}
							else
							{
								AW1SLiKC9pj.ActionLogger?.LogInfo($"MainWinHandle窗口{process2.MainWindowHandle}不是正确的窗口。");
							}
						}
						num++;
						continue;
					}
					IntPtr intPtr = WindowHelper.hVrLFjUVDGe(array.Select(_003C_003Ec.Ck9SLFi6hmV ?? (_003C_003Ec.Ck9SLFi6hmV = _003C_003Ec.nWRSLAcfnt6.U0GSLM8Zgqj)).ToArray(), "", "", new Size(100, 100));
					if (intPtr != IntPtr.Zero)
					{
						AW1SLiKC9pj.ActionLogger?.LogInfo($"从桌面上找到了一个窗口:0x{(uint)(int)intPtr:X}。");
						NativeMethods.BringProcessMainWindowToFront(intPtr);
						intptr_ = intPtr;
						PaDSL3qCLxJ.LMHgwmD4yTI(intptr_, TuASLluClZq, AW1SLiKC9pj, raTSLfwDepj);
						return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
					}
					return (isSuccess: false, message: "未能激活进程 " + text + " 的主窗口，它可能已隐藏到系统托盘。", failReason: ActionStopFlag.OperationFailed);
				}
				AW1SLiKC9pj.ActionLogger?.LogInfo("使用MainWinHandle激活了窗口");
				PaDSL3qCLxJ.LMHgwmD4yTI(intptr_, TuASLluClZq, AW1SLiKC9pj, raTSLfwDepj);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			IntPtr intPtr2 = WindowHelper.hVrLFjUVDGe(array.Select(_003C_003Ec.GxySLOti7ev ?? (_003C_003Ec.GxySLOti7ev = _003C_003Ec.nWRSLAcfnt6.ixlSLTa3jvi)).ToArray(), textParamValue, textParamValue2);
			if (intPtr2 != IntPtr.Zero)
			{
				AW1SLiKC9pj.ActionLogger.LogInfo("使用窗口类名/标题找到了窗口");
				NativeMethods.BringProcessMainWindowToFront(intPtr2);
				intptr_ = intPtr2;
				PaDSL3qCLxJ.LMHgwmD4yTI(intptr_, TuASLluClZq, AW1SLiKC9pj, raTSLfwDepj);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return (isSuccess: false, message: "根据类名、标题未找到窗口", failReason: ActionStopFlag.OperationFailed);
		}

		internal static bool FBJ6vRW0ZKpWXxXC62YG()
		{
			return IKMPDbW0lBrdGkryYAwL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public IntPtr E3ESvtQIR7D;

		internal static _003C_003Ec__DisplayClass44_0 VHEJ5FW0YgH6vhKuPgWd;

		internal object B4RSLzRRQ80()
		{
			return NativeMethods.GetWindowProcessId(E3ESvtQIR7D);
		}

		internal object PtDSvwvIaKY()
		{
			return NativeMethods.GetWindowTitle(E3ESvtQIR7D);
		}

		internal static void hQoNGRW0grZLBEuHDp2M()
		{
		}

		internal static bool H74YKMW08Z3MAb8Vlghh()
		{
			return VHEJ5FW0YgH6vhKuPgWd == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> evdgwr2P3eP;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> PiMgwp1WvEa;

	[CompilerGenerated]
	private readonly string iIIgwBxJ0y0 = "https://getquicker.net/KC/Help/Doc/activateprocessmainwindow";

	[CompilerGenerated]
	private readonly bool GqogwQqX8ZS;

	private static readonly StepInParamDef tTLgwjKfyJe;

	private static readonly StepInParamDef UuRgwnmOypt;

	private static readonly StepInParamDef MlBgw4jpUJB;

	private static readonly StepInParamDef SlUgw5OZMvm;

	private static readonly StepInParamDef GrggwDhQ9Le;

	private static readonly StepInParamDef ihbgwdZEa0t;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> do0gwoFI6rN = new List<StepInParamDef> { tTLgwjKfyJe, MlBgw4jpUJB, SlUgw5OZMvm, UuRgwnmOypt, GrggwDhQ9Le, ihbgwdZEa0t };

	private static readonly StepOutParamDef PlKgwTRV6kI;

	private static readonly StepOutParamDef X1rgwMdPdA2;

	private static readonly StepOutParamDef vZEgwAPovxu;

	private static readonly StepOutParamDef zm9gwOuh9Cl;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> IIugwFZCSjG = new StepOutParamDef[4] { zm9gwOuh9Cl, PlKgwTRV6kI, X1rgwMdPdA2, vZEgwAPovxu };

	internal static ActivateProcessMainWindowStep P6ZTqyQ85IP7VF86RDjP;

	public string Key => "sys:activateProcessMainWindow";

	public string Name => "激活进程主窗口";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return evdgwr2P3eP;
		}
	}

	public string Icon => "windows.png";

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return PiMgwp1WvEa;
		}
	}

	public string Description => "找到指定进程的主窗口并使其显示在前台。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return iIIgwBxJ0y0;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return GqogwQqX8ZS;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return do0gwoFI6rN;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return IIugwFZCSjG;
		}
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.TuASLluClZq = step;
		_003C_003Ec__DisplayClass42_.AW1SLiKC9pj = context;
		_003C_003Ec__DisplayClass42_.PaDSL3qCLxJ = this;
		_003C_003Ec__DisplayClass42_.raTSLfwDepj = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.AW1SLiKC9pj, _003C_003Ec__DisplayClass42_.TuASLluClZq, _003C_003Ec__DisplayClass42_.raTSLfwDepj, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.Fi2SLUykCRq, (Action)null, (Action)null, ihbgwdZEa0t, zm9gwOuh9Cl);
	}

	private static void as0gwXeuYkx(string string_1, int int_0)
	{
		int num = 50;
		for (int i = 0; i <= int_0; i += num)
		{
			if (string.Equals(string_1, NativeMethods.GetForegroundProcessName(), StringComparison.OrdinalIgnoreCase))
			{
				break;
			}
			Thread.Sleep(num);
		}
	}

	private void LMHgwmD4yTI(IntPtr intptr_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
		_003C_003Ec__DisplayClass44_.E3ESvtQIR7D = intptr_0;
		XActionHelper.OutputResult(X1rgwMdPdA2, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass44_.E3ESvtQIR7D, xaction_0);
		XActionHelper.OutputResultIfNeeded(PlKgwTRV6kI, _003C_003Ec__DisplayClass44_.B4RSLzRRQ80, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(vZEgwAPovxu, _003C_003Ec__DisplayClass44_.PtDSvwvIaKY, actionStep_0, actionExecuteContext_0, xaction_0);
	}

	private static bool eJYgwKIsTgK(string string_1, int? nullable_0, out IntPtr intptr_0)
	{
		IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
		intptr_0 = IntPtr.Zero;
		if (!NativeMethods.IsWindowVisible(foregroundWindow))
		{
			return false;
		}
		if (nullable_0.HasValue)
		{
			int windowProcessId = NativeMethods.GetWindowProcessId(foregroundWindow);
			if (nullable_0.Value == windowProcessId)
			{
				intptr_0 = foregroundWindow;
				return true;
			}
			return false;
		}
		if (string.Equals(string_1, NativeMethods.GetWindowProcessName(foregroundWindow)))
		{
			intptr_0 = foregroundWindow;
			return true;
		}
		return false;
	}

	private static Process bLrgwxF42ub(Process[] process_0)
	{
		int num = 0;
		Process process;
		while (true)
		{
			if (num < process_0.Length)
			{
				process = process_0[num];
				if (process.MainWindowHandle != IntPtr.Zero)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return process;
	}

	public string GetSummary(ActionStep step)
	{
		return "激活 " + XActionHelper.GetParamDisplayString(tTLgwjKfyJe, step) + " 进程的主窗口";
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	static ActivateProcessMainWindowStep()
	{
		tTLgwjKfyJe = new StepInParamDef
		{
			Key = "process",
			Name = "进程名称/pid",
			DefaultValue = "",
			Description = "请输入要验证的进程名称或pid。进程名通常是exe的文件名去掉后缀，比如记事本程序的进程名称为notepad。",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectProcessName },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		UuRgwnmOypt = new StepInParamDef
		{
			Key = "hotkey",
			Name = "热键",
			DefaultValue = "",
			Description = "选填。软件最小化到托盘时，使用指定的全局热键激活窗口。",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectSendKeysData }
		};
		MlBgw4jpUJB = new StepInParamDef
		{
			Key = "className",
			Name = "窗口类名",
			Description = "选填。未能获取主窗口时（如窗口隐藏），可以尝试根据类名查找窗口，支持正则。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			TextTools = new List<TextToolType> { TextToolType.SelectWindowClass },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		SlUgw5OZMvm = new StepInParamDef
		{
			Key = "windowTitle",
			Name = "窗口标题",
			Description = "选填。未能获取主窗口时，根据窗口标题查找，支持正则。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			TextTools = new List<TextToolType> { TextToolType.SelectWindowTitle },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		GrggwDhQ9Le = new StepInParamDef
		{
			Key = "path",
			Name = "程序路径",
			DefaultValue = "",
			Description = "选填。如果进程不存在，可以根据此路径启动程序。",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectProcessPath },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		ihbgwdZEa0t = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		PlKgwTRV6kI = new StepOutParamDef
		{
			Name = "PID",
			Description = "进程ID",
			Key = "pid",
			Type = VarType.Integer
		};
		X1rgwMdPdA2 = new StepOutParamDef
		{
			Key = "mainWinHandle",
			Name = "主窗口句柄",
			Description = "进程的主窗口句柄",
			Type = VarType.Integer
		};
		vZEgwAPovxu = new StepOutParamDef
		{
			Key = "mainWinTitle",
			Name = "主窗口标题",
			Description = "",
			Type = VarType.Text
		};
		zm9gwOuh9Cl = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功激活了进程主窗口",
			Type = VarType.Boolean
		};
	}

	internal static bool akMfe4Q8YjWCJPhelMGa()
	{
		return P6ZTqyQ85IP7VF86RDjP == null;
	}
}
