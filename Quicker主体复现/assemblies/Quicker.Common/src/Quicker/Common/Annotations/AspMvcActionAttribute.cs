using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcActionAttribute : Attribute
{
	[CanBeNull]
	public string AnonymousProperty { get; }

	public AspMvcActionAttribute()
	{
	}

	public AspMvcActionAttribute([NotNull] string anonymousProperty)
	{
		AnonymousProperty = anonymousProperty;
	}
}
