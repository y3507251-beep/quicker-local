using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Utilities.Pinyin;

namespace Quicker.Pinyin.Fast1;

public class FastMatchResultNoPosition : IMatchResult
{
	[CompilerGenerated]
	private int WCOv0KADmbG;

	[CompilerGenerated]
	private object yqVv0xAnJis;

	internal static FastMatchResultNoPosition yYm92uccyphUVwIXCF5d;

	public int Score
	{
		[CompilerGenerated]
		get
		{
			return WCOv0KADmbG;
		}
		[CompilerGenerated]
		set
		{
			WCOv0KADmbG = value;
		}
	}

	public bool IsMatch => true;

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return yqVv0xAnJis;
		}
		[CompilerGenerated]
		set
		{
			yqVv0xAnJis = value;
		}
	}

	public bool GetPosition(int pos)
	{
		return false;
	}

	public void SetPosition(int pos)
	{
	}

	public void SetPositionRange(int start, int length)
	{
	}

	public IList<int> GetMatchPositions()
	{
		return Array.Empty<int>();
	}

	internal static bool wmgah0ccpuuMS1dlSAZi()
	{
		return yYm92uccyphUVwIXCF5d == null;
	}
}
