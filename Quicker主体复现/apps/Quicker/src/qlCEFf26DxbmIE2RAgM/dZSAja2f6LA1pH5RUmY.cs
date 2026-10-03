using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Modules.Searching.Builtin;
using Quicker.Modules.Searching.Plugins.Builtin.Network;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Yf8A0Tj55ce1jngb1h3;

namespace qlCEFf26DxbmIE2RAgM;

internal class dZSAja2f6LA1pH5RUmY : SearchPlugin, ICreateSettingUI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec amJv1YxyaBS;

		public static Func<JToken, string> c0Wv1IhV1K1;

		public static Func<JToken, string> EuZv1W0HSnh;

		private static _003C_003Ec v9brUucPTF8eYSfEbPuu;

		static _003C_003Ec()
		{
			amJv1YxyaBS = new _003C_003Ec();
		}

		internal string Oarv1h1F6IX(JToken x)
		{
			return (string?)x;
		}

		internal string C1dv1eD9GMy(JToken s)
		{
			return (string?)s;
		}

		internal static bool Tf5NYscPm81nlVErV6NH()
		{
			return v9brUucPTF8eYSfEbPuu == null;
		}
	}

	private static readonly ILog v4NtJUJYFot;

	[CompilerGenerated]
	private readonly SearchPluginSettings ttmtJlFprsD = new SearchPluginSettings
	{
		IncludeInGlobalSearch = true,
		IsEnabled = true,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "web "
			}
		},
		PluginId = "search.sys.web",
		MinGlobalTriggerLength = 2,
		GlobalSearchWeight = 10.0
	};

	[CompilerGenerated]
	private readonly PluginInfo NOUtJiKWFfG = new PluginInfo
	{
		Name = "网络搜索",
		Description = "使用搜索引擎搜索关键词",
		SearchContentName = "网络",
		Icon = "fa:Light_Globe"
	};

	[CompilerGenerated]
	private readonly string xIdtJ3lUxVv = "search.sys.web";

	[CompilerGenerated]
	private readonly string zu7tJfyJtAF = "fa:Light_Search";

	[CompilerGenerated]
	private readonly SearchResultOperationType PjmtJzWvP21 = SearchResultOperationType.Open;

	[CompilerGenerated]
	private readonly SearchResultOperationType LUdt0wBbeZ6 = SearchResultOperationType.Copy;

	[CompilerGenerated]
	private readonly bool jBet0tMkZw1 = true;

	private IList<WebSearchEngine> W7ct0gBFXWe = DcwtJdPNyVc();

	private static dZSAja2f6LA1pH5RUmY oNt6xsQnNlqEFsPyMDnT;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return ttmtJlFprsD;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return NOUtJiKWFfG;
		}
	}

	public override string Id
	{
		[CompilerGenerated]
		get
		{
			return xIdtJ3lUxVv;
		}
	}

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return zu7tJfyJtAF;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return PjmtJzWvP21;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return LUdt0wBbeZ6;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return jBet0tMkZw1;
		}
	}

	internal static IList<WebSearchEngine> DcwtJdPNyVc()
	{
		return new List<WebSearchEngine>
		{
			new WebSearchEngine
			{
				Name = "百度",
				TriggerWords = "bd",
				QueryUrl = "https://www.baidu.com/s?wd=%[s]",
				CompletionUrl = "https://sp0.baidu.com/5a1Fazu8AA54nxGko9WTAnF6hhy/su?wd=%[s]&json=1",
				CompletionXPath = ".s"
			},
			new WebSearchEngine
			{
				Name = "360搜索",
				TriggerWords = "so",
				QueryUrl = "https://www.so.com/s?ie=utf-8&fr=none&src=360sou_newhome&ssid=&sp=acc&cp=0f8c0009ac&q=%[s]",
				CompletionUrl = "https://sug.so.360.cn/suggest?encodein=utf-8&encodeout=utf-8&format=json&word=%[s]&callback=window.so.sug",
				CompletionXPath = ".result[*].word"
			},
			new WebSearchEngine
			{
				Name = "bilibili",
				TriggerWords = "bili",
				QueryUrl = "https://search.bilibili.com/all?keyword=%[s]&search_source=1",
				CompletionUrl = "https://s.search.bilibili.com/main/suggest?func=suggest&suggest_type=accurate&sub_type=tag&main_ver=v1&highlight=&userid=&bangumi_acc_num=1&special_acc_num=1&topic_acc_num=1&upuser_acc_num=3&tag_num=10&special_num=10&bangumi_num=10&upuser_num=3&term=%[s]",
				CompletionXPath = ".result.tag[*].term"
			},
			new WebSearchEngine
			{
				Name = "必应",
				TriggerWords = "bing",
				QueryUrl = "https://www.bing.com/search?q=%[s]",
				CompletionUrl = "https://api.bing.com/qsonhs.aspx?type=json&q=%[s]",
				CompletionXPath = ".AS.Results[*].Suggests[*].Txt"
			},
			new WebSearchEngine
			{
				Name = "谷歌",
				TriggerWords = "gg",
				QueryUrl = "https://www.google.com/search?q=%[s]",
				CompletionUrl = "http://suggestqueries.google.com/complete/search?client=youtube&q=%[s]&jsonp=window.google.ac.h",
				CompletionXPath = "[1][*][0]"
			},
			new WebSearchEngine
			{
				Name = "搜狗",
				TriggerWords = "sg",
				QueryUrl = "https://www.sogou.com/web?query=%[s]",
				CompletionUrl = "https://sor.html5.qq.com/api/getsug?key=%[s]&type=pc&ori=yes&pr=web&abtestid=0&ipn=false",
				CompletionXPath = "[1]"
			},
			new WebSearchEngine
			{
				Name = "淘宝",
				TriggerWords = "tb",
				QueryUrl = "https://s.taobao.com/search?q=%[s]",
				CompletionUrl = "https://suggest.taobao.com/sug?code=utf-8&q=%[s]",
				CompletionXPath = "result[*][0]"
			}
		};
	}

	public override void ApplySettings()
	{
		base.ApplySettings();
		if (_settings.CustomSettings != null && _settings.CustomSettings.ContainsKey("SEARCH_ENGINES"))
		{
			string value = _settings.CustomSettings["SEARCH_ENGINES"];
			W7ct0gBFXWe = JsonConvert.DeserializeObject<IList<WebSearchEngine>>(value);
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		throw new NotImplementedException();
	}

	public override IEnumerable<SearchResultItem> GetResultsForEmptySearch(QueryContext queryContext_0, IList<SearchHistoryItem> ilist_1, CancellationToken cancellationToken_0, bool bool_1)
	{
		if (queryContext_0.IsGlobalSearch)
		{
			return Array.Empty<SearchResultItem>();
		}
		List<SearchResultItem> list = new List<SearchResultItem>();
		int num = 100;
		foreach (WebSearchEngine item in W7ct0gBFXWe)
		{
			list.Add(new SearchResultItem
			{
				Title = item.Name,
				Description = item.TriggerWords,
				TextData = item.QueryUrl.Replace("%s", "").Replace("%[s]", ""),
				SecondaryTitle = "网页搜索",
				TextDataType = "url",
				Score = 950 - num++,
				Icon = item.GetIcon(),
				HistoryData = uUntJo9soCE(item, queryContext_0),
				CompletionText = item.TriggerWords
			});
		}
		gIh8AyjqAySmmxFMtv4.goOte1B8NYt(ilist_1, list);
		return list;
	}

	[SpecialName]
	public IList<WebSearchEngine> j3GtJO2tWRB()
	{
		return W7ct0gBFXWe;
	}

	private string uUntJo9soCE(WebSearchEngine webSearchEngine_0, QueryContext queryContext_0)
	{
		return webSearchEngine_0.Name;
	}

	public override IList<SearchResultItem> GetImmediateResults(QueryContext queryContext_0)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (queryContext_0.SearchWords.Length < 2)
		{
			string text = queryContext_0.Search.TrimEnd();
			foreach (WebSearchEngine item in W7ct0gBFXWe)
			{
				if (item.TriggerWords.StartsWith(text))
				{
					bool flag = item.TriggerWords == text;
					list.Add(new SearchResultItem
					{
						Title = (item.Name ?? ""),
						Description = ((!flag) ? item.TriggerWords : ((queryContext_0.Search.Length > item.TriggerWords.Length) ? "继续输入关键词进行搜索" : "继续输入空格+关键词进行搜索")),
						TextData = item.QueryUrl.Replace("%s", "").Replace("%[s]", ""),
						SecondaryTitle = "网页搜索",
						TextDataType = "url",
						Score = 950 + (flag ? 100 : 0),
						Icon = item.GetIcon(),
						HistoryData = uUntJo9soCE(item, queryContext_0),
						DescriptionMatchPositions = (flag ? null : Enumerable.Range(0, queryContext_0.Search.Length).ToList())
					});
				}
			}
		}
		else
		{
			foreach (WebSearchEngine item2 in W7ct0gBFXWe)
			{
				if (item2.TriggerWords.Equals(queryContext_0.SearchWords[0]))
				{
					string text2 = string.Join(" ", queryContext_0.OriginSearchWords.Skip(1));
					list.Add(new SearchResultItem
					{
						Title = (text2 ?? ""),
						Description = item2.Name + " 搜索 “" + text2 + "”",
						TextData = item2.QueryUrl.Replace("%s", text2).Replace("%[s]", text2.UrlEncode()),
						SecondaryTitle = "网页搜索",
						TextDataType = "url",
						Score = 950.0,
						Icon = item2.GetIcon()
					});
				}
			}
		}
		if (!queryContext_0.IsGlobalSearch && !list.HasData())
		{
			string text3 = string.Join(" ", queryContext_0.OriginSearchWords);
			int num = 100;
			foreach (WebSearchEngine item3 in W7ct0gBFXWe)
			{
				list.Add(new SearchResultItem
				{
					Title = item3.Name,
					Description = item3.Name + " 搜索 “" + text3 + "”",
					TextData = item3.QueryUrl.Replace("%s", text3).Replace("%[s]", text3.UrlEncode()),
					SecondaryTitle = "网页搜索",
					TextDataType = "url",
					Score = 950 + num,
					Icon = item3.GetIcon()
				});
				num--;
			}
		}
		return list;
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (queryContext_0.SearchWords.Length < 2)
		{
			return list;
		}
		foreach (WebSearchEngine item in W7ct0gBFXWe)
		{
			if (item.TriggerWords.Equals(queryContext_0.SearchWords[0]))
			{
				string string_ = string.Join(" ", queryContext_0.SearchWords.Skip(1));
				if (!string.IsNullOrEmpty(item.CompletionUrl))
				{
					wrytJT8JeOs(item, string_, list, cancellationToken_0);
				}
			}
		}
		return list;
	}

	private static void wrytJT8JeOs(WebSearchEngine webSearchEngine_0, string string_2, List<SearchResultItem> list_0, CancellationToken cancellationToken_0)
	{
		string text = webSearchEngine_0.CompletionUrl.Replace("%s", string_2).Replace("%[s]", string_2.UrlEncode());
		HttpClient httpClient = aFIptTXYsUoTUF4v33R.edGt1WgaPmw();
		try
		{
			using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(2.0));
			using CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(cancellationTokenSource.Token, cancellationToken_0);
			HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, text);
			httpRequestMessage.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
			httpRequestMessage.Properties.Add("Timeout", TimeSpan.FromSeconds(1.0));
			Uri uri = new Uri(webSearchEngine_0.QueryUrl);
			httpRequestMessage.Headers.Add("Referer", uri.Scheme + "://" + uri.Host);
			HttpResponseMessage result = httpClient.SendAsync(httpRequestMessage, cancellationTokenSource2.Token).GetAwaiter().GetResult();
			result.EnsureSuccessStatusCode();
			string result2 = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
			result2 = result2.Trim();
			if (!result2.StartsWithAny(false, "{", "["))
			{
				result2 = cd4tJM4RfaB(result2);
			}
			if (result2.IsNullOrEmpty())
			{
				return;
			}
			JToken jToken = JToken.Parse(result2);
			IList<string> list;
			if (webSearchEngine_0.CompletionXPath.Contains("[*]"))
			{
				list = jToken.SelectTokens(webSearchEngine_0.CompletionXPath).Select<JToken, string>(_003C_003Ec.c0Wv1IhV1K1 ?? (_003C_003Ec.c0Wv1IhV1K1 = _003C_003Ec.amJv1YxyaBS.Oarv1h1F6IX)).ToList();
			}
			else
			{
				JToken jToken2 = jToken.SelectToken(webSearchEngine_0.CompletionXPath);
				list = ((!(jToken2 is JArray source)) ? ((IList<string>)(((string?)jToken2)?.SplitToList())) : ((IList<string>)source.Select<JToken, string>(_003C_003Ec.EuZv1W0HSnh ?? (_003C_003Ec.EuZv1W0HSnh = _003C_003Ec.amJv1YxyaBS.C1dv1eD9GMy)).ToList()));
			}
			list?.Remove(string_2);
			if (!list.HasData())
			{
				return;
			}
			int num = 0;
			foreach (string item in list)
			{
				list_0.Add(new SearchResultItem
				{
					Title = (item ?? ""),
					Description = webSearchEngine_0.Name + " 搜索 “" + item + "”",
					TextData = webSearchEngine_0.QueryUrl.Replace("%s", item).Replace("%[s]", item.UrlEncode()),
					SecondaryTitle = "网页搜索",
					TextDataType = "url",
					Score = 850 - num,
					Icon = webSearchEngine_0.GetIcon()
				});
				num += 10;
			}
		}
		catch (TaskCanceledException)
		{
		}
		catch (Exception ex2)
		{
			v4NtJUJYFot.Warn("请求补全 " + text + " 出错:" + ex2.Message, ex2);
		}
	}

	private static string cd4tJM4RfaB(string string_2)
	{
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return null;
		}
		int num = string_2.IndexOf('(');
		string_2 = string_2.Substring(num + 1, string_2.LastIndexOf(')') - num - 1).Trim();
		if (!string_2.StartsWith("{") && !string_2.StartsWith("["))
		{
			return string_2;
		}
		return uhQtJAVYHnG(string_2);
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new WebSearchEnginePluginSettingsControl();
	}

	private static string uhQtJAVYHnG(string string_2)
	{
		char c;
		char c2;
		while (true)
		{
			c = string_2[0];
			int num = 1;
			if (oNt6xsQnNlqEFsPyMDnT == null)
			{
				goto IL_0003;
			}
			goto IL_0026;
			IL_0026:
			switch (num)
			{
			case 1:
				break;
			case 2:
				continue;
			default:
				goto IL_0051;
			}
			goto IL_0003;
			IL_0003:
			c2 = c switch
			{
				'[' => ']', 
				'{' => '}', 
				_ => '\0', 
			};
			if (c2 != 0)
			{
				break;
			}
			num = 0;
			if (oNt6xsQnNlqEFsPyMDnT == null)
			{
				goto IL_0026;
			}
			goto IL_0051;
			IL_0051:
			return null;
		}
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		for (int i = 0; i < string_2.Length; i++)
		{
			if (string_2[i] == c)
			{
				num4++;
			}
			else if (string_2[i] == c2)
			{
				num4--;
				if (num4 == 0)
				{
					num3 = i;
					break;
				}
			}
		}
		if (num3 > num2)
		{
			return string_2.Substring(num2, num3 - num2 + 1);
		}
		return null;
	}

	static dZSAja2f6LA1pH5RUmY()
	{
		v4NtJUJYFot = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool f8TRH1Qn9Hel5dgA2EJ5()
	{
		return oNt6xsQnNlqEFsPyMDnT == null;
	}
}
