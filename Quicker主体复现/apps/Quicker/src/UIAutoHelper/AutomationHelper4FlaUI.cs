using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BsN3vJfWIs2lmn8y2ox;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Patterns;
using FlaUI.UIA3;
using gcnHvsfjY8cBsNZphbX;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;

namespace UIAutoHelper;

public static class AutomationHelper4FlaUI
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public AutomationElement GDbv8V2e8YQ;

		internal static _003C_003Ec__DisplayClass24_0 H81OhBcGGpSDhCHreAXn;

		internal ConditionBase zrMv8c9Kqm1(ConditionFactory cf)
		{
			return cf.ByControlType(GDbv8V2e8YQ.Properties.ControlType);
		}

		internal static bool rPcO6DcG0B3SNjBDi0Rv()
		{
			return H81OhBcGGpSDhCHreAXn == null;
		}
	}

	public static readonly IList<ControlType> SupportedControlTypes;

	internal static object IpsT96v9UPkNcnZWl1P;

	public static AutomationElement FindFirstWithMaxDepth(this AutomationElement parentElement, ConditionBase condition, int depth)
	{
		if (depth > 0)
		{
			AutomationElement automationElement = parentElement.FindFirst(TreeScope.Children, condition);
			if (automationElement != null)
			{
				return automationElement;
			}
			AutomationElement[] array = parentElement.FindAll(TreeScope.Children, TrueCondition.Default);
			int num = 0;
			AutomationElement automationElement2;
			int num3 = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					automationElement2 = array[num].FindFirstWithMaxDepth(condition, depth - 1);
					if (automationElement2 != null)
					{
						break;
					}
					num++;
					continue;
				}
				int num2 = 0;
				if (!EayIMDvLY06jqABI7V7())
				{
					num2 = num3;
				}
				return num2 switch
				{
					_ => null, 
				};
			}
			return automationElement2;
		}
		return null;
	}

	public static AutomationElement FindWindowControl(IntPtr windowHandle, string controlXPathOrName, ControlType controlType, UIA3Automation uia3Automation)
	{
		AutomationElement automationElement = uia3Automation.FromHandle(windowHandle);
		AutomationElement[] collection = automationElement.FindAllChildren();
		for (int i = 0; i < 10; i++)
		{
			if (collection.HasData())
			{
				break;
			}
		}
		AutomationElement automationElement2 = null;
		if (controlXPathOrName.StartsWith("/"))
		{
			automationElement2 = automationElement.FindFirstByXPath(controlXPathOrName);
		}
		else
		{
			ConditionFactory conditionFactory = new ConditionFactory(new UIA3PropertyLibrary());
			List<ConditionBase> list = new List<ConditionBase>();
			list.Add(conditionFactory.ByName(controlXPathOrName));
			if (controlType != ControlType.Unknown)
			{
				list.Add(conditionFactory.ByControlType(controlType));
			}
			ConditionBase condition = new AndCondition(list.ToArray());
			automationElement2 = automationElement.FindFirst(TreeScope.Descendants, condition);
			int num = 1;
			if (!EayIMDvLY06jqABI7V7())
			{
				int num2 = default(int);
				num = num2;
			}
			int num3 = default(int);
			AutomationElement[] array = default(AutomationElement[]);
			while (true)
			{
				IL_0136:
				switch (num)
				{
				default:
					while (num3 < array.Length)
					{
						AutomationElement automationElement3 = array[num3];
						if (automationElement3.Properties.NativeWindowHandle.Value != windowHandle)
						{
							automationElement2 = automationElement3.FindFirstWithMaxDepth(condition, 10);
							if (automationElement2 != null)
							{
								return automationElement2;
							}
						}
						num3++;
						num = 0;
						if (IpsT96v9UPkNcnZWl1P != null)
						{
							continue;
						}
						goto IL_0136;
					}
					break;
				case 1:
				{
					if (automationElement2 != null)
					{
						break;
					}
					int windowProcessId = NativeMethods.GetWindowProcessId(windowHandle);
					array = uia3Automation.GetDesktop().FindAll(TreeScope.Children, conditionFactory.ByProcessId(windowProcessId));
					num3 = 0;
					num = 2;
					if (IpsT96v9UPkNcnZWl1P != null)
					{
						continue;
					}
					goto default;
				}
				}
				break;
			}
		}
		return automationElement2;
	}

	public static void InvokeWindowMenu(AutomationElement windowElement, string[] menuNames, int expandDelay, UIA3Automation automation)
	{
		if (menuNames.Length < 1)
		{
			throw new InvalidDataException("未指定要调用的菜单项");
		}
		AutomationElement automationElement = null;
		ConditionFactory conditionFactory = new ConditionFactory(new UIA3PropertyLibrary());
		ConditionBase condition = new AndCondition(conditionFactory.ByName(menuNames[0]), conditionFactory.ByControlType(ControlType.MenuItem));
		automationElement = windowElement.FindFirstWithMaxDepth(condition, 3);
		if (automationElement == null)
		{
			throw new Exception("无法找到根菜单!");
		}
		if (!automationElement.ExpandCollapse(true))
		{
			automationElement.Invoke();
			if (IpsT96v9UPkNcnZWl1P != null)
			{
				switch (0)
				{
				}
			}
		}
		if (menuNames.Length > 1)
		{
			Thread.Sleep(expandDelay);
		}
		Qo1EPO2CkA(windowElement, automationElement, menuNames, 1, expandDelay, automation);
	}

	private static void Qo1EPO2CkA(AutomationElement automationElement_0, AutomationElement automationElement_1, string[] string_0, int int_0, int int_1, UIA3Automation uia3Automation_0)
	{
		if (int_0 >= string_0.Length)
		{
			return;
		}
		ConditionFactory conditionFactory = new ConditionFactory(new UIA3PropertyLibrary());
		AndCondition condition = new AndCondition(conditionFactory.ByControlType(ControlType.MenuItem), conditionFactory.ByName(string_0[int_0]));
		AutomationElement automationElement = automationElement_1.FindFirst(TreeScope.Children, condition);
		int num;
		if (automationElement == null)
		{
			num = 0;
			if (IpsT96v9UPkNcnZWl1P != null)
			{
				goto IL_00a0;
			}
			goto IL_00e3;
		}
		goto IL_00f2;
		IL_00e3:
		int num2 = default(int);
		AutomationElement[] array = default(AutomationElement[]);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				if (num2 >= array.Length)
				{
					break;
				}
				AutomationElement automationElement2 = array[num2];
				if (automationElement2.Properties.NativeWindowHandle != automationElement_0.Properties.NativeWindowHandle)
				{
					automationElement = automationElement2.FindFirstWithMaxDepth(condition, 5);
					if (automationElement != null)
					{
						break;
					}
				}
				goto IL_008d;
			}
			default:
				automationElement = automationElement_0.FindFirstWithMaxDepth(condition, 6);
				if (automationElement != null)
				{
					break;
				}
				array = uia3Automation_0.GetDesktop().FindAll(TreeScope.Children, conditionFactory.ByProcessId(automationElement_0.Properties.ProcessId.Value));
				num2 = 0;
				goto case 1;
			}
			break;
			IL_008d:
			num2++;
			num = 1;
			if (IpsT96v9UPkNcnZWl1P == null)
			{
				continue;
			}
			goto IL_00a0;
		}
		goto IL_00f2;
		IL_00f2:
		if (automationElement == null)
		{
			throw new Exception("未找到菜单：" + string_0[int_0]);
		}
		automationElement.ExpandOrInvokeMenu();
		if (string_0.Length > int_0)
		{
			Thread.Sleep(int_1);
			Qo1EPO2CkA(automationElement_0, automationElement, string_0, int_0 + 1, int_1, uia3Automation_0);
		}
		return;
		IL_00a0:
		int num3 = default(int);
		num = num3;
		goto IL_00e3;
	}

	public static bool ExpandOrInvokeMenu(this AutomationElement menu)
	{
		if (menu.ExpandCollapse(true))
		{
			return true;
		}
		return menu.Invoke();
	}

	public static void InvokeContextMenu(IntPtr window, int processId, string[] menuNames, int expandDelay)
	{
	}

	private static ConditionFactory HU4EEp0QQ2()
	{
		return new ConditionFactory(new UIA3PropertyLibrary());
	}

	private static void tgkEy3wQGc(string[] string_0, int int_0, UIA3Automation uia3Automation_0)
	{
		uia3Automation_0.GetDesktop().FindFirst(TreeScope.Children, HU4EEp0QQ2().ByControlType(ControlType.Menu));
	}

	private static bool Invoke(this AutomationElement element)
	{
		if (element.Patterns.Invoke.TryGetPattern(out var pattern))
		{
			pattern.Invoke();
			return true;
		}
		return false;
	}

	public static bool Select(this AutomationElement element)
	{
		if (element.Patterns.SelectionItem.IsSupported)
		{
			element.Patterns.SelectionItem.Pattern.Select();
			return true;
		}
		return false;
	}

	public static bool AddToSelection(this AutomationElement element)
	{
		if (element.Patterns.SelectionItem.IsSupported)
		{
			element.Patterns.SelectionItem.Pattern.AddToSelection();
			return true;
		}
		return false;
	}

	public static bool ToggleSelection(this AutomationElement element)
	{
		if (element.Patterns.Toggle.IsSupported)
		{
			element.Patterns.Toggle.Pattern.Toggle();
			return true;
		}
		return false;
	}

	public static bool RemoveFromSelection(this AutomationElement element)
	{
		if (!element.Patterns.SelectionItem.IsSupported)
		{
			return false;
		}
		element.Patterns.SelectionItem.Pattern.RemoveFromSelection();
		return true;
	}

	public static bool ToggleItem(this AutomationElement element, bool? on)
	{
		if (element == null)
		{
			return false;
		}
		if (element.Patterns.Toggle.IsSupported)
		{
			ITogglePattern pattern = element.Patterns.Toggle.Pattern;
			ToggleState toggleState = (on.HasValue ? (on.Value ? ToggleState.On : ToggleState.Off) : (((ToggleState)pattern.ToggleState != ToggleState.On) ? ToggleState.On : ToggleState.Off));
			int num = 0;
			while (true)
			{
				if (num < Enum.GetNames(typeof(ToggleState)).Length)
				{
					if ((ToggleState)pattern.ToggleState == toggleState)
					{
						break;
					}
					pattern.Toggle();
					num++;
					continue;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	public static bool ExpandCollapse(this AutomationElement element, bool? isExpand)
	{
		if (element.Patterns.ExpandCollapse.IsSupported)
		{
			IExpandCollapsePattern pattern = element.Patterns.ExpandCollapse.Pattern;
			AutomationProperty<ExpandCollapseState> expandCollapseState = pattern.ExpandCollapseState;
			if (!isExpand.HasValue)
			{
				if ((ExpandCollapseState)expandCollapseState == ExpandCollapseState.Expanded)
				{
					pattern.Collapse();
				}
				else if ((ExpandCollapseState)expandCollapseState == ExpandCollapseState.Collapsed || (ExpandCollapseState)expandCollapseState == ExpandCollapseState.PartiallyExpanded)
				{
					pattern.Expand();
				}
			}
			else if (isExpand == true)
			{
				if ((ExpandCollapseState)expandCollapseState == ExpandCollapseState.Collapsed || (ExpandCollapseState)expandCollapseState == ExpandCollapseState.PartiallyExpanded)
				{
					pattern.Expand();
				}
			}
			else if (isExpand == false && ((ExpandCollapseState)expandCollapseState == ExpandCollapseState.Expanded || (ExpandCollapseState)expandCollapseState == ExpandCollapseState.PartiallyExpanded))
			{
				pattern.Collapse();
			}
			return true;
		}
		return false;
	}

	internal static bool N9BE8T1eLL(this AutomationElement automationElement_0, v9EadRfwNc77raIiRMH v9EadRfwNc77raIiRMH_0)
	{
		Point position = Cursor.Position;
		if (automationElement_0.TryGetClickablePoint(out var point))
		{
			Cursor.Position = new Point(point.X, point.Y);
			g7ZWAWf2CaY9F7R2ytX.EXTLl1eaAPe(v9EadRfwNc77raIiRMH_0);
			int num = 0;
			if (IpsT96v9UPkNcnZWl1P != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				Cursor.Position = position;
				return true;
			}
		}
		Rectangle boundingRectangle = automationElement_0.BoundingRectangle;
		if (boundingRectangle != Rectangle.Empty)
		{
			Cursor.Position = new Point((boundingRectangle.Left + boundingRectangle.Right) / 2, (boundingRectangle.Top + boundingRectangle.Bottom) / 2);
			g7ZWAWf2CaY9F7R2ytX.EXTLl1eaAPe(v9EadRfwNc77raIiRMH_0);
			Cursor.Position = position;
			return true;
		}
		return false;
	}

	public static void TriggerControlOperation(IntPtr windowHandle, string controlName, ControlType controlType, string controlOperation, UIA3Automation automation)
	{
		TriggerControlOperation(FindWindowControl(windowHandle, controlName, controlType, automation) ?? throw new InvalidOperationException("未找到控件：" + controlName), controlOperation);
	}

	public static void TriggerControlOperation(AutomationElement element, string operation, string value = null, UIA3Automation automation = null)
	{
		int num = 6;
		while (true)
		{
			bool flag = false;
			num = 5;
			while (true)
			{
				int num2;
				if (operation != null)
				{
					num2 = 0;
					if (IpsT96v9UPkNcnZWl1P != null)
					{
						goto IL_00f2;
					}
					goto IL_00f6;
				}
				goto IL_0384;
				IL_0384:
				if (!flag)
				{
					throw new InvalidOperationException("不支持此操作：" + operation);
				}
				return;
				IL_00f6:
				char c;
				while (true)
				{
					switch (num2)
					{
					case 3:
						break;
					default:
						goto IL_0047;
					case 5:
						goto end_IL_00f6;
					case 6:
						goto end_IL_012c;
					case 8:
						goto IL_0365;
					case 1:
						goto IL_0372;
					case 2:
					case 4:
					case 7:
					case 9:
					case 10:
						goto IL_0384;
					}
					goto IL_0023;
					IL_0047:
					switch (operation.Length)
					{
					case 6:
						break;
					case 9:
						goto IL_00ca;
					case 4:
						if (operation == "Auto")
						{
							flag = PerformAutoControlOperation(element);
						}
						goto IL_0384;
					case 8:
						goto IL_01d0;
					case 10:
						if (operation == "RightClick")
						{
							flag = element.N9BE8T1eLL((v9EadRfwNc77raIiRMH)1);
						}
						goto IL_0384;
					case 11:
						if (operation == "MiddleClick")
						{
							flag = element.N9BE8T1eLL((v9EadRfwNc77raIiRMH)3);
						}
						goto IL_0384;
					case 14:
						if (operation == "AddToSelection")
						{
							flag = element.AddToSelection();
						}
						goto IL_0384;
					case 15:
						if (operation == "LeftDoubleClick")
						{
							flag = element.N9BE8T1eLL((v9EadRfwNc77raIiRMH)2);
						}
						goto IL_0384;
					case 19:
						goto IL_0309;
					case 20:
						goto IL_0365;
					default:
						goto IL_0384;
					}
					c = operation[0];
					if ((uint)c <= 73u)
					{
						goto IL_0162;
					}
					if (c != 'S')
					{
						if (c == 'T')
						{
							goto IL_0023;
						}
					}
					else if (operation == "Select")
					{
						flag = element.Select();
					}
					goto IL_0384;
					IL_0365:
					if (operation == "ToggleExpandCollapse")
					{
						goto IL_0372;
					}
					goto IL_0384;
					IL_00ca:
					c = operation[0];
					if (c != 'L')
					{
						if (c != 'T')
						{
							num2 = 2;
							if (IpsT96v9UPkNcnZWl1P == null)
							{
								continue;
							}
							goto IL_00f2;
						}
						if (operation == "ToggleOff")
						{
							flag = element.ToggleItem(false);
						}
					}
					else if (operation == "LeftClick")
					{
						flag = element.N9BE8T1eLL((v9EadRfwNc77raIiRMH)0);
					}
					goto IL_0384;
					IL_0023:
					if (!(operation == "Toggle"))
					{
						num2 = 9;
						if (IpsT96v9UPkNcnZWl1P == null)
						{
							continue;
						}
						goto IL_0372;
					}
					flag = element.ToggleItem(null);
					goto IL_0384;
					IL_0372:
					flag = element.ExpandCollapse(null);
					goto IL_0384;
					continue;
					end_IL_00f6:
					break;
				}
				continue;
				IL_0309:
				switch (operation[0])
				{
				case 'T':
					if (operation == "ToggleItemSelection")
					{
						flag = element.ToggleSelection();
					}
					break;
				case 'R':
					if (operation == "RemoveFromSelection")
					{
						flag = element.RemoveFromSelection();
					}
					break;
				}
				goto IL_0384;
				IL_01d0:
				switch (operation[0])
				{
				case 'T':
					if (operation == "ToggleOn")
					{
						flag = element.ToggleItem(true);
					}
					break;
				case 'S':
					if (operation == "SetValue")
					{
						flag = SetValue(element, value);
					}
					break;
				case 'C':
					if (operation == "Collapse")
					{
						flag = element.ExpandCollapse(false);
					}
					break;
				}
				goto IL_0384;
				IL_00f2:
				num2 = num;
				goto IL_00f6;
				IL_0162:
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
				goto IL_0384;
				continue;
				end_IL_012c:
				break;
			}
		}
	}

	private static bool SetValue(AutomationElement element, string value)
	{
		if (!element.IsEnabled)
		{
			return false;
		}
		if (element.Patterns.Value.IsSupported)
		{
			element.Patterns.Value.Pattern.SetValue(value);
			return true;
		}
		element.Focus();
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
			return element.N9BE8T1eLL((v9EadRfwNc77raIiRMH)0);
		}
		return true;
	}

	public static string GetControlValue(AutomationElement element)
	{
		if (element.Properties.IsPassword.IsSupported && element.Properties.IsPassword.Value)
		{
			return "PASSWORD NOT SUPPORTED!";
		}
		if (!element.Patterns.Value.IsSupported)
		{
			if (element.Patterns.Text.TryGetPattern(out var pattern))
			{
				return pattern.DocumentRange.GetText(int.MaxValue);
			}
			if (element.Patterns.SelectionItem.TryGetPattern(out var pattern2))
			{
				return pattern2.IsSelected.ToString();
			}
			if (element.Patterns.Toggle.TryGetPattern(out var pattern3))
			{
				return pattern3.ToggleState.ToString();
			}
			return "NOT SUPPORTED";
		}
		return element.Patterns.Value.Pattern.Value.Value;
	}

	public static string GetControlText(AutomationElement element)
	{
		try
		{
			if (element.Patterns.Value.IsSupported)
			{
				return element.Patterns.Value.Pattern.Value.Value;
			}
			if (element.Patterns.Text.TryGetPattern(out var pattern))
			{
				return pattern.DocumentRange.GetText(int.MaxValue);
			}
			return element.Name;
		}
		catch (Exception)
		{
			return "";
		}
	}

	internal static string vwrEaeusyU(AutomationElement automationElement_0, AutomationElement automationElement_1 = null)
	{
		ITreeWalker controlViewWalker = automationElement_0.Automation.TreeWalkerFactory.GetControlViewWalker();
		return qyOE79rmt1(automationElement_0, controlViewWalker, automationElement_1);
	}

	private static string qyOE79rmt1(AutomationElement automationElement_0, ITreeWalker itreeWalker_0, AutomationElement automationElement_1 = null)
	{
        AutomationElement[] array2 = default;
        int num2 = default;
        string text2 = default;
        int num3 = default;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.GDbv8V2e8YQ = automationElement_0;
		AutomationElement parent;
		string text;
		int num;
		if (_003C_003Ec__DisplayClass24_.GDbv8V2e8YQ != null && (automationElement_1 == null || !_003C_003Ec__DisplayClass24_.GDbv8V2e8YQ.Equals(automationElement_1)))
		{
			parent = itreeWalker_0.GetParent(_003C_003Ec__DisplayClass24_.GDbv8V2e8YQ);
			if (parent == null)
			{
				return string.Empty;
			}
			text = qyOE79rmt1(parent, itreeWalker_0, automationElement_1);
			num = 1;
			if (IpsT96v9UPkNcnZWl1P != null)
			{
				goto IL_00eb;
			}
			goto IL_00f3;
		}
		return string.Empty;
		IL_00eb:
		num2 = num2 + 1;
		goto IL_00b7;
		IL_011c:
		text2 = default(string);
		return text + "/" + text2;
		IL_00f3:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00eb;
		}
		AutomationElement[] array = parent.FindAllChildren(_003C_003Ec__DisplayClass24_.zrMv8c9Kqm1);
		text2 = $"{_003C_003Ec__DisplayClass24_.GDbv8V2e8YQ.Properties.ControlType.Value}";
		num3 = default(int);
		array2 = default(AutomationElement[]);
		if (array.Length > 1)
		{
			num3 = 1;
			array2 = array;
			num2 = 0;
			goto IL_00b7;
		}
		goto IL_011c;
		IL_00b7:
		if (num2 < array2.Length && !array2[num2].Equals(_003C_003Ec__DisplayClass24_.GDbv8V2e8YQ))
		{
			num3++;
			num = 0;
			if (IpsT96v9UPkNcnZWl1P != null)
			{
				int num4 = default(int);
				num = num4;
			}
			goto IL_00f3;
		}
		text2 += $"[{num3}]";
		goto IL_011c;
	}

	static AutomationHelper4FlaUI()
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

	internal static bool EayIMDvLY06jqABI7V7()
	{
		return IpsT96v9UPkNcnZWl1P == null;
	}
}
