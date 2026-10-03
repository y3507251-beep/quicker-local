using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcMasterLocationFormatAttribute : Attribute
{
	[NotNull]
	public string Format { get; }

	public AspMvcMasterLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}
}
