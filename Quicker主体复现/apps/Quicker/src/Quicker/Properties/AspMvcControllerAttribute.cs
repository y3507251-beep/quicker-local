using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public sealed class AspMvcControllerAttribute : Attribute
{
	[CompilerGenerated]
	private string QBkbydl7tR;

	private static AspMvcControllerAttribute Ojpb2gYYOj2Geonc9lN;

	[CanBeNull]
	public string AnonymousProperty
	{
		[CompilerGenerated]
		get
		{
			return QBkbydl7tR;
		}
		[CompilerGenerated]
		private set
		{
			QBkbydl7tR = value;
		}
	}

	public AspMvcControllerAttribute()
	{
	}

	public AspMvcControllerAttribute([NotNull] string anonymousProperty)
	{
		AnonymousProperty = anonymousProperty;
	}

	internal static bool InkqoAY8asfAg3FFwBf()
	{
		return Ojpb2gYYOj2Geonc9lN == null;
	}
}
