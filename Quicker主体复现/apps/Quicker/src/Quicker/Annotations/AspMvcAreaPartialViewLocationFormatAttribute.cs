using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string uC063CGYrb;

	internal static AspMvcAreaPartialViewLocationFormatAttribute sSWZOKP7VratvMcVQAU;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return uC063CGYrb;
		}
	}

	public AspMvcAreaPartialViewLocationFormatAttribute([NotNull] string format)
	{
		uC063CGYrb = format;
	}

	internal static bool WoNYPCP4HtohDrZeJis()
	{
		return sSWZOKP7VratvMcVQAU == null;
	}
}
