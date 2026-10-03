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

public class SimpleIfStepRunner : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public ActionStep DWVv3EGh0Xt;

		public ActionExecuteContext Q72v3yNepea;

		public XAction ogyv38TeH6S;

		public string O1vv3aTAKre;

		internal static _003C_003Ec__DisplayClass36_0 MUpGnZWDFbm5scTOnEkd;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Fgvv3PJXBuL()
		{
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(NdatTdahmSH, DWVv3EGh0Xt, Q72v3yNepea);
			int startIndex = 0;
			if (booleanParamValue)
			{
				IList<ActionStep> ifSteps = DWVv3EGh0Xt.IfSteps;
				if (Q72v3yNepea.IsDebugging)
				{
					Q72v3yNepea.ActionLogger.LogInfo($"执行 {booleanParamValue} 分支, 共 {ifSteps.Count} 步骤");
				}
				if (ifSteps != null && ifSteps.Count > 0)
				{
					XActionRunner.RunChildSteps(ifSteps, startIndex, Q72v3yNepea, ogyv38TeH6S, O1vv3aTAKre);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			Q72v3yNepea.ActionLogger.LogInfo("不符合条件，跳过。");
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool tuPyrpWDcFIeL8CwuS9A()
		{
			return MUpGnZWDFbm5scTOnEkd == null;
		}
	}

	public const string RunnerKey = "sys:simpleIf";

	[CompilerGenerated]
	private readonly IEnumerable<string> wQAtTjc9OjX = new string[4] { "如果否则", "条件", "if", "condition" };

	[CompilerGenerated]
	private readonly string vVutTny53Xq = $"fa:{EFontAwesomeIcon.Regular_ProjectDiagram}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> sB8tT43W3Mj;

	[CompilerGenerated]
	private readonly string dqAtT5JgdqT = "https://getquicker.net/KC/Help/Doc/if";

	[CompilerGenerated]
	private readonly bool TmktTDC31dT;

	private static readonly StepInParamDef NdatTdahmSH;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> hV9tTo57Q0n = new StepInParamDef[1] { NdatTdahmSH };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> xwctTTGRePB;

	internal static SimpleIfStepRunner cMYFU3QioQymH0jkJJVq;

	public string Key => "sys:simpleIf";

	public string Name => "如果";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return wQAtTjc9OjX;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return vVutTny53Xq;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return sB8tT43W3Mj;
		}
	}

	public string Description => "依据条件执行操作";

	public StepType StepType => StepType.Loop;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return dqAtT5JgdqT;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return TmktTDC31dT;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return hV9tTo57Q0n;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return xwctTTGRePB;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step1, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.DWVv3EGh0Xt = step1;
		_003C_003Ec__DisplayClass36_.Q72v3yNepea = context;
		_003C_003Ec__DisplayClass36_.ogyv38TeH6S = action;
		_003C_003Ec__DisplayClass36_.O1vv3aTAKre = stepId;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass36_.Q72v3yNepea, _003C_003Ec__DisplayClass36_.DWVv3EGh0Xt, _003C_003Ec__DisplayClass36_.ogyv38TeH6S, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass36_.Fgvv3PJXBuL, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "判断条件：" + XActionHelper.GetParamDisplayString(NdatTdahmSH, step);
	}

	static SimpleIfStepRunner()
	{
		NdatTdahmSH = new StepInParamDef
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

	internal static bool ARBPLkQif12av2NikfU1()
	{
		return cMYFU3QioQymH0jkJJVq == null;
	}
}
