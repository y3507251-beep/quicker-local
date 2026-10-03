using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HtmlAttributeValueAttribute : Attribute
{
	[CompilerGenerated]
	private string RMRbRM1Usy;

	private static HtmlAttributeValueAttribute Mmuvhw8KQHItA36TBc1;

	[NotNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return RMRbRM1Usy;
		}
		[CompilerGenerated]
		private set
		{
			RMRbRM1Usy = value;
		}
	}

	public HtmlAttributeValueAttribute([NotNull] string name)
	{
		Name = name;
	}

	internal static bool JxDgxc8B2kmvFBpe3vR()
	{
		return Mmuvhw8KQHItA36TBc1 == null;
	}
}
