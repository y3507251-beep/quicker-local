using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using FontAwesome5;
using Quicker.Common;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetSelectedTextStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionStep YqYSgHllEgA;

		public ActionExecuteContext k8iSg13ln23;

		public XAction K9bSgby9AUG;

		internal static _003C_003Ec__DisplayClass47_0 BBnhHvWG8NA5ljZpjmqc;

		internal (bool isSuccess, string message, ActionStopFlag failReason) zUvSgs757X8()
		{
			_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_1();
			int waitMs = (int)XActionHelper.GetIntegerParamValue(lwBtf0AOess, YqYSgHllEgA, k8iSg13ln23);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(pj8tfEjN15L, YqYSgHllEgA, k8iSg13ln23);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(iNTtfPHRxUg, YqYSgHllEgA, k8iSg13ln23);
			_003C_003Ec__DisplayClass47_.CbpSgX3YTUm = "";
			if (booleanParamValue && !string.IsNullOrEmpty(k8iSg13ln23.InputParam))
			{
				k8iSg13ln23.ActionLogger.LogInfo("使用动作参数作为获取的内容！");
				_003C_003Ec__DisplayClass47_.CbpSgX3YTUm = k8iSg13ln23.InputParam;
				ttVtfL2dfdL(YqYSgHllEgA, k8iSg13ln23, K9bSgby9AUG, _003C_003Ec__DisplayClass47_.CbpSgX3YTUm);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			long num = XActionHelper.GetIntegerParamValue(eQStfCBRc4y, YqYSgHllEgA, k8iSg13ln23);
			if (num < 0L)
			{
				num = 0L;
			}
			string textParamValue = XActionHelper.GetTextParamValue(JhntfJUmBwI, YqYSgHllEgA, k8iSg13ln23);
			TextDataFormat result = TextDataFormat.UnicodeText;
			if (!string.IsNullOrWhiteSpace(textParamValue) && !Enum.TryParse<TextDataFormat>(textParamValue, out result))
			{
				result = TextDataFormat.UnicodeText;
			}
			if (result == TextDataFormat.UnicodeText)
			{
				ActionAssociation association = k8iSg13ln23.Action.Association;
				if (association != null && association.IsTextProcessor)
				{
					ActionAssociation association2 = k8iSg13ln23.Action.Association;
					if (association2 != null && association2.ReturnTextFromGetSelectedTextStep && !string.IsNullOrEmpty(k8iSg13ln23.ExtraData?.Text))
					{
						k8iSg13ln23.ActionLogger.LogInfo("返回了上下文文本内容");
						_003C_003Ec__DisplayClass47_.CbpSgX3YTUm = k8iSg13ln23.ExtraData?.Text;
						ttVtfL2dfdL(YqYSgHllEgA, k8iSg13ln23, K9bSgby9AUG, _003C_003Ec__DisplayClass47_.CbpSgX3YTUm);
						return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
					}
				}
			}
			try
			{
				_003C_003Ec__DisplayClass47_.CbpSgX3YTUm = AppHelper.GetSelectedText(num, result, waitMs, booleanParamValue2);
				if (result == TextDataFormat.Html)
				{
					XActionHelper.OutputResultIfNeeded(_cleanHtmlParam, _003C_003Ec__DisplayClass47_.uytSg67Bix1, YqYSgHllEgA, k8iSg13ln23, K9bSgby9AUG);
				}
			}
			catch (Exception)
			{
				return (isSuccess: false, message: "获取选中文本失败了。请确认目标位置具有焦点并支持Ctrl+C复制。", failReason: ActionStopFlag.OperationFailed);
			}
			if (XActionHelper.IsOutputParamSetted(dXytf7btnQN.Key, YqYSgHllEgA))
			{
				string result2 = "";
				try
				{
					result2 = ClipboardHelper.GetClipboardUrl();
				}
				catch (Exception ex2)
				{
					k8iSg13ln23.ActionLogger.LogWarning("获取网址出错：" + ex2.Message);
				}
				XActionHelper.OutputResult(dXytf7btnQN, YqYSgHllEgA, k8iSg13ln23, result2, K9bSgby9AUG);
			}
			ttVtfL2dfdL(YqYSgHllEgA, k8iSg13ln23, K9bSgby9AUG, _003C_003Ec__DisplayClass47_.CbpSgX3YTUm);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void lS1AI5WGP8FkxvP8OG6H()
		{
		}

		internal static bool Nvy7ovWGRHB94b6UqZfg()
		{
			return BBnhHvWG8NA5ljZpjmqc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		public string CbpSgX3YTUm;

		private static _003C_003Ec__DisplayClass47_1 BQU9YuWGMAFMr8xbcCJs;

		internal object uytSg67Bix1()
		{
			return HtmlClipboardHelper.GetCleanHtml(CbpSgX3YTUm);
		}

		internal static bool enSEqnWGUhFD8cfKtvCJ()
		{
			return BQU9YuWGMAFMr8xbcCJs == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> lk8tfvwkMnu = new string[5] { "文本", "选择", "text", "selected", "获取选择的文本" };

	[CompilerGenerated]
	private readonly string ruptfS985eB = $"fa:{EFontAwesomeIcon.Light_ICursor}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> lgatf2wMHvB = new StepRunnerCategory[1] { StepRunnerCategory.Text };

	[CompilerGenerated]
	private readonly string gW3tfu50PNx = "https://getquicker.net/KC/Help/Doc/get_selected_text";

	[CompilerGenerated]
	private readonly bool hADtfN3b9MH;

	private static readonly StepInParamDef JhntfJUmBwI;

	private static readonly StepInParamDef lwBtf0AOess;

	private static readonly StepInParamDef eQStfCBRc4y;

	private static readonly StepInParamDef iNTtfPHRxUg;

	private static readonly StepInParamDef pj8tfEjN15L;

	private static readonly StepInParamDef m8ntfy66W1q;

	private static readonly StepInParamDef RV2tf8eIwiA;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> epStfa9irG1 = new StepInParamDef[7] { JhntfJUmBwI, lwBtf0AOess, eQStfCBRc4y, m8ntfy66W1q, iNTtfPHRxUg, pj8tfEjN15L, RV2tf8eIwiA };

	public static StepOutParamDef _outputParam;

	public static StepOutParamDef _cleanHtmlParam;

	public static StepOutParamDef _outputUrlEncodedParam;

	private static readonly StepOutParamDef dXytf7btnQN;

	private static readonly StepOutParamDef tsotfR9yyCg;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> hoFtfqZMKRx = new StepOutParamDef[5] { tsotfR9yyCg, _outputParam, _cleanHtmlParam, _outputUrlEncodedParam, dXytf7btnQN };

	internal static GetSelectedTextStep RVmJ74QY1RlH8RDHojFP;

	public string Key => "sys:getSelectedText";

	public string Name => "获取选中的文本";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return lk8tfvwkMnu;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ruptfS985eB;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return lgatf2wMHvB;
		}
	}

	public string Description => "获取选中的文字";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return gW3tfu50PNx;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return hADtfN3b9MH;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return epStfa9irG1;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return hoFtfqZMKRx;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.YqYSgHllEgA = step;
		_003C_003Ec__DisplayClass47_.k8iSg13ln23 = context;
		_003C_003Ec__DisplayClass47_.K9bSgby9AUG = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass47_.k8iSg13ln23, _003C_003Ec__DisplayClass47_.YqYSgHllEgA, _003C_003Ec__DisplayClass47_.K9bSgby9AUG, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass47_.zUvSgs757X8, (Action)null, (Action)null, RV2tf8eIwiA, tsotfR9yyCg);
	}

	private static void ttVtfL2dfdL(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		if (XActionHelper.GetBooleanParamValue(m8ntfy66W1q, actionStep_0, actionExecuteContext_0))
		{
			string_2 = string_2.Trim();
		}
		XActionHelper.OutputResult(_outputParam, actionStep_0, actionExecuteContext_0, string_2, xaction_0);
		if (XActionHelper.IsOutputParamSetted(_outputUrlEncodedParam.Key, actionStep_0))
		{
			XActionHelper.OutputResult(_outputUrlEncodedParam, actionStep_0, actionExecuteContext_0, Uri.EscapeDataString(string_2), xaction_0);
		}
	}

	public string GetSummary(ActionStep step)
	{
		return "=> " + XActionHelper.GetOutputParamDisplayString(_outputParam, step) + " " + XActionHelper.GetOutputParamDisplayString(_outputUrlEncodedParam, step);
	}

	static GetSelectedTextStep()
	{
		JhntfJUmBwI = new StepInParamDef
		{
			Key = "format",
			Name = "文本数据格式",
			DefaultValue = "UnicodeText",
			Description = "需要读取的剪贴板文本内容格式。通常请使用Unicode纯文本格式。",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("UnicodeText", "纯文本（默认）"),
				new SelectionItem("Rtf"),
				new SelectionItem("Html"),
				new SelectionItem("CommaSeparatedValue", "逗号分隔的值（csv）")
			},
			IsControlField = true
		};
		lwBtf0AOess = new StepInParamDef
		{
			Key = "waitMs",
			Name = "等待剪贴板时间",
			DefaultValue = 250,
			Description = "模拟复制键后，等待剪贴板变化的最长时间毫秒数。",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		eQStfCBRc4y = new StepInParamDef
		{
			Key = "repeat",
			Name = "重试次数",
			DefaultValue = 0,
			Description = "【已过时，仅为兼容性保留】失败后重试的次数。",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.Input
		};
		iNTtfPHRxUg = new StepInParamDef
		{
			Key = "tryNoClipboard",
			Name = "尝试不通过剪贴板的方式获取",
			DefaultValue = false,
			Description = "通过UIAutomation方式获取（某些情况可能出现无法完整获取文字、失去换行信息等问题）",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		pj8tfEjN15L = new StepInParamDef
		{
			Key = "useActionParam",
			Name = "如果为动作传递了参数，使用参数值作为获取的结果",
			DefaultValue = false,
			Description = "没有传递参数时仍尝试获取选中的文本。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		m8ntfy66W1q = new StepInParamDef
		{
			Key = "trim",
			Name = "去除前后的空白",
			DefaultValue = false,
			Description = "去除内容前后的空白（包括空行）。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		RV2tf8eIwiA = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "获取选中的文本失败后，是否停止后续动作的执行。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		_outputParam = new StepOutParamDef
		{
			Key = "output",
			Name = "内容",
			Description = "将获得的文本写入到变量",
			Type = VarType.Text
		};
		_cleanHtmlParam = new StepOutParamDef
		{
			Key = "cleanHtml",
			Name = "去除封装的HTML",
			Description = "剪贴板HTML的主要内容<!--StartFragment-->和<!--EndFragment-->之间的部分",
			Type = VarType.Text,
			ValidForList = new string[1] { "Html" }
		};
		_outputUrlEncodedParam = new StepOutParamDef
		{
			Key = "outputEncoded",
			Name = "URL编码的内容",
			Description = "对选中的内容进行URL编码处理后的结果，通常用于拼接网址。",
			Type = VarType.Text
		};
		dXytf7btnQN = new StepOutParamDef
		{
			Key = "url",
			Name = "来源网址",
			Description = "从网页中复制内容时，可能会携带网址信息。",
			Type = VarType.Text
		};
		tsotfR9yyCg = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功获取了文本",
			Type = VarType.Boolean
		};
	}

	internal static bool lrUKRYQYKDLV3i812JLa()
	{
		return RVmJ74QY1RlH8RDHojFP == null;
	}
}
