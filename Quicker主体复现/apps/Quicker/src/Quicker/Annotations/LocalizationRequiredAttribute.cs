using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.All)]
public sealed class LocalizationRequiredAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool O7E646kpVq;

	internal static LocalizationRequiredAttribute AljT6qPyqx9EUos8gHu;

	public bool Required
	{
		[CompilerGenerated]
		get
		{
			return O7E646kpVq;
		}
	}

	public LocalizationRequiredAttribute()
		: this(true)
	{
	}

	public LocalizationRequiredAttribute(bool required)
	{
		O7E646kpVq = required;
	}

	internal static bool R26H6lPposdUWwVA19U()
	{
		return AljT6qPyqx9EUos8gHu == null;
	}
}
