using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class AssertionConditionAttribute : Attribute
{
	public AssertionConditionType ConditionType { get; }

	public AssertionConditionAttribute(AssertionConditionType conditionType)
	{
		ConditionType = conditionType;
	}
}
