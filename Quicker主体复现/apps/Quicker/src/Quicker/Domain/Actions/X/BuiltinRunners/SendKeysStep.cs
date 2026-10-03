using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class SendKeysStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public ActionStep XPKvfGKqlDL;

		public ActionExecuteContext ewnvfsuiR7i;

		internal static _003C_003Ec__DisplayClass34_0 eFGq5eW3nRK4c6KyNUdU;

		internal (bool isSuccess, string message, ActionStopFlag failReason) EaIvfkjrYTv()
		{
			string textParamValue = XActionHelper.GetTextParamValue(zPttOgTbjmg, XPKvfGKqlDL, ewnvfsuiR7i);
			if (string.Equals(textParamValue, "^c"))
			{
				ewnvfsuiR7i.ClipboardSeqBeforeCtrlC = AppState.ClipboardSequenceNumber;
			}
			else
			{
				ewnvfsuiR7i.ClipboardSeqBeforeCtrlC = 0;
			}
			if (!string.IsNullOrEmpty(textParamValue))
			{
				try
				{
					SendKeys.SendWait(textParamValue);
				}
				catch (Exception ex)
				{
					try
					{
						Thread.Sleep(10);
						SendKeys.SendWait(textParamValue);
					}
					catch
					{
						return (isSuccess: false, message: "发送按键出错。" + ex.Message, failReason: ActionStopFlag.OperationFailed);
					}
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool MSvQ9FW3eFiEiHS1RCRV()
		{
			return eFGq5eW3nRK4c6KyNUdU == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> dcFtA3itlSb = new string[3] { "按键", "键盘", "keyboard" };

	[CompilerGenerated]
	private readonly string pA4tAfiylAH = $"fa:{EFontAwesomeIcon.Light_Keyboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> vjbtAz7qPxd = new StepRunnerCategory[1] { StepRunnerCategory.Input };

	[CompilerGenerated]
	private readonly string IDjtOwEcfpU = "https://getquicker.net/KC/Help/Doc/sendKeys";

	[CompilerGenerated]
	private readonly bool GSPtOtiMaoC;

	private static readonly StepInParamDef zPttOgTbjmg;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> y8otOL2cOP6 = new StepInParamDef[1] { zPttOgTbjmg };

	internal static SendKeysStep l4fYi0Qlq5idv5AEeR0Y;

	public string Key => "sys:sendKeys";

	public string Name => "模拟按键B（参数）";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return dcFtA3itlSb;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return pA4tAfiylAH;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return vjbtAz7qPxd;
		}
	}

	public string Description => "发送按键和文本";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return IDjtOwEcfpU;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return GSPtOtiMaoC;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return y8otOL2cOP6;
		}
	}

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.XPKvfGKqlDL = step;
		_003C_003Ec__DisplayClass34_.ewnvfsuiR7i = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass34_.ewnvfsuiR7i, _003C_003Ec__DisplayClass34_.XPKvfGKqlDL, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass34_.EaIvfkjrYTv, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(zPttOgTbjmg, step) ?? "";
	}

	static SendKeysStep()
	{
		zPttOgTbjmg = new StepInParamDef
		{
			Key = "keys",
			Name = "按键序列",
			Description = "要发送的按键序列，使用C#语言SendKeys.Send()语法，具体请参考教程文档。",
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			Type = VarType.Text,
			TextTools = new List<TextToolType> { TextToolType.SelectSendKeysData },
			ReplaceMode = TextToolsReplaceMode.ReplaceSelected
		};
	}

	internal static bool cmE8Q0QlisC22Ghn15jM()
	{
		return l4fYi0Qlq5idv5AEeR0Y == null;
	}
}
