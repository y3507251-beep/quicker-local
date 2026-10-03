using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Newtonsoft.Json;
using obeHQ65BC0uIkwN6URv;
using qIOAiL5tHSq0oBCxwHP;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.ContextMenus;
using Quicker.Modules.Searching;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using SWBMfZYGyc6L9yHIvKQ;
using vjGJX2WpUfGgQtNkVc7;
using WindowsInput.Native;

namespace nTcrhUWGhOwDpTXBUpF;

internal class iKTOkqWIMO3lqa4hFjM : kI86NbWLfJKJc0tGQJY
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public ActionItem eYKvHwYkIkX;

		public CustomSearchResultItem Q0PvHtRbRHK;

		public iKTOkqWIMO3lqa4hFjM blTvHgnCUGr;

		internal static _003C_003Ec__DisplayClass10_0 diWCFEcgrlHVNBZT7j8G;

		internal void yvrvsfjdElV(ItemCollection menuItems, IList<CommonOperationItem> operations, double iconSize)
		{
			foreach (CommonOperationItem operation in operations)
			{
				if (operation.IsSeparator)
				{
					AppHelper.AddMenuSeparator(menuItems);
					continue;
				}
				System.Windows.Controls.MenuItem menuItem = AppHelper.AddMenuItem(menuItems, operation.Title, operation.Description, operation.Icon, operation.Children.HasData() ? null : new RoutedEventHandler(NjqvszyjXXn), null, null, null, iconSize);
				menuItem.Tag = operation.Data;
				if (operation.Children.HasData())
				{
					yvrvsfjdElV(menuItem.Items, operation.Children, iconSize);
				}
			}
		}

		internal void NjqvszyjXXn(object sender, RoutedEventArgs e)
		{
			string text = (sender as System.Windows.Controls.MenuItem).Tag as string;
			AppState.AppServer.ExecuteAction(eYKvHwYkIkX, -1, null, JrJWiKYIEBcPm8FFZOl.kBQLD2aG1Qb(), false, false, "menu:" + text + ":" + Q0PvHtRbRHK.Data, ActionTrigger.SearchContextMenu, null, new ActionExtraContextData
			{
				ActiveWindowBeforeSearch = blTvHgnCUGr.uJDtNmIdWYw.ActiveWindowBeforeShow
			});
		}

		internal static bool YOwgVicgN9LLsJdwPgCw()
		{
			return diWCFEcgrlHVNBZT7j8G == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass12_0
	{
		public string J1cvHLPbtKf;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public ActionItem Xm4vHS2Bw4w;

		public string DiPvH2Zck4x;

		public iKTOkqWIMO3lqa4hFjM v73vHuU3k3y;

		public CancellationToken kmUvHNMrqWw;

		public int Fu3vHJHQyP9;

		private static _003C_003Ec__DisplayClass3_0 MSsARrcgfcIEhyWcva6D;

		internal void gTyvHv273cK()
		{
			ActionExecuteContext actionExecuteContext = AppState.AppServer.ExecuteAction(Xm4vHS2Bw4w, -1, null, false, true, false, "search:" + DiPvH2Zck4x, ActionTrigger.SearchInput, null, new ActionExtraContextData
			{
				ActiveWindowBeforeSearch = v73vHuU3k3y.uJDtNmIdWYw.ActiveWindowBeforeShow
			}, kmUvHNMrqWw);
			if (kmUvHNMrqWw.IsCancellationRequested)
			{
				return;
			}
			StringCharInfo stringCharInfo_ = new StringCharInfo(DiPvH2Zck4x);
			if (actionExecuteContext == null)
			{
				return;
			}
			int num = 0;
			if (!wePbhgcgb515pSSO7I8P())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (actionExecuteContext.ReturnResultObject is CustomSearchResult customSearchResult)
			{
				IList<SearchResultItem> results = C9VtNYwcFYY(Xm4vHS2Bw4w, customSearchResult.Items);
				v73vHuU3k3y.uJDtNmIdWYw.SetResults(results, Fu3vHJHQyP9);
			}
			else if (!string.IsNullOrEmpty(actionExecuteContext.ReturnResult))
			{
				IList<SearchResultItem> list = v73vHuU3k3y.mAEtNIwrKw3(actionExecuteContext.ReturnResult, Xm4vHS2Bw4w);
				foreach (SearchResultItem item in list)
				{
					if (item.TitleMatchPositions == null && !string.IsNullOrEmpty(DiPvH2Zck4x))
					{
						item.TitleMatchPositions = tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(item.Title, DiPvH2Zck4x, stringCharInfo_)?.GetMatchPositions();
					}
				}
				if (!kmUvHNMrqWw.IsCancellationRequested)
				{
					v73vHuU3k3y.uJDtNmIdWYw.SetResults(list, Fu3vHJHQyP9);
				}
			}
			else
			{
				v73vHuU3k3y.uJDtNmIdWYw.ClearResults();
			}
		}

		internal static bool wePbhgcgb515pSSO7I8P()
		{
			return MSsARrcgfcIEhyWcva6D == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public ActionItem s1qvHCyhmTK;

		private static _003C_003Ec__DisplayClass4_0 NrH5aacgiTZcUoUNbm8p;

		internal SearchResultItem W75vH0wRU1r(CustomSearchResultItem op)
		{
			return new SearchResultItem
			{
				Title = op.Title,
				Description = op.Description,
				Icon = ((!string.IsNullOrEmpty(op.Icon)) ? op.Icon : s1qvHCyhmTK?.Icon),
				SecondaryIcon = op.SecondaryIcon,
				Score = 100 + op.Score,
				TextData = op.Data,
				SecondaryTitle = op.SecondaryTitle,
				Tag = op
			};
		}

		internal static bool GssdZ1cgly63qhiQktWv()
		{
			return NrH5aacgiTZcUoUNbm8p == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public ActionItem PoQvHE5sIrk;

		private static _003C_003Ec__DisplayClass5_0 BO8yjicgYasKBuTGT4ui;

		internal SearchResultItem onPvHP1DdnC(SimpleOperationItem op)
		{
			return new SearchResultItem
			{
				Title = op.Name,
				Description = op.Description,
				Icon = ((!string.IsNullOrEmpty(op.Icon)) ? op.Icon : PoQvHE5sIrk?.Icon),
				Score = 100.0,
				TextData = op.Key
			};
		}

		internal static bool zci5uScg8v1bkGlS7NWy()
		{
			return BO8yjicgYasKBuTGT4ui == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public ActionItem jBKvH81H1TA;

		public string y2SvHafg12v;

		public iKTOkqWIMO3lqa4hFjM RBCvH7sOR69;

		public bool GQwvHRLns92;

		private static _003C_003Ec__DisplayClass6_0 HrKtKRcgggsXnibH37Tr;

		internal void xa7vHyPN2Vb()
		{
			Thread.Sleep(100);
			try
			{
				AppState.AppServer.ExecuteAction(jBKvH81H1TA, -1, null, GQwvHRLns92, false, false, y2SvHafg12v, ActionTrigger.SearchWindow, null, new ActionExtraContextData
				{
					Text = y2SvHafg12v,
					ActiveWindowBeforeSearch = RBCvH7sOR69.uJDtNmIdWYw.ActiveWindowBeforeShow
				});
			}
			catch (Exception ex)
			{
				MBUtNK0tNoI.Warn("执行动作时出错：" + ex.Message, ex);
				AppHelper.ShowWarning("执行动作时出错：" + ex.Message);
			}
		}

		internal static bool aERTGCcgP2YqY1xSU4HP()
		{
			return HrKtKRcgggsXnibH37Tr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct aq82ZEH0g470dynDPsS : IAsyncStateMachine
		{
			public int GeO2aMoa6i5;

			public AsyncTaskMethodBuilder VMG2aAZMvpN;

			public _003C_003Ec__DisplayClass8_0 FZS2aOkyfAH;

			private TaskAwaiter U0O2aF2xcwy;

			private static object SU5ghIyLLcEpH2GwlAsm;

			private void MoveNext()
			{
				int num = GeO2aMoa6i5;
				_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = FZS2aOkyfAH;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							GeO2aMoa6i5 = 0;
							U0O2aF2xcwy = awaiter;
							VMG2aAZMvpN.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = U0O2aF2xcwy;
						int num2 = 0;
						if (!f4oKR3yLuFhueqThuRm5())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						U0O2aF2xcwy = default(TaskAwaiter);
						num = -1;
						GeO2aMoa6i5 = -1;
					}
					awaiter.GetResult();
					ActionHelper.SendTextToWindow(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data, true, false);
				}
				catch (Exception exception)
				{
					GeO2aMoa6i5 = -2;
					VMG2aAZMvpN.SetException(exception);
					return;
				}
				GeO2aMoa6i5 = -2;
				VMG2aAZMvpN.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				VMG2aAZMvpN.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool f4oKR3yLuFhueqThuRm5()
			{
				return SU5ghIyLLcEpH2GwlAsm == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct Od29a3HTGfoie0SZUky : IAsyncStateMachine
		{
			public int c1o2aUcIjkc;

			public AsyncTaskMethodBuilder WW42alLkGhd;

			public _003C_003Ec__DisplayClass8_0 CnK2aiqC9Vv;

			private TaskAwaiter pHP2a3MEQhV;

			internal static object nwJE07yLfSGbjo7H2CWV;

			private void MoveNext()
			{
				int num = c1o2aUcIjkc;
				_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = CnK2aiqC9Vv;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(150).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							c1o2aUcIjkc = 0;
							pHP2a3MEQhV = awaiter;
							WW42alLkGhd.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = pHP2a3MEQhV;
						pHP2a3MEQhV = default(TaskAwaiter);
						int num2 = 0;
						if (!ngKwFOyLbkBGWKpJ1RGY())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						num = -1;
						c1o2aUcIjkc = -1;
					}
					awaiter.GetResult();
					SendKeys.SendWait(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data);
				}
				catch (Exception exception)
				{
					c1o2aUcIjkc = -2;
					WW42alLkGhd.SetException(exception);
					return;
				}
				c1o2aUcIjkc = -2;
				WW42alLkGhd.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				WW42alLkGhd.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool ngKwFOyLbkBGWKpJ1RGY()
			{
				return nwJE07yLfSGbjo7H2CWV == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct PeXEEvHSjFJVImMMiW8 : IAsyncStateMachine
		{
			public int Vcn2af5PKwb;

			public AsyncTaskMethodBuilder yUq2azEUgWV;

			public _003C_003Ec__DisplayClass8_0 NKZ27wSGqUp;

			private TaskAwaiter CTv27tDrcEe;

			internal static object jTCmu5yLiN2OI1GJHFtm;

			private void MoveNext()
			{
				int num = Vcn2af5PKwb;
				_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = NKZ27wSGqUp;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(150).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							if (!i2Ro3yyLl3bCLQ8ao0JF())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = 0;
							Vcn2af5PKwb = 0;
							CTv27tDrcEe = awaiter;
							yUq2azEUgWV.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = CTv27tDrcEe;
						CTv27tDrcEe = default(TaskAwaiter);
						num = -1;
						Vcn2af5PKwb = -1;
					}
					awaiter.GetResult();
					ActionHelper.SendTextToWindow(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data, false, false);
				}
				catch (Exception exception)
				{
					Vcn2af5PKwb = -2;
					yUq2azEUgWV.SetException(exception);
					return;
				}
				Vcn2af5PKwb = -2;
				yUq2azEUgWV.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				yUq2azEUgWV.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool i2Ro3yyLl3bCLQ8ao0JF()
			{
				return jTCmu5yLiN2OI1GJHFtm == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct iBqqcQHK7ABCLfMxvAM : IAsyncStateMachine
		{
			public int v2n27ghBQO6;

			public AsyncTaskMethodBuilder RbL27LbkhQl;

			public _003C_003Ec__DisplayClass8_0 QpZ27v9dyaO;

			private TaskAwaiter BUP27STPv9v;

			private static object JNfrdjyL50P4LlgK7x9f;

			private void MoveNext()
			{
				int num = v2n27ghBQO6;
				_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = QpZ27v9dyaO;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							v2n27ghBQO6 = 0;
							BUP27STPv9v = awaiter;
							RbL27LbkhQl.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = BUP27STPv9v;
						int num2 = 0;
						if (JNfrdjyL50P4LlgK7x9f != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						BUP27STPv9v = default(TaskAwaiter);
						num = -1;
						v2n27ghBQO6 = -1;
					}
					awaiter.GetResult();
					ActionHelper.SendTextToWindow(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data, true, false);
				}
				catch (Exception exception)
				{
					v2n27ghBQO6 = -2;
					RbL27LbkhQl.SetException(exception);
					return;
				}
				v2n27ghBQO6 = -2;
				RbL27LbkhQl.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				RbL27LbkhQl.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool vop4DEyLYaj9TgDb8rVH()
			{
				return JNfrdjyL50P4LlgK7x9f == null;
			}
		}

		public CustomSearchResultItem joOvH9VHgtF;

		internal static _003C_003Ec__DisplayClass8_0 Pe9tBpcgx6fuf587rqxI;

		[AsyncStateMachine(typeof(aq82ZEH0g470dynDPsS))]
		internal Task H54vHqjDuOj()
		{
			aq82ZEH0g470dynDPsS stateMachine = default(aq82ZEH0g470dynDPsS);
			stateMachine.VMG2aAZMvpN = AsyncTaskMethodBuilder.Create();
			stateMachine.FZS2aOkyfAH = this;
			stateMachine.GeO2aMoa6i5 = -1;
			stateMachine.VMG2aAZMvpN.Start(ref stateMachine);
			return stateMachine.VMG2aAZMvpN.Task;
		}

		[AsyncStateMachine(typeof(Od29a3HTGfoie0SZUky))]
		internal Task u1LvHcHciQK()
		{
			Od29a3HTGfoie0SZUky stateMachine = default(Od29a3HTGfoie0SZUky);
			stateMachine.WW42alLkGhd = AsyncTaskMethodBuilder.Create();
			stateMachine.CnK2aiqC9Vv = this;
			stateMachine.c1o2aUcIjkc = -1;
			stateMachine.WW42alLkGhd.Start(ref stateMachine);
			return stateMachine.WW42alLkGhd.Task;
		}

		[AsyncStateMachine(typeof(PeXEEvHSjFJVImMMiW8))]
		internal Task xgUvHVZdBJ2()
		{
			PeXEEvHSjFJVImMMiW8 stateMachine = default(PeXEEvHSjFJVImMMiW8);
			stateMachine.yUq2azEUgWV = AsyncTaskMethodBuilder.Create();
			stateMachine.NKZ27wSGqUp = this;
			stateMachine.Vcn2af5PKwb = -1;
			stateMachine.yUq2azEUgWV.Start(ref stateMachine);
			return stateMachine.yUq2azEUgWV.Task;
		}

		[AsyncStateMachine(typeof(iBqqcQHK7ABCLfMxvAM))]
		internal Task u0vvHZKBymP()
		{
			iBqqcQHK7ABCLfMxvAM stateMachine = default(iBqqcQHK7ABCLfMxvAM);
			stateMachine.RbL27LbkhQl = AsyncTaskMethodBuilder.Create();
			stateMachine.QpZ27v9dyaO = this;
			stateMachine.v2n27ghBQO6 = -1;
			stateMachine.RbL27LbkhQl.Start(ref stateMachine);
			return stateMachine.RbL27LbkhQl.Task;
		}

		internal static bool qfjeo4cgIoVs7OvefSDy()
		{
			return Pe9tBpcgx6fuf587rqxI == null;
		}
	}

	private readonly SearchWindow uJDtNmIdWYw;

	private static readonly ILog MBUtNK0tNoI;

	internal static iKTOkqWIMO3lqa4hFjM n1TkrlQAaMADLDEW4ZY4;

	public iKTOkqWIMO3lqa4hFjM(SearchWindow searchWindow_1)
	{
		uJDtNmIdWYw = searchWindow_1;
	}

	public void LEmMjgMin79(string string_0, CancellationToken cancellationToken_0, int int_0, int int_1)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.DiPvH2Zck4x = string_0;
		_003C_003Ec__DisplayClass3_.v73vHuU3k3y = this;
		_003C_003Ec__DisplayClass3_.kmUvHNMrqWw = cancellationToken_0;
		_003C_003Ec__DisplayClass3_.Fu3vHJHQyP9 = int_0;
		_003C_003Ec__DisplayClass3_.Xm4vHS2Bw4w = uJDtNmIdWYw.SelectedAction;
		if (_003C_003Ec__DisplayClass3_.Xm4vHS2Bw4w == null)
		{
			return;
		}
		if (_003C_003Ec__DisplayClass3_.Xm4vHS2Bw4w.Association != null)
		{
			ActionAssociation association = _003C_003Ec__DisplayClass3_.Xm4vHS2Bw4w.Association;
			if (association == null || association.EnableRealtimeSearch)
			{
				Task.Run((Action)_003C_003Ec__DisplayClass3_.gTyvHv273cK, _003C_003Ec__DisplayClass3_.kmUvHNMrqWw);
				return;
			}
		}
		uJDtNmIdWYw.ClearResults();
	}

	private static IList<SearchResultItem> C9VtNYwcFYY(ActionItem actionItem_0, IList<CustomSearchResultItem> ilist_0)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.s1qvHCyhmTK = actionItem_0;
		return ilist_0.Select(_003C_003Ec__DisplayClass4_.W75vH0wRU1r).ToList();
	}

	private IList<SearchResultItem> mAEtNIwrKw3(string string_0, ActionItem actionItem_0)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.PoQvHE5sIrk = actionItem_0;
		if (string_0.StartsWith("{") && string_0.EndsWith("}"))
		{
			try
			{
				CustomSearchResult customSearchResult = JsonConvert.DeserializeObject<CustomSearchResult>(string_0);
				return C9VtNYwcFYY(_003C_003Ec__DisplayClass5_.PoQvHE5sIrk, customSearchResult.Items);
			}
			catch (Exception)
			{
				AppHelper.ShowWarning("解析json格式搜索结果失败！");
			}
			return null;
		}
		return AppHelper.StringToOperationItems(string_0, true).Select(_003C_003Ec__DisplayClass5_.onPvHP1DdnC).ToList();
	}

	public void FA5MjViPItw(SearchResultItem searchResultItem_0, string string_0, SearchTriggerType searchTriggerType_0, SearchWindow searchWindow_1)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.y2SvHafg12v = string_0;
		_003C_003Ec__DisplayClass6_.RBCvH7sOR69 = this;
		_003C_003Ec__DisplayClass6_.jBKvH81H1TA = uJDtNmIdWYw.SelectedAction;
		if (searchResultItem_0 == null)
		{
			uJDtNmIdWYw.AfterActionSelected();
			_003C_003Ec__DisplayClass6_.GQwvHRLns92 = JrJWiKYIEBcPm8FFZOl.hCwLDvPTh1Q(VirtualKeyCode.RSHIFT);
			Task.Run((Action)_003C_003Ec__DisplayClass6_.xa7vHyPN2Vb);
			return;
		}
		ycstNWRfDUf(searchResultItem_0, _003C_003Ec__DisplayClass6_.jBKvH81H1TA);
		if (n1TkrlQAaMADLDEW4ZY4 == null)
		{
			switch (0)
			{
			}
		}
	}

	private void ycstNWRfDUf(SearchResultItem searchResultItem_0, ActionItem actionItem_0)
	{
		if (searchResultItem_0 == null)
		{
			return;
		}
		CustomSearchResultItem customSearchResultItem = jDltNHRRyiS(searchResultItem_0);
		if (customSearchResultItem != null)
		{
			if (!customSearchResultItem.NoHide)
			{
				uJDtNmIdWYw.AfterActionSelected();
			}
			hXXtNkhVGA8(customSearchResultItem, actionItem_0);
		}
	}

	private void hXXtNkhVGA8(CustomSearchResultItem customSearchResultItem_0, ActionItem actionItem_0)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.joOvH9VHgtF = customSearchResultItem_0;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data))
		{
			return;
		}
		try
		{
			string text = _003C_003Ec__DisplayClass8_.joOvH9VHgtF.Operation?.ToLower();
			if (text != null)
			{
				char c;
				switch (text.Length)
				{
				case 3:
					if (text == "run")
					{
						AppHelper.ExecuteText(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data);
						return;
					}
					break;
				case 4:
					switch (text[0])
					{
					case 't':
						if (text == "text")
						{
							if (JrJWiKYIEBcPm8FFZOl.hCwLDvPTh1Q(VirtualKeyCode.LCONTROL))
							{
								Task.Run((Func<Task>)_003C_003Ec__DisplayClass8_.u0vvHZKBymP);
							}
							else
							{
								ClipboardHelper.SetText(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data);
							}
							return;
						}
						break;
					case 'c':
						if (text == "copy")
						{
							ClipboardHelper.SetText(_003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data);
							return;
						}
						break;
					}
					break;
				case 5:
					while (true)
					{
						IL_0164:
						c = text[0];
						if (c == 'i')
						{
							break;
						}
						while (true)
						{
							if (c != 'p')
							{
								if (!SJxBYhQArP2g8AbmtpUo())
								{
									switch (0)
									{
									case 2:
										break;
									case 1:
										goto IL_0164;
									case 3:
										goto IL_01b5;
									case 4:
										goto IL_0200;
									default:
										goto end_IL_004d;
									}
									continue;
								}
								break;
							}
							if (!(text == "paste"))
							{
								break;
							}
							Task.Run((Func<Task>)_003C_003Ec__DisplayClass8_.H54vHqjDuOj);
							return;
						}
						goto end_IL_004d;
					}
					if (!(text == "input"))
					{
						break;
					}
					goto IL_0251;
				case 8:
					goto IL_01b5;
				case 9:
					{
						if (!(text == "inputtext"))
						{
							break;
						}
						goto IL_0251;
					}
					IL_01b5:
					c = text[0];
					if (c != 'c')
					{
						if (c != 's' || !(text == "sendkeys"))
						{
							break;
						}
						Task.Run((Func<Task>)_003C_003Ec__DisplayClass8_.u1LvHcHciQK);
						return;
					}
					if (!(text == "callback"))
					{
						break;
					}
					goto IL_0200;
					IL_0200:
					AppState.AppServer.ExecuteAction(actionItem_0, -1, null, JrJWiKYIEBcPm8FFZOl.kBQLD2aG1Qb(), false, false, _003C_003Ec__DisplayClass8_.joOvH9VHgtF.Data, ActionTrigger.SearchCallback, null, new ActionExtraContextData
					{
						ActiveWindowBeforeSearch = uJDtNmIdWYw.ActiveWindowBeforeShow
					});
					return;
					IL_0251:
					Task.Run((Func<Task>)_003C_003Ec__DisplayClass8_.xgUvHVZdBJ2);
					return;
					end_IL_004d:
					break;
				}
			}
			AppHelper.ShowWarning("未知的操作类型：" + _003C_003Ec__DisplayClass8_.joOvH9VHgtF.Operation);
		}
		catch (Exception exception)
		{
			MBUtNK0tNoI.Warn("搜索框执行操作出错：" + exception.GetMessageWithInner(), exception);
			AppHelper.ShowWarning("搜索框执行操作出错：" + exception.GetMessageWithInner());
		}
	}

	public System.Windows.Controls.ContextMenu wZJMjMr3ySd(SearchResultItem searchResultItem_0)
	{
		return aSxtNGkJgAH(searchResultItem_0, uJDtNmIdWYw.SelectedAction);
	}

	private System.Windows.Controls.ContextMenu aSxtNGkJgAH(SearchResultItem searchResultItem_0, ActionItem actionItem_0)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.eYKvHwYkIkX = actionItem_0;
		_003C_003Ec__DisplayClass10_.blTvHgnCUGr = this;
		_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK = jDltNHRRyiS(searchResultItem_0);
		System.Windows.Controls.ContextMenu contextMenu;
		int? num;
		object obj;
		int num2;
		if (_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK != null)
		{
			contextMenu = new System.Windows.Controls.ContextMenu();
			num = null;
			if (_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Children.HasData())
			{
				_003C_003Ec__DisplayClass10_.yvrvsfjdElV(contextMenu.Items, _003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Children, 16.0);
				num = contextMenu.Items.Add(new Separator());
			}
			string dataType = _003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.DataType;
			if (dataType != null)
			{
				obj = dataType.ToLower();
				if (obj == null)
				{
					goto IL_00bb;
				}
				goto IL_00c1;
			}
			num2 = 0;
			if (!SJxBYhQArP2g8AbmtpUo())
			{
				int num3 = default(int);
				num2 = num3;
			}
			goto IL_0122;
		}
		goto IL_0234;
		IL_00bb:
		obj = string.Empty;
		goto IL_00c1;
		IL_0122:
		switch (num2)
		{
		case 1:
			goto IL_01cd;
		case 2:
			goto IL_0234;
		}
		obj = null;
		goto IL_00bb;
		IL_00c1:
		switch ((string)obj)
		{
		case "path":
			break;
		default:
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data) && (File.Exists(_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data) || Directory.Exists(_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data)))
			{
				bLptNsQnN7V(contextMenu, _003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data, _003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Title);
			}
			goto IL_01ed;
		case "text":
			ContentContextMenuService.BuildTextContextMenus(contextMenu.Items, _003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data);
			goto IL_01ed;
		case "custom":
			goto IL_01ed;
		}
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data))
		{
			if (!File.Exists(_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data))
			{
				if (!Directory.Exists(_003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data))
				{
					goto IL_01ed;
				}
				num2 = 1;
				if (SJxBYhQArP2g8AbmtpUo())
				{
					goto IL_0122;
				}
			}
			goto IL_01cd;
		}
		goto IL_01ed;
		IL_0234:
		AppHelper.ShowWarning("此项数据不完整，请检查动作。");
		return null;
		IL_01ed:
		if (num.HasValue && contextMenu.Items.Count == num.Value + 1)
		{
			contextMenu.Items.RemoveAt(num.Value);
		}
		if (contextMenu.Items.Count > 0)
		{
			return contextMenu;
		}
		return null;
		IL_01cd:
		bLptNsQnN7V(contextMenu, _003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Data, _003C_003Ec__DisplayClass10_.Q0PvHtRbRHK.Title);
		goto IL_01ed;
	}

	private void bLptNsQnN7V(System.Windows.Controls.ContextMenu contextMenu_0, string string_0, string string_1)
	{
		if (string_0.IsPathExists())
		{
			SqoZP75Qt63qQSW6CF1.LZjBkbQjRm(string_0, contextMenu_0.Items);
			SqoZP75Qt63qQSW6CF1.TITBsl183p(string_0, contextMenu_0.Items, contextMenu_0);
			ContentContextMenuService.KXCteJAL0Uj(contextMenu_0.Items, new List<string> { string_0 }, true, string_1);
		}
	}

	private static CustomSearchResultItem jDltNHRRyiS(SearchResultItem searchResultItem_0)
	{
		CustomSearchResultItem customSearchResultItem = null;
		IEnumerator<CommonOperationItem> enumerator = default(IEnumerator<CommonOperationItem>);
		int num;
		gNcjnN5ZX5ywtU0mFU6 gNcjnN5ZX5ywtU0mFU = default(gNcjnN5ZX5ywtU0mFU6);
		if (searchResultItem_0.Tag != null && searchResultItem_0.Tag is CustomSearchResultItem customSearchResultItem2)
		{
			customSearchResultItem = customSearchResultItem2;
			if (customSearchResultItem.Menu.HasData())
			{
				if (customSearchResultItem.Children == null)
				{
					customSearchResultItem.Children = new List<CommonOperationItem>();
				}
				else
				{
					customSearchResultItem.Children.Clear();
				}
				enumerator = customSearchResultItem.Menu.GetEnumerator();
				num = 1;
				if (n1TkrlQAaMADLDEW4ZY4 != null)
				{
					goto IL_012a;
				}
				goto IL_012e;
			}
		}
		else if (!string.IsNullOrEmpty(searchResultItem_0.TextData))
		{
			gNcjnN5ZX5ywtU0mFU = dCwtN1oue0j(searchResultItem_0.TextData);
			customSearchResultItem = new CustomSearchResultItem
			{
				NoHide = gNcjnN5ZX5ywtU0mFU.e6BBVxpeAQ(),
				Data = gNcjnN5ZX5ywtU0mFU.Data,
				Operation = gNcjnN5ZX5ywtU0mFU.Operation,
				DataType = gNcjnN5ZX5ywtU0mFU.DataType,
				Icon = searchResultItem_0.Icon,
				Title = searchResultItem_0.Title,
				Description = searchResultItem_0.Description,
				Score = (int)searchResultItem_0.Score
			};
			if (!string.IsNullOrEmpty(gNcjnN5ZX5ywtU0mFU.Menu))
			{
				customSearchResultItem.Children = new List<CommonOperationItem>();
				num = 0;
				if (n1TkrlQAaMADLDEW4ZY4 != null)
				{
					goto IL_012a;
				}
				goto IL_012e;
			}
		}
		goto IL_035f;
		IL_012a:
		int num2 = default(int);
		num = num2;
		goto IL_012e;
		IL_035f:
		return customSearchResultItem;
		IL_012e:
		switch (num)
		{
		default:
		{
			List<SimpleOperationItem> list = AppHelper.StringToOperationItems(gNcjnN5ZX5ywtU0mFU.Menu, false, true);
			if (!list.HasData())
			{
				break;
			}
			_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_0_ = default(_003C_003Ec__DisplayClass12_0);
			_003C_003Ec__DisplayClass12_0_.J1cvHLPbtKf = "#008000";
			CommonOperationItem commonOperationItem = null;
			int num4 = default(int);
			foreach (SimpleOperationItem item in list)
			{
				if (item.IsSeparator)
				{
					customSearchResultItem.Children.Add(new CommonOperationItem
					{
						IsSeparator = true
					});
					continue;
				}
				if (item.Name.StartsWith("[+]"))
				{
					(string, string, string) tuple = UIHelper.ExtractIconAndTitle(item.Name.Substring(3));
					commonOperationItem = new CommonOperationItem
					{
						Title = tuple.Item2,
						Description = tuple.Item3,
						Icon = MwUtNXHYG7w(tuple.Item1, ref _003C_003Ec__DisplayClass12_0_),
						Children = new List<CommonOperationItem>()
					};
					customSearchResultItem.Children.Add(commonOperationItem);
					continue;
				}
				int num3;
				if (item.Name.StartsWith("[-]") && commonOperationItem != null)
				{
					(string, string, string) tuple2 = UIHelper.ExtractIconAndTitle(item.Name.Substring(3));
					IList<CommonOperationItem> children = commonOperationItem.Children;
					CommonOperationItem obj = new CommonOperationItem
					{
						Title = tuple2.Item2,
						Data = item.Key,
						Description = tuple2.Item3
					};
					(obj.Icon, _, _) = tuple2;
					children.Add(obj);
					num3 = 1;
					if (n1TkrlQAaMADLDEW4ZY4 != null)
					{
						continue;
					}
				}
				else
				{
					commonOperationItem = null;
					(string, string, string) tuple4 = UIHelper.ExtractIconAndTitle(item.Name);
					IList<CommonOperationItem> children2 = customSearchResultItem.Children;
					CommonOperationItem obj2 = new CommonOperationItem
					{
						Title = tuple4.Item2,
						Data = item.Key,
						Description = tuple4.Item3
					};
					(obj2.Icon, _, _) = tuple4;
					children2.Add(obj2);
					num3 = 0;
					if (!SJxBYhQArP2g8AbmtpUo())
					{
						num3 = num4;
					}
				}
				switch (num3)
				{
				}
			}
			break;
		}
		case 1:
			try
			{
				while (enumerator.MoveNext())
				{
					CommonOperationItem current = enumerator.Current;
					customSearchResultItem.Children.Add(current);
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
			break;
		}
		goto IL_035f;
	}

	private static gNcjnN5ZX5ywtU0mFU6 dCwtN1oue0j(string string_0)
	{
		gNcjnN5ZX5ywtU0mFU6 gNcjnN5ZX5ywtU0mFU = new gNcjnN5ZX5ywtU0mFU6();
		gNcjnN5ZX5ywtU0mFU.Operation = "text";
		gNcjnN5ZX5ywtU0mFU.DataType = "";
		try
		{
			NameValueCollection nameValueCollection;
			Dictionary<string, object> dictionary;
			string[] allKeys;
			int num;
			if (string_0.Contains("operation="))
			{
				nameValueCollection = HttpUtility.ParseQueryString(string_0);
				dictionary = new Dictionary<string, object>();
				allKeys = nameValueCollection.AllKeys;
				num = 0;
				if (!SJxBYhQArP2g8AbmtpUo())
				{
					goto IL_008f;
				}
				goto IL_009a;
			}
			gNcjnN5ZX5ywtU0mFU.Data = string_0;
			goto end_IL_001f;
			IL_009a:
			string text = default(string);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					dictionary.Add(text.ToLower(), nameValueCollection[text]);
					num2++;
					break;
				default:
					num2 = 0;
					break;
				}
				if (num2 < allKeys.Length)
				{
					text = allKeys[num2];
					num = 1;
					if (n1TkrlQAaMADLDEW4ZY4 != null)
					{
						break;
					}
					continue;
				}
				if (dictionary.ContainsKey("operation"))
				{
					gNcjnN5ZX5ywtU0mFU.Operation = dictionary["operation"].ToString();
				}
				if (dictionary.ContainsKey("data"))
				{
					gNcjnN5ZX5ywtU0mFU.Data = dictionary["data"].ToString();
				}
				if (dictionary.ContainsKey("datatype"))
				{
					gNcjnN5ZX5ywtU0mFU.DataType = dictionary["datatype"].ToString().ToLower();
				}
				if (dictionary.ContainsKey("menu"))
				{
					gNcjnN5ZX5ywtU0mFU.Menu = dictionary["menu"].ToString();
				}
				if (dictionary.ContainsKey("nohide"))
				{
					gNcjnN5ZX5ywtU0mFU.IRcBZgcXoJ(dictionary["nohide"].ToString() == "1");
				}
				goto end_IL_001f;
			}
			goto IL_008f;
			IL_008f:
			int num3 = default(int);
			num = num3;
			goto IL_009a;
			end_IL_001f:;
		}
		catch (Exception)
		{
			gNcjnN5ZX5ywtU0mFU.Data = string_0;
		}
		return gNcjnN5ZX5ywtU0mFU;
	}

	public void oH2tNbRwEON(SearchWindow searchWindow_1, SearchResultItem searchResultItem_0)
	{
	}

	public string UOotN6gXydc(SearchResultItem searchResultItem_0)
	{
		if (searchResultItem_0.Tag != null && searchResultItem_0.Tag is CustomSearchResultItem customSearchResultItem)
		{
			return customSearchResultItem.Data;
		}
		if (!string.IsNullOrEmpty(searchResultItem_0.TextData))
		{
			return dCwtN1oue0j(searchResultItem_0.TextData).Data;
		}
		return string.Empty;
	}

	static iKTOkqWIMO3lqa4hFjM()
	{
		MBUtNK0tNoI = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static string MwUtNXHYG7w(string string_0, ref _003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_0_0)
	{
		if (!string.IsNullOrEmpty(string_0) && string_0.StartsWith("fa:", StringComparison.Ordinal) && !string_0.Contains(":#"))
		{
			return string_0 + ":" + _003C_003Ec__DisplayClass12_0_0.J1cvHLPbtKf;
		}
		return string_0;
	}

	internal static bool SJxBYhQArP2g8AbmtpUo()
	{
		return n1TkrlQAaMADLDEW4ZY4 == null;
	}
}
