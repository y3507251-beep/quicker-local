using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class CheckProcessExistsStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LPjSLkJYB3j;

		public static Func<object> JICSLGk2GM9;

		public static Func<object> kI7SLsf79oW;

		public static Func<object> Qs4SLHq5w7t;

		public static Func<object> W9vSL1vmNcO;

		public static Func<object> gZLSLbivZN5;

		public static Func<object> TrJSL6A6VRA;

		public static Func<Process, string> QVsSLXKU5du;

		public static Func<Process, string> pagSLmKfWFS;

		private static _003C_003Ec k1bLI4W0J5WTmU7OBKib;

		static _003C_003Ec()
		{
			LPjSLkJYB3j = new _003C_003Ec();
		}

		internal object d0DSLVCsImL()
		{
			return 0;
		}

		internal object g3tSLZNbtVR()
		{
			return new List<string>();
		}

		internal object gNVSL9x4ST5()
		{
			return string.Empty;
		}

		internal object hHySLhtxGhr()
		{
			return 0;
		}

		internal object p0DSLe9l1XY()
		{
			return string.Empty;
		}

		internal object cDBSLYwmU6C()
		{
			return DateTime.MinValue;
		}

		internal string tgfSLIp77t7(Process x)
		{
			return x.Id.ToString();
		}

		internal string bsPSLWlNiZc(Process x)
		{
			return x.Id.ToString();
		}

		internal static bool HK73MLW0krNBL642Al3t()
		{
			return k1bLI4W0J5WTmU7OBKib == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep vaqSLxEyp1t;

		public ActionExecuteContext SjLSLrfZMxY;

		public XAction aOfSLpmXYee;

		internal static _003C_003Ec__DisplayClass42_0 RYpv5xW0rqKLWC6AEE4m;

		internal (bool isSuccess, string message, ActionStopFlag failReason) rHOSLK70dik()
		{
			_003C_003Ec__DisplayClass42_1 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_1();
			string textParamValue = XActionHelper.GetTextParamValue(sTlgwhRfwnF, vaqSLxEyp1t, SjLSLrfZMxY);
			if (string.IsNullOrEmpty(textParamValue))
			{
				string item = SjLSLrfZMxY.ActionTitle + ": 要检查的进程名为空。";
				return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass42_.NUqSLdrlM2I = new List<Process>();
			if (int.TryParse(textParamValue, out _003C_003Ec__DisplayClass42_.amhSLDLx2Ia))
			{
				try
				{
					Process processById = Process.GetProcessById(_003C_003Ec__DisplayClass42_.amhSLDLx2Ia);
					_003C_003Ec__DisplayClass42_.NUqSLdrlM2I.Add(processById);
				}
				catch
				{
				}
			}
			if (_003C_003Ec__DisplayClass42_.NUqSLdrlM2I.Count == 0)
			{
				Process[] processesByName = Process.GetProcessesByName(textParamValue);
				foreach (Process item2 in processesByName)
				{
					_003C_003Ec__DisplayClass42_.NUqSLdrlM2I.Add(item2);
				}
			}
			if (_003C_003Ec__DisplayClass42_.NUqSLdrlM2I.Count == 0)
			{
				XActionHelper.OutputResultIfNeeded(ywOgwkgbOT5, _003C_003Ec.JICSLGk2GM9 ?? (_003C_003Ec.JICSLGk2GM9 = _003C_003Ec.LPjSLkJYB3j.d0DSLVCsImL), vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(hDxgwGa3k7v, _003C_003Ec.kI7SLsf79oW ?? (_003C_003Ec.kI7SLsf79oW = _003C_003Ec.LPjSLkJYB3j.g3tSLZNbtVR), vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(cYpgwsRBmWB, _003C_003Ec.Qs4SLHq5w7t ?? (_003C_003Ec.Qs4SLHq5w7t = _003C_003Ec.LPjSLkJYB3j.gNVSL9x4ST5), vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(amDgwHlgXcI, _003C_003Ec.W9vSL1vmNcO ?? (_003C_003Ec.W9vSL1vmNcO = _003C_003Ec.LPjSLkJYB3j.hHySLhtxGhr), vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(poOgw1gL1T7, _003C_003Ec.gZLSLbivZN5 ?? (_003C_003Ec.gZLSLbivZN5 = _003C_003Ec.LPjSLkJYB3j.p0DSLe9l1XY), vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(WrNgwbwbTTO, _003C_003Ec.TrJSL6A6VRA ?? (_003C_003Ec.TrJSL6A6VRA = _003C_003Ec.LPjSLkJYB3j.cDBSLYwmU6C), vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
			}
			else
			{
				_003C_003Ec__DisplayClass42_.T8pSLoPtcqk = _003C_003Ec__DisplayClass42_.NUqSLdrlM2I.Last();
				XActionHelper.OutputResultIfNeeded(ywOgwkgbOT5, _003C_003Ec__DisplayClass42_.RusSLB6bFUq, vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(hDxgwGa3k7v, _003C_003Ec__DisplayClass42_.GucSLQnxGIN, vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(cYpgwsRBmWB, _003C_003Ec__DisplayClass42_.z7cSLjLE0Yt, vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(amDgwHlgXcI, _003C_003Ec__DisplayClass42_.fBISLnNdwwG, vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(poOgw1gL1T7, _003C_003Ec__DisplayClass42_.AH3SL4yhbfC, vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
				XActionHelper.OutputResultIfNeeded(WrNgwbwbTTO, _003C_003Ec__DisplayClass42_.q9GSL5LZApF, vaqSLxEyp1t, SjLSLrfZMxY, aOfSLpmXYee);
			}
			XActionHelper.OutputResult(YWcgwWkmwv3, vaqSLxEyp1t, SjLSLrfZMxY, _003C_003Ec__DisplayClass42_.NUqSLdrlM2I.Count > 0, aOfSLpmXYee);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool Tcmtw2W0N1C7uknYp05N()
		{
			return RYpv5xW0rqKLWC6AEE4m == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_1
	{
		public int amhSLDLx2Ia;

		public IList<Process> NUqSLdrlM2I;

		public Process T8pSLoPtcqk;

		internal static _003C_003Ec__DisplayClass42_1 TQs7LhW0Lu425uVtg2S3;

		internal object RusSLB6bFUq()
		{
			return T8pSLoPtcqk.Id;
		}

		internal object GucSLQnxGIN()
		{
			if (amhSLDLx2Ia > 0)
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName(T8pSLoPtcqk.ProcessName);
					foreach (Process process in processesByName)
					{
						if (process.Id != amhSLDLx2Ia)
						{
							NUqSLdrlM2I.Add(process);
						}
					}
				}
				catch
				{
				}
				return NUqSLdrlM2I.Select(_003C_003Ec.QVsSLXKU5du ?? (_003C_003Ec.QVsSLXKU5du = _003C_003Ec.LPjSLkJYB3j.tgfSLIp77t7)).ToList();
			}
			return NUqSLdrlM2I.Select(_003C_003Ec.pagSLmKfWFS ?? (_003C_003Ec.pagSLmKfWFS = _003C_003Ec.LPjSLkJYB3j.bsPSLWlNiZc)).ToList();
		}

		internal object z7cSLjLE0Yt()
		{
			try
			{
				return T8pSLoPtcqk.MainModule.FileName;
			}
			catch
			{
				return "";
			}
		}

		internal object fBISLnNdwwG()
		{
			return T8pSLoPtcqk.MainWindowHandle;
		}

		internal object AH3SL4yhbfC()
		{
			return T8pSLoPtcqk.MainWindowTitle ?? "";
		}

		internal object q9GSL5LZApF()
		{
			return T8pSLoPtcqk.StartTime;
		}

		internal static bool wAiY2hW0ukDVdZCejHPx()
		{
			return TQs7LhW0Lu425uVtg2S3 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> geGgwcLM56F = new string[4] { "进程", "程序", "软件", "pid" };

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> yAPgwV8rffM;

	[CompilerGenerated]
	private readonly string JHrgwZQhIwM = "https://getquicker.net/KC/Help/Doc/checkprocessexists";

	[CompilerGenerated]
	private readonly bool suagw9jiVS1;

	private static readonly StepInParamDef sTlgwhRfwnF;

	private static readonly StepInParamDef WItgweQWoNq;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> uiYgwYZRiq8 = new List<StepInParamDef> { sTlgwhRfwnF, WItgweQWoNq };

	private static readonly StepOutParamDef WNLgwIjI1sI;

	private static readonly StepOutParamDef YWcgwWkmwv3;

	private static readonly StepOutParamDef ywOgwkgbOT5;

	private static readonly StepOutParamDef hDxgwGa3k7v;

	private static readonly StepOutParamDef cYpgwsRBmWB;

	private static readonly StepOutParamDef amDgwHlgXcI;

	private static readonly StepOutParamDef poOgw1gL1T7;

	private static readonly StepOutParamDef WrNgwbwbTTO;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Ljjgw6GUiHq = new StepOutParamDef[8] { WNLgwIjI1sI, YWcgwWkmwv3, ywOgwkgbOT5, hDxgwGa3k7v, cYpgwsRBmWB, amDgwHlgXcI, poOgw1gL1T7, WrNgwbwbTTO };

	internal static CheckProcessExistsStep GkJ48cQ8ocxaeFcShvVb;

	public string Key => "sys:checkProcessExists";

	public string Name => "检查程序已启动/获取进程信息";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return geGgwcLM56F;
		}
	}

	public string Icon => "windows.png";

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return yAPgwV8rffM;
		}
	}

	public string Description => "检查指定的应用程序是否已经启动。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return JHrgwZQhIwM;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return suagw9jiVS1;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return uiYgwYZRiq8;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Ljjgw6GUiHq;
		}
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.vaqSLxEyp1t = step;
		_003C_003Ec__DisplayClass42_.SjLSLrfZMxY = context;
		_003C_003Ec__DisplayClass42_.aOfSLpmXYee = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.SjLSLrfZMxY, _003C_003Ec__DisplayClass42_.vaqSLxEyp1t, _003C_003Ec__DisplayClass42_.aOfSLpmXYee, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.rHOSLK70dik, (Action)null, (Action)null, WItgweQWoNq, WNLgwIjI1sI);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(sTlgwhRfwnF, step) ?? "";
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	static CheckProcessExistsStep()
	{
		sTlgwhRfwnF = new StepInParamDef
		{
			Key = "process",
			Name = "进程名称/pid",
			DefaultValue = "",
			Description = "请输入要验证的进程名称或id。通常是exe的文件名去掉后缀，比如记事本程序的进程名称为notepad。",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectProcessName },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		WItgweQWoNq = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		WNLgwIjI1sI = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "操作是否成功",
			Description = "可能会因为无法访问高权限进程等原因而失败。进程未启动不会导致操作失败。",
			Type = VarType.Boolean
		};
		YWcgwWkmwv3 = new StepOutParamDef
		{
			Key = "isExists",
			Name = "是否运行",
			Description = "指定的进程是否运行。如果已运行，返回True，否则返回False",
			Type = VarType.Boolean
		};
		ywOgwkgbOT5 = new StepOutParamDef
		{
			Key = "pid",
			Name = "进程ID",
			Description = "找到的第一个匹配进程的ID",
			Type = VarType.Integer
		};
		hDxgwGa3k7v = new StepOutParamDef
		{
			Key = "pidList",
			Name = "所有进程ID列表",
			Description = "具有相同进程名的所有进程的ID列表",
			Type = VarType.List
		};
		cYpgwsRBmWB = new StepOutParamDef
		{
			Key = "path",
			Name = "程序路径",
			Description = "进程的应用程序路径",
			Type = VarType.Text
		};
		amDgwHlgXcI = new StepOutParamDef
		{
			Key = "mainWinHandle",
			Name = "主窗口句柄",
			Type = VarType.Integer
		};
		poOgw1gL1T7 = new StepOutParamDef
		{
			Key = "mainwinTitle",
			Name = "主窗口标题",
			Type = VarType.Text
		};
		WrNgwbwbTTO = new StepOutParamDef
		{
			Key = "startTime",
			Name = "启动时间",
			Type = VarType.DateTime
		};
	}

	internal static bool U5O5h0Q8fmYgvTpLX1eW()
	{
		return GkJ48cQ8ocxaeFcShvVb == null;
	}
}
