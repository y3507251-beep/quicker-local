using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
public sealed class PublicAPIAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string dpa6Mm0ZNQ;

	internal static PublicAPIAttribute ervp6kPrIUO221o58XN;

	[CanBeNull]
	public string Comment
	{
		[CompilerGenerated]
		get
		{
			return dpa6Mm0ZNQ;
		}
	}

	public PublicAPIAttribute()
	{
	}

	public PublicAPIAttribute([NotNull] string comment)
	{
		dpa6Mm0ZNQ = comment;
	}

	static PublicAPIAttribute()
	{
	}

	internal static bool FLyW33PNB4dBZSDfPGW()
	{
		return ervp6kPrIUO221o58XN == null;
	}

	internal static void SsZqbqPLtpxQjhB2Y2k()
	{
	}
}
