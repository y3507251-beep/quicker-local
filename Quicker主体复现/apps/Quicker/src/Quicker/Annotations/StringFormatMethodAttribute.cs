using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
public sealed class StringFormatMethodAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string qqm6pqBPGZ;

	internal static StringFormatMethodAttribute HgY8IpgxhPixSLGCinY;

	[NotNull]
	public string FormatParameterName
	{
		[CompilerGenerated]
		get
		{
			return qqm6pqBPGZ;
		}
	}

	public StringFormatMethodAttribute([NotNull] string formatParameterName)
	{
		qqm6pqBPGZ = formatParameterName;
	}

	static StringFormatMethodAttribute()
	{
	}

	internal static bool B6WktCgIoPBXy5gmMZj()
	{
		return HgY8IpgxhPixSLGCinY == null;
	}

	internal static void IeuDAvgtNy66b6og6fr()
	{
	}
}
