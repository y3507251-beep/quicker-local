using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class AssignValueStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionStep MrQS7dYijY0;

		public ActionExecuteContext TThS7oeKLAE;

		public XAction QjqS7TueZ7m;

		internal static _003C_003Ec__DisplayClass39_0 K72k3CWkDkwH9raiH2KR;

		internal (bool isSuccess, string message, ActionStopFlag failReason) HfPS7DVmnhH()
		{
			object paramValue = XActionHelper.GetParamValue(TBggEAlUav0, MrQS7dYijY0, TThS7oeKLAE, false, false, true);
			if (XActionHelper.IsOutputParamSetted(UJ2gEFwlSTT.Key, MrQS7dYijY0))
			{
				_003C_003Ec__DisplayClass39_1 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_1
				{
					y6uS7AYpp0X = MrQS7dYijY0.OutputParams[UJ2gEFwlSTT.Key]
				};
				ActionVariable actionVariable = QjqS7TueZ7m.Variables.FirstOrDefault(_003C_003Ec__DisplayClass39_.BBlS7M2k6wC);
				if (actionVariable != null)
				{
					object obj = VariableHelper.ConvertToType(actionVariable.Type, paramValue);
					if (actionVariable.Type == VarType.List && obj.IsList())
					{
						obj = new List<string>((obj as IList<string>) ?? throw new InvalidOperationException("内容不是列表"));
					}
					else if (actionVariable.Type == VarType.Dict && obj.IsDictionary())
					{
						obj = new Dictionary<string, object>((obj as Dictionary<string, object>) ?? throw new InvalidOperationException("内容不是词典"));
					}
					XActionHelper.OutputResult(UJ2gEFwlSTT, MrQS7dYijY0, TThS7oeKLAE, obj, QjqS7TueZ7m);
				}
				else
				{
					XActionHelper.OutputResult(UJ2gEFwlSTT, MrQS7dYijY0, TThS7oeKLAE, paramValue, QjqS7TueZ7m);
				}
			}
			else
			{
				TThS7oeKLAE.ActionLogger.LogWarning("赋值模块未定义输出。");
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		static _003C_003Ec__DisplayClass39_0()
		{
		}

		internal static bool qusC0PWk33fI3fmLUJR5()
		{
			return K72k3CWkDkwH9raiH2KR == null;
		}

		internal static void Y1fvRcWkGutNQoL0l35p()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_1
	{
		public string y6uS7AYpp0X;

		internal static _003C_003Ec__DisplayClass39_1 S6TAXNWk0oEkRXYoPnf5;

		internal bool BBlS7M2k6wC(ActionVariable x)
		{
			return x.Key == y6uS7AYpp0X;
		}

		internal static bool raVgdGWk1NIW7BVf0Bkv()
		{
			return S6TAXNWk0oEkRXYoPnf5 == null;
		}
	}

	public const string KEY = "sys:assign";

	[CompilerGenerated]
	private readonly IEnumerable<string> bgBgE4OFf0n = new string[3] { "写入", "转换", "convert" };

	[CompilerGenerated]
	private readonly string WVegE5LvUBG = $"fa:{EFontAwesomeIcon.Light_Edit}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ouIgED54iY0;

	[CompilerGenerated]
	private readonly string n4WgEdWLVJk = "https://getquicker.net/KC/Help/Doc/assign";

	[CompilerGenerated]
	private readonly bool i2dgEopRfQ3;

	private static readonly StepInParamDef ATRgETqmfH4;

	private static readonly StepOutParamDef NdCgEMQa9mU;

	private static readonly StepInParamDef TBggEAlUav0;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> upAgEOutEZS = new StepInParamDef[2] { TBggEAlUav0, ATRgETqmfH4 };

	private static readonly StepOutParamDef UJ2gEFwlSTT;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> tdRgEUVlb0Q = new StepOutParamDef[2] { NdCgEMQa9mU, UJ2gEFwlSTT };

	internal static AssignValueStep ViyCGFQxNCSbhPxWx4mb;

	public string Key => "sys:assign";

	public string Name => "赋值";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return bgBgE4OFf0n;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return WVegE5LvUBG;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ouIgED54iY0;
		}
	}

	public string Description => "为变量赋值。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return n4WgEdWLVJk;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return i2dgEopRfQ3;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return upAgEOutEZS;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return tdRgEUVlb0Q;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.MrQS7dYijY0 = step;
		_003C_003Ec__DisplayClass39_.TThS7oeKLAE = context;
		_003C_003Ec__DisplayClass39_.QjqS7TueZ7m = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.TThS7oeKLAE, _003C_003Ec__DisplayClass39_.MrQS7dYijY0, _003C_003Ec__DisplayClass39_.QjqS7TueZ7m, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.HfPS7DVmnhH, (Action)null, (Action)null, ATRgETqmfH4, NdCgEMQa9mU);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(TBggEAlUav0, step, 60) + " => " + XActionHelper.GetOutputParamDisplayString(UJ2gEFwlSTT, step);
	}

	static AssignValueStep()
	{
		ATRgETqmfH4 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		NdCgEMQa9mU = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		TBggEAlUav0 = new StepInParamDef
		{
			Key = "input",
			Name = "输入",
			Description = "要赋值给变量的内容，可以直接是其他变量，也可以直接输入值或使用插值格式。",
			DefaultValue = "",
			Type = VarType.Any,
			IsRequired = true,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		UJ2gEFwlSTT = new StepOutParamDef
		{
			Key = "output",
			Name = "输出",
			Description = "将数据写入到变量中",
			Type = VarType.Any
		};
	}

	internal static bool uIpuCiQx9wpV1IAm6lrL()
	{
		return ViyCGFQxNCSbhPxWx4mb == null;
	}
}
