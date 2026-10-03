using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using eHGj15MUIx8QneCHitQ;
using IOn6RhAJdTUbfGy6gwn;
using ouEd6sWQPCqARFECqJe;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Chrome;

namespace AJ0bYW2ojUV4ldM3oND;

internal class FkN6J12XpMBh1QH4ouf : SearchPlugin, IContextMenuBuilder
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public string CD4v1ZFh4u0;

		public int Ngtv19MaeQX;

		private static _003C_003Ec__DisplayClass23_0 AqcJpycPxijt1WyL1LkR;

		internal SearchResultItem nudv1VFYmJP(BrowserTabInfo tab)
		{
			return new SearchResultItem
			{
				Title = tab.Title,
				Label = tab.BrowserProcName,
				TextData = tab.Url,
				TextDataType = "url",
				Description = tab.Url,
				Icon = "url:" + tab.FaviconUrl,
				SecondaryIcon = CD4v1ZFh4u0,
				Tag = tab,
				Score = Ngtv19MaeQX--
			};
		}

		internal static bool MRZlV7cPIZ3IpEBJryWO()
		{
			return AqcJpycPxijt1WyL1LkR == null;
		}
	}

	[CompilerGenerated]
	private readonly SearchPluginSettings OhPtJk92Zdg = new SearchPluginSettings
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
				TriggerWord = "@",
				Weight = 2.0
			}
		},
		PluginId = "search.sys.browser.tabs"
	};

	[CompilerGenerated]
	private readonly PluginInfo PZHtJGuvyLQ = new PluginInfo
	{
		Name = "浏览器标签页",
		Description = "搜索当前打开的浏览器标签",
		SearchContentName = "浏览器标签",
		Icon = "fa:Light_WindowMaximize"
	};

	[CompilerGenerated]
	private readonly string IBXtJswQ7k9 = "fa:Brands_Chrome";

	[CompilerGenerated]
	private readonly SearchResultOperationType iIbtJHylyEa = SearchResultOperationType.Custom;

	[CompilerGenerated]
	private readonly SearchResultOperationType w3etJ1YBFJY;

	private IList<BrowserTabInfo> LtXtJbSTgWg;

	private long EoMtJ63GbgZ;

	private bool VMPtJXbBitR;

	internal static FkN6J12XpMBh1QH4ouf MvWkZPQnE63Lj4YaGdMg;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return OhPtJk92Zdg;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return PZHtJGuvyLQ;
		}
	}

	public override string Id => "search.sys.browser.tabs";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return IBXtJswQ7k9;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return iIbtJHylyEa;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return w3etJ1YBFJY;
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		ChromeControl.ShowTab(searchResultItem_0.Tag as BrowserTabInfo);
	}

	private bool hR9tJYQ0MVf()
	{
		if (LtXtJbSTgWg != null)
		{
			if (AppHelper.fLiLTj0x4QY() - EoMtJ63GbgZ > 1000L)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (queryContext_0.IsGlobalSearch && string.IsNullOrWhiteSpace(queryContext_0.Search))
		{
			return list;
		}
		if (hR9tJYQ0MVf())
		{
			if (VMPtJXbBitR)
			{
				return list;
			}
			VMPtJXbBitR = true;
			try
			{
				Stopwatch.StartNew();
				LtXtJbSTgWg = ChromeControl.GetCurrentTabs();
				EoMtJ63GbgZ = AppHelper.fLiLTj0x4QY();
			}
			finally
			{
				VMPtJXbBitR = false;
			}
		}
		if (LtXtJbSTgWg == null)
		{
			return list;
		}
		_003C_003Ec__DisplayClass23_.CD4v1ZFh4u0 = "fa:Regular_Globe:#0086ff";
		if (string.IsNullOrEmpty(queryContext_0.Search))
		{
			_003C_003Ec__DisplayClass23_.Ngtv19MaeQX = 400;
			return LtXtJbSTgWg.Select(_003C_003Ec__DisplayClass23_.nudv1VFYmJP).ToList();
		}
		foreach (BrowserTabInfo item in LtXtJbSTgWg)
		{
			MultiFieldMatchResult multiFieldMatchResult = tkxn6HAKAgMT8gvXbyh.KwUidyksAU(item.Title, 2.0, item.Url, 1.0, true, queryContext_0);
			if (multiFieldMatchResult.Score > 0)
			{
				list.Add(new SearchResultItem
				{
					Title = item.Title,
					Label = item.BrowserProcName,
					Description = item.Url,
					Icon = "url:" + item.FaviconUrl,
					TextData = item.Url,
					TextDataType = "url",
					SecondaryIcon = _003C_003Ec__DisplayClass23_.CD4v1ZFh4u0,
					Tag = item,
					Score = multiFieldMatchResult.Score,
					TitleMatchPositions = multiFieldMatchResult.Result1?.GetMatchPositions()
				});
			}
		}
		return list;
	}

	private string VSwtJIaonov(int int_0)
	{
		return tZZhZGM4HaKvySF2OqY.ulvLOm7PgsE((uint)int_0);
	}

	private SearchResultItem LO5tJWPd501(BrowserTabInfo browserTabInfo_0, MultiFieldMatchResult multiFieldMatchResult_0)
	{
		return new SearchResultItem
		{
			Title = browserTabInfo_0.Title,
			Label = browserTabInfo_0.BrowserProcName,
			Description = browserTabInfo_0.Url,
			Icon = "url:" + browserTabInfo_0.FaviconUrl,
			SecondaryIcon = "shellicon:" + VSwtJIaonov(browserTabInfo_0.BrowserProcId),
			Tag = browserTabInfo_0,
			Score = multiFieldMatchResult_0.Score,
			TitleMatchPositions = multiFieldMatchResult_0.Result1?.GetMatchPositions()
		};
	}

	public override IEnumerable<SearchResultItem> GetResultsForEmptySearch(QueryContext queryContext_0, IList<SearchHistoryItem> ilist_1, CancellationToken cancellationToken_0, bool bool_1)
	{
		return DoSearch(queryContext_0, cancellationToken_0);
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		TkqATlWBPrB8iqNuFZQ.tGRtuKNCim6(searchResultItem_0.TextData, searchResultItem_0.Title, searchResultItem_0.Icon, contextMenu_0.Items);
		return true;
	}

	internal static bool X07Y7BQnGkSZDgFXnRQW()
	{
		return MvWkZPQnE63Lj4YaGdMg == null;
	}

	internal static void iLhqAKQnKjWNqYH2ZyKC()
	{
	}
}
