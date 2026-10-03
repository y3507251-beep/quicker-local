using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using bO46JfWAenppOQ94A2q;
using FontAwesome5;
using log4net;
using LPAgent.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace zkDBafo3nCg7Ay6vnkx;

internal class tDr6CKos9H62j34ncfZ : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0
	{
		public ActionStep zcMS1PvMAYo;

		public ActionExecuteContext XP8S1EqIasa;

		public XAction X5jS1yl50OW;

		internal static _003C_003Ec__DisplayClass49_0 hpf03TWiyvsCC5UoVwvE;

		internal (bool isSuccess, string message, ActionStopFlag failReason) t08S1CC3DBT()
		{
			y2RHWHW5SANm8yApQAU y2RHWHW5SANm8yApQAU = y2RHWHW5SANm8yApQAU.PeBtgjCTonj();
			string textParamValue = XActionHelper.GetTextParamValue(tIMgr7KPR4U, zcMS1PvMAYo, XP8S1EqIasa);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(rrMgrRXhjfi, zcMS1PvMAYo, XP8S1EqIasa);
			int maxWaitMs = (int)XActionHelper.GetIntegerParamValue(MiagrqVxhkA, zcMS1PvMAYo, XP8S1EqIasa);
			Command command_ = new Command
			{
				Runner = "rhino",
				Operation = "rhino:runscript",
				Data = textParamValue,
				WaitResp = booleanParamValue,
				MaxWaitMs = maxWaitMs
			};
			Response response = y2RHWHW5SANm8yApQAU.PFotgQdV5Ru(command_);
			if (booleanParamValue)
			{
				if (response == null)
				{
					return (isSuccess: false, message: "超时未收到低权限代理程序响应。", failReason: ActionStopFlag.OperationFailed);
				}
				if (!response.IsSuccess)
				{
					return (isSuccess: false, message: "命令返回失败，错误：" + response.Message, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResult(OPCgr9aMiqI, zcMS1PvMAYo, XP8S1EqIasa, response.Data ?? "", X5jS1yl50OW);
			}
			else
			{
				XActionHelper.OutputResult(OPCgr9aMiqI, zcMS1PvMAYo, XP8S1EqIasa, "*未等待返回*", X5jS1yl50OW);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool LD1vcdWip3VvadR0hk71()
		{
			return hpf03TWiyvsCC5UoVwvE == null;
		}
	}

	private static readonly ILog vuYgrv9yK8F;

	[CompilerGenerated]
	private readonly string jDAgrSW7pIP = "sys:rhinocontrol";

	[CompilerGenerated]
	private readonly string qOogr2vUu7y = "Rhino软件控制";

	[CompilerGenerated]
	private readonly IEnumerable<string> hhXgruXWpAY;

	[CompilerGenerated]
	private readonly string plhgrNr065a = $"fa:{EFontAwesomeIcon.Light_RulerCombined}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory P1jgrJFmSw4 = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> VrGgr0KCgfB;

	[CompilerGenerated]
	private readonly string PZIgrC4cLgw = "向Rhino发送命令或脚本";

	[CompilerGenerated]
	private readonly StepType km3grP8W8h6;

	[CompilerGenerated]
	private readonly string EW3grEmZms2 = "https://getquicker.net/KC/Help/Doc/rhinocontrol";

	[CompilerGenerated]
	private readonly bool lrVgryGtJUq;

	[CompilerGenerated]
	private readonly bool YiIgr8O0qrp;

	public static StepInParamDef RV4grarWOiv;

	private static readonly StepInParamDef tIMgr7KPR4U;

	private static readonly StepInParamDef rrMgrRXhjfi;

	private static readonly StepInParamDef MiagrqVxhkA;

	private static readonly StepInParamDef hhJgrc1tIhv;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> WfagrV3Y6t3 = new List<StepInParamDef> { RV4grarWOiv, tIMgr7KPR4U, rrMgrRXhjfi, MiagrqVxhkA, hhJgrc1tIhv };

	private static readonly StepOutParamDef ExXgrZ8NJ5J;

	private static readonly StepOutParamDef OPCgr9aMiqI;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> tWYgrht8PGe = new List<StepOutParamDef> { ExXgrZ8NJ5J, OPCgr9aMiqI };

	internal static tDr6CKos9H62j34ncfZ Bx5ihsQhXkSVMb36QyAs;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return jDAgrSW7pIP;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return qOogr2vUu7y;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return hhXgruXWpAY;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return plhgrNr065a;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return P1jgrJFmSw4;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return VrGgr0KCgfB;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return PZIgrC4cLgw;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return km3grP8W8h6;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return EW3grEmZms2;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return lrVgryGtJUq;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return YiIgr8O0qrp;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return WfagrV3Y6t3;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return tWYgrht8PGe;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
		_003C_003Ec__DisplayClass49_.zcMS1PvMAYo = step;
		_003C_003Ec__DisplayClass49_.XP8S1EqIasa = context;
		_003C_003Ec__DisplayClass49_.X5jS1yl50OW = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass49_.XP8S1EqIasa, _003C_003Ec__DisplayClass49_.zcMS1PvMAYo, _003C_003Ec__DisplayClass49_.X5jS1yl50OW, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass49_.t08S1CC3DBT, (Action)null, (Action)null, hhJgrc1tIhv, ExXgrZ8NJ5J);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(RV4grarWOiv, step) + " " + XActionHelper.GetParamDisplayString(tIMgr7KPR4U, step);
	}

	static tDr6CKos9H62j34ncfZ()
	{
		vuYgrv9yK8F = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		RV4grarWOiv = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "RunScript",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("RunScript", "执行脚本")
			},
			IsControlField = true
		};
		tIMgr7KPR4U = new StepInParamDef
		{
			Key = "command",
			Name = "命令内容",
			Description = "命令或脚本内容。",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "RunScript" }
		};
		rrMgrRXhjfi = new StepInParamDef
		{
			Key = "waitResp",
			Name = "等待命令结束",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = true,
			ValidForList = new List<string> { "RunScript" }
		};
		MiagrqVxhkA = new StepInParamDef
		{
			Key = "waitMs",
			Name = "最长等待时间(ms)",
			DefaultValue = 10000,
			Description = "最长的等待返回结果的，毫秒数",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		hhJgrc1tIhv = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ExXgrZ8NJ5J = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		OPCgr9aMiqI = new StepOutParamDef
		{
			Key = "output",
			Name = "脚本输出",
			Description = "仅通过接口执行脚本时支持返回内容。",
			Type = VarType.Text
		};
	}

	internal static bool EOa2NWQh2uvyMfUgjqHu()
	{
		return Bx5ihsQhXkSVMb36QyAs == null;
	}
}
