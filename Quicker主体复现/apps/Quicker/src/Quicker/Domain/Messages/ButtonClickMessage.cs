using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.Runtime;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;

namespace Quicker.Domain.Messages;

public class ButtonClickMessage : TinyMessageBase
{
	[CompilerGenerated]
	private int Tb7thAu7SKt;

	[CompilerGenerated]
	private PointTargetInfo FIwthONvwWM;

	[CompilerGenerated]
	private ActionTrigger LYvthF2DVA3;

	[CompilerGenerated]
	private bool QnIthUDENtt;

	private static ButtonClickMessage zSRDkLQvgmyv6AcWwyiC;

	public int ButtonIndex
	{
		[CompilerGenerated]
		get
		{
			return Tb7thAu7SKt;
		}
		[CompilerGenerated]
		set
		{
			Tb7thAu7SKt = value;
		}
	}

	public PointTargetInfo TargetInfo
	{
		[CompilerGenerated]
		get
		{
			return FIwthONvwWM;
		}
		[CompilerGenerated]
		set
		{
			FIwthONvwWM = value;
		}
	}

	public ActionTrigger ActionTrigger
	{
		[CompilerGenerated]
		get
		{
			return LYvthF2DVA3;
		}
		[CompilerGenerated]
		set
		{
			LYvthF2DVA3 = value;
		}
	}

	public bool Debug
	{
		[CompilerGenerated]
		get
		{
			return QnIthUDENtt;
		}
		[CompilerGenerated]
		set
		{
			QnIthUDENtt = value;
		}
	}

	public ButtonClickMessage(object sender, int btnIndex, PointTargetInfo targetInfo, ActionTrigger actionTrigger, bool debug)
		: base(sender)
	{
		ButtonIndex = btnIndex;
		TargetInfo = targetInfo;
		ActionTrigger = actionTrigger;
		Debug = debug;
	}

	internal static bool QLw2BDQvPXr2OIEZtmPD()
	{
		return zSRDkLQvgmyv6AcWwyiC == null;
	}
}
