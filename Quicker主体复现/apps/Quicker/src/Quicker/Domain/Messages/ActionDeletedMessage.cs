using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class ActionDeletedMessage : TinyMessageBase
{
	[CompilerGenerated]
	private string taEthrLVY9U;

	internal static ActionDeletedMessage bo7MHuQBsKuUKPkbcQlM;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return taEthrLVY9U;
		}
		[CompilerGenerated]
		set
		{
			taEthrLVY9U = value;
		}
	}

	public ActionDeletedMessage(object sender, string actionId)
		: base(sender)
	{
		ActionId = actionId;
	}

	internal static bool vkvBv4QBC27dLbGVmo9s()
	{
		return bo7MHuQBsKuUKPkbcQlM == null;
	}
}
