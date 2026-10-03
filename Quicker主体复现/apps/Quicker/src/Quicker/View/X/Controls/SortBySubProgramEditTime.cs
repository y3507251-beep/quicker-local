using System;
using System.Collections;
using Quicker.Domain.Actions.X;

namespace Quicker.View.X.Controls;

public class SortBySubProgramEditTime : IComparer
{
	internal static SortBySubProgramEditTime ddPstiF9O3B2mkisVmYj;

	public int Compare(SubProgram x, SubProgram y)
	{
		if (!((x.LastEditTimeUtc ?? DateTime.MinValue) > (y.LastEditTimeUtc ?? DateTime.MinValue)))
		{
			return 1;
		}
		return -1;
	}

	public int Compare(object x, object y)
	{
		if (x != null && y != null)
		{
			return Compare((SubProgram)x, (SubProgram)y);
		}
		return 0;
	}

	internal static bool C0UoWaF9JILgNGPOhP6Y()
	{
		return ddPstiF9O3B2mkisVmYj == null;
	}
}
