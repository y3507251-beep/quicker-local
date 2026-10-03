using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private string vaAbgLJLb1;

	private static AspMvcAreaViewLocationFormatAttribute crTlR5YvpsQlDkmJHrT;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return vaAbgLJLb1;
		}
		[CompilerGenerated]
		private set
		{
			vaAbgLJLb1 = value;
		}
	}

	public AspMvcAreaViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}

	static AspMvcAreaViewLocationFormatAttribute()
	{
	}

	internal static bool awTTQ3Yd3QktRcrYoFI()
	{
		return crTlR5YvpsQlDkmJHrT == null;
	}

	internal static void B1eHoEYJ3F2RBu5DpqM()
	{
	}
}
