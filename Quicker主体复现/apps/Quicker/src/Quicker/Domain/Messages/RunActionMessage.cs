using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.Runtime;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;

namespace Quicker.Domain.Messages;

public class RunActionMessage : TinyMessageBase
{
	[CompilerGenerated]
	private string MAjth3BBvVw;

	[CompilerGenerated]
	private string FlhthfK4MGR;

	[CompilerGenerated]
	private bool WBlthzt7NbR;

	[CompilerGenerated]
	private bool LjNtew7H1LU;

	[CompilerGenerated]
	private bool pOjtetPyfBd;

	[CompilerGenerated]
	private PointTargetInfo srategbtXCe;

	[CompilerGenerated]
	private ActionTrigger ayYteLHxBil;

	private static RunActionMessage OQ24WkQvwSElovIFYeDi;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return MAjth3BBvVw;
		}
		[CompilerGenerated]
		set
		{
			MAjth3BBvVw = value;
		}
	}

	public string Param
	{
		[CompilerGenerated]
		get
		{
			return FlhthfK4MGR;
		}
		[CompilerGenerated]
		set
		{
			FlhthfK4MGR = value;
		}
	}

	public bool EnableDebugging
	{
		[CompilerGenerated]
		get
		{
			return WBlthzt7NbR;
		}
		[CompilerGenerated]
		set
		{
			WBlthzt7NbR = value;
		}
	}

	public bool IsSubAction
	{
		[CompilerGenerated]
		get
		{
			return LjNtew7H1LU;
		}
		[CompilerGenerated]
		set
		{
			LjNtew7H1LU = value;
		}
	}

	public bool FromFloatWindow
	{
		[CompilerGenerated]
		get
		{
			return pOjtetPyfBd;
		}
		[CompilerGenerated]
		set
		{
			pOjtetPyfBd = value;
		}
	}

	public PointTargetInfo PointTargetInfo
	{
		[CompilerGenerated]
		get
		{
			return srategbtXCe;
		}
		[CompilerGenerated]
		set
		{
			srategbtXCe = value;
		}
	}

	public ActionTrigger ActionTrigger
	{
		[CompilerGenerated]
		get
		{
			return ayYteLHxBil;
		}
		[CompilerGenerated]
		set
		{
			ayYteLHxBil = value;
		}
	}

	public RunActionMessage(object sender, string actionId, bool enableDebugging, bool isSubAction, bool fromFloatWindow, PointTargetInfo pointTargetInfo, ActionTrigger actionTrigger, string param)
		: base(sender)
	{
		ActionId = actionId;
		EnableDebugging = enableDebugging;
		IsSubAction = isSubAction;
		FromFloatWindow = fromFloatWindow;
		PointTargetInfo = pointTargetInfo;
		ActionTrigger = actionTrigger;
		Param = param;
	}

	internal static bool hllAb4QvTI1877rsW6pi()
	{
		return OQ24WkQvwSElovIFYeDi == null;
	}
}
