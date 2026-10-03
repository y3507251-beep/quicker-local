using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Quicker.Utilities.UI;

public class FakeWindowsPeer : WindowAutomationPeer
{
	internal static FakeWindowsPeer J59dJAF4Wf0FpMJNjZUF;

	public FakeWindowsPeer(Window window)
		: base(window)
	{
	}

	protected override string GetNameCore()
	{
		return "CustomWindowAutomationPeer";
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Window;
	}

	protected override List<AutomationPeer> GetChildrenCore()
	{
		return null;
	}

	internal static bool FtKNAkF4ypceW1Q0oyQP()
	{
		return J59dJAF4Wf0FpMJNjZUF == null;
	}
}
