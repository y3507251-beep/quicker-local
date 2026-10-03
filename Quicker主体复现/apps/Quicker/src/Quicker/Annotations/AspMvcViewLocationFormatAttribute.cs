using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string WrbXt0nsj6;

	private static AspMvcViewLocationFormatAttribute lNH4wyMXFsD3vIoM4BR;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return WrbXt0nsj6;
		}
	}

	public AspMvcViewLocationFormatAttribute([NotNull] string format)
	{
		WrbXt0nsj6 = format;
	}

	internal static bool ElOj6BM2jHt4MUOywbJ()
	{
		return lNH4wyMXFsD3vIoM4BR == null;
	}
}
