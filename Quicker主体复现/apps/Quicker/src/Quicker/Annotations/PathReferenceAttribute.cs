using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class PathReferenceAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string u906OAjbPA;

	private static PathReferenceAttribute fJdOiyPPsnPJsZOL5S7;

	[CanBeNull]
	public string BasePath
	{
		[CompilerGenerated]
		get
		{
			return u906OAjbPA;
		}
	}

	public PathReferenceAttribute()
	{
	}

	public PathReferenceAttribute([NotNull][PathReference] string basePath)
	{
		u906OAjbPA = basePath;
	}

	internal static bool iByUuHPMdLycL1ayO6n()
	{
		return fJdOiyPPsnPJsZOL5S7 == null;
	}

	internal static void Me6qJmPxbAAInEIYh5B()
	{
	}
}
