using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BSpkSC2BMVITn7dofh0;
using EetOBeXoEKPaUQX04bS;
using EOqy55MyMeuU2apYyog;
using FontAwesome5;
using GEs2Jejr6IXgOTY0tM8;
using GuvA3OiyFyyWpKJlb8c;
using HMdjedXPwaug8yh9mEq;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Newtonsoft.Json;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Backup;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Domain.Entities;
using Quicker.Domain.Extensions;
using Quicker.Domain.Floating;
using Quicker.Domain.Hotkeys;
using Quicker.Domain.Messages;
using Quicker.Domain.Profiles;
using Quicker.Domain.SQL.Entities;
using Quicker.Modules.VersionUpdate;
using Quicker.Properties;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View;
using Quicker.View.Hotkeys;
using Quicker.View.Share;
using Quicker.View.UI;
using Quicker.View.X;
using SWBMfZYGyc6L9yHIvKQ;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.Domain.Services;

public class ActionEditMgr
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Ny9v5bO7g78;

		public static Func<SharedActionLocalRevisionItem, int> nMiv56plInr;

		private static _003C_003Ec z8nviNWFl2U0qi8HRLIw;

		static _003C_003Ec()
		{
			Ny9v5bO7g78 = new _003C_003Ec();
		}

		internal int TGsv51PAQKL(SharedActionLocalRevisionItem x)
		{
			return x.Revision;
		}

		internal static bool NOH2wDWFZ7GsdUWMmHWX()
		{
			return z8nviNWFl2U0qi8HRLIw == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public EditingActionInfo HT2v5m6hkqI;

		private static _003C_003Ec__DisplayClass20_0 Pf4QTLWFYvgc0DjaKbl1;

		internal bool EdHv5XkHYw6(EditingActionInfo x)
		{
			return x.ActionId == HT2v5m6hkqI.ActionId;
		}

		static _003C_003Ec__DisplayClass20_0()
		{
		}

		internal static bool ke2BhIWF84OLrDTroKmO()
		{
			return Pf4QTLWFYvgc0DjaKbl1 == null;
		}

		internal static void wcXgS9WFgM8ovjJQhnNx()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public ActionEditMgr YSbv5xaYNkS;

		public ActionItem shCv5rZ2Ej7;

		public bool Edav5p4loUB;

		public ActionItem SV2v5BbwEZ4;

		public EditingActionInfo arDv5QGrtPy;

		public string Brkv5jF2Cyo;

		public ActionProfile g9Tv5nj8IOE;

		public Action hekv54DHJdT;

		private static _003C_003Ec__DisplayClass21_0 eaH061WFPKj7NaibJIuw;

		internal void zQ6v5KDX8nE()
		{
			YSbv5xaYNkS.mTetrzZiEIl.BackupAction(SV2v5BbwEZ4, ActionBackupType.EditComplete);
		}

		internal static bool TZFgYFWFMgZbfTyScFuU()
		{
			return eaH061WFPKj7NaibJIuw == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_1
	{
		public SharedActionDto RoYv5DXQkYS;

		public _003C_003Ec__DisplayClass21_0 BYuv5dZ9wCv;

		internal static _003C_003Ec__DisplayClass21_1 cVUPKmWFxDXLCZNB0HLB;

		internal void Uufv55mRvdP()
		{
			RoYv5DXQkYS = BYuv5dZ9wCv.YSbv5xaYNkS.kB4tpwTmVen.Wott6D3Yp9F(Guid.Parse(BYuv5dZ9wCv.shCv5rZ2Ej7.TemplateId), BYuv5dZ9wCv.shCv5rZ2Ej7.TemplateRevision).GetAwaiter().GetResult();
		}

		internal static bool qJUCuOWFIk7sAVYNd7WW()
		{
			return cVUPKmWFxDXLCZNB0HLB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct kABsLjkANduOpm6Tlco : IAsyncStateMachine
		{
			public int pv12REQXfNP;

			public AsyncVoidMethodBuilder Tg42RyfvFfe;

			public _003C_003Ec__DisplayClass21_2 qVr2R8dMDUm;

			private _003C_003Ec__DisplayClass21_3 Xsa2Ra58Wnu;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter nj72R7ghviL;

			internal static object VhRn3MyuPjnMEIkDnRPr;

			private void MoveNext()
			{
				int num = pv12REQXfNP;
				_003C_003Ec__DisplayClass21_2 _003C_003Ec__DisplayClass21_ = qVr2R8dMDUm;
				try
				{
					if (num == 0 || (_003C_003Ec__DisplayClass21_.oNcv5TUGbdl.Result == true && !_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.Edav5p4loUB))
					{
						try
						{
							ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
							if (num != 0)
							{
								int num2 = 0;
								if (!qcXj9DyuMjVI56eWNJmP())
								{
									int num3 = default(int);
									num2 = num3;
								}
								ConfiguredTaskAwaitable configuredTaskAwaitable = default(ConfiguredTaskAwaitable);
								while (true)
								{
									switch (num2)
									{
									case 1:
										goto end_IL_00ec;
									case 3:
										goto IL_0215;
									case 2:
										goto IL_033c;
									}
									Xsa2Ra58Wnu = new _003C_003Ec__DisplayClass21_3();
									Xsa2Ra58Wnu.PGFv5UaB3bk = _003C_003Ec__DisplayClass21_;
									Xsa2Ra58Wnu.SiYv5FlvkKj = _003C_003Ec__DisplayClass21_.oNcv5TUGbdl.ResultActionItem;
									if (!AppHelper.IsEqualSerialized(Xsa2Ra58Wnu.SiYv5FlvkKj, _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.SV2v5BbwEZ4))
									{
										configuredTaskAwaitable = Task.Run(_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.hekv54DHJdT ?? (_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.hekv54DHJdT = _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.zQ6v5KDX8nE)).ConfigureAwait(true);
										num2 = 1;
										if (VhRn3MyuPjnMEIkDnRPr != null)
										{
											break;
										}
										continue;
									}
									goto IL_035e;
									continue;
									end_IL_00ec:
									break;
								}
								awaiter = configuredTaskAwaitable.GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									pv12REQXfNP = 0;
									nj72R7ghviL = awaiter;
									Tg42RyfvFfe.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = nj72R7ghviL;
								nj72R7ghviL = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
								num = -1;
								pv12REQXfNP = -1;
							}
							awaiter.GetResult();
							Xsa2Ra58Wnu.SiYv5FlvkKj.LastEditTimeUtc = AppHelper.GetUtcNowForDb();
							Xsa2Ra58Wnu.SiYv5FlvkKj.Row = _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.arDv5QGrtPy.Row;
							Xsa2Ra58Wnu.SiYv5FlvkKj.Col = _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.arDv5QGrtPy.Col;
							if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.Brkv5jF2Cyo) && string.Equals(_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.Brkv5jF2Cyo, Xsa2Ra58Wnu.SiYv5FlvkKj.Data))
							{
								Xsa2Ra58Wnu.SiYv5FlvkKj.UseTemplate = true;
								Xsa2Ra58Wnu.SiYv5FlvkKj.Data = "";
							}
							goto IL_0215;
							IL_035e:
							Xsa2Ra58Wnu = null;
							goto end_IL_003a;
							IL_033c:
							_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.YSbv5xaYNkS.Q1MtrjGPF2a(Xsa2Ra58Wnu.SiYv5FlvkKj, "编辑后保存");
							goto IL_035e;
							IL_0215:
							_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.YSbv5xaYNkS.SetButtonAction(_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.arDv5QGrtPy.Profile, _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.arDv5QGrtPy.Row, _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.arDv5QGrtPy.Col, Xsa2Ra58Wnu.SiYv5FlvkKj);
							if (_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.YSbv5xaYNkS.orltrlKx8rp.GetActionRunningCount(Xsa2Ra58Wnu.SiYv5FlvkKj.Id) > 0 && AppState.DataService.CpItmVISR7P().AfterEditRunningAction > 0)
							{
								if (AppState.DataService.CpItmVISR7P().AfterEditRunningAction == 1)
								{
									AppHelper.ShowInformation("动作 " + Xsa2Ra58Wnu.SiYv5FlvkKj.Title + " 已在运行，将自动停止此动作。\r\n点击本通知重启动作。", false, Xsa2Ra58Wnu.mTxv5AwIoJ4);
									_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.YSbv5xaYNkS.orltrlKx8rp.StopActionByIdOrName(Xsa2Ra58Wnu.SiYv5FlvkKj.Id, 0, true);
								}
								else if (AppState.DataService.CpItmVISR7P().AfterEditRunningAction == 2)
								{
									Task.Run((Action)Xsa2Ra58Wnu.zG8v5Oj6HWm);
								}
							}
							goto IL_033c;
							end_IL_003a:;
						}
						catch (Exception ex)
						{
							qiytpSkwiIN.Error(ex.Message, ex);
							AppHelper.ShowWarning("保存出错。" + ex.Message);
						}
					}
					_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.YSbv5xaYNkS.RyRtrQqS621(_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.arDv5QGrtPy);
					_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.YSbv5xaYNkS.Kfitrf6DTx6.NotifyActionEditComplete(_003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.YSbv5xaYNkS, _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.SV2v5BbwEZ4?.Id, _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.SV2v5BbwEZ4, _003C_003Ec__DisplayClass21_.yrbv5Mi0Ouj.g9Tv5nj8IOE);
					WsnAlhjCfHjoVZXu241 wsnAlhjCfHjoVZXu = AppState.vjAt7Seco0Y();
					if (wsnAlhjCfHjoVZXu == null)
					{
						if (qcXj9DyuMjVI56eWNJmP())
						{
							switch (0)
							{
							case 0:
								break;
							}
						}
					}
					else
					{
						wsnAlhjCfHjoVZXu.YyrtG5nkZFy(null);
					}
				}
				catch (Exception exception)
				{
					pv12REQXfNP = -2;
					Tg42RyfvFfe.SetException(exception);
					return;
				}
				pv12REQXfNP = -2;
				Tg42RyfvFfe.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Tg42RyfvFfe.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool qcXj9DyuMjVI56eWNJmP()
			{
				return VhRn3MyuPjnMEIkDnRPr == null;
			}
		}

		public ActionDesignerWindow oNcv5TUGbdl;

		public _003C_003Ec__DisplayClass21_0 yrbv5Mi0Ouj;

		private static _003C_003Ec__DisplayClass21_2 OiE6HfWFSaxJKwyBckVK;

		[AsyncStateMachine(typeof(kABsLjkANduOpm6Tlco))]
		internal void lxdv5o0FiVT(object sender, EventArgs e)
		{
			kABsLjkANduOpm6Tlco stateMachine = default(kABsLjkANduOpm6Tlco);
			stateMachine.Tg42RyfvFfe = AsyncVoidMethodBuilder.Create();
			stateMachine.qVr2R8dMDUm = this;
			stateMachine.pv12REQXfNP = -1;
			stateMachine.Tg42RyfvFfe.Start(ref stateMachine);
		}

		internal static bool cmIAyPWFwcSrFCScwVsS()
		{
			return OiE6HfWFSaxJKwyBckVK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_3
	{
		public ActionItem SiYv5FlvkKj;

		public _003C_003Ec__DisplayClass21_2 PGFv5UaB3bk;

		private static _003C_003Ec__DisplayClass21_3 sQObtiWFmsQ5WjGTGiYX;

		internal void mTxv5AwIoJ4()
		{
			PGFv5UaB3bk.yrbv5Mi0Ouj.YSbv5xaYNkS.orltrlKx8rp.ExecuteActionByIdOrName(SiYv5FlvkKj.Id, null, false, false, false, "", ActionTrigger.NA);
		}

		internal void zG8v5Oj6HWm()
		{
			PGFv5UaB3bk.yrbv5Mi0Ouj.YSbv5xaYNkS.orltrlKx8rp.StopActionByIdOrName(SiYv5FlvkKj.Id, 0, true);
			bool flag = false;
			for (int i = 0; i < 30; i++)
			{
				if (PGFv5UaB3bk.yrbv5Mi0Ouj.YSbv5xaYNkS.orltrlKx8rp.GetActionRunningCount(SiYv5FlvkKj.Id) != 0)
				{
					Thread.Sleep(100);
					continue;
				}
				flag = true;
				break;
			}
			if (flag)
			{
				PGFv5UaB3bk.yrbv5Mi0Ouj.YSbv5xaYNkS.orltrlKx8rp.ExecuteActionByIdOrName(SiYv5FlvkKj.Id, null, false, false, false, "", ActionTrigger.NA);
				AppHelper.ShowInformation("已重启动作 " + SiYv5FlvkKj.Title + "。");
				return;
			}
			AppHelper.ShowWarning("未能成功停止动作 " + SiYv5FlvkKj.Title + "，请手动停止和启动该动作。");
			int num = 0;
			if (sQObtiWFmsQ5WjGTGiYX != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}

		internal static bool s9o77PWFsKEdleOTpuQ9()
		{
			return sQObtiWFmsQ5WjGTGiYX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_4
	{
		public ActionEditorWindow qbRv5iMcNKo;

		public _003C_003Ec__DisplayClass21_0 u5Iv53JnV6M;

		internal static _003C_003Ec__DisplayClass21_4 elM4YRWF7uDpRcoSfZFv;

		internal void VJMv5lywCFO(object sender, EventArgs e)
		{
			try
			{
				if (qbRv5iMcNKo.Result == true)
				{
					ActionItem resultItem = qbRv5iMcNKo.ResultItem;
					if (!AppHelper.IsEqualSerialized(resultItem, u5Iv53JnV6M.SV2v5BbwEZ4))
					{
						resultItem.LastEditTimeUtc = AppHelper.GetUtcNowForDb();
						resultItem.Row = u5Iv53JnV6M.arDv5QGrtPy.Row;
						if (OU0DKrWF4UYT4JsdBEkc())
						{
							switch (0)
							{
							}
						}
						resultItem.Col = u5Iv53JnV6M.arDv5QGrtPy.Col;
						if (!resultItem.CreateTimeUtc.HasValue)
						{
							resultItem.CreateTimeUtc = AppHelper.GetUtcNowForDb();
						}
						u5Iv53JnV6M.YSbv5xaYNkS.SetButtonAction(u5Iv53JnV6M.arDv5QGrtPy.Profile, u5Iv53JnV6M.arDv5QGrtPy.Row, u5Iv53JnV6M.arDv5QGrtPy.Col, resultItem);
						u5Iv53JnV6M.YSbv5xaYNkS.Q1MtrjGPF2a(resultItem, "编辑后保存");
						AppState.vjAt7Seco0Y()?.YyrtG5nkZFy(null);
					}
				}
			}
			catch (Exception ex)
			{
				qiytpSkwiIN.Error(ex.Message, ex);
				AppHelper.ShowWarning("保存出错。" + ex.Message);
			}
			u5Iv53JnV6M.YSbv5xaYNkS.RyRtrQqS621(u5Iv53JnV6M.arDv5QGrtPy);
			u5Iv53JnV6M.YSbv5xaYNkS.Kfitrf6DTx6.NotifyActionEditComplete(u5Iv53JnV6M.YSbv5xaYNkS, u5Iv53JnV6M.SV2v5BbwEZ4?.Id, u5Iv53JnV6M.SV2v5BbwEZ4, u5Iv53JnV6M.g9Tv5nj8IOE);
		}

		internal static void dyUDAbWFHD1WgFBKa61B()
		{
		}

		internal static bool OU0DKrWF4UYT4JsdBEkc()
		{
			return elM4YRWF7uDpRcoSfZFv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct QSNX5mkw8bdixclPCVR : IAsyncStateMachine
		{
			public int FMo2RRtDSQv;

			public AsyncTaskMethodBuilder yNU2RqgMvxN;

			public _003C_003Ec__DisplayClass22_0 KN62RcbAg2g;

			private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter dbb2RV200LK;

			private static object Nt32AsyuCk7fOflZkgJu;

			private void MoveNext()
			{
				int num = FMo2RRtDSQv;
				_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = KN62RcbAg2g;
				try
				{
					try
					{
						ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = aFIptTXYsUoTUF4v33R.JEqt1cQCpi8(_003C_003Ec__DisplayClass22_.m0Sv5zT0toW, _003C_003Ec__DisplayClass22_.H4kvDwYw3Tq, DateTime.UtcNow.AddDays(_003C_003Ec__DisplayClass22_.rFdvDtwDtKh)).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								FMo2RRtDSQv = 0;
								dbb2RV200LK = awaiter;
								yNU2RqgMvxN.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = dbb2RV200LK;
							dbb2RV200LK = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
							int num2 = 0;
							if (!ab6OMOyu7iD39thbrQCh())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = -1;
							FMo2RRtDSQv = -1;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						qiytpSkwiIN.Warn("自动备份动作出错：" + exception.GetMessageWithInner());
					}
				}
				catch (Exception exception2)
				{
					FMo2RRtDSQv = -2;
					yNU2RqgMvxN.SetException(exception2);
					return;
				}
				FMo2RRtDSQv = -2;
				yNU2RqgMvxN.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				yNU2RqgMvxN.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool ab6OMOyu7iD39thbrQCh()
			{
				return Nt32AsyuCk7fOflZkgJu == null;
			}
		}

		public ActionItem m0Sv5zT0toW;

		public string H4kvDwYw3Tq;

		public int rFdvDtwDtKh;

		internal static _003C_003Ec__DisplayClass22_0 JHyPm7WFzlQwBUfkrOV6;

		[AsyncStateMachine(typeof(QSNX5mkw8bdixclPCVR))]
		internal Task wN1v5f1q70m()
		{
			QSNX5mkw8bdixclPCVR stateMachine = default(QSNX5mkw8bdixclPCVR);
			stateMachine.yNU2RqgMvxN = AsyncTaskMethodBuilder.Create();
			stateMachine.KN62RcbAg2g = this;
			stateMachine.FMo2RRtDSQv = -1;
			stateMachine.yNU2RqgMvxN.Start(ref stateMachine);
			return stateMachine.yNU2RqgMvxN.Task;
		}

		internal static void YNBr7MWcFtkGEu8R2Ga3()
		{
		}

		internal static bool u6o62LWcVlusTcAw77Dw()
		{
			return JHyPm7WFzlQwBUfkrOV6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public ActionItem YUUvDvXp1TH;

		public ActionEditMgr FW9vDSsln8P;

		internal static _003C_003Ec__DisplayClass23_0 AtlOkpWccNbhLQZtQmLe;

		internal bool TojvDgDRBud(EditingActionInfo x)
		{
			return x.ActionId == YUUvDvXp1TH.Id;
		}

		internal void NEHvDL3uPcG()
		{
			FW9vDSsln8P.mTetrzZiEIl.BackupAction(YUUvDvXp1TH, ActionBackupType.Deleting);
		}

		internal static bool Ax6yXJWcWwDjuLDk1RX1()
		{
			return AtlOkpWccNbhLQZtQmLe == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public ActionItem VOKvDJ5a6LU;

		public ShareActionWindow LqPvD0OIiyE;

		public ActionEditMgr IUcvDCK7pdx;

		public ActionProfile aJPvDPjNLUx;

		public Action eSIvDE8mfPb;

		internal static _003C_003Ec__DisplayClass26_0 wjj3ubWcp3GMJZXG5ACE;

		internal bool Ee9vD21jkhk(EditingActionInfo x)
		{
			return x.ActionId == VOKvDJ5a6LU.Id;
		}

		internal void YqevDuMsfZ0(object sender, EventArgs e)
		{
			if (LqPvD0OIiyE.NewSharedAction != null)
			{
				VOKvDJ5a6LU.SharedActionId = LqPvD0OIiyE.NewSharedAction.Id.ToString();
				VOKvDJ5a6LU.ShareTimeUtc = AppHelper.GetUtcNowForDb();
				if (string.IsNullOrEmpty(VOKvDJ5a6LU.Description) && !string.IsNullOrEmpty(LqPvD0OIiyE.NewSharedAction.Description))
				{
					VOKvDJ5a6LU.Description = LqPvD0OIiyE.NewSharedAction.Description;
				}
				IUcvDCK7pdx.orltrlKx8rp.SaveProfile(aJPvDPjNLUx, false);
				Task.Run(eSIvDE8mfPb ?? (eSIvDE8mfPb = sLXvDNIrrQf));
				int num = 0;
				if (wjj3ubWcp3GMJZXG5ACE != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}

		internal void sLXvDNIrrQf()
		{
			IUcvDCK7pdx.mTetrzZiEIl.BackupAction(VOKvDJ5a6LU, ActionBackupType.AfterShare);
			IUcvDCK7pdx.Q1MtrjGPF2a(VOKvDJ5a6LU, $"分享后备份,版本：{LqPvD0OIiyE.NewSharedAction.Revision}", 3000);
		}

		internal static bool x3l3FLWcXUdjgySZDjsZ()
		{
			return wjj3ubWcp3GMJZXG5ACE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public string wHsvD8Mpqww;

		public ActionEditMgr dDjvDaICn96;

		public ActionItem zn2vD7IfGjU;

		internal static _003C_003Ec__DisplayClass27_0 fakskXWceCNdWi5naOAC;

		internal bool SkYvDyaPv9Y(EditingActionInfo x)
		{
			return x.ActionId == wHsvD8Mpqww;
		}

		internal static bool T0Y0Q2WcjCH9ixbYQV30()
		{
			return fakskXWceCNdWi5naOAC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_1
	{
		public SharedActionDto u3OvDq3g76q;

		public _003C_003Ec__DisplayClass27_0 ttjvDcD7uv3;

		internal static _003C_003Ec__DisplayClass27_1 mPBIY5Wc3ietLWvSITN2;

		internal void hGWvDRTWTSw()
		{
			ttjvDcD7uv3.dDjvDaICn96.mTetrzZiEIl.BackupAction(ttjvDcD7uv3.zn2vD7IfGjU, ActionBackupType.AfterShare);
			ttjvDcD7uv3.dDjvDaICn96.Q1MtrjGPF2a(ttjvDcD7uv3.zn2vD7IfGjU, $"分享后备份,版本：{u3OvDq3g76q.Revision}", 3000);
		}

		internal static bool xGP1TTWcE9eEIAND0xDb()
		{
			return mPBIY5Wc3ietLWvSITN2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public ActionEditMgr L0GvDZ7HLCV;

		public SharedActionDto ATqvD9DmBTj;

		private static _003C_003Ec__DisplayClass29_0 Ic5sWLWc1CS6wlgFudqV;

		internal void BSVvDVrfy6C()
		{
			L0GvDZ7HLCV.kB4tpwTmVen.Gn9t6dsn2Bp(ATqvD9DmBTj);
		}

		static _003C_003Ec__DisplayClass29_0()
		{
		}

		internal static bool UCuoF2WcK7jm8Dn0tYSr()
		{
			return Ic5sWLWc1CS6wlgFudqV == null;
		}

		internal static void nUNtcdWcvKeWhnXgJQVL()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass32_0
	{
		public ActionItem aOqvDeDwD3K;

		internal static _003C_003Ec__DisplayClass32_0 UDXLfCWcdKYGRmfTFVKl;

		internal bool zUOvDhjoZWH(ActionHotKeyItem x)
		{
			return x.ActionId == aOqvDeDwD3K.Id;
		}

		internal static bool Oh8hI3WcOJdj66AYMqjw()
		{
			return UDXLfCWcdKYGRmfTFVKl == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct IGADixkWM7bDq93RmgI : IAsyncStateMachine
		{
			public int A9T2RZYCxLQ;

			public AsyncVoidMethodBuilder DFJ2R97MoqE;

			public _003C_003Ec__DisplayClass35_0 eDQ2Rhvl3r0;

			private _003C_003Ec__DisplayClass35_1 hTW2ReboR91;

			private ActionItem Nts2RYfkZ13;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter nEO2RID53Dd;

			private static object peHGWMyuhaxGtE5Q9d8G;

			private void MoveNext()
			{
				int num = A9T2RZYCxLQ;
				_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = eDQ2Rhvl3r0;
				try
				{
					if ((uint)num <= 1u || _003C_003Ec__DisplayClass35_.ovHvDWxbqS8.Result == true)
					{
						try
						{
							if (num == 0)
							{
								goto IL_013f;
							}
							int num2;
							ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
							if (num != 1)
							{
								Nts2RYfkZ13 = _003C_003Ec__DisplayClass35_.ovHvDWxbqS8.ResultActionItem;
								if (!AppHelper.IsEqualSerialized(Nts2RYfkZ13, _003C_003Ec__DisplayClass35_.fs8vDkNmU0x))
								{
									hTW2ReboR91 = new _003C_003Ec__DisplayClass35_1();
									hTW2ReboR91.N6HvDba9UkD = _003C_003Ec__DisplayClass35_;
									if (_003C_003Ec__DisplayClass35_.fs8vDkNmU0x == null)
									{
										goto IL_0164;
									}
									awaiter = Task.Run(_003C_003Ec__DisplayClass35_.F84vDsuuIX2 ?? (_003C_003Ec__DisplayClass35_.F84vDsuuIX2 = _003C_003Ec__DisplayClass35_.mqlvDIGJ06Z)).ConfigureAwait(true).GetAwaiter();
									if (awaiter.IsCompleted)
									{
										goto IL_015d;
									}
									num = 0;
									A9T2RZYCxLQ = 0;
									nEO2RID53Dd = awaiter;
									DFJ2R97MoqE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num2 = 1;
									if (peHGWMyuhaxGtE5Q9d8G != null)
									{
										int num3 = default(int);
										num2 = num3;
									}
									goto IL_0288;
								}
								AppHelper.ShowInformation("动作定义未改变，跳过保存。");
								goto IL_02b3;
							}
							awaiter = nEO2RID53Dd;
							nEO2RID53Dd = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
							num = -1;
							A9T2RZYCxLQ = -1;
							goto IL_02a5;
							IL_0164:
							Nts2RYfkZ13.LastEditTimeUtc = AppHelper.GetUtcNowForDb();
							hTW2ReboR91.Ca5vD1ajmN3 = SubProgramHelper.GetGlobalSubProgramFromWrapperAction(Nts2RYfkZ13);
							if (string.IsNullOrEmpty(hTW2ReboR91.Ca5vD1ajmN3.Id) || Guid.Parse(hTW2ReboR91.Ca5vD1ajmN3.Id) == Guid.Empty)
							{
								hTW2ReboR91.Ca5vD1ajmN3.Id = Guid.NewGuid().ToString();
							}
							Nts2RYfkZ13.Id = hTW2ReboR91.Ca5vD1ajmN3.Id;
							num2 = 0;
							if (SvjS0syuHf28at4dOBSm())
							{
								goto IL_0213;
							}
							goto IL_0288;
							IL_0213:
							_003C_003Ec__DisplayClass35_.b9ivDGvYwLY.Q1MtrjGPF2a(Nts2RYfkZ13, "【公共子程序】编辑后保存");
							awaiter = Task.Run((Action)hTW2ReboR91.xChvDHPf6Fn).ConfigureAwait(true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								A9T2RZYCxLQ = 1;
								nEO2RID53Dd = awaiter;
								DFJ2R97MoqE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num2 = 1;
								if (SvjS0syuHf28at4dOBSm())
								{
									return;
								}
								goto IL_0288;
							}
							goto IL_02a5;
							IL_02a5:
							awaiter.GetResult();
							hTW2ReboR91 = null;
							goto IL_02b3;
							IL_013f:
							awaiter = nEO2RID53Dd;
							nEO2RID53Dd = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
							num = -1;
							A9T2RZYCxLQ = -1;
							goto IL_015d;
							IL_0288:
							switch (num2)
							{
							case 3:
								break;
							default:
								goto IL_0213;
							case 1:
								return;
							case 2:
								return;
							}
							goto IL_013f;
							IL_015d:
							awaiter.GetResult();
							goto IL_0164;
							IL_02b3:
							Nts2RYfkZ13 = null;
						}
						catch (Exception ex)
						{
							qiytpSkwiIN.Error(ex.Message, ex);
							AppHelper.ShowWarning("保存出错。" + ex.Message);
						}
					}
				}
				catch (Exception exception)
				{
					A9T2RZYCxLQ = -2;
					DFJ2R97MoqE.SetException(exception);
					return;
				}
				A9T2RZYCxLQ = -2;
				DFJ2R97MoqE.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				DFJ2R97MoqE.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool SvjS0syuHf28at4dOBSm()
			{
				return peHGWMyuhaxGtE5Q9d8G == null;
			}
		}

		public ActionDesignerWindow ovHvDWxbqS8;

		public ActionItem fs8vDkNmU0x;

		public ActionEditMgr b9ivDGvYwLY;

		public Action F84vDsuuIX2;

		private static _003C_003Ec__DisplayClass35_0 TOPeeiWckIPCLtpMN4bY;

		[AsyncStateMachine(typeof(IGADixkWM7bDq93RmgI))]
		internal void Uk3vDYgNQYx(object sender, EventArgs e)
		{
			IGADixkWM7bDq93RmgI stateMachine = default(IGADixkWM7bDq93RmgI);
			stateMachine.DFJ2R97MoqE = AsyncVoidMethodBuilder.Create();
			stateMachine.eDQ2Rhvl3r0 = this;
			stateMachine.A9T2RZYCxLQ = -1;
			stateMachine.DFJ2R97MoqE.Start(ref stateMachine);
		}

		internal void mqlvDIGJ06Z()
		{
			b9ivDGvYwLY.mTetrzZiEIl.BackupAction(fs8vDkNmU0x, ActionBackupType.EditComplete);
		}

		internal static bool tSArNGWcaqyibpGiTK8G()
		{
			return TOPeeiWckIPCLtpMN4bY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_1
	{
		public SubProgram Ca5vD1ajmN3;

		public _003C_003Ec__DisplayClass35_0 N6HvDba9UkD;

		private static _003C_003Ec__DisplayClass35_1 NuI46UWcNkC4JOP2ZyJl;

		internal void xChvDHPf6Fn()
		{
			N6HvDba9UkD.b9ivDGvYwLY.kB4tpwTmVen.fgstXGxbg6P(Ca5vD1ajmN3);
		}

		internal static bool spp7kFWc9WHYf29ST9PK()
		{
			return NuI46UWcNkC4JOP2ZyJl == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public int knjvDXKv82y;

		public int M6ovDmdYuu9;

		private static _003C_003Ec__DisplayClass42_0 RAX1IWWcu5wWW3GfDIjw;

		internal bool gZMvD6XQW9Z(ActionItem x)
		{
			if (x.Row == knjvDXKv82y)
			{
				return x.Col == M6ovDmdYuu9;
			}
			return false;
		}

		internal static bool yEYwDdWco1u6MYPdbX1j()
		{
			return RAX1IWWcu5wWW3GfDIjw == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionEditMgr omXvDxaa92S;

		public ActionProfile ErNvDrayYdC;

		public ActionItemDragObject UjAvDpwwBBZ;

		public ActionItem CkfvDBEev0Y;

		public ActionProfile JqXvDQiZmfg;

		public int PGvvDjHZOrI;

		public int YtEvDnY9I77;

		private static _003C_003Ec__DisplayClass47_0 D3CbxgWcbZ5aoiXh5RlO;

		internal void cogvDKr7t9I()
		{
			omXvDxaa92S.SetButtonAction(ErNvDrayYdC, UjAvDpwwBBZ.Row, UjAvDpwwBBZ.Col, CkfvDBEev0Y, ErNvDrayYdC == JqXvDQiZmfg);
			omXvDxaa92S.SetButtonAction(JqXvDQiZmfg, PGvvDjHZOrI, YtEvDnY9I77, UjAvDpwwBBZ.Action);
		}

		internal static bool Cey0NpWcqO8UBphtckeA()
		{
			return D3CbxgWcbZ5aoiXh5RlO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass53_0
	{
		public Action<CommonOperationItem, object, ContextMenu> OFwvD4vG3xh;

		public ContextMenu NWrvD5JUm3u;

		private static _003C_003Ec__DisplayClass53_0 tpvUMHWclsaSPlLQucDY;

		internal static bool aTfIW6WcZPjIPEJ4VHjY()
		{
			return tpvUMHWclsaSPlLQucDY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass53_1
	{
		public CommonOperationItem YZjvDdwenKf;

		public _003C_003Ec__DisplayClass53_0 uL1vDowhsHs;

		internal static _003C_003Ec__DisplayClass53_1 uHXdVLWcYyWnbZNOEY30;

		internal void akxvDDayK5y(object sender, RoutedEventArgs e)
		{
			uL1vDowhsHs.OFwvD4vG3xh?.Invoke(YZjvDdwenKf, sender, uL1vDowhsHs.NWrvD5JUm3u);
		}

		internal static bool w5u3s9Wc8jw78iOws8Or()
		{
			return uHXdVLWcYyWnbZNOEY30 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public Action G6ovDMuDv8t;

		public ActionItem wiOvDAcBrLy;

		public PointTargetInfo NG3vDONmyiI;

		internal static _003C_003Ec__DisplayClass54_0 J0Etx9WcgvnIPdssctyO;

		internal void MgcvDT0Qcpy(CommonOperationItem op, object sender, ContextMenu menu)
		{
			G6ovDMuDv8t?.Invoke();
			AppState.HS2taepcAbc().RequestHide();
			AppState.Y2RtaqSv0AQ().NotifyRunAction(menu, wiOvDAcBrLy.Id, JrJWiKYIEBcPm8FFZOl.kBQLD2aG1Qb(), false, ActionTrigger.ContextMenu, false, NG3vDONmyiI, op.Data);
		}

		internal static bool u6cDP8WcP7TL4IUW4Xwj()
		{
			return J0Etx9WcgvnIPdssctyO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Ko8kSVk2SjmIUKWpMpu : IAsyncStateMachine
		{
			public int fcq2RWHnblo;

			public AsyncVoidMethodBuilder Vvr2RkW4aZu;

			public _003C_003Ec__DisplayClass57_0 Amb2RG1yM5d;

			private TaskAwaiter<bool> FBi2Rs8AUNn;

			private static object ph6bkPyoQqcq2OianlCx;

			private void MoveNext()
			{
				int num = fcq2RWHnblo;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = Amb2RG1yM5d;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass57_.mTAvdKmAvM2.InstallAction(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB, AppHelper.CreateSharedActionLink(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.TemplateId), _003C_003Ec__DisplayClass57_.VDxvdx9L8v4, _003C_003Ec__DisplayClass57_.gDtvdBaBq0w, _003C_003Ec__DisplayClass57_.py0vdQSLHa6, _003C_003Ec__DisplayClass57_.aq7vdXTvn14).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							fcq2RWHnblo = 0;
							FBi2Rs8AUNn = awaiter;
							Vvr2RkW4aZu.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							int num2 = 0;
							if (!hM2rEiyoFrQwTatxNEwR())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							return;
						}
					}
					else
					{
						awaiter = FBi2Rs8AUNn;
						FBi2Rs8AUNn = default(TaskAwaiter<bool>);
						num = -1;
						fcq2RWHnblo = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					fcq2RWHnblo = -2;
					Vvr2RkW4aZu.SetException(exception);
					return;
				}
				fcq2RWHnblo = -2;
				Vvr2RkW4aZu.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Vvr2RkW4aZu.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool hM2rEiyoFrQwTatxNEwR()
			{
				return ph6bkPyoQqcq2OianlCx == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct IekurMkjc8v3YDEmUV6 : IAsyncStateMachine
		{
			public int VMt2RHV2QTQ;

			public AsyncVoidMethodBuilder UnA2R1e5ZIR;

			public _003C_003Ec__DisplayClass57_0 w2d2RbtOF6V;

			private TaskAwaiter kYm2R6oH1YM;

			internal static object BZQdr0yoyE7KZhJ3gCU1;

			private void MoveNext()
			{
				int num = VMt2RHV2QTQ;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = w2d2RbtOF6V;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass57_.mTAvdKmAvM2.QyZtr4R8UOZ(_003C_003Ec__DisplayClass57_.Txavdmsj39W).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							VMt2RHV2QTQ = 0;
							kYm2R6oH1YM = awaiter;
							int num2 = 0;
							if (BZQdr0yoyE7KZhJ3gCU1 != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							UnA2R1e5ZIR.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = kYm2R6oH1YM;
						kYm2R6oH1YM = default(TaskAwaiter);
						num = -1;
						VMt2RHV2QTQ = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					VMt2RHV2QTQ = -2;
					UnA2R1e5ZIR.SetException(exception);
					return;
				}
				VMt2RHV2QTQ = -2;
				UnA2R1e5ZIR.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				UnA2R1e5ZIR.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool OaYu1YyopNS8H7eDbQN8()
			{
				return BZQdr0yoyE7KZhJ3gCU1 == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct sZQhmwkX4ACakpPOMvM : IAsyncStateMachine
		{
			public int wS42RX3bPU7;

			public AsyncVoidMethodBuilder txs2RmhL12s;

			public _003C_003Ec__DisplayClass57_0 xiE2RKAOfMW;

			internal static object TJ0xbKyoAGJrjXIbQmEM;

			private void MoveNext()
			{
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = xiE2RKAOfMW;
				try
				{
					AppState.AppServer.StopActionByIdOrName(_003C_003Ec__DisplayClass57_.Txavdmsj39W.Id, 0, false);
				}
				catch (Exception exception)
				{
					wS42RX3bPU7 = -2;
					txs2RmhL12s.SetException(exception);
					return;
				}
				wS42RX3bPU7 = -2;
				txs2RmhL12s.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				txs2RmhL12s.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool CgnFU0yonwZma7uJxtEM()
			{
				return TJ0xbKyoAGJrjXIbQmEM == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct Fm1h5mkowvlyY1Aj81T : IAsyncStateMachine
		{
			public int T5d2RxXpiNE;

			public AsyncVoidMethodBuilder n3w2RrNCsWp;

			public _003C_003Ec__DisplayClass57_0 vMI2RpKLRoQ;

			private TaskAwaiter<bool> gIE2RBf9REU;

			internal static object jvuldgyoj3UFLdOjoxuf;

			private void MoveNext()
			{
				int num = T5d2RxXpiNE;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = vMI2RpKLRoQ;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass57_.mTAvdKmAvM2.InstallAction(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB, AppHelper.CreateSharedActionLink(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.TemplateId), _003C_003Ec__DisplayClass57_.VDxvdx9L8v4, _003C_003Ec__DisplayClass57_.gDtvdBaBq0w, _003C_003Ec__DisplayClass57_.py0vdQSLHa6, _003C_003Ec__DisplayClass57_.aq7vdXTvn14).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							T5d2RxXpiNE = 0;
							gIE2RBf9REU = awaiter;
							n3w2RrNCsWp.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = gIE2RBf9REU;
						int num2 = 0;
						if (jvuldgyoj3UFLdOjoxuf != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						gIE2RBf9REU = default(TaskAwaiter<bool>);
						num = -1;
						T5d2RxXpiNE = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					T5d2RxXpiNE = -2;
					n3w2RrNCsWp.SetException(exception);
					return;
				}
				T5d2RxXpiNE = -2;
				n3w2RrNCsWp.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				n3w2RrNCsWp.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool hw5c0LyoDF9hgyuSZ9BL()
			{
				return jvuldgyoj3UFLdOjoxuf == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct Bv8n0PkY53Hbgrpnf9y : IAsyncStateMachine
		{
			public int lEW2RQGGQuC;

			public AsyncVoidMethodBuilder RYa2RjnEE2b;

			public _003C_003Ec__DisplayClass57_0 Cr02RnFmArH;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter ECF2R4pCBxq;

			internal static object gcshhwyoETey8k8dUQ3M;

			private void MoveNext()
			{
				int num = lEW2RQGGQuC;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = Cr02RnFmArH;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						AppState.HS2taepcAbc().RequestHide();
						awaiter = _003C_003Ec__DisplayClass57_.mTAvdKmAvM2.kB4tpwTmVen.WKAtXmLkFkM(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB, false, null).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							if (gcshhwyoETey8k8dUQ3M != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = 0;
							lEW2RQGGQuC = 0;
							ECF2R4pCBxq = awaiter;
							RYa2RjnEE2b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = ECF2R4pCBxq;
						ECF2R4pCBxq = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						lEW2RQGGQuC = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					lEW2RQGGQuC = -2;
					RYa2RjnEE2b.SetException(exception);
					return;
				}
				lEW2RQGGQuC = -2;
				RYa2RjnEE2b.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				RYa2RjnEE2b.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool uPv556yoGZwSYgxPX3JY()
			{
				return gcshhwyoETey8k8dUQ3M == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct zDqffDkMCjeu9WhpdnU : IAsyncStateMachine
		{
			public int OaB2R5vnTd4;

			public AsyncVoidMethodBuilder W4d2RDK8XXd;

			public _003C_003Ec__DisplayClass57_0 WCv2Rd4i5fZ;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter KOG2RoXDias;

			internal static object wL0rhuyo1kBXmZP9p8Io;

			private void MoveNext()
			{
				int num = OaB2R5vnTd4;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = WCv2Rd4i5fZ;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					int num2;
					if (num != 0)
					{
						if (!AppState.AppServer.IsActionRunning(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
						{
							goto IL_00d9;
						}
						AppState.AppServer.StopActionByIdOrName(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id, 0, true);
						awaiter = Task.Delay(250).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = 0;
							if (!qXb1HbyoK0gP7iRbej1v())
							{
								goto IL_00a2;
							}
							goto IL_0103;
						}
					}
					else
					{
						awaiter = KOG2RoXDias;
						KOG2RoXDias = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						OaB2R5vnTd4 = -1;
						num2 = 0;
						if (qXb1HbyoK0gP7iRbej1v())
						{
							goto IL_00a2;
						}
					}
					goto IL_00af;
					IL_00af:
					awaiter.GetResult();
					if (!AppState.AppServer.IsActionRunning(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
					{
						AppHelper.ShowInformation("已自动停止动作。");
						goto IL_00d9;
					}
					AppHelper.ShowWarning("动作正在运行中，请先停止动作后再删除数据。");
					goto end_IL_000e;
					IL_00a2:
					switch (num2)
					{
					case 1:
						goto IL_0103;
					}
					goto IL_00af;
					IL_0103:
					num = 0;
					OaB2R5vnTd4 = 0;
					KOG2RoXDias = awaiter;
					W4d2RDK8XXd.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
					IL_00d9:
					ActionStateWriter.ResetPanelState(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id);
					AppHelper.ShowSuccess("已重置操作窗状态。");
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					OaB2R5vnTd4 = -2;
					W4d2RDK8XXd.SetException(exception);
					return;
				}
				OaB2R5vnTd4 = -2;
				W4d2RDK8XXd.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				W4d2RDK8XXd.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool qXb1HbyoK0gP7iRbej1v()
			{
				return wL0rhuyo1kBXmZP9p8Io == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct FHXnvckfNN6xCuYNyhl : IAsyncStateMachine
		{
			public int zMV2RTkUOaL;

			public AsyncVoidMethodBuilder Jan2RMghsKT;

			public _003C_003Ec__DisplayClass57_0 Cl62RA9lkJj;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter vdf2ROPMjoO;

			private static object rT6s6Jyodh7NVeD6rfNq;

			private void MoveNext()
			{
				int num = zMV2RTkUOaL;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = Cl62RA9lkJj;
				try
				{
        ConfiguredTaskAwaitable configuredTaskAwaitable = default;
					ModifierKeys modifierKeys;
					int num2;
					if (num != 0)
					{
						modifierKeys = JrJWiKYIEBcPm8FFZOl.Modifiers;
						num2 = 0;
						if (!JBewtnyoO9EEQeCF32AW())
						{
							goto IL_002b;
						}
						goto IL_0086;
					}
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = vdf2ROPMjoO;
					vdf2ROPMjoO = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					zMV2RTkUOaL = -1;
					goto IL_0112;
					IL_0112:
					awaiter.GetResult();
					if (!AppState.AppServer.IsActionRunning(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
					{
						AppHelper.ShowInformation("已自动停止动作。");
						goto IL_014a;
					}
					AppHelper.ShowWarning("动作正在运行中，请先停止动作后再删除数据。");
					goto end_IL_0010;
					IL_0086:
					switch (num2)
					{
					case 1:
						goto IL_00bd;
					}
					goto IL_002b;
					IL_002b:
					configuredTaskAwaitable = default(ConfiguredTaskAwaitable);
					if (modifierKeys == ModifierKeys.None)
					{
						if (AppState.AppServer.IsActionRunning(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
						{
							AppState.AppServer.StopActionByIdOrName(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id, 0, true);
							configuredTaskAwaitable = Task.Delay(250).ConfigureAwait(true);
							num2 = 1;
							if (rT6s6Jyodh7NVeD6rfNq != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							goto IL_0086;
						}
						goto IL_014a;
					}
					if (modifierKeys == ModifierKeys.Shift)
					{
						ActionStateWriter.OpenStateFile(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id);
						AppState.HS2taepcAbc().RequestHide();
					}
					goto end_IL_0010;
					IL_00bd:
					awaiter = configuredTaskAwaitable.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						zMV2RTkUOaL = 0;
						vdf2ROPMjoO = awaiter;
						Jan2RMghsKT.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0112;
					IL_014a:
					ActionStateWriter.DeleteStateFile(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id);
					_003C_003Ec__DisplayClass57_.mTAvdKmAvM2.kB4tpwTmVen.h9YtXkxrfZH(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id);
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					zMV2RTkUOaL = -2;
					Jan2RMghsKT.SetException(exception);
					return;
				}
				zMV2RTkUOaL = -2;
				Jan2RMghsKT.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Jan2RMghsKT.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool JBewtnyoO9EEQeCF32AW()
			{
				return rT6s6Jyodh7NVeD6rfNq == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct PLR71Ck6f7OXBF1TO0B : IAsyncStateMachine
		{
			public int FdZ2RFDOlRc;

			public AsyncVoidMethodBuilder V5B2RU7rLeT;

			public _003C_003Ec__DisplayClass57_0 SCc2Rl0mW76;

			private static object xA95VUyoriZvDBwC2Na7;

			private void MoveNext()
			{
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = SCc2Rl0mW76;
				try
				{
					AppState.HS2taepcAbc().RequestHide();
					string text = ActionStateWriter.fb2gP1gvJ8p(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id);
					if (File.Exists(text))
					{
						AppHelper.SelectFileInExplorer(text, false);
					}
					else
					{
						AppHelper.ShowWarning("未找到状态文件：" + text);
					}
				}
				catch (Exception exception)
				{
					FdZ2RFDOlRc = -2;
					V5B2RU7rLeT.SetException(exception);
					return;
				}
				FdZ2RFDOlRc = -2;
				V5B2RU7rLeT.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				V5B2RU7rLeT.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool U0lmAQyoN7VWN5KrS2ht()
			{
				return xA95VUyoriZvDBwC2Na7 == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct DoEraVk7Db9kwJabfAC : IAsyncStateMachine
		{
			public int Bkv2Riud1ms;

			public AsyncVoidMethodBuilder OXJ2R3xDAse;

			public _003C_003Ec__DisplayClass57_0 oJJ2Rf7DF03;

			private UserInputWindow Wx72Rz2Scl5;

			private TaskAwaiter<bool?> crJ2qwFpMtY;

			private TaskAwaiter<(bool isSuccess, string message)> xNl2qtsAqF8;

			private static object YkeZufyouKxmNSDMCx32;

			private void MoveNext()
			{
				int num = Bkv2Riud1ms;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = oJJ2Rf7DF03;
				try
				{
					if ((uint)num <= 1u)
					{
						goto IL_0043;
					}
					if (_003C_003Ec__DisplayClass57_.mTAvdKmAvM2.kB4tpwTmVen.Hb9tmk3OsJ7())
					{
						AppState.HS2taepcAbc().RequestHide();
						goto IL_0043;
					}
					AppHelper.ShowWarning("本功能需要专业版。");
					goto end_IL_0010;
					IL_0043:
					try
					{
						TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
						int num2;
						TaskAwaiter<(bool, string)> awaiter2;
						if (num != 0)
						{
							if (num != 1)
							{
								Wx72Rz2Scl5 = new UserInputWindow("text", "请输入备份说明", "", "")
								{
									Title = "备份动作数据"
								};
								awaiter = Wx72Rz2Scl5.MjdLOXIjD10(true).GetAwaiter();
								num2 = 2;
								if (!zjusR6yooG2lid67P4pv())
								{
									goto IL_015b;
								}
								goto IL_015f;
							}
							awaiter2 = xNl2qtsAqF8;
							xNl2qtsAqF8 = default(TaskAwaiter<(bool, string)>);
							num = -1;
							Bkv2Riud1ms = -1;
							goto IL_010d;
						}
						awaiter = crJ2qwFpMtY;
						crJ2qwFpMtY = default(TaskAwaiter<bool?>);
						num = -1;
						Bkv2Riud1ms = -1;
						goto IL_0172;
						IL_01dc:
						Wx72Rz2Scl5 = null;
						goto end_IL_0043;
						IL_015f:
						while (true)
						{
							switch (num2)
							{
							case 2:
								break;
							default:
								return;
							case 0:
								return;
							case 1:
								goto end_IL_015f;
							}
							if (!awaiter.IsCompleted)
							{
								num = 0;
								Bkv2Riud1ms = 0;
								crJ2qwFpMtY = awaiter;
								OXJ2R3xDAse.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num2 = 0;
								if (YkeZufyouKxmNSDMCx32 == null)
								{
									continue;
								}
								goto IL_015b;
							}
							goto IL_0172;
							continue;
							end_IL_015f:
							break;
						}
						(bool, string) result = default((bool, string));
						if (result.Item1)
						{
							AppHelper.ShowSuccess("备份成功！");
						}
						else
						{
							AppHelper.ShowWarning("备份失败：" + result.Item2);
						}
						goto IL_01dc;
						IL_010d:
						result = awaiter2.GetResult();
						num2 = 1;
						if (YkeZufyouKxmNSDMCx32 != null)
						{
							goto IL_015b;
						}
						goto IL_015f;
						IL_0172:
						if (awaiter.GetResult() == true)
						{
							awaiter2 = ActionStateWriter.EgmgPBaUk5t(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id, Wx72Rz2Scl5.TextValue).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								Bkv2Riud1ms = 1;
								xNl2qtsAqF8 = awaiter2;
								OXJ2R3xDAse.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_010d;
						}
						goto IL_01dc;
						IL_015b:
						int num3 = default(int);
						num2 = num3;
						goto IL_015f;
						end_IL_0043:;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("备份异常：" + ex.Message);
					}
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					Bkv2Riud1ms = -2;
					OXJ2R3xDAse.SetException(exception);
					return;
				}
				Bkv2Riud1ms = -2;
				OXJ2R3xDAse.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				OXJ2R3xDAse.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool zjusR6yooG2lid67P4pv()
			{
				return YkeZufyouKxmNSDMCx32 == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct KvW4tOkil1FBkx3uTXQ : IAsyncStateMachine
		{
			public int Jbn2qg1wYWW;

			public AsyncVoidMethodBuilder TYl2qLTFKam;

			public _003C_003Ec__DisplayClass57_0 now2qvECk51;

			private DownloadBackupWindow T272qS47T8M;

			private TaskAwaiter<bool?> Itw2q2CJFAT;

			internal static object cq4QK2yoiLDwvaQfmDtN;

			private void MoveNext()
			{
				int num = Jbn2qg1wYWW;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = now2qvECk51;
				try
				{
					int num2;
					if (num == 0)
					{
						num2 = 0;
						if (Uj8XDGyolKaAFbPUTghb())
						{
							goto IL_007c;
						}
						goto IL_0089;
					}
					if (!AppState.AppServer.IsActionRunning(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
					{
						AppState.HS2taepcAbc().RequestHide();
						T272qS47T8M = new DownloadBackupWindow(UserObjectType.ActionState, _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id, "下载状态备份");
						num2 = 1;
						if (cq4QK2yoiLDwvaQfmDtN == null)
						{
							goto IL_007c;
						}
						goto IL_0089;
					}
					AppHelper.ShowWarning("动作正在运行，请先关闭动作后再恢复数据。");
					goto end_IL_000e;
					IL_00a7:
					TaskAwaiter<bool?> awaiter = T272qS47T8M.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						Jbn2qg1wYWW = 0;
						Itw2q2CJFAT = awaiter;
						TYl2qLTFKam.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00e2;
					IL_0089:
					awaiter = Itw2q2CJFAT;
					Itw2q2CJFAT = default(TaskAwaiter<bool?>);
					num = -1;
					Jbn2qg1wYWW = -1;
					goto IL_00e2;
					IL_00e2:
					if (awaiter.GetResult() == true)
					{
						BackupItemDetailDto backupItem = T272qS47T8M.BackupItem;
						ActionStateWriter.t53gPQ4YJjh(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id, backupItem);
						AppHelper.ShowSuccess("恢复成功！");
					}
					goto end_IL_000e;
					IL_007c:
					switch (num2)
					{
					case 1:
						goto IL_00a7;
					}
					goto IL_0089;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					Jbn2qg1wYWW = -2;
					T272qS47T8M = null;
					TYl2qLTFKam.SetException(exception);
					return;
				}
				Jbn2qg1wYWW = -2;
				T272qS47T8M = null;
				TYl2qLTFKam.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				TYl2qLTFKam.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Uj8XDGyolKaAFbPUTghb()
			{
				return cq4QK2yoiLDwvaQfmDtN == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct NCMsYwkmKlJIXwqsENw : IAsyncStateMachine
		{
			public int qhx2qugoboF;

			public AsyncTaskMethodBuilder KeH2qNeVfOT;

			public _003C_003Ec__DisplayClass57_0 bhN2qJjl8QL;

			private TaskAwaiter vtr2q0EeISo;

			private static object KqDfX3yo5qb3XNTC2Jj0;

			private void MoveNext()
			{
				int num = qhx2qugoboF;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = bhN2qJjl8QL;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(250).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							qhx2qugoboF = 0;
							vtr2q0EeISo = awaiter;
							KeH2qNeVfOT.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = vtr2q0EeISo;
						if (KqDfX3yo5qb3XNTC2Jj0 != null)
						{
							switch (0)
							{
							}
						}
						vtr2q0EeISo = default(TaskAwaiter);
						num = -1;
						qhx2qugoboF = -1;
					}
					awaiter.GetResult();
					AppState.AppServer.RequestSwitchProfile(_003C_003Ec__DisplayClass57_.VDxvdx9L8v4.Id, false);
				}
				catch (Exception exception)
				{
					qhx2qugoboF = -2;
					KeH2qNeVfOT.SetException(exception);
					return;
				}
				qhx2qugoboF = -2;
				KeH2qNeVfOT.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				KeH2qNeVfOT.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool t1h9C3yoYD7Onat7BqEB()
			{
				return KqDfX3yo5qb3XNTC2Jj0 == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct q70xLwkdTqv2aYQHgZg : IAsyncStateMachine
		{
			public int xU92qClPfCh;

			public AsyncVoidMethodBuilder WQY2qPic0PK;

			public _003C_003Ec__DisplayClass57_0 ERg2qEdJOFp;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter m6s2qyyshYV;

			internal static object EQopShyoRjGhfuICg8DW;

			private void MoveNext()
			{
				int num = xU92qClPfCh;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = ERg2qEdJOFp;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						ConfiguredTaskAwaitable<bool> configuredTaskAwaitable = _003C_003Ec__DisplayClass57_.mTAvdKmAvM2.DeleteAction(_003C_003Ec__DisplayClass57_.VDxvdx9L8v4, _003C_003Ec__DisplayClass57_.FXyvdpLR6nB, true, false).ConfigureAwait(true);
						int num2 = 0;
						if (!h1q36uyoglfj8lGXNlEx())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						awaiter = configuredTaskAwaitable.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							xU92qClPfCh = 0;
							m6s2qyyshYV = awaiter;
							WQY2qPic0PK.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = m6s2qyyshYV;
						m6s2qyyshYV = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = -1;
						xU92qClPfCh = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					xU92qClPfCh = -2;
					WQY2qPic0PK.SetException(exception);
					return;
				}
				xU92qClPfCh = -2;
				WQY2qPic0PK.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				WQY2qPic0PK.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool h1q36uyoglfj8lGXNlEx()
			{
				return EQopShyoRjGhfuICg8DW == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct o28RREkuQ0n00ONNqAF : IAsyncStateMachine
		{
			public int b5Z2q8sC2k2;

			public AsyncVoidMethodBuilder Ril2qacmW75;

			public _003C_003Ec__DisplayClass57_0 nkt2q7sY5xa;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter UvH2qRfNRXf;

			internal static object kLsfq8yoMrMZe2CSINgC;

			private void MoveNext()
			{
				int num = b5Z2q8sC2k2;
				_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = nkt2q7sY5xa;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass57_.mTAvdKmAvM2.PasteIconAsync(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB, _003C_003Ec__DisplayClass57_.VDxvdx9L8v4).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							b5Z2q8sC2k2 = 0;
							UvH2qRfNRXf = awaiter;
							Ril2qacmW75.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = UvH2qRfNRXf;
						UvH2qRfNRXf = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = -1;
						b5Z2q8sC2k2 = -1;
					}
					awaiter.GetResult();
					if (kLsfq8yoMrMZe2CSINgC != null)
					{
						switch (0)
						{
						}
					}
				}
				catch (Exception exception)
				{
					b5Z2q8sC2k2 = -2;
					Ril2qacmW75.SetException(exception);
					return;
				}
				b5Z2q8sC2k2 = -2;
				Ril2qacmW75.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Ril2qacmW75.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool DVdSChyoUWqLV5cEhtlr()
			{
				return kLsfq8yoMrMZe2CSINgC == null;
			}
		}

		public bool kNBvd69n8jh;

		public Window aq7vdXTvn14;

		public ActionItem Txavdmsj39W;

		public ActionEditMgr mTAvdKmAvM2;

		public ActionProfile VDxvdx9L8v4;

		public ActionProfile btMvdre638y;

		public ActionItem FXyvdpLR6nB;

		public int gDtvdBaBq0w;

		public int py0vdQSLHa6;

		public bool UgJvdjPZMD7;

		public ContextMenu tGZvdn3Q4XR;

		public bool PSivd43uisT;

		public ActionTrigger z6Fvd5rhhSr;

		public PointTargetInfo OFSvdDPK3Ad;

		public Func<Task> mmJvdd4ojc2;

		internal static _003C_003Ec__DisplayClass57_0 vy2vE9WcUc5hc9pOKwCt;

		internal void HolvDFH348u()
		{
			if (kNBvd69n8jh)
			{
				(aq7vdXTvn14 as SearchWindow)?.RequestHide();
			}
		}

		[AsyncStateMachine(typeof(sZQhmwkX4ACakpPOMvM))]
		internal void uP9vDUHjrm3(object sender, RoutedEventArgs e)
		{
			sZQhmwkX4ACakpPOMvM stateMachine = default(sZQhmwkX4ACakpPOMvM);
			stateMachine.txs2RmhL12s = AsyncVoidMethodBuilder.Create();
			stateMachine.xiE2RKAOfMW = this;
			stateMachine.wS42RX3bPU7 = -1;
			stateMachine.txs2RmhL12s.Start(ref stateMachine);
		}

		internal void UPyvDlqitT7(object sender, RoutedEventArgs e)
		{
			mTAvdKmAvM2.FloatAction(Txavdmsj39W, aq7vdXTvn14);
		}

		internal void ajGvDiSiSVr(object sender, RoutedEventArgs e)
		{
			if (mTAvdKmAvM2.kB4tpwTmVen.hfGtbAvJrRQ(true))
			{
				FloatPanelWindow floatPanelWindow = new FloatPanelWindow(VDxvdx9L8v4, null, mTAvdKmAvM2.orltrlKx8rp, mTAvdKmAvM2.Kfitrf6DTx6, mTAvdKmAvM2, mTAvdKmAvM2.kB4tpwTmVen, mTAvdKmAvM2.mNttpLTwBmW, null, (aq7vdXTvn14 is SearchWindow searchWindow) ? searchWindow.ActiveProcessBeforeShow : null);
				floatPanelWindow.Show();
				IHNRIiikxBwJdYmHpM3.p1AvvooEqum(floatPanelWindow, ShowWindowLocation.WithMouse1);
				AppState.HS2taepcAbc().RequestHide();
			}
		}

		internal void dLLvD3iX8sf(object sender, RoutedEventArgs e)
		{
			if (mTAvdKmAvM2.kB4tpwTmVen.Hb9tmk3OsJ7())
			{
				mTAvdKmAvM2.qoYtpv5p7Bo.AddProfile(VDxvdx9L8v4);
			}
			else
			{
				AppHelper.ShowVersionLimitInfo(null, "了解 “添加到文本悬浮窗” 功能", "https://getquicker.net/KC/Help/Doc/text-select-float-panel");
			}
		}

		internal void o2GvDfeqRMZ(object sender, RoutedEventArgs e)
		{
			mTAvdKmAvM2.ShareAction(Txavdmsj39W, btMvdre638y, aq7vdXTvn14);
		}

		internal void bTdvDzpx7Hf(object sender, RoutedEventArgs e)
		{
			if (JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Control)
			{
				ClipboardHelper.SetText(AppHelper.CreateSharedActionLink(Txavdmsj39W.SharedActionId));
				AppHelper.ShowSuccess("已复制。");
			}
			else
			{
				AppHelper.ttpLTxjOp3r(Txavdmsj39W);
			}
			AppState.HS2taepcAbc().RequestHide();
		}

		internal void swPvdwHrir9(object sender, RoutedEventArgs e)
		{
			ClipboardHelper.SetText(AppHelper.CreateSharedActionLink(Txavdmsj39W.SharedActionId));
			AppHelper.ShowSuccess("已复制。");
			AppState.HS2taepcAbc().RequestHide();
		}

		internal void zvmvdtKaI7P(object sender, RoutedEventArgs e)
		{
			mTAvdKmAvM2.ShareAction(Txavdmsj39W, btMvdre638y, aq7vdXTvn14);
		}

		internal void DKbvdgSsmMY(object sender, RoutedEventArgs e)
		{
			AppHelper.OpenSourceSharedActionUrl(Txavdmsj39W);
			AppState.HS2taepcAbc().RequestHide();
		}

		[AsyncStateMachine(typeof(Ko8kSVk2SjmIUKWpMpu))]
		internal void RCFvdLkWljV(object sender, RoutedEventArgs e)
		{
			Ko8kSVk2SjmIUKWpMpu stateMachine = default(Ko8kSVk2SjmIUKWpMpu);
			stateMachine.Vvr2RkW4aZu = AsyncVoidMethodBuilder.Create();
			stateMachine.Amb2RG1yM5d = this;
			stateMachine.fcq2RWHnblo = -1;
			stateMachine.Vvr2RkW4aZu.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(IekurMkjc8v3YDEmUV6))]
		internal void xtnvdvFCw0u(object sender, RoutedEventArgs e)
		{
			IekurMkjc8v3YDEmUV6 stateMachine = default(IekurMkjc8v3YDEmUV6);
			stateMachine.UnA2R1e5ZIR = AsyncVoidMethodBuilder.Create();
			stateMachine.w2d2RbtOF6V = this;
			stateMachine.VMt2RHV2QTQ = -1;
			stateMachine.UnA2R1e5ZIR.Start(ref stateMachine);
		}

		internal void E2BvdSKs4KA(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().RequestHide();
			AppHelper.OpenSourceSharedActionFeedbackUrl(Txavdmsj39W);
		}

		internal void zu4vd2UFq2T(object sender, RoutedEventArgs e)
		{
			AppHelper.CopyActionSourceUrl(Txavdmsj39W);
		}

		[AsyncStateMachine(typeof(Fm1h5mkowvlyY1Aj81T))]
		internal void CtKvduUxeLb(object sender, RoutedEventArgs e)
		{
			Fm1h5mkowvlyY1Aj81T stateMachine = default(Fm1h5mkowvlyY1Aj81T);
			stateMachine.n3w2RrNCsWp = AsyncVoidMethodBuilder.Create();
			stateMachine.vMI2RpKLRoQ = this;
			stateMachine.T5d2RxXpiNE = -1;
			stateMachine.n3w2RrNCsWp.Start(ref stateMachine);
		}

		internal void Gv2vdNTnFUW(object sender, RoutedEventArgs e)
		{
			if (JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Control)
			{
				CopyActionAndId(FXyvdpLR6nB);
			}
			else
			{
				CopyAction(FXyvdpLR6nB);
			}
		}

		internal void NNAvdJqUwh4(object sender, RoutedEventArgs e)
		{
			HolvDFH348u();
			CopyAction(FXyvdpLR6nB);
			AppState.CuttingAction = FXyvdpLR6nB;
			AppState.CuttingActionProfile = VDxvdx9L8v4;
		}

		[AsyncStateMachine(typeof(q70xLwkdTqv2aYQHgZg))]
		internal void GHyvd0n60CG(object sender, RoutedEventArgs e)
		{
			q70xLwkdTqv2aYQHgZg stateMachine = default(q70xLwkdTqv2aYQHgZg);
			stateMachine.WQY2qPic0PK = AsyncVoidMethodBuilder.Create();
			stateMachine.ERg2qEdJOFp = this;
			stateMachine.xU92qClPfCh = -1;
			stateMachine.WQY2qPic0PK.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(o28RREkuQ0n00ONNqAF))]
		internal void sxQvdC2B1aa(object sender, RoutedEventArgs e)
		{
			o28RREkuQ0n00ONNqAF stateMachine = default(o28RREkuQ0n00ONNqAF);
			stateMachine.Ril2qacmW75 = AsyncVoidMethodBuilder.Create();
			stateMachine.nkt2q7sY5xa = this;
			stateMachine.b5Z2q8sC2k2 = -1;
			stateMachine.Ril2qacmW75.Start(ref stateMachine);
		}

		internal void wAyvdPmqrcU(object sender, RoutedEventArgs e)
		{
			mTAvdKmAvM2.ip0trMUrXfx(FXyvdpLR6nB, VDxvdx9L8v4, gDtvdBaBq0w, py0vdQSLHa6, aq7vdXTvn14);
		}

		internal void GgTvdEKQcRu(object sender, RoutedEventArgs e)
		{
			mTAvdKmAvM2.EditActionHotkey(FXyvdpLR6nB);
		}

		internal void KxFvdy7ivYk(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().RequestHide();
			(bool, string) tuple = AppHelper.ShowSaveFileDialog("json文件|*.json|任意文件|*.*", ".json", FXyvdpLR6nB.Title.ToValidFileName() + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".json", "", "导出动作");
			if (!tuple.Item1)
			{
				return;
			}
			try
			{
				ActionItem actionItem = AppHelper.Clone(FXyvdpLR6nB);
				if (actionItem.ActionType == ActionType.XAction)
				{
					string text = ShareActionHelper.EmbedGlobalSubPrograms(actionItem.Data);
					if (!string.Equals(actionItem.Data, text) && MessageBoxHelper.Show("是否将公共子程序嵌入到动作中？", "导出动作", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
					{
						actionItem.Data = text;
					}
				}
				File.WriteAllText(tuple.Item2, JsonConvert.SerializeObject(actionItem, Formatting.Indented));
				AppHelper.SelectFileInExplorer(tuple.Item2, false);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("导出出错！" + ex.Message, true);
			}
		}

		[AsyncStateMachine(typeof(Bv8n0PkY53Hbgrpnf9y))]
		internal void jGXvd85ZNSq(object sender, RoutedEventArgs e)
		{
			Bv8n0PkY53Hbgrpnf9y stateMachine = default(Bv8n0PkY53Hbgrpnf9y);
			stateMachine.RYa2RjnEE2b = AsyncVoidMethodBuilder.Create();
			stateMachine.Cr02RnFmArH = this;
			stateMachine.lEW2RQGGQuC = -1;
			stateMachine.RYa2RjnEE2b.Start(ref stateMachine);
		}

		internal void JyZvdaB3Wim(object sender, RoutedEventArgs e)
		{
			AppState.AlwaysDebugActionId = FXyvdpLR6nB.Id;
			AppHelper.ShowSuccess("已开启自动调试运行动作:" + FXyvdpLR6nB.Title);
		}

		internal void QrCvd7W6lmD(object sender, RoutedEventArgs e)
		{
			AppState.AlwaysDebugActionId = "";
			AppHelper.ShowInformation("已关闭自动调试运行动作:" + FXyvdpLR6nB.Title);
		}

		[AsyncStateMachine(typeof(zDqffDkMCjeu9WhpdnU))]
		internal void CeCvdRWHn3p(object sender, RoutedEventArgs e)
		{
			zDqffDkMCjeu9WhpdnU stateMachine = default(zDqffDkMCjeu9WhpdnU);
			stateMachine.W4d2RDK8XXd = AsyncVoidMethodBuilder.Create();
			stateMachine.WCv2Rd4i5fZ = this;
			stateMachine.OaB2R5vnTd4 = -1;
			stateMachine.W4d2RDK8XXd.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(FHXnvckfNN6xCuYNyhl))]
		internal void tcWvdqYe060(object sender, RoutedEventArgs e)
		{
			FHXnvckfNN6xCuYNyhl stateMachine = default(FHXnvckfNN6xCuYNyhl);
			stateMachine.Jan2RMghsKT = AsyncVoidMethodBuilder.Create();
			stateMachine.Cl62RA9lkJj = this;
			stateMachine.zMV2RTkUOaL = -1;
			stateMachine.Jan2RMghsKT.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(PLR71Ck6f7OXBF1TO0B))]
		internal void dnpvdcT5r5n(object sender, RoutedEventArgs e)
		{
			PLR71Ck6f7OXBF1TO0B stateMachine = default(PLR71Ck6f7OXBF1TO0B);
			stateMachine.V5B2RU7rLeT = AsyncVoidMethodBuilder.Create();
			stateMachine.SCc2Rl0mW76 = this;
			stateMachine.FdZ2RFDOlRc = -1;
			stateMachine.V5B2RU7rLeT.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(DoEraVk7Db9kwJabfAC))]
		internal void PvVvdVC9FSV(object sender, RoutedEventArgs e)
		{
			DoEraVk7Db9kwJabfAC stateMachine = default(DoEraVk7Db9kwJabfAC);
			stateMachine.OXJ2R3xDAse = AsyncVoidMethodBuilder.Create();
			stateMachine.oJJ2Rf7DF03 = this;
			stateMachine.Bkv2Riud1ms = -1;
			stateMachine.OXJ2R3xDAse.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(KvW4tOkil1FBkx3uTXQ))]
		internal void FtMvdZ5b95n(object sender, RoutedEventArgs e)
		{
			KvW4tOkil1FBkx3uTXQ stateMachine = default(KvW4tOkil1FBkx3uTXQ);
			stateMachine.TYl2qLTFKam = AsyncVoidMethodBuilder.Create();
			stateMachine.now2qvECk51 = this;
			stateMachine.Jbn2qg1wYWW = -1;
			stateMachine.TYl2qLTFKam.Start(ref stateMachine);
		}

		internal void nevvd9YyTDl(object sender, RoutedEventArgs e)
		{
			mTAvdKmAvM2.CreateLinkActionAndWriteToClipboard(FXyvdpLR6nB);
		}

		internal void TFdvdh9BfEY(object sender, RoutedEventArgs e)
		{
			HolvDFH348u();
			AppState.AppServer.RequestShowPanel();
			Task.Run(mmJvdd4ojc2 ?? (mmJvdd4ojc2 = V9AvdeuhrlK));
		}

		[AsyncStateMachine(typeof(NCMsYwkmKlJIXwqsENw))]
		internal Task V9AvdeuhrlK()
		{
			NCMsYwkmKlJIXwqsENw stateMachine = default(NCMsYwkmKlJIXwqsENw);
			stateMachine.KeH2qNeVfOT = AsyncTaskMethodBuilder.Create();
			stateMachine.bhN2qJjl8QL = this;
			stateMachine.qhx2qugoboF = -1;
			stateMachine.KeH2qNeVfOT.Start(ref stateMachine);
			return stateMachine.KeH2qNeVfOT.Task;
		}

		internal void pdAvdYshh7e(object sender, RoutedEventArgs e)
		{
			AppServer.ShowActionInfo(FXyvdpLR6nB, aq7vdXTvn14);
		}

		internal void PPcvdIESIBn(object sender, RoutedEventArgs e)
		{
			ClipboardHelper.SetText(FXyvdpLR6nB.Icon);
		}

		internal void kA1vdWwZifv(object sender, RoutedEventArgs e)
		{
			AppHelper.CopyActionId(FXyvdpLR6nB);
		}

		internal void zdxvdkEjkjD(object sender, RoutedEventArgs e)
		{
			ClipboardHelper.SetText(FXyvdpLR6nB.Title);
			AppHelper.ShowSuccess("已复制。");
		}

		internal void SEFvdGOV2xU(object sender, RoutedEventArgs e)
		{
			AppHelper.CopyActionUri(FXyvdpLR6nB);
		}

		internal void mofvdsVaAle()
		{
			if (UgJvdjPZMD7)
			{
				AppHelper.AddMenuItem(tGZvdn3Q4XR.Items, "编辑", "编辑动作定义\r\n【面板窗口快速触发方式】左Shift+点击。\r\n按Ctrl点击菜单以只读模式打开。", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Pen, "#1296db"), ub6vdHU8nlM);
			}
			int num;
			_003C_003Ec__DisplayClass57_6 _003C_003Ec__DisplayClass57_2 = default(_003C_003Ec__DisplayClass57_6);
			if (PSivd43uisT)
			{
				if (FXyvdpLR6nB.ActionType == ActionType.LinkAction)
				{
					_003C_003Ec__DisplayClass57_5 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_5
					{
						UeMvotdjSMd = this,
						Cp1vowLj0yU = FXyvdpLR6nB.Data
					};
					if (mTAvdKmAvM2.kB4tpwTmVen.GetActionById(_003C_003Ec__DisplayClass57_.Cp1vowLj0yU).action != null)
					{
						AppHelper.AddMenuItem(tGZvdn3Q4XR.Items, "编辑链接的目标动作", "编辑当前动作链接到的动作定义。", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Solid_Pen, "#1296db"), _003C_003Ec__DisplayClass57_.xdmvdzbJF2N);
						num = 0;
						if (vy2vE9WcUc5hc9pOKwCt != null)
						{
							goto IL_016b;
						}
					}
				}
				else if (FXyvdpLR6nB.TemplateRevision == -1 && !string.IsNullOrEmpty(FXyvdpLR6nB.TemplateId))
				{
					_003C_003Ec__DisplayClass57_2 = new _003C_003Ec__DisplayClass57_6
					{
						phUvovjvmCK = this
					};
					num = 1;
					if (vy2vE9WcUc5hc9pOKwCt != null)
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_016b;
				}
			}
			goto IL_0204;
			IL_0204:
			if (UgJvdjPZMD7 && FXyvdpLR6nB.ActionType == ActionType.XAction)
			{
				AppHelper.AddMenuItem(tGZvdn3Q4XR.Items, "调试运行", "以调试模式运行动作，结束后自动用浏览器打开调试文件\r\n【面板窗口快速触发方式】右Shift+点击。", $"fa:{EFontAwesomeIcon.Light_Play}:#f75711", jyPvd1WEEb8);
			}
			return;
			IL_016b:
			switch (num)
			{
			case 1:
				_003C_003Ec__DisplayClass57_2.qi4voLwMfFK = FXyvdpLR6nB.TemplateId;
				if (mTAvdKmAvM2.kB4tpwTmVen.GetActionById(_003C_003Ec__DisplayClass57_2.qi4voLwMfFK).action != null)
				{
					AppHelper.AddMenuItem(tGZvdn3Q4XR.Items, "编辑链接的目标动作", "编辑当前动作链接到的动作定义。", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Solid_Pen, "#1296db"), _003C_003Ec__DisplayClass57_2.bYNvogjVP6K);
				}
				break;
			}
			goto IL_0204;
		}

		internal void ub6vdHU8nlM(object sender, RoutedEventArgs e)
		{
			if (VDxvdx9L8v4.IsGlobalProfile() && AppState.DataService.Gont6sBnlpf(AppHelper.GetButtonIndex(true, gDtvdBaBq0w, py0vdQSLHa6)))
			{
				AppHelper.ShowVersionLimitInfo("编辑右上角按钮");
				return;
			}
			if (!string.IsNullOrEmpty(FXyvdpLR6nB.Id))
			{
				mTAvdKmAvM2.EditActionById(FXyvdpLR6nB.Id, null, JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Control);
			}
			else
			{
				mTAvdKmAvM2.EditAction(VDxvdx9L8v4, gDtvdBaBq0w, py0vdQSLHa6, FXyvdpLR6nB, null);
			}
			HolvDFH348u();
		}

		internal void jyPvd1WEEb8(object sender, RoutedEventArgs e)
		{
			HolvDFH348u();
			mTAvdKmAvM2.Kfitrf6DTx6.NotifyRunAction(mTAvdKmAvM2, FXyvdpLR6nB.Id, true, false, z6Fvd5rhhSr, false, OFSvdDPK3Ad);
			AppState.HS2taepcAbc().RequestHide();
		}

		internal void YoVvdbBaq39()
		{
			try
			{
				AddActionContextMenu(Txavdmsj39W.ContextMenuData, tGZvdn3Q4XR, Txavdmsj39W, HolvDFH348u, OFSvdDPK3Ad);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("创建菜单项出错：" + ex.Message);
			}
			try
			{
				AddActionContextMenu(mTAvdKmAvM2.kB4tpwTmVen.GetActionExtraContextMenu(Txavdmsj39W.Id), tGZvdn3Q4XR, Txavdmsj39W, HolvDFH348u, OFSvdDPK3Ad);
			}
			catch (Exception ex2)
			{
				AppHelper.ShowWarning("创建自定义菜单项出错：" + ex2.Message);
			}
		}

		internal static bool iXAkf9Wcx2ihIpaE1q7L()
		{
			return vy2vE9WcUc5hc9pOKwCt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_1
	{
		public bool PsQvdTnk9B4;

		public MenuItem ClFvdMCxGib;

		public _003C_003Ec__DisplayClass57_0 GnuvdAXY4CW;

		internal static _003C_003Ec__DisplayClass57_1 rDsMh7Wcs5Cm0d35Uhu6;

		internal void UdnvdoOgKEU(object sender, RoutedEventArgs e)
		{
			if (PsQvdTnk9B4)
			{
				return;
			}
			PsQvdTnk9B4 = true;
			try
			{
				IList<SharedActionLocalRevisionItem> list = AppState.SQLDataMgr.EHLtrsqXGsM(GnuvdAXY4CW.Txavdmsj39W.TemplateId);
				if (list.Count <= 1)
				{
					return;
				}
				string icon = string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_History, "#1296db");
				MenuItem menuItem = AppHelper.AddMenuItem(ClFvdMCxGib.Items, "切换版本", "将动作恢复本地曾经安装过的历史版本", icon, null);
				using IEnumerator<SharedActionLocalRevisionItem> enumerator = list.OrderByDescending(_003C_003Ec.nMiv56plInr ?? (_003C_003Ec.nMiv56plInr = _003C_003Ec.Ny9v5bO7g78.TGsv51PAQKL)).GetEnumerator();
				int num2 = default(int);
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass57_2 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_2
					{
						poQvdU11JcZ = this,
						zBmvdFowt6d = enumerator.Current
					};
					int num = 0;
					if (rDsMh7Wcs5Cm0d35Uhu6 != null)
					{
						num = num2;
					}
					switch (num)
					{
					}
					MenuItem menuItem2 = AppHelper.AddMenuItem(menuItem.Items, $"v{_003C_003Ec__DisplayClass57_.zBmvdFowt6d.Revision}\t{_003C_003Ec__DisplayClass57_.zBmvdFowt6d.InstallTimeUtc.ToLocalTime()}", "", "", null);
					menuItem2.Tag = _003C_003Ec__DisplayClass57_.zBmvdFowt6d;
					if (_003C_003Ec__DisplayClass57_.zBmvdFowt6d.Revision == GnuvdAXY4CW.Txavdmsj39W.TemplateRevision)
					{
						menuItem2.IsChecked = true;
					}
					else
					{
						menuItem2.Click += _003C_003Ec__DisplayClass57_.gEbvdOajX65;
					}
				}
			}
			catch (Exception ex)
			{
				qiytpSkwiIN.Warn("加载本地历史版本出错：" + ex.Message, ex);
				AppHelper.ShowWarning("加载本地历史版本出错：" + ex.Message);
			}
		}

		static _003C_003Ec__DisplayClass57_1()
		{
		}

		internal static bool jOP1ulWcCPBtHVaffChF()
		{
			return rDsMh7Wcs5Cm0d35Uhu6 == null;
		}

		internal static void PQGaPTWcHKbS4Lo1ACIR()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct vvgnHnkDhq0GUpXPxNb : IAsyncStateMachine
		{
			public int d3e2qqRn1VO;

			public AsyncVoidMethodBuilder YcA2qcTfQJy;

			public object Ktc2qVKZSg6;

			public _003C_003Ec__DisplayClass57_2 tCG2qZayxNQ;

			private TaskAwaiter<(bool isSuccess, string button)> cX92q9EIPEu;

			private static object tOWQyNyoIAWRyBa7rXCI;

			private void MoveNext()
			{
				int num = d3e2qqRn1VO;
				_003C_003Ec__DisplayClass57_2 _003C_003Ec__DisplayClass57_ = tCG2qZayxNQ;
				try
				{
					TaskAwaiter<(bool, string)> awaiter;
					if (num == 0)
					{
						awaiter = cX92q9EIPEu;
						cX92q9EIPEu = default(TaskAwaiter<(bool, string)>);
						num = -1;
						d3e2qqRn1VO = -1;
						goto IL_00c5;
					}
					if ((Ktc2qVKZSg6 as MenuItem).Tag is SharedActionLocalRevisionItem)
					{
						awaiter = ConfirmDialog.jQyL0Wq9wU6(_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.aq7vdXTvn14, "切换动作版本", "", "将会覆盖所有本地修改，除非必要，请勿使用！\r\n如果动作保存了本地数据，不同动作版本的数据结构可能会不兼容。\r\n\r\n注：切换后，此动作不会再自动更新。", "Warning", "切换(_Y)|Ok\r\n取消(_C)|Cancel", "Cancel").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							d3e2qqRn1VO = 0;
							cX92q9EIPEu = awaiter;
							YcA2qcTfQJy.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00c5;
					}
					AppHelper.ShowWarning("数据为空。");
					goto end_IL_000e;
					IL_00c5:
					if (awaiter.GetResult().Item2 == "Ok")
					{
						try
						{
							if (!_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.UseTemplate && !_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.Data.IsNullOrEmpty() && _003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.ActionType == ActionType.XAction)
							{
								new ActionAutoBackup(_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W).Save(_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.Data, $"before_change_rev_to_{_003C_003Ec__DisplayClass57_.zBmvdFowt6d.Revision}");
							}
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.mTAvdKmAvM2.orltrlKx8rp.StopActionByIdOrName(_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.Id, 0, true);
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.Data = null;
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.UseTemplate = true;
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.TemplateRevision = _003C_003Ec__DisplayClass57_.zBmvdFowt6d.Revision;
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.AutoUpdate = false;
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.CreateTimeUtc = DateTime.UtcNow;
							SharedActionDto sharedActionDto = _003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.mTAvdKmAvM2.mTetrzZiEIl.p02trGElaNv(_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.TemplateId, _003C_003Ec__DisplayClass57_.zBmvdFowt6d.Revision);
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.ContextMenuData = sharedActionDto.ContextMenuData;
							if (tOWQyNyoIAWRyBa7rXCI == null)
							{
								switch (0)
								{
								}
							}
							_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.mTAvdKmAvM2.SetButtonAction(_003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.VDxvdx9L8v4, _003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.gDtvdBaBq0w, _003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.py0vdQSLHa6, _003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.FXyvdpLR6nB);
						}
						catch (Exception ex)
						{
							qiytpSkwiIN.Warn("切换动作" + _003C_003Ec__DisplayClass57_.poQvdU11JcZ.GnuvdAXY4CW.Txavdmsj39W.Title + "版本出错：" + ex.Message, ex);
							AppHelper.ShowWarning("切换版本出错：" + ex.Message);
						}
					}
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					d3e2qqRn1VO = -2;
					YcA2qcTfQJy.SetException(exception);
					return;
				}
				d3e2qqRn1VO = -2;
				YcA2qcTfQJy.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				YcA2qcTfQJy.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool OQtVC5yo6apDlWCxDPuW()
			{
				return tOWQyNyoIAWRyBa7rXCI == null;
			}
		}

		public SharedActionLocalRevisionItem zBmvdFowt6d;

		public _003C_003Ec__DisplayClass57_1 poQvdU11JcZ;

		private static _003C_003Ec__DisplayClass57_2 tYSEb4WczPebX7txu8rL;

		[AsyncStateMachine(typeof(vvgnHnkDhq0GUpXPxNb))]
		internal void gEbvdOajX65(object sender, RoutedEventArgs e)
		{
			vvgnHnkDhq0GUpXPxNb stateMachine = default(vvgnHnkDhq0GUpXPxNb);
			stateMachine.YcA2qcTfQJy = AsyncVoidMethodBuilder.Create();
			stateMachine.tCG2qZayxNQ = this;
			stateMachine.Ktc2qVKZSg6 = sender;
			stateMachine.d3e2qqRn1VO = -1;
			stateMachine.YcA2qcTfQJy.Start(ref stateMachine);
		}

		internal static bool cMI0vrWWV3UU3pBjnwFQ()
		{
			return tYSEb4WczPebX7txu8rL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_3
	{
		public string ctlvdijSUFF;

		private static _003C_003Ec__DisplayClass57_3 ac24mpWWcAtnNvM2e0Rn;

		internal void mJ8vdlYOma9(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().RequestHide();
			AppHelper.SelectFileInExplorer(ctlvdijSUFF, false);
		}

		internal static bool rbDsNuWWWxOGHbuqtKrO()
		{
			return ac24mpWWcAtnNvM2e0Rn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_4
	{
		public string mYTvdfjh06y;

		private static _003C_003Ec__DisplayClass57_4 A18ILUWWpkEP0LdvVx3H;

		internal void RKEvd3WcDL2(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().RequestHide();
			AppHelper.SelectFileInExplorer(mYTvdfjh06y, false);
		}

		internal static bool nmCP0TWWXsInL6Dr90Cp()
		{
			return A18ILUWWpkEP0LdvVx3H == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_5
	{
		public string Cp1vowLj0yU;

		public _003C_003Ec__DisplayClass57_0 UeMvotdjSMd;

		internal static _003C_003Ec__DisplayClass57_5 PykMTtWWnjlZ5rtu7tUK;

		internal void xdmvdzbJF2N(object sender, RoutedEventArgs e)
		{
			UeMvotdjSMd.mTAvdKmAvM2.EditActionById(Cp1vowLj0yU);
			UeMvotdjSMd.HolvDFH348u();
		}

		internal static bool mPiexiWWeRrDR4rWpvXc()
		{
			return PykMTtWWnjlZ5rtu7tUK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_6
	{
		public string qi4voLwMfFK;

		public _003C_003Ec__DisplayClass57_0 phUvovjvmCK;

		private static _003C_003Ec__DisplayClass57_6 lxBYeZWWDTAXJggmCRck;

		internal void bYNvogjVP6K(object sender, RoutedEventArgs e)
		{
			phUvovjvmCK.mTAvdKmAvM2.EditActionById(qi4voLwMfFK);
			phUvovjvmCK.HolvDFH348u();
		}

		internal static bool nAgVTxWW31qYJIAeRXbg()
		{
			return lxBYeZWWDTAXJggmCRck == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct gcMQSFkH0meX9KKrrIg : IAsyncStateMachine
		{
			public int cVS2qhwWAeb;

			public AsyncVoidMethodBuilder MB92qe6ikfA;

			public _003C_003Ec__DisplayClass63_0 Brq2qYIlwOR;

			private TaskAwaiter zwU2qIST5gG;

			private static object y9uEa9yommPyb0PBYCMr;

			private void MoveNext()
			{
				int num = cVS2qhwWAeb;
				_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = Brq2qYIlwOR;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass63_.PQsvoE3Ol9s.PasteAction(_003C_003Ec__DisplayClass63_.iEyvoyOwhP1, _003C_003Ec__DisplayClass63_.woEvo8L7ai7, _003C_003Ec__DisplayClass63_.hoXvoawNHGN).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							cVS2qhwWAeb = 0;
							zwU2qIST5gG = awaiter;
							MB92qe6ikfA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = zwU2qIST5gG;
						zwU2qIST5gG = default(TaskAwaiter);
						num = -1;
						cVS2qhwWAeb = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					cVS2qhwWAeb = -2;
					MB92qe6ikfA.SetException(exception);
					return;
				}
				cVS2qhwWAeb = -2;
				MB92qe6ikfA.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				MB92qe6ikfA.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Y5URalyosDZO1Ga99ETd()
			{
				return y9uEa9yommPyb0PBYCMr == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct CXQCj7kk1RkLPgkbhIF : IAsyncStateMachine
		{
			public int m0I2qWQWNOn;

			public AsyncVoidMethodBuilder TTT2qkyItWc;

			public _003C_003Ec__DisplayClass63_0 kef2qGp0RrD;

			private TaskAwaiter D0T2qsfrPBe;

			internal static object XjolBgyo7ZoVjELlbbLW;

			private void MoveNext()
			{
				int num = m0I2qWQWNOn;
				_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = kef2qGp0RrD;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass63_.PQsvoE3Ol9s.idDtrOTgEW4(_003C_003Ec__DisplayClass63_.iEyvoyOwhP1, _003C_003Ec__DisplayClass63_.woEvo8L7ai7, _003C_003Ec__DisplayClass63_.hoXvoawNHGN).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							m0I2qWQWNOn = 0;
							int num2 = 0;
							if (XjolBgyo7ZoVjELlbbLW != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							D0T2qsfrPBe = awaiter;
							TTT2qkyItWc.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = D0T2qsfrPBe;
						D0T2qsfrPBe = default(TaskAwaiter);
						num = -1;
						m0I2qWQWNOn = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					m0I2qWQWNOn = -2;
					TTT2qkyItWc.SetException(exception);
					return;
				}
				m0I2qWQWNOn = -2;
				TTT2qkyItWc.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				TTT2qkyItWc.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool QBF6L2yo4uqxEcIIrSll()
			{
				return XjolBgyo7ZoVjELlbbLW == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct QSutpwkh87MgLJitJ1g : IAsyncStateMachine
		{
			public int zAq2qHwPbcw;

			public AsyncVoidMethodBuilder e0y2q1i9kFv;

			public _003C_003Ec__DisplayClass63_0 hq02qbi9GBi;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter gDV2q6Hb1BC;

			private static object MdIQaoyoHCkSJAvyKwQU;

			private void MoveNext()
			{
				int num = zAq2qHwPbcw;
				_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = hq02qbi9GBi;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass63_.PQsvoE3Ol9s.InstallAction(null, _003C_003Ec__DisplayClass63_.zG2vo7LcnAT, _003C_003Ec__DisplayClass63_.iEyvoyOwhP1, _003C_003Ec__DisplayClass63_.woEvo8L7ai7, _003C_003Ec__DisplayClass63_.hoXvoawNHGN, _003C_003Ec__DisplayClass63_.NRQvoPUSg8G).ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							zAq2qHwPbcw = 0;
							gDV2q6Hb1BC = awaiter;
							if (MdIQaoyoHCkSJAvyKwQU == null)
							{
								switch (0)
								{
								}
							}
							e0y2q1i9kFv.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = gDV2q6Hb1BC;
						gDV2q6Hb1BC = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = -1;
						zAq2qHwPbcw = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					zAq2qHwPbcw = -2;
					e0y2q1i9kFv.SetException(exception);
					return;
				}
				zAq2qHwPbcw = -2;
				e0y2q1i9kFv.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				e0y2q1i9kFv.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool ifa3KEyoziQ8XJXtBCql()
			{
				return MdIQaoyoHCkSJAvyKwQU == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct QDlJhak8btT9w1THGvx : IAsyncStateMachine
		{
			public int tUG2qXyCopo;

			public AsyncVoidMethodBuilder fo92qmeo1uR;

			public _003C_003Ec__DisplayClass63_0 zjT2qKMHB4H;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter QFU2qxHmwFF;

			private static object CRjddgyfQSGqrKYRuQ5u;

			private void MoveNext()
			{
				int num = tUG2qXyCopo;
				_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = zjT2qKMHB4H;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						ConfiguredTaskAwaitable<bool> configuredTaskAwaitable = _003C_003Ec__DisplayClass63_.PQsvoE3Ol9s.InstallAction(null, _003C_003Ec__DisplayClass63_.zG2vo7LcnAT, _003C_003Ec__DisplayClass63_.iEyvoyOwhP1, _003C_003Ec__DisplayClass63_.woEvo8L7ai7, _003C_003Ec__DisplayClass63_.hoXvoawNHGN, _003C_003Ec__DisplayClass63_.NRQvoPUSg8G, true).ConfigureAwait(false);
						int num2 = 0;
						if (!ALgNyqyfFt5yyQRv14Fi())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						awaiter = configuredTaskAwaitable.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							tUG2qXyCopo = 0;
							QFU2qxHmwFF = awaiter;
							fo92qmeo1uR.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = QFU2qxHmwFF;
						QFU2qxHmwFF = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = -1;
						tUG2qXyCopo = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					tUG2qXyCopo = -2;
					fo92qmeo1uR.SetException(exception);
					return;
				}
				tUG2qXyCopo = -2;
				fo92qmeo1uR.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				fo92qmeo1uR.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool ALgNyqyfFt5yyQRv14Fi()
			{
				return CRjddgyfQSGqrKYRuQ5u == null;
			}
		}

		public ContextMenu VuVvoCxSghp;

		public Window NRQvoPUSg8G;

		public ActionEditMgr PQsvoE3Ol9s;

		public ActionProfile iEyvoyOwhP1;

		public int woEvo8L7ai7;

		public int hoXvoawNHGN;

		public string zG2vo7LcnAT;

		internal static _003C_003Ec__DisplayClass63_0 MwJZv9WWGDhMfSVIbuXL;

		internal void WjUvoSOQGpw(string header, string tooltip, ActionType? newActionType, string icon)
		{
			_003C_003Ec__DisplayClass63_1 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_1
			{
				DANvocM2jRk = this,
				IPIvoqKpVkS = newActionType
			};
			AppHelper.AddMenuItem(VuVvoCxSghp.Items, header, tooltip, icon, _003C_003Ec__DisplayClass63_.nvDvoRvPIcR);
		}

		[AsyncStateMachine(typeof(gcMQSFkH0meX9KKrrIg))]
		internal void Isbvo29IP7Q(object sender, RoutedEventArgs e)
		{
			gcMQSFkH0meX9KKrrIg stateMachine = default(gcMQSFkH0meX9KKrrIg);
			stateMachine.MB92qe6ikfA = AsyncVoidMethodBuilder.Create();
			stateMachine.Brq2qYIlwOR = this;
			stateMachine.cVS2qhwWAeb = -1;
			stateMachine.MB92qe6ikfA.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(CXQCj7kk1RkLPgkbhIF))]
		internal void tjAvouacQdb(object sender, RoutedEventArgs e)
		{
			CXQCj7kk1RkLPgkbhIF stateMachine = default(CXQCj7kk1RkLPgkbhIF);
			stateMachine.TTT2qkyItWc = AsyncVoidMethodBuilder.Create();
			stateMachine.kef2qGp0RrD = this;
			stateMachine.m0I2qWQWNOn = -1;
			stateMachine.TTT2qkyItWc.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(QSutpwkh87MgLJitJ1g))]
		internal void qLnvoNSvhf3(object sender, MouseButtonEventArgs e)
		{
			QSutpwkh87MgLJitJ1g stateMachine = default(QSutpwkh87MgLJitJ1g);
			stateMachine.e0y2q1i9kFv = AsyncVoidMethodBuilder.Create();
			stateMachine.hq02qbi9GBi = this;
			stateMachine.zAq2qHwPbcw = -1;
			stateMachine.e0y2q1i9kFv.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(QDlJhak8btT9w1THGvx))]
		internal void pTWvoJxEjRI(object sender, MouseButtonEventArgs e)
		{
			QDlJhak8btT9w1THGvx stateMachine = default(QDlJhak8btT9w1THGvx);
			stateMachine.fo92qmeo1uR = AsyncVoidMethodBuilder.Create();
			stateMachine.zjT2qKMHB4H = this;
			stateMachine.tUG2qXyCopo = -1;
			stateMachine.fo92qmeo1uR.Start(ref stateMachine);
		}

		internal void oQBvo0gZDTM(object sender, RoutedEventArgs e)
		{
			using (BjxbsJXXKfq9q6nXgXg.RPyt1vLAkLm("导入动作"))
			{
				PQsvoE3Ol9s.PVVtrFPDjDg(iEyvoyOwhP1, woEvo8L7ai7, hoXvoawNHGN);
			}
		}

		internal static bool cP88VaWW01vekh93VwnW()
		{
			return MwJZv9WWGDhMfSVIbuXL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_1
	{
		public ActionType? IPIvoqKpVkS;

		public _003C_003Ec__DisplayClass63_0 DANvocM2jRk;

		private static _003C_003Ec__DisplayClass63_1 NywNgnWWKwKPRx99g8g2;

		internal void nvDvoRvPIcR(object sender, RoutedEventArgs e)
		{
			if (DANvocM2jRk.NRQvoPUSg8G == AppState.HS2taepcAbc())
			{
				AppState.HS2taepcAbc().EnableKeyTrigger = false;
				AppState.HS2taepcAbc().RequestHide();
			}
			DANvocM2jRk.PQsvoE3Ol9s.CreateAction(DANvocM2jRk.iEyvoyOwhP1, DANvocM2jRk.woEvo8L7ai7, DANvocM2jRk.hoXvoawNHGN, IPIvoqKpVkS);
		}

		internal static bool CDmDEaWWBOHkyjdDHdT6()
		{
			return NywNgnWWKwKPRx99g8g2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct bFH13skbwEI38tRad7T : IAsyncStateMachine
		{
			public int qyp2qrjqQln;

			public AsyncVoidMethodBuilder ulH2qpOOSgv;

			public _003C_003Ec__DisplayClass63_2 slH2qB24Waj;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter g4C2qQSGt2C;

			internal static object D1Y945yfWQGG6kaGxGKX;

			private void MoveNext()
			{
				int num = qyp2qrjqQln;
				_003C_003Ec__DisplayClass63_2 _003C_003Ec__DisplayClass63_ = slH2qB24Waj;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass63_.bF0vohKUe4u.PQsvoE3Ol9s.CreateOpenFileOrFolderActionAsync(_003C_003Ec__DisplayClass63_.bF0vohKUe4u.iEyvoyOwhP1, _003C_003Ec__DisplayClass63_.bF0vohKUe4u.woEvo8L7ai7, _003C_003Ec__DisplayClass63_.bF0vohKUe4u.hoXvoawNHGN, _003C_003Ec__DisplayClass63_.HKwvo9SLWCO, false).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							qyp2qrjqQln = 0;
							int num2 = 0;
							if (D1Y945yfWQGG6kaGxGKX != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							g4C2qQSGt2C = awaiter;
							ulH2qpOOSgv.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = g4C2qQSGt2C;
						g4C2qQSGt2C = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						qyp2qrjqQln = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					qyp2qrjqQln = -2;
					ulH2qpOOSgv.SetException(exception);
					return;
				}
				qyp2qrjqQln = -2;
				ulH2qpOOSgv.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				ulH2qpOOSgv.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool MKVofayfyKlkwRxfCEXj()
			{
				return D1Y945yfWQGG6kaGxGKX == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct yyKDpWkeXD98paS7tRo : IAsyncStateMachine
		{
			public int shQ2qj1WQcZ;

			public AsyncVoidMethodBuilder pPI2qnRsFg4;

			public _003C_003Ec__DisplayClass63_2 J1J2q4nyc1t;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter FXU2q5TaUD9;

			private static object Y2xv7jyfXAq2E6d7P0jU;

			private void MoveNext()
			{
				int num = shQ2qj1WQcZ;
				_003C_003Ec__DisplayClass63_2 _003C_003Ec__DisplayClass63_ = J1J2q4nyc1t;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass63_.bF0vohKUe4u.PQsvoE3Ol9s.CreateOpenFileOrFolderActionAsync(_003C_003Ec__DisplayClass63_.bF0vohKUe4u.iEyvoyOwhP1, _003C_003Ec__DisplayClass63_.bF0vohKUe4u.woEvo8L7ai7, _003C_003Ec__DisplayClass63_.bF0vohKUe4u.hoXvoawNHGN, _003C_003Ec__DisplayClass63_.HKwvo9SLWCO, true).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							shQ2qj1WQcZ = 0;
							FXU2q5TaUD9 = awaiter;
							pPI2qnRsFg4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							if (!eMxT2Xyf24VWThWpyl1l())
							{
								switch (0)
								{
								}
							}
							return;
						}
					}
					else
					{
						awaiter = FXU2q5TaUD9;
						FXU2q5TaUD9 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						shQ2qj1WQcZ = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					shQ2qj1WQcZ = -2;
					pPI2qnRsFg4.SetException(exception);
					return;
				}
				shQ2qj1WQcZ = -2;
				pPI2qnRsFg4.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				pPI2qnRsFg4.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool eMxT2Xyf24VWThWpyl1l()
			{
				return Y2xv7jyfXAq2E6d7P0jU == null;
			}
		}

		public string HKwvo9SLWCO;

		public _003C_003Ec__DisplayClass63_0 bF0vohKUe4u;

		internal static _003C_003Ec__DisplayClass63_2 bFehvLWWdCa6g8XiSqRM;

		[AsyncStateMachine(typeof(bFH13skbwEI38tRad7T))]
		internal void Pf7voVKqZ6v(object sender, RoutedEventArgs e)
		{
			bFH13skbwEI38tRad7T stateMachine = default(bFH13skbwEI38tRad7T);
			stateMachine.ulH2qpOOSgv = AsyncVoidMethodBuilder.Create();
			stateMachine.slH2qB24Waj = this;
			stateMachine.qyp2qrjqQln = -1;
			stateMachine.ulH2qpOOSgv.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(yyKDpWkeXD98paS7tRo))]
		internal void SAmvoZgeabM(object sender, RoutedEventArgs e)
		{
			yyKDpWkeXD98paS7tRo stateMachine = default(yyKDpWkeXD98paS7tRo);
			stateMachine.pPI2qnRsFg4 = AsyncVoidMethodBuilder.Create();
			stateMachine.J1J2q4nyc1t = this;
			stateMachine.shQ2qj1WQcZ = -1;
			stateMachine.pPI2qnRsFg4.Start(ref stateMachine);
		}

		internal static bool JiwEQjWWOsET2uIDA34Y()
		{
			return bFehvLWWdCa6g8XiSqRM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass71_0
	{
		public ActionItem Em0voYvFrVp;

		internal static _003C_003Ec__DisplayClass71_0 hZSepCWWkiBIvDfP7FBW;

		internal bool OOxvoerQjmE(EditingActionInfo x)
		{
			return x.ActionId == Em0voYvFrVp.Id;
		}

		internal static bool mUISLNWWapdkFssQ2QQq()
		{
			return hZSepCWWkiBIvDfP7FBW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateAndCopyActionForCommand_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public string iconPath;

		public ActionEditMgr _003C_003E4__this;

		public string title;

		public string command;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object pPrGfRWWNHLU7jpiyDTr;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			bool result;
			try
			{
				string icon;
				ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
				if (num != 0)
				{
					if (num != 1)
					{
						icon = string.Empty;
						if (!string.IsNullOrEmpty(iconPath))
						{
							if (!iconPath.StartsWith("shellicon:"))
							{
								goto IL_00fe;
							}
							awaiter = actionEditMgr.PjUtrisBbF8.GetFileOrFolderIconAsync(iconPath.Substring("shellicon:".Length)).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_015e;
						}
						goto IL_01b3;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01a0;
				}
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				int num2 = 0;
				if (!h5CBPHWW9wTdf2OpVYhj())
				{
					goto IL_0149;
				}
				goto IL_014d;
				IL_0149:
				int num3 = default(int);
				num2 = num3;
				goto IL_014d;
				IL_01b3:
				CopyAction(new ActionItem
				{
					Title = title,
					Icon = icon,
					Description = "执行命令：" + command,
					ActionType = ActionType.RunProgram,
					Col = -1,
					Row = -1,
					CreateTimeUtc = DateTime.UtcNow,
					Data = command,
					LastEditTimeUtc = DateTime.UtcNow
				});
				result = true;
				goto end_IL_0010;
				IL_0169:
				ConfiguredTaskAwaitable<string> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<string>);
				awaiter = configuredTaskAwaitable.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_01a0;
				IL_014d:
				switch (num2)
				{
				case 2:
					break;
				default:
					goto IL_015e;
				case 1:
					goto IL_0169;
				}
				goto IL_00fe;
				IL_01a0:
				icon = awaiter.GetResult();
				goto IL_01b3;
				IL_00fe:
				if (iconPath.StartsWith("icon:"))
				{
					configuredTaskAwaitable = actionEditMgr.PjUtrisBbF8.GetFileOrFolderIconAsync(iconPath.Substring("icon:".Length)).ConfigureAwait(false);
					num2 = 1;
					if (pPrGfRWWNHLU7jpiyDTr != null)
					{
						goto IL_0149;
					}
					goto IL_014d;
				}
				icon = iconPath;
				goto IL_01b3;
				IL_015e:
				icon = awaiter.GetResult();
				goto IL_01b3;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool h5CBPHWW9wTdf2OpVYhj()
		{
			return pPrGfRWWNHLU7jpiyDTr == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateAndCopyActionForPath_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public ActionEditMgr _003C_003E4__this;

		public string path;

		public string name;

		public bool useLinkTarget;

		private TaskAwaiter<ActionItem> _003C_003Eu__1;

		internal static object IP5aKPWWfwAi4LiYgduT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			bool result;
			try
			{
				TaskAwaiter<ActionItem> awaiter;
				if (num != 0)
				{
					awaiter = actionEditMgr.FtHtr55k4dh(-1, -1, path, name, useLinkTarget).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (IP5aKPWWfwAi4LiYgduT != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ActionItem>);
					num = -1;
					_003C_003E1__state = -1;
				}
				CopyAction(awaiter.GetResult());
				result = true;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool x27dD6WWbeCpegZhyF0B()
		{
			return IP5aKPWWfwAi4LiYgduT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateAndCopyActionForUrl_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public string iconPath;

		public ActionEditMgr _003C_003E4__this;

		public string title;

		public string url;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object vmB1M3WWiNWWVNku65Ef;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			bool result;
			try
			{
        ConfiguredTaskAwaitable<string> configuredTaskAwaitable = default;
				if (num == 0)
				{
					goto IL_0138;
				}
				string icon;
				configuredTaskAwaitable = default(ConfiguredTaskAwaitable<string>);
				int num2;
				ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
				if (num != 1)
				{
					icon = string.Empty;
					if (!string.IsNullOrEmpty(iconPath))
					{
						if (iconPath.StartsWith("shellicon:"))
						{
							awaiter = actionEditMgr.PjUtrisBbF8.GetFileOrFolderIconAsync(iconPath.Substring("shellicon:".Length)).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0169;
						}
						if (iconPath.StartsWith("icon:"))
						{
							configuredTaskAwaitable = actionEditMgr.PjUtrisBbF8.GetFileOrFolderIconAsync(iconPath.Substring("icon:".Length)).ConfigureAwait(false);
							num2 = 1;
							if (vmB1M3WWiNWWVNku65Ef != null)
							{
								goto IL_0125;
							}
							goto IL_0174;
						}
						icon = iconPath;
					}
					goto IL_01b4;
				}
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_01ab;
				IL_0174:
				awaiter = configuredTaskAwaitable.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_01ab;
				IL_0138:
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				num2 = 0;
				if (!IohoHZWWlLF3xX68EGV4())
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_0125;
				IL_0125:
				switch (num2)
				{
				case 2:
					break;
				default:
					goto IL_0169;
				case 1:
					goto IL_0174;
				}
				goto IL_0138;
				IL_01b4:
				CopyAction(new ActionItem
				{
					Title = title,
					Icon = icon,
					Description = "打开网址：" + url,
					ActionType = ActionType.OpenUrl,
					Col = -1,
					Row = -1,
					CreateTimeUtc = DateTime.UtcNow,
					Data = url,
					LastEditTimeUtc = DateTime.UtcNow
				});
				result = true;
				goto end_IL_0010;
				IL_01ab:
				icon = awaiter.GetResult();
				goto IL_01b4;
				IL_0169:
				icon = awaiter.GetResult();
				goto IL_01b4;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003CCreateAndCopyActionForUrl_003Ed__41()
		{
		}

		internal static bool IohoHZWWlLF3xX68EGV4()
		{
			return vmB1M3WWiNWWVNku65Ef == null;
		}

		internal static void W5sHOhWW8WWB6KR1xRIG()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateOpenFileOrFolderActionAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionEditMgr _003C_003E4__this;

		public int row;

		public int col;

		public string path;

		public bool useLnkTarget;

		public ActionProfile profile;

		private ConfiguredTaskAwaitable<ActionItem>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object xQ4WYQWWRt2VxkuTjhge;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<ActionItem>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = actionEditMgr.FtHtr55k4dh(row, col, path, null, useLnkTarget).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						int num2 = 0;
						if (xQ4WYQWWRt2VxkuTjhge != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ActionItem>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				ActionItem result = awaiter.GetResult();
				actionEditMgr.SetButtonAction(profile, row, col, result);
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool vnPcMrWWg4PMSBfsV7hr()
		{
			return xQ4WYQWWRt2VxkuTjhge == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateOpenFileOrFolderActionAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ActionItem> _003C_003Et__builder;

		public ActionEditMgr _003C_003E4__this;

		public string path;

		public string name;

		public bool useLnkTarget;

		public int col;

		public int row;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object QsCVymWWM7hwlHy1ROqs;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			ActionItem result2;
			try
			{
        string arguments = default;
        string result = default;
        string text2 = default;
				ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
				int num2;
				if (num != 0)
				{
					awaiter = actionEditMgr.PjUtrisBbF8.GetFileOrFolderIconAsync(path).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						num2 = 0;
						if (QsCVymWWM7hwlHy1ROqs == null)
						{
							goto IL_00a7;
						}
						goto IL_00b8;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
				string text = "";
				text2 = path;
				arguments = "";
				num2 = 1;
				if (!UvJa4MWWUR2ixSXovTuc())
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_00a7;
				IL_00a7:
				string description = default(string);
				switch (num2)
				{
				case 1:
					description = "打开 「" + text2 + "」";
					goto case 2;
				case 2:
				{
					text = ((!string.IsNullOrEmpty(name)) ? name : (File.Exists(path) ? Path.GetFileNameWithoutExtension(path) : ((!Directory.Exists(path)) ? Path.GetFileNameWithoutExtension(path) : Path.GetFileName(path.TrimEnd('\\', '/')))));
					if (useLnkTarget && path.EndsWith(".lnk"))
					{
						try
						{
							ShellObject shellObject = ShellObject.FromParsingName(path);
							try
							{
								ShellProperty<string> targetParsingPath = shellObject.Properties.System.Link.TargetParsingPath;
								object obj;
								if (targetParsingPath == null)
								{
									obj = null;
								}
								else
								{
									obj = targetParsingPath.Value;
									if (obj != null)
									{
										goto IL_01b0;
									}
								}
								obj = "";
								goto IL_01b0;
								IL_01dd:
								object obj2;
								arguments = (string)obj2;
								ShellProperty<string> title = shellObject.Properties.System.Title;
								object obj3;
								if (title == null)
								{
									int num4 = 0;
									if (!UvJa4MWWUR2ixSXovTuc())
									{
										int num5 = default(int);
										num4 = num5;
									}
									switch (num4)
									{
									}
									obj3 = null;
								}
								else
								{
									obj3 = title.Value;
									if (obj3 != null)
									{
										goto IL_021c;
									}
								}
								obj3 = text;
								goto IL_021c;
								IL_021c:
								text = (string)obj3;
								description = "打开 「" + text + "」";
								goto end_IL_0185;
								IL_01b0:
								text2 = (string)obj;
								ShellProperty<string> arguments2 = shellObject.Properties.System.Link.Arguments;
								if (arguments2 == null)
								{
									obj2 = null;
								}
								else
								{
									obj2 = arguments2.Value;
									if (obj2 != null)
									{
										goto IL_01dd;
									}
								}
								obj2 = "";
								goto IL_01dd;
								end_IL_0185:;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)shellObject)?.Dispose();
								}
							}
						}
						catch (Exception ex)
						{
							AppHelper.ShowWarning("获取快捷方式目标出错。" + ex.Message);
						}
					}
					ActionItem obj4 = new ActionItem
					{
						Title = text,
						Icon = result,
						Description = description,
						ActionType = ActionType.RunProgram,
						Col = col,
						Row = row,
						CreateTimeUtc = DateTime.UtcNow,
						LastEditTimeUtc = DateTime.UtcNow
					};
					ProcessActionParams processActionParams = new ProcessActionParams
					{
						FileName = text2,
						Arguments = arguments
					};
					obj4.Data = processActionParams.ToDataString();
					result2 = obj4;
					goto end_IL_0010;
				}
				}
				goto IL_00b8;
				IL_00b8:
				_003C_003Eu__1 = awaiter;
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool UvJa4MWWUR2ixSXovTuc()
		{
			return QsCVymWWM7hwlHy1ROqs == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeleteAction_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public ActionItem actionItem;

		public ActionEditMgr _003C_003E4__this;

		public bool showConfirm;

		public bool isCuttingAction;

		private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

		public ActionProfile profile;

		private TaskAwaiter _003C_003Eu__1;

		private static object esbrmWWWSSB78EfmsBvH;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			bool result = default(bool);
			try
			{
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass23_0();
					_003C_003E8__1.YUUvDvXp1TH = actionItem;
					_003C_003E8__1.FW9vDSsln8P = _003C_003E4__this;
				}
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0215;
					}
					bool flag;
					int num2;
					if (!actionEditMgr.kr8tp2sZD2W.Any(_003C_003E8__1.TojvDgDRBud))
					{
						flag = false;
						AppState.AppServer.StopActionByIdOrName(_003C_003E8__1.YUUvDvXp1TH.Id, 0, true);
						num2 = 0;
						if (esbrmWWWSSB78EfmsBvH == null)
						{
							goto IL_00a5;
						}
						goto IL_0180;
					}
					AppHelper.ShowWarning("动作正在编辑中，不能剪切或删除。");
					result = false;
					goto end_IL_000e;
					IL_0197:
					if (!isCuttingAction)
					{
						goto IL_01ae;
					}
					goto IL_0234;
					IL_0234:
					actionEditMgr.SetButtonAction(profile, _003C_003E8__1.YUUvDvXp1TH.Row, _003C_003E8__1.YUUvDvXp1TH.Col, null);
					if (!isCuttingAction)
					{
						actionEditMgr.vFdtpgdWYM0.Get<brgW8EX9ZVfZExh7q9t>(Array.Empty<IParameter>()).UottpHVZVJE(_003C_003E8__1.YUUvDvXp1TH);
					}
					actionEditMgr.Kfitrf6DTx6.NotifyActionDeleted(actionEditMgr, _003C_003E8__1.YUUvDvXp1TH.Id);
					AppState.vjAt7Seco0Y()?.YyrtG5nkZFy(null);
					result = true;
					goto end_IL_000e;
					IL_0180:
					switch (num2)
					{
					case 1:
						break;
					default:
						goto IL_017a;
					case 2:
						goto end_IL_000e;
					case 3:
						goto IL_01ae;
					}
					goto IL_00a5;
					IL_00a5:
					if (!showConfirm)
					{
						flag = true;
					}
					else
					{
						BjxbsJXXKfq9q6nXgXg bjxbsJXXKfq9q6nXgXg = BjxbsJXXKfq9q6nXgXg.RPyt1vLAkLm("删除动作");
						try
						{
							if (!string.IsNullOrEmpty(_003C_003E8__1.YUUvDvXp1TH.SharedActionId))
							{
								if (MessageBoxHelper.Show("动作 “" + _003C_003E8__1.YUUvDvXp1TH.Title + "” 已分享，删除后需要从动作库安装才能再次更新动作库动作。您确认要删除么？", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
								{
									flag = true;
								}
							}
							else if (MessageBoxHelper.Show("您确认要删除动作 “" + _003C_003E8__1.YUUvDvXp1TH.Title + "” 么？", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
							{
								flag = true;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)bjxbsJXXKfq9q6nXgXg)?.Dispose();
							}
						}
					}
					goto IL_017a;
					IL_0215:
					awaiter.GetResult();
					actionEditMgr.Q1MtrjGPF2a(_003C_003E8__1.YUUvDvXp1TH, "删除前保存");
					goto IL_0234;
					IL_01ae:
					awaiter = Task.Run((Action)_003C_003E8__1.NEHvDL3uPcG).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0215;
					IL_017a:
					while (flag)
					{
						if (_003C_003E8__1.YUUvDvXp1TH == null)
						{
							AppHelper.ShowWarning("没有要删除的动作！");
							result = false;
							num2 = 2;
							if (!oJ9ABmWWwDkPL8NbXj56())
							{
								continue;
							}
							goto IL_0180;
						}
						goto IL_0197;
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("删除动作出错：" + ex.Message);
				}
				result = false;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool oJ9ABmWWwDkPL8NbXj56()
		{
			return esbrmWWWSSB78EfmsBvH == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInstallAction_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public ActionEditMgr _003C_003E4__this;

		public ActionItem oldAction;

		public string sharedActionUrl;

		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		public bool skipConfirm;

		public Window ownerWindow;

		public ActionProfile profile;

		public int row;

		public int col;

		private ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private BjxbsJXXKfq9q6nXgXg _003Clocker_003E5__2;

		private bool _003CautoUpdate_003E5__3;

		private ActionItem _003CnewAction_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private static object owdqZcWWClaC3lqWM7oT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			bool result2;
			try
			{
        ApiResult<SharedActionDto> result = default;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_01f9;
					}
					_003C_003E8__1 = new _003C_003Ec__DisplayClass29_0();
					_003C_003E8__1.L0GvDZ7HLCV = _003C_003E4__this;
					if (oldAction != null)
					{
						int num2 = 1;
						if (owdqZcWWClaC3lqWM7oT != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						case 1:
							break;
						default:
							goto IL_0684;
						}
						AppState.AppServer.StopActionByIdOrName(oldAction.Id, 0, true);
					}
				}
				result = default(ApiResult<SharedActionDto>);
				try
				{
					ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.ewCt1dE0NmP(sharedActionUrl).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
						int num4 = 0;
						if (owdqZcWWClaC3lqWM7oT != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						switch (num4)
						{
						}
						num = -1;
						_003C_003E1__state = -1;
					}
					result = awaiter.GetResult();
				}
				catch (Exception ex)
				{
					qiytpSkwiIN.Warn("获取共享动作失败：" + ex.Message, ex);
					AppHelper.ShowWarning("获取共享动作失败！" + ex.Message);
					result2 = false;
					goto end_IL_0010;
				}
				if (!result.IsSuccess)
				{
					goto IL_0684;
				}
				_003C_003E8__1.ATqvD9DmBTj = result.Data;
				if (!string.IsNullOrEmpty(result.Message)) AppHelper.ShowWarning(result.Message);
				if (string.IsNullOrEmpty(_003C_003E8__1.ATqvD9DmBTj.MinQuickerVersion) || !SoftVersionHelper.IsVersionNewer(_003C_003E8__1.ATqvD9DmBTj.MinQuickerVersion, AppHelper.GetCurrAppVersion()))
				{
					_003Clocker_003E5__2 = BjxbsJXXKfq9q6nXgXg.RPyt1vLAkLm("安装动作");
					goto IL_01f9;
				}
				AppHelper.ShowWarning("此动作需要Quicker " + _003C_003E8__1.ATqvD9DmBTj.MinQuickerVersion + ".0 或以上版本，您的Quicker版本为 " + AppHelper.GetCurrAppVersion() + "。请升级Quicker后再安装此动作。", true);
				result2 = false;
				goto end_IL_0010;
				IL_0684:
				AppHelper.ShowWarning("获取分享的动作失败。" + result.Message);
				result2 = false;
				goto end_IL_0010;
				IL_01f9:
				try
				{
					int num6;
					if (num != 1)
					{
						num6 = 3;
						if (owdqZcWWClaC3lqWM7oT != null)
						{
							goto IL_036d;
						}
						goto IL_0450;
					}
					TaskAwaiter awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0551;
					IL_0551:
					awaiter2.GetResult();
					_003CnewAction_003E5__4.CreateTimeUtc = AppHelper.GetUtcNowForDb();
					if (string.Equals(_003C_003E8__1.ATqvD9DmBTj.UserId, AppState.DataService.PZTtmCY0ah7(), StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(_003C_003E8__1.ATqvD9DmBTj.UserId) && !string.IsNullOrWhiteSpace(_003C_003E8__1.ATqvD9DmBTj.InternalId) && !actionEditMgr.qMdtptd2UCL.IsActionExists(_003C_003E8__1.ATqvD9DmBTj.InternalId))
					{
						_003CnewAction_003E5__4.Id = _003C_003E8__1.ATqvD9DmBTj.InternalId;
						_003CnewAction_003E5__4.SharedActionId = _003C_003E8__1.ATqvD9DmBTj.Id.ToString();
						_003CnewAction_003E5__4.UserLimitation = ActionUserLimitation.None;
						AppHelper.ShowInformation("恢复为已删除动作的ID。");
					}
					if (oldAction != null)
					{
						if (AppState.HHxtaMaoqJr().KeepActionLocalIconAndName || oldAction.KeepInfoWhenUpdate)
						{
							_003CnewAction_003E5__4.Title = oldAction.Title;
							_003CnewAction_003E5__4.Icon = oldAction.Icon;
							_003CnewAction_003E5__4.Description = oldAction.Description;
						}
						_003CnewAction_003E5__4.KeepInfoWhenUpdate = oldAction.KeepInfoWhenUpdate;
						_003CnewAction_003E5__4.SkipCheckUpdate = oldAction.SkipCheckUpdate;
						_003CnewAction_003E5__4.SkipWhenStopRunningActions = oldAction.SkipWhenStopRunningActions;
					}
					goto IL_0472;
					IL_0472:
					_003CnewAction_003E5__4.AutoUpdate = false;
					num6 = 1;
					if (owdqZcWWClaC3lqWM7oT != null)
					{
						goto IL_036d;
					}
					goto IL_0450;
					IL_036d:
					int num7 = default(int);
					num6 = num7;
					goto IL_0450;
					IL_0450:
					while (true)
					{
						switch (num6)
						{
						case 4:
							_003CnewAction_003E5__4 = _003C_003E8__1.ATqvD9DmBTj.CreateActionItem(true);
							if (oldAction != null)
							{
								profile.RemoveAction(oldAction);
								_003CnewAction_003E5__4.Id = oldAction.Id;
							}
							goto IL_032a;
						case 3:
						{
							_003CautoUpdate_003E5__3 = false;
							if (skipConfirm || !(AppState.y6Rt78JCICI() != _003C_003E8__1.ATqvD9DmBTj.Id))
							{
								goto case 2;
							}
							SharedActionInfoWindow sharedActionInfoWindow = new SharedActionInfoWindow(_003C_003E8__1.ATqvD9DmBTj, oldAction);
							Window window = ownerWindow;
							sharedActionInfoWindow.Owner = ((window != null && window.IsLoaded) ? ownerWindow : null);
							SharedActionInfoWindow sharedActionInfoWindow2 = sharedActionInfoWindow;
							if (oldAction != null)
							{
								sharedActionInfoWindow2.Title = "更新动作";
								sharedActionInfoWindow2.AutoUpdate = oldAction.AutoUpdate;
							}
							if (sharedActionInfoWindow2.ShowDialog() == true)
							{
								_003CautoUpdate_003E5__3 = sharedActionInfoWindow2.AutoUpdate;
								goto case 4;
							}
							result2 = false;
							goto end_IL_01f9;
						}
						case 2:
							if (oldAction != null)
							{
								_003CautoUpdate_003E5__3 = oldAction.AutoUpdate;
							}
							goto case 4;
						case 5:
							break;
						default:
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 1:
							actionEditMgr.SetButtonAction(profile, row, col, _003CnewAction_003E5__4);
							if (_003C_003E8__1.ATqvD9DmBTj.NeedVerify && !string.Equals(_003C_003E8__1.ATqvD9DmBTj.UserId, AppState.DataService.PZTtmCY0ah7()))
							{
								ActionFeedbackHelper.AddAction(_003C_003E8__1.ATqvD9DmBTj.Id);
							}
							actionEditMgr.Kfitrf6DTx6.NotifyActionEditComplete(actionEditMgr, _003CnewAction_003E5__4.Id, _003CnewAction_003E5__4, profile);
							AppHelper.ShowSuccess("动作安装成功。");
							if (ownerWindow is SearchWindow searchWindow)
							{
								searchWindow.RequestHide();
							}
							result2 = true;
							goto end_IL_01f9;
						}
						break;
						IL_032a:
						awaiter2 = Task.Run((Action)_003C_003E8__1.BSVvDVrfy6C).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							num6 = 0;
							if (owdqZcWWClaC3lqWM7oT == null)
							{
								continue;
							}
							goto IL_036d;
						}
						goto IL_0551;
					}
					goto IL_0472;
					end_IL_01f9:;
				}
				finally
				{
					if (num < 0 && _003Clocker_003E5__2 != null)
					{
						((IDisposable)_003Clocker_003E5__2).Dispose();
					}
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003C_003Et__builder.SetResult(result2);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool cuquVOWW7kDrX2kc4Hhp()
		{
			return owdqZcWWClaC3lqWM7oT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnActionButtonDrop_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionEditMgr _003C_003E4__this;

		public ActionProfile targetProfile;

		public int targetRow;

		public int targetCol;

		public DragEventArgs e;

		public Window ownerWindow;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ActionItem _003Caction_003E5__2;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__3;

		internal static object RsPGitWyc3V40KoiTxoH;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			try
			{
        ActionItem actionItem = default;
				if ((uint)num <= 2u)
				{
					goto IL_00b1;
				}
				actionItem = default(ActionItem);
				if (actionEditMgr.aoWtrpBsaBq(targetProfile, targetRow, targetCol))
				{
					AppHelper.ShowWarning("此按钮动作正在编辑，不能覆盖。");
				}
				else
				{
					if (!targetProfile.IsGlobalProfile() || !AppState.DataService.Gont6sBnlpf(AppHelper.GetButtonIndex(true, targetRow, targetCol)))
					{
						actionItem = targetProfile.FindActionByLocation(targetRow, targetCol);
						goto IL_00b1;
					}
					AppHelper.ShowVersionLimitInfo("编辑右上角按钮");
					int num2 = 0;
					if (!deGF2JWyWLLKHy8jCwBd())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				goto end_IL_0010;
				IL_00b1:
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					int num4;
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					WinAppItem winAppItem = default(WinAppItem);
					string text = default(string);
					switch (num)
					{
					default:
						if (e.Data.GetDataPresent("quicker-action-drag-item"))
						{
							ActionItemDragObject actionItemDragObject = (ActionItemDragObject)e.Data.GetData("quicker-action-drag-item");
							if (actionItemDragObject == null)
							{
								AppHelper.ShowWarning("获得的拖动对象为空。");
							}
							else
							{
								actionEditMgr.ProcessDragDropAction(actionItemDragObject, targetProfile, targetRow, targetCol);
							}
						}
						else
						{
							if (!e.Data.GetDataPresent(typeof(SharedActionListDto)))
							{
								goto IL_01ff;
							}
							if (e.Data.GetData(typeof(SharedActionListDto)) is SharedActionListDto sharedActionListDto)
							{
								awaiter2 = actionEditMgr.InstallAction(actionItem, AppHelper.CreateSharedActionLink(sharedActionListDto.Id.ToString()), targetProfile, targetRow, targetCol, ownerWindow).ConfigureAwait(false).GetAwaiter();
								goto IL_0397;
							}
							AppHelper.ShowWarning("动作内容为空。");
						}
						goto end_IL_00b1;
					case 0:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num4 = 2;
						if (RsPGitWyc3V40KoiTxoH != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						goto IL_029d;
					case 1:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0437;
					case 2:
						break;
						IL_0437:
						awaiter.GetResult();
						goto end_IL_00b1;
						IL_0359:
						_003Caction_003E5__2 = new ActionItem
						{
							ActionType = ActionType.RunProgram,
							Data = winAppItem.FullPath,
							Title = winAppItem.DisplayName
						};
						break;
						IL_029d:
						switch (num4)
						{
						case 1:
							goto IL_0359;
						case 2:
							goto IL_038b;
						case 3:
							goto IL_0397;
						case 4:
							goto IL_03d2;
						case 5:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01ff;
						IL_038b:
						num = -1;
						_003C_003E1__state = -1;
						goto IL_03c5;
						IL_03d2:
						actionItem.Icon = "fa:" + text;
						goto IL_03e5;
						IL_0397:
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_03c5;
						IL_03e5:
						actionEditMgr.SetButtonAction(targetProfile, targetRow, targetCol, actionItem);
						goto end_IL_00b1;
						IL_03c5:
						awaiter2.GetResult();
						goto end_IL_00b1;
						IL_01ff:
						if (e.Data.GetDataPresent(DataFormats.FileDrop))
						{
							string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
							if (array.HasData())
							{
								string string_ = array[0];
								awaiter = actionEditMgr.dmwtrDfZl5m(string_, targetProfile, targetRow, targetCol).ConfigureAwait(false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 1;
									_003C_003E1__state = 1;
									_003C_003Eu__2 = awaiter;
									num4 = 5;
									if (deGF2JWyWLLKHy8jCwBd())
									{
										goto IL_029d;
									}
									goto IL_0397;
								}
								goto IL_0437;
							}
						}
						else if (e.Data.GetDataPresent("win-app-item"))
						{
							winAppItem = e.Data.GetData("win-app-item") as WinAppItem;
							if (winAppItem != null)
							{
								goto IL_0359;
							}
							AppHelper.ShowWarning("拖动的对象为空。");
						}
						else if (e.Data.GetDataPresent("FA_ICON") && actionItem != null)
						{
							text = e.Data.GetData("FA_ICON") as string;
							if (Enum.TryParse<EFontAwesomeIcon>(text, out var result))
							{
								goto IL_03d2;
							}
							goto IL_03e5;
						}
						goto end_IL_00b1;
					}
					try
					{
						ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter3;
						if (num != 2)
						{
							awaiter3 = actionEditMgr.PjUtrisBbF8.GetFileOrFolderIconAsync(winAppItem.FullPath).ConfigureAwait(true).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 2;
								_003C_003E1__state = 2;
								_003C_003Eu__3 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
						}
						else
						{
							awaiter3 = _003C_003Eu__3;
							_003C_003Eu__3 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
						}
						string result2 = awaiter3.GetResult();
						if (result2 != null)
						{
							int num6 = 0;
							if (!deGF2JWyWLLKHy8jCwBd())
							{
								int num7 = default(int);
								num6 = num7;
							}
							switch (num6)
							{
							default:
								_003Caction_003E5__2.Icon = result2;
								break;
							}
						}
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("保存图标失败！" + ex.Message);
					}
					actionEditMgr.SetButtonAction(targetProfile, targetRow, targetCol, _003Caction_003E5__2);
					_003Caction_003E5__2 = null;
					end_IL_00b1:;
				}
				catch (Exception exception)
				{
					string message = "拖放内容到动作按钮出错：" + exception.GetMessageWithInner();
					qiytpSkwiIN.Warn(message, exception);
					AppHelper.ShowWarning(message);
				}
				end_IL_0010:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003COnActionButtonDrop_003Ed__48()
		{
		}

		internal static bool deGF2JWyWLLKHy8jCwBd()
		{
			return RsPGitWyc3V40KoiTxoH == null;
		}

		internal static void JkGjKTWynBP7Nh7jHQly()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPasteAction_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionEditMgr _003C_003E4__this;

		public ActionProfile profile;

		public int row;

		public int col;

		private ActionItem _003Citem_003E5__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object FH4trAWyevQkofsHjMsw;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			try
			{
				if (num != 0 && !ClipboardHelper.ContainsData("quicker-action-item"))
				{
					AppHelper.ShowWarning("剪贴板中没有数据。");
				}
				else
				{
					try
					{
						ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						if (num == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0160;
						}
						_003Citem_003E5__2 = (ActionItem)ClipboardHelper.GetData("quicker-action-item");
						int num2;
						if (_003Citem_003E5__2 != null)
						{
							if (AppState.CuttingAction != null && AppState.CuttingAction.Id == _003Citem_003E5__2.Id)
							{
								awaiter = actionEditMgr.DeleteAction(AppState.CuttingActionProfile, AppState.CuttingAction, false, true).ConfigureAwait(true).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto IL_0160;
								}
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								num2 = 0;
								if (FH4trAWyevQkofsHjMsw == null)
								{
									goto IL_0124;
								}
							}
							else
							{
								bool newId = actionEditMgr.kB4tpwTmVen.GetActionById(_003Citem_003E5__2.Id).action != null;
								actionEditMgr.SetButtonAction(profile, row, col, _003Citem_003E5__2.Clone(newId));
								num2 = 1;
								if (pxrRSXWyjWp016gfGwg6())
								{
									goto IL_0124;
								}
							}
							goto IL_0131;
						}
						AppHelper.ShowWarning("无法粘贴，内容位空。");
						goto end_IL_002e;
						IL_0131:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_0124:
						switch (num2)
						{
						case 1:
							goto IL_0193;
						}
						goto IL_0131;
						IL_0160:
						awaiter.GetResult();
						actionEditMgr.SetButtonAction(profile, row, col, _003Citem_003E5__2);
						AppState.CuttingActionProfile = null;
						AppState.CuttingAction = null;
						goto IL_0193;
						IL_0193:
						_003Citem_003E5__2 = null;
						end_IL_002e:;
					}
					catch (Exception ex)
					{
						qiytpSkwiIN.Warn("粘贴动作出错：" + ex.Message, ex);
						AppHelper.ShowWarning("粘贴动作出错：" + ex.Message);
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool pxrRSXWyjWp016gfGwg6()
		{
			return FH4trAWyevQkofsHjMsw == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPasteIconAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public ActionItem action;

		public ActionEditMgr _003C_003E4__this;

		public ActionProfile profile;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object BC2uBOWy3nyqnBM6yUVp;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			bool result;
			try
			{
				if (num == 0)
				{
					goto IL_0231;
				}
				int num2;
				if (num != 1)
				{
					if (ClipboardHelper.IsClipboardHasIconUrl())
					{
						string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
						if (!string.IsNullOrEmpty(text))
						{
							action.Icon = text;
							action.LastEditTimeUtc = DateTime.UtcNow;
							actionEditMgr.orltrlKx8rp.SaveProfile(profile, false);
							actionEditMgr.Kfitrf6DTx6.NotifyActionEditComplete(actionEditMgr, action?.Id, action, profile);
							result = true;
							num2 = 1;
							if (!bhoMB7WyE7DtDdYiH6Vn())
							{
								int num3 = default(int);
								num2 = num3;
							}
							goto IL_0375;
						}
					}
					if (ClipboardHelper.GetImage() == null)
					{
						if (ClipboardHelper.IsClipboardHasIconFile())
						{
							goto IL_0231;
						}
						AppHelper.ShowWarning("没有要粘贴的图标。");
						goto IL_0363;
					}
				}
				try
				{
        ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default;
					int num4;
					if (num != 1)
					{
						num4 = 0;
						if (BC2uBOWy3nyqnBM6yUVp != null)
						{
							goto IL_012c;
						}
						goto IL_0130;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_019b;
					IL_019b:
					string result2 = awaiter.GetResult();
					action.Icon = result2;
					action.LastEditTimeUtc = DateTime.UtcNow;
					actionEditMgr.orltrlKx8rp.SaveProfile(profile, false);
					actionEditMgr.Kfitrf6DTx6.NotifyActionEditComplete(actionEditMgr, action?.Id, action, profile);
					result = true;
					goto end_IL_00d9;
					IL_0130:
					while (true)
					{
						string text2;
						switch (num4)
						{
						default:
							text2 = IconHelper.WriteClipboardImageToTempFile();
							if (string.IsNullOrEmpty(text2))
							{
								AppHelper.ShowWarning("没有要粘贴的图标。");
								goto end_IL_0130;
							}
							goto IL_0100;
						case 1:
							if (!awaiter.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto IL_019b;
						IL_0100:
						awaiter = actionEditMgr.PjUtrisBbF8.UploadIconImageFileAsync(text2).ConfigureAwait(true).GetAwaiter();
						num4 = 1;
						if (BC2uBOWy3nyqnBM6yUVp == null)
						{
							continue;
						}
						goto IL_012c;
						continue;
						end_IL_0130:
						break;
					}
					goto IL_0228;
					IL_012c:
					int num5 = default(int);
					num4 = num5;
					goto IL_0130;
					end_IL_00d9:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("粘贴图标出错。" + ex.Message);
					goto IL_0228;
				}
				goto end_IL_0010;
				IL_0228:
				result = false;
				goto end_IL_0010;
				IL_0363:
				result = false;
				num2 = 0;
				if (bhoMB7WyE7DtDdYiH6Vn())
				{
					goto IL_0375;
				}
				goto end_IL_0010;
				IL_0375:
				switch (num2)
				{
				case 1:
					break;
				}
				goto end_IL_0010;
				IL_0231:
				try
				{
        ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default;
					awaiter = default;
					int num6;
					if (num != 0)
					{
						string imageFile = ClipboardHelper.GetFileDropList()[0];
						awaiter = actionEditMgr.PjUtrisBbF8.UploadIconImageFileAsync(imageFile).ConfigureAwait(true).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_02c9;
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						num6 = 1;
						if (BC2uBOWy3nyqnBM6yUVp != null)
						{
							int num7 = default(int);
							num6 = num7;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num6 = 0;
						if (BC2uBOWy3nyqnBM6yUVp == null)
						{
							goto IL_02b3;
						}
					}
					switch (num6)
					{
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_02b3;
					IL_02c9:
					string result3 = awaiter.GetResult();
					action.Icon = result3;
					action.LastEditTimeUtc = DateTime.UtcNow;
					actionEditMgr.orltrlKx8rp.SaveProfile(profile, false);
					actionEditMgr.Kfitrf6DTx6.NotifyActionEditComplete(actionEditMgr, action?.Id, action, profile);
					result = true;
					goto end_IL_0231;
					IL_02b3:
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_02c9;
					end_IL_0231:;
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning("粘贴图标出错。" + ex2.Message);
					goto IL_0363;
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool bhoMB7WyE7DtDdYiH6Vn()
		{
			return BC2uBOWy3nyqnBM6yUVp == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPasteLinkAction_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionEditMgr _003C_003E4__this;

		public ActionProfile profile;

		public int row;

		public int col;

		private static object IGiF45WyKA5xApsPMQYL;

		private void MoveNext()
		{
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			try
			{
				if (!ClipboardHelper.ContainsData("quicker-action-item"))
				{
					AppHelper.ShowWarning("剪贴板中没有数据。");
				}
				else
				{
					ActionItem actionItem = (ActionItem)ClipboardHelper.GetData("quicker-action-item");
					if (actionItem == null)
					{
						AppHelper.ShowWarning("无法粘贴，内容位空。");
					}
					else
					{
						ActionItem action = actionEditMgr.cq4trdU9GPh(actionItem);
						int num = 0;
						if (!tOVJU4WyB4XSKBpKpsjt())
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						default:
							actionEditMgr.SetButtonAction(profile, row, col, action);
							break;
						}
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003CPasteLinkAction_003Ed__65()
		{
		}

		internal static bool tOVJU4WyB4XSKBpKpsjt()
		{
			return IGiF45WyKA5xApsPMQYL == null;
		}

		internal static void L1pvfPWyOK9NInKkpO5C()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessDropFileAsync_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionProfile targetProfile;

		public int targetRow;

		public int targetCol;

		public ActionEditMgr _003C_003E4__this;

		public string filepath;

		private ActionItem _003ColdAction_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ActionItem _003C_003E7__wrap2;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__2;

		internal static object EfY90qWyJx8gdP266xom;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			try
			{
				int num2;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				switch (num)
				{
				default:
					_003ColdAction_003E5__2 = targetProfile.FindActionByLocation(targetRow, targetCol);
					if (_003ColdAction_003E5__2 == null)
					{
						awaiter = actionEditMgr.CreateOpenFileOrFolderActionAsync(targetProfile, targetRow, targetCol, filepath, false).ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01fc;
					}
					if (!filepath.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !filepath.EndsWith(".svg", StringComparison.OrdinalIgnoreCase))
					{
						num2 = 0;
						if (EfY90qWyJx8gdP266xom != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_0197;
					}
					if (new FileInfo(filepath).Length >= 10000L)
					{
						goto IL_0107;
					}
					goto case 1;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01fc;
				case 1:
					try
					{
						ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2;
						if (num != 1)
						{
							_003C_003E7__wrap2 = _003ColdAction_003E5__2;
							ConfiguredTaskAwaitable<string> configuredTaskAwaitable = actionEditMgr.PjUtrisBbF8.UploadIconImageFileAsync(filepath).ConfigureAwait(true);
							int num4 = 0;
							if (!dnY376Wyk3m8xlAyvHyh())
							{
								int num5 = default(int);
								num4 = num5;
							}
							switch (num4)
							{
							}
							awaiter2 = configuredTaskAwaitable.GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
						}
						string result = awaiter2.GetResult();
						_003C_003E7__wrap2.Icon = result;
						_003C_003E7__wrap2 = null;
						actionEditMgr.orltrlKx8rp.SaveProfile(targetProfile, false);
						actionEditMgr.Kfitrf6DTx6.NotifyActionEditComplete(actionEditMgr, _003ColdAction_003E5__2?.Id, _003ColdAction_003E5__2, targetProfile);
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("无法保存图标！" + ex.Message);
					}
					goto end_IL_0010;
				case 2:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						break;
					}
					IL_01ad:
					if (!awaiter.IsCompleted)
					{
						num = 2;
						_003C_003E1__state = 2;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_0107:
					while (MessageBoxHelper.Show("请注意，当前动作将被覆盖！\r\n如果您希望更换图标，请确保png文件小于10KiB。\r\n您确认要将当前动作替换为打开文件(夹)“" + filepath + "”么?", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						actionEditMgr.mTetrzZiEIl.BackupAction(_003ColdAction_003E5__2, ActionBackupType.Deleting, DateTime.MaxValue, "覆盖动作");
						awaiter = actionEditMgr.CreateOpenFileOrFolderActionAsync(targetProfile, targetRow, targetCol, filepath, false).ConfigureAwait(false).GetAwaiter();
						num2 = 1;
						if (EfY90qWyJx8gdP266xom != null)
						{
							continue;
						}
						goto IL_0197;
					}
					goto end_IL_0010;
					IL_01fc:
					awaiter.GetResult();
					goto end_IL_0010;
					IL_0197:
					switch (num2)
					{
					case 1:
						goto IL_01ad;
					case 2:
						goto end_IL_0010;
					}
					goto IL_0107;
				}
				awaiter.GetResult();
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003ColdAction_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003ColdAction_003E5__2 = null;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool dnY376Wyk3m8xlAyvHyh()
		{
			return EfY90qWyJx8gdP266xom == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateSharedActionAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string message)> _003C_003Et__builder;

		public string actionId;

		public ActionEditMgr _003C_003E4__this;

		public string changeLog;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		private (ActionItem action, ActionProfile profile) _003CactionInfo_003E5__2;

		private ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object aeQOvkWy9MMMcDtwag3S;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionEditMgr actionEditMgr = _003C_003E4__this;
			(bool, string) result = default((bool, string));
			try
			{
				int num2;
				if ((uint)num > 1u)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass27_0();
					_003C_003E8__1.wHsvD8Mpqww = actionId;
					_003C_003E8__1.dDjvDaICn96 = _003C_003E4__this;
					num2 = 1;
					if (!o7SvIUWyLNn41HcfEKWB())
					{
						goto IL_0055;
					}
					goto IL_01c1;
				}
				goto IL_024c;
				IL_01bd:
				int num3 = default(int);
				num2 = num3;
				goto IL_01c1;
				IL_0055:
				if (!AppState.DataService.BV9tm7kpqII() && !AppState.DataService.JTftmqIPFYx())
				{
					if (!actionEditMgr.kr8tp2sZD2W.Any(_003C_003E8__1.SkYvDyaPv9Y))
					{
						_003CactionInfo_003E5__2 = actionEditMgr.kB4tpwTmVen.GetActionById(_003C_003E8__1.wHsvD8Mpqww);
						_003C_003E8__1.zn2vD7IfGjU = _003CactionInfo_003E5__2.action;
						if (_003C_003E8__1.zn2vD7IfGjU == null)
						{
							goto IL_0217;
						}
						if (Guid.Empty == Guid.Parse(_003C_003E8__1.wHsvD8Mpqww))
						{
							num2 = 0;
							if (!o7SvIUWyLNn41HcfEKWB())
							{
								goto IL_01bd;
							}
							goto IL_01c1;
						}
						DateTime? lastEditTimeUtc = _003C_003E8__1.zn2vD7IfGjU.LastEditTimeUtc;
						DateTime? shareTimeUtc = _003C_003E8__1.zn2vD7IfGjU.ShareTimeUtc;
						if (!(lastEditTimeUtc.HasValue & shareTimeUtc.HasValue) || !(lastEditTimeUtc.GetValueOrDefault() <= shareTimeUtc.GetValueOrDefault()) || _003C_003E8__1.zn2vD7IfGjU.Data.Contains("%%"))
						{
							if (string.IsNullOrEmpty(_003C_003E8__1.zn2vD7IfGjU.SharedActionId))
							{
								result = (false, "动作 " + _003C_003E8__1.zn2vD7IfGjU.Title + " 未分享，不能更新。");
								num2 = 2;
								if (aeQOvkWy9MMMcDtwag3S != null)
								{
									goto IL_01bd;
								}
								goto IL_01c1;
							}
							if (!string.IsNullOrEmpty(changeLog))
							{
								goto IL_024c;
							}
							result = (false, "更新说明不能为空。");
						}
						else
						{
							result = (false, "动作未修改，不需要更新分享。");
						}
					}
					else
					{
						result = (false, "动作正在编辑中，不能分享动作。");
					}
				}
				else
				{
					result = (false, "需要登录到帐号后方可使用此功能。");
				}
				goto end_IL_0010;
				IL_024c:
				try
				{
					if (num == 0)
					{
						goto IL_0307;
					}
					ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
					if (num != 1)
					{
						int num4 = 2;
						if (aeQOvkWy9MMMcDtwag3S != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						while (true)
						{
							switch (num4)
							{
							case 2:
								awaiter = aFIptTXYsUoTUF4v33R.nGpt1D5WKDf(_003CactionInfo_003E5__2.action).ConfigureAwait(true).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									_003C_003E1__state = 0;
									_003C_003Eu__1 = awaiter;
									num4 = 0;
									if (!o7SvIUWyLNn41HcfEKWB())
									{
										continue;
									}
									goto case 1;
								}
								goto IL_0325;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								break;
							default:
								goto IL_0307;
							}
							break;
						}
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0615;
					IL_0615:
					ApiResult<SharedActionDto> result2 = awaiter.GetResult();
					if (result2.IsSuccess)
					{
						_003C_003Ec__DisplayClass27_1 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_1();
						_003C_003Ec__DisplayClass27_.ttjvDcD7uv3 = _003C_003E8__1;
						_003C_003Ec__DisplayClass27_.u3OvDq3g76q = result2.Data;
						_003C_003Ec__DisplayClass27_.ttjvDcD7uv3.zn2vD7IfGjU.ShareTimeUtc = AppHelper.GetUtcNowForDb();
						actionEditMgr.orltrlKx8rp.SaveProfile(_003CactionInfo_003E5__2.profile, false);
						Task.Run((Action)_003C_003Ec__DisplayClass27_.hGWvDRTWTSw);
						result = (true, "更新分享成功。");
					}
					else
					{
						result = (false, "分享失败。" + result2.Message);
					}
					goto end_IL_024c;
					IL_0325:
					ApiResult<SharedActionDto> result3 = awaiter.GetResult();
					if (!result3.IsSuccess)
					{
						result = (false, "获取共享动作信息失败：" + result3.Message);
					}
					else
					{
						SharedActionDto data = result3.Data;
						if (data != null)
						{
							SharedActionVm sharedActionVm = new SharedActionVm
							{
								Id = data?.Id,
								ActionType = _003C_003E8__1.zn2vD7IfGjU.ActionType,
								Title = data.Title,
								Data = _003C_003E8__1.zn2vD7IfGjU.Data,
								Data2 = _003C_003E8__1.zn2vD7IfGjU.Data2,
								Data3 = _003C_003E8__1.zn2vD7IfGjU.Data3,
								Description = data.Description,
								InternalId = _003C_003E8__1.zn2vD7IfGjU.Id,
								SourceSharedActionId = _003C_003E8__1.zn2vD7IfGjU.TemplateId,
								SourceSharedActionRevision = _003C_003E8__1.zn2vD7IfGjU.TemplateRevision,
								SourceProfileId = _003CactionInfo_003E5__2.profile.Id,
								Language = Thread.CurrentThread.CurrentCulture.Name,
								Icon = _003C_003E8__1.zn2vD7IfGjU.Icon,
								Tags = data.Tags,
								IsPublic = data.IsPublic,
								ChangeLog = changeLog,
								SoftVersion = AppHelper.GetSoftVersion(),
								MinQuickerVersion = _003C_003E8__1.zn2vD7IfGjU.MinQuickerVersion,
								UserLimitation = data.UserLimitation,
								ContextMenuData = _003C_003E8__1.zn2vD7IfGjU.ContextMenuData,
								EnableEvaluateVariable = _003C_003E8__1.zn2vD7IfGjU.EnableEvaluateVariable,
								DoNotClosePanel = (_003C_003E8__1.zn2vD7IfGjU.DoNotClosePanel == true),
								AllowScrollTrigger = _003C_003E8__1.zn2vD7IfGjU.AllowScrollTrigger,
								Association = _003C_003E8__1.zn2vD7IfGjU.Association,
								ExeFile = data.ExeFile,
								ExeFullpath = data.ExeFullpath
							};
							if (_003C_003E8__1.zn2vD7IfGjU.ActionType == ActionType.XAction)
							{
								try
								{
									sharedActionVm.Data = ShareActionHelper.EmbedGlobalSubPrograms(_003C_003E8__1.zn2vD7IfGjU.Data);
								}
								catch (Exception exception)
								{
									result = (false, "将公共子程序转换为内部子程序时出错。" + exception.GetMessageWithInner());
									goto end_IL_024c;
								}
							}
							awaiter = aFIptTXYsUoTUF4v33R.vnvt1pYyGU6(sharedActionVm).ConfigureAwait(true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0615;
						}
						result = (false, "就动作数据为空");
					}
					goto end_IL_024c;
					IL_0307:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0325;
					end_IL_024c:;
				}
				catch (Exception ex)
				{
					qiytpSkwiIN.Warn("通过代码UpdateShareAction出错：" + ex.Message, ex);
					result = (false, "分享动作出错：" + ex.Message);
				}
				goto end_IL_0010;
				IL_0217:
				result = (false, "未找到动作：" + _003C_003E8__1.wHsvD8Mpqww);
				goto end_IL_0010;
				IL_01c1:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_0217;
				case 2:
					goto end_IL_0010;
				}
				goto IL_0055;
				end_IL_0010:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003CactionInfo_003E5__2 = default((ActionItem, ActionProfile));
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003CactionInfo_003E5__2 = default((ActionItem, ActionProfile));
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool o7SvIUWyLNn41HcfEKWB()
		{
			return aeQOvkWy9MMMcDtwag3S == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CVoteActionAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionItem action;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Ib0HZdWyZUur4QxtC2AZ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num != 0 && (AppState.DataService.BV9tm7kpqII() || AppState.DataService.JTftmqIPFYx()))
				{
					AppHelper.ShowInformation("登录您的帐号后方可使用此功能。");
				}
				else
				{
					try
					{
						ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = aFIptTXYsUoTUF4v33R.KtUt1lKVWry(Guid.Parse(action.TemplateId)).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								if (Ib0HZdWyZUur4QxtC2AZ != null)
								{
									switch (0)
									{
									}
								}
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
						}
						ApiResult<string> result = awaiter.GetResult();
						if (result.IsSuccess)
						{
							AppHelper.ShowInformation("点赞成功了！谢谢你~");
						}
						else
						{
							AppHelper.ShowInformation(result.Message);
						}
					}
					catch (Exception ex)
					{
						qiytpSkwiIN.Warn("点赞异常。", ex);
						AppHelper.ShowWarning("操作异常：" + ex.Message);
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool AdlKAjWy5l9JNLtNpFUg()
		{
			return Ib0HZdWyZUur4QxtC2AZ == null;
		}
	}

	private readonly AppServer orltrlKx8rp;

	private readonly IconManager PjUtrisBbF8;

	private readonly PanelState DZZtr3VVGYn;

	private readonly ITinyMessengerHub Kfitrf6DTx6;

	private readonly SQLDataMgr mTetrzZiEIl;

	private readonly DataService kB4tpwTmVen;

	private readonly ProfileManager qMdtptd2UCL;

	private readonly IKernel vFdtpgdWYM0;

	private readonly FloatButtonAndPanelManager mNttpLTwBmW;

	private readonly TextFloatPanelMgr qoYtpv5p7Bo;

	private static readonly ILog qiytpSkwiIN;

	private readonly IList<EditingActionInfo> kr8tp2sZD2W = new List<EditingActionInfo>();

	internal static ActionEditMgr S92giaQNUaQ8o0FnJnaO;

	public ActionEditMgr(AppServer appServer, IconManager iconManager, PanelState panelState, ITinyMessengerHub hub, SQLDataMgr sqlDataMgr, DataService dataService, ProfileManager profileManager, IKernel container, FloatButtonAndPanelManager floatButtonAndPanelManager, TextFloatPanelMgr textFloatPanelMgr)
	{
		orltrlKx8rp = appServer;
		PjUtrisBbF8 = iconManager;
		DZZtr3VVGYn = panelState;
		Kfitrf6DTx6 = hub;
		mTetrzZiEIl = sqlDataMgr;
		kB4tpwTmVen = dataService;
		qMdtptd2UCL = profileManager;
		vFdtpgdWYM0 = container;
		mNttpLTwBmW = floatButtonAndPanelManager;
		qoYtpv5p7Bo = textFloatPanelMgr;
		AppState.COBtapKhJtY(this);
	}

	public bool IsEditing()
	{
		return kr8tp2sZD2W.Count > 0;
	}

	public bool IsEditingProfile(ActionProfile profile)
	{
		foreach (EditingActionInfo item in kr8tp2sZD2W)
		{
			if (item.Profile == profile)
			{
				return true;
			}
		}
		return false;
	}

	public bool IsButtonEditing(int btnIndex)
	{
		if (!IsEditing())
		{
			return false;
		}
		ActionProfile profileByButtonIndex = DZZtr3VVGYn.GetProfileByButtonIndex(btnIndex);
		(bool isGlobal, int row, int column) buttonLocation = AppHelper.GetButtonLocation(btnIndex);
		int item = buttonLocation.row;
		int item2 = buttonLocation.column;
		return aoWtrpBsaBq(profileByButtonIndex, item, item2);
	}

	private bool aoWtrpBsaBq(ActionProfile actionProfile_0, int int_0, int int_1)
	{
		foreach (EditingActionInfo item in kr8tp2sZD2W)
		{
			if (item.Profile == actionProfile_0 && item.Row == int_0 && item.Col == int_1)
			{
				return true;
			}
		}
		return false;
	}

	public void ShowEditor()
	{
		if (IsEditing())
		{
			try
			{
				exdtrBJbnaK(kr8tp2sZD2W[0].Editor);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("恢复编辑器窗口出错：" + ex.Message);
			}
		}
	}

	public void ShowEditor(ActionProfile profile, int row, int col)
	{
		foreach (EditingActionInfo item in kr8tp2sZD2W)
		{
			if (item.Profile == profile && item.Row == row && item.Col == col)
			{
				try
				{
					exdtrBJbnaK(item.Editor);
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("恢复编辑器窗口出错：" + ex.Message);
				}
			}
		}
	}

	private static void exdtrBJbnaK(Window window_0)
	{
		if (window_0 == null || !window_0.IsLoaded)
		{
			return;
		}
		try
		{
			if (window_0.WindowState == WindowState.Minimized)
			{
				window_0.WindowState = WindowState.Normal;
			}
			window_0.Show();
			window_0.Activate();
		}
		catch (Exception exception)
		{
			qiytpSkwiIN.Warn("恢复窗口异常。" + exception.GetMessageWithInner(), exception);
		}
	}

	private void RyRtrQqS621(EditingActionInfo editingActionInfo_0)
	{
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.HT2v5m6hkqI = editingActionInfo_0;
		kr8tp2sZD2W.Remove(_003C_003Ec__DisplayClass20_.HT2v5m6hkqI);
		foreach (EditingActionInfo item in kr8tp2sZD2W.Where(_003C_003Ec__DisplayClass20_.EdHv5XkHYw6).ToList())
		{
			kr8tp2sZD2W.Remove(item);
		}
	}

	public void EditAction(ActionProfile profile, int row, int col, ActionItem actionItem, ActionType? newActionType, EditActionParam editParam = null, bool forceReadonly = false)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.YSbv5xaYNkS = this;
		_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7 = actionItem;
		_003C_003Ec__DisplayClass21_.g9Tv5nj8IOE = profile;
		if (aoWtrpBsaBq(_003C_003Ec__DisplayClass21_.g9Tv5nj8IOE, row, col))
		{
			ShowEditor(_003C_003Ec__DisplayClass21_.g9Tv5nj8IOE, row, col);
			AppState.HS2taepcAbc().RequestHide();
			return;
		}
		_003C_003Ec__DisplayClass21_.arDv5QGrtPy = new EditingActionInfo
		{
			Profile = _003C_003Ec__DisplayClass21_.g9Tv5nj8IOE,
			ActionId = _003C_003Ec__DisplayClass21_.shCv5rZ2Ej7?.Id,
			Row = row,
			Col = col
		};
		kr8tp2sZD2W.Add(_003C_003Ec__DisplayClass21_.arDv5QGrtPy);
		Kfitrf6DTx6.NotifyActionEditBegin(this, _003C_003Ec__DisplayClass21_.arDv5QGrtPy);
		AppState.HS2taepcAbc().EnableKeyTrigger = false;
		AppState.HS2taepcAbc().RequestHide();
		ActionItem actionItem3;
		object obj;
		if (_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7 == null && newActionType == ActionType.XAction)
		{
			_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7 = ActionTypeManager.CreateActionItem(ActionType.XAction);
			_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.Row = row;
			_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.Col = col;
			_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.CreateTimeUtc = AppHelper.GetUtcNowForDb();
			IList<ActionItem> list = kB4tpwTmVen.S0KtXvrNDeP("_template_");
			if (list.HasData())
			{
				ActionItem actionItem2 = list[0];
				_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.Data = actionItem2.Data;
				_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.Association = AppHelper.Clone(actionItem2.Association);
				_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.ContextMenuData = actionItem2.ContextMenuData;
				_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.EnableEvaluateVariable = actionItem2.EnableEvaluateVariable;
			}
			if (!string.Equals(AppState.HHxtaMaoqJr()?.NewActionDefaultIcon, "auto"))
			{
				actionItem3 = _003C_003Ec__DisplayClass21_.shCv5rZ2Ej7;
				UserSettings userSettings = AppState.HHxtaMaoqJr();
				if (userSettings == null)
				{
					obj = null;
				}
				else
				{
					obj = userSettings.NewActionDefaultIcon;
					if (obj != null)
					{
						goto IL_01d5;
					}
				}
				obj = "";
				goto IL_01d5;
			}
			_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.Icon = $"fa:{AppHelper.RandomEnumValue<EFontAwesomeIcon>()}";
		}
		goto IL_01da;
		IL_01da:
		_003C_003Ec__DisplayClass21_.SV2v5BbwEZ4 = _003C_003Ec__DisplayClass21_.shCv5rZ2Ej7;
		_003C_003Ec__DisplayClass21_.arDv5QGrtPy.ActionId = _003C_003Ec__DisplayClass21_.SV2v5BbwEZ4?.Id;
		_003C_003Ec__DisplayClass21_.Edav5p4loUB = false;
		_003C_003Ec__DisplayClass21_.Brkv5jF2Cyo = null;
		if (_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7 != null && _003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.UseTemplate && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass21_.shCv5rZ2Ej7.TemplateId))
		{
			_003C_003Ec__DisplayClass21_1 _003C_003Ec__DisplayClass21_2 = new _003C_003Ec__DisplayClass21_1();
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv = _003C_003Ec__DisplayClass21_;
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4 = JsonConvert.DeserializeObject<ActionItem>(JsonConvert.SerializeObject(_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.shCv5rZ2Ej7));
			_003C_003Ec__DisplayClass21_2.RoYv5DXQkYS = null;
			try
			{
				Task.Run((Action)_003C_003Ec__DisplayClass21_2.Uufv55mRvdP).Wait(1000);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("无法下载动作，可能网络不通或原始动作已删除。" + exception.GetMessageWithInner());
				RyRtrQqS621(_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.arDv5QGrtPy);
				Kfitrf6DTx6.NotifyActionEditComplete(this, _003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4?.Id, _003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4, _003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.g9Tv5nj8IOE);
				return;
			}
			if (_003C_003Ec__DisplayClass21_2.RoYv5DXQkYS == null)
			{
				AppHelper.ShowWarning("获取的共享动作为空。");
				RyRtrQqS621(_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.arDv5QGrtPy);
				Kfitrf6DTx6.NotifyActionEditComplete(this, _003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4?.Id, _003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4, _003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.g9Tv5nj8IOE);
				return;
			}
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.Brkv5jF2Cyo = _003C_003Ec__DisplayClass21_2.RoYv5DXQkYS.Data;
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4.Data = _003C_003Ec__DisplayClass21_2.RoYv5DXQkYS.Data;
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4.Data2 = _003C_003Ec__DisplayClass21_2.RoYv5DXQkYS.Data2;
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4.Data3 = _003C_003Ec__DisplayClass21_2.RoYv5DXQkYS.Data3;
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4.Children = _003C_003Ec__DisplayClass21_2.RoYv5DXQkYS.Children;
			_003C_003Ec__DisplayClass21_2.BYuv5dZ9wCv.SV2v5BbwEZ4.UseTemplate = false;
		}
		object[] array = new object[4];
		ActionItem actionItem4 = _003C_003Ec__DisplayClass21_.shCv5rZ2Ej7;
		object obj2;
		if (actionItem4 == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = actionItem4.Title;
			if (obj2 != null)
			{
				goto IL_042e;
			}
		}
		obj2 = "新动作";
		goto IL_042e;
		IL_042e:
		array[0] = obj2;
		array[1] = _003C_003Ec__DisplayClass21_.g9Tv5nj8IOE.DisplayName;
		array[2] = row + 1;
		array[3] = col + 1;
		string title = string.Format("{0} -- {1} {2}行 {3}列 -- 编辑动作", array);
		if (_003C_003Ec__DisplayClass21_.SV2v5BbwEZ4 != null && _003C_003Ec__DisplayClass21_.SV2v5BbwEZ4.ActionType == ActionType.XAction)
		{
			_003C_003Ec__DisplayClass21_2 _003C_003Ec__DisplayClass21_3 = new _003C_003Ec__DisplayClass21_2();
			_003C_003Ec__DisplayClass21_3.yrbv5Mi0Ouj = _003C_003Ec__DisplayClass21_;
			_003C_003Ec__DisplayClass21_3.yrbv5Mi0Ouj.Edav5p4loUB = forceReadonly;
			_003C_003Ec__DisplayClass21_3.oNcv5TUGbdl = new ActionDesignerWindow(mTetrzZiEIl, _003C_003Ec__DisplayClass21_3.yrbv5Mi0Ouj.SV2v5BbwEZ4, false, _003C_003Ec__DisplayClass21_3.yrbv5Mi0Ouj.Edav5p4loUB)
			{
				Owner = null,
				Topmost = false,
				EditParam = editParam
			};
			_003C_003Ec__DisplayClass21_3.oNcv5TUGbdl.Title = title;
			_003C_003Ec__DisplayClass21_3.yrbv5Mi0Ouj.arDv5QGrtPy.Editor = _003C_003Ec__DisplayClass21_3.oNcv5TUGbdl;
			_003C_003Ec__DisplayClass21_3.oNcv5TUGbdl.Closed += _003C_003Ec__DisplayClass21_3.lxdv5o0FiVT;
			_003C_003Ec__DisplayClass21_3.oNcv5TUGbdl.ShowActivated = true;
			_003C_003Ec__DisplayClass21_3.oNcv5TUGbdl.Show();
			_003C_003Ec__DisplayClass21_3.oNcv5TUGbdl.Activate();
		}
		else
		{
			_003C_003Ec__DisplayClass21_4 _003C_003Ec__DisplayClass21_4 = new _003C_003Ec__DisplayClass21_4();
			_003C_003Ec__DisplayClass21_4.u5Iv53JnV6M = _003C_003Ec__DisplayClass21_;
			_003C_003Ec__DisplayClass21_4.qbRv5iMcNKo = new ActionEditorWindow(PjUtrisBbF8)
			{
				EditingActionItem = _003C_003Ec__DisplayClass21_4.u5Iv53JnV6M.SV2v5BbwEZ4,
				NewActionType = newActionType,
				Topmost = false
			};
			_003C_003Ec__DisplayClass21_4.qbRv5iMcNKo.Title = title;
			_003C_003Ec__DisplayClass21_4.u5Iv53JnV6M.arDv5QGrtPy.Editor = _003C_003Ec__DisplayClass21_4.qbRv5iMcNKo;
			_003C_003Ec__DisplayClass21_4.qbRv5iMcNKo.Closed += _003C_003Ec__DisplayClass21_4.VJMv5lywCFO;
			_003C_003Ec__DisplayClass21_4.qbRv5iMcNKo.ShowActivated = true;
			_003C_003Ec__DisplayClass21_4.qbRv5iMcNKo.Show();
			_003C_003Ec__DisplayClass21_4.qbRv5iMcNKo.Activate();
		}
		return;
		IL_01d5:
		actionItem3.Icon = (string)obj;
		goto IL_01da;
	}

	private void Q1MtrjGPF2a(ActionItem actionItem_0, string string_0, int int_0 = 30)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		_003C_003Ec__DisplayClass22_.m0Sv5zT0toW = actionItem_0;
		_003C_003Ec__DisplayClass22_.H4kvDwYw3Tq = string_0;
		_003C_003Ec__DisplayClass22_.rFdvDtwDtKh = int_0;
		if (kB4tpwTmVen.Hb9tmk3OsJ7() && kB4tpwTmVen.CpItmVISR7P().EnableAutoBackupActions)
		{
			Task.Run((Func<Task>)_003C_003Ec__DisplayClass22_.wN1v5f1q70m);
		}
	}

	[AsyncStateMachine(typeof(_003CDeleteAction_003Ed__23))]
	public Task<bool> DeleteAction(ActionProfile profile, ActionItem actionItem, bool showConfirm, bool isCuttingAction)
	{
		_003CDeleteAction_003Ed__23 stateMachine = default(_003CDeleteAction_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.profile = profile;
		stateMachine.actionItem = actionItem;
		stateMachine.showConfirm = showConfirm;
		stateMachine.isCuttingAction = isCuttingAction;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static void CopyAction(ActionItem action)
	{
		AppState.CuttingAction = null;
		ClipboardHelper.SetData("quicker-action-item", action);
	}

	public static void CopyActionAndId(ActionItem action)
	{
		AppState.CuttingAction = null;
		DataObject dataObject = new DataObject();
		dataObject.SetData("quicker-action-item", action);
		dataObject.SetText(action.Id);
		ClipboardHelper.SetDataObject(dataObject, true);
	}

	public void ShareAction(ActionItem action, ActionProfile profile, Window ownerWindow)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.VOKvDJ5a6LU = action;
		int num = 0;
		if (S92giaQNUaQ8o0FnJnaO != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		_003C_003Ec__DisplayClass26_.IUcvDCK7pdx = this;
		_003C_003Ec__DisplayClass26_.aJPvDPjNLUx = profile;
		if (!AppState.DataService.BV9tm7kpqII() && !AppState.DataService.JTftmqIPFYx())
		{
			if (!kr8tp2sZD2W.Any(_003C_003Ec__DisplayClass26_.Ee9vD21jkhk))
			{
				AppState.HS2taepcAbc().RequestHide();
				using (BjxbsJXXKfq9q6nXgXg.RPyt1vLAkLm("分享动作"))
				{
					if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass26_.VOKvDJ5a6LU.Id) || Guid.Empty == Guid.Parse(_003C_003Ec__DisplayClass26_.VOKvDJ5a6LU.Id))
					{
						_003C_003Ec__DisplayClass26_.VOKvDJ5a6LU.Id = Guid.NewGuid().ToString();
						int num3 = 0;
						if (S92giaQNUaQ8o0FnJnaO != null)
						{
							int num4 = default(int);
							num3 = num4;
						}
						switch (num3)
						{
						}
					}
					if (_003C_003Ec__DisplayClass26_.VOKvDJ5a6LU.UseTemplate && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass26_.VOKvDJ5a6LU.TemplateId))
					{
						if (MessageBoxHelper.Show("此动作是一个未修改的共享动作，为避免重复，请使用原始共享动作。\n要查看打开动作的页面么？", "Quicker", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
						{
							AppHelper.TryOpenUrlOrFile(AppHelper.CreateSharedActionLink(_003C_003Ec__DisplayClass26_.VOKvDJ5a6LU.TemplateId));
						}
						return;
					}
					_003C_003Ec__DisplayClass26_.LqPvD0OIiyE = new ShareActionWindow
					{
						Profile = _003C_003Ec__DisplayClass26_.aJPvDPjNLUx,
						Action = _003C_003Ec__DisplayClass26_.VOKvDJ5a6LU
					};
					_003C_003Ec__DisplayClass26_.LqPvD0OIiyE.Closed += _003C_003Ec__DisplayClass26_.YqevDuMsfZ0;
					_003C_003Ec__DisplayClass26_.LqPvD0OIiyE.Show();
					_003C_003Ec__DisplayClass26_.LqPvD0OIiyE.Activate();
					return;
				}
			}
			AppHelper.ShowWarning("动作正在编辑中，不能分享动作。");
		}
		else
		{
			AppHelper.ShowInformation("需要登录到帐号后方可使用此功能。");
		}
	}

	[AsyncStateMachine(typeof(_003CUpdateSharedActionAsync_003Ed__27))]
	public Task<(bool isSuccess, string message)> UpdateSharedActionAsync(string actionId, string changeLog)
	{
		_003CUpdateSharedActionAsync_003Ed__27 stateMachine = default(_003CUpdateSharedActionAsync_003Ed__27);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.actionId = actionId;
		stateMachine.changeLog = changeLog;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void fDftrnWFlHD(object sender, EventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003CInstallAction_003Ed__29))]
	public Task<bool> InstallAction(ActionItem oldAction, string sharedActionUrl, ActionProfile profile, int row, int col, Window ownerWindow, bool skipConfirm = false)
	{
		_003CInstallAction_003Ed__29 stateMachine = default(_003CInstallAction_003Ed__29);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.oldAction = oldAction;
		stateMachine.sharedActionUrl = sharedActionUrl;
		stateMachine.profile = profile;
		stateMachine.row = row;
		stateMachine.col = col;
		stateMachine.ownerWindow = ownerWindow;
		stateMachine.skipConfirm = skipConfirm;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CVoteActionAsync_003Ed__30))]
	internal Task QyZtr4R8UOZ(ActionItem actionItem_0)
	{
		_003CVoteActionAsync_003Ed__30 stateMachine = default(_003CVoteActionAsync_003Ed__30);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.action = actionItem_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPasteIconAsync_003Ed__31))]
	public Task<bool> PasteIconAsync(ActionItem action, ActionProfile profile)
	{
		_003CPasteIconAsync_003Ed__31 stateMachine = default(_003CPasteIconAsync_003Ed__31);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.action = action;
		stateMachine.profile = profile;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void EditActionHotkey(ActionItem action)
	{
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
		_003C_003Ec__DisplayClass32_.aOqvDeDwD3K = action;
		if (AppWindowManager.IsSettingPageOpened(SettingPageId.ActionHotkeysSettingPage))
		{
			AppHelper.ShowWarning("为避免数据冲突，请先关闭设置窗口后再设置动作快捷键。");
			return;
		}
		using (BjxbsJXXKfq9q6nXgXg.RPyt1vLAkLm("设置动作快捷键"))
		{
			HotKeySettings hotKeySettings = HotKeySettings.FromData(AppState.DataService.CpItmVISR7P().HotKeysData);
			ActionHotKeyItem actionHotKeyItem = null;
			int num;
			if (hotKeySettings.ActionHotkeys.HasData())
			{
				actionHotKeyItem = hotKeySettings.ActionHotkeys.FirstOrDefault(_003C_003Ec__DisplayClass32_.zUOvDhjoZWH);
				num = 0;
				if (ANdWDHQNx8cgudb22boA())
				{
					goto IL_0085;
				}
			}
			goto IL_0092;
			IL_0098:
			if (!AppState.DataService.QUotbFwOhur())
			{
				AppHelper.ShowHotkeyLimitInfo(null);
				return;
			}
			goto IL_00af;
			IL_0092:
			if (actionHotKeyItem == null)
			{
				num = 1;
				if (!ANdWDHQNx8cgudb22boA())
				{
					goto IL_0085;
				}
				goto IL_0098;
			}
			goto IL_00af;
			IL_00af:
			ActionHotkeyEditorWindow actionHotkeyEditorWindow = new ActionHotkeyEditorWindow
			{
				Owner = AppState.HS2taepcAbc(),
				EditingItem = actionHotKeyItem
			};
			actionHotkeyEditorWindow.SetEditingAction(_003C_003Ec__DisplayClass32_.aOqvDeDwD3K);
			if (actionHotkeyEditorWindow.ShowDialog() == true)
			{
				hotKeySettings.ActionHotkeys.Remove(actionHotKeyItem);
				if (!string.IsNullOrEmpty(actionHotkeyEditorWindow.ResultItem.Keys))
				{
					hotKeySettings.ActionHotkeys.Insert(0, actionHotkeyEditorWindow.ResultItem);
				}
				else
				{
					AppHelper.ShowInformation("动作快捷键已取消。");
				}
				AppState.HHxtaMaoqJr().HotKeysData = hotKeySettings.ToData();
				AppState.DataService.ydot6rVZAkW();
				Kfitrf6DTx6.NotifyUserSettingsChange(this);
			}
			return;
			IL_0085:
			switch (num)
			{
			case 1:
				goto IL_0098;
			}
			goto IL_0092;
		}
	}

	[AsyncStateMachine(typeof(_003CPasteAction_003Ed__33))]
	public Task PasteAction(ActionProfile profile, int row, int col)
	{
		_003CPasteAction_003Ed__33 stateMachine = default(_003CPasteAction_003Ed__33);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.profile = profile;
		stateMachine.row = row;
		stateMachine.col = col;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void CreateAction(ActionProfile profile, int row, int col, ActionType? actionType)
	{
		if (profile.IsGlobalProfile() && AppState.DataService.Gont6sBnlpf(AppHelper.GetButtonIndex(true, row, col)))
		{
			AppHelper.ShowVersionLimitInfo("编辑右上角按钮");
		}
		else if (aoWtrpBsaBq(profile, row, col))
		{
			AppHelper.ShowWarning("正在编辑此按钮动作。");
			ShowEditor(profile, row, col);
		}
		else
		{
			EditAction(profile, row, col, null, actionType);
		}
	}

	public void CreateOrEditGlobalSubProgram(SubProgram subProgram)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.b9ivDGvYwLY = this;
		if (subProgram != null)
		{
			foreach (ActionDesignerWindow item in AppHelper.FindRootWindows<ActionDesignerWindow>())
			{
				if (item.EditingActionItem == null || !(item.EditingActionItem.Id == subProgram.Id))
				{
					continue;
				}
				item.Show();
				if (!ANdWDHQNx8cgudb22boA())
				{
					switch (0)
					{
					}
				}
				item.Activate();
				item.WindowState = WindowState.Normal;
				return;
			}
		}
		_003C_003Ec__DisplayClass35_.fs8vDkNmU0x = ((subProgram == null) ? null : SubProgramHelper.CreateWrapperAction(subProgram));
		_003C_003Ec__DisplayClass35_.ovHvDWxbqS8 = new ActionDesignerWindow(mTetrzZiEIl, _003C_003Ec__DisplayClass35_.fs8vDkNmU0x, true)
		{
			Owner = null
		};
		if (_003C_003Ec__DisplayClass35_.fs8vDkNmU0x == null)
		{
			_003C_003Ec__DisplayClass35_.ovHvDWxbqS8.Title = "创建公共子程序";
		}
		else
		{
			_003C_003Ec__DisplayClass35_.ovHvDWxbqS8.Title = _003C_003Ec__DisplayClass35_.fs8vDkNmU0x.Title + " - 公共子程序";
		}
		_003C_003Ec__DisplayClass35_.ovHvDWxbqS8.Closed += _003C_003Ec__DisplayClass35_.Uk3vDYgNQYx;
		_003C_003Ec__DisplayClass35_.ovHvDWxbqS8.Show();
		_003C_003Ec__DisplayClass35_.ovHvDWxbqS8.Activate();
	}

	public void ShareSubProgram(SubProgram subProgram, Window owner, bool isGlobal)
	{
		if (subProgram == null)
		{
			AppHelper.ShowWarning("要分享的子程序为空。");
			return;
		}
		ShareSubProgramWindow shareSubProgramWindow = new ShareSubProgramWindow
		{
			SubProgram = subProgram,
			Owner = owner
		};
		int num = 0;
		if (!ANdWDHQNx8cgudb22boA())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		shareSubProgramWindow.ShowDialog();
		if (shareSubProgramWindow.NewSharedAction != null)
		{
			subProgram.SharedId = shareSubProgramWindow.NewSharedAction.Id.ToString();
			subProgram.ShareTimeUtc = shareSubProgramWindow.NewSharedAction.LastUpdateTimeUtc ?? DateTime.UtcNow;
			if (isGlobal)
			{
				kB4tpwTmVen.fgstXGxbg6P(subProgram);
			}
		}
	}

	[AsyncStateMachine(typeof(_003CCreateOpenFileOrFolderActionAsync_003Ed__37))]
	public Task CreateOpenFileOrFolderActionAsync(ActionProfile profile, int row, int col, string path, bool useLnkTarget)
	{
		_003CCreateOpenFileOrFolderActionAsync_003Ed__37 stateMachine = default(_003CCreateOpenFileOrFolderActionAsync_003Ed__37);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.profile = profile;
		stateMachine.row = row;
		stateMachine.col = col;
		stateMachine.path = path;
		stateMachine.useLnkTarget = useLnkTarget;
		stateMachine._003C_003E1__state = -1;
		if (!ANdWDHQNx8cgudb22boA())
		{
			switch (0)
			{
			}
		}
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateOpenFileOrFolderActionAsync_003Ed__38))]
	private Task<ActionItem> FtHtr55k4dh(int int_0, int int_1, string string_0, string string_1, bool bool_0)
	{
		_003CCreateOpenFileOrFolderActionAsync_003Ed__38 stateMachine = default(_003CCreateOpenFileOrFolderActionAsync_003Ed__38);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ActionItem>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.row = int_0;
		stateMachine.col = int_1;
		stateMachine.path = string_0;
		stateMachine.name = string_1;
		stateMachine.useLnkTarget = bool_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateAndCopyActionForPath_003Ed__39))]
	public Task<bool> CreateAndCopyActionForPath(string path, string name, bool useLinkTarget)
	{
		_003CCreateAndCopyActionForPath_003Ed__39 stateMachine = default(_003CCreateAndCopyActionForPath_003Ed__39);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.path = path;
		stateMachine.name = name;
		stateMachine.useLinkTarget = useLinkTarget;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateAndCopyActionForCommand_003Ed__40))]
	public Task<bool> CreateAndCopyActionForCommand(string command, string title, string iconPath)
	{
		_003CCreateAndCopyActionForCommand_003Ed__40 stateMachine = default(_003CCreateAndCopyActionForCommand_003Ed__40);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.command = command;
		stateMachine.title = title;
		stateMachine.iconPath = iconPath;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateAndCopyActionForUrl_003Ed__41))]
	public Task<bool> CreateAndCopyActionForUrl(string url, string title, string iconPath)
	{
		_003CCreateAndCopyActionForUrl_003Ed__41 stateMachine = default(_003CCreateAndCopyActionForUrl_003Ed__41);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.title = title;
		stateMachine.iconPath = iconPath;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void SetButtonAction(ActionProfile profile, int row, int col, ActionItem action, bool skipSave = false)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.knjvDXKv82y = row;
		_003C_003Ec__DisplayClass42_.M6ovDmdYuu9 = col;
		ActionItem actionItem = profile.ActionItems.FirstOrDefault(_003C_003Ec__DisplayClass42_.gZMvD6XQW9Z);
		if (actionItem != null)
		{
			profile.ActionItems.Remove(actionItem);
		}
		if (action != null)
		{
			action.Row = _003C_003Ec__DisplayClass42_.knjvDXKv82y;
			action.Col = _003C_003Ec__DisplayClass42_.M6ovDmdYuu9;
			profile.ActionItems.Add(action);
			string data = action.Data;
			if (data != null && data.Length > 400000)
			{
				AppHelper.ShowWarning("动作大小超过400K，可能导致无法同步。复杂的动作请考虑使用脚本方式实现。");
			}
		}
		if (!skipSave)
		{
			qMdtptd2UCL.SaveProfile(profile);
			if (S92giaQNUaQ8o0FnJnaO != null)
			{
				switch (0)
				{
				}
			}
			DZZtr3VVGYn.OnProfileUpdated(profile);
		}
		Kfitrf6DTx6.NotifyActionEditComplete(this, action?.Id, action, profile);
	}

	public void UpdateActionProfiles(IList<ActionItem> actions)
	{
		ActionItem[] items = actions.ToArray();
		foreach (ActionProfile value in kB4tpwTmVen.mP6tXA8VyNP().Values)
		{
			if (value.ActionItems.ContainsAny(items))
			{
				qMdtptd2UCL.SaveProfile(value);
			}
		}
	}

	public void SetActionByButtonIndex(int btnIndex, ActionItem action)
	{
		(bool isGlobal, int row, int column) buttonLocation = AppHelper.GetButtonLocation(btnIndex);
		int item = buttonLocation.row;
		int item2 = buttonLocation.column;
		ActionProfile profileByButtonIndex = DZZtr3VVGYn.GetProfileByButtonIndex(btnIndex);
		SetButtonAction(profileByButtonIndex, item, item2, action);
	}

	public void EditActionByButtonIndex(int btnIndex, ActionItem action, bool forceReadonly)
	{
		ActionProfile profileByButtonIndex = DZZtr3VVGYn.GetProfileByButtonIndex(btnIndex);
		(bool, int, int) buttonLocation = AppHelper.GetButtonLocation(btnIndex);
		EditAction(profileByButtonIndex, buttonLocation.Item2, buttonLocation.Item3, action, null, null, forceReadonly);
	}

	public void CreateActionByButtonIndex(int btnIndex, ActionType actionType)
	{
		ActionProfile profileByButtonIndex = DZZtr3VVGYn.GetProfileByButtonIndex(btnIndex);
		(bool, int, int) buttonLocation = AppHelper.GetButtonLocation(btnIndex);
		CreateAction(profileByButtonIndex, buttonLocation.Item2, buttonLocation.Item3, actionType);
	}

	public void ProcessDragDropAction(ActionItemDragObject dragObject, ActionProfile targetProfile, int targetRow, int targetCol)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.omXvDxaa92S = this;
		_003C_003Ec__DisplayClass47_.UjAvDpwwBBZ = dragObject;
		_003C_003Ec__DisplayClass47_.JqXvDQiZmfg = targetProfile;
		int num = 0;
		if (S92giaQNUaQ8o0FnJnaO == null)
		{
			goto IL_002c;
		}
		goto IL_0083;
		IL_002c:
		_003C_003Ec__DisplayClass47_.PGvvDjHZOrI = targetRow;
		_003C_003Ec__DisplayClass47_.YtEvDnY9I77 = targetCol;
		_003C_003Ec__DisplayClass47_.ErNvDrayYdC = qMdtptd2UCL.GetProfileById(_003C_003Ec__DisplayClass47_.UjAvDpwwBBZ.ProfileId);
		if (_003C_003Ec__DisplayClass47_.ErNvDrayYdC != null)
		{
			if (_003C_003Ec__DisplayClass47_.UjAvDpwwBBZ.Action == null)
			{
				num = 0;
				if (S92giaQNUaQ8o0FnJnaO != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0083;
			}
			_003C_003Ec__DisplayClass47_.CkfvDBEev0Y = _003C_003Ec__DisplayClass47_.JqXvDQiZmfg.FindActionByLocation(_003C_003Ec__DisplayClass47_.PGvvDjHZOrI, _003C_003Ec__DisplayClass47_.YtEvDnY9I77);
			if (JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Control)
			{
				if (_003C_003Ec__DisplayClass47_.CkfvDBEev0Y != null)
				{
					AppHelper.ShowWarning("目标位置已有动作，不可再添加新动作。");
					return;
				}
				ActionItem action = _003C_003Ec__DisplayClass47_.UjAvDpwwBBZ.Action.Clone();
				SetButtonAction(_003C_003Ec__DisplayClass47_.JqXvDQiZmfg, _003C_003Ec__DisplayClass47_.PGvvDjHZOrI, _003C_003Ec__DisplayClass47_.YtEvDnY9I77, action);
				return;
			}
			if (_003C_003Ec__DisplayClass47_.UjAvDpwwBBZ.Action != null)
			{
				_003C_003Ec__DisplayClass47_.ErNvDrayYdC.RemoveAction(_003C_003Ec__DisplayClass47_.UjAvDpwwBBZ.Action);
			}
			if (_003C_003Ec__DisplayClass47_.CkfvDBEev0Y != null)
			{
				_003C_003Ec__DisplayClass47_.JqXvDQiZmfg.RemoveAction(_003C_003Ec__DisplayClass47_.CkfvDBEev0Y);
			}
			Task.Run((Action)_003C_003Ec__DisplayClass47_.cogvDKr7t9I);
			return;
		}
		AppHelper.ShowWarning("找不到源面板！" + _003C_003Ec__DisplayClass47_.UjAvDpwwBBZ.ProfileId);
		return;
		IL_0083:
		switch (num)
		{
		case 1:
			break;
		default:
			AppHelper.ShowWarning("拖动的动作为空。");
			return;
		}
		goto IL_002c;
	}

	[AsyncStateMachine(typeof(_003COnActionButtonDrop_003Ed__48))]
	public Task OnActionButtonDrop(ActionProfile targetProfile, int targetRow, int targetCol, DragEventArgs e, Window ownerWindow)
	{
		_003COnActionButtonDrop_003Ed__48 stateMachine = default(_003COnActionButtonDrop_003Ed__48);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.targetProfile = targetProfile;
		stateMachine.targetRow = targetRow;
		stateMachine.targetCol = targetCol;
		stateMachine.e = e;
		int num = 0;
		if (S92giaQNUaQ8o0FnJnaO != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			stateMachine.ownerWindow = ownerWindow;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}
	}

	[AsyncStateMachine(typeof(_003CProcessDropFileAsync_003Ed__49))]
	private Task dmwtrDfZl5m(string string_0, ActionProfile actionProfile_0, int int_0, int int_1)
	{
		_003CProcessDropFileAsync_003Ed__49 stateMachine = default(_003CProcessDropFileAsync_003Ed__49);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.filepath = string_0;
		stateMachine.targetProfile = actionProfile_0;
		stateMachine.targetRow = int_0;
		stateMachine.targetCol = int_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private ActionItem cq4trdU9GPh(ActionItem actionItem_0)
	{
		ActionItem actionItem = actionItem_0;
		if (actionItem_0.ActionType == ActionType.LinkAction)
		{
			(ActionItem, ActionProfile) actionById = kB4tpwTmVen.GetActionById(actionItem_0.Data);
			if (actionById.Item1 != null)
			{
				(actionItem, _) = actionById;
			}
		}
		return new ActionItem
		{
			ActionType = ActionType.LinkAction,
			Data = actionItem.Id,
			Title = "*" + actionItem.Title,
			Icon = actionItem.Icon,
			Description = "[链接]" + actionItem.Description,
			CreateTimeUtc = DateTime.UtcNow,
			LastEditTimeUtc = DateTime.UtcNow,
			Row = -1,
			Col = -1
		};
	}

	public void CreateLinkActionAndWriteToClipboard(ActionItem action)
	{
		ActionItem data = cq4trdU9GPh(action);
		ClipboardHelper.SetData("quicker-action-item", data);
		AppHelper.ShowInformation("已复制到剪贴板，请在合适的位置粘贴。");
	}

	public void BuildMenuForActionButton(ContextMenu menu, ActionItem action, ActionProfile profile, int row, int col, Window ownerWindow, ActionTrigger actionTrigger, bool showDelete = true)
	{
		if (action != null)
		{
			CreateContextMenuForActionButton(menu, action, profile, row, col, ownerWindow, actionTrigger, true, showDelete);
		}
		else
		{
			wHNtrAdmuKR(menu, profile, row, col, ownerWindow);
		}
	}

	internal static void qDOtrodjUqk(ContextMenu contextMenu_0, ItemCollection itemCollection_0, IList<CommonOperationItem> ilist_1, double double_0, Action<CommonOperationItem, object, ContextMenu> action_0)
	{
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
		_003C_003Ec__DisplayClass53_.OFwvD4vG3xh = action_0;
		_003C_003Ec__DisplayClass53_.NWrvD5JUm3u = contextMenu_0;
		using IEnumerator<CommonOperationItem> enumerator = ilist_1.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass53_1 _003C_003Ec__DisplayClass53_2 = new _003C_003Ec__DisplayClass53_1();
			_003C_003Ec__DisplayClass53_2.uL1vDowhsHs = _003C_003Ec__DisplayClass53_;
			_003C_003Ec__DisplayClass53_2.YZjvDdwenKf = enumerator.Current;
			if (_003C_003Ec__DisplayClass53_2.YZjvDdwenKf.IsSeparator)
			{
				AppHelper.AddMenuSeparator(itemCollection_0);
				continue;
			}
			MenuItem menuItem = AppHelper.AddMenuItem(itemCollection_0, _003C_003Ec__DisplayClass53_2.YZjvDdwenKf.Title, _003C_003Ec__DisplayClass53_2.YZjvDdwenKf.Description, _003C_003Ec__DisplayClass53_2.YZjvDdwenKf.Icon, null, null, null, null, double_0);
			menuItem.Tag = _003C_003Ec__DisplayClass53_2.YZjvDdwenKf;
			if (_003C_003Ec__DisplayClass53_2.YZjvDdwenKf.Children.HasData())
			{
				qDOtrodjUqk(_003C_003Ec__DisplayClass53_2.uL1vDowhsHs.NWrvD5JUm3u, menuItem.Items, _003C_003Ec__DisplayClass53_2.YZjvDdwenKf.Children, double_0, _003C_003Ec__DisplayClass53_2.uL1vDowhsHs.OFwvD4vG3xh);
			}
			else
			{
				menuItem.Click += _003C_003Ec__DisplayClass53_2.akxvDDayK5y;
			}
		}
	}

	public static void AddActionContextMenu(string menuData, ContextMenu menu, ActionItem action, Action callBack, PointTargetInfo pointTargetInfo)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.G6ovDMuDv8t = callBack;
		_003C_003Ec__DisplayClass54_.wiOvDAcBrLy = action;
		_003C_003Ec__DisplayClass54_.NG3vDONmyiI = pointTargetInfo;
		if (!string.IsNullOrEmpty(menuData))
		{
			IList<CommonOperationItem> list = CommonOperationItem.ParseLinesWithSubItems(menuData, true);
			if (list.HasData())
			{
				qDOtrodjUqk(menu, menu.Items, list, 16.0, _003C_003Ec__DisplayClass54_.MgcvDT0Qcpy);
			}
		}
	}

	public void CreateContextMenuForActionButton(ContextMenu menu, ActionItem action, ActionProfile profile, int row, int col, Window ownerWindow, ActionTrigger actionTrigger, bool showFloat = true, bool showDelete = true)
	{
		CreateContextMenuForActionButton(menu, action, profile, row, col, ownerWindow, actionTrigger, showFloat, showDelete, false);
	}

	public void CreateContextMenuForActionButton(ContextMenu menu, ActionItem action, ActionProfile profile, int row, int col, Window ownerWindow, ActionTrigger actionTrigger, bool showFloat, bool showDelete, bool onlyCustomMenu)
	{
        _003C_003Ec__DisplayClass57_3 _003C_003Ec__DisplayClass57_3 = default;
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
		_003C_003Ec__DisplayClass57_.aq7vdXTvn14 = ownerWindow;
		_003C_003Ec__DisplayClass57_.mTAvdKmAvM2 = this;
		_003C_003Ec__DisplayClass57_.VDxvdx9L8v4 = profile;
		_003C_003Ec__DisplayClass57_.FXyvdpLR6nB = action;
		_003C_003Ec__DisplayClass57_.gDtvdBaBq0w = row;
		_003C_003Ec__DisplayClass57_.py0vdQSLHa6 = col;
		int num = 7;
		if (S92giaQNUaQ8o0FnJnaO != null)
		{
			goto IL_0e5d;
		}
		goto IL_1453;
		IL_0e5d:
		MenuItem menuItem = default(MenuItem);
		AppHelper.AddMenuItem(menuItem.Items, "动作ID", "复制动作的ID文字", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), _003C_003Ec__DisplayClass57_.kA1vdWwZifv);
		AppHelper.AddMenuItem(menuItem.Items, "动作名称", "复制动作的名称文字", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), _003C_003Ec__DisplayClass57_.zdxvdkEjkjD);
		AppHelper.AddMenuItem(menuItem.Items, "动作URI", "URI可以用于在其他软件中启动动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), _003C_003Ec__DisplayClass57_.SEFvdGOV2xU);
		goto IL_0f56;
		IL_0f56:
		if (!_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.ActionType.IsEither(ActionType.OpenFile, ActionType.OpenFolder))
		{
			if (_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.ActionType != ActionType.RunProgram)
			{
				return;
			}
			_003C_003Ec__DisplayClass57_4 _003C_003Ec__DisplayClass57_2 = new _003C_003Ec__DisplayClass57_4();
			ProcessActionParams processActionParams = ProcessActionParams.FromActionItem(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB);
			string argument = processActionParams.Arguments;
			_003C_003Ec__DisplayClass57_2.mYTvdfjh06y = processActionParams.FileName;
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass57_2.mYTvdfjh06y))
			{
				num = 11;
				if (ANdWDHQNx8cgudb22boA())
				{
					return;
				}
				goto IL_1453;
			}
			if (!_003C_003Ec__DisplayClass57_2.mYTvdfjh06y.StartsWith("\\") && RNhtrUts27f(_003C_003Ec__DisplayClass57_2.mYTvdfjh06y))
			{
				AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "打开所在位置", "在资源管理器中找到对应文件或文件夹", "fa:Light_FolderOpen:#1296db", _003C_003Ec__DisplayClass57_2.RKEvd3WcDL2);
			}
			return;
		}
		_003C_003Ec__DisplayClass57_3 = new _003C_003Ec__DisplayClass57_3();
		_003C_003Ec__DisplayClass57_3.ctlvdijSUFF = _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Data;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass57_3.ctlvdijSUFF) || _003C_003Ec__DisplayClass57_3.ctlvdijSUFF.StartsWith("\\"))
		{
			return;
		}
		goto IL_14ee;
		IL_1453:
		MenuItem menuItem3 = default(MenuItem);
		MenuItem menuItem4 = default(MenuItem);
		_003C_003Ec__DisplayClass57_1 _003C_003Ec__DisplayClass57_4 = default(_003C_003Ec__DisplayClass57_1);
		ActionUserLimitation? userLimitation = default(ActionUserLimitation?);
		ActionUserLimitation actionUserLimitation = default(ActionUserLimitation);
		MenuItem menuItem2 = default(MenuItem);
		bool flag = default(bool);
		int num2 = default(int);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 17:
				_003C_003Ec__DisplayClass57_.YoVvdbBaq39();
				AppHelper.AddMenuSeparator(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items);
				_003C_003Ec__DisplayClass57_.mofvdsVaAle();
				goto IL_006e;
			case 5:
				if (_003C_003Ec__DisplayClass57_.PSivd43uisT)
				{
					AppHelper.AddMenuItem(menuItem3.Items, "添加动作页到文本悬浮窗", "在选择文本后弹出的悬浮窗中显示此页", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_PlusCircle, "#1296db"), _003C_003Ec__DisplayClass57_.dLLvD3iX8sf);
				}
				if (_003C_003Ec__DisplayClass57_.PSivd43uisT)
				{
					if (_003C_003Ec__DisplayClass57_.Txavdmsj39W.IsActionShared())
					{
						menuItem4 = AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "分享", "分享动作的相关操作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ShareAlt, "#1296db"), null);
						if ((_003C_003Ec__DisplayClass57_.Txavdmsj39W.CanBeShared() || !string.IsNullOrEmpty(_003C_003Ec__DisplayClass57_.Txavdmsj39W.SharedActionId)) && !_003C_003Ec__DisplayClass57_.Txavdmsj39W.UseTemplate)
						{
							if (_003C_003Ec__DisplayClass57_.Txavdmsj39W.LastEditTimeUtc.HasValue && _003C_003Ec__DisplayClass57_.Txavdmsj39W.ShareTimeUtc.HasValue && !(_003C_003Ec__DisplayClass57_.Txavdmsj39W.ShareTimeUtc < _003C_003Ec__DisplayClass57_.Txavdmsj39W.LastEditTimeUtc))
							{
								ActionItem actionItem = _003C_003Ec__DisplayClass57_.Txavdmsj39W;
								if (actionItem == null || !actionItem.Data.Contains("%%"))
								{
									goto case 15;
								}
							}
							goto case 16;
						}
						goto case 15;
					}
					if (_003C_003Ec__DisplayClass57_.Txavdmsj39W.CanBeShared() && !_003C_003Ec__DisplayClass57_.Txavdmsj39W.UseTemplate)
					{
						AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass57_.Txavdmsj39W.SharedActionId) ? "分享此动作" : "更新分享", "分享动作，或更新之前已经分享的动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ShareAlt, "#1296db"), _003C_003Ec__DisplayClass57_.zvmvdtKaI7P);
					}
				}
				goto case 13;
			case 16:
				AppHelper.AddMenuItem(menuItem4.Items, string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass57_.Txavdmsj39W.SharedActionId) ? "分享此动作" : "更新分享", "分享动作，或更新之前已经分享的动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ShareAlt, "#1296db"), _003C_003Ec__DisplayClass57_.o2GvDfeqRMZ);
				goto case 15;
			case 15:
				if (_003C_003Ec__DisplayClass57_.Txavdmsj39W.IsActionShared())
				{
					AppHelper.AddMenuItem(menuItem4.Items, "打开动作网页", "您已将此动作分享，点击查看已分享的动作页面。", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ExternalLink, "#1296db"), _003C_003Ec__DisplayClass57_.bTdvDzpx7Hf);
					AppHelper.AddMenuItem(menuItem4.Items, "复制网址", "复制已分享的动作网址", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), _003C_003Ec__DisplayClass57_.swPvdwHrir9);
				}
				goto case 13;
			case 13:
				if (_003C_003Ec__DisplayClass57_.Txavdmsj39W.IsFromSharedAction())
				{
					AppHelper.AddMenuSeparator(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items);
					if (_003C_003Ec__DisplayClass57_.PSivd43uisT)
					{
						_003C_003Ec__DisplayClass57_4 = new _003C_003Ec__DisplayClass57_1();
						num = 1;
						if (ANdWDHQNx8cgudb22boA())
						{
							continue;
						}
						goto default;
					}
					goto IL_053b;
				}
				goto IL_05db;
			default:
				num3 = ((userLimitation >= actionUserLimitation) ? 1 : 0);
				goto IL_0504;
			case 12:
				AppHelper.AddMenuItem(menuItem2.Items, "关闭自动调试", "关闭总是以调试模式运行此动作", "fa:Solid_Play:#1296db", _003C_003Ec__DisplayClass57_.QrCvd7W6lmD);
				goto IL_0a5b;
			case 2:
				if (_003C_003Ec__DisplayClass57_.PSivd43uisT && _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.CanCreateLinkAction())
				{
					AppHelper.AddMenuItem(menuItem2.Items, "创建链接动作", "创建一个链接动作并复制到剪贴板，从而在其他面板中使用这个动作。", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ExternalLink, "#1296db"), _003C_003Ec__DisplayClass57_.nevvd9YyTDl);
				}
				if (_003C_003Ec__DisplayClass57_.PSivd43uisT)
				{
					AppHelper.AddMenuItem(menuItem2.Items, "打开所在动作页", "在面板窗口中加载动作所在的动作页", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_FolderOpen, "#1296db"), _003C_003Ec__DisplayClass57_.TFdvdh9BfEY);
				}
				AppHelper.AddMenuSeparator(menuItem2.Items);
				AppHelper.AddMenuItem(menuItem2.Items, "查看信息", "查看动作信息", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_InfoCircle, "#1296db"), _003C_003Ec__DisplayClass57_.pdAvdYshh7e);
				if (_003C_003Ec__DisplayClass57_.PSivd43uisT)
				{
					menuItem = AppHelper.AddMenuItem(menuItem2.Items, "复制", null, string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), null);
					if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Icon))
					{
						AppHelper.AddMenuItem(menuItem.Items, "图标网址", "将图标网址复制到剪贴板", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), _003C_003Ec__DisplayClass57_.PPcvdIESIBn);
						num2 = 6;
					}
					break;
				}
				goto IL_0f56;
			case 6:
				break;
			case 11:
				userLimitation = _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.UserLimitation;
				goto case 3;
			case 3:
				if (userLimitation.HasValue)
				{
					userLimitation = _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.UserLimitation;
					actionUserLimitation = ActionUserLimitation.ReadOnly;
					num = 0;
					if (!ANdWDHQNx8cgudb22boA())
					{
						continue;
					}
					goto default;
				}
				num3 = 0;
				goto IL_0504;
			case 9:
				_003C_003Ec__DisplayClass57_.YoVvdbBaq39();
				AppHelper.AddMenuSeparator(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items);
				goto IL_006e;
			case 8:
				if (_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.ActionType == ActionType.LinkAction)
				{
					(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Data);
					if (actionById.Item1 != null)
					{
						(_003C_003Ec__DisplayClass57_.Txavdmsj39W, _003C_003Ec__DisplayClass57_.btMvdre638y) = actionById;
					}
				}
				_003C_003Ec__DisplayClass57_.OFSvdDPK3Ad = null;
				if (_003C_003Ec__DisplayClass57_.aq7vdXTvn14 is PopupWindow popupWindow)
				{
					_003C_003Ec__DisplayClass57_.OFSvdDPK3Ad = popupWindow.TargetInfo;
				}
				if (_003C_003Ec__DisplayClass57_.Txavdmsj39W != null && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass57_.Txavdmsj39W.Id) && AppState.AppServer.IsActionRunning(_003C_003Ec__DisplayClass57_.Txavdmsj39W.Id))
				{
					AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "停止动作", "此动作正在运行中", $"fa:{EFontAwesomeIcon.Solid_Stop}:#FF0000", _003C_003Ec__DisplayClass57_.uP9vDUHjrm3);
				}
				if (!onlyCustomMenu)
				{
					if (SmktrTnnkP6(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB))
					{
						goto case 17;
					}
					_003C_003Ec__DisplayClass57_.mofvdsVaAle();
					AppHelper.AddMenuSeparator(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items);
					goto case 9;
				}
				_003C_003Ec__DisplayClass57_.YoVvdbBaq39();
				return;
			case 7:
			{
				_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR = menu;
				_003C_003Ec__DisplayClass57_.z6Fvd5rhhSr = actionTrigger;
				_003C_003Ec__DisplayClass57_.kNBvd69n8jh = _003C_003Ec__DisplayClass57_.aq7vdXTvn14 != null && _003C_003Ec__DisplayClass57_.aq7vdXTvn14 is SearchWindow;
				bool enableSimpleMode = AppState.HS2taepcAbc().EnableSimpleMode;
				_003C_003Ec__DisplayClass57_.PSivd43uisT = !enableSimpleMode;
				_003C_003Ec__DisplayClass57_.UgJvdjPZMD7 = _003C_003Ec__DisplayClass57_.PSivd43uisT || _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.TemplateId.IsNullOrWhiteSpace();
				goto case 11;
			}
			case 1:
				_003C_003Ec__DisplayClass57_4.GnuvdAXY4CW = _003C_003Ec__DisplayClass57_;
				AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.tGZvdn3Q4XR.Items, "打开动作网页", "打开来源动作网页", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Globe, "#1296db"), _003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.DKbvdgSsmMY);
				_003C_003Ec__DisplayClass57_4.ClFvdMCxGib = AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.tGZvdn3Q4XR.Items, "来源动作", "来源共享动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Solid_ThLarge, "#1296db"), null);
				if (!kB4tpwTmVen.T0DtXck0Jas(_003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.FXyvdpLR6nB))
				{
					AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_4.ClFvdMCxGib.Items, "重新安装/更新动作", "重新安装此动作的最新版本", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Redo, "#1296db"), _003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.RCFvdLkWljV);
				}
				AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_4.ClFvdMCxGib.Items, "点赞", "点赞喜欢的动作，为作者加油~", $"fa:{EFontAwesomeIcon.Light_ThumbsUp}:#28a745", _003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.xtnvdvFCw0u);
				AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_4.ClFvdMCxGib.Items, "反馈", "反馈动作问题", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_CommentAltSmile, "#1296db"), _003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.E2BvdSKs4KA);
				AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_4.ClFvdMCxGib.Items, "复制网址", "复制来源动作网址", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), _003C_003Ec__DisplayClass57_4.GnuvdAXY4CW.zu4vd2UFq2T);
				_003C_003Ec__DisplayClass57_4.PsQvdTnk9B4 = false;
				_003C_003Ec__DisplayClass57_4.ClFvdMCxGib.SubmenuOpened += _003C_003Ec__DisplayClass57_4.UdnvdoOgKEU;
				goto IL_053b;
			case 4:
				goto IL_14ee;
			case 10:
				return;
			case 14:
				return;
				IL_0504:
				flag = (byte)num3 != 0;
				_003C_003Ec__DisplayClass57_.Txavdmsj39W = _003C_003Ec__DisplayClass57_.FXyvdpLR6nB;
				_003C_003Ec__DisplayClass57_.btMvdre638y = _003C_003Ec__DisplayClass57_.VDxvdx9L8v4;
				num = 8;
				if (S92giaQNUaQ8o0FnJnaO != null)
				{
					num = num2;
				}
				continue;
				IL_0a5b:
				if (ActionStateWriter.IsStateFileExists(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id) || AppState.DataService.EH9tXeOe7nj(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
				{
					MenuItem menuItem5 = AppHelper.AddMenuItem(menuItem2.Items, "动作数据", "动作状态数据文件", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Database, "#1296db"), null);
					if (ActionStateWriter.IsStateHasPanelState(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
					{
						AppHelper.AddMenuItem(menuItem5.Items, "重置自定义操作窗状态", "重置操作窗位置、尺寸等信息", $"fa:{EFontAwesomeIcon.Light_Undo}:#f75800", _003C_003Ec__DisplayClass57_.CeCvdRWHn3p);
					}
					AppHelper.AddMenuItem(menuItem5.Items, "删除动作数据", "删除动作的本地状态存储文件(移入回收站)；删除动作修饰（徽标文字/附加的右键菜单等）。\r\n如果按Shift点击菜单，可打开文件。", $"fa:{EFontAwesomeIcon.Light_Eraser}:#f75800", _003C_003Ec__DisplayClass57_.tcWvdqYe060);
					AppHelper.AddMenuItem(menuItem5.Items, "打开所在位置", "打开状态数据文件所在位置", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_FolderOpen, "#1296db"), _003C_003Ec__DisplayClass57_.dnpvdcT5r5n);
					AppHelper.AddMenuItem(menuItem5.Items, "备份到云端", "以加密方式备份到Quicker服务器", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Upload, "#1296db"), _003C_003Ec__DisplayClass57_.PvVvdVC9FSV);
					AppHelper.AddMenuItem(menuItem5.Items, "从云端恢复", "", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Download, "#1296db"), _003C_003Ec__DisplayClass57_.FtMvdZ5b95n);
				}
				goto case 2;
				IL_006e:
				menuItem3 = AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "悬浮", "悬浮动作或动作页", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_UfoBeam, "#1296db"), null);
				if (showFloat)
				{
					AppHelper.AddMenuItem(menuItem3.Items, "悬浮此动作", "将动作悬浮在桌面方便随时点击\r\n【面板窗口快速触发方式】右键拖拽 或 Alt+左键拖拽悬。", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ChevronSquareUp, "#1296db"), _003C_003Ec__DisplayClass57_.UPyvDlqitT7);
				}
				AppHelper.AddMenuItem(menuItem3.Items, "悬浮动作页", "悬浮动作所在动作页\r\n【面板窗口快速触发方式】Ctrl+右键点击动作页", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ChevronCircleUp, "#1296db"), _003C_003Ec__DisplayClass57_.ajGvDiSiSVr);
				goto case 5;
				IL_053b:
				if (kB4tpwTmVen.T0DtXck0Jas(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB))
				{
					int num4 = kB4tpwTmVen.cyttXVGPoZW(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB);
					AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, $"更新动作 {_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.TemplateRevision}\ud83e\udc52{num4}", "重新安装此动作的最新版本", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ArrowUp, "#1296db"), _003C_003Ec__DisplayClass57_.CtKvduUxeLb);
				}
				goto IL_05db;
				IL_05db:
				AppHelper.AddMenuSeparator(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items);
				AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "复制", "复制动作\r\nCtrl+点击可连同复制动作ID\r\n【面板窗口快速复制】Ctrl+拖动动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Copy, "#1296db"), _003C_003Ec__DisplayClass57_.Gv2vdNTnFUW);
				if (showDelete)
				{
					AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "剪切", "复制并删除动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Cut, "#1296db"), _003C_003Ec__DisplayClass57_.NNAvdJqUwh4);
					AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "删除", "【面板窗口快速触发方式】拖动动作到右上角的关闭按钮。", $"fa:{EFontAwesomeIcon.Light_Times}:#FF0000", _003C_003Ec__DisplayClass57_.GHyvd0n60CG);
				}
				if (_003C_003Ec__DisplayClass57_.PSivd43uisT)
				{
					if (AppHelper.IsCanPasteIcon())
					{
						AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "粘贴图标", "设置动作图标为剪贴板图片", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Paste, "#1296db"), _003C_003Ec__DisplayClass57_.sxQvdC2B1aa);
					}
					if (_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.ActionType.IsEither(ActionType.SendKeys, ActionType.OpenFile, ActionType.OpenFolder, ActionType.OpenUrl, ActionType.RunProgram, ActionType.SendText, ActionType.RunScriptFile))
					{
						AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "转换为组合动作", "将基础动作转换为组合动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Exchange, "#1296db"), _003C_003Ec__DisplayClass57_.wAyvdPmqrcU);
					}
				}
				menuItem2 = AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "信息", "其它功能", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_InfoCircle, "#1296db"), null);
				AppHelper.AddMenuItem(menuItem2.Items, "设置快捷键", "为动作设置全局快捷键", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_Keyboard, "#1296db"), _003C_003Ec__DisplayClass57_.GgTvdEKQcRu);
				AppHelper.AddMenuSeparator(menuItem2.Items);
				if (_003C_003Ec__DisplayClass57_.PSivd43uisT && !flag)
				{
					AppHelper.AddMenuItem(menuItem2.Items, "导出动作", "导出动作定义到文件", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_FileExport, "#1296db"), _003C_003Ec__DisplayClass57_.KxFvdy7ivYk);
					if (_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.ActionType == ActionType.XAction || _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.ActionType == ActionType.XSubProgram)
					{
						AppHelper.AddMenuItem(menuItem2.Items, "备份版本到服务器", "备份动作的当前版本到服务器", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_CloudUpload, "#1296db"), _003C_003Ec__DisplayClass57_.jGXvd85ZNSq).IsEnabled = AppState.DataService.Hb9tmk3OsJ7();
					}
					if (_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.ActionType == ActionType.XAction && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id) && _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id != Guid.Empty.ToString())
					{
						if (!(AppState.AlwaysDebugActionId != _003C_003Ec__DisplayClass57_.FXyvdpLR6nB.Id))
						{
							goto case 12;
						}
						AppHelper.AddMenuItem(menuItem2.Items, "开启自动调试", "自动以调试模式运行此动作", "fa:Light_Play:#1296db", _003C_003Ec__DisplayClass57_.JyZvdaB3Wim);
					}
				}
				goto IL_0a5b;
			}
			break;
		}
		goto IL_0e5d;
		IL_14ee:
		if (RNhtrUts27f(_003C_003Ec__DisplayClass57_3.ctlvdijSUFF))
		{
			AppHelper.AddMenuItem(_003C_003Ec__DisplayClass57_.tGZvdn3Q4XR.Items, "打开所在位置", "在资源管理器中找到对应文件或文件夹", "fa:Light_FolderOpen:#1296db", _003C_003Ec__DisplayClass57_3.mJ8vdlYOma9);
			num2 = 10;
		}
	}

	private bool SmktrTnnkP6(ActionItem actionItem_0)
	{
		switch (AppState.HHxtaMaoqJr().ActionMenuLayout)
		{
		case ActionMenuLayout.Auto:
			if (!string.IsNullOrEmpty(actionItem_0.TemplateId))
			{
				return !actionItem_0.LastEditTimeUtc.HasValue;
			}
			return false;
		case ActionMenuLayout.CustomMenuFirst:
			return true;
		default:
			if (!actionItem_0.LastEditTimeUtc.HasValue)
			{
				if (!ANdWDHQNx8cgudb22boA())
				{
					switch (0)
					{
					}
				}
				return true;
			}
			return actionItem_0.LastEditTimeUtc < DateTime.UtcNow.AddDays(-7.0);
		case ActionMenuLayout.EditFirst:
			return false;
		}
	}

	public void FloatAction(ActionItem action, Window ownerWindow)
	{
		if (kB4tpwTmVen.hfGtbAvJrRQ(true))
		{
			khuggB2ZntAfW2CDU1r.FloatAction(action, AppHelper.GetTopLeftScreenPositionBasedOnMouseAndVisualOffset(ownerWindow, new System.Windows.Point(40.0, 40.0)), orltrlKx8rp, Kfitrf6DTx6, this, kB4tpwTmVen, mNttpLTwBmW, null, (ownerWindow is SearchWindow searchWindow) ? searchWindow.ActiveProcessBeforeShow : null);
		}
	}

	public FloatButtonWindow RestoreFloatAction(FloatItemState itemState)
	{
		if (kB4tpwTmVen.hfGtbAvJrRQ(false))
		{
			(ActionItem, ActionProfile) actionById = kB4tpwTmVen.GetActionById(itemState.ItemId);
			if (actionById.Item1 != null)
			{
				if (itemState.Location.HasValue)
				{
					return khuggB2ZntAfW2CDU1r.FloatAction(actionById.Item1, itemState.Location.Value, orltrlKx8rp, Kfitrf6DTx6, this, kB4tpwTmVen, mNttpLTwBmW, itemState);
				}
				return khuggB2ZntAfW2CDU1r.FloatAction(actionById.Item1, new System.Drawing.Point((int)itemState.Left, (int)itemState.Top), orltrlKx8rp, Kfitrf6DTx6, this, kB4tpwTmVen, mNttpLTwBmW, itemState, "", true);
			}
		}
		else
		{
			qiytpSkwiIN.Warn("无法恢复悬浮动作。当前用户不支持悬浮动作。");
		}
		return null;
	}

	public FloatPanelWindow RestoreFloatPanelWindow(FloatItemState itemState)
	{
		ActionProfile profileById = qMdtptd2UCL.GetProfileById(itemState.ItemId);
		if (profileById != null)
		{
			FloatPanelWindow floatPanelWindow = new FloatPanelWindow(profileById, null, orltrlKx8rp, Kfitrf6DTx6, this, kB4tpwTmVen, mNttpLTwBmW, itemState);
			floatPanelWindow.Show();
			return floatPanelWindow;
		}
		return null;
	}

	private void ip0trMUrXfx(ActionItem actionItem_0, ActionProfile actionProfile_0, int int_0, int int_1, Window window_0)
	{
		try
		{
			if (actionItem_0.UseTemplate)
			{
				AppHelper.ShowWarning("不支持转换动作库的原始动作。请先修改后再转换。");
			}
			else if (AppHelper.Confirm("您确认要将动作 " + actionItem_0.Title + " 转换为组合动作么？"))
			{
				ActionItem action = ActionConverter.ConvertToXAction(actionItem_0);
				SetButtonAction(actionProfile_0, int_0, int_1, action);
				AppHelper.ShowSuccess("转换成功！");
			}
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("转换失败：" + exception.GetMessageWithInner());
		}
	}

	private void wHNtrAdmuKR(ContextMenu contextMenu_0, ActionProfile actionProfile_0, int int_0, int int_1, Window window_0)
	{
        _003C_003Ec__DisplayClass63_2 _003C_003Ec__DisplayClass63_2 = default;
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
		_003C_003Ec__DisplayClass63_.VuVvoCxSghp = contextMenu_0;
		_003C_003Ec__DisplayClass63_.NRQvoPUSg8G = window_0;
		_003C_003Ec__DisplayClass63_.PQsvoE3Ol9s = this;
		_003C_003Ec__DisplayClass63_.iEyvoyOwhP1 = actionProfile_0;
		_003C_003Ec__DisplayClass63_.woEvo8L7ai7 = int_0;
		_003C_003Ec__DisplayClass63_.hoXvoawNHGN = int_1;
		bool flag = !AppState.HS2taepcAbc().EnableSimpleMode;
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw("新建基础动作", null, null, "plus.png");
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw("新建组合动作", null, ActionType.XAction, ActionTypeManager.GetActionTypeInfo(ActionType.XAction).Icon);
		int num;
		if (ClipboardHelper.ContainsData("quicker-action-item"))
		{
			num = 1;
			if (S92giaQNUaQ8o0FnJnaO == null)
			{
				goto IL_02b3;
			}
			goto IL_02cd;
		}
		goto IL_0448;
		IL_0181:
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw("加载动作页", null, ActionType.OpenProfile, ActionTypeManager.GetActionTypeInfo(ActionType.OpenProfile).Icon);
		_003C_003Ec__DisplayClass63_2 = default(_003C_003Ec__DisplayClass63_2);
		if (ClipboardHelper.ContainsFileDropList())
		{
			StringCollection fileDropList = ClipboardHelper.GetFileDropList();
			if (fileDropList != null && fileDropList.Count > 0)
			{
				_003C_003Ec__DisplayClass63_2 = new _003C_003Ec__DisplayClass63_2();
				_003C_003Ec__DisplayClass63_2.bF0vohKUe4u = _003C_003Ec__DisplayClass63_;
				_003C_003Ec__DisplayClass63_2.HKwvo9SLWCO = fileDropList[0];
				num = 3;
				if (!ANdWDHQNx8cgudb22boA())
				{
					goto IL_01f5;
				}
				goto IL_02b3;
			}
		}
		goto IL_059a;
		IL_02cd:
		ActionItem actionItem = (ActionItem)ClipboardHelper.GetData("quicker-action-item");
		bool flag2 = actionItem.Id == AppState.CuttingAction?.Id;
		AppHelper.AddMenuItem(_003C_003Ec__DisplayClass63_.VuVvoCxSghp.Items, "粘贴动作：" + actionItem.Title, flag2 ? "粘贴剪切的动作" : "为复制的动作创建一个副本", "paste.png", _003C_003Ec__DisplayClass63_.Isbvo29IP7Q);
		if (CanPasteActionCopy(actionItem))
		{
			AppHelper.AddMenuItem(_003C_003Ec__DisplayClass63_.VuVvoCxSghp.Items, "粘贴为链接动作：*" + actionItem.Title, "为复制的动作创建一个链接动作", string.Format("fa:{0}:{1}", EFontAwesomeIcon.Light_ExternalLink, "#1296db"), _003C_003Ec__DisplayClass63_.tjAvouacQdb);
		}
		goto IL_0448;
		IL_01f5:
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw(CommonStrings.Common_ActionType_SendText, null, ActionType.SendText, $"fa:{EFontAwesomeIcon.Light_CommentAltLines}:#6aaded");
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw("执行脚本", null, ActionType.RunScriptFile, $"fa:{EFontAwesomeIcon.Light_Scroll}:#6aaded");
		goto IL_0181;
		IL_02b3:
		switch (num)
		{
		case 2:
			break;
		default:
			_003C_003Ec__DisplayClass63_.VuVvoCxSghp.Items.Add(new Separator());
			_003C_003Ec__DisplayClass63_.WjUvoSOQGpw(CommonStrings.Common_ActionType_OpenUrl, null, ActionType.OpenUrl, $"fa:{EFontAwesomeIcon.Light_Globe}:#6aaded");
			_003C_003Ec__DisplayClass63_.WjUvoSOQGpw(CommonStrings.Common_ActionType_SendKeys, null, ActionType.SendKeys, $"fa:{EFontAwesomeIcon.Light_Keyboard}:#6aaded");
			break;
		case 1:
			goto IL_02cd;
		case 3:
			goto IL_046c;
		}
		goto IL_01f5;
		IL_046c:
		try
		{
			AppHelper.AddMenuItem(_003C_003Ec__DisplayClass63_2.bF0vohKUe4u.VuVvoCxSghp.Items, "创建动作：打开「" + Path.GetFileName(_003C_003Ec__DisplayClass63_2.HKwvo9SLWCO) + "」", "创建打开文件或文件夹 " + _003C_003Ec__DisplayClass63_2.HKwvo9SLWCO + " 的动作", "fa:Regular_Plus:#71b1ee", _003C_003Ec__DisplayClass63_2.Pf7voVKqZ6v);
			if (_003C_003Ec__DisplayClass63_2.HKwvo9SLWCO.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
			{
				AppHelper.AddMenuItem(_003C_003Ec__DisplayClass63_2.bF0vohKUe4u.VuVvoCxSghp.Items, "创建动作：打开「" + Path.GetFileName(_003C_003Ec__DisplayClass63_2.HKwvo9SLWCO) + "」的目标", "打开或运行 " + _003C_003Ec__DisplayClass63_2.HKwvo9SLWCO + " 所指向的目标程序", "fa:Regular_Plus:#71b1ee", _003C_003Ec__DisplayClass63_2.SAmvoZgeabM);
			}
		}
		catch (Exception ex)
		{
			qiytpSkwiIN.Warn("生成快捷菜单出错：" + ex.Message, ex);
			AppHelper.ShowWarning("生成快捷菜单出错：" + ex.Message);
		}
		goto IL_059a;
		IL_059a:
		if (flag)
		{
			AppHelper.AddMenuItem(_003C_003Ec__DisplayClass63_.VuVvoCxSghp.Items, "导入动作", "从本地文件中导入动作", $"fa:{EFontAwesomeIcon.Light_FileImport}:#6aaded", _003C_003Ec__DisplayClass63_.oQBvo0gZDTM);
		}
		return;
		IL_0448:
		_003C_003Ec__DisplayClass63_.zG2vo7LcnAT = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass63_.zG2vo7LcnAT) && _003C_003Ec__DisplayClass63_.zG2vo7LcnAT.Trim().StartsWith("https://getquicker.net/Sharedaction?code=", StringComparison.OrdinalIgnoreCase))
		{
			MenuItem menuItem = AppHelper.AddMenuItem(_003C_003Ec__DisplayClass63_.VuVvoCxSghp.Items, "粘贴分享的动作", "", "paste.png", null);
			menuItem.PreviewMouseLeftButtonUp += _003C_003Ec__DisplayClass63_.qLnvoNSvhf3;
			menuItem.PreviewMouseRightButtonUp += _003C_003Ec__DisplayClass63_.pTWvoJxEjRI;
		}
		if (!flag)
		{
			goto IL_0181;
		}
		_003C_003Ec__DisplayClass63_.VuVvoCxSghp.Items.Add(new Separator());
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw("启动软件", null, ActionType.TempRunSoftware, $"fa:{EFontAwesomeIcon.Brands_Windows}:#6aaded");
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw(CommonStrings.Common_ActionType_OpenFile, null, ActionType.OpenFile, $"fa:{EFontAwesomeIcon.Light_FileCheck}:#6aaded");
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw("打开文件夹", null, ActionType.OpenFolder, $"fa:{EFontAwesomeIcon.Light_FolderOpen}:#6aaded");
		_003C_003Ec__DisplayClass63_.WjUvoSOQGpw("运行命令", null, ActionType.RunProgram, $"fa:{EFontAwesomeIcon.Light_PaperPlane}:#6aaded");
		num = 0;
		if (!ANdWDHQNx8cgudb22boA())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_02b3;
	}

	public bool CanPasteActionCopy(ActionItem item)
	{
		if (item.Row >= 0 && item.Col >= 0 && AppState.CuttingAction == null)
		{
			return kB4tpwTmVen.GetActionById(item.Id).action?.Id == item.Id;
		}
		return false;
	}

	[AsyncStateMachine(typeof(_003CPasteLinkAction_003Ed__65))]
	private Task idDtrOTgEW4(ActionProfile actionProfile_0, int int_0, int int_1)
	{
		_003CPasteLinkAction_003Ed__65 stateMachine = default(_003CPasteLinkAction_003Ed__65);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.profile = actionProfile_0;
		stateMachine.row = int_0;
		stateMachine.col = int_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void PVVtrFPDjDg(ActionProfile actionProfile_0, int int_0, int int_1)
	{
		(bool, string) tuple = AppHelper.ShowSelectFileDialog("json文件|*.json|任意文件|*.*", ".json", "", "");
		if (!tuple.Item1)
		{
			return;
		}
		try
		{
			if (new FileInfo(tuple.Item2).Length > 4024000L)
			{
				AppHelper.ShowWarning("文件太大，可能不是动作导出文件。");
				return;
			}
			ActionItem actionItem = JsonConvert.DeserializeObject<ActionItem>(File.ReadAllText(tuple.Item2));
			if (actionItem == null)
			{
				AppHelper.ShowWarning("导入失败，文件格式不正确。");
				return;
			}
			if (actionItem.Id == Guid.Empty.ToString())
			{
				AppHelper.ShowWarning("文件格式不正确，可能不是动作导出文件。");
				int num = 0;
				if (S92giaQNUaQ8o0FnJnaO != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				return;
			}
			if (AppState.DataService.GetActionById(actionItem.Id).action != null)
			{
				actionItem.Id = Guid.NewGuid().ToString();
				AppHelper.ShowInformation("因为动作ID已存在，所以为导入的动作创建了新的ID。");
			}
			actionItem.SharedActionId = "";
			actionItem.LastEditTimeUtc = DateTime.UtcNow;
			SetButtonAction(actionProfile_0, int_0, int_1, actionItem);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("导入失败。" + ex.Message);
		}
	}

	public static void ShowAppSelectorWindow(Window parentWindow)
	{
		AppSelectorWindow appSelectorWindow = parentWindow.qK6vuTvuZiE<AppSelectorWindow>();
		if (appSelectorWindow != null)
		{
			int num = 0;
			if (S92giaQNUaQ8o0FnJnaO != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			appSelectorWindow = new AppSelectorWindow(false)
			{
				Owner = parentWindow
			};
			if (parentWindow.WindowState != WindowState.Maximized)
			{
				appSelectorWindow.Height = parentWindow.Height + 8.0;
				appSelectorWindow.Left = parentWindow.Left + parentWindow.ActualWidth;
				appSelectorWindow.Top = parentWindow.Top;
			}
			else
			{
				appSelectorWindow.Height = parentWindow.Height;
				appSelectorWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			}
		}
		appSelectorWindow.Show();
		appSelectorWindow.Activate();
	}

	public static ActionItem CreateSwitchProfileAction(ActionProfile profile, bool writeToClipboard)
	{
		ActionItem actionItem = ActionTypeManager.GetActionTypeInfo(ActionType.OpenProfile).CreateNewItemFunc();
		actionItem.Title = profile.Name;
		actionItem.Description = "加载动作页：" + profile.Name;
		actionItem.Data = profile.Id;
		actionItem.LastEditTimeUtc = DateTime.UtcNow;
		actionItem.CreateTimeUtc = DateTime.UtcNow;
		if (writeToClipboard)
		{
			ClipboardHelper.SetData("quicker-action-item", actionItem);
		}
		return actionItem;
	}

	public static ActionItem CreateLoadExePagesAction(ExeInfo exeInfo, bool writeClipboard)
	{
		XAction xAction = new XAction();
		xAction.Steps.Add(new ActionStep
		{
			StepRunnerKey = "sys:quickeroperations",
			InputParams = new Dictionary<string, ActionStepParam>
			{
				{
					"type",
					new ActionStepParam
					{
						Value = "loadExeProfilesNoLock"
					}
				},
				{
					"exe",
					new ActionStepParam
					{
						Value = exeInfo.Exe
					}
				}
			}
		});
		ActionItem actionItem = new ActionItem
		{
			Title = exeInfo.Name,
			Icon = "fa:Light_LayerGroup",
			Description = "加载应用程序 " + exeInfo.Exe + " 的所有动作页",
			ActionType = ActionType.XAction,
			CreateTimeUtc = DateTime.UtcNow,
			LastEditTimeUtc = DateTime.UtcNow,
			DoNotClosePanel = true,
			Data = JsonConvert.SerializeObject(xAction),
			Row = -1,
			Col = -1
		};
		if (writeClipboard)
		{
			ClipboardHelper.SetData("quicker-action-item", actionItem);
		}
		return actionItem;
	}

	public void EditActionById(string actionId, EditActionParam editParam = null, bool forceReadOnly = false)
	{
		var (actionItem, profile) = kB4tpwTmVen.GetActionById(actionId);
		if (actionItem == null)
		{
			AppHelper.ShowWarning("要编辑的动作不存在。");
		}
		else
		{
			EditAction(profile, actionItem.Row, actionItem.Col, actionItem, null, editParam, forceReadOnly);
		}
	}

	public void SaveEditingAction(ActionItem resultAction)
	{
		_003C_003Ec__DisplayClass71_0 _003C_003Ec__DisplayClass71_ = new _003C_003Ec__DisplayClass71_0();
		_003C_003Ec__DisplayClass71_.Em0voYvFrVp = resultAction;
		var (actionItem, profile) = kB4tpwTmVen.GetActionById(_003C_003Ec__DisplayClass71_.Em0voYvFrVp.Id);
		if (actionItem != null)
		{
			SetButtonAction(profile, actionItem.Row, actionItem.Col, _003C_003Ec__DisplayClass71_.Em0voYvFrVp);
			Kfitrf6DTx6.NotifyActionEditComplete(this, _003C_003Ec__DisplayClass71_.Em0voYvFrVp?.Id, _003C_003Ec__DisplayClass71_.Em0voYvFrVp, profile);
			AppHelper.ShowSuccess("已保存到动作页。");
			if (S92giaQNUaQ8o0FnJnaO == null)
			{
				switch (0)
				{
				}
			}
		}
		else
		{
			EditingActionInfo editingActionInfo = kr8tp2sZD2W.FirstOrDefault(_003C_003Ec__DisplayClass71_.OOxvoerQjmE);
			if (editingActionInfo != null)
			{
				SetButtonAction(editingActionInfo.Profile, _003C_003Ec__DisplayClass71_.Em0voYvFrVp.Row, _003C_003Ec__DisplayClass71_.Em0voYvFrVp.Col, _003C_003Ec__DisplayClass71_.Em0voYvFrVp);
				Kfitrf6DTx6.NotifyActionEditComplete(this, _003C_003Ec__DisplayClass71_.Em0voYvFrVp?.Id, _003C_003Ec__DisplayClass71_.Em0voYvFrVp, profile);
				AppHelper.ShowSuccess("已保存到动作页。");
			}
			else
			{
				AppHelper.ShowWarning("新动作不支持此操作。");
			}
		}
	}

	static ActionEditMgr()
	{
		qiytpSkwiIN = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static bool RNhtrUts27f(string string_0)
	{
		if (File.Exists(string_0) || Directory.Exists(string_0))
		{
			return true;
		}
		if (string_0.Contains("%"))
		{
			string_0 = Environment.ExpandEnvironmentVariables(string_0);
			if (File.Exists(string_0) || Directory.Exists(string_0))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool ANdWDHQNx8cgudb22boA()
	{
		return S92giaQNUaQ8o0FnJnaO == null;
	}
}
