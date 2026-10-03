using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using log4net;
using Microsoft.Win32;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View;
using Quicker.View.CircleMenu;
using Quicker.View.Main;

namespace Quicker.Domain.Services;

public class SystemEventsWatcher
{
	private static readonly ILog t3PtQh6XfiU;

	private IList<WeakReference<Window>> qkUtQew4YZK = new List<WeakReference<Window>>();

	internal static SystemEventsWatcher EI5BpkQLQiXJhpQpaU2d;

	public void Start()
	{
		SystemEvents.PowerModeChanged += W1btQVsFaDb;
		SystemEvents.SessionSwitch += E1EtQZyGFh9;
		SystemEvents.DisplaySettingsChanged += HhAtQcFpI1K;
	}

	private void HhAtQcFpI1K(object sender, EventArgs e)
	{
		try
		{
			AppState.vVktaZmxU7S()?.RequestUpdateLocation();
		}
		catch (Exception ex)
		{
			t3PtQh6XfiU.Warn("显示设置改变回调出错：" + ex.Message, ex);
		}
	}

	private void W1btQVsFaDb(object sender, PowerModeChangedEventArgs e)
	{
		switch (e.Mode)
		{
		case PowerModes.Suspend:
			t3PtQh6XfiU.Info("电脑将要休眠");
			AppState.IsComputerSuspended = true;
			break;
		case PowerModes.Resume:
		{
			AppState.LastSystemResumeTime = AppHelper.fLiLTj0x4QY();
			t3PtQh6XfiU.Info($"电源状态改变：{e.Mode}");
			try
			{
				AppState.e8GtaFtc06Z()?.RestartAfterSystemSleep("PowerModeChanged");
			}
			catch (Exception exception)
			{
				t3PtQh6XfiU.Warn("唤醒时处理出错！" + exception.GetMessageWithInner());
			}
			AppState.IsComputerSuspended = false;
			DataService dataService = AppState.DataService;
			if (dataService != null && dataService.Hb9tmk3OsJ7())
			{
				int num = 0;
				if (EI5BpkQLQiXJhpQpaU2d != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					AppState.DataService.xdNt6mQNakh(false);
					break;
				}
			}
			break;
		}
		}
	}

	private void E1EtQZyGFh9(object sender, SessionSwitchEventArgs e)
	{
		if (AppState.v5FtaQ4hQfg() == null)
		{
			t3PtQh6XfiU.Warn("AppState.PopupMgr = null");
			AppHelper.ShowError("AppState.PopupMgr = null", false);
			return;
		}
		try
		{
			IZ2tQ9ynPxb(e);
		}
		catch (Exception ex)
		{
			t3PtQh6XfiU.Warn(ex.Message, ex);
			AppHelper.ShowWarning("处理会话切换出错：" + ex.Message + "。\r\n欢迎报告此问题。");
		}
	}

	private void IZ2tQ9ynPxb(SessionSwitchEventArgs sessionSwitchEventArgs_0)
	{
		if (sessionSwitchEventArgs_0.Reason == SessionSwitchReason.SessionLock)
		{
			AppState.IsWindowsLocked = true;
			try
			{
				t3PtQh6XfiU.Info("会话锁定了");
				qkUtQew4YZK.Clear();
				int num2 = default(int);
				foreach (Window window in Application.Current.Windows)
				{
					if (!(window is CircleMenuWindow))
					{
						if (!(window is GestureWindow))
						{
							if (window.Topmost && window.IsVisible)
							{
								if (window is SelectOperationWindow)
								{
									window.Topmost = false;
									continue;
								}
								window.Hide();
								qkUtQew4YZK.Add(new WeakReference<Window>(window));
							}
							continue;
						}
						int num = 0;
						if (EI5BpkQLQiXJhpQpaU2d != null)
						{
							num = num2;
						}
						switch (num)
						{
						}
					}
					t3PtQh6XfiU.Info("关闭轮盘窗口。");
					AppState.v5FtaQ4hQfg().R8Fvtoeu87h();
				}
				t3PtQh6XfiU.Info($"保存了{qkUtQew4YZK.Count}个TopMost窗口信息");
			}
			catch (Exception exception)
			{
				string message = "会话锁定处理出错！" + exception.GetMessageWithInner();
				t3PtQh6XfiU.Warn(message, exception);
			}
			AppState.v5FtaQ4hQfg().xJ2vLGOZrLf();
		}
		else
		{
			if (sessionSwitchEventArgs_0.Reason != SessionSwitchReason.SessionUnlock)
			{
				return;
			}
			AppState.IsWindowsLocked = false;
			DataService dataService = AppState.DataService;
			if (dataService != null && dataService.Hb9tmk3OsJ7())
			{
				AppState.DataService.xdNt6mQNakh(false);
			}
			AppState.e8GtaFtc06Z()?.RestartAfterSystemSleep("SessionUnlock");
			if (xQytfTQLFE2oW4WerETj())
			{
				switch (0)
				{
				}
			}
			try
			{
				t3PtQh6XfiU.Info("会话解锁了");
				AppState.SessionUnlockTime = AppHelper.fLiLTj0x4QY();
				if (qkUtQew4YZK.HasData())
				{
					int num3 = 0;
					foreach (WeakReference<Window> item in qkUtQew4YZK)
					{
						if (item.TryGetTarget(out var target))
						{
							if (target.IsLoaded)
							{
								target.Show();
							}
							num3++;
						}
					}
					t3PtQh6XfiU.Info($"恢复了{num3}个TopMost窗口信息，共{qkUtQew4YZK.Count}个");
				}
				qkUtQew4YZK.Clear();
			}
			catch (Exception ex)
			{
				string message2 = "会话解锁处理出错：" + ex.Message;
				t3PtQh6XfiU.Warn(message2, ex);
				AppHelper.ShowWarning(message2, true);
			}
			AppState.v5FtaQ4hQfg().XybvLsbQWal();
		}
	}

	static SystemEventsWatcher()
	{
		t3PtQh6XfiU = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool xQytfTQLFE2oW4WerETj()
	{
		return EI5BpkQLQiXJhpQpaU2d == null;
	}
}
