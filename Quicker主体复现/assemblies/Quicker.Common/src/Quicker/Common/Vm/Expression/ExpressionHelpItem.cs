using System;
using Quicker.Public.Actions;

namespace Quicker.Common.Vm.Expression;

public class ExpressionHelpItem
{
	public Guid Id { get; set; }

	public VarType ForVarType { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public ExpressionHelpOperation HelpOperation { get; set; }

	public string HelpOperationData { get; set; }

	public string HelpLink { get; set; }

	public int? CaretOffset { get; set; }

	public int UseCount { get; set; }

	public VarType? ResultType { get; set; }

	public string MessageAfterApply { get; set; }
}
