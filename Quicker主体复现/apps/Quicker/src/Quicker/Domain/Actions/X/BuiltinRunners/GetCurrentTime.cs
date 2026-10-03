using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetCurrentTime : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_0
	{
		public ActionStep tjjSvLx0cf9;

		public ActionExecuteContext y96SvvG1mIO;

		public XAction ojPSvSkwDql;

		private static _003C_003Ec__DisplayClass67_0 tlyVFmW0PxFkKrfAJ0Lk;

		internal (bool isSuccess, string message, ActionStopFlag failReason) jRkSvgbB8Nt()
		{
			DateTime dateTime = DateTime.MinValue;
			string textParamValue = XActionHelper.GetTextParamValue(I6Lgwz6MHhC, tjjSvLx0cf9, y96SvvG1mIO);
			if (string.IsNullOrEmpty(textParamValue))
			{
				goto IL_01fa;
			}
			switch (textParamValue)
			{
			case "fromString":
				break;
			case "fromVar":
				dateTime = (DateTime)XActionHelper.GetParamValue(sn8gtvJmHyG, tjjSvLx0cf9, y96SvvG1mIO);
				goto IL_021f;
			case "fromUnixTimeStamp":
			case "Source_UnixTimeStampMs":
				goto IL_0164;
			case "currTime":
				goto IL_01fa;
			default:
				goto IL_021f;
			}
			string textParamValue2 = XActionHelper.GetTextParamValue(AxDgttVsXDf, tjjSvLx0cf9, y96SvvG1mIO);
			if (string.IsNullOrEmpty(textParamValue2))
			{
				return (isSuccess: false, message: "要转换为时间的值为空。", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue3 = XActionHelper.GetTextParamValue(BNJgtg2AQ6l, tjjSvLx0cf9, y96SvvG1mIO);
			string textParamValue4 = XActionHelper.GetTextParamValue(KqfgtLgXXWi, tjjSvLx0cf9, y96SvvG1mIO);
			CultureInfo provider = CultureInfo.CurrentCulture;
			if (!string.IsNullOrEmpty(textParamValue4) && textParamValue4 != "CURRENT")
			{
				provider = new CultureInfo(textParamValue4);
			}
			dateTime = (string.IsNullOrEmpty(textParamValue3) ? DateTime.Parse(textParamValue2, provider) : DateTime.ParseExact(textParamValue2, textParamValue3, provider));
			if (XActionHelper.GetBooleanParamValue(KZ6gtwPNYwK, tjjSvLx0cf9, y96SvvG1mIO))
			{
				dateTime = dateTime.ToUniversalTime();
			}
			goto IL_021f;
			IL_021f:
			double value = Convert.ToDouble(XActionHelper.GetNumberParamValue(txWgt2tmpcG, tjjSvLx0cf9, y96SvvG1mIO));
			if (Math.Abs(value) > 0.0001)
			{
				dateTime = dateTime.AddDays(value);
			}
			double value2 = Convert.ToDouble(XActionHelper.GetNumberParamValue(SL3gtu8wPdD, tjjSvLx0cf9, y96SvvG1mIO));
			if (Math.Abs(value2) > 0.0001)
			{
				dateTime = dateTime.AddHours(value2);
			}
			double value3 = Convert.ToDouble(XActionHelper.GetNumberParamValue(Hk7gtNTYUyF, tjjSvLx0cf9, y96SvvG1mIO));
			if (Math.Abs(value3) > 0.0001)
			{
				dateTime = dateTime.AddMinutes(value3);
			}
			double value4 = Convert.ToDouble(XActionHelper.GetNumberParamValue(mm9gtJAlNE7, tjjSvLx0cf9, y96SvvG1mIO));
			if (Math.Abs(value4) > 0.0001)
			{
				dateTime = dateTime.AddSeconds(value4);
			}
			int months = Convert.ToInt32(XActionHelper.GetNumberParamValue(Aglgt0EixSC, tjjSvLx0cf9, y96SvvG1mIO));
			dateTime = dateTime.AddMonths(months);
			string text = XActionHelper.GetTextParamValue(fMWgtCjJLX5, tjjSvLx0cf9, y96SvvG1mIO);
			if (string.IsNullOrEmpty(text))
			{
				text = "yyyy-MM-dd HH:mm:ss";
			}
			XActionHelper.OutputResult(beogt84nJUR, tjjSvLx0cf9, y96SvvG1mIO, dateTime, ojPSvSkwDql);
			string textParamValue5 = XActionHelper.GetTextParamValue(hjhgtPcPEEU, tjjSvLx0cf9, y96SvvG1mIO);
			CultureInfo cultureInfo = CultureInfo.CurrentCulture;
			if (!string.IsNullOrEmpty(textParamValue5) && textParamValue5 != "CURRENT")
			{
				cultureInfo = new CultureInfo(textParamValue5);
			}
			string result = dateTime.ToString(text, cultureInfo);
			XActionHelper.OutputResult(ssCgtaj3UTI, tjjSvLx0cf9, y96SvvG1mIO, result, ojPSvSkwDql);
			TimeSpan timeSpan = dateTime.Subtract(new DateTime(1970, 1, 1));
			XActionHelper.OutputResult(Qlvgt7Mronx, tjjSvLx0cf9, y96SvvG1mIO, (long)timeSpan.TotalSeconds, ojPSvSkwDql);
			XActionHelper.OutputResult(NrcgtRVAZNW, tjjSvLx0cf9, y96SvvG1mIO, (long)timeSpan.TotalMilliseconds, ojPSvSkwDql);
			XActionHelper.OutputResult(aebgtqaeIqo, tjjSvLx0cf9, y96SvvG1mIO, dateTime.Year, ojPSvSkwDql);
			XActionHelper.OutputResult(zCSgtcRpxJI, tjjSvLx0cf9, y96SvvG1mIO, dateTime.Month, ojPSvSkwDql);
			XActionHelper.OutputResult(mpTgtVflHDF, tjjSvLx0cf9, y96SvvG1mIO, dateTime.Day, ojPSvSkwDql);
			XActionHelper.OutputResult(VYggtZdTy59, tjjSvLx0cf9, y96SvvG1mIO, dateTime.Hour, ojPSvSkwDql);
			XActionHelper.OutputResult(eHbgt9xGnWu, tjjSvLx0cf9, y96SvvG1mIO, dateTime.Minute, ojPSvSkwDql);
			XActionHelper.OutputResult(PjHgthj21tV, tjjSvLx0cf9, y96SvvG1mIO, dateTime.Second, ojPSvSkwDql);
			XActionHelper.OutputResult(Wq5gteyVFxF, tjjSvLx0cf9, y96SvvG1mIO, (int)dateTime.DayOfWeek, ojPSvSkwDql);
			XActionHelper.OutputResult(rV8gtY1yExM, tjjSvLx0cf9, y96SvvG1mIO, dateTime.DayOfYear, ojPSvSkwDql);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			IL_01fa:
			dateTime = (XActionHelper.GetBooleanParamValue(KZ6gtwPNYwK, tjjSvLx0cf9, y96SvvG1mIO) ? DateTime.UtcNow : DateTime.Now);
			goto IL_021f;
			IL_0164:
			string textParamValue6 = XActionHelper.GetTextParamValue(TFQgtSgAws8, tjjSvLx0cf9, y96SvvG1mIO);
			if (string.IsNullOrEmpty(textParamValue6))
			{
				return (isSuccess: false, message: "要转换为时间的值为空。", failReason: ActionStopFlag.OperationFailed);
			}
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(KZ6gtwPNYwK, tjjSvLx0cf9, y96SvvG1mIO);
			DateTimeOffset dateTimeOffset = ((textParamValue == "fromUnixTimeStamp") ? DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(textParamValue6, CultureInfo.InvariantCulture)) : DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(textParamValue6, CultureInfo.InvariantCulture)));
			dateTime = ((!booleanParamValue) ? dateTimeOffset.DateTime : dateTimeOffset.UtcDateTime.ToLocalTime());
			goto IL_021f;
		}

		internal static bool H6vGgCW0MBfkYLhDU0xh()
		{
			return tlyVFmW0PxFkKrfAJ0Lk == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> hi2gwUw6jwo = new string[5] { "当前时间", "riqi", "date", "time", "utc" };

	[CompilerGenerated]
	private readonly string fGTgwli5Vbf = $"fa:{EFontAwesomeIcon.Light_Clock}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> RiLgwiFhd8a = new StepRunnerCategory[1] { StepRunnerCategory.Compute };

	[CompilerGenerated]
	private readonly string f9Sgw3gwBA4 = "https://getquicker.net/KC/Help/Doc/gettime";

	[CompilerGenerated]
	private readonly bool IUxgwfT6Glh;

	private static readonly StepInParamDef I6Lgwz6MHhC;

	private static readonly StepInParamDef KZ6gtwPNYwK;

	private static readonly StepInParamDef AxDgttVsXDf;

	private static readonly StepInParamDef BNJgtg2AQ6l;

	private static readonly StepInParamDef KqfgtLgXXWi;

	private static readonly StepInParamDef sn8gtvJmHyG;

	private static readonly StepInParamDef TFQgtSgAws8;

	private static readonly StepInParamDef txWgt2tmpcG;

	private static readonly StepInParamDef SL3gtu8wPdD;

	private static readonly StepInParamDef Hk7gtNTYUyF;

	private static readonly StepInParamDef mm9gtJAlNE7;

	private static readonly StepInParamDef Aglgt0EixSC;

	private static readonly StepInParamDef fMWgtCjJLX5;

	private static readonly StepInParamDef hjhgtPcPEEU;

	private static readonly StepInParamDef QxxgtEANAjU;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> QSlgty6vbUL = new StepInParamDef[15]
	{
		I6Lgwz6MHhC, KZ6gtwPNYwK, AxDgttVsXDf, KqfgtLgXXWi, BNJgtg2AQ6l, sn8gtvJmHyG, TFQgtSgAws8, txWgt2tmpcG, SL3gtu8wPdD, Hk7gtNTYUyF,
		mm9gtJAlNE7, Aglgt0EixSC, fMWgtCjJLX5, hjhgtPcPEEU, QxxgtEANAjU
	};

	private static readonly StepOutParamDef beogt84nJUR;

	private static readonly StepOutParamDef ssCgtaj3UTI;

	private static readonly StepOutParamDef Qlvgt7Mronx;

	private static readonly StepOutParamDef NrcgtRVAZNW;

	private static readonly StepOutParamDef aebgtqaeIqo;

	private static readonly StepOutParamDef zCSgtcRpxJI;

	private static readonly StepOutParamDef mpTgtVflHDF;

	private static readonly StepOutParamDef VYggtZdTy59;

	private static readonly StepOutParamDef eHbgt9xGnWu;

	private static readonly StepOutParamDef PjHgthj21tV;

	private static readonly StepOutParamDef Wq5gteyVFxF;

	private static readonly StepOutParamDef rV8gtY1yExM;

	private static readonly StepOutParamDef BPggtILcPQG;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> eDZgtWJI7uZ = new StepOutParamDef[13]
	{
		BPggtILcPQG, beogt84nJUR, ssCgtaj3UTI, Qlvgt7Mronx, NrcgtRVAZNW, aebgtqaeIqo, zCSgtcRpxJI, mpTgtVflHDF, VYggtZdTy59, eHbgt9xGnWu,
		PjHgthj21tV, Wq5gteyVFxF, rV8gtY1yExM
	};

	internal static GetCurrentTime bf9PnuQ8I1uEu6l9Hu0A;

	public string Key => "sys:getCurrentTime";

	public string Name => "获取日期时间";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return hi2gwUw6jwo;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return fGTgwli5Vbf;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return RiLgwiFhd8a;
		}
	}

	public string Description => "获取当前或从文本、unix时间戳转换日期时间";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return f9Sgw3gwBA4;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return IUxgwfT6Glh;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return QSlgty6vbUL;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return eDZgtWJI7uZ;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
		_003C_003Ec__DisplayClass67_.tjjSvLx0cf9 = step;
		_003C_003Ec__DisplayClass67_.y96SvvG1mIO = context;
		_003C_003Ec__DisplayClass67_.ojPSvSkwDql = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass67_.y96SvvG1mIO, _003C_003Ec__DisplayClass67_.tjjSvLx0cf9, _003C_003Ec__DisplayClass67_.ojPSvSkwDql, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass67_.jRkSvgbB8Nt, (Action)null, (Action)null, QxxgtEANAjU, BPggtILcPQG);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(I6Lgwz6MHhC, step) ?? "";
	}

	static GetCurrentTime()
	{
		I6Lgwz6MHhC = new StepInParamDef
		{
			Key = "source",
			Name = "时间来源",
			DefaultValue = "currTime",
			Description = "时间数据来源",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("currTime", "当前时间"),
				new SelectionItem("fromString", "从文本转换"),
				new SelectionItem("fromUnixTimeStamp", "从Unix时间戳转换(秒)"),
				new SelectionItem("Source_UnixTimeStampMs", "从Unix时间戳转换(毫秒)"),
				new SelectionItem("fromVar", "时间变量")
			},
			IsControlField = true
		};
		KZ6gtwPNYwK = new StepInParamDef
		{
			Key = "useUtc",
			Name = "使用UTC时间",
			DefaultValue = false,
			Description = "是表示使用UTC时间，否表示使用本地时间（电脑的当前时间）。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "currTime", "fromString", "fromUnixTimeStamp", "Source_UnixTimeStampMs" }
		};
		AxDgttVsXDf = new StepInParamDef
		{
			Key = "timeStr",
			Name = "待解析文本",
			DefaultValue = "",
			Description = "待转换为时间值的文本",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "fromString" }
		};
		BNJgtg2AQ6l = new StepInParamDef
		{
			Key = "inputFormat",
			Name = "数据格式",
			DefaultValue = "",
			Description = "可选，待解析文本的数据格式，如yyyy表示4位数年份，MM表示2位数月份等。详情请参考文档。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "fromString" }
		};
		KqfgtLgXXWi = new StepInParamDef
		{
			Key = "inputCulture",
			Name = "语言文化",
			DefaultValue = "CURRENT",
			Description = "可选，待解析文本的语言文化。如zh-CN表示中文简体，en-US表示英文美国等。详情请参考文档。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "fromString" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("CURRENT", "当前系统语言"),
				new SelectionItem("zh-CN"),
				new SelectionItem("en-US"),
				new SelectionItem("ja-JP"),
				new SelectionItem("ko-KR"),
				new SelectionItem("fr-FR"),
				new SelectionItem("de-DE"),
				new SelectionItem("es-ES"),
				new SelectionItem("it-IT"),
				new SelectionItem("ru-RU"),
				new SelectionItem("pt-BR")
			}
		};
		sn8gtvJmHyG = new StepInParamDef
		{
			Key = "timeVar",
			Name = "时间变量",
			DefaultValue = "",
			Description = "时间变量",
			Type = VarType.DateTime,
			VariableMode = ParamVariableMode.UseVarOnly,
			ValidForList = new List<string> { "fromVar" }
		};
		TFQgtSgAws8 = new StepInParamDef
		{
			Key = "timeStampStr",
			Name = "Unix时间戳值",
			DefaultValue = "",
			Description = "从1970年1月1日开始所经过的秒数或毫秒数。根据需要开启或关闭使用UTC时间选项。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "fromUnixTimeStamp", "Source_UnixTimeStampMs" }
		};
		txWgt2tmpcG = new StepInParamDef
		{
			Key = "addDays",
			Name = "添加天数",
			DefaultValue = 0,
			Description = "添加指定的天数（可以为小数/负数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		SL3gtu8wPdD = new StepInParamDef
		{
			Key = "addHours",
			Name = "添加小时数",
			DefaultValue = 0,
			Description = "添加指定的小时数（可以为小数/负数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Hk7gtNTYUyF = new StepInParamDef
		{
			Key = "addMinutes",
			Name = "添加分钟数",
			DefaultValue = 0,
			Description = "添加指定的分钟数（可以为小数/负数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		mm9gtJAlNE7 = new StepInParamDef
		{
			Key = "addSeconds",
			Name = "添加秒数",
			DefaultValue = 0,
			Description = "添加指定的秒数（可以为小数/负数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Aglgt0EixSC = new StepInParamDef
		{
			Key = "addMonths",
			Name = "添加月数",
			DefaultValue = 0,
			Description = "添加指定的月数（整数）结果不跨月，如1月31日增加1个月等于2月28日。",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		fMWgtCjJLX5 = new StepInParamDef
		{
			Key = "format",
			Name = "输出文本值格式",
			DefaultValue = "yyyy-MM-dd HH:mm:ss",
			Description = "文本值的输出格式，请参考c#语言DateTime.ToString()的参数文档。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		hjhgtPcPEEU = new StepInParamDef
		{
			Key = "outputCulture",
			Name = "输出语言文化",
			DefaultValue = "CURRENT",
			Description = "可选。指定将时间值格式化为文本时所使用的语言文化。如zh-CN表示中文简体，en-US表示美国英文等。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("CURRENT", "当前系统语言"),
				new SelectionItem("zh-CN"),
				new SelectionItem("en-US"),
				new SelectionItem("ja-JP"),
				new SelectionItem("ko-KR"),
				new SelectionItem("fr-FR"),
				new SelectionItem("de-DE"),
				new SelectionItem("es-ES"),
				new SelectionItem("it-IT"),
				new SelectionItem("ru-RU"),
				new SelectionItem("pt-BR")
			}
		};
		QxxgtEANAjU = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		beogt84nJUR = new StepOutParamDef
		{
			Key = "output",
			Name = "时间值",
			Description = "日期时间类型的结果时间",
			Type = VarType.DateTime
		};
		ssCgtaj3UTI = new StepOutParamDef
		{
			Key = "strValue",
			Name = "文本值",
			Description = "按‘文本值格式’参数转换后的文本格式值",
			Type = VarType.Text
		};
		Qlvgt7Mronx = new StepOutParamDef
		{
			Key = "timeStamp",
			Name = "UNIX时间戳(s)",
			Description = "获取Unix时间戳（1970年1月1日0时到指定时间的秒数）",
			Type = VarType.Integer
		};
		NrcgtRVAZNW = new StepOutParamDef
		{
			Key = "timeStampMs",
			Name = "UNIX时间戳(ms)",
			Description = "获取Unix时间戳（1970年1月1日0时到指定时间的毫秒数）",
			Type = VarType.Integer
		};
		aebgtqaeIqo = new StepOutParamDef
		{
			Key = "year",
			Name = "年",
			Description = "年份值",
			Type = VarType.Integer
		};
		zCSgtcRpxJI = new StepOutParamDef
		{
			Key = "month",
			Name = "月",
			Description = "月份值",
			Type = VarType.Integer
		};
		mpTgtVflHDF = new StepOutParamDef
		{
			Key = "day",
			Name = "日",
			Description = "日期值",
			Type = VarType.Integer
		};
		VYggtZdTy59 = new StepOutParamDef
		{
			Key = "hour",
			Name = "时",
			Description = "当前小时数，24小时制。",
			Type = VarType.Integer
		};
		eHbgt9xGnWu = new StepOutParamDef
		{
			Key = "minute",
			Name = "分",
			Description = "当前分钟数。",
			Type = VarType.Integer
		};
		PjHgthj21tV = new StepOutParamDef
		{
			Key = "second",
			Name = "秒",
			Description = "当前秒数。",
			Type = VarType.Integer
		};
		Wq5gteyVFxF = new StepOutParamDef
		{
			Key = "dayOfWeek",
			Name = "周第几天",
			Description = "本周的第几天，周日为0，周一为1，以此类推。",
			Type = VarType.Integer
		};
		rV8gtY1yExM = new StepOutParamDef
		{
			Key = "dayOfYear",
			Name = "年第几天",
			Description = "本年的第几天。",
			Type = VarType.Integer
		};
		BPggtILcPQG = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool dOXASBQ86hxgbZ0Cj6Kv()
	{
		return bf9PnuQ8I1uEu6l9Hu0A == null;
	}

	internal static void fyla7bQ8SPAywEFPdm0m()
	{
	}
}
