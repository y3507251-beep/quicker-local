using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Compute;

public class ComputeTimeStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_0
	{
		public ActionStep BIQS80WfZBM;

		public ActionExecuteContext vCkS8Coh9EP;

		public XAction joZS8Pw9yb7;

		private static _003C_003Ec__DisplayClass57_0 JcGH1uWO7SBEAVLTGS2b;

		internal (bool isSuccess, string message, ActionStopFlag failReason) gn4S8JaOZjp()
		{
			string textParamValue = XActionHelper.GetTextParamValue(UKAgC9pjX18, BIQS80WfZBM, vCkS8Coh9EP);
			object paramValue = XActionHelper.GetParamValue(Wm0gChJoyVY, BIQS80WfZBM, vCkS8Coh9EP);
			if (!(paramValue is DateTime))
			{
				return (isSuccess: false, message: "日期时间 参数值不是时间值", failReason: ActionStopFlag.OperationFailed);
			}
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			case "localToUtc":
				XActionHelper.OutputResult(SNWgC6NpxOo, BIQS80WfZBM, vCkS8Coh9EP, ((DateTime)paramValue).ToUniversalTime(), joZS8Pw9yb7);
				goto IL_0105;
			case "utcToLocal":
				XActionHelper.OutputResult(SNWgC6NpxOo, BIQS80WfZBM, vCkS8Coh9EP, ((DateTime)paramValue).ToLocalTime(), joZS8Pw9yb7);
				goto IL_0105;
			case "endtime":
			{
				DateTime dateTime = (DateTime)paramValue;
				int value = Convert.ToInt32(XActionHelper.GetNumberParamValue(SCAgCWyOUuT, BIQS80WfZBM, vCkS8Coh9EP));
				dateTime = dateTime.AddYears(value);
				int months = Convert.ToInt32(XActionHelper.GetNumberParamValue(I1igCkD3lPt, BIQS80WfZBM, vCkS8Coh9EP));
				dateTime = dateTime.AddMonths(months);
				double value2 = Convert.ToDouble(XActionHelper.GetNumberParamValue(jDagCGEtth7, BIQS80WfZBM, vCkS8Coh9EP));
				if (Math.Abs(value2) > 0.0001)
				{
					dateTime = dateTime.AddDays(value2);
				}
				double value3 = Convert.ToDouble(XActionHelper.GetNumberParamValue(NYggCscacQo, BIQS80WfZBM, vCkS8Coh9EP));
				if (Math.Abs(value3) > 0.0001)
				{
					dateTime = dateTime.AddHours(value3);
				}
				double value4 = Convert.ToDouble(XActionHelper.GetNumberParamValue(vcBgCHKpIwH, BIQS80WfZBM, vCkS8Coh9EP));
				if (Math.Abs(value4) > 0.0001)
				{
					dateTime = dateTime.AddMinutes(value4);
				}
				double value5 = Convert.ToDouble(XActionHelper.GetNumberParamValue(CAvgC1okjBd, BIQS80WfZBM, vCkS8Coh9EP));
				if (Math.Abs(value5) > 0.0001)
				{
					dateTime = dateTime.AddSeconds(value5);
				}
				XActionHelper.OutputResult(SNWgC6NpxOo, BIQS80WfZBM, vCkS8Coh9EP, dateTime, joZS8Pw9yb7);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "timespan":
			{
				object paramValue2 = XActionHelper.GetParamValue(fQfgCegGYn7, BIQS80WfZBM, vCkS8Coh9EP);
				if (!(paramValue2 is DateTime))
				{
					return (isSuccess: false, message: "日期时间2 的参数值不是时间值", failReason: ActionStopFlag.OperationFailed);
				}
				TimeSpan timeSpan = (DateTime)paramValue2 - (DateTime)paramValue;
				XActionHelper.OutputResult(p6ngCXiLNyM, BIQS80WfZBM, vCkS8Coh9EP, timeSpan.TotalDays, joZS8Pw9yb7);
				XActionHelper.OutputResult(KKHgCmMokxP, BIQS80WfZBM, vCkS8Coh9EP, timeSpan.TotalHours, joZS8Pw9yb7);
				XActionHelper.OutputResult(sNEgCxRS0FY, BIQS80WfZBM, vCkS8Coh9EP, timeSpan.TotalSeconds, joZS8Pw9yb7);
				XActionHelper.OutputResult(taNgCKRMW2V, BIQS80WfZBM, vCkS8Coh9EP, timeSpan.TotalMinutes, joZS8Pw9yb7);
				if (XActionHelper.IsOutputParamSetted(dcygCrhSK4r.Key, BIQS80WfZBM))
				{
					string textParamValue2 = XActionHelper.GetTextParamValue(J5cgCY7cQmt, BIQS80WfZBM, vCkS8Coh9EP);
					string result = timeSpan.ToString(textParamValue2);
					XActionHelper.OutputResult(dcygCrhSK4r, BIQS80WfZBM, vCkS8Coh9EP, result, joZS8Pw9yb7);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "getdate":
				{
					XActionHelper.OutputResult(SNWgC6NpxOo, BIQS80WfZBM, vCkS8Coh9EP, ((DateTime)paramValue).Date, joZS8Pw9yb7);
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				IL_0105:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool lkYgbsWO46uNNHxbA4Re()
		{
			return JcGH1uWO7SBEAVLTGS2b == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> KbMgCR0rudM = new string[6] { "time", "date", "日期", "时间", "utc", "riqi" };

	[CompilerGenerated]
	private readonly string yNJgCq3QYcx = $"fa:{EFontAwesomeIcon.Light_Clock}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> dnTgCcRMQED;

	[CompilerGenerated]
	private readonly string bbogCVq7Wuq = "https://getquicker.net/KC/Help/Doc/computetime";

	[CompilerGenerated]
	private readonly bool MMRgCZNUno9;

	private static readonly StepInParamDef UKAgC9pjX18;

	private static readonly StepInParamDef Wm0gChJoyVY;

	private static readonly StepInParamDef fQfgCegGYn7;

	private static readonly StepInParamDef J5cgCY7cQmt;

	private static readonly StepInParamDef rvvgCI70sAs;

	private static readonly StepInParamDef SCAgCWyOUuT;

	private static readonly StepInParamDef I1igCkD3lPt;

	private static readonly StepInParamDef jDagCGEtth7;

	private static readonly StepInParamDef NYggCscacQo;

	private static readonly StepInParamDef vcBgCHKpIwH;

	private static readonly StepInParamDef CAvgC1okjBd;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> IRigCbaXt8u = new List<StepInParamDef>
	{
		UKAgC9pjX18, Wm0gChJoyVY, fQfgCegGYn7, J5cgCY7cQmt, SCAgCWyOUuT, I1igCkD3lPt, jDagCGEtth7, NYggCscacQo, vcBgCHKpIwH, CAvgC1okjBd,
		rvvgCI70sAs
	};

	private static readonly StepOutParamDef SNWgC6NpxOo;

	private static readonly StepOutParamDef p6ngCXiLNyM;

	private static readonly StepOutParamDef KKHgCmMokxP;

	private static readonly StepOutParamDef taNgCKRMW2V;

	private static readonly StepOutParamDef sNEgCxRS0FY;

	private static readonly StepOutParamDef dcygCrhSK4r;

	private static readonly StepOutParamDef h2lgCpeOEnF;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> MoSgCBCDUSw = new List<StepOutParamDef> { h2lgCpeOEnF, SNWgC6NpxOo, p6ngCXiLNyM, KKHgCmMokxP, taNgCKRMW2V, sNEgCxRS0FY, dcygCrhSK4r };

	private static ComputeTimeStep drEKofQULsGjUQCr746X;

	public string Key => "sys:computeTime";

	public string Name => "计算时间";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return KbMgCR0rudM;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return yNJgCq3QYcx;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return dnTgCcRMQED;
		}
	}

	public string Description => "时间相关的计算操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bbogCVq7Wuq;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return MMRgCZNUno9;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return IRigCbaXt8u;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return MoSgCBCDUSw;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
		_003C_003Ec__DisplayClass57_.BIQS80WfZBM = step;
		_003C_003Ec__DisplayClass57_.vCkS8Coh9EP = context;
		_003C_003Ec__DisplayClass57_.joZS8Pw9yb7 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass57_.vCkS8Coh9EP, _003C_003Ec__DisplayClass57_.BIQS80WfZBM, _003C_003Ec__DisplayClass57_.joZS8Pw9yb7, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass57_.gn4S8JaOZjp, (Action)null, (Action)null, rvvgCI70sAs, h2lgCpeOEnF);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(UKAgC9pjX18, step) ?? "";
	}

	static ComputeTimeStep()
	{
		UKAgC9pjX18 = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "比较方式",
			DefaultValue = "getdate",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("getdate", "取日期值（去除当天的时间部分）"),
				new SelectionItem("timespan", "计算时间差（日期时间2 减 日期时间）"),
				new SelectionItem("endtime", "计算结束时间"),
				new SelectionItem("localToUtc", "本地时间转换为UTC时间"),
				new SelectionItem("utcToLocal", "UTC时间转换为本地时间")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		Wm0gChJoyVY = new StepInParamDef
		{
			Key = "time1",
			Name = "日期时间",
			Description = "要计算的时间值",
			Type = VarType.DateTime,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		fQfgCegGYn7 = new StepInParamDef
		{
			Key = "time2",
			Name = "日期时间2",
			Description = "要计算的第二个时间值",
			Type = VarType.DateTime,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "timespan" }
		};
		J5cgCY7cQmt = new StepInParamDef
		{
			Key = "formatString",
			Name = "格式化字符串",
			Description = "时间差转换为文本时的格式化字符串。d:天数,hh:小时,mm:分钟,ss:秒。符号.:需要使用\\转义",
			Type = VarType.Text,
			DefaultValue = "d\\.hh\\:mm\\:ss",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "timespan" }
		};
		rvvgCI70sAs = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		SCAgCWyOUuT = new StepInParamDef
		{
			Key = "addYears",
			Name = "添加年数",
			DefaultValue = 0,
			Description = "添加指定的年数（整数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "endtime" }
		};
		I1igCkD3lPt = new StepInParamDef
		{
			Key = "addMonths",
			Name = "添加月数",
			DefaultValue = 0,
			Description = "添加指定的月数（整数）结果不跨月，如1月31日增加1个月等于2月28日。",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "endtime" }
		};
		jDagCGEtth7 = new StepInParamDef
		{
			Key = "addDays",
			Name = "添加天数",
			DefaultValue = 0,
			Description = "添加指定的天数（可以为小数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "endtime" }
		};
		NYggCscacQo = new StepInParamDef
		{
			Key = "addHours",
			Name = "添加小时数",
			DefaultValue = 0,
			Description = "添加指定的小时数（可以为小数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "endtime" }
		};
		vcBgCHKpIwH = new StepInParamDef
		{
			Key = "addMinutes",
			Name = "添加分钟数",
			DefaultValue = 0,
			Description = "添加指定的分钟数（可以为小数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "endtime" }
		};
		CAvgC1okjBd = new StepInParamDef
		{
			Key = "addSeconds",
			Name = "添加秒数",
			DefaultValue = 0,
			Description = "添加指定的秒数（可以为小数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "endtime" }
		};
		SNWgC6NpxOo = new StepOutParamDef
		{
			Key = "resultTime",
			Name = "结果时间",
			Type = VarType.DateTime,
			Description = "计算的结果时间",
			ValidForList = new string[4] { "endtime", "getdate", "utcToLocal", "localToUtc" }
		};
		p6ngCXiLNyM = new StepOutParamDef
		{
			Key = "totalDays",
			Name = "总天数",
			Type = VarType.Number,
			Description = "间隔的总天数值",
			ValidForList = new string[1] { "timespan" }
		};
		KKHgCmMokxP = new StepOutParamDef
		{
			Key = "totalHours",
			Name = "总小时数",
			Type = VarType.Number,
			Description = "间隔的总小时数",
			ValidForList = new string[1] { "timespan" }
		};
		taNgCKRMW2V = new StepOutParamDef
		{
			Key = "totalMinutes",
			Name = "总分钟数",
			Type = VarType.Number,
			Description = "间隔的总分钟数值",
			ValidForList = new string[1] { "timespan" }
		};
		sNEgCxRS0FY = new StepOutParamDef
		{
			Key = "totalSeconds",
			Name = "总秒数",
			Type = VarType.Number,
			Description = "间隔的总秒数数值",
			ValidForList = new string[1] { "timespan" }
		};
		dcygCrhSK4r = new StepOutParamDef
		{
			Key = "textValue",
			Name = "文本值",
			Type = VarType.Text,
			Description = "时间间隔的文本结果",
			ValidForList = new string[1] { "timespan" }
		};
		h2lgCpeOEnF = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool VcdHKnQUu5PFJ1rUSTG4()
	{
		return drEKofQULsGjUQCr746X == null;
	}
}
