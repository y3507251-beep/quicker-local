using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class RegexExtractStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_0
	{
		public ActionStep CnYSNssvR8G;

		public ActionExecuteContext A9USNHf6vgS;

		public XAction OTMSN1QNLwl;

		private static _003C_003Ec__DisplayClass57_0 cLkhboWBzfPyih2D6hVU;

		internal (bool isSuccess, string message, ActionStopFlag failReason) WQCSNGqhwb1()
		{
			string textParamValue = XActionHelper.GetTextParamValue(FH2gunZNpu2, CnYSNssvR8G, A9USNHf6vgS);
			string textParamValue2 = XActionHelper.GetTextParamValue(meNgu4MjDWL, CnYSNssvR8G, A9USNHf6vgS);
			string textParamValue3 = XActionHelper.GetTextParamValue(mchgu59udP4, CnYSNssvR8G, A9USNHf6vgS);
			RegexOptions regexOptions = RegexOptions.None;
			if (XActionHelper.GetBooleanParamValue(O4HguDq2YTQ, CnYSNssvR8G, A9USNHf6vgS))
			{
				regexOptions |= RegexOptions.IgnoreCase;
			}
			if (XActionHelper.GetBooleanParamValue(u31gudQbFJ6, CnYSNssvR8G, A9USNHf6vgS))
			{
				regexOptions |= RegexOptions.Singleline;
			}
			if (XActionHelper.GetBooleanParamValue(Te5guotfdoS, CnYSNssvR8G, A9USNHf6vgS))
			{
				regexOptions |= RegexOptions.Multiline;
			}
			if (XActionHelper.GetBooleanParamValue(GUHguT1H4E8, CnYSNssvR8G, A9USNHf6vgS))
			{
				regexOptions |= RegexOptions.RightToLeft;
			}
			string item = "正则匹配不成功。";
			if (!(textParamValue == "0") && !textParamValue.Equals("false", StringComparison.OrdinalIgnoreCase))
			{
				if (!(textParamValue == "1") && !textParamValue.Equals("true", StringComparison.OrdinalIgnoreCase))
				{
					if (textParamValue == "2")
					{
						MatchCollection matchCollection = Regex.Matches(textParamValue2, textParamValue3, regexOptions, TimeSpan.FromSeconds(3.0));
						bool flag = matchCollection.Count > 0;
						XActionHelper.OutputResult(fiwguU3gprW, CnYSNssvR8G, A9USNHf6vgS, flag, OTMSN1QNLwl);
						if (flag)
						{
							List<string> list = new List<string>();
							foreach (Match item2 in matchCollection)
							{
								list.Add(item2.Value);
							}
							XActionHelper.OutputResult(jiJguWdQH09(), CnYSNssvR8G, A9USNHf6vgS, list, OTMSN1QNLwl);
							XActionHelper.OutputResult(TGSguGtKB3P(), CnYSNssvR8G, A9USNHf6vgS, CM0guIFTSjX(matchCollection, 1), OTMSN1QNLwl);
							XActionHelper.OutputResult(BChguH21xHw(), CnYSNssvR8G, A9USNHf6vgS, CM0guIFTSjX(matchCollection, 2), OTMSN1QNLwl);
							XActionHelper.OutputResult(Jc7gubQphLR(), CnYSNssvR8G, A9USNHf6vgS, CM0guIFTSjX(matchCollection, 3), OTMSN1QNLwl);
							XActionHelper.OutputResult(VyfguXd9pKY(), CnYSNssvR8G, A9USNHf6vgS, CM0guIFTSjX(matchCollection, 4), OTMSN1QNLwl);
							XActionHelper.OutputResult(yeAguKToUpt(), CnYSNssvR8G, A9USNHf6vgS, CM0guIFTSjX(matchCollection, 5), OTMSN1QNLwl);
							XActionHelper.OutputResult(gSKguFJwx95, CnYSNssvR8G, A9USNHf6vgS, matchCollection, OTMSN1QNLwl);
							return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
						}
						return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
					}
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				Match match2 = Regex.Match(textParamValue2, textParamValue3, regexOptions, TimeSpan.FromSeconds(1.0));
				XActionHelper.OutputResult(fiwguU3gprW, CnYSNssvR8G, A9USNHf6vgS, match2.Success, OTMSN1QNLwl);
				if (match2.Success)
				{
					List<string> list2 = new List<string>();
					for (int i = 1; i < match2.Groups.Count; i++)
					{
						list2.Add(match2.Groups[i].Value);
					}
					XActionHelper.OutputResult(jiJguWdQH09(), CnYSNssvR8G, A9USNHf6vgS, list2, OTMSN1QNLwl);
					XActionHelper.OutputResult(TGSguGtKB3P(), CnYSNssvR8G, A9USNHf6vgS, (match2.Groups.Count > 1) ? match2.Groups[1].Value : "", OTMSN1QNLwl);
					XActionHelper.OutputResult(BChguH21xHw(), CnYSNssvR8G, A9USNHf6vgS, (match2.Groups.Count > 2) ? match2.Groups[2].Value : "", OTMSN1QNLwl);
					XActionHelper.OutputResult(Jc7gubQphLR(), CnYSNssvR8G, A9USNHf6vgS, (match2.Groups.Count > 3) ? match2.Groups[3].Value : "", OTMSN1QNLwl);
					XActionHelper.OutputResult(VyfguXd9pKY(), CnYSNssvR8G, A9USNHf6vgS, (match2.Groups.Count > 4) ? match2.Groups[4].Value : "", OTMSN1QNLwl);
					XActionHelper.OutputResult(yeAguKToUpt(), CnYSNssvR8G, A9USNHf6vgS, (match2.Groups.Count > 5) ? match2.Groups[5].Value : "", OTMSN1QNLwl);
					XActionHelper.OutputResult(JnoguOOVBIj, CnYSNssvR8G, A9USNHf6vgS, match2, OTMSN1QNLwl);
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
			}
			MatchCollection matchCollection2 = Regex.Matches(textParamValue2, textParamValue3, regexOptions, TimeSpan.FromSeconds(3.0));
			bool flag2 = matchCollection2.Count > 0;
			XActionHelper.OutputResult(fiwguU3gprW, CnYSNssvR8G, A9USNHf6vgS, flag2, OTMSN1QNLwl);
			if (flag2)
			{
				List<string> list3 = new List<string>();
				foreach (Match item3 in matchCollection2)
				{
					list3.Add(item3.Value);
				}
				XActionHelper.OutputResult(jiJguWdQH09(), CnYSNssvR8G, A9USNHf6vgS, list3, OTMSN1QNLwl);
				XActionHelper.OutputResult(TGSguGtKB3P(), CnYSNssvR8G, A9USNHf6vgS, (list3.Count > 0) ? list3[0] : "", OTMSN1QNLwl);
				XActionHelper.OutputResult(BChguH21xHw(), CnYSNssvR8G, A9USNHf6vgS, (list3.Count > 1) ? list3[1] : "", OTMSN1QNLwl);
				XActionHelper.OutputResult(Jc7gubQphLR(), CnYSNssvR8G, A9USNHf6vgS, (list3.Count > 2) ? list3[2] : "", OTMSN1QNLwl);
				XActionHelper.OutputResult(VyfguXd9pKY(), CnYSNssvR8G, A9USNHf6vgS, (list3.Count > 3) ? list3[3] : "", OTMSN1QNLwl);
				XActionHelper.OutputResult(yeAguKToUpt(), CnYSNssvR8G, A9USNHf6vgS, (list3.Count > 4) ? list3[4] : "", OTMSN1QNLwl);
				XActionHelper.OutputResult(gSKguFJwx95, CnYSNssvR8G, A9USNHf6vgS, matchCollection2, OTMSN1QNLwl);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
		}

		internal static bool CjQSdbWvVhIFvkHYJgJo()
		{
			return cLkhboWBzfPyih2D6hVU == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> K3bgurYEdUi;

	[CompilerGenerated]
	private readonly string q2ygup2Erpx = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> wpSguB3NuiL;

	[CompilerGenerated]
	private readonly string fbwguQUrAP8 = "https://getquicker.net/KC/Help/Doc/regexextract";

	[CompilerGenerated]
	private readonly bool I9SgujHVk0x;

	private static readonly StepInParamDef FH2gunZNpu2;

	private static readonly StepInParamDef meNgu4MjDWL;

	private static readonly StepInParamDef mchgu59udP4;

	private static readonly StepInParamDef O4HguDq2YTQ;

	private static readonly StepInParamDef u31gudQbFJ6;

	private static readonly StepInParamDef Te5guotfdoS;

	private static readonly StepInParamDef GUHguT1H4E8;

	private static readonly StepInParamDef DN4guMyrYyC;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> PpZguABdtS9 = new StepInParamDef[8] { FH2gunZNpu2, meNgu4MjDWL, mchgu59udP4, O4HguDq2YTQ, u31gudQbFJ6, Te5guotfdoS, GUHguT1H4E8, DN4guMyrYyC };

	private static StepOutParamDef JnoguOOVBIj;

	private static StepOutParamDef gSKguFJwx95;

	private static readonly StepOutParamDef fiwguU3gprW;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> jtSgulccHTP = new StepOutParamDef[9]
	{
		jiJguWdQH09(),
		TGSguGtKB3P(),
		BChguH21xHw(),
		Jc7gubQphLR(),
		VyfguXd9pKY(),
		yeAguKToUpt(),
		JnoguOOVBIj,
		gSKguFJwx95,
		fiwguU3gprW
	};

	internal static RegexExtractStep WYc0gdQPqtbKSsd8xuOU;

	public string Key => "sys:regexExtract";

	public string Name => "正则提取";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return K3bgurYEdUi;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return q2ygup2Erpx;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return wpSguB3NuiL;
		}
	}

	public string Description => "使用正则表达式提取指定内容";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return fbwguQUrAP8;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return I9SgujHVk0x;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return PpZguABdtS9;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return jtSgulccHTP;
		}
	}

	[SpecialName]
	private static StepOutParamDef jiJguWdQH09()
	{
		return new StepOutParamDef
		{
			Key = "matches",
			Name = "所有匹配列表",
			Description = "返回所有的匹配项",
			Type = VarType.List
		};
	}

	[SpecialName]
	private static StepOutParamDef TGSguGtKB3P()
	{
		return new StepOutParamDef
		{
			Key = "match1 ",
			Name = "匹配1",
			Description = "第1个匹配项的值",
			Type = VarType.Any
		};
	}

	[SpecialName]
	private static StepOutParamDef BChguH21xHw()
	{
		return new StepOutParamDef
		{
			Key = "match2 ",
			Name = "匹配2",
			Description = "第2个匹配项的值",
			Type = VarType.Any
		};
	}

	[SpecialName]
	private static StepOutParamDef Jc7gubQphLR()
	{
		return new StepOutParamDef
		{
			Key = "match3 ",
			Name = "匹配3",
			Description = "第3个匹配项的值",
			Type = VarType.Any
		};
	}

	[SpecialName]
	private static StepOutParamDef VyfguXd9pKY()
	{
		return new StepOutParamDef
		{
			Key = "match4 ",
			Name = "匹配4",
			Description = "第4个匹配项的值",
			Type = VarType.Any
		};
	}

	[SpecialName]
	private static StepOutParamDef yeAguKToUpt()
	{
		return new StepOutParamDef
		{
			Key = "match5 ",
			Name = "匹配5",
			Description = "第5个匹配项的值",
			Type = VarType.Any
		};
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
		_003C_003Ec__DisplayClass57_.CnYSNssvR8G = step;
		_003C_003Ec__DisplayClass57_.A9USNHf6vgS = context;
		_003C_003Ec__DisplayClass57_.OTMSN1QNLwl = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass57_.A9USNHf6vgS, _003C_003Ec__DisplayClass57_.CnYSNssvR8G, _003C_003Ec__DisplayClass57_.OTMSN1QNLwl, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass57_.WQCSNGqhwb1, (Action)null, (Action)null, DN4guMyrYyC, fiwguU3gprW);
	}

	private static IList<string> CM0guIFTSjX(MatchCollection matchCollection_0, int int_0)
	{
		IList<string> list = new List<string>();
		for (int i = 0; i < matchCollection_0.Count; i++)
		{
			if (matchCollection_0[i].Groups.Count > int_0)
			{
				list.Add(matchCollection_0[i].Groups[int_0].Value);
			}
			else
			{
				list.Add("");
			}
		}
		return list;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(FH2gunZNpu2, step) ?? "";
	}

	static RegexExtractStep()
	{
		FH2gunZNpu2 = new StepInParamDef
		{
			Key = "getGroup",
			Name = "提取方式",
			Description = "输出的内容根据提取内容有所不同，请参考模块文档。",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "0",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("0", "各匹配项的值"),
				new SelectionItem("1", "第一个匹配项的组"),
				new SelectionItem("2", "各匹配项的组")
			},
			IsControlField = true
		};
		meNgu4MjDWL = new StepInParamDef
		{
			Key = "data",
			Name = "输入",
			Description = "要提取内容的文本",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		mchgu59udP4 = new StepInParamDef
		{
			Key = "pattern",
			Name = "正则表达式",
			Description = "用于提取内容的正则表达式",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		O4HguDq2YTQ = new StepInParamDef
		{
			Key = "ignoreCase",
			Name = "忽略大小写",
			Description = "不区分英文大小写",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		u31gudQbFJ6 = new StepInParamDef
		{
			Key = "singleLine",
			Name = "单行模式",
			Description = "此模式下“.”能匹配任意字符，包括换行符。(否则匹配除了\\n外的任意字符)",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Te5guotfdoS = new StepInParamDef
		{
			Key = "multiLine",
			Name = "多行模式",
			Description = "此模式下^和$可以分别匹配行首和行尾。(否则匹配输入内容的开始和结束)",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		GUHguT1H4E8 = new StepInParamDef
		{
			Key = "rightToLeft",
			Name = "从右向左",
			Description = "从右向左查找匹配内容",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		DN4guMyrYyC = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "操作失败后，是否停止后续动作的执行。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		JnoguOOVBIj = new StepOutParamDef
		{
			Key = "matchObj",
			Name = "Match对象",
			Description = "首个匹配的原始的C#语言Match对象，可以在表达式中使用",
			Type = VarType.Object,
			ValidForList = new string[1] { "1" }
		};
		gSKguFJwx95 = new StepOutParamDef
		{
			Key = "matchesCollection",
			Name = "Matches集合",
			Description = "所有匹配的原始Match对象集合(MatchCollection)，可以在表达式中使用",
			Type = VarType.Object,
			ValidForList = new string[2] { "0", "2" }
		};
		fiwguU3gprW = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否匹配成功",
			Type = VarType.Boolean
		};
	}

	internal static bool VIqeiXQPiR0eoDVDomMv()
	{
		return WYc0gdQPqtbKSsd8xuOU == null;
	}
}
