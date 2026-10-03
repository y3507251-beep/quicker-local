using System.Collections.Generic;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.X;

public interface IXProgram
{
	IList<ActionVariable> Variables { get; set; }

	IList<ActionStep> Steps { get; set; }

	IList<SubProgram> SubPrograms { get; set; }
}
