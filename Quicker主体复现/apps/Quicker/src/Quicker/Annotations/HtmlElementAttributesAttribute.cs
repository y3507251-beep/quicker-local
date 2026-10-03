using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HtmlElementAttributesAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string un8XS4J2cw;

	internal static HtmlElementAttributesAttribute cjdh8dMTlpeI8KV3M4N;

	[CanBeNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return un8XS4J2cw;
		}
	}

	public HtmlElementAttributesAttribute()
	{
	}

	public HtmlElementAttributesAttribute([NotNull] string name)
	{
		un8XS4J2cw = name;
	}

	internal static bool TklypxMmuD9Q4A7QDbO()
	{
		return cjdh8dMTlpeI8KV3M4N == null;
	}
}
