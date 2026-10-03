using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class PathExtractionStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass61_0
	{
		public ActionStep k8uSNIQ5fB6;

		public ActionExecuteContext TMKSNW6wYJT;

		public XAction qgcSNkrgo0e;

		internal static _003C_003Ec__DisplayClass61_0 ew33naWB7IhwisEaA8yJ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) SYrSNYPBLYi()
		{
			string textParamValue = XActionHelper.GetTextParamValue(IE7guyIqCQC, k8uSNIQ5fB6, TMKSNW6wYJT);
			string textParamValue2 = XActionHelper.GetTextParamValue(R1pgu8uAidD, k8uSNIQ5fB6, TMKSNW6wYJT);
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "未识别的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			case "combine":
			{
				string textParamValue6 = XActionHelper.GetTextParamValue(dbAgucW79uU, k8uSNIQ5fB6, TMKSNW6wYJT);
				string textParamValue7 = XActionHelper.GetTextParamValue(YV8guVBaOME, k8uSNIQ5fB6, TMKSNW6wYJT);
				string textParamValue8 = XActionHelper.GetTextParamValue(bgeguZ5MI0T, k8uSNIQ5fB6, TMKSNW6wYJT);
				XActionHelper.OutputResult(IMHg2zo51Cf(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.Combine(textParamValue2, textParamValue6, textParamValue7, textParamValue8), qgcSNkrgo0e);
				break;
			}
			case "changeDir":
			{
				string textParamValue5 = XActionHelper.GetTextParamValue(MYlguq27jDw, k8uSNIQ5fB6, TMKSNW6wYJT);
				XActionHelper.OutputResult(IMHg2zo51Cf(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.Combine(textParamValue5, Path.GetFileName(textParamValue2)), qgcSNkrgo0e);
				break;
			}
			case "changeNameWithoutExt":
			{
				string path = XActionHelper.GetTextParamValue(nW3guRuCa0j, k8uSNIQ5fB6, TMKSNW6wYJT) + Path.GetExtension(textParamValue2);
				XActionHelper.OutputResult(IMHg2zo51Cf(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.Combine(Path.GetDirectoryName(textParamValue2), path), qgcSNkrgo0e);
				break;
			}
			case "changeName":
			{
				string textParamValue4 = XActionHelper.GetTextParamValue(rSSgu7JQh6m, k8uSNIQ5fB6, TMKSNW6wYJT);
				XActionHelper.OutputResult(IMHg2zo51Cf(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.Combine(Path.GetDirectoryName(textParamValue2), textParamValue4), qgcSNkrgo0e);
				break;
			}
			case "changeExt":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(A6ogua9cbdo, k8uSNIQ5fB6, TMKSNW6wYJT);
				XActionHelper.OutputResult(IMHg2zo51Cf(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.ChangeExtension(textParamValue2, textParamValue3), qgcSNkrgo0e);
				break;
			}
			case "getInfo":
				XActionHelper.OutputResult(KhbgutXwoAn(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.GetFileName(textParamValue2), qgcSNkrgo0e);
				XActionHelper.OutputResult(P1rguLTNYiT(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.GetFileNameWithoutExtension(textParamValue2), qgcSNkrgo0e);
				XActionHelper.OutputResult(apfguSNibPc(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.GetDirectoryName(textParamValue2), qgcSNkrgo0e);
				XActionHelper.OutputResult(TcmguuNaMS1(), k8uSNIQ5fB6, TMKSNW6wYJT, Path.GetExtension(textParamValue2), qgcSNkrgo0e);
				break;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void AOEgCZWBHvhUqjtksrSP()
		{
		}

		internal static bool cXyJ7nWB4KTvLb3soRJK()
		{
			return ew33naWB7IhwisEaA8yJ == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> xchguJMh7uS = new string[3] { "path", "文件名", "扩展名" };

	[CompilerGenerated]
	private readonly string MoYgu0bsygh = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> yGYguCtN97B;

	[CompilerGenerated]
	private readonly string r8pguPTY3iF = "https://getquicker.net/KC/Help/Doc/pathExtraction";

	[CompilerGenerated]
	private readonly bool fhVguE1dkwm;

	public const string OPERATION_GET_INFO = "getInfo";

	public const string OPERATION_CHANGE_EXT = "changeExt";

	public const string OPERATION_CHANGE_NAME = "changeName";

	public const string OPERATION_CHANGE_NAME_WITHOUT_EXT = "changeNameWithoutExt";

	public const string OPERATION_CHANGE_DIR = "changeDir";

	public const string OPERATION_COMBINE = "combine";

	private static readonly StepInParamDef IE7guyIqCQC;

	private static readonly StepInParamDef R1pgu8uAidD;

	private static readonly StepInParamDef A6ogua9cbdo;

	private static readonly StepInParamDef rSSgu7JQh6m;

	private static readonly StepInParamDef nW3guRuCa0j;

	private static readonly StepInParamDef MYlguq27jDw;

	private static readonly StepInParamDef dbAgucW79uU;

	private static readonly StepInParamDef YV8guVBaOME;

	private static readonly StepInParamDef bgeguZ5MI0T;

	private static readonly StepInParamDef Dl7gu9QEqhr;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> IUPguhXCDnT = new StepInParamDef[10] { IE7guyIqCQC, R1pgu8uAidD, A6ogua9cbdo, rSSgu7JQh6m, nW3guRuCa0j, MYlguq27jDw, dbAgucW79uU, YV8guVBaOME, bgeguZ5MI0T, Dl7gu9QEqhr };

	private static readonly StepOutParamDef YR5gueOZ0Pg;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> VKAguY94b2a = new StepOutParamDef[6]
	{
		YR5gueOZ0Pg,
		IMHg2zo51Cf(),
		KhbgutXwoAn(),
		P1rguLTNYiT(),
		TcmguuNaMS1(),
		apfguSNibPc()
	};

	private static PathExtractionStep CSRGCpQPNYhE2fI4flPu;

	public string Key => "sys:pathExtraction";

	public string Name => "提取文件路径信息/生成路径";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return xchguJMh7uS;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return MoYgu0bsygh;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return yGYguCtN97B;
		}
	}

	public string Description => "从文件路径中提取文件名、文件夹等信息";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return r8pguPTY3iF;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return fhVguE1dkwm;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return IUPguhXCDnT;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return VKAguY94b2a;
		}
	}

	[SpecialName]
	private static StepOutParamDef IMHg2zo51Cf()
	{
		StepOutParamDef stepOutParamDef = new StepOutParamDef();
		stepOutParamDef.Key = "resultPath";
		stepOutParamDef.Name = "结果路径";
		stepOutParamDef.Description = "生成的结果路径";
		stepOutParamDef.Type = VarType.Text;
		stepOutParamDef.ValidForList = new string[5] { "changeExt", "changeDir", "changeName", "changeNameWithoutExt", "combine" };
		return stepOutParamDef;
	}

	[SpecialName]
	private static StepOutParamDef KhbgutXwoAn()
	{
		StepOutParamDef stepOutParamDef = new StepOutParamDef();
		stepOutParamDef.Key = "name";
		stepOutParamDef.Name = "文件名";
		stepOutParamDef.Description = "去除路径的文件名";
		stepOutParamDef.Type = VarType.Text;
		stepOutParamDef.ValidForList = new string[1] { "getInfo" };
		return stepOutParamDef;
	}

	[SpecialName]
	private static StepOutParamDef P1rguLTNYiT()
	{
		StepOutParamDef stepOutParamDef = new StepOutParamDef();
		stepOutParamDef.Key = "nameNoExt";
		stepOutParamDef.Name = "文件名(去掉扩展名)";
		stepOutParamDef.Description = "去除扩展名的文件名";
		stepOutParamDef.Type = VarType.Text;
		stepOutParamDef.ValidForList = new string[1] { "getInfo" };
		return stepOutParamDef;
	}

	[SpecialName]
	private static StepOutParamDef apfguSNibPc()
	{
		StepOutParamDef stepOutParamDef = new StepOutParamDef();
		stepOutParamDef.Key = "path";
		stepOutParamDef.Name = "所在文件夹路径";
		stepOutParamDef.Description = "父目录路径";
		stepOutParamDef.Type = VarType.Text;
		stepOutParamDef.ValidForList = new string[1] { "getInfo" };
		return stepOutParamDef;
	}

	[SpecialName]
	private static StepOutParamDef TcmguuNaMS1()
	{
		StepOutParamDef stepOutParamDef = new StepOutParamDef();
		stepOutParamDef.Key = "ext";
		stepOutParamDef.Name = "扩展名";
		stepOutParamDef.Description = "文件的扩展名";
		stepOutParamDef.Type = VarType.Text;
		stepOutParamDef.ValidForList = new string[1] { "getInfo" };
		return stepOutParamDef;
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass61_0 _003C_003Ec__DisplayClass61_ = new _003C_003Ec__DisplayClass61_0();
		_003C_003Ec__DisplayClass61_.k8uSNIQ5fB6 = step;
		_003C_003Ec__DisplayClass61_.TMKSNW6wYJT = context;
		_003C_003Ec__DisplayClass61_.qgcSNkrgo0e = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass61_.TMKSNW6wYJT, _003C_003Ec__DisplayClass61_.k8uSNIQ5fB6, _003C_003Ec__DisplayClass61_.qgcSNkrgo0e, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass61_.SYrSNYPBLYi, (Action)null, (Action)null, Dl7gu9QEqhr, YR5gueOZ0Pg);
	}

	public string GetSummary(ActionStep step)
	{
		string paramDirectValue = XActionHelper.GetParamDirectValue(IE7guyIqCQC, step, false);
		string text = XActionHelper.GetParamDisplayString(IE7guyIqCQC, step) + " " + XActionHelper.GetParamDisplayString(R1pgu8uAidD, step) + " ";
		return paramDirectValue switch
		{
			"changeDir" => text + "=> " + XActionHelper.GetParamDisplayString(MYlguq27jDw, step), 
			"changeName" => text + "=> " + XActionHelper.GetParamDisplayString(rSSgu7JQh6m, step), 
			"changeExt" => text + "=> " + XActionHelper.GetParamDisplayString(A6ogua9cbdo, step), 
			_ => text, 
		};
	}

	static PathExtractionStep()
	{
		IE7guyIqCQC = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "getInfo",
			SelectionItems = new SelectionItem[6]
			{
				new SelectionItem("getInfo", "提取文件路径信息"),
				new SelectionItem("changeExt", "更改扩展名，其它不变"),
				new SelectionItem("changeName", "更改文件名(含扩展名)，所在目录不变"),
				new SelectionItem("changeNameWithoutExt", "更改文件名(不含扩展名和所在目录)"),
				new SelectionItem("changeDir", "更改所在目录，文件名不变"),
				new SelectionItem("combine", "合并路径 (拼接)")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		R1pgu8uAidD = new StepInParamDef
		{
			Key = "path",
			Name = "路径",
			Description = "待处理或拼接的路径",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[6] { "getInfo", "changeExt", "changeName", "changeNameWithoutExt", "changeDir", "combine" }
		};
		A6ogua9cbdo = new StepInParamDef
		{
			Key = "newExtension",
			Name = "新的扩展名",
			Description = "新的扩展名，如：.png",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[1] { "changeExt" }
		};
		rSSgu7JQh6m = new StepInParamDef
		{
			Key = "newFileName",
			Name = "新的文件名",
			Description = "新的文件名，如：abcd.png",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[1] { "changeName" }
		};
		nW3guRuCa0j = new StepInParamDef
		{
			Key = "newFileNameWithoutExt",
			Name = "新的文件名",
			Description = "新的文件名(不包含扩展名），如：newfile",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[1] { "changeNameWithoutExt" }
		};
		MYlguq27jDw = new StepInParamDef
		{
			Key = "newDir",
			Name = "目标目录路径",
			Description = "目标存储路径，如：d:\\Work\\Test",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[1] { "changeDir" }
		};
		dbAgucW79uU = new StepInParamDef
		{
			Key = "path2",
			Name = "路径部分2",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[1] { "combine" }
		};
		YV8guVBaOME = new StepInParamDef
		{
			Key = "path3",
			Name = "路径部分3",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[1] { "combine" }
		};
		bgeguZ5MI0T = new StepInParamDef
		{
			Key = "path4",
			Name = "路径部分4",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[1] { "combine" }
		};
		Dl7gu9QEqhr = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		YR5gueOZ0Pg = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "提取过程是否没有遇到异常",
			Type = VarType.Boolean
		};
	}

	internal static bool T8DLloQP911WYpJk4ynP()
	{
		return CSRGCpQPNYhE2fI4flPu == null;
	}
}
