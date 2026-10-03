using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class CommentStep : IStepRunner, IStepRunningInfo
{
	public const string STEP_KEY = "sys:comment";

	[CompilerGenerated]
	private readonly IEnumerable<string> TfegyUOdqN2 = new string[3] { "comment", "note", "备注" };

	[CompilerGenerated]
	private readonly string u3JgylZaRDw = $"fa:{EFontAwesomeIcon.Solid_FileAlt}:#f2ba00";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> zQwgyikQ9yo;

	[CompilerGenerated]
	private readonly string ahUgy3FbdXT = "https://getquicker.net/KC/Help/Doc/comment";

	[CompilerGenerated]
	private readonly bool DCkgyfRwq5N;

	internal static readonly StepInParamDef tFBgyzt1kKa;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> iy6g8w8XB03 = new StepInParamDef[1] { tFBgyzt1kKa };

	internal static CommentStep nDftGaQIQaPid5Gt2oHo;

	public string Key => "sys:comment";

	public string Name => "注释";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return TfegyUOdqN2;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return u3JgylZaRDw;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return zQwgyikQ9yo;
		}
	}

	public string Description => "使用注释将步骤分组，描述后续步骤的目的。";

	public StepType StepType => StepType.Comment;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return ahUgy3FbdXT;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return DCkgyfRwq5N;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return iy6g8w8XB03;
		}
	}

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(tFBgyzt1kKa, step, 0);
	}

	static CommentStep()
	{
		tFBgyzt1kKa = new StepInParamDef
		{
			Key = "note",
			Name = "注释内容",
			Description = "注释内容",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Text,
			IsMultiLine = true
		};
	}

	internal static bool JsldTJQIFU3IWsNHw0ps()
	{
		return nDftGaQIQaPid5Gt2oHo == null;
	}
}
