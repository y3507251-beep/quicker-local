using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using FontAwesome5;
using log4net;
using Quicker.Common;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Services;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class RunOrOpenStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_0
	{
		public ActionStep lRFSS67bZMC;

		public ActionExecuteContext fNvSSXH63pJ;

		public XAction MAaSSmiMqE3;

		internal static _003C_003Ec__DisplayClass59_0 VlR6PLW1S9kXDDwlJCLP;

		internal (bool isSuccess, string message, ActionStopFlag failReason) SLUSSblf8kS()
		{
			string text = XActionHelper.GetTextParamValue(zMjgLVmk8bI, lRFSS67bZMC, fNvSSXH63pJ);
			string text2 = XActionHelper.GetTextParamValue(uy8gL99K6A6, lRFSS67bZMC, fNvSSXH63pJ);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(ASggLhqtLGp, lRFSS67bZMC, fNvSSXH63pJ);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(pXIgLI0thwN, lRFSS67bZMC, fNvSSXH63pJ);
			bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(PB2gLWyf5Kd, lRFSS67bZMC, fNvSSXH63pJ);
			string textParamValue = XActionHelper.GetTextParamValue(vhGgLkn65xt, lRFSS67bZMC, fNvSSXH63pJ);
			string textParamValue2 = XActionHelper.GetTextParamValue(vuEgLGY2oSV, lRFSS67bZMC, fNvSSXH63pJ);
			string textParamValue3 = XActionHelper.GetTextParamValue(kL9gLZP0fyu, lRFSS67bZMC, fNvSSXH63pJ);
			string textParamValue4 = XActionHelper.GetTextParamValue(hI9gLewLBbI, lRFSS67bZMC, fNvSSXH63pJ);
			string textParamValue5 = XActionHelper.GetTextParamValue(eNmgLYMh6MA, lRFSS67bZMC, fNvSSXH63pJ);
			bool booleanParamValue4 = XActionHelper.GetBooleanParamValue(P9dgLsJ4TAE, lRFSS67bZMC, fNvSSXH63pJ);
			string text3 = XActionHelper.GetTextParamValue(C0rgLHjho8k, lRFSS67bZMC, fNvSSXH63pJ);
			string textParamValue6 = XActionHelper.GetTextParamValue(F41gL1tiv7U, lRFSS67bZMC, fNvSSXH63pJ);
			string textParamValue7 = XActionHelper.GetTextParamValue(D4jgLb5tJjh, lRFSS67bZMC, fNvSSXH63pJ);
			switch (text3)
			{
			case "false":
			case "true":
			case "0":
			case "1":
				text3 = "";
				break;
			}
			if ((text2 != null && text2.Contains("{cliptext}")) || (text != null && text.Contains("{cliptext}")))
			{
				string newString = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
				text2 = AppHelper.ReplacePattern(text2, "{cliptext}", newString);
				text = AppHelper.ReplacePattern(text, "{cliptext}", newString).Trim();
			}
			if ((text2 != null && text2.Contains("{context}")) || (text != null && text.Contains("{context}")))
			{
				string newString2 = string.Format(CultureInfo.InvariantCulture, "{0}", fNvSSXH63pJ.GetVarValue("context"));
				text2 = AppHelper.ReplacePattern(text2, "{context}", newString2);
				text = AppHelper.ReplacePattern(text, "{context}", newString2);
			}
			bool flag = XActionHelper.IsOutputParamSetted(v5rgLp2aDlc.Key, lRFSS67bZMC) || XActionHelper.IsOutputParamSetted(nDLgLQ8e7Ck.Key, lRFSS67bZMC) || XActionHelper.IsOutputParamSetted(qmqgLB2aeKV.Key, lRFSS67bZMC);
			try
			{
				string fileName = text;
				string arguments = text2;
				string activateWindowHotkey = text3;
				using Process process = ActionHelper.StartProcess(fileName, arguments, textParamValue2, textParamValue, booleanParamValue, false, textParamValue3, booleanParamValue2, flag, textParamValue4, textParamValue5, booleanParamValue4, activateWindowHotkey, textParamValue6, textParamValue7);
				if (XActionHelper.IsOutputParamSetted(niygLK7Rg1u.Key, lRFSS67bZMC) || XActionHelper.IsOutputParamSetted(RdogLxbUQhb.Key, lRFSS67bZMC) || XActionHelper.IsOutputParamSetted(wsRgLrP4SIx.Key, lRFSS67bZMC) || XActionHelper.IsOutputParamSetted(zbigLj9f9GK.Key, lRFSS67bZMC) || flag || booleanParamValue3)
				{
					if (process == null)
					{
						string item = "无法获得进程对象，所以无法得到Pid。";
						return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
					}
					XActionHelper.OutputResult(niygLK7Rg1u, lRFSS67bZMC, fNvSSXH63pJ, process.Id, MAaSSmiMqE3);
					if (XActionHelper.IsOutputParamSetted(RdogLxbUQhb.Key, lRFSS67bZMC) || XActionHelper.IsOutputParamSetted(wsRgLrP4SIx.Key, lRFSS67bZMC))
					{
						Thread.Sleep(50);
						XActionHelper.OutputResult(RdogLxbUQhb, lRFSS67bZMC, fNvSSXH63pJ, process.MainWindowHandle, MAaSSmiMqE3);
						XActionHelper.OutputResult(wsRgLrP4SIx, lRFSS67bZMC, fNvSSXH63pJ, process.MainWindowTitle, MAaSSmiMqE3);
					}
					if (flag)
					{
						_003C_003Ec__DisplayClass59_1 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_1
						{
							zyFSSrFF3HZ = new StringBuilder(),
							uyuSSB3F8b0 = new StringBuilder(),
							dd4SSpJWrtp = new StringBuilder()
						};
						int milliseconds = 36000000;
						try
						{
							process.OutputDataReceived += _003C_003Ec__DisplayClass59_.q6QSSKQhVys;
							process.ErrorDataReceived += _003C_003Ec__DisplayClass59_.YjcSSxE5qiB;
							process.BeginOutputReadLine();
							process.BeginErrorReadLine();
							if (process.WaitForExit(milliseconds))
							{
								Thread.Sleep(10);
								int exitCode = process.ExitCode;
							}
						}
						catch (Exception ex)
						{
							mOggL8MeMWy.Warn("执行进程出错,FileName=" + text + " Arguments=" + text2 + " 错误：" + ex.Message, ex);
							throw;
						}
						finally
						{
							process.OutputDataReceived -= _003C_003Ec__DisplayClass59_.q6QSSKQhVys;
							process.ErrorDataReceived -= _003C_003Ec__DisplayClass59_.YjcSSxE5qiB;
						}
						string text4 = _003C_003Ec__DisplayClass59_.uyuSSB3F8b0.ToString();
						string text5 = _003C_003Ec__DisplayClass59_.zyFSSrFF3HZ.ToString();
						string result = text5.Or(text4);
						XActionHelper.OutputResult(v5rgLp2aDlc, lRFSS67bZMC, fNvSSXH63pJ, result, MAaSSmiMqE3);
						XActionHelper.OutputResult(nDLgLQ8e7Ck, lRFSS67bZMC, fNvSSXH63pJ, text4, MAaSSmiMqE3);
						XActionHelper.OutputResult(qmqgLB2aeKV, lRFSS67bZMC, fNvSSXH63pJ, text5, MAaSSmiMqE3);
					}
					if (booleanParamValue3 && !process.HasExited)
					{
						process.WaitForExit();
					}
					if (XActionHelper.IsOutputParamSetted(zbigLj9f9GK.Key, lRFSS67bZMC))
					{
						if (!process.HasExited)
						{
							process.WaitForExit();
						}
						XActionHelper.OutputResult(zbigLj9f9GK, lRFSS67bZMC, fNvSSXH63pJ, process.ExitCode, MAaSSmiMqE3);
					}
				}
			}
			catch (Exception ex2)
			{
				throw new Exception("运行 " + text + " 失败：\r\n" + ex2.Message, ex2);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		static _003C_003Ec__DisplayClass59_0()
		{
		}

		internal static bool iuTb1CW1wlfbOE1t0uO3()
		{
			return VlR6PLW1S9kXDDwlJCLP == null;
		}

		internal static void a9krJUW1mvadXOMYj2Tn()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_1
	{
		public StringBuilder zyFSSrFF3HZ;

		public StringBuilder dd4SSpJWrtp;

		public StringBuilder uyuSSB3F8b0;

		private static _003C_003Ec__DisplayClass59_1 wBlkOGW1skQVtn6gieKR;

		internal void q6QSSKQhVys(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				zyFSSrFF3HZ.AppendLine(e.Data);
				dd4SSpJWrtp.AppendLine(e.Data);
			}
		}

		internal void YjcSSxE5qiB(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				uyuSSB3F8b0.AppendLine(e.Data);
				dd4SSpJWrtp.AppendLine(e.Data);
			}
		}

		internal static bool ApggAlW1Cd5NfGT5PD9P()
		{
			return wBlkOGW1skQVtn6gieKR == null;
		}
	}

	private static readonly ILog mOggL8MeMWy;

	[CompilerGenerated]
	private readonly IEnumerable<string> BU8gLaWEmrs = new string[7] { "软件", "文件", "文件夹", "命令行", "file", "folder", "software" };

	[CompilerGenerated]
	private readonly string eDhgL7FB6f4 = $"fa:{EFontAwesomeIcon.Solid_PaperPlane}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> UpZgLRd0E6W;

	[CompilerGenerated]
	private readonly string vg6gLqN08fy = "https://getquicker.net/KC/Help/Doc/run";

	[CompilerGenerated]
	private readonly bool IL7gLcGZUKd;

	private static readonly StepInParamDef zMjgLVmk8bI;

	private static readonly StepInParamDef kL9gLZP0fyu;

	private static readonly StepInParamDef uy8gL99K6A6;

	private static readonly StepInParamDef ASggLhqtLGp;

	private static readonly StepInParamDef hI9gLewLBbI;

	private static readonly StepInParamDef eNmgLYMh6MA;

	private static readonly StepInParamDef pXIgLI0thwN;

	private static readonly StepInParamDef PB2gLWyf5Kd;

	private static readonly StepInParamDef vhGgLkn65xt;

	private static readonly StepInParamDef vuEgLGY2oSV;

	private static readonly StepInParamDef P9dgLsJ4TAE;

	private static readonly StepInParamDef C0rgLHjho8k;

	private static readonly StepInParamDef F41gL1tiv7U;

	private static readonly StepInParamDef D4jgLb5tJjh;

	private static readonly StepInParamDef YXIgL6kJKF9;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> wNCgLXyva8p = new StepInParamDef[15]
	{
		zMjgLVmk8bI, uy8gL99K6A6, vhGgLkn65xt, vuEgLGY2oSV, ASggLhqtLGp, pXIgLI0thwN, PB2gLWyf5Kd, P9dgLsJ4TAE, C0rgLHjho8k, kL9gLZP0fyu,
		hI9gLewLBbI, eNmgLYMh6MA, F41gL1tiv7U, D4jgLb5tJjh, YXIgL6kJKF9
	};

	private static readonly StepOutParamDef BrPgLmygFi0;

	private static readonly StepOutParamDef niygLK7Rg1u;

	private static readonly StepOutParamDef RdogLxbUQhb;

	private static readonly StepOutParamDef wsRgLrP4SIx;

	private static readonly StepOutParamDef v5rgLp2aDlc;

	private static readonly StepOutParamDef qmqgLB2aeKV;

	private static readonly StepOutParamDef nDLgLQ8e7Ck;

	private static readonly StepOutParamDef zbigLj9f9GK;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> tBygLnqGAhA = new List<StepOutParamDef> { BrPgLmygFi0, niygLK7Rg1u, RdogLxbUQhb, wsRgLrP4SIx, v5rgLp2aDlc, qmqgLB2aeKV, nDLgLQ8e7Ck, zbigLj9f9GK };

	private static RunOrOpenStep K2oeVfQRtlLbAiCDkX1v;

	public string Key => "sys:run";

	public string Name => "运行或打开";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return BU8gLaWEmrs;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return eDhgL7FB6f4;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return UpZgLRd0E6W;
		}
	}

	public string Description => "运行软件或命令，打开文件、文件夹或网址。效果类似于在Windows“运行”对话框中执行命令。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return vg6gLqN08fy;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return IL7gLcGZUKd;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return wNCgLXyva8p;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return tBygLnqGAhA;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
		_003C_003Ec__DisplayClass59_.lRFSS67bZMC = step;
		_003C_003Ec__DisplayClass59_.fNvSSXH63pJ = context;
		_003C_003Ec__DisplayClass59_.MAaSSmiMqE3 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass59_.fNvSSXH63pJ, _003C_003Ec__DisplayClass59_.lRFSS67bZMC, _003C_003Ec__DisplayClass59_.MAaSSmiMqE3, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass59_.SLUSSblf8kS, (Action)null, (Action)null, YXIgL6kJKF9, BrPgLmygFi0);
	}

	public string GetSummary(ActionStep step)
	{
		return "运行：" + XActionHelper.GetParamDisplayString(zMjgLVmk8bI, step) + " " + XActionHelper.GetParamDisplayString(uy8gL99K6A6, step);
	}

	public static ActionStep CreateStep(ProcessActionParams processActionParams)
	{
		return new ActionStep
		{
			StepRunnerKey = "sys:run",
			InputParams = 
			{
				[zMjgLVmk8bI.Key] = new ActionStepParam
				{
					Value = processActionParams.FileName
				},
				[kL9gLZP0fyu.Key] = new ActionStepParam
				{
					Value = processActionParams.AlternativePaths
				},
				[uy8gL99K6A6.Key] = new ActionStepParam
				{
					Value = processActionParams.Arguments
				},
				[ASggLhqtLGp.Key] = new ActionStepParam
				{
					Value = ActionConverter.BoolToString(processActionParams.RunAsAdmin)
				},
				[pXIgLI0thwN.Key] = new ActionStepParam
				{
					Value = ActionConverter.BoolToString(false)
				},
				[PB2gLWyf5Kd.Key] = new ActionStepParam
				{
					Value = ActionConverter.BoolToString(processActionParams.WaitForExit)
				},
				[vhGgLkn65xt.Key] = new ActionStepParam
				{
					Value = processActionParams.GetWorkingDir()
				},
				[vuEgLGY2oSV.Key] = new ActionStepParam
				{
					Value = processActionParams.WindowStyle
				},
				[P9dgLsJ4TAE.Key] = new ActionStepParam
				{
					Value = ActionConverter.BoolToString(processActionParams.ActivateWindowIfRunning)
				},
				[C0rgLHjho8k.Key] = new ActionStepParam
				{
					Value = processActionParams.ActivateWindowHotkey
				}
			}
		};
	}

	static RunOrOpenStep()
	{
		mOggL8MeMWy = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		zMjgLVmk8bI = new StepInParamDef
		{
			Key = "path",
			Name = "路径或命令",
			Description = "要运行的命令或打开的文件路径、网址、URI等。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextToolsContextHint = new TextToolsContextHint
			{
				FileDialogFilter = "应用程序文件|*.exe"
			},
			TextTools = new List<TextToolType>
			{
				TextToolType.SelectProcessPath,
				TextToolType.SelectSingleFile
			},
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		kL9gLZP0fyu = new StepInParamDef
		{
			Key = "alternativePath",
			Name = "备用路径",
			Description = "文件在多个电脑上路径不同时，使用备用路径填写其他电脑上的文件路径。",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.Input,
			TextToolsContextHint = new TextToolsContextHint
			{
				FileDialogFilter = "应用程序文件|*.exe"
			},
			TextTools = new List<TextToolType>
			{
				TextToolType.SelectProcessPath,
				TextToolType.SelectSingleFile
			},
			ReplaceMode = TextToolsReplaceMode.AppendWithNewline
		};
		uy8gL99K6A6 = new StepInParamDef
		{
			Key = "arg",
			Name = "参数(可选)",
			Description = "程序参数",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		ASggLhqtLGp = new StepInParamDef
		{
			Key = "runas",
			Name = "以管理员身份运行",
			DefaultValue = false,
			Description = "以管理员身份运行软件或命令。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		hI9gLewLBbI = new StepInParamDef
		{
			Key = "username",
			Name = "用户名",
			DefaultValue = "",
			Description = "使用指定的用户运行",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		eNmgLYMh6MA = new StepInParamDef
		{
			Key = "password",
			Name = "密码",
			DefaultValue = "",
			Description = "用户名对应的密码",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		pXIgLI0thwN = new StepInParamDef
		{
			Key = "waitInputIdle",
			Name = "等待启动完成",
			DefaultValue = false,
			Description = "等待进程完成后了初始化，可以接受用户输入。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		PB2gLWyf5Kd = new StepInParamDef
		{
			Key = "waitExit",
			Name = "等待进程结束",
			DefaultValue = false,
			Description = "等待进程结束后再执行后续操作步骤。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		vhGgLkn65xt = new StepInParamDef
		{
			Key = "setWorkingDir",
			Name = "工作目录",
			DefaultValue = "1",
			Description = "可输入 0或留空(不设置,由windows默认)、1(软件所在目录)、具体的工作目录路径。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		vuEgLGY2oSV = new StepInParamDef
		{
			Key = "windowStyle",
			Name = "窗口风格",
			DefaultValue = "0",
			Description = "设置期望的窗口风格，是否有效依赖于具体的软件。",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("0", "普通(Normal)"),
				new SelectionItem("1", "隐藏(Hidden)"),
				new SelectionItem("2", "最小化(Minimized)"),
				new SelectionItem("3", "最大化(Maximized)")
			},
			IsAdvanced = true
		};
		P9dgLsJ4TAE = new StepInParamDef
		{
			Key = "activateWindowIfRunning",
			Name = "如果程序已运行则尝试激活窗口",
			DefaultValue = false,
			Description = "如果程序已经在运行，则尝试激活其窗口。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = false
		};
		C0rgLHjho8k = new StepInParamDef
		{
			Key = "activateWindowHotkey",
			Name = "激活窗口快捷键",
			DefaultValue = "",
			Description = "对于支持快捷键激活窗口的软件，设置该快捷键。支持“模拟按键B”语法。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = false,
			TextTools = new List<TextToolType> { TextToolType.SelectSendKeysData }
		};
		F41gL1tiv7U = new StepInParamDef
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
			},
			IsAdvanced = true
		};
		D4jgLb5tJjh = new StepInParamDef
		{
			Key = "envVariables",
			Name = "环境变量",
			DefaultValue = "",
			Description = "为应用程序设置特定的环境变量值。每行一个，格式“变量名=值”，如“CONFIG_FILE=d:\\config.json”",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			IsAdvanced = true
		};
		YXIgL6kJKF9 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		BrPgLmygFi0 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		niygLK7Rg1u = new StepOutParamDef
		{
			Name = "PID",
			Description = "进程ID",
			Key = "pid",
			Type = VarType.Integer
		};
		RdogLxbUQhb = new StepOutParamDef
		{
			Key = "mainWinHandle",
			Name = "主窗口句柄",
			Description = "进程的主窗口句柄",
			Type = VarType.Integer
		};
		wsRgLrP4SIx = new StepOutParamDef
		{
			Key = "mainWinTitle",
			Name = "主窗口标题",
			Description = "",
			Type = VarType.Text
		};
		v5rgLp2aDlc = new StepOutParamDef
		{
			Key = "stdout",
			Name = "控制台输出",
			Description = "慎用！仅用于控制台程序，会自动等待进程结束。输出stdout，为空时输出stderr。",
			Type = VarType.Text
		};
		qmqgLB2aeKV = new StepOutParamDef
		{
			Key = "stdoutOnly",
			Name = "stdout输出",
			Description = "慎用！捕获控制台程序的stdout输出，会自动等待进程结束",
			Type = VarType.Text
		};
		nDLgLQ8e7Ck = new StepOutParamDef
		{
			Key = "stderr",
			Name = "stderr输出",
			Description = "慎用！捕获控制台程序的stderr输出，会自动等待进程结束",
			Type = VarType.Text
		};
		zbigLj9f9GK = new StepOutParamDef
		{
			Key = "exitCode",
			Name = "退出代码",
			Description = "进程的ExitCode，会自动等待进程结束。",
			Type = VarType.Integer
		};
	}

	internal static bool rMiEIeQRSjHQwPHOblR5()
	{
		return K2oeVfQRtlLbAiCDkX1v == null;
	}
}
