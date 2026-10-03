using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class JoinListStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionStep jsaSN03edUD;

		public ActionExecuteContext E21SNCah8Nl;

		public XAction bYcSNP0mPuJ;

		internal static _003C_003Ec__DisplayClass39_0 WOqFLwWBMUPweKm8Wki9;

		internal (bool isSuccess, string message, ActionStopFlag failReason) iu0SNJbJsAB()
		{
			object paramValue = XActionHelper.GetParamValue(zIsg2Gv2j8t, jsaSN03edUD, E21SNCah8Nl);
			if (!(paramValue is IList<string>))
			{
				return (isSuccess: false, message: "输入的数据不是列表。", failReason: ActionStopFlag.OperationFailed);
			}
			string text = XActionHelper.GetTextParamValue(Neyg2sMASoM, jsaSN03edUD, E21SNCah8Nl);
			if (XActionHelper.GetBooleanParamValue(dmGg2HPenKp, jsaSN03edUD, E21SNCah8Nl))
			{
				text = AppHelper.UnescapeString(text);
			}
			string result = string.Join(text, paramValue as IList<string>);
			XActionHelper.OutputResult(pV4g29HGd2b(), jsaSN03edUD, E21SNCah8Nl, result, bYcSNP0mPuJ);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool yypgNaWBUPcOspMQGSE0()
		{
			return WOqFLwWBMUPweKm8Wki9 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> Bisg2et7gCw;

	[CompilerGenerated]
	private readonly string CPtg2YuNe9o = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> nuhg2I6BkSA;

	[CompilerGenerated]
	private readonly string wNtg2WcBs6Q = "https://getquicker.net/KC/Help/Doc/joinlist";

	[CompilerGenerated]
	private readonly bool Fodg2kHsGXw;

	private static readonly StepInParamDef zIsg2Gv2j8t;

	private static readonly StepInParamDef Neyg2sMASoM;

	private static readonly StepInParamDef dmGg2HPenKp;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> nUcg21Il5J0 = new StepInParamDef[3] { zIsg2Gv2j8t, Neyg2sMASoM, dmGg2HPenKp };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> mCjg2bfRRtd = new StepOutParamDef[1] { pV4g29HGd2b() };

	private static JoinListStep EYpqSdQPeZYqxksl7RNU;

	public string Key => "sys:joinList";

	public string Name => "列表合并成文本";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return Bisg2et7gCw;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return CPtg2YuNe9o;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return nuhg2I6BkSA;
		}
	}

	public string Description => "将列表拼接为一段文本";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return wNtg2WcBs6Q;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return Fodg2kHsGXw;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return nUcg21Il5J0;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return mCjg2bfRRtd;
		}
	}

	[SpecialName]
	private static StepOutParamDef pV4g29HGd2b()
	{
		return new StepOutParamDef
		{
			Key = "output",
			Name = "结果",
			Description = "生成的文本内容",
			Type = VarType.Text
		};
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.jsaSN03edUD = step;
		_003C_003Ec__DisplayClass39_.E21SNCah8Nl = context;
		_003C_003Ec__DisplayClass39_.bYcSNP0mPuJ = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.E21SNCah8Nl, _003C_003Ec__DisplayClass39_.jsaSN03edUD, _003C_003Ec__DisplayClass39_.bYcSNP0mPuJ, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.iu0SNJbJsAB, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(zIsg2Gv2j8t, step) + " => " + XActionHelper.GetOutputParamDisplayString(pV4g29HGd2b(), step);
	}

	static JoinListStep()
	{
		zIsg2Gv2j8t = new StepInParamDef
		{
			Key = "list",
			Name = "输入",
			Description = "要拼接为文本的列表",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.List,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Neyg2sMASoM = new StepInParamDef
		{
			Key = "separator",
			Name = "分隔文本",
			Description = "拼接内容时，两项之间的内容。",
			DefaultValue = ",",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true
		};
		dmGg2HPenKp = new StepInParamDef
		{
			Key = "escapeSeparator",
			Name = "转义“分隔文本”",
			Description = "替换“分隔文本”中的转义字符（\\r,\\n,\\t）",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
	}

	internal static bool bPY35gQPjoV7VKPkack2()
	{
		return EYpqSdQPeZYqxksl7RNU == null;
	}
}
