using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HtmlAttributeValueAttribute : Attribute
{
	[NotNull]
	public string Name { get; }

	public HtmlAttributeValueAttribute([NotNull] string name)
	{
		Name = name;
	}
}
