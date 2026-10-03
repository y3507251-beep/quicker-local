using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using AutoIt;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.Debugging;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using UIAutoHelper;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Sys;

public class UiAutomationStep : IStepRunner, IStepRunningInfo
{
	public enum AutoCreateDirMode
	{
		No,
		Auto,
		AsFilePath,
		AsFolderPath
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec IEGSZCCMOA8;

		public static Func<char, bool> eAMSZPUUFuL;

		public static Func<string, bool> dBUSZEAcEDF;

		internal static _003C_003Ec ak11CmWNLHUstujxuAWn;

		static _003C_003Ec()
		{
			IEGSZCCMOA8 = new _003C_003Ec();
		}

		internal bool CuESZJDcbaB(char x)
		{
			return x == '"';
		}

		internal bool sRKSZ0dJ1yK(string x)
		{
			return x.IndexOf(':') >= 0;
		}

		internal static bool f0j7rDWNu9emPcxJxshD()
		{
			return ak11CmWNLHUstujxuAWn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass69_0
	{
		public ActionStep i7fSZ8dr1Mx;

		public ActionExecuteContext JEiSZagVCWq;

		public UiAutomationStep Ll6SZ7rjUb0;

		public XAction fiuSZRKFB0y;

		private static _003C_003Ec__DisplayClass69_0 fWniVnWNfA0BjCK38OnI;

		internal (bool isSuccess, string message, ActionStopFlag failReason) RrYSZyaLDRH()
		{
			string textParamValue = XActionHelper.GetTextParamValue(Nn2gV5Pdqlk, i7fSZ8dr1Mx, JEiSZagVCWq);
			return textParamValue switch
			{
				"GetFocusedControlInfo" => Ll6SZ7rjUb0.GetFocusedControlInfo(JEiSZagVCWq, i7fSZ8dr1Mx, fiuSZRKFB0y), 
				"UpdateSaveAsDialogPath" => Ll6SZ7rjUb0.UpdateSaveAsDialogPath(JEiSZagVCWq, i7fSZ8dr1Mx, fiuSZRKFB0y), 
				"GetControlInfoByPosition" => Ll6SZ7rjUb0.pddgVbes6lo(JEiSZagVCWq, i7fSZ8dr1Mx, fiuSZRKFB0y), 
				"GetCursorPointControlInfo" => Ll6SZ7rjUb0.GetCursorPointControlInfo(JEiSZagVCWq, i7fSZ8dr1Mx, fiuSZRKFB0y), 
				"TriggerControl" => Ll6SZ7rjUb0.TriggerControl(JEiSZagVCWq, i7fSZ8dr1Mx), 
				"GetControlInfo" => Ll6SZ7rjUb0.GetControlInfo(JEiSZagVCWq, i7fSZ8dr1Mx, fiuSZRKFB0y), 
				"TriggerMenu" => Ll6SZ7rjUb0.TriggerMenu(JEiSZagVCWq, i7fSZ8dr1Mx), 
				_ => (isSuccess: false, message: "不支持的操作类型" + textParamValue + "，请升级Quicker版本。", failReason: ActionStopFlag.OperationFailed), 
			};
		}

		static _003C_003Ec__DisplayClass69_0()
		{
		}

		internal static bool odywTVWNbBh0J0vgISml()
		{
			return fWniVnWNfA0BjCK38OnI == null;
		}

		internal static void O93NKgWNi5PVfNM4pu9U()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass74_0
	{
		public string wuZSZcluMOb;

		public IActionLogger eN0SZVITWZk;

		public AutoCreateDirMode YBKSZZvG0Ae;

		private static _003C_003Ec__DisplayClass74_0 jECbjMWNlU4mK3AoYeZj;

		internal void BmhSZqi7nrO()
		{
			z8vgVmK9kAJ(wuZSZcluMOb, eN0SZVITWZk, YBKSZZvG0Ae);
		}

		internal static bool dauRSnWNZ8EFC8dCUYCR()
		{
			return jECbjMWNlU4mK3AoYeZj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass79_0
	{
		public AutomationElement PhGSZIOLGTI;

		private static _003C_003Ec__DisplayClass79_0 kyYjveWNYQlZlu8tCZIc;

		internal object xpnSZ9ci9kd()
		{
			return AutomationHelper.GetControlText(PhGSZIOLGTI);
		}

		internal object KDTSZhiCgbC()
		{
			return PhGSZIOLGTI.Current.IsEnabled;
		}

		internal object U77SZegMwvm()
		{
			return !PhGSZIOLGTI.Current.IsOffscreen;
		}

		internal object BHqSZYkDtUf()
		{
			return PhGSZIOLGTI.Current.NativeWindowHandle;
		}

		static _003C_003Ec__DisplayClass79_0()
		{
		}

		internal static bool L4EySoWN8eCpFMJlmj46()
		{
			return kyYjveWNYQlZlu8tCZIc == null;
		}

		internal static void SKfFfqWNPIyQQCw958q8()
		{
		}
	}

	private static readonly ILog jwbgVpkfAHi;

	[CompilerGenerated]
	private readonly IEnumerable<string> kMUgVBocb5h = new List<string> { "Window", "control", "button", "点击", "dianji", "菜单", "caidan" };

	[CompilerGenerated]
	private readonly string RRygVQrTDmh = $"fa:{EFontAwesomeIcon.Light_Window}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory SktgVjmDjUf = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> bAigVnuPQE0;

	[CompilerGenerated]
	private readonly string aYCgV4g0Uop = "https://getquicker.net/KC/Help/Doc/uiautomation";

	private static readonly StepInParamDef Nn2gV5Pdqlk;

	private static readonly StepInParamDef HbGgVDAlIu8;

	private static readonly StepInParamDef VVZgVdITaAR;

	private static readonly StepInParamDef QROgVoeytnU;

	private static readonly StepInParamDef FmFgVTvAemt;

	private static readonly StepInParamDef zPJgVMff2Sb;

	private static readonly StepInParamDef IlugVAkAvfF;

	private static readonly StepInParamDef behgVOxAQcv;

	private static readonly StepInParamDef v0TgVFY1o9A;

	private static readonly StepInParamDef uETgVUA2fNQ;

	private static readonly StepInParamDef G6mgVlIdSlw;

	private static readonly StepInParamDef jKCgVi5NRfQ;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> j1DgV3PgS52 = new List<StepInParamDef>
	{
		Nn2gV5Pdqlk, HbGgVDAlIu8, VVZgVdITaAR, FmFgVTvAemt, zPJgVMff2Sb, IlugVAkAvfF, behgVOxAQcv, v0TgVFY1o9A, uETgVUA2fNQ, G6mgVlIdSlw,
		QROgVoeytnU, jKCgVi5NRfQ
	};

	public static readonly StepOutParamDef ValueOutputParam;

	public static readonly StepOutParamDef CtrlTextParam;

	public static readonly StepOutParamDef RectOutputParam;

	public static readonly StepOutParamDef CtrlNameParam;

	public static readonly StepOutParamDef CtrlTypeParam;

	private static readonly StepOutParamDef WfdgVfvNNmq;

	private static readonly StepOutParamDef Pi3gVzW6P5F;

	private static readonly StepOutParamDef CGLgZw8dr6l;

	private static readonly StepOutParamDef kG3gZtuAoNY;

	private static readonly StepOutParamDef dQHgZgVyqCP;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> DpQgZLU4LXO = new List<StepOutParamDef> { dQHgZgVyqCP, ValueOutputParam, CtrlTextParam, RectOutputParam, CtrlNameParam, CtrlTypeParam, Pi3gVzW6P5F, CGLgZw8dr6l, kG3gZtuAoNY, WfdgVfvNNmq };

	private static UiAutomationStep fjQg1FQt7NlNY2jgfeFA;

	public string Key => "sys:uiautomation";

	public string Name => "窗口界面控制";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return kMUgVBocb5h;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return RRygVQrTDmh;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return SktgVjmDjUf;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return bAigVnuPQE0;
		}
	}

	public string Description => "触发Windows窗口的菜单/按钮等控件。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return aYCgV4g0Uop;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return j1DgV3PgS52;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return DpQgZLU4LXO;
		}
	}

