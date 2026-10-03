using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcActionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string IcEXgNvcO4;

	private static AspMvcActionAttribute zcCQWVMnkAtc1YjjGJB;

	[CanBeNull]
	public string AnonymousProperty
	{
		[CompilerGenerated]
		get
		{
			return IcEXgNvcO4;
		}
	}

	public AspMvcActionAttribute()
	{
	}

	public AspMvcActionAttribute([NotNull] string anonymousProperty)
	{
		IcEXgNvcO4 = anonymousProperty;
	}

	internal static bool nbCX5bMej4MQQHkxRZg()
	{
		return zcCQWVMnkAtc1YjjGJB == null;
	}
}
