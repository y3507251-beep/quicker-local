using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[BaseTypeRequired(typeof(Attribute))]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class BaseTypeRequiredAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Type QRu65yYJZl;

	private static BaseTypeRequiredAttribute wEaYjaPjwQhNqCtKUqf;

	[NotNull]
	public Type BaseType
	{
		[CompilerGenerated]
		get
		{
			return QRu65yYJZl;
		}
	}

	public BaseTypeRequiredAttribute([NotNull] Type baseType)
	{
		QRu65yYJZl = baseType;
	}

	internal static bool wSYV2oPDkAKpX3Ihybp()
	{
		return wEaYjaPjwQhNqCtKUqf == null;
	}
}
