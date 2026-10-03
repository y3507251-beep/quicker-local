using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcControllerAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string S9wXv4Hbxl;

	internal static AspMvcControllerAttribute r2pjG4MGvL1RD8gvQRF;

	[CanBeNull]
	public string AnonymousProperty
	{
		[CompilerGenerated]
		get
		{
			return S9wXv4Hbxl;
		}
	}

	public AspMvcControllerAttribute()
	{
	}

	public AspMvcControllerAttribute([NotNull] string anonymousProperty)
	{
		S9wXv4Hbxl = anonymousProperty;
	}

	internal static bool eh5HhtM0errmg20E23N()
	{
		return r2pjG4MGvL1RD8gvQRF == null;
	}
}
