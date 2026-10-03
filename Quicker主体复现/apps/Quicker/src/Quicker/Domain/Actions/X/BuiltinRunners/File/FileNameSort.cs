using System.Collections;
using System.Runtime.InteropServices;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class FileNameSort : IComparer
{
	internal static FileNameSort Ynlla4QtNZDR6tXs1uYt;

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, EntryPoint = "StrCmpLogicalW")]
	private static extern int yujgc9TZlk0(string string_0, string string_1);

	public int Compare(object name1, object name2)
	{
		if (name1 == null && name2 == null)
		{
			return 0;
		}
		if (name1 == null)
		{
			return -1;
		}
		if (name2 == null)
		{
			return 1;
		}
		return yujgc9TZlk0(name1.ToString(), name2.ToString());
	}

	internal static bool jpOVAsQt9OEfqdkNsuSx()
	{
		return Ynlla4QtNZDR6tXs1uYt == null;
	}
}
