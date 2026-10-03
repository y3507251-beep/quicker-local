using Quicker.Domain.Actions;

namespace Quicker.View.Forms.Controls;

public interface IUpdatableFieldControl
{
	bool IsShouldUpdate();

	void Update(IVariableContext context);
}
