using System;

namespace Quicker.Common.Vm.Sync;

public static class TimeStampHelper
{
	public static long GetTimeStamp()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}
}
