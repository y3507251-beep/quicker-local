using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.View.Progress;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class RepeatStepRunner : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ActionStep Lb9SLPfwqPi;

		public ActionExecuteContext DwVSLEWi5wR;

		public XAction bgXSLy03G57;

		public string Y5nSL84jZsO;

		internal static _003C_003Ec__DisplayClass41_0 PmN61kW00er22Jl9AwNc;

		internal (bool isSuccess, string message, ActionStopFlag failReason) hWmSLCeeIKS()
		{
			long integerParamValue = XActionHelper.GetIntegerParamValue(rgPtz3LcZGf, Lb9SLPfwqPi, DwVSLEWi5wR);
			long integerParamValue2 = XActionHelper.GetIntegerParamValue(hKwtzfMSCUS, Lb9SLPfwqPi, DwVSLEWi5wR);
			bool flag = XActionHelper.IsInputParamDefined(YEmtzzyw3n1, Lb9SLPfwqPi);
			int num = (int)XActionHelper.GetIntegerParamValue(uCHgwwkj3Dc, Lb9SLPfwqPi, DwVSLEWi5wR);
			string textParamValue = XActionHelper.GetTextParamValue(Hexgwt9Yi7i, Lb9SLPfwqPi, DwVSLEWi5wR);
			if (integerParamValue < -1L)
			{
				DwVSLEWi5wR.ActionLogger?.LogWarning($"循环次数为{integerParamValue}，提前退出循环");
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			IList<ActionStep> ifSteps = Lb9SLPfwqPi.IfSteps;
			if (ifSteps != null && ifSteps.Count >= 0)
			{
				if (DwVSLEWi5wR.IsDebugging)
				{
					DwVSLEWi5wR.ActionLogger.BeginStepGroup("", (int)integerParamValue);
				}
				CancellationTokenSource cancellationTokenSource = null;
				int num2 = 0;
				if (!string.IsNullOrEmpty(textParamValue) && integerParamValue > 0L)
				{
					cancellationTokenSource = new CancellationTokenSource();
					num2 = ProgressReportMgr.RequestProgressId();
					ProgressReportMgr.UpdateProgress(num2, "", textParamValue, 0.0, $"共 {integerParamValue} 项", DwVSLEWi5wR.Id, cancellationTokenSource);
				}
				try
				{
					for (long num3 = 0L; num3 < integerParamValue || integerParamValue == -1L; num3++)
					{
						if (num2 > 0)
						{
							CancellationToken? cancellationToken = DwVSLEWi5wR.CancellationToken;
							if (cancellationToken.HasValue && cancellationToken.GetValueOrDefault().IsCancellationRequested)
							{
								return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
							}
							ProgressReportMgr.UpdateProgress(num2, "", textParamValue, (double)(num3 + 1L) * 100.0 / (double)integerParamValue, $"第 {num3 + 1L}/{integerParamValue} 项", DwVSLEWi5wR.Id, cancellationTokenSource);
						}
						if (DwVSLEWi5wR.IsDebugging)
						{
							DwVSLEWi5wR.ActionLogger.BeginRepeat($"第 {num3} 次循环");
						}
						if (cancellationTokenSource == null || !cancellationTokenSource.IsCancellationRequested)
						{
							try
							{
								XActionHelper.OutputResult(HTYgwLfZRvJ, Lb9SLPfwqPi, DwVSLEWi5wR, num3 + integerParamValue2, bgXSLy03G57);
								if (flag && XActionHelper.GetBooleanParamValue(YEmtzzyw3n1, Lb9SLPfwqPi, DwVSLEWi5wR))
								{
									if (DwVSLEWi5wR.IsDebugging)
									{
										DwVSLEWi5wR.ActionLogger.LogInfo("符合了循环退出条件，退出循环。");
									}
									break;
								}
								XActionRunner.RunChildSteps(Lb9SLPfwqPi.IfSteps, 0, DwVSLEWi5wR, bgXSLy03G57, Y5nSL84jZsO);
							}
							finally
							{
								DwVSLEWi5wR.ActionLogger.EndRepeat();
							}
							if (DwVSLEWi5wR.ShouldContinue())
							{
								DwVSLEWi5wR.ClearContinueFlag();
							}
							if (!DwVSLEWi5wR.IsShouldBreak())
							{
								if (!DwVSLEWi5wR.IsShouldStopAction())
								{
									if (num3 >= integerParamValue - 1L && integerParamValue >= 0L)
									{
										continue;
									}
									if (num > 20)
									{
										long num4 = AppHelper.fLiLTj0x4QY() + num;
										while (num4 > AppHelper.fLiLTj0x4QY() && !DwVSLEWi5wR.IsShouldStopAction())
										{
											Thread.Sleep(20);
										}
									}
									else if (num > 0)
									{
										Thread.Sleep(num);
									}
									continue;
								}
								return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
							}
							DwVSLEWi5wR.ActionLogger.LogInfo("检测到Break标记，停止循环");
							DwVSLEWi5wR.ClearBreakFlag();
							break;
						}
						return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
					}
				}
				catch (OperationCanceledException)
				{
					return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
				}
				finally
				{
					if (DwVSLEWi5wR.IsDebugging)
					{
						DwVSLEWi5wR.ActionLogger.EndStepGroup();
					}
					if (num2 > 0)
					{
						ProgressReportMgr.RemoveProgress(num2);
					}
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool Euf534W01aa7o751McM2()
		{
			return PmN61kW00er22Jl9AwNc == null;
		}
	}

	public const string KEY = "sys:repeat";

	[CompilerGenerated]
	private readonly IEnumerable<string> EystzOUpah5 = new string[5] { "for", "循环", "repeat", "条件", "check" };

	[CompilerGenerated]
	private readonly string Y4otzFN469G = $"fa:{EFontAwesomeIcon.Light_Repeat}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> SIBtzUAZH2r;

	[CompilerGenerated]
	private readonly string kM0tzllIGhw = "https://getquicker.net/KC/Help/Doc/repeat";

	[CompilerGenerated]
	private readonly bool er6tziKS5Vq;

	private static readonly StepInParamDef rgPtz3LcZGf;

	private static readonly StepInParamDef hKwtzfMSCUS;

	private static readonly StepInParamDef YEmtzzyw3n1;

	private static readonly StepInParamDef uCHgwwkj3Dc;

	private static readonly StepInParamDef Hexgwt9Yi7i;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> n1Pgwg4Ns6f = new StepInParamDef[5] { rgPtz3LcZGf, YEmtzzyw3n1, hKwtzfMSCUS, uCHgwwkj3Dc, Hexgwt9Yi7i };

	private static readonly StepOutParamDef HTYgwLfZRvJ;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> i5Ugwvd2dOq = new StepOutParamDef[1] { HTYgwLfZRvJ };

	internal static RepeatStepRunner PRecUDQ8EkfbT93qgtkg;

	public string Key => "sys:repeat";

	public string Name => "重复";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return EystzOUpah5;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Y4otzFN469G;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return SIBtzUAZH2r;
		}
	}

	public string Description => "循环指定的次数，或符合某个条件时中止";

	public StepType StepType => StepType.Loop;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return kM0tzllIGhw;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return er6tziKS5Vq;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return n1Pgwg4Ns6f;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return i5Ugwvd2dOq;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step1, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.Lb9SLPfwqPi = step1;
		_003C_003Ec__DisplayClass41_.DwVSLEWi5wR = context;
		_003C_003Ec__DisplayClass41_.bgXSLy03G57 = action;
		_003C_003Ec__DisplayClass41_.Y5nSL84jZsO = stepId;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass41_.DwVSLEWi5wR, _003C_003Ec__DisplayClass41_.Lb9SLPfwqPi, _003C_003Ec__DisplayClass41_.bgXSLy03G57, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass41_.hWmSLCeeIKS, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "重复" + XActionHelper.GetParamDisplayString(rgPtz3LcZGf, step) + "次，循环间隔: " + XActionHelper.GetParamDisplayString(uCHgwwkj3Dc, step) + "ms，中止条件: " + XActionHelper.GetParamDisplayString(YEmtzzyw3n1, step);
	}

	static RepeatStepRunner()
	{
		rgPtz3LcZGf = new StepInParamDef
		{
			Key = "count",
			DefaultValue = 1,
			Description = "重复次数，除非符合条件提前中止。-1表示无限循环。",
			IsRequired = false,
			Name = "次数",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		hKwtzfMSCUS = new StepInParamDef
		{
			Key = "startIndex",
			Name = "计数开始值",
			DefaultValue = 0,
			Description = "计数序号的开始值，通常应该为0。",
			IsRequired = false,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		YEmtzzyw3n1 = new StepInParamDef
		{
			Key = "stopCondition",
			DefaultValue = null,
			Name = "中止条件",
			Description = "选填。条件满足时停止循环（每次循环开始时检查）。",
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.BoolExpressionHelper }
		};
		uCHgwwkj3Dc = new StepInParamDef
		{
			Key = "repeatDelayMs",
			Name = "循环间隔时间",
			DefaultValue = 1,
			Description = "每次循环之间的间隔毫秒数。如果为0，请确保循环内部有其他等待步骤，避免连续循环占用较多资源。",
			IsRequired = false,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Hexgwt9Yi7i = new StepInParamDef
		{
			Key = "progressBarTitle",
			Name = "进度条标题",
			DefaultValue = null,
			Description = "如果设置了此参数，则在循环过程中会显示一个进度条，标题为此参数的值。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		HTYgwLfZRvJ = new StepOutParamDef
		{
			Key = "count",
			Name = "计数",
			Description = "计数序号，表示第几次循环。",
			Type = VarType.Integer
		};
	}

	internal static bool H51pH6Q8GfoxRZIvTnCx()
	{
		return PRecUDQ8EkfbT93qgtkg == null;
	}
}
