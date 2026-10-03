using System;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Searching.Actions;

public class ActionSearchAdjustScoreData
{
	[CompilerGenerated]
	private bool SiutY0IxSpr;

	[CompilerGenerated]
	private string yrOtYCFfHjS;

	[CompilerGenerated]
	private double Q17tYPpMXOX = 1.0;

	[CompilerGenerated]
	private double CvJtYEJFk2x = 1.0;

	[CompilerGenerated]
	private double ft9tYyfdZXk = 1.0;

	private static string IvntY8nU7jm;

	private static string GcstYaF8dT2;

	private static ActionSearchAdjustScoreData NZmtY73TxWP;

	private static ActionSearchAdjustScoreData wVJKa7QdTF7eZxoVOcWK;

	public bool IsAdd
	{
		[CompilerGenerated]
		get
		{
			return SiutY0IxSpr;
		}
		[CompilerGenerated]
		set
		{
			SiutY0IxSpr = value;
		}
	}

	public bool IsMultiply => !IsAdd;

	public string CurrentExe
	{
		[CompilerGenerated]
		get
		{
			return yrOtYCFfHjS;
		}
		[CompilerGenerated]
		set
		{
			yrOtYCFfHjS = value;
		}
	}

	public double DeltaCurrProc
	{
		[CompilerGenerated]
		get
		{
			return Q17tYPpMXOX;
		}
		[CompilerGenerated]
		set
		{
			Q17tYPpMXOX = value;
		}
	}

	public double DeltaGlobal
	{
		[CompilerGenerated]
		get
		{
			return CvJtYEJFk2x;
		}
		[CompilerGenerated]
		set
		{
			CvJtYEJFk2x = value;
		}
	}

	public double DeltaOther
	{
		[CompilerGenerated]
		get
		{
			return ft9tYyfdZXk;
		}
		[CompilerGenerated]
		set
		{
			ft9tYyfdZXk = value;
		}
	}

	public static ActionSearchAdjustScoreData Create(string currExe, string adjString)
	{
		if (string.IsNullOrEmpty(adjString))
		{
			return null;
		}
		int num;
		ActionSearchAdjustScoreData actionSearchAdjustScoreData = default(ActionSearchAdjustScoreData);
		if (currExe == IvntY8nU7jm && adjString == GcstYaF8dT2)
		{
			num = 0;
			if (!wHc9scQdmL3YPbhVJK7n())
			{
				goto IL_004f;
			}
		}
		else
		{
			actionSearchAdjustScoreData = new ActionSearchAdjustScoreData();
			actionSearchAdjustScoreData.CurrentExe = currExe;
			num = 1;
			if (!wHc9scQdmL3YPbhVJK7n())
			{
				goto IL_004f;
			}
		}
		goto IL_0053;
		IL_004f:
		int num2 = default(int);
		num = num2;
		goto IL_0053;
		IL_0053:
		switch (num)
		{
		default:
			return NZmtY73TxWP;
		case 1:
		{
			if (adjString[0] == '+')
			{
				actionSearchAdjustScoreData.IsAdd = true;
			}
			else
			{
				if (adjString[0] != '*')
				{
					return null;
				}
				actionSearchAdjustScoreData.IsAdd = false;
			}
			string[] array = adjString.Substring(1).Split(';');
			if (array.Length != 3)
			{
				return null;
			}
			actionSearchAdjustScoreData.DeltaCurrProc = Convert.ToDouble(array[0].Trim());
			actionSearchAdjustScoreData.DeltaGlobal = Convert.ToDouble(array[1].Trim());
			actionSearchAdjustScoreData.DeltaOther = Convert.ToDouble(array[2].Trim());
			NZmtY73TxWP = actionSearchAdjustScoreData;
			IvntY8nU7jm = currExe;
			GcstYaF8dT2 = adjString;
			return actionSearchAdjustScoreData;
		}
		}
	}

	public bool IsNoAdjust()
	{
		if (string.IsNullOrEmpty(CurrentExe))
		{
			return true;
		}
		if (DeltaCurrProc == DeltaGlobal)
		{
			return DeltaGlobal == DeltaOther;
		}
		return false;
	}

	internal int g4GtYJsaroi(int int_0, bool bool_1, bool bool_2, bool bool_3)
	{
		if (IsMultiply)
		{
			if (bool_1)
			{
				return (int)((double)int_0 * DeltaCurrProc);
			}
			if (bool_2)
			{
				return (int)((double)int_0 * DeltaGlobal);
			}
			if (bool_3)
			{
				return (int)((double)int_0 * DeltaOther);
			}
			return int_0;
		}
		if (bool_1)
		{
			return (int)((double)int_0 + DeltaCurrProc);
		}
		if (bool_2)
		{
			return (int)((double)int_0 + DeltaGlobal);
		}
		if (bool_3)
		{
			return (int)((double)int_0 + DeltaOther);
		}
		return int_0;
	}

	static ActionSearchAdjustScoreData()
	{
	}

	internal static bool wHc9scQdmL3YPbhVJK7n()
	{
		return wVJKa7QdTF7eZxoVOcWK == null;
	}

	internal static void MF3sHmQdhkePiIOEtspD()
	{
	}
}
