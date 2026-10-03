using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Recorder;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class PlayRecordStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public ActionStep NbOS7bLgAbI;

		public ActionExecuteContext JS5S76vpI4O;

		internal static _003C_003Ec__DisplayClass37_0 I8UBNgWkcSOt8hA1PBiQ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) D86S71IpCk9()
		{
			string textParamValue = XActionHelper.GetTextParamValue(xqdgEkUBWFc, NbOS7bLgAbI, JS5S76vpI4O);
			double numberParamValue = XActionHelper.GetNumberParamValue(km7gEGSXP8y, NbOS7bLgAbI, JS5S76vpI4O);
			new RecordPlayer().Play(textParamValue, Convert.ToDouble(numberParamValue), JS5S76vpI4O);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool vAxQy0WkWmd7T9ejp4BH()
		{
			return I8UBNgWkcSOt8hA1PBiQ == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> peVgEhdvcAX = new string[3] { "录制", "record", "播放" };

	[CompilerGenerated]
	private readonly string OLcgEeKZXk7 = $"fa:{EFontAwesomeIcon.Light_PlayCircle}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> rdvgEYlHfsY;

	[CompilerGenerated]
	private readonly string cfSgEImZAJe = "https://getquicker.net/KC/Help/Doc/playrecord";

	[CompilerGenerated]
	private readonly bool yEvgEWAiXSw;

	private static readonly StepInParamDef xqdgEkUBWFc;

	private static readonly StepInParamDef km7gEGSXP8y;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> fGygEsUDBfq = new List<StepInParamDef> { xqdgEkUBWFc, km7gEGSXP8y };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> DEPgEHJKPUD = new List<StepOutParamDef>();

	internal static PlayRecordStep QJZMsPQx0U1nkmVAKsnR;

	public string Key => "sys:playRecords";

	public string Name => "重放键鼠操作";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return peVgEhdvcAX;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return OLcgEeKZXk7;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return rdvgEYlHfsY;
		}
	}

	public string Description => "重放录制好的键鼠操作数据。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return cfSgEImZAJe;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return yEvgEWAiXSw;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return fGygEsUDBfq;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return DEPgEHJKPUD;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.NbOS7bLgAbI = step;
		_003C_003Ec__DisplayClass37_.JS5S76vpI4O = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass37_.JS5S76vpI4O, _003C_003Ec__DisplayClass37_.NbOS7bLgAbI, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass37_.D86S71IpCk9, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	public static ActionStep CreateStep(string recordedData, double speed = 1.5)
	{
		ActionStep actionStep = new ActionStep();
		actionStep.StepRunnerKey = "sys:playRecords";
		actionStep.InputParams = new Dictionary<string, ActionStepParam>();
		actionStep.InputParams[xqdgEkUBWFc.Key] = new ActionStepParam
		{
			Value = recordedData
		};
		actionStep.InputParams[km7gEGSXP8y.Key] = new ActionStepParam
		{
			Value = speed.ToString()
		};
		return actionStep;
	}

	static PlayRecordStep()
	{
		xqdgEkUBWFc = new StepInParamDef
		{
			Key = "data",
			Name = "录制数据",
			Description = "录制的键鼠操作数据",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		km7gEGSXP8y = new StepInParamDef
		{
			Key = "speed",
			Name = "重放速度",
			Description = "重放操作的速度",
			Type = VarType.Number,
			IsRequired = true,
			DefaultValue = 2,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
	}

	internal static bool VfHxMkQx12ypitRjsdEt()
	{
		return QJZMsPQx0U1nkmVAKsnR == null;
	}
}
