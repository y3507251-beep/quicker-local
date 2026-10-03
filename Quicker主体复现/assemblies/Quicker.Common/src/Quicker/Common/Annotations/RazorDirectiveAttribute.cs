using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorDirectiveAttribute : Attribute
{
	[NotNull]
	public string Directive { get; }

	public RazorDirectiveAttribute([NotNull] string directive)
	{
		Directive = directive;
	}
}
