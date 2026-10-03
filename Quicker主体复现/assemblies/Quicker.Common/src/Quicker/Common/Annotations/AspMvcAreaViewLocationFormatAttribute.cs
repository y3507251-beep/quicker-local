using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
{
	[NotNull]
	public string Format { get; }

	public AspMvcAreaViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}
}
