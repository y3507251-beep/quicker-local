using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using c1g2QaYqqQIXXsN2NRs;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Texting;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class StringProcessStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public ActionStep ddvSgABq9aL;

		public ActionExecuteContext XmsSgODfJkD;

		public StringProcessStep gsNSgFAIqgf;

		public XAction kRkSgUuINDa;

		private static _003C_003Ec__DisplayClass56_0 Gi09SgW0F5Rt6ZouvoTo;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Ku3SgMK8ge2()
		{
			string textParamValue = XActionHelper.GetTextParamValue(IPAtzqQy5n4, ddvSgABq9aL, XmsSgODfJkD);
			string textParamValue2 = XActionHelper.GetTextParamValue(MYatzVNRZBS, ddvSgABq9aL, XmsSgODfJkD);
			string text = textParamValue;
			switch (textParamValue2.ToUpperInvariant())
			{
			case "REMOVE":
			{
				int int_4 = (int)XActionHelper.GetIntegerParamValue(UIUtzhP0UbB, ddvSgABq9aL, XmsSgODfJkD);
				int val = (int)XActionHelper.GetIntegerParamValue(fqetzYBkvsq, ddvSgABq9aL, XmsSgODfJkD);
				int_4 = H5wtzC7Q68k(textParamValue.Length, int_4);
				text = textParamValue.Remove(int_4, Math.Min(val, textParamValue.Length - int_4));
				break;
			}
			case "INSERT":
			{
				int int_3 = (int)XActionHelper.GetIntegerParamValue(UIUtzhP0UbB, ddvSgABq9aL, XmsSgODfJkD);
				string textParamValue7 = XActionHelper.GetTextParamValue(GMltzeHajWs, ddvSgABq9aL, XmsSgODfJkD);
				int_3 = H5wtzC7Q68k(textParamValue.Length, int_3);
				text = textParamValue.Insert(int_3, textParamValue7);
				break;
			}
			case "APPEND":
			{
				string textParamValue9 = XActionHelper.GetTextParamValue(GMltzeHajWs, ddvSgABq9aL, XmsSgODfJkD);
				text = textParamValue + textParamValue9;
				break;
			}
			case "PADLEFT":
			case "PADRIGHT":
			{
				int totalWidth = (int)XActionHelper.GetIntegerParamValue(M89tzIhZQo9, ddvSgABq9aL, XmsSgODfJkD);
				string textParamValue6 = XActionHelper.GetTextParamValue(l4ltzWPbV75, ddvSgABq9aL, XmsSgODfJkD);
				char paddingChar = ' ';
				if (!string.IsNullOrWhiteSpace(textParamValue6))
				{
					if (textParamValue6.Length != 1)
					{
						return (isSuccess: false, message: "填充字符只能有1个。", failReason: ActionStopFlag.OperationFailed);
					}
					paddingChar = textParamValue6[0];
				}
				text = ((!string.Equals(textParamValue2, "padleft", StringComparison.OrdinalIgnoreCase)) ? textParamValue.PadRight(totalWidth, paddingChar) : textParamValue.PadLeft(totalWidth, paddingChar));
				break;
			}
			case "URLENCODE":
			{
				string textParamValue8 = XActionHelper.GetTextParamValue(zoVtzZAaY27, ddvSgABq9aL, XmsSgODfJkD);
				text = ((!textParamValue8.EqualsAny(true, "", "utf8", "utf-8")) ? HttpUtility.UrlEncode(textParamValue, Encoding.GetEncoding(textParamValue8)) : textParamValue.EscapeUriDataString());
				break;
			}
			case "URLDECODE":
			{
				string textParamValue5 = XActionHelper.GetTextParamValue(zoVtzZAaY27, ddvSgABq9aL, XmsSgODfJkD);
				text = ((!string.IsNullOrEmpty(textParamValue5)) ? HttpUtility.UrlDecode(textParamValue, Encoding.GetEncoding(textParamValue5)) : HttpUtility.UrlDecode(textParamValue));
				break;
			}
			case "SUBSTRING":
			{
				int int_ = (int)XActionHelper.GetIntegerParamValue(UIUtzhP0UbB, ddvSgABq9aL, XmsSgODfJkD);
				int int_2 = (int)XActionHelper.GetIntegerParamValue(fqetzYBkvsq, ddvSgABq9aL, XmsSgODfJkD);
				text = gsNSgFAIqgf.ovotzP6PGjF(textParamValue, int_, int_2);
				break;
			}
			case "HTML2TEXT":
				text = gLHFbCYlOEuoKl12sik.ndHgQ1w05CP(textParamValue);
				break;
			case "URLDATAENCODE":
				text = textParamValue.EscapeUriDataString();
				break;
			case "URLDATADECODE":
				text = Uri.UnescapeDataString(textParamValue);
				break;
			case "CONVERTENCODING":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(zoVtzZAaY27, ddvSgABq9aL, XmsSgODfJkD);
				string textParamValue4 = XActionHelper.GetTextParamValue(bAVtz9GmKsX, ddvSgABq9aL, XmsSgODfJkD);
				text = EncodingConvert(textParamValue, textParamValue3, textParamValue4);
				break;
			}
			default:
				try
				{
					text = InternalTextProcessor.ProcessText(textParamValue2, textParamValue, "");
				}
				catch (Exception exception)
				{
					return (isSuccess: false, message: "文本处理出错(" + textParamValue2 + "):" + exception.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
				break;
			}
			XActionHelper.OutputResult(olltzHV7l2y, ddvSgABq9aL, XmsSgODfJkD, text, kRkSgUuINDa);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool Yq4OeqW0cjZyalkV1etu()
		{
			return Gi09SgW0F5Rt6ZouvoTo == null;
		}
	}

	private static readonly ILog xvAtzEbEm8l;

	private static List<string> eaitzyBpbc0;

	[CompilerGenerated]
	private readonly string kV0tz8AfoHC = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> lN2tza3Wjnu;

	[CompilerGenerated]
	private readonly string wxetz7vUFKC = "https://getquicker.net/KC/Help/Doc/stringprocess";

	[CompilerGenerated]
	private readonly bool DKLtzRLZPEG;

	private static readonly StepInParamDef IPAtzqQy5n4;

	private static List<SelectionItem> j6KtzcR4UkZ;

	private static readonly StepInParamDef MYatzVNRZBS;

	private static readonly StepInParamDef zoVtzZAaY27;

	private static readonly StepInParamDef bAVtz9GmKsX;

	private static readonly StepInParamDef UIUtzhP0UbB;

	private static readonly StepInParamDef GMltzeHajWs;

	private static readonly StepInParamDef fqetzYBkvsq;

	private static readonly StepInParamDef M89tzIhZQo9;

	private static readonly StepInParamDef l4ltzWPbV75;

	private static readonly StepInParamDef u4itzkRMJpq;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> SpZtzGQrej9 = new StepInParamDef[10] { IPAtzqQy5n4, MYatzVNRZBS, zoVtzZAaY27, bAVtz9GmKsX, UIUtzhP0UbB, GMltzeHajWs, fqetzYBkvsq, M89tzIhZQo9, l4ltzWPbV75, u4itzkRMJpq };

	private static readonly StepOutParamDef E3GtzsweJKW;

	private static readonly StepOutParamDef olltzHV7l2y;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Gdmtz1Gkmce = new StepOutParamDef[2] { olltzHV7l2y, E3GtzsweJKW };

	internal static StringProcessStep pPitEQQ8Fr2B4tqmrsFP;

	public string Key => "sys:stringProcess";

	public string Name => "文本处理";

	public IEnumerable<string> KeyWords => eaitzyBpbc0;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return kV0tz8AfoHC;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return lN2tza3Wjnu;
		}
	}

	public string Description => "各种文本处理功能";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return wxetz7vUFKC;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return DKLtzRLZPEG;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return SpZtzGQrej9;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Gdmtz1Gkmce;
		}
	}

	static StringProcessStep()
	{
		xvAtzEbEm8l = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		eaitzyBpbc0 = new List<string>();
		IPAtzqQy5n4 = new StepInParamDef
		{
			Key = "data",
			Name = "待处理内容",
			Description = "需要进行文本处理的内容",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		j6KtzcR4UkZ = new List<SelectionItem>
		{
			new SelectionItem("utf-8"),
			new SelectionItem("gbk"),
			new SelectionItem("gb2312"),
			new SelectionItem("big5"),
			new SelectionItem("utf-16"),
			new SelectionItem("utf-32")
		};
		MYatzVNRZBS = new StepInParamDef
		{
			Key = "method",
			Name = "处理",
			Description = "对文本进行什么处理",
			Type = VarType.Enum,
			DefaultValue = "",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("toUpper", "英文转大写"),
				new SelectionItem("toLower", "英文转小写"),
				new SelectionItem("reverse", "前后反转"),
				new SelectionItem("substring", "截取"),
				new SelectionItem("trimStart", "去除前面空白字符"),
				new SelectionItem("trimEnd", "去除后面空白字符"),
				new SelectionItem("trim", "去除前后空白字符"),
				new SelectionItem("urlEncode", "URL编码"),
				new SelectionItem("urlDecode", "URL解码 (+解码为空格)"),
				new SelectionItem("urlDataDecode", "URL数据解码 (保留+号)"),
				new SelectionItem("htmlEncode", "Html编码"),
				new SelectionItem("htmlDecode", "Html解码"),
				new SelectionItem("intercappedToSentence", "组合词拆分成句子(thisIsChina=>this Is China)"),
				new SelectionItem("base64Encode", "Base64编码"),
				new SelectionItem("base64Decode", "Base64解码"),
				new SelectionItem("removeEmptyLine", "去除空行"),
				new SelectionItem("mergeEmptyLine", "合并多个空行"),
				new SelectionItem("sortLinesAsc", "排序多行A-Z"),
				new SelectionItem("sortLinesDesc", "排序多行Z-A"),
				new SelectionItem("reverseLines", "翻转多行顺序"),
				new SelectionItem("toTitleCase", "首字母大写"),
				new SelectionItem("formatJson", "格式化JSON"),
				new SelectionItem("md5", "计算MD5哈希"),
				new SelectionItem("sha256Hash", "计算SHA256哈希"),
				new SelectionItem("sha1Hash", "计算SHA1哈希"),
				new SelectionItem("escapeJson", "转义文本为合法Json值"),
				new SelectionItem("DecodeUnicode", "解码Unicode字串(\\uXXXX转普通字符)"),
				new SelectionItem("convertEncoding", "转换编码"),
				new SelectionItem("toCnNum", "金额数字转换为大写"),
				new SelectionItem("cn2num", "中文转数字"),
				new SelectionItem("num2cn", "数字转中文"),
				new SelectionItem("ExpandEnvironmentVariables", "替换环境变量"),
				new SelectionItem("padLeft", "从左侧补齐长度"),
				new SelectionItem("padRight", "从右侧补齐长度"),
				new SelectionItem("insert", "插入内容"),
				new SelectionItem("append", "追加内容"),
				new SelectionItem("remove", "移除内容"),
				new SelectionItem("removeZeroWidthChars", "移除零宽字符"),
				new SelectionItem("html2text", "HTML转纯文本")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		zoVtzZAaY27 = new StepInParamDef
		{
			Key = "srcEncoding",
			Name = "编码",
			Type = VarType.Text,
			DefaultValue = "utf-8",
			ValidForList = new string[3] { "convertEncoding", "urlEncode", "urlDecode" },
			SelectionItems = j6KtzcR4UkZ
		};
		bAVtz9GmKsX = new StepInParamDef
		{
			Key = "dstEncoding",
			Name = "目标编码",
			Type = VarType.Text,
			DefaultValue = "gbk",
			ValidForList = new string[1] { "convertEncoding" },
			SelectionItems = j6KtzcR4UkZ
		};
		UIUtzhP0UbB = new StepInParamDef
		{
			Key = "start",
			Name = "开始位置",
			Description = "开始截取/插入位置，从0开始。如果为负值，表示从文本末尾开始向前的字符数。",
			DefaultValue = 0,
			Type = VarType.Integer,
			ValidForList = new string[3] { "substring", "insert", "remove" }
		};
		GMltzeHajWs = new StepInParamDef
		{
			Key = "value",
			Name = "内容",
			Description = "插入或追加的内容",
			DefaultValue = "",
			Type = VarType.Text,
			IsMultiLine = true,
			ValidForList = new string[2] { "insert", "append" }
		};
		fqetzYBkvsq = new StepInParamDef
		{
			Key = "length",
			Name = "长度",
			Description = "截取或移除字符个数。截取时，0表示开始位置以后的所有内容，负值表示截取到结束前的多少个字符。",
			DefaultValue = 0,
			Type = VarType.Integer,
			ValidForList = new string[2] { "substring", "remove" }
		};
		M89tzIhZQo9 = new StepInParamDef
		{
			Key = "totalWidth",
			Name = "总宽度",
			Description = "补齐后的总字符数",
			DefaultValue = 10,
			Type = VarType.Integer,
			ValidForList = new string[2] { "padLeft", "padRight" }
		};
		l4ltzWPbV75 = new StepInParamDef
		{
			Key = "paddingChar",
			Name = "填充字符",
			Description = "补齐时使用的填充字符，默认为空格。",
			DefaultValue = " ",
			Type = VarType.Text,
			ValidForList = new string[2] { "padLeft", "padRight" }
		};
		u4itzkRMJpq = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		E3GtzsweJKW = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		olltzHV7l2y = new StepOutParamDef
		{
			Key = "output",
			Name = "结果",
			Description = "处理后的文本",
			Type = VarType.Text
		};
		foreach (SelectionItem selectionItem in MYatzVNRZBS.SelectionItems)
		{
			eaitzyBpbc0.Add(selectionItem.Name);
			eaitzyBpbc0.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.ddvSgABq9aL = step;
		_003C_003Ec__DisplayClass56_.XmsSgODfJkD = context;
		_003C_003Ec__DisplayClass56_.gsNSgFAIqgf = this;
		_003C_003Ec__DisplayClass56_.kRkSgUuINDa = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass56_.XmsSgODfJkD, _003C_003Ec__DisplayClass56_.ddvSgABq9aL, _003C_003Ec__DisplayClass56_.kRkSgUuINDa, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass56_.Ku3SgMK8ge2, (Action)null, (Action)null, u4itzkRMJpq, E3GtzsweJKW);
	}

	private static int H5wtzC7Q68k(int int_0, int int_1)
	{
		if (int_1 < 0)
		{
			int_1 = int_0 + int_1;
		}
		if (int_1 < 0)
		{
			int_1 = 0;
		}
		if (int_1 > int_0 - 1)
		{
			int_1 = int_0 - 1;
		}
		return int_1;
	}

	private string ovotzP6PGjF(string string_2, int int_0, int int_1)
	{
		return string_2.SubStringByTextElements(int_0, int_1);
	}

	public static string EncodingConvert(string fromString, Encoding fromEncoding, Encoding toEncoding)
	{
		byte[] bytes = fromEncoding.GetBytes(fromString);
		return toEncoding.GetString(bytes);
	}

	public static string EncodingConvert(string fromString, string fromEncodingStr, string toEnocodingStr)
	{
		return EncodingConvert(fromString, Encoding.GetEncoding(fromEncodingStr), Encoding.GetEncoding(toEnocodingStr));
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(IPAtzqQy5n4, step) + " " + XActionHelper.GetParamDisplayString(MYatzVNRZBS, step) + " => " + XActionHelper.GetOutputParamDisplayString(olltzHV7l2y, step);
	}

	internal static bool qpwFF1Q8c2kut11obQaw()
	{
		return pPitEQQ8Fr2B4tqmrsFP == null;
	}

	internal static void wuY1I9Q8noWssyMVpghC()
	{
	}
}
