using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;

namespace Quicker.Domain.Messages;

public class RequestShowPanelMessage : TinyMessageBase
{
	[CompilerGenerated]
	private PopupSource zC8te2yNPq2;

	internal static RequestShowPanelMessage zW8hpWQvzZ0188q4sj49;

	public PopupSource Source
	{
		[CompilerGenerated]
		get
		{
			return zC8te2yNPq2;
		}
		[CompilerGenerated]
		set
		{
			zC8te2yNPq2 = value;
		}
	}

	public RequestShowPanelMessage(object sender, PopupSource source = PopupSource.Others)
		: base(sender)
	{
		Source = source;
	}

	internal static bool rgVmTpQdVoQ4Rk59sM61()
	{
		return zW8hpWQvzZ0188q4sj49 == null;
	}
}
