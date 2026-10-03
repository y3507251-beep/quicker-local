using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Ink;
using FontAwesome5;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common.Enums;
using Quicker.Common.Services.MathOcr;
using Quicker.Common.Vm;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.View.UI;

namespace Quicker.Actions.XActions.BuildinRunners;

public class MathOcrStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec AZwSkydj1gd;

		public static Func<Mathpix.DataItem, bool> yGlSk8VIHZn;

		public static Func<Mathpix.DataItem, bool> a2ASkaOOA39;

		public static Func<Mathpix.DataItem, bool> DeBSk7b0MeE;

		internal static _003C_003Ec TUBsXwWfB5rNIClwweal;

		static _003C_003Ec()
		{
			AZwSkydj1gd = new _003C_003Ec();
		}

		internal bool HSFSkCpQyif(Mathpix.DataItem x)
		{
			return string.Equals(x.type, "latex", StringComparison.OrdinalIgnoreCase);
		}

		internal bool hHfSkPKVKgY(Mathpix.DataItem x)
		{
			return string.Equals(x.type, "mathml", StringComparison.OrdinalIgnoreCase);
		}

		internal bool hC6SkEei9vO(Mathpix.DataItem x)
		{
			return string.Equals(x.type, "asciimath", StringComparison.OrdinalIgnoreCase);
		}

		internal static bool jIDg69WfvcwD1eclRdOg()
		{
			return TUBsXwWfB5rNIClwweal == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public ActionStep AmrSkqDc9SU;

		public ActionExecuteContext TwYSkcLkEh1;

		public XAction PqFSkVWLTH1;

		internal static _003C_003Ec__DisplayClass45_0 IJwjlgWfJoDSnU5Kcf1M;

		internal (bool isSuccess, string message, ActionStopFlag failReason) we2SkRo14PC()
		{
			return (false, "原厂公式 OCR 服务已删除，请使用本地工具或自行配置的识别服务。", ActionStopFlag.OperationFailed);
		}

		internal static bool O1UH1HWfkNjBGn22qZBf()
		{
			return IJwjlgWfJoDSnU5Kcf1M == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_1
	{
		public WhiteboardWindow EXRSkhQYhtM;

		public bool ra9SkexMrQV;

		public StrokeCollection krQSkYY5Qcw;

		public EventHandler XCYSkI4AeJS;

		internal static _003C_003Ec__DisplayClass45_1 JlXQiCWfrcT794tfRFBW;

		internal void qt8SkZDjo6r()
		{
			EXRSkhQYhtM = new WhiteboardWindow(false, false);
			EXRSkhQYhtM.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			EXRSkhQYhtM.Closed += XCYSkI4AeJS ?? (XCYSkI4AeJS = DN6Sk9iNOoI);
			EXRSkhQYhtM.Show();
		}

		internal void DN6Sk9iNOoI(object sender, EventArgs e)
		{
			ra9SkexMrQV = true;
			krQSkYY5Qcw = (EXRSkhQYhtM.IsSuccess ? EXRSkhQYhtM.Strokes : null);
		}

		internal static void oQvk5FWfLD5reoKLxrBt()
		{
		}

		internal static bool UC1nF2WfNQlLsNJx78K7()
		{
			return JlXQiCWfrcT794tfRFBW == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> te1gbnkmCSo = new List<string> { "mathpix", "api" };

	[CompilerGenerated]
	private readonly string PKIgb4RhbVA = $"fa:{EFontAwesomeIcon.Light_Function}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> AOLgb5lYAIr = new StepRunnerCategory[1] { StepRunnerCategory.Image };

	[CompilerGenerated]
	private readonly string aM6gbDfcIk8 = "https://getquicker.net/KC/Help/Doc/mathocr";

	private static IList<SelectionItem> z4fgbdBvR2K;

	private static readonly StepInParamDef bfNgboa9LKD;

	private static readonly StepInParamDef SG8gbTdjgFO;

	private static readonly StepInParamDef tmmgbMungng;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> rtogbAX6xvd = new StepInParamDef[3] { bfNgboa9LKD, SG8gbTdjgFO, tmmgbMungng };

	private static readonly StepOutParamDef tRkgbOpMPOe;

	public static readonly StepOutParamDef MathpixMarkdownOutputParam;

	public static readonly StepOutParamDef MathmlOutputParam;

	public static readonly StepOutParamDef AsciimathOutputParam;

	public static readonly StepOutParamDef LatexOutputParam;

	public static readonly StepOutParamDef LatexEx1OutputParam;

	public static readonly StepOutParamDef LatexEx2OutputParam;

	private static readonly StepOutParamDef B3DgbFA1Z5K;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> qscgbUij18p = new List<StepOutParamDef> { tRkgbOpMPOe, MathpixMarkdownOutputParam, LatexOutputParam, MathmlOutputParam, AsciimathOutputParam, LatexEx1OutputParam, LatexEx2OutputParam, B3DgbFA1Z5K };

	internal static MathOcrStep zLK5AfQCkgLqhx7TWbTR;

	public string Key => "sys:mathocr";

	public string Name => "公式识别";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return te1gbnkmCSo;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return PKIgb4RhbVA;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return AOLgb5lYAIr;
		}
	}

	public string Description => "数学公式识别";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return aM6gbDfcIk8;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return rtogbAX6xvd;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return qscgbUij18p;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
		_003C_003Ec__DisplayClass45_.AmrSkqDc9SU = step;
		_003C_003Ec__DisplayClass45_.TwYSkcLkEh1 = context;
		_003C_003Ec__DisplayClass45_.PqFSkVWLTH1 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass45_.TwYSkcLkEh1, _003C_003Ec__DisplayClass45_.AmrSkqDc9SU, _003C_003Ec__DisplayClass45_.PqFSkVWLTH1, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass45_.we2SkRo14PC, (Action)null, (Action)null, tmmgbMungng, tRkgbOpMPOe);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	static MathOcrStep()
	{
		z4fgbdBvR2K = new SelectionItem[2]
		{
			new SelectionItem(Vendors.Mathpix.ToString(), "图片识别(Mathpix)"),
			new SelectionItem(Vendors.MathpixStrokes.ToString(), "手写并识别(Mathpix)")
		};
		bfNgboa9LKD = new StepInParamDef
		{
			Key = "vendor",
			Name = "厂商接口",
			Description = "详情请参考文档。",
			Type = VarType.Enum,
			DefaultValue = Vendors.Mathpix.ToString(),
			VariableMode = ParamVariableMode.Input,
			SelectionItems = z4fgbdBvR2K,
			IsControlField = true
		};
		SG8gbTdjgFO = new StepInParamDef
		{
			Key = "image",
			Name = "公式图片",
			Description = "指定待识别的图片变量、图片文件的路径或网址(通过表达式传入)。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVarOrInput,
			InvalidForList = new string[1] { Vendors.MathpixStrokes.ToString() }
		};
		tmmgbMungng = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		tRkgbOpMPOe = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		MathpixMarkdownOutputParam = new StepOutParamDef
		{
			Key = "mathpixMarkdown",
			Name = "Mathpix MD",
			Description = "Mathpix Markdown格式",
			Type = VarType.Text
		};
		MathmlOutputParam = new StepOutParamDef
		{
			Key = "mathml",
			Name = "MathML",
			Description = "",
			Type = VarType.Text
		};
		AsciimathOutputParam = new StepOutParamDef
		{
			Key = "asciimath",
			Name = "AsciiMath",
			Description = "",
			Type = VarType.Text
		};
		LatexOutputParam = new StepOutParamDef
		{
			Key = "latex",
			Name = "Latex",
			Description = "",
			Type = VarType.Text
		};
		LatexEx1OutputParam = new StepOutParamDef
		{
			Key = "latexEx1",
			Name = "Latex附加格式1",
			Description = "",
			Type = VarType.Text
		};
		LatexEx2OutputParam = new StepOutParamDef
		{
			Key = "latexEx2",
			Name = "Latex附加格式2",
			Description = "",
			Type = VarType.Text
		};
		B3DgbFA1Z5K = new StepOutParamDef
		{
			Key = "rawData",
			Name = "原始响应",
			Description = "厂商接口返回的原始内容，通常为json格式。",
			Type = VarType.Text
		};
	}

	internal static bool LOEtAuQCaE75rHAxJ3XA()
	{
		return zLK5AfQCkgLqhx7TWbTR == null;
	}
}
