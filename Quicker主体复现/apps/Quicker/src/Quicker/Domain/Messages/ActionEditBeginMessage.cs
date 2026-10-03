using System.Runtime.CompilerServices;
using Quicker.Domain.Services;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class ActionEditBeginMessage : TinyMessageBase
{
	[CompilerGenerated]
	private EditingActionInfo vdNthpavBfJ;

	private static ActionEditBeginMessage lEGQwlQB4yHo0KBNkP4q;

	public EditingActionInfo EditingActionInfo
	{
		[CompilerGenerated]
		get
		{
			return vdNthpavBfJ;
		}
		[CompilerGenerated]
		set
		{
			vdNthpavBfJ = value;
		}
	}

	public ActionEditBeginMessage(object sender, EditingActionInfo editingActionInfo)
		: base(sender)
	{
		EditingActionInfo = editingActionInfo;
	}

	internal static bool pW3ATJQBhZyALkipcKLC()
	{
		return lEGQwlQB4yHo0KBNkP4q == null;
	}
}
