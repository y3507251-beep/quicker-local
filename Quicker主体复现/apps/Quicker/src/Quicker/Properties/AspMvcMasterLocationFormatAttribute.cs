using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcMasterLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private string z2dbvajXyO;

	internal static AspMvcMasterLocationFormatAttribute ONdmTRYkiwLMHpSjZ3e;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return z2dbvajXyO;
		}
		[CompilerGenerated]
		private set
		{
			z2dbvajXyO = value;
		}
	}

	public AspMvcMasterLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}

	internal static bool K3wrtSYaCjxomatAqR8()
	{
		return ONdmTRYkiwLMHpSjZ3e == null;
	}
}
