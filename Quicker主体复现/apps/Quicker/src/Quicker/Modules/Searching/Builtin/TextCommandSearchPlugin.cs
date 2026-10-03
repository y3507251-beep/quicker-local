using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using EOqy55MyMeuU2apYyog;
using IOn6RhAJdTUbfGy6gwn;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.QuickActions;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities;
using Quicker.View.TextCommands;

namespace Quicker.Modules.Searching.Builtin;

public class TextCommandSearchPlugin : SearchPlugin, IContextMenuBuilder
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec b6ev6w9f6Bm;

		public static Func<TextCommand, string> SO5v6t06PcQ;

		public static Func<string, bool> tylv6gBATmI;

		public static Func<string, string> XNcv6LW5PWm;

		internal static _003C_003Ec gOenrkcUgAvGTXmY1ydt;

		static _003C_003Ec()
		{
			b6ev6w9f6Bm = new _003C_003Ec();
		}

		internal string uv7vb3sNb5X(TextCommand x)
		{
			return x.Group;
		}

		internal bool R2uvbfFYL8l(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string ymgvbzPkSdV(string x)
		{
			return x;
		}

		internal static bool s73oIdcUPLxXWyVe3sau()
		{
			return gOenrkcUgAvGTXmY1ydt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct oZZyW1HBbkv4kp1e2gu : IAsyncStateMachine
		{
			public int GRB27JR2AVn;

			public AsyncTaskMethodBuilder eWP270wBrJR;

			public _003C_003Ec__DisplayClass20_0 pN027CPMFsb;

			private TaskAwaiter oro27PbrihJ;

			internal static object gldX4QyL66NJZQ9vM6x5;

			private void MoveNext()
			{
				int num = GRB27JR2AVn;
				_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = pN027CPMFsb;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							GRB27JR2AVn = 0;
							oro27PbrihJ = awaiter;
							eWP270wBrJR.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = oro27PbrihJ;
						oro27PbrihJ = default(TaskAwaiter);
						num = -1;
						GRB27JR2AVn = -1;
					}
					awaiter.GetResult();
					QuickActionRunner.ExecuteTextCommand(_003C_003Ec__DisplayClass20_.AEuv6ShMpIK, _003C_003Ec__DisplayClass20_.wlTv626JLmU, "", AppState.HHxtaMaoqJr(), AppState.Y2RtaqSv0AQ(), AppState.AppServer, true, false, 0);
				}
				catch (Exception exception)
				{
					GRB27JR2AVn = -2;
					eWP270wBrJR.SetException(exception);
					return;
				}
				GRB27JR2AVn = -2;
				eWP270wBrJR.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				eWP270wBrJR.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool SJs7ghyLtLGWAhfsDxGs()
			{
				return gldX4QyL66NJZQ9vM6x5 == null;
			}
		}

		public TextCommandSearchPlugin AEuv6ShMpIK;

		public TextCommand wlTv626JLmU;

		private static _003C_003Ec__DisplayClass20_0 cqik0OcUxNnyxxp2TKWn;

		[AsyncStateMachine(typeof(oZZyW1HBbkv4kp1e2gu))]
		internal Task BDVv6vabRc9()
		{
			oZZyW1HBbkv4kp1e2gu stateMachine = default(oZZyW1HBbkv4kp1e2gu);
			stateMachine.eWP270wBrJR = AsyncTaskMethodBuilder.Create();
			stateMachine.pN027CPMFsb = this;
			stateMachine.GRB27JR2AVn = -1;
			stateMachine.eWP270wBrJR.Start(ref stateMachine);
			return stateMachine.eWP270wBrJR.Task;
		}

		internal static bool TITtnbcUIIg34CtcuCks()
		{
			return cqik0OcUxNnyxxp2TKWn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public Guid BYEv6NcR2f5;

		internal static _003C_003Ec__DisplayClass23_0 d5JYFJcUSY824Px7vWQg;

		internal bool QBNv6un3Cds(TextCommand x)
		{
			return x.Id == BYEv6NcR2f5;
		}

		internal static bool RjEaaHcUwnlHB4SWXJwV()
		{
			return d5JYFJcUSY824Px7vWQg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct PSL6udHQrlsuv8LC7U2 : IAsyncStateMachine
		{
			public int vks27Evw4ji;

			public AsyncVoidMethodBuilder Bt627ySjhEG;

			public _003C_003Ec__DisplayClass24_0 hGt278yhHYq;

			private TextCommandEditWindow BRi27atHdCj;

			private TaskAwaiter<bool?> riI277S1SeE;

			private static object wf27XDyLTFwVOjIn5L57;

			private void MoveNext()
			{
				int num = vks27Evw4ji;
				_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = hGt278yhHYq;
				try
				{
					int num2;
					TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
					if (num != 0)
					{
						num2 = 0;
						if (!HNOCSJyLmFIIj9MADDA1())
						{
							goto IL_0044;
						}
					}
					else
					{
						awaiter = riI277S1SeE;
						riI277S1SeE = default(TaskAwaiter<bool?>);
						num2 = 1;
						if (wf27XDyLTFwVOjIn5L57 != null)
						{
							goto IL_0044;
						}
					}
					goto IL_0048;
					IL_0048:
					switch (num2)
					{
					default:
					{
						_003C_003Ec__DisplayClass24_.Em5v60A5Wnx.Hide();
						List<string> groups = AppState.DataService.neZtXfcGsie().Select(_003C_003Ec.SO5v6t06PcQ ?? (_003C_003Ec.SO5v6t06PcQ = _003C_003Ec.b6ev6w9f6Bm.uv7vb3sNb5X)).Distinct()
							.Where(_003C_003Ec.tylv6gBATmI ?? (_003C_003Ec.tylv6gBATmI = _003C_003Ec.b6ev6w9f6Bm.R2uvbfFYL8l))
							.OrderBy(_003C_003Ec.XNcv6LW5PWm ?? (_003C_003Ec.XNcv6LW5PWm = _003C_003Ec.b6ev6w9f6Bm.ymgvbzPkSdV))
							.ToList();
						BRi27atHdCj = new TextCommandEditWindow(AppState.DataService, _003C_003Ec__DisplayClass24_.M8Xv6CxiYEV.Group, groups)
						{
							TextCommand = _003C_003Ec__DisplayClass24_.M8Xv6CxiYEV
						};
						BRi27atHdCj.Owner = null;
						awaiter = BRi27atHdCj.MjdLOXIjD10(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							vks27Evw4ji = 0;
							riI277S1SeE = awaiter;
							Bt627ySjhEG.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					case 1:
						num = -1;
						vks27Evw4ji = -1;
						break;
					}
					if (awaiter.GetResult() == true)
					{
						AppState.DataService.neZtXfcGsie().Remove(_003C_003Ec__DisplayClass24_.M8Xv6CxiYEV);
						AppState.DataService.neZtXfcGsie().Add(BRi27atHdCj.TextCommand);
						AppState.DataService.il2tXPiARoC();
					}
					goto end_IL_0010;
					IL_0044:
					int num3 = default(int);
					num2 = num3;
					goto IL_0048;
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					vks27Evw4ji = -2;
					BRi27atHdCj = null;
					Bt627ySjhEG.SetException(exception);
					return;
				}
				vks27Evw4ji = -2;
				BRi27atHdCj = null;
				Bt627ySjhEG.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Bt627ySjhEG.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool HNOCSJyLmFIIj9MADDA1()
			{
				return wf27XDyLTFwVOjIn5L57 == null;
			}
		}

		public Window Em5v60A5Wnx;

		public TextCommand M8Xv6CxiYEV;

		private static _003C_003Ec__DisplayClass24_0 LYub3QcUmfvlGZpJRcpN;

		[AsyncStateMachine(typeof(PSL6udHQrlsuv8LC7U2))]
		internal void HpJv6J5khb8(object sender, RoutedEventArgs e)
		{
			PSL6udHQrlsuv8LC7U2 stateMachine = default(PSL6udHQrlsuv8LC7U2);
			stateMachine.Bt627ySjhEG = AsyncVoidMethodBuilder.Create();
			stateMachine.hGt278yhHYq = this;
			stateMachine.vks27Evw4ji = -1;
			stateMachine.Bt627ySjhEG.Start(ref stateMachine);
		}

		internal static bool d7nw8XcUsSFNiWFcxkpB()
		{
			return LYub3QcUmfvlGZpJRcpN == null;
		}
	}

	[CompilerGenerated]
	private readonly SearchPluginSettings bnJtEgirViL = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "`"
			},
			new SearchTrigger
			{
				TriggerWord = "·"
			}
		},
		PluginId = "search.sys.quicker.textcommand",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo kNFtELDVYQE = new PluginInfo
	{
		Name = "文本指令",
		Description = "搜索Quicker文本指令",
		SearchContentName = "文本指令",
		Icon = "fa:Light_Ad"
	};

	[CompilerGenerated]
	private readonly string hkftEvrMLHs = "fa:Light_Ad";

	[CompilerGenerated]
	private readonly SearchResultOperationType PsRtESspdmq = SearchResultOperationType.Custom;

	[CompilerGenerated]
	private readonly SearchResultOperationType KA2tE2yR16r = SearchResultOperationType.Custom;

	internal static TextCommandSearchPlugin bQXpG9QDFl1nAZkrRvRU;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return bnJtEgirViL;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return kNFtELDVYQE;
		}
	}

	public override string Id => "search.sys.quicker.textcommand";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return hkftEvrMLHs;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return PsRtESspdmq;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return KA2tE2yR16r;
		}
	}

	public override bool IsSupportHistory => true;

	public override void ProcessResult(SearchResultItem resultItem, QueryContext context)
	{
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.AEuv6ShMpIK = this;
		_003C_003Ec__DisplayClass20_.wlTv626JLmU = resultItem.Tag as TextCommand;
		GaZT3MMHZ3eZxDOySux.CrALMOVaWOa(_003C_003Ec__DisplayClass20_.BDVv6vabRc9);
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext, CancellationToken cancellationToken)
	{
		if (string.IsNullOrEmpty(queryContext.Search))
		{
			return new List<SearchResultItem>();
		}
		List<SearchResultItem> list = new List<SearchResultItem>();
		foreach (TextCommand item in AppState.DataService.neZtXfcGsie())
		{
			MultiFieldMatchResult multiFieldMatchResult = tkxn6HAKAgMT8gvXbyh.KwUidyksAU(item.CmdText, 1.0, item.Title, 0.5, false, queryContext);
			if (multiFieldMatchResult.Score > 0)
			{
				list.Add(IOItEtTK14q(item, multiFieldMatchResult));
			}
		}
		return list;
	}

	private static SearchResultItem IOItEtTK14q(TextCommand textCommand_0, MultiFieldMatchResult multiFieldMatchResult_0)
	{
		SearchResultItem searchResultItem = new SearchResultItem();
		searchResultItem.Title = textCommand_0.CmdText;
		searchResultItem.Description = textCommand_0.Title + " (" + textCommand_0.ActionType.GetEnumDisplayName() + ": " + textCommand_0.GetSummary() + ")";
		searchResultItem.Tag = textCommand_0;
		searchResultItem.Score = multiFieldMatchResult_0?.Score ?? 0;
		searchResultItem.TitleMatchPositions = multiFieldMatchResult_0?.Result1?.GetMatchPositions();
		searchResultItem.DescriptionMatchPositions = multiFieldMatchResult_0?.Result2?.GetMatchPositions();
		searchResultItem.HistoryData = textCommand_0.Id.ToString();
		return searchResultItem;
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem historyItem)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		if (string.IsNullOrEmpty(historyItem.HistoryData))
		{
			return null;
		}
		if (Guid.TryParse(historyItem.HistoryData, out _003C_003Ec__DisplayClass23_.BYEv6NcR2f5))
		{
			TextCommand textCommand = AppState.DataService.neZtXfcGsie()?.FirstOrDefault(_003C_003Ec__DisplayClass23_.QBNv6un3Cds);
			if (textCommand != null)
			{
				return IOItEtTK14q(textCommand, null);
			}
		}
		return null;
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem, ContextMenu contextMenu, Window window)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.Em5v60A5Wnx = window;
		_003C_003Ec__DisplayClass24_.M8Xv6CxiYEV = searchResultItem.Tag as TextCommand;
		if (_003C_003Ec__DisplayClass24_.M8Xv6CxiYEV == null)
		{
			return false;
		}
		AppHelper.AddMenuItem(contextMenu.Items, "编辑", "编辑此文本指令", "fa:Light_Edit", _003C_003Ec__DisplayClass24_.HpJv6J5khb8);
		return true;
	}

	internal static bool ucx5cMQDcxOpVTjkHM0n()
	{
		return bQXpG9QDFl1nAZkrRvRU == null;
	}
}
