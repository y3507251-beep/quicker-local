using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
{
	[NotNull]
	public string Format { get; }

	public AspMvcAreaPartialViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}
}
