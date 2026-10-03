using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using ouEd6sWQPCqARFECqJe;
using Quicker.Domain;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Chrome;
using Quicker.View;
using Rn3s242UWRarQxcDcxp;

namespace uqYElb2WVkpP0FWdV1D;

internal class HOvYIX2wovhtMxBUwgX : SearchPlugin, IContextMenuBuilder, ICreateSettingUI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Q8Ov1tDqffi;

		public static Func<KeyValuePair<string, string>, string> ovHv1gJkRZg;

		public static Func<KeyValuePair<string, string>, string> tXrv1L4wCvn;

		public static Func<SearchResultItem, double> S5Vv1vhAVJj;

		private static _003C_003Ec ttohilcPk937tRPOGbvs;

		static _003C_003Ec()
		{
			Q8Ov1tDqffi = new _003C_003Ec();
		}

		internal string iwTvHfLYWOi(KeyValuePair<string, string> x)
		{
			return x.Key;
		}

		internal string jH9vHzNEERW(KeyValuePair<string, string> x)
		{
			return x.Value;
		}

		internal double iI0v1wMIsvH(SearchResultItem x)
		{
			return x.Score;
		}

		internal static bool r2BjT0cPaaRZQsDr43e0()
		{
			return ttohilcPk937tRPOGbvs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public KeyValuePair<string, string> browser;

		private static _003C_003Ec__DisplayClass35_0 TCSYuTcP9cPg6BnRW7Hq;

		internal bool LNwv1SSbbrW(string x)
		{
			return x.StartsWith(browser.Key + "-");
		}

		internal static bool rsVgMOcPLgnGmF9uRkgT()
		{
			return TCSYuTcP9cPg6BnRW7Hq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public string uH1v1uvueHU;

		private static _003C_003Ec__DisplayClass38_0 KgitgQcPoNvld2YZxher;

		internal bool IW5v12q0jiy(BookmarkInfo x)
		{
			return x.Id == uH1v1uvueHU;
		}

		internal static void CSBJMCcPqkGLoD2XQhHk()
		{
		}

		internal static bool iessd0cPf1Yu8cblmFkv()
		{
			return KgitgQcPoNvld2YZxher == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public BookmarkInfo GHEv10SK9mM;

		public HOvYIX2wovhtMxBUwgX zQCv1CgkvtH;

		public Window x8bv1PcvQy5;

		public Action bRov1EyJm3h;

		private static _003C_003Ec__DisplayClass40_0 CqmHxwcPiugxkTomdQBE;

		internal void qWtv1NNoB0c(object sender, RoutedEventArgs e)
		{
			Task.Run(bRov1EyJm3h ?? (bRov1EyJm3h = OXav1JOu95B));
			(x8bv1PcvQy5 as SearchWindow)?.RequestHide();
		}

		internal void OXav1JOu95B()
		{
			if (ChromeControl.TryDeleteBookmark(GHEv10SK9mM))
			{
				zQCv1CgkvtH.SxgtJSXqHAy.Remove(GHEv10SK9mM);
			}
		}

		internal static bool f0JdngcPl2WXld6JTonL()
		{
			return CqmHxwcPiugxkTomdQBE == null;
		}
	}

	private static readonly ILog V5ptNio8eeM;

	[CompilerGenerated]
	private readonly SearchPluginSettings etptN3k0jn0 = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "##"
			},
			new SearchTrigger
			{
				TriggerWord = "@",
				Weight = 1.0
			}
		},
		PluginId = "search.sys.browser.bookmarks",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo tUdtNfarUPj = new PluginInfo
	{
		Name = "浏览器书签",
		Description = "搜索浏览器书签",
		SearchContentName = "浏览器书签",
		Icon = "fa:Light_Bookmark"
	};

	[CompilerGenerated]
	private readonly string QGAtNz6VoYj = "fa:Brands_Chrome";

	[CompilerGenerated]
	private readonly SearchResultOperationType Tp8tJwBZ9cH = SearchResultOperationType.Custom;

	[CompilerGenerated]
	private readonly SearchResultOperationType TWZtJtHE9bV;

	[CompilerGenerated]
	private readonly bool NdUtJgNTJAy = true;

	private readonly IDictionary<string, string> ebItJLuHKXG = new Dictionary<string, string>();

	private bool eVPtJvcgwfv = true;

	private List<BookmarkInfo> SxgtJSXqHAy;

	private long yOItJ2qLD9W;

	private bool RMDtJuC2cUu;

	private static HOvYIX2wovhtMxBUwgX o8sEa7QAHIZWGZOM8jKD;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return etptN3k0jn0;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return tUdtNfarUPj;
		}
	}

	public override string Id => "search.sys.browser.bookmarks";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return QGAtNz6VoYj;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return Tp8tJwBZ9cH;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return TWZtJtHE9bV;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return NdUtJgNTJAy;
		}
	}

	public override void ApplySettings()
	{
		base.ApplySettings();
		ebItJLuHKXG.Clear();
		eVPtJvcgwfv = true;
		IDictionary<string, string> customSettings = _settings.CustomSettings;
		if (customSettings != null && customSettings.ContainsKey("browsers"))
		{
			string text = _settings.CustomSettings["browsers"];
			if (!string.IsNullOrEmpty(text))
			{
				string[] array = text.SplitToList();
				string[] array2 = default(string[]);
				int num2 = default(int);
				foreach (string text2 in array)
				{
					if (text2.StartsWith("#") || text2.StartsWith("//"))
					{
						continue;
					}
					int num;
					if (text2.Contains(":"))
					{
						array2 = text2.Split(new char[1] { ':' }, 2);
						num = 0;
						if (!rxb4a6QAzXKS9Dgy6S4A())
						{
							num = num2;
						}
					}
					else
					{
						ebItJLuHKXG.Add(text2, string.Empty);
						num = 2;
						if (o8sEa7QAHIZWGZOM8jKD != null)
						{
							continue;
						}
					}
					do
					{
						switch (num)
						{
						default:
							goto IL_00f2;
						case 1:
						case 2:
							break;
						}
						break;
						IL_00f2:
						ebItJLuHKXG.Add(array2[0], array2[1]);
						num = 0;
					}
					while (o8sEa7QAHIZWGZOM8jKD != null);
				}
			}
		}
		IDictionary<string, string> customSettings2 = _settings.CustomSettings;
		if (customSettings2 != null && customSettings2.ContainsKey("enableReadFile"))
		{
			eVPtJvcgwfv = _settings.CustomSettings["enableReadFile"] == "1";
		}
		SxgtJSXqHAy?.Clear();
		yOItJ2qLD9W = 0L;
		tGhtNAprPYP();
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		if (searchResultItem_0.Tag is BookmarkInfo bookmarkInfo)
		{
			ChromeControl.R83vwtdpW8O(bookmarkInfo.BrowserProcName, bookmarkInfo.Url, bookmarkInfo.BrowserProcId);
		}
	}

	public override void Init(SearchPluginInitContext searchPluginInitContext_0)
	{
		base.Init(searchPluginInitContext_0);
		tGhtNAprPYP();
	}

	private bool qN0tNMXr2kP()
	{
		if (SxgtJSXqHAy == null)
		{
			return true;
		}
		if (AppHelper.fLiLTj0x4QY() - yOItJ2qLD9W > 120000L)
		{
			return true;
		}
		return false;
	}

	private Task tGhtNAprPYP()
	{
		if (qN0tNMXr2kP())
		{
			if (RMDtJuC2cUu)
			{
				return null;
			}
			RMDtJuC2cUu = true;
			return Task.Run((Action)uEOtNlLbUSX);
		}
		return null;
	}

	private void AnDtNOLZsDw(List<BookmarkInfo> list_1, IList<BookmarkInfo> ilist_0)
	{
		if (ilist_0.HasData())
		{
			string browserProcName = ilist_0[0].BrowserProcName;
			list_1.AddRange(ilist_0);
		}
	}

	private IDictionary<string, IList<BookmarkInfo>> IGTtNF0XlRj(ICollection<string> icollection_0)
	{
		IDictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{ "chrome", "%LOCALAPPDATA%\\Google\\Chrome\\User Data\\Default\\Bookmarks" },
			{ "msedge", "%LOCALAPPDATA%\\Microsoft\\Edge\\User Data\\Default\\Bookmarks" },
			{ "360chromex", "%LOCALAPPDATA%\\360ChromeX\\Chrome\\User Data\\Default\\Bookmarks" },
			{ "vivaldi", "%LOCALAPPDATA%\\Vivaldi\\User Data\\Default\\Bookmarks" }
		};
		Dictionary<string, IList<BookmarkInfo>> dictionary2 = new Dictionary<string, IList<BookmarkInfo>>();
		IDictionary<string, string> dictionary3 = dictionary;
		if (ebItJLuHKXG.HasData())
		{
			dictionary3 = ebItJLuHKXG.ToDictionary(_003C_003Ec.ovHv1gJkRZg ?? (_003C_003Ec.ovHv1gJkRZg = _003C_003Ec.Q8Ov1tDqffi.iwTvHfLYWOi), _003C_003Ec.tXrv1L4wCvn ?? (_003C_003Ec.tXrv1L4wCvn = _003C_003Ec.Q8Ov1tDqffi.jH9vHzNEERW));
			foreach (string item in dictionary3.Keys.ToList())
			{
				if (string.IsNullOrEmpty(dictionary3[item]) && dictionary.ContainsKey(item))
				{
					dictionary3[item] = dictionary[item];
				}
			}
		}
		using IEnumerator<KeyValuePair<string, string>> enumerator2 = dictionary3.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
			_003C_003Ec__DisplayClass35_.browser = enumerator2.Current;
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass35_.browser.Value) || icollection_0.Any(_003C_003Ec__DisplayClass35_.LNwv1SSbbrW))
			{
				continue;
			}
			string text = Environment.ExpandEnvironmentVariables(_003C_003Ec__DisplayClass35_.browser.Value);
			if (File.Exists(text))
			{
				try
				{
					dictionary2.Add(_003C_003Ec__DisplayClass35_.browser.Key, zNDBT324IHaUJUaYALP.TBDtEuNInUZ(text, _003C_003Ec__DisplayClass35_.browser.Key).ToList());
				}
				catch (Exception ex)
				{
					V5ptNio8eeM.Warn("读取书签文件" + text + "出错：" + ex.Message);
				}
			}
		}
		return dictionary2;
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		tGhtNAprPYP();
		if (queryContext_0.IsEmptySearch && queryContext_0.IsGlobalSearch)
		{
			return list;
		}
		if (SxgtJSXqHAy != null && SxgtJSXqHAy.Count != 0)
		{
			string string_ = "fa:Solid_Bookmark:#0086ff";
			bool isEmptySearch = queryContext_0.IsEmptySearch;
			foreach (BookmarkInfo item in SxgtJSXqHAy)
			{
				MultiFieldMatchResult multiFieldMatchResult = tkxn6HAKAgMT8gvXbyh.KwUidyksAU(item.Title, 2.0, item.Url, 1.0, true, queryContext_0);
				if (multiFieldMatchResult.Score > 0)
				{
					list.Add(XN3tNUHXYdW(item, string_, multiFieldMatchResult));
				}
			}
			return list.OrderByDescending(_003C_003Ec.S5Vv1vhAVJj ?? (_003C_003Ec.S5Vv1vhAVJj = _003C_003Ec.Q8Ov1tDqffi.iI0v1wMIsvH)).Take(100).ToList();
		}
		if (queryContext_0.IsGlobalSearch)
		{
			return list;
		}
		return new List<SearchResultItem> { SearchPlugin.CreateWarningResult("暂无书签数据。" + (RMDtJuC2cUu ? "加载中..." : ""), "请确认浏览器开启，Quicker扩展已安装并成功连接，已开放bookmarks权限。") };
	}

	private static SearchResultItem XN3tNUHXYdW(BookmarkInfo bookmarkInfo_0, string string_1, MultiFieldMatchResult multiFieldMatchResult_0)
	{
		return new SearchResultItem
		{
			Title = bookmarkInfo_0.Title,
			Description = bookmarkInfo_0.Url,
			Label = bookmarkInfo_0.BrowserProcName,
			TextData = bookmarkInfo_0.Url,
			TextDataType = "url",
			Icon = AppHelper.GetUrlFavicon(bookmarkInfo_0.Url),
			SecondaryIcon = string_1,
			Tag = bookmarkInfo_0,
			Score = (multiFieldMatchResult_0?.Score ?? 0),
			TitleMatchPositions = multiFieldMatchResult_0?.Result1?.GetMatchPositions(),
			DescriptionMatchPositions = multiFieldMatchResult_0?.Result2?.GetMatchPositions(),
			HistoryData = bookmarkInfo_0.Id
		};
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem searchHistoryItem_0)
	{
		if (SxgtJSXqHAy.HasData())
		{
			_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
			_003C_003Ec__DisplayClass38_.uH1v1uvueHU = searchHistoryItem_0.HistoryData;
			BookmarkInfo bookmarkInfo = SxgtJSXqHAy.FirstOrDefault(_003C_003Ec__DisplayClass38_.IW5v12q0jiy);
			if (bookmarkInfo != null)
			{
				return XN3tNUHXYdW(bookmarkInfo, "fa:Solid_Bookmark:#0086ff", null);
			}
		}
		return null;
	}

	public override IEnumerable<SearchResultItem> GetResultsForEmptySearch(QueryContext queryContext_0, IList<SearchHistoryItem> ilist_0, CancellationToken cancellationToken_0, bool bool_3)
	{
		tGhtNAprPYP()?.Wait(150, cancellationToken_0);
		return base.GetResultsForEmptySearch(queryContext_0, ilist_0, cancellationToken_0, bool_3);
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.zQCv1CgkvtH = this;
		_003C_003Ec__DisplayClass40_.x8bv1PcvQy5 = window_0;
		TkqATlWBPrB8iqNuFZQ.tGRtuKNCim6(searchResultItem_0.TextData, searchResultItem_0.Title, searchResultItem_0.Icon, contextMenu_0.Items);
		_003C_003Ec__DisplayClass40_.GHEv10SK9mM = searchResultItem_0.Tag as BookmarkInfo;
		if (_003C_003Ec__DisplayClass40_.GHEv10SK9mM != null && AppState.vjAt7Seco0Y().xSstGKB1AqB(_003C_003Ec__DisplayClass40_.GHEv10SK9mM.BrowserProcName, _003C_003Ec__DisplayClass40_.GHEv10SK9mM.BrowserProcId))
		{
			AppHelper.AddMenuItem(contextMenu_0.Items, "删除书签", "从浏览器中删除此书签", "fa:Light_Times:#FF0000", _003C_003Ec__DisplayClass40_.qWtv1NNoB0c);
		}
		return true;
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new BookmarksSearchPluginSettingsControl();
	}

	static HOvYIX2wovhtMxBUwgX()
	{
		V5ptNio8eeM = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void uEOtNlLbUSX()
	{
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			List<BookmarkInfo> list = new List<BookmarkInfo>();
			IDictionary<string, IList<BookmarkInfo>> bookmarks = ChromeControl.GetBookmarks(ebItJLuHKXG.Keys.ToList());
			if (bookmarks.Keys.Count > 0)
			{
				foreach (IList<BookmarkInfo> value in bookmarks.Values)
				{
					AnDtNOLZsDw(list, value);
				}
			}
			if (eVPtJvcgwfv)
			{
				IDictionary<string, IList<BookmarkInfo>> dictionary = IGTtNF0XlRj(bookmarks.Keys);
				if (dictionary.HasData())
				{
					if (rxb4a6QAzXKS9Dgy6S4A())
					{
						switch (0)
						{
						}
					}
					foreach (IList<BookmarkInfo> value2 in dictionary.Values)
					{
						AnDtNOLZsDw(list, value2);
					}
				}
			}
			if (list.HasData())
			{
				SxgtJSXqHAy = list;
				yOItJ2qLD9W = AppHelper.fLiLTj0x4QY();
			}
			V5ptNio8eeM.Info($"获取Bookmarks耗时：{stopwatch.ElapsedMilliseconds} ms, {SxgtJSXqHAy?.Count}");
		}
		catch (Exception ex)
		{
			V5ptNio8eeM.Info("获取Bookmarks出错：" + ex.Message, ex);
		}
		finally
		{
			RMDtJuC2cUu = false;
		}
	}

	internal static bool rxb4a6QAzXKS9Dgy6S4A()
	{
		return o8sEa7QAHIZWGZOM8jKD == null;
	}
}
