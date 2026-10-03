using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class KeyInputStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	private readonly IEnumerable<string> zfgtfZo3CE5 = new string[3] { "键盘", "Key", "Keyboard" };

	[CompilerGenerated]
	private readonly string NPGtf9BR0SK = $"fa:{EFontAwesomeIcon.Light_Keyboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> usctfhYD4oo = new StepRunnerCategory[1] { StepRunnerCategory.Input };

	[CompilerGenerated]
	private readonly string sZ4tfeeCZh8 = "https://getquicker.net/KC/Help/Doc/keyinput";

	[CompilerGenerated]
	private readonly bool gbltfYqigWB;

	public static readonly StepInParamDef KeysParam;

	public static readonly StepInParamDef RepeatCountParam;

	public static readonly StepInParamDef RepeatIntervalParam;

	public static readonly StepInParamDef HoldMsParam;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> XNstfIL9JtL = new StepInParamDef[4] { KeysParam, RepeatCountParam, RepeatIntervalParam, HoldMsParam };

	private static KeyInputStep lfZVfPQYLUGe2kkrE0yV;

	public string Key => "sys:keyInput";

	public string Name => "模拟按键A（录入）";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return zfgtfZo3CE5;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return NPGtf9BR0SK;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return usctfhYD4oo;
		}
	}

	public string Description => "模拟键盘输入";

	public StepType StepType => StepType.Keyboard;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return sZ4tfeeCZh8;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return gbltfYqigWB;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return XNstfIL9JtL;
		}
	}

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		KeyInputStepData keyInputStepData = KeyInputStepData.Deserialize(XActionHelper.GetTextParamValue(KeysParam, step, context));
		if (keyInputStepData.Keys.Count != 1 || keyInputStepData.Keys[0] != VirtualKeyCode.VK_C || keyInputStepData.CtrlKeys.Count != 1)
		{
			goto IL_00ab;
		}
		if (keyInputStepData.CtrlKeys[0] != VirtualKeyCode.LCONTROL && keyInputStepData.CtrlKeys[0] != VirtualKeyCode.CONTROL)
		{
			int num = 1;
			if (lfZVfPQYLUGe2kkrE0yV != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_00ab;
			}
			if (keyInputStepData.CtrlKeys[0] != VirtualKeyCode.RCONTROL)
			{
				goto IL_00ab;
			}
		}
		context.ClipboardSeqBeforeCtrlC = AppState.ClipboardSequenceNumber;
		goto IL_00b2;
		IL_00b2:
		int num3 = (int)XActionHelper.GetIntegerParamValue(RepeatCountParam, step, context);
		int num4 = (int)XActionHelper.GetIntegerParamValue(RepeatIntervalParam, step, context);
		int num5 = (int)XActionHelper.GetIntegerParamValue(HoldMsParam, step, context);
		for (int i = 0; i < num3; i++)
		{
			InputSimulator.Instance.Keyboard.ModifiedKeyStroke(keyInputStepData.CtrlKeys, keyInputStepData.Keys, (num5 < 0) ? AppHelper.kPoLTdWFLA7() : num5);
			if (i < num3 - 1 && num4 > 0)
			{
				Thread.Sleep(num4);
			}
		}
		return;
		IL_00ab:
		context.ClipboardSeqBeforeCtrlC = 0;
		goto IL_00b2;
	}

	public string GetSummary(ActionStep step)
	{
		KeyInputStepData keyInputStepData = KeyInputStepData.Deserialize(XActionHelper.GetParamDirectValue(KeysParam, step));
		string paramDisplayString = XActionHelper.GetParamDisplayString(RepeatCountParam, step);
		if (!(paramDisplayString == "1") && !string.IsNullOrEmpty(paramDisplayString))
		{
			return KeyboardHelper.GetKeysName(keyInputStepData.CtrlKeys, keyInputStepData.Keys) + "   重复:" + XActionHelper.GetParamDisplayString(RepeatCountParam, step) + " 间隔:" + XActionHelper.GetParamDisplayString(RepeatIntervalParam, step) + "ms";
		}
		return KeyboardHelper.GetKeysName(keyInputStepData.CtrlKeys, keyInputStepData.Keys) ?? "";
	}

	public static ActionStep CreateStep(IList<VirtualKeyCode> ctrlKeys, IList<VirtualKeyCode> normalKeys)
	{
		ActionStep actionStep = new ActionStep();
		actionStep.StepRunnerKey = "sys:keyInput";
		actionStep.InputParams = new Dictionary<string, ActionStepParam>();
		KeyInputStepData keyInputStepData = new KeyInputStepData
		{
			Keys = normalKeys,
			CtrlKeys = ctrlKeys
		};
		actionStep.InputParams[KeysParam.Key] = new ActionStepParam
		{
			Value = keyInputStepData.Serialize()
		};
		return actionStep;
	}

	static KeyInputStep()
	{
		KeysParam = new StepInParamDef
		{
			Key = "keys",
			Name = "按键",
			Description = "模拟的按键内容",
			IsRequired = true,
			Type = VarType.Keyboard,
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input
		};
		RepeatCountParam = new StepInParamDef
		{
			Key = "repeat",
			Name = "重复次数",
			Type = VarType.Integer,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.Input
		};
		RepeatIntervalParam = new StepInParamDef
		{
			Key = "interval",
			Name = "重复间隔(毫秒)",
			Description = "每次重复之间的间隔毫秒数",
			Type = VarType.Integer,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.Input
		};
		HoldMsParam = new StepInParamDef
		{
			Key = "holdMs",
			Name = "保持毫秒数",
			Description = "普通键（非Ctrl/Alt/Shift/Win）在抬起前保持的时间。-1表示使用默认设置。\r\n某些直接模拟按键无法生效的软件中可以尝试增加此值。",
			Type = VarType.Integer,
			DefaultValue = -1,
			VariableMode = ParamVariableMode.Input
		};
	}

	internal static bool pwL9G8QYuPnCQW8mYjft()
	{
		return lfZVfPQYLUGe2kkrE0yV == null;
	}
}
