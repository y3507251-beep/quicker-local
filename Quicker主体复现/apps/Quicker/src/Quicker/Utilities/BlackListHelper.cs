using System;
using System.Linq;

namespace Quicker.Utilities;

public static class BlackListHelper
{
	private static object howHGbFZ1lSWyTPn2KTi;

	public static bool IsProcessInBlackList(string processName, string blackListStr)
	{
		if (string.IsNullOrWhiteSpace(blackListStr))
		{
			return false;
		}
		return blackListStr.ToLower().Split(new char[6] { ';', '；', ',', '，', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Contains(processName.ToLower());
	}

	internal static bool UOw1cVFZKOeVvKB4AbgF()
	{
		return howHGbFZ1lSWyTPn2KTi == null;
	}
}
