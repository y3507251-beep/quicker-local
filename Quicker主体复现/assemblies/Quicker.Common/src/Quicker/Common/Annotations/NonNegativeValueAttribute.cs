using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class NonNegativeValueAttribute : Attribute
{
}
