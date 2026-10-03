using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Forms;
using BsN3vJfWIs2lmn8y2ox;
using gcnHvsfjY8cBsNZphbX;
using Quicker.Domain;

namespace UIAutoHelper;

public static class AutomationHelper
{
	public const string CTRLOP_AUTO = "Auto";

	public const string CTRLOP_INVOKE = "Invoke";

	public const string CTRLOP_SELECT = "Select";

	public const string CTRLOP_ADD_TO_SELECTION = "AddToSelection";

	public const string CTRLOP_REMOVE_FROM_SELECTION = "RemoveFromSelection";

	public const string CTRLOP_TOGGLE_SELECTION = "ToggleItemSelection";

	public const string CTRLOP_EXPAND = "Expand";

	public const string CTRLOP_COLLAPSE = "Collapse";

	public const string CTRLOP_TOGGLE_COLLAPSE = "ToggleExpandCollapse";

	public const string CTRLOP_TOGGLE = "Toggle";

	public const string CTRLOP_TOGGLE_ON = "ToggleOn";

	public const string CTRLOP_TOGGLE_OFF = "ToggleOff";

	public const string CTRLOP_LeftCLICK = "LeftClick";

	public const string CTRLOP_MiddleCLICK = "MiddleClick";

	public const string CTRLOP_LeftDoubleCLICK = "LeftDoubleClick";

	public const string CTRLOP_RightCLICK = "RightClick";

	public const string CTRLOP_SetValue = "SetValue";

	public static readonly IList<ControlType> SupportedControlTypes;

	private static object e0MfiNvZiCgualce48F;

	public static AutomationElement FindFirstWithMaxDepth(this AutomationElement parentElement, System.Windows.Automation.Condition condition, int depth)
	{
		if (depth <= 0)
		{
			return null;
		}
		AutomationElement automationElement = parentElement.FindFirst(TreeScope.Children, condition);
		if (automationElement != null)
		{
			return automationElement;
		}
		foreach (AutomationElement item in parentElement.FindAll(TreeScope.Children, System.Windows.Automation.Condition.TrueCondition))
		{
			AutomationElement automationElement2 = item.FindFirstWithMaxDepth(condition, depth - 1);
			if (automationElement2 != null)
			{
				return automationElement2;
			}
		}
		return null;
	}

