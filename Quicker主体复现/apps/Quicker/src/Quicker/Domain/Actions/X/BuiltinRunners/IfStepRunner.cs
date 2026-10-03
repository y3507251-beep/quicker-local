using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class IfStepRunner : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public ActionStep Da1SL7P1VxW;

		public ActionExecuteContext ARfSLRraBbT;

		public XAction zwASLqD9LHt;

		public string FRhSLceqjfa;

		internal static _003C_003Ec__DisplayClass36_0 F3w3lBW0BrblXKXsqAig;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Lf6SLaOprle()
		{
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(zDrgw0TKadA, Da1SL7P1VxW, ARfSLRraBbT);
			int startIndex = 0;
			IList<ActionStep> list;
			if (booleanParamValue)
			{
				list = Da1SL7P1VxW.IfSteps;
			}
			else
			{
				startIndex = ((Da1SL7P1VxW.IfSteps != null) ? Da1SL7P1VxW.IfSteps.Count : 0);
				list = Da1SL7P1VxW.ElseSteps;
			}
			if (ARfSLRraBbT.IsDebugging)
			{
				ARfSLRraBbT.ActionLogger.LogInfo($"执行 {booleanParamValue} 分支, 共 {list.Count} 步骤");
			}
			if (list != null && list.Count > 0)
			{
				XActionRunner.RunChildSteps(list, startIndex, ARfSLRraBbT, zwASLqD9LHt, FRhSLceqjfa);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		static _003C_003Ec__DisplayClass36_0()
		{
		}

		internal static bool NZjIx0W0vlHyINuotOjN()
		{
			return F3w3lBW0BrblXKXsqAig == null;
		}

		internal static void JP96rfW0OrEJLg1Sxwoj()
		{
		}
	}

	public const string RunnerKey = "sys:if";

	[CompilerGenerated]
	private readonly IEnumerable<string> qRcgwSKyr6D = new string[4] { "if", "whether", "如果", "switch" };

	[CompilerGenerated]
	private readonly string Nsngw20Tueb = $"fa:{EFontAwesomeIcon.Regular_ProjectDiagram}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> XHrgwuIj6rW;

	[CompilerGenerated]
	private readonly string hgngwNUJTjE = "https://getquicker.net/KC/Help/Doc/if";

	[CompilerGenerated]
	private readonly bool CA2gwJZsJEr;

	private static readonly StepInParamDef zDrgw0TKadA;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> W78gwCJZD46 = new StepInParamDef[1] { zDrgw0TKadA };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> os3gwPv9rF7;

	internal static IfStepRunner rTwNO2Q8KUQxm9Moj9RX;

	public string Key => "sys:if";

	public string Name => "如果/否则";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return qRcgwSKyr6D;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Nsngw20Tueb;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return XHrgwuIj6rW;
		}
	}

	public string Description => "依据条件执行操作";

	public StepType StepType => StepType.If;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return hgngwNUJTjE;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return CA2gwJZsJEr;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return W78gwCJZD46;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return os3gwPv9rF7;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step1, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.Da1SL7P1VxW = step1;
		_003C_003Ec__DisplayClass36_.ARfSLRraBbT = context;
		_003C_003Ec__DisplayClass36_.zwASLqD9LHt = action;
		_003C_003Ec__DisplayClass36_.FRhSLceqjfa = stepId;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass36_.ARfSLRraBbT, _003C_003Ec__DisplayClass36_.Da1SL7P1VxW, _003C_003Ec__DisplayClass36_.zwASLqD9LHt, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass36_.Lf6SLaOprle, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "判断条件：" + XActionHelper.GetParamDisplayString(zDrgw0TKadA, step);
	}

	static IfStepRunner()
	{
		zDrgw0TKadA = new StepInParamDef
		{
			Key = "condition",
			DefaultValue = "",
			Description = "是否符合指定的条件",
			IsRequired = false,
			Name = "如果",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			TextTools = new List<TextToolType> { TextToolType.BoolExpressionHelper }
		};
	}

	internal static bool rBSqSlQ8BMOpI5IvYEEd()
	{
		return rTwNO2Q8KUQxm9Moj9RX == null;
	}
}
