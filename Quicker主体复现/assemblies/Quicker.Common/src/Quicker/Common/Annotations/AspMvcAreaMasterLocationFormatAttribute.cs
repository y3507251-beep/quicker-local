using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
{
	[NotNull]
	public string Format { get; }

	public AspMvcAreaMasterLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}
}
