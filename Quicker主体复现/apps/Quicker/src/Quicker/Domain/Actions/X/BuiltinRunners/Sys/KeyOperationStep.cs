using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using f5fV1EMjxQYCEGaKlWD;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Sys;

public class KeyOperationStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public ActionStep MHVSZ2fKcTC;

		public ActionExecuteContext osiSZu0y3Ar;

		public XAction V9eSZNC3pKc;

		internal static _003C_003Ec__DisplayClass46_0 GiIg4TWNJbkIt9isAtxI;

		internal (bool isSuccess, string message, ActionStopFlag failReason) poTSZS8n6Eg()
		{
			string textParamValue = XActionHelper.GetTextParamValue(BJ6gVYMTgpc, MHVSZ2fKcTC, osiSZu0y3Ar);
			bool num = !textParamValue.IsEither("key_keydown_v1", "key_keyup_v1");
			string valueOrName = (num ? XActionHelper.GetTextParamValue(LlXgVI5EONG, MHVSZ2fKcTC, osiSZu0y3Ar) : string.Empty);
			Keys keys = (num ? KeyboardHelper.KeyFromValueOrName(valueOrName) : Keys.None);
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的操作：" + textParamValue + "。可能您使用的版本过旧。", failReason: ActionStopFlag.OperationFailed);
			case "key_keyup_v1":
				CiNTbyM2WDubHspat0P.iBBLdEolQUM().XvVLdCvqF9q(VirtualKeyCode.APP_V1);
				break;
			case "key_keydown_v1":
			{
				int int_ = (int)XActionHelper.GetIntegerParamValue(tXugVkXks4U, MHVSZ2fKcTC, osiSZu0y3Ar);
				CiNTbyM2WDubHspat0P.iBBLdEolQUM().FlBLd0y6eX8(VirtualKeyCode.APP_V1, int_);
				break;
			}
			case "key_up":
				InputSimulator.Instance.Keyboard.KeyUp((VirtualKeyCode)keys);
				break;
			case "key_down":
				InputSimulator.Instance.Keyboard.KeyDown((VirtualKeyCode)keys);
				break;
			case "get_key_state":
			{
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(yCCgVWmidfT, MHVSZ2fKcTC, osiSZu0y3Ar);
				if (SystemParameters.SwapButtons)
				{
					switch (keys)
					{
					case Keys.LButton:
						keys = Keys.RButton;
						break;
					case Keys.RButton:
						keys = Keys.LButton;
						break;
					}
				}
				bool flag = false;
				bool flag2 = false;
				if (keys > Keys.None)
				{
					if (keys <= Keys.XButton2 && booleanParamValue)
					{
						flag = AppState.v5FtaQ4hQfg().zYwvLopdTEn().RealState.Kcpt9nPM6AT(KeyboardHelper.MouseButtonFromKeyCode((int)keys));
					}
					else
					{
						(bool isDown, bool isToggle) keyStateFromSystem = KeyboardHelper.GetKeyStateFromSystem(keys);
						flag = KeyboardHelper.IsKeyDown((VirtualKeyCode)keys);
						flag2 = keyStateFromSystem.isToggle;
						if (booleanParamValue)
						{
							flag = AppState.v5FtaQ4hQfg().dHavLMV7kRX().RealKeyState.IsKeyDown((int)keys);
						}
					}
				}
				XActionHelper.OutputResult(GKxgVsrK50g, MHVSZ2fKcTC, osiSZu0y3Ar, flag, V9eSZNC3pKc);
				XActionHelper.OutputResult(eVSgVHM3fgw, MHVSZ2fKcTC, osiSZu0y3Ar, flag2, V9eSZNC3pKc);
				break;
			}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool t2XDwaWNkbvadi4GgpZi()
		{
			return GiIg4TWNJbkIt9isAtxI == null;
		}
	}

	private static List<string> yGxgVV6ICpi;

	[CompilerGenerated]
	private readonly string QVhgVZ39dPD = $"fa:{EFontAwesomeIcon.Light_Keyboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Q7tgV9I2jyL = new List<StepRunnerCategory> { StepRunnerCategory.Input };

	[CompilerGenerated]
	private readonly string dsjgVhIxKK5 = "https://getquicker.net/KC/Help/Doc/keyoperation";

	[CompilerGenerated]
	private readonly bool Nu4gVeYBtyQ;

	private static readonly StepInParamDef BJ6gVYMTgpc;

	private static readonly StepInParamDef LlXgVI5EONG;

	private static readonly StepInParamDef yCCgVWmidfT;

	private static readonly StepInParamDef tXugVkXks4U;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> ndNgVGIEE90 = new List<StepInParamDef> { BJ6gVYMTgpc, LlXgVI5EONG, yCCgVWmidfT, tXugVkXks4U };

	private static readonly StepOutParamDef GKxgVsrK50g;

	private static readonly StepOutParamDef eVSgVHM3fgw;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> L1bgV1OHEWd = new List<StepOutParamDef> { GKxgVsrK50g, eVSgVHM3fgw };

	private static KeyOperationStep vmU6ojQtTwa7FpQFFtYN;

	public string Key => "sys:keyoperation";

	public string Name => "按键操作";

	public IEnumerable<string> KeyWords => yGxgVV6ICpi;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return QVhgVZ39dPD;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Q7tgV9I2jyL;
		}
	}

	public string Description => "单个键盘按键的操作控制或状态获取";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return dsjgVhIxKK5;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return Nu4gVeYBtyQ;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return ndNgVGIEE90;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return L1bgV1OHEWd;
		}
	}

	static KeyOperationStep()
	{
		yGxgVV6ICpi = new List<string> { "键盘", "Keyboard", "jianpan" };
		BJ6gVYMTgpc = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "操作类型。按下和抬起需要配对使用。",
			Type = VarType.Enum,
			DefaultValue = "get_key_state",
			SelectionItems = new SelectionItem[5]
			{
				new SelectionItem("get_key_state", "获取按键状态"),
				new SelectionItem("key_down", "按下按键"),
				new SelectionItem("key_up", "抬起按键"),
				new SelectionItem("key_keydown_v1", "按下Quicker虚拟键V1"),
				new SelectionItem("key_keyup_v1", "抬起Quicker虚拟键V1")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		LlXgVI5EONG = new StepInParamDef
		{
			Key = "key",
			Name = "按键",
			DefaultValue = "",
			Description = "要操作或检查状态的按键(单个)。可以为键值或键名，具体请参考文档。",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectKeyName },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll,
			InvalidForList = new string[2] { "key_keydown_v1", "key_keyup_v1" }
		};
		yCCgVWmidfT = new StepInParamDef
		{
			Key = "getRealMouseState",
			Name = "获取按键的实际状态（在远程时无法获取）",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = false,
			ValidForList = new string[1] { "get_key_state" }
		};
		tXugVkXks4U = new StepInParamDef
		{
			Key = "keepMs",
			Name = "保持按下时间",
			DefaultValue = "1000",
			Description = "保持此虚拟键按下的时间（毫秒数），之后会自动抬起。",
			Type = VarType.Integer,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "key_keydown_v1" }
		};
		GKxgVsrK50g = new StepOutParamDef
		{
			Key = "isDown",
			Name = "是否按下",
			Type = VarType.Boolean,
			Description = "此按键是否为按下状态",
			ValidForList = new string[1] { "get_key_state" }
		};
		eVSgVHM3fgw = new StepOutParamDef
		{
			Key = "isToggled",
			Name = "是否锁定",
			Type = VarType.Boolean,
			Description = "此按键是否为锁定状态，仅对CapsLock、NumLock等按键有效。",
			ValidForList = new string[1] { "get_key_state" }
		};
		foreach (SelectionItem selectionItem in BJ6gVYMTgpc.SelectionItems)
		{
			yGxgVV6ICpi.Add(selectionItem.Name);
			yGxgVV6ICpi.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.MHVSZ2fKcTC = step;
		_003C_003Ec__DisplayClass46_.osiSZu0y3Ar = context;
		_003C_003Ec__DisplayClass46_.V9eSZNC3pKc = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass46_.osiSZu0y3Ar, _003C_003Ec__DisplayClass46_.MHVSZ2fKcTC, _003C_003Ec__DisplayClass46_.V9eSZNC3pKc, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass46_.poTSZS8n6Eg, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(BJ6gVYMTgpc, step) + " " + XActionHelper.GetParamDisplayString(LlXgVI5EONG, step);
	}

	internal static bool BBqKUPQtmim0hKw4N4lm()
	{
		return vmU6ojQtTwa7FpQFFtYN == null;
	}
}
