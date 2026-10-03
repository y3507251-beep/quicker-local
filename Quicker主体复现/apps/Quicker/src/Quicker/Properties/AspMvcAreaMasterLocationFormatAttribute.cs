using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private string EyM1fIQs5W;

	private static AspMvcAreaMasterLocationFormatAttribute CNHKYBYEaXwntjOVcBQ;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return EyM1fIQs5W;
		}
		[CompilerGenerated]
		private set
		{
			EyM1fIQs5W = value;
		}
	}

	public AspMvcAreaMasterLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}

	internal static bool DPu1sSYGJ6vhY60uCGI()
	{
		return CNHKYBYEaXwntjOVcBQ == null;
	}
}
