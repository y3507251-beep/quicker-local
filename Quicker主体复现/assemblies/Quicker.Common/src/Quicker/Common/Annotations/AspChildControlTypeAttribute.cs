using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AspChildControlTypeAttribute : Attribute
{
	[NotNull]
	public string TagName { get; }

	[NotNull]
	public Type ControlType { get; }

	public AspChildControlTypeAttribute([NotNull] string tagName, [NotNull] Type controlType)
	{
		TagName = tagName;
		ControlType = controlType;
	}
}
