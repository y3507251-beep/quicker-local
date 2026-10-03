using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Chrome;

namespace FdaTBA2jtlaSbaTAl7V;

internal class kJRDjH226hXeo1HfxgN : SearchPlugin, IContextMenuBuilder, ICreateSettingUI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec An9v1aWlVuI;

		public static Func<string, bool> gMxv17CYJ5G;

		public static Func<SearchResultItem, double> bh9v1RscKUE;

		internal static _003C_003Ec DatRhXcP5nvtDpQiNWCm;

		static _003C_003Ec()
		{
			An9v1aWlVuI = new _003C_003Ec();
		}

		internal bool Owrv1yYmeph(string x)
		{
			return x.StartsWith("maxdays:");
		}

		internal double cO6v183YFVT(SearchResultItem x)
		{
			return x.Score;
		}

		internal static void S9ZvJvcPRepxK6HOTilQ()
		{
		}

		internal static bool caygk4cPYsOJGGpcta1u()
		{
			return DatRhXcP5nvtDpQiNWCm == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public BrowserHistoryItem FQjv1cSGSGq;

		private static _003C_003Ec__DisplayClass34_0 SOHSZ4cPgxKKtFYKfnDw;

		internal bool maov1q4dvAw(string pattern)
		{
			return FQjv1cSGSGq.Url.IndexOf(pattern, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		internal static bool Mi4P3ScPPosVLEuAyFoj()
		{
			return SOHSZ4cPgxKKtFYKfnDw == null;
		}
	}

	private static readonly ILog QcrtJydKxlX;

	[CompilerGenerated]
	private readonly SearchPluginSettings KfEtJ8iOphn = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "!"
			},
			new SearchTrigger
			{
				TriggerWord = "!!",
				Condition = "full maxdays:30"
			},
			new SearchTrigger
			{
				TriggerWord = "@",
				Weight = 0.7
			}
		},
		PluginId = "search.sys.browser.history",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo W5ctJaB3KtI = new PluginInfo
	{
		Name = "浏览器历史",
		Description = "搜索浏览器浏览历史",
		SearchContentName = "浏览器历史",
		Icon = "fa:Light_History",
		ConditionNote = "full maxdays:天数 使用浏览器接口直接搜索（而非拼音模糊匹配），搜索最多指定天数内的历史记录。"
	};

	[CompilerGenerated]
	private readonly bool TcTtJ72jAZa = true;

	[CompilerGenerated]
	private readonly string dQJtJRchnsY = "fa:Brands_Chrome";

	[CompilerGenerated]
	private readonly SearchResultOperationType wdstJqNnHDG = SearchResultOperationType.Custom;

	[CompilerGenerated]
	private readonly SearchResultOperationType n9XtJcAn1QG;

	private IList<string> FWmtJVGDwne;

	private IList<BrowserHistoryItem> WPCtJZyu9IZ;

	private long ubDtJ9TftwL;

	private bool NyotJhrvFmp;

	private static kJRDjH226hXeo1HfxgN MAltOjQnpC1U8Zt9HNmV;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return KfEtJ8iOphn;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return W5ctJaB3KtI;
		}
	}

	public override bool IsSupportCondition
	{
		[CompilerGenerated]
		get
		{
			return TcTtJ72jAZa;
		}
	}

	public override string Id => "search.sys.browser.history";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return dQJtJRchnsY;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return wdstJqNnHDG;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return n9XtJcAn1QG;
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		BrowserHistoryItem browserHistoryItem = searchResultItem_0.Tag as BrowserHistoryItem;
		ChromeControl.R83vwtdpW8O(browserHistoryItem.BrowserProcName, browserHistoryItem.Url, browserHistoryItem.BrowserProcId);
	}

	public override void Init(SearchPluginInitContext searchPluginInitContext_0)
	{
		base.Init(searchPluginInitContext_0);
		RN2tJNGv6c1();
	}

	private void RN2tJNGv6c1()
	{
		IDictionary<string, string> customSettings = _settings.CustomSettings;
		if (customSettings != null && customSettings.ContainsKey("blacklist"))
		{
			FWmtJVGDwne = _settings.CustomSettings["blacklist"]?.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		}
		else
		{
			FWmtJVGDwne = null;
		}
	}

	public override void UpdateSettings(SearchPluginSettings settings)
	{
		base.UpdateSettings(settings);
		RN2tJNGv6c1();
	}

	private bool eRmtJJ1xSah()
	{
		if (WPCtJZyu9IZ == null)
		{
			return true;
		}
		if (AppHelper.fLiLTj0x4QY() - ubDtJ9TftwL > 60000L)
		{
			return true;
		}
		return false;
	}

	private bool cvUtJ0M8yEq(QueryContext queryContext_0)
	{
		if (!string.IsNullOrEmpty(queryContext_0.PluginItem.Condition))
		{
			return queryContext_0.PluginItem.Condition.Contains("full");
		}
		return false;
	}

	private Task tXdtJCNNCU0(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		if (cvUtJ0M8yEq(queryContext_0))
		{
			double result = 100.0;
			string condition = queryContext_0.PluginItem.Condition;
			if (condition != null && condition.Contains("maxdays"))
			{
				string text = queryContext_0.PluginItem.Condition.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault(_003C_003Ec.gMxv17CYJ5G ?? (_003C_003Ec.gMxv17CYJ5G = _003C_003Ec.An9v1aWlVuI.Owrv1yYmeph));
				if (text != null && !double.TryParse(text.Substring("maxdays:".Length), out result))
				{
					result = 30.0;
				}
			}
			try
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				IList<BrowserHistoryItem> history = ChromeControl.GetHistory(queryContext_0.Search, 50, result);
				if (!cancellationToken_0.IsCancellationRequested && history.HasData())
				{
					WPCtJZyu9IZ = history;
				}
				QcrtJydKxlX.Info($"获取浏览器历史耗时：{stopwatch.ElapsedMilliseconds} ms, {history?.Count}");
			}
			catch (Exception ex)
			{
				QcrtJydKxlX.Info("获取浏览器历史出错：" + ex.Message, ex);
			}
			return null;
		}
		if (!eRmtJJ1xSah())
		{
			return null;
		}
		if (NyotJhrvFmp)
		{
			return null;
		}
		NyotJhrvFmp = true;
		return Task.Run((Action)kWHtJEtP8Z0);
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		if (queryContext_0.IsGlobalSearch && queryContext_0.IsEmptySearch)
		{
			return SearchPlugin.EmptyResults;
		}
		List<SearchResultItem> list = new List<SearchResultItem>();
		IList<BrowserHistoryItem> list2 = null;
		if (queryContext_0.IsEmptySearch)
		{
			list2 = ChromeControl.GetHistory(queryContext_0.Search, 50, 4.0);
		}
		else
		{
			tXdtJCNNCU0(queryContext_0, cancellationToken_0);
			list2 = WPCtJZyu9IZ;
		}
		if (!list2.HasData())
		{
			return new List<SearchResultItem>
			{
				new SearchResultItem
				{
					Title = "暂无符合条件的浏览历史数据。" + (NyotJhrvFmp ? "加载中..." : ""),
					Description = "请确认浏览器开启，Quicker扩展已安装并成功连接，已开放history权限。",
					Icon = "fa:Light_Question"
				}
			};
		}
		string string_ = "fa:Solid_History:#0086ff";
		bool flag = cvUtJ0M8yEq(queryContext_0);
		int int_ = 200;
		using (IEnumerator<BrowserHistoryItem> enumerator = list2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
				_003C_003Ec__DisplayClass34_.FQjv1cSGSGq = enumerator.Current;
				if (!FWmtJVGDwne.HasData() || !FWmtJVGDwne.Any(_003C_003Ec__DisplayClass34_.maov1q4dvAw))
				{
					MultiFieldMatchResult multiFieldMatchResult = tkxn6HAKAgMT8gvXbyh.KwUidyksAU(_003C_003Ec__DisplayClass34_.FQjv1cSGSGq.Title, 1.0, _003C_003Ec__DisplayClass34_.FQjv1cSGSGq.Url, 0.4, true, queryContext_0);
					if (queryContext_0.IsEmptySearch || flag || (multiFieldMatchResult != null && multiFieldMatchResult != MultiFieldMatchResult.Empty))
					{
						int_ = YfYtJPjGHX3(list, _003C_003Ec__DisplayClass34_.FQjv1cSGSGq, string_, multiFieldMatchResult, int_);
					}
				}
			}
		}
		return list.OrderByDescending(_003C_003Ec.bh9v1RscKUE ?? (_003C_003Ec.bh9v1RscKUE = _003C_003Ec.An9v1aWlVuI.cO6v183YFVT)).Take(100).ToList();
	}

	private static int YfYtJPjGHX3(List<SearchResultItem> list_0, BrowserHistoryItem browserHistoryItem_0, string string_1, MultiFieldMatchResult multiFieldMatchResult_0, int int_0)
	{
		list_0.Add(new SearchResultItem
		{
			Title = browserHistoryItem_0.Title,
			SecondaryTitle = DateTimeOffset.FromUnixTimeMilliseconds(browserHistoryItem_0.LastVisitTime).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss"),
			Label = browserHistoryItem_0.BrowserProcName,
			Description = browserHistoryItem_0.Url,
			TextData = browserHistoryItem_0.Url,
			TextDataType = "url",
			Icon = AppHelper.GetUrlFavicon(browserHistoryItem_0.Url),
			SecondaryIcon = string_1,
			Tag = browserHistoryItem_0,
			Score = (multiFieldMatchResult_0?.Score ?? int_0--),
			TitleMatchPositions = multiFieldMatchResult_0?.Result1?.GetMatchPositions(),
			DescriptionMatchPositions = multiFieldMatchResult_0?.Result2?.GetMatchPositions()
		});
		return int_0;
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new BrowserHistorySearchPluginSettingsControl();
	}

	public override IEnumerable<SearchResultItem> GetResultsForEmptySearch(QueryContext queryContext_0, IList<SearchHistoryItem> ilist_2, CancellationToken cancellationToken_0, bool bool_1)
	{
		return DoSearch(queryContext_0, cancellationToken_0);
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		TkqATlWBPrB8iqNuFZQ.tGRtuKNCim6(searchResultItem_0.TextData, searchResultItem_0.Title, searchResultItem_0.Icon, contextMenu_0.Items);
		return true;
	}

	static kJRDjH226hXeo1HfxgN()
	{
		QcrtJydKxlX = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void kWHtJEtP8Z0()
	{
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			IList<BrowserHistoryItem> history = ChromeControl.GetHistory("", 1000, 4.0);
			if (history.HasData())
			{
				WPCtJZyu9IZ = history;
			}
			ubDtJ9TftwL = AppHelper.fLiLTj0x4QY();
			QcrtJydKxlX.Info($"获取浏览器历史耗时：{stopwatch.ElapsedMilliseconds} ms, {history?.Count}");
		}
		catch (Exception ex)
		{
			QcrtJydKxlX.Info("获取浏览器历史出错：" + ex.Message, ex);
		}
		finally
		{
			NyotJhrvFmp = false;
		}
	}

	internal static bool VSKMoZQnXYZJolTFOEuR()
	{
		return MAltOjQnpC1U8Zt9HNmV == null;
	}
}
