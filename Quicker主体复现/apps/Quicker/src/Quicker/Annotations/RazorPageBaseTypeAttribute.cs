using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorPageBaseTypeAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string boZX7vfIZq;

	[CompilerGenerated]
	private readonly string oEJXR7xYJV;

	internal static RazorPageBaseTypeAttribute aLXywFx2dwHQdYnO2rC;

	[NotNull]
	public string BaseType
	{
		[CompilerGenerated]
		get
		{
			return boZX7vfIZq;
		}
	}

	[CanBeNull]
	public string PageName
	{
		[CompilerGenerated]
		get
		{
			return oEJXR7xYJV;
		}
	}

	public RazorPageBaseTypeAttribute([NotNull] string baseType)
	{
		boZX7vfIZq = baseType;
	}

	public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
	{
		boZX7vfIZq = baseType;
		oEJXR7xYJV = pageName;
	}

	internal static bool puRONBxAJ19RRA3HBU0()
	{
		return aLXywFx2dwHQdYnO2rC == null;
	}
}
