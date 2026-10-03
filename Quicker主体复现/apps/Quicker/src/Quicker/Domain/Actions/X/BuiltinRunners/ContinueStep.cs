using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class ContinueStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	private readonly IEnumerable<string> h52tOxoDRkN = new string[2] { "循环", "continue" };

	[CompilerGenerated]
	private readonly string G00tOr040la = $"fa:{EFontAwesomeIcon.Light_Forward}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> XGKtOpbpNTE;

	[CompilerGenerated]
	private readonly string BD5tOBMtclF = "https://getquicker.net/KC/Help/Doc/continue";

	[CompilerGenerated]
	private readonly bool dmWtOQnTHYv;

	internal static ContinueStep iAOHF2Qlw7C8eomfdTed;

	public string Key => "sys:continue";

	public string Name => "跳过后续步骤(continue)";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return h52tOxoDRkN;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return G00tOr040la;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return XGKtOpbpNTE;
		}
	}

	public string Description => "跳过后续步骤（循环内部），开始下一次循环。在循环内部使用。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return BD5tOBMtclF;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return dmWtOQnTHYv;
		}
	}

	public IList<StepInParamDef> InputParams => Array.Empty<StepInParamDef>();

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		context.SetContinueFlag();
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	internal static void fibqpRQls1IuyAcsvrXV()
	{
	}

	internal static bool TY97QCQlThGUrjbF8pE9()
	{
		return iAOHF2Qlw7C8eomfdTed == null;
	}
}
