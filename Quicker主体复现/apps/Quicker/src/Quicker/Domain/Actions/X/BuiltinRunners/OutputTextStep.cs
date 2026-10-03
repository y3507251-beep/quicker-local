using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class OutputTextStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public ActionStep ANGSSHAZGpK;

		public ActionExecuteContext BMqSS1sPU3C;

		private static _003C_003Ec__DisplayClass44_0 obDir9W1I6D89Ii6Bpqp;

		internal (bool isSuccess, string message, ActionStopFlag failReason) hq4SSs8IL4W()
		{
			string textParamValue = XActionHelper.GetTextParamValue(ESRgL2YmYlE, ANGSSHAZGpK, BMqSS1sPU3C);
			string textParamValue2 = XActionHelper.GetTextParamValue(qV9gLubii3s, ANGSSHAZGpK, BMqSS1sPU3C);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(AASgLCkd5o2, ANGSSHAZGpK, BMqSS1sPU3C);
			int delayMsBeforePaste = Convert.ToInt32(XActionHelper.GetNumberParamValue(niAgLNE2S4X, ANGSSHAZGpK, BMqSS1sPU3C));
			int delayMsAfterPaste = Convert.ToInt32(XActionHelper.GetNumberParamValue(lCbgLJSrWwK, ANGSSHAZGpK, BMqSS1sPU3C));
			int delayBetweenChar = Convert.ToInt32(XActionHelper.GetIntegerParamValue(km2gL0jrRB1, ANGSSHAZGpK, BMqSS1sPU3C));
			bool useCopyPaste = string.Equals(textParamValue2, "paste", StringComparison.OrdinalIgnoreCase);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(QeBgLPtCRyA, ANGSSHAZGpK, BMqSS1sPU3C);
			if (string.IsNullOrEmpty(textParamValue))
			{
				BMqSS1sPU3C.ActionLogger.LogWarning("要发送的文本内容为空，已跳过。");
			}
			else
			{
				ActionHelper.SendTextToWindow(textParamValue, useCopyPaste, booleanParamValue, delayMsBeforePaste, delayMsAfterPaste, delayBetweenChar, booleanParamValue2, BMqSS1sPU3C.CancellationToken);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool pAqp5mW16LAIA4wClyCB()
		{
			return obDir9W1I6D89Ii6Bpqp == null;
		}
	}

	public const string Method_Input = "input";

	public const string Method_Paste = "paste";

	[CompilerGenerated]
	private readonly IEnumerable<string> qJAgLtxiunx = new string[4] { "sendtext", "text", "paste", "粘贴" };

	[CompilerGenerated]
	private readonly string DJWgLgNHvXw = $"fa:{EFontAwesomeIcon.Light_CommentAltLines}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> P8QgLLt0Jhh = new StepRunnerCategory[2]
	{
		StepRunnerCategory.Text,
		StepRunnerCategory.Input
	};

	[CompilerGenerated]
	private readonly string w3NgLvOQcR9 = "https://getquicker.net/KC/Help/Doc/outputtext";

	[CompilerGenerated]
	private readonly bool bQqgLSgdOWD;

	private static readonly StepInParamDef ESRgL2YmYlE;

	private static readonly StepInParamDef qV9gLubii3s;

	private static readonly StepInParamDef niAgLNE2S4X;

	private static readonly StepInParamDef lCbgLJSrWwK;

	private static readonly StepInParamDef km2gL0jrRB1;

	private static readonly StepInParamDef AASgLCkd5o2;

	private static readonly StepInParamDef QeBgLPtCRyA;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> boHgLEZF0CN = new StepInParamDef[8]
	{
		ESRgL2YmYlE,
		qV9gLubii3s,
		niAgLNE2S4X,
		lCbgLJSrWwK,
		km2gL0jrRB1,
		AASgLCkd5o2,
		QeBgLPtCRyA,
		StepInParamDef.StopIfFailParam
	};

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> J3TgLyrPBpw = new List<StepOutParamDef> { StepOutParamDef.IsSuccessOutputParam };

	internal static OutputTextStep j8e06FQRg8dXDGthXfNR;

	public string Key => "sys:outputText";

	public string Name => "发送文本到窗口";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return qJAgLtxiunx;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return DJWgLgNHvXw;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return P8QgLLt0Jhh;
		}
	}

	public string Description => "将文本输出到活动窗口中";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return w3NgLvOQcR9;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return bQqgLSgdOWD;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return boHgLEZF0CN;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return J3TgLyrPBpw;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
		_003C_003Ec__DisplayClass44_.ANGSSHAZGpK = step;
		_003C_003Ec__DisplayClass44_.BMqSS1sPU3C = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass44_.BMqSS1sPU3C, _003C_003Ec__DisplayClass44_.ANGSSHAZGpK, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass44_.hq4SSs8IL4W, (Action)null, (Action)null, StepInParamDef.StopIfFailParam, StepOutParamDef.IsSuccessOutputParam);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ESRgL2YmYlE, step) ?? "";
	}

	public static ActionStep CreateStep(string text, bool useCopyPaste, bool appendReturn = false)
	{
		ActionStep actionStep = new ActionStep();
		actionStep.StepRunnerKey = "sys:outputText";
		actionStep.InputParams = new Dictionary<string, ActionStepParam>();
		actionStep.InputParams[ESRgL2YmYlE.Key] = new ActionStepParam
		{
			Value = text
		};
		actionStep.InputParams[qV9gLubii3s.Key] = new ActionStepParam
		{
			Value = (useCopyPaste ? "paste" : "input")
		};
		actionStep.InputParams[AASgLCkd5o2.Key] = new ActionStepParam
		{
			Value = (appendReturn ? "1" : "0")
		};
		return actionStep;
	}

	static OutputTextStep()
	{
		ESRgL2YmYlE = new StepInParamDef
		{
			Key = "content",
			Name = "内容",
			Description = "要输出的内容",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = true
		};
		qV9gLubii3s = new StepInParamDef
		{
			Key = "method",
			Name = "方法",
			Description = "发送内容使用的方法",
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			DefaultValue = "paste",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("input", "模拟输入"),
				new SelectionItem("paste", "复制到剪贴板后粘贴(Ctrl+V)")
			},
			IsControlField = true
		};
		niAgLNE2S4X = new StepInParamDef
		{
			Key = "delayBeforePaste",
			Name = "粘贴前延时",
			Description = "毫秒数。写入剪贴板以后，等待指定的时间后再发送粘贴按键(Ctrl+V)",
			DefaultValue = 50,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Integer,
			ValidForList = new List<string> { "paste" }
		};
		lCbgLJSrWwK = new StepInParamDef
		{
			Key = "delayAfterPaste",
			Name = "粘贴后延时",
			Description = "毫秒数。发送粘贴按键(Ctrl+V)之后等待的毫秒数",
			DefaultValue = 10,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Integer,
			ValidForList = new List<string> { "paste" }
		};
		km2gL0jrRB1 = new StepInParamDef
		{
			Key = "delayBetweenChar",
			Name = "字符间延迟",
			Description = "模拟输入下一个字符之前等待的毫秒数。",
			DefaultValue = 0,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Integer,
			ValidForList = new List<string> { "input" }
		};
		AASgLCkd5o2 = new StepInParamDef
		{
			Key = "appendReturn",
			Name = "在末尾添加回车",
			Description = "发送内容后，在末尾输入回车",
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Boolean,
			DefaultValue = false
		};
		QeBgLPtCRyA = new StepInParamDef
		{
			Key = "hideInHistory",
			Name = "从剪贴板历史中隐藏",
			Description = "Win+v 是否允许看到本条历史",
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Boolean,
			DefaultValue = false,
			ValidForList = new List<string> { "paste" }
		};
	}

	internal static bool Dr1KrpQRPd1Al3Br8nFK()
	{
		return j8e06FQRg8dXDGthXfNR == null;
	}

	internal static void lM43JNQRUdQDuQY6ybpD()
	{
	}
}
