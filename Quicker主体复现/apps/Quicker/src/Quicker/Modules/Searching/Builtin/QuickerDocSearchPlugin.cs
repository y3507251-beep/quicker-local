using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using IgQBbvXMVdsN7GVNUxX;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.QuickActions;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.UI;

namespace Quicker.Modules.Searching.Builtin;

public class QuickerDocSearchPlugin : SearchPlugin, IContextMenuBuilder
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public DocSearchResultItem x;

		internal static _003C_003Ec__DisplayClass27_0 pEgp9bcU31n1BlfElWl4;

		internal bool hapvbDqE2vp(SearchResultItem d)
		{
			return d.Title == x.Title;
		}

		static _003C_003Ec__DisplayClass27_0()
		{
		}

		internal static bool pc35WjcUEwMFoXpEQcUt()
		{
			return pEgp9bcU31n1BlfElWl4 == null;
		}

		internal static void KRhDQNcU0pdJ4VtFqkh2()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public int LB7vbosD0QD;

		private static _003C_003Ec__DisplayClass28_0 c5KWb2cU1uQoHtZSeUIb;

		internal SearchResultItem lipvbdoVTLS(string x, int index)
		{
			string[] array = x.Split('|');
			return new SearchResultItem
			{
				Title = array[0],
				Description = array[1],
				Icon = "fa:Light_InfoCircle:#B0B0B0",
				Score = LB7vbosD0QD - index
			};
		}

		static _003C_003Ec__DisplayClass28_0()
		{
		}

		internal static bool NZLW3scUKDl6CPpXEc3e()
		{
			return c5KWb2cU1uQoHtZSeUIb == null;
		}

		internal static void VKjjLycUvq0EuqEiH52k()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass31_0
	{
		public SearchResultItem BfnvbMRm5o8;

		internal static _003C_003Ec__DisplayClass31_0 V3uNbDcUd7natyxtEV5c;

		internal void GoAvbTYpSrl(object sender, RoutedEventArgs e)
		{
			ClipboardHelper.SetText(BfnvbMRm5o8.TextData);
			AppHelper.ShowSuccess("已复制。");
		}

		internal static bool pqa29VcUOH3hv0BwT0J4()
		{
			return V3uNbDcUd7natyxtEV5c == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass32_0
	{
		public SearchResultItem tOOvbOm7lAU;

		internal static _003C_003Ec__DisplayClass32_0 b8PFFAcUkHlaHofyaeIQ;

		internal void ycAvbAeQnCo(object x)
		{
			ClipboardHelper.SetText(tOOvbOm7lAU.TextData);
			AppHelper.ShowSuccess("已复制。");
		}

		internal static bool IjwIYncUaXkXOFxwXqGM()
		{
			return b8PFFAcUkHlaHofyaeIQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public string url;

		internal static _003C_003Ec__DisplayClass33_0 qF34BocU9UZUi5echiYK;

		internal bool Hx4vbFyxFiI(DocSearchResultItem x)
		{
			return x.Link == url;
		}

		internal static bool Syus7EcULXdUIeBkL19i()
		{
			return qF34BocU9UZUi5echiYK == null;
		}
	}

	private static readonly ILog LtitPYv9cl6;

	[CompilerGenerated]
	private readonly SearchPluginSettings Xw3tPIgia88 = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "?"
			},
			new SearchTrigger
			{
				TriggerWord = "？"
			}
		},
		PluginId = "search.sys.quicker.docs",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo S2etPWmdgWr = new PluginInfo
	{
		Name = "Quicker文档",
		Description = "搜索Quicker在线文档",
		SearchContentName = "Quicker文档",
		Icon = "fa:Light_Book"
	};

	[CompilerGenerated]
	private readonly string H4utPkHGiwU = "search.sys.quicker.docs";

	[CompilerGenerated]
	private readonly string wr7tPGosAp0;

	private bool zFFtPsxHlcs;

	private IList<DocSearchResultItem> CgytPHTZI0Q;

	private static QuickerDocSearchPlugin t24cunQjAR5IXEGFCqd2;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return Xw3tPIgia88;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return S2etPWmdgWr;
		}
	}

	public override string Id
	{
		[CompilerGenerated]
		get
		{
			return H4utPkHGiwU;
		}
	}

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return wr7tPGosAp0;
		}
	}

	public override SearchResultOperationType EnterSelectOperation => SearchResultOperationType.Open;

	public override SearchResultOperationType CtrlEnterOperation => SearchResultOperationType.Copy;

	public override bool IsSupportHistory => true;

	public override void ProcessResult(SearchResultItem resultItem, QueryContext context)
	{
		AppHelper.TryOpenUrlOrFile((string)resultItem.Tag);
	}

	public override void Init(SearchPluginInitContext context)
	{
		base.Init(context);
		CgytPHTZI0Q = AppState.SQLDataMgr.PP6trtaO3SY<DocSearchResult>("local_document_index")?.Items ?? new List<DocSearchResultItem>();
		zFFtPsxHlcs = CgytPHTZI0Q.HasData();
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext, CancellationToken cancellationToken)
	{
		if (string.IsNullOrEmpty(queryContext.TriggerWord) && string.IsNullOrEmpty(queryContext.Search))
		{
			return new List<SearchResultItem>();
		}
		if (string.IsNullOrEmpty(queryContext.Search))
		{
			return rg7tP9yS6nw();
		}
		string secondaryIcon = (queryContext.IsGlobalSearch ? "fa:Solid_Question:#0086ff" : string.Empty);
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (!zFFtPsxHlcs)
		{
			if (queryContext.IsGlobalSearch)
			{
				return list;
			}
		}
		else
		{
			foreach (DocSearchResultItem item in CgytPHTZI0Q)
			{
				IMatchResult matchResult = tkxn6HAKAgMT8gvXbyh.Xafi4HAJ87(item.Title, queryContext);
				if (matchResult != null)
				{
					list.Add(new SearchResultItem
					{
						Title = item.Title,
						Label = qM2tPeEHdug(item),
						Icon = i8MtPhfX1xV(item),
						SecondaryIcon = secondaryIcon,
						Tag = item.Link,
						TextData = item.Link,
						Description = "本地文档索引",
						Score = matchResult.Score,
						TitleMatchPositions = matchResult.GetMatchPositions(),
						HistoryData = item.Link
					});
				}
			}
		}
		if (queryContext.IsGlobalSearch)
		{
			return list;
		}
		return list;
	}

	private static List<SearchResultItem> rg7tP9yS6nw()
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		List<string> source = new List<string> { "关键词或拼音|搜索动作或Quicker设置页面", "le:|查看最近修改的动作(Last Edited)", "li:|查看最近安装的动作(Last Installed)", "?+关键词|搜索Quicker文档", "f+空格+关键词|搜索本地文件(需everything开启)", "`+关键词|搜索文本指令", "=算式，如78*56、Math.Pow(10,2)*Math.Pi|计算算式的结果(支持表达式语法)", "按键提示|回车：运行动作；Tab：选择动作，并为动作输入参数;" };
		_003C_003Ec__DisplayClass28_.LB7vbosD0QD = 10000;
		List<SearchResultItem> list = source.Select(_003C_003Ec__DisplayClass28_.lipvbdoVTLS).ToList();
		int num = list.Count + 1;
		if (AppState.HHxtaMaoqJr().QuickRunItems.HasData())
		{
			foreach (QuickRunItem quickRunItem in AppState.HHxtaMaoqJr().QuickRunItems)
			{
				list.Add(new SearchResultItem
				{
					Title = quickRunItem.CmdText,
					Description = quickRunItem.GetSummary(),
					Icon = "fa:Light_InfoCircle:#B0B0B0",
					Score = _003C_003Ec__DisplayClass28_.LB7vbosD0QD - num++
				});
			}
		}
		return list;
	}

	private string i8MtPhfX1xV(DocSearchResultItem docSearchResultItem_0)
	{
		if (docSearchResultItem_0.Type == "Article")
		{
			return "fa:Solid_FileAlt:#17a2b8";
		}
		if (docSearchResultItem_0.Type == "DevDoc")
		{
			return "fa:Solid_PencilRuler:#007bff";
		}
		return "fa:Solid_Book:#369e4d";
	}

	private string qM2tPeEHdug(DocSearchResultItem docSearchResultItem_0)
	{
		if (docSearchResultItem_0.Type == "Article")
		{
			return "知识库";
		}
		if (docSearchResultItem_0.Type == "DevDoc")
		{
			return "动作开发";
		}
		return "使用教程";
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem, ContextMenu contextMenu, Window window)
	{
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
		_003C_003Ec__DisplayClass31_.BfnvbMRm5o8 = searchResultItem;
		AppHelper.AddMenuItem(contextMenu.Items, "复制网址", "复制文档网址", "fa:Light_Copy", _003C_003Ec__DisplayClass31_.GoAvbTYpSrl);
		return true;
	}

	public IList<MenuItemInfo> GetQuickButtons(SearchResultItem item)
	{
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
		_003C_003Ec__DisplayClass32_.tOOvbOm7lAU = item;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass32_.tOOvbOm7lAU.TextData))
		{
			return null;
		}
		return new List<MenuItemInfo>
		{
			new MenuItemInfo
			{
				Title = "复制网址",
				Icon = "fa:Light_Copy",
				Command = new RelayCommand(_003C_003Ec__DisplayClass32_.ycAvbAeQnCo)
			}
		};
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem historyItem)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.url = historyItem.HistoryData;
		if (CgytPHTZI0Q.HasData())
		{
			DocSearchResultItem docSearchResultItem = CgytPHTZI0Q.FirstOrDefault(_003C_003Ec__DisplayClass33_.Hx4vbFyxFiI);
			if (docSearchResultItem != null)
			{
				return new SearchResultItem
				{
					Title = docSearchResultItem.Title,
					Label = qM2tPeEHdug(docSearchResultItem),
					Icon = i8MtPhfX1xV(docSearchResultItem),
					SecondaryIcon = "",
					Tag = docSearchResultItem.Link,
					TextData = docSearchResultItem.Link,
					Description = "本地文档索引",
					Score = 0.0,
					TitleMatchPositions = null,
					HistoryData = docSearchResultItem.Link
				};
			}
		}
		return null;
	}

	static QuickerDocSearchPlugin()
	{
		LtitPYv9cl6 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool j10khcQjnLsuYmE8YpfK()
	{
		return t24cunQjAR5IXEGFCqd2 == null;
	}
}
