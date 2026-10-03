using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Identifiers;
using FlaUI.UIA3;
using FontAwesome5;
using Interop.UIAutomationClient;
using pxc1Ohfdkf57WBwuHwe;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using UIAutoHelper;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Sys;

public class FlaUiAutomationStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xtTSVApXjcR;

		public static Func<PatternId, string> YjSSVO4qbML;

		private static _003C_003Ec ePCsOvWN3tt3L2f6Xldv;

		static _003C_003Ec()
		{
			xtTSVApXjcR = new _003C_003Ec();
		}

		internal string iBkSVMXUMxN(PatternId x)
		{
			return x.Name;
		}

		internal static bool UF5FolWNEUE4y77C6S1D()
		{
			return ePCsOvWN3tt3L2f6Xldv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass64_0
	{
		public ActionStep HUcSVUs1leW;

		public ActionExecuteContext RSJSVld8iO7;

		public FlaUiAutomationStep Mi5SViqX0ZO;

		public XAction Sq0SV3QrwRP;

		internal static _003C_003Ec__DisplayClass64_0 jdUmFhWN019kpNUe7lhh;

		internal (bool isSuccess, string message, ActionStopFlag failReason) V5BSVFCQikr()
		{
			using UIA3Automation uIA3Automation = new UIA3Automation();
			string textParamValue = XActionHelper.GetTextParamValue(XQ8gVShC0al, HUcSVUs1leW, RSJSVld8iO7);
			return textParamValue switch
			{
				"GetControlInfoByPosition" => Mi5SViqX0ZO.Ynngci9fe3h(RSJSVld8iO7, HUcSVUs1leW, Sq0SV3QrwRP, uIA3Automation), 
				"GetFocusedControlInfo" => Mi5SViqX0ZO.GetFocusedControlInfo(RSJSVld8iO7, HUcSVUs1leW, Sq0SV3QrwRP, uIA3Automation), 
				"GetCursorPointControlInfo" => Mi5SViqX0ZO.GetCursorPointControlInfo(RSJSVld8iO7, HUcSVUs1leW, Sq0SV3QrwRP, uIA3Automation), 
				"GetControlInfo" => Mi5SViqX0ZO.GetControlInfo(RSJSVld8iO7, HUcSVUs1leW, Sq0SV3QrwRP, uIA3Automation), 
				"TriggerControl" => Mi5SViqX0ZO.TriggerControl(RSJSVld8iO7, HUcSVUs1leW, uIA3Automation), 
				"TriggerMenu" => Mi5SViqX0ZO.TriggerMenu(RSJSVld8iO7, HUcSVUs1leW, uIA3Automation), 
				_ => (isSuccess: false, message: "不支持的操作类型" + textParamValue + "，请升级Quicker版本。", failReason: ActionStopFlag.OperationFailed), 
			};
		}

		internal static bool jjeYnMWN1WOnaoLErbEf()
		{
			return jdUmFhWN019kpNUe7lhh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass69_0
	{
		public AutomationElement G0aSZLAdpHa;

		public string xxZSZveDxup;

		private static _003C_003Ec__DisplayClass69_0 rNGxYXWNBU1NF8jlqEkb;

		internal object RyBSVfTboel()
		{
			return AutomationHelper4FlaUI.GetControlText(G0aSZLAdpHa);
		}

		internal object PUKSVz4Mm0n()
		{
			return xxZSZveDxup.gKqLi70dfao();
		}

		internal object XdWSZwhbpFS()
		{
			return G0aSZLAdpHa.IsEnabled;
		}

		internal object Cw8SZtYeVRH()
		{
			return !G0aSZLAdpHa.IsOffscreen;
		}

		internal object gBiSZgOMIZ2()
		{
			return G0aSZLAdpHa;
		}

		internal static void ponDW3WNOa0XuaH7LcTT()
		{
		}

		internal static bool DYDcIhWNvg0oypehb7Gw()
		{
			return rNGxYXWNBU1NF8jlqEkb == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> ajTgVwa8C4o = new List<string> { "Window", "control", "button" };

	[CompilerGenerated]
	private readonly string jHbgVtBo4Fw = $"fa:{EFontAwesomeIcon.Light_Window}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory Bs4gVgUtInq = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ufbgVLVxgkk;

	[CompilerGenerated]
	private readonly string HqNgVvtDMdL = "https://getquicker.net/KC/Help/Doc/uiautomation";

	public const Interop.UIAutomationClient.DockPosition _temp = Interop.UIAutomationClient.DockPosition.DockPosition_Bottom;

	private static readonly StepInParamDef XQ8gVShC0al;

	private static readonly StepInParamDef uiOgV2p3Edh;

	private static readonly StepInParamDef RQOgVupflvk;

	private static readonly StepInParamDef Yk1gVNjoD84;

	private static readonly StepInParamDef Q0SgVJ5Eudn;

	private static readonly StepInParamDef vWHgV0ho1Cn;

	private static readonly StepInParamDef UNNgVCoJpBW;

	private static readonly StepInParamDef AusgVPemQBd;

	private static readonly StepInParamDef P5HgVEGhAid;

	private static readonly StepInParamDef diogVyeybZr;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> uswgV8lnD0q = new List<StepInParamDef> { XQ8gVShC0al, RQOgVupflvk, Yk1gVNjoD84, Q0SgVJ5Eudn, vWHgV0ho1Cn, UNNgVCoJpBW, AusgVPemQBd, P5HgVEGhAid, uiOgV2p3Edh, diogVyeybZr };

	public static readonly StepOutParamDef ValueOutputParam;

	public static readonly StepOutParamDef CtrlTextParam;

	public static readonly StepOutParamDef RectOutputParam;

	public static readonly StepOutParamDef CtrlNameParam;

	public static readonly StepOutParamDef CtrlTypeParam;

	public static readonly StepOutParamDef CtrlXPathParam;

	private static readonly StepOutParamDef WKagVaJRdOM;

	public static readonly StepOutParamDef ControlInfoParam;

	private static readonly StepOutParamDef QdAgV7CZnym;

	private static readonly StepOutParamDef NdwgVR0hxvr;

	public static readonly StepOutParamDef RawElementObjectParam;

	private static readonly StepOutParamDef PmAgVqv1kyv;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> qvGgVc9UDlP = new List<StepOutParamDef>
	{
		PmAgVqv1kyv, ValueOutputParam, CtrlTextParam, RectOutputParam, CtrlNameParam, CtrlTypeParam, CtrlXPathParam, WKagVaJRdOM, ControlInfoParam, QdAgV7CZnym,
		NdwgVR0hxvr, RawElementObjectParam
	};

	internal static FlaUiAutomationStep HgnK2sQtxwH9nC30VtNC;

	public string Key => "sys:flauiautomation";

	public string Name => "窗口界面控制(FlaUI)";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return ajTgVwa8C4o;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return jHbgVtBo4Fw;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return Bs4gVgUtInq;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ufbgVLVxgkk;
		}
	}

	public string Description => "触发Windows窗口的菜单/按钮等控件(通过FlaUI库实现)。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return HqNgVvtDMdL;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return uswgV8lnD0q;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return qvGgVc9UDlP;
		}
	}

	static FlaUiAutomationStep()
	{
		XQ8gVShC0al = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "操作类型。按下和抬起需要配对使用。",
			Type = VarType.Enum,
			DefaultValue = "TriggerMenu",
			SelectionItems = new SelectionItem[6]
			{
				new SelectionItem("TriggerMenu", "触发窗口菜单"),
				new SelectionItem("TriggerControl", "触发窗口控件"),
				new SelectionItem("GetControlInfo", "获取窗口控件信息"),
				new SelectionItem("GetCursorPointControlInfo", "获取鼠标指针位置控件信息"),
				new SelectionItem("GetControlInfoByPosition", "获取指定位置控件信息"),
				new SelectionItem("GetFocusedControlInfo", "获取焦点控件信息")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		uiOgV2p3Edh = new StepInParamDef
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
		RQOgVupflvk = new StepInParamDef
		{
			Key = "window",
			Name = "窗口句柄",
			Description = "要操作哪个窗口的控件。不填写=使用前台窗口；或窗口句柄数字。",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[3] { "TriggerMenu", "TriggerControl", "GetControlInfo" }
		};
		Yk1gVNjoD84 = new StepInParamDef
		{
			Key = "menuPath",
			Name = "菜单路径",
			Description = "菜单的展开路径。每行写一个级别的菜单名（需完全匹配）",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "TriggerMenu" }
		};
		Q0SgVJ5Eudn = new StepInParamDef
		{
			Key = "expandDelay",
			Name = "展开延时",
			Description = "等待下级菜单展开的时间(ms)",
			Type = VarType.Integer,
			DefaultValue = 200,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "TriggerMenu" }
		};
		vWHgV0ho1Cn = new StepInParamDef
		{
			Key = "control",
			Name = "控件XPath或Name",
			Description = "控件的XPath或Name。XPath以/开始。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "TriggerControl", "GetControlInfo" },
			TextTools = new List<TextToolType> { TextToolType.SelectControlXPath }
		};
		UNNgVCoJpBW = new StepInParamDef
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
		AusgVPemQBd = new StepInParamDef
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
		P5HgVEGhAid = new StepInParamDef
		{
			Key = "value",
			Name = "值",
			Description = "仅用于 “设置值” 操作。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "TriggerControl" }
		};
		diogVyeybZr = new StepInParamDef
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
		CtrlXPathParam = new StepOutParamDef
		{
			Key = "controlXPath",
			Name = "控件XPath",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		WKagVaJRdOM = new StepOutParamDef
		{
			Key = "controlTypeId",
			Name = "控件类型ID",
			Description = "",
			Type = VarType.Integer,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		ControlInfoParam = new StepOutParamDef
		{
			Key = "controlInfo",
			Name = "其他信息",
			Type = VarType.Dict,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		QdAgV7CZnym = new StepOutParamDef
		{
			Key = "controlIsEnabled",
			Name = "是否启用",
			Description = "控件未处于禁用状态",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		NdwgVR0hxvr = new StepOutParamDef
		{
			Key = "controlIsVisible",
			Name = "是否可见",
			Description = "控件是否在屏幕上。",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		RawElementObjectParam = new StepOutParamDef
		{
			Key = "element",
			Name = "原始对象",
			Description = "返回控件的AutomationElement对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "GetControlInfo", "GetCursorPointControlInfo", "GetFocusedControlInfo", "GetControlInfoByPosition" }
		};
		PmAgVqv1kyv = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		foreach (ControlType supportedControlType in AutomationHelper4FlaUI.SupportedControlTypes)
		{
			UNNgVCoJpBW.SelectionItems.Add(new SelectionItem(supportedControlType.ToString(), supportedControlType.ToString()));
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass64_0 _003C_003Ec__DisplayClass64_ = new _003C_003Ec__DisplayClass64_0();
		_003C_003Ec__DisplayClass64_.HUcSVUs1leW = step;
		_003C_003Ec__DisplayClass64_.RSJSVld8iO7 = context;
		_003C_003Ec__DisplayClass64_.Mi5SViqX0ZO = this;
		_003C_003Ec__DisplayClass64_.Sq0SV3QrwRP = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass64_.RSJSVld8iO7, _003C_003Ec__DisplayClass64_.HUcSVUs1leW, _003C_003Ec__DisplayClass64_.Sq0SV3QrwRP, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass64_.V5BSVFCQikr, (Action)null, (Action)null, diogVyeybZr, PmAgVqv1kyv);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) Ynngci9fe3h(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, UIA3Automation uia3Automation_0)
	{
		Point point = PointExt.FromValue(XActionHelper.GetTextParamValue(uiOgV2p3Edh, actionStep_0, actionExecuteContext_0));
		AutomationElement automationElement_ = uia3Automation_0.FromPoint(point);
		return aKggc35fqiN(actionExecuteContext_0, actionStep_0, xaction_0, automationElement_);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetFocusedControlInfo(ActionExecuteContext context, ActionStep step, XAction action, UIA3Automation automation)
	{
		return aKggc35fqiN(context, step, action, automation.FocusedElement());
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetCursorPointControlInfo(ActionExecuteContext context, ActionStep step, XAction action, UIA3Automation automation)
	{
		Point mousePosition = NativeMethods.GetMousePosition();
		AutomationElement automationElement_ = automation.FromPoint(mousePosition);
		return aKggc35fqiN(context, step, action, automationElement_);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetControlInfo(ActionExecuteContext context, ActionStep step, XAction action, UIA3Automation automation)
	{
		AutomationElement automationElement_ = eNOgcfVdsuo(context, step, automation);
		return aKggc35fqiN(context, step, action, automationElement_);
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) aKggc35fqiN(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, AutomationElement automationElement_0)
	{
		_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
		_003C_003Ec__DisplayClass69_.G0aSZLAdpHa = automationElement_0;
		XActionHelper.OutputResult(CtrlNameParam, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Name, xaction_0);
		XActionHelper.OutputResult(CtrlTypeParam, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.ControlType.ToString(), xaction_0);
		XActionHelper.OutputResult(WKagVaJRdOM, actionStep_0, actionExecuteContext_0, (int)_003C_003Ec__DisplayClass69_.G0aSZLAdpHa.ControlType, xaction_0);
		if (XActionHelper.IsOutputParamSetted(RectOutputParam.Key, actionStep_0))
		{
			Rectangle boundingRectangle = _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.BoundingRectangle;
			string result = $"{boundingRectangle.Left},{boundingRectangle.Top},{boundingRectangle.Right},{boundingRectangle.Bottom}";
			XActionHelper.OutputResult(RectOutputParam, actionStep_0, actionExecuteContext_0, result, xaction_0);
		}
		if (XActionHelper.IsOutputParamSetted(ValueOutputParam.Key, actionStep_0))
		{
			string controlValue = AutomationHelper4FlaUI.GetControlValue(_003C_003Ec__DisplayClass69_.G0aSZLAdpHa);
			XActionHelper.OutputResult(ValueOutputParam, actionStep_0, actionExecuteContext_0, controlValue, xaction_0);
		}
		XActionHelper.OutputResultIfNeeded(CtrlTextParam, _003C_003Ec__DisplayClass69_.RyBSVfTboel, actionStep_0, actionExecuteContext_0, xaction_0);
		_003C_003Ec__DisplayClass69_.xxZSZveDxup = "";
		if (XActionHelper.IsOutputParamSetted(ControlInfoParam.Key, actionStep_0) || XActionHelper.IsOutputParamSetted(CtrlXPathParam.Key, actionStep_0))
		{
			try
			{
				_003C_003Ec__DisplayClass69_.xxZSZveDxup = Debug.GetXPathToElement(_003C_003Ec__DisplayClass69_.G0aSZLAdpHa);
			}
			catch (Exception)
			{
				_003C_003Ec__DisplayClass69_.xxZSZveDxup = "不支持此控件获取XPath";
			}
		}
		XActionHelper.OutputResultIfNeeded(CtrlXPathParam, _003C_003Ec__DisplayClass69_.PUKSVz4Mm0n, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(QdAgV7CZnym, _003C_003Ec__DisplayClass69_.XdWSZwhbpFS, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(NdwgVR0hxvr, _003C_003Ec__DisplayClass69_.Cw8SZtYeVRH, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(RawElementObjectParam, _003C_003Ec__DisplayClass69_.gBiSZgOMIZ2, actionStep_0, actionExecuteContext_0, xaction_0);
		if (XActionHelper.IsOutputParamSetted(ControlInfoParam.Key, actionStep_0))
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("IsEnabled", !_003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Properties.IsEnabled.IsSupported || _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.IsEnabled);
			dictionary.Add("ActualHeight", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.ActualHeight);
			dictionary.Add("ActualWidth", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.ActualWidth);
			dictionary.Add("ClassName", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Properties.ClassName.IsSupported ? _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.ClassName : "");
			dictionary.Add("FrameworkType", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.FrameworkType);
			dictionary.Add("HelpText", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Properties.HelpText.IsSupported ? _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.HelpText : "");
			dictionary.Add("ControlType", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Properties.ControlType.IsSupported ? _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.ControlType : ControlType.Unknown);
			dictionary.Add("Name", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Properties.Name.IsSupported ? _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Name : "");
			dictionary.Add("AutomationId", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Properties.AutomationId.IsSupported ? _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.AutomationId : "");
			dictionary.Add("IsAvailable", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.IsAvailable);
			dictionary.Add("IsOffscreen", (bool)_003C_003Ec__DisplayClass69_.G0aSZLAdpHa.Properties.IsOffscreen && _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.IsOffscreen);
			dictionary.Add("XPathFromRoot", _003C_003Ec__DisplayClass69_.xxZSZveDxup);
			dictionary.Add("SupportedPatterns", string.Join(";", _003C_003Ec__DisplayClass69_.G0aSZLAdpHa.GetSupportedPatterns().Select(_003C_003Ec.YjSSVO4qbML ?? (_003C_003Ec.YjSSVO4qbML = _003C_003Ec.xtTSVApXjcR.iBkSVMXUMxN))));
			XActionHelper.OutputResult(ControlInfoParam, actionStep_0, actionExecuteContext_0, dictionary, xaction_0);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) TriggerControl(ActionExecuteContext context, ActionStep step, UIA3Automation automation)
	{
		AutomationElement element = eNOgcfVdsuo(context, step, automation);
		string textParamValue = XActionHelper.GetTextParamValue(AusgVPemQBd, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(P5HgVEGhAid, step, context);
		AutomationHelper4FlaUI.TriggerControlOperation(element, textParamValue, textParamValue2, automation);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private AutomationElement eNOgcfVdsuo(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, UIA3Automation uia3Automation_0)
	{
		IntPtr windowHandle = mGugcz5aGRJ(actionExecuteContext_0, actionStep_0);
		string textParamValue = XActionHelper.GetTextParamValue(vWHgV0ho1Cn, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue))
		{
			throw new InvalidDataException("未指定控件名。");
		}
		string textParamValue2 = XActionHelper.GetTextParamValue(UNNgVCoJpBW, actionStep_0, actionExecuteContext_0);
		ControlType controlType = ControlType.Unknown;
		if (textParamValue2 != "0")
		{
			controlType = (ControlType)Enum.Parse(typeof(ControlType), textParamValue2);
		}
		return AutomationHelper4FlaUI.FindWindowControl(windowHandle, textParamValue, controlType, uia3Automation_0) ?? throw new InvalidOperationException("未找到控件：" + textParamValue);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) TriggerMenu(ActionExecuteContext context, ActionStep step, UIA3Automation automation)
	{
		IntPtr hwnd = mGugcz5aGRJ(context, step);
		AutomationElement windowElement = automation.FromHandle(hwnd);
		string[] array = XActionHelper.GetTextParamValue(Yk1gVNjoD84, step, context).Split(new string[3] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length < 1)
		{
			return (isSuccess: false, message: "未指定菜单路径", failReason: ActionStopFlag.OperationFailed);
		}
		int expandDelay = (int)XActionHelper.GetIntegerParamValue(Q0SgVJ5Eudn, step, context);
		AutomationHelper4FlaUI.InvokeWindowMenu(windowElement, array, expandDelay, automation);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private IntPtr mGugcz5aGRJ(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(RQOgVupflvk, actionStep_0, actionExecuteContext_0);
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
		return XActionHelper.GetParamDirectValue(XQ8gVShC0al, step) + " " + XActionHelper.GetParamDisplayString(vWHgV0ho1Cn, step) + " " + XActionHelper.GetParamDisplayString(AusgVPemQBd, step);
	}

	internal static bool vkYVtdQtIiEjeLS3NxgJ()
	{
		return HgnK2sQtxwH9nC30VtNC == null;
	}
}
