using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true)]
public sealed class ValueRangeAttribute : Attribute
{
	public object From { get; }

	public object To { get; }

	public ValueRangeAttribute(long from, long to)
	{
		From = from;
		To = to;
	}

	public ValueRangeAttribute(ulong from, ulong to)
	{
		From = from;
		To = to;
	}

	public ValueRangeAttribute(long value)
	{
		From = (To = value);
	}

	public ValueRangeAttribute(ulong value)
	{
		From = (To = value);
	}
}
