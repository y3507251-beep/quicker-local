using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using FontAwesome5;
using Quicker.Common;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class RunActionStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public ActionStep vlAvfqrHGm9;

		public ActionExecuteContext pYqvfcalVYk;

		public XAction bO0vfVokGPn;

		internal static _003C_003Ec__DisplayClass50_0 qGSkOcW3VE4CO3ZOJwo6;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Mr9vfRPbQ92()
		{
			string textParamValue = XActionHelper.GetTextParamValue(PpWtA4Rb6Bj, vlAvfqrHGm9, pYqvfcalVYk);
			switch (textParamValue)
			{
			default:
				return (isSuccess: true, message: "不支持的操作类型：" + textParamValue + "。可能您使用的Quicker版本过旧。", failReason: ActionStopFlag.OperationFailed);
			case "StartAction":
			case "StartCurrentAction":
			{
				_003C_003Ec__DisplayClass50_2 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_2();
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(jkTtAdAoqsx, vlAvfqrHGm9, pYqvfcalVYk);
				string textParamValue3 = XActionHelper.GetTextParamValue(mEntAoHQKNS, vlAvfqrHGm9, pYqvfcalVYk);
				bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(B14tATanb29, vlAvfqrHGm9, pYqvfcalVYk);
				string text;
				if (textParamValue == "StartAction")
				{
					text = XActionHelper.GetTextParamValue(l2LtA5Eln8I, vlAvfqrHGm9, pYqvfcalVYk);
				}
				else
				{
					text = pYqvfcalVYk.ActionId;
					if (text == Guid.Empty.ToString())
					{
						return (isSuccess: false, message: "临时动作不支持运行自身。", failReason: ActionStopFlag.OperationFailed);
					}
				}
				_003C_003Ec__DisplayClass50_.M6PvfWewg6k = pYqvfcalVYk.AppServer.ExecuteActionByIdOrName(text, pYqvfcalVYk.TargetInfo, booleanParamValue2, booleanParamValue, true, textParamValue3, pYqvfcalVYk.ActionTrigger);
				XActionHelper.OutputResultIfNeeded(SLXtAUX1KUX, _003C_003Ec__DisplayClass50_.hNwvfI2RwHH, vlAvfqrHGm9, pYqvfcalVYk, bO0vfVokGPn);
				if (booleanParamValue && _003C_003Ec__DisplayClass50_.M6PvfWewg6k.context != null)
				{
					XActionHelper.OutputResult(pXHtAl11Pf7, vlAvfqrHGm9, pYqvfcalVYk, _003C_003Ec__DisplayClass50_.M6PvfWewg6k.context.ReturnResult, bO0vfVokGPn);
					if (_003C_003Ec__DisplayClass50_.M6PvfWewg6k.context.ReturnError)
					{
						string item = (string.IsNullOrEmpty(_003C_003Ec__DisplayClass50_.M6PvfWewg6k.context.ReturnResult) ? "动作返回失败" : _003C_003Ec__DisplayClass50_.M6PvfWewg6k.context.ReturnResult);
						return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
					}
				}
				break;
			}
			case "GetRunningActionCount":
			{
				string textParamValue4 = XActionHelper.GetTextParamValue(l2LtA5Eln8I, vlAvfqrHGm9, pYqvfcalVYk);
				if (string.IsNullOrEmpty(textParamValue4))
				{
					textParamValue4 = pYqvfcalVYk.ActionId;
				}
				else
				{
					if (!string.IsNullOrEmpty(pYqvfcalVYk.Action.TemplateId))
					{
						return (isSuccess: false, message: "动作库安装的动作不支持获取其它动作的运行个数。", failReason: ActionStopFlag.OperationFailed);
					}
					(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(textParamValue4);
					if (tuple.Item1 == null)
					{
						return (isSuccess: false, message: tuple.Item2, failReason: ActionStopFlag.OperationFailed);
					}
					textParamValue4 = tuple.Item1.Id;
				}
				int actionRunningCount = AppState.AppServer.GetActionRunningCount(textParamValue4);
				XActionHelper.OutputResult(ncHtAidSpBS, vlAvfqrHGm9, pYqvfcalVYk, actionRunningCount, bO0vfVokGPn);
				break;
			}
			case "ShowActionContextMenu":
			{
				_003C_003Ec__DisplayClass50_1 _003C_003Ec__DisplayClass50_2 = new _003C_003Ec__DisplayClass50_1();
				string textParamValue5 = XActionHelper.GetTextParamValue(l2LtA5Eln8I, vlAvfqrHGm9, pYqvfcalVYk);
				_003C_003Ec__DisplayClass50_2.WIXvfhcpPY7 = XActionHelper.GetBooleanParamValue(PsEtAD1nAQJ, vlAvfqrHGm9, pYqvfcalVYk);
				_003C_003Ec__DisplayClass50_2.yfjvfegXi13 = AppState.DataService.QHmtXwg81eY(textParamValue5);
				if (_003C_003Ec__DisplayClass50_2.yfjvfegXi13.action == null)
				{
					return (isSuccess: false, message: "未找到动作，因此无法显示右键菜单。动作ID：" + textParamValue5, failReason: ActionStopFlag.OperationFailed);
				}
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass50_2.DK0vfZgyq4Z);
				break;
			}
			case "StopOtherInstance":
			{
				string actionId = pYqvfcalVYk.RootContext.ActionId;
				int num2 = AppState.AppServer.StopActionByIdOrName(actionId, pYqvfcalVYk.RootContext.Id, true);
				pYqvfcalVYk.ActionLogger.LogInfo("停止的动作数量：" + num2);
				break;
			}
			case "StopAction":
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(l2LtA5Eln8I, vlAvfqrHGm9, pYqvfcalVYk);
				bool skipStopWarning = false;
				if (string.IsNullOrEmpty(pYqvfcalVYk.Action.TemplateId))
				{
					skipStopWarning = XActionHelper.GetBooleanParamValue(KsRtAM1aMCm, vlAvfqrHGm9, pYqvfcalVYk);
				}
				int num = AppState.AppServer.StopActionByIdOrName(textParamValue2, pYqvfcalVYk.Id, skipStopWarning);
				pYqvfcalVYk.ActionLogger.LogInfo("停止的动作数量：" + num);
				if (num == 0)
				{
					return (isSuccess: false, message: "停止动作：未找到匹配的动作", failReason: ActionStopFlag.OperationFailed);
				}
				break;
			}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool RSqOR4W3QB7K56oycsQj()
		{
			return qGSkOcW3VE4CO3ZOJwo6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_1
	{
		public bool WIXvfhcpPY7;

		public (ActionItem action, string message) yfjvfegXi13;

		public Func<ActionProfile, bool> ipBvfYs2NFD;

		internal static _003C_003Ec__DisplayClass50_1 J4qdZVW3ckxIFyuP4O5W;

		internal void DK0vfZgyq4Z()
		{
			ContextMenu contextMenu = new ContextMenu();
			ActionProfile profile = (WIXvfhcpPY7 ? null : AppState.DataService.mP6tXA8VyNP().Values.FirstOrDefault(ipBvfYs2NFD ?? (ipBvfYs2NFD = axbvf96YGSH)));
			AppState.lWutartRfUY().CreateContextMenuForActionButton(contextMenu, yfjvfegXi13.action, profile, yfjvfegXi13.action.Row, yfjvfegXi13.action.Col, null, ActionTrigger.ContextMenu, true, false, WIXvfhcpPY7);
			contextMenu.IsOpen = true;
		}

		internal bool axbvf96YGSH(ActionProfile x)
		{
			return x.ActionItems.Contains(yfjvfegXi13.action);
		}

		internal static bool GEaByEW3WZ1atS2N2DGw()
		{
			return J4qdZVW3ckxIFyuP4O5W == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_2
	{
		public (ActionItem actionItem, ActionExecuteContext context, string errorMessage) M6PvfWewg6k;

		internal static _003C_003Ec__DisplayClass50_2 LsaN9DW3XqLGQNOYx45h;

		internal object hNwvfI2RwHH()
		{
			return M6PvfWewg6k.actionItem.Title;
		}

		internal static bool YgpsaXW32pT9GZ8bDMcm()
		{
			return LsaN9DW3XqLGQNOYx45h == null;
		}
	}

	public const string Operation_StartAction = "StartAction";

	public const string Operation_StartCurrentAction = "StartCurrentAction";

	public const string Operation_ShowActionContextMenu = "ShowActionContextMenu";

	public const string StepKey = "sys:runAction";

	[CompilerGenerated]
	private readonly IEnumerable<string> S3AtAButO36;

	[CompilerGenerated]
	private readonly string oIhtAQXYMtV = $"fa:{EFontAwesomeIcon.Light_Cog}:#6aaded";

	[CompilerGenerated]
	private readonly string DH7tAjNtwf4 = "https://getquicker.net/KC/Help/Doc/runaction";

	[CompilerGenerated]
	private readonly bool MwZtAn6qKxb;

	private static readonly StepInParamDef PpWtA4Rb6Bj;

	private static readonly StepInParamDef l2LtA5Eln8I;

	private static readonly StepInParamDef PsEtAD1nAQJ;

	private static readonly StepInParamDef jkTtAdAoqsx;

	private static readonly StepInParamDef mEntAoHQKNS;

	private static readonly StepInParamDef B14tATanb29;

	private static readonly StepInParamDef KsRtAM1aMCm;

	private static readonly StepInParamDef pdatAAoVuHt;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> rfMtAO1Ix2c = new StepInParamDef[8] { PpWtA4Rb6Bj, l2LtA5Eln8I, PsEtAD1nAQJ, mEntAoHQKNS, jkTtAdAoqsx, B14tATanb29, KsRtAM1aMCm, pdatAAoVuHt };

	private static readonly StepOutParamDef WaitAFCKeWF;

	private static readonly StepOutParamDef SLXtAUX1KUX;

	private static readonly StepOutParamDef pXHtAl11Pf7;

	private static readonly StepOutParamDef ncHtAidSpBS;

	internal static RunActionStep NY6rOqQlrk76PxSAJvGX;

	public string Key => "sys:runAction";

	public string Name => "运行或停止动作";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return S3AtAButO36;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return oIhtAQXYMtV;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories => null;

	public string Description => "执行指定的其他动作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return DH7tAjNtwf4;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return MwZtAn6qKxb;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return rfMtAO1Ix2c;
		}
	}

	public IList<StepOutParamDef> OutputParams => new List<StepOutParamDef> { WaitAFCKeWF, SLXtAUX1KUX, ncHtAidSpBS, pXHtAl11Pf7 };

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.vlAvfqrHGm9 = step;
		_003C_003Ec__DisplayClass50_.pYqvfcalVYk = context;
		_003C_003Ec__DisplayClass50_.bO0vfVokGPn = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass50_.pYqvfcalVYk, _003C_003Ec__DisplayClass50_.vlAvfqrHGm9, _003C_003Ec__DisplayClass50_.bO0vfVokGPn, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass50_.Mr9vfRPbQ92, (Action)null, (Action)null, pdatAAoVuHt, WaitAFCKeWF);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(PpWtA4Rb6Bj, step) + " " + XActionHelper.GetParamDisplayString(l2LtA5Eln8I, step) + " " + XActionHelper.GetParamDisplayString(mEntAoHQKNS, step);
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	static RunActionStep()
	{
		PpWtA4Rb6Bj = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "StartAction",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("StartAction", "运行动作"),
				new SelectionItem("StopAction", "停止动作"),
				new SelectionItem("ShowActionContextMenu", "显示动作右键菜单"),
				new SelectionItem("StartCurrentAction", "运行当前动作（注意避免产生循环或递归）"),
				new SelectionItem("StopOtherInstance", "停止当前动作的其它实例"),
				new SelectionItem("GetRunningActionCount", "获取动作运行个数（自己编写动作时可用）")
			},
			IsControlField = true
		};
		l2LtA5Eln8I = new StepInParamDef
		{
			Key = "actionId",
			Name = "目标动作",
			Description = "要运行的其他动作的ID或名称(使用名称时需要完全匹配且不能有重名动作)",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = false,
			ValidForList = new List<string> { "StartAction", "StopAction", "ShowActionContextMenu", "GetRunningActionCount" },
			TextTools = new List<TextToolType>
			{
				TextToolType.SelectActionId,
				TextToolType.SelectActionName
			}
		};
		PsEtAD1nAQJ = new StepInParamDef
		{
			Key = "onlyCustomMenu",
			Name = "仅显示动作的自定义菜单",
			Description = "不显示编辑、复制等菜单",
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Boolean,
			DefaultValue = false,
			ValidForList = new List<string> { "ShowActionContextMenu" }
		};
		jkTtAdAoqsx = new StepInParamDef
		{
			Key = "wait",
			Name = "等待运行结束",
			Description = "是否等待此动作运行结束再执行后续动作（如需获取目标动作的输出，需选中此项）",
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Boolean,
			DefaultValue = true,
			ValidForList = new List<string> { "StartAction", "StartCurrentAction" }
		};
		mEntAoHQKNS = new StepInParamDef
		{
			Key = "inputParam",
			Name = "命令参数",
			Description = "传递给目标动作的参数。存储在该动作的quicker_in_param变量中。",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = false,
			ValidForList = new List<string> { "StartAction", "StartCurrentAction" }
		};
		B14tATanb29 = new StepInParamDef
		{
			Key = "debug",
			Name = "调试模式运行",
			DefaultValue = false,
			Description = "是否以调试模式运行动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "StartAction", "StartCurrentAction" }
		};
		KsRtAM1aMCm = new StepInParamDef
		{
			Key = "hideMessage",
			Name = "不显示提示消息",
			DefaultValue = false,
			Description = "仅对非动作库安装的动作有效",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "StopAction" }
		};
		pdatAAoVuHt = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "如果未找到目标动作，是否停止当前动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		WaitAFCKeWF = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		SLXtAUX1KUX = new StepOutParamDef
		{
			Key = "actionTitle",
			Name = "动作名称",
			Description = "运行的动作名称。",
			Type = VarType.Text,
			ValidForList = new List<string> { "StartAction" }
		};
		pXHtAl11Pf7 = new StepOutParamDef
		{
			Key = "output",
			Name = "动作输出",
			Description = "被调用动作的输出。",
			Type = VarType.Text,
			ValidForList = new List<string> { "StartAction", "StartCurrentAction" }
		};
		ncHtAidSpBS = new StepOutParamDef
		{
			Key = "count",
			Name = "运行个数",
			Description = "动作正在运行的个数",
			Type = VarType.Number,
			ValidForList = new List<string> { "GetRunningActionCount" }
		};
	}

	internal static bool il510jQlNUxcK2AUl7cR()
	{
		return NY6rOqQlrk76PxSAJvGX == null;
	}

	internal static void Q1dDpqQlLdPogSfCZrxJ()
	{
	}
}
