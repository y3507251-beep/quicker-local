using System;

namespace Quicker.Utilities.UI;

public class EventReducer
{
	private DateTime RRqvSVqIHgh = DateTime.MinValue;

	private static EventReducer aWnoYbFh2Q3WaFSN1xK0;

	public void DoEvent(Action action, int intervalMs)
	{
		if (DateTime.UtcNow > RRqvSVqIHgh.AddMilliseconds(intervalMs))
		{
			RRqvSVqIHgh = DateTime.UtcNow;
			action();
		}
	}

	internal static bool HAB578FhAmaLPwskXDCf()
	{
		return aWnoYbFh2Q3WaFSN1xK0 == null;
	}
}
