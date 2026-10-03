using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcAreaAttribute : Attribute
{
	[CanBeNull]
	public string AnonymousProperty { get; }

	public AspMvcAreaAttribute()
	{
	}

	public AspMvcAreaAttribute([NotNull] string anonymousProperty)
	{
		AnonymousProperty = anonymousProperty;
	}
}
