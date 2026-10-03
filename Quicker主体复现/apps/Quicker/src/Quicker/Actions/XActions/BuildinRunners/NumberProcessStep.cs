using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace Quicker.Actions.XActions.BuildinRunners;

public class NumberProcessStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec kr7ShoAmnQy;

		public static Func<char, bool> YEjShTcxXDo;

		public static Func<char, bool> Du6ShMjJ8et;

		private static _003C_003Ec yBvfS5WL1vIMLHXU4koc;

		static _003C_003Ec()
		{
			kr7ShoAmnQy = new _003C_003Ec();
		}

		internal bool qBVShDF3lAY(char ch)
		{
			return ch >= 'A';
		}

		internal bool sKWShdHiOCR(char ch)
		{
			if (ch != '0')
			{
				return ch == '1';
			}
			return true;
		}

		internal static bool D3jWcRWLKHAcH9Ui1KbI()
		{
			return yBvfS5WL1vIMLHXU4koc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_0
	{
		public ActionStep nUXShOOnXMp;

		public ActionExecuteContext RMLShFQWuRb;

		public XAction RJ3ShUdTfAF;

		private static _003C_003Ec__DisplayClass58_0 alAPCyWLvd6ITxEe0W4y;

		internal (bool isSuccess, string message, ActionStopFlag failReason) tN3ShAgIxdr()
		{
			string textParamValue = XActionHelper.GetTextParamValue(KYMgYO3QUGD, nUXShOOnXMp, RMLShFQWuRb);
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			case "baseConversion":
			{
				string text = XActionHelper.GetTextParamValue(IJpgYFwlPs2, nUXShOOnXMp, RMLShFQWuRb).Trim();
				string text2 = text.Replace(" ", "").Replace(",", "").ToUpper();
				int num2 = (int)XActionHelper.GetIntegerParamValue(x1rgYUUXIDm, nUXShOOnXMp, RMLShFQWuRb);
				long num3 = 0L;
				num3 = ((num2 != 0) ? Convert.ToInt64(text2, num2) : (text.ContainsAny(",", "，") ? long.Parse(text2) : ((text2.StartsWith("0x", StringComparison.OrdinalIgnoreCase) || text2.Any(_003C_003Ec.YEjShTcxXDo ?? (_003C_003Ec.YEjShTcxXDo = _003C_003Ec.kr7ShoAmnQy.qBVShDF3lAY))) ? long.Parse(text2.Substring(2), NumberStyles.HexNumber) : ((!text2.All(_003C_003Ec.Du6ShMjJ8et ?? (_003C_003Ec.Du6ShMjJ8et = _003C_003Ec.kr7ShoAmnQy.sKWShdHiOCR))) ? long.Parse(text2) : Convert.ToInt64(text2, 2)))));
				XActionHelper.OutputResult(fiHgISUijQn, nUXShOOnXMp, RMLShFQWuRb, num3, RJ3ShUdTfAF);
				XActionHelper.OutputResult(RjjgI2gOUZP, nUXShOOnXMp, RMLShFQWuRb, num3.ToString("X"), RJ3ShUdTfAF);
				XActionHelper.OutputResult(a6UgIuCcQxW, nUXShOOnXMp, RMLShFQWuRb, Convert.ToString(num3, 8), RJ3ShUdTfAF);
				XActionHelper.OutputResult(HTrgINbw27T, nUXShOOnXMp, RMLShFQWuRb, Convert.ToString(num3, 2), RJ3ShUdTfAF);
				break;
			}
			case "toInteger":
			{
				double numberParamValue = XActionHelper.GetNumberParamValue(jHwgYlZks8b, nUXShOOnXMp, RMLShFQWuRb);
				string textParamValue2 = XActionHelper.GetTextParamValue(jtIgYfON0lt, nUXShOOnXMp, RMLShFQWuRb);
				long num4 = 0L;
				switch (textParamValue2)
				{
				case "Floor":
					num4 = (long)Math.Floor(numberParamValue);
					break;
				case "Ceiling":
					num4 = (long)Math.Ceiling(numberParamValue);
					break;
				case "Round":
					num4 = (long)Math.Round(numberParamValue, MidpointRounding.ToEven);
					break;
				case "Round45":
					num4 = (long)Math.Round(numberParamValue, MidpointRounding.AwayFromZero);
					break;
				}
				XActionHelper.OutputResult(fiHgISUijQn, nUXShOOnXMp, RMLShFQWuRb, num4, RJ3ShUdTfAF);
				break;
			}
			case "toString":
			{
				_003C_003Ec__DisplayClass58_1 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_1();
				_003C_003Ec__DisplayClass58_.fKaSet67l6K = XActionHelper.GetNumberParamValue(jHwgYlZks8b, nUXShOOnXMp, RMLShFQWuRb);
				_003C_003Ec__DisplayClass58_.b7RShzb2XpZ = (int)XActionHelper.GetIntegerParamValue(qvKgYine2Na, nUXShOOnXMp, RMLShFQWuRb);
				_003C_003Ec__DisplayClass58_.mXBSewnf1N6 = XActionHelper.GetTextParamValue(kNqgY33ijZB, nUXShOOnXMp, RMLShFQWuRb);
				_003C_003Ec__DisplayClass58_.ecbShfckrVe = _003C_003Ec__DisplayClass58_.fKaSet67l6K;
				switch (_003C_003Ec__DisplayClass58_.mXBSewnf1N6)
				{
				default:
					_003C_003Ec__DisplayClass58_.ecbShfckrVe = _003C_003Ec__DisplayClass58_.fKaSet67l6K;
					break;
				case "Round":
					_003C_003Ec__DisplayClass58_.ecbShfckrVe = Math.Round(_003C_003Ec__DisplayClass58_.fKaSet67l6K, _003C_003Ec__DisplayClass58_.b7RShzb2XpZ, MidpointRounding.ToEven);
					break;
				case "Truncate":
				{
					double num = Math.Pow(10.0, _003C_003Ec__DisplayClass58_.b7RShzb2XpZ);
					_003C_003Ec__DisplayClass58_.ecbShfckrVe = Math.Truncate(_003C_003Ec__DisplayClass58_.fKaSet67l6K * num) / num;
					break;
				}
				case "Round45":
					_003C_003Ec__DisplayClass58_.ecbShfckrVe = Math.Round(_003C_003Ec__DisplayClass58_.fKaSet67l6K, _003C_003Ec__DisplayClass58_.b7RShzb2XpZ, MidpointRounding.AwayFromZero);
					break;
				}
				XActionHelper.OutputResultIfNeeded(Po6gIgshgQi, _003C_003Ec__DisplayClass58_.wqBShl6t30J, nUXShOOnXMp, RMLShFQWuRb, RJ3ShUdTfAF);
				XActionHelper.OutputResultIfNeeded(FhvgILh6oik, _003C_003Ec__DisplayClass58_.T2MShidufk3, nUXShOOnXMp, RMLShFQWuRb, RJ3ShUdTfAF);
				XActionHelper.OutputResultIfNeeded(yJqgIvUo6XU, _003C_003Ec__DisplayClass58_.zFmSh37McFi, nUXShOOnXMp, RMLShFQWuRb, RJ3ShUdTfAF);
				break;
			}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void XmZ2TRWLJw8K1UgTLWDg()
		{
		}

		internal static bool G7OP69WLdIAwS2w1xkKx()
		{
			return alAPCyWLvd6ITxEe0W4y == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_1
	{
		public double ecbShfckrVe;

		public int b7RShzb2XpZ;

		public string mXBSewnf1N6;

		public double fKaSet67l6K;

		internal static _003C_003Ec__DisplayClass58_1 FBCcMbWLkQy1yAZprMHv;

		internal object wqBShl6t30J()
		{
			return ecbShfckrVe.ToString($"F{b7RShzb2XpZ}");
		}

		internal object T2MShidufk3()
		{
			return ecbShfckrVe.ToString($"N{b7RShzb2XpZ}");
		}

		internal object zFmSh37McFi()
		{
			switch (mXBSewnf1N6)
			{
			default:
				ecbShfckrVe = fKaSet67l6K;
				break;
			case "Round":
				ecbShfckrVe = Math.Round(fKaSet67l6K, b7RShzb2XpZ + 2, MidpointRounding.ToEven);
				break;
			case "Truncate":
			{
				double num = Math.Pow(10.0, b7RShzb2XpZ + 2);
				ecbShfckrVe = Math.Truncate(fKaSet67l6K * num) / num;
				break;
			}
			case "Round45":
				ecbShfckrVe = Math.Round(fKaSet67l6K, b7RShzb2XpZ + 2, MidpointRounding.AwayFromZero);
				if (!qjIWa6WLaEcIdJ9PirHh())
				{
					switch (0)
					{
					}
				}
				break;
			}
			return ecbShfckrVe.ToString($"P{b7RShzb2XpZ}");
		}

		internal static bool qjIWa6WLaEcIdJ9PirHh()
		{
			return FBCcMbWLkQy1yAZprMHv == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> wGEgYoy97oP = new string[1] { "小数" };

	[CompilerGenerated]
	private readonly string rdmgYTjAPpG = "Steps/common_step.png";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Cm0gYM5EHDR;

	[CompilerGenerated]
	private readonly string mfEgYAcW2ba = "https://getquicker.net/KC/Help/Doc/numberprocess";

	private static readonly StepInParamDef KYMgYO3QUGD;

	private static readonly StepInParamDef IJpgYFwlPs2;

	private static readonly StepInParamDef x1rgYUUXIDm;

	private static readonly StepInParamDef jHwgYlZks8b;

	private static readonly StepInParamDef qvKgYine2Na;

	private static readonly StepInParamDef kNqgY33ijZB;

	private static readonly StepInParamDef jtIgYfON0lt;

	private static readonly StepInParamDef AEygYzX8Xke;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> xujgIw7TUFg = new List<StepInParamDef> { KYMgYO3QUGD, jHwgYlZks8b, qvKgYine2Na, kNqgY33ijZB, jtIgYfON0lt, IJpgYFwlPs2, x1rgYUUXIDm, AEygYzX8Xke };

	private static readonly StepOutParamDef l3RgItQjjKE;

	private static readonly StepOutParamDef Po6gIgshgQi;

	private static readonly StepOutParamDef FhvgILh6oik;

	private static readonly StepOutParamDef yJqgIvUo6XU;

	private static readonly StepOutParamDef fiHgISUijQn;

	private static readonly StepOutParamDef RjjgI2gOUZP;

	private static readonly StepOutParamDef a6UgIuCcQxW;

	private static readonly StepOutParamDef HTrgINbw27T;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> AMtgIJfG2Bg = new List<StepOutParamDef> { l3RgItQjjKE, Po6gIgshgQi, FhvgILh6oik, yJqgIvUo6XU, fiHgISUijQn, RjjgI2gOUZP, a6UgIuCcQxW, HTrgINbw27T };

	private static NumberProcessStep BXSBVjQTf1k8lLcLgn1u;

	public string Key => "sys:numberprocess";

	public string Name => "数字转换与处理";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return wGEgYoy97oP;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return rdmgYTjAPpG;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Cm0gYM5EHDR;
		}
	}

	public string Description => "数字转换为文本等相关处理";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return mfEgYAcW2ba;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return xujgIw7TUFg;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return AMtgIJfG2Bg;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
		_003C_003Ec__DisplayClass58_.nUXShOOnXMp = step;
		_003C_003Ec__DisplayClass58_.RMLShFQWuRb = context;
		_003C_003Ec__DisplayClass58_.RJ3ShUdTfAF = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass58_.RMLShFQWuRb, _003C_003Ec__DisplayClass58_.nUXShOOnXMp, _003C_003Ec__DisplayClass58_.RJ3ShUdTfAF, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass58_.tN3ShAgIxdr, (Action)null, (Action)null, AEygYzX8Xke, l3RgItQjjKE);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(jHwgYlZks8b, step) ?? "";
	}

	static NumberProcessStep()
	{
		KYMgYO3QUGD = new StepInParamDef
		{
			Key = "operation",
			Name = "操作",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "toString",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("toString", "数字转换为文本"),
				new SelectionItem("toInteger", "取整"),
				new SelectionItem("baseConversion", "进制转换")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		IJpgYFwlPs2 = new StepInParamDef
		{
			Key = "srcNumberStr",
			Name = "原始数字(文本)",
			DefaultValue = 0,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "baseConversion" }
		};
		x1rgYUUXIDm = new StepInParamDef
		{
			Key = "srcBase",
			Name = "原始数字进制",
			DefaultValue = 0,
			Description = "可选0/2/8/16。0为自动判断：全由0、1构成判断为二进制，0x开始或包含A-D判断为16进制，其它判断为10进制。",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "baseConversion" }
		};
		jHwgYlZks8b = new StepInParamDef
		{
			Key = "srcNumber",
			Name = "原始数字",
			DefaultValue = 0,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "toString", "toInteger" }
		};
		qvKgYine2Na = new StepInParamDef
		{
			Key = "decimalPlace",
			Name = "保留小数位",
			DefaultValue = 2,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "toString" }
		};
		kNqgY33ijZB = new StepInParamDef
		{
			Key = "roundingMethod",
			Name = "舍入方式",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "Round45",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Round", "舍入：奇进偶舍"),
				new SelectionItem("Round45", "舍入：四舍五入"),
				new SelectionItem("Truncate", "截断")
			},
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "toString" }
		};
		jtIgYfON0lt = new StepInParamDef
		{
			Key = "toIntegerMethod",
			Name = "取整方式",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "Round45",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Round", "舍入：奇进偶舍"),
				new SelectionItem("Round45", "舍入：四舍五入"),
				new SelectionItem("Ceiling", "向上取整"),
				new SelectionItem("Floor", "向下取整")
			},
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "toInteger" }
		};
		AEygYzX8Xke = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		l3RgItQjjKE = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		Po6gIgshgQi = new StepOutParamDef
		{
			Key = "rtnF",
			Name = "结果文本(不含逗号)",
			Description = "如1234.56",
			Type = VarType.Text,
			ValidForList = new List<string> { "toString" }
		};
		FhvgILh6oik = new StepOutParamDef
		{
			Key = "rtnN",
			Name = "结果文本(含逗号)",
			Description = "如1,234.56",
			Type = VarType.Text,
			ValidForList = new List<string> { "toString" }
		};
		yJqgIvUo6XU = new StepOutParamDef
		{
			Key = "rtnPercent",
			Name = "结果文本(百分比)",
			Description = "如23.56%",
			Type = VarType.Text,
			ValidForList = new List<string> { "toString" }
		};
		fiHgISUijQn = new StepOutParamDef
		{
			Key = "rtnInteger",
			Name = "结果整数",
			Description = "十进制数",
			Type = VarType.Integer,
			ValidForList = new List<string> { "toInteger", "baseConversion" }
		};
		RjjgI2gOUZP = new StepOutParamDef
		{
			Key = "resultHex",
			Name = "十六进制",
			Type = VarType.Text,
			ValidForList = new List<string> { "baseConversion" }
		};
		a6UgIuCcQxW = new StepOutParamDef
		{
			Key = "resultOctal",
			Name = "八进制",
			Type = VarType.Text,
			ValidForList = new List<string> { "baseConversion" }
		};
		HTrgINbw27T = new StepOutParamDef
		{
			Key = "resultBin",
			Name = "二进制",
			Type = VarType.Text,
			ValidForList = new List<string> { "baseConversion" }
		};
	}

	internal static bool TBi9nhQTbJ2XeiHZxBqs()
	{
		return BXSBVjQTf1k8lLcLgn1u == null;
	}
}
