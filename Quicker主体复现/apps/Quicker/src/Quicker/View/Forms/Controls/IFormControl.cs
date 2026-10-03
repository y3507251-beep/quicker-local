using System.Windows;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Forms;

namespace Quicker.View.Forms.Controls;

public interface IFormControl
{
	void Init(FormField field, ActionVariable variable, IVariableContext context);

	object GetInputValue();

	(bool isValid, string message) Validate();

	void SetFocus();

	UIElement GetPrimaryElement();

	void SetInputWidth(double width);

	void UpdateValue(object value);

	void SetReadOnly(bool isReadOnly);
}
