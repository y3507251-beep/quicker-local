using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using bO46JfWAenppOQ94A2q;
using FontAwesome5;
using log4net;
using LPAgent.Domain;
using Microsoft.Win32;
using Quicker.Actions.XActions.StepRunners;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace Wc5pWrorOjb6k1eByFk;

internal class ROWAp7oCqoO68Ncbqn7 : BaseMultiOperationStep, IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Q96S6Y02syk;

		public static StepOperation.GetSummaryFunc ryIS6IGDTF6;

		public static StepOperation.GetSummaryFunc vnJS6W63OL2;

		public static StepOperation.GetSummaryFunc p9nS6kKiubY;

		public static StepOperation.GetSummaryFunc E6QS6GsV2s7;

		public static Action Y2MS6sv32F5;

		private static _003C_003Ec zux3KhWljlaGh7HXSFf6;

		static _003C_003Ec()
		{
			Q96S6Y02syk = new _003C_003Ec();
		}

		internal string GF3S6VCTcrJ(ActionStep step)
		{
			return "执行VBA脚本(" + XActionHelper.GetParamDisplayString(t5igB4esFdV, step) + ")";
		}

		internal string DGBS6ZggK4R(ActionStep step)
		{
			return "设置格式(" + XActionHelper.GetParamDisplayString(t5igB4esFdV, step) + ")";
		}

		internal string BoDS69WaGOU(ActionStep step)
		{
			return "执行界面命令(" + XActionHelper.GetParamDisplayString(t5igB4esFdV, step) + ")";
		}

		internal string VhLS6hetdaE(ActionStep step)
		{
			return "获取ProgId(" + XActionHelper.GetParamDisplayString(t5igB4esFdV, step) + ")";
		}

		internal void t67S6eN7yXC()
		{
			MessageBoxHelper.Show("VBA运行环境未开启，请开启后继续。\r\n开启方法：在各个Office软件中，点击【文件】-【选项】-【信任中心】-【信任中心设置】-【宏设置】，启用【信任对VBA工程对象模型的访问】选项。", "VBA运行环境", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}

		internal static void kBLNk0WlEdD2woiqiUou()
		{
		}

		internal static bool vmlUKLWlDfsL3AWr58hK()
		{
			return zux3KhWljlaGh7HXSFf6 == null;
		}
	}

	private static readonly ILog bm5gBK5uLEf;

	[CompilerGenerated]
	private readonly IEnumerable<string> Hf0gBxLCg1X = new string[8] { "word", "excel", "ppt", "power point", "wps", "et", "wpp", "vba" };

	[CompilerGenerated]
	private readonly string zdigBrdaxwL = $"fa:{EFontAwesomeIcon.Brands_Microsoft}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory zgugBpdgMmn = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> XRRgBBI0BvB;

	[CompilerGenerated]
	private readonly string SUVgBQbJHhh = "https://getquicker.net/KC/Help/Doc/officehelper";

	[CompilerGenerated]
	private readonly bool NR1gBjBu3uF;

	[CompilerGenerated]
	private readonly bool sZcgBnqi4hH;

	public static StepInParamDef t5igB4esFdV;

	public static StepInParamDef fE0gB5iblnC;

	public static StepInParamDef QfIgBD7s0oi;

	public static StepInParamDef YOPgBdZQTMI;

	public static StepInParamDef GJRgBoBIlFk;

	private static readonly StepInParamDef FiKgBTbDNAQ;

	private static readonly StepOutParamDef s89gBMVmokY;

	private static readonly StepOutParamDef T6kgBA04spJ;

	private static ROWAp7oCqoO68Ncbqn7 a55r3WQHuS6amKE49SU5;

	public string Key => "sys:officehelper";

	public string Name => "Office软件辅助";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return Hf0gBxLCg1X;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return zdigBrdaxwL;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return zgugBpdgMmn;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return XRRgBBI0BvB;
		}
	}

	public string Description => "辅助控制Office软件";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return SUVgBQbJHhh;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return NR1gBjBu3uF;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return sZcgBnqi4hH;
		}
	}

	public ROWAp7oCqoO68Ncbqn7()
	{
		SetupParams(new StepInParamDef[6] { t5igB4esFdV, fE0gB5iblnC, QfIgBD7s0oi, YOPgBdZQTMI, GJRgBoBIlFk, FiKgBTbDNAQ }, new StepOutParamDef[2] { s89gBMVmokY, T6kgBA04spJ });
		AddOperation(new StepOperation
		{
			Key = "execVBA",
			Title = "执行VBA宏代码",
			GetSummary = (_003C_003Ec.ryIS6IGDTF6 ?? (_003C_003Ec.ryIS6IGDTF6 = _003C_003Ec.Q96S6Y02syk.GF3S6VCTcrJ)),
			InputParams = { t5igB4esFdV, fE0gB5iblnC, GJRgBoBIlFk, FiKgBTbDNAQ },
			OutputParams = { s89gBMVmokY },
			Execute = qwagB6e1njE
		}, true);
		AddOperation(new StepOperation
		{
			Key = "setFormats",
			Title = "设置格式/对象属性赋值",
			GetSummary = (_003C_003Ec.vnJS6W63OL2 ?? (_003C_003Ec.vnJS6W63OL2 = _003C_003Ec.Q96S6Y02syk.DGBS6ZggK4R)),
			InputParams = { t5igB4esFdV, YOPgBdZQTMI, GJRgBoBIlFk, FiKgBTbDNAQ },
			Execute = eJegB1S5rZL
		});
		AddOperation(new StepOperation
		{
			Key = "executeMsoCommand",
			Title = "执行界面命令",
			GetSummary = (_003C_003Ec.p9nS6kKiubY ?? (_003C_003Ec.p9nS6kKiubY = _003C_003Ec.Q96S6Y02syk.BoDS69WaGOU)),
			InputParams = { t5igB4esFdV, QfIgBD7s0oi, GJRgBoBIlFk, FiKgBTbDNAQ },
			Execute = llvgBsLM181
		});
		AddOperation(new StepOperation
		{
			Key = "getProgId",
			Title = "获取ProgId",
			GetSummary = (_003C_003Ec.E6QS6GsV2s7 ?? (_003C_003Ec.E6QS6GsV2s7 = _003C_003Ec.Q96S6Y02syk.VhLS6hetdaE)),
			InputParams = { t5igB4esFdV },
			OutputParams = { T6kgBA04spJ },
			Execute = LbBgBHA7Mkn
		});
	}

	private StepExecuteResult llvgBsLM181(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_1)
	{
		string textParamValue = XActionHelper.GetTextParamValue(t5igB4esFdV, actionStep_0, actionExecuteContext_0);
		string text = DI5gBmeeO4A(textParamValue);
		if (!K8ugBbmH5cY(text))
		{
			return StepExecuteResult.Failed("当前电脑缺少程序组件，未找到ProgId：" + text);
		}
		actionExecuteContext_0.ActionLogger.LogInfo("ProgId=" + text);
		string textParamValue2 = XActionHelper.GetTextParamValue(QfIgBD7s0oi, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(GJRgBoBIlFk, actionStep_0, actionExecuteContext_0);
		int num = 0;
		if (!futSdEQHoqVAySHCA4u3())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			int maxWaitMs = (int)XActionHelper.GetIntegerParamValue(FiKgBTbDNAQ, actionStep_0, actionExecuteContext_0);
			Command command_ = new Command
			{
				Runner = "office",
				Operation = "mso",
				SubTarget = text,
				Data = textParamValue2,
				WaitResp = booleanParamValue,
				MaxWaitMs = maxWaitMs
			};
			Response response = y2RHWHW5SANm8yApQAU.PeBtgjCTonj().PFotgQdV5Ru(command_);
			if (booleanParamValue)
			{
				if (response == null)
				{
					return StepExecuteResult.Failed("超时未收到低权限代理程序响应。");
				}
				if (!response.IsSuccess)
				{
					actionExecuteContext_0.ActionLogger.LogWarning(response.Message + "  StackTrace:" + response.StackTrace);
					return StepExecuteResult.Failed("命令返回失败，错误：" + response.Message);
				}
				XActionHelper.OutputResult(s89gBMVmokY, actionStep_0, actionExecuteContext_0, response.Data, xaction_0);
			}
			else
			{
				XActionHelper.OutputResult(s89gBMVmokY, actionStep_0, actionExecuteContext_0, "", xaction_0);
			}
			return StepExecuteResult.Success;
		}
		}
	}

	private StepExecuteResult LbBgBHA7Mkn(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_1)
	{
		string textParamValue = XActionHelper.GetTextParamValue(t5igB4esFdV, actionStep_0, actionExecuteContext_0);
		string text = DI5gBmeeO4A(textParamValue);
		if (!K8ugBbmH5cY(text))
		{
			return StepExecuteResult.Failed("当前电脑缺少程序组件，未找到ProgId：" + text);
		}
		actionExecuteContext_0.ActionLogger.LogInfo("ProgId=" + text);
		XActionHelper.OutputResult(T6kgBA04spJ, actionStep_0, actionExecuteContext_0, text, xaction_0);
		return StepExecuteResult.Success;
	}

	private StepExecuteResult eJegB1S5rZL(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_1)
	{
		string textParamValue = XActionHelper.GetTextParamValue(t5igB4esFdV, actionStep_0, actionExecuteContext_0);
		string text = DI5gBmeeO4A(textParamValue);
		if (!K8ugBbmH5cY(text))
		{
			return StepExecuteResult.Failed("当前电脑缺少程序组件，未找到ProgId：" + text);
		}
		string textParamValue2 = XActionHelper.GetTextParamValue(YOPgBdZQTMI, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(GJRgBoBIlFk, actionStep_0, actionExecuteContext_0);
		int maxWaitMs = (int)XActionHelper.GetIntegerParamValue(FiKgBTbDNAQ, actionStep_0, actionExecuteContext_0);
		Command command_ = new Command
		{
			Runner = "office",
			Operation = "set_formats",
			SubTarget = text,
			Data = textParamValue2,
			WaitResp = booleanParamValue,
			MaxWaitMs = maxWaitMs
		};
		int num = 0;
		if (!futSdEQHoqVAySHCA4u3())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			Response response = y2RHWHW5SANm8yApQAU.PeBtgjCTonj().PFotgQdV5Ru(command_);
			if (booleanParamValue)
			{
				if (response == null)
				{
					return StepExecuteResult.Failed("超时未收到低权限代理程序响应。");
				}
				if (!response.IsSuccess)
				{
					actionExecuteContext_0.ActionLogger.LogWarning(response.Message + "  StackTrace:" + response.StackTrace);
					return StepExecuteResult.Failed("命令返回失败，错误：" + response.Message);
				}
				XActionHelper.OutputResult(s89gBMVmokY, actionStep_0, actionExecuteContext_0, response.Data, xaction_0);
			}
			else
			{
				XActionHelper.OutputResult(s89gBMVmokY, actionStep_0, actionExecuteContext_0, "", xaction_0);
			}
			return StepExecuteResult.Success;
		}
		}
	}

	private static bool K8ugBbmH5cY(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException("progID");
		}
		try
		{
			using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(string_1);
			return registryKey != null;
		}
		catch (Exception ex)
		{
			bm5gBK5uLEf.Warn("判断ProgID是否合法出错：" + ex.Message, ex);
			return false;
		}
	}

	private StepExecuteResult qwagB6e1njE(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_1)
	{
		string textParamValue = XActionHelper.GetTextParamValue(t5igB4esFdV, actionStep_0, actionExecuteContext_0);
		string text = DI5gBmeeO4A(textParamValue);
		if (!K8ugBbmH5cY(text))
		{
			return StepExecuteResult.Failed("当前电脑缺少程序组件，未找到ProgId：" + text);
		}
		actionExecuteContext_0.ActionLogger.LogInfo("ProgId=" + text);
		vZlgBXUmQ88(text);
		string textParamValue2 = XActionHelper.GetTextParamValue(fE0gB5iblnC, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(GJRgBoBIlFk, actionStep_0, actionExecuteContext_0);
		int maxWaitMs = (int)XActionHelper.GetIntegerParamValue(FiKgBTbDNAQ, actionStep_0, actionExecuteContext_0);
		Command command_ = new Command
		{
			Runner = "office",
			Operation = "exec_vba_code",
			SubTarget = text,
			Data = textParamValue2,
			WaitResp = booleanParamValue,
			MaxWaitMs = maxWaitMs
		};
		Response response = y2RHWHW5SANm8yApQAU.PeBtgjCTonj().PFotgQdV5Ru(command_);
		if (booleanParamValue)
		{
			if (response == null)
			{
				return StepExecuteResult.Failed("超时未收到低权限代理程序响应。");
			}
			if (!response.IsSuccess)
			{
				int num = 0;
				if (a55r3WQHuS6amKE49SU5 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					actionExecuteContext_0.ActionLogger.LogWarning(response.Message + "  StackTrace:" + response.StackTrace);
					return StepExecuteResult.Failed("命令返回失败，错误：" + response.Message);
				}
			}
			XActionHelper.OutputResult(s89gBMVmokY, actionStep_0, actionExecuteContext_0, response.Data, xaction_0);
		}
		else
		{
			XActionHelper.OutputResult(s89gBMVmokY, actionStep_0, actionExecuteContext_0, "", xaction_0);
		}
		return StepExecuteResult.Success;
	}

	private void vZlgBXUmQ88(string string_1)
	{
		string text = "";
		string text2 = "";
		switch (string_1)
		{
		default:
			return;
		case "Powerpoint.Application":
			text = "powerpnt";
			text2 = "Software\\Microsoft\\Office\\%VERSION%\\PowerPoint\\Security";
			break;
		case "Word.Application":
			text = "winword";
			text2 = "Software\\Microsoft\\Office\\%VERSION%\\Word\\Security";
			break;
		case "Excel.Application":
			text = "excel";
			text2 = "Software\\Microsoft\\Office\\%VERSION%\\Excel\\Security";
			break;
		}
		using Process process = Process.GetProcessesByName(text).FirstOrDefault();
		if (process == null)
		{
			return;
		}
		FileVersionInfo fileVersionInfo = process.MainModule.FileVersionInfo;
		string text3 = $"{fileVersionInfo.FileMajorPart}.{fileVersionInfo.FileMinorPart}";
		text2 = text2.Replace("%VERSION%", text3.ToString());
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text2);
		if (registryKey != null)
		{
			object value = registryKey.GetValue("AccessVBOM");
			if (value == null || !(value.ToString() == "1"))
			{
				AppHelper.RunOnUiThread(true, _003C_003Ec.Y2MS6sv32F5 ?? (_003C_003Ec.Y2MS6sv32F5 = _003C_003Ec.Q96S6Y02syk.t67S6eN7yXC));
			}
		}
	}

	private string DI5gBmeeO4A(string string_1)
	{
		switch (string_1)
		{
		case "et":
			return "KET.Application";
		case "wps":
			return "KWPS.Application";
		case "word":
			return "Word.Application";
		case "excel":
			return "Excel.Application";
		case "word_wps":
		{
			bool flag5 = K8ugBbmH5cY("KWPS.Application");
			bool flag6 = K8ugBbmH5cY("Word.Application");
			if (string.Equals(AppState.CurrentProcessName, "winword", StringComparison.OrdinalIgnoreCase))
			{
				return "Word.Application";
			}
			if (string.Equals(AppState.CurrentProcessName, "wps", StringComparison.OrdinalIgnoreCase))
			{
				if (!flag5 && flag6)
				{
					return "Word.Application";
				}
				return "KWPS.Application";
			}
			if (Process.GetProcessesByName("winword").Length != 0)
			{
				goto IL_01cb;
			}
			int num2 = default(int);
			while (true)
			{
				if (Process.GetProcessesByName("wps").Length != 0)
				{
					if (!flag5)
					{
						int num = 0;
						if (!futSdEQHoqVAySHCA4u3())
						{
							num = num2;
						}
						switch (num)
						{
						case 5:
							break;
						default:
							goto IL_019a;
						case 1:
							goto end_IL_018b;
						case 3:
							goto IL_01cb;
						case 2:
						case 4:
							goto IL_034d;
						}
						continue;
					}
					goto IL_01ba;
				}
				throw new Exception("无法找到需要执行VBA代码的程序。");
				IL_01ba:
				return "KWPS.Application";
				IL_019a:
				if (flag6)
				{
					return "Word.Application";
				}
				goto IL_01ba;
				continue;
				end_IL_018b:
				break;
			}
			if (string_1 == "wpp")
			{
				goto case "wpp";
			}
			goto IL_034d;
		}
		case "wpp":
			return "KWPP.Application";
		case "excel_et":
		{
			bool flag3 = K8ugBbmH5cY("KET.Application");
			bool flag4 = K8ugBbmH5cY("Excel.Application");
			if (string.Equals(AppState.CurrentProcessName, "excel", StringComparison.OrdinalIgnoreCase))
			{
				return "Excel.Application";
			}
			if (AppState.CurrentProcessName.EqualsAny(true, "wps", "et"))
			{
				if (!flag3 && flag4)
				{
					return "Excel.Application";
				}
				return "KET.Application";
			}
			if (Process.GetProcessesByName("excel").Length != 0)
			{
				return "Excel.Application";
			}
			if (Process.GetProcessesByName("et").Length != 0)
			{
				if (!flag3 && flag4)
				{
					return "Excel.Application";
				}
				return "KET.Application";
			}
			throw new Exception("无法找到需要执行VBA代码的程序。");
		}
		case "powerpoint":
			return "Powerpoint.Application";
		case "powerpoint_wpp":
		{
			bool flag = K8ugBbmH5cY("KWPP.Application");
			bool flag2 = K8ugBbmH5cY("Powerpoint.Application");
			if (string.Equals(AppState.CurrentProcessName, "powerpnt", StringComparison.OrdinalIgnoreCase))
			{
				return "Powerpoint.Application";
			}
			if (AppState.CurrentProcessName.EqualsAny(true, "wps", "wpp"))
			{
				if (!flag && flag2)
				{
					return "Powerpoint.Application";
				}
				return "KWPP.Application";
			}
			if (Process.GetProcessesByName("powerpnt").Length != 0)
			{
				return "Powerpoint.Application";
			}
			if (Process.GetProcessesByName("wpp").Length != 0)
			{
				if (!flag && flag2)
				{
					return "Powerpoint.Application";
				}
				break;
			}
			throw new Exception("无法找到需要执行VBA代码的程序。");
		}
		default:
			goto IL_034d;
			IL_034d:
			throw new Exception("不支持此应用类型（" + string_1 + "），可能您的Quicker版本过旧或参数值不合法。");
			IL_01cb:
			return "Word.Application";
		}
		return "KWPP.Application";
	}

	static ROWAp7oCqoO68Ncbqn7()
	{
		bm5gBK5uLEf = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		t5igB4esFdV = new StepInParamDef
		{
			Key = "appType",
			Name = "应用程序",
			Type = VarType.Enum,
			DefaultValue = "word_wps",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("word_wps", "Word 或 WPS文字（根据前台进程自动识别）"),
				new SelectionItem("word", "Word"),
				new SelectionItem("wps", "WPS文字"),
				new SelectionItem("excel_et", "Excel 或 WPS表格（根据前台进程自动识别）"),
				new SelectionItem("excel", "Excel"),
				new SelectionItem("et", "WPS表格"),
				new SelectionItem("powerpoint_wpp", "PowerPoint 或 WPS幻灯片（根据前台进程自动识别）"),
				new SelectionItem("powerpoint", "PowerPoint"),
				new SelectionItem("wpp", "WPS幻灯片")
			}
		};
		fE0gB5iblnC = new StepInParamDef
		{
			Key = "code",
			Name = "宏名称或VBA代码",
			Description = "宏的名称，或VBA代码（将执行第一个找到的Sub或Function）",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "Sub Hello()\r\nMsgBox \"Hello World\"\r\nEnd Sub\r\n",
			DefaultHighlightType = "VB"
		};
		QfIgBD7s0oi = new StepInParamDef
		{
			Key = "command",
			Name = "命令ID",
			Description = "界面按钮所对应的命令ID，请参考模块文档了解如何获取。",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = ""
		};
		YOPgBdZQTMI = new StepInParamDef
		{
			Key = "formats",
			Name = "格式设置/属性赋值代码",
			Description = "请参考文档说明",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "",
			DefaultHighlightType = "VB"
		};
		GJRgBoBIlFk = new StepInParamDef
		{
			Key = "waitResp",
			Name = "等待执行结束",
			Description = "不等待将立即继续后续步骤的执行，如果遇到异常情况无法获知。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = 1
		};
		FiKgBTbDNAQ = new StepInParamDef
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
		s89gBMVmokY = new StepOutParamDef
		{
			Key = "resp",
			Name = "返回内容",
			Description = "",
			Type = VarType.Text
		};
		T6kgBA04spJ = new StepOutParamDef
		{
			Key = "progId",
			Name = "ProgId",
			Description = "获取程序的ProgId，可用于在C#里得到对应的Application对象。",
			Type = VarType.Text
		};
	}

	internal static bool futSdEQHoqVAySHCA4u3()
	{
		return a55r3WQHuS6amKE49SU5 == null;
	}
}
