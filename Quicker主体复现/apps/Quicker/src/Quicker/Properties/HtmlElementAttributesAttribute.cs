using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HtmlElementAttributesAttribute : Attribute
{
	[CompilerGenerated]
	private string ljtbaaITRN;

	private static HtmlElementAttributesAttribute PuVayX8EI5D6rHERBi3;

	[CanBeNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return ljtbaaITRN;
		}
		[CompilerGenerated]
		private set
		{
			ljtbaaITRN = value;
		}
	}

	public HtmlElementAttributesAttribute()
	{
	}

	public HtmlElementAttributesAttribute([NotNull] string name)
	{
		Name = name;
	}

	static HtmlElementAttributesAttribute()
	{
	}

	internal static bool q9NwAd8GQNwhYR0s901()
	{
		return PuVayX8EI5D6rHERBi3 == null;
	}

	internal static void oq3ifB81C9CakPnun7W()
	{
	}
}
