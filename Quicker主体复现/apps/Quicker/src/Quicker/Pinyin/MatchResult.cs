using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Public.Searching;

namespace Quicker.Pinyin;

[Obsolete("请使用Matcher 和 MatchResult")]
public class MatchResult
{
	[CompilerGenerated]
	private int fjmv0gWlUCd = -1;

	[CompilerGenerated]
	private IList<MatchRange> Ghpv0LSMla3;

	public const int NOT_MATCH = -1;

	public const int FULL_MATCH = 500;

	public const int PARTIAL_FROM_START = 300;

	public const int PARTIAL_FROM_MIDDLE = 200;

	public const int NO_CONTINUE = 100;

	internal static MatchResult w8vnbvcFb8mMQoENetob;

	public int Score
	{
		[CompilerGenerated]
		get
		{
			return fjmv0gWlUCd;
		}
		[CompilerGenerated]
		set
		{
			fjmv0gWlUCd = value;
		}
	}

	public IList<MatchRange> MatchRanges
	{
		[CompilerGenerated]
		get
		{
			return Ghpv0LSMla3;
		}
		[CompilerGenerated]
		set
		{
			Ghpv0LSMla3 = value;
		}
	}

	internal static bool oNTq2ScFqvfZX8l7Kp1t()
	{
		return w8vnbvcFb8mMQoENetob == null;
	}
}
