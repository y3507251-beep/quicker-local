using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class CollectionAccessAttribute : Attribute
{
	[CompilerGenerated]
	private readonly CollectionAccessType E1CXuG4kuw;

	internal static CollectionAccessAttribute xDo9ZwUViZSSGQiSNmL;

	public CollectionAccessType CollectionAccessType
	{
		[CompilerGenerated]
		get
		{
			return E1CXuG4kuw;
		}
	}

	public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
	{
		E1CXuG4kuw = collectionAccessType;
	}

	static CollectionAccessAttribute()
	{
	}

	internal static void zgwqbtUcnRumiU5TndE()
	{
	}

	internal static bool klvW1WUQPuVPDvccfXi()
	{
		return xDo9ZwUViZSSGQiSNmL == null;
	}

	internal static void dmoACRUWiBSsYtBHCpt()
	{
	}
}
