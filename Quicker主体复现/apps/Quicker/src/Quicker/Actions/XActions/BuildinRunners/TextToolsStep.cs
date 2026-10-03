using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Actions.XActions.BuildinRunners;

public class TextToolsStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionStep P6DSsFrCn0e;

		public ActionExecuteContext p1cSsUKltDg;

		public XAction iusSslnd2Hv;

		internal static _003C_003Ec__DisplayClass39_0 UsOOA2WqaGhrmCsUFI0p;

		internal (bool isSuccess, string message, ActionStopFlag failReason) LEuSsOqbh48()
		{
			_003C_003Ec__DisplayClass39_1 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_1();
			string textParamValue = XActionHelper.GetTextParamValue(ynUgmLYINgh, P6DSsFrCn0e, p1cSsUKltDg);
			if (!Enum.TryParse<TextToolType>(textParamValue, out var result))
			{
				return (isSuccess: false, message: "不支持的选择器类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			}
			TextToolItem textToolItem = TextToolsProvider.L8Etvx2Bmx1(result);
			if (textToolItem == null)
			{
				return (isSuccess: false, message: "不支持的选择器类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass39_.Uy1SszMYi2M = false;
			_003C_003Ec__DisplayClass39_.ituSHwaU9ia = "";
			string textParamValue2 = XActionHelper.GetTextParamValue(kIRgmvguyC4, P6DSsFrCn0e, p1cSsUKltDg);
			TextToolContext arg = new TextToolContext
			{
				ActionVariables = new List<ActionVariable>(),
				ParentWindow = null,
				ProcessSelectedTextFunc = _003C_003Ec__DisplayClass39_.obySsicuIrc,
				SelectionCanceledFunc = _003C_003Ec__DisplayClass39_.kcaSs3UIj59,
				TextControl = new VirtualTextControl(textParamValue2)
			};
			_003C_003Ec__DisplayClass39_.WloSHtkES6c = textToolItem.CreateToolFunc(arg);
			if (_003C_003Ec__DisplayClass39_.WloSHtkES6c == null)
			{
				return (isSuccess: false, message: "创建选择器失败！", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass39_.WloSHtkES6c.CancellationToken = p1cSsUKltDg.CancellationToken;
			_003C_003Ec__DisplayClass39_.WloSHtkES6c.ForStepUse = true;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass39_.DWkSsfRTiHy);
			while (!_003C_003Ec__DisplayClass39_.Uy1SszMYi2M && !p1cSsUKltDg.IsShouldStopAction())
			{
				CancellationToken? cancellationToken = p1cSsUKltDg.CancellationToken;
				if (cancellationToken.HasValue && cancellationToken.GetValueOrDefault().IsCancellationRequested)
				{
					break;
				}
				Thread.Sleep(20);
			}
			if (_003C_003Ec__DisplayClass39_.Uy1SszMYi2M && _003C_003Ec__DisplayClass39_.ituSHwaU9ia != null)
			{
				XActionHelper.OutputResult(ResultParam, P6DSsFrCn0e, p1cSsUKltDg, _003C_003Ec__DisplayClass39_.ituSHwaU9ia, iusSslnd2Hv);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return (isSuccess: false, message: "未选择内容", failReason: ActionStopFlag.OperationFailed);
		}

		internal static bool Cuev05WqrDnROVSwWeXI()
		{
			return UsOOA2WqaGhrmCsUFI0p == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_1
	{
		public bool Uy1SszMYi2M;

		public string ituSHwaU9ia;

		public BaseTextTool WloSHtkES6c;

		private static _003C_003Ec__DisplayClass39_1 LIEi3rWq9ldG6168fKaw;

		internal void obySsicuIrc(string text, bool isFullContent)
		{
			Uy1SszMYi2M = true;
			ituSHwaU9ia = text;
		}

		internal void kcaSs3UIj59()
		{
			Uy1SszMYi2M = true;
			ituSHwaU9ia = null;
		}

		internal void DWkSsfRTiHy()
		{
			WloSHtkES6c.OnMouseDown(true);
			WloSHtkES6c.OnMouseUp(null);
		}

		internal static bool w2okE0WqLUhY2HLdXuoT()
		{
			return LIEi3rWq9ldG6168fKaw == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> WsEgXzDrg6U = new string[1] { "文本处理" };

	[CompilerGenerated]
	private readonly string bppgmwhuVOb = $"fa:{EFontAwesomeIcon.Light_MousePointer}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> bbigmtFHIFM;

	[CompilerGenerated]
	private readonly string X0PgmgQFR5u = "https://getquicker.net/KC/Help/Doc/textselecttools";

	private static StepInParamDef ynUgmLYINgh;

	private static StepInParamDef kIRgmvguyC4;

	private static readonly StepInParamDef Ys8gmSPcvpQ;

	private static readonly StepOutParamDef Bpogm2ePfnQ;

	public static readonly StepOutParamDef ResultParam;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> AEGgmuqKfW2 = new List<StepInParamDef> { ynUgmLYINgh, kIRgmvguyC4, Ys8gmSPcvpQ };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> uiegmNXmEaD = new List<StepOutParamDef> { Bpogm2ePfnQ, ResultParam };

	internal static TextToolsStep G0urBoQ7npJKl9PGMUSF;

	public string Key => "sys:textSelectTools";

	public string Name => "辅助选择工具";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return WsEgXzDrg6U;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return bppgmwhuVOb;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return bbigmtFHIFM;
		}
	}

	public string Description => "一些常用的选择内容并获取文本的工具";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return X0PgmgQFR5u;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return AEGgmuqKfW2;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return uiegmNXmEaD;
		}
	}

	static TextToolsStep()
	{
		ynUgmLYINgh = new StepInParamDef
		{
			Key = "operation",
			Name = "选择器",
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>(),
			IsControlField = true
		};
		kIRgmvguyC4 = new StepInParamDef
		{
			Key = "currValue",
			Name = "当前值",
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			Type = VarType.Text,
			ValidForList = new List<string> { "OperationItemEditor" }
		};
		Ys8gmSPcvpQ = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		Bpogm2ePfnQ = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		ResultParam = new StepOutParamDef
		{
			Key = "output",
			Name = "结果文本",
			Description = "选择器的结果",
			Type = VarType.Text
		};
		foreach (TextToolItem item in TextToolsProvider.XJdtvBxU8Ou())
		{
			ynUgmLYINgh.SelectionItems.Add(new SelectionItem(item.ToolType.ToString(), item.Tooltip));
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.P6DSsFrCn0e = step;
		_003C_003Ec__DisplayClass39_.p1cSsUKltDg = context;
		_003C_003Ec__DisplayClass39_.iusSslnd2Hv = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.p1cSsUKltDg, _003C_003Ec__DisplayClass39_.P6DSsFrCn0e, _003C_003Ec__DisplayClass39_.iusSslnd2Hv, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.LEuSsOqbh48, (Action)null, (Action)null, Ys8gmSPcvpQ, Bpogm2ePfnQ);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ynUgmLYINgh, step) + " => " + XActionHelper.GetOutputParamDisplayString(ResultParam, step);
	}

	internal static void y41nVeQ7DYyuyks0NQEc()
	{
	}

	internal static bool DKsYEtQ7eeKbcSfdLyHS()
	{
		return G0urBoQ7npJKl9PGMUSF == null;
	}
}
