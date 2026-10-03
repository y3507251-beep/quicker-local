using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HtmlElementAttributesAttribute : Attribute
{
	[CanBeNull]
	public string Name { get; }

	public HtmlElementAttributesAttribute()
	{
	}

	public HtmlElementAttributesAttribute([NotNull] string name)
	{
		Name = name;
	}
}
