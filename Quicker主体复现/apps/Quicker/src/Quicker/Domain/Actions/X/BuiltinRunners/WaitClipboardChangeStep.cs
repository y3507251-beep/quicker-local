using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class WaitClipboardChangeStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public ActionStep pQCSSjEE7H5;

		public ActionExecuteContext zBxSSnEC2TN;

		public ActionExecuteContext Cr5SS4kfDtZ;

		private static _003C_003Ec__DisplayClass37_0 JwEnX7W1hMhwy13y4g2f;

		internal (bool isSuccess, string message, ActionStopFlag failReason) NCCSSQnOgpj()
		{
			double numberParamValue = XActionHelper.GetNumberParamValue(gAngLTQ3KDD, pQCSSjEE7H5, zBxSSnEC2TN);
			long integerParamValue = XActionHelper.GetIntegerParamValue(WRtgLMmlnk8, pQCSSjEE7H5, zBxSSnEC2TN);
			bool flag = XActionHelper.GetBooleanParamValue(NbmgLAfyDw8, pQCSSjEE7H5, zBxSSnEC2TN) && !Cr5SS4kfDtZ.IsWaitWindowClosed("");
			if (integerParamValue > 0L && integerParamValue >= AppHelper.fLiLTj0x4QY() - AppState.LastClipboardChangeTime)
			{
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			if (zBxSSnEC2TN.ClipboardSeqBeforeCtrlC > 0 && zBxSSnEC2TN.ClipboardSeqBeforeCtrlC < AppState.ClipboardSequenceNumber && zBxSSnEC2TN.ClipboardSeqBeforeCtrlC > AppState.ClipboardSequenceNumber - 3)
			{
				zBxSSnEC2TN.ActionLogger?.LogInfo("剪贴板内容已改变");
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			long num = AppState.ClipboardSequenceNumber;
			long num2 = num;
			int millisecondsTimeout = 100;
			int num3 = 50;
			num3 = (int)(numberParamValue * 1000.0 / 100.0);
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			for (int i = 0; i < num3; i++)
			{
				if (zBxSSnEC2TN.IsShouldStopAction())
				{
					break;
				}
				if (flag && Cr5SS4kfDtZ.IsWaitWindowClosed(""))
				{
					break;
				}
				num2 = AppState.ClipboardSequenceNumber;
				if (num2 == num)
				{
					Thread.Sleep(millisecondsTimeout);
					continue;
				}
				Thread.Sleep(20);
				break;
			}
			if (num2 == num)
			{
				string item = zBxSSnEC2TN.ActionTitle + ": 等待时间已到或已取消，剪贴板内容未改变。";
				return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
			}
			stopwatch.Stop();
			string message = stopwatch.ElapsedMilliseconds + "ms后剪贴板内容改变了。";
			zBxSSnEC2TN.ActionLogger?.LogInfo(message);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool C1yjJmW1H4vFSJ3BlZs2()
		{
			return JwEnX7W1hMhwy13y4g2f == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> CrwgL4Krlb0;

	[CompilerGenerated]
	private readonly string WOKgL5Vgfky = $"fa:{EFontAwesomeIcon.Light_ClipboardCheck}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> CsUgLDykp2a = new StepRunnerCategory[1];

	[CompilerGenerated]
	private readonly string VxrgLdVAaOd = "https://getquicker.net/KC/Help/Doc/waitclipboardchange";

	[CompilerGenerated]
	private readonly bool v4jgLoqPDXf;

	private static readonly StepInParamDef gAngLTQ3KDD;

	private static readonly StepInParamDef WRtgLMmlnk8;

	private static readonly StepInParamDef NbmgLAfyDw8;

	private static readonly StepInParamDef AcFgLOM3oGH;

	private static readonly StepOutParamDef QgygLFrQc5L;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> fGDgLUSeaNa = new StepOutParamDef[1] { QgygLFrQc5L };

	internal static WaitClipboardChangeStep XU8MKkQgFPSvoJAlcvXT;

	public string Key => "sys:waitClipboardChange";

	public string Name => "等待剪贴板内容改变";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return CrwgL4Krlb0;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return WOKgL5Vgfky;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Clipboard;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return CsUgLDykp2a;
		}
	}

	public string Description => "等待剪贴板的内容发生改变。等待第三方工具（如截图工具）完成操作并更新剪贴板。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return VxrgLdVAaOd;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return v4jgLoqPDXf;
		}
	}

	public IList<StepInParamDef> InputParams => new List<StepInParamDef> { gAngLTQ3KDD, WRtgLMmlnk8, NbmgLAfyDw8, AcFgLOM3oGH };

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return fGDgLUSeaNa;
		}
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.pQCSSjEE7H5 = step;
		_003C_003Ec__DisplayClass37_.zBxSSnEC2TN = context;
		_003C_003Ec__DisplayClass37_.Cr5SS4kfDtZ = ((_003C_003Ec__DisplayClass37_.zBxSSnEC2TN.ParentContext == null) ? _003C_003Ec__DisplayClass37_.zBxSSnEC2TN : _003C_003Ec__DisplayClass37_.zBxSSnEC2TN.RootContext);
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass37_.zBxSSnEC2TN, _003C_003Ec__DisplayClass37_.pQCSSjEE7H5, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass37_.NCCSSQnOgpj, (Action)null, (Action)null, AcFgLOM3oGH, QgygLFrQc5L);
	}

	public string GetSummary(ActionStep step)
	{
		return "最长 " + XActionHelper.GetParamDisplayString(gAngLTQ3KDD, step) + " 秒";
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	static WaitClipboardChangeStep()
	{
		gAngLTQ3KDD = new StepInParamDef
		{
			Key = "maxWaitSeconds",
			Name = "最长等待秒数",
			DefaultValue = 10,
			Description = "超过等待时间剪贴板未改变，则结束等待。",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		WRtgLMmlnk8 = new StepInParamDef
		{
			Key = "recentChangeMs",
			Name = "包含临近的改变",
			DefaultValue = 10,
			Description = "包含在此之前一定时间内(毫秒)发生的改变。",
			Type = VarType.Integer,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		NbmgLAfyDw8 = new StepInParamDef
		{
			Key = "monitorWaitWin",
			Name = "等待窗口关闭时取消",
			DefaultValue = false,
			Description = "结合“等待窗口”模块，如果等待窗口关闭，则停止等待剪贴板变化。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		AcFgLOM3oGH = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "超时后剪贴板仍未改变，是否中止动作。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		QgygLFrQc5L = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否改变",
			Description = "剪贴板内容是否改变了",
			Type = VarType.Boolean
		};
	}

	internal static bool XR7tMBQgc5k9e0IB0dJI()
	{
		return XU8MKkQgFPSvoJAlcvXT == null;
	}
}
