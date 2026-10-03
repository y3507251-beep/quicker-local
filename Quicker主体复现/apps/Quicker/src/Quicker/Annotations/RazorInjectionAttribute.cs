using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorInjectionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string p3aXyor4bD;

	[CompilerGenerated]
	private readonly string LCVX8ZUciW;

	private static RazorInjectionAttribute KLRT67xQiF8lVW1sLFA;

	[NotNull]
	public string Type
	{
		[CompilerGenerated]
		get
		{
			return p3aXyor4bD;
		}
	}

	[NotNull]
	public string FieldName
	{
		[CompilerGenerated]
		get
		{
			return LCVX8ZUciW;
		}
	}

	public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
	{
		p3aXyor4bD = type;
		LCVX8ZUciW = fieldName;
	}

	internal static bool rgRQnhxFGSc01B5acso()
	{
		return KLRT67xQiF8lVW1sLFA == null;
	}
}
