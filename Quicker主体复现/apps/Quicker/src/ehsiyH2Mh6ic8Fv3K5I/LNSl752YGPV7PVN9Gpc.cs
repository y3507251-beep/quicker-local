using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;

namespace ehsiyH2Mh6ic8Fv3K5I;

internal class LNSl752YGPV7PVN9Gpc : SearchPlugin, ICreateSettingUI
{
	private bool bM6tJrN6hhN = true;

	private bool SUftJpZE9ZY = true;

	[CompilerGenerated]
	private readonly SearchPluginSettings wLTtJBJ9O0m = new SearchPluginSettings
	{
		IncludeInGlobalSearch = true,
		GlobalSearchWeight = 0.2,
		Triggers = new List<SearchTrigger>(),
		PluginId = "search.sys.other.defaultoperation",
		CustomSettings = new Dictionary<string, string>
		{
			{ "CUSTOM_OPERATIONS", "百度搜索 %s|https://www.baidu.com/s?wd=%[s]\r\n[fa:Brands_Google:#d49000]谷歌搜索 %s|https://www.google.com/search?q=%[s]\r\n在动作库搜 %s|https://getquicker.net/Share/Actions?filter=%[s]\r\n" },
			{ "ENABLE_RUN_AS_COMMAND", "1" },
			{ "ENABLE_OPEN_AS_URL", "1" }
		}
	};

	[CompilerGenerated]
	private readonly PluginInfo Ua6tJQvCGNo = new PluginInfo
	{
		Name = "默认操作",
		Description = "为搜索结果较少的内容提供一些默认操作。如“作为网址打开”，“作为命令运行”等。",
		Icon = "fa:Light_Play"
	};

	[CompilerGenerated]
	private readonly string iU0tJj3TBSB = "search.sys.other.defaultoperation";

	[CompilerGenerated]
	private readonly string y3RtJnCgW4B = "fa:Light_Play";

	[CompilerGenerated]
	private readonly SearchResultOperationType KwktJ4nMM6w = SearchResultOperationType.Execute;

	[CompilerGenerated]
	private readonly SearchResultOperationType KWytJ5dJGEV = SearchResultOperationType.ExecWithAdmin;

