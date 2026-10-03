using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class BreakStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	private readonly IEnumerable<string> WO3tUQDvvyM = new string[3] { "循环", "break", "停止" };

	[CompilerGenerated]
	private readonly string e0UtUjVFFBD = $"fa:{EFontAwesomeIcon.Light_SignOut}:#fbbc05";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> WOMtUnKcakI;

	[CompilerGenerated]
	private readonly string whstU4insAU = "https://getquicker.net/KC/Help/Doc/break";

	[CompilerGenerated]
	private readonly bool DUAtU54XmHn;

	internal static BreakStep CpXBMeQZxHUYrbNanmtC;

	public string Key => "sys:break";

	public string Name => "跳出循环(break)";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return WO3tUQDvvyM;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return e0UtUjVFFBD;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return WOMtUnKcakI;
		}
	}

	public string Description => "跳出循环（“每个” 或 “重复” 模块）";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return whstU4insAU;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return DUAtU54XmHn;
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
		context.SetBreakFlag();
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	internal static bool KNfOV2QZI8UB1ZnNkFTv()
	{
		return CpXBMeQZxHUYrbNanmtC == null;
	}
}
