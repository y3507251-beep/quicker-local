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
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Services.Trans;
using Quicker.Domain.ContextMenus;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;

namespace f8ogFZ2dBqt6qJtMhHZ;

internal class OcfjAK2mDoFrkKoG0ga : SearchPlugin, IContextMenuBuilder
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		public string dtAv1bAZI8M;

		public string LKMv16if7ap;

		public Action FjMv1XEdsCF;

		internal static _003C_003Ec__DisplayClass22_0 T9iTf6cMpbPNDtM75VDA;

		internal void BTyv1HK4xLi(object sender, RoutedEventArgs e)
		{
			AppHelper.Try(FjMv1XEdsCF ?? (FjMv1XEdsCF = HkUv11RhDXK), "已复制", "复制出错。");
		}

		internal void HkUv11RhDXK()
		{
			Clipboard.SetText(dtAv1bAZI8M);
		}

		internal static bool DL50rAcMXc0BxUloixUd()
		{
			return T9iTf6cMpbPNDtM75VDA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_1
	{
		public KeyValuePair<string, string> V0Hv1x0YYrq;

		public _003C_003Ec__DisplayClass22_0 mOkv1rwfPy2;

		public Action LgGv1pifqjp;

		private static _003C_003Ec__DisplayClass22_1 jQXKRbcMn4DbAQ4qfjiN;

		internal void JVdv1mQAXak(object sender, RoutedEventArgs e)
		{
			AppHelper.Try(LgGv1pifqjp ?? (LgGv1pifqjp = BJfv1KXNH1M), "", "");
		}

		internal void BJfv1KXNH1M()
		{
			AppHelper.TryOpenUrlOrFile(V0Hv1x0YYrq.Value.Replace("%s", mOkv1rwfPy2.LKMv16if7ap.UrlEncode()));
		}

		internal static bool yLf1ZjcMemX73iriMtT3()
		{
			return jQXKRbcMn4DbAQ4qfjiN == null;
		}
	}

	private static readonly ILog ntRt0h1H6Dp;

	[CompilerGenerated]
	private readonly SearchPluginSettings yK6t0eNxJpD = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		IsEnabled = true,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "w "
			}
		},
		PluginId = "search.sys.other.dict",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo bSIt0Y7q1ip = new PluginInfo
	{
		Name = "简易词典",
		Description = "简明英汉词典",
		SearchContentName = "单词",
		Icon = "fa:Light_Language"
	};

	[CompilerGenerated]
	private readonly string EgIt0IYqUk8 = "search.sys.other.dict";

	[CompilerGenerated]
	private readonly string pOWt0WEowff = "fa:Light_Language";

	[CompilerGenerated]
	private readonly SearchResultOperationType Fxpt0kMxDGE = SearchResultOperationType.Copy;

	[CompilerGenerated]
	private readonly SearchResultOperationType UIpt0GyvUIH = SearchResultOperationType.PasteTo;

	private static OcfjAK2mDoFrkKoG0ga fmoenTQnSnCoTODEPgcc;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return yK6t0eNxJpD;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return bSIt0Y7q1ip;
		}
	}

	public override string Id
	{
		[CompilerGenerated]
		get
		{
			return EgIt0IYqUk8;
		}
	}

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return pOWt0WEowff;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return Fxpt0kMxDGE;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return UIpt0GyvUIH;
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		throw new NotImplementedException();
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		cancellationToken_0.ThrowIfCancellationRequested();
		var entries = Quicker.Domain.AppState.SQLDataMgr.PP6trtaO3SY<List<SearchResultItem>>("local_dictionary") ?? new List<SearchResultItem>();
		return entries.Where(x => (x.Title ?? "").IndexOf(queryContext_0.Search ?? "", StringComparison.OrdinalIgnoreCase) >= 0).Take(20).ToList();
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		_003C_003Ec__DisplayClass22_.dtAv1bAZI8M = searchResultItem_0.TextData;
		_003C_003Ec__DisplayClass22_.LKMv16if7ap = searchResultItem_0.QueryContext.Search;
		List<KeyValuePair<string, string>> obj = new List<KeyValuePair<string, string>>
		{
			new KeyValuePair<string, string>("有道词典", "https://www.youdao.com/w/auto/%s"),
			new KeyValuePair<string, string>("必应词典", "https://cn.bing.com/dict/search?q=%s"),
			new KeyValuePair<string, string>("剑桥词典", "https://dictionary.cambridge.org/zhs/%E8%AF%8D%E5%85%B8/%E8%8B%B1%E8%AF%AD-%E6%B1%89%E8%AF%AD-%E7%AE%80%E4%BD%93/%s"),
			new KeyValuePair<string, string>("Dict.cn词海", "https://dict.cn/search?q=%s")
		};
		AppHelper.AddMenuItem(contextMenu_0.Items, "复制", "复制此单词", "fa:Light_Copy", _003C_003Ec__DisplayClass22_.BTyv1HK4xLi);
		using (IEnumerator<KeyValuePair<string, string>> enumerator = ((IEnumerable<KeyValuePair<string, string>>)obj).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass22_1 _003C_003Ec__DisplayClass22_2 = new _003C_003Ec__DisplayClass22_1();
				_003C_003Ec__DisplayClass22_2.mOkv1rwfPy2 = _003C_003Ec__DisplayClass22_;
				_003C_003Ec__DisplayClass22_2.V0Hv1x0YYrq = enumerator.Current;
				AppHelper.AddMenuItem(contextMenu_0.Items, _003C_003Ec__DisplayClass22_2.V0Hv1x0YYrq.Key, "使用 " + _003C_003Ec__DisplayClass22_2.V0Hv1x0YYrq.Key + " 查单词", "", _003C_003Ec__DisplayClass22_2.JVdv1mQAXak);
			}
		}
		ContentContextMenuService.BuildTextContextMenus(contextMenu_0.Items, _003C_003Ec__DisplayClass22_.LKMv16if7ap);
		return true;
	}

	static OcfjAK2mDoFrkKoG0ga()
	{
		ntRt0h1H6Dp = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool bfruXRQnwV236qyCgE1m()
	{
		return fmoenTQnSnCoTODEPgcc == null;
	}

	internal static void uYgg3dQnsHunptfltePy()
	{
	}
}
