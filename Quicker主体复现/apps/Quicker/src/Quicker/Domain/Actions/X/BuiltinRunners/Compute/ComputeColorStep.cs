using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using c4LBdq5YohQFUgxFYw4;
using FontAwesome5;
using nVJdY15fbnHJJyC6ngN;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Compute;

public class ComputeColorStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_0
	{
		public ActionStep Ul9SyiO4u9A;

		public ActionExecuteContext bo9Sy3JUf2n;

		public XAction YpXSyf9NK1K;

		public ComputeColorStep vRcSyzrULfG;

		private static _003C_003Ec__DisplayClass67_0 zur8TbWOg4lfkHBiXtwQ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) B02SylVb7fH()
		{
			_003C_003Ec__DisplayClass67_1 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_1();
			string textParamValue = XActionHelper.GetTextParamValue(uJsgCwZ8suy, Ul9SyiO4u9A, bo9Sy3JUf2n);
			_003C_003Ec__DisplayClass67_.MODS8trrKrH = Color.Empty;
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			case "editOrSelectColor":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(HTEgCtVPqHn, Ul9SyiO4u9A, bo9Sy3JUf2n);
				if (string.IsNullOrEmpty(textParamValue3))
				{
					return (isSuccess: false, message: "颜色文本值为空", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass67_.MODS8trrKrH = ColorHelper.StringToWinformColor(textParamValue3);
				_003C_003Ec__DisplayClass67_.efoS8ghftDF = false;
				_003C_003Ec__DisplayClass67_.qVlS8LMImkt = null;
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass67_.XMcS8wpXvLc);
				while (!_003C_003Ec__DisplayClass67_.efoS8ghftDF)
				{
					Thread.Sleep(50);
				}
				if (!_003C_003Ec__DisplayClass67_.qVlS8LMImkt.HasValue)
				{
					return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
				}
				_003C_003Ec__DisplayClass67_.MODS8trrKrH = _003C_003Ec__DisplayClass67_.qVlS8LMImkt.Value;
				break;
			}
			case "selectFromScreen":
			{
				_003C_003Ec__DisplayClass67_2 _003C_003Ec__DisplayClass67_2 = new _003C_003Ec__DisplayClass67_2
				{
					rmAS8S2f7nG = null
				};
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass67_2.KJ4S8v1f35b);
				if (!_003C_003Ec__DisplayClass67_2.rmAS8S2f7nG.IsSuccess)
				{
					return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
				}
				_003C_003Ec__DisplayClass67_.MODS8trrKrH = _003C_003Ec__DisplayClass67_2.rmAS8S2f7nG.wZFmIfirit();
				break;
			}
			case "fromScreenPosition":
			{
				string[] array = XActionHelper.GetTextParamValue(yfhgCLeghLv, Ul9SyiO4u9A, bo9Sy3JUf2n).Split(',');
				Point location = new Point(int.Parse(array[0]), int.Parse(array[1]));
				_003C_003Ec__DisplayClass67_.MODS8trrKrH = ColorHelper.GetColorAt(location);
				break;
			}
			case "fromString":
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(HTEgCtVPqHn, Ul9SyiO4u9A, bo9Sy3JUf2n);
				if (string.IsNullOrEmpty(textParamValue2))
				{
					return (isSuccess: false, message: "颜色文本值为空", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass67_.MODS8trrKrH = ColorHelper.StringToWinformColor(textParamValue2);
				break;
			}
			}
			XActionHelper.OutputResult(hmLgCuIGpmh, Ul9SyiO4u9A, bo9Sy3JUf2n, _003C_003Ec__DisplayClass67_.MODS8trrKrH.A, YpXSyf9NK1K);
			XActionHelper.OutputResult(rehgCNFk16R, Ul9SyiO4u9A, bo9Sy3JUf2n, _003C_003Ec__DisplayClass67_.MODS8trrKrH.R, YpXSyf9NK1K);
			XActionHelper.OutputResult(RgQgCJ3XB4W, Ul9SyiO4u9A, bo9Sy3JUf2n, _003C_003Ec__DisplayClass67_.MODS8trrKrH.G, YpXSyf9NK1K);
			XActionHelper.OutputResult(EcggC0LCk7c, Ul9SyiO4u9A, bo9Sy3JUf2n, _003C_003Ec__DisplayClass67_.MODS8trrKrH.B, YpXSyf9NK1K);
			XActionHelper.OutputResult(tB4gCCHgK5C, Ul9SyiO4u9A, bo9Sy3JUf2n, _003C_003Ec__DisplayClass67_.MODS8trrKrH.GetHue(), YpXSyf9NK1K);
			(double, double, double) hSL = _003C_003Ec__DisplayClass67_.MODS8trrKrH.GetHSL();
			XActionHelper.OutputResult(jWVgCP8cc1A, Ul9SyiO4u9A, bo9Sy3JUf2n, hSL.Item2, YpXSyf9NK1K);
			XActionHelper.OutputResult(sYZgCEtJ29K, Ul9SyiO4u9A, bo9Sy3JUf2n, hSL.Item3, YpXSyf9NK1K);
			(double, double, double) hSV = _003C_003Ec__DisplayClass67_.MODS8trrKrH.GetHSV();
			XActionHelper.OutputResult(QnpgCy0w9In, Ul9SyiO4u9A, bo9Sy3JUf2n, hSV.Item2, YpXSyf9NK1K);
			XActionHelper.OutputResult(uF9gC8chs9J, Ul9SyiO4u9A, bo9Sy3JUf2n, hSV.Item3, YpXSyf9NK1K);
			string textParamValue4 = XActionHelper.GetTextParamValue(t2pgCgdEMsd, Ul9SyiO4u9A, bo9Sy3JUf2n);
			XActionHelper.OutputResult(UTsgCavqCN3, Ul9SyiO4u9A, bo9Sy3JUf2n, vRcSyzrULfG.ColorToString(_003C_003Ec__DisplayClass67_.MODS8trrKrH, textParamValue4), YpXSyf9NK1K);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool j1BhRdWOPpFP176cIhBh()
		{
			return zur8TbWOg4lfkHBiXtwQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_1
	{
		public Color MODS8trrKrH;

		public bool efoS8ghftDF;

		public Color? qVlS8LMImkt;

		private static _003C_003Ec__DisplayClass67_1 QscfcpWOUehwQt0FVs3u;

		internal void XMcS8wpXvLc()
		{
			_003C_003Ec__DisplayClass67_3 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_3();
			_003C_003Ec__DisplayClass67_.FIRS8NgodwI = this;
			_003C_003Ec__DisplayClass67_.nwvS8uAJkDX = new ColorSelectorWindow(MODS8trrKrH.ToMediaColor());
			_003C_003Ec__DisplayClass67_.nwvS8uAJkDX.Closed += _003C_003Ec__DisplayClass67_.fD5S82Erahf;
			_003C_003Ec__DisplayClass67_.nwvS8uAJkDX.Show();
			_003C_003Ec__DisplayClass67_.nwvS8uAJkDX.Activate();
		}

		internal static bool PYx9HeWOxkbJeAR32pKN()
		{
			return QscfcpWOUehwQt0FVs3u == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_2
	{
		public qsQtMm5MtHtoYi1dcdV rmAS8S2f7nG;

		internal static _003C_003Ec__DisplayClass67_2 CMeETGWOSMSkd8g4tU7g;

		internal void KJ4S8v1f35b()
		{
			rmAS8S2f7nG = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Color);
		}

		internal static bool KBuS7qWOwu6SXqRmAHc2()
		{
			return CMeETGWOSMSkd8g4tU7g == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_3
	{
		public ColorSelectorWindow nwvS8uAJkDX;

		public _003C_003Ec__DisplayClass67_1 FIRS8NgodwI;

		internal static _003C_003Ec__DisplayClass67_3 g1F5lvWOm3HJJuNgYrGW;

		internal void fD5S82Erahf(object sender, EventArgs e)
		{
			FIRS8NgodwI.efoS8ghftDF = true;
			FIRS8NgodwI.qVlS8LMImkt = nwvS8uAJkDX.SelectedColor?.ToSystemDrawingColor();
		}

		internal static bool VEYst6WOsuSckyIA1Per()
		{
			return g1F5lvWOm3HJJuNgYrGW == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> z2jg0lqVgGc = new string[1] { "color" };

	[CompilerGenerated]
	private readonly string ti3g0iEuCPQ = $"fa:{EFontAwesomeIcon.Solid_FillDrip}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> rfcg038jiwr;

	[CompilerGenerated]
	private readonly string QAOg0fABb2j = "https://getquicker.net/KC/Help/Doc/color";

	[CompilerGenerated]
	private readonly bool pIwg0z6pIav;

	private static readonly StepInParamDef uJsgCwZ8suy;

	private static readonly StepInParamDef HTEgCtVPqHn;

	private static readonly StepInParamDef t2pgCgdEMsd;

	private static readonly StepInParamDef yfhgCLeghLv;

	private static readonly StepInParamDef BnZgCvVW8wp;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> myBgCSV4f7I = new List<StepInParamDef> { uJsgCwZ8suy, HTEgCtVPqHn, yfhgCLeghLv, t2pgCgdEMsd, BnZgCvVW8wp };

	private static readonly StepOutParamDef OAmgC2MohmQ;

	private static readonly StepOutParamDef hmLgCuIGpmh;

	private static readonly StepOutParamDef rehgCNFk16R;

	private static readonly StepOutParamDef RgQgCJ3XB4W;

	private static readonly StepOutParamDef EcggC0LCk7c;

	private static readonly StepOutParamDef tB4gCCHgK5C;

	private static readonly StepOutParamDef jWVgCP8cc1A;

	private static readonly StepOutParamDef sYZgCEtJ29K;

	private static readonly StepOutParamDef QnpgCy0w9In;

	private static readonly StepOutParamDef uF9gC8chs9J;

	private static readonly StepOutParamDef UTsgCavqCN3;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> rdhgC72sbxM = new List<StepOutParamDef>
	{
		OAmgC2MohmQ, hmLgCuIGpmh, rehgCNFk16R, RgQgCJ3XB4W, EcggC0LCk7c, tB4gCCHgK5C, jWVgCP8cc1A, sYZgCEtJ29K, QnpgCy0w9In, uF9gC8chs9J,
		UTsgCavqCN3
	};

	internal static ComputeColorStep khhH1EQUdQDE8FtanMlO;

	public string Key => "sys:color";

	public string Name => "屏幕取色/颜色转换与计算";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return z2jg0lqVgGc;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ti3g0iEuCPQ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return rfcg038jiwr;
		}
	}

	public string Description => "转换颜色值及相关计算处理";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return QAOg0fABb2j;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return pIwg0z6pIav;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return myBgCSV4f7I;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return rdhgC72sbxM;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
		_003C_003Ec__DisplayClass67_.Ul9SyiO4u9A = step;
		_003C_003Ec__DisplayClass67_.bo9Sy3JUf2n = context;
		_003C_003Ec__DisplayClass67_.YpXSyf9NK1K = action;
		_003C_003Ec__DisplayClass67_.vRcSyzrULfG = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass67_.bo9Sy3JUf2n, _003C_003Ec__DisplayClass67_.Ul9SyiO4u9A, _003C_003Ec__DisplayClass67_.YpXSyf9NK1K, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass67_.B02SylVb7fH, (Action)null, (Action)null, BnZgCvVW8wp, OAmgC2MohmQ);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(uJsgCwZ8suy, step) ?? "";
	}

	public string ColorToString(Color color, string format)
	{
		if (format != null)
		{
			int num;
			char c = default(char);
			int num2 = default(int);
			switch (format.Length)
			{
			default:
				num = 1;
				if (!maZbLsQUO8ay4XwJtF0h())
				{
					goto IL_02a6;
				}
				goto IL_02aa;
			case 3:
				c = format[0];
				goto IL_0390;
			case 4:
				switch (format[0])
				{
				case 'r':
					if (format == "rgba")
					{
						return $"rgba({color.R}, {color.G}, {color.B}, {(double)(int)color.A / 255.0})";
					}
					break;
				case 'h':
					if (format == "hsla")
					{
						(double, double, double) hSL = color.GetHSL();
						return $"hsla({hSL.Item1}, {hSL.Item2:P}, {hSL.Item3:P}, {(float)(int)color.A / 255f})";
					}
					break;
				case 'C':
					if (format == "CMYK")
					{
						(float, float, float, float) tuple = ColorHelper.ConvertRgbToCmyk(color.R, color.G, color.B);
						return $"{tuple.Item1 * 100f},{tuple.Item2 * 100f},{tuple.Item3 * 100f},{tuple.Item4 * 100f}";
					}
					break;
				}
				break;
			case 5:
				if (format == "Swift")
				{
					return $"red:{(float)(int)color.R / 255f}, green:{(float)(int)color.G / 255f}, blue:{(float)(int)color.B / 255f}, alpha:{(double)(int)color.A / 255.0}";
				}
				break;
			case 7:
				c = format[1];
				if (c != 'E')
				{
					goto IL_02e5;
				}
				if (format == "HEX_RGB")
				{
					return color.ToRgbHexString();
				}
				break;
			case 8:
				c = format[0];
				if (c != 'D')
				{
					num = 0;
					if (khhH1EQUdQDE8FtanMlO != null)
					{
						goto IL_02a6;
					}
					goto IL_02aa;
				}
				if (!(format == "DOT_RGBA"))
				{
					if (format == "DOT_ARGB")
					{
						return $"{color.A}, {color.R}, {color.G}, {color.B}";
					}
					break;
				}
				return $"{color.R}, {color.G}, {color.B}, {color.A}";
			case 10:
				if (format == "float_rgba")
				{
					return $"{(double)(int)color.R / 255.0}f,{(double)(int)color.G / 255.0}f,{(double)(int)color.B / 255.0}f,{(double)(int)color.A / 255.0}f";
				}
				break;
			case 6:
			case 9:
				break;
				IL_02e5:
				switch (c)
				{
				case 'S':
					if (format == "HSV_HSB")
					{
						(double, double, double) hSV = color.GetHSV();
						return $"{hSV.Item1},{hSV.Item2 * 100.0}, {hSV.Item3 * 100.0}";
					}
					break;
				case 'O':
					if (format == "DOT_RGB")
					{
						return $"{color.R}, {color.G}, {color.B}";
					}
					break;
				}
				break;
				IL_02a6:
				num = num2;
				goto IL_02aa;
				IL_02aa:
				switch (num)
				{
				default:
					if (c != 'H' || !(format == "HEX_ARGB"))
					{
						goto end_IL_0012;
					}
					return color.ToArgbHexString();
				case 2:
					break;
				case 4:
					goto IL_0390;
				case 1:
				case 3:
					goto end_IL_0012;
				}
				goto IL_02e5;
				IL_0390:
				switch (c)
				{
				case 'r':
					if (format == "rgb")
					{
						return $"rgb({color.R}, {color.G}, {color.B})";
					}
					break;
				case 'H':
					if (format == "HSL")
					{
						(double, double, double) hSL2 = color.GetHSL();
						return $"hsl({hSL2.Item1}, {hSL2.Item2:P}, {hSL2.Item3:P})";
					}
					break;
				}
				break;
				end_IL_0012:
				break;
			}
		}
		return "Error：不支持的格式 " + format;
	}

	static ComputeColorStep()
	{
		uJsgCwZ8suy = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "比较方式",
			DefaultValue = "fromString",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("fromString", "通过文本指定颜色"),
				new SelectionItem("selectFromScreen", "从屏幕选取颜色"),
				new SelectionItem("fromScreenPosition", "取屏幕指定位置颜色"),
				new SelectionItem("editOrSelectColor", "编辑/选择颜色")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		HTEgCtVPqHn = new StepInParamDef
		{
			Key = "colorStr",
			Name = "颜色",
			Description = "颜色的文本值, 格式支持：#223344, #FF223344(ARGB顺序), Red, rgb(200,200,200), rgba(200,200,200,0.5), CMYK(0,0,0,0)或CMYK:0,0,0,0",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "fromString", "editOrSelectColor" },
			TextTools = new List<TextToolType> { TextToolType.SelectColor },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		t2pgCgdEMsd = new StepInParamDef
		{
			Key = "format",
			Name = "输出文本格式",
			Description = "输出的颜色文本值格式，用以转换颜色值的格式",
			DefaultValue = "HEX_RGB",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("HEX_RGB", "十六进制RGB: #6496C8"),
				new SelectionItem("HEX_ARGB", "十六进制ARGB: #FF6496C8"),
				new SelectionItem("rgba", "HTML: rgba(100,150,200,1)"),
				new SelectionItem("rgb", "HTML: rgb(100,150,200)"),
				new SelectionItem("DOT_RGB", "RGB: 100,150,200"),
				new SelectionItem("DOT_RGBA", "RGBA: 100,150,200,255"),
				new SelectionItem("DOT_ARGB", "ARGB: 255,100,150,200"),
				new SelectionItem("float_rgba", "浮点: 0.39f, 0.59f, 0.78f, 1.00f"),
				new SelectionItem("Swift", "Swift: UIColor(red:0.39, green:0.59, blue:0.78, alpha:1.00)"),
				new SelectionItem("CMYK", "CMYK: 50,25,0,22"),
				new SelectionItem("HSL", "hsl(210,47.6%,58.8%)"),
				new SelectionItem("hsla", "hsla(210,47.6%,58.8%,1)"),
				new SelectionItem("HSV_HSB", "HSV/HSB: 210°,50,78.4")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsControlField = false
		};
		yfhgCLeghLv = new StepInParamDef
		{
			Key = "location",
			Name = "坐标",
			Description = "格式为:“横坐标X,纵坐标Y”",
			Type = VarType.Text,
			DefaultValue = "0,0",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "fromScreenPosition" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationPoint }
		};
		BnZgCvVW8wp = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		OAmgC2MohmQ = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		hmLgCuIGpmh = new StepOutParamDef
		{
			Key = "A",
			Name = "透明度值",
			Type = VarType.Number,
			Description = "Alpha值（0-255）0表示透明"
		};
		rehgCNFk16R = new StepOutParamDef
		{
			Key = "R",
			Name = "红色值",
			Type = VarType.Number,
			Description = "R值（0-255）"
		};
		RgQgCJ3XB4W = new StepOutParamDef
		{
			Key = "G",
			Name = "绿色值",
			Type = VarType.Number,
			Description = "G值（0-255）"
		};
		EcggC0LCk7c = new StepOutParamDef
		{
			Key = "B",
			Name = "蓝色值",
			Type = VarType.Number,
			Description = "B值（0-255）"
		};
		tB4gCCHgK5C = new StepOutParamDef
		{
			Key = "Hue",
			Name = "色相",
			Type = VarType.Number,
			Description = "Hue值（0-360）"
		};
		jWVgCP8cc1A = new StepOutParamDef
		{
			Key = "HslS",
			Name = "HSL.S",
			Type = VarType.Number,
			Description = "HSL颜色空间的饱和度S"
		};
		sYZgCEtJ29K = new StepOutParamDef
		{
			Key = "HslL",
			Name = "HSL.L",
			Type = VarType.Number,
			Description = "HSL颜色空间的亮度值L"
		};
		QnpgCy0w9In = new StepOutParamDef
		{
			Key = "HsvS",
			Name = "HSV.S",
			Type = VarType.Number,
			Description = "HSV颜色空间的饱和度S"
		};
		uF9gC8chs9J = new StepOutParamDef
		{
			Key = "HsvV",
			Name = "HSV.V",
			Type = VarType.Number,
			Description = "HSV颜色空间的明度V"
		};
		UTsgCavqCN3 = new StepOutParamDef
		{
			Key = "textValue",
			Name = "文本值",
			Type = VarType.Text,
			Description = "输出颜色的文本值，格式请在输入参数中选择"
		};
	}

	internal static bool maZbLsQUO8ay4XwJtF0h()
	{
		return khhH1EQUdQDE8FtanMlO == null;
	}
}
