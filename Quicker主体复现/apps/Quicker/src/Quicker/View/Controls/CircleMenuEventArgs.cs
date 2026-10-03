using System;
using System.Runtime.CompilerServices;
using Quicker.Common;

namespace Quicker.View.Controls;

public class CircleMenuEventArgs : EventArgs
{
	[CompilerGenerated]
	private int u4ALBJC6MYl;

	[CompilerGenerated]
	private ActionItem mtULB0q8q4f;

	private static CircleMenuEventArgs IUhsxNFfLWbseM6F2CIi;

	public int Position
	{
		[CompilerGenerated]
		get
		{
			return u4ALBJC6MYl;
		}
		[CompilerGenerated]
		set
		{
			u4ALBJC6MYl = value;
		}
	}

	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return mtULB0q8q4f;
		}
		[CompilerGenerated]
		set
		{
			mtULB0q8q4f = value;
		}
	}

	internal static bool GAHkrVFfuwkmxssqtgBF()
	{
		return IUhsxNFfLWbseM6F2CIi == null;
	}
}
