using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcControllerAttribute : Attribute
{
	[CanBeNull]
	public string AnonymousProperty { get; }

	public AspMvcControllerAttribute()
	{
	}

	public AspMvcControllerAttribute([NotNull] string anonymousProperty)
	{
		AnonymousProperty = anonymousProperty;
	}
}
