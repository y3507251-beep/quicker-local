using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities.Pinyin;
using rlluYPmoa97LQl8MR84;

namespace v2NlFR21rmluiZMqxnt;

internal class oHULgO2ej03xFaPEQcU : SearchPlugin, ICreateSettingUI
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<string, bool> syOvbtu5to9;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec V3PvbLtTHqZ;

		public static Func<KeyValuePair<string, IMatchResult>, int> cZyvbv0jWnw;

		private static _003C_003Ec GnXSomcM8Zb9gRru592i;

		static _003C_003Ec()
		{
			V3PvbLtTHqZ = new _003C_003Ec();
		}

		internal int SxjvbgbyXme(KeyValuePair<string, IMatchResult> x)
		{
			return x.Value.Score;
		}

		internal static bool mfGjsKcMR8URiSjELFBx()
		{
			return GnXSomcM8Zb9gRru592i == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass31_0
	{
		public QueryContext aZfvbuC8LZB;

		public CancellationToken qRxvbNId8uB;

		public int rPvvbJkfRrN;

		public ConcurrentBag<KeyValuePair<string, IMatchResult>> eJAvb0k6ohb;

		private static _003C_003Ec__DisplayClass31_0 jWrHtecMPj4QZiHsOKGU;

		internal bool u1RvbSbMIdv(string x)
		{
			if (File.Exists(x))
			{
				return Path.GetFileName(x).Contains(aZfvbuC8LZB.PluginItem.Condition);
			}
			return false;
		}

		internal void cBIvb2JFMm2(string file)
		{
			foreach (string item in File.ReadLines(file))
			{
				if (!string.IsNullOrEmpty(item) && !qRxvbNId8uB.IsCancellationRequested)
				{
					int num = item.IndexOf('|');
					string string_ = ((num > 0) ? item.Substring(0, num) : item);
					IMatchResult matchResult = ((rPvvbJkfRrN == 0) ? tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(string_, aZfvbuC8LZB.Search) : JgbqhZmXYZ38IYyT8kD.udTv0YIJNUQ(string_, aZfvbuC8LZB.Search));
					if (matchResult != null)
					{
						eJAvb0k6ohb.Add(new KeyValuePair<string, IMatchResult>(item, matchResult));
					}
					continue;
				}
				return;
			}
			bool isCancellationRequested = qRxvbNId8uB.IsCancellationRequested;
		}

		internal static bool dMWR8AcMMYWM9LUQF6TB()
		{
			return jWrHtecMPj4QZiHsOKGU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass31_1
	{
		public string[] e01vbPLOUBv;

		internal static _003C_003Ec__DisplayClass31_1 fLNnhecM6LrHFmi6OJuB;

		internal bool ufLvbCLBuXs(string x)
		{
			if (File.Exists(x))
			{
				return Path.GetFileName(x).Contains(e01vbPLOUBv[0]);
			}
			return false;
		}

		internal static bool zFkBAHcMtik5kwVNdcBw()
		{
			return fLNnhecM6LrHFmi6OJuB == null;
		}
	}

	private static readonly ILog ipAtC8Zg9re;

	[CompilerGenerated]
	private readonly SearchPluginSettings QiWtCaiLcoe = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "t "
			}
		},
		PluginId = "search.sys.quicker.quicktext",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo haltC7VhflB = new PluginInfo
	{
		Name = "常用文本",
		Description = "快速输入常用文本内容",
		SearchContentName = "文本",
		Icon = "fa:Light_CommentDots"
	};

	[CompilerGenerated]
	private readonly string PMktCRZ4KiM = "search.sys.quicker.quicktext";

	[CompilerGenerated]
	private readonly string qFntCqJyCgA = "fa:Light_CommentDots";

	[CompilerGenerated]
	private readonly bool vxOtCcksKLh = true;

	[CompilerGenerated]
	private readonly SearchResultOperationType Q6XtCVWIA4E = SearchResultOperationType.PasteTo;

	[CompilerGenerated]
	private readonly SearchResultOperationType phltCZKgStI = SearchResultOperationType.Copy;

	private IList<string> qcdtC905On9 = new List<string>();

	internal static oHULgO2ej03xFaPEQcU zyvPESQefUu1GUWHhkSt;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return QiWtCaiLcoe;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return haltC7VhflB;
		}
	}

	public override string Id
	{
		[CompilerGenerated]
		get
		{
			return PMktCRZ4KiM;
		}
	}

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return qFntCqJyCgA;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return vxOtCcksKLh;
		}
	}

	public override bool IsSupportCondition => true;

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return Q6XtCVWIA4E;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return phltCZKgStI;
		}
	}

	public override void Init(SearchPluginInitContext searchPluginInitContext_0)
	{
		base.Init(searchPluginInitContext_0);
		OMxtCEjWMVg(searchPluginInitContext_0.Settings);
	}

	private void OMxtCEjWMVg(SearchPluginSettings searchPluginSettings_0)
	{
		qcdtC905On9.Clear();
		if (searchPluginSettings_0.CustomSettings == null || !searchPluginSettings_0.CustomSettings.ContainsKey("PATH_LIST"))
		{
			return;
		}
		string[] array = searchPluginSettings_0.CustomSettings["PATH_LIST"].SplitToList();
		List<string> list = new List<string>();
		string[] array2 = array;
		int num2 = default(int);
		foreach (string text in array2)
		{
			if (File.Exists(text))
			{
				int num = 0;
				if (zyvPESQefUu1GUWHhkSt != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				list.Add(text.ToLower());
			}
			else
			{
				if (!Directory.Exists(text))
				{
					continue;
				}
				foreach (string item in Directory.EnumerateFiles(text, "quick_text_*.txt", SearchOption.AllDirectories))
				{
					list.Add(item.ToLower());
				}
			}
		}
		qcdtC905On9 = list.Distinct().ToList();
	}

	public override void UpdateSettings(SearchPluginSettings settings)
	{
		base.UpdateSettings(settings);
		OMxtCEjWMVg(settings);
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
		_003C_003Ec__DisplayClass31_.aZfvbuC8LZB = queryContext_0;
		_003C_003Ec__DisplayClass31_.qRxvbNId8uB = cancellationToken_0;
		if (!_003C_003Ec__DisplayClass31_.aZfvbuC8LZB.IsEmptySearch && qcdtC905On9.HasData())
		{
			_003C_003Ec__DisplayClass31_.eJAvb0k6ohb = new ConcurrentBag<KeyValuePair<string, IMatchResult>>();
			_003C_003Ec__DisplayClass31_.rPvvbJkfRrN = 0;
			IList<string> list;
			if (!_003C_003Ec__DisplayClass31_.aZfvbuC8LZB.PluginItem.Condition.IsNullOrEmpty())
			{
				_003C_003Ec__DisplayClass31_1 _003C_003Ec__DisplayClass31_2 = new _003C_003Ec__DisplayClass31_1();
				_003C_003Ec__DisplayClass31_2.e01vbPLOUBv = _003C_003Ec__DisplayClass31_.aZfvbuC8LZB.PluginItem.Condition.Split(':', '：');
				if (_003C_003Ec__DisplayClass31_2.e01vbPLOUBv.Length == 2)
				{
					list = qcdtC905On9.Where(_003C_003Ec__DisplayClass31_2.ufLvbCLBuXs).ToList();
					_003C_003Ec__DisplayClass31_.rPvvbJkfRrN = Convert.ToInt32(_003C_003Ec__DisplayClass31_2.e01vbPLOUBv[1]);
				}
				else
				{
					list = qcdtC905On9.Where(_003C_003Ec__DisplayClass31_.u1RvbSbMIdv).ToList();
				}
			}
			else
			{
				list = qcdtC905On9.Where(_003C_003EO.syOvbtu5to9 ?? (_003C_003EO.syOvbtu5to9 = File.Exists)).ToList();
			}
			if (list.Count == 0)
			{
				return new List<SearchResultItem>
				{
					new SearchResultItem
					{
						Title = "文本查询错误：没有符合条件的数据文件。",
						Icon = "fa:Light_QuestionCircle:#FF0000",
						Description = "条件：" + _003C_003Ec__DisplayClass31_.aZfvbuC8LZB.PluginItem.Condition
					}
				};
			}
			list.AsParallel().ForAll(_003C_003Ec__DisplayClass31_.cBIvb2JFMm2);
			if (_003C_003Ec__DisplayClass31_.qRxvbNId8uB.IsCancellationRequested)
			{
				return SearchPlugin.EmptyResults;
			}
			List<SearchResultItem> list2 = new List<SearchResultItem>();
			{
				foreach (KeyValuePair<string, IMatchResult> item2 in _003C_003Ec__DisplayClass31_.eJAvb0k6ohb.OrderByDescending(_003C_003Ec.cZyvbv0jWnw ?? (_003C_003Ec.cZyvbv0jWnw = _003C_003Ec.V3PvbLtTHqZ.SxjvbgbyXme)))
				{
					string key = item2.Key;
					IMatchResult value = item2.Value;
					SearchResultItem item = sgXtCyF7WfJ(key, value);
					list2.Add(item);
				}
				return list2;
			}
		}
		return SearchPlugin.EmptyResults;
	}

	private static SearchResultItem sgXtCyF7WfJ(string string_2, IMatchResult imatchResult_0)
	{
		int num = 2;
		string text = default(string);
		string text2 = default(string);
		string text4 = default(string);
		while (true)
		{
			string[] array = string_2.Split(new char[1] { '|' }, 4);
			int num2 = 1;
			if (!kvrKdZQeb4FrFm1LTyW6())
			{
				num2 = num;
			}
			while (true)
			{
				string text3;
				object obj;
				switch (num2)
				{
				case 1:
					text = array[0];
					text2 = ((array.Length > 1) ? array[1] : null);
					text3 = ((array.Length > 2) ? array[2] : null);
					if (array.Length <= 3)
					{
						obj = text;
						if (obj == null)
						{
							goto IL_0049;
						}
					}
					else
					{
						obj = array[3];
						if (obj == null)
						{
							goto IL_0049;
						}
					}
					goto IL_004f;
				case 2:
					break;
				default:
					{
						return new SearchResultItem
						{
							Title = text,
							Description = (string.IsNullOrEmpty(text2) ? text4.ToShortString(30) : text2),
							TextData = text4,
							TextDataType = "text",
							Tag = text4,
							Score = (imatchResult_0?.Score ?? 0),
							TitleMatchPositions = imatchResult_0?.GetMatchPositions(),
							HistoryData = string_2
						};
					}
					IL_0089:
					text4 = Regex.Unescape(text4);
					num2 = 0;
					if (zyvPESQefUu1GUWHhkSt != null)
					{
						continue;
					}
					goto default;
					IL_004f:
					text4 = (string)obj;
					switch (text3)
					{
					case "S":
					case "s":
						goto IL_0089;
					case "E":
					case "e":
						text4 = Uri.UnescapeDataString(text4);
						break;
					}
					goto default;
					IL_0049:
					obj = "";
					goto IL_004f;
				}
				break;
			}
		}
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new QuickTextSearchPluginSettingsControl();
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem searchHistoryItem_0)
	{
		string historyData = searchHistoryItem_0.HistoryData;
		if (string.IsNullOrEmpty(historyData))
		{
			return null;
		}
		return sgXtCyF7WfJ(historyData, null);
	}

	static oHULgO2ej03xFaPEQcU()
	{
		ipAtC8Zg9re = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool kvrKdZQeb4FrFm1LTyW6()
	{
		return zyvPESQefUu1GUWHhkSt == null;
	}
}
