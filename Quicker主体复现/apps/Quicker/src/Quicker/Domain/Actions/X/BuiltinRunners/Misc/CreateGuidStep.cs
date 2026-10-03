using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class CreateGuidStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public ActionStep o7CSRPQIxrp;

		public ActionExecuteContext mjnSREfx7Qd;

		public XAction xUnSRyJdVoY;

		private static _003C_003Ec__DisplayClass37_0 thD0h7Wkbc4NGX96srca;

		internal (bool isSuccess, string message, ActionStopFlag failReason) xIRSRCD6ZbG()
		{
			string textParamValue = XActionHelper.GetTextParamValue(Sqxg82OBcNu, o7CSRPQIxrp, mjnSREfx7Qd);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(kKkg8uOnulW, o7CSRPQIxrp, mjnSREfx7Qd);
			string text = Guid.NewGuid().ToString(string.IsNullOrEmpty(textParamValue) ? "D" : textParamValue, CultureInfo.InvariantCulture);
			text = ((!booleanParamValue) ? text.ToLowerInvariant() : text.ToUpperInvariant());
			XActionHelper.OutputResult(KnGg8JTikBq, o7CSRPQIxrp, mjnSREfx7Qd, text, xUnSRyJdVoY);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool gY7B92WkqlmOakDvOid6()
		{
			return thD0h7Wkbc4NGX96srca == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> yQRg8tLAXks = new string[1] { "全局唯一ID" };

	[CompilerGenerated]
	private readonly string qZng8gPCcTS = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> gPMg8LhF1e8;

	[CompilerGenerated]
	private readonly string Qleg8vPnpJM = "https://getquicker.net/KC/Help/Doc/newguid";

	[CompilerGenerated]
	private readonly bool DQIg8SRD4Vd;

	private static readonly StepInParamDef Sqxg82OBcNu;

	private static readonly StepInParamDef kKkg8uOnulW;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> nkXg8N0NTtl = new StepInParamDef[2] { Sqxg82OBcNu, kKkg8uOnulW };

	private static readonly StepOutParamDef KnGg8JTikBq;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> bXlg80912Pg = new StepOutParamDef[1] { KnGg8JTikBq };

	private static CreateGuidStep VLOJmUQIW3Q9LpdBYEia;

	public string Key => "sys:newGuid";

	public string Name => "生成Guid";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return yQRg8tLAXks;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return qZng8gPCcTS;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return gPMg8LhF1e8;
		}
	}

	public string Description => "生成一个新的Guid(全局唯一ID标示符)，并转换为文本格式。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return Qleg8vPnpJM;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return DQIg8SRD4Vd;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return nkXg8N0NTtl;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return bXlg80912Pg;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.o7CSRPQIxrp = step;
		_003C_003Ec__DisplayClass37_.mjnSREfx7Qd = context;
		_003C_003Ec__DisplayClass37_.xUnSRyJdVoY = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass37_.mjnSREfx7Qd, _003C_003Ec__DisplayClass37_.o7CSRPQIxrp, _003C_003Ec__DisplayClass37_.xUnSRyJdVoY, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass37_.xIRSRCD6ZbG, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "输出到：" + XActionHelper.GetOutputParamDisplayString(KnGg8JTikBq, step);
	}

	static CreateGuidStep()
	{
		Sqxg82OBcNu = new StepInParamDef
		{
			Key = "format",
			Name = "格式",
			Description = "转换为文本时使用的格式",
			DefaultValue = "D",
			Type = VarType.Enum,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("D", "默认：00000000-0000-0000-0000-000000000000"),
				new SelectionItem("N", "去除连字符：00000000000000000000000000000000"),
				new SelectionItem("B", "大括号包围：{00000000-0000-0000-0000-000000000000}"),
				new SelectionItem("P", "小括号包围：(00000000-0000-0000-0000-000000000000)"),
				new SelectionItem("X", "十六进制：{0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}}")
			}
		};
		kKkg8uOnulW = new StepInParamDef
		{
			Key = "upper",
			Name = "大写",
			DefaultValue = false,
			Description = "字母输出为大写格式。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		KnGg8JTikBq = new StepOutParamDef
		{
			Key = "output",
			Name = "内容",
			Description = "将获得的文本写入到变量",
			Type = VarType.Text
		};
	}

	internal static bool l5B3bxQIyClDaHw2FSd4()
	{
		return VLOJmUQIW3Q9LpdBYEia == null;
	}
}
