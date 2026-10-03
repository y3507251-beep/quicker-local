using System;
using System.Collections;
using Quicker.Domain.Actions.X;

namespace Quicker.View.X.Controls;

public class SortBySubProgramName : IComparer
{
	private static SortBySubProgramName lOxLcTF9KWPGIS2Bp1iu;

	public int Compare(SubProgram x, SubProgram y)
	{
		return string.Compare(x.Name, y.Name, StringComparison.CurrentCultureIgnoreCase);
	}

	public int Compare(object x, object y)
	{
		if (x != null && y != null)
		{
			return Compare((SubProgram)x, (SubProgram)y);
		}
		return 0;
	}

	internal static bool feQ7nAF9Bv8WgV5sEx7l()
	{
		return lOxLcTF9KWPGIS2Bp1iu == null;
	}
}
