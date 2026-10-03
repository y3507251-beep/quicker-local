using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Automation;

namespace cXuiZ7i2m2sRaR7QhhS;

internal class sDvXVkiWVWu4wUdiwlQ
{
	internal static sDvXVkiWVWu4wUdiwlQ xagtKRFsEW2IDIDYVOdt;

	public static string QZwvw5sJCpI()
	{
		Process[] processesByName = Process.GetProcessesByName("onecommander");
		if (processesByName.Length != 0)
		{
			return processesByName.First().MainModule.FileName;
		}
		return "onecommander.exe";
	}

	public static void mtyvwD0Wsw3(string string_0)
	{
		Process.Start(new ProcessStartInfo(QZwvw5sJCpI())
		{
			UseShellExecute = true,
			Arguments = "-path \"" + string_0 + "\""
		});
	}

	public static string oJFvwd4TOJW(IntPtr intptr_0)
	{
		if (intptr_0 != IntPtr.Zero)
		{
			AutomationElement automationElement = tlFvwo127Kt(AutomationElement.FromHandle(intptr_0), "CurrentPathGet");
			if (automationElement == null)
			{
				throw new InvalidDataException("未找到CurrentPathGet控件");
			}
			if (automationElement.TryGetCurrentPattern(ValuePattern.Pattern, out var patternObject))
			{
				return ((ValuePattern)patternObject).Current.Value;
			}
		}
		throw new InvalidDataException("窗口句柄为空。");
	}

	public static AutomationElement tlFvwo127Kt(AutomationElement automationElement_0, string string_0)
	{
		TreeWalker rawViewWalker;
		while (true)
		{
			rawViewWalker = TreeWalker.RawViewWalker;
			if (xagtKRFsEW2IDIDYVOdt == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		Queue<AutomationElement> queue = new Queue<AutomationElement>();
		queue.Enqueue(automationElement_0);
		AutomationElement automationElement;
		while (true)
		{
			if (queue.Count > 0)
			{
				automationElement = queue.Dequeue();
				object currentPropertyValue = automationElement.GetCurrentPropertyValue(AutomationElement.AutomationIdProperty, true);
				if (currentPropertyValue != AutomationElement.NotSupported && string.Equals(currentPropertyValue as string, string_0))
				{
					break;
				}
				AutomationElement nextSibling = rawViewWalker.GetNextSibling(automationElement);
				if (nextSibling != null)
				{
					queue.Enqueue(nextSibling);
				}
				AutomationElement firstChild = rawViewWalker.GetFirstChild(automationElement);
				if (firstChild != null)
				{
					queue.Enqueue(firstChild);
				}
				continue;
			}
			return null;
		}
		return automationElement;
	}

	internal static bool TYrBvaFsGKgCQXCcyD7u()
	{
		return xagtKRFsEW2IDIDYVOdt == null;
	}
}
