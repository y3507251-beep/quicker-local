using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AspChildControlTypeAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string TJUXJlqnyy;

	[CompilerGenerated]
	private readonly Type IxSX0dOYWj;

	private static AspChildControlTypeAttribute l6FqZcU8ZSWgXkpKrcj;

	[NotNull]
	public string TagName
	{
		[CompilerGenerated]
		get
		{
			return TJUXJlqnyy;
		}
	}

	[NotNull]
	public Type ControlType
	{
		[CompilerGenerated]
		get
		{
			return IxSX0dOYWj;
		}
	}

	public AspChildControlTypeAttribute([NotNull] string tagName, [NotNull] Type controlType)
	{
		TJUXJlqnyy = tagName;
		IxSX0dOYWj = controlType;
	}

	internal static bool XbWP91URIdgHpVxtq0B()
	{
		return l6FqZcU8ZSWgXkpKrcj == null;
	}
}
