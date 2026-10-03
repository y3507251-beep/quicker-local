using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using bO46JfWAenppOQ94A2q;
using FontAwesome5;
using LPAgent.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace plg1kho04k380EAlDXh;

internal class i2KmbQoEvmSN6KnrWAE : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public ActionStep DCdS1aMIjT8;

		public ActionExecuteContext EdCS175GvaM;

		public XAction keJS1RVLqy7;

		private static _003C_003Ec__DisplayClass50_0 rDW7KIWi2GDBgJ5nBffj;

		internal (bool isSuccess, string message, ActionStopFlag failReason) VvRS18mY6Zs()
		{
			string textParamValue = XActionHelper.GetTextParamValue(SXCgrXl47N1, DCdS1aMIjT8, EdCS175GvaM);
			y2RHWHW5SANm8yApQAU y2RHWHW5SANm8yApQAU = y2RHWHW5SANm8yApQAU.PeBtgjCTonj();
			string textParamValue2;
			bool flag;
			int maxWaitMs;
			string operation;
			if (!(textParamValue == "ReadVariable"))
			{
				if ((textParamValue == null || textParamValue.Length != 0) && !(textParamValue == "SendCommand"))
				{
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				textParamValue2 = XActionHelper.GetTextParamValue(GU0grmYs7ME, DCdS1aMIjT8, EdCS175GvaM);
				flag = XActionHelper.GetBooleanParamValue(oUbgrx12lnp, DCdS1aMIjT8, EdCS175GvaM);
				maxWaitMs = (int)XActionHelper.GetIntegerParamValue(IpagrrQGQvy, DCdS1aMIjT8, EdCS175GvaM);
				operation = "cad:sendcommand";
			}
			else
			{
				textParamValue2 = XActionHelper.GetTextParamValue(y1hgrKInwiD, DCdS1aMIjT8, EdCS175GvaM);
				flag = true;
				maxWaitMs = 1000;
				operation = "cad:readvaraible";
			}
			Command command_ = new Command
			{
				Runner = "cad",
				Operation = operation,
				Data = textParamValue2,
				WaitResp = flag,
				MaxWaitMs = maxWaitMs
			};
			Response response = y2RHWHW5SANm8yApQAU.PFotgQdV5Ru(command_);
			string result = "";
			if (flag)
			{
				if (response == null)
				{
					return (isSuccess: false, message: "超时未收到低权限代理程序响应。", failReason: ActionStopFlag.OperationFailed);
				}
				if (!response.IsSuccess)
				{
					XActionHelper.OutputResult(JHSgrjDsybk, DCdS1aMIjT8, EdCS175GvaM, result, keJS1RVLqy7);
					return (isSuccess: false, message: "命令返回失败，错误：" + response.Message, failReason: ActionStopFlag.OperationFailed);
				}
				result = response.Data ?? "";
				XActionHelper.OutputResult(JHSgrjDsybk, DCdS1aMIjT8, EdCS175GvaM, result, keJS1RVLqy7);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool CVaZnjWiAdyRTIFkRnLj()
		{
			return rDW7KIWi2GDBgJ5nBffj == null;
		}
	}

	[CompilerGenerated]
	private readonly string IRagrePqfjI = "sys:autocadcontrol";

	[CompilerGenerated]
	private readonly string I0egrY1MZDm = "AutoCAD控制";

	[CompilerGenerated]
	private readonly IEnumerable<string> Md6grItQ8yU;

	[CompilerGenerated]
	private readonly string VyYgrW4sn6M = $"fa:{EFontAwesomeIcon.Light_RulerCombined}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory Hk3grkbXUyc = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> dh6grGxafBd;

	[CompilerGenerated]
	private readonly string ViegrsKDIWZ = "向AutoCAD发送命令";

	[CompilerGenerated]
	private readonly StepType VDXgrHtw9EI;

	[CompilerGenerated]
	private readonly string fkBgr13AaOj = "https://getquicker.net/KC/Help/Doc/autocadcontrol";

	[CompilerGenerated]
	private readonly bool vHOgrb8CdpU;

	[CompilerGenerated]
	private readonly bool Q1rgr6svsJs;

	public static StepInParamDef SXCgrXl47N1;

	private static readonly StepInParamDef GU0grmYs7ME;

	private static readonly StepInParamDef y1hgrKInwiD;

	private static readonly StepInParamDef oUbgrx12lnp;

	private static readonly StepInParamDef IpagrrQGQvy;

	private static readonly StepInParamDef pESgrpWIWkn;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> SndgrBbb00b = new List<StepInParamDef> { SXCgrXl47N1, GU0grmYs7ME, y1hgrKInwiD, oUbgrx12lnp, IpagrrQGQvy, pESgrpWIWkn };

	private static readonly StepOutParamDef NZ3grQp8EVR;

	private static readonly StepOutParamDef JHSgrjDsybk;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> bv0grnpKo7l = new List<StepOutParamDef> { NZ3grQp8EVR, JHSgrjDsybk };

	internal static i2KmbQoEvmSN6KnrWAE TJdmR1QhGxBmdhj6P5b6;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return IRagrePqfjI;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return I0egrY1MZDm;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return Md6grItQ8yU;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return VyYgrW4sn6M;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return Hk3grkbXUyc;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return dh6grGxafBd;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return ViegrsKDIWZ;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return VDXgrHtw9EI;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return fkBgr13AaOj;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return vHOgrb8CdpU;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return Q1rgr6svsJs;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return SndgrBbb00b;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return bv0grnpKo7l;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.DCdS1aMIjT8 = step;
		_003C_003Ec__DisplayClass50_.EdCS175GvaM = context;
		_003C_003Ec__DisplayClass50_.keJS1RVLqy7 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass50_.EdCS175GvaM, _003C_003Ec__DisplayClass50_.DCdS1aMIjT8, _003C_003Ec__DisplayClass50_.keJS1RVLqy7, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass50_.VvRS18mY6Zs, (Action)null, (Action)null, pESgrpWIWkn, NZ3grQp8EVR);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(SXCgrXl47N1, step) + " " + XActionHelper.GetParamDisplayString(GU0grmYs7ME, step);
	}

	static i2KmbQoEvmSN6KnrWAE()
	{
		SXCgrXl47N1 = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "SendCommand",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("SendCommand", "执行命令"),
				new SelectionItem("ReadVariable", "读取变量")
			},
			IsControlField = true
		};
		GU0grmYs7ME = new StepInParamDef
		{
			Key = "command",
			Name = "命令内容",
			Description = "发送到CAD执行的命令内容。通常以空格结尾开始执行。",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "SendCommand" }
		};
		y1hgrKInwiD = new StepInParamDef
		{
			Key = "varList",
			Name = "变量列表",
			Description = "每行一个变量名称",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "ReadVariable" }
		};
		oUbgrx12lnp = new StepInParamDef
		{
			Key = "waitResp",
			Name = "等待命令结束",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = true,
			ValidForList = new List<string> { "SendCommand" }
		};
		IpagrrQGQvy = new StepInParamDef
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
		pESgrpWIWkn = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		NZ3grQp8EVR = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		JHSgrjDsybk = new StepOutParamDef
		{
			Key = "output",
			Name = "变量值",
			Description = "从当前文档读取的变量值，多个变量时每行一个，和变量名顺序对应。",
			Type = VarType.Text,
			ValidForList = new string[1] { "ReadVariable" }
		};
	}

	internal static bool bJyoOCQh0AyFJK6xiPyx()
	{
		return TJdmR1QhGxBmdhj6P5b6 == null;
	}
}
