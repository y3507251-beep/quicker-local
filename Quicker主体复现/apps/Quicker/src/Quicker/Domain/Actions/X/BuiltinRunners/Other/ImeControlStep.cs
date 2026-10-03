using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using tPW96NMSpaXlHvSiZCX;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Other;

public class ImeControlStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ActionExecuteContext gJ4SZBibLnI;

		public ActionStep O8bSZQ1xZ4d;

		public XAction jlFSZjKphQX;

		internal static _003C_003Ec__DisplayClass40_0 p3nndXWNh6vO2Eq7YOj7;

		internal (bool isSuccess, string message, ActionStopFlag failReason) kPaSZpUKHIR()
		{
			bool flag = QeCVqvMTGqyXjRSCuyP.hF7LF2kDefY();
			gJ4SZBibLnI.ActionLogger.LogInfo("当前输入法状态：" + (flag ? "中" : "英文"));
			gJ4SZBibLnI.SaveImeState(flag);
			switch (XActionHelper.GetTextParamValue(JppgZk5wl80, O8bSZQ1xZ4d, gJ4SZBibLnI))
			{
			case "GET_STATE":
				XActionHelper.OutputResult(zMegZsBMwc7, O8bSZQ1xZ4d, gJ4SZBibLnI, flag, jlFSZjKphQX);
				break;
			case "RESTORE":
				if (gJ4SZBibLnI.IsImeEnabled.HasValue)
				{
					QeCVqvMTGqyXjRSCuyP.bc0LFuNtAhp(gJ4SZBibLnI.IsImeEnabled.Value);
				}
				break;
			case "DISABLE":
				QeCVqvMTGqyXjRSCuyP.bc0LFuNtAhp(false);
				break;
			case "ENABLE":
				QeCVqvMTGqyXjRSCuyP.bc0LFuNtAhp(true);
				break;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool N6ZvUHWNH3wXkeLEoWn2()
		{
			return p3nndXWNh6vO2Eq7YOj7 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> xeVgZhpkh9X;

	[CompilerGenerated]
	private readonly string SIrgZeLkZgv = $"fa:{EFontAwesomeIcon.Light_Keyboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Cp0gZYmjidk;

	[CompilerGenerated]
	private readonly string GY5gZIAMsx6 = "https://getquicker.net/KC/Help/Doc/imecontrol";

	[CompilerGenerated]
	private readonly bool i4tgZWoutnv;

	private static readonly StepInParamDef JppgZk5wl80;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> lUngZGtZ6jg = new List<StepInParamDef> { JppgZk5wl80 };

	private static StepOutParamDef zMegZsBMwc7;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> FvsgZHVGsZU = new List<StepOutParamDef> { zMegZsBMwc7 };

	internal static ImeControlStep BNG8SdQSrP4ltOfaKh9V;

	public string Key => "sys:imeControl";

	public string Name => "输入法状态";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return xeVgZhpkh9X;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return SIrgZeLkZgv;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Cp0gZYmjidk;
		}
	}

	public string Description => "获取或更改当前的输入法中英文状态，避免在发送热键时受影响。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return GY5gZIAMsx6;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return i4tgZWoutnv;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return lUngZGtZ6jg;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return FvsgZHVGsZU;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.gJ4SZBibLnI = context;
		_003C_003Ec__DisplayClass40_.O8bSZQ1xZ4d = step;
		_003C_003Ec__DisplayClass40_.jlFSZjKphQX = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass40_.gJ4SZBibLnI, _003C_003Ec__DisplayClass40_.O8bSZQ1xZ4d, _003C_003Ec__DisplayClass40_.jlFSZjKphQX, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass40_.kPaSZpUKHIR, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(JppgZk5wl80, step);
	}

	static ImeControlStep()
	{
		JppgZk5wl80 = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "要执行的操作。所有操作仅在输入法启用的情况下有效。",
			DefaultValue = "GET_STATE",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("ENABLE", "切换为中文"),
				new SelectionItem("DISABLE", "切换为英文"),
				new SelectionItem("RESTORE", "恢复"),
				new SelectionItem("GET_STATE", "是否为中文状态？")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		zMegZsBMwc7 = new StepOutParamDef
		{
			Key = "isEnabled",
			Name = "是否为中文状态",
			Description = "",
			ValidForList = new List<string> { "GET_STATE" },
			Type = VarType.Boolean
		};
	}

	internal static bool kHFVDsQSNmvSB8JnT5DK()
	{
		return BNG8SdQSrP4ltOfaKh9V == null;
	}
}
