using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using FontAwesome5;
using log4net;
using Microsoft.WindowsAPICodePack.Dialogs;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using Quicker.View;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class SelectFolderStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec zO5SVEHE1j7;

		public static Func<string, SimpleOperationItem> J2WSVyeSRqQ;

		internal static _003C_003Ec KkoULYWrI9tc9AqPU0IR;

		static _003C_003Ec()
		{
			zO5SVEHE1j7 = new _003C_003Ec();
		}

		internal SimpleOperationItem PTfSVPJEA1m(string x)
		{
			return new SimpleOperationItem
			{
				Key = x,
				Name = x
			};
		}

		internal static bool d8JISJWr6lauh1bb9DVV()
		{
			return KkoULYWrI9tc9AqPU0IR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public SelectFolderStep sQMSVaVHY8P;

		public ActionStep W0VSV791wMD;

		public ActionExecuteContext mfSSVRBifPU;

		public XAction wEbSVqVtyKb;

		private static _003C_003Ec__DisplayClass40_0 iw4QqkWrSxCl3deIiGts;

		internal (bool isSuccess, string message, ActionStopFlag failReason) uvrSV8HekSG()
		{
			_003C_003Ec__DisplayClass40_1 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_1
			{
				dQDSVe5Iirb = this,
				Q5eSVZfgg0c = null,
				J91SV9iew1Q = XActionHelper.GetTextParamValue(sQMSVaVHY8P.h7ugq5jMMcK, W0VSV791wMD, mfSSVRBifPU),
				LM2SVhJjqBG = XActionHelper.GetTextParamValue(sQMSVaVHY8P.RP9gqD4GBFO, W0VSV791wMD, mfSSVRBifPU),
				RXfSVVIwfUA = XActionHelper.GetBooleanParamValue(sQMSVaVHY8P.rU7gqd0gZGh, W0VSV791wMD, mfSSVRBifPU)
			};
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass40_.L4ESVc3PW5c);
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass40_.Q5eSVZfgg0c))
			{
				XActionHelper.OutputResult(pVBgqMedYOi, W0VSV791wMD, mfSSVRBifPU, _003C_003Ec__DisplayClass40_.Q5eSVZfgg0c, wEbSVqVtyKb);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return (isSuccess: false, message: "已取消操作。", failReason: ActionStopFlag.UserCancel);
		}

		internal static bool FbXdxCWrw5ZZ6vDTtp8W()
		{
			return iw4QqkWrSxCl3deIiGts == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_1
	{
		public bool RXfSVVIwfUA;

		public string Q5eSVZfgg0c;

		public string J91SV9iew1Q;

		public string LM2SVhJjqBG;

		public _003C_003Ec__DisplayClass40_0 dQDSVe5Iirb;

		internal static _003C_003Ec__DisplayClass40_1 D5OXN2WrmRINUqdKXkbB;

		internal void L4ESVc3PW5c()
		{
			IList<string> list = new List<string>();
			if (RXfSVVIwfUA)
			{
				try
				{
					list = NativeMethods.GetAllOpenedFolders();
				}
				catch (Exception ex)
				{
					LdTgqpbeH5x.Warn("获取已打开的文件夹路径出错：" + ex.Message, ex);
					dQDSVe5Iirb.mfSSVRBifPU.ActionLogger.LogWarning("获取已打开的文件夹路径出错：" + ex.Message);
				}
			}
			if (RXfSVVIwfUA)
			{
				if (list.Count != 0)
				{
					List<SimpleOperationItem> list2 = list.Select(_003C_003Ec.J2WSVyeSRqQ ?? (_003C_003Ec.J2WSVyeSRqQ = _003C_003Ec.zO5SVEHE1j7.PTfSVPJEA1m)).ToList();
					list2.Add(new SimpleOperationItem
					{
						Key = "SELECT",
						Name = "选择..."
					});
					SelectOperationWindow selectOperationWindow = new SelectOperationWindow(list2)
					{
						EnableQuickConfirm = true
					};
					selectOperationWindow.Title = J91SV9iew1Q;
					if (selectOperationWindow.ShowDialog() == true)
					{
						if (selectOperationWindow.SelectedItem.Key == "SELECT")
						{
							Q5eSVZfgg0c = SelectFolder(J91SV9iew1Q, LM2SVhJjqBG);
						}
						else
						{
							Q5eSVZfgg0c = selectOperationWindow.SelectedItem.Key;
						}
					}
					return;
				}
				if (D5OXN2WrmRINUqdKXkbB != null)
				{
					switch (0)
					{
					}
				}
			}
			Q5eSVZfgg0c = SelectFolder(J91SV9iew1Q, LM2SVhJjqBG);
		}

		internal static bool ydyD11WrsMDqg40PwXXc()
		{
			return D5OXN2WrmRINUqdKXkbB == null;
		}
	}

	private static readonly ILog LdTgqpbeH5x;

	[CompilerGenerated]
	private readonly IEnumerable<string> sWBgqBcVJPX = new string[2] { "选择目录", "选择路径" };

	[CompilerGenerated]
	private readonly string g45gqQsS9rF = $"fa:{EFontAwesomeIcon.Light_FolderOpen}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> RN8gqjbqfk7;

	[CompilerGenerated]
	private readonly string SdLgqnFNYiu = "https://getquicker.net/KC/Help/Doc/selectfolder";

	[CompilerGenerated]
	private readonly bool iMcgq4bvYtW;

	private readonly StepInParamDef h7ugq5jMMcK = new StepInParamDef
	{
		Key = "prompt",
		Name = "提示文字",
		Description = "选择窗口的标题",
		DefaultValue = "请选择文件夹",
		Type = VarType.Text,
		IsRequired = true,
		VariableMode = ParamVariableMode.Input
	};

	private readonly StepInParamDef RP9gqD4GBFO = new StepInParamDef
	{
		Key = "initDir",
		Name = "初始路径",
		Description = "初始文件夹路径",
		DefaultValue = "",
		Type = VarType.Text,
		IsRequired = false,
		VariableMode = ParamVariableMode.UseVarOrInput
	};

	private readonly StepInParamDef rU7gqd0gZGh = new StepInParamDef
	{
		Key = "showOpenedDirs",
		Name = "显示已打开的文件夹",
		Description = "显示当前在资源管理器窗口中打开的文件夹。",
		DefaultValue = true,
		Type = VarType.Boolean,
		IsRequired = false,
		VariableMode = ParamVariableMode.Input
	};

	private static readonly StepInParamDef c4hgqo33lI5;

	private static readonly StepOutParamDef XN2gqTBvFFG;

	private static readonly StepOutParamDef pVBgqMedYOi;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> jJmgqA26l9o = new StepOutParamDef[2] { XN2gqTBvFFG, pVBgqMedYOi };

	private static SelectFolderStep IieGTXQt2ey5E5rQWy4F;

	public string Key => "sys:selectFolder";

	public string Name => "选择文件夹";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return sWBgqBcVJPX;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return g45gqQsS9rF;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return RN8gqjbqfk7;
		}
	}

	public string Description => "文件夹选择对话框";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return SdLgqnFNYiu;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return iMcgq4bvYtW;
		}
	}

	public IList<StepInParamDef> InputParams => new StepInParamDef[4] { h7ugq5jMMcK, RP9gqD4GBFO, rU7gqd0gZGh, c4hgqo33lI5 };

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return jJmgqA26l9o;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.sQMSVaVHY8P = this;
		_003C_003Ec__DisplayClass40_.W0VSV791wMD = step;
		_003C_003Ec__DisplayClass40_.mfSSVRBifPU = context;
		_003C_003Ec__DisplayClass40_.wEbSVqVtyKb = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass40_.mfSSVRBifPU, _003C_003Ec__DisplayClass40_.W0VSV791wMD, _003C_003Ec__DisplayClass40_.wEbSVqVtyKb, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass40_.uvrSV8HekSG, (Action)null, (Action)null, c4hgqo33lI5, XN2gqTBvFFG);
	}

	public static string SelectFolder(string title, string initDir)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
		commonOpenFileDialog.IsFolderPicker = true;
		commonOpenFileDialog.Title = title;
		if (!string.IsNullOrEmpty(initDir) && Directory.Exists(initDir))
		{
			commonOpenFileDialog.InitialDirectory = initDir;
		}
		if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
		{
			return commonOpenFileDialog.FileName;
		}
		return null;
	}

	public string GetSummary(ActionStep step)
	{
		return "选择文件夹路径";
	}

	static SelectFolderStep()
	{
		LdTgqpbeH5x = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		c4hgqo33lI5 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "取消后停止",
			DefaultValue = true,
			Description = "取消后是否停止动作运行",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		XN2gqTBvFFG = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功选择了路径。",
			Type = VarType.Boolean
		};
		pVBgqMedYOi = new StepOutParamDef
		{
			Key = "path",
			Name = "路径",
			Description = "选择的文件夹路径。",
			Type = VarType.Text
		};
	}

	internal static bool yqY26DQtAZJPM1g1rFPD()
	{
		return IieGTXQt2ey5E5rQWy4F == null;
	}
}
