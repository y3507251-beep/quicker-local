using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Services;

public static class ActionFeedbackHelper
{
	[CompilerGenerated]
	private static readonly IList<Guid> wLwtHwd5Lkx;

	[CompilerGenerated]
	private static readonly IList<Guid> jCNtHt32fep;

	internal static object gvR92TQaa7KJIdWZTe1J;

	public static IList<Guid> VerifiedActions
	{
		[CompilerGenerated]
		get
		{
			return wLwtHwd5Lkx;
		}
	}

	public static IList<Guid> PendingVerifyActions
	{
		[CompilerGenerated]
		get
		{
			return jCNtHt32fep;
		}
	}

	public static void AddAction(Guid sharedActionId)
	{
		if (!wLwtHwd5Lkx.Contains(sharedActionId))
		{
			if (!jCNtHt32fep.Contains(sharedActionId))
			{
				jCNtHt32fep.Add(sharedActionId);
			}
			wLwtHwd5Lkx.Add(sharedActionId);
		}
	}

	public static void RetryAction(Guid sharedActionId)
	{
		if (!jCNtHt32fep.Contains(sharedActionId))
		{
			jCNtHt32fep.Add(sharedActionId);
		}
	}

	public static bool ShouldShowFeedback(Guid sharedActionId)
	{
		return jCNtHt32fep.Contains(sharedActionId);
	}

	public static void RemoveFeedbackItem(Guid sharedActionId)
	{
		if (jCNtHt32fep.Contains(sharedActionId))
		{
			jCNtHt32fep.Remove(sharedActionId);
		}
	}

	static ActionFeedbackHelper()
	{
		wLwtHwd5Lkx = new List<Guid>();
		jCNtHt32fep = new List<Guid>();
	}

	internal static bool VLKp7IQarZC54TQp9wQ3()
	{
		return gvR92TQaa7KJIdWZTe1J == null;
	}
}
