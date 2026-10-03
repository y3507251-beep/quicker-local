using System;
using System.Runtime.CompilerServices;

namespace UniversalRecognizer.PointPatterns;

public struct PointPatternMatchResult
{
	[CompilerGenerated]
	private readonly string VmZaR44qWT;

	[CompilerGenerated]
	private readonly double OLVaq6deat;

	[CompilerGenerated]
	private readonly int tckacRInfw;

	private static object yxuRY0dlgOaSkluihg7;

	public readonly string PatternId
	{
		[CompilerGenerated]
		get
		{
			return VmZaR44qWT;
		}
	}

	public readonly double Probability
	{
		[CompilerGenerated]
		get
		{
			return OLVaq6deat;
		}
	}

	public readonly int PointPatternSetCount
	{
		[CompilerGenerated]
		get
		{
			return tckacRInfw;
		}
	}

	public PointPatternMatchResult(string patternId, double probability, int pointPatternSetCount)
	{
		this = default(PointPatternMatchResult);
		if (probability > 100.0 || probability < 0.0)
		{
			throw new OverflowException("Proability must be between zero (0) and one hundred (100)");
		}
		VmZaR44qWT = patternId;
		OLVaq6deat = probability;
		tckacRInfw = pointPatternSetCount;
	}

	static PointPatternMatchResult()
	{
	}

	internal static bool rEilQadZBfiGLpjK0Zi()
	{
		return yxuRY0dlgOaSkluihg7 == null;
	}

	internal static void SiVcjidYqPmV9UTyGfX()
	{
	}
}