	public static AutomationElement FindWindowControl(IntPtr windowHandle, string controlName, ControlType controlType)
	{
		AutomationElement automationElement = AutomationElement.FromHandle(windowHandle);
		List<System.Windows.Automation.Condition> list = new List<System.Windows.Automation.Condition>();
		list.Add(new PropertyCondition(AutomationElement.NameProperty, controlName));
		list.Add(new PropertyCondition(AutomationElement.IsControlElementProperty, true));
		if (controlType != null)
		{
			if (KXCArsv5OxnFMZ6j4jI())
			{
				switch (0)
				{
				}
			}
			list.Add(new PropertyCondition(AutomationElement.ControlTypeProperty, controlType));
		}
		System.Windows.Automation.Condition condition = new AndCondition(list.ToArray());
		AutomationElement automationElement2 = automationElement.FindFirst(TreeScope.Descendants, condition);
		if (automationElement2 == null)
		{
			int processId = automationElement.Current.ProcessId;
			foreach (AutomationElement item in AutomationElement.RootElement.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ProcessIdProperty, processId)))
			{
				if (item.Current.NativeWindowHandle != (int)windowHandle)
				{
					automationElement2 = item.FindFirstWithMaxDepth(condition, 10);
					if (automationElement2 != null)
					{
						return automationElement2;
					}
				}
			}
		}
		return automationElement2;
	}

	public static IntPtr FindProcessWindow(int procId)
	{
		AutomationElementCollection automationElementCollection = AutomationElement.RootElement.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ProcessIdProperty, procId));
		if (automationElementCollection.Count == 0)
		{
			return IntPtr.Zero;
		}
		return (IntPtr)automationElementCollection[0].Current.NativeWindowHandle;
	}

	public static void InvokeWindowMenu(AutomationElement windowElement, string[] menuNames, int expandDelay = 100)
	{
		if (menuNames.Length < 1)
		{
			throw new InvalidDataException("未指定要调用的菜单项");
		}
		AutomationElement automationElement = null;
		System.Windows.Automation.Condition condition = new AndCondition(new PropertyCondition(AutomationElement.NameProperty, menuNames[0]), new PropertyCondition(AutomationElement.IsControlElementProperty, true), new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.MenuItem));
		automationElement = windowElement.FindFirstWithMaxDepth(condition, 3);
		if (automationElement == null)
		{
			throw new Exception("无法找到根菜单!");
		}
		uu9EcTDmVB(automationElement);
		if (!automationElement.ExpandCollapse(true))
		{
			if (e0MfiNvZiCgualce48F == null)
			{
				switch (0)
				{
				}
			}
			automationElement.Invoke();
		}
		if (menuNames.Length > 1)
		{
			Thread.Sleep(expandDelay);
		}
		jkqERAM6DQ(windowElement, automationElement, menuNames, 1, expandDelay);
	}

	private static void jkqERAM6DQ(AutomationElement automationElement_0, AutomationElement automationElement_1, string[] string_0, int int_0, int int_1)
	{
		if (int_0 >= string_0.Length)
		{
			return;
		}
		AndCondition condition = new AndCondition(new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.MenuItem), new PropertyCondition(AutomationElement.NameProperty, string_0[int_0]));
		AutomationElement automationElement = automationElement_1.FindFirst(TreeScope.Children, condition);
		if (automationElement == null)
		{
			automationElement = automationElement_0.FindFirstWithMaxDepth(condition, 6);
			if (automationElement == null)
			{
				foreach (AutomationElement item in AutomationElement.RootElement.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ProcessIdProperty, automationElement_0.Current.ProcessId)))
				{
					if (item.Current.NativeWindowHandle != automationElement_0.Current.NativeWindowHandle)
					{
						automationElement = item.FindFirstWithMaxDepth(condition, 5);
						if (automationElement != null)
						{
							break;
						}
					}
				}
			}
		}
		if (automationElement == null)
		{
			throw new Exception("未找到菜单：" + string_0[int_0]);
		}
		automationElement.ExpandOrInvokeMenu();
		if (string_0.Length <= int_0)
		{
			return;
		}
		Thread.Sleep(int_1);
		if (KXCArsv5OxnFMZ6j4jI())
		{
			switch (0)
			{
			}
		}
		jkqERAM6DQ(automationElement_0, automationElement, string_0, int_0 + 1, int_1);
	}

	public static bool ExpandOrInvokeMenu(this AutomationElement menu)
	{
		if (!menu.ExpandCollapse(true))
		{
			return menu.Invoke();
		}
		return true;
	}

	public static void InvokeContextMenu(IntPtr window, int processId, string[] menuNames, int expandDelay)
	{
	}

	private static void WodEq52cvx(string[] string_0, int int_0 = 100)
	{
		AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Menu));
	}

	private static void uu9EcTDmVB(AutomationElement automationElement_0)
	{
		AutomationPattern[] supportedPatterns = automationElement_0.GetSupportedPatterns();
		for (int i = 0; i < supportedPatterns.Length; i++)
		{
		}
	}

	public static void InvokeControl(IntPtr windowHandle, string controlName)
	{
		AutomationElement automationElement = FindWindowControl(windowHandle, controlName, null);
		if (automationElement == null)
		{
			throw new InvalidOperationException("未找到控件：" + controlName);
		}
		if (!automationElement.Invoke())
		{
			throw new InvalidOperationException("控件不支持调用：" + controlName);
		}
	}

	private static bool Invoke(this AutomationElement element)
	{
		if (element.TryGetCurrentPattern(InvokePattern.Pattern, out var patternObject))
		{
			(patternObject as InvokePattern).Invoke();
			return true;
		}
		return false;
	}

	public static bool Select(this AutomationElement element)
	{
		if (element.TryGetCurrentPattern(SelectionItemPattern.Pattern, out var patternObject))
		{
			(patternObject as SelectionItemPattern).Select();
			return true;
		}
		return false;
	}

	public static bool AddToSelection(this AutomationElement element)
	{
		if (element.TryGetCurrentPattern(SelectionItemPattern.Pattern, out var patternObject))
		{
			try
			{
				(patternObject as SelectionItemPattern).AddToSelection();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool ToggleSelection(this AutomationElement element)
	{
		if (element.TryGetCurrentPattern(SelectionItemPattern.Pattern, out var patternObject))
		{
			SelectionItemPattern selectionItemPattern = patternObject as SelectionItemPattern;
			try
			{
				if (selectionItemPattern.Current.IsSelected)
				{
					selectionItemPattern.RemoveFromSelection();
				}
				else
				{
					selectionItemPattern.AddToSelection();
				}
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool RemoveFromSelection(this AutomationElement element)
	{
		if (element.TryGetCurrentPattern(SelectionItemPattern.Pattern, out var patternObject))
		{
			try
			{
				(patternObject as SelectionItemPattern).RemoveFromSelection();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool ToggleItem(IntPtr windowHandle, string controlName, bool? on)
	{
		AutomationElement automationElement = FindWindowControl(windowHandle, controlName, null);
		if (automationElement == null)
		{
			throw new InvalidDataException("未找到控件：" + controlName);
		}
		return automationElement.ToggleItem(on);
	}

	public static bool ToggleItem(this AutomationElement element, bool? on)
	{
		if (element == null)
		{
			return false;
		}
		if (element.TryGetCurrentPattern(TogglePattern.Pattern, out var patternObject))
		{
			TogglePattern togglePattern = patternObject as TogglePattern;
			ToggleState toggleState = (on.HasValue ? (on.Value ? ToggleState.On : ToggleState.Off) : ((togglePattern.Current.ToggleState != ToggleState.On) ? ToggleState.On : ToggleState.Off));
			int num = 0;
			while (true)
			{
				if (num < Enum.GetNames(typeof(ToggleState)).Length)
				{
					if (togglePattern.Current.ToggleState == toggleState)
					{
						break;
					}
					togglePattern.Toggle();
					num++;
					continue;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	public static ToggleState GetToggleState(this AutomationElement element)
	{
		if (!element.TryGetCurrentPattern(TogglePattern.Pattern, out var patternObject))
		{
			throw new InvalidOperationException("不支持Toggle模式");
		}
		return (patternObject as TogglePattern).Current.ToggleState;
	}

	public static bool ExpandCollapse(this AutomationElement element, bool? isExpand)
	{
		if (element.TryGetCurrentPattern(ExpandCollapsePattern.Pattern, out var patternObject))
		{
			ExpandCollapsePattern expandCollapsePattern = patternObject as ExpandCollapsePattern;
			ExpandCollapseState expandCollapseState = expandCollapsePattern.Current.ExpandCollapseState;
			if (!isExpand.HasValue)
			{
				switch (expandCollapseState)
				{
				case ExpandCollapseState.Expanded:
					expandCollapsePattern.Collapse();
					break;
				case ExpandCollapseState.Collapsed:
				case ExpandCollapseState.PartiallyExpanded:
					expandCollapsePattern.Expand();
					break;
				}
			}
			else if (isExpand == true)
			{
				if (expandCollapseState == ExpandCollapseState.Collapsed || expandCollapseState == ExpandCollapseState.PartiallyExpanded)
				{
					expandCollapsePattern.Expand();
				}
			}
			else if (isExpand == false && (expandCollapseState == ExpandCollapseState.Expanded || expandCollapseState == ExpandCollapseState.PartiallyExpanded))
			{
				expandCollapsePattern.Collapse();
			}
			return true;
		}
		return false;
	}

	internal static bool IEFEVggZcy(this AutomationElement automationElement_0, v9EadRfwNc77raIiRMH v9EadRfwNc77raIiRMH_0)
	{
		System.Drawing.Point position = Cursor.Position;
		if (automationElement_0.TryGetClickablePoint(out var pt))
		{
			Cursor.Position = new System.Drawing.Point((int)pt.X, (int)pt.Y);
			g7ZWAWf2CaY9F7R2ytX.EXTLl1eaAPe(v9EadRfwNc77raIiRMH_0);
			Cursor.Position = position;
			return true;
		}
		AutomationElement.AutomationElementInformation current = automationElement_0.Current;
		if (KXCArsv5OxnFMZ6j4jI())
		{
			switch (0)
			{
			}
		}
		Rect boundingRectangle = current.BoundingRectangle;
		if (boundingRectangle.Width > 0.0)
		{
			Cursor.Position = new System.Drawing.Point((int)(boundingRectangle.Left + boundingRectangle.Right) / 2, (int)(boundingRectangle.Top + boundingRectangle.Bottom) / 2);
			g7ZWAWf2CaY9F7R2ytX.EXTLl1eaAPe(v9EadRfwNc77raIiRMH_0);
			Cursor.Position = position;
			return true;
		}
		return false;
	}

	public static void TriggerControlOperation(IntPtr windowHandle, string controlName, ControlType controlType, string controlOperation)
	{
		AutomationElement automationElement = FindWindowControl(windowHandle, controlName, controlType);
		if (automationElement == null)
		{
			throw new InvalidOperationException("未找到控件：" + controlName);
		}
		TriggerControlOperation(automationElement, controlOperation);
	}

	public static void TriggerControlOperation(AutomationElement element, string operation, string value = null)
	{
        int length = default;
		bool flag = false;
		int num;
		if (operation != null)
		{
			num = 1;
			if (!KXCArsv5OxnFMZ6j4jI())
			{
				goto IL_00ed;
			}
			goto IL_00fa;
		}
		goto IL_0363;
		IL_00fa:
		switch (num)
		{
		case 7:
			break;
		case 1:
			goto IL_00ed;
		case 5:
			goto IL_01a5;
		default:
			goto IL_0260;
		case 4:
			goto IL_02bf;
		case 2:
			goto IL_033a;
		case 3:
		case 6:
		case 8:
		case 9:
			goto IL_0363;
		}
		goto IL_001e;
		IL_00ed:
		length = operation.Length;
		goto IL_001e;
		IL_001e:
		switch (length)
		{
		case 6:
			break;
		case 8:
			goto IL_00b6;
		case 4:
			if (operation == "Auto")
			{
				flag = PerformAutoControlOperation(element);
			}
			goto IL_0363;
		case 9:
			goto IL_0236;
		case 10:
			if (operation == "RightClick")
			{
				flag = element.IEFEVggZcy((v9EadRfwNc77raIiRMH)1);
			}
			goto IL_0363;
		case 11:
			goto IL_02af;
		case 14:
			if (operation == "AddToSelection")
			{
				flag = element.AddToSelection();
			}
			goto IL_0363;
		case 15:
			if (operation == "LeftDoubleClick")
			{
				flag = element.IEFEVggZcy((v9EadRfwNc77raIiRMH)2);
			}
			goto IL_0363;
		case 19:
			goto IL_02ff;
		case 20:
			if (operation == "ToggleExpandCollapse")
			{
				flag = element.ExpandCollapse(null);
			}
			goto IL_0363;
		default:
			goto IL_0363;
		}
		char c = operation[0];
		if ((uint)c > 73u)
		{
			if (c == 'S')
			{
				if (operation == "Select")
				{
					flag = element.Select();
					num = 8;
					if (e0MfiNvZiCgualce48F == null)
					{
						goto IL_00fa;
					}
					goto IL_0260;
				}
			}
			else if (c == 'T')
			{
				goto IL_01a5;
			}
		}
		else
		{
			switch (c)
			{
			case 'I':
				if (operation == "Invoke")
				{
					flag = element.Invoke();
				}
				break;
			case 'E':
				if (operation == "Expand")
				{
					flag = element.ExpandCollapse(true);
				}
				break;
			}
		}
		goto IL_0363;
		IL_02ff:
		c = operation[0];
		if (c != 'R')
		{
			if (c == 'T' && operation == "ToggleItemSelection")
			{
				flag = element.ToggleSelection();
			}
		}
		else if (operation == "RemoveFromSelection")
		{
			goto IL_033a;
		}
		goto IL_0363;
		IL_033a:
		flag = element.RemoveFromSelection();
		goto IL_0363;
		IL_01a5:
		if (operation == "Toggle")
		{
			flag = element.ToggleItem(null);
		}
		goto IL_0363;
		IL_00b6:
		c = operation[0];
		if (c != 'C')
		{
			if (c != 'S')
			{
				if (c != 'T')
				{
					num = 9;
					if (e0MfiNvZiCgualce48F != null)
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_00fa;
				}
				if (operation == "ToggleOn")
				{
					flag = element.ToggleItem(true);
				}
			}
			else if (operation == "SetValue")
			{
				flag = SetValue(element, value);
			}
		}
		else if (operation == "Collapse")
		{
			flag = element.ExpandCollapse(false);
		}
		goto IL_0363;
		IL_02bf:
		flag = element.IEFEVggZcy((v9EadRfwNc77raIiRMH)3);
		goto IL_0363;
		IL_0363:
		if (!flag)
		{
			throw new InvalidOperationException("不支持此操作：" + operation);
		}
		return;
		IL_0236:
		c = operation[0];
		if (c != 'L')
		{
			if (c == 'T' && operation == "ToggleOff")
			{
				goto IL_0260;
			}
		}
		else if (operation == "LeftClick")
		{
			flag = element.IEFEVggZcy((v9EadRfwNc77raIiRMH)0);
		}
		goto IL_0363;
		IL_0260:
		flag = element.ToggleItem(false);
		goto IL_0363;
		IL_02af:
		if (operation == "MiddleClick")
		{
			goto IL_02bf;
		}
		goto IL_0363;
	}

	private static bool SetValue(AutomationElement element, string value)
	{
		if (element.Current.IsPassword)
		{
			int num = 0;
			if (e0MfiNvZiCgualce48F != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => false, 
			};
		}
		if (element.TryGetCurrentPattern(ValuePattern.Pattern, out var patternObject))
		{
			(patternObject as ValuePattern).SetValue(value);
			return true;
		}
		element.SetFocus();
		SendKeys.SendWait("^{HOME}");
		SendKeys.SendWait("^+{END}");
		SendKeys.SendWait("{DEL}");
		ActionHelper.SendTextToWindow(value, true, false);
		return true;
	}

	public static bool PerformAutoControlOperation(AutomationElement element)
	{
		if (!element.Invoke() && !element.ToggleItem(null) && !element.Select() && !element.ExpandCollapse(null))
		{
			return element.IEFEVggZcy((v9EadRfwNc77raIiRMH)0);
		}
		return true;
	}

	public static string GetControlValue(AutomationElement element)
	{
		if (element.Current.IsPassword)
		{
			return "PASSWORD NOT SUPPORTED!";
		}
		if (!element.TryGetCurrentPattern(ValuePattern.Pattern, out var patternObject))
		{
			if (element.TryGetCurrentPattern(TextPattern.Pattern, out patternObject))
			{
				return (patternObject as TextPattern).DocumentRange.GetText(int.MaxValue);
			}
			if (element.TryGetCurrentPattern(SelectionItemPattern.Pattern, out patternObject))
			{
				return (patternObject as SelectionItemPattern).Current.IsSelected.ToString();
			}
			if (element.TryGetCurrentPattern(TogglePattern.Pattern, out patternObject))
			{
				TogglePattern.TogglePatternInformation current = (patternObject as TogglePattern).Current;
				if (e0MfiNvZiCgualce48F == null)
				{
					switch (0)
					{
					}
				}
				return current.ToggleState.ToString();
			}
			return "NOT SUPPORTED";
		}
		return (patternObject as ValuePattern).Current.Value;
	}

	public static string GetControlText(AutomationElement element)
	{
		string result;
		try
		{
			if (element.TryGetCurrentPattern(ValuePattern.Pattern, out var patternObject))
			{
				result = ((ValuePattern)patternObject).Current.Value;
			}
			else if (element.TryGetCurrentPattern(TextPattern.Pattern, out patternObject))
			{
				result = ((TextPattern)patternObject).DocumentRange.GetText(-1).TrimEnd('\r');
				if (e0MfiNvZiCgualce48F != null)
				{
					switch (0)
					{
					}
				}
			}
			else
			{
				result = element.Current.Name;
			}
		}
		catch (Exception)
		{
			result = "";
		}
		return result;
	}

	static AutomationHelper()
	{
		SupportedControlTypes = new List<ControlType>
		{
			ControlType.Button,
			ControlType.Calendar,
			ControlType.CheckBox,
			ControlType.ComboBox,
			ControlType.Custom,
			ControlType.DataGrid,
			ControlType.DataItem,
			ControlType.Document,
			ControlType.Edit,
			ControlType.Group,
			ControlType.Header,
			ControlType.HeaderItem,
			ControlType.Hyperlink,
			ControlType.Image,
			ControlType.List,
			ControlType.ListItem,
			ControlType.Menu,
			ControlType.MenuBar,
			ControlType.MenuItem,
			ControlType.Pane,
			ControlType.ProgressBar,
			ControlType.RadioButton,
			ControlType.ScrollBar,
			ControlType.Separator,
			ControlType.Slider,
			ControlType.Spinner,
			ControlType.SplitButton,
			ControlType.StatusBar,
			ControlType.Tab,
			ControlType.TabItem,
			ControlType.Table,
			ControlType.Text,
			ControlType.Thumb,
			ControlType.TitleBar,
			ControlType.ToolBar,
			ControlType.ToolTip,
			ControlType.Tree,
			ControlType.TreeItem,
			ControlType.Window
		};
	}

	internal static bool KXCArsv5OxnFMZ6j4jI()
	{
		return e0MfiNvZiCgualce48F == null;
	}
}
