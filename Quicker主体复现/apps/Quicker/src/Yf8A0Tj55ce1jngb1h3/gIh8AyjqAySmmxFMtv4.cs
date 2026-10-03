using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using AJ0bYW2ojUV4ldM3oND;
using ehsiyH2Mh6ic8Fv3K5I;
using f8ogFZ2dBqt6qJtMhHZ;
using FdaTBA2jtlaSbaTAl7V;
using j8ojdX2D2B58EaImI2T;
using log4net;
using lskHK22VTco51slRGWB;
using NJ0cYkjlYYOxMCCyCXt;
using qlCEFf26DxbmIE2RAgM;
using qqBnADjS9jtMqIMqTPB;
using Quicker.Annotations;
using Quicker.Api;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Searching.Actions;
using Quicker.Modules.Searching;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.View;
using SWBMfZYGyc6L9yHIvKQ;
using t8SGKhhgLWTgeqjGcrq;
using u0v4xm29tYkLqOhtv67;
using uqYElb2WVkpP0FWdV1D;
using v2NlFR21rmluiZMqxnt;

namespace Yf8A0Tj55ce1jngb1h3;

internal static class gIh8AyjqAySmmxFMtv4
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ag1vri0cRDk;

		public static Func<pHWGPP2zInOmuZ0GwWH, bool> jEYvr3hkhFb;

		public static Func<pHWGPP2zInOmuZ0GwWH, SearchPluginItem> kh9vrfxTyYe;

		public static Func<SearchResultItem, double> kwSvrzN7Rkn;

		public static Func<pHWGPP2zInOmuZ0GwWH, bool> KFpvpw9vV3U;

		public static Func<pHWGPP2zInOmuZ0GwWH, SearchPluginItem> bJbvpt8n0xb;

		public static Func<Task, bool> FkIvpgxTPtB;

		public static Func<SearchResultItem, double> XEKvpLJdTPS;

		public static Func<SearchResultItem, double> ROSvpvJMSGw;

		internal static _003C_003Ec hYIaRncwm8MJsqT3dCZ1;

		static _003C_003Ec()
		{
			ag1vri0cRDk = new _003C_003Ec();
		}

		internal bool vV4vrorqPvy(pHWGPP2zInOmuZ0GwWH x)
		{
			if (x.diTtecv8vkP().Plugin.IsSupportHistory)
			{
				return x.diTtecv8vkP().Settings?.ShowSearchHistory ?? false;
			}
			return false;
		}

		internal SearchPluginItem sNXvrTM9JbS(pHWGPP2zInOmuZ0GwWH x)
		{
			return x.diTtecv8vkP();
		}

		internal double YRRvrMKY8oD(SearchResultItem x)
		{
			return x.WeightedScore;
		}

		internal bool OiCvrAjZQ88(pHWGPP2zInOmuZ0GwWH x)
		{
			return x.diTtecv8vkP().Plugin.IsSupportHistory;
		}

		internal SearchPluginItem T1wvrOUPicX(pHWGPP2zInOmuZ0GwWH x)
		{
			return x.diTtecv8vkP();
		}

		internal bool w6jvrFkD274(Task x)
		{
			return !x.IsCompleted;
		}

		internal double XCvvrUUlJqX(SearchResultItem x)
		{
			return x.WeightedScore;
		}

		internal double qq0vrlNCCHI(SearchResultItem x)
		{
			return x.WeightedScore;
		}

		internal static bool lZGOdpcwsa67bgh54BmW()
		{
			return hYIaRncwm8MJsqT3dCZ1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public SearchPlugin KwEvp25i5GG;

		internal static _003C_003Ec__DisplayClass11_0 qmWlNOcw72IJPl4WdKdD;

		internal bool spQvpSGXCVg(SearchPluginSettings x)
		{
			return x.PluginId == KwEvp25i5GG.Id;
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}

		internal static bool N2cM8dcw4ha3Wk8aT9Qj()
		{
			return qmWlNOcw72IJPl4WdKdD == null;
		}

		internal static void Mr31kucwHtPhEy0BfYYw()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public string jl1vpulNNtD;

		public int ROYvpNaKXDm;

		public int LDqvpJfBBd6;

		public SearchWindow t0Jvp0llOpc;

		public IList<SearchHistoryItem> UCSvpC7WEbL;

		public CancellationToken K6tvpPOGiuF;

		public IList<pHWGPP2zInOmuZ0GwWH> vP2vpEeS6OZ;

		public string kKpvpyy2UAY;

		public ConcurrentBag<SearchResultItem> QACvp8ZOfOY;

		private static _003C_003Ec__DisplayClass16_0 R7K3B2cwzEnIgExs5pBP;

		internal static bool HatMWgcTVJVXAkK2el7e()
		{
			return R7K3B2cwzEnIgExs5pBP == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_1
	{
		public pHWGPP2zInOmuZ0GwWH BGWvpRoQjJX;

		public _003C_003Ec__DisplayClass16_0 T71vpqBym78;

		public Func<SearchHistoryItem, bool> XdevpcjyDDV;

		internal static _003C_003Ec__DisplayClass16_1 o9pgPycTF0U1YFji3MkZ;

		internal void KSLvpa0sqYb()
		{
			QueryContext queryContext = new QueryContext
			{
				RawQuery = T71vpqBym78.jl1vpulNNtD,
				PluginItem = BGWvpRoQjJX.diTtecv8vkP(),
				QuerySerial = T71vpqBym78.ROYvpNaKXDm,
				SearchSession = T71vpqBym78.LDqvpJfBBd6,
				SearchWindow = T71vpqBym78.t0Jvp0llOpc
			};
			queryContext.SetSearch(BGWvpRoQjJX.VL6te7XmvJQ(), !AppState.HHxtaMaoqJr().MatchUpperCaseEqual);
			List<SearchResultItem> list = BGWvpRoQjJX.diTtecv8vkP().Plugin.GetResultsForEmptySearch(queryContext, T71vpqBym78.UCSvpC7WEbL.Where(XdevpcjyDDV ?? (XdevpcjyDDV = fSXvp7ffsKm)).ToList(), T71vpqBym78.K6tvpPOGiuF, T71vpqBym78.vP2vpEeS6OZ.Count == 1).ToList();
			if (T71vpqBym78.K6tvpPOGiuF.IsCancellationRequested)
			{
				return;
			}
			int num2 = default(int);
			foreach (SearchResultItem item in list)
			{
				item.QueryContext = queryContext;
				item.WeightedScore = item.Score;
				if (!string.IsNullOrEmpty(item.Icon))
				{
					int num = 0;
					if (!wFxR7BcTcv4WLXG5Bhn9())
					{
						num = num2;
					}
					switch (num)
					{
					}
				}
				else
				{
					item.Icon = BGWvpRoQjJX.diTtecv8vkP().Plugin.DefaultItemIcon;
				}
				if (item.IsHistoryItem)
				{
					item.SecondaryIcon = T71vpqBym78.kKpvpyy2UAY;
				}
				T71vpqBym78.QACvp8ZOfOY.Add(item);
			}
		}

		internal bool fSXvp7ffsKm(SearchHistoryItem x)
		{
			return x.PlugInId == BGWvpRoQjJX.diTtecv8vkP().Plugin.Id;
		}

		internal static bool wFxR7BcTcv4WLXG5Bhn9()
		{
			return o9pgPycTF0U1YFji3MkZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public IList<SearchHistoryItem> I8YvpZxTYkY;

		public IList<pHWGPP2zInOmuZ0GwWH> v3Hvp9EwpF6;

		public int k6vvphO9dx8;

		public string H4XvpeFE8A4;

		public int GCXvpYbMEZc;

		public SearchWindow dJHvpILDWG0;

		public bool FjavpWk6D9t;

		public ConcurrentBag<SearchResultItem> h33vpkk31EG;

		public ParallelOptions F4VvpG9BsIN;

		public CancellationToken rQCvps4OJTS;

		internal static _003C_003Ec__DisplayClass17_0 NTefkecTXNPslgSGG3db;

		internal void yAUvpV1E3XV()
		{
			try
			{
				I8YvpZxTYkY = XMwte44BNt0.GetSearchHistory(v3Hvp9EwpF6.First().VL6te7XmvJQ(), v3Hvp9EwpF6.Where(_003C_003Ec.KFpvpw9vV3U ?? (_003C_003Ec.KFpvpw9vV3U = _003C_003Ec.ag1vri0cRDk.OiCvrAjZQ88)).Select(_003C_003Ec.bJbvpt8n0xb ?? (_003C_003Ec.bJbvpt8n0xb = _003C_003Ec.ag1vri0cRDk.T1wvrOUPicX)).ToList());
			}
			catch (Exception ex)
			{
				ogutejRcN2Y.Warn($"获取历史搜索记录出错：({k6vvphO9dx8})" + ex.Message, ex);
			}
		}

		internal static bool Y9OD57cT25KVTMGpRfBZ()
		{
			return NTefkecTXNPslgSGG3db == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_1
	{
		public pHWGPP2zInOmuZ0GwWH ca0vp1tG2Oe;

		public _003C_003Ec__DisplayClass17_0 GvKvpbwmT10;

		internal static _003C_003Ec__DisplayClass17_1 NGufaRcTnRHl9tJPalOs;

		internal void S7EvpHVkh2w()
		{
			int num = 1;
			QueryContext queryContext = default(QueryContext);
			int num4 = default(int);
			IList<SearchResultItem> list = default(IList<SearchResultItem>);
			while (true)
			{
				Stopwatch stopwatch = new Stopwatch();
				int num2 = 0;
				if (!vloKjpcTeufthL60Wow8())
				{
					goto IL_01cc;
				}
				goto IL_01d0;
				IL_01d0:
				while (true)
				{
					switch (num2)
					{
					default:
					{
						stopwatch.Start();
						queryContext = new QueryContext
						{
							RawQuery = GvKvpbwmT10.H4XvpeFE8A4,
							PluginItem = ca0vp1tG2Oe.diTtecv8vkP(),
							QuerySerial = GvKvpbwmT10.k6vvphO9dx8,
							SearchSession = GvKvpbwmT10.GCXvpYbMEZc,
							SearchWindow = GvKvpbwmT10.dJHvpILDWG0,
							CurrentExe = GvKvpbwmT10.dJHvpILDWG0?.CurrentExeBeforeShow
						};
						queryContext.SetSearch(ca0vp1tG2Oe.VL6te7XmvJQ(), GvKvpbwmT10.FjavpWk6D9t);
						IList<SearchResultItem> immediateResults = ca0vp1tG2Oe.diTtecv8vkP().Plugin.GetImmediateResults(queryContext);
						if (immediateResults.HasData())
						{
							foreach (SearchResultItem item in immediateResults)
							{
								item.QueryContext = queryContext;
								item.WeightedScore = item.Score * ca0vp1tG2Oe.diTtecv8vkP().Weight;
								if (string.IsNullOrEmpty(item.Icon))
								{
									item.Icon = ca0vp1tG2Oe.diTtecv8vkP().Plugin.DefaultItemIcon;
								}
								GvKvpbwmT10.h33vpkk31EG.Add(item);
								int num3 = 0;
								if (!vloKjpcTeufthL60Wow8())
								{
									num3 = num4;
								}
								switch (num3)
								{
								}
							}
						}
						if (GvKvpbwmT10.F4VvpG9BsIN.CancellationToken.IsCancellationRequested)
						{
							return;
						}
						goto IL_019b;
					}
					case 1:
						break;
					case 2:
						if (GvKvpbwmT10.F4VvpG9BsIN.CancellationToken.IsCancellationRequested)
						{
							return;
						}
						foreach (SearchResultItem item2 in list)
						{
							item2.QueryContext = queryContext;
							item2.WeightedScore = item2.Score * ca0vp1tG2Oe.diTtecv8vkP().Weight;
							if (string.IsNullOrEmpty(item2.Icon))
							{
								item2.Icon = ca0vp1tG2Oe.diTtecv8vkP().Plugin.DefaultItemIcon;
							}
						}
						if (GvKvpbwmT10.F4VvpG9BsIN.CancellationToken.IsCancellationRequested)
						{
							return;
						}
						foreach (SearchResultItem item3 in list)
						{
							GvKvpbwmT10.h33vpkk31EG.Add(item3);
						}
						ogutejRcN2Y.Info($"搜索：({GvKvpbwmT10.k6vvphO9dx8}:{GvKvpbwmT10.H4XvpeFE8A4}) - {ca0vp1tG2Oe.diTtecv8vkP().Plugin.PluginInfo.Name} 耗时：{stopwatch.ElapsedMilliseconds} 条数：{list.Count}");
						return;
					}
					break;
					IL_019b:
					list = ca0vp1tG2Oe.diTtecv8vkP().Plugin.DoSearch(queryContext, GvKvpbwmT10.rQCvps4OJTS);
					num2 = 2;
					if (NGufaRcTnRHl9tJPalOs == null)
					{
						continue;
					}
					goto IL_01cc;
				}
				continue;
				IL_01cc:
				num2 = num;
				goto IL_01d0;
			}
		}

		internal static bool vloKjpcTeufthL60Wow8()
		{
			return NGufaRcTnRHl9tJPalOs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_2
	{
		public Task[] Q7FvpXC7Xwa;

		public _003C_003Ec__DisplayClass17_0 RDqvpm4KX0B;

		private static _003C_003Ec__DisplayClass17_2 WmJd37cTEiJM8QPH81Hj;

		internal void dT1vp6lesJ4()
		{
			try
			{
				Task.WaitAll(Q7FvpXC7Xwa, 3000, RDqvpm4KX0B.rQCvps4OJTS);
				if (!RDqvpm4KX0B.rQCvps4OJTS.IsCancellationRequested)
				{
					olCteHTXa5J(RDqvpm4KX0B.I8YvpZxTYkY, RDqvpm4KX0B.h33vpkk31EG);
					List<SearchResultItem> results = RDqvpm4KX0B.h33vpkk31EG.OrderByDescending(_003C_003Ec.XEKvpLJdTPS ?? (_003C_003Ec.XEKvpLJdTPS = _003C_003Ec.ag1vri0cRDk.XCvvrUUlJqX)).ToList();
					RDqvpm4KX0B.dJHvpILDWG0.SetResults(results, RDqvpm4KX0B.k6vvphO9dx8);
				}
			}
			catch
			{
			}
		}

		internal static bool wgbXTDcTGGMMYKTxlupH()
		{
			return WmJd37cTEiJM8QPH81Hj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public IList<SearchHistoryItem> lt2vpx7JCYv;

		public int hIhvprN2D1U;

		public Func<SearchResultItem, bool> Fkcvpp1KDwe;

		internal static _003C_003Ec__DisplayClass18_0 dPkrORcT1a7LV8r3WTjy;

		internal bool Cp7vpKeVTTj(SearchResultItem x)
		{
			return x.HistoryData == lt2vpx7JCYv[hIhvprN2D1U].HistoryData;
		}

		internal static bool vh7rO7cTKodQ0B8K3VhU()
		{
			return dPkrORcT1a7LV8r3WTjy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public IList<SearchHistoryItem> oIdvpQTChvf;

		public int zVPvpjD8k6Y;

		public Func<SearchResultItem, bool> OwOvpn3eCOb;

		private static _003C_003Ec__DisplayClass19_0 frSRDPcTv583VXM5AVLd;

		internal bool ji8vpBxNhFh(SearchResultItem x)
		{
			return x.HistoryData == oIdvpQTChvf[zVPvpjD8k6Y].HistoryData;
		}

		internal static bool svFLs9cTddpQPRtKxPPA()
		{
			return frSRDPcTv583VXM5AVLd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public string RrevpdEi4T2;

		internal static _003C_003Ec__DisplayClass20_0 STXPStcTJh0IdW0sLBaU;

		internal IList<pHWGPP2zInOmuZ0GwWH> H1lvp4N6Bip()
		{
			return gUBtenXpVcR.Where(LZxvp5aiON8).Select(uPDvpDGYvr8).ToList();
		}

		internal bool LZxvp5aiON8(SearchPluginItem x)
		{
			if (x.IsGlobal)
			{
				if (RrevpdEi4T2.Length != 0)
				{
					return RrevpdEi4T2.Length >= x.MinTriggerLength;
				}
				return true;
			}
			return false;
		}

		internal pHWGPP2zInOmuZ0GwWH uPDvpDGYvr8(SearchPluginItem x)
		{
			pHWGPP2zInOmuZ0GwWH pHWGPP2zInOmuZ0GwWH = new pHWGPP2zInOmuZ0GwWH();
			pHWGPP2zInOmuZ0GwWH.haeteRMAckq(RrevpdEi4T2);
			pHWGPP2zInOmuZ0GwWH.ovWteVdMjK4(x);
			return pHWGPP2zInOmuZ0GwWH;
		}

		internal static bool FJEWXRcTkPJT1LBJjFQd()
		{
			return STXPStcTJh0IdW0sLBaU == null;
		}
	}

	private static readonly ILog ogutejRcN2Y;

	private static readonly IList<SearchPluginItem> gUBtenXpVcR;

	private static ISearchHistoryStore XMwte44BNt0;

	private static IList<SearchPlugin> zZyte5jVboY;

	private static object VO1Bg7QdNRPFWEBwS3MG;

	static gIh8AyjqAySmmxFMtv4()
	{
		ogutejRcN2Y = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		gUBtenXpVcR = new List<SearchPluginItem>();
		XMwte44BNt0 = new jXRS7fjTYAcMZvIFwQ6();
		zZyte5jVboY = new List<SearchPlugin>();
		GdNteY7DhPE();
	}

	[SpecialName]
	public static IList<SearchPlugin> UOeterPKajP()
	{
		return zZyte5jVboY;
	}

	[SpecialName]
	public static IList<SearchPluginItem> ncrteB8LyB5()
	{
		return gUBtenXpVcR;
	}

	public static SearchPluginSettings shatee0g8di(SearchPlugin searchPlugin_0)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.KwEvp25i5GG = searchPlugin_0;
		SearchPluginSettings searchPluginSettings = AppState.HHxtaMaoqJr().SearchSettings.PluginSettings.FirstOrDefault(_003C_003Ec__DisplayClass11_.spQvpSGXCVg) ?? _003C_003Ec__DisplayClass11_.KwEvp25i5GG.DefaultSettings;
		if (_003C_003Ec__DisplayClass11_.KwEvp25i5GG is QuickerActionSearchPlugin)
		{
			searchPluginSettings.MinGlobalTriggerLength = 0;
		}
		return searchPluginSettings;
	}

	public static void GdNteY7DhPE()
	{
		gUBtenXpVcR.Clear();
		if (zZyte5jVboY.Count == 0)
		{
			Type[] array = new Type[17]
			{
				typeof(HOvYIX2wovhtMxBUwgX),
				typeof(kJRDjH226hXeo1HfxgN),
				typeof(FkN6J12XpMBh1QH4ouf),
				typeof(LNSl752YGPV7PVN9Gpc),
				typeof(OcfjAK2mDoFrkKoG0ga),
				typeof(h8GNtg2u86JIw02vpvJ),
				typeof(oHULgO2ej03xFaPEQcU),
				typeof(iRSgYZ2cfBf2EeB2RM1),
				typeof(global::F43XQF2y67i44S1l9aA.F0DMWs2Pfa79EIZeZ8T),
				typeof(QuickerDocSearchPlugin),
				typeof(ComputePlugin),
				typeof(EverythingSearchPlugin),
				typeof(TextCommandSearchPlugin),
				typeof(ONgL3r2gY2UDTxHt94I),
				typeof(QuickerActionSearchPlugin),
				typeof(QuickerSettingsSearchPlugin),
				typeof(dZSAja2f6LA1pH5RUmY)
			};
			for (int i = 0; i < array.Length; i++)
			{
				SearchPlugin item = (SearchPlugin)Activator.CreateInstance(array[i]);
				zZyte5jVboY.Add(item);
			}
		}
		foreach (SearchPlugin item2 in zZyte5jVboY)
		{
			ia2teIxFluT(item2, shatee0g8di(item2));
		}
		foreach (SearchPluginItem item3 in gUBtenXpVcR)
		{
			if (item3.Condition == "ext:xslx;xls;xlsm;csv;")
			{
				item3.Condition = "ext:xlsx;xls;xlsm;csv;";
			}
		}
	}

	private static void ia2teIxFluT(SearchPlugin searchPlugin_0, SearchPluginSettings searchPluginSettings_0)
	{
		if (!searchPluginSettings_0.IsEnabled)
		{
			return;
		}
		if (searchPluginSettings_0.IncludeInGlobalSearch)
		{
			gUBtenXpVcR.Add(new SearchPluginItem
			{
				TriggerWord = string.Empty,
				Plugin = searchPlugin_0,
				Settings = searchPluginSettings_0,
				IsGlobal = true,
				Weight = searchPluginSettings_0.GlobalSearchWeight,
				MinTriggerLength = searchPluginSettings_0.MinGlobalTriggerLength,
				Condition = searchPluginSettings_0.GlobalSearchCondition
			});
		}
		if (!searchPluginSettings_0.Triggers.HasData())
		{
			return;
		}
		foreach (SearchTrigger trigger in searchPluginSettings_0.Triggers)
		{
			gUBtenXpVcR.Add(new SearchPluginItem
			{
				TriggerWord = trigger.TriggerWord,
				Condition = trigger.Condition,
				Plugin = searchPlugin_0,
				Settings = searchPluginSettings_0,
				Weight = trigger.Weight,
				MinTriggerLength = 0
			});
		}
	}

	public static void nh5teW3nHJ7()
	{
		ogutejRcN2Y.Info("开始初始化搜索扩展。");
		XMwte44BNt0.Init();
		foreach (SearchPlugin item in zZyte5jVboY)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			try
			{
				item.Init(new SearchPluginInitContext
				{
					Settings = shatee0g8di(item),
					Qk = QuickerApi.Instance
				});
			}
			catch (Exception ex)
			{
				ogutejRcN2Y.Warn("搜索扩展 " + item.PluginInfo.Name + " 初始化出错：" + ex.Message, ex);
			}
			if (stopwatch.ElapsedMilliseconds > 10L)
			{
				ogutejRcN2Y.Info($"搜索扩展 {item.PluginInfo.Name} 初始化耗时：{stopwatch.ElapsedMilliseconds}ms");
			}
		}
		ogutejRcN2Y.Info("搜索扩展初始化完成了。");
		GC.Collect(1);
	}

	public static IList<SearchResultItem> TystekJOcgU(string string_0, SearchWindow searchWindow_0, CancellationToken cancellationToken_0, int int_0, int int_1)
	{
		int num = string_0?.LastIndexOf(" @") ?? 0;
		if (num > 0 && num < string_0.Length - 2)
		{
			string_0 = string_0.Substring(num + 2) + " " + string_0.Substring(0, num);
		}
		IList<pHWGPP2zInOmuZ0GwWH> item = zRZteb4rxhg(string_0).pluginList;
		if (!item.Any())
		{
			return new List<SearchResultItem>();
		}
		if (string.IsNullOrEmpty(item.First().VL6te7XmvJQ()))
		{
			return knJteG1JuvL(string_0, searchWindow_0, cancellationToken_0, int_0, int_1, item);
		}
		return lqPtesooUqp(string_0, searchWindow_0, cancellationToken_0, int_0, int_1, item);
	}

	private static IList<SearchResultItem> knJteG1JuvL(string string_0, SearchWindow searchWindow_0, CancellationToken cancellationToken_0, int int_0, int int_1, IList<pHWGPP2zInOmuZ0GwWH> ilist_2)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.jl1vpulNNtD = string_0;
		_003C_003Ec__DisplayClass16_.ROYvpNaKXDm = int_0;
		_003C_003Ec__DisplayClass16_.LDqvpJfBBd6 = int_1;
		_003C_003Ec__DisplayClass16_.t0Jvp0llOpc = searchWindow_0;
		_003C_003Ec__DisplayClass16_.K6tvpPOGiuF = cancellationToken_0;
		_003C_003Ec__DisplayClass16_.vP2vpEeS6OZ = ilist_2;
		if (_003C_003Ec__DisplayClass16_.vP2vpEeS6OZ.Count == 0)
		{
			return new List<SearchResultItem> { SearchPlugin.CreateWarningResult("无可用的历史搜索记录", "暂无支持历史的搜索扩展。") };
		}
		_003C_003Ec__DisplayClass16_.QACvp8ZOfOY = new ConcurrentBag<SearchResultItem>();
		List<Task> list = new List<Task>();
		List<SearchPluginItem> list2 = _003C_003Ec__DisplayClass16_.vP2vpEeS6OZ.Where(_003C_003Ec.jEYvr3hkhFb ?? (_003C_003Ec.jEYvr3hkhFb = _003C_003Ec.ag1vri0cRDk.vV4vrorqPvy)).Select(_003C_003Ec.kh9vrfxTyYe ?? (_003C_003Ec.kh9vrfxTyYe = _003C_003Ec.ag1vri0cRDk.sNXvrTM9JbS)).ToList();
		IList<SearchHistoryItem> uCSvpC7WEbL;
		if (!list2.HasData())
		{
			IList<SearchHistoryItem> list3 = Array.Empty<SearchHistoryItem>();
			uCSvpC7WEbL = list3;
		}
		else
		{
			uCSvpC7WEbL = XMwte44BNt0.GetRecentSearchHistory(list2);
		}
		_003C_003Ec__DisplayClass16_.UCSvpC7WEbL = uCSvpC7WEbL;
		_003C_003Ec__DisplayClass16_.kKpvpyy2UAY = "fa:Light_History:#007eff";
		bool matchUpperCaseEqual = AppState.HHxtaMaoqJr().MatchUpperCaseEqual;
		using (IEnumerator<pHWGPP2zInOmuZ0GwWH> enumerator = _003C_003Ec__DisplayClass16_.vP2vpEeS6OZ.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass16_1 _003C_003Ec__DisplayClass16_2 = new _003C_003Ec__DisplayClass16_1();
				_003C_003Ec__DisplayClass16_2.T71vpqBym78 = _003C_003Ec__DisplayClass16_;
				_003C_003Ec__DisplayClass16_2.BGWvpRoQjJX = enumerator.Current;
				Task item = Task.Factory.StartNew(_003C_003Ec__DisplayClass16_2.KSLvpa0sqYb);
				list.Add(item);
			}
		}
		try
		{
			Task.WaitAll(list.ToArray(), 300, _003C_003Ec__DisplayClass16_.K6tvpPOGiuF);
		}
		catch (OperationCanceledException)
		{
			return new List<SearchResultItem>();
		}
		catch (Exception ex2)
		{
			ogutejRcN2Y.Warn("等待搜索任务结束出错：" + ex2.Message, ex2);
		}
		return _003C_003Ec__DisplayClass16_.QACvp8ZOfOY.OrderByDescending(_003C_003Ec.kwSvrzN7Rkn ?? (_003C_003Ec.kwSvrzN7Rkn = _003C_003Ec.ag1vri0cRDk.YRRvrMKY8oD)).ToList();
	}

	private static IList<SearchResultItem> lqPtesooUqp(string string_0, SearchWindow searchWindow_0, CancellationToken cancellationToken_0, int int_0, int int_1, IList<pHWGPP2zInOmuZ0GwWH> ilist_2)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.v3Hvp9EwpF6 = ilist_2;
		_003C_003Ec__DisplayClass17_.k6vvphO9dx8 = int_0;
		_003C_003Ec__DisplayClass17_.H4XvpeFE8A4 = string_0;
		_003C_003Ec__DisplayClass17_.GCXvpYbMEZc = int_1;
		_003C_003Ec__DisplayClass17_.dJHvpILDWG0 = searchWindow_0;
		_003C_003Ec__DisplayClass17_.rQCvps4OJTS = cancellationToken_0;
		_003C_003Ec__DisplayClass17_.h33vpkk31EG = new ConcurrentBag<SearchResultItem>();
		_003C_003Ec__DisplayClass17_.F4VvpG9BsIN = new ParallelOptions();
		_003C_003Ec__DisplayClass17_.F4VvpG9BsIN.CancellationToken = _003C_003Ec__DisplayClass17_.rQCvps4OJTS;
		bool flag = false;
		_003C_003Ec__DisplayClass17_.I8YvpZxTYkY = null;
		List<Task> list = new List<Task>();
		list.Add(Task.Run((Action)_003C_003Ec__DisplayClass17_.yAUvpV1E3XV));
		_003C_003Ec__DisplayClass17_.FjavpWk6D9t = !AppState.HHxtaMaoqJr().MatchUpperCaseEqual;
		using (IEnumerator<pHWGPP2zInOmuZ0GwWH> enumerator = _003C_003Ec__DisplayClass17_.v3Hvp9EwpF6.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass17_1 _003C_003Ec__DisplayClass17_2 = new _003C_003Ec__DisplayClass17_1();
				_003C_003Ec__DisplayClass17_2.GvKvpbwmT10 = _003C_003Ec__DisplayClass17_;
				_003C_003Ec__DisplayClass17_2.ca0vp1tG2Oe = enumerator.Current;
				Task item = Task.Run((Action)_003C_003Ec__DisplayClass17_2.S7EvpHVkh2w, _003C_003Ec__DisplayClass17_2.GvKvpbwmT10.rQCvps4OJTS);
				list.Add(item);
			}
		}
		try
		{
			_003C_003Ec__DisplayClass17_2 _003C_003Ec__DisplayClass17_3 = new _003C_003Ec__DisplayClass17_2();
			_003C_003Ec__DisplayClass17_3.RDqvpm4KX0B = _003C_003Ec__DisplayClass17_;
			flag = Task.WaitAll(list.ToArray(), 300, _003C_003Ec__DisplayClass17_3.RDqvpm4KX0B.rQCvps4OJTS);
			_003C_003Ec__DisplayClass17_3.Q7FvpXC7Xwa = list.Where(_003C_003Ec.FkIvpgxTPtB ?? (_003C_003Ec.FkIvpgxTPtB = _003C_003Ec.ag1vri0cRDk.w6jvrFkD274)).ToArray();
			if (_003C_003Ec__DisplayClass17_3.Q7FvpXC7Xwa.Any())
			{
				Task.Run((Action)_003C_003Ec__DisplayClass17_3.dT1vp6lesJ4, _003C_003Ec__DisplayClass17_3.RDqvpm4KX0B.rQCvps4OJTS);
			}
		}
		catch (OperationCanceledException)
		{
			return new List<SearchResultItem>();
		}
		catch (Exception ex2)
		{
			ogutejRcN2Y.Warn("等待搜索任务结束出错：" + ex2.Message, ex2);
		}
		if (!flag)
		{
			Thread.Sleep(1);
		}
		olCteHTXa5J(_003C_003Ec__DisplayClass17_.I8YvpZxTYkY, _003C_003Ec__DisplayClass17_.h33vpkk31EG);
		return _003C_003Ec__DisplayClass17_.h33vpkk31EG.OrderByDescending(_003C_003Ec.ROSvpvJMSGw ?? (_003C_003Ec.ROSvpvJMSGw = _003C_003Ec.ag1vri0cRDk.qq0vrlNCCHI)).ToList();
	}

	private static void olCteHTXa5J(IList<SearchHistoryItem> ilist_2, ConcurrentBag<SearchResultItem> concurrentBag_0)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.lt2vpx7JCYv = ilist_2;
		if (!_003C_003Ec__DisplayClass18_.lt2vpx7JCYv.HasData())
		{
			return;
		}
		int num = 2000;
		_003C_003Ec__DisplayClass18_.hIhvprN2D1U = 0;
		while (_003C_003Ec__DisplayClass18_.hIhvprN2D1U < _003C_003Ec__DisplayClass18_.lt2vpx7JCYv.Count)
		{
			SearchResultItem searchResultItem = concurrentBag_0.FirstOrDefault(_003C_003Ec__DisplayClass18_.Fkcvpp1KDwe ?? (_003C_003Ec__DisplayClass18_.Fkcvpp1KDwe = _003C_003Ec__DisplayClass18_.Cp7vpKeVTTj));
			if (searchResultItem != null)
			{
				double val = num + _003C_003Ec__DisplayClass18_.lt2vpx7JCYv[_003C_003Ec__DisplayClass18_.hIhvprN2D1U].UseCount * 10 - (_003C_003Ec__DisplayClass18_.lt2vpx7JCYv[_003C_003Ec__DisplayClass18_.hIhvprN2D1U].SearchText.Length - searchResultItem.QueryContext.Search.Length) * 100;
				searchResultItem.WeightedScore += Math.Max(0.0, val);
				num -= 100;
			}
			_003C_003Ec__DisplayClass18_.hIhvprN2D1U++;
		}
	}

	public static void goOte1B8NYt(IList<SearchHistoryItem> ilist_2, IList<SearchResultItem> ilist_3)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.oIdvpQTChvf = ilist_2;
		if (!_003C_003Ec__DisplayClass19_.oIdvpQTChvf.HasData())
		{
			return;
		}
		int num = 200;
		_003C_003Ec__DisplayClass19_.zVPvpjD8k6Y = 0;
		while (_003C_003Ec__DisplayClass19_.zVPvpjD8k6Y < _003C_003Ec__DisplayClass19_.oIdvpQTChvf.Count)
		{
			SearchResultItem searchResultItem = ilist_3.FirstOrDefault(_003C_003Ec__DisplayClass19_.OwOvpn3eCOb ?? (_003C_003Ec__DisplayClass19_.OwOvpn3eCOb = _003C_003Ec__DisplayClass19_.ji8vpBxNhFh));
			if (searchResultItem != null)
			{
				double val = num + _003C_003Ec__DisplayClass19_.oIdvpQTChvf[_003C_003Ec__DisplayClass19_.zVPvpjD8k6Y].UseCount * 10 - (_003C_003Ec__DisplayClass19_.oIdvpQTChvf[_003C_003Ec__DisplayClass19_.zVPvpjD8k6Y].SearchText?.Length ?? (-(searchResultItem.QueryContext?.Search.Length)).GetValueOrDefault()) * 100;
				searchResultItem.Score += Math.Max(0.0, val);
				num -= 10;
			}
			_003C_003Ec__DisplayClass19_.zVPvpjD8k6Y++;
		}
	}

	private static (bool isGlobal, IList<pHWGPP2zInOmuZ0GwWH> pluginList) zRZteb4rxhg([NotNull] string query)
	{
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.RrevpdEi4T2 = query;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass20_.RrevpdEi4T2))
		{
			return (isGlobal: true, pluginList: _003C_003Ec__DisplayClass20_.H1lvp4N6Bip());
		}
		List<pHWGPP2zInOmuZ0GwWH> list = new List<pHWGPP2zInOmuZ0GwWH>();
		foreach (SearchPluginItem item in gUBtenXpVcR)
		{
			if (item.IsGlobal || !_003C_003Ec__DisplayClass20_.RrevpdEi4T2.StartsWith(item.TriggerWord))
			{
				continue;
			}
			bool flag = false;
			if (list.Count != 0 && item.TriggerWord.Length != list[0].diTtecv8vkP().TriggerWord.Length)
			{
				if (item.TriggerWord.Length > list[0].diTtecv8vkP().TriggerWord.Length)
				{
					list.Clear();
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				pHWGPP2zInOmuZ0GwWH pHWGPP2zInOmuZ0GwWH = new pHWGPP2zInOmuZ0GwWH();
				pHWGPP2zInOmuZ0GwWH.haeteRMAckq(_003C_003Ec__DisplayClass20_.RrevpdEi4T2.Substring(item.TriggerWord.Length));
				pHWGPP2zInOmuZ0GwWH.ovWteVdMjK4(item);
				list.Add(pHWGPP2zInOmuZ0GwWH);
			}
		}
		if (list.Count > 0)
		{
			return (isGlobal: false, pluginList: list);
		}
		if (_003C_003Ec__DisplayClass20_.RrevpdEi4T2.StartsWith(" "))
		{
			return (isGlobal: false, pluginList: new List<pHWGPP2zInOmuZ0GwWH>());
		}
		return (isGlobal: true, pluginList: _003C_003Ec__DisplayClass20_.H1lvp4N6Bip());
	}

	private static void iTpte6RFNqp(SearchResultItem searchResultItem_0, SearchResultOperationType searchResultOperationType_0)
	{
		switch (searchResultOperationType_0)
		{
		case SearchResultOperationType.Copy:
			if (!string.IsNullOrEmpty(searchResultItem_0.TextData))
			{
				AppHelper.TryCopy(searchResultItem_0.TextData, true);
			}
			else
			{
				AppHelper.ShowWarning("没有要复制的内容！");
			}
			break;
		case SearchResultOperationType.PasteTo:
			if (!string.IsNullOrEmpty(searchResultItem_0.TextData))
			{
				ActionHelper.SendTextToWindow(searchResultItem_0.TextData, true, false);
			}
			else
			{
				AppHelper.ShowInformation("没有要发送的内容。");
			}
			break;
		case SearchResultOperationType.Open:
			AppHelper.TryOpenUrlOrFile(searchResultItem_0.TextData);
			break;
		case SearchResultOperationType.OpenFolder:
			AppHelper.SelectFileInExplorer(searchResultItem_0.TextData, false);
			break;
		case SearchResultOperationType.Execute:
			try
			{
				AppHelper.ExecuteText(searchResultItem_0.TextData);
				break;
			}
			catch (Exception ex2)
			{
				AppHelper.ShowWarning("执行命令(" + searchResultItem_0.TextData + ")出错：" + ex2.Message);
				break;
			}
		case SearchResultOperationType.ExecWithAdmin:
			try
			{
				AppHelper.ExecuteText(searchResultItem_0.TextData, true);
				break;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("执行命令(" + searchResultItem_0.TextData + ")出错：" + ex.Message);
				break;
			}
		}
	}

	public static void PyWteX4rdk9(SearchResultItem searchResultItem_0, string string_0, SearchTriggerType searchTriggerType_0)
	{
		if (searchResultItem_0 == null)
		{
			return;
		}
		QueryContext queryContext = searchResultItem_0.QueryContext;
		if (queryContext == null)
		{
			ogutejRcN2Y.Warn("QueryContext 为空。");
			AppHelper.ShowWarning("QueryContext 为空。");
			return;
		}
		ModifierKeys modifierKeys = JrJWiKYIEBcPm8FFZOl.Modifiers;
		int num;
		if (modifierKeys == ModifierKeys.Control)
		{
			if (!queryContext.PluginItem.Plugin.CtrlEnterOperation.IsAny(SearchResultOperationType.Custom, SearchResultOperationType.None))
			{
				iTpte6RFNqp(searchResultItem_0, queryContext.PluginItem.Plugin.CtrlEnterOperation);
				return;
			}
			num = 0;
			if (X2UrA5Qd9wG0TCOKjU8F())
			{
				goto IL_0103;
			}
		}
		goto IL_0139;
		IL_0139:
		if (modifierKeys != ModifierKeys.Shift || queryContext.PluginItem.Plugin.ShiftEnterOperation.IsAny(SearchResultOperationType.Custom, SearchResultOperationType.None))
		{
			if (queryContext.PluginItem.Plugin.EnterSelectOperation == SearchResultOperationType.Custom)
			{
				queryContext.IsCtrlDown = (modifierKeys & ModifierKeys.Control) == ModifierKeys.Control;
				queryContext.IsAltDown = (modifierKeys & ModifierKeys.Alt) == ModifierKeys.Alt;
				queryContext.IsShiftDown = (modifierKeys & ModifierKeys.Shift) == ModifierKeys.Shift;
				queryContext.IsWinDown = (modifierKeys & ModifierKeys.Windows) == ModifierKeys.Windows;
				searchResultItem_0.QueryContext.PluginItem.Plugin.ProcessResult(searchResultItem_0, queryContext);
				num = 1;
				if (!X2UrA5Qd9wG0TCOKjU8F())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0103;
			}
			iTpte6RFNqp(searchResultItem_0, queryContext.PluginItem.Plugin.EnterSelectOperation);
			return;
		}
		iTpte6RFNqp(searchResultItem_0, queryContext.PluginItem.Plugin.ShiftEnterOperation);
		return;
		IL_0103:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_0139;
	}

	public static void ktatemHmAHQ(IList<SearchPlugin> ilist_2)
	{
		foreach (SearchPlugin item in ilist_2)
		{
			item.UpdateSettings(shatee0g8di(item));
		}
	}

	public static void tuPteKqOI5r(SearchResultItem searchResultItem_0, string string_0)
	{
		if (searchResultItem_0.QueryContext?.PluginItem != null && searchResultItem_0.QueryContext.PluginItem.Plugin.IsSupportHistory && !string.IsNullOrEmpty(searchResultItem_0.HistoryData))
		{
			XMwte44BNt0.AddHistory(new SearchHistoryItem
			{
				SearchText = searchResultItem_0.QueryContext.Search,
				LastSelectTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
				PlugInId = searchResultItem_0.QueryContext.PluginItem.Plugin.Id,
				Condition = (searchResultItem_0.QueryContext.PluginItem.Condition ?? string.Empty),
				HistoryData = searchResultItem_0.HistoryData,
				CurrentProcess = string_0.ToLowerInvariant(),
				PluginWithCondition = searchResultItem_0.QueryContext.PluginItem.PluginIdWithCondition
			});
		}
	}

	public static void snVtexogTaa(ActionItem actionItem_0)
	{
		if (actionItem_0 == null || string.IsNullOrEmpty(actionItem_0.Id))
		{
			return;
		}
		ISearchHistoryStore xMwte44BNt = XMwte44BNt0;
		SearchHistoryItem obj = new SearchHistoryItem
		{
			SearchText = "",
			LastSelectTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
			PlugInId = "search.sys.quicker.actions",
			Condition = string.Empty,
			HistoryData = actionItem_0.Id
		};
		string currentProcessName = AppState.CurrentProcessName;
		object obj2;
		if (currentProcessName == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = currentProcessName.ToLowerInvariant();
			if (obj2 != null)
			{
				goto IL_0079;
			}
		}
		obj2 = "";
		goto IL_0079;
		IL_0079:
		obj.CurrentProcess = (string)obj2;
		obj.PluginWithCondition = "search.sys.quicker.actions_";
		xMwte44BNt.AddHistory(obj);
	}

	internal static bool X2UrA5Qd9wG0TCOKjU8F()
	{
		return VO1Bg7QdNRPFWEBwS3MG == null;
	}
}
