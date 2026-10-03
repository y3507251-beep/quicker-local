using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using l9W6KWifMfNKrInJR4l;
using log4net;
using qIOAiL5tHSq0oBCxwHP;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.ContextMenus;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View;

namespace Quicker.Modules.Searching.Builtin;

public class EverythingSearchPlugin : SearchPlugin, IContextMenuBuilder, ICreateSettingUI
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public string Q35vblWFfHE;

		public IntPtr qxRvbijgR44;

		internal static _003C_003Ec__DisplayClass34_0 gdp1mqcUYwU0e9dEiI6a;

		internal void J1TvbUnOZMF()
		{
			string text = ytnqhyiMNhGmytDmEj7.GvXvtJLyniF(qxRvbijgR44);
			if (!string.IsNullOrEmpty(text))
			{
				Q35vblWFfHE = "\"" + text + "\"";
			}
			else
			{
				Q35vblWFfHE = "";
			}
		}

		internal static bool LrOLDocU8pqywLFYPUaA()
		{
			return gdp1mqcUYwU0e9dEiI6a == null;
		}
	}

	public const string KEY_SORT = "sort";

	public const string KEY_EXCLUDE = "exclude";

	private static readonly ILog UiLtPMrUjQ4;

	[CompilerGenerated]
	private readonly SearchPluginSettings vjxtPAC8qXD = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "f "
			},
			new SearchTrigger
			{
				TriggerWord = "fd ",
				Condition = "folder:"
			},
			new SearchTrigger
			{
				TriggerWord = "fw ",
				Condition = "ext:docx;doc;"
			},
			new SearchTrigger
			{
				TriggerWord = "fx ",
				Condition = "ext:xlsx;xls;xlsm;csv;"
			},
			new SearchTrigger
			{
				TriggerWord = "fpdf ",
				Condition = "ext:pdf"
			},
			new SearchTrigger
			{
				TriggerWord = "fc ",
				Condition = "_current_"
			}
		},
		PluginId = "search.sys.windows.everything",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo xx2tPO7VcAQ = new PluginInfo
	{
		Name = "文件(Everything)",
		Description = "通过Everything搜索系统文件",
		SearchContentName = "文件",
		Icon = "fa:Regular_Search",
		ConditionNote = "条件参数将会原样插入到搜索内容中。如：\r\n只搜索Word和Excel文件，可以使用条件：ext:docx;doc;xlsx;xlsx\r\n只搜索文件夹，可以使用条件：folder:"
	};

	[CompilerGenerated]
	private readonly string kYotPF50S8m = "fa:Light_File";

	[CompilerGenerated]
	private readonly SearchResultOperationType JmYtPUNsIdx = SearchResultOperationType.Open;

	[CompilerGenerated]
	private readonly SearchResultOperationType S9MtPlVkjMt = SearchResultOperationType.OpenFolder;

	[CompilerGenerated]
	private readonly SearchResultOperationType T9QtPiDgISN;

	private uint dcftP3QvZ1K = 14u;

	private string[] hmRtPfVl8mj = new string[3] { "\\WinSxS\\", "\\$Recycle.Bin\\", "C:\\Windows\\Prefetch\\" };

	private static bool cEetPz3SA4P;

	private static bool G9HtEwoWNdq;

	internal static EverythingSearchPlugin lEHe6lQjsW4rXAyOjX1k;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return vjxtPAC8qXD;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return xx2tPO7VcAQ;
		}
	}

	public override string Id => "search.sys.windows.everything";

	public override bool IsSupportCondition => true;

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return kYotPF50S8m;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return JmYtPUNsIdx;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return S9MtPlVkjMt;
		}
	}

	public override SearchResultOperationType ShiftEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return T9QtPiDgISN;
		}
	}

	public override bool IsSupportHistory => true;

	public override void ProcessResult(SearchResultItem resultItem, QueryContext context)
	{
		throw new NotImplementedException();
	}

	public override void ApplySettings()
	{
		base.ApplySettings();
		if (_settings == null)
		{
			return;
		}
		if (_settings.CustomSettings == null)
		{
			if (!f2V1X8QjCvRDahaeQhfF())
			{
				switch (0)
				{
				case 0:
					break;
				}
			}
			return;
		}
		if (_settings.CustomSettings.TryGetValue("sort", out var value) && value == "1")
		{
			dcftP3QvZ1K = 1u;
		}
		if (_settings.CustomSettings.TryGetValue("exclude", out var value2))
		{
			hmRtPfVl8mj = value2.SplitToList() ?? Array.Empty<string>();
		}
	}

	private static void Qq4tPoWNmCj()
	{
		if (cEetPz3SA4P || G9HtEwoWNdq)
		{
			return;
		}
		G9HtEwoWNdq = true;
		try
		{
			Process[] processesByName = Process.GetProcessesByName("Everything");
			if (processesByName.Length > 1)
			{
				cEetPz3SA4P = true;
				return;
			}
			if (processesByName.Length == 0)
			{
				if (lEHe6lQjsW4rXAyOjX1k != null)
				{
					switch (0)
					{
					}
				}
				processesByName = Process.GetProcessesByName("Everything64");
				if (processesByName.Length > 1)
				{
					cEetPz3SA4P = true;
					return;
				}
			}
			if (processesByName.Length != 1)
			{
				return;
			}
			try
			{
				string fileName = processesByName[0].MainModule.FileName;
				cEetPz3SA4P = true;
			}
			catch (Exception)
			{
			}
		}
		finally
		{
			G9HtEwoWNdq = false;
		}
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext, CancellationToken cancellationToken)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (string.IsNullOrEmpty(queryContext.Search) && queryContext.IsGlobalSearch)
		{
			return list;
		}
		Qq4tPoWNmCj();
		if (!cEetPz3SA4P)
		{
			return new List<SearchResultItem> { SearchPlugin.CreateWarningResult("Everything软件尚未启动", "请先启动Everything软件。") };
		}
		string secondaryIcon = (queryContext.IsGlobalSearch ? "fa:Solid_Search:#0086ff" : string.Empty);
		EverythingAPI everythingAPI = new EverythingAPI();
		if (queryContext.SearchWords.Length > 1 && queryContext.Search.IndexOf("nopath:", StringComparison.OrdinalIgnoreCase) < 0 && (queryContext.PluginItem.Condition == null || queryContext.PluginItem.Condition.IndexOf("nopath:", StringComparison.OrdinalIgnoreCase) < 0))
		{
			everythingAPI.MatchPath = true;
		}
		try
		{
			_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
			everythingAPI.Sort = dcftP3QvZ1K;
			string text = "";
			string[] array = hmRtPfVl8mj;
			foreach (string text2 in array)
			{
				text = "!\"" + text2 + "\" " + text;
			}
			_003C_003Ec__DisplayClass34_.Q35vblWFfHE = queryContext.PluginItem.Condition ?? "";
			if (_003C_003Ec__DisplayClass34_.Q35vblWFfHE == "_current_")
			{
				try
				{
					_003C_003Ec__DisplayClass34_.qxRvbijgR44 = (queryContext.SearchWindow as SearchWindow).ActiveWindowBeforeShow;
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass34_.J1TvbUnOZMF);
				}
				catch (Exception ex)
				{
					UiLtPMrUjQ4.Warn("获取资源管理器当前目录出错：" + ex.Message);
					_003C_003Ec__DisplayClass34_.Q35vblWFfHE = "";
				}
			}
			string keyWord = text + " " + _003C_003Ec__DisplayClass34_.Q35vblWFfHE + " " + queryContext.Search;
			new List<EverythingFileInfo>();
			if (cancellationToken.IsCancellationRequested)
			{
				UiLtPMrUjQ4.Info($"Everything搜索已取消，({queryContext.QuerySerial}:{queryContext.Search})");
				return new List<SearchResultItem>();
			}
			List<EverythingFileInfo> list2 = everythingAPI.Search(keyWord, 0u, 100u, cancellationToken, queryContext.QuerySerial).ToList();
			int num = list2.Count();
			int num2 = 0;
			foreach (EverythingFileInfo item in (IEnumerable<EverythingFileInfo>)list2)
			{
				num2++;
				if (!cancellationToken.IsCancellationRequested)
				{
					if (!string.IsNullOrEmpty(item.FileName))
					{
						list.Add(new SearchResultItem
						{
							Title = item.FileName,
							SecondaryTitle = $"{item.Size.GetBytesReadable()}  {item.Modified}",
							Description = item.FilePath,
							SecondaryIcon = secondaryIcon,
							Icon = GetPathIcon(item.FilePath),
							Score = (double)(string.Equals(item.FileName, queryContext.Search) ? 100 : 50) - (double)num2 * 1.0 / (double)num * 10.0,
							TextData = item.FilePath,
							TextDataType = "path",
							TitleMatchPositions = EHotPTxIQWp(item),
							HistoryData = item.FilePath
						});
						if (list.Count > 150)
						{
							return list;
						}
						continue;
					}
					UiLtPMrUjQ4.Info("file.FileName 为空，中止输出");
					return list;
				}
				return new List<SearchResultItem>();
			}
			return list;
		}
		catch (Exception exception)
		{
			UiLtPMrUjQ4.Warn($"Everything搜索出错：({queryContext.QuerySerial} - {queryContext.Search})" + exception.GetMessageWithInner(), exception);
			AppHelper.ShowWarning("Everything搜索出错：" + exception.GetMessageWithInner());
			return list;
		}
	}

	public override IEnumerable<SearchResultItem> GetResultsForEmptySearch(QueryContext queryContext, IList<SearchHistoryItem> historyItems, CancellationToken cancellationToken, bool onlyOnePlugin)
	{
		if (string.IsNullOrEmpty(queryContext.PluginItem.Condition))
		{
			return base.GetResultsForEmptySearch(queryContext, historyItems, cancellationToken, onlyOnePlugin);
		}
		return DoSearch(queryContext, cancellationToken);
	}

	public static string GetPathIcon(string path)
	{
		SearchSettings searchSettings = AppState.HHxtaMaoqJr().SearchSettings;
		if (searchSettings != null && searchSettings.ShowFileThumbnail)
		{
			return "shellicon:" + path;
		}
		try
		{
			if (Directory.Exists(path))
			{
				return "shellicon:" + path;
			}
			string text = Path.GetExtension(path).ToLower();
			if (!(text == ".exe"))
			{
				if (!(text == ".lnk"))
				{
					return "icon:" + text;
				}
				int num = 0;
				if (lEHe6lQjsW4rXAyOjX1k != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return "shellicon:" + path;
		}
		catch (Exception ex)
		{
			UiLtPMrUjQ4.Info("生成路径" + path + "图标出错：" + ex.Message);
			return "";
		}
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem historyItem)
	{
		string historyData = historyItem.HistoryData;
		FileSystemInfo fileSystemInfo = null;
		if (File.Exists(historyData))
		{
			fileSystemInfo = new FileInfo(historyData);
		}
		else
		{
			if (!Directory.Exists(historyData))
			{
				return null;
			}
			fileSystemInfo = new DirectoryInfo(historyData);
		}
		return new SearchResultItem
		{
			Title = Path.GetFileName(historyData),
			SecondaryTitle = $"{(fileSystemInfo as FileInfo)?.Length.GetBytesReadable()}  {fileSystemInfo.LastWriteTime}",
			Description = historyData,
			SecondaryIcon = "fa:Solid_Search:#0086ff",
			Icon = GetPathIcon(historyData),
			Score = 0.0,
			TextData = historyData,
			TextDataType = "path",
			TitleMatchPositions = null,
			HistoryData = historyData
		};
	}

	private static IList<int> EHotPTxIQWp(EverythingFileInfo everythingFileInfo_0)
	{
		if (everythingFileInfo_0.HighlightedFileName == null)
		{
			return Array.Empty<int>();
		}
		IList<int> list = new List<int>(everythingFileInfo_0.FileName.Length);
		int num = 0;
		bool flag = false;
		for (int i = 0; i < everythingFileInfo_0.HighlightedFileName.Length && i < 64; i++)
		{
			if (everythingFileInfo_0.HighlightedFileName[i] == '*')
			{
				flag = !flag;
				continue;
			}
			if (flag)
			{
				list.Add(num);
			}
			num++;
		}
		return list;
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem, ContextMenu contextMenu, Window window)
	{
		string textData = searchResultItem.TextData;
		if (string.IsNullOrEmpty(textData))
		{
			return false;
		}
		SqoZP75Qt63qQSW6CF1.LZjBkbQjRm(textData, contextMenu.Items);
		SqoZP75Qt63qQSW6CF1.TITBsl183p(textData, contextMenu.Items, contextMenu);
		ContentContextMenuService.KXCteJAL0Uj(contextMenu.Items, new List<string> { textData }, true);
		return true;
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new EverythingSearchPluginSettingsControl();
	}

	static EverythingSearchPlugin()
	{
		UiLtPMrUjQ4 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		cEetPz3SA4P = false;
		G9HtEwoWNdq = false;
	}

	internal static bool f2V1X8QjCvRDahaeQhfF()
	{
		return lEHe6lQjsW4rXAyOjX1k == null;
	}
}
