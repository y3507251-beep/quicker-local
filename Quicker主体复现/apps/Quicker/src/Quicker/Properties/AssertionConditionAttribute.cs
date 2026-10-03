using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class AssertionConditionAttribute : Attribute
{
	[CompilerGenerated]
	private AssertionConditionType LCIbZEiHdU;

	internal static AssertionConditionAttribute KnHVWh8qVCKv2YuCvim;

	public AssertionConditionType ConditionType
	{
		[CompilerGenerated]
		get
		{
			return LCIbZEiHdU;
		}
		[CompilerGenerated]
		private set
		{
			LCIbZEiHdU = value;
		}
	}

	public AssertionConditionAttribute(AssertionConditionType conditionType)
	{
		ConditionType = conditionType;
	}

	static AssertionConditionAttribute()
	{
	}

	internal static bool QTCkAc8iZmsC01AIIKU()
	{
		return KnHVWh8qVCKv2YuCvim == null;
	}

	internal static void OJhHsK8ZhOckcQk4kVE()
	{
	}
}
