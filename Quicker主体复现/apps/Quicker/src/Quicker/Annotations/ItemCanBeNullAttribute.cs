using System;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class ItemCanBeNullAttribute : Attribute
{
	private static ItemCanBeNullAttribute o7CKHUgP8mMphB05qps;

	internal static bool y1AcAvgM37eQFg2ct8w()
	{
		return o7CKHUgP8mMphB05qps == null;
	}
}
