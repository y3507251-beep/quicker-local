using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Utilities.Pinyin;

namespace Quicker.Pinyin.Fast1;

public class FastMatchResult : IMatchResult
{
	public const int MAX_LEN = 128;

	private bool[] q99v0bY6yvf;

	[CompilerGenerated]
	private int y35v06ROlS3 = int.MinValue;

	private IList<int> IUxv0XW3jpE;

	[CompilerGenerated]
	private object oQUv0mpIpqO;

	internal static FastMatchResult bA2AQZccF1HUYCHG8Ona;

	public int Score
	{
		[CompilerGenerated]
		get
		{
			return y35v06ROlS3;
		}
		[CompilerGenerated]
		set
		{
			y35v06ROlS3 = value;
		}
	}

	public bool IsMatch => Score > 0;

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return oQUv0mpIpqO;
		}
		[CompilerGenerated]
		set
		{
			oQUv0mpIpqO = value;
		}
	}

	public FastMatchResult(int len)
	{
		q99v0bY6yvf = new bool[Math.Min(len, 128)];
	}

	public bool GetPosition(int pos)
	{
		if (pos >= 0 && pos < q99v0bY6yvf.Length)
		{
			return q99v0bY6yvf[pos];
		}
		return false;
	}

	public IList<int> GetMatchPositions()
	{
		if (IUxv0XW3jpE == null)
		{
			IUxv0XW3jpE = new List<int>(q99v0bY6yvf.Length);
			for (int i = 0; i < q99v0bY6yvf.Length; i++)
			{
				if (q99v0bY6yvf[i])
				{
					IUxv0XW3jpE.Add(i);
				}
			}
		}
		return IUxv0XW3jpE;
	}

	public void SetPosition(int pos)
	{
		if (pos >= 0 && pos < 128)
		{
			q99v0bY6yvf[pos] = true;
		}
	}

	public void SetPositionRange(int start, int length)
	{
		for (int i = start; i < start + length && i < q99v0bY6yvf.Length; i++)
		{
			q99v0bY6yvf[i] = true;
		}
	}

	public void MergePositions(IMatchResult other)
	{
		if (other == null)
		{
			return;
		}
		for (int i = 0; i < q99v0bY6yvf.Length; i++)
		{
			if (other.GetPosition(i))
			{
				q99v0bY6yvf[i] = true;
			}
		}
	}

	internal static bool hCX9BTcccAeGOebovQju()
	{
		return bA2AQZccF1HUYCHG8Ona == null;
	}
}
