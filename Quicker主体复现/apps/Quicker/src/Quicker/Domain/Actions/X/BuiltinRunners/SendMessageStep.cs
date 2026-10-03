using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class SendMessageStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionStep H2uvf1rJatH;

		public ActionExecuteContext dI3vfbIWbvO;

		public XAction OVNvf6Uepln;

		internal static _003C_003Ec__DisplayClass47_0 CWmdARW3DX1FRs3bhE64;

		internal (bool isSuccess, string message, ActionStopFlag failReason) oqpvfHxJKxU()
		{
			string textParamValue = XActionHelper.GetTextParamValue(_operationParam, H2uvf1rJatH, dI3vfbIWbvO);
			IntPtr intPtr = (IntPtr)Convert.ToInt32(XActionHelper.GetIntegerParamValue(KuFtO0o7aOA, H2uvf1rJatH, dI3vfbIWbvO), CultureInfo.InvariantCulture);
			if (intPtr == IntPtr.Zero)
			{
				intPtr = NativeMethods.GetForegroundWindow();
			}
			long num = TextToInt(XActionHelper.GetTextParamValue(cZdtOCoUro1, H2uvf1rJatH, dI3vfbIWbvO));
			long num2 = TextToInt(XActionHelper.GetTextParamValue(GYLtOPe0fxC, H2uvf1rJatH, dI3vfbIWbvO));
			long num3 = TextToInt(XActionHelper.GetTextParamValue(ShVtOE0aVYR, H2uvf1rJatH, dI3vfbIWbvO));
			try
			{
				IntPtr intPtr2 = IntPtr.Zero;
				switch (textParamValue)
				{
				default:
					return (isSuccess: false, message: "不支持此操作类型：" + textParamValue + "。请升级Quicker版本。", failReason: ActionStopFlag.OperationFailed);
				case "SendMessageTextLParam":
				{
					string textParamValue2 = XActionHelper.GetTextParamValue(gtDtOyxFkGY, H2uvf1rJatH, dI3vfbIWbvO);
					if (num < 1024L)
					{
						if (num == 74L)
						{
							byte[] bytes = Encoding.Unicode.GetBytes(textParamValue2);
							int num4 = bytes.Length;
							IntPtr intPtr3 = Marshal.AllocHGlobal(num4);
							Marshal.Copy(bytes, 0, intPtr3, num4);
							NativeMethods.COPYDATASTRUCT lParam = default(NativeMethods.COPYDATASTRUCT);
							lParam.dwData = IntPtr.Zero;
							lParam.cbData = num4;
							lParam.lpData = intPtr3;
							intPtr2 = (IntPtr)NativeMethods.SendMessage(intPtr, 74, IntPtr.Zero, ref lParam);
							Marshal.FreeHGlobal(intPtr3);
						}
						else
						{
							intPtr2 = NativeMethods.SendMessage(intPtr, (int)num, (IntPtr)num2, textParamValue2);
						}
					}
					else
					{
						IntPtr intPtr4 = Marshal.StringToHGlobalUni(textParamValue2);
						try
						{
							intPtr2 = NativeMethods.SendMessage(intPtr, (int)num, (IntPtr)num2, intPtr4);
						}
						finally
						{
							Marshal.FreeHGlobal(intPtr4);
						}
					}
					break;
				}
				case "PostMessage":
					NativeMethods.PostMessageSafe(intPtr, (uint)num, (IntPtr)num2, (IntPtr)num3);
					break;
				case "SendMessage":
					intPtr2 = NativeMethods.SendMessage(intPtr, (int)num, (IntPtr)num2, (IntPtr)num3);
					break;
				}
				XActionHelper.OutputResult(AiVtO7qCYhm, H2uvf1rJatH, dI3vfbIWbvO, intPtr2, OVNvf6Uepln);
			}
			catch (Exception ex)
			{
				string item = "执行SendMessage出错：" + ex.Message;
				return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool La9Oq4W33AFuALpkwp91()
		{
			return CWmdARW3DX1FRs3bhE64 == null;
		}
	}

	private static readonly ILog XN8tOvD0CgE;

	[CompilerGenerated]
	private readonly IEnumerable<string> cv0tOSLsZyg = new List<string> { "SendMessage", "PostMessage" };

	[CompilerGenerated]
	private readonly string LtvtO2iHcl6 = $"fa:{EFontAwesomeIcon.Light_Envelope}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> WRltOudFvm5;

	[CompilerGenerated]
	private readonly string DGFtONj2hng = "https://getquicker.net/KC/Help/Doc/sendMessage";

	[CompilerGenerated]
	private readonly bool I7QtOJjifeO;

	public static readonly StepInParamDef _operationParam;

	private static readonly StepInParamDef KuFtO0o7aOA;

	private static readonly StepInParamDef cZdtOCoUro1;

	private static readonly StepInParamDef GYLtOPe0fxC;

	private static readonly StepInParamDef ShVtOE0aVYR;

	private static readonly StepInParamDef gtDtOyxFkGY;

	private static readonly StepInParamDef SXGtO89tspe;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> jkGtOaTjQGo = new StepInParamDef[7] { _operationParam, KuFtO0o7aOA, cZdtOCoUro1, GYLtOPe0fxC, ShVtOE0aVYR, gtDtOyxFkGY, SXGtO89tspe };

	private static readonly StepOutParamDef AiVtO7qCYhm;

	private static readonly StepOutParamDef XfGtORwflVW;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> R2ZtOq3LjaV = new StepOutParamDef[2] { XfGtORwflVW, AiVtO7qCYhm };

	internal static SendMessageStep L3anP2QlZPgoCPO9xcyl;

	public string Key => "sys:sendMessage";

	public string Name => "向窗口发送消息";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return cv0tOSLsZyg;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return LtvtO2iHcl6;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return WRltOudFvm5;
		}
	}

	public string Description => "使用SendMessage Win32Api向窗口发送消息。使用方法请搜索SendMessage Win32 API接口。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return DGFtONj2hng;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return I7QtOJjifeO;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return jkGtOaTjQGo;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return R2ZtOq3LjaV;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.H2uvf1rJatH = step;
		_003C_003Ec__DisplayClass47_.dI3vfbIWbvO = context;
		_003C_003Ec__DisplayClass47_.OVNvf6Uepln = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass47_.dI3vfbIWbvO, _003C_003Ec__DisplayClass47_.H2uvf1rJatH, _003C_003Ec__DisplayClass47_.OVNvf6Uepln, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass47_.oqpvfHxJKxU, (Action)null, (Action)null, SXGtO89tspe, XfGtORwflVW);
	}

	public static long TextToInt(string txt)
	{
		if (string.IsNullOrEmpty(txt))
		{
			return 0L;
		}
		if (txt.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
		{
			txt = txt.Substring(2);
			return long.Parse(txt, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return Convert.ToInt64(txt, CultureInfo.InvariantCulture);
	}

	public string GetSummary(ActionStep step)
	{
		return "向窗口发送消息";
	}

	static SendMessageStep()
	{
		XN8tOvD0CgE = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		_operationParam = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			DefaultValue = "SendMessage",
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("SendMessage", "SendMessage(等待返回，LParam为数字)"),
				new SelectionItem("SendMessageTextLParam", "SendMessage(等待返回，LParam为文本)"),
				new SelectionItem("PostMessage", "PostMessage(不等待返回)")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		KuFtO0o7aOA = new StepInParamDef
		{
			Key = "hWnd",
			Name = "窗口句柄hWnd",
			Description = "留空或0表示前台窗口",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer
		};
		cZdtOCoUro1 = new StepInParamDef
		{
			Key = "wMsg",
			Name = "消息",
			Description = "要发送的消息。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text
		};
		GYLtOPe0fxC = new StepInParamDef
		{
			Key = "wParam",
			Name = "wParam参数",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text
		};
		ShVtOE0aVYR = new StepInParamDef
		{
			Key = "lParam",
			Name = "lParam参数",
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			InvalidForList = new List<string> { "SendMessageTextLParam" }
		};
		gtDtOyxFkGY = new StepInParamDef
		{
			Key = "textLParam",
			Name = "lParam参数(文本)",
			Description = "文本内容",
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new List<string> { "SendMessageTextLParam" }
		};
		SXGtO89tspe = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		AiVtO7qCYhm = new StepOutParamDef
		{
			Key = "rtn",
			Name = "返回值",
			Description = "返回值，依据消息的不同具有不同的含义，请查询对应API的文档。",
			Type = VarType.Integer,
			ValidForList = new string[2] { "SendMessage", "SendMessageTextLParam" }
		};
		XfGtORwflVW = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool abOFicQl5SpbeyGoi8PM()
	{
		return L3anP2QlZPgoCPO9xcyl == null;
	}

	internal static void lRwttBQl8lVG4OHZe0pN()
	{
	}
}
