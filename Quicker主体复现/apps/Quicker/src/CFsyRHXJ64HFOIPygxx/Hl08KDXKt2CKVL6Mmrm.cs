using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Actions.XActions.StepRunners;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace CFsyRHXJ64HFOIPygxx;

internal class Hl08KDXKt2CKVL6Mmrm : BaseMultiOperationStep, IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Ig8ShuhMaWB;

		public static StepOperation.GetSummaryFunc WN5ShNj8t6D;

		public static StepOperation.ExecuteFunc yrwShJ0JRKt;

		public static StepOperation.GetSummaryFunc jBJSh0yIDg9;

		public static StepOperation.ExecuteFunc cyDShCTDS3U;

		internal static _003C_003Ec M9eYKAW9xEB0JhcVbS47;

		static _003C_003Ec()
		{
			Ig8ShuhMaWB = new _003C_003Ec();
		}

		internal string sAnShL0j9Vh(ActionStep step)
		{
			return "提取文本内容";
		}

		internal StepExecuteResult gttShvTmFJs(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
		{
			XActionHelper.GetTextParamValue(W8Dge7fXg00, step, context);
			XActionHelper.OutputResult(frGgeclueHc, step, context, "Sample Result", action);
			return StepExecuteResult.Success;
		}

		internal string JQBShSTQLfC(ActionStep step)
		{
			return "提取表格内容";
		}

		internal StepExecuteResult H17Sh21oETw(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
		{
			XActionHelper.GetTextParamValue(W8Dge7fXg00, step, context);
			XActionHelper.OutputResult(frGgeclueHc, step, context, "Table Result", action);
			return StepExecuteResult.Success;
		}

		internal static bool PpXkOoW9I0A20mhk8b9X()
		{
			return M9eYKAW9xEB0JhcVbS47 == null;
		}
	}

	[CompilerGenerated]
	private readonly string KOege2gkZJZ = "sys:test";

	[CompilerGenerated]
	private readonly string hQQgeuSir6b = "测试多操作步骤";

	[CompilerGenerated]
	private readonly IEnumerable<string> GJvgeN21aHo = Enumerable.Empty<string>();

	[CompilerGenerated]
	private readonly string NK2geJYNUGG = "fa:Light_Cog:#FF0000";

	[CompilerGenerated]
	private readonly StepRunnerCategory g0Yge0Lj4jq = StepRunnerCategory.Network;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> XN4geCuOb6d;

	[CompilerGenerated]
	private readonly string JM4gePfO28W = "用于测试";

	[CompilerGenerated]
	private readonly StepType V2WgeEjA61S;

	[CompilerGenerated]
	private readonly string P7WgeyWAGmY = "https://baidu.com";

	[CompilerGenerated]
	private readonly bool atxge8mRw1e;

	[CompilerGenerated]
	private readonly bool t9egeaPlvqB;

	private static StepInParamDef W8Dge7fXg00;

	private static StepInParamDef irLgeR7ZB4a;

	private static StepInParamDef hO4geq07DQk;

	private static readonly StepOutParamDef frGgeclueHc;

	private static readonly StepOutParamDef KrbgeVL2jJw;

	internal static Hl08KDXKt2CKVL6Mmrm OrkA6lQw4OYC5sYZ7APT;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return KOege2gkZJZ;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return hQQgeuSir6b;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return GJvgeN21aHo;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return NK2geJYNUGG;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return g0Yge0Lj4jq;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return XN4geCuOb6d;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return JM4gePfO28W;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return V2WgeEjA61S;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return P7WgeyWAGmY;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return atxge8mRw1e;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return t9egeaPlvqB;
		}
	}

	public Hl08KDXKt2CKVL6Mmrm()
	{
		try
		{
			SetupParams(new StepInParamDef[3] { W8Dge7fXg00, irLgeR7ZB4a, hO4geq07DQk }, new StepOutParamDef[2] { frGgeclueHc, KrbgeVL2jJw });
			StepOperation operation = new StepOperation
			{
				Key = "extractText",
				Title = "提取文本内容",
				GetSummary = (_003C_003Ec.WN5ShNj8t6D ?? (_003C_003Ec.WN5ShNj8t6D = _003C_003Ec.Ig8ShuhMaWB.sAnShL0j9Vh)),
				InputParams = { W8Dge7fXg00, irLgeR7ZB4a },
				OutputParams = { frGgeclueHc, KrbgeVL2jJw },
				Execute = (_003C_003Ec.yrwShJ0JRKt ?? (_003C_003Ec.yrwShJ0JRKt = _003C_003Ec.Ig8ShuhMaWB.gttShvTmFJs))
			};
			AddOperation(operation, true);
			AddOperation(new StepOperation
			{
				Key = "extractTable",
				Title = "提取表格内容",
				GetSummary = (_003C_003Ec.jBJSh0yIDg9 ?? (_003C_003Ec.jBJSh0yIDg9 = _003C_003Ec.Ig8ShuhMaWB.JQBShSTQLfC)),
				InputParams = { W8Dge7fXg00, hO4geq07DQk },
				OutputParams = { frGgeclueHc, KrbgeVL2jJw },
				Execute = (_003C_003Ec.cyDShCTDS3U ?? (_003C_003Ec.cyDShCTDS3U = _003C_003Ec.Ig8ShuhMaWB.H17Sh21oETw))
			}, true);
		}
		catch (Exception)
		{
		}
	}

	static Hl08KDXKt2CKVL6Mmrm()
	{
		W8Dge7fXg00 = new StepInParamDef
		{
			Key = "source",
			Name = "源HTML",
			Description = "原始HTML内容，或网址，或根节点对象",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = true,
			IsRequired = true
		};
		irLgeR7ZB4a = new StepInParamDef
		{
			Key = "encoding",
			Name = "网页编码类型",
			Description = "通过网址加载内容时，使用指定的编码。留空时默认为UTF8。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = false,
			IsRequired = false,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("auto", "自动检测 (加载两次)"),
				new SelectionItem("gb2312", "GB2312编码"),
				new SelectionItem("utf-8", "UTF8编码")
			}
		};
		hO4geq07DQk = new StepInParamDef
		{
			Key = "xpath",
			Name = "节点XPath",
			Description = "内容的XPath，详细说明请参考文档",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = false,
			IsRequired = true
		};
		frGgeclueHc = new StepOutParamDef
		{
			Key = "value",
			Name = "提取值",
			Description = "提取的内容。请确保结果类型和变量类型匹配。",
			Type = VarType.Any
		};
		KrbgeVL2jJw = new StepOutParamDef
		{
			Key = "rootNode",
			Name = "根节点",
			Description = "整个HTML源内容对应的HtmlNode节点对象，可用于后续处理使用。",
			Type = VarType.Any
		};
	}

	internal static bool oBguSeQwhO5kgZE3ig2s()
	{
		return OrkA6lQw4OYC5sYZ7APT == null;
	}
}