	internal static LNSl752YGPV7PVN9Gpc k6bm6HQndss02aQddupS;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return wLTtJBJ9O0m;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return Ua6tJQvCGNo;
		}
	}

	public override string Id
	{
		[CompilerGenerated]
		get
		{
			return iU0tJj3TBSB;
		}
	}

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return y3RtJnCgW4B;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return KwktJ4nMM6w;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return KWytJ5dJGEV;
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		throw new NotImplementedException();
	}

	public override void Init(SearchPluginInitContext searchPluginInitContext_0)
	{
		base.Init(searchPluginInitContext_0);
		YjOtJmN1UoG();
	}

	public override void UpdateSettings(SearchPluginSettings settings)
	{
		base.UpdateSettings(settings);
		YjOtJmN1UoG();
	}

	private void YjOtJmN1UoG()
	{
		SearchPluginSettings settings = _settings;
		IDictionary<string, string> customSettings = settings.CustomSettings;
		if (customSettings != null && customSettings.ContainsKey("ENABLE_RUN_AS_COMMAND"))
		{
			bM6tJrN6hhN = settings.CustomSettings["ENABLE_RUN_AS_COMMAND"] == "1";
		}
		IDictionary<string, string> customSettings2 = settings.CustomSettings;
		if (customSettings2 != null && customSettings2.ContainsKey("ENABLE_OPEN_AS_URL"))
		{
			SUftJpZE9ZY = settings.CustomSettings["ENABLE_OPEN_AS_URL"] == "1";
		}
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		if (queryContext_0.IsEmptySearch)
		{
			return SearchPlugin.EmptyResults;
		}
		int num = 100;
		List<SearchResultItem> list = new List<SearchResultItem>();
		object obj;
		if (!string.IsNullOrEmpty(AppState.HHxtaMaoqJr().SearchSettings?.DefaultSearchProcessor) && AppState.HHxtaMaoqJr().SearchSettings?.DefaultSearchProcessor != "%s")
		{
			SearchSettings searchSettings = AppState.HHxtaMaoqJr().SearchSettings;
			if (searchSettings == null)
			{
				obj = null;
			}
			else
			{
				obj = searchSettings.DefaultSearchProcessor;
				if (obj != null)
				{
					goto IL_007b;
				}
			}
			obj = "%s";
			goto IL_007b;
		}
		goto IL_01be;
		IL_007b:
		string text = (string)obj;
		if (!text.Contains("%s") && !text.Contains("%[s]"))
		{
			(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(text);
			if (tuple.Item1 != null)
			{
				list.Add(new SearchResultItem
				{
					Title = "使用 " + tuple.Item1.Title + " 处理 " + queryContext_0.OriginSearch,
					Description = tuple.Item1.Description,
					TextData = "quicker://runaction:" + tuple.Item1.Id + "?" + queryContext_0.OriginSearch,
					Icon = tuple.Item1.Icon,
					Score = num--
				});
			}
		}
		else
		{
			text = text.Replace("%s", queryContext_0.OriginSearch.TrimStart());
			text = text.Replace("%[s]", queryContext_0.OriginSearch.TrimStart().EscapeUriDataString());
			list.Add(new SearchResultItem
			{
				Title = (text ?? ""),
				Description = "打开或运行",
				TextData = text,
				Icon = "fa:Light_Play:#d49000",
				Score = num--
			});
		}
		goto IL_01be;
		IL_01be:
		if (bM6tJrN6hhN)
		{
			list.Add(new SearchResultItem
			{
				Title = "作为命令运行",
				Description = "运行命令 " + queryContext_0.OriginSearch,
				TextData = queryContext_0.OriginSearch.Trim(),
				Icon = "fa:Light_Play:#d49000",
				Score = num--
			});
		}
		if (SUftJpZE9ZY)
		{
			if (!queryContext_0.Search.Trim().Contains(' '))
			{
				if (queryContext_0.Search.StartsWith("http", StringComparison.OrdinalIgnoreCase))
				{
					string text2 = queryContext_0.OriginSearch.Trim();
					if (!text2.Contains('.'))
					{
						text2 += ".com";
					}
					list.Add(new SearchResultItem
					{
						Title = "打开网址 " + text2,
						Description = "作为网址打开",
						TextData = text2,
						Icon = "fa:Light_Globe:#d49000",
						Score = 100 + num--
					});
				}
				else
				{
					string text3 = "https://" + queryContext_0.OriginSearch.Trim();
					int num2 = (text3.EndsWithAny(true, ".cn", ".com", ".net", ".org", ".edu", ".gov", ".xyz", ".top", ".vip", ".cc", ".io", ".ltd", ".tv") ? 100 : 0);
					if (!text3.Contains('.'))
					{
						text3 += ".com";
					}
					list.Add(new SearchResultItem
					{
						Title = "打开网址 " + text3,
						Description = "作为网址打开",
						TextData = text3,
						Icon = "fa:Light_Globe:#d49000",
						Score = num2 + num--
					});
				}
			}
			if (queryContext_0.Search.Trim() == "quicker" || queryContext_0.Search.Trim() == "getquicker")
			{
				list.Add(new SearchResultItem
				{
					Title = "打开Quicker主页",
					Description = "打开Quicker官方网址",
					TextData = "https://getquicker.net",
					Icon = "https://files.getquicker.net/_icons/DB515904053CE292B1F30E179EB2B77437CA8A24.png",
					Score = num--
				});
			}
		}
		if (_settings != null && _settings.CustomSettings != null && _settings.CustomSettings.ContainsKey("CUSTOM_OPERATIONS"))
		{
			string text4 = _settings.CustomSettings["CUSTOM_OPERATIONS"];
			if (!string.IsNullOrEmpty(text4))
			{
				foreach (CommonOperationItem item in CommonOperationItem.ParseLines(text4, true, true))
				{
					string text5 = DoitJKl10QB(item.Data, queryContext_0.OriginSearch);
					list.Add(new SearchResultItem
					{
						Title = DoitJKl10QB(item.Title, queryContext_0.OriginSearch),
						Description = item.Description.Or(text5),
						TextData = text5,
						Icon = item.Icon.Or(text5.StartsWith("http", StringComparison.OrdinalIgnoreCase) ? AppHelper.GetUrlFavicon(text5) : "fa:Light_Play:#d49000"),
						Score = num--
					});
				}
			}
		}
		return list;
	}

	private string DoitJKl10QB(string string_2, string string_3)
	{
		return string_2.Replace("%s", string_3).Replace("%[s]", string_3.EscapeUriDataString());
	}

	private bool a5etJxF2Mr1(string string_2)
	{
		if (!string_2.Trim().Contains(' '))
		{
			return string_2.Contains('.');
		}
		return false;
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new DefaultOperationPluginSettingsControl();
	}

	internal static bool POPHknQnO65ZxA9Qkqig()
	{
		return k6bm6HQndss02aQddupS == null;
	}
}
