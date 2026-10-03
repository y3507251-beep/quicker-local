using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AspRequiredAttributeAttribute : Attribute
{
	[NotNull]
	public string Attribute { get; }

	public AspRequiredAttributeAttribute([NotNull] string attribute)
	{
		Attribute = attribute;
	}
}
