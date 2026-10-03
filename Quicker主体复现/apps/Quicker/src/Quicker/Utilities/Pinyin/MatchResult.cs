using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Pinyin;

namespace Quicker.Utilities.Pinyin;

public class MatchResult : IMatchResult
{
	[CompilerGenerated]
	private int nuYvJ9WMgXt = int.MinValue;

	internal BitVector64 paXvJhSk2gu;

	[CompilerGenerated]
	private int wjhvJeO7KRK = -1;

	[CompilerGenerated]
	private int hMVvJY1pZqw = 63;

	[CompilerGenerated]
	private string UWBvJI5IQi7;

	[CompilerGenerated]
	private object HOevJWcCy5R;

	internal static MatchResult C3Ic78cQx1ykVT1Hp21K;

	public int Score
	{
		[CompilerGenerated]
		get
		{
			return nuYvJ9WMgXt;
		}
		[CompilerGenerated]
		set
		{
			nuYvJ9WMgXt = value;
		}
	}

	public bool IsMatch => Score > 0;

	public int LastMatchPosition
	{
		[CompilerGenerated]
		get
		{
			return wjhvJeO7KRK;
		}
		[CompilerGenerated]
		private set
		{
			wjhvJeO7KRK = value;
		}
	}

	public int FirstMatchPosition
	{
		[CompilerGenerated]
		get
		{
			return hMVvJY1pZqw;
		}
		[CompilerGenerated]
		private set
		{
			hMVvJY1pZqw = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return UWBvJI5IQi7;
		}
		[CompilerGenerated]
		private set
		{
			UWBvJI5IQi7 = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return HOevJWcCy5R;
		}
		[CompilerGenerated]
		set
		{
			HOevJWcCy5R = value;
		}
	}

	public MatchResult(string text)
	{
		Text = text;
	}

	public override string ToString()
	{
		return $"Score:{Score},_positions:{paXvJhSk2gu}";
	}

	public void SetMatchPositionsFromStart(int textLength)
	{
		for (int i = 0; i < textLength && i < 64; i++)
		{
			paXvJhSk2gu.Set(i);
		}
		LastMatchPosition = textLength - 1;
		FirstMatchPosition = 0;
	}

	public void SetMatchPositionsFromPosition(int startPos, int length)
	{
		for (int i = startPos; i < startPos + length && i < 64; i++)
		{
			paXvJhSk2gu.Set(i);
		}
		LastMatchPosition = startPos + length - 1;
		FirstMatchPosition = startPos;
	}

	public void SetPositionRange(int startPos, int length)
	{
		for (int i = startPos; i < startPos + length && i < 64; i++)
		{
			paXvJhSk2gu.Set(i);
		}
	}

	public void SetPosition(int pos)
	{
		if (pos < 64)
		{
			paXvJhSk2gu.Set(pos);
		}
	}

	public bool GetPosition(int pos)
	{
		if (pos >= 64)
		{
			return false;
		}
		return paXvJhSk2gu.Get(pos);
	}

	public IList<int> GetMatchPositions()
	{
		return paXvJhSk2gu.ToList();
	}

	public void SetPositions(BitVector64 positions)
	{
		paXvJhSk2gu = positions;
	}

	private void E6GvJq7O4b8()
	{
		FirstMatchPosition = BitScanner.BitScanForward(paXvJhSk2gu.Data);
		LastMatchPosition = BitScanner.BitScanReverse(paXvJhSk2gu.Data);
	}

	public void CombinePositions(MatchResult other)
	{
		paXvJhSk2gu.Union(other.paXvJhSk2gu);
	}

	public void CombinePositions(BitVector64 other)
	{
		paXvJhSk2gu.Union(other);
	}

	public void ComputeScore(string pattern)
	{
		E6GvJq7O4b8();
		if (LastMatchPosition == Text.Length - 1 && Text.Length < 63 && paXvJhSk2gu.Data == new BitVector64(Text.Length).Data - 1L)
		{
			Score = 950 + pattern.Length - Text.Length;
			return;
		}
		int num = ((FirstMatchPosition == 0) ? 800 : 500);
		if (b8tOwpcQIahU8oNwZIlq())
		{
			switch (0)
			{
			}
		}
		num -= FirstMatchPosition * 4;
		num = num + pattern.Length - Text.Length;
		for (int i = FirstMatchPosition; i <= LastMatchPosition; i++)
		{
			if (!paXvJhSk2gu.Get(i))
			{
				num -= Text.Length - i;
			}
		}
		Score = num;
	}

	public void ComputeScoreAcronym(string pattern)
	{
		E6GvJq7O4b8();
		Score = 500 - FirstMatchPosition * 2 - (LastMatchPosition - FirstMatchPosition - pattern.Length) * 2;
	}

	public void UpdateSimpleMatchScore(string pattern)
	{
		E6GvJq7O4b8();
		Score = 200 - FirstMatchPosition * 2 - (LastMatchPosition - FirstMatchPosition - pattern.Length) * 2;
	}

	internal static bool b8tOwpcQIahU8oNwZIlq()
	{
		return C3Ic78cQx1ykVT1Hp21K == null;
	}
}
