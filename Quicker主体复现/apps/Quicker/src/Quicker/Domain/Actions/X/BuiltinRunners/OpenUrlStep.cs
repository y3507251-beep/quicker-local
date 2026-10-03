using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Properties;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class OpenUrlStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ActionStep nhGSgooFXbe;

		public ActionExecuteContext VLASgTHVJon;

		private static _003C_003Ec__DisplayClass40_0 hebnjpWGHKxIKXt9Bme7;

		internal (bool isSuccess, string message, ActionStopFlag failReason) GDSSgdCStAR()
		{
			try
			{
				string textParamValue = XActionHelper.GetTextParamValue(vOktzvvR3Rl, nhGSgooFXbe, VLASgTHVJon);
				if (string.IsNullOrEmpty(textParamValue))
				{
					return (isSuccess: false, message: "要打开的网址为空。", failReason: ActionStopFlag.OperationFailed);
				}
				string textParamValue2 = XActionHelper.GetTextParamValue(XEftzSDWa3H, nhGSgooFXbe, VLASgTHVJon);
				string textParamValue3 = XActionHelper.GetTextParamValue(ymItz2FVpSA, nhGSgooFXbe, VLASgTHVJon);
				ActionHelper.OpenUrl(textParamValue, textParamValue2, textParamValue3);
			}
			catch (Exception ex)
			{
				return (isSuccess: false, message: ex.Message, failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void gUhx7YW0QGvhJuNbfUBL()
		{
		}

		internal static bool utWMw9WGzEA7fnEfYNqd()
		{
			return hebnjpWGHKxIKXt9Bme7 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> X3dtfzJ8ftR = new string[3] { "URL", "网址", "网页" };

	[CompilerGenerated]
	private readonly string pMStzwWS2Of = $"fa:{EFontAwesomeIcon.Light_Globe}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> mJXtztTmRMV = new StepRunnerCategory[1] { StepRunnerCategory.Network };

	[CompilerGenerated]
	private readonly string b8LtzgkTTBt = "https://getquicker.net/KC/Help/Doc/openurl";

	[CompilerGenerated]
	private readonly bool o3JtzLxpC27;

	private static readonly StepInParamDef vOktzvvR3Rl;

	private static readonly StepInParamDef XEftzSDWa3H;

	private static readonly StepInParamDef ymItz2FVpSA;

	private static readonly StepInParamDef aeQtzucxDHT;

	private static readonly StepOutParamDef GSctzNpKKfr;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> OOetzJi3vyi = new StepInParamDef[4] { vOktzvvR3Rl, XEftzSDWa3H, ymItz2FVpSA, aeQtzucxDHT };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Cbttz0sY1Tf = new List<StepOutParamDef> { GSctzNpKKfr };

	private static OpenUrlStep FUAKJfQYsQZvODcgvryH;

	public string Key => "sys:openUrl";

	public string Name => CommonStrings.Common_ActionType_OpenUrl;

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return X3dtfzJ8ftR;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return pMStzwWS2Of;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return mJXtztTmRMV;
		}
	}

	public string Description => "打开指定的网址";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return b8LtzgkTTBt;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return o3JtzLxpC27;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return OOetzJi3vyi;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Cbttz0sY1Tf;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.nhGSgooFXbe = step;
		_003C_003Ec__DisplayClass40_.VLASgTHVJon = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass40_.VLASgTHVJon, _003C_003Ec__DisplayClass40_.nhGSgooFXbe, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass40_.GDSSgdCStAR, (Action)null, (Action)null, aeQtzucxDHT, GSctzNpKKfr);
	}

	public string GetSummary(ActionStep step)
	{
		return "(" + XActionHelper.GetParamDisplayString(XEftzSDWa3H, step) + ") " + XActionHelper.GetParamDisplayString(vOktzvvR3Rl, step);
	}

	public static ActionStep CreateStep(string url, string browser, string borwserExePath)
	{
		ActionStep actionStep = new ActionStep();
		actionStep.StepRunnerKey = "sys:openUrl";
		actionStep.InputParams[vOktzvvR3Rl.Key] = new ActionStepParam
		{
			Value = url
		};
		actionStep.InputParams[XEftzSDWa3H.Key] = new ActionStepParam
		{
			Value = browser
		};
		if (!string.IsNullOrEmpty(borwserExePath))
		{
			actionStep.InputParams[ymItz2FVpSA.Key] = new ActionStepParam
			{
				Value = borwserExePath
			};
		}
		return actionStep;
	}

	static OpenUrlStep()
	{
		vOktzvvR3Rl = new StepInParamDef
		{
			Key = "url",
			Name = "网址",
			DefaultValue = "https://",
			Description = "要打开的网页地址",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		XEftzSDWa3H = new StepInParamDef
		{
			Key = "browser",
			Name = "浏览器",
			DefaultValue = "default",
			Description = "使用什么浏览器打开网址",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = ActionHelper.GetWebBrowsers(),
			IsControlField = true
		};
		ymItz2FVpSA = new StepInParamDef
		{
			Key = "exePath",
			Name = "浏览器程序路径",
			DefaultValue = "",
			Description = "浏览器exe程序路径",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "custom" },
			TextTools = new List<TextToolType>
			{
				TextToolType.SelectProcessPath,
				TextToolType.SelectSingleFile
			},
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		aeQtzucxDHT = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		GSctzNpKKfr = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool mgPLL2QYCRYSQeQHS87L()
	{
		return FUAKJfQYsQZvODcgvryH == null;
	}
}
