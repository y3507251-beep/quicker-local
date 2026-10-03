using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.All)]
public sealed class LocalizationRequiredAttribute : Attribute
{
	[CompilerGenerated]
	private bool X6v1xCdRHv;

	internal static LocalizationRequiredAttribute EDiUxs5uGaSBpMecA6T;

	public bool Required
	{
		[CompilerGenerated]
		get
		{
			return X6v1xCdRHv;
		}
		[CompilerGenerated]
		private set
		{
			X6v1xCdRHv = value;
		}
	}

	public LocalizationRequiredAttribute()
		: this(true)
	{
	}

	public LocalizationRequiredAttribute(bool required)
	{
		Required = required;
	}

	internal static bool mmZmcM5oJsc0ciIsPst()
	{
		return EDiUxs5uGaSBpMecA6T == null;
	}
}
