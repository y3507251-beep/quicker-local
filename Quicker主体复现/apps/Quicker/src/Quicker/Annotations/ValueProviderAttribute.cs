using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class ValueProviderAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string xqW6BnpwDn;

	private static ValueProviderAttribute IvoSHbgSKix8mflwcui;

	[NotNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return xqW6BnpwDn;
		}
	}

	public ValueProviderAttribute([NotNull] string name)
	{
		xqW6BnpwDn = name;
	}

	static ValueProviderAttribute()
	{
	}

	internal static bool tDkkYvgw3YFEyJ2y7Qt()
	{
		return IvoSHbgSKix8mflwcui == null;
	}

	internal static void HwloQ4gmdyGrx7Uq4Bf()
	{
	}
}
