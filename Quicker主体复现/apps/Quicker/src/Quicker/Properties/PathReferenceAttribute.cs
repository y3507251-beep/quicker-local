using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class PathReferenceAttribute : Attribute
{
	[CompilerGenerated]
	private string gGb1FpJd72;

	internal static PathReferenceAttribute KUWhneYpe543eTqTNmB;

	[CanBeNull]
	public string BasePath
	{
		[CompilerGenerated]
		get
		{
			return gGb1FpJd72;
		}
		[CompilerGenerated]
		private set
		{
			gGb1FpJd72 = value;
		}
	}

	public PathReferenceAttribute()
	{
	}

	public PathReferenceAttribute([NotNull][PathReference] string basePath)
	{
		BasePath = basePath;
	}

	internal static bool UpqcopYXw2COhR7TA4s()
	{
		return KUWhneYpe543eTqTNmB == null;
	}
}