	static UiAutomationStep()
	{
		jwbgVpkfAHi = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		Nn2gV5Pdqlk = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "操作类型。按下和抬起需要配对使用。",
			Type = VarType.Enum,
			DefaultValue = "TriggerMenu",
			SelectionItems = new SelectionItem[7]
			{
				new SelectionItem("TriggerMenu", "触发窗口菜单"),
				new SelectionItem("TriggerControl", "触发窗口控件"),
				new SelectionItem("GetControlInfo", "获取窗口控件信息"),
				new SelectionItem("GetCursorPointControlInfo", "获取鼠标指针位置控件信息"),
				new SelectionItem("GetFocusedControlInfo", "获取焦点控件信息"),
				new SelectionItem("GetControlInfoByPosition", "获取指定位置控件信息"),
				new SelectionItem("UpdateSaveAsDialogPath", "更新\"另存为\"或\"打开\"对话框的路径")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		HbGgVDAlIu8 = new StepInParamDef
		{
			Key = "window",
			Name = "窗口句柄",
			Description = "要操作哪个窗口的控件。不填写=使用前台窗口；或窗口句柄数字。",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[3] { "TriggerMenu", "TriggerControl", "GetControlInfo" }
		};
		VVZgVdITaAR = new StepInParamDef
		{
			Key = "menuPath",
			Name = "菜单路径",
			Description = "菜单的展开路径。每行写一个级别的菜单名（需完全匹配）",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "TriggerMenu" }
		};
		QROgVoeytnU = new StepInParamDef
		{
			Key = "pointLocation",
			Name = "坐标位置",
			Description = "指定要检查的控件的屏幕坐标位置，格式为“x,y”",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "GetControlInfoByPosition" },
			TextTools = new TextToolType[1] { TextToolType.SelectLocationPoint }
		};
		FmFgVTvAemt = new StepInParamDef
		{
			Key = "expandDelay",
			Name = "展开延时",
			Description = "等待下级菜单展开的时间(ms)",
			Type = VarType.Integer,
			DefaultValue = 200,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "TriggerMenu" }
		};
		zPJgVMff2Sb = new StepInParamDef
		{
			Key = "control",
			Name = "控件名",
			Description = "控件名，请确保唯一性。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "TriggerControl", "GetControlInfo" }
		};
		IlugVAkAvfF = new StepInParamDef
		{
			Key = "controlType",
			Name = "控件类型",
			Description = "可选。当有多个名称相同但类型不同的控件时区分。",
			Type = VarType.Enum,
			DefaultValue = "0",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "TriggerControl", "GetControlInfo" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("0", "*任意类型*")
			}
		};
		behgVOxAQcv = new StepInParamDef
		{
			Key = "controlOperation",
			Name = "动作",
			Description = "对控件执行的操作。",
			Type = VarType.Enum,
			DefaultValue = "Auto",
			SelectionItems = new SelectionItem[17]
			{
				new SelectionItem("Auto", "自动"),
				new SelectionItem("Invoke", "调用（按钮、菜单项等）"),
				new SelectionItem("LeftClick", "鼠标左键单击"),
				new SelectionItem("MiddleClick", "鼠标中键单击"),
				new SelectionItem("RightClick", "鼠标右键单击"),
				new SelectionItem("LeftDoubleClick", "鼠标左键双击"),
				new SelectionItem("Select", "单选：选择（单选框、标签页等）"),
				new SelectionItem("AddToSelection", "多选：添加到多选（多选列表等）"),
				new SelectionItem("RemoveFromSelection", "多选：从多选中移除（多选列表）"),
				new SelectionItem("ToggleItemSelection", "多选：切换选中状态"),
				new SelectionItem("Expand", "展开折叠：展开（菜单等）"),
				new SelectionItem("Collapse", "展开折叠：折叠（菜单等）"),
				new SelectionItem("ToggleExpandCollapse", "展开折叠：切换展开折叠（菜单等）"),
				new SelectionItem("Toggle", "切换：切换（检查框等）"),
				new SelectionItem("ToggleOn", "切换：开（检查框等）"),
				new SelectionItem("ToggleOff", "切换：关（检查框等）"),
				new SelectionItem("SetValue", "设置值")
			},
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "TriggerControl" }
		};
		v0TgVFY1o9A = new StepInParamDef
		{
			Key = "value",
			Name = "值",
			Description = "仅用于 “设置值” 操作。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "TriggerControl" }
		};
		uETgVUA2fNQ = new StepInParamDef
		{
			Key = "path",
			Name = "路径",
			Description = "要更新的路径",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "UpdateSaveAsDialogPath" }
		};
		G6mgVlIdSlw = new StepInParamDef
		{
			Key = "autoCreateDir",
			Name = "自动创建文件夹",
			Description = "如果目录不存在则自动创建。",
			Type = VarType.Enum,
			DefaultValue = "no",
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "UpdateSaveAsDialogPath" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("no", "不自动创建"),
				new SelectionItem("auto", "自动创建：自动（根据后缀自动判断路径为文件还是文件夹路径）"),
				new SelectionItem("asFilePath", "自动创建：给定文件路径"),
				new SelectionItem("asFolderPath", "自动创建：给定文件夹路径")
			}
		};
		jKCgVi5NRfQ = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ValueOutputParam = new StepOutParamDef
		{
			Key = "value",
			Name = "值",
			Description = "控件的值",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		CtrlTextParam = new StepOutParamDef
		{
			Key = "controlText",
			Name = "文本",
			Description = "获取控件上的文本。根据控件不同，可能从Value、Text、Name等信息获取。",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		RectOutputParam = new StepOutParamDef
		{
			Key = "rect",
			Name = "位置",
			Description = "控件坐标位置",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		CtrlNameParam = new StepOutParamDef
		{
			Key = "controlName",
			Name = "控件名称",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		CtrlTypeParam = new StepOutParamDef
		{
			Key = "controlType",
			Name = "控件类型",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		WfdgVfvNNmq = new StepOutParamDef
		{
			Key = "controlTypeId",
			Name = "控件类型ID",
			Description = "",
			Type = VarType.Integer,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		Pi3gVzW6P5F = new StepOutParamDef
		{
			Key = "controlIsEnabled",
			Name = "是否启用",
			Description = "控件未处于禁用状态",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		CGLgZw8dr6l = new StepOutParamDef
		{
			Key = "controlIsVisible",
			Name = "是否可见",
			Description = "控件是否在屏幕上。",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		kG3gZtuAoNY = new StepOutParamDef
		{
			Key = "controlNativeWindowHandle",
			Name = "原始句柄",
			Description = "控件的原始窗口句柄(NativeWindowHandle)",
			Type = VarType.Integer,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		dQHgZgVyqCP = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		foreach (ControlType supportedControlType in AutomationHelper.SupportedControlTypes)
		{
			IlugVAkAvfF.SelectionItems.Add(new SelectionItem(supportedControlType.Id.ToString(), supportedControlType.LocalizedControlType));
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
		_003C_003Ec__DisplayClass69_.i7fSZ8dr1Mx = step;
		_003C_003Ec__DisplayClass69_.JEiSZagVCWq = context;
		_003C_003Ec__DisplayClass69_.Ll6SZ7rjUb0 = this;
		_003C_003Ec__DisplayClass69_.fiuSZRKFB0y = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass69_.JEiSZagVCWq, _003C_003Ec__DisplayClass69_.i7fSZ8dr1Mx, _003C_003Ec__DisplayClass69_.fiuSZRKFB0y, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass69_.RrYSZyaLDRH, (Action)null, (Action)null, jKCgVi5NRfQ, dQHgZgVyqCP);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) pddgVbes6lo(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		System.Drawing.Point point = PointExt.FromValue(XActionHelper.GetTextParamValue(QROgVoeytnU, actionStep_0, actionExecuteContext_0));
		AutomationElement automationElement_ = AutomationElement.FromPoint(new System.Windows.Point(point.X, point.Y));
		return TxTgVKryrBs(actionExecuteContext_0, actionStep_0, xaction_0, automationElement_);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) UpdateSaveAsDialogPath(ActionExecuteContext context, ActionStep step, XAction action)
	{
		string textParamValue = XActionHelper.GetTextParamValue(uETgVUA2fNQ, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(G6mgVlIdSlw, step, context);
		AutoCreateDirMode result = AutoCreateDirMode.No;
		Enum.TryParse<AutoCreateDirMode>(textParamValue2, true, out result);
		z8vgVmK9kAJ(textParamValue, context.ActionLogger, result);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	internal static void arvgV6U35wv(string string_2, AutoCreateDirMode autoCreateDirMode_0)
	{
		string folderPath = string.Empty;
		switch (autoCreateDirMode_0)
		{
		case AutoCreateDirMode.No:
			return;
		case AutoCreateDirMode.Auto:
			folderPath = ((!string.IsNullOrEmpty(Path.GetExtension(string_2))) ? Path.GetDirectoryName(string_2) : string_2);
			break;
		case AutoCreateDirMode.AsFilePath:
			folderPath = Path.GetDirectoryName(string_2);
			break;
		case AutoCreateDirMode.AsFolderPath:
			folderPath = string_2;
			break;
		}
		FileSystemHelper.EnsureFolderExists(folderPath);
	}

	internal static void sW9gVXkNnxW(string string_2, IActionLogger iactionLogger_0 = null, AutoCreateDirMode autoCreateDirMode_0 = AutoCreateDirMode.No)
	{
		_003C_003Ec__DisplayClass74_0 _003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_0();
		_003C_003Ec__DisplayClass74_.wuZSZcluMOb = string_2;
		_003C_003Ec__DisplayClass74_.eN0SZVITWZk = iactionLogger_0;
		_003C_003Ec__DisplayClass74_.YBKSZZvG0Ae = autoCreateDirMode_0;
		if (!DebugHelper.IsOnUiThread())
		{
			z8vgVmK9kAJ(_003C_003Ec__DisplayClass74_.wuZSZcluMOb, _003C_003Ec__DisplayClass74_.eN0SZVITWZk, _003C_003Ec__DisplayClass74_.YBKSZZvG0Ae);
		}
		else
		{
			Task.Run((Action)_003C_003Ec__DisplayClass74_.BmhSZqi7nrO);
		}
	}

	internal static void z8vgVmK9kAJ(string string_2, IActionLogger iactionLogger_0 = null, AutoCreateDirMode autoCreateDirMode_0 = AutoCreateDirMode.No)
	{
		int num = 4;
		IntPtr intPtr;
		string text = default(string);
		Environment.SpecialFolder[] array = default(Environment.SpecialFolder[]);
		int num4 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		while (true)
		{
			intPtr = IntPtr.Zero;
			int num2 = 3;
			if (fjQg1FQt7NlNY2jgfeFA != null)
			{
				goto IL_001f;
			}
			goto IL_0041;
			IL_0041:
			int num3 = string_2.Count(_003C_003Ec.eAMSZPUUFuL ?? (_003C_003Ec.eAMSZPUUFuL = _003C_003Ec.IEGSZCCMOA8.CuESZJDcbaB));
			if (num3 < 4)
			{
				if (num3 == 2)
				{
					string_2 = string_2.Trim('"', ' ', '\r', '\n');
				}
				try
				{
					arvgV6U35wv(string_2, autoCreateDirMode_0);
				}
				catch (Exception ex)
				{
					jwbgVpkfAHi.Warn("自动创建文件夹失败：" + ex.Message);
				}
			}
			IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
			string windowClass = NativeMethods.GetWindowClass(foregroundWindow);
			intPtr = ((!string.Equals("#32770", windowClass)) ? OpenWindowGetter.FindAllWindowsWithClassName("#32770", StringComparison.Ordinal).FirstOrDefault() : foregroundWindow);
			if (intPtr == IntPtr.Zero)
			{
				num2 = 5;
				if (fjQg1FQt7NlNY2jgfeFA == null)
				{
					goto IL_001f;
				}
				goto IL_01dc;
			}
			iactionLogger_0?.LogInfo($"找到窗口，句柄：{intPtr}");
			text = OpenWindowGetter.FindChildWindows(intPtr, "ToolbarWindow32", "", false).Values.FirstOrDefault(_003C_003Ec.dBUSZEAcEDF ?? (_003C_003Ec.dBUSZEAcEDF = _003C_003Ec.IEGSZCCMOA8.sRKSZ0dJ1yK));
			if (!string.IsNullOrEmpty(text))
			{
				if (text.IndexOf(':') >= 0)
				{
					text = text.Substring(text.IndexOf(':') + 1).Trim();
				}
				if (!text.EqualsAny(true, "Downloads", "下载", "下載"))
				{
					array = new Environment.SpecialFolder[5]
					{
						Environment.SpecialFolder.Personal,
						Environment.SpecialFolder.MyPictures,
						Environment.SpecialFolder.MyMusic,
						Environment.SpecialFolder.MyVideos,
						Environment.SpecialFolder.Desktop
					};
					num4 = 0;
					goto IL_01c1;
				}
				text = AppHelper.GetDownloadsPath();
				goto IL_025a;
			}
			goto IL_0284;
			IL_01dc:
			num2 = num;
			goto IL_001f;
			IL_01c1:
			if (num4 < array.Length)
			{
				num2 = 0;
				if (krqxjyQt4Wfl8fBYZn5N())
				{
					goto IL_001f;
				}
				goto IL_01dc;
			}
			goto IL_025a;
			IL_001f:
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 3:
					goto IL_0041;
				case 1:
					goto IL_01c1;
				default:
					goto IL_01e5;
				case 5:
					throw new Exception("未找到另存为窗口");
				case 2:
					goto end_IL_0009;
				}
				break;
				IL_01e5:
				Environment.SpecialFolder folder = array[num4];
				if (text.EqualsAny(true, PathHelper.GetSpecialFolderDisplayName(folder)))
				{
					text = Environment.GetFolderPath(folder);
				}
				num4++;
				num2 = 1;
				if (krqxjyQt4Wfl8fBYZn5N())
				{
					continue;
				}
				goto IL_01dc;
			}
			continue;
			IL_0284:
			intPtr2 = AutoItX.ControlGetHandle(intPtr, "Edit1");
			if (intPtr2 == IntPtr.Zero)
			{
				throw new Exception("未找到控件（文件路径）");
			}
			if (string_2.StartsWith("\""))
			{
				AutoItX.WinActivate(intPtr);
				AutoItX.ControlFocus(intPtr, intPtr2);
				AutoItX.ControlSetText(intPtr, intPtr2, string_2);
				AutoItX.Sleep(50);
				AutoItX.ControlSend(intPtr, intPtr2, "{ENTER}");
				return;
			}
			AutoItX.WinActivate(intPtr);
			AutoItX.ControlFocus(intPtr, intPtr2);
			AutoItX.ControlSetText(intPtr, intPtr2, string_2.Substring(0, string_2.Length - 1));
			AutoItX.ControlSend(intPtr, intPtr2, "{END}" + string_2.Substring(string_2.Length - 1));
			AutoItX.Sleep(50);
			break;
			IL_025a:
			if (string.Equals(text, string_2.Trim('"'), StringComparison.OrdinalIgnoreCase))
			{
				iactionLogger_0?.LogInfo("当前路径和目标路径一致，跳过更新");
				return;
			}
			goto IL_0284;
			continue;
			end_IL_0009:
			break;
		}
		AutoItX.ControlSend(intPtr, intPtr2, "{ENTER}");
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetFocusedControlInfo(ActionExecuteContext context, ActionStep step, XAction action)
	{
		return TxTgVKryrBs(context, step, action, AutomationElement.FocusedElement);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetCursorPointControlInfo(ActionExecuteContext context, ActionStep step, XAction action)
	{
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		AutomationElement automationElement_ = AutomationElement.FromPoint(new System.Windows.Point(mousePosition.X, mousePosition.Y));
		return TxTgVKryrBs(context, step, action, automationElement_);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetControlInfo(ActionExecuteContext context, ActionStep step, XAction action)
	{
		AutomationElement automationElement = OiNgVxadvr4(context, step);
		if (automationElement == null)
		{
			return (isSuccess: false, message: "未找到控件", failReason: ActionStopFlag.OperationFailed);
		}
		return TxTgVKryrBs(context, step, action, automationElement);
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) TxTgVKryrBs(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, AutomationElement automationElement_0)
	{
		_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0();
		_003C_003Ec__DisplayClass79_.PhGSZIOLGTI = automationElement_0;
		XActionHelper.OutputResult(CtrlNameParam, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass79_.PhGSZIOLGTI.Current.Name, xaction_0);
		XActionHelper.OutputResult(CtrlTypeParam, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass79_.PhGSZIOLGTI.Current.LocalizedControlType, xaction_0);
		XActionHelper.OutputResult(WfdgVfvNNmq, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass79_.PhGSZIOLGTI.Current.ControlType.Id, xaction_0);
		if (XActionHelper.IsOutputParamSetted(RectOutputParam.Key, actionStep_0))
		{
			Rect boundingRectangle = _003C_003Ec__DisplayClass79_.PhGSZIOLGTI.Current.BoundingRectangle;
			string result = $"{boundingRectangle.Left},{boundingRectangle.Top},{boundingRectangle.Right},{boundingRectangle.Bottom}";
			XActionHelper.OutputResult(RectOutputParam, actionStep_0, actionExecuteContext_0, result, xaction_0);
		}
		if (XActionHelper.IsOutputParamSetted(ValueOutputParam.Key, actionStep_0))
		{
			string controlValue = AutomationHelper.GetControlValue(_003C_003Ec__DisplayClass79_.PhGSZIOLGTI);
			XActionHelper.OutputResult(ValueOutputParam, actionStep_0, actionExecuteContext_0, controlValue, xaction_0);
		}
		XActionHelper.OutputResultIfNeeded(CtrlTextParam, _003C_003Ec__DisplayClass79_.xpnSZ9ci9kd, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(Pi3gVzW6P5F, _003C_003Ec__DisplayClass79_.KDTSZhiCgbC, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(CGLgZw8dr6l, _003C_003Ec__DisplayClass79_.U77SZegMwvm, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(kG3gZtuAoNY, _003C_003Ec__DisplayClass79_.BHqSZYkDtUf, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) TriggerControl(ActionExecuteContext context, ActionStep step)
	{
		AutomationElement element = OiNgVxadvr4(context, step);
		string textParamValue = XActionHelper.GetTextParamValue(behgVOxAQcv, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(v0TgVFY1o9A, step, context);
		AutomationHelper.TriggerControlOperation(element, textParamValue, textParamValue2);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private AutomationElement OiNgVxadvr4(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0)
	{
		IntPtr intPtr = uR3gVrvP80W(actionExecuteContext_0, actionStep_0);
		AutomationElement.FromHandle(intPtr);
		string textParamValue = XActionHelper.GetTextParamValue(zPJgVMff2Sb, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue))
		{
			throw new InvalidDataException("未指定控件名。");
		}
		int num = Convert.ToInt32(XActionHelper.GetTextParamValue(IlugVAkAvfF, actionStep_0, actionExecuteContext_0));
		ControlType controlType = null;
		if (num > 0)
		{
			controlType = ControlType.LookupById(num);
		}
		AutomationElement automationElement = AutomationHelper.FindWindowControl(intPtr, textParamValue, controlType);
		if (automationElement == null)
		{
			throw new InvalidOperationException("未找到控件：" + textParamValue);
		}
		return automationElement;
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) TriggerMenu(ActionExecuteContext context, ActionStep step)
	{
		AutomationElement windowElement = AutomationElement.FromHandle(uR3gVrvP80W(context, step));
		string[] array = XActionHelper.GetTextParamValue(VVZgVdITaAR, step, context).Split(new string[3] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length < 1)
		{
			return (isSuccess: false, message: "未指定菜单路径", failReason: ActionStopFlag.OperationFailed);
		}
		int expandDelay = (int)XActionHelper.GetIntegerParamValue(FmFgVTvAemt, step, context);
		AutomationHelper.InvokeWindowMenu(windowElement, array, expandDelay);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private IntPtr uR3gVrvP80W(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(HbGgVDAlIu8, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue))
		{
			return NativeMethods.GetForegroundWindow();
		}
		if (!int.TryParse(textParamValue, out var result))
		{
			throw new InvalidDataException("未找到窗口 " + textParamValue + " , 请指定窗口句柄或留空。");
		}
		return (IntPtr)result;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(Nn2gV5Pdqlk, step) + " " + XActionHelper.GetParamDisplayString(zPJgVMff2Sb, step) + " " + XActionHelper.GetParamDisplayString(behgVOxAQcv, step);
	}

	internal static void L5UrDoQtHFp2furD88r5()
	{
	}

	internal static bool krqxjyQt4Wfl8fBYZn5N()
	{
		return fjQg1FQt7NlNY2jgfeFA == null;
	}
}
