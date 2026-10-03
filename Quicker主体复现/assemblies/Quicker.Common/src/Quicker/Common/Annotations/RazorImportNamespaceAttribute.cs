using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorImportNamespaceAttribute : Attribute
{
	[NotNull]
	public string Name { get; }

	public RazorImportNamespaceAttribute([NotNull] string name)
	{
		Name = name;
	}
}
