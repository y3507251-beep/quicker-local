using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AspRequiredAttributeAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string Y79XClF4ql;

	private static AspRequiredAttributeAttribute FrH17iUTVti8ik7mh43;

	[NotNull]
	public string Attribute
	{
		[CompilerGenerated]
		get
		{
			return Y79XClF4ql;
		}
	}

	public AspRequiredAttributeAttribute([NotNull] string attribute)
	{
		Y79XClF4ql = attribute;
	}

	internal static bool BuSPHFUmHmnbhfypSVB()
	{
		return FrH17iUTVti8ik7mh43 == null;
	}
}
