using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class ComputeStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionStep TtGS7FlttsV;

		public ActionExecuteContext nRlS7UWpfjK;

		public XAction NV4S7l4IH0i;

		internal static _003C_003Ec__DisplayClass39_0 R0leChWkvSPY1dZEw6My;

		internal (bool isSuccess, string message, ActionStopFlag failReason) iJwS7ORjR4k()
		{
			string textParamValue = XActionHelper.GetTextParamValue(gr4gyw8AGSU, TtGS7FlttsV, nRlS7UWpfjK);
			if (string.IsNullOrEmpty(textParamValue))
			{
				return (isSuccess: false, message: "要计算的表达式为空。", failReason: ActionStopFlag.OperationFailed);
			}
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(igQgytFRuPL, TtGS7FlttsV, nRlS7UWpfjK);
			object obj = null;
			obj = ((!booleanParamValue) ? XActionHelper.EvaluateExpression(textParamValue) : XActionHelper.GetValueFromExpression2(textParamValue, nRlS7UWpfjK));
			XActionHelper.OutputResult(wcbgyv5Tjdt, TtGS7FlttsV, nRlS7UWpfjK, obj, NV4S7l4IH0i);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool zIuVH4WkdmmAIKM6RHBi()
		{
			return R0leChWkvSPY1dZEw6My == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> GHmgElRwVMP = new string[1] { "calc" };

	[CompilerGenerated]
	private readonly string HFZgEiB1ijI = $"fa:{EFontAwesomeIcon.Light_CalculatorAlt}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> yqfgE31vj1p;

	[CompilerGenerated]
	private readonly string bsdgEfM3HRq = "https://getquicker.net/KC/Help/Doc/compute";

	[CompilerGenerated]
	private readonly bool idGgEz1c8Mw;

	private static readonly StepInParamDef gr4gyw8AGSU;

	private static readonly StepInParamDef igQgytFRuPL;

	private static readonly StepInParamDef h0Fgyg2mC34;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Xa5gyLPb0Bc = new StepInParamDef[3] { gr4gyw8AGSU, igQgytFRuPL, h0Fgyg2mC34 };

	private static readonly StepOutParamDef wcbgyv5Tjdt;

	private static readonly StepOutParamDef QCagySSqnMX;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> BLJgy2rYj5W = new StepOutParamDef[2] { QCagySSqnMX, wcbgyv5Tjdt };

	private static ComputeStep UZ3VcGQxunQDPqL2hI1L;

	public string Key => "sys:compute";

	public string Name => "计算";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return GHmgElRwVMP;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return HFZgEiB1ijI;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return yqfgE31vj1p;
		}
	}

	public string Description => "对表达式进行计算。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bsdgEfM3HRq;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return idGgEz1c8Mw;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Xa5gyLPb0Bc;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return BLJgy2rYj5W;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.TtGS7FlttsV = step;
		_003C_003Ec__DisplayClass39_.nRlS7UWpfjK = context;
		_003C_003Ec__DisplayClass39_.NV4S7l4IH0i = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.nRlS7UWpfjK, _003C_003Ec__DisplayClass39_.TtGS7FlttsV, _003C_003Ec__DisplayClass39_.NV4S7l4IH0i, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.iJwS7ORjR4k, (Action)null, (Action)null, h0Fgyg2mC34, QCagySSqnMX);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(gr4gyw8AGSU, step) + " => " + XActionHelper.GetOutputParamDisplayString(wcbgyv5Tjdt, step);
	}

	static ComputeStep()
	{
		gr4gyw8AGSU = new StepInParamDef
		{
			Key = "expression",
			Name = "表达式",
			Description = "要计算的表达式",
			DefaultValue = "1+1",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		igQgytFRuPL = new StepInParamDef
		{
			Key = "evalVar",
			Name = "增强模式",
			Description = "支持在表达式中使用{变量名}和Math对象",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		h0Fgyg2mC34 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		wcbgyv5Tjdt = new StepOutParamDef
		{
			Key = "output",
			Name = "结果",
			Description = "将表达式计算结果写入变量",
			Type = VarType.Any
		};
		QCagySSqnMX = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool peXJj2Qxo1H05GCbJNv6()
	{
		return UZ3VcGQxunQDPqL2hI1L == null;
	}
}
