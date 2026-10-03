using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class CollectionAccessAttribute : Attribute
{
	[CompilerGenerated]
	private CollectionAccessType SLDbclMPKj;

	internal static CollectionAccessAttribute gbtMKs8ks0ZiPMW46Qb;

	public CollectionAccessType CollectionAccessType
	{
		[CompilerGenerated]
		get
		{
			return SLDbclMPKj;
		}
		[CompilerGenerated]
		private set
		{
			SLDbclMPKj = value;
		}
	}

	public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
	{
		CollectionAccessType = collectionAccessType;
	}

	internal static void R8pO4F8NTYvmtZT5UvL()
	{
	}

	internal static bool PoyXDT8awg20jiUVR4p()
	{
		return gbtMKs8ks0ZiPMW46Qb == null;
	}
}
