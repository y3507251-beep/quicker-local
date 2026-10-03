using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.ContextMenus;
using Quicker.Domain.Messages;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.Utilities.Win32.Monitor;
using tPW96NMSpaXlHvSiZCX;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.View.TextCommands;

public class QuickOperationItem
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BulSQ98729d;

		public static Action pQxSQhhuPKA;

		internal static _003C_003Ec pO9yyqWxxnge8hgfO28E;

		static _003C_003Ec()
		{
			BulSQ98729d = new _003C_003Ec();
		}

		internal void xc5SBQ8Q2qA(QuickOperationContext context)
		{
			if (!string.IsNullOrEmpty(context.QuickActionItem?.ParamData))
			{
				IQuickActionItem quickActionItem = context.QuickActionItem;
				object obj;
				if (quickActionItem == null)
				{
					if (LU3fmDWxIxusvOrD7Vnc())
					{
						switch (0)
						{
						}
					}
					obj = null;
				}
				else
				{
					obj = quickActionItem.ParamData;
				}
				string exeName = (string)obj;
				context.AppServer.LoadExeProfilesAndLock(exeName, false, true);
				if (context.ActionTrigger != ActionTrigger.App)
				{
					context.AppServer.RequestShowPanel();
				}
			}
			else
			{
				context.Hub.NotifyRequestShowPanel(context, (!context.IsFromMouse) ? PopupSource.Keyboard : PopupSource.Mouse);
			}
		}

		internal void AYOSBjuQ9Cw(QuickOperationContext context)
		{
			AppState.AppServer.RequestShowPanel(true, (!context.IsFromMouse) ? PopupSource.Keyboard : PopupSource.Mouse, true);
		}

		internal void U3kSBnWRINB(QuickOperationContext context)
		{
			AppState.AppServer.ShowConfigWindow();
		}

		internal void ARWSB4naTRr(QuickOperationContext context)
		{
			AppState.AppServer.ShowExeSettingsWindow(null);
		}

		internal void hOCSB55EICK(QuickOperationContext context)
		{
			AppHelper.ShowCircleMenu(context.QuickActionItem?.ParamData);
		}

		internal void CJESBDKILBP(QuickOperationContext context)
		{
			AppHelper.RunOnUiThread(false, new _003C_003Ec__DisplayClass49_0
			{
				CZfSQYwKAMu = context
			}.zaoSQeTbehF);
		}

		internal void RVeSBdlOqWQ(QuickOperationContext context)
		{
			context.Hub.TogglePausePopup(context);
		}

		internal void PWsSBoZv58v(QuickOperationContext context)
		{
			AppState.AppServer.RunLastAction(context.ActionTrigger);
		}

		internal void cHYSBTTlTM5(QuickOperationContext context)
		{
			AppHelper.RunOnUiThread(false, new _003C_003Ec__DisplayClass49_1
			{
				cBFSQWvLyXM = context
			}.zEFSQIL3UZo);
		}

		internal void XnRSBM19JaF(QuickOperationContext context)
		{
			VolumeHelper.VolUp();
		}

		internal void gMjSBAqrb3h(QuickOperationContext context)
		{
			VolumeHelper.VolDown();
		}

		internal void YhjSBOpBpH6(QuickOperationContext context)
		{
			VolumeHelper.Mute();
		}

		internal void ntvSBFaHbrH(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);
		}

		internal void dG9SBU54AbK(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
		}

		internal void RtISBl0dsoA(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.MEDIA_STOP);
		}

		internal void w3uSBiqUEmU(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
		}

		internal void huLSB3axbPu(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.BROWSER_BACK);
		}

		internal void U3CSBfqZvAa(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.BROWSER_FORWARD);
		}

		internal void VGGSBzqZLJZ(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.BROWSER_REFRESH);
		}

		internal void A6NSQwVm5GI(QuickOperationContext context)
		{
			QeCVqvMTGqyXjRSCuyP.bc0LFuNtAhp(true);
		}

		internal void bdxSQtEX8qg(QuickOperationContext context)
		{
			QeCVqvMTGqyXjRSCuyP.bc0LFuNtAhp(false);
		}

		internal void BGySQg2mX3F(QuickOperationContext context)
		{
			bool flag = QeCVqvMTGqyXjRSCuyP.HjPLFNlY29G();
			AppHelper.ShowInformation("输入法状态：" + (flag ? "中文" : "英文"));
		}

		internal void PBISQLs3LM6(QuickOperationContext context)
		{
			WindowHelper.CloseForegroundWindow();
		}

		internal void xlmSQvtdlLQ(QuickOperationContext context)
		{
			InputSimulator.Instance.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_W, AppHelper.kPoLTdWFLA7());
		}

		internal void ssrSQS38EpZ(QuickOperationContext context)
		{
			WindowHelper.MinimizeForegroundWindow();
		}

		internal void yCoSQ2tknEr(QuickOperationContext context)
		{
			WindowHelper.MaxmizeForegroundWindow();
		}

		internal void AQESQuWRqfW(QuickOperationContext context)
		{
			WindowHelper.MaximizeOrRestoreForegroundWindow();
		}

		internal void VHPSQNh986D(QuickOperationContext context)
		{
			WindowHelper.EmWLFmQtusT(-25);
		}

		internal void jIqSQJ0t125(QuickOperationContext context)
		{
			WindowHelper.EmWLFmQtusT(25);
		}

		internal void AfaSQ0tRhOh(QuickOperationContext context)
		{
			(bool, bool) tuple = WindowHelper.ToggleTopmost(WindowHelper.GetForegroundOrMousePositionWindow());
			if (tuple.Item1)
			{
				AppHelper.ShowSuccess(tuple.Item2 ? "已置顶" : "已取消");
			}
			else
			{
				AppHelper.ShowWarning("操作失败");
			}
		}

		internal void FpvSQCXmu1o(QuickOperationContext context)
		{
			if (!WindowHelper.hMNLFGcwaHv(WindowHelper.GetForegroundOrMousePositionWindow()))
			{
				AppHelper.ShowWarning("操作失败");
			}
		}

		internal void l3oSQPmHyxv(QuickOperationContext context)
		{
			MonitorHelper.IncreaseBrightness();
		}

		internal void XFySQE9jkL0(QuickOperationContext context)
		{
			MonitorHelper.DecreaseBrightness();
		}

		internal void WmnSQyJG6SS(QuickOperationContext context)
		{
			string text = AppHelper.GetSelectedText(2L).Trim();
			if (!string.IsNullOrEmpty(text))
			{
				AppHelper.ExecuteText(text);
			}
			else
			{
				AppHelper.ShowWarning("无法获取选中内容，或内容为空。");
			}
		}

		internal void IQRSQ8uYBYw(QuickOperationContext context)
		{
			string selectedText = AppHelper.GetSelectedText(2L);
			if (!string.IsNullOrEmpty(selectedText))
			{
				AppHelper.TryOpenUrlOrFile("https://getquicker.net/s?q=" + HttpUtility.UrlEncode(selectedText));
			}
			else
			{
				AppHelper.ShowWarning("无法获取选中内容。");
			}
		}

		internal void zKuSQaDh3FJ(QuickOperationContext context)
		{
			AppHelper.SendCopyKeys();
		}

		internal void KK5SQ7oVrNN(QuickOperationContext context)
		{
			AppHelper.SendPasteKeys();
		}

		internal void DSSSQR8TqNk(QuickOperationContext context)
		{
			ActionHelper.CopyOrPaste(true);
		}

		internal void VOHSQqt6aO7(QuickOperationContext context)
		{
			ActionHelper.CopyOrPaste(false);
		}

		internal void JeuSQcXLlGM(QuickOperationContext context)
		{
			ContentContextMenuService.ShowClipboardContextMenu();
		}

		internal void vIMSQVIuP9i(QuickOperationContext context)
		{
			Task.Run(pQxSQhhuPKA ?? (pQxSQhhuPKA = BulSQ98729d.uJ6SQZteUgx));
		}

		internal void uJ6SQZteUgx()
		{
			int clipboardSequenceNumber = AppState.ClipboardSequenceNumber;
			AppHelper.SendCopyKeys();
			AppHelper.WaitClipboardChange(clipboardSequenceNumber, 300);
			ContentContextMenuService.ShowClipboardContextMenu();
		}

		internal static bool LU3fmDWxIxusvOrD7Vnc()
		{
			return pO9yyqWxxnge8hgfO28E == null;
		}

		internal static void y5xSsJWxtmyXhF9rMVki()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0
	{
		public QuickOperationContext CZfSQYwKAMu;

		internal static _003C_003Ec__DisplayClass49_0 x8kdAUWx4HQKAZqxuFsy;

		internal void zaoSQeTbehF()
		{
			AppServer appServer = CZfSQYwKAMu.AppServer;
			IQuickActionItem quickActionItem = CZfSQYwKAMu.QuickActionItem;
			object obj;
			if (quickActionItem == null)
			{
				obj = null;
			}
			else
			{
				obj = quickActionItem.ParamData;
				if (obj != null)
				{
					goto IL_002b;
				}
			}
			obj = string.Empty;
			goto IL_002b;
			IL_002b:
			appServer.ShowSearchWindow((string)obj, true);
		}

		static _003C_003Ec__DisplayClass49_0()
		{
		}

		internal static bool nnnIAYWxhhb3Qd6A6juh()
		{
			return x8kdAUWx4HQKAZqxuFsy == null;
		}

		internal static void AC14jlWIVM29VaPijKyi()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_1
	{
		public QuickOperationContext cBFSQWvLyXM;

		internal static _003C_003Ec__DisplayClass49_1 HEKealWIQm0gnDNwOeXU;

		internal void zEFSQIL3UZo()
		{
			cBFSQWvLyXM.AppServer.ToggleLockPanel(null);
		}

		internal static bool K2CWvUWIFcpUgdKbhMSj()
		{
			return HEKealWIQm0gnDNwOeXU == null;
		}
	}

	public const string MonitorBrightnessIncrease = "monitor_brightness_increase";

	public const string MonitorBrightnessDecrease = "monitor_brightness_decrease";

	public const string QuickerShowMainWin = "quicker_show_main_win";

	public const string QuickerShowMainWinAutoActivate = "quicker_show_main_win_auto_activate";

	public const string WindowsWindowMaxRestore = "windows_window_max_restore";

	public const string WindowsWindowMin = "windows_window_min";

	public const string OPERATION_SEARCH_SELECTED_TEXT = "search_selected_text";

	public const string OPERATION_COPY = "operation_copy";

	public const string OPERATION_COPY_OR_PASTE = "operation_copy_or_paste";

	public const string OPERATION_COPY_OR_PASTE_NO_HINT = "operation_copy_or_paste_no_hint";

	public const string OPERATION_PASTE = "operation_paste";

	public const string OPERATION_SHOWCONTEXTMENU = "operation_show_context_menu";

	public const string OPERATION_COPY_AND_SHOW_CONTEXTMENU = "operation_copy_and_show_contextmenu";

	[CompilerGenerated]
	private string LHmLS3u75uj;

	[CompilerGenerated]
	private string WFqLSfxCVnJ;

	[CompilerGenerated]
	private string z07LSzwkf9f;

	[CompilerGenerated]
	private bool TXNL2wsAC1m;

	[CompilerGenerated]
	private string lDkL2tBpKTK;

	[CompilerGenerated]
	private string B0GL2guxNoH;

	[CompilerGenerated]
	private Action<QuickOperationContext> OmfL2LV4edE;

	[CompilerGenerated]
	private static IList<QuickOperationItem> CgAL2vntNTP;

	private static QuickOperationItem yovvDVFef2JkAeMqeYN2;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return LHmLS3u75uj;
		}
		[CompilerGenerated]
		set
		{
			LHmLS3u75uj = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return WFqLSfxCVnJ;
		}
		[CompilerGenerated]
		set
		{
			WFqLSfxCVnJ = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return z07LSzwkf9f;
		}
		[CompilerGenerated]
		set
		{
			z07LSzwkf9f = value;
		}
	}

	public bool IsSupportParamData
	{
		[CompilerGenerated]
		get
		{
			return TXNL2wsAC1m;
		}
		[CompilerGenerated]
		set
		{
			TXNL2wsAC1m = value;
		}
	}

	public string ParamDataTitle
	{
		[CompilerGenerated]
		get
		{
			return lDkL2tBpKTK;
		}
		[CompilerGenerated]
		set
		{
			lDkL2tBpKTK = value;
		}
	}

	public string ParamDataNote
	{
		[CompilerGenerated]
		get
		{
			return B0GL2guxNoH;
		}
		[CompilerGenerated]
		set
		{
			B0GL2guxNoH = value;
		}
	}

	public Action<QuickOperationContext> Func
	{
		[CompilerGenerated]
		get
		{
			return OmfL2LV4edE;
		}
		[CompilerGenerated]
		set
		{
			OmfL2LV4edE = value;
		}
	}

	public static IList<QuickOperationItem> AllQuickerOperationItems
	{
		[CompilerGenerated]
		get
		{
			return CgAL2vntNTP;
		}
		[CompilerGenerated]
		set
		{
			CgAL2vntNTP = value;
		}
	}

	static QuickOperationItem()
	{
		CgAL2vntNTP = new List<QuickOperationItem>
		{
			new QuickOperationItem
			{
				Key = "quicker_show_main_win",
				Name = "Quicker：显示面板窗口",
				Description = "显示Quicker主面板窗口",
				Func = _003C_003Ec.BulSQ98729d.xc5SBQ8Q2qA,
				IsSupportParamData = true,
				ParamDataTitle = "场景标识",
				ParamDataNote = "选择场景标识，留空为前台程序场景"
			},
			new QuickOperationItem
			{
				Key = "quicker_show_main_win_auto_activate",
				Name = "Quicker：显示面板窗口（激活鼠标位置窗口）",
				Description = "自动激活鼠标位置窗口，并显示Quicker主面板",
				Func = _003C_003Ec.BulSQ98729d.AYOSBjuQ9Cw
			},
			new QuickOperationItem
			{
				Key = "showConfigWindow",
				Name = "Quicker：打开设置窗口",
				Description = "打开Quicker设置窗口",
				Func = _003C_003Ec.BulSQ98729d.U3kSBnWRINB
			},
			new QuickOperationItem
			{
				Key = "showExeSettingWindow",
				Name = "Quicker：打开场景与动作管理窗口",
				Description = "打开场景与动作管理窗口",
				Func = _003C_003Ec.BulSQ98729d.ARWSB4naTRr
			},
			new QuickOperationItem
			{
				Key = "showCircleMenu",
				Name = "Quicker：打开轮盘菜单 (点击)",
				Description = "弹出轮盘菜单",
				Func = _003C_003Ec.BulSQ98729d.hOCSB55EICK,
				IsSupportParamData = true,
				ParamDataTitle = "场景标识",
				ParamDataNote = "选择场景标识，留空为前台程序场景"
			},
			new QuickOperationItem
			{
				Key = "quicker_show_search",
				Name = "Quicker：打开搜索",
				Description = "显示Quicker搜索窗口",
				Func = _003C_003Ec.BulSQ98729d.CJESBDKILBP,
				IsSupportParamData = true,
				ParamDataTitle = "预置搜索词",
				ParamDataNote = "直接以某个触发词开始搜索"
			},
			new QuickOperationItem
			{
				Key = "quicker_disable",
				Name = "Quicker：禁用Quicker",
				Func = _003C_003Ec.BulSQ98729d.RVeSBdlOqWQ
			},
			new QuickOperationItem
			{
				Key = "quicker_run_last_action",
				Name = "Quicker：运行最后使用的动作",
				Func = _003C_003Ec.BulSQ98729d.PWsSBoZv58v
			},
			new QuickOperationItem
			{
				Key = "toggle_lock_panel",
				Name = "Quicker：锁定/解锁 动作页自动切换",
				Func = _003C_003Ec.BulSQ98729d.cHYSBTTlTM5
			},
			new QuickOperationItem
			{
				Key = "windows_volume_up",
				Name = "媒体：音量+",
				Func = _003C_003Ec.BulSQ98729d.XnRSBM19JaF
			},
			new QuickOperationItem
			{
				Key = "windows_volume_down",
				Name = "媒体：音量-",
				Func = _003C_003Ec.BulSQ98729d.gMjSBAqrb3h
			},
			new QuickOperationItem
			{
				Key = "windows_volume_mute",
				Name = "媒体：静音",
				Func = _003C_003Ec.BulSQ98729d.YhjSBOpBpH6
			},
			new QuickOperationItem
			{
				Key = "windows_media_next_track",
				Name = "媒体：下一首",
				Func = _003C_003Ec.BulSQ98729d.ntvSBFaHbrH
			},
			new QuickOperationItem
			{
				Key = "windows_media_prev_track",
				Name = "媒体：上一首",
				Func = _003C_003Ec.BulSQ98729d.dG9SBU54AbK
			},
			new QuickOperationItem
			{
				Key = "windows_media_stop",
				Name = "媒体：停止",
				Func = _003C_003Ec.BulSQ98729d.RtISBl0dsoA
			},
			new QuickOperationItem
			{
				Key = "windows_media_play_pause",
				Name = "媒体：播放/暂停",
				Func = _003C_003Ec.BulSQ98729d.w3uSBiqUEmU
			},
			new QuickOperationItem
			{
				Key = "windows_browser_back",
				Name = "浏览：后退",
				Func = _003C_003Ec.BulSQ98729d.huLSB3axbPu
			},
			new QuickOperationItem
			{
				Key = "windows_browser_forward",
				Name = "浏览：前进",
				Func = _003C_003Ec.BulSQ98729d.U3CSBfqZvAa
			},
			new QuickOperationItem
			{
				Key = "windows_browser_refresh",
				Name = "浏览：刷新",
				Func = _003C_003Ec.BulSQ98729d.VGGSBzqZLJZ
			},
			new QuickOperationItem
			{
				Key = "windows_ime_zh",
				Name = "输入法：中文",
				Func = _003C_003Ec.BulSQ98729d.A6NSQwVm5GI
			},
			new QuickOperationItem
			{
				Key = "windows_ime_en",
				Name = "输入法：英文",
				Func = _003C_003Ec.BulSQ98729d.bdxSQtEX8qg
			},
			new QuickOperationItem
			{
				Key = "windows_ime_toggle",
				Name = "输入法：切换中英文",
				Func = _003C_003Ec.BulSQ98729d.BGySQg2mX3F
			},
			new QuickOperationItem
			{
				Key = "windows_window_close_window",
				Name = "窗口：关闭窗口",
				Func = _003C_003Ec.BulSQ98729d.PBISQLs3LM6
			},
			new QuickOperationItem
			{
				Key = "windows_window_close_tab",
				Name = "窗口：关闭标签/文档(Ctrl+W)",
				Func = _003C_003Ec.BulSQ98729d.xlmSQvtdlLQ
			},
			new QuickOperationItem
			{
				Key = "windows_window_min",
				Name = "窗口：最小化",
				Func = _003C_003Ec.BulSQ98729d.ssrSQS38EpZ
			},
			new QuickOperationItem
			{
				Key = "windows_window_max",
				Name = "窗口：最大化",
				Func = _003C_003Ec.BulSQ98729d.yCoSQ2tknEr
			},
			new QuickOperationItem
			{
				Key = "windows_window_max_restore",
				Name = "窗口：最大化/还原",
				Func = _003C_003Ec.BulSQ98729d.AQESQuWRqfW
			},
			new QuickOperationItem
			{
				Key = "windows_alpha_down",
				Name = "窗口：透明度+",
				Func = _003C_003Ec.BulSQ98729d.VHPSQNh986D
			},
			new QuickOperationItem
			{
				Key = "windows_alpha_up",
				Name = "窗口：透明度-",
				Func = _003C_003Ec.BulSQ98729d.jIqSQJ0t125
			},
			new QuickOperationItem
			{
				Key = "windows_window_keep_top",
				Name = "窗口：置顶/取消置顶前台窗口",
				Func = _003C_003Ec.BulSQ98729d.AfaSQ0tRhOh
			},
			new QuickOperationItem
			{
				Key = "windows_window_move_bottom",
				Name = "窗口：置底窗口",
				Func = _003C_003Ec.BulSQ98729d.FpvSQCXmu1o
			},
			new QuickOperationItem
			{
				Key = "monitor_brightness_increase",
				Name = "显示器：亮度+",
				Func = _003C_003Ec.BulSQ98729d.l3oSQPmHyxv
			},
			new QuickOperationItem
			{
				Key = "monitor_brightness_decrease",
				Name = "显示器：亮度-",
				Func = _003C_003Ec.BulSQ98729d.XFySQE9jkL0
			},
			new QuickOperationItem
			{
				Key = "run_selected_text",
				Name = "运行选中文字",
				Func = _003C_003Ec.BulSQ98729d.WmnSQyJG6SS
			},
			new QuickOperationItem
			{
				Key = "search_selected_text",
				Name = "在线搜索选中文字",
				Func = _003C_003Ec.BulSQ98729d.IQRSQ8uYBYw
			},
			new QuickOperationItem
			{
				Key = "operation_copy",
				Name = "复制",
				Func = _003C_003Ec.BulSQ98729d.zKuSQaDh3FJ
			},
			new QuickOperationItem
			{
				Key = "operation_paste",
				Name = "粘贴",
				Func = _003C_003Ec.BulSQ98729d.KK5SQ7oVrNN
			},
			new QuickOperationItem
			{
				Key = "operation_copy_or_paste",
				Name = "复制或粘贴(显示提示)",
				Func = _003C_003Ec.BulSQ98729d.DSSSQR8TqNk
			},
			new QuickOperationItem
			{
				Key = "operation_copy_or_paste_no_hint",
				Name = "复制或粘贴(不显示提示)",
				Func = _003C_003Ec.BulSQ98729d.VOHSQqt6aO7
			},
			new QuickOperationItem
			{
				Key = "operation_show_context_menu",
				Name = "显示剪贴板上下文菜单",
				Func = _003C_003Ec.BulSQ98729d.JeuSQcXLlGM
			},
			new QuickOperationItem
			{
				Key = "operation_copy_and_show_contextmenu",
				Name = "复制并显示剪贴板上下文菜单",
				Func = _003C_003Ec.BulSQ98729d.vIMSQVIuP9i
			}
		};
	}

	internal static bool qcAAISFebQLDKASQK7ru()
	{
		return yovvDVFef2JkAeMqeYN2 == null;
	}

	internal static void Fusc6BFeib6ifPJGoS56()
	{
	}
}
