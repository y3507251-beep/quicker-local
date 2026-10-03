using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private string jImbwFuqRT;

	internal static AspMvcAreaPartialViewLocationFormatAttribute rvxuXJY1p2ga1RVHFst;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return jImbwFuqRT;
		}
		[CompilerGenerated]
		private set
		{
			jImbwFuqRT = value;
		}
	}

	public AspMvcAreaPartialViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}

	internal static bool W0Y8J0YKCjWc3PZew6P()
	{
		return rvxuXJY1p2ga1RVHFst == null;
	}
}
