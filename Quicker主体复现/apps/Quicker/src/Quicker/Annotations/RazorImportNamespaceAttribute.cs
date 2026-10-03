using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorImportNamespaceAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string ysWXE9aAiJ;

	private static RazorImportNamespaceAttribute b2erXBUhpJg5a9KEpiv;

	[NotNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return ysWXE9aAiJ;
		}
	}

	public RazorImportNamespaceAttribute([NotNull] string name)
	{
		ysWXE9aAiJ = name;
	}

	static RazorImportNamespaceAttribute()
	{
	}

	internal static bool mru7KfUHXgeIJYijKyv()
	{
		return b2erXBUhpJg5a9KEpiv == null;
	}

	internal static void Bf23QoxVZU8uWq8wGQT()
	{
	}
}
