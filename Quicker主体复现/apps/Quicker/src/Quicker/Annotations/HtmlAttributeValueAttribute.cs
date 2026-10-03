using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HtmlAttributeValueAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string zvYX2v88ms;

	internal static HtmlAttributeValueAttribute Ca1EIeMCav6OXYOZgfw;

	[NotNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return zvYX2v88ms;
		}
	}

	public HtmlAttributeValueAttribute([NotNull] string name)
	{
		zvYX2v88ms = name;
	}

	internal static bool L0I69ZM7iw0X3V2NDZU()
	{
		return Ca1EIeMCav6OXYOZgfw == null;
	}
}
