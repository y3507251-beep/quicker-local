using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class SelectFileInExplorerStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public ActionStep bwxSgv9TLvx;

		public ActionExecuteContext LlsSgSlomT2;

		private static _003C_003Ec__DisplayClass38_0 uoil68WGKs876sRbfGCi;

		internal (bool isSuccess, string message, ActionStopFlag failReason) y7ISgLdlHgh()
		{
			string textParamValue = XActionHelper.GetTextParamValue(MVkt3SwGlXc, bwxSgv9TLvx, LlsSgSlomT2);
			textParamValue = PathHelper.RemoveZeroWidthChar(textParamValue);
			if (!System.IO.File.Exists(textParamValue) && !Directory.Exists(textParamValue))
			{
				string item = "文件不存在：" + textParamValue;
				return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
			}
			if (string.IsNullOrEmpty(AppState.HHxtaMaoqJr().CustomSelectInExplorerCommand) && (AppState.HHxtaMaoqJr().DefaultExplorerSoftware == ExplorerSoftware.Na || AppState.HHxtaMaoqJr().DefaultExplorerSoftware == ExplorerSoftware.WindowsExplorer))
			{
				if (textParamValue.Contains("\n") && textParamValue.SplitToList().Length > 1)
				{
					string[] array = textParamValue.SplitToList();
					NativeMethods.OpenFolderAndSelectItems(Path.GetDirectoryName(array[0]), array);
				}
				else
				{
					NativeMethods.OpenFolderAndSelectItem(Path.GetDirectoryName(textParamValue), Path.GetFileName(textParamValue));
				}
			}
			else
			{
				AppHelper.SelectFileInExplorer(textParamValue, true);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool MVUHD3WGBxAuQ4p7E0B9()
		{
			return uoil68WGKs876sRbfGCi == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> Utpt3wM1tDO;

	[CompilerGenerated]
	private readonly string j8Xt3tcvKd5 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> xEot3gvqxDL;

	[CompilerGenerated]
	private readonly string Hy9t3LFa5MR = "https://getquicker.net/KC/Help/Doc/selectfileinexplorer";

	[CompilerGenerated]
	private readonly bool B8mt3veVCKe;

	private static readonly StepInParamDef MVkt3SwGlXc;

	private static readonly StepInParamDef ov2t32KxvGO;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> xUht3uhxFok = new StepInParamDef[2] { MVkt3SwGlXc, ov2t32KxvGO };

	private static readonly StepOutParamDef QEtt3NUWrXe;

	[CompilerGenerated]
	private IList<StepOutParamDef> BcKt3JW5sVu = new List<StepOutParamDef> { QEtt3NUWrXe };

	internal static SelectFileInExplorerStep ikllpsQ5P22LONg7IgyW;

	public string Key => "sys:SelectFileInExplorer";

	public string Name => "在资源管理器中定位文件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return Utpt3wM1tDO;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return j8Xt3tcvKd5;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return xEot3gvqxDL;
		}
	}

	public string Description => "在资源管理器中选中文件";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return Hy9t3LFa5MR;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return B8mt3veVCKe;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return xUht3uhxFok;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return BcKt3JW5sVu;
		}
		[CompilerGenerated]
		set
		{
			BcKt3JW5sVu = value;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		_003C_003Ec__DisplayClass38_.bwxSgv9TLvx = step;
		_003C_003Ec__DisplayClass38_.LlsSgSlomT2 = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass38_.LlsSgSlomT2, _003C_003Ec__DisplayClass38_.bwxSgv9TLvx, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass38_.y7ISgLdlHgh, (Action)null, (Action)null, ov2t32KxvGO, QEtt3NUWrXe);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(MVkt3SwGlXc, step) ?? "";
	}

	static SelectFileInExplorerStep()
	{
		MVkt3SwGlXc = new StepInParamDef
		{
			Key = "path",
			Name = "路径",
			Description = "要定位的文件完整路径。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		ov2t32KxvGO = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		QEtt3NUWrXe = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool yCYa0MQ5Mjd6EgL3gpk6()
	{
		return ikllpsQ5P22LONg7IgyW == null;
	}

	internal static void mke4WgQ5xgLU7RkpmaLj()
	{
	}
}
