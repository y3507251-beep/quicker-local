using System;
using System.Collections.Generic;
using Quicker.Public.Actions;

namespace Quicker.Common.Vm.Expression;

public class ShareExpressionVm
{
	public Guid? Id { get; set; }

	public VarType? ForVarType { get; set; }

	public VarType? ResultType { get; set; }

	public string ResultDescription { get; set; }

	public string ResultSampleValue { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public string Keywords { get; set; }

	public string Expression { get; set; }

	public IList<ExpressionInputParam> InputParams { get; set; }

	public bool IsPublic { get; set; }

	public string UpdateNote { get; set; }
}
