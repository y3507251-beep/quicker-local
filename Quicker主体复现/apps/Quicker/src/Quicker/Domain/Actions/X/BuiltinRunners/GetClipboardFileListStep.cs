using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetClipboardFileListStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec QBmSgNLa78Y;

		public static Action ifdSgJ5t9Ik;

		public static Action SlkSg0In1fP;

		internal static _003C_003Ec qvjh4pWGdVU9F21IdYmU;

		static _003C_003Ec()
		{
			QBmSgNLa78Y = new _003C_003Ec();
		}

		internal void iCySg26AhVu()
		{
		}

		internal void ytWSguj6B9c()
		{
		}

		internal static bool SMdOZ5WGOqIqYJkpwxDj()
		{
			return qvjh4pWGdVU9F21IdYmU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public ActionStep lySSgEKbxaO;

		public ActionExecuteContext P0fSgyquZ8V;

		public XAction BoiSg8vDwRk;

		public Action DA5SgalgG96;

		private static _003C_003Ec__DisplayClass38_0 YcFV9EWGk6ukpwi0hNb1;

		internal (bool isSuccess, string message, ActionStopFlag failReason) pEpSgCIjLYW()
		{
			XActionHelper.OutputResult(xeat3qUbVN7, lySSgEKbxaO, P0fSgyquZ8V, AppHelper.fLiLTj0x4QY() - AppState.LastClipboardChangeTime, BoiSg8vDwRk);
			if (!ClipboardHelper.ContainsFileDropList())
			{
				return (isSuccess: false, message: "剪贴板中没有文件", failReason: ActionStopFlag.OperationFailed);
			}
			AppHelper.RunOnUiThread(true, DA5SgalgG96 ?? (DA5SgalgG96 = jZYSgPbTQAR));
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal void jZYSgPbTQAR()
		{
			StringCollection fileDropList = ClipboardHelper.GetFileDropList();
			List<string> list = new List<string>();
			StringEnumerator enumerator = fileDropList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					list.Add(current);
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			XActionHelper.OutputResult(jhOt37tKYvZ, lySSgEKbxaO, P0fSgyquZ8V, list, BoiSg8vDwRk);
		}

		internal static bool K2Ej44WGa3FpT96kp5lm()
		{
			return YcFV9EWGk6ukpwi0hNb1 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> HvIt30c9Ht8 = new string[5] { "剪贴板", "文件", "Files", "clipboard", "复制" };

	[CompilerGenerated]
	private readonly string pWpt3C061dM = $"fa:{EFontAwesomeIcon.Light_ClipboardList}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> nANt3PwPMUl = new StepRunnerCategory[1] { StepRunnerCategory.Files };

	[CompilerGenerated]
	private readonly string AI7t3E5YNNU = "https://getquicker.net/KC/Help/Doc/getclipboardfiles";

	[CompilerGenerated]
	private readonly bool DJOt3ylgZ6X;

	private static readonly StepInParamDef LBpt38BHFDb;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> J4pt3aodCxt = new StepInParamDef[1] { LBpt38BHFDb };

	private static readonly StepOutParamDef jhOt37tKYvZ;

	private static readonly StepOutParamDef sbyt3RqgQkg;

	private static readonly StepOutParamDef xeat3qUbVN7;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> krpt3cAFE9E = new List<StepOutParamDef> { sbyt3RqgQkg, jhOt37tKYvZ, xeat3qUbVN7 };

	private static GetClipboardFileListStep LWcpo1Q56AW6j7261s7M;

	public string Key => "sys:getClipboardFiles";

	public string Name => CommonStrings.GetClipboardFileListStep_Name;

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return HvIt30c9Ht8;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return pWpt3C061dM;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Clipboard;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return nANt3PwPMUl;
		}
	}

	public string Description => CommonStrings.GetClipboardFileListStep_Description;

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return AI7t3E5YNNU;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return DJOt3ylgZ6X;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return J4pt3aodCxt;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return krpt3cAFE9E;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		_003C_003Ec__DisplayClass38_.lySSgEKbxaO = step;
		_003C_003Ec__DisplayClass38_.P0fSgyquZ8V = context;
		_003C_003Ec__DisplayClass38_.BoiSg8vDwRk = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass38_.P0fSgyquZ8V, _003C_003Ec__DisplayClass38_.lySSgEKbxaO, _003C_003Ec__DisplayClass38_.BoiSg8vDwRk, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass38_.pEpSgCIjLYW, _003C_003Ec.ifdSgJ5t9Ik ?? (_003C_003Ec.ifdSgJ5t9Ik = _003C_003Ec.QBmSgNLa78Y.iCySg26AhVu), _003C_003Ec.SlkSg0In1fP ?? (_003C_003Ec.SlkSg0In1fP = _003C_003Ec.QBmSgNLa78Y.ytWSguj6B9c), LBpt38BHFDb, sbyt3RqgQkg);
	}

	public string GetSummary(ActionStep step)
	{
		return "=> " + XActionHelper.GetOutputParamDisplayString(jhOt37tKYvZ, step);
	}

	static GetClipboardFileListStep()
	{
		LBpt38BHFDb = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = CommonStrings.GetClipboardFileListStep__stopIfEmptyParam_Name,
			DefaultValue = true,
			Description = CommonStrings.GetClipboardFileListStep__stopIfEmptyParam_Desc,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		jhOt37tKYvZ = new StepOutParamDef
		{
			Key = "output",
			Name = CommonStrings.GetClipboardFileListStep__outputParam_FileList,
			Description = CommonStrings.GetClipboardFileListStep__outputParam_FileList_Desc,
			Type = VarType.List
		};
		sbyt3RqgQkg = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = CommonStrings.GetClipboardFileListStep__successParam_isSuccess,
			Description = CommonStrings.GetClipboardFileListStep__successParam_isSuccess_Desc,
			Type = VarType.Boolean
		};
		xeat3qUbVN7 = new StepOutParamDef
		{
			Key = "elapsedMs",
			Name = "已更新时间",
			Description = "剪贴板最后更新是在多少毫秒以前",
			Type = VarType.Integer
		};
	}

	internal static bool NiQIj7Q5ttZN3auy8WHg()
	{
		return LWcpo1Q56AW6j7261s7M == null;
	}
}
