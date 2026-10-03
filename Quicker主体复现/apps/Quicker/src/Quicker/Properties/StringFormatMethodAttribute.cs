using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
public sealed class StringFormatMethodAttribute : Attribute
{
	[CompilerGenerated]
	private string Y3r1kDxPPb;

	internal static StringFormatMethodAttribute RbnZSJ53yTUQgaifSgG;

	[NotNull]
	public string FormatParameterName
	{
		[CompilerGenerated]
		get
		{
			return Y3r1kDxPPb;
		}
		[CompilerGenerated]
		private set
		{
			Y3r1kDxPPb = value;
		}
	}

	public StringFormatMethodAttribute([NotNull] string formatParameterName)
	{
		FormatParameterName = formatParameterName;
	}

	internal static bool pCpbe65E2pvpFHPVDIT()
	{
		return RbnZSJ53yTUQgaifSgG == null;
	}
}
