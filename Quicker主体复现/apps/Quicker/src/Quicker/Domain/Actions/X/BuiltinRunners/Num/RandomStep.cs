using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Num;

public class RandomStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	private readonly IEnumerable<string> epAgvqTKdrH = new string[1] { "random" };

	[CompilerGenerated]
	private readonly string UvOgvcGx0UZ = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> d9KgvVnejVN;

	[CompilerGenerated]
	private readonly string LcVgvZxmymN = "https://getquicker.net/KC/Help/Doc/randomnum";

	[CompilerGenerated]
	private readonly bool KMbgv9mJRmA;

	private static readonly StepInParamDef yCFgvhpnCZB;

	private static readonly StepInParamDef QJGgvevQgSJ;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> KuJgvYOdH59 = new StepInParamDef[2] { yCFgvhpnCZB, QJGgvevQgSJ };

	private static readonly StepOutParamDef JCcgvIIWpkq;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Lk0gvW2vflX = new StepOutParamDef[1] { JCcgvIIWpkq };

	private static readonly Random fnGgvkHh9LY;

	private static RandomStep UShwpdQg0H12saLGavPs;

	public string Key => "sys:randomNum";

	public string Name => "生成随机数";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return epAgvqTKdrH;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return UvOgvcGx0UZ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return d9KgvVnejVN;
		}
	}

	public string Description => "生成随机数";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return LcVgvZxmymN;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return KMbgv9mJRmA;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return KuJgvYOdH59;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Lk0gvW2vflX;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		long integerParamValue = XActionHelper.GetIntegerParamValue(yCFgvhpnCZB, step, context);
		long integerParamValue2 = XActionHelper.GetIntegerParamValue(QJGgvevQgSJ, step, context);
		int num = fnGgvkHh9LY.Next((int)integerParamValue, (int)integerParamValue2);
		XActionHelper.OutputResult(JCcgvIIWpkq, step, context, num, action);
	}

	public string GetSummary(ActionStep step)
	{
		return "=> " + XActionHelper.GetOutputParamDisplayString(JCcgvIIWpkq, step);
	}

	static RandomStep()
	{
		yCFgvhpnCZB = new StepInParamDef
		{
			Key = "min",
			Name = "最小值",
			DefaultValue = 0,
			Description = "随机数范围的最小值（结果大于或等于此值）",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		QJGgvevQgSJ = new StepInParamDef
		{
			Key = "max",
			Name = "最大值",
			DefaultValue = 100,
			Description = "随机数范围的最大值（结果小于此值）",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		JCcgvIIWpkq = new StepOutParamDef
		{
			Key = "output",
			Name = "随机数",
			Description = "生成的随机数",
			Type = VarType.Integer
		};
		fnGgvkHh9LY = new Random();
	}

	internal static bool iTqtiKQg1r5Yp5G4malK()
	{
		return UShwpdQg0H12saLGavPs == null;
	}
}
