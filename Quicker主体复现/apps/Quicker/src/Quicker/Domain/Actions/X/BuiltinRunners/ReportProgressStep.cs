using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.View.Progress;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class ReportProgressStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep plbviL4Rs3p;

		public ActionExecuteContext tZovivCDNLZ;

		public XAction Fg6viSRGDDj;

		private static _003C_003Ec__DisplayClass42_0 EsjmLAWjAIVEjFp5p7yl;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Rj7vigIuP0U()
		{
			switch (XActionHelper.GetTextParamValue(J0ktonP6t6Y, plbviL4Rs3p, tZovivCDNLZ))
			{
			case "REMOVE":
				ProgressReportMgr.RemoveProgress(SvGtorVD3rg(plbviL4Rs3p, tZovivCDNLZ));
				break;
			case "UPDATE_PROGRESS":
			{
				int id = SvGtorVD3rg(plbviL4Rs3p, tZovivCDNLZ);
				string textParamValue = XActionHelper.GetTextParamValue(LIwto5hAWrh, plbviL4Rs3p, tZovivCDNLZ);
				double numberParamValue = XActionHelper.GetNumberParamValue(lt4toDQ9dgL, plbviL4Rs3p, tZovivCDNLZ);
				string textParamValue2 = XActionHelper.GetTextParamValue(BVQtodn9Yiw, plbviL4Rs3p, tZovivCDNLZ);
				ProgressReportMgr.UpdateProgress(id, "", textParamValue, numberParamValue, textParamValue2, tZovivCDNLZ.Id);
				break;
			}
			case "REQUEST_ID":
				XActionHelper.OutputResult(NNjtoTvTld6, plbviL4Rs3p, tZovivCDNLZ, ProgressReportMgr.RequestProgressId(), Fg6viSRGDDj);
				break;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool WO4uOQWjnXieI4NKXuUI()
		{
			return EsjmLAWjAIVEjFp5p7yl == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> XE7topwbh5T = new string[1] { "progress" };

	[CompilerGenerated]
	private readonly string jkqtoBe5xbp = $"fa:{EFontAwesomeIcon.Light_TasksAlt}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> yEstoQnaTt7;

	[CompilerGenerated]
	private readonly string djstoj0DEtu = "https://getquicker.net/KC/Help/Doc/reportProgress";

	private static readonly StepInParamDef J0ktonP6t6Y;

	private static readonly StepInParamDef jgeto4wgooc;

	private static readonly StepInParamDef LIwto5hAWrh;

	private static readonly StepInParamDef lt4toDQ9dgL;

	private static readonly StepInParamDef BVQtodn9Yiw;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> q6wtoo3ohOO = new List<StepInParamDef> { J0ktonP6t6Y, jgeto4wgooc, LIwto5hAWrh, lt4toDQ9dgL, BVQtodn9Yiw };

	private static readonly StepOutParamDef NNjtoTvTld6;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> TW2toMndhJv = new List<StepOutParamDef> { NNjtoTvTld6 };

	internal static ReportProgressStep ajxIO1QiXOFfkXXkAx4B;

	public string Key => "sys:reportProgress";

	public string Name => "显示进度条";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return XE7topwbh5T;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return jkqtoBe5xbp;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return yEstoQnaTt7;
		}
	}

	public string Description => "显示/更新进度条";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return djstoj0DEtu;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return q6wtoo3ohOO;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return TW2toMndhJv;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.plbviL4Rs3p = step;
		_003C_003Ec__DisplayClass42_.tZovivCDNLZ = context;
		_003C_003Ec__DisplayClass42_.Fg6viSRGDDj = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.tZovivCDNLZ, _003C_003Ec__DisplayClass42_.plbviL4Rs3p, _003C_003Ec__DisplayClass42_.Fg6viSRGDDj, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.Rj7vigIuP0U, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	private static int SvGtorVD3rg(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		int num = Convert.ToInt32(XActionHelper.GetIntegerParamValue(jgeto4wgooc, actionStep_0, actionExecuteContext_0));
		if (num == 0)
		{
			num = actionExecuteContext_0.GetRootContext()?.Id ?? 0;
			actionExecuteContext_0.ActionLogger.LogInfo($"进度条ID为0，将使用当前上下文的ID {num} 作为进度条ID");
		}
		return num;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(J0ktonP6t6Y, step) + "  " + XActionHelper.GetParamDirectValue(jgeto4wgooc, step);
	}

	static ReportProgressStep()
	{
		J0ktonP6t6Y = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "REQUEST_ID",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("REQUEST_ID", "创建进度条"),
				new SelectionItem("UPDATE_PROGRESS", "更新进度"),
				new SelectionItem("REMOVE", "去除进度条")
			},
			IsControlField = true
		};
		jgeto4wgooc = new StepInParamDef
		{
			Key = "progressId",
			Name = "进度条ID",
			Description = "进度条的序号，用于后续更新或删除进度条",
			Type = VarType.Integer,
			DefaultValue = 0,
			ValidForList = new List<string> { "UPDATE_PROGRESS", "REMOVE" }
		};
		LIwto5hAWrh = new StepInParamDef
		{
			Key = "title",
			Name = "进度条标题",
			Description = "进度条的标题(显示在进度条上方)",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "UPDATE_PROGRESS" }
		};
		lt4toDQ9dgL = new StepInParamDef
		{
			Key = "percentage",
			Name = "进度百分比",
			Description = "0到100之间的数字",
			Type = VarType.Number,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "UPDATE_PROGRESS" }
		};
		BVQtodn9Yiw = new StepInParamDef
		{
			Key = "text",
			Name = "说明文字",
			Description = "显示在进度条下方",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "UPDATE_PROGRESS" }
		};
		NNjtoTvTld6 = new StepOutParamDef
		{
			Key = "progressId",
			Name = "进度条ID",
			Description = "进度条的序号，用于后续更新或删除进度条",
			Type = VarType.Integer,
			ValidForList = new List<string> { "REQUEST_ID" }
		};
	}

	internal static bool YfLmdwQi2Por02t9aAIU()
	{
		return ajxIO1QiXOFfkXXkAx4B == null;
	}
}
