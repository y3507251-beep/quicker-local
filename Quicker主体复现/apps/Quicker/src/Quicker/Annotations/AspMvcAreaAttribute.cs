using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcAreaAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string xC3XLZ4Fm3;

	internal static AspMvcAreaAttribute cvETyPMDYqjf7gH4xP8;

	[CanBeNull]
	public string AnonymousProperty
	{
		[CompilerGenerated]
		get
		{
			return xC3XLZ4Fm3;
		}
	}

	public AspMvcAreaAttribute()
	{
	}

	public AspMvcAreaAttribute([NotNull] string anonymousProperty)
	{
		xC3XLZ4Fm3 = anonymousProperty;
	}

	internal static bool CSGgfZM3D7LrIE8N87E()
	{
		return cvETyPMDYqjf7gH4xP8 == null;
	}
}
