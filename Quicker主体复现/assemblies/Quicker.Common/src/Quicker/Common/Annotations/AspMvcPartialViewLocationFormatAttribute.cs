using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
{
	[NotNull]
	public string Format { get; }

	public AspMvcPartialViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}
}
