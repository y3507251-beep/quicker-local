using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
[BaseTypeRequired(typeof(Attribute))]
public sealed class BaseTypeRequiredAttribute : Attribute
{
	[NotNull]
	public Type BaseType { get; }

	public BaseTypeRequiredAttribute([NotNull] Type baseType)
	{
		BaseType = baseType;
	}
}
