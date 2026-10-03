using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Quicker.Common;
using Quicker.Domain.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Services;

public class RunningActionMgr
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec B0yvTpe840g;

		public static Func<ActionExecuteContext, ActionItem> rKWvTBefTxX;

		public static Func<ActionItem, string> JUbvTQNbXE6;

		private static _003C_003Ec bMZJXmWpMDW99i9HxFPE;

		static _003C_003Ec()
		{
			B0yvTpe840g = new _003C_003Ec();
		}

		internal ActionItem ikQvTxApjD1(ActionExecuteContext x)
		{
			return x.Action;
		}

		internal string O7xvTrypmBD(ActionItem a)
		{
			return $"{a.Id} {a.TemplateId} {a.Title} {a.TemplateRevision}";
		}

		internal static bool Sw7fGFWpUGF3aahbx3fu()
		{
			return bMZJXmWpMDW99i9HxFPE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public string OOEvTnBrayx;

		private static _003C_003Ec__DisplayClass13_0 bbr228WpIwaOhOfJtRed;

		internal bool n16vTjJr9NB(ActionExecuteContext x)
		{
			return x.ActionId == OOEvTnBrayx;
		}

		internal static bool f1oNThWp6C0KWZOpps1E()
		{
			return bbr228WpIwaOhOfJtRed == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public string uUFvT5eRalO;

		private static _003C_003Ec__DisplayClass14_0 Act8uRWpSMHfibhbGyXc;

		internal bool KDdvT4fKEkn(ActionExecuteContext x)
		{
			return x.ActionId == uUFvT5eRalO;
		}

		internal static bool e1GjkdWpwPAoYBbHBkPt()
		{
			return Act8uRWpSMHfibhbGyXc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public string g46vTdKpXex;

		internal static _003C_003Ec__DisplayClass15_0 uDp2UUWpmX7NturYDeia;

		internal bool HtuvTDNNNJs(ActionExecuteContext x)
		{
			return x.ActionId == g46vTdKpXex;
		}

		internal static bool XXpYCJWpsMUQtMYQqao9()
		{
			return uDp2UUWpmX7NturYDeia == null;
		}
	}

	private readonly ConcurrentDictionary<int, ActionExecuteContext> CnytQRdTSyq = new ConcurrentDictionary<int, ActionExecuteContext>();

	private static readonly ILog KhNtQqqY38D;

	private static RunningActionMgr gWUL2sQ94UJG1cL53lHu;

	public IList<ActionExecuteContext> Items => CnytQRdTSyq.Values.ToList();

	public string GetAllRunningActions()
	{
		return string.Join("\r\n", CnytQRdTSyq.Values.Select(_003C_003Ec.rKWvTBefTxX ?? (_003C_003Ec.rKWvTBefTxX = _003C_003Ec.B0yvTpe840g.ikQvTxApjD1)).Select(_003C_003Ec.JUbvTQNbXE6 ?? (_003C_003Ec.JUbvTQNbXE6 = _003C_003Ec.B0yvTpe840g.O7xvTrypmBD)));
	}

	public (int stopCount, int ignoreCount) StopAll()
	{
		int num = 0;
		int num2 = 0;
		try
		{
			foreach (KeyValuePair<int, ActionExecuteContext> item in CnytQRdTSyq)
			{
				if (!item.Value.Action.SkipWhenStopRunningActions)
				{
					item.Value.IsStoppedByUser = true;
					item.Value.StopAction(ActionStopFlag.ForceStop, "用户停止所有动作");
					num2++;
				}
				else
				{
					num++;
				}
			}
			string text = $"共取消了{num2}个动作";
			if (num > 0)
			{
				text += $",忽略了{num}个动作";
			}
			text += "。";
			AppHelper.ShowInformation(text);
			return (stopCount: num2, ignoreCount: num);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("取消任务出错：" + ex.Message);
			return (stopCount: num2, ignoreCount: num);
		}
	}

	public int StopActionByIdOrName(string actionIdOrName, int currentContextId, bool skipWarning = false)
	{
		int num = 0;
		foreach (KeyValuePair<int, ActionExecuteContext> item in CnytQRdTSyq)
		{
			if (gWUL2sQ94UJG1cL53lHu == null)
			{
				switch (0)
				{
				}
			}
			if ((item.Value.ActionId == actionIdOrName || item.Value.Action.Title == actionIdOrName) && item.Value.Id != currentContextId)
			{
				item.Value.IsStoppedByUser = true;
				item.Value.SkipStopWarning = skipWarning;
				item.Value.StopAction(ActionStopFlag.ForceStop, "用户停止动作");
				num++;
			}
		}
		return num;
	}

	public void Stop(ActionExecuteContext context)
	{
		try
		{
			context.IsStoppedByUser = true;
			context.StopAction(ActionStopFlag.ForceStop, "用户停止此动作");
			CnytQRdTSyq.TryRemove(context.Id, out context);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("取消任务出错：" + ex.Message);
		}
	}

	public void Add(ActionExecuteContext context)
	{
		CnytQRdTSyq[context.Id] = context;
		T91tQ7w7Sx7();
	}

	private void T91tQ7w7Sx7()
	{
		DataService dataService = AppState.DataService;
		if (dataService == null || dataService.CpItmVISR7P()?.ShowRunningCountOnTrayIcon != true)
		{
			return;
		}
		lock (AppState.NotifyIconWrapper)
		{
			try
			{
				AppState.NotifyIconWrapper?.RefreshActionCount();
			}
			catch (Exception ex)
			{
				KhNtQqqY38D.Warn("刷新角标出错：" + ex.Message, ex);
			}
		}
	}

	public void Remove(ActionExecuteContext context)
	{
		if (CnytQRdTSyq.ContainsKey(context.Id))
		{
			CnytQRdTSyq.TryRemove(context.Id, out context);
		}
		T91tQ7w7Sx7();
	}

	public int Count()
	{
		return CnytQRdTSyq.Count;
	}

	public bool IsCurrentActionRunning(string actionId)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.OOEvTnBrayx = actionId;
		return CnytQRdTSyq.Values.Count(_003C_003Ec__DisplayClass13_.n16vTjJr9NB) > 1;
	}

	public bool IsActionRunning(string actionId)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_.uUFvT5eRalO = actionId;
		return CnytQRdTSyq.Values.Count(_003C_003Ec__DisplayClass14_.KDdvT4fKEkn) > 0;
	}

	public int GetActionRunningCount(string actionId)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.g46vTdKpXex = actionId;
		return CnytQRdTSyq.Values.Count(_003C_003Ec__DisplayClass15_.HtuvTDNNNJs);
	}

	static RunningActionMgr()
	{
		KhNtQqqY38D = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool JNoVC1Q9hQXqdam6CKjR()
	{
		return gWUL2sQ94UJG1cL53lHu == null;
	}
}
