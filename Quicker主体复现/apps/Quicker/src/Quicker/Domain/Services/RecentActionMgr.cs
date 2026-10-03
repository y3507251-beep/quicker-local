using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.Domain.Services;

public class RecentActionMgr
{
	public const int MAX_COUNT = 12;

	[CompilerGenerated]
	private IList<string> fu5tKnQKGa8;

	private object UF6tK4VJEHS = new object();

	[CompilerGenerated]
	private string ChKtK5msBy0;

	private static RecentActionMgr KgQZnqQrwXYb7Vml7elH;

	public IList<string> RecentActions
	{
		[CompilerGenerated]
		get
		{
			return fu5tKnQKGa8;
		}
		[CompilerGenerated]
		private set
		{
			fu5tKnQKGa8 = value;
		}
	}

	public string LastActionParam
	{
		[CompilerGenerated]
		get
		{
			return ChKtK5msBy0;
		}
		[CompilerGenerated]
		set
		{
			ChKtK5msBy0 = value;
		}
	}

	public RecentActionMgr()
	{
		try
		{
			RecentActions = dDh7g7Xw7JyQPUTbYwJ.okJtHx8iWyG().ToList();
		}
		catch (Exception)
		{
			RecentActions = new List<string>();
		}
	}

	public void RecordLastAction(string actionId, string paramData)
	{
		if (!Monitor.TryEnter(UF6tK4VJEHS))
		{
			return;
		}
		LastActionParam = paramData;
		try
		{
			int num = RecentActions.IndexOf(actionId);
			if (num == 0)
			{
				return;
			}
			if (num > 0)
			{
				RecentActions.RemoveAt(num);
			}
			RecentActions.Insert(0, actionId);
			int num2 = 0;
			if (KgQZnqQrwXYb7Vml7elH != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (RecentActions.Count > 12)
			{
				RecentActions.RemoveAt(RecentActions.Count - 1);
			}
			dDh7g7Xw7JyQPUTbYwJ.UVhtHrfISJb(RecentActions);
		}
		finally
		{
			Monitor.Exit(UF6tK4VJEHS);
		}
	}

	public string GetLastActionId()
	{
		if (RecentActions.Count > 0)
		{
			return RecentActions[0];
		}
		return "";
	}

	internal static void uk0ca8Qrs4VeMThXnJ3U()
	{
	}

	internal static bool meNO0HQrTd3knogqAHvX()
	{
		return KgQZnqQrwXYb7Vml7elH == null;
	}
}
