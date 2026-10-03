using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd;

namespace sRKxvLoO2f5yntWNjFh;

internal class oyi2lvone7QEWdEeRuW : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass55_0
	{
		public ActionStep PyFS1NNN3G6;

		public ActionExecuteContext i7US1Jhhenr;

		public XAction b0HS109XB3i;

		internal static _003C_003Ec__DisplayClass55_0 DfNHAgWiFcMZxCW1dG7G;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Mg8S1uAufpH()
		{
			y2RHWHW5SANm8yApQAU y2RHWHW5SANm8yApQAU = y2RHWHW5SANm8yApQAU.PeBtgjCTonj();
			string textParamValue = XActionHelper.GetTextParamValue(gB5gxOPJ7I8, PyFS1NNN3G6, i7US1Jhhenr);
			string textParamValue2 = XActionHelper.GetTextParamValue(zBvgxFey1en, PyFS1NNN3G6, i7US1Jhhenr);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(G61gxiVy0W4, PyFS1NNN3G6, i7US1Jhhenr);
			int maxWaitMs = (int)XActionHelper.GetIntegerParamValue(jJWgx3qjI8Y, PyFS1NNN3G6, i7US1Jhhenr);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(zyWgxfT1DCk, PyFS1NNN3G6, i7US1Jhhenr);
			if (textParamValue.IsEither("afterfx"))
			{
				string text = dpIgxKplgfj(PyFS1NNN3G6, i7US1Jhhenr, textParamValue2);
				string text2 = textParamValue;
				Process[] processesByName = Process.GetProcessesByName(text2);
				if (!processesByName.HasData())
				{
					return (isSuccess: false, message: "未找到进程" + text2, failReason: ActionStopFlag.OperationFailed);
				}
				Process.Start(processesByName[0].MainModule.FileName, "-r " + text);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			string text3 = "";
			if (!(textParamValue2 == "dojavascript"))
			{
				if (!(textParamValue2 == "dojavascriptfile"))
				{
					throw new InvalidDataException("不支持的操作类型" + textParamValue2 + "，可能您使用的Quicker版本过旧。");
				}
				text3 = XActionHelper.GetTextParamValue(wSxgxlndePA, PyFS1NNN3G6, i7US1Jhhenr);
			}
			else
			{
				text3 = XActionHelper.GetTextParamValue(k4pgxUWrJCx, PyFS1NNN3G6, i7US1Jhhenr);
			}
			Command command_ = new Command
			{
				Runner = "adobe",
				SubTarget = textParamValue,
				Operation = textParamValue2,
				Data = text3,
				WaitResp = booleanParamValue,
				MaxWaitMs = maxWaitMs,
				Params = new Dictionary<string, string> { { "software", textParamValue } }
			};
			Response response = y2RHWHW5SANm8yApQAU.PFotgQdV5Ru(command_);
			if (booleanParamValue)
			{
				bool flag = false;
				string text4 = "";
				if (response == null)
				{
					text4 = "超时未收到低权限代理程序响应。";
				}
				else if (!response.IsSuccess)
				{
					text4 = "命令返回失败，错误：" + response.Message;
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					text4 = "通过接口运行脚本出错：" + text4;
					i7US1Jhhenr.ActionLogger.LogWarning(text4);
					if (booleanParamValue2)
					{
						if (textParamValue == "Photoshop.Application")
						{
							i7US1Jhhenr.ActionLogger.LogInfo("尝试使用兼容方式运行PS脚本。");
							kW6gxrAHfG3(PyFS1NNN3G6, i7US1Jhhenr, textParamValue2, "Photoshop");
							return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
						}
						if (textParamValue == "Illustrator.Application")
						{
							i7US1Jhhenr.ActionLogger.LogInfo("尝试使用兼容方式运行Ai脚本。");
							kW6gxrAHfG3(PyFS1NNN3G6, i7US1Jhhenr, textParamValue2, "Illustrator");
							return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
						}
					}
					return (isSuccess: false, message: text4, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResult(CpigrgM8Q1H, PyFS1NNN3G6, i7US1Jhhenr, response.Data ?? "", b0HS109XB3i);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool gKdn5XWic83lwSQ1ds7L()
		{
			return DfNHAgWiFcMZxCW1dG7G == null;
		}
	}

	private static readonly ILog FY1gxBV4Vsd;

	[CompilerGenerated]
	private readonly string wMkgxQwWb6B = "sys:adobesoftscontrol";

	[CompilerGenerated]
	private readonly string qiEgxjxYZvZ = "Adobe系列软件控制";

	[CompilerGenerated]
	private readonly IEnumerable<string> JIKgxnfdeqi = new string[4] { "ps", "photoshop", "AE", "After effects" };

	[CompilerGenerated]
	private readonly string byKgx4u5CL2 = $"fa:{EFontAwesomeIcon.Brands_Adobe}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory R9Hgx5E0ZDs = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> KPbgxD6Z4sU;

	[CompilerGenerated]
	private readonly string gEygxdUqY92 = "";

	[CompilerGenerated]
	private readonly StepType gkdgxo4OdaZ;

	[CompilerGenerated]
	private readonly string fusgxTq6R3X = "https://getquicker.net/KC/Help/Doc/adobesoftscontrol";

	[CompilerGenerated]
	private readonly bool yROgxMtxb9j;

	[CompilerGenerated]
	private readonly bool G60gxA4bbLl;

	public static StepInParamDef gB5gxOPJ7I8;

	public static StepInParamDef zBvgxFey1en;

	private static readonly StepInParamDef k4pgxUWrJCx;

	private static readonly StepInParamDef wSxgxlndePA;

	private static readonly StepInParamDef G61gxiVy0W4;

	private static readonly StepInParamDef jJWgx3qjI8Y;

	private static readonly StepInParamDef zyWgxfT1DCk;

	private static readonly StepInParamDef qkogxzivdrj;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> y9egrwLNB05 = new List<StepInParamDef> { gB5gxOPJ7I8, zBvgxFey1en, k4pgxUWrJCx, wSxgxlndePA, G61gxiVy0W4, jJWgx3qjI8Y, zyWgxfT1DCk, qkogxzivdrj };

	private static readonly StepOutParamDef w7WgrtHYoKd;

	private static readonly StepOutParamDef CpigrgM8Q1H;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> C90grL7avND = new List<StepOutParamDef> { w7WgrtHYoKd, CpigrgM8Q1H };

	internal static oyi2lvone7QEWdEeRuW yUT0mxQ4H4P5hqWGaGYj;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return wMkgxQwWb6B;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return qiEgxjxYZvZ;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return JIKgxnfdeqi;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return byKgx4u5CL2;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return R9Hgx5E0ZDs;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return KPbgxD6Z4sU;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return gEygxdUqY92;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return gkdgxo4OdaZ;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return fusgxTq6R3X;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return yROgxMtxb9j;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return G60gxA4bbLl;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return y9egrwLNB05;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return C90grL7avND;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
		_003C_003Ec__DisplayClass55_.PyFS1NNN3G6 = step;
		_003C_003Ec__DisplayClass55_.i7US1Jhhenr = context;
		_003C_003Ec__DisplayClass55_.b0HS109XB3i = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass55_.i7US1Jhhenr, _003C_003Ec__DisplayClass55_.PyFS1NNN3G6, _003C_003Ec__DisplayClass55_.b0HS109XB3i, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass55_.Mg8S1uAufpH, (Action)null, (Action)null, qkogxzivdrj, w7WgrtHYoKd);
	}

	private static string dpIgxKplgfj(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, string string_5)
	{
		if (!(string_5 == "dojavascript"))
		{
			if (!(string_5 == "dojavascriptfile"))
			{
				throw new InvalidDataException("不支持的操作类型" + string_5 + "，可能您使用的Quicker版本过旧。");
			}
			return XActionHelper.GetTextParamValue(wSxgxlndePA, actionStep_0, actionExecuteContext_0);
		}
		return fEVgxxh5V5k(XActionHelper.GetTextParamValue(k4pgxUWrJCx, actionStep_0, actionExecuteContext_0));
	}

	private static string fEVgxxh5V5k(string string_5)
	{
		string text = Path.GetTempFileName() + ".jsx";
		File.WriteAllText(text, string_5);
		return text;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(zBvgxFey1en, step) + " " + XActionHelper.GetParamDisplayString(k4pgxUWrJCx, step);
	}

	private static void kW6gxrAHfG3(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, string string_5, string string_6)
	{
		string fileName = gL1gxpQfV2j(string_6);
		string text = dpIgxKplgfj(actionStep_0, actionExecuteContext_0, string_5);
		Process.Start(fileName, "-r " + text);
	}

	private static string gL1gxpQfV2j(string string_5)
	{
		Process[] processesByName = Process.GetProcessesByName(string_5);
		if (!processesByName.HasData())
		{
			throw new Exception("未找到" + string_5 + "进程，如果尚未启动，请先启动。 如果已启动，请确认程序名为" + string_5 + ".exe");
		}
		return processesByName[0].MainModule.FileName;
	}

	static oyi2lvone7QEWdEeRuW()
	{
		FY1gxBV4Vsd = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		gB5gxOPJ7I8 = new StepInParamDef
		{
			Key = "software",
			Name = "软件名称",
			Description = "要执行脚本的软件",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "Photoshop.Application",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Photoshop.Application", "Photoshop"),
				new SelectionItem("Illustrator.Application", "Illustrator"),
				new SelectionItem("afterfx", "After Effects")
			},
			IsControlField = false
		};
		zBvgxFey1en = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "dojavascript",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("dojavascript", "执行js脚本"),
				new SelectionItem("dojavascriptfile", "执行js脚本文件")
			},
			IsControlField = true
		};
		k4pgxUWrJCx = new StepInParamDef
		{
			Key = "script",
			Name = "脚本内容",
			Description = "要执行的js脚本代码。",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "dojavascript" },
			DefaultHighlightType = "JavaScript"
		};
		wSxgxlndePA = new StepInParamDef
		{
			Key = "scriptFile",
			Name = "脚本文件路径",
			Description = "js脚本文件的完整路径",
			IsRequired = false,
			IsMultiLine = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			ValidForList = new List<string> { "dojavascriptfile" }
		};
		G61gxiVy0W4 = new StepInParamDef
		{
			Key = "waitResp",
			Name = "等待执行结束",
			IsRequired = false,
			IsMultiLine = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = true
		};
		jJWgx3qjI8Y = new StepInParamDef
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
		zyWgxfT1DCk = new StepInParamDef
		{
			Key = "tryRunScriptUsingExe",
			Name = "接口失败后，尝试使用程序exe运行脚本文件",
			DefaultValue = false,
			Description = "使用运行程序并将脚本路径作为参数的方式执行脚本。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		qkogxzivdrj = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		w7WgrtHYoKd = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		CpigrgM8Q1H = new StepOutParamDef
		{
			Key = "output",
			Name = "脚本输出",
			Description = "仅通过接口执行脚本时支持返回内容。",
			Type = VarType.Text
		};
	}

	internal static bool oaC4i3Q4zbEVMuUbZKO9()
	{
		return yUT0mxQ4H4P5hqWGaGYj == null;
	}
}
