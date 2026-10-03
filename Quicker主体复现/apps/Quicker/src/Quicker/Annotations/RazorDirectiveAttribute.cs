using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorDirectiveAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string OqgXaL3xPN;

	private static RazorDirectiveAttribute T6AZTZxWhuP7eCflPT8;

	[NotNull]
	public string Directive
	{
		[CompilerGenerated]
		get
		{
			return OqgXaL3xPN;
		}
	}

	public RazorDirectiveAttribute([NotNull] string directive)
	{
		OqgXaL3xPN = directive;
	}

	static RazorDirectiveAttribute()
	{
	}

	internal static bool b1d3rdxylvhWyxXPuL3()
	{
		return T6AZTZxWhuP7eCflPT8 == null;
	}

	internal static void JknOEyxXuUGueQxJBG7()
	{
	}
}
