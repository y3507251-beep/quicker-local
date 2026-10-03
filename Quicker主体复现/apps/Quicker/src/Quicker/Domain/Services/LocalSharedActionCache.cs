using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Quicker.Common.Vm;

namespace Quicker.Domain.Services;

public class LocalSharedActionCache
{
	private readonly IDictionary<string, SharedActionDto> KP4txrBl0Sl = new ConcurrentDictionary<string, SharedActionDto>();

	private static LocalSharedActionCache O8ouH8QNda7GyMPPZBDl;

	public SharedActionDto Get(Guid id, int revision)
	{
		string key = srjtxxTaBQ6(id, revision);
		if (KP4txrBl0Sl.ContainsKey(key))
		{
			return KP4txrBl0Sl[key];
		}
		return null;
	}

	public void Save(SharedActionDto sharedAction)
	{
		string key = srjtxxTaBQ6(sharedAction.Id, sharedAction.Revision);
		KP4txrBl0Sl[key] = sharedAction;
	}

	private static string srjtxxTaBQ6(Guid guid_0, int int_0)
	{
		return $"{guid_0}:{int_0}";
	}

	internal static bool bgcoGRQNOiOhRoieEfcx()
	{
		return O8ouH8QNda7GyMPPZBDl == null;
	}
}
