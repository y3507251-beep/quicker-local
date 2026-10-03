using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetActiveProcessInfoStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionExecuteContext lgFSvlfAmfQ;

		public ActionStep XMcSvihs3rc;

		public XAction PvpSv3KqYTG;

		private static _003C_003Ec__DisplayClass39_0 k7kD63W1GpxZEDROewJq;

		internal (bool isSuccess, string message, ActionStopFlag failReason) l4dSvUjRJJK()
		{
			using Process process = NativeMethods.GetForegroundProcess();
			ProcessModule mainModule = process.MainModule;
			object obj;
			if (mainModule == null)
			{
				obj = null;
			}
			else
			{
				obj = mainModule.FileName;
				if (obj != null)
				{
					goto IL_0021;
				}
			}
			obj = string.Empty;
			goto IL_0021;
			IL_0021:
			string result = (string)obj;
			string processName = process.ProcessName;
			try
			{
				if (HostedProcessHelper.IsHostProcess(processName))
				{
					using Process process2 = HostedProcessHelper.GetRealProcess(process);
					object obj2;
					if (process2 != null)
					{
						ProcessModule mainModule2 = process2.MainModule;
						if (mainModule2 == null)
						{
							obj2 = null;
						}
						else
						{
							obj2 = mainModule2.FileName;
							if (obj2 != null)
							{
								goto IL_0056;
							}
						}
						obj2 = string.Empty;
						goto IL_0056;
					}
					goto end_IL_0038;
					IL_0056:
					result = (string)obj2;
					processName = process2.ProcessName;
					end_IL_0038:;
				}
			}
			catch (Exception ex)
			{
				lgFSvlfAmfQ.ActionLogger.LogWarning("获取进程信息失败。" + ex.Message);
			}
			XActionHelper.OutputResult(Wa9ggt9JWa6, XMcSvihs3rc, lgFSvlfAmfQ, result, PvpSv3KqYTG);
			XActionHelper.OutputResult(hiRgggKZMyo, XMcSvihs3rc, lgFSvlfAmfQ, processName, PvpSv3KqYTG);
			XActionHelper.OutputResult(SfsggL4WUoU, XMcSvihs3rc, lgFSvlfAmfQ, process.Id, PvpSv3KqYTG);
			XActionHelper.OutputResult(eqtggvlcwk1, XMcSvihs3rc, lgFSvlfAmfQ, true, PvpSv3KqYTG);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool cHkN2xW101uyYo1bCIHv()
		{
			return k7kD63W1GpxZEDROewJq == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> fSngtUCWpHy = new string[3] { "前台窗口", "程序", "软件" };

	[CompilerGenerated]
	private readonly string fFRgtlthH16 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> A1MgtinTfGk;

	[CompilerGenerated]
	private readonly string ULJgt3Ll2Rp = "https://getquicker.net/KC/Help/Doc/getactiveprocessinfo";

	[CompilerGenerated]
	private readonly bool LhVgtf3JnOP;

	private static readonly StepInParamDef t36gtzwNSZT;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> tUwggwvoEk2 = new List<StepInParamDef> { t36gtzwNSZT };

	private static readonly StepOutParamDef Wa9ggt9JWa6;

	private static readonly StepOutParamDef hiRgggKZMyo;

	private static readonly StepOutParamDef SfsggL4WUoU;

	private static readonly StepOutParamDef eqtggvlcwk1;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> bVAggSVaed2 = new StepOutParamDef[4] { Wa9ggt9JWa6, hiRgggKZMyo, SfsggL4WUoU, eqtggvlcwk1 };

	private static GetActiveProcessInfoStep S4mZWuQREkU6lvGmSggl;

	public string Key => "sys:getActiveProcessInfo";

	public string Name => "获取前台进程信息";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return fSngtUCWpHy;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return fFRgtlthH16;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return A1MgtinTfGk;
		}
	}

	public string Description => "获取当前活动窗口进程的信息。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return ULJgt3Ll2Rp;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return LhVgtf3JnOP;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return tUwggwvoEk2;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return bVAggSVaed2;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.lgFSvlfAmfQ = context;
		_003C_003Ec__DisplayClass39_.XMcSvihs3rc = step;
		_003C_003Ec__DisplayClass39_.PvpSv3KqYTG = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.lgFSvlfAmfQ, _003C_003Ec__DisplayClass39_.XMcSvihs3rc, _003C_003Ec__DisplayClass39_.PvpSv3KqYTG, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.l4dSvUjRJJK, (Action)null, (Action)null, t36gtzwNSZT, eqtggvlcwk1);
	}

	public string GetSummary(ActionStep step)
	{
		return "获取进程信息：" + XActionHelper.GetOutputParamDisplayString(Wa9ggt9JWa6, step);
	}

	static GetActiveProcessInfoStep()
	{
		t36gtzwNSZT = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "获取进程信息失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		Wa9ggt9JWa6 = new StepOutParamDef
		{
			Key = "path",
			Name = "程序路径",
			Description = "获得的进程路径",
			Type = VarType.Text
		};
		hiRgggKZMyo = new StepOutParamDef
		{
			Key = "procName",
			Name = "进程名",
			Description = "进程名称",
			Type = VarType.Text
		};
		SfsggL4WUoU = new StepOutParamDef
		{
			Key = "pid",
			Name = "PID",
			Description = "进程ID",
			Type = VarType.Integer
		};
		eqtggvlcwk1 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功获得进程信息",
			Type = VarType.Boolean
		};
	}

	internal static bool epdckJQRGbBPPXbC6Ksm()
	{
		return S4mZWuQREkU6lvGmSggl == null;
	}
}
