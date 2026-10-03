using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class CollectionAccessAttribute : Attribute
{
	public CollectionAccessType CollectionAccessType { get; }

	public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
	{
		CollectionAccessType = collectionAccessType;
	}
}
