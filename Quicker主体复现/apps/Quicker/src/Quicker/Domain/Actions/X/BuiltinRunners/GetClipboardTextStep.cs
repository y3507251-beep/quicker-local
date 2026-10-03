using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using FontAwesome5;
using gNDpGkYZYbhLdMnAyKv;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetClipboardTextStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionStep W1DSgZS4DOf;

		public ActionExecuteContext U0YSg94uKmI;

		public XAction qWPSgh2acRO;

		internal static _003C_003Ec__DisplayClass47_0 taG6NXWGoySFf5U7Pv16;

		internal (bool isSuccess, string message, ActionStopFlag failReason) JcKSgVfpCCB()
		{
			_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_1();
			string textParamValue = XActionHelper.GetTextParamValue(Dnjt3mWaGiP, W1DSgZS4DOf, U0YSg94uKmI);
			_003C_003Ec__DisplayClass47_.jLISgIaCahr = string.Empty;
			int num = (int)XActionHelper.GetIntegerParamValue(Mmpt3rcsmfJ, W1DSgZS4DOf, U0YSg94uKmI);
			if (textParamValue == "Custom")
			{
				string text = XActionHelper.GetTextParamValue(Rvrt3KxEBE2, W1DSgZS4DOf, U0YSg94uKmI).Trim();
				if (string.IsNullOrEmpty(text))
				{
					return (isSuccess: false, message: "未指定自定义剪贴板格式名称。", failReason: ActionStopFlag.OperationFailed);
				}
				if (!kWsP1bYRVsfaicfjr67.fxRL5cZYrUS(text))
				{
					return (isSuccess: false, message: "剪贴板中没有指定格式(" + text + ")的内容。", failReason: ActionStopFlag.OperationFailed);
				}
				object obj = kWsP1bYRVsfaicfjr67.rjwL5IECtxV(text);
				if (obj is MemoryStream)
				{
					U0YSg94uKmI.ActionLogger?.LogInfo("剪贴板对象是MemoryStream");
					string textParamValue2 = XActionHelper.GetTextParamValue(Jqot3xILMt6, W1DSgZS4DOf, U0YSg94uKmI);
					Encoding encoding = Encoding.UTF8;
					if (!string.IsNullOrWhiteSpace(textParamValue2))
					{
						if (textParamValue2.Equals("default", StringComparison.OrdinalIgnoreCase))
						{
							encoding = Encoding.Default;
						}
						else
						{
							try
							{
								encoding = Encoding.GetEncoding(textParamValue2);
							}
							catch (Exception ex)
							{
								U0YSg94uKmI.ActionLogger?.LogWarning(CommonStrings.Common_Err_UnknownEncoding + textParamValue2 + ex.Message);
								encoding = Encoding.UTF8;
							}
						}
					}
					U0YSg94uKmI.ActionLogger?.LogInfo("使用编码类型 " + encoding.BodyName + " 解析剪贴板内容");
					_003C_003Ec__DisplayClass47_.jLISgIaCahr = encoding.GetString((obj as MemoryStream).ToArray());
				}
				else
				{
					_003C_003Ec__DisplayClass47_.jLISgIaCahr = obj.ToString();
				}
			}
			else
			{
				TextDataFormat result = TextDataFormat.UnicodeText;
				if (!string.IsNullOrWhiteSpace(textParamValue) && !Enum.TryParse<TextDataFormat>(textParamValue, out result))
				{
					result = TextDataFormat.UnicodeText;
				}
				if (result == TextDataFormat.UnicodeText)
				{
					_003C_003Ec__DisplayClass47_.jLISgIaCahr = ClipboardHelper2.GetUnicodeText();
					if (num > 0)
					{
						long num2 = AppHelper.fLiLTj0x4QY() + num;
						while (AppHelper.fLiLTj0x4QY() < num2 && string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_.jLISgIaCahr))
						{
							Thread.Sleep(10);
							_003C_003Ec__DisplayClass47_.jLISgIaCahr = ClipboardHelper2.GetUnicodeText();
						}
					}
				}
				else
				{
					_003C_003Ec__DisplayClass47_.jLISgIaCahr = ClipboardHelper.TryGetClipboardText(result);
					if (num > 0)
					{
						long num3 = AppHelper.fLiLTj0x4QY() + num;
						while (AppHelper.fLiLTj0x4QY() < num3 && string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_.jLISgIaCahr))
						{
							Thread.Sleep(10);
							_003C_003Ec__DisplayClass47_.jLISgIaCahr = ClipboardHelper.TryGetClipboardText(result);
						}
					}
				}
				if (result == TextDataFormat.Html)
				{
					XActionHelper.OutputResultIfNeeded(_cleanHtmlParam, _003C_003Ec__DisplayClass47_.YapSgeHYgR5, W1DSgZS4DOf, U0YSg94uKmI, qWPSgh2acRO);
					XActionHelper.OutputResultIfNeeded(_htmlDocParam, _003C_003Ec__DisplayClass47_.ty8SgYvajyX, W1DSgZS4DOf, U0YSg94uKmI, qWPSgh2acRO);
				}
			}
			if (XActionHelper.IsOutputParamSetted(FSVt3jNLLSO.Key, W1DSgZS4DOf))
			{
				string result2 = "";
				try
				{
					result2 = ClipboardHelper.GetClipboardUrl();
				}
				catch (Exception ex2)
				{
					U0YSg94uKmI.ActionLogger?.LogWarning("获取网址出错：" + ex2.Message);
				}
				XActionHelper.OutputResult(FSVt3jNLLSO, W1DSgZS4DOf, U0YSg94uKmI, result2, qWPSgh2acRO);
			}
			XActionHelper.OutputResult(n6ht3nJiYaL, W1DSgZS4DOf, U0YSg94uKmI, AppHelper.fLiLTj0x4QY() - AppState.LastClipboardChangeTime, qWPSgh2acRO);
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_.jLISgIaCahr))
			{
				return (isSuccess: false, message: CommonStrings.GetClipboardTextStep_Execute_NoData, failReason: ActionStopFlag.OperationFailed);
			}
			XActionHelper.OutputResult(eGjt3Qy8vR0, W1DSgZS4DOf, U0YSg94uKmI, _003C_003Ec__DisplayClass47_.jLISgIaCahr, qWPSgh2acRO);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool He0UdVWGfQykS4H6AO7A()
		{
			return taG6NXWGoySFf5U7Pv16 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		public string jLISgIaCahr;

		private static _003C_003Ec__DisplayClass47_1 uAqQIYWGqXovMNteVIiO;

		internal object YapSgeHYgR5()
		{
			return HtmlClipboardHelper.GetCleanHtml(jLISgIaCahr);
		}

		internal object ty8SgYvajyX()
		{
			return HtmlClipboardHelper.GetHtmlDoc(jLISgIaCahr);
		}

		internal static bool Eh8DvUWGiSEny1uJgRSS()
		{
			return uAqQIYWGqXovMNteVIiO == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> WqVt3HxPWPK = new string[5] { "剪贴板", "文本", "Text", "clipboard", "复制" };

	[CompilerGenerated]
	private readonly string oGjt314qv7f = $"fa:{EFontAwesomeIcon.Light_Clipboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> zRNt3bEMgr9 = new StepRunnerCategory[1] { StepRunnerCategory.Text };

	[CompilerGenerated]
	private readonly string Vudt36sBQCm = "https://getquicker.net/KC/Help/Doc/getClipboardText";

	[CompilerGenerated]
	private readonly bool gwJt3Xvs8EB;

	private static readonly StepInParamDef Dnjt3mWaGiP;

	private static readonly StepInParamDef Rvrt3KxEBE2;

	private static readonly StepInParamDef Jqot3xILMt6;

	private static readonly StepInParamDef Mmpt3rcsmfJ;

	private static readonly StepInParamDef ttkt3p77v24;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> ehBt3B6ZYbL = new StepInParamDef[5] { Dnjt3mWaGiP, Rvrt3KxEBE2, Jqot3xILMt6, Mmpt3rcsmfJ, ttkt3p77v24 };

	private static readonly StepOutParamDef eGjt3Qy8vR0;

	public static StepOutParamDef _cleanHtmlParam;

	public static StepOutParamDef _htmlDocParam;

	private static readonly StepOutParamDef FSVt3jNLLSO;

	private static readonly StepOutParamDef n6ht3nJiYaL;

	private static readonly StepOutParamDef sVAt34TBiBc;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> iast35SsoOt = new StepOutParamDef[6] { sVAt34TBiBc, eGjt3Qy8vR0, _cleanHtmlParam, _htmlDocParam, FSVt3jNLLSO, n6ht3nJiYaL };

	private static GetClipboardTextStep JpMWW4Q57YDWiOZlh4Qt;

	public string Key => "sys:getClipboardText";

	public string Name => CommonStrings.GetClipboardTextStep_Name;

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return WqVt3HxPWPK;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return oGjt314qv7f;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Clipboard;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return zRNt3bEMgr9;
		}
	}

	public string Description => CommonStrings.GetClipboardTextStep_Description;

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return Vudt36sBQCm;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return gwJt3Xvs8EB;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return ehBt3B6ZYbL;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return iast35SsoOt;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.W1DSgZS4DOf = step;
		_003C_003Ec__DisplayClass47_.U0YSg94uKmI = context;
		_003C_003Ec__DisplayClass47_.qWPSgh2acRO = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass47_.U0YSg94uKmI, _003C_003Ec__DisplayClass47_.W1DSgZS4DOf, _003C_003Ec__DisplayClass47_.qWPSgh2acRO, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass47_.JcKSgVfpCCB, (Action)null, (Action)null, ttkt3p77v24, sVAt34TBiBc);
	}

	public string GetSummary(ActionStep step)
	{
		return "=> " + XActionHelper.GetOutputParamDisplayString(eGjt3Qy8vR0, step);
	}

	static GetClipboardTextStep()
	{
		Dnjt3mWaGiP = new StepInParamDef
		{
			Key = "format",
			Name = CommonStrings.GetClipboardTextStep_TxtFormatParam_Name,
			DefaultValue = "UnicodeText",
			Description = CommonStrings.GetClipboardTextStep_TxtFormatParam_Desc,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("UnicodeText", CommonStrings.GetClipboardTextStep_Format_UnicodeText),
				new SelectionItem("Rtf"),
				new SelectionItem("Html"),
				new SelectionItem("CommaSeparatedValue", CommonStrings.GetClipboardTextStep_Format_CommaSeparatedValue),
				new SelectionItem("Custom", "自定义格式名")
			},
			IsControlField = true
		};
		Rvrt3KxEBE2 = new StepInParamDef
		{
			Key = "customFormat",
			Name = "格式名称",
			Description = "自定义的剪贴板格式名，请和实际剪贴板格式名一致。只支持实际为文本类型的内容。",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Text,
			IsMultiLine = false,
			ValidForList = new List<string> { "Custom" }
		};
		Jqot3xILMt6 = new StepInParamDef
		{
			Key = "encoding",
			Name = "文本编码",
			Description = "读取自定义格式时候使用的编码类型",
			DefaultValue = Encoding.UTF8.WebName,
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(Encoding.UTF8.WebName, "UTF8"),
				new SelectionItem(Encoding.Unicode.WebName, "UTF-16 LE"),
				new SelectionItem(Encoding.BigEndianUnicode.WebName, "UTF-16 BE"),
				new SelectionItem(Encoding.ASCII.WebName, "ASCII"),
				new SelectionItem(Encoding.UTF7.WebName, "UTF7"),
				new SelectionItem(Encoding.UTF32.WebName, "UTF32"),
				new SelectionItem("default", "系统默认(" + Encoding.Default.WebName + ")")
			},
			ValidForList = new List<string> { "Custom" }
		};
		Mmpt3rcsmfJ = new StepInParamDef
		{
			Key = "waitMs",
			Name = "重试时间",
			DefaultValue = 400,
			Description = "每10ms重试一次，直到获取到文本。为0时不重试。",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		ttkt3p77v24 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = CommonStrings.GetClipboardTextStep_StopIfEmptyParam_Name,
			DefaultValue = true,
			Description = CommonStrings.GetClipboardTextStep_StopIfEmptyParam_Desc,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		eGjt3Qy8vR0 = new StepOutParamDef
		{
			Key = "output",
			Name = "完整结果内容",
			Description = CommonStrings.GetClipboardTextStep_OutputParam_Desc,
			Type = VarType.Text
		};
		_cleanHtmlParam = new StepOutParamDef
		{
			Key = "cleanHtml",
			Name = "主要HTML片段",
			Description = "HTML的主要内容。<!--StartFragment-->和<!--EndFragment-->之间的部分",
			Type = VarType.Text,
			ValidForList = new string[1] { "Html" }
		};
		_htmlDocParam = new StepOutParamDef
		{
			Key = "htmlDoc",
			Name = "完整的HTML文档",
			Description = "仅去除剪贴板头部信息的完整HTML文档内容。包含<html>等标签，可直接保存为.html文件。",
			Type = VarType.Text,
			ValidForList = new string[1] { "Html" }
		};
		FSVt3jNLLSO = new StepOutParamDef
		{
			Key = "url",
			Name = "来源网址",
			Description = "从网页中复制内容时，可能会携带网址信息。",
			Type = VarType.Text
		};
		n6ht3nJiYaL = new StepOutParamDef
		{
			Key = "elapsedMs",
			Name = "已更新时间",
			Description = "剪贴板最后更新是在多少毫秒以前",
			Type = VarType.Integer
		};
		sVAt34TBiBc = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = CommonStrings.GetClipboardTextStep_SuccessParam_Name,
			Description = CommonStrings.GetClipboardTextStep_SuccessParam_Desc,
			Type = VarType.Boolean
		};
	}

	internal static bool Ix3WfMQ54pneZZwAN4o7()
	{
		return JpMWW4Q57YDWiOZlh4Qt == null;
	}

	internal static void xtjtISQ5HAXai88YEBj8()
	{
	}
}
