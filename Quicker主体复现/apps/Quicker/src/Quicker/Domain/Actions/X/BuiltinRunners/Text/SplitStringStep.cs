using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class SplitStringStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ActionStep unQSNvLS1SI;

		public ActionExecuteContext TkvSNSN7j4Q;

		public XAction PpnSN2VDBsy;

		private static _003C_003Ec__DisplayClass41_0 jqvyVpWB5iyVotRos1Sa;

		internal (bool isSuccess, string message, ActionStopFlag failReason) IxLSNLG1CdW()
		{
			_003C_003Ec__DisplayClass41_1 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_1();
			string textParamValue = XActionHelper.GetTextParamValue(ViSg2atmiBw, unQSNvLS1SI, TkvSNSN7j4Q);
			string text = XActionHelper.GetTextParamValue(ukBg27I2QFT, unQSNvLS1SI, TkvSNSN7j4Q);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(L4mg2cl59sa, unQSNvLS1SI, TkvSNSN7j4Q);
			_003C_003Ec__DisplayClass41_.yTxSNNqOP36 = XActionHelper.GetBooleanParamValue(SXKg2RXoqMH, unQSNvLS1SI, TkvSNSN7j4Q);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(zr8g2qxZvol, unQSNvLS1SI, TkvSNSN7j4Q);
			IList<string> result;
			if (string.IsNullOrEmpty(textParamValue))
			{
				result = new List<string>();
			}
			else if (booleanParamValue2)
			{
				string[] separator = text.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec__DisplayClass41_.YexSNuVp8oS).ToArray();
				result = textParamValue.Split(separator, booleanParamValue ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None).ToList();
			}
			else
			{
				if (_003C_003Ec__DisplayClass41_.yTxSNNqOP36)
				{
					text = AppHelper.UnescapeString(text);
				}
				result = textParamValue.Split(new string[1] { text }, booleanParamValue ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None).ToList();
			}
			XActionHelper.OutputResult(qfLg2JoSdQ5(), unQSNvLS1SI, TkvSNSN7j4Q, result, PpnSN2VDBsy);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool jQP2qfWBYERqscof7jvq()
		{
			return jqvyVpWB5iyVotRos1Sa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_1
	{
		public bool yTxSNNqOP36;

		internal static _003C_003Ec__DisplayClass41_1 QpWNjJWBRv7MfjPZEi1t;

		internal string YexSNuVp8oS(string x)
		{
			if (yTxSNNqOP36)
			{
				return AppHelper.UnescapeString(x);
			}
			return x;
		}

		internal static bool cZNYMPWBgLu7JXSr12rm()
		{
			return QpWNjJWBRv7MfjPZEi1t == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> BJOg2CFhPwF;

	[CompilerGenerated]
	private readonly string H9ug2PSG26H = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> EI1g2E6SbF2;

	[CompilerGenerated]
	private readonly string WTmg2yQsCA1 = "https://getquicker.net/KC/Help/Doc/splitstring";

	[CompilerGenerated]
	private readonly bool sWgg28IlW85;

	private static readonly StepInParamDef ViSg2atmiBw;

	private static readonly StepInParamDef ukBg27I2QFT;

	private static readonly StepInParamDef SXKg2RXoqMH;

	private static readonly StepInParamDef zr8g2qxZvol;

	private static readonly StepInParamDef L4mg2cl59sa;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> uoEg2VHfEbG = new StepInParamDef[5] { ViSg2atmiBw, ukBg27I2QFT, SXKg2RXoqMH, zr8g2qxZvol, L4mg2cl59sa };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> MSRg2ZHu0rg = new StepOutParamDef[1] { qfLg2JoSdQ5() };

	internal static SplitStringStep tCqhpAQPctS5ViIxOucF;

	public string Key => "sys:splitString";

	public string Name => "拆分文本为列表";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return BJOg2CFhPwF;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return H9ug2PSG26H;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return EI1g2E6SbF2;
		}
	}

	public string Description => "将文本拆分为列表";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return WTmg2yQsCA1;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return sWgg28IlW85;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return uoEg2VHfEbG;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return MSRg2ZHu0rg;
		}
	}

	[SpecialName]
	private static StepOutParamDef qfLg2JoSdQ5()
	{
		return new StepOutParamDef
		{
			Key = "output",
			Name = "结果",
			Description = "生成的文本内容",
			Type = VarType.List
		};
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.unQSNvLS1SI = step;
		_003C_003Ec__DisplayClass41_.TkvSNSN7j4Q = context;
		_003C_003Ec__DisplayClass41_.PpnSN2VDBsy = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass41_.TkvSNSN7j4Q, _003C_003Ec__DisplayClass41_.unQSNvLS1SI, _003C_003Ec__DisplayClass41_.PpnSN2VDBsy, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass41_.IxLSNLG1CdW, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ViSg2atmiBw, step) + " => " + XActionHelper.GetOutputParamDisplayString(qfLg2JoSdQ5(), step);
	}

	static SplitStringStep()
	{
		ViSg2atmiBw = new StepInParamDef
		{
			Key = "data",
			Name = "输入",
			Description = "要拆分为列表的文本",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		ukBg27I2QFT = new StepInParamDef
		{
			Key = "separator",
			Name = "分隔",
			Description = "拆分分隔符",
			DefaultValue = ",",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true
		};
		SXKg2RXoqMH = new StepInParamDef
		{
			Key = "escapeSeparator",
			Name = "转义分隔符",
			Description = "转义分隔符\\r\\n\\t字符",
			DefaultValue = false,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		zr8g2qxZvol = new StepInParamDef
		{
			Key = "multiSeparator",
			Name = "使用多个分隔符拆分列表",
			Description = "每行指定一个。",
			DefaultValue = false,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		L4mg2cl59sa = new StepInParamDef
		{
			Key = "removeEmpty",
			Name = "滤除空值",
			Description = "滤除没有内容的文本",
			DefaultValue = true,
			IsRequired = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
	}

	internal static bool SnusXvQPWNNGW58Y0Pr6()
	{
		return tCqhpAQPctS5ViIxOucF == null;
	}

	internal static void i59kGoQPXhB3Itjle90p()
	{
	}
}
