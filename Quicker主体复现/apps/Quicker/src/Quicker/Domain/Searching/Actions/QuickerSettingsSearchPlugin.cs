using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Domain.Services;
using Quicker.Public.Searching;
using Quicker.Settings;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities.Pinyin;

namespace Quicker.Domain.Searching.Actions;

public class QuickerSettingsSearchPlugin : SearchPlugin, IContextMenuBuilder
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public SearchHistoryItem IqlvB8Fuq02;

		internal static _003C_003Ec__DisplayClass23_0 Un4AcvcTsj2Q5SrRtxrH;

		internal bool nxWvBysoPhO(SettingPageInfo p)
		{
			return IqlvB8Fuq02.HistoryData == p.Id.ToString();
		}

		internal static bool KZSfwqcTCp41PJrOyZW7()
		{
			return Un4AcvcTsj2Q5SrRtxrH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct HJvK4hHLosRPqalqS08 : IAsyncStateMachine
		{
			public int FB127DLxw45;

			public AsyncVoidMethodBuilder Xs827dHEDRG;

			public _003C_003Ec__DisplayClass26_0 imK27oq4pYs;

			private TaskAwaiter<bool> jZm27TsXIoD;

			internal static object c2mBkLyu1jHGo66Db1RS;

			private void MoveNext()
			{
				int num = FB127DLxw45;
				_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = imK27oq4pYs;
				try
				{
					string command = default(string);
					if (num != 0)
					{
						command = $"quicker://settings:{_003C_003Ec__DisplayClass26_.QrvvBqsiI3D.Tag}";
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = AppState.lWutartRfUY().CreateAndCopyActionForCommand(command, _003C_003Ec__DisplayClass26_.QrvvBqsiI3D.Title, "fa:Solid_Cog:#1E90FF").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								FB127DLxw45 = 0;
								jZm27TsXIoD = awaiter;
								Xs827dHEDRG.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = jZm27TsXIoD;
							jZm27TsXIoD = default(TaskAwaiter<bool>);
							num = -1;
							FB127DLxw45 = -1;
						}
						awaiter.GetResult();
						AppHelper.ShowSuccess("已复制");
						if (c2mBkLyu1jHGo66Db1RS != null)
						{
							switch (0)
							{
							}
						}
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning(ex.Message);
					}
				}
				catch (Exception exception)
				{
					FB127DLxw45 = -2;
					Xs827dHEDRG.SetException(exception);
					return;
				}
				FB127DLxw45 = -2;
				Xs827dHEDRG.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Xs827dHEDRG.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool eH2HUiyuK4UCPnLdns5O()
			{
				return c2mBkLyu1jHGo66Db1RS == null;
			}
		}

		public SearchResultItem QrvvBqsiI3D;

		internal static _003C_003Ec__DisplayClass26_0 yvrDBocT4mBivqnKbxXm;

		internal void dv0vBa4yUjH(object sender, RoutedEventArgs e)
		{
			ClipboardHelper.SetText($"quicker://settings:{QrvvBqsiI3D.Tag}");
			AppHelper.ShowSuccess("已复制");
		}

		[AsyncStateMachine(typeof(HJvK4hHLosRPqalqS08))]
		internal void TesvB734O0B(object sender, RoutedEventArgs e)
		{
			HJvK4hHLosRPqalqS08 stateMachine = default(HJvK4hHLosRPqalqS08);
			stateMachine.Xs827dHEDRG = AsyncVoidMethodBuilder.Create();
			stateMachine.imK27oq4pYs = this;
			stateMachine.FB127DLxw45 = -1;
			stateMachine.Xs827dHEDRG.Start(ref stateMachine);
		}

		internal void QmxvBRb8Hes(object sender, RoutedEventArgs e)
		{
			AppHelper.TryOpenUrlOrFile(string.Format("{0}/settings-{1}", "https://getquicker.net/KC/Manual/Doc", QrvvBqsiI3D.Tag));
		}

		internal static bool YIQlfYcThIiUxxOesXKc()
		{
			return yvrDBocT4mBivqnKbxXm == null;
		}
	}

	[CompilerGenerated]
	private readonly SearchPluginSettings xMntYqLGY3V = new SearchPluginSettings
	{
		IncludeInGlobalSearch = true,
		PluginId = "search.sys.quicker.settings",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo pvOtYcoDKNg = new PluginInfo
	{
		Name = "Quicker设置",
		Description = "搜索Quicker设置页",
		SearchContentName = "Quicker设置页",
		Icon = "fa:Light_Cog"
	};

	[CompilerGenerated]
	private readonly string C7vtYVuMpdQ = "fa:Light_Cog:#1E90FF";

	[CompilerGenerated]
	private readonly SearchResultOperationType blqtYZHNLBu = SearchResultOperationType.Custom;

	[CompilerGenerated]
	private readonly SearchResultOperationType d60tY918A0C;

	[CompilerGenerated]
	private readonly bool agHtYhdMAg8 = true;

	private static QuickerSettingsSearchPlugin e1HctsQdHGp7y6B3diHj;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return xMntYqLGY3V;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return pvOtYcoDKNg;
		}
	}

	public override string Id => "search.sys.quicker.settings";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return C7vtYVuMpdQ;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return blqtYZHNLBu;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return d60tY918A0C;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return agHtYhdMAg8;
		}
	}

	public override void ProcessResult(SearchResultItem resultItem, QueryContext context)
	{
		AppWindowManager.ShowSettingsWindow((SettingPageId)resultItem.Tag);
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext, CancellationToken cancellationToken)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (string.IsNullOrEmpty(queryContext.Search))
		{
			return list;
		}
		foreach (SettingPageInfo allPage in SettingsMenuProvider.AllPages)
		{
			IMatchResult matchResult = tkxn6HAKAgMT8gvXbyh.Xafi4HAJ87(allPage.FullTitle, queryContext);
			if (matchResult != null)
			{
				list.Add(HaFtYRrycwJ(allPage, matchResult));
			}
		}
		return list;
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem historyItem)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.IqlvB8Fuq02 = historyItem;
		SettingPageInfo settingPageInfo = SettingsMenuProvider.AllPages.FirstOrDefault(_003C_003Ec__DisplayClass23_.nxWvBysoPhO);
		if (settingPageInfo == null)
		{
			return null;
		}
		return HaFtYRrycwJ(settingPageInfo, null);
	}

	private static SearchResultItem HaFtYRrycwJ(SettingPageInfo settingPageInfo_0, IMatchResult imatchResult_0)
	{
		return new SearchResultItem
		{
			Title = settingPageInfo_0.FullTitle,
			Tag = settingPageInfo_0.Id,
			SecondaryTitle = "Quicker设置",
			Description = settingPageInfo_0.Description,
			Icon = "fa:" + settingPageInfo_0.Icon.ToString() + ":#999999",
			SecondaryIcon = "fa:Solid_Cog:#1E90FF",
			Score = (imatchResult_0?.Score ?? 100),
			TitleMatchPositions = imatchResult_0?.GetMatchPositions(),
			HistoryData = settingPageInfo_0.Id.ToString(),
			TextData = "quicker://settings:" + settingPageInfo_0.GetUri(),
			TextDataType = "exec"
		};
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem, ContextMenu contextMenu, Window window)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.QrvvBqsiI3D = searchResultItem;
		AppHelper.AddMenuItem(contextMenu.Items, "复制URI", "复制打开设置页的URI文本", "fa:Light_Copy", _003C_003Ec__DisplayClass26_.dv0vBa4yUjH);
		AppHelper.AddMenuItem(contextMenu.Items, "复制为动作", "复制打开设置页的URI文本", "fa:Light_Copy:#007eff", _003C_003Ec__DisplayClass26_.TesvB734O0B);
		AppHelper.AddMenuItem(contextMenu.Items, "打开帮助文档网页", "打开设置页码帮助文档网页", "fa:Light_QuestionCircle", _003C_003Ec__DisplayClass26_.QmxvBRb8Hes);
		return true;
	}

	internal static bool pmcG0BQdzSQeHwddnF1F()
	{
		return e1HctsQdHGp7y6B3diHj == null;
	}
}
