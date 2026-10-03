using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class StopActionStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	private readonly IEnumerable<string> IQ6gwEBhb7C = new string[4] { "中止", "返回", "return", "stop" };

	[CompilerGenerated]
	private readonly string DKngwywxWAq = $"fa:{EFontAwesomeIcon.Solid_Square}:#FF3000";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> T2Agw85ag98;

	[CompilerGenerated]
	private readonly string q4Agwafvbxy = "https://getquicker.net/KC/Help/Doc/stop";

	[CompilerGenerated]
	private readonly bool lg9gw7ggml1;

	private static readonly StepInParamDef oeygwRNQS3w;

	public static StepInParamDef _isErrorParam;

	public static StepInParamDef _returnParam;

	public static StepInParamDef _showMessageParam;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> KqCgwqQDsWe = new List<StepInParamDef> { oeygwRNQS3w, _isErrorParam, _returnParam, _showMessageParam };

	internal static StopActionStep QVCtg5Q8JAa2ml5vg9tH;

	public string Key => "sys:stop";

	public string Name => "停止(return)";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return IQ6gwEBhb7C;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return DKngwywxWAq;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return T2Agw85ag98;
		}
	}

	public string Description => "停止动作或从子程序中返回";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return q4Agwafvbxy;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return lg9gw7ggml1;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return KqCgwqQDsWe;
		}
	}

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		string textParamValue = XActionHelper.GetTextParamValue(oeygwRNQS3w, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(_showMessageParam, step, context);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(_isErrorParam, step, context);
		if (!string.IsNullOrWhiteSpace(textParamValue2))
		{
			if (booleanParamValue)
			{
				AppHelper.ShowWarning(textParamValue2);
			}
			else
			{
				AppHelper.ShowInformation(textParamValue2);
			}
		}
		object obj = (context.ReturnResultObject = XActionHelper.GetParamValue(_returnParam, step, context));
		string textParamValue3 = default(string);
		int num2 = default(int);
		while (true)
		{
			int num;
			if (!(obj is string returnResult))
			{
				textParamValue3 = XActionHelper.GetTextParamValue(_returnParam, step, context);
				num = 0;
				if (QVCtg5Q8JAa2ml5vg9tH == null)
				{
					goto IL_0083;
				}
				goto IL_00db;
			}
			context.ReturnResult = returnResult;
			goto IL_008b;
			IL_0173:
			context.StopAction(ActionStopFlag.ForceStop, "停止整个动作");
			break;
			IL_008b:
			if (!string.IsNullOrEmpty(textParamValue) && !(textParamValue == "default"))
			{
				if (!(textParamValue == "forcestop"))
				{
					break;
				}
				if (context.RootContext != null && context.RootContext != context)
				{
					num = 1;
					if (QVCtg5Q8JAa2ml5vg9tH != null)
					{
						num = num2;
					}
					goto IL_00db;
				}
				goto IL_0173;
			}
			try
			{
				context.ReturnError = booleanParamValue;
			}
			catch (Exception exception)
			{
				context.ReturnError = true;
				context.ReturnResult = "执行异常：" + exception.GetMessageWithInner();
			}
			context.ErrorMessage = context.ReturnResult;
			context.StopAction(ActionStopFlag.StopFromCode, "停止动作（默认）");
			break;
			IL_00db:
			switch (num)
			{
			case 2:
				continue;
			case 1:
				goto IL_0151;
			}
			goto IL_0083;
			IL_0151:
			context.RootContext.ReturnResult = context.ReturnResult;
			context.RootContext.ReturnResultObject = context.ReturnResultObject;
			goto IL_0173;
			IL_0083:
			context.ReturnResult = textParamValue3;
			goto IL_008b;
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(oeygwRNQS3w, step) + " (标记为出错：" + XActionHelper.GetParamDisplayString(_isErrorParam, step) + ")";
	}

	static StopActionStep()
	{
		oeygwRNQS3w = new StepInParamDef
		{
			Key = "method",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "default",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("default", "默认：停止动作或从子程序返回"),
				new SelectionItem("forcestop", "停止动作：停止整个动作(即使在子程序中)")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		_isErrorParam = new StepInParamDef
		{
			Key = "isError",
			Name = "标记为出错",
			Description = "用作子程序或被其他动作调用时，返回出错状态。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		_returnParam = new StepInParamDef
		{
			Key = "return",
			Name = "返回值",
			Description = "被其他动作调用时，返回的动作结果。",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		_showMessageParam = new StepInParamDef
		{
			Key = "showMessage",
			Name = "提示消息",
			Description = "显示的提示信息。",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
	}

	internal static bool gnGld1Q8k2LF5JtskBRC()
	{
		return QVCtg5Q8JAa2ml5vg9tH == null;
	}

	internal static void lRkmfBQ89BUV46GQ6rS1()
	{
	}
}
