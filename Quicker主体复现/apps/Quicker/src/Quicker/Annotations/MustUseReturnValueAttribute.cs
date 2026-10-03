using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Method)]
public sealed class MustUseReturnValueAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string XVH6AWQr67;

	internal static MustUseReturnValueAttribute JWZGIVPZBMc55xJq5M3;

	[CanBeNull]
	public string Justification
	{
		[CompilerGenerated]
		get
		{
			return XVH6AWQr67;
		}
	}

	public MustUseReturnValueAttribute()
	{
	}

	public MustUseReturnValueAttribute([NotNull] string justification)
	{
		XVH6AWQr67 = justification;
	}

	internal static bool TGHlxDP5wEHqQxSWgq3()
	{
		return JWZGIVPZBMc55xJq5M3 == null;
	}
}
