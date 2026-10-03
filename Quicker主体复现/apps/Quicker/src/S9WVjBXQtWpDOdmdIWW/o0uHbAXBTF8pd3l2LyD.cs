using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Ko4fe7AdlIHVfm4LNc6;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace S9WVjBXQtWpDOdmdIWW;

internal class o0uHbAXBTF8pd3l2LyD : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public ActionStep xrsSh4AUCgp;

		public ActionExecuteContext sG8Sh5BaQct;

		private static _003C_003Ec__DisplayClass36_0 tKUsg6WLEErlqiEIl4JA;

		internal (bool isSuccess, string message, ActionStopFlag failReason) PNgShnXTT0y()
		{
			D3mwCbAmx8tANGphaEi.ExecuteScript(XActionHelper.GetTextParamValue(ss9gY5a6mmr, xrsSh4AUCgp, sG8Sh5BaQct));
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool XWSMS9WLGCX4u37Wfv0T()
		{
			return tKUsg6WLEErlqiEIl4JA == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> rnlgYps7imU = new string[3] { "按键", "键盘", "keyboard" };

	[CompilerGenerated]
	private readonly string sFIgYB1uN1x = $"fa:{EFontAwesomeIcon.Light_Keyboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> OT9gYQmhcQq;

	[CompilerGenerated]
	private readonly string xfUgYjQuqw9 = "https://getquicker.net/KC/Help/Doc/inputscript";

	[CompilerGenerated]
	private readonly bool gBAgYncM92Y;

	private static readonly StepInParamDef dlEgY4WJUGI;

	private static readonly StepInParamDef ss9gY5a6mmr;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> AeTgYDpDwjE = new StepInParamDef[2] { ss9gY5a6mmr, dlEgY4WJUGI };

	private static readonly StepOutParamDef cKQgYdCTVIb;

	internal static o0uHbAXBTF8pd3l2LyD nR9ajbQTNDIbKQWnjZHq;

	public string Key => "sys:inputScript";

	public string Name => "多步骤输入";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return rnlgYps7imU;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return sFIgYB1uN1x;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Input;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return OT9gYQmhcQq;
		}
	}

	public string Description => "多步骤键盘组合输入";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return xfUgYjQuqw9;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return gBAgYncM92Y;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return AeTgYDpDwjE;
		}
	}

	public IList<StepOutParamDef> OutputParams => new List<StepOutParamDef> { cKQgYdCTVIb };

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.xrsSh4AUCgp = step;
		_003C_003Ec__DisplayClass36_.sG8Sh5BaQct = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass36_.sG8Sh5BaQct, _003C_003Ec__DisplayClass36_.xrsSh4AUCgp, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass36_.PNgShnXTT0y, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ss9gY5a6mmr, step);
	}

	static o0uHbAXBTF8pd3l2LyD()
	{
		dlEgY4WJUGI = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ss9gY5a6mmr = new StepInParamDef
		{
			Key = "data",
			Name = "步骤脚本",
			Description = "模拟输入的步骤列表，每行一个。详细格式请参考模块文档。",
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			Type = VarType.Text
		};
		cKQgYdCTVIb = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool oEfDrcQT9PpSMNTkY1Q5()
	{
		return nR9ajbQTNDIbKQWnjZHq == null;
	}
}
