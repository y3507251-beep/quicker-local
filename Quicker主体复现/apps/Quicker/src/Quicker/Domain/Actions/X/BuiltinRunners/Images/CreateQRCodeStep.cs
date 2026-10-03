using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using FontAwesome5;
using QRCoder;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class CreateQRCodeStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass48_0
	{
		public ActionStep Lv0SqpQmyFn;

		public ActionExecuteContext yuySqBIxYdo;

		public XAction qmfSqQVHCrk;

		internal static _003C_003Ec__DisplayClass48_0 Pk2RRVWabEW5i1MRD9Q6;

		internal (bool isSuccess, string message, ActionStopFlag failReason) JriSqrsy9bm()
		{
			_003C_003Ec__DisplayClass48_1 _003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_1();
			string textParamValue = XActionHelper.GetTextParamValue(AB6g7epyfAD, Lv0SqpQmyFn, yuySqBIxYdo);
			if (string.IsNullOrEmpty(textParamValue))
			{
				return (isSuccess: false, message: "要生成二维码的内容为空", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass48_.RNvSq5KcMCw = Convert.ToInt32(XActionHelper.GetIntegerParamValue(o2Xg7YhE736, Lv0SqpQmyFn, yuySqBIxYdo));
			string textParamValue2 = XActionHelper.GetTextParamValue(QM8g7IeV6Mj, Lv0SqpQmyFn, yuySqBIxYdo);
			string textParamValue3 = XActionHelper.GetTextParamValue(ix8g7WYZISU, Lv0SqpQmyFn, yuySqBIxYdo);
			Bitmap icon = XActionHelper.NbwtDs1GvAM(tbNg7kn3RyR, Lv0SqpQmyFn, yuySqBIxYdo);
			int iconSizePercent = (int)XActionHelper.GetIntegerParamValue(iMig7G20kLT, Lv0SqpQmyFn, yuySqBIxYdo);
			int iconBorderWidth = (int)XActionHelper.GetIntegerParamValue(MDQg7s7d1Ys, Lv0SqpQmyFn, yuySqBIxYdo);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(Tn8g7HgWVf8, Lv0SqpQmyFn, yuySqBIxYdo);
			QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
			_003C_003Ec__DisplayClass48_.qrLSq4N5ugg = qRCodeGenerator.CreateQrCode(textParamValue, QRCodeGenerator.ECCLevel.Q);
			Bitmap graphic = new QRCode(_003C_003Ec__DisplayClass48_.qrLSq4N5ugg).GetGraphic(_003C_003Ec__DisplayClass48_.RNvSq5KcMCw, ColorTranslator.FromHtml(textParamValue2), ColorTranslator.FromHtml(textParamValue3), icon, iconSizePercent, iconBorderWidth, booleanParamValue);
			XActionHelper.OutputResult(rGwg7XGlVuP, Lv0SqpQmyFn, yuySqBIxYdo, graphic, qmfSqQVHCrk);
			XActionHelper.OutputResultIfNeeded(pMeg7mioVhS, _003C_003Ec__DisplayClass48_.WBwSqjwhd9u, Lv0SqpQmyFn, yuySqBIxYdo, qmfSqQVHCrk);
			string textParamValue4 = XActionHelper.GetTextParamValue(kEeg716dncm, Lv0SqpQmyFn, yuySqBIxYdo);
			if (!string.IsNullOrEmpty(textParamValue4))
			{
				byte[] graphic2 = new PdfByteQRCode(_003C_003Ec__DisplayClass48_.qrLSq4N5ugg).GetGraphic(_003C_003Ec__DisplayClass48_.RNvSq5KcMCw);
				System.IO.File.WriteAllBytes(textParamValue4, graphic2);
			}
			XActionHelper.OutputResultIfNeeded(u05g7KL74eR, _003C_003Ec__DisplayClass48_.NbkSqnC64DA, Lv0SqpQmyFn, yuySqBIxYdo, qmfSqQVHCrk);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool pa8uyHWaqP3rgcCok2tU()
		{
			return Pk2RRVWabEW5i1MRD9Q6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass48_1
	{
		public QRCodeData qrLSq4N5ugg;

		public int RNvSq5KcMCw;

		private static _003C_003Ec__DisplayClass48_1 gvkuXnWalnyKyH1e6GBT;

		internal object WBwSqjwhd9u()
		{
			return new SvgQRCode(qrLSq4N5ugg).GetGraphic(RNvSq5KcMCw);
		}

		internal object NbkSqnC64DA()
		{
			return new AsciiQRCode(qrLSq4N5ugg).GetGraphic(1);
		}

		internal static void gAltUaWaYfM0Wr7ptehH()
		{
		}

		internal static bool ExQfUYWaZWfL5laKEYcQ()
		{
			return gvkuXnWalnyKyH1e6GBT == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> q1Ug7c4PDZr;

	[CompilerGenerated]
	private readonly string eKog7VIyEOB = $"fa:{EFontAwesomeIcon.Light_Qrcode}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> XWmg7ZsptAN;

	[CompilerGenerated]
	private readonly string hyvg791dN9i = "https://getquicker.net/KC/Help/Doc/createqrcode";

	[CompilerGenerated]
	private readonly bool NXfg7h74cyQ;

	private static readonly StepInParamDef AB6g7epyfAD;

	private static readonly StepInParamDef o2Xg7YhE736;

	private static readonly StepInParamDef QM8g7IeV6Mj;

	private static readonly StepInParamDef ix8g7WYZISU;

	private static readonly StepInParamDef tbNg7kn3RyR;

	private static readonly StepInParamDef iMig7G20kLT;

	private static readonly StepInParamDef MDQg7s7d1Ys;

	private static readonly StepInParamDef Tn8g7HgWVf8;

	private static readonly StepInParamDef kEeg716dncm;

	private static readonly StepInParamDef iO7g7bxnDXf;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> pL5g761I2q9 = new StepInParamDef[10] { AB6g7epyfAD, o2Xg7YhE736, QM8g7IeV6Mj, ix8g7WYZISU, tbNg7kn3RyR, iMig7G20kLT, MDQg7s7d1Ys, Tn8g7HgWVf8, kEeg716dncm, iO7g7bxnDXf };

	private static readonly StepOutParamDef rGwg7XGlVuP;

	private static readonly StepOutParamDef pMeg7mioVhS;

	private static readonly StepOutParamDef u05g7KL74eR;

	private static readonly StepOutParamDef NSlg7xQD58m;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> YVVg7rIKm8L = new StepOutParamDef[4] { NSlg7xQD58m, rGwg7XGlVuP, pMeg7mioVhS, u05g7KL74eR };

	private static CreateQRCodeStep uKb6inQ6nU0UhppClMMC;

	public string Key => "sys:createQrCode";

	public string Name => "生成二维码";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return q1Ug7c4PDZr;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return eKog7VIyEOB;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return XWmg7ZsptAN;
		}
	}

	public string Description => "将文本转换为二维码";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return hyvg791dN9i;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return NXfg7h74cyQ;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return pL5g761I2q9;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return YVVg7rIKm8L;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0();
		_003C_003Ec__DisplayClass48_.Lv0SqpQmyFn = step;
		_003C_003Ec__DisplayClass48_.yuySqBIxYdo = context;
		_003C_003Ec__DisplayClass48_.qmfSqQVHCrk = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass48_.yuySqBIxYdo, _003C_003Ec__DisplayClass48_.Lv0SqpQmyFn, _003C_003Ec__DisplayClass48_.qmfSqQVHCrk, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass48_.JriSqrsy9bm, (Action)null, (Action)null, iO7g7bxnDXf, NSlg7xQD58m);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(AB6g7epyfAD, step) + " => " + XActionHelper.GetOutputParamDisplayString(rGwg7XGlVuP, step);
	}

	static CreateQRCodeStep()
	{
		AB6g7epyfAD = new StepInParamDef
		{
			Key = "code",
			Name = "文本",
			Description = "要转换为二维码的内容",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		o2Xg7YhE736 = new StepInParamDef
		{
			Key = "pixelsPerModule",
			Name = "每模块像素数",
			Type = VarType.Integer,
			DefaultValue = 4,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		QM8g7IeV6Mj = new StepInParamDef
		{
			Key = "darkColor",
			Name = "暗色",
			Description = "#AARRGGBB格式的颜色值",
			Type = VarType.Text,
			DefaultValue = "#FF000000",
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType>
			{
				TextToolType.ColorPicker,
				TextToolType.SelectColor
			},
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		ix8g7WYZISU = new StepInParamDef
		{
			Key = "lightColor",
			Name = "亮色",
			Description = "#AARRGGBB格式的颜色值",
			Type = VarType.Text,
			DefaultValue = "#FFFFFFFF",
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType>
			{
				TextToolType.ColorPicker,
				TextToolType.SelectColor
			},
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		tbNg7kn3RyR = new StepInParamDef
		{
			Key = "icon",
			Name = "图标",
			Description = "图片变量或图标文件路径",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Image
		};
		iMig7G20kLT = new StepInParamDef
		{
			Key = "iconPercent",
			Name = "图标占比",
			Description = "百分比数字（只填数字，不写百分号）",
			Type = VarType.Integer,
			DefaultValue = 15,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		MDQg7s7d1Ys = new StepInParamDef
		{
			Key = "iconBorderWidth",
			Name = "图标边框宽度",
			Description = "最小为1",
			Type = VarType.Integer,
			DefaultValue = 6,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Tn8g7HgWVf8 = new StepInParamDef
		{
			Key = "drawQuietZones",
			Name = "绘制外框",
			Type = VarType.Boolean,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		kEeg716dncm = new StepInParamDef
		{
			Key = "saveToPdfPath",
			Name = "输出pdf文件",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		iO7g7bxnDXf = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		rGwg7XGlVuP = new StepOutParamDef
		{
			Key = "img",
			Name = "二维码图片",
			Description = "生成的二维码图片对象",
			Type = VarType.Image
		};
		pMeg7mioVhS = new StepOutParamDef
		{
			Key = "svg",
			Name = "SVG格式结果",
			Description = "Svg格式结果代码",
			Type = VarType.Text
		};
		u05g7KL74eR = new StepOutParamDef
		{
			Key = "ascii",
			Name = "Ascii格式结果",
			Description = "Ascii字符格式结果代码",
			Type = VarType.Text
		};
		NSlg7xQD58m = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool p7ys7UQ6e6h8wMeWklA7()
	{
		return uKb6inQ6nU0UhppClMMC == null;
	}
}
