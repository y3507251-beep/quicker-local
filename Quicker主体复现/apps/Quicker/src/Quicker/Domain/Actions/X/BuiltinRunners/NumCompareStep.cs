using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class NumCompareStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public ActionStep kSUStLQjppw;

		public ActionExecuteContext zd1StvbY8vv;

		public XAction jXoStSMZau5;

		private static _003C_003Ec__DisplayClass38_0 MbgZXXWElPmmB2YV5WbA;

		internal (bool isSuccess, string message, ActionStopFlag failReason) BlRStgQaZ9w()
		{
			string textParamValue = XActionHelper.GetTextParamValue(pLXtl7SFkZK, kSUStLQjppw, zd1StvbY8vv);
			double numberParamValue = XActionHelper.GetNumberParamValue(OQLtlack2uB, kSUStLQjppw, zd1StvbY8vv);
			double numberParamValue2 = XActionHelper.GetNumberParamValue(eFytlRgijsV, kSUStLQjppw, zd1StvbY8vv);
			bool flag = false;
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的操作符：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			case "<=":
				flag = numberParamValue <= numberParamValue2;
				break;
			case "<":
				flag = numberParamValue < numberParamValue2;
				break;
			case "=":
				flag = numberParamValue == numberParamValue2;
				break;
			case ">=":
				flag = numberParamValue >= numberParamValue2;
				break;
			case ">":
				flag = numberParamValue > numberParamValue2;
				break;
			}
			XActionHelper.OutputResult(fYAtlcbeGfM, kSUStLQjppw, zd1StvbY8vv, flag, jXoStSMZau5);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool k6aXnNWEZ6elLPhcmpfU()
		{
			return MbgZXXWElPmmB2YV5WbA == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> jO9tlCXfFyh = new string[4] { "比较", "compare", "number", "数字" };

	[CompilerGenerated]
	private readonly string gKCtlPZP4xZ = $"fa:{EFontAwesomeIcon.Light_Calculator}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> fNXtlE0jh5x;

	[CompilerGenerated]
	private readonly string A13tlyiNrCd = "https://getquicker.net/KC/Help/Doc/numcompare";

	[CompilerGenerated]
	private readonly bool YMytl8EeRdZ;

	private static readonly StepInParamDef OQLtlack2uB;

	private static readonly StepInParamDef pLXtl7SFkZK;

	private static readonly StepInParamDef eFytlRgijsV;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> wNVtlqCr8GW = new StepInParamDef[3] { OQLtlack2uB, pLXtl7SFkZK, eFytlRgijsV };

	private static readonly StepOutParamDef fYAtlcbeGfM;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> upytlVQh9KS = new StepOutParamDef[1] { fYAtlcbeGfM };

	internal static NumCompareStep NDSW4rQ5y85l9ktZhsmV;

	public string Key => "sys:numCompare";

	public string Name => "比较数字";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return jO9tlCXfFyh;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return gKCtlPZP4xZ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return fNXtlE0jh5x;
		}
	}

	public string Description => "比较数字大小。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return A13tlyiNrCd;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return YMytl8EeRdZ;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return wNVtlqCr8GW;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return upytlVQh9KS;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		_003C_003Ec__DisplayClass38_.kSUStLQjppw = step;
		_003C_003Ec__DisplayClass38_.zd1StvbY8vv = context;
		_003C_003Ec__DisplayClass38_.jXoStSMZau5 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass38_.zd1StvbY8vv, _003C_003Ec__DisplayClass38_.kSUStLQjppw, _003C_003Ec__DisplayClass38_.jXoStSMZau5, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass38_.BlRStgQaZ9w, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(OQLtlack2uB, step) + " " + XActionHelper.GetParamDirectValue(pLXtl7SFkZK, step) + "  " + XActionHelper.GetParamDisplayString(eFytlRgijsV, step) + " ?";
	}

	static NumCompareStep()
	{
		OQLtlack2uB = new StepInParamDef
		{
			Key = "param1",
			Name = "数字1",
			Description = "左侧的数字",
			DefaultValue = "0",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		pLXtl7SFkZK = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "比较方式",
			DefaultValue = ">",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(">"),
				new SelectionItem(">="),
				new SelectionItem("="),
				new SelectionItem("<"),
				new SelectionItem("<=")
			},
			VariableMode = ParamVariableMode.Input
		};
		eFytlRgijsV = new StepInParamDef
		{
			Key = "param2",
			Name = "数字2",
			Description = "右侧的数字",
			DefaultValue = "0",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		fYAtlcbeGfM = new StepOutParamDef
		{
			Key = "value",
			Name = "值",
			Description = "比较结果是否为真",
			Type = VarType.Boolean
		};
	}

	internal static bool mbyqDvQ5pl72RlmVUYXb()
	{
		return NDSW4rQ5y85l9ktZhsmV == null;
	}

	internal static void msd8ftQ5AxGRdx3kQvu2()
	{
	}
}
