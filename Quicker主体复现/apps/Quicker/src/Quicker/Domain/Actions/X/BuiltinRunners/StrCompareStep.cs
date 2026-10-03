using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using FontAwesome5;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class StrCompareStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ActionStep PqoSwz7ITSD;

		public ActionExecuteContext JE6StwKgBuA;

		public XAction BDkSttM06D8;

		private static _003C_003Ec__DisplayClass41_0 PxeI2KWEbbCP1p6NBuoS;

		internal (bool isSuccess, string message, ActionStopFlag failReason) NJFSwfVPDPj()
		{
			string textParamValue = XActionHelper.GetTextParamValue(s0TtlSCQ8Cb, PqoSwz7ITSD, JE6StwKgBuA);
			string textParamValue2 = XActionHelper.GetTextParamValue(bwdtlvYHLr0, PqoSwz7ITSD, JE6StwKgBuA);
			string textParamValue3 = XActionHelper.GetTextParamValue(Etmtl2dr0KV, PqoSwz7ITSD, JE6StwKgBuA);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(oHdtluMP70L, PqoSwz7ITSD, JE6StwKgBuA);
			bool flag = false;
			switch (textParamValue)
			{
			case "match":
				try
				{
					flag = Regex.IsMatch(textParamValue2, textParamValue3, (!booleanParamValue) ? RegexOptions.IgnoreCase : RegexOptions.None);
				}
				catch (Exception exception)
				{
					return (isSuccess: false, message: "匹配出错：" + exception.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_020c;
			case "endsWith":
				flag = (booleanParamValue ? textParamValue2.EndsWith(textParamValue3, StringComparison.Ordinal) : textParamValue2.EndsWith(textParamValue3, StringComparison.OrdinalIgnoreCase));
				goto IL_020c;
			case "contains":
				flag = (booleanParamValue ? textParamValue2.Contains(textParamValue3) : textParamValue2.ToUpperInvariant().Contains(textParamValue3.ToUpperInvariant()));
				goto IL_020c;
			case "startsWith":
				flag = (booleanParamValue ? textParamValue2.StartsWith(textParamValue3, StringComparison.Ordinal) : textParamValue2.StartsWith(textParamValue3, StringComparison.OrdinalIgnoreCase));
				goto IL_020c;
			case "pinyinMatch":
				flag = tkxn6HAKAgMT8gvXbyh.IsMatch(textParamValue2, textParamValue3);
				goto IL_020c;
			case "<":
				flag = string.Compare(textParamValue2, textParamValue3, CultureInfo.InvariantCulture, (!booleanParamValue) ? CompareOptions.IgnoreCase : CompareOptions.None) < 0;
				goto IL_020c;
			case "=":
				flag = string.Equals(textParamValue2, textParamValue3, booleanParamValue ? StringComparison.InvariantCulture : StringComparison.InvariantCultureIgnoreCase);
				goto IL_020c;
			case ">":
				flag = string.Compare(textParamValue2, textParamValue3, CultureInfo.InvariantCulture, (!booleanParamValue) ? CompareOptions.IgnoreCase : CompareOptions.None) > 0;
				goto IL_020c;
			default:
				{
					return (isSuccess: false, message: "不支持的操作符：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_020c:
				XActionHelper.OutputResult(ohttlJDWSsf, PqoSwz7ITSD, JE6StwKgBuA, flag, BDkSttM06D8);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool yfOPlWWEqyJ8Hqi2FR4B()
		{
			return PxeI2KWEbbCP1p6NBuoS == null;
		}
	}

	private static List<string> QxitUzAxXQy;

	[CompilerGenerated]
	private readonly string tOWtlw0O4vO = $"fa:{EFontAwesomeIcon.Light_Calculator}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> hKPtlt7hsMm = new StepRunnerCategory[1] { StepRunnerCategory.Text };

	[CompilerGenerated]
	private readonly string Xi2tlgX1U9b = "https://getquicker.net/KC/Help/Doc/strCompare";

	[CompilerGenerated]
	private readonly bool OjbtlLB7HmF;

	private static readonly StepInParamDef bwdtlvYHLr0;

	private static readonly StepInParamDef s0TtlSCQ8Cb;

	private static readonly StepInParamDef Etmtl2dr0KV;

	private static readonly StepInParamDef oHdtluMP70L;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> JYVtlNFUhic = new StepInParamDef[4] { bwdtlvYHLr0, s0TtlSCQ8Cb, Etmtl2dr0KV, oHdtluMP70L };

	private static readonly StepOutParamDef ohttlJDWSsf;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Jtvtl0OrBbq = new StepOutParamDef[1] { ohttlJDWSsf };

	private static StrCompareStep e39ubiQZHLV0Xi6Ejtit;

	public string Key => "sys:strCompare";

	public string Name => "比较文本";

	public IEnumerable<string> KeyWords => QxitUzAxXQy;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return tOWtlw0O4vO;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return hKPtlt7hsMm;
		}
	}

	public string Description => "文本比较";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return Xi2tlgX1U9b;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return OjbtlLB7HmF;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return JYVtlNFUhic;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Jtvtl0OrBbq;
		}
	}

	static StrCompareStep()
	{
		QxitUzAxXQy = new List<string> { "比较", "正则", "以指定内容开始", "窗口" };
		bwdtlvYHLr0 = new StepInParamDef
		{
			Key = "param1",
			Name = "文本1",
			Description = "被比较的文本",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		s0TtlSCQ8Cb = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "比较方式",
			DefaultValue = ">",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(">"),
				new SelectionItem("="),
				new SelectionItem("<"),
				new SelectionItem("contains", "包含"),
				new SelectionItem("startsWith", "以指定内容开始"),
				new SelectionItem("endsWith", "以指定内容结束"),
				new SelectionItem("match", "正则匹配"),
				new SelectionItem("pinyinMatch", "包含指定内容，或匹配拼音、拼音首字母")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		Etmtl2dr0KV = new StepInParamDef
		{
			Key = "param2",
			Name = "文本2",
			Description = "对比文本。拼音匹配时，也可用于指定拼音、拼音首字母。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		oHdtluMP70L = new StepInParamDef
		{
			Key = "case",
			Name = "区分大小写",
			Description = "是否区分大小写",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			InvalidForList = new List<string> { "pinyinMatch" }
		};
		ohttlJDWSsf = new StepOutParamDef
		{
			Key = "value",
			Name = "值",
			Description = "比较结果是否为真",
			Type = VarType.Boolean
		};
		foreach (SelectionItem selectionItem in s0TtlSCQ8Cb.SelectionItems)
		{
			QxitUzAxXQy.Add(selectionItem.Name);
			QxitUzAxXQy.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.PqoSwz7ITSD = step;
		_003C_003Ec__DisplayClass41_.JE6StwKgBuA = context;
		_003C_003Ec__DisplayClass41_.BDkSttM06D8 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass41_.JE6StwKgBuA, _003C_003Ec__DisplayClass41_.PqoSwz7ITSD, _003C_003Ec__DisplayClass41_.BDkSttM06D8, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass41_.NJFSwfVPDPj, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(bwdtlvYHLr0, step) + " " + XActionHelper.GetParamDirectValue(s0TtlSCQ8Cb, step) + "  " + XActionHelper.GetParamDisplayString(Etmtl2dr0KV, step) + " ?";
	}

	internal static bool YaVEMhQZzOjognDJPFxX()
	{
		return e39ubiQZHLV0Xi6Ejtit == null;
	}
}
