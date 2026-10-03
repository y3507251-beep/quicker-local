using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using eHGj15MUIx8QneCHitQ;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Domain;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Win32;
using Quicker.View;

namespace F43XQF2y67i44S1l9aA;

internal class F0DMWs2Pfa79EIZeZ8T : SearchPlugin, IContextMenuBuilder, ICreateSettingUI
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public Quicker.Modules.Searching.Builtin.WindowInfo BiUvbmbYcLI;

		internal static _003C_003Ec__DisplayClass26_0 kuITyvcUXmqKbtNmqTOG;

		internal void ALUvbXgxdE8()
		{
			NativeMethods.BringProcessMainWindowToFront(BiUvbmbYcLI.Handle);
		}

		internal static bool NOT1lpcU23D7V3v6hlQM()
		{
			return kuITyvcUXmqKbtNmqTOG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass32_0
	{
		public Window aCNvbnkijyN;

		public IntPtr XZOvb4E10P7;

		public Action q59vb5mEFuS;

		internal static _003C_003Ec__DisplayClass32_0 jAfOpJcUnB2MYEIW7qfQ;

		internal void tsxvbKNLgbf(object sender, RoutedEventArgs e)
		{
			(aCNvbnkijyN as SearchWindow)?.RequestHide();
			WindowHelper.RestoreAndSetForeground(XZOvb4E10P7);
		}

		internal void K0ivbxTBiRt(object sender, RoutedEventArgs e)
		{
			(aCNvbnkijyN as SearchWindow)?.RequestHide();
			WindowHelper.MaximizeWindow(XZOvb4E10P7);
			AppHelper.SetForegroundWindow(XZOvb4E10P7);
		}

		internal void TEfvbrsvC0u(object sender, RoutedEventArgs e)
		{
			(aCNvbnkijyN as SearchWindow)?.RequestHide();
			Task.Run(q59vb5mEFuS ?? (q59vb5mEFuS = WUovbpW42Ux));
		}

		internal void WUovbpW42Ux()
		{
			WindowHelper.MoveToScreenCenter(XZOvb4E10P7);
			AppHelper.SetForegroundWindow(XZOvb4E10P7);
		}

		internal void Hi5vbB6PRFL(object sender, RoutedEventArgs e)
		{
			(aCNvbnkijyN as SearchWindow)?.RequestHide();
			(aCNvbnkijyN as SearchWindow)?.RequestHide();
			try
			{
				string text = Process.GetProcessById(NativeMethods.GetWindowProcessId(XZOvb4E10P7)).MainModule?.FileName;
				if (string.IsNullOrEmpty(text))
				{
					AppHelper.ShowWarning("无法获得程序路径。");
				}
				else
				{
					AppHelper.SelectFileInExplorer(text, false);
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("关闭进程失败：" + ex.Message);
			}
		}

		internal void QfqvbQcbkl8(object sender, RoutedEventArgs e)
		{
			(aCNvbnkijyN as SearchWindow)?.RequestHide();
			WindowHelper.CloseWindow(XZOvb4E10P7);
		}

		internal void oRuvbjPGW4N(object sender, RoutedEventArgs e)
		{
			(aCNvbnkijyN as SearchWindow)?.RequestHide();
			try
			{
				Process.GetProcessById(NativeMethods.GetWindowProcessId(XZOvb4E10P7)).Kill();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("关闭进程失败：" + ex.Message);
			}
		}

		internal static bool VqeC8scUeC1ZX1ZukaD9()
		{
			return jAfOpJcUnB2MYEIW7qfQ == null;
		}
	}

	[CompilerGenerated]
	private readonly SearchPluginSettings p41tPJJQ6yU = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "<"
			},
			new SearchTrigger
			{
				TriggerWord = "《"
			}
		},
		PluginId = "search.sys.windows.window",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo UZRtP0PBj04 = new PluginInfo
	{
		Name = "窗口",
		Description = "搜索打开的Windows窗口",
		SearchContentName = "窗口",
		Icon = "fa:Light_WindowAlt"
	};

	[CompilerGenerated]
	private readonly string jILtPCvo7ue = "fa:Brands_Windows";

	[CompilerGenerated]
	private readonly SearchResultOperationType ohitPPdrtgm = SearchResultOperationType.Custom;

	[CompilerGenerated]
	private readonly SearchResultOperationType hBOtPEEBdCn;

	private IList<string> ypUtPyt3YHL = new List<string>();

	private bool lDntP8FvbD3;

	private IList<string> di7tPaeitUA = new List<string>();

	private IList<string> UmStP7v6M9B = new List<string>();

	private static F0DMWs2Pfa79EIZeZ8T UwC9L8QjFVrS8NfZva4V;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return p41tPJJQ6yU;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return UZRtP0PBj04;
		}
	}

	public override string Id => "search.sys.windows.window";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return jILtPCvo7ue;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return ohitPPdrtgm;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return hBOtPEEBdCn;
		}
	}

	public override void ApplySettings()
	{
		base.ApplySettings();
		if (_settings != null && _settings.CustomSettings != null)
		{
			if (_settings.CustomSettings.TryGetValue("IGNORE_NO_ACTIVATE", out var value))
			{
				if (UwC9L8QjFVrS8NfZva4V == null)
				{
					switch (0)
					{
					}
				}
				lDntP8FvbD3 = value == "1";
			}
			if (_settings.CustomSettings.TryGetValue("BLACK_LIST", out var value2))
			{
				string string_ = value2;
				Wx8tPSUH1dB(string_);
			}
		}
		else
		{
			Wx8tPSUH1dB("");
		}
	}

	private void Wx8tPSUH1dB(string string_1)
	{
		int num2 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			ypUtPyt3YHL.Clear();
			int num = 0;
			if (sfyIESQjcpldKBq7yjeR())
			{
				goto IL_00d7;
			}
			goto IL_0174;
			IL_0174:
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_00d7;
			case 1:
				continue;
			}
			goto IL_0006;
			IL_0006:
			num2++;
			goto IL_000a;
			IL_000a:
			if (num2 >= array.Length)
			{
				break;
			}
			string text = array[num2];
			if (!string.IsNullOrEmpty(text) && !text.StartsWith("//"))
			{
				if (text.StartsWith("p:", StringComparison.OrdinalIgnoreCase))
				{
					string text2 = text.Substring(2);
					if (!text2.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
					{
						text2 += ".exe";
					}
					ypUtPyt3YHL.Add(text2);
					num = 2;
					if (UwC9L8QjFVrS8NfZva4V != null)
					{
						goto IL_00d7;
					}
					goto IL_0174;
				}
				if (text.StartsWith("c:", StringComparison.OrdinalIgnoreCase))
				{
					UmStP7v6M9B.Add(text.Substring(2));
				}
				else if (text.StartsWith("t:", StringComparison.OrdinalIgnoreCase))
				{
					di7tPaeitUA.Add(text.Substring(2));
				}
			}
			goto IL_0006;
			IL_00d7:
			UmStP7v6M9B.Clear();
			di7tPaeitUA.Clear();
			ypUtPyt3YHL.AddRange(new string[9] { "TextInputHost.exe", "LockApp.exe", "ShellExperienceHost.exe", "StartMenuExperienceHost.exe", "SearchHost.exe", "ApplicationFrameHost.exe", "WebExperienceHostApp.exe", "ScreenClippingHost.exe", "MiniSearchHost.exe" });
			UmStP7v6M9B.Add("Windows.Internal.Shell.TabProxyWindow");
			di7tPaeitUA.Add("NotificationsWindow");
			if (!string.IsNullOrEmpty(string_1))
			{
				array = string_1.SplitToList();
				num2 = 0;
				goto IL_000a;
			}
			break;
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.BiUvbmbYcLI = searchResultItem_0.Tag as Quicker.Modules.Searching.Builtin.WindowInfo;
		if (_003C_003Ec__DisplayClass26_.BiUvbmbYcLI != null)
		{
			Task.Run((Action)_003C_003Ec__DisplayClass26_.ALUvbXgxdE8);
		}
	}

	private bool XnRtP2s4toY(string string_1)
	{
		return bbktPu5ZJRj(string_1, ypUtPyt3YHL);
	}

	private bool bbktPu5ZJRj(string string_1, IList<string> ilist_3)
	{
		if (!ilist_3.HasData())
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < ilist_3.Count)
			{
				string text = ilist_3[num];
				if (text.StartsWith("regex:", StringComparison.OrdinalIgnoreCase))
				{
					if (Regex.IsMatch(string_1, text.Substring(6)))
					{
						return true;
					}
				}
				else if (string.Equals(text, string_1, StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (queryContext_0.IsGlobalSearch && string.IsNullOrWhiteSpace(queryContext_0.Search))
		{
			return list;
		}
		Stopwatch.StartNew();
		IDictionary<IntPtr, string> openWindows = OpenWindowGetter.GetOpenWindows(true);
		int num = 500;
		string secondaryIcon = "fa:Regular_WindowAlt:#0086ff";
		foreach (KeyValuePair<IntPtr, string> item in openWindows)
		{
			if (item.Key.IsEither((queryContext_0.SearchWindow as SearchWindow)?.WindowHandle ?? IntPtr.Zero, AppState.MainWinHandle) || bbktPu5ZJRj(item.Value, di7tPaeitUA) || (lDntP8FvbD3 && NativeMethods.IsWindowNoActivate(item.Key)))
			{
				continue;
			}
			string text = tZZhZGM4HaKvySF2OqY.ulvLOm7PgsE((uint)NativeMethods.GetWindowProcessId(item.Key));
			string fileName = Path.GetFileName(text);
			if (XnRtP2s4toY(fileName))
			{
				continue;
			}
			string windowClass = NativeMethods.GetWindowClass(item.Key);
			if (bbktPu5ZJRj(windowClass, UmStP7v6M9B))
			{
				continue;
			}
			NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(item.Key);
			if (windowRectangle.Right <= windowRectangle.Left || windowRectangle.Bottom <= windowRectangle.Top)
			{
				continue;
			}
			Quicker.Modules.Searching.Builtin.WindowInfo windowInfo = new Quicker.Modules.Searching.Builtin.WindowInfo
			{
				Handle = item.Key,
				Title = item.Value,
				ProcessPath = text,
				ProcessName = fileName,
				Rect = windowRectangle
			};
			if (string.IsNullOrEmpty(queryContext_0.Search))
			{
				list.Add(new SearchResultItem
				{
					Title = (windowInfo.Title ?? ""),
					Tag = windowInfo,
					TextData = item.Key.ToString(),
					TextDataType = "winhandle",
					Label = "窗口",
					Icon = "shellicon:" + text,
					SecondaryIcon = secondaryIcon,
					Description = z1OtPNHyDPJ(windowInfo),
					Score = num--
				});
				continue;
			}
			MultiFieldMatchResult multiFieldMatchResult = tkxn6HAKAgMT8gvXbyh.KwUidyksAU(windowInfo.Title, 1.0, windowInfo.ProcessName, 0.5, true, queryContext_0);
			if (multiFieldMatchResult.Score > 0)
			{
				list.Add(new SearchResultItem
				{
					Title = (windowInfo.Title ?? ""),
					Tag = windowInfo,
					TextData = item.Key.ToString(),
					TextDataType = "winhandle",
					Label = "窗口",
					Icon = "shellicon:" + text,
					SecondaryIcon = secondaryIcon,
					Description = z1OtPNHyDPJ(windowInfo),
					Score = multiFieldMatchResult.Score,
					TitleMatchPositions = multiFieldMatchResult.Result1?.GetMatchPositions()
				});
			}
		}
		return list;
	}

	private static string z1OtPNHyDPJ(Quicker.Modules.Searching.Builtin.WindowInfo windowInfo_0)
	{
		return $"{windowInfo_0.ProcessName}   {windowInfo_0.Rect.Width}*{windowInfo_0.Rect.Height}";
	}

	public override IEnumerable<SearchResultItem> GetResultsForEmptySearch(QueryContext queryContext_0, IList<SearchHistoryItem> ilist_3, CancellationToken cancellationToken_0, bool bool_1)
	{
		return DoSearch(queryContext_0, cancellationToken_0);
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		int num = 1;
		while (true)
		{
			_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
			int num2 = 0;
			if (!sfyIESQjcpldKBq7yjeR())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			_003C_003Ec__DisplayClass32_.aCNvbnkijyN = window_0;
			if (searchResultItem_0.TextData.IsNullOrEmpty())
			{
				return false;
			}
			_003C_003Ec__DisplayClass32_.XZOvb4E10P7 = (IntPtr)uint.Parse(searchResultItem_0.TextData);
			if (_003C_003Ec__DisplayClass32_.XZOvb4E10P7 == IntPtr.Zero)
			{
				return false;
			}
			AppHelper.AddMenuItem(contextMenu_0.Items, "设置为前台窗口(_F)", "激活此窗口", "fa:Light_BringForward", _003C_003Ec__DisplayClass32_.tsxvbKNLgbf);
			AppHelper.AddMenuItem(contextMenu_0.Items, "最大化(_M)", "激活并最大化此窗口", "fa:Light_WindowMaximize", _003C_003Ec__DisplayClass32_.K0ivbxTBiRt);
			AppHelper.AddMenuItem(contextMenu_0.Items, "移动到屏幕中心(_C)", "将窗口移动到屏幕中心", "fa:Light_Compress", _003C_003Ec__DisplayClass32_.TEfvbrsvC0u);
			AppHelper.AddMenuItem(contextMenu_0.Items, "打开程序位置(_O)", "打开窗口进程的主程序位置", "fa:Light_FolderOpen", _003C_003Ec__DisplayClass32_.Hi5vbB6PRFL);
			AppHelper.AddMenuSeparator(contextMenu_0.Items);
			AppHelper.AddMenuItem(contextMenu_0.Items, "关闭窗口(_X)", "关闭此窗口", "fa:Light_Times:#ffb900", _003C_003Ec__DisplayClass32_.QfqvbQcbkl8);
			AppHelper.AddMenuItem(contextMenu_0.Items, "关闭程序(_K)", "关闭此窗口的进程", "fa:Light_Times:#FF0000", _003C_003Ec__DisplayClass32_.oRuvbjPGW4N);
			return true;
		}
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new WindowSearchPluginSettingsControl();
	}

	internal static bool sfyIESQjcpldKBq7yjeR()
	{
		return UwC9L8QjFVrS8NfZva4V == null;
	}
}
