using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using log4net;
using Quicker.Common;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Services;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class RunScriptStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public ActionStep XxCS73SFw1U;

		public ActionExecuteContext rM2S7f5SgmU;

		public XAction VnTS7zaCt7o;

		private static _003C_003Ec__DisplayClass51_0 x3WksUWkJwYTtF8vk4I5;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Lc4S7i8ZD9f()
		{
			string textParamValue = XActionHelper.GetTextParamValue(FFDgyEgnnYQ, XxCS73SFw1U, rM2S7f5SgmU);
			string textParamValue2 = XActionHelper.GetTextParamValue(cRWgyynEQP1, XxCS73SFw1U, rM2S7f5SgmU);
			string textParamValue3 = XActionHelper.GetTextParamValue(hwcgy8mU2yh, XxCS73SFw1U, rM2S7f5SgmU);
			string textParamValue4 = XActionHelper.GetTextParamValue(IiPgyaq0upU, XxCS73SFw1U, rM2S7f5SgmU);
			string textParamValue5 = XActionHelper.GetTextParamValue(zn4gy7MIhKw, XxCS73SFw1U, rM2S7f5SgmU);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(RcvgyqQiCVh, XxCS73SFw1U, rM2S7f5SgmU);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(atsgycv0vtY, XxCS73SFw1U, rM2S7f5SgmU);
			string textParamValue6 = XActionHelper.GetTextParamValue(IO7gyV2SPlF, XxCS73SFw1U, rM2S7f5SgmU);
			string textParamValue7 = XActionHelper.GetTextParamValue(mGIgyRkefso, XxCS73SFw1U, rM2S7f5SgmU);
			bool flag = XActionHelper.IsOutputParamSetted(bORgyh6Jq8a.Key, XxCS73SFw1U) || XActionHelper.IsOutputParamSetted(EOngyYUkORt.Key, XxCS73SFw1U) || XActionHelper.IsOutputParamSetted(mDigyenOO2Y.Key, XxCS73SFw1U);
			string textParamValue8 = XActionHelper.GetTextParamValue(o4pgyZ3mGKO, XxCS73SFw1U, rM2S7f5SgmU);
			if (booleanParamValue && flag)
			{
				rM2S7f5SgmU.ActionLogger.LogWarning("输出到控制台和以管理员身份运行同时使用可能会无法正常工作。");
				AppHelper.ShowWarning("输出到控制台和以管理员身份运行同时使用可能会无法正常工作。");
			}
			Encoding encoding = Encoding.Default;
			if (textParamValue6 == "UTF8-NOBOM")
			{
				encoding = new UTF8Encoding(false);
			}
			else if (!string.IsNullOrEmpty(textParamValue6) && !textParamValue6.Equals("default", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					encoding = Encoding.GetEncoding(textParamValue6);
				}
				catch
				{
					yDRgyumBhn9.Warn(CommonStrings.Common_Err_UnknownEncoding + textParamValue6);
					rM2S7f5SgmU.ActionLogger.LogWarning(CommonStrings.Common_Err_UnknownEncoding + textParamValue6);
					encoding = Encoding.UTF8;
				}
			}
			else
			{
				encoding = Encoding.Default;
			}
			ScriptRunner scriptRunner = new ScriptRunner(textParamValue, textParamValue2, textParamValue3, textParamValue4, booleanParamValue, booleanParamValue2, true, encoding, textParamValue7, textParamValue8, textParamValue5, 36000000, rM2S7f5SgmU.ActionTitle);
			try
			{
				ProcessResult processResult = scriptRunner.Execute(flag);
				rM2S7f5SgmU.ActionLogger.LogInfo("脚本文件路径：" + scriptRunner.ScriptFile);
				if (flag)
				{
					XActionHelper.OutputResult(bORgyh6Jq8a, XxCS73SFw1U, rM2S7f5SgmU, processResult.StdOutMerged, VnTS7zaCt7o);
					XActionHelper.OutputResult(EOngyYUkORt, XxCS73SFw1U, rM2S7f5SgmU, processResult.StdError, VnTS7zaCt7o);
					XActionHelper.OutputResult(mDigyenOO2Y, XxCS73SFw1U, rM2S7f5SgmU, processResult.StdOut, VnTS7zaCt7o);
				}
			}
			catch (Exception ex)
			{
				rM2S7f5SgmU.ActionLogger?.LogInfo("StackTrace:" + ex.Message);
				return (isSuccess: false, message: "执行脚本出错：" + ex.Message, failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool YLYK74Wkk8ITMVEVIRxK()
		{
			return x3WksUWkJwYTtF8vk4I5 == null;
		}
	}

	public const string UTF8_NOBOM_NAME = "UTF8-NOBOM";

	private static readonly ILog yDRgyumBhn9;

	private static List<string> kFfgyN1gHGx;

	[CompilerGenerated]
	private readonly string y4ZgyJVQf1F = $"fa:{EFontAwesomeIcon.Light_Scroll}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Lkwgy0pLcJQ;

	[CompilerGenerated]
	private readonly string lI3gyC7K8O5 = "https://getquicker.net/KC/Help/Doc/runScript";

	[CompilerGenerated]
	private readonly bool UC7gyPVWpH1;

	private static readonly StepInParamDef FFDgyEgnnYQ;

	private static readonly StepInParamDef cRWgyynEQP1;

	private static readonly StepInParamDef hwcgy8mU2yh;

	private static readonly StepInParamDef IiPgyaq0upU;

	private static readonly StepInParamDef zn4gy7MIhKw;

	private static readonly StepInParamDef mGIgyRkefso;

	private static readonly StepInParamDef RcvgyqQiCVh;

	private static readonly StepInParamDef atsgycv0vtY;

	private static readonly StepInParamDef IO7gyV2SPlF;

	private static readonly StepInParamDef o4pgyZ3mGKO;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> a8pgy95TMlA = new StepInParamDef[10] { FFDgyEgnnYQ, cRWgyynEQP1, hwcgy8mU2yh, IO7gyV2SPlF, IiPgyaq0upU, zn4gy7MIhKw, o4pgyZ3mGKO, mGIgyRkefso, RcvgyqQiCVh, atsgycv0vtY };

	private static readonly StepOutParamDef bORgyh6Jq8a;

	private static readonly StepOutParamDef mDigyenOO2Y;

	private static readonly StepOutParamDef EOngyYUkORt;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> UQQgyIWb5hC = new StepOutParamDef[3] { bORgyh6Jq8a, mDigyenOO2Y, EOngyYUkORt };

	private static RunScriptStep xWu1LiQxlIeD1eKm63T2;

	public string Key => "sys:runScript";

	public string Name => "运行脚本";

	public IEnumerable<string> KeyWords => kFfgyN1gHGx;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return y4ZgyJVQf1F;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Lkwgy0pLcJQ;
		}
	}

	public string Description => "运行脚本。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return lI3gyC7K8O5;
		}
	}

	public bool IsRisky => true;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return UC7gyPVWpH1;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return a8pgy95TMlA;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return UQQgyIWb5hC;
		}
	}

	static RunScriptStep()
	{
		yDRgyumBhn9 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		kFfgyN1gHGx = new List<string>();
		FFDgyEgnnYQ = new StepInParamDef
		{
			Key = "script",
			Name = "脚本内容",
			Description = "要运行的脚本内容",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		cRWgyynEQP1 = new StepInParamDef
		{
			Key = "type",
			Name = "脚本类型",
			Description = "要执行的脚本类型",
			DefaultValue = "CMD_K",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("CMD_K", "CMD命令 (完成后保留窗口)"),
				new SelectionItem("CMD_C", "CMD命令 (完成后关闭窗口)"),
				new SelectionItem("CMD_H", "CMD命令 (隐藏命令行窗口)"),
				new SelectionItem("BAT", "BAT批处理脚本(.bat)"),
				new SelectionItem("CMD_F", "CMD批处理脚本(.cmd)"),
				new SelectionItem("PS", "PowerShell脚本(.ps1)"),
				new SelectionItem("AHK", "AutoHotKey脚本(.ahk)"),
				new SelectionItem("CUSTOM", "自定义脚本类型")
			},
			IsControlField = true
		};
		hwcgy8mU2yh = new StepInParamDef
		{
			Key = "ext",
			Name = "扩展名",
			Description = "自定义脚本文件的扩展名(如: .ps1 )",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = false,
			ValidForList = new List<string> { "CUSTOM" }
		};
		IiPgyaq0upU = new StepInParamDef
		{
			Key = "runner",
			Name = "使用指定软件",
			Description = "使用指定的程序运行脚本。如果双击脚本可以直接运行，则不需要指定。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = false,
			ValidForList = new List<string> { "CUSTOM" }
		};
		zn4gy7MIhKw = new StepInParamDef
		{
			Key = "argTemplate",
			Name = "命令行参数模板",
			Description = "使用指定软件时指定命令行参数的格式。%FILE% 代替脚本文件的路径。",
			DefaultValue = "%FILE%",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = false,
			ValidForList = new List<string> { "CUSTOM" }
		};
		mGIgyRkefso = new StepInParamDef
		{
			Key = "workingDir",
			Name = "工作目录",
			DefaultValue = "",
			Description = "不填写（自动为资源管理器的当前目录或桌面目录）或具体的工作目录路径。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		RcvgyqQiCVh = new StepInParamDef
		{
			Key = "runAsAdmin",
			DefaultValue = false,
			Description = "是否以管理员身份运行脚本。隐藏窗口或输出控制台内容时，不支持以管理员身份运行。",
			IsRequired = false,
			Name = "以管理员身份运行",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		atsgycv0vtY = new StepInParamDef
		{
			Key = "waitToExit",
			DefaultValue = false,
			Description = "等待此进程结束后再进行后续操作",
			IsRequired = false,
			Name = "等待进程结束",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		IO7gyV2SPlF = new StepInParamDef
		{
			Key = "encoding",
			Name = "文件编码",
			Description = "写入文件的编码格式",
			DefaultValue = "default",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(Encoding.UTF8.WebName, "UTF8 (有BOM)"),
				new SelectionItem("UTF8-NOBOM", "UTF8 (无BOM)"),
				new SelectionItem(Encoding.Unicode.WebName, "UTF-16 LE"),
				new SelectionItem(Encoding.BigEndianUnicode.WebName, "UTF-16 BE"),
				new SelectionItem(Encoding.ASCII.WebName, "ASCII"),
				new SelectionItem(Encoding.UTF7.WebName, "UTF7"),
				new SelectionItem(Encoding.UTF32.WebName, "UTF32"),
				new SelectionItem("default", "系统默认(" + Encoding.Default.WebName + ")")
			}
		};
		o4pgyZ3mGKO = new StepInParamDef
		{
			Key = "outputEncoding",
			Name = "控制台输出编码",
			Description = "控制台输出编码。如果输出遇到乱码，尝试修改此选项。",
			DefaultValue = "oem",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("utf8", "UTF8"),
				new SelectionItem("oem", "OEM")
			}
		};
		bORgyh6Jq8a = new StepOutParamDef
		{
			Key = "stdout",
			Name = "控制台输出",
			Description = "捕获控制台输出(输出stdout，为空时输出stderr)，会自动等待进程结束。输出此内容时，命令行窗口将不显示。",
			Type = VarType.Text
		};
		mDigyenOO2Y = new StepOutParamDef
		{
			Key = "stdoutOnly",
			Name = "标准输出",
			Description = "捕获标准输出(stdout)，会自动等待进程结束。输出此内容时，命令行窗口将不显示。",
			Type = VarType.Text
		};
		EOngyYUkORt = new StepOutParamDef
		{
			Key = "stderr",
			Name = "错误输出",
			Description = "捕获错误输出(stderr)，会自动等待进程结束。输出此内容时，命令行窗口将不显示。",
			Type = VarType.Text
		};
		foreach (SelectionItem selectionItem in cRWgyynEQP1.SelectionItems)
		{
			kFfgyN1gHGx.Add(selectionItem.Name);
			kFfgyN1gHGx.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
		_003C_003Ec__DisplayClass51_.XxCS73SFw1U = step;
		_003C_003Ec__DisplayClass51_.rM2S7f5SgmU = context;
		_003C_003Ec__DisplayClass51_.VnTS7zaCt7o = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass51_.rM2S7f5SgmU, _003C_003Ec__DisplayClass51_.XxCS73SFw1U, _003C_003Ec__DisplayClass51_.VnTS7zaCt7o, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass51_.Lc4S7i8ZD9f, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	public static ActionStep CreateStep(RunScriptActionParam scriptActionParam)
	{
		return new ActionStep
		{
			StepRunnerKey = "sys:runScript",
			InputParams = 
			{
				[FFDgyEgnnYQ.Key] = new ActionStepParam
				{
					Value = scriptActionParam.Script
				},
				[cRWgyynEQP1.Key] = new ActionStepParam
				{
					Value = scriptActionParam.Type
				},
				[hwcgy8mU2yh.Key] = new ActionStepParam
				{
					Value = scriptActionParam.Ext
				},
				[IiPgyaq0upU.Key] = new ActionStepParam
				{
					Value = ""
				},
				[mGIgyRkefso.Key] = new ActionStepParam
				{
					Value = scriptActionParam.WorkingDir
				},
				[RcvgyqQiCVh.Key] = new ActionStepParam
				{
					Value = ActionConverter.BoolToString(scriptActionParam.RunAsAdmin)
				},
				[atsgycv0vtY.Key] = new ActionStepParam
				{
					Value = ActionConverter.BoolToString(scriptActionParam.WaitForExit)
				},
				[IO7gyV2SPlF.Key] = new ActionStepParam
				{
					Value = scriptActionParam.Encoding
				}
			}
		};
	}

	internal static bool zNIBa1QxZwHUVSyk239y()
	{
		return xWu1LiQxlIeD1eKm63T2 == null;
	}
}
