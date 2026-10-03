using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class ActionUpdatedMessage : TinyMessageBase
{
	[CompilerGenerated]
	private string sSXthbZRuv1;

	internal static ActionUpdatedMessage RhdSNiQBUZ793CxUHDKj;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return sSXthbZRuv1;
		}
		[CompilerGenerated]
		set
		{
			sSXthbZRuv1 = value;
		}
	}

	public ActionUpdatedMessage(object sender, string actionId)
		: base(sender)
	{
		ActionId = actionId;
	}

	internal static bool kKFA6WQBxKarL8mPmU2a()
	{
		return RhdSNiQBUZ793CxUHDKj == null;
	}
}
