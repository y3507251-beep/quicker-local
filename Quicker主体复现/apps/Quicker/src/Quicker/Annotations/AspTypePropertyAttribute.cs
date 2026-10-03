using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Property)]
public sealed class AspTypePropertyAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool zUOXPCgpJa;

	private static AspTypePropertyAttribute AYLNr1UCRnvwHLEC1g7;

	public bool CreateConstructorReferences
	{
		[CompilerGenerated]
		get
		{
			return zUOXPCgpJa;
		}
	}

	public AspTypePropertyAttribute(bool createConstructorReferences)
	{
		zUOXPCgpJa = createConstructorReferences;
	}

	internal static bool jAt5RdU7VviiP6TF9ie()
	{
		return AYLNr1UCRnvwHLEC1g7 == null;
	}
}
