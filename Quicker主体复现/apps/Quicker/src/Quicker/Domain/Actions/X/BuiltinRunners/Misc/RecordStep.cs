using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Recorder.UI;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class RecordStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ActionStep m7wS7me2q7N;

		public ActionExecuteContext AFIS7K2L5TB;

		public XAction V7iS7xR0dw1;

		private static _003C_003Ec__DisplayClass40_0 UZlCm2Wkpx4k9cnpCZRk;

		internal (bool isSuccess, string message, ActionStopFlag failReason) xMLS7X1xO12()
		{
			_003C_003Ec__DisplayClass40_1 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_1
			{
				OeiS7QjsNll = XActionHelper.GetBooleanParamValue(TJygExGi7sc, m7wS7me2q7N, AFIS7K2L5TB),
				CZOS7jZrNKk = XActionHelper.GetBooleanParamValue(pNDgEpD3PGj, m7wS7me2q7N, AFIS7K2L5TB),
				hHeS7ncUv2L = XActionHelper.GetNumberParamValue(EhugErCs1Cm, m7wS7me2q7N, AFIS7K2L5TB),
				RiDS74FsVhh = false,
				GjWS7BujwLD = null
			};
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass40_.YVaS7rEo5BG);
			while (!_003C_003Ec__DisplayClass40_.RiDS74FsVhh)
			{
				Thread.Sleep(20);
			}
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass40_.GjWS7BujwLD.ResultData))
			{
				XActionHelper.OutputResult(RtigEjyC3Lj, m7wS7me2q7N, AFIS7K2L5TB, _003C_003Ec__DisplayClass40_.GjWS7BujwLD.ResultData, V7iS7xR0dw1);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return (isSuccess: false, message: "取消录制", failReason: ActionStopFlag.UserCancel);
		}

		internal static bool BOp6ysWkXS8IvHxfBs0P()
		{
			return UZlCm2Wkpx4k9cnpCZRk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_1
	{
		public RecorderWindow GjWS7BujwLD;

		public bool OeiS7QjsNll;

		public bool CZOS7jZrNKk;

		public double hHeS7ncUv2L;

		public bool RiDS74FsVhh;

		public EventHandler PKwS75ct4RU;

		internal static _003C_003Ec__DisplayClass40_1 EtyOjEWkA1iSpODbXxSb;

		internal void YVaS7rEo5BG()
		{
			GjWS7BujwLD = new RecorderWindow(true, OeiS7QjsNll, CZOS7jZrNKk, hHeS7ncUv2L);
			GjWS7BujwLD.Closed += PKwS75ct4RU ?? (PKwS75ct4RU = ORfS7pxMRP2);
			GjWS7BujwLD.Show();
		}

		internal void ORfS7pxMRP2(object sender, EventArgs e)
		{
			RiDS74FsVhh = true;
		}

		internal static void AJNMcIWkjZEb8PgObsZp()
		{
		}

		internal static bool okymr0Wknki2cwJ2H9ng()
		{
			return EtyOjEWkA1iSpODbXxSb == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> ri2gE1sE4ch = new string[3] { "播放", "重放", "play" };

	[CompilerGenerated]
	private readonly string LROgEb4gHj0 = $"fa:{EFontAwesomeIcon.Light_Video}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> JfAgE6somkN;

	[CompilerGenerated]
	private readonly string ICpgEXChpnO = "https://getquicker.net/KC/Help/Doc/record";

	[CompilerGenerated]
	private readonly bool kgkgEma8bE6;

	private static readonly StepInParamDef WkegEKcqpnX;

	private static readonly StepInParamDef TJygExGi7sc;

	private static readonly StepInParamDef EhugErCs1Cm;

	private static readonly StepInParamDef pNDgEpD3PGj;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> ggMgEBwoVb4 = new List<StepInParamDef> { TJygExGi7sc, pNDgEpD3PGj, EhugErCs1Cm, WkegEKcqpnX };

	private static readonly StepOutParamDef VoGgEQjL0jQ;

	private static readonly StepOutParamDef RtigEjyC3Lj;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> ophgEn5KuPN = new List<StepOutParamDef> { VoGgEQjL0jQ, RtigEjyC3Lj };

	private static RecordStep WZERNHQxJd6dSoAh0dEs;

	public string Key => "sys:record";

	public string Name => "录制键鼠操作";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return ri2gE1sE4ch;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return LROgEb4gHj0;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return JfAgE6somkN;
		}
	}

	public string Description => "录制键鼠操作过程";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return ICpgEXChpnO;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return kgkgEma8bE6;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return ggMgEBwoVb4;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return ophgEn5KuPN;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.m7wS7me2q7N = step;
		_003C_003Ec__DisplayClass40_.AFIS7K2L5TB = context;
		_003C_003Ec__DisplayClass40_.V7iS7xR0dw1 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass40_.AFIS7K2L5TB, _003C_003Ec__DisplayClass40_.m7wS7me2q7N, _003C_003Ec__DisplayClass40_.V7iS7xR0dw1, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass40_.xMLS7X1xO12, (Action)null, (Action)null, WkegEKcqpnX, VoGgEQjL0jQ);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	static RecordStep()
	{
		WkegEKcqpnX = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		TJygExGi7sc = new StepInParamDef
		{
			Key = "autoStart",
			Name = "自动开始录制",
			DefaultValue = true,
			Description = "2秒后是否自动开始录制",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		EhugErCs1Cm = new StepInParamDef
		{
			Key = "prepareSeconds",
			Name = "准备时间",
			DefaultValue = 2,
			Description = "开始录制前的倒计时秒数（支持小数）",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		pNDgEpD3PGj = new StepInParamDef
		{
			Key = "recordMouseMove",
			Name = "录制鼠标移动过程",
			DefaultValue = true,
			Description = "是否录制鼠标的中间移动过程，仅必要时开启。关闭时仅记录点击位置。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		VoGgEQjL0jQ = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		RtigEjyC3Lj = new StepOutParamDef
		{
			Key = "output",
			Name = "录制数据",
			Description = "录制的结果数据",
			Type = VarType.Text
		};
	}

	internal static bool l8KHoXQxkbRKOBQnEDFN()
	{
		return WZERNHQxJd6dSoAh0dEs == null;
	}
}
