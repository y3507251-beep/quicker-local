using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetClipboardImageStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public ActionStep smKSgRGv2we;

		public ActionExecuteContext NZpSgqL5K0X;

		public XAction Ar9SgcGf9T9;

		private static _003C_003Ec__DisplayClass38_0 ypxRE0WGN2maUENGcmtt;

		internal (bool isSuccess, string message, ActionStopFlag failReason) QRoSg7ZqNEr()
		{
			XActionHelper.OutputResult(jAft3GUNbxc, smKSgRGv2we, NZpSgqL5K0X, AppHelper.fLiLTj0x4QY() - AppState.LastClipboardChangeTime, Ar9SgcGf9T9);
			Bitmap imageFromClipboard = ImageClipboardHelper.GetImageFromClipboard();
			if (imageFromClipboard == null)
			{
				return (isSuccess: false, message: CommonStrings.GetClipboardImageStep_Execute_Err_NoData, failReason: ActionStopFlag.OperationFailed);
			}
			XActionHelper.OutputResult(e7kt3W1OJh8, smKSgRGv2we, NZpSgqL5K0X, imageFromClipboard, Ar9SgcGf9T9);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		static _003C_003Ec__DisplayClass38_0()
		{
		}

		internal static bool n2sWEiWG9YJUuROMB3nU()
		{
			return ypxRE0WGN2maUENGcmtt == null;
		}

		internal static void FTbXFBWGujUCOvqI3Vt1()
		{
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> oadt3Vpm3DV = new string[4] { "剪贴板", "图片", "Image", "clipboard" };

	[CompilerGenerated]
	private readonly string bUUt3ZTfonn = $"fa:{EFontAwesomeIcon.Light_Clipboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> lYrt392uMhF = new StepRunnerCategory[1] { StepRunnerCategory.Image };

	[CompilerGenerated]
	private readonly string qpKt3hAe3UN = "https://getquicker.net/KC/Help/Doc/getclipboardimage";

	[CompilerGenerated]
	private readonly bool hXCt3eOnvGS;

	private static readonly StepInParamDef yhdt3Y0tWXX;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> cTXt3I3hA8Q = new StepInParamDef[1] { yhdt3Y0tWXX };

	private static readonly StepOutParamDef e7kt3W1OJh8;

	private static readonly StepOutParamDef Ewdt3knMTmY;

	private static readonly StepOutParamDef jAft3GUNbxc;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> cDFt3smI4lG = new StepOutParamDef[3] { Ewdt3knMTmY, e7kt3W1OJh8, jAft3GUNbxc };

	internal static GetClipboardImageStep ktyHkvQ5wFHuDJGPLXF1;

	public string Key => "sys:getClipboardImage";

	public string Name => CommonStrings.GetClipboardImageStep_Name;

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return oadt3Vpm3DV;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return bUUt3ZTfonn;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Clipboard;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return lYrt392uMhF;
		}
	}

	public string Description => CommonStrings.GetClipboardImageStep_Description;

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return qpKt3hAe3UN;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return hXCt3eOnvGS;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return cTXt3I3hA8Q;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return cDFt3smI4lG;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		_003C_003Ec__DisplayClass38_.smKSgRGv2we = step;
		_003C_003Ec__DisplayClass38_.NZpSgqL5K0X = context;
		_003C_003Ec__DisplayClass38_.Ar9SgcGf9T9 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass38_.NZpSgqL5K0X, _003C_003Ec__DisplayClass38_.smKSgRGv2we, _003C_003Ec__DisplayClass38_.Ar9SgcGf9T9, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass38_.QRoSg7ZqNEr, (Action)null, (Action)null, yhdt3Y0tWXX, Ewdt3knMTmY);
	}

	public string GetSummary(ActionStep step)
	{
		return "=> " + XActionHelper.GetOutputParamDisplayString(e7kt3W1OJh8, step);
	}

	static GetClipboardImageStep()
	{
		yhdt3Y0tWXX = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = CommonStrings.GetClipboardImageStep__stopIfEmptyParam,
			DefaultValue = true,
			Description = CommonStrings.GetClipboardImageStep__stopIfEmptyParam_Desc,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		e7kt3W1OJh8 = new StepOutParamDef
		{
			Key = "output",
			Name = CommonStrings.GetClipboardImageStep__outputParam_img,
			Description = CommonStrings.GetClipboardImageStep__outputParam_img_desc,
			Type = VarType.Image
		};
		Ewdt3knMTmY = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = CommonStrings.GetClipboardImageStep__successParam,
			Description = CommonStrings.GetClipboardImageStep__successParam_desc,
			Type = VarType.Boolean
		};
		jAft3GUNbxc = new StepOutParamDef
		{
			Key = "elapsedMs",
			Name = "已更新时间",
			Description = "剪贴板最后更新是在多少毫秒以前",
			Type = VarType.Integer
		};
	}

	internal static bool ipRUj2Q5TWMgBkx3x3lK()
	{
		return ktyHkvQ5wFHuDJGPLXF1 == null;
	}
}
