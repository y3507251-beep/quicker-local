using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class StringReplaceStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0
	{
		public ActionStep gONSN6CSJqZ;

		public ActionExecuteContext pgbSNX1cgnV;

		public XAction x7vSNmq5X4F;

		internal static _003C_003Ec__DisplayClass49_0 CCjD7MWvFVktkJmw9X7F;

		internal (bool isSuccess, string message, ActionStopFlag failReason) okHSNbsi7pL()
		{
			string textParamValue = XActionHelper.GetTextParamValue(xCegNvJ71Eo, gONSN6CSJqZ, pgbSNX1cgnV);
			string textParamValue2 = XActionHelper.GetTextParamValue(XFUgNSebkxq, gONSN6CSJqZ, pgbSNX1cgnV);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(Xw2gNJWG1cG, gONSN6CSJqZ, pgbSNX1cgnV);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(YeKgN0gVrRN, gONSN6CSJqZ, pgbSNX1cgnV);
			bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(s8GgNCoZk84, gONSN6CSJqZ, pgbSNX1cgnV);
			bool booleanParamValue4 = XActionHelper.GetBooleanParamValue(uNWgNPinJKG, gONSN6CSJqZ, pgbSNX1cgnV);
			bool booleanParamValue5 = XActionHelper.GetBooleanParamValue(cuSgNE4U0nV, gONSN6CSJqZ, pgbSNX1cgnV);
			bool booleanParamValue6 = XActionHelper.GetBooleanParamValue(o0ogNy53aUC, gONSN6CSJqZ, pgbSNX1cgnV);
			if (string.IsNullOrEmpty(textParamValue2))
			{
				pgbSNX1cgnV.ActionLogger.LogInfo("输入内容为空");
				XActionHelper.OutputResult(N0Agu3glp1m(), gONSN6CSJqZ, pgbSNX1cgnV, string.Empty, x7vSNmq5X4F);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			if (!string.IsNullOrEmpty(textParamValue) && !(textParamValue == "single"))
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(tePgNNhd2R8, gONSN6CSJqZ, pgbSNX1cgnV);
				if (string.IsNullOrEmpty(textParamValue3))
				{
					return (isSuccess: false, message: "查找和替换数据为空", failReason: ActionStopFlag.OperationFailed);
				}
				string[] array = textParamValue3.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
				string text = textParamValue2;
				string text2 = "|";
				for (int i = 0; i < array.Length; i++)
				{
					string text3 = array[i];
					if (i == 0 && text3.StartsWith("|="))
					{
						text2 = text3.Substring(2);
						if (string.IsNullOrEmpty(text2))
						{
							return (isSuccess: false, message: "未正确指定分隔符", failReason: ActionStopFlag.OperationFailed);
						}
						continue;
					}
					string text4 = text2;
					if (text2 == "|" && text3.Contains("|||"))
					{
						text4 = "|||";
					}
					string[] array2 = text3.Split(new string[1] { text4 }, StringSplitOptions.None);
					if (array2.Length == 2)
					{
						text = iWiguifD2G8(booleanParamValue2, array2[1], booleanParamValue, array2[0], booleanParamValue3, text, booleanParamValue4, booleanParamValue5, booleanParamValue6);
						continue;
					}
					return (isSuccess: false, message: "查找和替换数据格式不正确。需要每行有且只有一个|作为分隔符。\r\n错误行：" + text3, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResult(N0Agu3glp1m(), gONSN6CSJqZ, pgbSNX1cgnV, text, x7vSNmq5X4F);
			}
			else
			{
				string textParamValue4 = XActionHelper.GetTextParamValue(EIIgN2eaUMx, gONSN6CSJqZ, pgbSNX1cgnV);
				string textParamValue5 = XActionHelper.GetTextParamValue(DMmgNuILWgB, gONSN6CSJqZ, pgbSNX1cgnV);
				string result = iWiguifD2G8(booleanParamValue2, textParamValue5, booleanParamValue, textParamValue4, booleanParamValue3, textParamValue2, booleanParamValue4, booleanParamValue5, booleanParamValue6);
				XActionHelper.OutputResult(N0Agu3glp1m(), gONSN6CSJqZ, pgbSNX1cgnV, result, x7vSNmq5X4F);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool XJ8u3jWvcj1rkOd2Q4bq()
		{
			return CCjD7MWvFVktkJmw9X7F == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> z6Fguz7Ye38 = new string[2] { "替换文本", "replace" };

	[CompilerGenerated]
	private readonly string ppRgNwXfDbH = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> moigNtR9fpl;

	[CompilerGenerated]
	private readonly string oisgNgT2MVa = "https://getquicker.net/KC/Help/Doc/strReplace";

	[CompilerGenerated]
	private readonly bool BwvgNLZ5PqS;

	private static readonly StepInParamDef xCegNvJ71Eo;

	private static readonly StepInParamDef XFUgNSebkxq;

	private static readonly StepInParamDef EIIgN2eaUMx;

	private static readonly StepInParamDef DMmgNuILWgB;

	private static readonly StepInParamDef tePgNNhd2R8;

	private static readonly StepInParamDef Xw2gNJWG1cG;

	private static readonly StepInParamDef YeKgN0gVrRN;

	private static readonly StepInParamDef s8GgNCoZk84;

	private static readonly StepInParamDef uNWgNPinJKG;

	private static readonly StepInParamDef cuSgNE4U0nV;

	private static readonly StepInParamDef o0ogNy53aUC;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> lt1gN8BBfGq = new StepInParamDef[11]
	{
		xCegNvJ71Eo, XFUgNSebkxq, tePgNNhd2R8, EIIgN2eaUMx, DMmgNuILWgB, Xw2gNJWG1cG, YeKgN0gVrRN, s8GgNCoZk84, uNWgNPinJKG, cuSgNE4U0nV,
		o0ogNy53aUC
	};

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> qsBgNalUigR = new StepOutParamDef[1] { N0Agu3glp1m() };

	internal static StringReplaceStep dUx4c5QPUaxZWMfOf8tP;

	public string Key => "sys:strReplace";

	public string Name => "替换文本";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return z6Fguz7Ye38;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ppRgNwXfDbH;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return moigNtR9fpl;
		}
	}

	public string Description => "替换文本中的指定内容";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return oisgNgT2MVa;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return BwvgNLZ5PqS;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return lt1gN8BBfGq;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return qsBgNalUigR;
		}
	}

	[SpecialName]
	private static StepOutParamDef N0Agu3glp1m()
	{
		return new StepOutParamDef
		{
			Key = "output",
			Name = "结果",
			Description = "替换后的文本",
			Type = VarType.Text
		};
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
		_003C_003Ec__DisplayClass49_.gONSN6CSJqZ = step;
		_003C_003Ec__DisplayClass49_.pgbSNX1cgnV = context;
		_003C_003Ec__DisplayClass49_.x7vSNmq5X4F = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass49_.pgbSNX1cgnV, _003C_003Ec__DisplayClass49_.gONSN6CSJqZ, _003C_003Ec__DisplayClass49_.x7vSNmq5X4F, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass49_.okHSNbsi7pL, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	private static string iWiguifD2G8(bool bool_1, string string_2, bool bool_2, string string_3, bool bool_3, string string_4, bool bool_4, bool bool_5, bool bool_6)
	{
		int num = 1;
		RegexOptions regexOptions = default(RegexOptions);
		while (true)
		{
			int num2;
			if (bool_1)
			{
				num2 = 0;
				if (dUx4c5QPUaxZWMfOf8tP == null)
				{
					goto IL_0038;
				}
				goto IL_0049;
			}
			goto IL_005d;
			IL_0049:
			string_2 = AppHelper.UnescapeString(string_2);
			goto IL_005d;
			IL_005d:
			if (bool_2)
			{
				string_3 = AppHelper.UnescapeString(string_3);
			}
			if (bool_3)
			{
				regexOptions = RegexOptions.None;
				if (bool_4)
				{
					regexOptions |= RegexOptions.IgnoreCase;
				}
				if (!bool_5)
				{
					break;
				}
				regexOptions |= RegexOptions.Singleline;
				num2 = 2;
				if (!EQYZ0oQPxbID8dAhWnNB())
				{
					num2 = num;
				}
				goto IL_0038;
			}
			if (bool_4)
			{
				return ReplaceEx(string_4, string_3, string_2, StringComparison.OrdinalIgnoreCase);
			}
			return string_4.Replace(string_3, string_2);
			IL_0038:
			switch (num2)
			{
			case 1:
				continue;
			case 2:
				goto end_IL_0071;
			}
			goto IL_0049;
			continue;
			end_IL_0071:
			break;
		}
		if (bool_6)
		{
			regexOptions |= RegexOptions.Multiline;
		}
		return Regex.Replace(string_4, string_3, string_2, regexOptions, TimeSpan.FromSeconds(2.0));
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(xCegNvJ71Eo, step) + " => " + XActionHelper.GetOutputParamDisplayString(N0Agu3glp1m(), step);
	}

	public static string ReplaceEx(string str, string oldValue, string newValue, StringComparison comparisonType)
	{
        int num2 = default;
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (str.Length == 0)
		{
			return str;
		}
		if (oldValue == null)
		{
			throw new ArgumentNullException("oldValue");
		}
		if (oldValue.Length == 0)
		{
			throw new ArgumentException("String cannot be of zero length.");
		}
		StringBuilder stringBuilder = new StringBuilder(str.Length);
		bool flag = string.IsNullOrEmpty(newValue);
		int num = 1;
		if (dUx4c5QPUaxZWMfOf8tP == null)
		{
			goto IL_005a;
		}
		goto IL_00b4;
		IL_005c:
		num2 = default(int);
		int num3;
		if ((num2 = str.IndexOf(oldValue, num3, comparisonType)) != -1)
		{
			int num4 = num2 - num3;
			if (num4 != 0)
			{
				stringBuilder.Append(str, num3, num4);
				num = 0;
				if (EQYZ0oQPxbID8dAhWnNB())
				{
					goto IL_00b4;
				}
			}
			goto IL_00ae;
		}
		int count = str.Length - num3;
		stringBuilder.Append(str, num3, count);
		return stringBuilder.ToString();
		IL_005a:
		num3 = 0;
		goto IL_005c;
		IL_00ae:
		if (!flag)
		{
			stringBuilder.Append(newValue);
		}
		num3 = num2 + oldValue.Length;
		if (num3 == str.Length)
		{
			return stringBuilder.ToString();
		}
		goto IL_005c;
		IL_00b4:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00ae;
		}
		goto IL_005a;
	}

	static StringReplaceStep()
	{
		xCegNvJ71Eo = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			DefaultValue = "single",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("single", "普通（替换一种内容）"),
				new SelectionItem("batch", "批量（替换多种内容）")
			},
			IsControlField = true
		};
		XFUgNSebkxq = new StepInParamDef
		{
			Key = "input",
			Name = "输入",
			Description = "要提取内容的文本",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		EIIgN2eaUMx = new StepInParamDef
		{
			Key = "old",
			Name = "查找内容",
			Description = "要替换的内容",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "single" }
		};
		DMmgNuILWgB = new StepInParamDef
		{
			Key = "new",
			Name = "替换为",
			Description = "替换成的内容",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "single" }
		};
		tePgNNhd2R8 = new StepInParamDef
		{
			Key = "batchReplaceData",
			Name = "查找和替换内容",
			Description = "每行一对查找和替换内容，中间使用|||或|分隔。例如将a替换成A，写作:a|A 或 a|||A",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "batch" }
		};
		Xw2gNJWG1cG = new StepInParamDef
		{
			Key = "escapeOld",
			Name = "转义“查找内容”",
			Description = "替换“查找内容”中的转义字符（\\r,\\n,\\t）",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		YeKgN0gVrRN = new StepInParamDef
		{
			Key = "replaceEscapes",
			Name = "转义“替换为”",
			Description = "替换“替换为”中的转义字符（\\r,\\n,\\t）",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		s8GgNCoZk84 = new StepInParamDef
		{
			Key = "useRegex",
			Name = "使用正则替换",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		uNWgNPinJKG = new StepInParamDef
		{
			Key = "ignoreCase",
			Name = "忽略大小写",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		cuSgNE4U0nV = new StepInParamDef
		{
			Key = "singleLine",
			Name = "正则：单行",
			Description = "此模式下“.”能匹配任意字符，包括换行符。(否则匹配除了\\n外的任意字符)",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		o0ogNy53aUC = new StepInParamDef
		{
			Key = "multiLine",
			Name = "正则：多行",
			Description = "此模式下^和$可以分别匹配行首和行尾。(否则匹配输入内容的开始和结束)",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
	}

	internal static bool EQYZ0oQPxbID8dAhWnNB()
	{
		return dUx4c5QPUaxZWMfOf8tP == null;
	}
}
