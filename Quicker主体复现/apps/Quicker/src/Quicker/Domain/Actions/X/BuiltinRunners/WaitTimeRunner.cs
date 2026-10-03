using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class WaitTimeRunner : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public ActionStep OZ9SSDO8vTT;

		public ActionExecuteContext xZ8SSdUlA2q;

		public ActionExecuteContext dfaSSoUwv0Y;

		internal static _003C_003Ec__DisplayClass36_0 N3Y2MuWKV7UNPAuwtARf;

		internal (bool isSuccess, string message, ActionStopFlag failReason) z8MSS5Slh9J()
		{
			int num = (int)XActionHelper.GetIntegerParamValue(delayMsParam, OZ9SSDO8vTT, xZ8SSdUlA2q);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(um9gvwCFN6N, OZ9SSDO8vTT, xZ8SSdUlA2q);
			if (num > 0)
			{
				long num2 = AppHelper.fLiLTj0x4QY() + num;
				while (num2 > AppHelper.fLiLTj0x4QY() && !xZ8SSdUlA2q.IsShouldStopAction() && (!booleanParamValue || !dfaSSoUwv0Y.IsWaitWindowClosed("")))
				{
					Thread.Sleep(20);
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool Pc9yw8WKQBUJ0x09wKwB()
		{
			return N3Y2MuWKV7UNPAuwtARf == null;
		}
	}

	public const string StepKey = "sys:delay";

	[CompilerGenerated]
	private readonly IEnumerable<string> OsOgLlgO6RR = new string[7] { "sleep", "waite", "time", "ms", "延迟时间", "delay", "yanchi" };

	[CompilerGenerated]
	private readonly string WvagLilwqyx = $"fa:{EFontAwesomeIcon.Light_Stopwatch}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Rl9gL3p85DX;

	[CompilerGenerated]
	private readonly string HHIgLfabtDT = "https://getquicker.net/KC/Help/Doc/delay";

	[CompilerGenerated]
	private readonly bool KfhgLzhGDnh;

	public static readonly StepInParamDef delayMsParam;

	private static readonly StepInParamDef um9gvwCFN6N;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> kF4gvtJG8Rb = new StepInParamDef[2] { delayMsParam, um9gvwCFN6N };

	internal static WaitTimeRunner mR8pVoQgXCn6lGQcNoW2;

	public string Key => "sys:delay";

	public string Name => "等待时间";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return OsOgLlgO6RR;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return WvagLilwqyx;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Rl9gL3p85DX;
		}
	}

	public string Description => "等待指定的毫秒数";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return HHIgLfabtDT;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return KfhgLzhGDnh;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return kF4gvtJG8Rb;
		}
	}

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.OZ9SSDO8vTT = step;
		_003C_003Ec__DisplayClass36_.xZ8SSdUlA2q = context;
		_003C_003Ec__DisplayClass36_.dfaSSoUwv0Y = ((_003C_003Ec__DisplayClass36_.xZ8SSdUlA2q.ParentContext == null) ? _003C_003Ec__DisplayClass36_.xZ8SSdUlA2q : _003C_003Ec__DisplayClass36_.xZ8SSdUlA2q.RootContext);
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass36_.xZ8SSdUlA2q, _003C_003Ec__DisplayClass36_.OZ9SSDO8vTT, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass36_.z8MSS5Slh9J, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "等待 " + XActionHelper.GetParamDisplayString(delayMsParam, step) + " ms";
	}

	public static ActionStep CreateStep(int ms)
	{
		ActionStep actionStep = new ActionStep();
		actionStep.StepRunnerKey = "sys:delay";
		actionStep.InputParams = new Dictionary<string, ActionStepParam>();
		actionStep.InputParams[delayMsParam.Key] = new ActionStepParam
		{
			Value = ms.ToString()
		};
		return actionStep;
	}

	static WaitTimeRunner()
	{
		delayMsParam = new StepInParamDef
		{
			Key = "delayMs",
			Name = "等待时间",
			Description = "等待时间毫秒数",
			DefaultValue = 100,
			Type = VarType.Integer,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		um9gvwCFN6N = new StepInParamDef
		{
			Key = "monitorWaitWin",
			Name = "等待窗口关闭时取消",
			DefaultValue = false,
			Description = "结合“等待窗口”模块，如果等待窗口关闭，则停止等待。仅当等待时间超过1000ms时生效",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
	}

	internal static bool TG5Fn1Qg2js9CAInCTmQ()
	{
		return mR8pVoQgXCn6lGQcNoW2 == null;
	}

	internal static void YqSDQDQgnt8Wa45l0ava()
	{
	}
}
