using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using bpNbEZj0vTDod37Z02B;
using Buax0Q2tBANN3iv8TIl;
using IgQBbvXMVdsN7GVNUxX;
using IOn6RhAJdTUbfGy6gwn;
using Jitbit.Utils;
using log4net;
using mmcmHlAD3xkvwaQf2Ut;
using NETWORKLIST;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Common.Vm.Backup;
using Quicker.Common.Vm.Sync.V3;
using Quicker.Common.Vm.Sync.V4;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Domain.Entities;
using Quicker.Domain.Exe;
using Quicker.Domain.Extensions;
using Quicker.Domain.Floating;
using Quicker.Domain.Hotkeys;
using Quicker.Domain.Local;
using Quicker.Domain.Messages;
using Quicker.Domain.Network;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.Profiles;
using Quicker.Domain.Searching.Actions;
using Quicker.Domain.SQL.Entities;
using Quicker.Modules.VersionUpdate;
using Quicker.Pinyin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using Quicker.View.Account;
using Quicker.View.Data;
using Quicker.View.Tools;
using ToastNotifications.Core;
using ToastNotifications.Messages;
using upLrfmibGdtSX9dWuOT;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.Domain.Services;

public class DataService : IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		[StructLayout(LayoutKind.Auto)]
		private struct TBr7AyHa5hjvZWmM6II : IAsyncStateMachine
		{
			public int kmD27UdXpPO;

			public AsyncVoidMethodBuilder JqC27lEJ3UA;

			private TaskAwaiter eQb27idUjEy;

			private static object AroyjyyukwmII0Bqdq6g;

			private void MoveNext()
			{
				int num = kmD27UdXpPO;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = eQb27idUjEy;
						eQb27idUjEy = default(TaskAwaiter);
						num = -1;
						kmD27UdXpPO = -1;
						goto IL_00ca;
					}
					if (V1kWZri8vrLTHgNDH0k.A3gYBiH70UKJSIvqdr2.EkR2PG1vawD().skG2P14t6Ce() != (V1kWZri8vrLTHgNDH0k.hgh80BHm0o6IE7HTQRK)4)
					{
						awaiter = krvQ8AAu3nWMBowhIM6.cm6Ow5ljga().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							kmD27UdXpPO = 0;
							eQb27idUjEy = awaiter;
							JqC27lEJ3UA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00ca;
					}
					InstallWebView2Window installWebView2Window = new InstallWebView2Window();
					installWebView2Window.ManualClose = true;
					installWebView2Window.Closed += wTOvnawiKji ?? (wTOvnawiKji = mElvj3e3w7y.ETMvjBF1ic3);
					installWebView2Window.Show();
					installWebView2Window.Activate();
					int num2 = 0;
					if (!HFRZX0yuaUelZOomQhlo())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 0:
						break;
					}
					goto end_IL_0008;
					IL_00ca:
					awaiter.GetResult();
					end_IL_0008:;
				}
				catch (Exception exception)
				{
					kmD27UdXpPO = -2;
					JqC27lEJ3UA.SetException(exception);
					return;
				}
				kmD27UdXpPO = -2;
				JqC27lEJ3UA.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				JqC27lEJ3UA.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static TBr7AyHa5hjvZWmM6II()
			{
			}

			internal static bool HFRZX0yuaUelZOomQhlo()
			{
				return AroyjyyukwmII0Bqdq6g == null;
			}

			internal static void zGiJrbyuLLQboUlpSKRE()
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct Lif2XJHzvEIi4J8oBbb : IAsyncStateMachine
		{
			public int bOb273IjQD7;

			public AsyncVoidMethodBuilder Dou27fCYEWL;

			private TaskAwaiter Fyc27zMGhj6;

			internal static object QruGERyuuxwXooELBYrg;

			private void MoveNext()
			{
				int num = bOb273IjQD7;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = krvQ8AAu3nWMBowhIM6.cm6Ow5ljga().GetAwaiter();
						if (TahgkOyuoNOH4p2IYP7v())
						{
							switch (0)
							{
							}
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							bOb273IjQD7 = 0;
							Fyc27zMGhj6 = awaiter;
							Dou27fCYEWL.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = Fyc27zMGhj6;
						Fyc27zMGhj6 = default(TaskAwaiter);
						num = -1;
						bOb273IjQD7 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					bOb273IjQD7 = -2;
					Dou27fCYEWL.SetException(exception);
					return;
				}
				bOb273IjQD7 = -2;
				Dou27fCYEWL.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Dou27fCYEWL.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool TahgkOyuoNOH4p2IYP7v()
			{
				return QruGERyuuxwXooELBYrg == null;
			}
		}

		public static readonly _003C_003Ec mElvj3e3w7y;

		public static Func<ActionProfile, string> dNlvjfnZWJv;

		public static Action<NotificationBase> ziWvjzDbti0;

		public static Func<SyncItemResult4, bool> AkWvnwiyWy8;

		public static Func<SyncItem4, bool> NUOvntw9nh1;

		public static Func<SyncItemResult4, bool> GPFvngY8DlM;

		public static Func<SyncItemResult4, bool> K4SvnL1u6Du;

		public static Func<ConflictItem, bool> p9Svnv9kc00;

		public static Func<ConflictItem, bool> al1vnSPBLDA;

		public static Func<ConflictItem, bool> cabvn2fC76G;

		public static Func<ConflictItem, bool> PCXvnu6puWC;

		public static Func<ConflictItem, bool> KLjvnN7BhS4;

		public static Func<SyncItemResult4, bool> giHvnJ5cdxi;

		public static Func<SyncItemResult4, bool> t5cvn0Bg8ku;

		public static Action bnxvnC7HHu4;

		public static Func<ActionProfile, string> kyavnPXOKQJ;

		public static Func<TextCommand, bool> Om0vnEa29ju;

		public static Func<TextCommand, int> yH2vnyaFuHr;

		public static Action LBFvn8HireU;

		public static EventHandler wTOvnawiKji;

		public static Action jo3vn7GoTX1;

		public static Func<ActionItem, string> Xr2vnReEkse;

		public static Func<string, bool> orMvnqQbTWy;

		public static Func<string, string> yFjvncLNf6S;

		public static Func<ActionProfile, string> K9RvnVnfiCl;

		public static Func<ActionItem, string> U4WvnZ14evi;

		public static Func<ActionItem, string> abevn9niSSx;

		public static Func<ActionItem, string> gQqvnhhwHgM;

		public static Func<ActionSearchResult, int> JsJvneDdP3a;

		public static Func<ActionSearchResult, int> tnivnYftC5A;

		public static Func<string, Guid> UtovnIm8yKs;

		public static Func<CheckActionUpdatesDto.SharedActionInfo, string> vdovnW3h4kj;

		public static Func<CheckActionUpdatesDto.SharedActionInfo, CheckActionUpdatesDto.SharedActionInfo> mQHvnkgRoY0;

		public static Func<ActionItem, string> qaTvnGTx8eN;

		public static Func<ActionItem, string> xdUvnsQyjbv;

		public static Func<ExeSettings, string> yOevnHU6v49;

		public static Func<ExeInfo, string> wwCvn1iU295;

		internal static _003C_003Ec XhATdrczoisjBeK9jFQr;

		static _003C_003Ec()
		{
			mElvj3e3w7y = new _003C_003Ec();
		}

		internal string fp0vj9B4FrT(ActionProfile x)
		{
			return x.ExeFile;
		}

		internal void aLdvjhWvLwg(NotificationBase _)
		{
			AppHelper.TryOpenUrlOrFile("https://getquicker.net/KC/Kb/Article/331");
		}

		internal bool Eakvjeif9lc(SyncItemResult4 x)
		{
			return x.SyncState == ItemSyncState4.Success;
		}

		internal bool HLlvjYGUwCH(SyncItem4 x)
		{
			return !string.IsNullOrEmpty(x.Data);
		}

		internal bool TytvjIreypU(SyncItemResult4 x)
		{
			return x.SyncState == ItemSyncState4.Success;
		}

		internal bool CMCvjWGk0sX(SyncItemResult4 x)
		{
			return x.SyncState == ItemSyncState4.Conflict;
		}

		internal bool Kbovjkvr9AF(ConflictItem x)
		{
			return x.ResolveMode == ConflictResolveMode.UseLocal;
		}

		internal bool D07vjGvGILM(ConflictItem x)
		{
			return x.ResolveMode == ConflictResolveMode.UseLocal;
		}

		internal bool ePhvjs8gm90(ConflictItem x)
		{
			return x.ResolveMode.IsEither(default(ConflictResolveMode));
		}

		internal bool VAAvjH16IZ6(ConflictItem x)
		{
			return x.ResolveMode == ConflictResolveMode.UseServer;
		}

		internal bool OuTvj1dSYhk(ConflictItem x)
		{
			return x.ResolveMode == ConflictResolveMode.UseLocal;
		}

		internal bool V2CvjbB3ZQW(SyncItemResult4 x)
		{
			return x.SyncState != ItemSyncState4.Success;
		}

		internal bool r6Fvj66gojx(SyncItemResult4 x)
		{
			return x.SyncState != ItemSyncState4.Success;
		}

		internal string H55vjmcSemd(ActionProfile x)
		{
			return x.ExeFile;
		}

		internal bool r1TvjKjffZB(TextCommand x)
		{
			return !x.IsDisabled;
		}

		internal int aSfvjxPbF7N(TextCommand x)
		{
			return x.CmdText.Length;
		}

		internal void Xi1vjr1KWZ9()
		{
			AppState.PushClient?.TryUpdateConnectState();
		}

		[AsyncStateMachine(typeof(TBr7AyHa5hjvZWmM6II))]
		internal void S6TvjptGT54()
		{
			TBr7AyHa5hjvZWmM6II stateMachine = default(TBr7AyHa5hjvZWmM6II);
			stateMachine.JqC27lEJ3UA = AsyncVoidMethodBuilder.Create();
			stateMachine.kmD27UdXpPO = -1;
			stateMachine.JqC27lEJ3UA.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(Lif2XJHzvEIi4J8oBbb))]
		internal void ETMvjBF1ic3(object sender, EventArgs e)
		{
			Lif2XJHzvEIi4J8oBbb stateMachine = default(Lif2XJHzvEIi4J8oBbb);
			stateMachine.Dou27fCYEWL = AsyncVoidMethodBuilder.Create();
			stateMachine.bOb273IjQD7 = -1;
			stateMachine.Dou27fCYEWL.Start(ref stateMachine);
		}

		internal string onTvjQOWRYh(ActionItem x)
		{
			return x.TemplateId;
		}

		internal bool z0AvjjCAwCw(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string h3FvjnW14fQ(string x)
		{
			return x;
		}

		internal string RPZvj46cbPA(ActionProfile x)
		{
			return x.Id;
		}

		internal string YT2vj5Ct4R5(ActionItem x)
		{
			return x.Title;
		}

		internal string wifvjDrmsiG(ActionItem x)
		{
			return x.Title;
		}

		internal string G0UvjdneaEB(ActionItem x)
		{
			return x.Title;
		}

		internal int U88vjoclLyw(ActionSearchResult x)
		{
			return x.Score;
		}

		internal int pkMvjTtyy6G(ActionSearchResult x)
		{
			return x.Score;
		}

		internal Guid j1HvjMp8OhM(string x)
		{
			return Guid.Parse(x);
		}

		internal string VAhvjAS5tRJ(CheckActionUpdatesDto.SharedActionInfo x)
		{
			return x.Id.ToString();
		}

		internal CheckActionUpdatesDto.SharedActionInfo iIkvjOrPFdi(CheckActionUpdatesDto.SharedActionInfo x)
		{
			return x;
		}

		internal string muSvjF7AeK3(ActionItem x)
		{
			return x.Title + "(" + x.Id + ")";
		}

		internal string uSCvjUCRovi(ActionItem x)
		{
			return "• " + x.Title;
		}

		internal string sIWvjlveRtE(ExeSettings x)
		{
			return x.Exe.ToLower();
		}

		internal string tFKvji9crwn(ExeInfo x)
		{
			return x.Name;
		}

		internal static void fHMNZ7czqbG5u2nYbdku()
		{
		}

		internal static bool hJsiryczfowxC4Chv9iT()
		{
			return XhATdrczoisjBeK9jFQr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass147_0
	{
		public AuthenticateResult2 lkHvn6mDV2W;

		private static _003C_003Ec__DisplayClass147_0 XQ50xGczZTMgyGoHeVr0;

		internal void COWvnbV8ntU()
		{
			LoginWindow loginWindow = new LoginWindow();
			if (loginWindow.ShowDialog() == true)
			{
				lkHvn6mDV2W = loginWindow.AuthenticateResult;
			}
		}

		internal static bool OOGeH4cz5ZfRJ3wZh18A()
		{
			return XQ50xGczZTMgyGoHeVr0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass147_1
	{
		public WaitWindow T1FvnK21uFb;

		internal static _003C_003Ec__DisplayClass147_1 JF6Dt0cz80ETcdkt3mc1;

		internal void aNbvnXtyL3t()
		{
			T1FvnK21uFb = new WaitWindow
			{
				Title = "加载动作数据..."
			};
			T1FvnK21uFb.InitializeComponent();
			T1FvnK21uFb.Show();
		}

		internal void gBcvnmLs1Pg()
		{
			T1FvnK21uFb.Close();
		}

		static _003C_003Ec__DisplayClass147_1()
		{
		}

		internal static bool vqnB2SczRtZx0iwOApKt()
		{
			return JF6Dt0cz80ETcdkt3mc1 == null;
		}

		internal static void p1Nj89czMM2JdgsiTcZk()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass150_0
	{
		public DataService qL2vnpPqoiy;

		public bool eA8vnBgkGjr;

		public bool EcfvnQsMgWO;

		private static _003C_003Ec__DisplayClass150_0 W4ESGcczUUFj5QdFg7wG;

		internal void gSLvnxHL1rO(object o)
		{
			qL2vnpPqoiy.CbQt6821R73(eA8vnBgkGjr, EcfvnQsMgWO);
		}

		internal void tA9vnrUAiMW(object o)
		{
			qL2vnpPqoiy.CbQt6821R73(eA8vnBgkGjr, EcfvnQsMgWO);
		}

		internal static bool B3dIsfczxihjCUVKQDe0()
		{
			return W4ESGcczUUFj5QdFg7wG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass152_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct mqdQCkklNRwETMdmro7 : IAsyncStateMachine
		{
			public int S0m2RwMIkTj;

			public AsyncTaskMethodBuilder xvF2Rtl7lkZ;

			public _003C_003Ec__DisplayClass152_0 zPj2Rgt3tiG;

			private TaskAwaiter Gow2RLtQene;

			private static object vKTdbPyub7NOpLYGI7dh;

			private void MoveNext()
			{
				int num = S0m2RwMIkTj;
				_003C_003Ec__DisplayClass152_0 _003C_003Ec__DisplayClass152_ = zPj2Rgt3tiG;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							S0m2RwMIkTj = 0;
							if (!IIit32yuqotwXoFND7q5())
							{
								switch (0)
								{
								}
							}
							Gow2RLtQene = awaiter;
							xvF2Rtl7lkZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = Gow2RLtQene;
						Gow2RLtQene = default(TaskAwaiter);
						num = -1;
						S0m2RwMIkTj = -1;
					}
					awaiter.GetResult();
					_003C_003Ec__DisplayClass152_.Xxgvn4IWR6u.xHZt6K2LJ8p(_003C_003Ec__DisplayClass152_.G9Yvn5bSft2, _003C_003Ec__DisplayClass152_.Uy2vndAcuKb++);
				}
				catch (Exception exception)
				{
					S0m2RwMIkTj = -2;
					xvF2Rtl7lkZ.SetException(exception);
					return;
				}
				S0m2RwMIkTj = -2;
				xvF2Rtl7lkZ.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				xvF2Rtl7lkZ.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool IIit32yuqotwXoFND7q5()
			{
				return vKTdbPyub7NOpLYGI7dh == null;
			}
		}

		public DataService Xxgvn4IWR6u;

		public ActionProfile G9Yvn5bSft2;

		public string HvFvnD3vLL3;

		public int Uy2vndAcuKb;

		internal static _003C_003Ec__DisplayClass152_0 jDZ32kcz6jWaLVocZGJu;

		internal void JFsvnj8I9Ip()
		{
			lock (Xxgvn4IWR6u.uYMtKuR8W45)
			{
				Xxgvn4IWR6u.Vc4tmAUDTP1.fcGtxUEHcM1(G9Yvn5bSft2.Id, HvFvnD3vLL3, true, AppHelper.GetUtcNowForDb());
			}
		}

		[AsyncStateMachine(typeof(mqdQCkklNRwETMdmro7))]
		internal Task X2OvnnUZrFu()
		{
			mqdQCkklNRwETMdmro7 stateMachine = default(mqdQCkklNRwETMdmro7);
			stateMachine.xvF2Rtl7lkZ = AsyncTaskMethodBuilder.Create();
			stateMachine.zPj2Rgt3tiG = this;
			stateMachine.S0m2RwMIkTj = -1;
			stateMachine.xvF2Rtl7lkZ.Start(ref stateMachine);
			return stateMachine.xvF2Rtl7lkZ.Task;
		}

		internal static bool BXOsJvcztasVrEXxZc6v()
		{
			return jDZ32kcz6jWaLVocZGJu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass157_0
	{
		public StringBuilder EsovnTARfcn;

		private static _003C_003Ec__DisplayClass157_0 c9Lm0YczwJfxJctrNVml;

		internal void CtgvnoR4QiI()
		{
			LocalBrowserWindow localBrowserWindow = new LocalBrowserWindow(null, EsovnTARfcn.ToString());
			localBrowserWindow.Show();
			localBrowserWindow.Activate();
		}

		internal static bool J5E0KkczT9ffR3o2y8e0()
		{
			return c9Lm0YczwJfxJctrNVml == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass158_0
	{
		public Gesture jOSvnAb5nmR;

		private static _003C_003Ec__DisplayClass158_0 H123oUczs1SbyfBG5mZL;

		internal bool dITvnM7Yd07(Gesture x)
		{
			return x.Id == jOSvnAb5nmR.Id;
		}

		internal static bool OOiqdlczCkqxFZvqyUEO()
		{
			return H123oUczs1SbyfBG5mZL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public string vxlvnFShZvy;

		internal static _003C_003Ec__DisplayClass15_0 yRkDPrcz4s8Dl9ZYSbKL;

		internal bool gYUvnOuYFTC(ActionProfile x)
		{
			return string.Equals(x.ExeFile, vxlvnFShZvy, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool M8oufgczhf2UwCphoP2e()
		{
			return yRkDPrcz4s8Dl9ZYSbKL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass174_0
	{
		public string Hp6vnix9nlI;

		private static _003C_003Ec__DisplayClass174_0 UGUNeeczzxv9see2aAw5;

		internal bool zM2vnUHByHW(ActionProfile x)
		{
			if (!string.IsNullOrEmpty(x.ExeFullpath) && File.Exists(x.ExeFullpath))
			{
				return string.Equals(Hp6vnix9nlI, x.ExeFile, StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		internal bool JDXvnltFy6X(ActionProfile x)
		{
			return ProfileManager.IsProfileMatchExe(x, Hp6vnix9nlI);
		}

		internal static bool b7ahMmWVVEokWWJtHIDX()
		{
			return UGUNeeczzxv9see2aAw5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass185_0
	{
		public string[] PdkvnzeH1hT;

		internal static _003C_003Ec__DisplayClass185_0 wnCnF5WVFr5fEKCSZKWO;

		internal bool VK9vn3UgY4Q(string p)
		{
			_003C_003Ec__DisplayClass185_1 _003C_003Ec__DisplayClass185_ = new _003C_003Ec__DisplayClass185_1
			{
				xHGv4tZB1Ug = p
			};
			return PdkvnzeH1hT.Any(_003C_003Ec__DisplayClass185_.weMv4wiX9b8);
		}

		internal bool ztVvnfTeRMq(string p)
		{
			_003C_003Ec__DisplayClass185_2 _003C_003Ec__DisplayClass185_ = new _003C_003Ec__DisplayClass185_2
			{
				RWuv4LV9Ujv = p
			};
			return PdkvnzeH1hT.Any(_003C_003Ec__DisplayClass185_.f12v4gm5LgR);
		}

		static _003C_003Ec__DisplayClass185_0()
		{
		}

		internal static bool JD7scbWVcZ6iVfH1kdyK()
		{
			return wnCnF5WVFr5fEKCSZKWO == null;
		}

		internal static void Ut0gGMWVyAsNp3alYrNc()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass185_1
	{
		public string xHGv4tZB1Ug;

		internal static _003C_003Ec__DisplayClass185_1 fQ1kBCWVpSp8xdKeJdkX;

		internal bool weMv4wiX9b8(string ext)
		{
			return i2HtXQLQTrg(xHGv4tZB1Ug, ext);
		}

		internal static bool eDHn4jWVX97iw5D67iwn()
		{
			return fQ1kBCWVpSp8xdKeJdkX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass185_2
	{
		public string RWuv4LV9Ujv;

		internal static _003C_003Ec__DisplayClass185_2 G4g5RXWVnae26rGdyFPw;

		internal bool f12v4gm5LgR(string ext)
		{
			return i2HtXQLQTrg(RWuv4LV9Ujv, ext);
		}

		internal static bool bRmeRhWVeY166WR2aG5i()
		{
			return G4g5RXWVnae26rGdyFPw == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass189_0
	{
		public ActionItem DgDv4SyFUTM;

		private static _003C_003Ec__DisplayClass189_0 BTV69CWVDjk5KYS0GHGv;

		internal bool BCov4vlAa4k(ActionSearchResult x)
		{
			return x.Action == DgDv4SyFUTM;
		}

		internal static bool dQs9VWWV37TVXPokjoPp()
		{
			return BTV69CWVDjk5KYS0GHGv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass190_0
	{
		public ActionItem sSYv4uKgk8l;

		private static _003C_003Ec__DisplayClass190_0 tWYke0WVGtw58CFRF619;

		internal bool lbmv42gCotj(ActionSearchResult x)
		{
			return x.Action == sSYv4uKgk8l;
		}

		internal static bool L6MuFGWV0xxMyh33DFNh()
		{
			return tWYke0WVGtw58CFRF619 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass199_0
	{
		public DataService qfCv4J1WBvu;

		public TextFloatPanelState kNJv40Af7Mp;

		private static _003C_003Ec__DisplayClass199_0 FE6BH2WVKFjJpTHDPhwj;

		internal void iMov4NustT0()
		{
			qfCv4J1WBvu.Vc4tmAUDTP1.SaveTextFloatPanelState(kNJv40Af7Mp);
		}

		internal static bool dWYUNOWVBp2Q0DdC6sRo()
		{
			return FE6BH2WVKFjJpTHDPhwj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass226_0
	{
		public string RTKv4PqJB61;

		public string FAYv4ESg0Eg;

		internal static _003C_003Ec__DisplayClass226_0 pseoj1WVOKp8vrryTxwt;

		internal void oqAv4CMRD76(ActionAdorn adorn)
		{
			adorn.OverlayIcon = RTKv4PqJB61;
			adorn.OverlayTooltip = FAYv4ESg0Eg;
		}

		internal static bool xJR5TbWVJVXHlfG7S7q8()
		{
			return pseoj1WVOKp8vrryTxwt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass227_0
	{
		public string m1Iv48AFBFx;

		public string HeIv4algF3A;

		public string zUfv47qvYtQ;

		private static _003C_003Ec__DisplayClass227_0 ocW06aWVaxktB0bhZ9l6;

		internal void RDAv4y1cky5(ActionAdorn adorn)
		{
			adorn.BadgeText = m1Iv48AFBFx;
			adorn.BadgeColor = HeIv4algF3A.Or("#00FFFFFF");
			adorn.BadgeTextColor = zUfv47qvYtQ;
		}

		internal static bool jmoy6XWVrWL6hm1PQgcc()
		{
			return ocW06aWVaxktB0bhZ9l6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass228_0
	{
		public string HJJv4qqxygk;

		internal static _003C_003Ec__DisplayClass228_0 CyeHyfWV9MLffVA2Qnaa;

		internal void LXCv4RiDgNi(ActionAdorn adorn)
		{
			adorn.ContextMenu = HJJv4qqxygk;
		}

		internal static bool Vip9MqWVLsGCoewZMv5S()
		{
			return CyeHyfWV9MLffVA2Qnaa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass232_0
	{
		public string MLKv4VHe9Vt;

		internal static _003C_003Ec__DisplayClass232_0 EdKv7yWVoaRNRq3ADPEC;

		internal bool vHrv4cFcPDD(SubProgram x)
		{
			return string.Equals(x.Name, MLKv4VHe9Vt, StringComparison.OrdinalIgnoreCase);
		}

		static _003C_003Ec__DisplayClass232_0()
		{
		}

		internal static bool uaG3nIWVfmkg9Y9ZafIP()
		{
			return EdKv7yWVoaRNRq3ADPEC == null;
		}

		internal static void DFZ6kaWVqO4WmRt9MroU()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass233_0
	{
		public SubProgram f0Qv49YZwSM;

		private static _003C_003Ec__DisplayClass233_0 ass7weWViBUor43eiIq8;

		internal bool T35v4ZALFfI(SubProgram x)
		{
			return x.Id == f0Qv49YZwSM.Id;
		}

		internal static bool SwEnGFWVlGQlRMtnMgFN()
		{
			return ass7weWViBUor43eiIq8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass234_0
	{
		public SubProgram vJev4eE3RVd;

		internal static _003C_003Ec__DisplayClass234_0 KVqeq3WVYrfdt3nSe8dv;

		internal bool ugmv4hNpTZD(SubProgram x)
		{
			return x.Id == vJev4eE3RVd.Id;
		}

		internal static void fbVEPuWVgwBMMkYet9DS()
		{
		}

		internal static bool iRHqGfWV861oS7vti6hQ()
		{
			return KVqeq3WVYrfdt3nSe8dv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass237_0
	{
		public string BWxv4IT5Qpd;

		private static _003C_003Ec__DisplayClass237_0 UuAF6iWVPXgPufwlxENn;

		internal bool aexv4YLp0cv(ExeInfo x)
		{
			return x.Exe == BWxv4IT5Qpd;
		}

		internal static bool cn8137WVMq1uG5kw8S9M()
		{
			return UuAF6iWVPXgPufwlxENn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public DataService Bqdv4kHAicj;

		public CommonDataEntity wKCv4GnqC9I;

		private static _003C_003Ec__DisplayClass34_0 f5jslHWVxJojweb4EugN;

		internal void gQlv4Ww7A3I()
		{
			Bqdv4kHAicj.HGwt6PDumqu(wKCv4GnqC9I);
		}

		internal static bool WKk8TEWVIaC3hnFmlhPK()
		{
			return f5jslHWVxJojweb4EugN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_1
	{
		public IList<MouseAction> myLv4H7wDZc;

		public _003C_003Ec__DisplayClass34_0 J4uv414lbOV;

		internal static _003C_003Ec__DisplayClass34_1 FrMAhhWVtCROp98UTlos;

		internal void uODv4s5JBeD()
		{
			if (myLv4H7wDZc.HasData())
			{
				J4uv414lbOV.Bqdv4kHAicj.FnrtmLxNViE().Reset(myLv4H7wDZc);
			}
			else
			{
				J4uv414lbOV.Bqdv4kHAicj.FnrtmLxNViE().Clear();
			}
		}

		internal static bool h7bx9oWVS0sxMKCSHhfc()
		{
			return FrMAhhWVtCROp98UTlos == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public string M8Fv46K6VrY;

		internal static _003C_003Ec__DisplayClass35_0 Lc8hcOWVTxSbk1d6APEW;

		internal bool Daav4bGojtk(SubProgram x)
		{
			return x.Id == M8Fv46K6VrY;
		}

		internal static bool Oxd3bEWVm6ZsB7p60F52()
		{
			return Lc8hcOWVTxSbk1d6APEW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public SyncItemResult4 kwvv4mEvrHr;

		internal static _003C_003Ec__DisplayClass44_0 AAto4QWV71bIZldCFkYd;

		internal bool hjvv4XF8L8X(SyncItem4 x)
		{
			if (x.ItemType == kwvv4mEvrHr.ItemType)
			{
				return x.ItemId == kwvv4mEvrHr.ItemId;
			}
			return false;
		}

		internal static bool iGVo9yWV4QKli1BkMVSN()
		{
			return AAto4QWV71bIZldCFkYd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_1
	{
		public IList<ConflictItem> Aqlv4rHLakB;

		public bool g0tv4pr2OxZ;

		public EventHandler ORkv4B4w2gL;

		internal static _003C_003Ec__DisplayClass44_1 YLKTQwWVHmawXvObLn6M;

		internal void H1Sv4KZBWxI()
		{
			SyncConflictsWindow syncConflictsWindow = new SyncConflictsWindow(Aqlv4rHLakB);
			syncConflictsWindow.Closed += ORkv4B4w2gL ?? (ORkv4B4w2gL = cD4v4xJEUav);
			syncConflictsWindow.Show();
			syncConflictsWindow.Activate();
		}

		internal void cD4v4xJEUav(object sender, EventArgs e)
		{
			g0tv4pr2OxZ = true;
		}

		internal static bool CDFE6hWVzcMjFFii7qyg()
		{
			return YLKTQwWVHmawXvObLn6M == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_2
	{
		public ConflictItem Kjpv4jNUmM1;

		private static _003C_003Ec__DisplayClass44_2 a7GuS5WQFVDEm83HmPCI;

		internal bool cPdv4QlkPNK(SyncItem4 x)
		{
			if (x.ItemType == Kjpv4jNUmM1.ItemType)
			{
				return x.ItemId == Kjpv4jNUmM1.ItemId;
			}
			return false;
		}

		internal static bool QaaWhWWQcaDroMdpoqww()
		{
			return a7GuS5WQFVDEm83HmPCI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_3
	{
		public SyncItemResult4 Hicv44q4Uwa;

		private static _003C_003Ec__DisplayClass44_3 BLUmJCWQyQF0fpggX8sY;

		internal bool JChv4nRg53W(SyncItem4 x)
		{
			if (x.ItemType == Hicv44q4Uwa.ItemType)
			{
				return x.ItemId == Hicv44q4Uwa.ItemId;
			}
			return false;
		}

		internal static bool q1pY9aWQpTbjEiYiPPTK()
		{
			return BLUmJCWQyQF0fpggX8sY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass84_0
	{
		public string yrHv4DyGd3k;

		internal static _003C_003Ec__DisplayClass84_0 ps9nHsWQ2fate6OdbHBc;

		internal bool myRv45QahL6(SubProgram x)
		{
			if (!(x.Id == yrHv4DyGd3k))
			{
				return string.Equals(yrHv4DyGd3k, x.Name, StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		static _003C_003Ec__DisplayClass84_0()
		{
		}

		internal static bool JhUNeKWQAcyB44ABRUke()
		{
			return ps9nHsWQ2fate6OdbHBc == null;
		}

		internal static void VqFkblWQeg7gu4Jfo59Y()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBackupActionManuallyAsync_003Ed__238 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Window owner;

		public DataService _003C_003E4__this;

		public ActionItem action;

		public bool isSubProgram;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object PvSsuNWQjhLcMjZXVTdQ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DataService dataService = _003C_003E4__this;
			try
			{
        BackupItemVm backupItemVm = default;
				if (num == 0)
				{
					goto IL_0163;
				}
				ActionBackupConfirmWindow actionBackupConfirmWindow = new ActionBackupConfirmWindow
				{
					Owner = owner
				};
				backupItemVm = default(BackupItemVm);
				if (actionBackupConfirmWindow.ShowDialog() == true)
				{
					dataService.Vc4tmAUDTP1.BackupAction(action, ActionBackupType.Manual, actionBackupConfirmWindow.LocalBackupExpireTime, actionBackupConfirmWindow.Note);
					if (actionBackupConfirmWindow.NetworkBackupExpireTime != DateTime.MinValue)
					{
						backupItemVm = new BackupItemVm
						{
							ObjectType = UserObjectType.Action,
							ObjectId = action.Id,
							CreateTimeUtc = DateTime.UtcNow,
							DisplayName = action.Title,
							ObjectIcon = action.Icon,
							UserNote = actionBackupConfirmWindow.Note,
							SystemNote = "手动保存" + (isSubProgram ? "(公共子程序)" : "(动作)"),
							IsManualSave = true,
							QuickerVersion = AppHelper.GetCurrAppVersion(),
							MachineName = Environment.MachineName,
							ExpireTimeUtc = actionBackupConfirmWindow.NetworkBackupExpireTime
						};
						int num2 = 0;
						if (!yI50g8WQDGtPrZGgicvG())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						backupItemVm.Data = JsonConvert.SerializeObject(action);
						goto IL_0163;
					}
				}
				goto end_IL_0010;
				IL_0163:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.is6tbeLotFm(backupItemVm).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<string> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						int num4 = 0;
						if (PvSsuNWQjhLcMjZXVTdQ != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						switch (num4)
						{
						default:
							AppHelper.ShowSuccess("备份成功！");
							break;
						}
					}
					else
					{
						AppHelper.ShowWarning(result.Message, true);
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("网络备份异常！" + ex.Message, true);
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

		internal static bool yI50g8WQDGtPrZGgicvG()
		{
			return PvSsuNWQjhLcMjZXVTdQ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetActionNewestVersion_003Ed__220 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DataService _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<CheckActionUpdatesDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object oKk869WQ0B6ddWhsBBPn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DataService dataService = _003C_003E4__this;
			try
			{
        List<string> list = default;
				if (num == 0)
				{
					goto IL_00d9;
				}
				list = default(List<string>);
				if (!File.Exists("c:\\qk_disable_actionupdate.txt"))
				{
					list = new List<string>();
					List<ActionProfile>.Enumerator enumerator = dataService.mP6tXA8VyNP().Values.ToList().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IEnumerator<ActionItem> enumerator2 = enumerator.Current.ActionItems.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									ActionItem current = enumerator2.Current;
									if (!current.SkipCheckUpdate && !string.IsNullOrEmpty(current.TemplateId) && !list.Contains(current.TemplateId))
									{
										list.Add(current.TemplateId);
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator2?.Dispose();
								}
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					goto IL_00d9;
				}
				AppHelper.ShowInformation("已忽略检查动作更新。");
				goto end_IL_000e;
				IL_00d9:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<CheckActionUpdatesDto>>.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<CheckActionUpdatesDto>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					else
					{
						awaiter = aFIptTXYsUoTUF4v33R.jKQtbNcw92B(new CheckActionUpdatesVm
						{
							SharedActions = list.Select(_003C_003Ec.UtovnIm8yKs ?? (_003C_003Ec.UtovnIm8yKs = _003C_003Ec.mElvj3e3w7y.j1HvjMp8OhM)).ToList()
						}).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					ApiResult<CheckActionUpdatesDto> result = awaiter.GetResult();
					if (!result.IsSuccess)
					{
						AFKtmdHLEbB.Warn("检查动作更新失败。" + result.Message);
					}
					else
					{
						Dictionary<string, CheckActionUpdatesDto.SharedActionInfo> dictionary = result.Data.SharedActions.ToDictionary(_003C_003Ec.vdovnW3h4kj ?? (_003C_003Ec.vdovnW3h4kj = _003C_003Ec.mElvj3e3w7y.VAhvjAS5tRJ), _003C_003Ec.mQHvnkgRoY0 ?? (_003C_003Ec.mQHvnkgRoY0 = _003C_003Ec.mElvj3e3w7y.iIkvjOrPFdi));
						IList<ActionItem> list2 = new List<ActionItem>();
						List<ActionProfile>.Enumerator enumerator = dataService.mP6tXA8VyNP().Values.ToList().GetEnumerator();
						try
						{
							int num3 = default(int);
							while (enumerator.MoveNext())
							{
								ActionProfile current2 = enumerator.Current;
								bool flag = false;
								IEnumerator<ActionItem> enumerator2 = current2.ActionItems.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										ActionItem current3 = enumerator2.Current;
										if (string.IsNullOrEmpty(current3.TemplateId) || !dictionary.ContainsKey(current3.TemplateId))
										{
											continue;
										}
										CheckActionUpdatesDto.SharedActionInfo sharedActionInfo = dictionary[current3.TemplateId];
										if (current3.TemplateRevision >= sharedActionInfo.Revision)
										{
											continue;
										}
										if (current3.AutoUpdate)
										{
											while (current3.UseTemplate)
											{
												int num2;
												if (string.IsNullOrEmpty(current3.MinQuickerVersion))
												{
													num2 = 0;
													if (!stBNTRWQ1L5S5IfYmsAt())
													{
														num2 = num3;
													}
													goto IL_03a6;
												}
												if (!SoftVersionHelper.IsVersionNewer(AppHelper.GetCurrAppVersion(), current3.MinQuickerVersion))
												{
													goto IL_03f1;
												}
												goto IL_02d5;
												IL_03a6:
												switch (num2)
												{
												case 2:
													continue;
												case 1:
													goto IL_03ca;
												}
												goto IL_02d5;
												IL_02d5:
												while (true)
												{
													current3.TemplateRevision = sharedActionInfo.Revision;
													current3.CreateTimeUtc = AppHelper.GetUtcNowForDb();
													current3.LastEditTimeUtc = null;
													current3.UserLimitation = sharedActionInfo.UserLimitation;
													if (!string.IsNullOrEmpty(sharedActionInfo.ContextMenuData))
													{
														current3.ContextMenuData = sharedActionInfo.ContextMenuData;
													}
													if (current3.KeepInfoWhenUpdate)
													{
														break;
													}
													if (!string.IsNullOrEmpty(sharedActionInfo.Title))
													{
														current3.Title = sharedActionInfo.Title;
													}
													if (!string.IsNullOrEmpty(sharedActionInfo.Icon))
													{
														current3.Icon = sharedActionInfo.Icon;
													}
													if (string.IsNullOrEmpty(sharedActionInfo.Description))
													{
														break;
													}
													current3.Description = sharedActionInfo.Description;
													num2 = 1;
													if (!stBNTRWQ1L5S5IfYmsAt())
													{
														continue;
													}
													goto IL_03a6;
												}
												goto IL_03ca;
												IL_03ca:
												flag = true;
												list2.Add(current3);
												goto IL_03f1;
											}
										}
										dataService.T3ntmpMv7Ps()[current3.Id] = sharedActionInfo.Revision;
										IL_03f1:;
									}
								}
								finally
								{
									if (num < 0)
									{
										enumerator2?.Dispose();
									}
								}
								if (flag)
								{
									dataService.xHZt6K2LJ8p(current2);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
						dataService.juQtmM3jwpR.NotifyPanelUpdate(dataService, true, true);
						int num4 = 1;
						if (oKk869WQ0B6ddWhsBBPn != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (list2.HasData())
								{
									AFKtmdHLEbB.Info("自动更新了动作：" + string.Join(",", list2.Select(_003C_003Ec.qaTvnGTx8eN ?? (_003C_003Ec.qaTvnGTx8eN = _003C_003Ec.mElvj3e3w7y.muSvjF7AeK3))));
									AppHelper.ShowWindowsToastMessage($"自动更新了 {list2.Count} 个动作：", string.Join("\r\n", list2.Select(_003C_003Ec.xdUvnsQyjbv ?? (_003C_003Ec.xdUvnsQyjbv = _003C_003Ec.mElvj3e3w7y.uSCvjUCRovi))));
									num4 = 0;
									if (!stBNTRWQ1L5S5IfYmsAt())
									{
										continue;
									}
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					AFKtmdHLEbB.Warn("检查更新异常：" + ex.Message);
				}
				end_IL_000e:;
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

		internal static bool stBNTRWQ1L5S5IfYmsAt()
		{
			return oKk869WQ0B6ddWhsBBPn == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAllActionItems_003Ed__181 : IDisposable, IEnumerable, IEnumerator, IEnumerable<ActionItem>, IEnumerator<ActionItem>
	{
		private int _003C_003E1__state;

		private ActionItem _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DataService _003C_003E4__this;

		private List<ActionProfile>.Enumerator _003C_003E7__wrap1;

		private IEnumerator<ActionItem> _003C_003E7__wrap2;

		private static _003CGetAllActionItems_003Ed__181 etuaQgWQJyi81Chn9s1d;

		ActionItem IEnumerator<ActionItem>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetAllActionItems_003Ed__181(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || num == 1)
			{
				try
				{
					if (num == -4 || num == 1)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = default(List<ActionProfile>.Enumerator);
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			bool result;
			try
			{
				int num = _003C_003E1__state;
				DataService dataService = _003C_003E4__this;
				if (num == 0)
				{
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = dataService.mP6tXA8VyNP().Values.ToList().GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_00b7;
				}
				if (num == 1)
				{
					_003C_003E1__state = -4;
					goto IL_009d;
				}
				result = false;
				if (etuaQgWQJyi81Chn9s1d == null)
				{
					switch (1)
					{
					case 1:
						break;
					case 2:
						goto IL_00b7;
					default:
						goto IL_00da;
					}
				}
				goto end_IL_0001;
				IL_009d:
				if (!_003C_003E7__wrap2.MoveNext())
				{
					_003C_003Em__Finally2();
					_003C_003E7__wrap2 = null;
					goto IL_00b7;
				}
				goto IL_00da;
				IL_00b7:
				if (_003C_003E7__wrap1.MoveNext())
				{
					ActionProfile current = _003C_003E7__wrap1.Current;
					_003C_003E7__wrap2 = current.ActionItems.GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_009d;
				}
				_003C_003Em__Finally1();
				_003C_003E7__wrap1 = default(List<ActionProfile>.Enumerator);
				result = false;
				goto end_IL_0001;
				IL_00da:
				ActionItem current2 = _003C_003E7__wrap2.Current;
				_003C_003E2__current = current2;
				_003C_003E1__state = 1;
				result = true;
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			((IDisposable)_003C_003E7__wrap1/*cast due to .constrained prefix*/).Dispose();
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<ActionItem> IEnumerable<ActionItem>.GetEnumerator()
		{
			_003CGetAllActionItems_003Ed__181 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetAllActionItems_003Ed__181(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<ActionItem>)this).GetEnumerator();
		}

		internal static bool IYaAxUWQkC5cZkEHXft9()
		{
			return etuaQgWQJyi81Chn9s1d == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAllValidActionItems_003Ed__182 : IDisposable, IEnumerable, IEnumerator, IEnumerable<ActionItem>, IEnumerator<ActionItem>
	{
		private int _003C_003E1__state;

		private ActionItem _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DataService _003C_003E4__this;

		private List<ActionProfile>.Enumerator _003C_003E7__wrap1;

		private IEnumerator<ActionItem> _003C_003E7__wrap2;

		private static _003CGetAllValidActionItems_003Ed__182 XOWQCOWQNV14fqAjLiXh;

		ActionItem IEnumerator<ActionItem>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetAllValidActionItems_003Ed__182(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || num == 1)
			{
				try
				{
					if (num == -4 || num == 1)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = default(List<ActionProfile>.Enumerator);
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				DataService dataService = _003C_003E4__this;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					goto IL_0069;
				}
				_003C_003E1__state = -1;
				_003C_003E7__wrap1 = dataService.mP6tXA8VyNP().Values.ToList().GetEnumerator();
				if (XOWQCOWQNV14fqAjLiXh == null)
				{
					switch (0)
					{
					case 1:
						goto IL_0069;
					case 2:
						goto IL_00b7;
					}
				}
				_003C_003E1__state = -3;
				goto IL_0073;
				IL_009b:
				if (!_003C_003E7__wrap2.MoveNext())
				{
					_003C_003Em__Finally2();
					_003C_003E7__wrap2 = null;
					goto IL_0073;
				}
				ActionItem current = _003C_003E7__wrap2.Current;
				_003C_003E2__current = current;
				_003C_003E1__state = 1;
				return true;
				IL_0073:
				if (!_003C_003E7__wrap1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = default(List<ActionProfile>.Enumerator);
					return false;
				}
				goto IL_00b7;
				IL_00b7:
				ActionProfile current2 = _003C_003E7__wrap1.Current;
				if (!ProfileManager.IsValidForCurrentMachine(current2))
				{
					goto IL_0073;
				}
				_003C_003E7__wrap2 = current2.ActionItems.GetEnumerator();
				_003C_003E1__state = -4;
				goto IL_009b;
				IL_0069:
				_003C_003E1__state = -4;
				goto IL_009b;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			((IDisposable)_003C_003E7__wrap1/*cast due to .constrained prefix*/).Dispose();
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<ActionItem> IEnumerable<ActionItem>.GetEnumerator()
		{
			_003CGetAllValidActionItems_003Ed__182 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetAllValidActionItems_003Ed__182(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<ActionItem>)this).GetEnumerator();
		}

		static _003CGetAllValidActionItems_003Ed__182()
		{
		}

		internal static bool Kc8CGLWQ90XNquSsV35A()
		{
			return XOWQCOWQNV14fqAjLiXh == null;
		}

		internal static void N8yH0hWQuerWBZpk5uoy()
		{
		}
	}


	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadActionBlockListAsync_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataService _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object gVlSLHWQi9CUfXlBaQVt;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DataService dataService = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.VSMtbXtiReP().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							int num2 = 0;
							if (gVlSLHWQi9CUfXlBaQVt != null)
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
						_003C_003Eu__1 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
					}
					string result = awaiter.GetResult();
					if (!result.IsNullOrEmpty())
					{
						dataService.BlockedActions = result.SplitToList();
					}
				}
				catch (Exception ex)
				{
					AFKtmdHLEbB.Warn("加载动作黑名单出错：" + ex.Message, ex);
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

		internal static bool fFwSEGWQlGAmk7ituAdu()
		{
			return gVlSLHWQi9CUfXlBaQVt == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadTextCommandsAsync_003Ed__200 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataService _003C_003E4__this;

		public bool showWarning;

		private TaskAwaiter<ApiResult<IList<TextCommand>>> _003C_003Eu__1;

		private static object vRSfGHWQ585l9KLit94r;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DataService dataService = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<ApiResult<IList<TextCommand>>> awaiter;
					if (num != 0)
					{
						DateTime? nullable_ = null;
						if (vRSfGHWQ585l9KLit94r != null)
						{
							switch (0)
							{
							}
						}
						awaiter = aFIptTXYsUoTUF4v33R.v6dtbKWl45S(nullable_).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<IList<TextCommand>>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<IList<TextCommand>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						dataService.neZtXfcGsie().Reset(result.Data);
						dataService.il2tXPiARoC();
					}
					else
					{
						AppHelper.ShowWarning("加载失败。" + result.Data);
					}
				}
				catch (Exception ex)
				{
					AFKtmdHLEbB.Warn("加载文本指令异常：" + ex.Message);
					if (showWarning)
					{
						AppHelper.ShowWarning("加载异常。" + ex.Message);
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

		static _003CLoadTextCommandsAsync_003Ed__200()
		{
		}

		internal static bool Dcfq7cWQYNwCE0wiEgAM()
		{
			return vRSfGHWQ585l9KLit94r == null;
		}

		internal static void pUcUBOWQPxDSGJtomveK()
		{
		}
	}

	private readonly object aXetmjSa3tp = new object();

	[CompilerGenerated]
	private QuickerSyncState SgAtmnja1au;

	private int ERDtm4Wi97r;

	private bool t7Ntm5rNrHp;

	[CompilerGenerated]
	private IList<string> ML4tmDkL6Ku = Array.Empty<string>();

	private static readonly ILog AFKtmdHLEbB;

	private readonly ProfileContentChangeChecker RYrtmoduVG5 = new ProfileContentChangeChecker();

	private readonly AppPathProvider dEytmTNDh9m;

	private readonly ITinyMessengerHub juQtmM3jwpR;

	private readonly SQLDataMgr Vc4tmAUDTP1;

	[CompilerGenerated]
	private UserSettings vIitmO9co2d;

	[CompilerGenerated]
	private readonly IDictionary<string, ActionProfile> LB7tmFN7yvI = new ConcurrentDictionary<string, ActionProfile>();

	[CompilerGenerated]
	private IDictionary<string, ExeSettings> WlNtmUwpA4o = new ConcurrentDictionary<string, ExeSettings>();

	private readonly SmartCollection<SubProgram> c56tmlhtETX = new SmartCollection<SubProgram>();

	private readonly object dOutmisFARV = new object();

	private IDictionary<string, SubProgram> f5ftm3iTPyu = new Dictionary<string, SubProgram>();

	private NetworkManager tWGtmf9CMcV;

	[CompilerGenerated]
	private IDictionary<string, string> MNhtmzg1jh4;

	[CompilerGenerated]
	private IList<TextCommand> hTrtKwNV8Pr;

	[CompilerGenerated]
	private SmartCollection<MouseAction> DJytKtcwIKB = new SmartCollection<MouseAction>();

	[CompilerGenerated]
	private IList<Gesture> vT8tKgprweH = new List<Gesture>();

	[CompilerGenerated]
	private IList<string> q6utKLl5NMU = new List<string>();

	[CompilerGenerated]
	private UserPreference jKhtKvnysqC = new UserPreference();

	private static DateTime YlotKS5VEVl;

	private readonly DebounceTimer NBetK2fsnHg = new DebounceTimer();

	private object uYMtKuR8W45 = new object();

	private bool fggtKNoOdmy = true;

	private readonly ManualResetEvent WU8tKJ2N7mo = new ManualResetEvent(false);

	private readonly LocalSharedActionCache vHwtK0yHtUa = new LocalSharedActionCache();

	private TextFloatPanelState gfxtKCsAt5a;

	private readonly SmartCollection<TextCommand> v1gtKP1MaNi = new SmartCollection<TextCommand>();

	[CompilerGenerated]
	private readonly IDictionary<int, PowerKey> VTatKE1aQk1 = new ConcurrentDictionary<int, PowerKey>();

	[CompilerGenerated]
	private readonly IDictionary<string, int> aJctKy0GjXI = new ConcurrentDictionary<string, int>();

	internal IDictionary<string, ActionAdorn> oKHtK8wCbaN = new ConcurrentDictionary<string, ActionAdorn>();

	private LocalSettings U8GtKa8f2NC;

	internal static DataService KRg6iMQrFIxATWQ640kL;

	public QuickerSyncState SyncState
	{
		[CompilerGenerated]
		get
		{
			return SgAtmnja1au;
		}
		[CompilerGenerated]
		private set
		{
			SgAtmnja1au = value;
		}
	}

	public IList<string> BlockedActions
	{
		[CompilerGenerated]
		get
		{
			return ML4tmDkL6Ku;
		}
		[CompilerGenerated]
		private set
		{
			ML4tmDkL6Ku = value;
		}
	}

	public SmartCollection<SubProgram> GlobalSubPrograms => c56tmlhtETX;

	public IDictionary<string, string> ConfigurationsFromServer
	{
		[CompilerGenerated]
		get
		{
			return MNhtmzg1jh4;
		}
		[CompilerGenerated]
		set
		{
			MNhtmzg1jh4 = value;
		}
	}

	public IList<string> FavorBlocks
	{
		[CompilerGenerated]
		get
		{
			return q6utKLl5NMU;
		}
		[CompilerGenerated]
		private set
		{
			q6utKLl5NMU = value;
		}
	}

	public UserPreference UserPreference
	{
		[CompilerGenerated]
		get
		{
			return jKhtKvnysqC;
		}
		[CompilerGenerated]
		private set
		{
			jKhtKvnysqC = value;
		}
	}

	internal LocalSettings LocalSettings
	{
		get
		{
			if (U8GtKa8f2NC == null)
			{
				U8GtKa8f2NC = dDh7g7Xw7JyQPUTbYwJ.LocalSettings;
				if (U8GtKa8f2NC == null)
				{
					U8GtKa8f2NC = new LocalSettings();
				}
			}
			return U8GtKa8f2NC;
		}
	}

	private void YFwt62i1oPu(bool bool_2, string string_0, SyncVm3 syncVm3_0 = null, SyncResult3 syncResult3_0 = null)
	{
		Vc4tmAUDTP1.LiZtrIojbbm(bool_2, string_0, syncVm3_0, syncResult3_0);
	}

	private void Q5Ft6uJgbDC(QuickerSyncState quickerSyncState_1)
	{
		SyncState = quickerSyncState_1;
		juQtmM3jwpR.UpdateSyncState(this, quickerSyncState_1);
	}

	private void zbHt6NG0g4a(string string_0)
	{
		AFKtmdHLEbB.Error(string_0);
		throw new InvalidDataException(string_0);
	}

	private bool u15t6JGk0Rc()
	{
		try
		{
			ApiResult<SyncResult4> result = aFIptTXYsUoTUF4v33R.vlatbSqwocC().Result;
			if (!result.IsSuccess)
			{
				AppHelper.LogErrorAndThrow("加载数据异常：" + result.Message);
			}
			Soht6Rmc1Fu();
			foreach (SyncItem4 server2PcItem in result.Data.Server2PcItems)
			{
				kUFt6V96H9J(server2PcItem, true);
			}
			lUit668XYex();
			if (result.Data.LastSuccessSyncTimeUtc.HasValue)
			{
				Vc4tmAUDTP1.SaveLastSyncInfo(new LastSyncInfo
				{
					ServerTimeUtc = result.Data.LastSuccessSyncTimeUtc
				});
				int num = 0;
				if (!nF9SMKQrcRNHDMBJ3LAt())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return true;
		}
		catch (Exception exception)
		{
			AFKtmdHLEbB.Error("加载数据异常：" + exception.GetMessageWithInner(), exception);
			AppHelper.ShowWarning("加载动作数据失败！" + exception.GetMessageWithInner(), true);
			return false;
		}
	}

	private void uKlt60gdcPZ(SyncItem4 syncItem4_0, bool bool_2)
	{
		CommonDataEntity commonDataEntity = new CommonDataEntity
		{
			Id = syncItem4_0.ItemId,
			Data = syncItem4_0.Data,
			SubType = syncItem4_0.SubType,
			DisplayName = syncItem4_0.DisplayName,
			DeleteTimeUtc = syncItem4_0.DeleteTimeUtc,
			IsDeleted = syncItem4_0.IsDeleted,
			LastUpdateTimeUtc = syncItem4_0.LastUpdateTimeUtc,
			LocalOnly = false,
			Revision = (syncItem4_0.BaseRevision ?? (-1)),
			SyncState = ItemSyncState.None,
			SyncErrorMessage = ""
		};
		Vc4tmAUDTP1.SaveCommonDataFromServer(commonDataEntity);
		bool flag = !bool_2;
		Vxot6COo2tW(commonDataEntity, flag);
		if (flag)
		{
			juQtmM3jwpR.NotifyCommonDataUpdated(this, syncItem4_0.ItemId);
		}
	}

	private void Vxot6COo2tW(CommonDataEntity commonDataEntity_0, bool bool_2)
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.Bqdv4kHAicj = this;
		_003C_003Ec__DisplayClass34_.wKCv4GnqC9I = commonDataEntity_0;
		string id = _003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Id;
		if (id != null)
		{
			char c;
			int num;
			switch (id.Length)
			{
			case 23:
				if (id == "user_txtFloatPanelState")
				{
					gfxtKCsAt5a = JsonConvert.DeserializeObject<TextFloatPanelState>(_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Data);
					return;
				}
				break;
			case 13:
				c = id[5];
				if (c != 'g')
				{
					if (c != 's')
					{
						break;
					}
					goto IL_01aa;
				}
				if (id == "user_gestures")
				{
					xvstmuUUh7c(JsonConvert.DeserializeObject<IList<Gesture>>(_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Data) ?? new List<Gesture>());
					return;
				}
				break;
			case 14:
				if (id == "user_powerKeys")
				{
					IDictionary<int, PowerKey> idictionary_ = JsonConvert.DeserializeObject<IDictionary<int, PowerKey>>(_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Data);
					JGJtXCmp26H(idictionary_);
					return;
				}
				break;
			case 16:
				c = id[5];
				num = 0;
				if (KRg6iMQrFIxATWQ640kL == null)
				{
					goto IL_011b;
				}
				goto IL_0132;
			case 17:
				goto IL_01e2;
				IL_0132:
				switch (num)
				{
				case 1:
					if (c != 'p' || !(id == "user_preferences"))
					{
						goto end_IL_003a;
					}
					UserPreference = JsonConvert.DeserializeObject<UserPreference>(_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Data);
					return;
				case 3:
					goto IL_01aa;
				case 2:
					goto IL_01e2;
				case 4:
					goto end_IL_003a;
				}
				goto IL_011b;
				IL_01e2:
				if (id == "user_mouseActions")
				{
					_003C_003Ec__DisplayClass34_1 _003C_003Ec__DisplayClass34_2 = new _003C_003Ec__DisplayClass34_1();
					_003C_003Ec__DisplayClass34_2.J4uv414lbOV = _003C_003Ec__DisplayClass34_;
					_003C_003Ec__DisplayClass34_2.myLv4H7wDZc = JsonConvert.DeserializeObject<IList<MouseAction>>(_003C_003Ec__DisplayClass34_2.J4uv414lbOV.wKCv4GnqC9I.Data);
					AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass34_2.uODv4s5JBeD);
					return;
				}
				break;
				IL_011b:
				if (c != 'f')
				{
					num = 1;
					if (KRg6iMQrFIxATWQ640kL != null)
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_0132;
				}
				if (id == "user_favorBlocks")
				{
					FavorBlocks = JsonConvert.DeserializeObject<IList<string>>(_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Data);
					return;
				}
				break;
				IL_01aa:
				if (id == "user_settings")
				{
					XTptXTpHkas(JsonConvert.DeserializeObject<UserSettings>(_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Data));
					if (bool_2)
					{
						juQtmM3jwpR.NotifyUserSettingsChange(this);
					}
					return;
				}
				break;
				end_IL_003a:
				break;
			}
		}
		if (_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Id.StartsWith("exe:", StringComparison.OrdinalIgnoreCase))
		{
			dTXt6Eup92s(_003C_003Ec__DisplayClass34_.wKCv4GnqC9I);
		}
		else if (_003C_003Ec__DisplayClass34_.wKCv4GnqC9I.Id.StartsWith("shared_subprogram:", StringComparison.OrdinalIgnoreCase))
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass34_.gQlv4Ww7A3I);
		}
	}

	private void HGwt6PDumqu(CommonDataEntity commonDataEntity_0)
	{
		while (true)
		{
			commonDataEntity_0.Id.Substring("shared_subprogram:".Length);
			if (KRg6iMQrFIxATWQ640kL == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (commonDataEntity_0.IsDeleted)
		{
			_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
			_003C_003Ec__DisplayClass35_.M8Fv46K6VrY = commonDataEntity_0.Id.Substring("shared_subprogram:".Length);
			int num = GlobalSubPrograms.IndexOf(_003C_003Ec__DisplayClass35_.Daav4bGojtk);
			if (num >= 0)
			{
				GlobalSubPrograms.RemoveAt(num);
			}
		}
		else
		{
			SubProgram subProgram_ = JsonConvert.DeserializeObject<SubProgram>(commonDataEntity_0.Data);
			biOtXHUANmi(subProgram_);
		}
	}

	private void dTXt6Eup92s(CommonDataEntity commonDataEntity_0)
	{
		ExeSettings value = JsonConvert.DeserializeObject<ExeSettings>(commonDataEntity_0.Data);
		string key = commonDataEntity_0.Id.Substring("exe:".Length);
		if (commonDataEntity_0.IsDeleted)
		{
			if (TxrtXFmcoEV().ContainsKey(key))
			{
				TxrtXFmcoEV().Remove(key);
			}
		}
		else
		{
			TxrtXFmcoEV()[key] = value;
		}
	}

	private ActionProfile bY4t6yuobRh(SyncItem4 syncItem4_0, bool bool_2)
	{
		int num = 1;
		while (true)
		{
			Vc4tmAUDTP1.SaveProfileDataFromServer(syncItem4_0);
			int num2 = 0;
			if (!nF9SMKQrcRNHDMBJ3LAt())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			ActionProfile actionProfile = JsonConvert.DeserializeObject<ActionProfile>(syncItem4_0.Data);
			actionProfile.FixExeName();
			if (syncItem4_0.IsDeleted)
			{
				if (mP6tXA8VyNP().ContainsKey(actionProfile.Id))
				{
					mP6tXA8VyNP().Remove(actionProfile.Id);
				}
			}
			else
			{
				mP6tXA8VyNP()[actionProfile.Id] = actionProfile;
			}
			if (!bool_2 && !syncItem4_0.IsDeleted)
			{
				wwQt6nwg0BT(actionProfile);
			}
			return actionProfile;
		}
	}

	internal void CbQt6821R73(bool bool_2, bool bool_3 = false)
	{
        // 兼容旧“立即同步”调用点，明确执行本地保存。
        ydot6rVZAkW();
        il2tXPiARoC();
        DtNtXKQWDel();
        Q5Ft6uJgbDC(QuickerSyncState.Idle);
        if (bool_2) AppHelper.ShowSuccess("设置已保存到本地。");
    }

	private (bool isSuccess, string message) ODet6a6DBMQ(bool bool_2)
	{
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (!CpItmVISR7P().SyncIgnoreNetworkState && !IsNetworkConnected())
			{
				if (!bool_2)
				{
					return (isSuccess: false, message: "网络没有连接，取消同步！");
				}
				stringBuilder.AppendLine("网络没有连接，强制尝试同步。");
			}
			bool lockTaken = false;
			try
			{
				Monitor.TryEnter(aXetmjSa3tp, 0, ref lockTaken);
				if (lockTaken)
				{
					try
					{
						bool flag;
						SyncResult4 syncResult;
						bool flag2;
						string text;
						(flag, text, syncResult, flag2) = Nc1t672cVD3();
						stringBuilder.Append(text);
						if (!flag)
						{
							if (text != null && text.Contains("同步异常"))
							{
								if (text.Contains("账号不存在"))
								{
									AFKtmdHLEbB.Warn("同步异常：" + text);
									MessageBoxHelper.Show("您的Quicker账号不存在，程序将自动退出。\r\n如需卸载，请在Windows设置-应用或控制面板中操作。\r\n如需清理数据，请使用everything搜索并删除quicker.db文件及所在目录。", "Quicker", MessageBoxButton.OK, MessageBoxImage.Hand);
									AppHelper.ExitApplication();
									return (isSuccess: false, message: stringBuilder.ToString());
								}
								if (text.Contains("账号异常"))
								{
									AppHelper.ExitApplication();
									return (isSuccess: false, message: stringBuilder.ToString());
								}
							}
							return (isSuccess: false, message: stringBuilder.ToString());
						}
						if (syncResult.UserInfo != null)
						{
							;
						}
						int num = 0;
						while (flag2)
						{
							stringBuilder.AppendLine("需要再次同步。");
							(flag, text, syncResult, flag2) = Nc1t672cVD3();
							stringBuilder.Append(text);
							num++;
							if (num > 3)
							{
								AFKtmdHLEbB.Warn("已经连续同步了3次了。停止循环！");
								break;
							}
						}
						ICollection<SyncItemResult4> pc2ServerResults = syncResult.Pc2ServerResults;
						if (pc2ServerResults != null && pc2ServerResults.Count(_003C_003Ec.AkWvnwiyWy8 ?? (_003C_003Ec.AkWvnwiyWy8 = _003C_003Ec.mElvj3e3w7y.Eakvjeif9lc)) > 0)
						{
							AppState.AppServer.NotifyOtherMachineSync();
						}
						return (isSuccess: flag, message: stringBuilder.ToString());
					}
					catch (Exception exception)
					{
						string text2 = "同步出错：" + exception.GetMessageWithInner();
						AFKtmdHLEbB.Warn(text2, exception);
						stringBuilder.AppendLine(text2);
						return (isSuccess: false, message: stringBuilder.ToString());
					}
				}
				return (isSuccess: false, message: "同步正在进行中，请稍等。");
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(aXetmjSa3tp);
				}
			}
		}
		return (isSuccess: false, message: "演示账号不支持同步。");
	}

	private (bool isSuccess, string message, SyncResult4 result, bool needAnotherSync) Nc1t672cVD3()
	{
		{
			StringBuilder stringBuilder = new StringBuilder();
			SyncVm4 syncVm = Mopt6hFfKUp();
			int num = syncVm.UpdatedItems.Count(_003C_003Ec.NUOvntw9nh1 ?? (_003C_003Ec.NUOvntw9nh1 = _003C_003Ec.mElvj3e3w7y.HLlvjYGUwCH));
			stringBuilder.AppendLine($"更新 {num} 项数据到服务器。");
			if (num > 0)
			{
				foreach (SyncItem4 updatedItem in syncVm.UpdatedItems)
				{
					stringBuilder.Append("  ");
					stringBuilder.AppendLine($"{updatedItem.ItemType}:{updatedItem.ItemId}  {updatedItem.DisplayName}");
				}
			}
			ApiResult<SyncResult4> apiResult = null;
			try
			{
				apiResult = aFIptTXYsUoTUF4v33R.UtBt1zMHveY(syncVm).Result;
				Soht6Rmc1Fu();
			}
			catch (Exception exception)
			{
				string text = "同步异常：" + exception.GetMessageWithInner();
				AFKtmdHLEbB.Warn(text, exception);
				stringBuilder.AppendLine(text);
				return (isSuccess: false, message: stringBuilder.ToString(), result: null, needAnotherSync: false);
			}
			(bool, bool) tuple = RCWt6qcvB1W(apiResult, syncVm, stringBuilder);
			if (apiResult.Data.Messages.HasData())
			{
				ifPt6pkp0yK(apiResult.Data.Messages);
			}
			if (syncVm.RequestFullData)
			{
				BEBtXZsF9mA();
			}
			return (isSuccess: tuple.Item1, message: stringBuilder.ToString(), result: apiResult.Data, needAnotherSync: tuple.Item2);
		}
		return (isSuccess: false, message: "当前帐号不支持同步。", result: null, needAnotherSync: false);
	}

	private void Soht6Rmc1Fu()
	{
		fggtKNoOdmy = false;
	}

	private (bool successWithNoError, bool needAnotherSync) RCWt6qcvB1W(ApiResult<SyncResult4> apiResult_0, SyncVm4 syncVm4_0, StringBuilder stringBuilder_0)
	{
		if (!apiResult_0.IsSuccess)
		{
			stringBuilder_0.AppendLine("服务器返回失败：" + apiResult_0.Message);
			AppHelper.ShowWarning("同步失败！" + apiResult_0.Message);
			return (successWithNoError: false, needAnotherSync: false);
		}
		bool item = true;
		bool item2 = false;
		MgRt6ZV8HEO(apiResult_0, stringBuilder_0);
		if (apiResult_0.Data.UserInfo != null)
		{
			hXrt6cJphpt(apiResult_0, stringBuilder_0);
		}
		if (!apiResult_0.Data.ConflictItems.HasData() && !string.IsNullOrEmpty(apiResult_0.Data.PcSlowVersion))
		{
			SoftVersionHelper.CheckVersionUpdateAfterFirstSync(apiResult_0.Data.PcSlowVersion, apiResult_0.Data.PcFastVersion);
		}
		if (apiResult_0.Data.Configurations != null)
		{
			ConfigurationsFromServer = apiResult_0.Data.Configurations;
		}
		if (apiResult_0.Data.Pc2ServerResults.HasData())
		{
			using IEnumerator<SyncItemResult4> enumerator = apiResult_0.Data.Pc2ServerResults.Where(_003C_003Ec.GPFvngY8DlM ?? (_003C_003Ec.GPFvngY8DlM = _003C_003Ec.mElvj3e3w7y.TytvjIreypU)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				_003C_003Ec__DisplayClass44_.kwvv4mEvrHr = enumerator.Current;
				SyncItem4 syncItem = syncVm4_0.UpdatedItems.FirstOrDefault(_003C_003Ec__DisplayClass44_.hjvv4XF8L8X);
				Vc4tmAUDTP1.UpdateItemSyncResult(_003C_003Ec__DisplayClass44_.kwvv4mEvrHr, syncItem, out var changedWhenSync);
				if (changedWhenSync)
				{
					item2 = true;
				}
			}
		}
		if (apiResult_0.Data.Server2PcItems.HasData())
		{
			foreach (SyncItem4 server2PcItem in apiResult_0.Data.Server2PcItems)
			{
				kUFt6V96H9J(server2PcItem, false);
			}
		}
		if (apiResult_0.Data.Pc2ServerResults.HasData())
		{
			_003C_003Ec__DisplayClass44_1 _003C_003Ec__DisplayClass44_2 = new _003C_003Ec__DisplayClass44_1();
			_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB = new SmartCollection<ConflictItem>();
			foreach (SyncItemResult4 item3 in apiResult_0.Data.Pc2ServerResults.Where(_003C_003Ec.K4SvnL1u6Du ?? (_003C_003Ec.K4SvnL1u6Du = _003C_003Ec.mElvj3e3w7y.CMCvjWGk0sX)))
			{
				ILocalDataEntity localDataEntity = null;
				if (item3.ItemType == SyncItemType.CommonData)
				{
					localDataEntity = Vc4tmAUDTP1.daWtreA8JCY(item3.ItemId);
				}
				if (item3.ItemType == SyncItemType.Profile)
				{
					localDataEntity = Vc4tmAUDTP1.GqStx3pjsFN(item3.ItemId);
				}
				if (localDataEntity != null)
				{
					_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.Add(new ConflictItem(item3, localDataEntity));
				}
			}
			if (_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.HasData())
			{
				_003C_003Ec__DisplayClass44_2.g0tv4pr2OxZ = false;
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass44_2.H1Sv4KZBWxI);
				while (!_003C_003Ec__DisplayClass44_2.g0tv4pr2OxZ)
				{
					Thread.Sleep(50);
				}
				using (IEnumerator<ConflictItem> enumerator3 = _003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						_003C_003Ec__DisplayClass44_2 _003C_003Ec__DisplayClass44_3 = new _003C_003Ec__DisplayClass44_2();
						_003C_003Ec__DisplayClass44_3.Kjpv4jNUmM1 = enumerator3.Current;
						if (_003C_003Ec__DisplayClass44_3.Kjpv4jNUmM1.ResolveMode == ConflictResolveMode.UseServer)
						{
							SyncItem4 syncItem2 = apiResult_0.Data.ConflictItems.FirstOrDefault(_003C_003Ec__DisplayClass44_3.cPdv4QlkPNK);
							if (syncItem2 == null)
							{
								AppHelper.ShowWarning($"未找到冲突条目的数据项：{_003C_003Ec__DisplayClass44_3.Kjpv4jNUmM1.ItemType} {_003C_003Ec__DisplayClass44_3.Kjpv4jNUmM1.ItemId}");
							}
							else
							{
								kUFt6V96H9J(syncItem2, false);
							}
						}
					}
				}
				if (_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.Any(_003C_003Ec.p9Svnv9kc00 ?? (_003C_003Ec.p9Svnv9kc00 = _003C_003Ec.mElvj3e3w7y.Kbovjkvr9AF)))
				{
					SyncOverwriteVm4 syncOverwriteVm = new SyncOverwriteVm4
					{
						MachineName = Environment.MachineName,
						UpdatedItems = new List<SyncItem4>()
					};
					foreach (ConflictItem item4 in _003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.Where(_003C_003Ec.al1vnSPBLDA ?? (_003C_003Ec.al1vnSPBLDA = _003C_003Ec.mElvj3e3w7y.D07vjGvGILM)))
					{
						syncOverwriteVm.UpdatedItems.Add(VfHt6WbbY06(item4.LocalDataEntity));
					}
					ApiResult<SyncOverwriteResult4> result = aFIptTXYsUoTUF4v33R.k2NtbwZrBv6(syncOverwriteVm).Result;
					if (result.IsSuccess)
					{
						using IEnumerator<SyncItemResult4> enumerator = result.Data.Pc2ServerResults.GetEnumerator();
						while (enumerator.MoveNext())
						{
							_003C_003Ec__DisplayClass44_3 _003C_003Ec__DisplayClass44_4 = new _003C_003Ec__DisplayClass44_3();
							_003C_003Ec__DisplayClass44_4.Hicv44q4Uwa = enumerator.Current;
							SyncItem4 syncItem3 = syncVm4_0.UpdatedItems.FirstOrDefault(_003C_003Ec__DisplayClass44_4.JChv4nRg53W);
							Vc4tmAUDTP1.UpdateItemSyncResult(_003C_003Ec__DisplayClass44_4.Hicv44q4Uwa, syncItem3, out var changedWhenSync2);
							if (changedWhenSync2)
							{
								item2 = true;
							}
						}
					}
					else
					{
						AFKtmdHLEbB.Warn("覆盖数据出错：" + result.Message);
						AppHelper.ShowWarning("覆盖服务器数据出错：" + result.Message);
					}
				}
				if (_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.Count(_003C_003Ec.cabvn2fC76G ?? (_003C_003Ec.cabvn2fC76G = _003C_003Ec.mElvj3e3w7y.ePhvjs8gm90)) > 0)
				{
					item = false;
				}
				stringBuilder_0.AppendLine($"共有{_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.Count}项冲突数据。保留服务器{_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.Count(_003C_003Ec.PCXvnu6puWC ?? (_003C_003Ec.PCXvnu6puWC = _003C_003Ec.mElvj3e3w7y.VAAvjH16IZ6))}项，保留本地{_003C_003Ec__DisplayClass44_2.Aqlv4rHLakB.Count(_003C_003Ec.KLjvnN7BhS4 ?? (_003C_003Ec.KLjvnN7BhS4 = _003C_003Ec.mElvj3e3w7y.OuTvj1dSYhk))}项。");
			}
		}
		if (apiResult_0.Data.RequestResendItems.HasData())
		{
			stringBuilder_0.AppendLine($"重传请求：{apiResult_0.Data.RequestResendItems.Count} 项；");
			Vc4tmAUDTP1.SetResendItems(apiResult_0.Data.RequestResendItems);
			item2 = true;
		}
		lUit668XYex();
		juQtmM3jwpR.NotifySyncComplete(this);
		if (apiResult_0.Data.LastSuccessSyncTimeUtc.HasValue)
		{
			Vc4tmAUDTP1.SaveLastSyncInfo(new LastSyncInfo
			{
				ServerTimeUtc = apiResult_0.Data.LastSuccessSyncTimeUtc
			});
		}
		return (successWithNoError: item, needAnotherSync: item2);
	}

	private void hXrt6cJphpt(ApiResult<SyncResult4> apiResult_0, StringBuilder stringBuilder_0)
	{
		uT4WJujEfNmOl8aWJJC.GiDtkIXiRXw(apiResult_0.Data.UserInfo.lGEtVStVQEK());
		if (string.IsNullOrEmpty(apiResult_0.Data.SecretInfo))
		{
			AppHelper.ShowWarning("同步异常，缺少用户信息数据。请反馈！");
			return;
		}
		Vc4tmAUDTP1.joVtrSyM3yO(apiResult_0.Data.SecretInfo, apiResult_0.Data.UserInfo);
		uT4WJujEfNmOl8aWJJC.UnxtkZDUHrh(apiResult_0.Data.UserInfo.Token);
		stringBuilder_0.AppendLine("更新本地用户信息；");
	}

	private void kUFt6V96H9J(SyncItem4 syncItem4_0, bool bool_2)
	{
		switch (syncItem4_0.ItemType)
		{
		case SyncItemType.Profile:
			bY4t6yuobRh(syncItem4_0, bool_2);
			break;
		default:
			AppHelper.LogErrorAndThrow($"加载数据异常：未知的数据类型：{syncItem4_0.ItemType}");
			break;
		case SyncItemType.CommonData:
			uKlt60gdcPZ(syncItem4_0, bool_2);
			break;
		}
	}

	private static void MgRt6ZV8HEO(ApiResult<SyncResult4> apiResult_0, StringBuilder stringBuilder_0)
	{
		int num = apiResult_0.Data.Pc2ServerResults?.Count ?? 0;
		int num2 = ((num > 0) ? apiResult_0.Data.Pc2ServerResults.Count(_003C_003Ec.giHvnJ5cdxi ?? (_003C_003Ec.giHvnJ5cdxi = _003C_003Ec.mElvj3e3w7y.V2CvjbB3ZQW)) : 0);
		int num3 = apiResult_0.Data.Server2PcItems?.Count ?? 0;
		stringBuilder_0.Append($"共更新 {num} 条数据到服务器。");
		if (num2 > 0)
		{
			stringBuilder_0.AppendLine($"失败 {num2} 条。");
			foreach (SyncItemResult4 item in apiResult_0.Data.Pc2ServerResults.Where(_003C_003Ec.t5cvn0Bg8ku ?? (_003C_003Ec.t5cvn0Bg8ku = _003C_003Ec.mElvj3e3w7y.r6Fvj66gojx)))
			{
				stringBuilder_0.AppendLine($" - {item.ItemType}:{item.ItemId} ({item.DisplayName}) 错误：{item.SyncState} {item.ErrorMessage}");
			}
		}
		else
		{
			stringBuilder_0.AppendLine("");
		}
		if (num3 <= 0)
		{
			return;
		}
		stringBuilder_0.AppendLine($"从服务器获取 {num3} 条数据。");
		foreach (SyncItem4 server2PcItem in apiResult_0.Data.Server2PcItems)
		{
			stringBuilder_0.Append("  ");
			stringBuilder_0.AppendLine($"{server2PcItem.ItemType}:{server2PcItem.ItemId}  {server2PcItem.DisplayName}");
		}
	}

	private SyncVm4 Mopt6hFfKUp()
	{
		LastSyncInfo lastSyncInfo = Vc4tmAUDTP1.GetLastSyncInfo();
		SyncVm4 syncVm = new SyncVm4
		{
			IsFirstSync = fggtKNoOdmy,
			RequestFullData = fggtKNoOdmy,
			LastSuccessSyncTimeUtc = lastSyncInfo?.ServerTimeUtc,
			LastUserMessageId = null,
			MachineName = Environment.MachineName,
			SoftVersion = AppHelper.GetSoftVersion(),
			LocalTimeUtc = DateTime.UtcNow,
			LastTextCommandSyncTime = null,
			TxBaffetId = uT4WJujEfNmOl8aWJJC.k25tkYhXNMI().phhtBlHX8M1()
		};
		foreach (CommonDataEntity item in Vc4tmAUDTP1.bGGtrhbtBm3())
		{
			ItemSyncState syncState = item.SyncState;
			if (KRg6iMQrFIxATWQ640kL == null)
			{
				switch (0)
				{
				}
			}
			switch (syncState)
			{
			case ItemSyncState.None:
				if (!item.IsDeleted)
				{
					syncVm.UnchangedItems.Add(new UnchangedSyncItem4
					{
						ItemType = SyncItemType.CommonData,
						ItemId = item.Id,
						BaseRevision = item.Revision,
						LastUpdateTimeUtc = item.LastUpdateTimeUtc
					});
				}
				break;
			case ItemSyncState.Pending:
			case ItemSyncState.Error:
				syncVm.UpdatedItems.Add(cpJt6YAOAke(item));
				break;
			}
		}
		int num2 = default(int);
		foreach (ProfileDataEntity item2 in Vc4tmAUDTP1.OYBtxfsIXs3())
		{
			if (item2.Data.Length <= 5000000)
			{
				ItemSyncState syncState = item2.SyncState;
				int num = 0;
				if (!nF9SMKQrcRNHDMBJ3LAt())
				{
					num = num2;
				}
				switch (num)
				{
				}
				switch (syncState)
				{
				case ItemSyncState.None:
					if (!item2.IsDeleted)
					{
						syncVm.UnchangedItems.Add(new UnchangedSyncItem4
						{
							ItemType = SyncItemType.Profile,
							ItemId = item2.Id,
							BaseRevision = item2.Revision,
							LastUpdateTimeUtc = item2.LastUpdateTimeUtc
						});
					}
					break;
				case ItemSyncState.Pending:
				case ItemSyncState.Error:
					syncVm.UpdatedItems.Add(XFXt6eiLsUt(item2));
					break;
				}
				continue;
			}
			ActionProfile actionProfile = mP6tXA8VyNP()[item2.Id];
			string message = $"同步失败!\n动作页 {actionProfile.Name:N0} ({item2.Data.Length}字节) 太大了（>5MB），无法进行同步。\n请修改此动作页中的动作，减小动作页尺寸。";
			AppHelper.ShowWarning(message);
			throw new InvalidDataException(message);
		}
		return syncVm;
	}

	private SyncItem4 XFXt6eiLsUt(ProfileDataEntity profileDataEntity_0)
	{
		return new SyncItem4
		{
			ItemType = SyncItemType.Profile,
			ItemId = profileDataEntity_0.Id,
			DisplayName = "(动作页)" + GetProfileName(profileDataEntity_0.Id),
			Data = profileDataEntity_0.Data,
			BaseRevision = profileDataEntity_0.Revision,
			LastUpdateTimeUtc = profileDataEntity_0.LastUpdateTimeUtc,
			IsDeleted = profileDataEntity_0.IsDeleted,
			DeleteTimeUtc = profileDataEntity_0.DeleteTimeUtc
		};
	}

	public string GetProfileName(string profileId)
	{
		mP6tXA8VyNP().TryGetValue(profileId, out var value);
		object obj;
		if (value == null)
		{
			obj = null;
		}
		else
		{
			obj = value.Name;
			if (obj != null)
			{
				goto IL_0022;
			}
		}
		obj = profileId;
		goto IL_0022;
		IL_0022:
		return (string)obj;
	}

	private static SyncItem4 cpJt6YAOAke(CommonDataEntity commonDataEntity_0)
	{
		return new SyncItem4
		{
			ItemType = SyncItemType.CommonData,
			ItemId = commonDataEntity_0.Id,
			SubType = commonDataEntity_0.SubType,
			DisplayName = "(常规数据)" + commonDataEntity_0.DisplayName,
			Data = commonDataEntity_0.Data,
			BaseRevision = commonDataEntity_0.Revision,
			LastUpdateTimeUtc = commonDataEntity_0.LastUpdateTimeUtc,
			IsDeleted = commonDataEntity_0.IsDeleted,
			DeleteTimeUtc = commonDataEntity_0.DeleteTimeUtc
		};
	}

	private SyncItem4 c89t6IT0Phx(SyncItemType syncItemType_0, string string_0)
	{
		switch (syncItemType_0)
		{
		case SyncItemType.CommonData:
			return cpJt6YAOAke(Vc4tmAUDTP1.daWtreA8JCY(string_0));
		default:
			throw new InvalidDataException($"无法获取同步对象！{syncItemType_0} {string_0}");
		case SyncItemType.Profile:
		{
			ProfileDataEntity profileDataEntity_ = Vc4tmAUDTP1.GqStx3pjsFN(string_0);
			return XFXt6eiLsUt(profileDataEntity_);
		}
		}
	}

	private SyncItem4 VfHt6WbbY06(ILocalDataEntity ilocalDataEntity_0)
	{
		if (ilocalDataEntity_0 is CommonDataEntity commonDataEntity_)
		{
			return cpJt6YAOAke(commonDataEntity_);
		}
		if (!(ilocalDataEntity_0 is ProfileDataEntity profileDataEntity_))
		{
			throw new InvalidDataException("无法识别的数据对象，可能您使用的Quicker版本太旧了！");
		}
		return XFXt6eiLsUt(profileDataEntity_);
	}

	
	public Task LoadActionBlockListAsync()
	{
        BlockedActions = Vc4tmAUDTP1.PP6trtaO3SY<List<string>>("local_blocked_actions") ?? new List<string>();
        return Task.CompletedTask;
    }

	[SpecialName]
	[CompilerGenerated]
	private UserSettings nYitXohYTns()
	{
		return vIitmO9co2d;
	}

	[SpecialName]
	[CompilerGenerated]
	private void XTptXTpHkas(UserSettings value)
	{
		vIitmO9co2d = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal IDictionary<string, ActionProfile> mP6tXA8VyNP()
	{
		return LB7tmFN7yvI;
	}

	[SpecialName]
	[CompilerGenerated]
	internal IDictionary<string, ExeSettings> TxrtXFmcoEV()
	{
		return WlNtmUwpA4o;
	}

	[SpecialName]
	[CompilerGenerated]
	private void G8HtXU9ZLAQ(IDictionary<string, ExeSettings> value)
	{
		WlNtmUwpA4o = value;
	}

	[SpecialName]
	internal int LDPtXifl4Ca()
	{
		return mP6tXA8VyNP().Values.Select(_003C_003Ec.kyavnPXOKQJ ?? (_003C_003Ec.kyavnPXOKQJ = _003C_003Ec.mElvj3e3w7y.H55vjmcSemd)).Distinct().Count();
	}

	public SubProgram GetGlobalSubProgram(string idOrName)
	{
		_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_0();
		_003C_003Ec__DisplayClass84_.yrHv4DyGd3k = idOrName;
		return GlobalSubPrograms.FirstOrDefault(_003C_003Ec__DisplayClass84_.myRv45QahL6);
	}

	public SubProgram GetSharedSubProgram(string id, string version)
	{
		if (string.IsNullOrEmpty(id))
		{
			return null;
		}
		string key = id + "@" + version;
		if (f5ftm3iTPyu.ContainsKey(key))
		{
			return f5ftm3iTPyu[key];
		}
		SharedActionDto result = Wott6D3Yp9F(Guid.Parse(id), Convert.ToInt32(version)).GetAwaiter().GetResult();
		if (result == null)
		{
			return null;
		}
		SubProgram subProgramFromSharedAction = SubProgramHelper.GetSubProgramFromSharedAction(result);
		f5ftm3iTPyu[key] = subProgramFromSharedAction;
		return subProgramFromSharedAction;
	}

	[SpecialName]
	internal SmartCollection<TextCommand> neZtXfcGsie()
	{
		return v1gtKP1MaNi;
	}

	[SpecialName]
	[CompilerGenerated]
	internal IList<TextCommand> pI6tmwhv9XL()
	{
		return hTrtKwNV8Pr;
	}

	[SpecialName]
	[CompilerGenerated]
	private void rTotmtq3Nyw(IList<TextCommand> value)
	{
		hTrtKwNV8Pr = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal SmartCollection<MouseAction> FnrtmLxNViE()
	{
		return DJytKtcwIKB;
	}

	[SpecialName]
	[CompilerGenerated]
	private void FPAtmvWAYct(SmartCollection<MouseAction> value)
	{
		DJytKtcwIKB = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal IList<Gesture> Y0Etm2L8Pto()
	{
		return vT8tKgprweH;
	}

	[SpecialName]
	[CompilerGenerated]
	private void xvstmuUUh7c(IList<Gesture> value)
	{
		vT8tKgprweH = value;
	}

	[SpecialName]
	internal string PZTtmCY0ah7()
	{
		return uT4WJujEfNmOl8aWJJC.k25tkYhXNMI().jxqtBavgP7C();
	}

	[SpecialName]
	internal int R4UtmELcTTk()
	{
		return uT4WJujEfNmOl8aWJJC.k25tkYhXNMI().z2BtBqnFctT();
	}

	[SpecialName]
	internal string uxEtm8IT39s()
	{
		return uT4WJujEfNmOl8aWJJC.k25tkYhXNMI().mV2tBZbEDIQ();
	}

	[SpecialName]
	internal UserSettings CpItmVISR7P()
	{
		if (nYitXohYTns() == null)
		{
			XTptXTpHkas(new UserSettings());
		}
		return nYitXohYTns();
	}

	[SpecialName]
	internal bool eZqtmsq6kBc()
	{
		return true;
	}

	[SpecialName]
	internal ActionItem oiEtm1YGfcm()
	{
		return uT4WJujEfNmOl8aWJJC.k25tkYhXNMI().rUStBD4WdHC();
	}


	public DataService(SQLDataMgr localDataMgr, AppPathProvider appPathProvider, ITinyMessengerHub hub)
	{
		Vc4tmAUDTP1 = localDataMgr;
		dEytmTNDh9m = appPathProvider;
		juQtmM3jwpR = hub;
		AppState.DataService = this;
		v1gtKP1MaNi.CollectionChanged += RV3tXxMWj4Z;
		Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Send, new Action(NTHtXrpSn7d));
	}

	private void g36t6H0gnnI()
	{
		Task.Run((Action)aJKtXpO0plN);
	}

	private void mBxt61DNq3n(NetworkManager networkManager_1, NLM_CONNECTIVITY nlm_CONNECTIVITY_0)
	{
        // 保留用户配置的网络恢复触发器，只移除原厂同步。
        if (IsNetworkConnected())
            AppState.e8GtaFtc06Z()?.RestartAfterSystemSleep("ConnectivityChanged");
    }

	public bool IsNetworkConnected()
	{
        return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
    }

	internal bool pNct6b5ah9E()
	{
        try
        {
            Vc4tmAUDTP1.SetReadonly(false);
            var data = Vc4tmAUDTP1.jiDtra7gJVt();
            uT4WJujEfNmOl8aWJJC.GiDtkIXiRXw(data.userInfo.lGEtVStVQEK());
            XTptXTpHkas(data.userSettings);
            G8HtXU9ZLAQ(data.exeSettings);
            gfxtKCsAt5a = data.txtFloatpanelState ?? new TextFloatPanelState();
            JGJtXCmp26H(data.powerKeys);
            neZtXfcGsie().Reset(data.textCommands);
            FnrtmLxNViE().Reset(data.mouseActions);
            xvstmuUUh7c(data.gestures);
            FavorBlocks = data.favorBlocks;
            GlobalSubPrograms.Reset(data.globalSubPrograms);
            UserPreference = data.userPreference;
            ConfigurationsFromServer = Vc4tmAUDTP1.PP6trtaO3SY<Dictionary<string, string>>("local_configurations")
                ?? new Dictionary<string, string>();

            foreach (ActionProfile profile in data.profiles)
                wwQt6nwg0BT(profile);
            lUit668XYex();

            var workspace = Vc4tmAUDTP1.LoadLocalWorkspace();
            if (!workspace.Initialized)
            {
                // 仅首次创建工作区时建立空白页，避免每次启动重新添加用户删除的页。
                if (!mP6tXA8VyNP().Values.Any(p => p.ExeFile == "_global"))
                    xHZt6K2LJ8p(new ActionProfile {
                        Id = Guid.NewGuid().ToString(), Name = "_global",
                        ExeFile = "_global", ProfileType = ProfileType.Global
                    });
                if (!mP6tXA8VyNP().Values.Any(p => p.ExeFile == "common"))
                    xHZt6K2LJ8p(new ActionProfile {
                        Id = Guid.NewGuid().ToString(), Name = "_default",
                        ExeFile = "common", ProfileType = ProfileType.Default
                    });
                Vc4tmAUDTP1.oYetrup9mBq(data.userSettings);
                workspace.Initialized = true;
                Vc4tmAUDTP1.SaveCommonDataObjectFromLocal("local_workspace", workspace, true);
            }

            var adorns = ActionStateWriter.LoadActionAdorn();
            if (adorns != null)
                foreach (var adorn in adorns)
                    oKHtK8wCbaN[adorn.Key] = adorn.Value;
            BlockedActions = Vc4tmAUDTP1.PP6trtaO3SY<List<string>>("local_blocked_actions") ?? new List<string>();
            fggtKNoOdmy = false;
            g36t6H0gnnI();
            return true;
        }
        catch (Exception error)
        {
            AFKtmdHLEbB.Error("加载本地工作区失败。", error);
            MessageBoxHelper.Show("无法读取本地工作区，原文件已保留。\n数据位置：" +
                dEytmTNDh9m.GetDataSubFolder() + "\n错误：" + error.Message,
                "Quicker 本地版", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
    }

	private void lUit668XYex()
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, ActionProfile> item in mP6tXA8VyNP())
		{
			ActionProfile value = item.Value;
			if (value.ExeFile.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) || !value.ExeFile.StartsWithAny(false, "#_", "@_"))
			{
				continue;
			}
			if (KRg6iMQrFIxATWQ640kL == null)
			{
				switch (0)
				{
				}
			}
			if (!TxrtXFmcoEV().ContainsKey(value.ExeFile))
			{
				AFKtmdHLEbB.Warn("忽略场景不存在的动作页：id=" + value.Id + " exe=" + value.ExeFile + " name=" + value.Name + " 适用主机=" + value.ValidForMachines);
				list.Add(item.Key);
			}
		}
		foreach (string item2 in list)
		{
			try
			{
				mP6tXA8VyNP().Remove(item2);
			}
			catch (Exception ex)
			{
				AFKtmdHLEbB.Warn("移除已删除动作页出错：" + ex.Message + " id=" + item2);
			}
		}
	}

	private static void vcxt6X69yZw()
	{
		AppHelper.RunOnUiThread(false, _003C_003Ec.jo3vn7GoTX1 ?? (_003C_003Ec.jo3vn7GoTX1 = _003C_003Ec.mElvj3e3w7y.S6TvjptGT54));
	}

	internal void xdNt6mQNakh(bool bool_2, bool bool_3 = false, bool bool_4 = false, int? nullable_0 = null)
	{
        // 旧调用点在写入 SQLite 后通知此方法。保存已经完成，无需安排上传。
        NBetK2fsnHg.Clear();
        Q5Ft6uJgbDC(QuickerSyncState.Idle);
    }

	internal void xHZt6K2LJ8p(ActionProfile actionProfile_0, int int_1 = 0)
	{
        if (actionProfile_0 == null) throw new ArgumentNullException(nameof(actionProfile_0));
        lock (uYMtKuR8W45)
        {
            actionProfile_0.SharedActionIds = (actionProfile_0.ActionItems ?? new List<ActionItem>())
                .Select(a => a.TemplateId).Where(id => !string.IsNullOrEmpty(id))
                .Distinct().OrderBy(id => id).ToArray();
            string json = JsonConvert.SerializeObject(actionProfile_0);
            if (!RYrtmoduVG5.IsProfileChanged(actionProfile_0, json)) return;
            actionProfile_0.LastUpdateTimeUtc = AppHelper.GetUtcNowForDb();
            json = JsonConvert.SerializeObject(actionProfile_0);
            Vc4tmAUDTP1.fcGtxUEHcM1(actionProfile_0.Id, json, false, actionProfile_0.LastUpdateTimeUtc.Value);
            // 写入成功后才更新缓存，失败时保留再次保存的机会。
            MXRt64qdb2Q(actionProfile_0);
            RYrtmoduVG5.UpdateProfile(actionProfile_0, json);
        }
        xdNt6mQNakh(false);
    }

	internal void hC1t6xmuLdZ(ActionProfile actionProfile_0)
	{
        lock (uYMtKuR8W45)
        {
            Vc4tmAUDTP1.mCXtxlXbkjx(actionProfile_0.Id);
            RYrtmoduVG5.RemoveProfile(actionProfile_0);
            mP6tXA8VyNP().Remove(actionProfile_0.Id);
        }
        xdNt6mQNakh(false);
    }

	internal void ydot6rVZAkW()
	{
        Vc4tmAUDTP1.oYetrup9mBq(nYitXohYTns());
        xdNt6mQNakh(false);
    }

	public bool IsFirstSync()
	{
		return fggtKNoOdmy;
	}

	private void ifPt6pkp0yK(IList<Server2UserMessage> ilist_4)
	{
		_003C_003Ec__DisplayClass157_0 _003C_003Ec__DisplayClass157_ = new _003C_003Ec__DisplayClass157_0();
		_003C_003Ec__DisplayClass157_.EsovnTARfcn = new StringBuilder(1000);
		_003C_003Ec__DisplayClass157_.EsovnTARfcn.Append("<html><head><meta charset=\"UTF-8\"></head><body>");
		_003C_003Ec__DisplayClass157_.EsovnTARfcn.AppendLine("来自Quicker服务器的消息：");
		_003C_003Ec__DisplayClass157_.EsovnTARfcn.AppendLine("<ul>");
		foreach (Server2UserMessage item in ilist_4)
		{
			_003C_003Ec__DisplayClass157_.EsovnTARfcn.AppendLine("<li>");
			_003C_003Ec__DisplayClass157_.EsovnTARfcn.AppendLine(item.Message);
			if (!string.IsNullOrEmpty(item.Link))
			{
				_003C_003Ec__DisplayClass157_.EsovnTARfcn.AppendLine(" <a href='" + item.Link + "' target=_blank>查看详情</a>");
			}
			_003C_003Ec__DisplayClass157_.EsovnTARfcn.AppendLine("</li>");
		}
		_003C_003Ec__DisplayClass157_.EsovnTARfcn.AppendLine("</ul>");
		_003C_003Ec__DisplayClass157_.EsovnTARfcn.Append("</body>");
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass157_.CtgvnoR4QiI);
	}

	private (bool hasNew, IList<Gesture> gestures) YZGt6BEB3Vb(IList<Gesture> ilist_4, IList<Gesture> ilist_5)
	{
		bool item = false;
		IList<Gesture> list = ilist_4.ToList();
		using (IEnumerator<Gesture> enumerator = ilist_5.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass158_0 _003C_003Ec__DisplayClass158_ = new _003C_003Ec__DisplayClass158_0();
				_003C_003Ec__DisplayClass158_.jOSvnAb5nmR = enumerator.Current;
				Gesture gesture = list.FirstOrDefault(_003C_003Ec__DisplayClass158_.dITvnM7Yd07);
				if (gesture != null)
				{
					if (_003C_003Ec__DisplayClass158_.jOSvnAb5nmR.LastUpdateTimeUtc > gesture.LastUpdateTimeUtc)
					{
						gesture.LastUpdateTimeUtc = _003C_003Ec__DisplayClass158_.jOSvnAb5nmR.LastUpdateTimeUtc;
						gesture.Points = _003C_003Ec__DisplayClass158_.jOSvnAb5nmR.Points;
						gesture.Name = _003C_003Ec__DisplayClass158_.jOSvnAb5nmR.Name;
						gesture.IsDeleted = _003C_003Ec__DisplayClass158_.jOSvnAb5nmR.IsDeleted;
						item = true;
					}
				}
				else
				{
					list.Add(_003C_003Ec__DisplayClass158_.jOSvnAb5nmR);
					item = true;
				}
			}
		}
		return (hasNew: item, gestures: list);
	}

	private void ObFt6Qyhpv4(string string_0)
	{
	}

	private ActionProfile HOJt6jqSmoE(Guid guid_0)
	{
		string text = guid_0.ToString();
		if (mP6tXA8VyNP().ContainsKey(text))
		{
			ActionProfile result = mP6tXA8VyNP()[text];
			mP6tXA8VyNP().Remove(text);
			RYrtmoduVG5.RemoveProfile(text);
			return result;
		}
		return null;
	}

	private void wwQt6nwg0BT(ActionProfile actionProfile_0)
	{
		MXRt64qdb2Q(actionProfile_0);
		RYrtmoduVG5.UpdateProfile(actionProfile_0, JsonConvert.SerializeObject(actionProfile_0));
	}

	private void MXRt64qdb2Q(ActionProfile actionProfile_0)
	{
		mP6tXA8VyNP()[actionProfile_0.Id] = actionProfile_0;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			tWGtmf9CMcV?.Dispose();
			WU8tKJ2N7mo?.Dispose();
			NBetK2fsnHg?.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public int GetPendingSyncItemCount()
	{
		return Vc4tmAUDTP1.GetPendingSyncItemCount();
	}

	public IList<SyncLogItem> GetRecentSyncLogs()
	{
		return Vc4tmAUDTP1.UKZtrWJeIVY();
	}

	internal Task<SharedActionDto> Wott6D3Yp9F(Guid guid_0, int int_1)
	{
		try
		{
			var action = vHwtK0yHtUa.Get(guid_0, int_1) ?? LocalDataStore.GetSharedAction(guid_0, int_1);
			vHwtK0yHtUa.Save(action);
			return Task.FromResult(action);
		}
		catch (Exception error)
		{
			return Task.FromException<SharedActionDto>(error);
		}
	}

	internal void Gn9t6dsn2Bp(SharedActionDto sharedActionDto_0)
	{
		vHwtK0yHtUa.Save(sharedActionDto_0);
		Vc4tmAUDTP1.SaveSharedAction(sharedActionDto_0);
	}

	[SpecialName]
	internal IList<ExeSettings> Q0ltmmbUTMB()
	{
		return TxrtXFmcoEV().Values.ToList();
	}

	internal ExeSettings yQWt6ownR4Z(string string_0, bool bool_2 = false)
	{
		_003C_003Ec__DisplayClass174_0 _003C_003Ec__DisplayClass174_ = new _003C_003Ec__DisplayClass174_0();
		_003C_003Ec__DisplayClass174_.Hp6vnix9nlI = string_0;
		if (_003C_003Ec__DisplayClass174_.Hp6vnix9nlI == "_global" && !bool_2)
		{
			bool_2 = true;
		}
		ExeSettings exeSettings;
		ICollection<ActionProfile> source;
		string text;
		int num;
		if (_003C_003Ec__DisplayClass174_.Hp6vnix9nlI != null)
		{
			string key = _003C_003Ec__DisplayClass174_.Hp6vnix9nlI.ToLowerInvariant();
			exeSettings = null;
			if (TxrtXFmcoEV() != null && TxrtXFmcoEV().ContainsKey(key))
			{
				exeSettings = TxrtXFmcoEV()[key];
			}
			if (exeSettings == null && bool_2)
			{
				source = mP6tXA8VyNP().Values.ToList();
				text = source.FirstOrDefault(_003C_003Ec__DisplayClass174_.zM2vnUHByHW)?.ExeFullpath;
				num = 0;
				if (KRg6iMQrFIxATWQ640kL != null)
				{
					goto IL_00d7;
				}
				goto IL_00db;
			}
			goto IL_017e;
		}
		return null;
		IL_00db:
		string text2;
		while (true)
		{
			switch (num)
			{
			default:
				text2 = "";
				if (string.IsNullOrEmpty(text))
				{
					break;
				}
				goto IL_00ca;
			case 1:
				text2 = ExeHelper.GetFileDescription(text);
				break;
			}
			break;
			IL_00ca:
			num = 1;
			if (nF9SMKQrcRNHDMBJ3LAt())
			{
				continue;
			}
			goto IL_00d7;
		}
		if (string.IsNullOrEmpty(text2))
		{
			text2 = _003C_003Ec__DisplayClass174_.Hp6vnix9nlI;
		}
		exeSettings = new ExeSettings
		{
			Exe = _003C_003Ec__DisplayClass174_.Hp6vnix9nlI,
			Name = text2,
			Path = text,
			DisableMiddleButton = false,
			IconUrl = "",
			ProfileList = source.Where(_003C_003Ec__DisplayClass174_.JDXvnltFy6X).Select(_003C_003Ec.K9RvnVnfiCl ?? (_003C_003Ec.K9RvnVnfiCl = _003C_003Ec.mElvj3e3w7y.RPZvj46cbPA)).ToList()
		};
		goto IL_017e;
		IL_017e:
		return exeSettings;
		IL_00d7:
		int num2 = default(int);
		num = num2;
		goto IL_00db;
	}

	internal ExeSettings yNft6Tt604K(string string_0)
	{
		ExeSettings exeSettings = yQWt6ownR4Z(string_0);
		if (exeSettings == null)
		{
			foreach (ExeSettings item in TxrtXFmcoEV().Values.ToList())
			{
				IList<string> aliasExeList = item.AliasExeList;
				if (aliasExeList != null && aliasExeList.Contains(string_0, StringComparer.OrdinalIgnoreCase))
				{
					return item;
				}
			}
			return null;
		}
		return exeSettings;
	}

	internal ExeSettings DjNt6MCQCru()
	{
		return yNft6Tt604K(AppState.CurrentExeName);
	}

	internal void a65t6APblky(ExeSettings exeSettings_0)
	{
		if (string.IsNullOrEmpty(exeSettings_0.Exe) || exeSettings_0.Exe != exeSettings_0.Exe.ToLowerInvariant())
		{
			throw new InvalidDataException("ExeSettings的exe值不正确");
		}
		TxrtXFmcoEV()[exeSettings_0.Exe] = exeSettings_0;
		Vc4tmAUDTP1.SaveCommonDataObjectFromLocal(exeSettings_0.GetCommonDataId(), exeSettings_0, false);
		xdNt6mQNakh(false);
	}

	internal void Dxnt6OJIGNi(string string_0)
	{
		TxrtXFmcoEV().Remove(string_0);
		Vc4tmAUDTP1.qektrwnCtKy(ExeSettings.GetCommonDataId(string_0));
		xdNt6mQNakh(false);
	}

	public void ExportActionListForListary(string filename)
	{
		StringBuilder stringBuilder = new StringBuilder(10000);
		foreach (ActionProfile value in mP6tXA8VyNP().Values)
		{
			foreach (ActionItem actionItem in value.ActionItems)
			{
				if (actionItem.CanExport())
				{
					stringBuilder.AppendLine(actionItem.Title + "|" + actionItem.Title + "|" + actionItem.GetUri());
				}
			}
		}
		File.WriteAllText(filename, stringBuilder.ToString());
	}

	internal void OY0t6FeNKVk(string string_0)
	{
		CsvExport csvExport = new CsvExport(",", true);
		int num2 = default(int);
		foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
		{
			ExeSettings exeSettings = yQWt6ownR4Z(item.ExeFile);
			foreach (ActionItem actionItem in item.ActionItems)
			{
				if (!actionItem.CanExport())
				{
					continue;
				}
				csvExport.AddRow();
				csvExport["Id"] = actionItem.Id;
				csvExport["名称"] = actionItem.Title;
				csvExport["说明"] = actionItem.Description;
				csvExport["图标"] = actionItem.Icon;
				csvExport["类型"] = actionItem.ActionType;
				csvExport["Uri"] = actionItem.GetUri();
				csvExport["动作页"] = item.Name;
				int num = 0;
				if (!nF9SMKQrcRNHDMBJ3LAt())
				{
					num = num2;
				}
				while (true)
				{
					switch (num)
					{
					default:
						do
						{
							csvExport["EXE"] = item.ExeFile;
							csvExport["关联Exe"] = exeSettings?.AliasExeList?.JoinToString(",").Or("");
							csvExport["位置"] = $"{actionItem.Row}行 {actionItem.Col}列";
							num = 1;
						}
						while (KRg6iMQrFIxATWQ640kL != null);
						continue;
					case 1:
						break;
					}
					break;
				}
				csvExport["大小"] = AppHelper.GetActionSizeKb(actionItem) + "K";
				csvExport["创建或安装时间"] = actionItem.CreateTimeUtc?.ToLocalTime();
				DateTime? lastEditTimeUtc = actionItem.LastEditTimeUtc;
				object obj;
				if (!lastEditTimeUtc.HasValue)
				{
					obj = null;
				}
				else
				{
					obj = lastEditTimeUtc.GetValueOrDefault().ToLocalTime().ToString();
					if (obj != null)
					{
						goto IL_0258;
					}
				}
				obj = "";
				goto IL_0258;
				IL_0258:
				csvExport["最后更新"] = obj;
				csvExport["来源动作"] = (string.IsNullOrEmpty(actionItem.TemplateId) ? "" : AppHelper.CreateSharedActionLink(actionItem.TemplateId));
			}
		}
		csvExport.ExportToFile(string_0, true);
	}

	[IteratorStateMachine(typeof(_003CGetAllActionItems_003Ed__181))]
	public IEnumerable<ActionItem> GetAllActionItems()
	{
		return new _003CGetAllActionItems_003Ed__181(-2)
		{
			_003C_003E4__this = this
		};
	}

	[IteratorStateMachine(typeof(_003CGetAllValidActionItems_003Ed__182))]
	internal IEnumerable<ActionItem> m8kt6U4wyce()
	{
		return new _003CGetAllValidActionItems_003Ed__182(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal IList<ActionItem> WhOt6lqZteK()
	{
		List<ActionItem> list = new List<ActionItem>();
		foreach (ActionItem allActionItem in GetAllActionItems())
		{
			ActionAssociation association = allActionItem.Association;
			if (association != null && association.IsImageProcessor)
			{
				list.Add(allActionItem);
			}
		}
		return list.OrderBy(_003C_003Ec.U4WvnZ14evi ?? (_003C_003Ec.U4WvnZ14evi = _003C_003Ec.mElvj3e3w7y.YT2vj5Ct4R5)).ToList();
	}

	internal IList<ActionItem> yR5t6iJkaBT(IList<string> ilist_4)
	{
		List<ActionItem> list = new List<ActionItem>();
		foreach (ActionItem allActionItem in GetAllActionItems())
		{
			if (iG2t63gcBZF(ilist_4, allActionItem.Association))
			{
				list.Add(allActionItem);
			}
		}
		return list.OrderBy(_003C_003Ec.abevn9niSSx ?? (_003C_003Ec.abevn9niSSx = _003C_003Ec.mElvj3e3w7y.wifvjDrmsiG)).ToList();
	}

	private static bool iG2t63gcBZF(IList<string> ilist_4, ActionAssociation actionAssociation_0)
	{
		if (actionAssociation_0 == null)
		{
			return false;
		}
		if (!actionAssociation_0.IsFileProcessor)
		{
			return false;
		}
		if (actionAssociation_0.FileMinCount > 0 && ilist_4.Count < actionAssociation_0.FileMinCount)
		{
			return false;
		}
		if (actionAssociation_0.FileMaxCount > 0 && ilist_4.Count > actionAssociation_0.FileMaxCount)
		{
			return false;
		}
		if (!string.IsNullOrWhiteSpace(actionAssociation_0.AllowedFileExtensions))
		{
			_003C_003Ec__DisplayClass185_0 _003C_003Ec__DisplayClass185_ = new _003C_003Ec__DisplayClass185_0();
			_003C_003Ec__DisplayClass185_.PdkvnzeH1hT = actionAssociation_0.AllowedFileExtensions.Split(new char[3] { ';', ',', '；' }, StringSplitOptions.RemoveEmptyEntries);
			if (_003C_003Ec__DisplayClass185_.PdkvnzeH1hT.Length == 0)
			{
				return true;
			}
			if (actionAssociation_0.RequireAllFileMatchExt)
			{
				return ilist_4.All(_003C_003Ec__DisplayClass185_.VK9vn3UgY4Q);
			}
			return ilist_4.Any(_003C_003Ec__DisplayClass185_.ztVvnfTeRMq);
		}
		return true;
	}

	internal IList<ActionItem> QVgt6fuEUYI(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return new List<ActionItem>();
		}
		List<ActionItem> list = new List<ActionItem>();
		foreach (ActionItem allActionItem in GetAllActionItems())
		{
			if (zVut6z3JOZb(string_0, allActionItem.Association))
			{
				list.Add(allActionItem);
			}
		}
		return list.OrderBy(_003C_003Ec.gQqvnhhwHgM ?? (_003C_003Ec.gQqvnhhwHgM = _003C_003Ec.mElvj3e3w7y.G0UvjdneaEB)).ToList();
	}

	private static bool zVut6z3JOZb(string string_0, ActionAssociation actionAssociation_0)
	{
		if (actionAssociation_0 == null)
		{
			return false;
		}
		if (!actionAssociation_0.IsTextProcessor)
		{
			return false;
		}
		if (actionAssociation_0.TextMinLength > 0 && string_0.Length < actionAssociation_0.TextMinLength)
		{
			return false;
		}
		if (actionAssociation_0.TextMaxLength > 0 && string_0.Length > actionAssociation_0.TextMaxLength)
		{
			return false;
		}
		if (!string.IsNullOrEmpty(actionAssociation_0.TextMatchExpression))
		{
			try
			{
				if (!Regex.IsMatch(string_0, actionAssociation_0.TextMatchExpression))
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				AFKtmdHLEbB.Warn("正则匹配出错。错误：" + ex.Message + " 原文：" + string_0.ToShortString(100) + " 正则：" + actionAssociation_0.TextMatchExpression);
				return false;
			}
		}
		return true;
	}

	internal (ActionItem action, string message) QHmtXwg81eY(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return (action: null, message: "请提供动作的id/名称/动作库id");
		}
		int num = string_0.IndexOfAny(new char[2] { ' ', '?' });
		if (num > 0)
		{
			string_0 = string_0.Substring(0, num);
		}
		ActionItem item = GetActionById(string_0).action;
		if (item != null)
		{
			return (action: item, message: "使用动作id找到动作");
		}
		IList<ActionItem> list = S0KtXvrNDeP(string_0);
		if (list.Count == 1)
		{
			return (action: list[0], message: "使用名称找到动作");
		}
		if (list.Count == 0)
		{
			IList<ActionItem> list2 = d2ctXSU2gt9(string_0);
			if (list2.Count == 1)
			{
				return (action: list2[0], message: "使用动作库id找到动作");
			}
			if (list2.Count == 0)
			{
				return (action: null, message: "找不到动作：" + string_0);
			}
			return (action: null, message: "找到多个具有相同动作库ID的动作：" + string_0);
		}
		return (action: null, message: "找到多个同名动作：" + string_0);
	}

	internal IEnumerable<ActionSearchResult> tyXtXtQLUHP(QueryContext queryContext_0, bool bool_2, bool bool_3, bool bool_4 = false, bool bool_5 = false)
	{
		List<ActionSearchResult> list = new List<ActionSearchResult>();
		string search = queryContext_0.Search;
		if (string.IsNullOrEmpty(search))
		{
			return list;
		}
		int num = 0;
		if (!bool_3)
		{
			foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
			{
				if (bool_5 && !AppHelper.IsMachineValid(item.ValidForMachines))
				{
					continue;
				}
				foreach (ActionItem actionItem in item.ActionItems)
				{
					if (actionItem.CanExport() && (!bool_4 || actionItem.ActionType != ActionType.LinkAction))
					{
						MultiFieldMatchResult multiFieldMatchResult = ovMtXLuvNls(actionItem, search, queryContext_0);
						if (multiFieldMatchResult != null && multiFieldMatchResult.Score > num)
						{
							list.Add(new ActionSearchResult(actionItem, item, multiFieldMatchResult.Score)
							{
								TitleMatchResult = multiFieldMatchResult.Result1,
								DescriptionMatchResult = multiFieldMatchResult.Result2
							});
						}
					}
				}
			}
		}
		if (bool_2 && CpItmVISR7P().QuickRunItems.HasData())
		{
			foreach (QuickRunItem quickRunItem in CpItmVISR7P().QuickRunItems)
			{
				if (!string.Equals(quickRunItem.CmdText, search, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
				_003C_003Ec__DisplayClass189_0 _003C_003Ec__DisplayClass189_ = new _003C_003Ec__DisplayClass189_0();
				_003C_003Ec__DisplayClass189_.DgDv4SyFUTM = null;
				ActionProfile profile = null;
				if (Guid.TryParse(quickRunItem.Data, out var result))
				{
					(ActionItem, ActionProfile) actionById = GetActionById(quickRunItem.Data);
					if (actionById.Item1 != null)
					{
						(_003C_003Ec__DisplayClass189_.DgDv4SyFUTM, profile) = actionById;
					}
				}
				else
				{
					(ActionItem, string) tuple2 = QHmtXwg81eY(quickRunItem.Data);
					if (tuple2.Item1 != null)
					{
						_003C_003Ec__DisplayClass189_.DgDv4SyFUTM = tuple2.Item1;
						profile = GetActionById(_003C_003Ec__DisplayClass189_.DgDv4SyFUTM.Id).profile;
					}
				}
				if (_003C_003Ec__DisplayClass189_.DgDv4SyFUTM != null)
				{
					ActionSearchResult actionSearchResult = list.FirstOrDefault(_003C_003Ec__DisplayClass189_.BCov4vlAa4k);
					int score = 11000;
					if (actionSearchResult != null)
					{
						actionSearchResult.Score = score;
						actionSearchResult.IsDirectWord = true;
					}
					else
					{
						list.Add(new ActionSearchResult(_003C_003Ec__DisplayClass189_.DgDv4SyFUTM, profile, score)
						{
							IsDirectWord = true
						});
					}
				}
			}
		}
		return list.OrderByDescending(_003C_003Ec.JsJvneDdP3a ?? (_003C_003Ec.JsJvneDdP3a = _003C_003Ec.mElvj3e3w7y.U88vjoclLyw)).Take(100);
	}

	internal IEnumerable<ActionSearchResult> NKbtXg2X0Rx(QueryContext queryContext_0, bool bool_2, bool bool_3, bool bool_4, bool bool_5, ActionSearchAdjustScoreData actionSearchAdjustScoreData_0)
	{
		if (actionSearchAdjustScoreData_0 != null && !actionSearchAdjustScoreData_0.IsNoAdjust())
		{
			List<ActionSearchResult> list = new List<ActionSearchResult>();
			string search = queryContext_0.Search;
			if (string.IsNullOrEmpty(search))
			{
				return list;
			}
			int num = 0;
			if (!bool_3)
			{
				IList<ActionProfile> validProfilesByExe = AppState.B2BtasP38AU().GetValidProfilesByExe(actionSearchAdjustScoreData_0.CurrentExe, false);
				IList<ActionProfile> globalProfiles = AppState.B2BtasP38AU().GetGlobalProfiles(bool_5);
				foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
				{
					if (bool_5 && !AppHelper.IsMachineValid(item.ValidForMachines))
					{
						continue;
					}
					bool flag = validProfilesByExe.Contains(item);
					bool flag2 = globalProfiles.Contains(item);
					bool flag3 = !flag && !flag2;
					if (actionSearchAdjustScoreData_0.IsMultiply && ((flag && actionSearchAdjustScoreData_0.DeltaCurrProc < 0.01) || (flag2 && actionSearchAdjustScoreData_0.DeltaGlobal < 0.01) || (flag3 && actionSearchAdjustScoreData_0.DeltaOther < 0.01)))
					{
						continue;
					}
					foreach (ActionItem actionItem in item.ActionItems)
					{
						if (actionItem.CanExport() && (!bool_4 || actionItem.ActionType != ActionType.LinkAction))
						{
							MultiFieldMatchResult multiFieldMatchResult = ovMtXLuvNls(actionItem, search, queryContext_0);
							if (multiFieldMatchResult != null && multiFieldMatchResult.Score > num)
							{
								list.Add(new ActionSearchResult(actionItem, item, actionSearchAdjustScoreData_0.g4GtYJsaroi(multiFieldMatchResult.Score, flag, flag2, flag3))
								{
									TitleMatchResult = multiFieldMatchResult.Result1,
									DescriptionMatchResult = multiFieldMatchResult.Result2
								});
							}
						}
					}
				}
			}
			if (bool_2 && CpItmVISR7P().QuickRunItems.HasData())
			{
				foreach (QuickRunItem quickRunItem in CpItmVISR7P().QuickRunItems)
				{
					if (!string.Equals(quickRunItem.CmdText, search, StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}
					_003C_003Ec__DisplayClass190_0 _003C_003Ec__DisplayClass190_ = new _003C_003Ec__DisplayClass190_0();
					_003C_003Ec__DisplayClass190_.sSYv4uKgk8l = null;
					ActionProfile profile = null;
					if (Guid.TryParse(quickRunItem.Data, out var result))
					{
						(ActionItem, ActionProfile) actionById = GetActionById(quickRunItem.Data);
						if (actionById.Item1 != null)
						{
							(_003C_003Ec__DisplayClass190_.sSYv4uKgk8l, profile) = actionById;
						}
					}
					else
					{
						(ActionItem, string) tuple2 = QHmtXwg81eY(quickRunItem.Data);
						if (tuple2.Item1 != null)
						{
							_003C_003Ec__DisplayClass190_.sSYv4uKgk8l = tuple2.Item1;
							profile = GetActionById(_003C_003Ec__DisplayClass190_.sSYv4uKgk8l.Id).profile;
						}
					}
					if (_003C_003Ec__DisplayClass190_.sSYv4uKgk8l != null)
					{
						ActionSearchResult actionSearchResult = list.FirstOrDefault(_003C_003Ec__DisplayClass190_.lbmv42gCotj);
						int score = 11000;
						if (actionSearchResult != null)
						{
							actionSearchResult.Score = score;
							actionSearchResult.IsDirectWord = true;
						}
						else
						{
							list.Add(new ActionSearchResult(_003C_003Ec__DisplayClass190_.sSYv4uKgk8l, profile, score)
							{
								IsDirectWord = true
							});
						}
					}
				}
			}
			return list.OrderByDescending(_003C_003Ec.tnivnYftC5A ?? (_003C_003Ec.tnivnYftC5A = _003C_003Ec.mElvj3e3w7y.pkMvjTtyy6G)).Take(100);
		}
		return tyXtXtQLUHP(queryContext_0, bool_2, bool_3, bool_4, bool_5);
	}

	private static MultiFieldMatchResult ovMtXLuvNls(ActionItem actionItem_0, string string_0, QueryContext queryContext_0)
	{
		if (string_0.Length == 36)
		{
			if (actionItem_0.Id == string_0)
			{
				return new MultiFieldMatchResult(1000, null, null);
			}
			if (!string.IsNullOrEmpty(actionItem_0.TemplateId) && string_0 == actionItem_0.TemplateId)
			{
				return new MultiFieldMatchResult(990, null, null);
			}
			if (!string.IsNullOrEmpty(actionItem_0.SharedActionId) && string_0 == actionItem_0.SharedActionId)
			{
				return new MultiFieldMatchResult(980, null, null);
			}
			return null;
		}
		if (string_0.StartsWith("CONTAINS:") && string_0.Length > "CONTAINS:".Length + 3)
		{
			if (string.IsNullOrEmpty(actionItem_0.Data))
			{
				int num = 0;
				if (KRg6iMQrFIxATWQ640kL != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else if (actionItem_0.Data.Contains(string_0.Substring("CONTAINS:".Length)))
			{
				return new MultiFieldMatchResult(950, null, null);
			}
		}
		return tkxn6HAKAgMT8gvXbyh.KwUidyksAU(actionItem_0.Title, 1.0, actionItem_0.Description, 0.5, false, queryContext_0);
	}

	[Obsolete("使用MatchHelper")]
	public static (int score, IList<MatchRange> matchRanges) GetMatchingScore(string value, string keyword, bool checkpinyin = false)
	{
		if (string.IsNullOrEmpty(value))
		{
			return (score: 0, matchRanges: null);
		}
		if (checkpinyin)
		{
			MatchResult matchResult = FullMatcher.Default.TryMatch(value, keyword);
			return (score: matchResult?.Score ?? 0, matchRanges: matchResult?.MatchRanges);
		}
		int num = value.IndexOf(keyword, StringComparison.OrdinalIgnoreCase);
		if (num == 0)
		{
			return (score: 300, matchRanges: new List<MatchRange>
			{
				new MatchRange(0, keyword.Length)
			});
		}
		if (num > 0)
		{
			return (score: 200, matchRanges: new List<MatchRange>
			{
				new MatchRange(num, num + keyword.Length)
			});
		}
		return (score: 0, matchRanges: null);
	}

	public (ActionItem action, ActionProfile profile) GetActionById(string actionId)
	{
		foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
		{
			foreach (ActionItem actionItem in item.ActionItems)
			{
				if (string.Equals(actionItem.Id, actionId, StringComparison.OrdinalIgnoreCase))
				{
					return (action: actionItem, profile: item);
				}
			}
		}
		return (action: null, profile: null);
	}

	internal IList<ActionItem> S0KtXvrNDeP(string string_0)
	{
		List<ActionItem> list = new List<ActionItem>();
		foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
		{
			foreach (ActionItem actionItem in item.ActionItems)
			{
				if (string.Equals(actionItem.Title, string_0, StringComparison.InvariantCulture))
				{
					list.Add(actionItem);
				}
			}
		}
		return list;
	}

	internal IList<ActionItem> d2ctXSU2gt9(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return new List<ActionItem>();
		}
		List<ActionItem> list = new List<ActionItem>();
		ActionItem actionItem = null;
		foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
		{
			foreach (ActionItem actionItem2 in item.ActionItems)
			{
				if (actionItem2.TemplateRevision >= 0)
				{
					if (string.Equals(actionItem2.TemplateId, string_0, StringComparison.InvariantCulture))
					{
						list.Add(actionItem2);
					}
					if (string.Equals(actionItem2.SharedActionId, string_0, StringComparison.Ordinal))
					{
						actionItem = actionItem2;
					}
				}
			}
		}
		if (list.Count == 0 && actionItem != null)
		{
			list.Add(actionItem);
		}
		return list;
	}

	internal TextFloatPanelState Xc6tX2mAm0N()
	{
		if (gfxtKCsAt5a == null)
		{
			gfxtKCsAt5a = Vc4tmAUDTP1.GetTextFloatPanelState() ?? new TextFloatPanelState();
		}
		return gfxtKCsAt5a;
	}

	internal void qqotXuGZfSq(TextFloatPanelState textFloatPanelState_1)
	{
		_003C_003Ec__DisplayClass199_0 _003C_003Ec__DisplayClass199_ = new _003C_003Ec__DisplayClass199_0();
		_003C_003Ec__DisplayClass199_.qfCv4J1WBvu = this;
		_003C_003Ec__DisplayClass199_.kNJv40Af7Mp = textFloatPanelState_1;
		gfxtKCsAt5a = _003C_003Ec__DisplayClass199_.kNJv40Af7Mp;
		Task.Run((Action)_003C_003Ec__DisplayClass199_.iMov4NustT0);
	}

	
	internal Task sAXtXN0S6sN(bool bool_2 = false)
	{
        var commands = Vc4tmAUDTP1.PP6trtaO3SY<List<TextCommand>>("user_textCommands") ?? new List<TextCommand>();
        AppHelper.RunOnUiThread(true, () => neZtXfcGsie().Reset(commands));
        return Task.CompletedTask;
    }

	internal IDictionary<int, PowerKey> DyhtXJ0GcZv()
	{
		return syctmxFqb6j();
	}

	[SpecialName]
	[CompilerGenerated]
	private IDictionary<int, PowerKey> syctmxFqb6j()
	{
		return VTatKE1aQk1;
	}

	internal void N78tX0QFb3C(IDictionary<int, PowerKey> idictionary_7)
	{
		JGJtXCmp26H(idictionary_7);
		Vc4tmAUDTP1.CXxtrNobmuJ(idictionary_7);
		xdNt6mQNakh(false);
	}

	private void JGJtXCmp26H(IDictionary<int, PowerKey> idictionary_7)
	{
		if (idictionary_7 == syctmxFqb6j())
		{
			return;
		}
		syctmxFqb6j().Clear();
		if (idictionary_7 == null)
		{
			return;
		}
		foreach (KeyValuePair<int, PowerKey> item in idictionary_7)
		{
			syctmxFqb6j().Add(item);
		}
	}

	internal void il2tXPiARoC()
	{
		if (neZtXfcGsie() != null)
		{
			Vc4tmAUDTP1.kfctrEcsj8x(neZtXfcGsie().ToList());
		}
		else
		{
			Vc4tmAUDTP1.kfctrEcsj8x(new List<TextCommand>());
		}
	}

	internal void EAjtXEg2I49(FloatState floatState_0)
	{
		Vc4tmAUDTP1.SaveCommonDataObjectFromLocal("float_state", floatState_0, true);
	}

	internal FloatState YDvtXy81syS()
	{
		return Vc4tmAUDTP1.PP6trtaO3SY<FloatState>("float_state");
	}

	internal void mxCtX8S7NGg()
	{
		Vc4tmAUDTP1.ddLtrPPbm0D(FnrtmLxNViE());
		xdNt6mQNakh(false);
	}

	internal void kRatXavVWw7()
	{
		Vc4tmAUDTP1.Pf5trJnWTLt(Y0Etm2L8Pto());
		xdNt6mQNakh(false);
	}

	internal void NEOtX7Edm6D()
	{
		Vc4tmAUDTP1.Cu6tr09HBtk(FavorBlocks);
		xdNt6mQNakh(false);
	}

	internal void tbAtXR5TON1()
	{
		Vc4tmAUDTP1.gBCtrCXUYyB(UserPreference);
		xdNt6mQNakh(false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal IDictionary<string, int> T3ntmpMv7Ps()
	{
		return aJctKy0GjXI;
	}

	internal bool T0DtXck0Jas(ActionItem actionItem_0)
	{
        return false; // 本地动作没有联网更新通知。
    }

	internal int cyttXVGPoZW(ActionItem actionItem_0)
	{
		if (!T3ntmpMv7Ps().TryGetValue(actionItem_0.Id, out var value))
		{
			return -1;
		}
		return value;
	}

	
	internal void BEBtXZsF9mA()
	{
        aJctKy0GjXI.Clear();
    }

	internal string udxtX9Ab5dp(string string_0)
	{
		if (ConfigurationsFromServer == null)
		{
			return null;
		}
		if (ConfigurationsFromServer.ContainsKey(string_0))
		{
			return ConfigurationsFromServer[string_0];
		}
		return null;
	}

	internal ActionAdorn QdntXhlJ6w2(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		if (oKHtK8wCbaN.TryGetValue(string_0, out var value))
		{
			return value;
		}
		return null;
	}

	internal bool EH9tXeOe7nj(string string_0)
	{
		return QdntXhlJ6w2(string_0) != null;
	}

	public string GetActionExtraContextMenu(string actionId)
	{
		if (string.IsNullOrEmpty(actionId))
		{
			return null;
		}
		if (oKHtK8wCbaN.TryGetValue(actionId, out var value))
		{
			return value.ContextMenu;
		}
		return null;
	}

	internal void bHxtXYylCek(string string_0, string string_1, string string_2)
	{
		_003C_003Ec__DisplayClass226_0 _003C_003Ec__DisplayClass226_ = new _003C_003Ec__DisplayClass226_0();
		_003C_003Ec__DisplayClass226_.RTKv4PqJB61 = string_1;
		_003C_003Ec__DisplayClass226_.FAYv4ESg0Eg = string_2;
		bvRtXWCZwNp(string_0, _003C_003Ec__DisplayClass226_.oqAv4CMRD76);
	}

	internal void UpdateActionBadge(string actionId, string badgeText, string badgeColor, string badgeTextColor)
	{
		_003C_003Ec__DisplayClass227_0 _003C_003Ec__DisplayClass227_ = new _003C_003Ec__DisplayClass227_0();
		_003C_003Ec__DisplayClass227_.m1Iv48AFBFx = badgeText;
		_003C_003Ec__DisplayClass227_.HeIv4algF3A = badgeColor;
		_003C_003Ec__DisplayClass227_.zUfv47qvYtQ = badgeTextColor;
		bvRtXWCZwNp(actionId, _003C_003Ec__DisplayClass227_.RDAv4y1cky5);
	}

	internal void GGHtXIpvHfO(string string_0, string string_1)
	{
		_003C_003Ec__DisplayClass228_0 _003C_003Ec__DisplayClass228_ = new _003C_003Ec__DisplayClass228_0();
		_003C_003Ec__DisplayClass228_.HJJv4qqxygk = string_1;
		bvRtXWCZwNp(string_0, _003C_003Ec__DisplayClass228_.LXCv4RiDgNi, false);
	}

	private void bvRtXWCZwNp(string string_0, Action<ActionAdorn> action_0, bool bool_2 = true)
	{
		oKHtK8wCbaN.TryGetValue(string_0, out var value);
		if (value == null)
		{
			value = new ActionAdorn();
		}
		action_0(value);
		if (value.IsEmpty())
		{
			if (oKHtK8wCbaN.ContainsKey(string_0))
			{
				oKHtK8wCbaN.Remove(string_0);
			}
		}
		else
		{
			oKHtK8wCbaN[string_0] = value;
		}
		ActionStateWriter.SaveActionAdorn(oKHtK8wCbaN);
		if (bool_2)
		{
			juQtmM3jwpR.NotifyActionUpdated(this, string_0);
		}
	}

	internal void h9YtXkxrfZH(string string_0)
	{
		if (oKHtK8wCbaN.ContainsKey(string_0))
		{
			oKHtK8wCbaN.Remove(string_0);
		}
		juQtmM3jwpR.NotifyActionUpdated(this, string_0);
		ActionStateWriter.SaveActionAdorn(oKHtK8wCbaN);
	}

	internal void fgstXGxbg6P(SubProgram subProgram_0)
	{
		biOtXHUANmi(subProgram_0);
		Vc4tmAUDTP1.uNftrHPi9Ww(subProgram_0);
		xdNt6mQNakh(false);
	}

	internal bool TaJtXswFMjn(string string_0)
	{
		_003C_003Ec__DisplayClass232_0 _003C_003Ec__DisplayClass232_ = new _003C_003Ec__DisplayClass232_0();
		_003C_003Ec__DisplayClass232_.MLKv4VHe9Vt = string_0;
		return GlobalSubPrograms.Any(_003C_003Ec__DisplayClass232_.vHrv4cFcPDD);
	}

	private void biOtXHUANmi(SubProgram subProgram_0)
	{
		_003C_003Ec__DisplayClass233_0 _003C_003Ec__DisplayClass233_ = new _003C_003Ec__DisplayClass233_0();
		_003C_003Ec__DisplayClass233_.f0Qv49YZwSM = subProgram_0;
		if (!GlobalSubPrograms.Contains(_003C_003Ec__DisplayClass233_.f0Qv49YZwSM))
		{
			int num = GlobalSubPrograms.IndexOf(_003C_003Ec__DisplayClass233_.T35v4ZALFfI);
			if (num >= 0)
			{
				GlobalSubPrograms[num] = _003C_003Ec__DisplayClass233_.f0Qv49YZwSM;
			}
			else
			{
				GlobalSubPrograms.Add(_003C_003Ec__DisplayClass233_.f0Qv49YZwSM);
			}
		}
	}

	internal void kittX1ycc6R(SubProgram subProgram_0)
	{
		_003C_003Ec__DisplayClass234_0 _003C_003Ec__DisplayClass234_ = new _003C_003Ec__DisplayClass234_0();
		_003C_003Ec__DisplayClass234_.vJev4eE3RVd = subProgram_0;
		if (GlobalSubPrograms.IndexOf(_003C_003Ec__DisplayClass234_.ugmv4hNpTZD) >= 0)
		{
			GlobalSubPrograms.Remove(_003C_003Ec__DisplayClass234_.vJev4eE3RVd);
		}
		Vc4tmAUDTP1.C2RtrbDCkyo(_003C_003Ec__DisplayClass234_.vJev4eE3RVd);
		xdNt6mQNakh(false);
	}

	internal (bool isExists, string objectName) JwotXbccdBP(string string_0)
	{
		foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
		{
			foreach (ActionItem actionItem in item.ActionItems)
			{
				if (actionItem.ActionType == ActionType.XAction && !string.IsNullOrEmpty(actionItem.Data) && actionItem.Data.Contains(string_0))
				{
					return (isExists: true, objectName: actionItem.Title);
				}
			}
		}
		foreach (SubProgram globalSubProgram in GlobalSubPrograms)
		{
			if (JsonConvert.SerializeObject(globalSubProgram).Contains(string_0))
			{
				return (isExists: true, objectName: globalSubProgram.Name);
			}
		}
		return (isExists: false, objectName: string.Empty);
	}

	internal (IList<ActionItem> actions, IList<SubProgram> subPrograms) qpbtX68Qs5r(string string_0)
	{
		IList<ActionItem> list = new List<ActionItem>();
		foreach (ActionProfile item in mP6tXA8VyNP().Values.ToList())
		{
			foreach (ActionItem actionItem in item.ActionItems)
			{
				if (actionItem.ActionType == ActionType.XAction && !string.IsNullOrEmpty(actionItem.Data) && actionItem.Data.Contains(string_0))
				{
					list.Add(actionItem);
				}
			}
		}
		IList<SubProgram> list2 = new List<SubProgram>();
		foreach (SubProgram globalSubProgram in GlobalSubPrograms)
		{
			if (JsonConvert.SerializeObject(globalSubProgram).Contains(string_0))
			{
				list2.Add(globalSubProgram);
			}
		}
		return (actions: list, subPrograms: list2);
	}

	internal IList<ExeInfo> Vo4tXXBRrsb(bool bool_2 = false)
	{
		IList<ExeInfo> list = new List<ExeInfo>();
		List<ExeSettings> list2 = TxrtXFmcoEV().Values.OrderBy(_003C_003Ec.yOevnHU6v49 ?? (_003C_003Ec.yOevnHU6v49 = _003C_003Ec.mElvj3e3w7y.sIWvjlveRtE)).ToList();
		if (bool_2)
		{
			list.Add(CommonExeInfo.Global);
		}
		list.Add(CommonExeInfo.Common);
		list.Add(CommonExeInfo.Taskbar);
		list.Add(CommonExeInfo.Desktop);
		IList<ExeInfo> list3 = new List<ExeInfo>();
		foreach (ExeSettings item2 in list2)
		{
			if (!CommonExeInfo.IsCommonExe(item2.Exe))
			{
				if (string.IsNullOrEmpty(item2.Name))
				{
					item2.Name = item2.Exe;
				}
				list3.Add(new ExeInfo(item2));
			}
		}
		foreach (ActionProfile item3 in mP6tXA8VyNP().Values.ToList())
		{
			if (!string.IsNullOrEmpty(item3.ExeFile) && item3.ExeFile.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				_003C_003Ec__DisplayClass237_0 _003C_003Ec__DisplayClass237_ = new _003C_003Ec__DisplayClass237_0();
				_003C_003Ec__DisplayClass237_.BWxv4IT5Qpd = item3.ExeFile.ToLower(CultureInfo.InvariantCulture);
				if (!list3.Any(_003C_003Ec__DisplayClass237_.aexv4YLp0cv))
				{
					ExeInfo item = new ExeInfo
					{
						Name = ExeHelper.GetFileDescription(item3.ExeFullpath),
						Exe = _003C_003Ec__DisplayClass237_.BWxv4IT5Qpd,
						Path = item3.ExeFullpath,
						Description = item3.ExeDisplayName,
						IconStr = ExeFileIconHelper.GetExeFileIconStr(item3.ExeFile, item3.ExeFullpath)
					};
					list3.Add(item);
				}
			}
		}
		foreach (ExeInfo item4 in list3.OrderBy(_003C_003Ec.wwCvn1iU295 ?? (_003C_003Ec.wwCvn1iU295 = _003C_003Ec.mElvj3e3w7y.tFKvji9crwn)))
		{
			list.Add(item4);
		}
		return list;
	}

	[AsyncStateMachine(typeof(_003CBackupActionManuallyAsync_003Ed__238))]
	internal Task WKAtXmLkFkM(ActionItem actionItem_0, bool bool_2, Window window_0)
	{
		_003CBackupActionManuallyAsync_003Ed__238 stateMachine = default(_003CBackupActionManuallyAsync_003Ed__238);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.action = actionItem_0;
		stateMachine.isSubProgram = bool_2;
		stateMachine.owner = window_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal void DtNtXKQWDel()
	{
		dDh7g7Xw7JyQPUTbYwJ.LocalSettings = U8GtKa8f2NC;
	}

	static DataService()
	{
		AFKtmdHLEbB = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		YlotKS5VEVl = new DateTime(2019, 7, 31);
	}

	[CompilerGenerated]
	private void RV3tXxMWj4Z(object sender, NotifyCollectionChangedEventArgs e)
	{
		rTotmtq3Nyw(v1gtKP1MaNi.Where(_003C_003Ec.Om0vnEa29ju ?? (_003C_003Ec.Om0vnEa29ju = _003C_003Ec.mElvj3e3w7y.r1TvjKjffZB)).OrderByDescending(_003C_003Ec.yH2vnyaFuHr ?? (_003C_003Ec.yH2vnyaFuHr = _003C_003Ec.mElvj3e3w7y.aSfvjxPbF7N)).ToList());
	}

	[CompilerGenerated]
	private void NTHtXrpSn7d()
	{
		BindingOperations.EnableCollectionSynchronization(GlobalSubPrograms, dOutmisFARV);
	}

	[CompilerGenerated]
	private void aJKtXpO0plN()
	{
		try
		{
			tWGtmf9CMcV = new NetworkManager();
			tWGtmf9CMcV.OnConnectivityChanged += mBxt61DNq3n;
		}
		catch (Exception ex)
		{
			AFKtmdHLEbB.Warn("绑定网络状态变更事件异常：" + ex.Message, ex);
		}
	}

	[CompilerGenerated]
	private void tjdtXBpLmZu()
	{
		Vc4tmAUDTP1.oYetrup9mBq(nYitXohYTns());
	}

	[CompilerGenerated]
	internal static bool i2HtXQLQTrg(string string_0, string string_1)
	{
		if (string.Equals(string_1, "dir", StringComparison.OrdinalIgnoreCase))
		{
			return Directory.Exists(string_0);
		}
		return string_0.EndsWith(string_1, StringComparison.OrdinalIgnoreCase);
	}

	internal static bool nF9SMKQrcRNHDMBJ3LAt()
	{
		return KRg6iMQrFIxATWQ640kL == null;
	}
}
