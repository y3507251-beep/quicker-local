using System.Collections.Generic;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Modules.TextTools;

public interface ITextControl
{
	string GetAllText();

	string GetSelectedText();

	IList<ActionVariable> GetActionVariables();

	void SetAllText(string text);

	void SetSelectedText(string text);

	void MoveCaretToEnd();
}
