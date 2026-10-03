using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using FontAwesome5;
using log4net;
using Quicker.Common;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Extensions;
using Quicker.Modules.Searching.Plugins.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.UI;
using Quicker.View;
using SWBMfZYGyc6L9yHIvKQ;

namespace Quicker.Domain.Searching.Actions;

public class QuickerActionSearchPlugin : SearchPlugin, IContextMenuBuilder, ICreateSettingUI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec bktvpOoSmUr;

		public static Func<ActionItem, DateTime?> qYkvpFXiB5O;

		public static Func<ActionItem, bool> kVHvpUkv3Qg;

		public static Func<ActionItem, DateTime?> pprvpl37JjI;

		public static Func<SearchResultItem, bool> rlhvpiGIltx;

		internal static _003C_003Ec lJgdIgcTreGkPTJtfLRD;

		static _003C_003Ec()
		{
			bktvpOoSmUr = new _003C_003Ec();
		}

		internal DateTime? vhdvpobSD6P(ActionItem x)
		{
			return x.LastEditTimeUtc;
		}

		internal bool uOAvpTL26i4(ActionItem x)
		{
			return !string.IsNullOrWhiteSpace(x.TemplateId);
		}

		internal DateTime? w12vpMLHcFF(ActionItem x)
		{
			return x.CreateTimeUtc;
		}

		internal bool lC5vpAuNmjF(SearchResultItem x)
		{
			return x != null;
		}

		internal static bool Lb8R4kcTNqq7wdYdUgD3()
		{
			return lJgdIgcTreGkPTJtfLRD == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass31_0
	{
		public ActionItem EIlvpfRNKO5;

		internal static _003C_003Ec__DisplayClass31_0 FbKpfpcTLCsite0yEKaj;

		internal void LR8vp3547wj()
		{
			AppState.lWutartRfUY().EditActionById(EIlvpfRNKO5.Id);
		}

		internal static bool d7GdgpcTu6WlfJq9geWV()
		{
			return FbKpfpcTLCsite0yEKaj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public QuickerActionSearchPlugin cuovBwlxa5a;

		public int gLQvBtHJ3yg;

		private static _003C_003Ec__DisplayClass34_0 PdcEnmcTbYrUO8ftq5Pg;

		internal SearchResultItem FdAvpzb3YFX(ActionItem x)
		{
			_003C_003Ec__DisplayClass34_1 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_1
			{
				x = x
			};
			ActionProfile profile = AppState.DataService.mP6tXA8VyNP().Values.FirstOrDefault(_003C_003Ec__DisplayClass34_.hSDvBgFk9Pe);
			return cuovBwlxa5a.ToSearchResultItem(_003C_003Ec__DisplayClass34_.x, profile, gLQvBtHJ3yg--, null, null, false);
		}

		internal static bool PU6Ly0cTqo6ICReuN2Mx()
		{
			return PdcEnmcTbYrUO8ftq5Pg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_1
	{
		public ActionItem x;

		private static _003C_003Ec__DisplayClass34_1 txxSTecTlq3k5Eg7OL38;

		internal bool hSDvBgFk9Pe(ActionProfile p)
		{
			return p.ActionItems.Contains(x);
		}

		static _003C_003Ec__DisplayClass34_1()
		{
		}

		internal static bool jyvfy0cTZDDtbyHd9djI()
		{
			return txxSTecTlq3k5Eg7OL38 == null;
		}

		internal static void VWP22ccTYdooCt66jNHo()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public QuickerActionSearchPlugin kf8vBvIhTfl;

		public int FPivBSSadpR;

		private static _003C_003Ec__DisplayClass35_0 sFoNf7cT8FYmmKBnijP6;

		internal SearchResultItem tTAvBLtUisW(ActionItem x)
		{
			_003C_003Ec__DisplayClass35_1 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_1
			{
				x = x
			};
			ActionProfile profile = AppState.DataService.mP6tXA8VyNP().Values.FirstOrDefault(_003C_003Ec__DisplayClass35_.TWovB2B0Lbj);
			return kf8vBvIhTfl.ToSearchResultItem(_003C_003Ec__DisplayClass35_.x, profile, FPivBSSadpR--, null, null, false);
		}

		internal static void Dokn7vcTP8WK1Mxj3stt()
		{
		}

		internal static bool UAQkZkcTRoCO8vaBfmW5()
		{
			return sFoNf7cT8FYmmKBnijP6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_1
	{
		public ActionItem x;

		internal static _003C_003Ec__DisplayClass35_1 LX0K3NcTMRJW4CcoYN78;

		internal bool TWovB2B0Lbj(ActionProfile p)
		{
			return p.ActionItems.Contains(x);
		}

		internal static bool NeRvcicTUw2PcOAHNCfq()
		{
			return LX0K3NcTMRJW4CcoYN78 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public QuickerActionSearchPlugin nIYvBNUgovQ;

		public int yh7vBJdmLan;

		internal static _003C_003Ec__DisplayClass36_0 eOvYRBcTIYZJFaiMCyRN;

		internal SearchResultItem UfivBuZwYv4(string actionId)
		{
			var (actionItem, profile) = AppState.DataService.GetActionById(actionId);
			if (actionItem != null && actionItem.CanExport())
			{
				return nIYvBNUgovQ.ToSearchResultItem(actionItem, profile, yh7vBJdmLan--, null, null, false);
			}
			return null;
		}

		internal static bool hNEyaYcT6XRE8MjwIF4i()
		{
			return eOvYRBcTIYZJFaiMCyRN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public SearchResultItem uHpvBPj9ml2;

		public ActionItem JykvBE4o2oB;

		internal static _003C_003Ec__DisplayClass39_0 kyjgEfcTSMAVlpZj9p8S;

		internal void XfkvB0I6blu(object _)
		{
			uHpvBPj9ml2.QueryContext.SearchWindow.RequestHide();
			Thread.Sleep(100);
			AppState.AppServer.ExecuteActionByIdOrName(JykvBE4o2oB.Id, null, true, false, false, null, ActionTrigger.SearchWindow);
		}

		internal void QKKvBCyZ2YY(object _)
		{
			AppState.lWutartRfUY().EditActionById(JykvBE4o2oB.Id);
		}

		internal static void Rsj2uVcTmkWPxC6ujCCU()
		{
		}

		internal static bool HlB0BUcTwQu7um9yaHf3()
		{
			return kyjgEfcTSMAVlpZj9p8S == null;
		}
	}

	private static readonly ILog QhNteflmQZP;

	public const string PLUGIN_ID = "search.sys.quicker.actions";

	public const string KEY_ExcludeLinkActions = "excludeLinkActions";

	public const string KEY_ExcludeOtherMachines = "excludeOtherMachines";

	public const string KEY_AdjustScore = "adjustScore";

	[CompilerGenerated]
	private readonly SearchPluginSettings iGDtezx7Op6 = new SearchPluginSettings
	{
		IncludeInGlobalSearch = true,
		PluginId = "search.sys.quicker.actions",
		MinGlobalTriggerLength = 0
	};

	[CompilerGenerated]
	private readonly PluginInfo quGtYwSqtUM = new PluginInfo
	{
		Name = "Quicker动作",
		Description = "搜索Quicker动作",
		SearchContentName = "动作",
		Icon = "fa:Light_Bolt"
	};

	[CompilerGenerated]
	private readonly string WjytYtKY0sa = "search.sys.quicker.actions";

	[CompilerGenerated]
	private readonly string yiRtYg4NoU3 = "";

	[CompilerGenerated]
	private readonly bool YCItYLjvCBo = true;

	private bool bbutYvGDubA;

	private bool fwdtYS8phZq;

	private string AYytY2yDeln;

	[CompilerGenerated]
	private readonly SearchResultOperationType QhPtYuBQ5gx = SearchResultOperationType.Custom;

	[CompilerGenerated]
	private readonly SearchResultOperationType xhHtYNEmcQY = SearchResultOperationType.Custom;

	private static QuickerActionSearchPlugin KqcFqvQdtQUpEGLIZhV8;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return iGDtezx7Op6;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return quGtYwSqtUM;
		}
	}

	public override string Id
	{
		[CompilerGenerated]
		get
		{
			return WjytYtKY0sa;
		}
	}

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return yiRtYg4NoU3;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return YCItYLjvCBo;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return QhPtYuBQ5gx;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return xhHtYNEmcQY;
		}
	}

	public override void ApplySettings()
	{
		base.ApplySettings();
		if (_settings == null || _settings.CustomSettings == null)
		{
			return;
		}
		if (_settings.CustomSettings.TryGetValue("excludeLinkActions", out var value))
		{
			bbutYvGDubA = value == "1";
		}
		if (_settings.CustomSettings.TryGetValue("excludeOtherMachines", out var value2))
		{
			int num = 0;
			if (!ysi8FTQdSQ9Zvx6Qc4x2())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			fwdtYS8phZq = value2 == "1";
		}
		if (_settings.CustomSettings.TryGetValue("adjustScore", out var value3))
		{
			AYytY2yDeln = value3;
		}
	}

	public override void ProcessResult(SearchResultItem resultItem, QueryContext context)
	{
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
		ActionSearchResultItem actionSearchResultItem = resultItem as ActionSearchResultItem;
		int num = 0;
		if (!ysi8FTQdSQ9Zvx6Qc4x2())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		_003C_003Ec__DisplayClass31_.EIlvpfRNKO5 = actionSearchResultItem.Tag as ActionItem;
		if (_003C_003Ec__DisplayClass31_.EIlvpfRNKO5 == null)
		{
			AppHelper.ShowWarning("未找到动作。");
			return;
		}
		if (JrJWiKYIEBcPm8FFZOl.uZxLDuAOweP())
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass31_.LR8vp3547wj);
			return;
		}
		bool enableDebugging = JrJWiKYIEBcPm8FFZOl.kBQLD2aG1Qb();
		try
		{
			AppState.AppServer.ExecuteAction(_003C_003Ec__DisplayClass31_.EIlvpfRNKO5, -1, null, enableDebugging, false, false, "", ActionTrigger.SearchWindow, null, new ActionExtraContextData
			{
				Text = "",
				ActiveWindowBeforeSearch = ((context.SearchWindow as SearchWindow)?.ActiveWindowBeforeShow ?? IntPtr.Zero)
			});
		}
		catch (Exception ex)
		{
			QhNteflmQZP.Warn("执行动作时出错：" + ex.Message, ex);
			AppHelper.ShowWarning("执行动作时出错：" + ex.Message);
		}
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext, CancellationToken cancellationToken)
	{
		if (string.IsNullOrEmpty(queryContext.Search))
		{
			return JXFte3crNrH();
		}
		if (!string.Equals(queryContext.Search, "le:", StringComparison.OrdinalIgnoreCase) && !string.Equals(queryContext.Search, "le：", StringComparison.OrdinalIgnoreCase) && !string.Equals(queryContext.Search, ":le", StringComparison.OrdinalIgnoreCase))
		{
			if (!string.Equals(queryContext.Search, "li:", StringComparison.OrdinalIgnoreCase) && !string.Equals(queryContext.Search, "li：", StringComparison.OrdinalIgnoreCase) && !string.Equals(queryContext.Search, ":li", StringComparison.OrdinalIgnoreCase))
			{
				ActionSearchAdjustScoreData actionSearchAdjustScoreData = ActionSearchAdjustScoreData.Create(queryContext.CurrentExe, AYytY2yDeln);
				IEnumerable<ActionSearchResult> enumerable = ((actionSearchAdjustScoreData == null) ? AppState.DataService.tyXtXtQLUHP(queryContext, true, false, bbutYvGDubA, fwdtYS8phZq) : AppState.DataService.NKbtXg2X0Rx(queryContext, true, false, bbutYvGDubA, fwdtYS8phZq, actionSearchAdjustScoreData));
				if (cancellationToken.IsCancellationRequested)
				{
					return Array.Empty<SearchResultItem>();
				}
				List<SearchResultItem> list = new List<SearchResultItem>();
				{
					foreach (ActionSearchResult item in enumerable)
					{
						list.Add(ToSearchResultItem(item.Action, item.Profile, item.Score, item.TitleMatchResult, item.DescriptionMatchResult, item.IsDirectWord));
					}
					return list;
				}
			}
			return yUfteiQjirT();
		}
		return xSDtelDvbuU();
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem historyItem)
	{
		string historyData = historyItem.HistoryData;
		if (!string.IsNullOrEmpty(historyData))
		{
			(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(historyData);
			if (actionById.Item1 != null)
			{
				return ToSearchResultItem(actionById.Item1, actionById.Item2, 0, null, null, false);
			}
		}
		return null;
	}

	private IList<SearchResultItem> xSDtelDvbuU()
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.cuovBwlxa5a = this;
		_003C_003Ec__DisplayClass34_.gLQvBtHJ3yg = 1000;
		return AppState.DataService.GetAllActionItems().OrderByDescending(_003C_003Ec.qYkvpFXiB5O ?? (_003C_003Ec.qYkvpFXiB5O = _003C_003Ec.bktvpOoSmUr.vhdvpobSD6P)).Take(20)
			.Select(_003C_003Ec__DisplayClass34_.FdAvpzb3YFX)
			.ToList();
	}

	private IList<SearchResultItem> yUfteiQjirT()
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.kf8vBvIhTfl = this;
		_003C_003Ec__DisplayClass35_.FPivBSSadpR = 1000;
		return AppState.DataService.GetAllActionItems().Where(_003C_003Ec.kVHvpUkv3Qg ?? (_003C_003Ec.kVHvpUkv3Qg = _003C_003Ec.bktvpOoSmUr.uOAvpTL26i4)).OrderByDescending(_003C_003Ec.pprvpl37JjI ?? (_003C_003Ec.pprvpl37JjI = _003C_003Ec.bktvpOoSmUr.w12vpMLHcFF))
			.Take(20)
			.Select(_003C_003Ec__DisplayClass35_.tTAvBLtUisW)
			.ToList();
	}

	private IList<SearchResultItem> JXFte3crNrH()
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.nIYvBNUgovQ = this;
		_003C_003Ec__DisplayClass36_.yh7vBJdmLan = 50;
		return AppState.P7gt7BYmHZ0.RecentActions.Select(_003C_003Ec__DisplayClass36_.UfivBuZwYv4).Where(_003C_003Ec.rlhvpiGIltx ?? (_003C_003Ec.rlhvpiGIltx = _003C_003Ec.bktvpOoSmUr.lC5vpAuNmjF)).ToList();
	}

	public ActionSearchResultItem ToSearchResultItem(ActionItem action, ActionProfile profile, int score, IMatchResult titleMatchResult, IMatchResult descriptionMatchResult, bool isDirectWord)
	{
		ActionSearchResultItem actionSearchResultItem = new ActionSearchResultItem(this, action, profile, score, isDirectWord)
		{
			TitleMatchPositions = titleMatchResult?.GetMatchPositions(),
			DescriptionMatchPositions = descriptionMatchResult?.GetMatchPositions(),
			HistoryData = action.Id
		};
		if (string.IsNullOrWhiteSpace(actionSearchResultItem.Icon))
		{
			actionSearchResultItem.Icon = "fa:Light_Bolt";
		}
		return actionSearchResultItem;
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem, ContextMenu contextMenu, Window window)
	{
		ActionSearchResultItem actionSearchResultItem = searchResultItem as ActionSearchResultItem;
		ActionItem actionItem = actionSearchResultItem.Tag as ActionItem;
		AppState.lWutartRfUY().CreateContextMenuForActionButton(contextMenu, actionItem, actionSearchResultItem.Profile, actionItem.Row, actionItem.Col, window, ActionTrigger.SearchWindow);
		return true;
	}

	public IList<MenuItemInfo> GetQuickButtons(SearchResultItem item)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.uHpvBPj9ml2 = item;
		_003C_003Ec__DisplayClass39_.JykvBE4o2oB = (_003C_003Ec__DisplayClass39_.uHpvBPj9ml2 as ActionSearchResultItem)?.Tag as ActionItem;
		if (_003C_003Ec__DisplayClass39_.JykvBE4o2oB == null)
		{
			return null;
		}
		List<MenuItemInfo> list = new List<MenuItemInfo>();
		if (_003C_003Ec__DisplayClass39_.JykvBE4o2oB.ActionType == ActionType.XAction)
		{
			list.Add(new MenuItemInfo
			{
				Title = "调试运行",
				Icon = $"fa:{EFontAwesomeIcon.Light_Play}:#f75711",
				Tooltip = "调试运行此动作",
				Command = new RelayCommand(_003C_003Ec__DisplayClass39_.XfkvB0I6blu)
			});
		}
		list.Add(new MenuItemInfo
		{
			Title = "编辑",
			Icon = "fa:Light_Pen",
			Tooltip = "编辑此动作",
			Command = new RelayCommand(_003C_003Ec__DisplayClass39_.QKKvBCyZ2YY)
		});
		return list;
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new QuickerActionSearchPluginSettingsControl();
	}

	static QuickerActionSearchPlugin()
	{
		QhNteflmQZP = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool ysi8FTQdSQ9Zvx6Qc4x2()
	{
		return KqcFqvQdtQUpEGLIZhV8 == null;
	}
}
