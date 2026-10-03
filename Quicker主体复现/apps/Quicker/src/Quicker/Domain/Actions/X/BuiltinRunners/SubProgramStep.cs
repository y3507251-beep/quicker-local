using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using j9PVNbXS3U4MP7j5Ps6;
using Quicker.Domain.Actions.Debugging;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class SubProgramStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec lBLvftakghv;

		public static Func<ActionVariable, bool> oZOvfgOIXLA;

		private static _003C_003Ec hObv9EWD65dFE8rAcT8q;

		static _003C_003Ec()
		{
			lBLvftakghv = new _003C_003Ec();
		}

		internal bool eslvfwVSrOE(ActionVariable x)
		{
			return x.IsOutput;
		}

		internal static bool bAveuoWDt0xwskneyO57()
		{
			return hObv9EWD65dFE8rAcT8q == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep FAgvfverpoL;

		public ActionExecuteContext I6DvfSrDSJk;

		public XAction Mkevf2cioiy;

		private static _003C_003Ec__DisplayClass42_0 QHbEOrWDwgRjYpyS8Awi;

		internal (bool isSuccess, string message, ActionStopFlag failReason) CR2vfLtvGPo()
		{
			string textParamValue = XActionHelper.GetTextParamValue(SubProgramNameParam, FAgvfverpoL, I6DvfSrDSJk);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(S7RtAEq85H5, FAgvfverpoL, I6DvfSrDSJk);
			SubProgram subProgram = GetSubProgram(I6DvfSrDSJk, textParamValue);
			if (subProgram == null)
			{
				return (isSuccess: false, message: "未找到子程序：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			}
			using (ActionExecuteContext actionExecuteContext = new ActionExecuteContext(I6DvfSrDSJk, I6DvfSrDSJk.Action, I6DvfSrDSJk.TargetInfo, I6DvfSrDSJk.AppServer, I6DvfSrDSJk.IsDebugging, I6DvfSrDSJk.Id, null, I6DvfSrDSJk.CancellationToken))
			{
				actionExecuteContext.Browser = I6DvfSrDSJk.Browser;
				I6DvfSrDSJk.ChildContext = actionExecuteContext;
				try
				{
					XAction action = (XAction)(actionExecuteContext.XProgram = new XAction
					{
						Steps = subProgram.Steps,
						Variables = subProgram.Variables,
						SubPrograms = subProgram.SubPrograms
					});
					IActionLogger actionLogger;
					if (!booleanParamValue)
					{
						actionLogger = I6DvfSrDSJk.ActionLogger;
					}
					else
					{
						IActionLogger actionLogger2 = new NopActionLogger();
						actionLogger = actionLogger2;
					}
					actionExecuteContext.ActionLogger = actionLogger;
					if (subProgram.Variables.HasData())
					{
						foreach (ActionVariable variable in subProgram.Variables)
						{
							try
							{
								jIXtAudhmjj(variable, actionExecuteContext, FAgvfverpoL, I6DvfSrDSJk);
							}
							catch (Exception ex)
							{
								return (isSuccess: false, message: "初始化变量失败：" + variable.Key + "，" + ex.Message, failReason: ActionStopFlag.OperationFailed);
							}
						}
					}
					actionExecuteContext.SetVarValueWithoutConvert("quicker_in_param", actionExecuteContext.RootContext.InputParam ?? string.Empty);
					try
					{
						XActionRunner.RunChildSteps(subProgram.Steps, 0, actionExecuteContext, action, "");
						if (actionExecuteContext.ReturnError)
						{
							return (isSuccess: false, message: "子程序 " + subProgram.Name + " 运行失败：" + actionExecuteContext.ReturnResult, failReason: ActionStopFlag.OperationFailed);
						}
					}
					catch (Exception exception)
					{
						return (isSuccess: false, message: "运行子程序出错：" + exception.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
					}
					foreach (ActionVariable item in subProgram.Variables.Where(_003C_003Ec.oZOvfgOIXLA ?? (_003C_003Ec.oZOvfgOIXLA = _003C_003Ec.lBLvftakghv.eslvfwVSrOE)))
					{
						XActionHelper.OutputResult(CreateStepOutParam(item), FAgvfverpoL, I6DvfSrDSJk, actionExecuteContext.GetVarValue(item.Key), Mkevf2cioiy);
					}
					if (actionExecuteContext.StopFlag.IsEither(ActionStopFlag.ForceStop))
					{
						I6DvfSrDSJk.StopAction(ActionStopFlag.ForceStop, "子程序中强制停止动作");
						return (isSuccess: false, message: "子程序(" + subProgram.Name + ")中强制停止动作。" + actionExecuteContext.ErrorMessage, failReason: ActionStopFlag.ForceStop);
					}
					if (actionExecuteContext.StopFlag != ActionStopFlag.NoStop && actionExecuteContext.StopFlag != ActionStopFlag.StopFromCode)
					{
						return (isSuccess: false, message: "运行子程序(" + subProgram.Name + ")失败。" + actionExecuteContext.ErrorMessage, failReason: actionExecuteContext.StopFlag);
					}
				}
				finally
				{
					I6DvfSrDSJk.ChildContext = null;
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool KdgtV0WDTUwCt3R5GHYR()
		{
			return QHbEOrWDwgRjYpyS8Awi == null;
		}
	}

	public const string StepKey = "sys:subprogram";

	[CompilerGenerated]
	private readonly IEnumerable<string> eWPtAN93kSm;

	[CompilerGenerated]
	private readonly string jm7tAJ2sMtO = $"fa:{EFontAwesomeIcon.Solid_Cubes}:#3196F4";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> VjYtA00u4Bv;

	[CompilerGenerated]
	private readonly string L0RtACnAX2O = "https://getquicker.net/KC/Help/Doc/subprogram";

	[CompilerGenerated]
	private readonly bool UvWtAPFasge;

	public static readonly StepInParamDef SubProgramNameParam;

	public static readonly StepInParamDef SubProgramSummaryParam;

	internal static readonly StepInParamDef S7RtAEq85H5;

	private static readonly StepInParamDef B0ZtAyP4dMJ;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> ybxtA8lTJfI = new List<StepInParamDef> { SubProgramNameParam, SubProgramSummaryParam, S7RtAEq85H5, B0ZtAyP4dMJ };

	private static readonly StepOutParamDef NmUtAaTUlqC;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> zeOtA7a6HvP = new List<StepOutParamDef> { NmUtAaTUlqC };

	private static SubProgramStep lTxVNgQlFa5dqFVTTvRX;

	public string Key => "sys:subprogram";

	public string Name => "运行子程序";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return eWPtAN93kSm;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return jm7tAJ2sMtO;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return VjYtA00u4Bv;
		}
	}

	public string Description => "运行子程序";

	public StepType StepType => StepType.SubProgram;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return L0RtACnAX2O;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return UvWtAPFasge;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return ybxtA8lTJfI;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return zeOtA7a6HvP;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public static SubProgram GetSubProgram(ActionExecuteContext context, string identifier)
	{
		SubProgram subProgramByIdentifier = SubProgramHelper.GetSubProgramByIdentifier(identifier, context.XProgram?.SubPrograms);
		if (subProgramByIdentifier != null)
		{
			return subProgramByIdentifier;
		}
		if (context.ParentContext != null && context.ParentContext != context)
		{
			SubProgram subProgram = GetSubProgram(context.ParentContext, identifier);
			if (subProgram != null)
			{
				return subProgram;
			}
		}
		if (context.RootContext != context)
		{
			return GetSubProgram(context.RootContext, identifier);
		}
		return null;
	}

	internal static void jIXtAudhmjj(ActionVariable actionVariable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_1)
	{
        StepInParamDef stepInParamDef2 = default;
		DataTable dataTable = default(DataTable);
		int num;
		if (actionVariable_0.Type == VarType.Table)
		{
			dataTable = new DataTable();
			if (actionVariable_0.TableDef != null)
			{
				zsVr57XToYMFTdxtZho.aNOghYZ7hRs(dataTable, actionVariable_0.TableDef);
			}
			if (!actionVariable_0.IsInput)
			{
				goto IL_0133;
			}
			StepInParamDef stepInParamDef = CreateStepInParam(actionVariable_0);
			object obj = null;
			if (actionStep_0.InputParams.ContainsKey(stepInParamDef.Key))
			{
				obj = XActionHelper.GetParamValue(stepInParamDef, actionStep_0, actionExecuteContext_1);
				if (obj is DataTable dataTable2)
				{
					dataTable = dataTable2;
				}
				else if (obj != null)
				{
					throw new InvalidDataException("传入的内容不是表格类型。");
				}
			}
			else
			{
				string defaultValue = actionVariable_0.DefaultValue;
				if (!string.IsNullOrEmpty(defaultValue))
				{
					dataTable.mFighIebWbm(defaultValue);
					num = 1;
					if (!rSWuAGQlcp5Wodc3ltbG())
					{
						goto IL_00d5;
					}
					goto IL_00d9;
				}
			}
			goto IL_014d;
		}
		stepInParamDef2 = default(StepInParamDef);
		if (actionVariable_0.IsInput)
		{
			stepInParamDef2 = CreateStepInParam(actionVariable_0);
			num = 0;
			if (lTxVNgQlFa5dqFVTTvRX != null)
			{
				goto IL_00d5;
			}
			goto IL_00d9;
		}
		actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, VariableHelper.ConvertVarDefaultValue(actionVariable_0.Type, actionVariable_0.DefaultValue));
		return;
		IL_014d:
		actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, dataTable);
		return;
		IL_0133:
		string defaultValue2 = actionVariable_0.DefaultValue;
		if (!string.IsNullOrEmpty(defaultValue2))
		{
			dataTable.mFighIebWbm(defaultValue2);
		}
		goto IL_014d;
		IL_00d5:
		int num2 = default(int);
		num = num2;
		goto IL_00d9;
		IL_00d9:
		switch (num)
		{
		default:
		{
			object obj2 = null;
			obj2 = ((!actionStep_0.InputParams.ContainsKey(stepInParamDef2.Key)) ? actionVariable_0.DefaultValue : XActionHelper.GetParamValue(stepInParamDef2, actionStep_0, actionExecuteContext_1));
			actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, VariableHelper.ConvertToType(actionVariable_0.Type, obj2));
			return;
		}
		case 2:
			break;
		case 1:
			goto IL_014d;
		}
		goto IL_0133;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.FAgvfverpoL = step;
		_003C_003Ec__DisplayClass42_.I6DvfSrDSJk = context;
		_003C_003Ec__DisplayClass42_.Mkevf2cioiy = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.I6DvfSrDSJk, _003C_003Ec__DisplayClass42_.FAgvfverpoL, _003C_003Ec__DisplayClass42_.Mkevf2cioiy, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.CR2vfLtvGPo, (Action)null, (Action)null, B0ZtAyP4dMJ, NmUtAaTUlqC);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	public static StepInParamDef CreateStepInParam(ActionVariable v)
	{
		StepInParamDef stepInParamDef = new StepInParamDef
		{
			Key = "var:" + v.Key,
			Name = v.GetParamName(),
			DefaultValue = v.DefaultValue,
			Description = v.Desc,
			Type = v.Type,
			InternalType = v.Type,
			IsMultiLine = (v.InputParamInfo?.MultiLine ?? false),
			VariableMode = ParamVariableMode.UseVarOrInput,
			VisibleExpression = v.InputParamInfo?.VisibleExpression,
			SkipEval = (v.InputParamInfo?.SkipEval ?? false)
		};
		if (!string.IsNullOrEmpty(v.InputParamInfo?.SelectionItems))
		{
			List<SimpleOperationItem> list = AppHelper.StringToOperationItems(v.InputParamInfo.SelectionItems, true);
			stepInParamDef.SelectionItems = new List<SelectionItem>(list.Count);
			List<SimpleOperationItem>.Enumerator enumerator = list.GetEnumerator();
			int num = 0;
			if (lTxVNgQlFa5dqFVTTvRX != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				while (enumerator.MoveNext())
				{
					SimpleOperationItem current = enumerator.Current;
					stepInParamDef.SelectionItems.Add(new SelectionItem
					{
						Value = current.Key,
						Name = current.Name,
						Description = current.Description
					});
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
			if (v.InputParamInfo.OnlyUseSelect)
			{
				stepInParamDef.VariableMode = ParamVariableMode.Input;
				stepInParamDef.Type = VarType.Enum;
			}
		}
		if (stepInParamDef.VariableMode.IsEither(ParamVariableMode.Input, ParamVariableMode.UseVarOrInput) && !string.IsNullOrEmpty(v.InputParamInfo?.TextTools))
		{
			stepInParamDef.TextTools = v.InputParamInfo?.TextTools.ParseToolsString();
		}
		return stepInParamDef;
	}

	public static StepOutParamDef CreateStepOutParam(ActionVariable v)
	{
		return new StepOutParamDef
		{
			Key = "var:" + v.Key,
			Name = v.GetParamName(),
			Description = v.Desc,
			Type = v.Type,
			VisibleExpression = v.OutputParamInfo?.VisibleExpression
		};
	}

	public static (string name, string summary) GetSubProgramInfo(ActionStep step)
	{
		string value;
		string item;
		object obj;
		if (step.InputParams.ContainsKey(SubProgramNameParam.Key))
		{
			value = step.InputParams[SubProgramNameParam.Key].Value;
			item = "";
			if (step.InputParams.ContainsKey(SubProgramSummaryParam.Key))
			{
				ActionStepParam actionStepParam = step.InputParams[SubProgramSummaryParam.Key];
				if (actionStepParam == null)
				{
					obj = null;
				}
				else
				{
					obj = actionStepParam.Value;
					if (obj != null)
					{
						goto IL_007c;
					}
				}
				obj = "";
				goto IL_007c;
			}
			goto IL_007d;
		}
		return (name: null, summary: null);
		IL_007d:
		if (value.StartsWith("%%"))
		{
			SubProgram globalSubProgram = AppState.DataService.GetGlobalSubProgram(value.Substring(2));
			if (globalSubProgram == null)
			{
				return (name: "未找到：" + value, summary: item);
			}
			return (name: globalSubProgram.Name ?? "", summary: item);
		}
		if (value.StartsWith("@@"))
		{
			string[] array = value.Substring(2).Split(new char[1] { '@' }, 3);
			return (name: array[2] + " v" + array[1], summary: item);
		}
		return (name: value, summary: item);
		IL_007c:
		item = (string)obj;
		goto IL_007d;
	}

	public static bool IsInternalSubProgram(ActionStep step)
	{
		string subProgramIdentifier = GetSubProgramIdentifier(step);
		if (subProgramIdentifier != null)
		{
			if (!subProgramIdentifier.StartsWith("%%"))
			{
				return !subProgramIdentifier.StartsWith("@@");
			}
			return false;
		}
		return false;
	}

	public static (string icon, string tooltip) GetSubProgramIcon(ActionStep step)
	{
		string item = $"fa:{EFontAwesomeIcon.Solid_Cubes}:#6aaded";
		string subProgramIdentifier = GetSubProgramIdentifier(step);
		if (string.IsNullOrEmpty(subProgramIdentifier))
		{
			return (icon: item, tooltip: "子程序");
		}
		if (subProgramIdentifier.StartsWith("%%"))
		{
			return (icon: $"fa:{EFontAwesomeIcon.Solid_Cubes}:#0f8f22", tooltip: "公共子程序，在所有动作中都可使用");
		}
		if (subProgramIdentifier.StartsWith("@@"))
		{
			return (icon: $"fa:{EFontAwesomeIcon.Solid_Cubes}:#f19503", tooltip: "网络共享子程序");
		}
		return (icon: item, tooltip: "动作内子程序");
	}

	public static string GetSubProgramIdentifier(ActionStep step)
	{
		if (step.InputParams.ContainsKey(SubProgramNameParam.Key))
		{
			return step.InputParams[SubProgramNameParam.Key].Value;
		}
		return "";
	}

	public static void SetSubprogramIdentifier(ActionStep step, string identifier)
	{
		step.InputParams[SubProgramNameParam.Key].Value = identifier;
	}

	static SubProgramStep()
	{
		SubProgramNameParam = new StepInParamDef
		{
			Key = "subProgram",
			Name = "子程序",
			Description = "调用哪个子程序",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		SubProgramSummaryParam = new StepInParamDef
		{
			Key = "summary",
			Name = "Summary",
			Description = "内部使用",
			Type = VarType.Text,
			ValidForList = new List<string> { "NO_SHOW" }
		};
		S7RtAEq85H5 = new StepInParamDef
		{
			Key = "skipDebugOutput",
			Name = "跳过调试输出",
			DefaultValue = false,
			Description = "调试运行动作时，不输出子程序内部调试信息",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		B0ZtAyP4dMJ = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "子程序运行失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		NmUtAaTUlqC = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "子程序是否运行成功",
			Type = VarType.Boolean
		};
	}

	internal static bool rSWuAGQlcp5Wodc3ltbG()
	{
		return lTxVNgQlFa5dqFVTTvRX == null;
	}

	internal static void LeIsyWQleIIgcbFIcNOC()
	{
	}
}
