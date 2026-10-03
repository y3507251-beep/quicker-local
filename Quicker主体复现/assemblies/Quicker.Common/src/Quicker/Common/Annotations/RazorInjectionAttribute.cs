using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorInjectionAttribute : Attribute
{
	[NotNull]
	public string Type { get; }

	[NotNull]
	public string FieldName { get; }

	public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
	{
		Type = type;
		FieldName = fieldName;
	}
}
