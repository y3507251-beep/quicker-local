using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using FontAwesome5;
using iD3rL0wqHLyQDnFvopm;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace LPXkJxoo8BnxcREeFLt;

internal class afTGWWoXytUImX5ZUwY : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public ActionStep HM0Se3r2Xbh;

		public ActionExecuteContext RdZSeffuuyE;

		public afTGWWoXytUImX5ZUwY X2DSezEYpfO;

		public XAction OrrSYws1Vmd;

		internal static _003C_003Ec__DisplayClass54_0 AZ2Rf8WunvDHqsCXHFar;

		internal (bool isSuccess, string message, ActionStopFlag failReason) e2YSei4QVqJ()
		{
			string textParamValue = XActionHelper.GetTextParamValue(ayEgGvNW6jS, HM0Se3r2Xbh, RdZSeffuuyE);
			string textParamValue2 = XActionHelper.GetTextParamValue(MMxgG0601OE, HM0Se3r2Xbh, RdZSeffuuyE);
			return textParamValue switch
			{
				"GetServerState" => X2DSezEYpfO.GetServerState(textParamValue2, RdZSeffuuyE, HM0Se3r2Xbh, OrrSYws1Vmd), 
				"CloseServer" => X2DSezEYpfO.bLHgkfDfYGE(textParamValue2, RdZSeffuuyE, HM0Se3r2Xbh, OrrSYws1Vmd), 
				"CreateFileServer" => X2DSezEYpfO.I59gkzLdYBu(textParamValue2, RdZSeffuuyE, HM0Se3r2Xbh, OrrSYws1Vmd), 
				_ => (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop), 
			};
		}

		internal static bool f0Is10WuekaaprPmskPA()
		{
			return AZ2Rf8WunvDHqsCXHFar == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_0
	{
		public string TydSYgRGCJj;

		public string url;

		internal static _003C_003Ec__DisplayClass57_0 iW48ZwWuDVJTiQ1EADip;

		internal object c4WSYtO3sFI()
		{
			if (!string.IsNullOrWhiteSpace(TydSYgRGCJj))
			{
				return url.Replace("://", "://quicker:" + TydSYgRGCJj + "@");
			}
			return url;
		}

		internal static bool alLOW0Wu3wy9yAvpjvWa()
		{
			return iW48ZwWuDVJTiQ1EADip == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> KcZgGwGDFH6;

	[CompilerGenerated]
	private readonly string zjrgGtNy5mf = $"fa:{EFontAwesomeIcon.Light_Server}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> dgKgGg5mwQ3;

	[CompilerGenerated]
	private readonly string RFogGLYOa91 = "https://getquicker.net/KC/Help/Doc/httpserver";

	private static readonly StepInParamDef ayEgGvNW6jS;

	private static readonly StepInParamDef kuQgGSmSoXL;

	private static readonly StepInParamDef r3ogG2RnyMd;

	private static readonly StepInParamDef B2hgGuP1Bck;

	private static readonly StepInParamDef q9QgGN1AVcD;

	private static readonly StepInParamDef JmwgGJVfTK7;

	private static readonly StepInParamDef MMxgG0601OE;

	private static readonly StepInParamDef ofBgGCEgXyA;

	private static readonly StepInParamDef cV7gGPSu2PE;

	private static readonly StepInParamDef UdJgGEPwpJ7;

	private static readonly StepInParamDef gqpgGylLCGL;

	private static readonly StepInParamDef zMIgG8i1r9Y;

	private static readonly StepInParamDef jABgGaqEAcr;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> X7ngG7uwPeV = new List<StepInParamDef>
	{
		ayEgGvNW6jS, kuQgGSmSoXL, r3ogG2RnyMd, B2hgGuP1Bck, q9QgGN1AVcD, JmwgGJVfTK7, MMxgG0601OE, gqpgGylLCGL, zMIgG8i1r9Y, cV7gGPSu2PE,
		UdJgGEPwpJ7, ofBgGCEgXyA, jABgGaqEAcr
	};

	private static readonly StepOutParamDef OOkgGRaBlES;

	public static readonly StepOutParamDef woCgGq5In1J;

	public static readonly StepOutParamDef XPfgGcdAOmB;

	private static readonly StepOutParamDef YvpgGV0BXUj;

	public static readonly StepOutParamDef zA4gGZATGm9;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> QtCgG9ioGlp = new List<StepOutParamDef> { OOkgGRaBlES, woCgGq5In1J, XPfgGcdAOmB, YvpgGV0BXUj, zA4gGZATGm9 };

	private static afTGWWoXytUImX5ZUwY FfFsbnQmoiHUdPQkjxEa;

	public string Key => "sys:httpserver";

	public string Name => "HTTP服务器";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return KcZgGwGDFH6;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return zjrgGtNy5mf;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return dgKgGg5mwQ3;
		}
	}

	public string Description => "创建临时的本地HTTP服务器，从而可以从移动端或其它设备访问。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return RFogGLYOa91;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return X7ngG7uwPeV;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return QtCgG9ioGlp;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.HM0Se3r2Xbh = step;
		_003C_003Ec__DisplayClass54_.RdZSeffuuyE = context;
		_003C_003Ec__DisplayClass54_.X2DSezEYpfO = this;
		_003C_003Ec__DisplayClass54_.OrrSYws1Vmd = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass54_.RdZSeffuuyE, _003C_003Ec__DisplayClass54_.HM0Se3r2Xbh, _003C_003Ec__DisplayClass54_.OrrSYws1Vmd, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass54_.e2YSei4QVqJ, (Action)null, (Action)null, jABgGaqEAcr, OOkgGRaBlES);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetServerState(string serverId, ActionExecuteContext context, ActionStep step, XAction action)
	{
		bool flag = IlMn5dwlDHBK7IvLxep.fRm3lP2xqA().V7X3FMuZWW(serverId);
		IList<string> result = IlMn5dwlDHBK7IvLxep.fRm3lP2xqA().bbV3Ug7KMi();
		XActionHelper.OutputResult(YvpgGV0BXUj, step, context, flag, action);
		XActionHelper.OutputResult(zA4gGZATGm9, step, context, result, action);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) bLHgkfDfYGE(string string_2, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		IlMn5dwlDHBK7IvLxep.fRm3lP2xqA().Iok3AIp1Qv(string_2);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) I59gkzLdYBu(string string_2, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
		int num = (int)XActionHelper.GetIntegerParamValue(kuQgGSmSoXL, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(r3ogG2RnyMd, actionStep_0, actionExecuteContext_0);
		string text = XActionHelper.GetTextParamValue(B2hgGuP1Bck, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass57_.TydSYgRGCJj = XActionHelper.GetTextParamValue(JmwgGJVfTK7, actionStep_0, actionExecuteContext_0);
		int int_ = (int)XActionHelper.GetIntegerParamValue(gqpgGylLCGL, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(zMIgG8i1r9Y, actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(q9QgGN1AVcD, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(cV7gGPSu2PE, actionStep_0, actionExecuteContext_0);
		string textParamValue3 = XActionHelper.GetTextParamValue(UdJgGEPwpJ7, actionStep_0, actionExecuteContext_0);
		string textParamValue4 = XActionHelper.GetTextParamValue(ofBgGCEgXyA, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrWhiteSpace(text))
		{
			text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
			Directory.CreateDirectory(text);
		}
		if (num == 0)
		{
			num = AppHelper.OLvLTFTFuIP();
		}
		IlMn5dwlDHBK7IvLxep.fRm3lP2xqA().A4w3ODOOTJ(string_2, text, num, booleanParamValue, _003C_003Ec__DisplayClass57_.TydSYgRGCJj, int_, textParamValue, textParamValue2, textParamValue3, actionExecuteContext_0.ActionId, textParamValue4, booleanParamValue2);
		_003C_003Ec__DisplayClass57_.url = "";
		string text2 = AppHelper.ckeLTO9a8ni();
		if (booleanParamValue)
		{
			_003C_003Ec__DisplayClass57_.url = string.Format("https://{0}:{1}/", text2, num);
		}
		else
		{
			_003C_003Ec__DisplayClass57_.url = $"http://{text2}:{num}";
		}
		XActionHelper.OutputResult(woCgGq5In1J, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass57_.url, xaction_0);
		XActionHelper.OutputResultIfNeeded(XPfgGcdAOmB, _003C_003Ec__DisplayClass57_.c4WSYtO3sFI, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ayEgGvNW6jS, step) + " " + XActionHelper.GetParamDisplayString(B2hgGuP1Bck, step);
	}

	static afTGWWoXytUImX5ZUwY()
	{
		ayEgGvNW6jS = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "CreateFileServer",
			Type = VarType.Enum,
			IsControlField = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("CreateFileServer", "创建文件服务器"),
				new SelectionItem("CloseServer", "关闭服务"),
				new SelectionItem("GetServerState", "获取服务状态")
			}
		};
		kuQgGSmSoXL = new StepInParamDef
		{
			Key = "port",
			Name = "端口号",
			Description = "服务端口号。值为0时自动生成端口号。",
			DefaultValue = 8080,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		r3ogG2RnyMd = new StepInParamDef
		{
			Key = "enableHttps",
			Name = "启用HTTPS",
			Type = VarType.Boolean,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		B2hgGuP1Bck = new StepInParamDef
		{
			Key = "docPath",
			Name = "文件夹路径",
			Description = "服务的文件夹完整路径。不支持磁盘根目录。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		q9QgGN1AVcD = new StepInParamDef
		{
			Key = "defaultDoc",
			Name = "默认文档",
			Description = "可选，如index.html。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		JmwgGJVfTK7 = new StepInParamDef
		{
			Key = "password",
			Name = "基础验证密码",
			Description = "Basic验证的密码，账号固定为quicker",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		MMxgG0601OE = new StepInParamDef
		{
			Key = "serviceId",
			Name = "服务ID",
			Description = "通过服务ID启动或关闭服务",
			DefaultValue = "default",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false
		};
		ofBgGCEgXyA = new StepInParamDef
		{
			Key = "customRequest",
			Name = "自定义请求处理",
			Description = "每行一条规则，格式为：“路径:HTTP方法:子程序名”。详细信息请参考模块文档。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			IsAdvanced = true,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		cV7gGPSu2PE = new StepInParamDef
		{
			Key = "headCode",
			Name = "HEAD插入代码",
			Description = "向目录HTML文档的Head中插入代码，可用于自定义风格。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			IsAdvanced = true,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		UdJgGEPwpJ7 = new StepInParamDef
		{
			Key = "bodyCode",
			Name = "BODY插入代码",
			Description = "向目录HTML文档的BODY中插入代码，可用于自定义脚本。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			IsAdvanced = true,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		gqpgGylLCGL = new StepInParamDef
		{
			Key = "autoShutdownSeconds",
			Name = "闲置自动关闭",
			DefaultValue = 0,
			Description = "可选。一定时间（秒）没有请求后自动关闭服务。",
			IsRequired = false,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		zMIgG8i1r9Y = new StepInParamDef
		{
			Key = "showNotifyWhenAutoClose",
			Name = "自动关闭时显示通知",
			DefaultValue = false,
			Description = "闲置超时关闭时，是否显示通知。",
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "CreateFileServer" }
		};
		jABgGaqEAcr = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		OOkgGRaBlES = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		woCgGq5In1J = new StepOutParamDef
		{
			Key = "serverUrl",
			Name = "服务地址",
			Type = VarType.Text,
			Description = "服务网址",
			ValidForList = new string[1] { "CreateFileServer" }
		};
		XPfgGcdAOmB = new StepOutParamDef
		{
			Key = "serverUrlWithAccount",
			Name = "带账号的地址",
			Type = VarType.Text,
			Description = "带有账号密码的地址。可用于扫码后自动登录。",
			ValidForList = new string[1] { "CreateFileServer" }
		};
		YvpgGV0BXUj = new StepOutParamDef
		{
			Key = "isRunning",
			Name = "是否在运行",
			Description = "指定ID的web服务是否在运行中",
			Type = VarType.Boolean,
			ValidForList = new string[1] { "GetServerState" }
		};
		zA4gGZATGm9 = new StepOutParamDef
		{
			Key = "serverList",
			Name = "运行中的服务列表",
			Type = VarType.List,
			Description = "所有运行中的服务的列表",
			ValidForList = new string[1] { "GetServerState" }
		};
	}

	internal static bool uiNj63QmfAJ3H17vfKYw()
	{
		return FfFsbnQmoiHUdPQkjxEa == null;
	}
}
