using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class FormatStringStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public ActionStep c3RSNZSYDYs;

		public ActionExecuteContext oyKSN95nk5P;

		public FormatStringStep OSsSNhUd2EV;

		public XAction jsSSNe4Lu2i;

		internal static _003C_003Ec__DisplayClass37_0 sh53DaWBm3jSEOw7BaY0;

		internal (bool isSuccess, string message, ActionStopFlag failReason) k0tSNVSDINK()
		{
			string result = string.Format(CultureInfo.CurrentCulture, XActionHelper.GetTextParamValue(PmIg2iBTgAS, c3RSNZSYDYs, oyKSN95nk5P), XActionHelper.GetParamValue(OSsSNhUd2EV.InputParams[1], c3RSNZSYDYs, oyKSN95nk5P), XActionHelper.GetParamValue(OSsSNhUd2EV.InputParams[2], c3RSNZSYDYs, oyKSN95nk5P), XActionHelper.GetParamValue(OSsSNhUd2EV.InputParams[3], c3RSNZSYDYs, oyKSN95nk5P), XActionHelper.GetParamValue(OSsSNhUd2EV.InputParams[4], c3RSNZSYDYs, oyKSN95nk5P), XActionHelper.GetParamValue(OSsSNhUd2EV.InputParams[5], c3RSNZSYDYs, oyKSN95nk5P));
			XActionHelper.OutputResult(N6Gg2TC1uRd(), c3RSNZSYDYs, oyKSN95nk5P, result, jsSSNe4Lu2i);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool zugfaYWBsBJ9XIRfClFu()
		{
			return sh53DaWBm3jSEOw7BaY0 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> tIfg2AudlOd = new string[2] { "拼接", "文本" };

	[CompilerGenerated]
	private readonly string sOMg2Oll0RW = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> hg9g2FDtBGK;

	[CompilerGenerated]
	private readonly string wk2g2Uiregf = "https://getquicker.net/KC/Help/Doc/formatstring";

	[CompilerGenerated]
	private readonly bool hVJg2lXEaq3;

	private static readonly StepInParamDef PmIg2iBTgAS;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> NLeg23yvXt6 = new StepInParamDef[6]
	{
		PmIg2iBTgAS,
		pERg2oRXMCc(0),
		pERg2oRXMCc(1),
		pERg2oRXMCc(2),
		pERg2oRXMCc(3),
		pERg2oRXMCc(4)
	};

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> J5Yg2fWWB12 = new StepOutParamDef[1] { N6Gg2TC1uRd() };

	private static FormatStringStep QUO8u5QPdQAogY8B1fNh;

	public string Key => "sys:formatString";

	public string Name => "组合成文本";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return tIfg2AudlOd;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return sOMg2Oll0RW;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return hg9g2FDtBGK;
		}
	}

	public string Description => "将（多个）变量组合成一段文本。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return wk2g2Uiregf;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return hVJg2lXEaq3;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return NLeg23yvXt6;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return J5Yg2fWWB12;
		}
	}

	[SpecialName]
	private static StepOutParamDef N6Gg2TC1uRd()
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
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.c3RSNZSYDYs = step;
		_003C_003Ec__DisplayClass37_.oyKSN95nk5P = context;
		_003C_003Ec__DisplayClass37_.OSsSNhUd2EV = this;
		_003C_003Ec__DisplayClass37_.jsSSNe4Lu2i = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass37_.oyKSN95nk5P, _003C_003Ec__DisplayClass37_.c3RSNZSYDYs, _003C_003Ec__DisplayClass37_.jsSSNe4Lu2i, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass37_.k0tSNVSDINK, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(PmIg2iBTgAS, step) ?? "";
	}

	private static StepInParamDef pERg2oRXMCc(int int_0)
	{
		return new StepInParamDef
		{
			Key = "p" + int_0,
			Name = "参数" + int_0,
			Description = $"第 {int_0} 个参数",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Any,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
	}

	static FormatStringStep()
	{
		PmIg2iBTgAS = new StepInParamDef
		{
			Key = "formatString",
			Name = "格式化字符串",
			Description = "使用C#的String.Format语法。",
			DefaultValue = "{0}",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
	}

	internal static bool so0CRPQPOKq98NSE1U9C()
	{
		return QUO8u5QPdQAogY8B1fNh == null;
	}
}
