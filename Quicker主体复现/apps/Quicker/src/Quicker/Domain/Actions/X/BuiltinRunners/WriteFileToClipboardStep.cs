using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class WriteFileToClipboardStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionStep SguvfMCOwAE;

		public ActionExecuteContext lEWvfASKgcm;

		private static _003C_003Ec__DisplayClass39_0 TbPM73W3bwp8sVLLWdqH;

		internal (bool isSuccess, string message, ActionStopFlag failReason) eXMvfTQKYrc()
		{
			AppState.LogQuickerPaste();
			string textParamValue = XActionHelper.GetTextParamValue(dbOtFLUaG12, SguvfMCOwAE, lEWvfASKgcm);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(QiStFStPK5K, SguvfMCOwAE, lEWvfASKgcm);
			if (!string.IsNullOrWhiteSpace(textParamValue))
			{
				lEWvfASKgcm.ActionLogger?.LogInfo("写入单个文件");
				if (!System.IO.File.Exists(textParamValue) && !Directory.Exists(textParamValue))
				{
					return (isSuccess: false, message: "路径不存在！", failReason: ActionStopFlag.OperationFailed);
				}
				if (!ClipboardHelper.SetFile(textParamValue, booleanParamValue))
				{
					return (isSuccess: false, message: CommonStrings.WriteFileToClipboardStep_Execute_FailedToWriteClipboard, failReason: ActionStopFlag.OperationFailed);
				}
			}
			else
			{
				lEWvfASKgcm.ActionLogger?.LogInfo("写入多个文件");
				object paramValue = XActionHelper.GetParamValue(eqBtFvTxReL, SguvfMCOwAE, lEWvfASKgcm);
				if (paramValue == null)
				{
					return (isSuccess: false, message: "没有指定要写入剪贴板的文件和文件列表。", failReason: ActionStopFlag.OperationFailed);
				}
				if (!(paramValue is IList<string> fileList))
				{
					return (isSuccess: false, message: "没有指定要写入剪贴板的文件和文件列表。(传入的参数不是文件列表）", failReason: ActionStopFlag.OperationFailed);
				}
				if (!ClipboardHelper.SetFile(fileList, booleanParamValue))
				{
					return (isSuccess: false, message: CommonStrings.WriteFileToClipboardStep_Execute_Err_FailedToWriteFileList, failReason: ActionStopFlag.OperationFailed);
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool e6nw8gW3qfs5twffGP9M()
		{
			return TbPM73W3bwp8sVLLWdqH == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> QT2tOfmLVt9 = new string[6] { "剪贴板", "文件", "Files", "clipboard", "复制", "copy" };

	[CompilerGenerated]
	private readonly string X6ytOzZFWZU = $"fa:{EFontAwesomeIcon.Light_NotesMedical}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> inGtFw2tZvP = new StepRunnerCategory[1] { StepRunnerCategory.Files };

	[CompilerGenerated]
	private readonly string I3ItFtPSrWx = "https://getquicker.net/KC/Help/Doc/filetoclipboard";

	[CompilerGenerated]
	private readonly bool AXMtFgcncKF;

	private static readonly StepInParamDef dbOtFLUaG12;

	private static readonly StepInParamDef eqBtFvTxReL;

	private static readonly StepInParamDef QiStFStPK5K;

	private static readonly StepInParamDef s9UtF2RHDj0;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> eHbtFua4Uee = new StepInParamDef[4] { dbOtFLUaG12, eqBtFvTxReL, QiStFStPK5K, s9UtF2RHDj0 };

	private static readonly StepOutParamDef ujCtFNoy0ZJ;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> NiJtFJQgtqn = new List<StepOutParamDef> { ujCtFNoy0ZJ };

	private static WriteFileToClipboardStep ioJ1x4QZcqsC2nw2oxGC;

	public string Key => "sys:fileToClipboard";

	public string Name => CommonStrings.WriteFileToClipboardStep_Name;

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return QT2tOfmLVt9;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return X6ytOzZFWZU;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Clipboard;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return inGtFw2tZvP;
		}
	}

	public string Description => CommonStrings.WriteFileToClipboardStep_Description;

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return I3ItFtPSrWx;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return AXMtFgcncKF;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return eHbtFua4Uee;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return NiJtFJQgtqn;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.SguvfMCOwAE = step;
		_003C_003Ec__DisplayClass39_.lEWvfASKgcm = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.lEWvfASKgcm, _003C_003Ec__DisplayClass39_.SguvfMCOwAE, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.eXMvfTQKYrc, (Action)null, (Action)null, s9UtF2RHDj0, ujCtFNoy0ZJ);
	}

	private static void StopAction(ActionExecuteContext context, string warningMsg)
	{
		AppHelper.ShowWarning(warningMsg);
		context.StopAction(ActionStopFlag.OperationFailed, "");
	}

	public string GetSummary(ActionStep step)
	{
		return string.Format(CultureInfo.InvariantCulture, CommonStrings.WriteFileToClipboardStep_GetSummary_Format, XActionHelper.GetParamDisplayString(dbOtFLUaG12, step), XActionHelper.GetParamDisplayString(eqBtFvTxReL, step));
	}

	static WriteFileToClipboardStep()
	{
		dbOtFLUaG12 = new StepInParamDef
		{
			Key = "file",
			Name = CommonStrings.WriteFileToClipboardStep_FileParam_Name,
			Description = CommonStrings.WriteFileToClipboardStep_FileParam_Desc,
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		eqBtFvTxReL = new StepInParamDef
		{
			Key = "list",
			Name = CommonStrings.WriteFileToClipboardStep_FileListParam_Name,
			Description = CommonStrings.WriteFileToClipboardStep_FileListParam_Desc,
			Type = VarType.List,
			IsRequired = false,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		QiStFStPK5K = new StepInParamDef
		{
			Key = "useCut",
			Name = "剪切文件",
			Description = "是否剪切文件",
			Type = VarType.Boolean,
			IsRequired = false,
			DefaultValue = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		s9UtF2RHDj0 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ujCtFNoy0ZJ = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool q5p1NZQZWS71Zug4hjBX()
	{
		return ioJ1x4QZcqsC2nw2oxGC == null;
	}
}
