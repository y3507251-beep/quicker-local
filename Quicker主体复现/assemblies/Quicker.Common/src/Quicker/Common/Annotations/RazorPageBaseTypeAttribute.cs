using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorPageBaseTypeAttribute : Attribute
{
	[NotNull]
	public string BaseType { get; }

	[CanBeNull]
	public string PageName { get; }

	public RazorPageBaseTypeAttribute([NotNull] string baseType)
	{
		BaseType = baseType;
	}

	public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
	{
		BaseType = baseType;
		PageName = pageName;
	}
}
