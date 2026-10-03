using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class AssertionConditionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly AssertionConditionType FWpXNy0cwV;

	private static AssertionConditionAttribute Ag9CvnUeyAhAu3GyE6q;

	public AssertionConditionType ConditionType
	{
		[CompilerGenerated]
		get
		{
			return FWpXNy0cwV;
		}
	}

	public AssertionConditionAttribute(AssertionConditionType conditionType)
	{
		FWpXNy0cwV = conditionType;
	}

	internal static bool Uq93IAUjnc1BAMVgoeB()
	{
		return Ag9CvnUeyAhAu3GyE6q == null;
	}
}
