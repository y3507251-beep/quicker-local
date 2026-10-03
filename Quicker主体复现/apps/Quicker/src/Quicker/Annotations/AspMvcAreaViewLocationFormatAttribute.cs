using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string xUk6fhNXug;

	internal static AspMvcAreaViewLocationFormatAttribute STQEATPH6b36j4xANZ9;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return xUk6fhNXug;
		}
	}

	public AspMvcAreaViewLocationFormatAttribute([NotNull] string format)
	{
		xUk6fhNXug = format;
	}

	internal static bool PhrGD5PzHYfvm79AJG0()
	{
		return STQEATPH6b36j4xANZ9 == null;
	}
}
