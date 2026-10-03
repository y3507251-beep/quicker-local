using System.Runtime.CompilerServices;
using Quicker.Common;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class ActionEditCompletedMessage : TinyMessageBase
{
	[CompilerGenerated]
	private string AaOthnE7Aqu;

	[CompilerGenerated]
	private ActionItem wWBth4xQ6nL;

	[CompilerGenerated]
	private ActionProfile n1Fth5F5cyh;

	internal static ActionEditCompletedMessage vkUqa1QvjRWCKNcBKg5X;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return AaOthnE7Aqu;
		}
		[CompilerGenerated]
		set
		{
			AaOthnE7Aqu = value;
		}
	}

	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return wWBth4xQ6nL;
		}
		[CompilerGenerated]
		set
		{
			wWBth4xQ6nL = value;
		}
	}

	public ActionProfile Profile
	{
		[CompilerGenerated]
		get
		{
			return n1Fth5F5cyh;
		}
		[CompilerGenerated]
		set
		{
			n1Fth5F5cyh = value;
		}
	}

	public ActionEditCompletedMessage(object sender, string actionId, ActionItem action, ActionProfile profile)
		: base(sender)
	{
		ActionId = actionId;
		Action = action;
		Profile = profile;
	}

	internal static bool Ca0E1SQvDtGCsmFPeflK()
	{
		return vkUqa1QvjRWCKNcBKg5X == null;
	}
}
