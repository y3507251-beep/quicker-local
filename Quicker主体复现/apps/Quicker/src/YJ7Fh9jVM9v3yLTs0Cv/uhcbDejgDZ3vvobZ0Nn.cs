using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using HMdjedXPwaug8yh9mEq;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Entities;
using Quicker.Domain.QuickActions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Hooks;
using Quicker.View.Hotkeys;
using SWBMfZYGyc6L9yHIvKQ;
using WindowsInput.Native;

namespace YJ7Fh9jVM9v3yLTs0Cv;

internal static class uhcbDejgDZ3vvobZ0Nn
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public HotkeyWatcherItem nvNvQEVKSSV;

		internal static _003C_003Ec__DisplayClass9_0 TfPySOcmwIQopJg35Kk5;

		internal void inMvQPmxGbb(Task t)
		{
			QuickActionRunner.RunQuickActionAsync(AppState.HS2taepcAbc(), nvNvQEVKSSV, AppState.Y2RtaqSv0AQ(), AppState.AppServer, false, ActionTrigger.HotkeyWatcher, "");
		}

		internal static bool XZPrlgcmTI9gjfdciQXb()
		{
			return TfPySOcmwIQopJg35Kk5 == null;
		}
	}

	private static IDictionary<int, IList<HotkeyWatcherItem>> xJttWimug3W;

	private static string DSStW3rU3l3;

	private static long v4XtWf4OvQF;

	private static Hotkey nOKtWzOtuRO;

	private static object gqxtkwv1Xb5;

	private static object pSN1oRQJSx43LwbNvZAR;

	public static void znHtWMAT5Vy()
	{
		JWStWAwZ2HF();
	}

	private static void JWStWAwZ2HF()
	{
		lock (gqxtkwv1Xb5)
		{
			xJttWimug3W.Clear();
			ExeSettings exeSettings = AppState.DataService.yQWt6ownR4Z("_global", true);
			if (!exeSettings.HotkeyWatcherItems.HasData())
			{
				return;
			}
			int num2 = default(int);
			foreach (HotkeyWatcherItem hotkeyWatcherItem in exeSettings.HotkeyWatcherItems)
			{
				if (!hotkeyWatcherItem.IsEnabled)
				{
					continue;
				}
				int num = 0;
				if (pSN1oRQJSx43LwbNvZAR != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (AppHelper.IsMachineValid(hotkeyWatcherItem.ValidForMachines))
				{
					if (hotkeyWatcherItem.Hotkey1 != null)
					{
						leqtWOmct9h(hotkeyWatcherItem, hotkeyWatcherItem.Hotkey1);
					}
					if (hotkeyWatcherItem.Hotkey2 != null)
					{
						leqtWOmct9h(hotkeyWatcherItem, hotkeyWatcherItem.Hotkey2);
					}
				}
			}
		}
	}

	private static void leqtWOmct9h(HotkeyWatcherItem hotkeyWatcherItem_0, Hotkey hotkey_1)
	{
		int key = (int)hotkey_1.Key;
		if (key != 0)
		{
			if (!xJttWimug3W.ContainsKey(key))
			{
				xJttWimug3W[key] = new List<HotkeyWatcherItem> { hotkeyWatcherItem_0 };
			}
			else if (!xJttWimug3W[key].Contains(hotkeyWatcherItem_0))
			{
				xJttWimug3W[key].Add(hotkeyWatcherItem_0);
			}
		}
	}

	public static void NQZtWFXCKDx(HookKeyEventArgs hookKeyEventArgs_0)
	{
		Keys keyCode = hookKeyEventArgs_0.KeyCode;
		if (!xJttWimug3W.ContainsKey((int)hookKeyEventArgs_0.KeyCode))
		{
			NdctWlgbJk1();
			return;
		}
		string currentProcessName = AppState.CurrentProcessName;
		bool num = currentProcessName != DSStW3rU3l3 || AppHelper.fLiLTj0x4QY() - v4XtWf4OvQF > 500L || nOKtWzOtuRO == null;
		ModifierKeys modifierKeys = JrJWiKYIEBcPm8FFZOl.Modifiers;
		if (AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.LWIN) || AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.RWIN))
		{
			modifierKeys |= ModifierKeys.Windows;
		}
		if (AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.LMENU) || AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.RMENU))
		{
			modifierKeys |= ModifierKeys.Alt;
		}
		if (AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.LSHIFT) || AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.RSHIFT))
		{
			modifierKeys |= ModifierKeys.Shift;
		}
		if (AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.LCONTROL) || AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(VirtualKeyCode.RCONTROL))
		{
			modifierKeys |= ModifierKeys.Control;
		}
		new Hotkey((VirtualKeyCode)hookKeyEventArgs_0.KeyCode, modifierKeys);
		if (num)
		{
			foreach (HotkeyWatcherItem item in xJttWimug3W[(int)hookKeyEventArgs_0.KeyCode])
			{
				if (item.IsMatchHotkey1(hookKeyEventArgs_0, modifierKeys) && brgW8EX9ZVfZExh7q9t.EhutpR97mio(item.BindingProcessName, item.BlackList, currentProcessName, true) && item.Hotkey2 == null)
				{
					DA4tWUR26XI(item);
				}
			}
		}
		else
		{
			int num3 = default(int);
			foreach (HotkeyWatcherItem item2 in xJttWimug3W[(int)hookKeyEventArgs_0.KeyCode])
			{
				if (!brgW8EX9ZVfZExh7q9t.EhutpR97mio(item2.BindingProcessName, item2.BlackList, currentProcessName, true))
				{
					continue;
				}
				bool flag = false;
				int num2 = 0;
				if (!d33khRQJw4XqnuEfA0ut())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				if ((item2.Hotkey2 != null) ? (nOKtWzOtuRO.Equals(item2.Hotkey1) && item2.IsMatchHotkey2(hookKeyEventArgs_0, modifierKeys)) : item2.IsMatchHotkey1(hookKeyEventArgs_0, modifierKeys))
				{
					DA4tWUR26XI(item2);
				}
			}
		}
		DSStW3rU3l3 = currentProcessName;
		nOKtWzOtuRO = new Hotkey((VirtualKeyCode)hookKeyEventArgs_0.KeyCode, modifierKeys);
		v4XtWf4OvQF = AppHelper.fLiLTj0x4QY();
	}

	private static void DA4tWUR26XI(HotkeyWatcherItem hotkeyWatcherItem_0)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.nvNvQEVKSSV = hotkeyWatcherItem_0;
		if (_003C_003Ec__DisplayClass9_.nvNvQEVKSSV.DelayMs > 0)
		{
			Task.Delay(_003C_003Ec__DisplayClass9_.nvNvQEVKSSV.DelayMs).ContinueWith(_003C_003Ec__DisplayClass9_.inMvQPmxGbb);
		}
		else
		{
			QuickActionRunner.RunQuickActionAsync(AppState.HS2taepcAbc(), _003C_003Ec__DisplayClass9_.nvNvQEVKSSV, AppState.Y2RtaqSv0AQ(), AppState.AppServer, false, ActionTrigger.HotkeyWatcher, "");
		}
		AppState.Lista4qx2wK().CountHotkeyWatcher();
	}

	private static void NdctWlgbJk1()
	{
		nOKtWzOtuRO = null;
		v4XtWf4OvQF = 0L;
		DSStW3rU3l3 = null;
	}

	static uhcbDejgDZ3vvobZ0Nn()
	{
		xJttWimug3W = new Dictionary<int, IList<HotkeyWatcherItem>>();
		gqxtkwv1Xb5 = new object();
	}

	internal static bool d33khRQJw4XqnuEfA0ut()
	{
		return pSN1oRQJSx43LwbNvZAR == null;
	}
}
