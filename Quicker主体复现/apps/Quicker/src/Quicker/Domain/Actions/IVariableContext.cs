using System.Collections.Generic;

namespace Quicker.Domain.Actions;

public interface IVariableContext
{
	IDictionary<string, object> GetVariables();

	void SetVarValue(string varName, object value);

	object GetVarValue(string varName);

	object TryGetValue(string var, object defaultValue);

	bool IsVarExists(string varName);
}
