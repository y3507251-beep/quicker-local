using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using Microsoft.Win32;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Actions.XActions.BuiltinRunners;

public class WinServiceStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec VeDShE3rKgA;

		public static Func<ServiceController, string> EolShyWulFd;

		private static _003C_003Ec CQ50HcW9tB0HNJYivcIO;

		static _003C_003Ec()
		{
			VeDShE3rKgA = new _003C_003Ec();
		}

		internal string GaJShPPIpMK(ServiceController x)
		{
			return x.ServiceName;
		}

		internal static bool eDq7I9W9Sb0s4BYm2p8A()
		{
			return CQ50HcW9tB0HNJYivcIO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public ActionStep x67ShaRlJ0q;

		public ActionExecuteContext TTnSh7gpmkc;

		public WinServiceStep WJqShRALMbO;

		public XAction dViShqxRsey;

		private static _003C_003Ec__DisplayClass54_0 gVHFV5W9TqgSWPGOQwuy;

		internal (bool isSuccess, string message, ActionStopFlag failReason) HiFSh8IcdmA()
		{
			return XActionHelper.GetTextParamValue(_operationParam, x67ShaRlJ0q, TTnSh7gpmkc) switch
			{
				"getRegValue" => WJqShRALMbO.d7ogeZ2oICT(TTnSh7gpmkc, x67ShaRlJ0q, dViShqxRsey), 
				"getServiceList" => WJqShRALMbO.SIJge9RgpOg(TTnSh7gpmkc, x67ShaRlJ0q, dViShqxRsey), 
				"getServiceInfo" => WJqShRALMbO.zAygehygmF0(TTnSh7gpmkc, x67ShaRlJ0q, dViShqxRsey), 
				_ => (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop), 
			};
		}

		internal static bool knJt6jW9m3P2MS2k3dQR()
		{
			return gVHFV5W9TqgSWPGOQwuy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_0
	{
		public string mnQShVrPuY4;

		internal static _003C_003Ec__DisplayClass57_0 PnarUtW9CuBdguHZcDPE;

		internal bool noKShcK8iRK(ServiceController s)
		{
			return s.ServiceName == mnQShVrPuY4;
		}

		internal static bool u7OJNQW97dYGXyGlk8B9()
		{
			return PnarUtW9CuBdguHZcDPE == null;
		}
	}

	[CompilerGenerated]
	private readonly string jh8gee89cOX = "sys:winservice";

	[CompilerGenerated]
	private readonly string c5DgeYc1gt1 = "Windows服务和注册表";

	[CompilerGenerated]
	private readonly IEnumerable<string> Aj3geI6W1Xo = new string[2] { "windows", "service" };

	[CompilerGenerated]
	private readonly string T2wgeWIewd7 = "Steps/common_step.png";

	[CompilerGenerated]
	private readonly StepRunnerCategory qlwgeklGhHR = StepRunnerCategory.System;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> OGJgeGbgrTM;

	[CompilerGenerated]
	private readonly string XY4gesmOSL1 = "获取Windows服务的状态、注册表项信息";

	[CompilerGenerated]
	private readonly StepType CkCgeH0HJKn;

	[CompilerGenerated]
	private readonly string ecqge1svgrK = "https://getquicker.net/KC/Help/Doc/winservice";

	[CompilerGenerated]
	private readonly bool R0UgebP0KGH;

	[CompilerGenerated]
	private readonly bool o8Kge6uaMs1;

	public const string OP_GetServiceInfo = "getServiceInfo";

	public const string OP_GetServiceList = "getServiceList";

	public const string OP_GetRegValue = "getRegValue";

	public static readonly StepInParamDef _operationParam;

	public static readonly StepInParamDef _serviceNameParam;

	private static readonly StepInParamDef MQSgeX1FxQw;

	public static readonly StepInParamDef RegKeyPathParam;

	public static readonly StepInParamDef RegValueNamePath;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> JPAgemdqt18 = new List<StepInParamDef> { _operationParam, _serviceNameParam, RegKeyPathParam, RegValueNamePath, MQSgeX1FxQw };

	private static readonly StepOutParamDef xOpgeKnLMPT;

	public static readonly StepOutParamDef IsExistsOutParam;

	public static readonly StepOutParamDef DisplayNameOutParam;

	public static readonly StepOutParamDef ServiceStateOutParam;

	public static readonly StepOutParamDef RegValueOutParam;

	public static readonly StepOutParamDef ServiceListOutParam;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> ocggexOQguC = new List<StepOutParamDef> { IsExistsOutParam, DisplayNameOutParam, ServiceStateOutParam, ServiceListOutParam, RegValueOutParam };

	private static WinServiceStep ddJ61pQTF7hvex7OI3W5;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return jh8gee89cOX;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return c5DgeYc1gt1;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return Aj3geI6W1Xo;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return T2wgeWIewd7;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return qlwgeklGhHR;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return OGJgeGbgrTM;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return XY4gesmOSL1;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return CkCgeH0HJKn;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return ecqge1svgrK;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return R0UgebP0KGH;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return o8Kge6uaMs1;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return JPAgemdqt18;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return ocggexOQguC;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.x67ShaRlJ0q = step;
		_003C_003Ec__DisplayClass54_.TTnSh7gpmkc = context;
		_003C_003Ec__DisplayClass54_.WJqShRALMbO = this;
		_003C_003Ec__DisplayClass54_.dViShqxRsey = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass54_.TTnSh7gpmkc, _003C_003Ec__DisplayClass54_.x67ShaRlJ0q, _003C_003Ec__DisplayClass54_.dViShqxRsey, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass54_.HiFSh8IcdmA, (Action)null, (Action)null, MQSgeX1FxQw, xOpgeKnLMPT);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) d7ogeZ2oICT(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		string text = XActionHelper.GetTextParamValue(RegKeyPathParam, actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(RegValueNamePath, actionStep_0, actionExecuteContext_0);
		if (text.StartsWith("计算机\\"))
		{
			text = text.Substring("计算机\\".Length);
		}
		if (text.StartsWith("HKCU\\"))
		{
			text = text.Replace("HKCU\\", "HKEY_CURRENT_USER\\");
		}
		if (text.StartsWith("HKLM\\"))
		{
			text = text.Replace("HKLM\\", "HKEY_LOCAL_MACHINE\\");
		}
		object value = Registry.GetValue(text, textParamValue, "");
		bool flag = value != null;
		XActionHelper.OutputResult(IsExistsOutParam, actionStep_0, actionExecuteContext_0, flag, xaction_0);
		StepOutParamDef regValueOutParam = RegValueOutParam;
		object obj;
		if (value == null)
		{
			obj = null;
		}
		else
		{
			obj = value.ToString();
			if (obj != null)
			{
				goto IL_00b6;
			}
		}
		obj = "";
		goto IL_00b6;
		IL_00b6:
		XActionHelper.OutputResult(regValueOutParam, actionStep_0, actionExecuteContext_0, obj, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) SIJge9RgpOg(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		List<string> result = ServiceController.GetServices().Select(_003C_003Ec.EolShyWulFd ?? (_003C_003Ec.EolShyWulFd = _003C_003Ec.VeDShE3rKgA.GaJShPPIpMK)).ToList();
		XActionHelper.OutputResult(ServiceListOutParam, actionStep_0, actionExecuteContext_0, result, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) zAygehygmF0(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
		_003C_003Ec__DisplayClass57_.mnQShVrPuY4 = XActionHelper.GetTextParamValue(_serviceNameParam, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass57_.mnQShVrPuY4))
		{
			return (isSuccess: false, message: "未指定要获取信息的服务名", failReason: ActionStopFlag.OperationFailed);
		}
		ServiceController serviceController = ServiceController.GetServices().FirstOrDefault(_003C_003Ec__DisplayClass57_.noKShcK8iRK);
		bool flag = serviceController != null;
		XActionHelper.OutputResult(IsExistsOutParam, actionStep_0, actionExecuteContext_0, flag, xaction_0);
		if (serviceController != null)
		{
			XActionHelper.OutputResult(DisplayNameOutParam, actionStep_0, actionExecuteContext_0, serviceController.DisplayName, xaction_0);
			XActionHelper.OutputResult(ServiceStateOutParam, actionStep_0, actionExecuteContext_0, (int)serviceController.Status, xaction_0);
		}
		else
		{
			XActionHelper.OutputResult(DisplayNameOutParam, actionStep_0, actionExecuteContext_0, "", xaction_0);
			XActionHelper.OutputResult(ServiceStateOutParam, actionStep_0, actionExecuteContext_0, 0, xaction_0);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(_operationParam, step) + " " + XActionHelper.GetParamDisplayString(_serviceNameParam, step) + " " + XActionHelper.GetParamDisplayString(RegKeyPathParam, step);
	}

	static WinServiceStep()
	{
		_operationParam = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			DefaultValue = "getServiceInfo",
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("getServiceInfo", "获取某个服务的信息"),
				new SelectionItem("getServiceList", "获取Windows服务列表"),
				new SelectionItem("getRegValue", "获取注册表项值")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		_serviceNameParam = new StepInParamDef
		{
			Key = "name",
			Name = "服务名",
			Description = "服务名称（不是显示名称），大小写敏感。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "getServiceInfo" }
		};
		MQSgeX1FxQw = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		RegKeyPathParam = new StepInParamDef
		{
			Key = "regKeyPath",
			Name = "注册表项路径",
			Description = "如：HKEY_CURRENT_USER\\Software\\Quicker",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "getRegValue" }
		};
		RegValueNamePath = new StepInParamDef
		{
			Key = "regValueName",
			Name = "值名称",
			Description = "留空表示“默认”项",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "getRegValue" }
		};
		xOpgeKnLMPT = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		IsExistsOutParam = new StepOutParamDef
		{
			Key = "isExists",
			Name = "是否存在",
			Description = "服务或注册表项是否存在",
			Type = VarType.Boolean,
			ValidForList = new string[2] { "getServiceInfo", "getRegValue" }
		};
		DisplayNameOutParam = new StepOutParamDef
		{
			Key = "displayName",
			Name = "显示名",
			Description = "服务的显示名",
			Type = VarType.Text,
			ValidForList = new string[1] { "getServiceInfo" }
		};
		ServiceStateOutParam = new StepOutParamDef
		{
			Key = "state",
			Name = "服务状态",
			Description = "服务的当前状态。4:运行中，1:已停止。其它状态请参考文档。",
			Type = VarType.Integer,
			ValidForList = new string[1] { "getServiceInfo" }
		};
		RegValueOutParam = new StepOutParamDef
		{
			Key = "regValue",
			Name = "值",
			Description = "注册表项的值",
			Type = VarType.Text,
			ValidForList = new string[1] { "getRegValue" }
		};
		ServiceListOutParam = new StepOutParamDef
		{
			Key = "serviceList",
			Name = "服务名列表",
			Description = "",
			Type = VarType.List,
			ValidForList = new string[1] { "getServiceList" }
		};
	}

	internal static bool AFL4BNQTcJTXXLnYfXpQ()
	{
		return ddJ61pQTF7hvex7OI3W5 == null;
	}

	internal static void EfTt4mQTykjl28LKp5tm()
	{
	}
}
