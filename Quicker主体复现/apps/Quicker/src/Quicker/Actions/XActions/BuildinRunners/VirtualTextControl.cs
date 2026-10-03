using System.Collections.Generic;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;

namespace Quicker.Actions.XActions.BuildinRunners;

public class VirtualTextControl : ITextControl
{
	private readonly string JMsgmJRsCoH = "";

	internal static VirtualTextControl s400p6Q7KS76aVQeafnu;

	public VirtualTextControl()
	{
	}

	public VirtualTextControl(string currValue)
	{
		JMsgmJRsCoH = currValue ?? "";
	}

	public string GetAllText()
	{
		return JMsgmJRsCoH;
	}

	public string GetSelectedText()
	{
		return JMsgmJRsCoH;
	}

	public IList<ActionVariable> GetActionVariables()
	{
		return new List<ActionVariable>();
	}

	public void SetAllText(string text)
	{
	}

	public void SetSelectedText(string text)
	{
	}

	public void MoveCaretToEnd()
	{
	}

	internal static bool WtDyl3Q7BNsHmjHcq5fn()
	{
		return s400p6Q7KS76aVQeafnu == null;
	}
}
