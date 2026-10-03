using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcViewLocationFormatAttribute : Attribute
{
	[NotNull]
	public string Format { get; }

	public AspMvcViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}
}
