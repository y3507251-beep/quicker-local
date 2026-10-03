using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
public sealed class PublicAPIAttribute : Attribute
{
	[CompilerGenerated]
	private string EiC1T56Ztf;

	private static PublicAPIAttribute OPjl8V5wnE00TBOjc0I;

	[CanBeNull]
	public string Comment
	{
		[CompilerGenerated]
		get
		{
			return EiC1T56Ztf;
		}
		[CompilerGenerated]
		private set
		{
			EiC1T56Ztf = value;
		}
	}

	public PublicAPIAttribute()
	{
	}

	public PublicAPIAttribute([NotNull] string comment)
	{
		Comment = comment;
	}

	internal static bool NptfaA5TY5qULNTC7Fo()
	{
		return OPjl8V5wnE00TBOjc0I == null;
	}
}
