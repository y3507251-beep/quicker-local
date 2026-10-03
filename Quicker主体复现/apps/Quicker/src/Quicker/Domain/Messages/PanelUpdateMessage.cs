using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class PanelUpdateMessage : TinyMessageBase
{
	[CompilerGenerated]
	private bool in1thlgLJmA;

	[CompilerGenerated]
	private bool CYVthiapFgu;

	internal static PanelUpdateMessage q5u9bvQv67xtPRHjtCuu;

	public bool UpdateGlobal
	{
		[CompilerGenerated]
		get
		{
			return in1thlgLJmA;
		}
		[CompilerGenerated]
		set
		{
			in1thlgLJmA = value;
		}
	}

	public bool UpdateContext
	{
		[CompilerGenerated]
		get
		{
			return CYVthiapFgu;
		}
		[CompilerGenerated]
		set
		{
			CYVthiapFgu = value;
		}
	}

	public PanelUpdateMessage(object sender, bool updateGlobal, bool updateContext)
		: base(sender)
	{
		UpdateGlobal = updateGlobal;
		UpdateContext = updateContext;
	}

	internal static bool RJbtmbQvt0NTmCHYntx0()
	{
		return q5u9bvQv67xtPRHjtCuu == null;
	}
}
