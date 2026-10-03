using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities.Ext;
using soLGR8XA95f82ljopSU;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class CloudDataStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public ActionStep pVSv3R1xSJa;

		public ActionExecuteContext syfv3q65Mab;

		public XAction Y7dv3cbG104;

		internal static _003C_003Ec__DisplayClass45_0 qlaGbGWDy5b2RrtqDnDg;

		internal (bool isSuccess, string message, ActionStopFlag failReason) fRDv37mRqFr()
		{
			string textParamValue = XActionHelper.GetTextParamValue(bkvtTleXCGy, pVSv3R1xSJa, syfv3q65Mab);
			string textParamValue2 = XActionHelper.GetTextParamValue(ub3tTi6XvUv, pVSv3R1xSJa, syfv3q65Mab);
			if (string.IsNullOrEmpty(textParamValue2))
			{
				return (isSuccess: false, message: "条目名称不应该为空", failReason: ActionStopFlag.OperationFailed);
			}
			double double_ = Convert.ToDouble(XActionHelper.GetNumberParamValue(fJ5tTfIE6H3, pVSv3R1xSJa, syfv3q65Mab));
			try
			{
				if (!string.IsNullOrEmpty(textParamValue) && !(textParamValue == "readGlobalState"))
				{
					if (textParamValue == "saveGlobalState")
					{
						string textParamValue3 = XActionHelper.GetTextParamValue(hSMtT38ja2f, pVSv3R1xSJa, syfv3q65Mab);
						int num = AppState.DataService.LgXtbzAujUF();
						if (textParamValue3.Length > num)
						{
							return (isSuccess: false, message: $"内容超过了允许的长度（{num}字节）", failReason: ActionStopFlag.OperationFailed);
						}
						oHyR5LX5l5qeapYlxI6.PmftHLHo6Ui(textParamValue2, textParamValue3, double_, syfv3q65Mab).Wait();
					}
				}
				else
				{
					(bool, string, string) result = oHyR5LX5l5qeapYlxI6.zustHvQuASd(textParamValue2, double_).Result;
					if (!result.Item1)
					{
						XActionHelper.OutputResult(WMstML0T10v, pVSv3R1xSJa, syfv3q65Mab, result.Item2, Y7dv3cbG104);
						XActionHelper.OutputResult(ldUtMvKjUyE, pVSv3R1xSJa, syfv3q65Mab, result.Item3, Y7dv3cbG104);
						return (isSuccess: false, message: result.Item2, failReason: ActionStopFlag.OperationFailed);
					}
					XActionHelper.OutputResult(qxZtMggqy0Z, pVSv3R1xSJa, syfv3q65Mab, result.Item2, Y7dv3cbG104);
					XActionHelper.OutputResult(ldUtMvKjUyE, pVSv3R1xSJa, syfv3q65Mab, "", Y7dv3cbG104);
				}
				XActionHelper.OutputResult(WMstML0T10v, pVSv3R1xSJa, syfv3q65Mab, "", Y7dv3cbG104);
			}
			catch (Exception exception)
			{
				XActionHelper.OutputResult(ldUtMvKjUyE, pVSv3R1xSJa, syfv3q65Mab, "Exception", Y7dv3cbG104);
				XActionHelper.OutputResult(WMstML0T10v, pVSv3R1xSJa, syfv3q65Mab, exception.GetMessageWithInner(), Y7dv3cbG104);
				throw;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void fk28jpWD2lCbbIIBrVMT()
		{
		}

		internal static bool y79VjdWDpnNaNCGMwoBc()
		{
			return qlaGbGWDy5b2RrtqDnDg == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> oj3tTMlEY5e = new string[4] { "网络", "云", "cloud", "同步" };

	[CompilerGenerated]
	private readonly string GsstTAKpt1k = $"fa:{EFontAwesomeIcon.Light_Cloud}:#32a852";

	[CompilerGenerated]
	private readonly StepRunnerCategory CT5tTOmbdcB = StepRunnerCategory.Network;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> La4tTFTE3e3;

	[CompilerGenerated]
	private readonly string Nw5tTUUFTRT = "https://getquicker.net/KC/Help/Doc/clouddata";

	private static readonly StepInParamDef bkvtTleXCGy;

	private static readonly StepInParamDef ub3tTi6XvUv;

	private static readonly StepInParamDef hSMtT38ja2f;

	private static readonly StepInParamDef fJ5tTfIE6H3;

	private static readonly StepInParamDef ImOtTz2kYhT;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> FwJtMwhAOBk = new StepInParamDef[5] { bkvtTleXCGy, ub3tTi6XvUv, hSMtT38ja2f, fJ5tTfIE6H3, ImOtTz2kYhT };

	private static readonly StepOutParamDef IxQtMtWEB9h;

	private static readonly StepOutParamDef qxZtMggqy0Z;

	private static readonly StepOutParamDef WMstML0T10v;

	private static readonly StepOutParamDef ldUtMvKjUyE;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> WWqtMS68iHw = new StepOutParamDef[4] { IxQtMtWEB9h, qxZtMggqy0Z, WMstML0T10v, ldUtMvKjUyE };

	private static CloudDataStep MOxNNNQiqDpA6aiSuKds;

	public string Key => "sys:clouddata";

	public string Name => "云状态存取";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return oj3tTMlEY5e;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return GsstTAKpt1k;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return CT5tTOmbdcB;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return La4tTFTE3e3;
		}
	}

	public string Description => "根据键值读取或写入网络数据。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return Nw5tTUUFTRT;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return FwJtMwhAOBk;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return WWqtMS68iHw;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
		_003C_003Ec__DisplayClass45_.pVSv3R1xSJa = step;
		_003C_003Ec__DisplayClass45_.syfv3q65Mab = context;
		_003C_003Ec__DisplayClass45_.Y7dv3cbG104 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass45_.syfv3q65Mab, _003C_003Ec__DisplayClass45_.pVSv3R1xSJa, _003C_003Ec__DisplayClass45_.Y7dv3cbG104, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass45_.fRDv37mRqFr, (Action)null, (Action)null, ImOtTz2kYhT, IxQtMtWEB9h);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(bkvtTleXCGy, step) + "  " + XActionHelper.GetParamDirectValue(ub3tTi6XvUv, step);
	}

	static CloudDataStep()
	{
		bkvtTleXCGy = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			DefaultValue = "readGlobalState",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("readGlobalState", "从网络读取数据"),
				new SelectionItem("saveGlobalState", "写入数据到网络")
			},
			IsControlField = true
		};
		ub3tTi6XvUv = new StepInParamDef
		{
			Key = "key",
			Name = "状态名称",
			Description = "存储或读取的数据条目名称(键)。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "readGlobalState", "saveGlobalState" }
		};
		hSMtT38ja2f = new StepInParamDef
		{
			Key = "value",
			Name = "内容",
			Description = "要保存的数据值。使用“*NULL*”删除此状态的存储。",
			DefaultValue = "",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "saveGlobalState" }
		};
		fJ5tTfIE6H3 = new StepInParamDef
		{
			Key = "expireSeconds",
			Name = "超时时间",
			Description = "请求超时时间（秒数）",
			Type = VarType.Number,
			DefaultValue = 2.5,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		ImOtTz2kYhT = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		IxQtMtWEB9h = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		qxZtMggqy0Z = new StepOutParamDef
		{
			Key = "value",
			Name = "内容",
			Description = "读取到的状态内容",
			Type = VarType.Any,
			ValidForList = new string[1] { "readGlobalState" }
		};
		WMstML0T10v = new StepOutParamDef
		{
			Key = "err",
			Name = "错误信息",
			Description = "出错时输出的错误信息。",
			Type = VarType.Text
		};
		ldUtMvKjUyE = new StepOutParamDef
		{
			Key = "errCode",
			Name = "错误代码",
			Description = "从云服务商返回的错误代码。NoSuchKey=不存在此状态。",
			Type = VarType.Text,
			ValidForList = new string[1] { "readGlobalState" }
		};
	}

	internal static bool bBjV5DQiiY8qhLE0b70d()
	{
		return MOxNNNQiqDpA6aiSuKds == null;
	}
}
