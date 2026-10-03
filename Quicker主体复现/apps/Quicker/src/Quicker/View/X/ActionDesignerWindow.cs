using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using aqQpqiYgxsE6yEqgoVK;
using HandyControl.Controls;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Domain.History;
using Quicker.Domain.Services;
using Quicker.Domain.SQL.Entities;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.UI;
using Quicker.View.X.Controls;
using t8SGKhhgLWTgeqjGcrq;
using ViNASxihuuLY1Gg9m6p;
using vnG2vQYciQtB4uvepMJ;

namespace Quicker.View.X;

public class ActionDesignerWindow : HandyControl.Controls.Window, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CBtnRun_OnContextMenuOpening_003Eb__165_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		public CommonOperationItem item;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object dGDMxcW7kmCyfVkWCIIR;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = actionDesignerWindow.RrfLeKkwhih(true, true, item.Data).ConfigureAwait(false).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				int num2 = 0;
				if (!HNy2bBW7ahXNJf1q3BME())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
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

		internal static bool HNy2bBW7ahXNJf1q3BME()
		{
			return dGDMxcW7kmCyfVkWCIIR == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CCbSearchOnExecuted_003Eb__83_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object lbUAuFW7NMD08AE05tps;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Delay(30).GetAwaiter();
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
					int num2 = 0;
					if (lbUAuFW7NMD08AE05tps != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				actionDesignerWindow.Dispatcher.InvokeAsync(actionDesignerWindow.PI2LYvhycF4);
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

		internal static bool iC31jIW79J3JMVXU7UnP()
		{
			return lbUAuFW7NMD08AE05tps == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CInitializeCommands_003Eb__78_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object m5Gp7VW7ukcqyYD1QbfZ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a7;
				}
				if (!actionDesignerWindow.SubProgramEditor.IsVisible)
				{
					awaiter = actionDesignerWindow.RrfLeKkwhih(true, true).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (m5Gp7VW7ukcqyYD1QbfZ != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a7;
				}
				goto end_IL_0010;
				IL_00a7:
				awaiter.GetResult();
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

		internal static bool YfBpU1W7oIwHF4cADVAl()
		{
			return m5Gp7VW7ukcqyYD1QbfZ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CInitializeCommands_003Eb__78_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object xDMdiRW7btBZy1D8D9m4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a9;
				}
				if (!actionDesignerWindow.SubProgramEditor.IsVisible)
				{
					awaiter = actionDesignerWindow.RrfLeKkwhih(false, true).ConfigureAwait(false).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						int num2 = 0;
						if (!yWHvH1W7qRtYwX5Gq8xa())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						goto IL_00a9;
					}
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto end_IL_0010;
				IL_00a9:
				awaiter.GetResult();
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

		internal static bool yWHvH1W7qRtYwX5Gq8xa()
		{
			return xDMdiRW7btBZy1D8D9m4 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CInitializeCommands_003Eb__78_2_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object agwnpDW7l4KpAUKDLFLr;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_009a;
				}
				if (!actionDesignerWindow.SubProgramEditor.IsVisible)
				{
					awaiter = actionDesignerWindow.RrfLeKkwhih(true, false).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						if (siUwodW7Z1PkDrVodf03())
						{
							switch (0)
							{
							}
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009a;
				}
				goto end_IL_000e;
				IL_009a:
				awaiter.GetResult();
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

		internal static bool siUwodW7Z1PkDrVodf03()
		{
			return agwnpDW7l4KpAUKDLFLr == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CInitializeCommands_003Eb__78_3_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object JfRk6kW7YH836UMCO0bd;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a7;
				}
				if (!actionDesignerWindow.SubProgramEditor.IsVisible)
				{
					ConfiguredTaskAwaitable configuredTaskAwaitable = actionDesignerWindow.RrfLeKkwhih(false, false).ConfigureAwait(false);
					int num2 = 0;
					if (JfRk6kW7YH836UMCO0bd != null)
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
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a7;
				}
				goto end_IL_0010;
				IL_00a7:
				awaiter.GetResult();
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

		static _003C_003CInitializeCommands_003Eb__78_3_003Ed()
		{
		}

		internal static bool eApmPZW78y90MMeheR6t()
		{
			return JfRk6kW7YH836UMCO0bd == null;
		}

		internal static void ix1ChWW7gnHYwW2HepIE()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec shESTGYWHrB;

		public static Func<ActionVariable, bool> u7mSTsGldtv;

		public static Func<SubProgramNavItem, string> xgTSTHffGXM;

		public static Func<SubProgram, string> SumST1BvoFH;

		public static Action rNISTbkjgST;

		public static Func<System.Windows.Controls.MenuItem, bool> mBqST6D6TnW;

		private static _003C_003Ec ajxB1FW7P6XRkfn0M11j;

		static _003C_003Ec()
		{
			shESTGYWHrB = new _003C_003Ec();
		}

		internal bool PVLSTeWSetj(ActionVariable x)
		{
			return x.Key != "text";
		}

		internal string CRFSTYrSc9H(SubProgramNavItem x)
		{
			return x.Name;
		}

		internal string yxPSTIdOLL2(SubProgram x)
		{
			return " - " + x.Name;
		}

		internal void HQMSTWXkdSN()
		{
			Thread.Sleep(2000);
		}

		internal bool AZkSTkZpvbJ(System.Windows.Controls.MenuItem x)
		{
			return x.Name == "MenuDebugWithContextMenuParam";
		}

		internal static void RaZa7GW7xpd1hjVA36Fw()
		{
		}

		internal static bool xLTXtLW7MiBViJVtKFAA()
		{
			return ajxB1FW7P6XRkfn0M11j == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass114_0
	{
		public SubProgram E41STmxFCc2;

		public string a5cSTKYiwYe;

		internal static _003C_003Ec__DisplayClass114_0 kI31NpW76U1rViP6W9S5;

		internal bool WehSTXgPsUQ(SubProgram x)
		{
			if (x != E41STmxFCc2)
			{
				return x.Name.Equals(a5cSTKYiwYe);
			}
			return false;
		}

		internal static bool dHIxCoW7tBHP2mfk4D07()
		{
			return kI31NpW76U1rViP6W9S5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass116_0
	{
		public string jRHSTr0DPHf;

		internal static _003C_003Ec__DisplayClass116_0 TnNtMVW7w1mSvB0iVnEZ;

		internal bool SY2STxo2nL3(SubProgram x)
		{
			return x.Name == jRHSTr0DPHf;
		}

		internal static void nu94avW7soDsgYB0DavN()
		{
		}

		internal static bool tNgWvLW7TuOWEVdsLcX6()
		{
			return TnNtMVW7w1mSvB0iVnEZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass117_0
	{
		public ActionDesignerWindow CJFSTBrju7J;

		public string eTVSTQYO2V8;

		internal static _003C_003Ec__DisplayClass117_0 nkjt3oW7CckjfMqZSfI2;

		internal void ifsSTpV5Wlc()
		{
			CJFSTBrju7J.SubProgramEditor.Focus();
			if (!eTVSTQYO2V8.IsNullOrEmpty())
			{
				CJFSTBrju7J.SubProgramEditor.TxtFilter.Text = eTVSTQYO2V8;
			}
		}

		internal static void eWi5PUW7hWOLfEnrZ2pf()
		{
		}

		internal static bool Ik0YhhW77605nDR0qk4n()
		{
			return nkjt3oW7CckjfMqZSfI2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass118_0
	{
		public SubProgram TMHSTnue4Bl;

		private static _003C_003Ec__DisplayClass118_0 NgYnoLW7zlFJy2diAxEj;

		internal bool tbhSTjK5y1m(SubProgram x)
		{
			return x.Id == TMHSTnue4Bl.Id;
		}

		internal static bool KCFbpdW4VMYpOqUsItP2()
		{
			return NgYnoLW7zlFJy2diAxEj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass119_0
	{
		public SubProgram kjKST5b5YVv;

		private static _003C_003Ec__DisplayClass119_0 bBWM0AW4FmSeLv6yrjUp;

		internal bool X5CST4LFvxX(SubProgramNavItem x)
		{
			if (x.Name == kjKST5b5YVv.Name)
			{
				return !x.IsMain;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass119_0()
		{
		}

		internal static bool a3Sj7GW4cbNHuKB69WHV()
		{
			return bBWM0AW4FmSeLv6yrjUp == null;
		}

		internal static void YRleAIW4yT53sOBZtaBv()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass132_0
	{
		public bool b2qSTobO3mj;

		public ActionDesignerWindow pasSTTdDIEp;

		public Action HXMSTMgFXIU;

		private static _003C_003Ec__DisplayClass132_0 tvX1xEW4pXIL2KU0mE4f;

		internal void d7qSTDjQn2m()
		{
			if (b2qSTobO3mj)
			{
				Thread.Sleep(800);
			}
			AppHelper.RunOnUiThread(false, HXMSTMgFXIU ?? (HXMSTMgFXIU = OjqSTdxooN2));
		}

		internal void OjqSTdxooN2()
		{
			try
			{
				if (pasSTTdDIEp.WindowState == WindowState.Minimized)
				{
					pasSTTdDIEp.WindowState = WindowState.Normal;
					pasSTTdDIEp.Show();
					pasSTTdDIEp.Activate();
				}
			}
			catch (Exception exception)
			{
				nLFLY8VGHEV.Warn("恢复窗口出错。", exception);
			}
		}

		internal static bool kSRkhNW4X3JHHtrr27O8()
		{
			return tvX1xEW4pXIL2KU0mE4f == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass134_0
	{
		public SubProgram Y32STOaWLwZ;

		internal static _003C_003Ec__DisplayClass134_0 NSyxd8W4AwJAj7nGii5p;

		internal bool MvUSTAf9ym0(SubProgram x)
		{
			return string.Equals(x.Name, Y32STOaWLwZ.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool dOSfK1W4np8k0eYg1sWP()
		{
			return NSyxd8W4AwJAj7nGii5p == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass135_0
	{
		public string FMDSTUwbZWv;

		internal static _003C_003Ec__DisplayClass135_0 Bettj5W4jjc66QDR9yEn;

		internal bool ECBSTFLMSN0(SubProgram x)
		{
			return string.Equals(FMDSTUwbZWv, x.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool NkcPoVW4Di6C3fV9MENJ()
		{
			return Bettj5W4jjc66QDR9yEn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass135_1
	{
		public string PEnSTiyUfXA;

		internal static _003C_003Ec__DisplayClass135_1 QDbDIdW4Ew44Ix6svnvx;

		internal bool ypkSTlQlmlU(SubProgram x)
		{
			return x.Name == PEnSTiyUfXA;
		}

		internal static bool mSy8QPW4Ghyoqucwfp80()
		{
			return QDbDIdW4Ew44Ix6svnvx == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass136_0
	{
		public SubProgram dM0STf1Buwb;

		private static _003C_003Ec__DisplayClass136_0 uCMNK2W41gASMouCJTEf;

		internal bool ePtST3ThOo5(SubProgram x)
		{
			return x.Name.Equals(dM0STf1Buwb.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool kL17RfW4KFoJ1fHD5hrP()
		{
			return uCMNK2W41gASMouCJTEf == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass141_0
	{
		public ActionDesignerWindow lKUSMtrDBE6;

		public string Y4ESMgGMDYW;

		public Action LFQSMLBUPXM;

		internal static _003C_003Ec__DisplayClass141_0 wTSLufW4v8Kc29WiQDb7;

		internal void ntVSTzCvrAv(object o)
		{
			Task.Run(LFQSMLBUPXM ?? (LFQSMLBUPXM = lrrSMwE0p7C));
		}

		internal void lrrSMwE0p7C()
		{
			lKUSMtrDBE6.de7LYxe05on?.Save(Y4ESMgGMDYW);
		}

		internal static bool R8qr2BW4dsSoakP4ZjR4()
		{
			return wTSLufW4v8Kc29WiQDb7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass142_0
	{
		public ActionDesignerWindow tE8SMS4gira;

		public string e9jSM25P15o;

		public string wshSMuMExcK;

		private static _003C_003Ec__DisplayClass142_0 Q72YyZW4J57Ndk01eitk;

		internal void YyWSMvmAcZI()
		{
			try
			{
				tE8SMS4gira.de7LYxe05on.Save(e9jSM25P15o, wshSMuMExcK);
			}
			catch (Exception exception)
			{
				nLFLY8VGHEV.Warn("自动备份动作出错：" + exception.GetMessageWithInner(), exception);
			}
		}

		internal static void GFNepSW4r2HSC88oLO9B()
		{
		}

		internal static bool Mj1cUcW4kw3p7kNmL7Lj()
		{
			return Q72YyZW4J57Ndk01eitk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass147_0
	{
		public SubProgram pH2SMJ0YCVL;

		private static _003C_003Ec__DisplayClass147_0 JhposrW4NoAE3yNPDBYW;

		internal bool mCTSMNdugVL(SubProgramNavItem x)
		{
			return x.Name == pH2SMJ0YCVL.Name;
		}

		internal static bool Xk5reCW496FRTom18oiH()
		{
			return JhposrW4NoAE3yNPDBYW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass150_0
	{
		public SubProgram Ab6SMCMurGf;

		private static _003C_003Ec__DisplayClass150_0 VQIMLlW4uNvodRJaGEXa;

		internal bool fp9SM0qns1T(SubProgramNavItem x)
		{
			if (!x.IsMain && x.aUHLYOSR7GK().TryGetTarget(out var target))
			{
				return target == Ab6SMCMurGf;
			}
			return false;
		}

		internal static bool GV4LCPW4oPJnUplHKv1G()
		{
			return VQIMLlW4uNvodRJaGEXa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass161_0
	{
		public int OUnSMEFurUO;

		private static _003C_003Ec__DisplayClass161_0 ODNyTtW4br0Ilrtyu6Zv;

		internal bool do8SMPVY3QC(SubProgramNavItem x, int i)
		{
			if (i > 0)
			{
				return i != OUnSMEFurUO;
			}
			return false;
		}

		internal static bool SRwVYlW4qENgq9hnUl0V()
		{
			return ODNyTtW4br0Ilrtyu6Zv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass162_0
	{
		public int yLYSM8knRLy;

		internal static _003C_003Ec__DisplayClass162_0 InlrA5W4lSqnThBEidxk;

		internal bool pqHSMyt0sZw(SubProgramNavItem x, int i)
		{
			if (i > 0)
			{
				return i < yLYSM8knRLy;
			}
			return false;
		}

		internal static bool L9TvKOW4ZwymTGW7b6Hj()
		{
			return InlrA5W4lSqnThBEidxk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass163_0
	{
		public SubProgram sp;

		public ActionDesignerWindow dVbSMRrHN13;

		internal static _003C_003Ec__DisplayClass163_0 cMorq4W4YtH1FdcDC0kb;

		internal bool dfxSMaZrwb0(SubProgram x)
		{
			return string.Equals(x.Name, sp.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal string N9BSM7VNFOj(string s)
		{
			_003C_003Ec__DisplayClass163_1 _003C_003Ec__DisplayClass163_ = new _003C_003Ec__DisplayClass163_1
			{
				lKRSMckxs8j = s
			};
			if (!dVbSMRrHN13.Action.SubPrograms.Any(_003C_003Ec__DisplayClass163_.K2aSMqpid4N))
			{
				return null;
			}
			return "此名称已存在。";
		}

		internal static bool mOY5HMW48W2CocLQMoAh()
		{
			return cMorq4W4YtH1FdcDC0kb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass163_1
	{
		public string lKRSMckxs8j;

		private static _003C_003Ec__DisplayClass163_1 fCoiREW4PHd0mLLDcAaf;

		internal bool K2aSMqpid4N(SubProgram x)
		{
			return x.Name == lKRSMckxs8j;
		}

		internal static bool P5r1saW4MAwC9v1CiONv()
		{
			return fCoiREW4PHd0mLLDcAaf == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass61_0
	{
		public string kesSMZ5GTjZ;

		private static _003C_003Ec__DisplayClass61_0 LqrJlHW4xws3p10OQht0;

		internal bool bJkSMVeiBst(ActionVariable x)
		{
			return x.Key == kesSMZ5GTjZ;
		}

		internal static bool DoCUsPW4IXpGXLYA9Cw8()
		{
			return LqrJlHW4xws3p10OQht0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_0
	{
		public SubProgram njYSMeAq6nW;

		public int YnJSMYKPuUm;

		public ActionDesignerWindow JpOSMIjRpmv;

		internal static _003C_003Ec__DisplayClass62_0 rIaExpW4tpuk8mqxNDo1;

		internal bool SBJSM9SOpyw(SubProgram x)
		{
			return string.Equals(x.Name, $"{njYSMeAq6nW.Name}_{YnJSMYKPuUm}");
		}

		internal string gilSMh0P00d(string s)
		{
			_003C_003Ec__DisplayClass62_1 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_1
			{
				AnXSMktCl4l = s
			};
			if (JpOSMIjRpmv.SubPrograms.Any(_003C_003Ec__DisplayClass62_.gK1SMWBEpVr))
			{
				return "此名称已存在!";
			}
			return null;
		}

		internal static bool rAU3pvW4SGi0BSvhX1RX()
		{
			return rIaExpW4tpuk8mqxNDo1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_1
	{
		public string AnXSMktCl4l;

		private static _003C_003Ec__DisplayClass62_1 HK2wjVW4TcjNbcwGLe3w;

		internal bool gK1SMWBEpVr(SubProgram x)
		{
			return string.Equals(x.Name, AnXSMktCl4l);
		}

		internal static bool n2Tp0SW4mQDWeZ65CnV9()
		{
			return HK2wjVW4TcjNbcwGLe3w == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_0
	{
		public string WQwSMsbI2Hp;

		private static _003C_003Ec__DisplayClass63_0 oLBrvUW4CnWQoMRCRgUN;

		internal bool ugRSMGiNsA5(SubProgram x)
		{
			return x.Name == WQwSMsbI2Hp;
		}

		internal static bool EgMOlDW47qwJUgtcoJRN()
		{
			return oLBrvUW4CnWQoMRCRgUN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass65_0
	{
		public string qpeSMbNvewE;

		public ActionDesignerWindow N51SM67Ses5;

		internal static _003C_003Ec__DisplayClass65_0 sgfr2qW4hMGL2wI5d0wp;

		internal bool PKySMHK4QgJ(SubProgram x)
		{
			return string.Equals(qpeSMbNvewE, x.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal string BspSM14QPFj(string s)
		{
			_003C_003Ec__DisplayClass65_1 _003C_003Ec__DisplayClass65_ = new _003C_003Ec__DisplayClass65_1
			{
				CFUSMm2ADP6 = s
			};
			if (N51SM67Ses5.Action.SubPrograms.Any(_003C_003Ec__DisplayClass65_.PYOSMXe83WV))
			{
				return "此名称已存在。";
			}
			return null;
		}

		internal static bool UnQ9jrW4H0R4TMSQujQp()
		{
			return sgfr2qW4hMGL2wI5d0wp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass65_1
	{
		public string CFUSMm2ADP6;

		private static _003C_003Ec__DisplayClass65_1 BvTR0YWhVekyZYDfdqbV;

		internal bool PYOSMXe83WV(SubProgram x)
		{
			return x.Name == CFUSMm2ADP6;
		}

		internal static void T8VwEcWhcPj5nCHDSJna()
		{
		}

		internal static bool ks5K3WWhQuquZNymLJai()
		{
			return BvTR0YWhVekyZYDfdqbV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass95_0
	{
		public string k6NSMxeqrGd;

		private static _003C_003Ec__DisplayClass95_0 gfsWX9WhWu75ZfY3yurP;

		internal bool R5oSMKiUMT6(SubProgram x)
		{
			return x.Name == k6NSMxeqrGd;
		}

		internal static bool wkMxNlWhyLEJf1Xsb8ip()
		{
			return gfsWX9WhWu75ZfY3yurP == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass96_0
	{
		public SubProgram faLSMpIyFwL;

		private static _003C_003Ec__DisplayClass96_0 xJCvJUWh2HHpxpORlZZO;

		internal void pH9SMrObsRh()
		{
			AppState.DataService.fgstXGxbg6P(faLSMpIyFwL);
		}

		static _003C_003Ec__DisplayClass96_0()
		{
		}

		internal static bool PLiEFmWhAKbl46TF2T4u()
		{
			return xJCvJUWh2HHpxpORlZZO == null;
		}

		internal static void TEAhD7Whe9UTqw74D15E()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CActionToolbox_OnItemDoubleClicked_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public ActionDesignerWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object wne5rHWhjXovxMtIJTn5;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0150;
				}
				if (num == 1)
				{
					goto IL_010b;
				}
				if (sender is XToolboxItem xToolboxItem)
				{
					if (actionDesignerWindow.SubProgramEditor.IsVisible)
					{
						awaiter = actionDesignerWindow.SubProgramEditor.CreateStep(xToolboxItem.Key, null, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0150;
					}
					awaiter = actionDesignerWindow.ActionStepsWrapper.CreateStep(xToolboxItem.Key, null, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						int num2 = 0;
						if (!TpsTHWWhDdwdMR0K4gkV())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						default:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 1:
							break;
						case 2:
							goto end_IL_0010;
						}
						goto IL_010b;
					}
					goto IL_0129;
				}
				goto end_IL_0010;
				IL_010b:
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0129;
				IL_0150:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_0129:
				awaiter.GetResult();
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

		internal static bool TpsTHWWhDdwdMR0K4gkV()
		{
			return wne5rHWhjXovxMtIJTn5 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNote_OnClick_003Ed__133 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object TG6iBFWhGtgXGjcToxZr;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00d5;
				}
				if (actionDesignerWindow.EditingActionItem != null)
				{
					awaiter = AppHelper.tNBLTbaIvty("/member/notes/actionnote?id=" + actionDesignerWindow.EditingActionItem.Id + "&tite=" + HttpUtility.UrlEncode(actionDesignerWindow.EditingActionItem.Title)).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (TG6iBFWhGtgXGjcToxZr != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						return;
					}
					goto IL_00d5;
				}
				AppHelper.ShowWarning("没有数据。");
				goto end_IL_0010;
				IL_00d5:
				awaiter.GetResult();
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

		internal static bool iTHx2QWh03Cn5I9s8AQI()
		{
			return TG6iBFWhGtgXGjcToxZr == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnRun_OnClick_003Ed__129 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object cqBctuWhKrwBIJYpYe1D;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (cqBctuWhKrwBIJYpYe1D != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					bool bool_ = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
					bool bool_2 = !actionDesignerWindow.zgeLem9TWWQ();
					awaiter = actionDesignerWindow.RrfLeKkwhih(bool_, bool_2).ConfigureAwait(false).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool WKRF9tWhBT0artfhVTDy()
		{
			return cqBctuWhKrwBIJYpYe1D == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnRun_OnMouseRightButtonUp_003Ed__130 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		public MouseButtonEventArgs e;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object kQvfxTWhdKlmqvgBpcmV;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_007a;
				}
				if (actionDesignerWindow.zgeLem9TWWQ())
				{
					awaiter = actionDesignerWindow.RrfLeKkwhih(true, false).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_007a;
				}
				goto end_IL_000e;
				IL_007a:
				awaiter.GetResult();
				e.Handled = true;
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

		internal static bool m9hM4LWhO5MOtlJ71Jpx()
		{
			return kQvfxTWhdKlmqvgBpcmV == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSaveVersion_OnClick_003Ed__100 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object x1B74oWhaAHgqpIw6ZwR;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0133;
				}
				int num2;
				if (actionDesignerWindow.IsReadonly)
				{
					AppHelper.ShowWarning("此动作不支持编辑。");
				}
				else
				{
					if (actionDesignerWindow.IsReadonly)
					{
						num2 = 0;
						if (x1B74oWhaAHgqpIw6ZwR != null)
						{
							goto IL_0061;
						}
						goto IL_0065;
					}
					if (actionDesignerWindow.ePnLYaPjWJ7 != null)
					{
						actionDesignerWindow.cIHLeV0myBR();
						awaiter = AppState.DataService.WKAtXmLkFkM(actionDesignerWindow.ResultActionItem, actionDesignerWindow.IsSubProgram, actionDesignerWindow).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0133;
					}
					AppHelper.ShowWarning("当前动作不支持此功能。");
				}
				goto end_IL_0010;
				IL_0133:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_0065:
				switch (num2)
				{
				default:
					AppHelper.ShowWarning("目前为只读状态，不支持保存。");
					break;
				case 1:

					break;
				}
				goto end_IL_0010;
				IL_0061:
				int num3 = default(int);
				num2 = num3;
				goto IL_0065;
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

		internal static bool c5LRRJWhre3p7T2DFyn2()
		{
			return x1B74oWhaAHgqpIw6ZwR == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSave_OnClick_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object QrKnpEWh9FbxfHP8n6nW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00f3;
				}
				int num2;
				if (actionDesignerWindow.IsReadonly)
				{
					AppHelper.ShowWarning("此动作不支持编辑。");
				}
				else
				{
					actionDesignerWindow.cIHLeV0myBR();
					if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
					{
						awaiter = actionDesignerWindow.cxeLeyXFlmr().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							num2 = 1;
							if (!IfbFEXWhLEWqPI1QkNIU())
							{
								goto IL_00a3;
							}
							goto IL_00a7;
						}
						goto IL_00f3;
					}
					actionDesignerWindow.uJZLeP2xrKU();
					if (actionDesignerWindow.CheckIfCanSave())
					{
						actionDesignerWindow.Result = true;
						num2 = 0;
						if (QrKnpEWh9FbxfHP8n6nW != null)
						{
							goto IL_00a3;
						}
						goto IL_00a7;
					}
				}
				goto end_IL_0010;
				IL_00a3:
				int num3 = default(int);
				num2 = num3;
				goto IL_00a7;
				IL_00a7:
				switch (num2)
				{
				default:
					actionDesignerWindow.q3JLe8OmW7q();
					break;
				case 1:
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto end_IL_0010;
				IL_00f3:
				awaiter.GetResult();
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

		internal static bool IfbFEXWhLEWqPI1QkNIU()
		{
			return QrKnpEWh9FbxfHP8n6nW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCbSaveOnExecuted_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object R4g7gNWhoC6B1AuG4QZR;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00bf;
				}
				int num2;
				if (!actionDesignerWindow.IsReadonly)
				{
					if (actionDesignerWindow.EditingActionItem != null)
					{
						if (actionDesignerWindow.SubProgramEditor.IsVisible)
						{
							actionDesignerWindow.SEPLeGWGYNb();
						}
						actionDesignerWindow.cIHLeV0myBR();
						awaiter = actionDesignerWindow.cxeLeyXFlmr().GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_00bf;
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 1;
						if (R4g7gNWhoC6B1AuG4QZR != null)
						{
							goto IL_00d4;
						}
						goto IL_00d8;
					}
					AppHelper.ShowWarning("新动作不支持快速保存。");
				}
				goto end_IL_0010;
				IL_00d8:
				switch (num2)
				{
				case 1:
					return;
				}
				goto end_IL_0010;
				IL_00bf:
				awaiter.GetResult();
				num2 = 0;
				if (R4g7gNWhoC6B1AuG4QZR != null)
				{
					goto IL_00d4;
				}
				goto IL_00d8;
				IL_00d4:
				int num3 = default(int);
				num2 = num3;
				goto IL_00d8;
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

		static _003CCbSaveOnExecuted_003Ed__84()
		{
		}

		internal static bool SvNky7WhflW3871V1JpE()
		{
			return R4g7gNWhoC6B1AuG4QZR == null;
		}

		internal static void owJPyoWhqUcGp9uoE9mM()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConvertGlobalSpToLocalSpAsync_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		public string globalSpId;

		private _003C_003Ec__DisplayClass65_0 _003C_003E8__1;

		private SubProgram _003CspClone_003E5__2;

		private TaskAwaiter<(bool isSuccess, string text)> _003C_003Eu__1;

		internal static object E5J3NvWhi5LKul3UDcfn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
        int num2 = default;
				if (num == 0)
				{
					goto IL_0158;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass65_0();
				_003C_003E8__1.N51SM67Ses5 = _003C_003E4__this;
				SubProgram globalSubProgram = AppState.DataService.GetGlobalSubProgram(globalSpId);
				TaskAwaiter<(bool, string)> awaiter;
				if (globalSubProgram == null)
				{
					AppHelper.ShowWarning("无法找到公共子程序" + globalSpId);
				}
				else if (AppHelper.Confirm("您确认要转换么？转换可能出现意外，请确认已做好动作备份。"))
				{
					_003CspClone_003E5__2 = AppHelper.Clone(globalSubProgram);
					_003C_003E8__1.qpeSMbNvewE = _003CspClone_003E5__2.Name;
					if (actionDesignerWindow.SubPrograms.Any(_003C_003E8__1.PKySMHK4QgJ))
					{
						awaiter = AppHelper.KPBLTUrDvVc(System.Windows.Window.GetWindow(actionDesignerWindow), "转换为动作内子程序", "请输入新的子程序名称", true, _003C_003E8__1.qpeSMbNvewE, "", _003C_003E8__1.BspSM14QPFj).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_012b;
					}
					goto IL_0198;
				}
				goto end_IL_0010;
				IL_0198:
				_003CspClone_003E5__2.Name = _003C_003E8__1.qpeSMbNvewE;
				_003CspClone_003E5__2.Id = Guid.NewGuid().ToString();
				num2 = 2;
				goto IL_01d6;
				IL_0158:
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_012b;
				IL_0178:
				(bool, string) result;
				if (result.Item1)
				{
					_003C_003E8__1.qpeSMbNvewE = result.Item2;
					goto IL_0198;
				}
				goto end_IL_0010;
				IL_01d6:
				actionDesignerWindow.SubPrograms.Add(_003CspClone_003E5__2);
				actionDesignerWindow.wc8LhAqM9ij("%%" + globalSpId, _003C_003E8__1.qpeSMbNvewE);
				goto end_IL_0010;
				IL_012b:
				result = awaiter.GetResult();
				int num3 = 0;
				if (!tkda1mWhlFpL1i04Uo2q())
				{
					num3 = num2;
				}
				switch (num3)
				{
				case 1:
					break;
				default:
					goto IL_0178;
				case 2:
					goto IL_01d6;
				}
				goto IL_0158;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003CspClone_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003CspClone_003E5__2 = null;
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

		internal static bool tkda1mWhlFpL1i04Uo2q()
		{
			return E5J3NvWhi5LKul3UDcfn == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConvertNetworkSharedSubprogramToInternalSp_003Ed__135 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string spIdentifier;

		public ActionDesignerWindow _003C_003E4__this;

		private _003C_003Ec__DisplayClass135_0 _003C_003E8__1;

		private SubProgram _003CspClone_003E5__2;

		private TaskAwaiter<(bool isSuccess, string text)> _003C_003Eu__1;

		internal static object XR6cZmWhYsJ9e24aI9X8;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
        (string, string, string) tuple = default;
				if (num == 0)
				{
					goto IL_0073;
				}
				int num2 = 0;
				if (!cJYe5iWh8UyaM4JwIWgf())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				tuple = default((string, string, string));
				if (!spIdentifier.StartsWith("@@"))
				{
					AppHelper.ShowWarning("不是一个网络共享子程序。");
				}
				else if (AppHelper.Confirm("您确认要转换么？\r\n可能存在转换失败的情况，请先备份好动作。"))
				{
					tuple = SubProgramHelper.ExtractNetworkShareSpInfo(spIdentifier);
					goto IL_0073;
				}
				goto end_IL_0010;
				IL_0073:
				try
				{
					if (num != 0)
					{
						goto IL_00b1;
					}
					TaskAwaiter<(bool, string)> awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01d4;
					IL_01ef:
					actionDesignerWindow.SubPrograms.Add(_003CspClone_003E5__2);
					actionDesignerWindow.wc8LhAqM9ij(spIdentifier, _003C_003E8__1.FMDSTUwbZWv);
					_003C_003E8__1 = null;
					_003CspClone_003E5__2 = null;
					goto end_IL_0073;
					IL_01d4:
					(bool, string) result = awaiter.GetResult();
					if (result.Item1)
					{
						_003C_003E8__1.FMDSTUwbZWv = result.Item2;
						goto IL_0191;
					}
					goto end_IL_0073;
					IL_00b1:
					_003C_003E8__1 = new _003C_003Ec__DisplayClass135_0();
					SubProgram sharedSubProgram = AppState.DataService.GetSharedSubProgram(tuple.Item1, tuple.Item2);
					int num4;
					if (sharedSubProgram != null)
					{
						_003CspClone_003E5__2 = AppHelper.Clone(sharedSubProgram);
						_003C_003E8__1.FMDSTUwbZWv = _003CspClone_003E5__2.Name;
						if (!actionDesignerWindow.SubPrograms.Any(_003C_003E8__1.ECBSTFLMSN0))
						{
							goto IL_0191;
						}
						awaiter = AppHelper.KPBLTUrDvVc(System.Windows.Window.GetWindow(actionDesignerWindow), "转换为动作内子程序", "请输入新的子程序名称", true, _003C_003E8__1.FMDSTUwbZWv, "", actionDesignerWindow.akPLYu6XMOu).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							num4 = 1;
							if (XR6cZmWhYsJ9e24aI9X8 != null)
							{
								int num5 = default(int);
								num4 = num5;
							}
							goto IL_017e;
						}
						goto IL_01d4;
					}
					AppHelper.ShowWarning("获得的子程序为空！");
					goto end_IL_0073;
					IL_0191:
					_003CspClone_003E5__2.Name = _003C_003E8__1.FMDSTUwbZWv;
					_003CspClone_003E5__2.Id = Guid.NewGuid().ToString();
					num4 = 0;
					if (XR6cZmWhYsJ9e24aI9X8 != null)
					{
						goto IL_017e;
					}
					goto IL_01ef;
					IL_017e:
					switch (num4)
					{
					case 2:
						break;
					default:
						goto IL_01ef;
					case 1:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00b1;
					end_IL_0073:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("转换子程序出错！" + ex.Message, true);
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

		internal static bool cJYe5iWh8UyaM4JwIWgf()
		{
			return XR6cZmWhYsJ9e24aI9X8 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoSaveWithoutClose_003Ed__96 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object u0BLaxWhPnyaRaILKBYb;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			bool result;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_022f;
				}
				if (actionDesignerWindow.IsSubProgram)
				{
					_003C_003Ec__DisplayClass96_0 _003C_003Ec__DisplayClass96_ = new _003C_003Ec__DisplayClass96_0();
					int num2 = 2;
					if (!geuo9xWhMCLByFpp4A8q())
					{
						int num3 = default(int);
						num2 = num3;
					}
					while (true)
					{
						int num3;
						switch (num2)
						{
						case 2:
							if (!actionDesignerWindow.ResultActionItem.Id.IsNullOrEmpty())
							{
								num2 = 0;
								if (u0BLaxWhPnyaRaILKBYb != null)
								{
									continue;
								}
								goto default;
							}
							goto IL_0199;
						default:
							if (!(Guid.Parse(actionDesignerWindow.ResultActionItem.Id) == Guid.Empty))
							{
								goto case 1;
							}
							goto IL_0199;
						case 1:
						{
							ActionItem actionItem = AppHelper.Clone(actionDesignerWindow.ResultActionItem);
							actionItem.LastEditTimeUtc = AppHelper.GetUtcNowForDb();
							actionDesignerWindow.ePnLYaPjWJ7.BackupAction(actionItem, ActionBackupType.EditComplete);
							_003C_003Ec__DisplayClass96_.faLSMpIyFwL = SubProgramHelper.GetGlobalSubProgramFromWrapperAction(actionItem);
							if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass96_.faLSMpIyFwL.Id) || Guid.Parse(_003C_003Ec__DisplayClass96_.faLSMpIyFwL.Id) == Guid.Empty)
							{
								_003C_003Ec__DisplayClass96_.faLSMpIyFwL.Id = Guid.NewGuid().ToString();
							}
							actionItem.Id = _003C_003Ec__DisplayClass96_.faLSMpIyFwL.Id;
							awaiter = Task.Run((Action)_003C_003Ec__DisplayClass96_.pH9SMrObsRh).ConfigureAwait(true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						case 3:
							{
								result = true;
								goto end_IL_005f;
							}
							IL_0199:
							AppHelper.ShowWarning("不支持此操作。");
							num3 = 3;
							goto case 3;
						}
						goto IL_022f;
						continue;
						end_IL_005f:
						break;
					}
				}
				else
				{
					ActionItem actionItem2 = AppHelper.Clone(actionDesignerWindow.ResultActionItem);
					actionItem2.LastEditTimeUtc = AppHelper.GetUtcNowForDb();
					AppState.lWutartRfUY()?.SaveEditingAction(actionItem2);
					actionDesignerWindow.ePnLYaPjWJ7.BackupAction(actionItem2, ActionBackupType.EditComplete);
					actionDesignerWindow.S7GLYIqkvCu = false;
					result = false;
				}
				goto end_IL_0010;
				IL_022f:
				awaiter.GetResult();
				AppHelper.ShowSuccess("已保存公共子程序。");
				result = true;
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

		static _003CDoSaveWithoutClose_003Ed__96()
		{
		}

		internal static bool geuo9xWhMCLByFpp4A8q()
		{
			return u0BLaxWhPnyaRaILKBYb == null;
		}

		internal static void CdlOOrWhILYq9NV6qLDG()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateInternalSubProgramAsync_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SubProgram subProgram;

		public ActionDesignerWindow _003C_003E4__this;

		private _003C_003Ec__DisplayClass62_0 _003C_003E8__1;

		private TaskAwaiter<(bool isSuccess, string text)> _003C_003Eu__1;

		private static object EJFNoLWh6dasiqG9f9Xa;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<(bool, string)> awaiter;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass62_0();
					_003C_003E8__1.njYSMeAq6nW = this.subProgram;
					int num2 = 0;
					if (EJFNoLWh6dasiqG9f9Xa != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
						_003C_003E8__1.JpOSMIjRpmv = _003C_003E4__this;
						_003C_003E8__1.YnJSMYKPuUm = 1;
						goto IL_006e;
					case 1:
						{
							int num4 = _003C_003E8__1.YnJSMYKPuUm;
							_003C_003E8__1.YnJSMYKPuUm = num4 + 1;
							goto IL_006e;
						}
						IL_006e:
						if (!actionDesignerWindow.SubPrograms.Any(_003C_003E8__1.SBJSM9SOpyw))
						{
							break;
						}
						goto case 1;
					}
					string string_ = $"{_003C_003E8__1.njYSMeAq6nW.Name}_{_003C_003E8__1.YnJSMYKPuUm}";
					awaiter = AppHelper.KPBLTUrDvVc(System.Windows.Window.GetWindow(actionDesignerWindow), "创建子程序副本", "请输入副本子程序的名称：", true, string_, string.Empty, _003C_003E8__1.gilSMh0P00d).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num = -1;
					_003C_003E1__state = -1;
				}
				(bool, string) result = awaiter.GetResult();
				if (result.Item1)
				{
					string string_ = result.Item2;
					SubProgram subProgram = AppHelper.Clone(_003C_003E8__1.njYSMeAq6nW);
					subProgram.Name = string_;
					subProgram.Id = Guid.NewGuid().ToString();
					actionDesignerWindow.SubPrograms.Add(subProgram);
				}
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

		internal static bool cPR45GWht36pMasQPyEv()
		{
			return EJFNoLWh6dasiqG9f9Xa == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CImportSharedSubProgramAsync_003Ed__134 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid id;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object YNUwMsWhwDmPUYCqkgul;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.duVtb7RQXW3(id, null).ConfigureAwait(true).GetAwaiter();
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
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<SharedActionDto> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						int num2 = 2;
						while (true)
						{
							IL_01e1:
							_003C_003Ec__DisplayClass134_0 _003C_003Ec__DisplayClass134_ = new _003C_003Ec__DisplayClass134_0
							{
								Y32STOaWLwZ = JsonConvert.DeserializeObject<SubProgram>(result.Data.Data)
							};
							int num3;
							if (_003C_003Ec__DisplayClass134_.Y32STOaWLwZ != null && (_003C_003Ec__DisplayClass134_.Y32STOaWLwZ.Steps.HasData() || _003C_003Ec__DisplayClass134_.Y32STOaWLwZ.Variables.HasData()))
							{
								_003C_003Ec__DisplayClass134_.Y32STOaWLwZ.Name = result.Data.Title;
								_003C_003Ec__DisplayClass134_.Y32STOaWLwZ.Description = result.Data.Description;
								_003C_003Ec__DisplayClass134_.Y32STOaWLwZ.TemplateId = result.Data.Id.ToString();
								_003C_003Ec__DisplayClass134_.Y32STOaWLwZ.TemplateRevision = result.Data.Revision;
								_003C_003Ec__DisplayClass134_.Y32STOaWLwZ.CreateTimeUtc = DateTime.UtcNow;
								if (!actionDesignerWindow.SubPrograms.Any(_003C_003Ec__DisplayClass134_.MvUSTAf9ym0))
								{
									_003C_003Ec__DisplayClass134_.Y32STOaWLwZ.Id = Guid.NewGuid().ToString();
									actionDesignerWindow.SubPrograms.Add(_003C_003Ec__DisplayClass134_.Y32STOaWLwZ);
									num3 = 0;
									if (YNUwMsWhwDmPUYCqkgul != null)
									{
										goto IL_01ca;
									}
									goto IL_01ce;
								}
								AppHelper.ShowWarning("子程序 " + _003C_003Ec__DisplayClass134_.Y32STOaWLwZ.Name + " 已存在，不能导入或创建重名的子程序。");
								break;
							}
							AppHelper.ShowWarning("子程序内容为空！");
							break;
							IL_01ce:
							while (true)
							{
								switch (num3)
								{
								default:
									goto IL_01b3;
								case 2:
									break;
								case 1:
									actionDesignerWindow.ToolTab.SelectedIndex = 1;
									goto end_IL_01ce;
								}
								goto IL_01e1;
								IL_01b3:
								AppHelper.ShowSuccess("导入成功！");
								num3 = 1;
								if (eFcv2TWhTHsg3cBftnve())
								{
									continue;
								}
								goto IL_01ca;
								continue;
								end_IL_01ce:
								break;
							}
							break;
							IL_01ca:
							num3 = num2;
							goto IL_01ce;
						}
					}
					else
					{
						AppHelper.ShowWarning("下载子程序失败。" + result.Message);
					}
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("下载子程序失败。" + exception.GetMessageWithInner());
					AppHelper.TryOpenUrlOrFile("https://getquicker.net/Share/SubPrograms");
				}
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

		static _003CImportSharedSubProgramAsync_003Ed__134()
		{
		}

		internal static bool eFcv2TWhTHsg3cBftnve()
		{
			return YNUwMsWhwDmPUYCqkgul == null;
		}

		internal static void jtwdyMWhsl2eJ5c85473()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuDebugWithParam_OnClick_003Ed__157 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object KZJsQKWhCrI8PEYPABaW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00ef;
				}
				UserInputWindow userInputWindow = new UserInputWindow("multiline", "输入动作参数", "", actionDesignerWindow.BHVLYB8v2Em)
				{
					IsRequired = true,
					Owner = actionDesignerWindow
				};
				int num2;
				if (userInputWindow.ShowDialog() == true)
				{
					num2 = 0;
					if (KZJsQKWhCrI8PEYPABaW != null)
					{
						goto IL_0075;
					}
					goto IL_00ab;
				}
				goto end_IL_000e;
				IL_00ef:
				awaiter.GetResult();
				goto end_IL_000e;
				IL_0075:
				while (true)
				{
					actionDesignerWindow.BHVLYB8v2Em = userInputWindow.TextValue;
					awaiter = actionDesignerWindow.RrfLeKkwhih(true, true, actionDesignerWindow.BHVLYB8v2Em).ConfigureAwait(false).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						break;
					}
					num = 0;
					_003C_003E1__state = 0;
					num2 = 1;
					if (KZJsQKWhCrI8PEYPABaW != null)
					{
						continue;
					}
					goto IL_00ab;
				}
				goto IL_00ef;
				IL_00ab:
				switch (num2)
				{
				case 1:
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0075;
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

		static _003CMenuDebugWithParam_OnClick_003Ed__157()
		{
		}

		internal static bool AOL8PnWh7ICGCTsNiFGy()
		{
			return KZJsQKWhCrI8PEYPABaW == null;
		}

		internal static void OVQLtIWhHgfe1k61ZRQO()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuDebug_OnClick_003Ed__155 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object WafZ78WhzZNjJGbXDnyj;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					bool bool_ = !actionDesignerWindow.zgeLem9TWWQ();
					awaiter = actionDesignerWindow.RrfLeKkwhih(true, bool_).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (!jafkCJWHVEdrpvyP8I8e())
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
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool jafkCJWHVEdrpvyP8I8e()
		{
			return WafZ78WhzZNjJGbXDnyj == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuRunWithParam_OnClick_003Ed__158 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object xmYCcNWHFFsWGq9uoAmS;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
        ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
				int num2;
				if (num != 0)
				{
					num2 = 1;
					if (!uKbIrBWHcthu8Hd2EOo9())
					{
						goto IL_00be;
					}
					goto IL_00c2;
				}
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0105;
				IL_0105:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_00c2:
				while (true)
				{
					switch (num2)
					{
					case 1:
						break;
					default:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					UserInputWindow userInputWindow = new UserInputWindow("multiline", "输入动作参数", "", actionDesignerWindow.BHVLYB8v2Em)
					{
						IsRequired = true,
						Owner = actionDesignerWindow
					};
					if (userInputWindow.ShowDialog() != true)
					{
						break;
					}
					actionDesignerWindow.BHVLYB8v2Em = userInputWindow.TextValue;
					awaiter = actionDesignerWindow.RrfLeKkwhih(false, true, actionDesignerWindow.BHVLYB8v2Em).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						num2 = 0;
						if (uKbIrBWHcthu8Hd2EOo9())
						{
							continue;
						}
						goto IL_00be;
					}
					goto IL_0105;
				}
				goto end_IL_0010;
				IL_00be:
				int num3 = default(int);
				num2 = num3;
				goto IL_00c2;
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

		internal static bool uKbIrBWHcthu8Hd2EOo9()
		{
			return xmYCcNWHFFsWGq9uoAmS == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnClosing_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionDesignerWindow _003C_003E4__this;

		public CancelEventArgs e;

		internal static object D4W0wqWHy5I8wyPTcmcE;

		private void MoveNext()
		{
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				bool? result;
				int num;
				if (!actionDesignerWindow.IsReadonly)
				{
					Keyboard.ClearFocus();
					result = actionDesignerWindow.Result;
					num = 0;
					if (!uK2IbPWHpVwhmaw413TL())
					{
						goto IL_0077;
					}
					goto IL_007b;
				}
				goto end_IL_0008;
				IL_007b:
				while (true)
				{
					switch (num)
					{
					default:
						if (result.HasValue || actionDesignerWindow.IsReadonly)
						{
							break;
						}
						goto IL_004b;
					case 1:
						if (actionDesignerWindow.ShouldShowCloseConfirm())
						{
							string title = actionDesignerWindow.ResultActionItem.Title;
							switch (ConfirmDialog.lVeL0kxeWvI(actionDesignerWindow, "Quicker", "", "是否保存对动作 “" + title + "” 的更改？", "Question", "[fa:Regular_Check:#48ff00]保存(_Y)|Yes\r\n[fa:Regular_Times:#dc3545]不保存(_N)|No\r\n取消(_C)|Cancel", "Yes").button)
							{
							default:
								e.Cancel = true;
								break;
							case "Yes":
								actionDesignerWindow.Result = true;
								break;
							case "Cancel":
								e.Cancel = true;
								break;
							case "No":
								break;
							}
						}
						break;
					}
					break;
					IL_004b:
					actionDesignerWindow.cIHLeV0myBR();
					actionDesignerWindow.nwKLeBwDMKD(actionDesignerWindow.ResultActionItem.Data, "BeforeClosing");
					num = 1;
					if (uK2IbPWHpVwhmaw413TL())
					{
						continue;
					}
					goto IL_0077;
				}
				goto end_IL_0008;
				IL_0077:
				int num2 = default(int);
				num = num2;
				goto IL_007b;
				end_IL_0008:;
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

		internal static bool uK2IbPWHpVwhmaw413TL()
		{
			return D4W0wqWHy5I8wyPTcmcE == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPasteSubProgramAsync_003Ed__163 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SubProgram sp;

		public ActionDesignerWindow _003C_003E4__this;

		private _003C_003Ec__DisplayClass163_0 _003C_003E8__1;

		private TaskAwaiter<(bool isSuccess, string text)> _003C_003Eu__1;

		internal static object q9pfEnWH2tqP4GhMmATs;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<(bool, string)> awaiter;
				int num2;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass163_0();
					_003C_003E8__1.sp = sp;
					_003C_003E8__1.dVbSMRrHN13 = _003C_003E4__this;
					if (!actionDesignerWindow.SubPrograms.Any(_003C_003E8__1.dfxSMaZrwb0))
					{
						goto IL_0172;
					}
					awaiter = AppHelper.KPBLTUrDvVc(System.Windows.Window.GetWindow(actionDesignerWindow), "粘贴子程序", "同名子程序已存在，请输入新名称", true, _003C_003E8__1.sp.Name, "", _003C_003E8__1.N9BSM7VNFOj).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_0123;
					}
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					num2 = 0;
					if (q9pfEnWH2tqP4GhMmATs != null)
					{
						goto IL_0106;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num2 = 1;
					if (!c2AI5eWHAJKYDHhJW9i7())
					{
						int num3 = default(int);
						num2 = num3;
					}
				}
				switch (num2)
				{
				case 1:
					goto IL_0119;
				}
				goto IL_0106;
				IL_0119:
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0123;
				IL_0172:
				actionDesignerWindow.SubPrograms.Add(_003C_003E8__1.sp);
				goto end_IL_0010;
				IL_0106:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				IL_0123:
				(bool, string) result = awaiter.GetResult();
				if (result.Item1)
				{
					_003C_003E8__1.sp.Name = result.Item2;
					_003C_003E8__1.sp.Id = Guid.NewGuid().ToString();
					goto IL_0172;
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

		internal static bool c2AI5eWHAJKYDHhJW9i7()
		{
			return q9pfEnWH2tqP4GhMmATs == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRenameInternalSubProgramAsync_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SubProgram subProgram;

		public ActionDesignerWindow _003C_003E4__this;

		private string _003ColdName_003E5__2;

		private TaskAwaiter<(bool isSuccess, string text)> _003C_003Eu__1;

		internal static object qhtmVuWHeEjfvvSXGl2m;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
        (bool, string) result = default;
				TaskAwaiter<(bool, string)> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00bc;
				}
				_003ColdName_003E5__2 = subProgram.Name;
				int num2;
				if (AppHelper.Confirm("可能无法替换到所有位置，您确认继续么？\r\n建议先备份动作当前版本。"))
				{
					awaiter = AppHelper.KPBLTUrDvVc(System.Windows.Window.GetWindow(actionDesignerWindow), "重命名子程序", "请输入新名称", true, subProgram.Name, "", actionDesignerWindow.B7lLe3OAAaD).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_00bc;
					}
					num = 0;
					_003C_003E1__state = 0;
					num2 = 1;
					if (!jowgDCWHjLYeE9E62kOT())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_00d4;
				}
				goto end_IL_0010;
				IL_00d4:
				switch (num2)
				{
				case 1:
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00e1;
				IL_00bc:
				result = awaiter.GetResult();
				num2 = 0;
				if (qhtmVuWHeEjfvvSXGl2m == null)
				{
					goto IL_00d4;
				}
				goto IL_00e1;
				IL_00e1:
				if (result.Item1)
				{
					string item = result.Item2;
					subProgram.Name = item;
					actionDesignerWindow.SubPrograms[actionDesignerWindow.SubPrograms.IndexOf(subProgram)] = subProgram;
					try
					{
						actionDesignerWindow.wc8LhAqM9ij(_003ColdName_003E5__2, item);
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("出错了：" + ex.Message);
					}
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003ColdName_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003ColdName_003E5__2 = null;
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

		internal static bool jowgDCWHjLYeE9E62kOT()
		{
			return qhtmVuWHeEjfvvSXGl2m == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunAction_003Ed__132 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool minimize;

		public ActionDesignerWindow _003C_003E4__this;

		public bool debug;

		public string inputParam;

		private _003C_003Ec__DisplayClass132_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object jUQanuWHEEIpU02m5VTT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionDesignerWindow actionDesignerWindow = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 0;
					if (CSoPg0WHGeXgJdr6io7J())
					{
						goto IL_0049;
					}
					goto IL_00fe;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_014d;
				IL_00af:
				AppState.AppServer.ExecuteAction(actionDesignerWindow.ResultActionItem, -1, null, debug, false, false, inputParam, ActionTrigger.ActionEditor, _003C_003E8__1.d7qSTDjQn2m);
				num2 = 1;
				if (CSoPg0WHGeXgJdr6io7J())
				{
					goto IL_0049;
				}
				goto IL_00fe;
				IL_014d:
				awaiter.GetResult();
				goto IL_00af;
				IL_00fe:
				int num3 = default(int);
				num2 = num3;
				goto IL_0049;
				IL_0049:
				switch (num2)
				{
				case 1:
					goto end_IL_0010;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass132_0();
				_003C_003E8__1.b2qSTobO3mj = minimize;
				_003C_003E8__1.pasSTTdDIEp = _003C_003E4__this;
				actionDesignerWindow.cIHLeV0myBR();
				actionDesignerWindow.nwKLeBwDMKD(actionDesignerWindow.ResultActionItem.Data, "BeforeRun");
				if (!_003C_003E8__1.b2qSTobO3mj)
				{
					goto IL_00af;
				}
				actionDesignerWindow.WindowState = WindowState.Minimized;
				awaiter = Task.Run(_003C_003Ec.rNISTbkjgST ?? (_003C_003Ec.rNISTbkjgST = _003C_003Ec.shESTGYWHrB.HQMSTWXkdSN)).ConfigureAwait(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_014d;
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

		internal static bool CSoPg0WHGeXgJdr6io7J()
		{
			return jUQanuWHEEIpU02m5VTT == null;
		}
	}

	private static readonly ILog nLFLY8VGHEV;

	private readonly SQLDataMgr ePnLYaPjWJ7;

	public static readonly DependencyProperty ActionProperty;

	[CompilerGenerated]
	private IToolBoxControl jfeLY74pto3;

	[CompilerGenerated]
	private readonly SmartCollection<SubProgram> CraLYRhmlxo = new SmartCollection<SubProgram>();

	[CompilerGenerated]
	private readonly SmartCollection<ActionVariable> dQ1LYqgRAHs = new SmartCollection<ActionVariable>();

	[CompilerGenerated]
	private readonly ActionItem o2qLYc50KHt;

	[CompilerGenerated]
	private readonly bool N45LYV3jeFK;

	[CompilerGenerated]
	private ActionItem PPQLYZB9DKH;

	private readonly HistoryManager fYLLY9kFyMc = new HistoryManager();

	[CompilerGenerated]
	private bool CWXLYhfVtwI;

	[CompilerGenerated]
	private bool? SGyLYeq4ke0;

	private bool W6ZLYYaqsg5;

	private bool S7GLYIqkvCu;

	private string mPXLYW3Owwj;

	[CompilerGenerated]
	private EditActionParam upqLYk3GB0s;

	[CompilerGenerated]
	private ActionUserLimitation X01LYGvYavM;

	private readonly DebounceDispatcher etrLYsPDIo5 = new DebounceDispatcher();

	private readonly RoutedCommand lFOLYHTNDsY = new RoutedCommand("Undo", typeof(ActionDesignerWindow));

	private readonly RoutedCommand il3LY1ZOJgo = new RoutedCommand("Redo", typeof(ActionDesignerWindow));

	private readonly RoutedCommand pMMLYbNxdp7 = new RoutedCommand("Save", typeof(ActionDesignerWindow));

	private readonly RoutedCommand IWpLY6ChQGA = new RoutedCommand("Search", typeof(ActionDesignerWindow));

	private readonly RoutedCommand iKQLYXTAhis = new RoutedCommand("CloseTab", typeof(ActionDesignerWindow));

	private DebounceTimer rvmLYmTyAZG = new DebounceTimer();

	private DebounceDispatcher wyuLYKjCpLB = new DebounceDispatcher();

	private ActionAutoBackup de7LYxe05on;

	[CompilerGenerated]
	private readonly SmartCollection<SubProgramNavItem> TjILYrsRh5t = new SmartCollection<SubProgramNavItem>
	{
		new SubProgramNavItem
		{
			IsMain = true,
			Name = "主程序",
			Key = "Main",
			Icon = "fa:Solid_Home:##6495ed",
			Description = "动作的主程序步骤"
		}
	};

	private bool HZnLYp34bkM;

	private string BHVLYB8v2Em = "";

	internal ActionDesignerWindow DesignerWindow;

	internal System.Windows.Controls.TabControl ToolTab;

	internal ContentControl ToolContent;

	internal InternalSubProgramListControl InternalSubProgramListControl;

	internal GlobalSubProgramListControl GlobalSubProgramsList;

	internal System.Windows.Controls.ListBox LbSubProgramNav;

	internal Grid GridMain;

	internal System.Windows.Controls.TextBox TxtFilter;

	internal System.Windows.Controls.Button BtnExpandByHightlight;

	internal System.Windows.Controls.Button BtnRun;

	internal System.Windows.Controls.MenuItem MenuDebug;

	internal System.Windows.Controls.MenuItem MenuDebugWithParam;

	internal System.Windows.Controls.MenuItem MenuDebugWithContextMenuParam;

	internal System.Windows.Controls.MenuItem MenuRunWithParam;

	internal System.Windows.Controls.Button BtnUndo;

	internal System.Windows.Controls.Button BtnRedo;

	internal System.Windows.Controls.Button BtnSaveVersion;

	internal System.Windows.Controls.Button BtnLoadHistoryVersion;

	internal System.Windows.Controls.Button BtnNote;

	internal DropDownButton BtnMenu;

	internal System.Windows.Controls.ContextMenu MainContextMenu1;

	internal System.Windows.Controls.MenuItem MenuExport;

	internal System.Windows.Controls.MenuItem MenuImport;

	internal System.Windows.Controls.MenuItem MenuClearAction;

	internal System.Windows.Controls.MenuItem MenuFloatAction;

	internal System.Windows.Controls.MenuItem MenuExpandAll;

	internal System.Windows.Controls.MenuItem MenuCollapseAll;

	internal ActionStepsWrapper ActionStepsWrapper;

	internal VariableListControl VariableListControl;

	internal ActionUIEditor UiEditor;

	internal System.Windows.Controls.TabItem TabOptions;

	internal ActionOptionsControl ActionOptionsEditor;

	internal System.Windows.Controls.TabItem TabAssociations;

	internal ActionAssociationControl ActionAssociationsEditor;

	internal System.Windows.Controls.TabItem TabSubProgram;

	internal TextBoxWithToolsControl TxtSummaryExpression;

	internal System.Windows.Controls.Button BtnSave;

	internal System.Windows.Controls.Button BtnCancel;

	internal SubProgramEditor SubProgramEditor;

	private bool ncALYQImwZ6;

	private static ActionDesignerWindow KApZprFO3YcWUGFN2FTE;

	public IToolBoxControl TheToolbox
	{
		[CompilerGenerated]
		get
		{
			return jfeLY74pto3;
		}
		[CompilerGenerated]
		private set
		{
			jfeLY74pto3 = value;
		}
	}

	public XAction Action
	{
		get
		{
			return (XAction)GetValue(ActionProperty);
		}
		set
		{
			SetValue(ActionProperty, value);
		}
	}

	public SmartCollection<SubProgram> SubPrograms
	{
		[CompilerGenerated]
		get
		{
			return CraLYRhmlxo;
		}
	}

	public SmartCollection<ActionVariable> VariableList
	{
		[CompilerGenerated]
		get
		{
			return dQ1LYqgRAHs;
		}
	}

	public ActionItem EditingActionItem
	{
		[CompilerGenerated]
		get
		{
			return o2qLYc50KHt;
		}
	}

	public bool IsSubProgram
	{
		[CompilerGenerated]
		get
		{
			return N45LYV3jeFK;
		}
	}

	public bool IsEditingSubProgram => SubProgramEditor.IsVisible;

	public ActionItem ResultActionItem
	{
		[CompilerGenerated]
		get
		{
			return PPQLYZB9DKH;
		}
		[CompilerGenerated]
		private set
		{
			PPQLYZB9DKH = value;
		}
	}

	public bool IsReadonly
	{
		[CompilerGenerated]
		get
		{
			return CWXLYhfVtwI;
		}
		[CompilerGenerated]
		set
		{
			CWXLYhfVtwI = value;
		}
	}

	public bool CurrentOptionEnableEvaluateVariable => ActionOptionsEditor.CurrentOptionEnableEvaluateVariable;

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return SGyLYeq4ke0;
		}
		[CompilerGenerated]
		set
		{
			SGyLYeq4ke0 = value;
		}
	}

	public EditActionParam EditParam
	{
		[CompilerGenerated]
		get
		{
			return upqLYk3GB0s;
		}
		[CompilerGenerated]
		set
		{
			upqLYk3GB0s = value;
		}
	}

	public ActionUserLimitation Limitation
	{
		[CompilerGenerated]
		get
		{
			return X01LYGvYavM;
		}
		[CompilerGenerated]
		set
		{
			X01LYGvYavM = value;
		}
	}

	internal bool GO3LhQ2nfmk()
	{
		return Limitation <= ActionUserLimitation.NoShareToActionStore;
	}

	private void I7xLhjgR9EI()
	{
		S7GLYIqkvCu = true;
	}

	public ActionDesignerWindow(SQLDataMgr sqlDataMgr, ActionItem editingActionItem, bool isGlobalSubProgram, bool isReadonly = false)
	{
		o2qLYc50KHt = editingActionItem;
		base.Tag = EditingActionItem?.Id;
		IsReadonly = isReadonly;
		N45LYV3jeFK = isGlobalSubProgram;
		ePnLYaPjWJ7 = sqlDataMgr;
		Action = new XAction();
		InitializeComponent();
		SVKLh4ECncQ();
		base.Loaded += PryLho4l0Ur;
		base.Closing += gkaLeJR8tZH;
		base.Closed += cPiLhdx8cNn;
		base.StateChanged += IBoLhOyiPRe;
		base.LocationChanged += zYvLhnk1NBd;
		VariableListControl.ProcessVarInfoChange = PkYLhM9vH8I;
		VariableListControl.OnHightlightRequested = VrcLeHTQ8dn;
		ActionStepsWrapper.ActionVariables = VariableList;
		VariableList.CollectionChanged += WlcLhUu1yje;
		SubPrograms.CollectionChanged += euCLhFcYKCb;
		zhcLh39cuM4();
		LbSubProgramNav.ItemsSource = LtbLYEgb25a();
		Limitation = (editingActionItem?.UserLimitation).GetValueOrDefault();
		gXCLhTyu4SG();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void zYvLhnk1NBd(object sender, EventArgs e)
	{
		if (base.WindowState != WindowState.Normal)
		{
			return;
		}
		try
		{
			DpiScale dpi = VisualTreeHelper.GetDpi(this);
			Screen screen = Screen.FromHandle(new WindowInteropHelper(this).Handle);
			if ((double)screen.WorkingArea.Width / dpi.DpiScaleX < base.Width)
			{
				base.Width = (double)screen.WorkingArea.Width / dpi.DpiScaleX;
			}
		}
		catch (Exception ex)
		{
			nLFLY8VGHEV.Warn("调整屏幕大小失败。" + ex.Message, ex);
			AppHelper.ShowWarning("调整屏幕大小失败。" + ex.Message);
		}
	}

	private void SVKLh4ECncQ()
	{
		if (AppState.HHxtaMaoqJr().EnableTreeTools)
		{
			TreeActionToolboxControl treeActionToolboxControl = (TreeActionToolboxControl)(TheToolbox = new TreeActionToolboxControl());
			treeActionToolboxControl.NodeDoubleClicked += VwNLh5MEjHb;
		}
		else
		{
			TheToolbox = new ActionToolbox();
			((ActionToolbox)TheToolbox).ItemDoubleClicked += jUdLhDdiBkU;
		}
		ToolContent.Content = TheToolbox;
	}

	private void VwNLh5MEjHb(object sender, EventArgs e)
	{
		j3rMU8Y10uUmMXKlqvc j3rMU8Y10uUmMXKlqvc = ((TreeActionToolboxControl)TheToolbox).B2OLb1H9YuK();
		if (j3rMU8Y10uUmMXKlqvc != null)
		{
			string text = "";
			string controlFieldKey = null;
			if (j3rMU8Y10uUmMXKlqvc is LNofqKYUdVwgyXju86h lNofqKYUdVwgyXju86h)
			{
				text = lNofqKYUdVwgyXju86h.TOdL6WbHTbf();
				controlFieldKey = lNofqKYUdVwgyXju86h.Key;
			}
			else
			{
				text = j3rMU8Y10uUmMXKlqvc.Key;
			}
			if (SubProgramEditor.IsVisible)
			{
				SubProgramEditor.CreateStep(text, null, controlFieldKey);
			}
			else
			{
				ActionStepsWrapper.CreateStep(text, null, controlFieldKey);
			}
		}
	}

	[AsyncStateMachine(typeof(_003CActionToolbox_OnItemDoubleClicked_003Ed__57))]
	private void jUdLhDdiBkU(object sender, EventArgs e)
	{
		_003CActionToolbox_OnItemDoubleClicked_003Ed__57 stateMachine = default(_003CActionToolbox_OnItemDoubleClicked_003Ed__57);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void cPiLhdx8cNn(object sender, EventArgs e)
	{
		GlobalSubProgramsList.ClearBinding();
		wyuLYKjCpLB.Cancel();
		RuFLewmq7r2();
	}

	private void PryLho4l0Ur(object sender, RoutedEventArgs e)
	{
		UpdateLayout();
		IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, ShowWindowLocation.CenterScreen);
		if (string.IsNullOrEmpty(EditingActionItem?.Title))
		{
			UiEditor.FocusTitle();
		}
		if (EditParam != null && !string.IsNullOrEmpty(EditParam.FindStepPath))
		{
			FindStep(EditParam.FindStepPath);
			if (KApZprFO3YcWUGFN2FTE == null)
			{
				switch (0)
				{
				}
			}
		}
		o0fLeE9T6A4();
	}

	private void gXCLhTyu4SG()
	{
		while (true)
		{
			if (IsSubProgram)
			{
				goto IL_01ae;
			}
			goto IL_025f;
			IL_025f:
			if (EditingActionItem == null)
			{
				ResultActionItem = new ActionItem
				{
					ActionType = (IsSubProgram ? ActionType.XSubProgram : ActionType.XAction)
				};
				BtnNote.Visibility = Visibility.Collapsed;
			}
			else
			{
				ResultActionItem = AppHelper.Clone(EditingActionItem);
				if (!ResultActionItem.ActionType.ContainedIn(ActionType.XAction, ActionType.XSubProgram))
				{
					throw new InvalidOperationException("要编辑的动作类型不正确！期待XAction类型");
				}
			}
			if (string.IsNullOrWhiteSpace(ResultActionItem.Data))
			{
				Action = new XAction();
				if (Action.Variables.All(_003C_003Ec.u7mSTsGldtv ?? (_003C_003Ec.u7mSTsGldtv = _003C_003Ec.shESTGYWHrB.PVLSTeWSetj)))
				{
					Action.Variables.Add(new ActionVariable
					{
						Key = "text",
						Desc = "默认的文本变量",
						DefaultValue = "",
						Type = VarType.Text
					});
				}
			}
			else
			{
				Action = JsonConvert.DeserializeObject<XAction>(ResultActionItem.Data);
				if (Action != null)
				{
					mPXLYW3Owwj = JsonConvert.SerializeObject(Action);
				}
			}
			BTqLecMJQ3a();
			TxtSummaryExpression.Text = Action.SummaryExpression ?? "";
			UiEditor.SetUiData(ResultActionItem);
			if (AppState.HHxtaMaoqJr().EnableAutoBackupActionsWhenEditing)
			{
				rh1LerMRNp9();
			}
			JPcLhiV5eLj();
			if (EditingActionItem == null || ePnLYaPjWJ7 == null || AppState.DataService == null)
			{
				break;
			}
			int num = 0;
			if (!FDCl2ZFOEAbTn1aciuNR())
			{
				goto IL_0168;
			}
			goto IL_018f;
			IL_01ae:
			base.Icon = FaIconHelper.GetImageSourceFromFaIcon("fa:Regular_Cube:#228b22", "#1296db", 64.0, AppHelper.GetDpiScaling(this));
			VariableListControl.IsForSubProgram = IsSubProgram;
			TabOptions.Visibility = Visibility.Collapsed;
			TabAssociations.Visibility = Visibility.Collapsed;
			BtnRun.Visibility = Visibility.Collapsed;
			TabSubProgram.Visibility = Visibility.Visible;
			goto IL_0213;
			IL_0168:
			System.Windows.Controls.Button btnLoadHistoryVersion = BtnLoadHistoryVersion;
			BtnSaveVersion.IsEnabled = true;
			btnLoadHistoryVersion.IsEnabled = true;
			num = 1;
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				break;
			}
			goto IL_018f;
			IL_018f:
			switch (num)
			{
			case 2:
				goto IL_01ae;
			case 4:
				goto IL_0213;
			case 3:
				continue;
			case 1:
			case 5:
				goto end_IL_026c;
			}
			goto IL_0168;
			IL_0213:
			TxtSummaryExpression.SetVariables(VariableList);
			goto IL_025f;
			continue;
			end_IL_026c:
			break;
		}
		if (EditingActionItem != null)
		{
			ActionOptionsEditor.LoadActionOptions(Action, EditingActionItem);
			ActionAssociationsEditor.LoadActionAssociations(EditingActionItem);
		}
		if (!GO3LhQ2nfmk())
		{
			base.Title += " (只读)";
			BtnSave.IsEnabled = false;
			BtnMenu.IsEnabled = false;
			InternalSubProgramListControl.IsReadonly = true;
			ToolContent.IsEnabled = false;
			IsReadonly = true;
		}
		if (IsReadonly)
		{
			BtnSave.IsEnabled = false;
			BtnSaveVersion.IsEnabled = false;
			BtnLoadHistoryVersion.IsEnabled = false;
			MenuExport.IsEnabled = false;
			MenuImport.IsEnabled = false;
			MenuFloatAction.IsEnabled = false;
			MenuClearAction.IsEnabled = false;
			SubProgramEditor.SetReadonly();
			BtnSave.Content = "(只读)";
		}
	}

	private void PkYLhM9vH8I(ActionVariable actionVariable_0, ActionVariable actionVariable_1)
	{
		_003C_003Ec__DisplayClass61_0 _003C_003Ec__DisplayClass61_ = new _003C_003Ec__DisplayClass61_0();
		_003C_003Ec__DisplayClass61_.kesSMZ5GTjZ = actionVariable_0.Key;
		int num;
		if (!string.Equals(actionVariable_1.Key, _003C_003Ec__DisplayClass61_.kesSMZ5GTjZ, StringComparison.InvariantCulture))
		{
			if (IsSubProgram)
			{
				if (actionVariable_1.IsInput)
				{
					goto IL_0053;
				}
				if (actionVariable_1.IsOutput)
				{
					num = 0;
					if (!FDCl2ZFOEAbTn1aciuNR())
					{
						goto IL_0070;
					}
					goto IL_0074;
				}
			}
			goto IL_0087;
		}
		int num2 = VariableList.IndexOf(_003C_003Ec__DisplayClass61_.bJkSMVeiBst);
		if (num2 >= 0)
		{
			VariableList[num2] = actionVariable_1;
			return;
		}
		nLFLY8VGHEV.Warn("未找到原始变量。");
		AppHelper.ShowWarning("未找到原始变量！");
		return;
		IL_0053:
		if (!AppHelper.Confirm("如果已经在动作中使用了子程序，修改变量名将会导致动作步骤中对应的参数设置丢失。\r\n\r\n您确认要修改么？"))
		{
			num = 2;
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				goto IL_0070;
			}
			goto IL_0074;
		}
		goto IL_0087;
		IL_0087:
		Action.Variables = VariableList.ToList();
		Action.Steps = ActionStepsWrapper.GetSteps();
		Action.SubPrograms = SubPrograms.ToList();
		JPcLhiV5eLj();
		Action.Variables[Action.Variables.IndexOf(actionVariable_0)] = actionVariable_1;
		num = 1;
		if (KApZprFO3YcWUGFN2FTE != null)
		{
			goto IL_0074;
		}
		goto IL_0101;
		IL_0101:
		if (IsSubProgram)
		{
			if (!string.IsNullOrEmpty(TxtSummaryExpression.Text))
			{
				TxtSummaryExpression.Text = XActionUiHelper.ReplaceVarInText(TxtSummaryExpression.Text, _003C_003Ec__DisplayClass61_.kesSMZ5GTjZ, actionVariable_1.Key, actionVariable_1.Type, true);
			}
			XActionUiHelper.ReplaceSubProgramVisibleExpVars(Action.Variables, _003C_003Ec__DisplayClass61_.kesSMZ5GTjZ, actionVariable_1.Key, actionVariable_1.Type);
		}
		XActionUiHelper.ReplaceStepsVar(Action.Steps, _003C_003Ec__DisplayClass61_.kesSMZ5GTjZ, actionVariable_1.Key, actionVariable_1.Type);
		JPcLhiV5eLj();
		BTqLecMJQ3a();
		if (EditingActionItem != null && !string.IsNullOrEmpty(EditingActionItem.Id))
		{
			ActionStateWriter.ChangeStateKey(EditingActionItem.Id, XActionRunner.GetVarStateKey(_003C_003Ec__DisplayClass61_.kesSMZ5GTjZ), XActionRunner.GetVarStateKey(actionVariable_1.Key));
		}
		return;
		IL_0074:
		switch (num)
		{
		case 1:
			goto IL_0101;
		case 2:
			return;
		}
		goto IL_0053;
		IL_0070:
		int num3 = default(int);
		num = num3;
		goto IL_0074;
	}

	[AsyncStateMachine(typeof(_003CDuplicateInternalSubProgramAsync_003Ed__62))]
	public Task DuplicateInternalSubProgramAsync(SubProgram subProgram)
	{
		_003CDuplicateInternalSubProgramAsync_003Ed__62 stateMachine = default(_003CDuplicateInternalSubProgramAsync_003Ed__62);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.subProgram = subProgram;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRenameInternalSubProgramAsync_003Ed__63))]
	public Task RenameInternalSubProgramAsync(SubProgram subProgram)
	{
		_003CRenameInternalSubProgramAsync_003Ed__63 stateMachine = default(_003CRenameInternalSubProgramAsync_003Ed__63);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.subProgram = subProgram;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void wc8LhAqM9ij(string string_2, string string_3)
	{
		Action.Variables = VariableList.ToList();
		Action.Steps = ActionStepsWrapper.GetSteps();
		Action.SubPrograms = SubPrograms.ToList();
		JPcLhiV5eLj();
		XActionUiHelper.ReplaceSpName(Action.Steps, string_2, string_3);
		int num = 0;
		if (!FDCl2ZFOEAbTn1aciuNR())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		foreach (SubProgram subProgram in SubPrograms)
		{
			XActionUiHelper.ReplaceSpName(subProgram.Steps, string_2, string_3);
		}
		JPcLhiV5eLj();
		BTqLecMJQ3a();
	}

	[AsyncStateMachine(typeof(_003CConvertGlobalSpToLocalSpAsync_003Ed__65))]
	public Task ConvertGlobalSpToLocalSpAsync(string globalSpId)
	{
		_003CConvertGlobalSpToLocalSpAsync_003Ed__65 stateMachine = default(_003CConvertGlobalSpToLocalSpAsync_003Ed__65);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.globalSpId = globalSpId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void IBoLhOyiPRe(object sender, EventArgs e)
	{
		if (base.WindowState == WindowState.Maximized)
		{
			ClearValue(FrameworkElement.MaxHeightProperty);
			UpdateLayout();
		}
	}

	private void euCLhFcYKCb(object sender, NotifyCollectionChangedEventArgs e)
	{
		if (!W6ZLYYaqsg5 && Action != null)
		{
			Action.SubPrograms = SubPrograms.ToList();
			K6xLhlAE4lX();
		}
	}

	private void WlcLhUu1yje(object sender, NotifyCollectionChangedEventArgs e)
	{
		if (!W6ZLYYaqsg5 && Action != null)
		{
			Action.Variables = VariableList.ToList();
			K6xLhlAE4lX();
		}
	}

	private void ActionStepsWrapper_OnStepChanged(object sender, EventArgs e)
	{
		Action.Steps = ActionStepsWrapper.GetSteps();
		K6xLhlAE4lX();
	}

	private void K6xLhlAE4lX()
	{
		etrLYsPDIo5.Debounce(100, fPLLefS7uRl);
	}

	private void JPcLhiV5eLj()
	{
		string text = JsonConvert.SerializeObject(Action);
		if (fYLLY9kFyMc.Add(text))
		{
			CommandManager.InvalidateRequerySuggested();
			I7xLhjgR9EI();
			ehALepw77di(text, "");
		}
	}

	private void zhcLh39cuM4()
	{
		BtnUndo.Command = lFOLYHTNDsY;
		BtnRedo.Command = il3LY1ZOJgo;
		int num = 1;
		if (KApZprFO3YcWUGFN2FTE != null)
		{
			goto IL_01ba;
		}
		goto IL_026b;
		IL_01ba:
		int num2 = default(int);
		num = num2;
		goto IL_026b;
		IL_026b:
		do
		{
			IL_026b_2:
			switch (num)
			{
			case 2:
				break;
			case 1:
				do
				{
					lFOLYHTNDsY.InputGestures.Add(new KeyGesture(Key.Z, ModifierKeys.Control));
					il3LY1ZOJgo.InputGestures.Add(new KeyGesture(Key.Y, ModifierKeys.Control));
					il3LY1ZOJgo.InputGestures.Add(new KeyGesture(Key.Z, ModifierKeys.Control | ModifierKeys.Shift));
					pMMLYbNxdp7.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
					IWpLY6ChQGA.InputGestures.Add(new KeyGesture(Key.F, ModifierKeys.Control));
					iKQLYXTAhis.InputGestures.Add(new KeyGesture(Key.W, ModifierKeys.Control));
					num = 2;
				}
				while (!FDCl2ZFOEAbTn1aciuNR());
				goto IL_026b_2;
			default:
				base.CommandBindings.AddKeyGesture(new KeyGesture(Key.F5, ModifierKeys.Control), mrdLYwQSkmw);
				base.CommandBindings.AddKeyGesture(new KeyGesture(Key.F6), B7bLYtOU6f1);
				base.CommandBindings.AddKeyGesture(new KeyGesture(Key.F6, ModifierKeys.Control), Rb9LYgQhRaP);
				return;
			}
			BtnUndo.CommandTarget = this;
			BtnRedo.CommandTarget = this;
			CommandBinding commandBinding = new CommandBinding
			{
				Command = lFOLYHTNDsY
			};
			commandBinding.CanExecute += jjGLeuP7mSq;
			commandBinding.Executed += QRYLeN5wbaL;
			base.CommandBindings.Add(commandBinding);
			CommandBinding commandBinding2 = new CommandBinding
			{
				Command = il3LY1ZOJgo
			};
			commandBinding2.CanExecute += tRJLe24WDA7;
			commandBinding2.Executed += TF0LevMjaqv;
			base.CommandBindings.Add(commandBinding2);
			CommandBinding commandBinding3 = new CommandBinding
			{
				Command = pMMLYbNxdp7
			};
			commandBinding3.Executed += XIeLeL7HIN0;
			base.CommandBindings.Add(commandBinding3);
			CommandBinding commandBinding4 = new CommandBinding
			{
				Command = IWpLY6ChQGA
			};
			commandBinding4.Executed += tT7LegRDURo;
			base.CommandBindings.Add(commandBinding4);
			CommandBinding commandBinding5 = new CommandBinding
			{
				Command = iKQLYXTAhis
			};
			commandBinding5.Executed += DVULhfvu6xq;
			commandBinding5.CanExecute += Ce8LhzOEkGH;
			base.CommandBindings.Add(commandBinding5);
			base.CommandBindings.AddKeyGesture(new KeyGesture(Key.F5), rRcLezdZ92i);
			num = 0;
		}
		while (KApZprFO3YcWUGFN2FTE == null);
		goto IL_01ba;
	}

	private void DVULhfvu6xq(object sender, ExecutedRoutedEventArgs e)
	{
		if (LbSubProgramNav.Items.Count > 1 && LbSubProgramNav.SelectedIndex != 0)
		{
			int selectedIndex = LbSubProgramNav.SelectedIndex;
			CgOLeI11p5l();
			LtbLYEgb25a().RemoveAt(selectedIndex);
			LbSubProgramNav.SelectedIndex = selectedIndex - 1;
		}
	}

	private void Ce8LhzOEkGH(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = LbSubProgramNav.Items.Count > 1 && LbSubProgramNav.SelectedIndex != 0;
	}

	private void RuFLewmq7r2()
	{
		base.CommandBindings.Clear();
		this.ClearAllBindings();
	}

	private void tT7LegRDURo(object sender, ExecutedRoutedEventArgs e)
	{
		if (ToolTab.SelectedIndex != 0)
		{
			ToolTab.SelectedIndex = 0;
			Task.Run((Func<Task>)xlkLYLRVVki);
		}
		else
		{
			TheToolbox.FocusSearch();
		}
	}

	[AsyncStateMachine(typeof(_003CCbSaveOnExecuted_003Ed__84))]
	private void XIeLeL7HIN0(object sender, ExecutedRoutedEventArgs e)
	{
		_003CCbSaveOnExecuted_003Ed__84 stateMachine = default(_003CCbSaveOnExecuted_003Ed__84);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void TF0LevMjaqv(object sender, ExecutedRoutedEventArgs e)
	{
		SubProgramEditor subProgramEditor = SubProgramEditor;
		if (subProgramEditor != null && subProgramEditor.IsVisible)
		{
			SubProgramEditor.CbRedoOnExecuted(sender, e);
			int num = 0;
			if (!FDCl2ZFOEAbTn1aciuNR())
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
			if (fYLLY9kFyMc.CanRedo())
			{
				ActionStepsDto actionStepsDto_ = JsonConvert.DeserializeObject<ActionStepsDto>(fYLLY9kFyMc.Redo());
				Tl3LeS7Nty9(actionStepsDto_);
			}
			else
			{
				AppHelper.ShowWarning("不能重做了");
			}
			e.Handled = true;
		}
	}

	private void Tl3LeS7Nty9(ActionStepsDto actionStepsDto_0)
	{
		Action.Steps = actionStepsDto_0.Steps;
		Action.Variables = actionStepsDto_0.Variables;
		Action.SubPrograms = actionStepsDto_0.SubPrograms;
		BTqLecMJQ3a();
	}

	private void tRJLe24WDA7(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = fYLLY9kFyMc.CanRedo();
		e.Handled = true;
	}

	private void jjGLeuP7mSq(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = fYLLY9kFyMc.CanUndo();
		e.Handled = true;
	}

	private void QRYLeN5wbaL(object sender, ExecutedRoutedEventArgs e)
	{
		SubProgramEditor subProgramEditor = SubProgramEditor;
		if (subProgramEditor != null && subProgramEditor.IsVisible)
		{
			SubProgramEditor.CbUndoOnExecuted(sender, e);
			return;
		}
		if (fYLLY9kFyMc.CanUndo())
		{
			ActionStepsDto actionStepsDto_ = JsonConvert.DeserializeObject<ActionStepsDto>(fYLLY9kFyMc.Undo());
			Tl3LeS7Nty9(actionStepsDto_);
		}
		else
		{
			AppHelper.ShowWarning("不能撤销了");
		}
		CommandManager.InvalidateRequerySuggested();
		int num = 0;
		if (!FDCl2ZFOEAbTn1aciuNR())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		e.Handled = true;
	}

	[AsyncStateMachine(typeof(_003COnClosing_003Ed__90))]
	private void gkaLeJR8tZH(object sender, CancelEventArgs e)
	{
		_003COnClosing_003Ed__90 stateMachine = default(_003COnClosing_003Ed__90);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void PZMLe0ZAlPN(object sender, RoutedEventArgs e)
	{
		q3JLe8OmW7q();
	}

	public bool ShouldShowCloseConfirm()
	{
		if (IsReadonly)
		{
			return false;
		}
		if (!S7GLYIqkvCu)
		{
			return false;
		}
		if (SubProgramEditor.IsVisible && SubProgramEditor.CanUndo())
		{
			return true;
		}
		if (EditingActionItem != null)
		{
			return !string.Equals(mPXLYW3Owwj, ResultActionItem.Data, StringComparison.Ordinal);
		}
		if (!fYLLY9kFyMc.CanUndo() && !fYLLY9kFyMc.CanRedo())
		{
			return false;
		}
		return true;
	}

	[AsyncStateMachine(typeof(_003CBtnSave_OnClick_003Ed__93))]
	private void s68LeCPPklA(object sender, RoutedEventArgs e)
	{
		_003CBtnSave_OnClick_003Ed__93 stateMachine = default(_003CBtnSave_OnClick_003Ed__93);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void uJZLeP2xrKU()
	{
		if (!string.IsNullOrWhiteSpace(EditingActionItem?.Id))
		{
			List<string> values = LtbLYEgb25a().Select(_003C_003Ec.xgTSTHffGXM ?? (_003C_003Ec.xgTSTHffGXM = _003C_003Ec.shESTGYWHrB.CRFSTYrSc9H)).Skip(1).ToList();
			ActionStateWriter.WriteActionState("action_edit_sp_list", EditingActionItem?.Id, values.JoinToString());
		}
	}

	private void o0fLeE9T6A4()
	{
		if (string.IsNullOrWhiteSpace(EditingActionItem?.Id))
		{
			int num = 0;
			if (!FDCl2ZFOEAbTn1aciuNR())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
		}
		else
		{
			if (!SubPrograms.HasData())
			{
				return;
			}
			string[] array = ActionStateWriter.ReadActionStateValue("action_edit_sp_list", EditingActionItem?.Id).data?.SplitToList();
			if (!array.HasData())
			{
				return;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				_003C_003Ec__DisplayClass95_0 _003C_003Ec__DisplayClass95_ = new _003C_003Ec__DisplayClass95_0();
				_003C_003Ec__DisplayClass95_.k6NSMxeqrGd = array2[i];
				SubProgram subProgram = SubPrograms.FirstOrDefault(_003C_003Ec__DisplayClass95_.R5oSMKiUMT6);
				if (subProgram != null)
				{
					SubProgramNavItem subProgramNavItem = new SubProgramNavItem();
					subProgramNavItem.IsMain = false;
					subProgramNavItem.Icon = "";
					subProgramNavItem.Name = subProgram.Name;
					subProgramNavItem.Description = subProgram.Description;
					subProgramNavItem.Key = subProgram.Name;
					subProgramNavItem.Uw7LYFHq947(new WeakReference<SubProgram>(subProgram));
					SubProgramNavItem item = subProgramNavItem;
					LtbLYEgb25a().Add(item);
				}
			}
			if (LtbLYEgb25a().Count <= 1)
			{
				return;
			}
		}
		LbSubProgramNav.SelectedIndex = 0;
	}

	[AsyncStateMachine(typeof(_003CDoSaveWithoutClose_003Ed__96))]
	private Task<bool> cxeLeyXFlmr()
	{
		_003CDoSaveWithoutClose_003Ed__96 stateMachine = default(_003CDoSaveWithoutClose_003Ed__96);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public bool CheckIfCanSave()
	{
		if (IsSubProgram && (EditingActionItem == null || !string.Equals(EditingActionItem.Title, ResultActionItem.Title, StringComparison.OrdinalIgnoreCase)))
		{
			if (string.IsNullOrEmpty(ResultActionItem.Title))
			{
				AppHelper.ShowWarning("请输入子程序名称！");
				int num = 0;
				if (!FDCl2ZFOEAbTn1aciuNR())
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => false, 
				};
			}
			if (!SubProgramHelper.IsValidSubProgramName(ResultActionItem.Title))
			{
				AppHelper.ShowWarning("子程序名称中不能包含特殊字符。");
				return false;
			}
			if (AppState.DataService.TaJtXswFMjn(ResultActionItem.Title) && !AppHelper.Confirm("已存在相同名称的公共子程序。仍要使用这个名称么？"))
			{
				return false;
			}
		}
		if (!string.IsNullOrEmpty(ResultActionItem.Title))
		{
			return true;
		}
		if (AppHelper.AskUser("尚未为动作设置文字标签，您确认不设置标签么？") == MessageBoxResult.OK)
		{
			return true;
		}
		UiEditor.FocusTitle();
		return false;
	}

	private void q3JLe8OmW7q()
	{
		try
		{
			if (base.IsLoaded)
			{
				Close();
			}
		}
		catch (Exception exception)
		{
			string message = "关闭窗口出错：" + exception.GetMessageWithInner();
			nLFLY8VGHEV.Warn(message, exception);
			AppHelper.ShowWarning(message);
		}
	}

	private void hSiLea9QP4i(object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			if (base.OwnedWindows.Count > 0)
			{
				if (!FDCl2ZFOEAbTn1aciuNR())
				{
					switch (0)
					{
					}
				}
			}
			else if (SubProgramEditor.IsVisible)
			{
				if (!IsReadonly && SubProgramEditor.CanUndo())
				{
					if (AppHelper.Confirm("您确认要关闭子程序编辑器么？更改将会丢失。"))
					{
						SubProgramEditor_OnCancel(sender, e);
					}
				}
				else
				{
					SubProgramEditor_OnCancel(sender, e);
				}
			}
			else
			{
				q3JLe8OmW7q();
				e.Handled = true;
			}
		}
		else if (e.Key == Key.F1)
		{
			uouLel5F0HD(this, e);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnSaveVersion_OnClick_003Ed__100))]
	private void sHgLe7sAQiD(object sender, RoutedEventArgs e)
	{
		_003CBtnSaveVersion_OnClick_003Ed__100 stateMachine = default(_003CBtnSaveVersion_OnClick_003Ed__100);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void T6KLeRoG8TW(object sender, RoutedEventArgs e)
	{
		while (true)
		{
			int num = 0;
			if (!FDCl2ZFOEAbTn1aciuNR())
			{
				goto IL_00df;
			}
			goto IL_00ec;
			IL_00df:
			do
			{
				if (ePnLYaPjWJ7 != null && EditingActionItem != null)
				{
					ActionHistoryWindow actionHistoryWindow = new ActionHistoryWindow(ePnLYaPjWJ7, EditingActionItem.Id)
					{
						Owner = this
					};
					if (actionHistoryWindow.ShowDialog() == true)
					{
						JPcLhiV5eLj();
						ActionItem restoreItem = actionHistoryWindow.RestoreItem;
						if (restoreItem.ActionType == ActionType.XAction)
						{
							if (!string.IsNullOrEmpty(restoreItem.Data))
							{
								XAction xAction = JsonConvert.DeserializeObject<XAction>(restoreItem.Data);
								Action.Steps = xAction.Steps;
								Action.Variables = xAction.Variables;
								Action.SubPrograms = xAction.SubPrograms;
								JPcLhiV5eLj();
								BTqLecMJQ3a();
								num = 2;
								continue;
							}
							AppHelper.ShowWarning("不支持恢复此版本。", true);
							return;
						}
						AppHelper.ShowWarning("动作类型不匹配。", true);
						return;
					}
					return;
				}
				AppHelper.ShowWarning("当前动作不支持此功能。");
				return;
			}
			while (KApZprFO3YcWUGFN2FTE != null);
			goto IL_00ec;
			IL_00ec:
			switch (num)
			{
			case 1:
				continue;
			case 2:
				return;
			}
			goto IL_00df;
		}

	}

	private void JlOLeqx4Mkh(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(AppHelper.CreateHelpLink(7, "动作编辑器"));
	}

	private void BTqLecMJQ3a()
	{
		W6ZLYYaqsg5 = true;
		try
		{
			VariableList.Reset(Action.Variables);
			if (Action.SubPrograms.HasData())
			{
				if (KApZprFO3YcWUGFN2FTE != null)
				{
					switch (0)
					{
					}
				}
				SubPrograms.Reset(Action.SubPrograms);
			}
			else
			{
				SubPrograms.Clear();
			}
			try
			{
				ActionStepsWrapper.SetSteps(Action.Steps);
			}
			catch (Exception ex)
			{
				nLFLY8VGHEV.Warn("加载步骤列表出错了。" + ex.Message, ex);
				AppHelper.ShowError("加载步骤列表出错了，可能是您的Quicker版本比较低。" + ex.Message);
				Close();
			}
			VariableListControl.SetDataSource(VariableList, Action);
			InternalSubProgramListControl.SetData(SubPrograms, Action);
		}
		finally
		{
			W6ZLYYaqsg5 = false;
		}
	}

	private void cIHLeV0myBR()
	{
		if (!IsReadonly)
		{
			Action.Variables = VariableList.ToList();
			Action.SubPrograms = SubPrograms.ToList();
			Action.Steps = ActionStepsWrapper.GetSteps();
			Action.SummaryExpression = TxtSummaryExpression.Text;
			ActionOptionsEditor.SaveXActionOptions(Action);
			ResultActionItem.Data = JsonConvert.SerializeObject(Action);
			ActionOptionsEditor.SaveActionOptions(ResultActionItem);
			ActionAssociationsEditor.SaveActionAssociations(ResultActionItem);
			UiEditor.SaveToAction(ResultActionItem);
			int num = 0;
			if (!FDCl2ZFOEAbTn1aciuNR())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void DvbLeZAqXnF(object sender, RoutedEventArgs e)
	{
		if (!GO3LhQ2nfmk())
		{
			AppHelper.ShowWarning("本动作不支持编辑。");
			return;
		}
		(bool, string) tuple = AppHelper.ShowSaveFileDialog("*.qka|*.qka", ".qka", AppHelper.RemoveInvalidCharsFromFileName(UiEditor.ActionTitle) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".qka", "", "导出动作-" + UiEditor.ActionTitle);
		if (!tuple.Item1)
		{
			return;
		}
		try
		{
			cIHLeV0myBR();
			new SubProgram
			{
				Variables = Action.Variables,
				SubPrograms = Action.SubPrograms,
				Steps = Action.Steps,
				Name = ResultActionItem.Title,
				Description = ResultActionItem.Description,
				SummaryExpression = Action.SummaryExpression
			};
			File.WriteAllText(tuple.Item2, JsonConvert.SerializeObject(Action, Formatting.Indented));
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("导出出错：" + ex.Message);
		}
	}

	private void eeqLe9psn1H(object sender, RoutedEventArgs e)
	{
		if (!GO3LhQ2nfmk())
		{
			AppHelper.ShowWarning("本动作不支持编辑。");
			return;
		}
		(bool, string) tuple = AppHelper.ShowSelectFileDialog("*.qka|*.qka", ".qka", "", "", "导入动作定义");
		if (!tuple.Item1)
		{
			return;
		}
		try
		{
			XAction xAction = JsonConvert.DeserializeObject<XAction>(File.ReadAllText(tuple.Item2));
			if (xAction != null)
			{
				if (xAction.Steps.HasData() || xAction.Variables.HasData())
				{
					JPcLhiV5eLj();
					Action.Steps = xAction.Steps;
					Action.Variables = xAction.Variables;
					Action.SubPrograms = xAction.SubPrograms;
					JPcLhiV5eLj();
					BTqLecMJQ3a();
					return;
				}
				int num = 0;
				if (!FDCl2ZFOEAbTn1aciuNR())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			AppHelper.ShowWarning("文件内容为空！");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("导入动作定义出错：" + ex.Message);
		}
	}

	private void q61Lehyi9mj(object sender, RoutedEventArgs e)
	{
		if (!GO3LhQ2nfmk())
		{
			AppHelper.ShowWarning("本动作不支持编辑。");
			return;
		}
		JPcLhiV5eLj();
		Tl3LeS7Nty9(new ActionStepsDto());
		K6xLhlAE4lX();
	}

	private void Ed1LeeocQjM(object sender, RoutedEventArgs e)
	{
		(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(EditingActionItem.Id);
		if (actionById.Item1 != null)
		{
			AppState.lWutartRfUY().FloatAction(actionById.Item1, this);
		}
		else
		{
			AppHelper.ShowWarning("请保存动作后再悬浮。", true);
		}
	}

	private void SubProgramEditor_OnSave(object sender, EventArgs e)
	{
		CgOLeI11p5l();
	}

	private void ubLLeYcQ878(object sender, RoutedEventArgs e)
	{
		CgOLeI11p5l();
	}

	private void CgOLeI11p5l()
	{
		try
		{
			if (SubProgramEditor.IsVisible)
			{
				SEPLeGWGYNb();
			}
			HKWLekI0CBp();
			DDPLe55Q9AK();
		}
		catch (Exception ex)
		{
			nLFLY8VGHEV.Warn("保存子程序出错：" + ex.Message, ex);
			AppHelper.ShowWarning(ex.Message, true);
		}
	}

	private void fCrLeWhopXg(string string_2)
	{
		try
		{
			if (SubProgramEditor.IsVisible)
			{
				SEPLeGWGYNb();
				HKWLekI0CBp();
			}
			EditInternalSubProgramByName(string_2);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message, true);
			jjSLejv5Z2s(SubProgramEditor.EditingSubProgram);
		}
	}

	private void HKWLekI0CBp()
	{
		SubProgramEditor.Visibility = Visibility.Collapsed;
		GridMain.Visibility = Visibility.Visible;
		SubProgramEditor.Reset();
		DDPLe55Q9AK();
	}

	private SubProgram SEPLeGWGYNb()
	{
		_003C_003Ec__DisplayClass114_0 _003C_003Ec__DisplayClass114_ = new _003C_003Ec__DisplayClass114_0();
		SubProgram result = SubProgramEditor.GetResult();
		_003C_003Ec__DisplayClass114_.a5cSTKYiwYe = result.Name.Trim();
		_003C_003Ec__DisplayClass114_.E41STmxFCc2 = SubProgramEditor.EditingSubProgram;
		if (!string.Equals(_003C_003Ec__DisplayClass114_.a5cSTKYiwYe, _003C_003Ec__DisplayClass114_.E41STmxFCc2.Name, StringComparison.Ordinal))
		{
			if (SubPrograms.Any(_003C_003Ec__DisplayClass114_.WehSTXgPsUQ))
			{
				throw new InvalidDataException("子程序名称 " + _003C_003Ec__DisplayClass114_.a5cSTKYiwYe + " 已存在，请更换一个新名称。");
			}
			SubProgramHelper.ReplaceInternalSubProgramName(Action, _003C_003Ec__DisplayClass114_.E41STmxFCc2.Name, _003C_003Ec__DisplayClass114_.a5cSTKYiwYe);
			BTqLecMJQ3a();
		}
		_003C_003Ec__DisplayClass114_.E41STmxFCc2.Name = result.Name;
		_003C_003Ec__DisplayClass114_.E41STmxFCc2.Description = result.Description;
		_003C_003Ec__DisplayClass114_.E41STmxFCc2.SummaryExpression = result.SummaryExpression;
		_003C_003Ec__DisplayClass114_.E41STmxFCc2.Variables = result.Variables;
		_003C_003Ec__DisplayClass114_.E41STmxFCc2.Steps = result.Steps;
		int num = 1;
		if (FDCl2ZFOEAbTn1aciuNR())
		{
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					_003C_003Ec__DisplayClass114_.E41STmxFCc2.LastEditTimeUtc = DateTime.UtcNow;
					_003C_003Ec__DisplayClass114_.E41STmxFCc2.IsLocalEdited = true;
					_003C_003Ec__DisplayClass114_.E41STmxFCc2.SharedId = result.SharedId;
					num = 0;
					if (KApZprFO3YcWUGFN2FTE != null)
					{
						num = num2;
					}
					continue;
				}
				break;
			}
		}
		_003C_003Ec__DisplayClass114_.E41STmxFCc2.ShareTimeUtc = result.ShareTimeUtc;
		lOcLe40oMsY(_003C_003Ec__DisplayClass114_.E41STmxFCc2);
		cIHLeV0myBR();
		JPcLhiV5eLj();
		return _003C_003Ec__DisplayClass114_.E41STmxFCc2;
	}

	private void SubProgramEditor_OnCancel(object sender, EventArgs e)
	{
		if (!SubProgramEditor.HasChanged || IsReadonly || AppHelper.Confirm("您确认要取消修改么？"))
		{
			HKWLekI0CBp();
		}
	}

	public void EditInternalSubProgramByName(string subProgramName)
	{
		_003C_003Ec__DisplayClass116_0 _003C_003Ec__DisplayClass116_ = new _003C_003Ec__DisplayClass116_0();
		_003C_003Ec__DisplayClass116_.jRHSTr0DPHf = subProgramName;
		SubProgram subProgram = SubPrograms.FirstOrDefault(_003C_003Ec__DisplayClass116_.SY2STxo2nL3);
		if (subProgram == null)
		{
			AppHelper.ShowWarning("未找到子程序：" + _003C_003Ec__DisplayClass116_.jRHSTr0DPHf, true);
		}
		else
		{
			EditSubProgram(subProgram);
		}
	}

	public void EditSubProgram(SubProgram subProgram)
	{
		_003C_003Ec__DisplayClass117_0 _003C_003Ec__DisplayClass117_ = new _003C_003Ec__DisplayClass117_0();
		_003C_003Ec__DisplayClass117_.CJFSTBrju7J = this;
		if (subProgram == null)
		{
			AppHelper.ShowWarning("数据为空！");
			return;
		}
		if (SubProgramEditor.IsVisible)
		{
			try
			{
				SEPLeGWGYNb();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("保存当前子程序失败。" + ex.Message, true);
				return;
			}
		}
		GridMain.Visibility = Visibility.Hidden;
		SubProgramEditor.SetSubProgram(subProgram, Action);
		SubProgramEditor.Visibility = Visibility.Visible;
		_003C_003Ec__DisplayClass117_.eTVSTQYO2V8 = SubProgramEditor.TxtFilter.Text;
		SubProgramEditor.TxtFilter.Text = "";
		SubProgramEditor.TxtVarFilter.Text = "";
		jjSLejv5Z2s(subProgram);
		base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass117_.ifsSTpV5Wlc);
		int num = 0;
		if (!FDCl2ZFOEAbTn1aciuNR())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public void ConvertToGlobalSubProgram(SubProgram internalSubProgram)
	{
		_003C_003Ec__DisplayClass118_0 _003C_003Ec__DisplayClass118_ = new _003C_003Ec__DisplayClass118_0();
		_003C_003Ec__DisplayClass118_.TMHSTnue4Bl = internalSubProgram;
		if (!SubProgramEditor.IsVisible)
		{
			if (!SubProgramHelper.CanInternalSubProgramBeConvertedToGlobal(_003C_003Ec__DisplayClass118_.TMHSTnue4Bl))
			{
				AppHelper.ShowWarning("子程序内部使用了其它内部子程序，无法转换为公共子程序。", true);
			}
			else
			{
				if (!AppHelper.Confirm("确认要把子程序 " + _003C_003Ec__DisplayClass118_.TMHSTnue4Bl.Name + " 转换为公共子程序么？"))
				{
					return;
				}
				cIHLeV0myBR();
				JPcLhiV5eLj();
				int num = 1;
				if (!FDCl2ZFOEAbTn1aciuNR())
				{
					int num2 = default(int);
					num = num2;
				}
				SubProgram subProgram = default(SubProgram);
				int num3 = default(int);
				while (true)
				{
					switch (num)
					{
					case 1:
						subProgram = AppHelper.Clone(_003C_003Ec__DisplayClass118_.TMHSTnue4Bl);
						if (AppState.DataService.TaJtXswFMjn(_003C_003Ec__DisplayClass118_.TMHSTnue4Bl.Name))
						{
							num = 0;
							if (KApZprFO3YcWUGFN2FTE != null)
							{
								continue;
							}
							goto default;
						}
						goto IL_011f;
					default:
					{
						UserInputWindow userInputWindow = new UserInputWindow("text", "已经存在相同的公共子程序名称。\r\n如需修改，请输入新的公共子程序名称。", "", subProgram.Name);
						userInputWindow.Title = "名称已存在";
						if (userInputWindow.ShowDialog() != false && !string.IsNullOrEmpty(userInputWindow.TextValue))
						{
							subProgram.Name = userInputWindow.TextValue;
							goto IL_011f;
						}
						return;
					}
					case 2:
						{
							SubPrograms.RemoveAt(num3);
							break;
						}
						IL_011f:
						if (AppState.DataService.GetGlobalSubProgram(_003C_003Ec__DisplayClass118_.TMHSTnue4Bl.Id) != null)
						{
							subProgram.Id = Guid.NewGuid().ToString();
						}
						AppState.DataService.fgstXGxbg6P(subProgram);
						num3 = SubPrograms.IndexOf(_003C_003Ec__DisplayClass118_.tbhSTjK5y1m);
						if (num3 < 0)
						{
							break;
						}
						goto case 2;
					}
					break;
				}
				SubProgramHelper.ConvertInternalSubProgramToGlobal(Action, _003C_003Ec__DisplayClass118_.TMHSTnue4Bl, subProgram);
				BTqLecMJQ3a();
			}
		}
		else
		{
			AppHelper.ShowWarning("请先保存编辑中的子程序。");
		}
	}

	public void DeleteInternalSubProgram(SubProgram subProgram)
	{
		_003C_003Ec__DisplayClass119_0 _003C_003Ec__DisplayClass119_ = new _003C_003Ec__DisplayClass119_0();
		_003C_003Ec__DisplayClass119_.kjKST5b5YVv = subProgram;
		if (SubProgramEditor.IsVisible)
		{
			if (KApZprFO3YcWUGFN2FTE == null)
			{
				switch (0)
				{
				}
			}
			AppHelper.ShowWarning("请先保存编辑中的子程序。");
		}
		else if (SubProgramHelper.IsInternalSubProgramUsedInAction(_003C_003Ec__DisplayClass119_.kjKST5b5YVv, Action))
		{
			AppHelper.ShowWarning("子程序在动作中已被使用，不能删除。", true);
		}
		else
		{
			if (!AppHelper.Confirm("您确认要删除子程序 “" + _003C_003Ec__DisplayClass119_.kjKST5b5YVv.Name + "” 么？"))
			{
				return;
			}
			SubPrograms.Remove(_003C_003Ec__DisplayClass119_.kjKST5b5YVv);
			if (!LbSubProgramNav.IsVisible)
			{
				return;
			}
			SubProgramNavItem subProgramNavItem = LtbLYEgb25a().FirstOrDefault(_003C_003Ec__DisplayClass119_.X5CST4LFvxX);
			if (subProgramNavItem != null)
			{
				if (LbSubProgramNav.SelectedItem as SubProgramNavItem == subProgramNavItem)
				{
					LbSubProgramNav.SelectedIndex = 0;
				}
				LtbLYEgb25a().Remove(subProgramNavItem);
			}
		}
	}

	public void ClearNotUsedInternalSubPrograms()
	{
		if (SubProgramEditor.IsVisible)
		{
			AppHelper.ShowWarning("请先保存编辑中的子程序。");
			return;
		}
		IList<SubProgram> list = new List<SubProgram>();
		foreach (SubProgram subProgram in SubPrograms)
		{
			if (!SubProgramHelper.IsInternalSubProgramUsedInAction(subProgram, Action))
			{
				list.Add(subProgram);
			}
		}
		if (!list.HasData())
		{
			AppHelper.ShowInformation("没有可以清理的子程序。");
		}
		else
		{
			if (MessageBoxHelper.Show(this, "您确认要删除这些子程序么？\r\n" + string.Join("\r\n", list.Select(_003C_003Ec.SumST1BvoFH ?? (_003C_003Ec.SumST1BvoFH = _003C_003Ec.shESTGYWHrB.yxPSTIdOLL2))), "删除未使用的子程序", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) != MessageBoxResult.OK)
			{
				return;
			}
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				switch (0)
				{
				}
			}
			foreach (SubProgram item in list)
			{
				SubPrograms.Remove(item);
			}
		}
	}

	public void OpenSubProgram(ActionStep step)
	{
		string subProgramIdentifier = SubProgramStep.GetSubProgramIdentifier(step);
		if (!string.IsNullOrEmpty(subProgramIdentifier))
		{
			int num = 0;
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (subProgramIdentifier.StartsWith("%%"))
			{
				SubProgram globalSubProgram = AppState.DataService.GetGlobalSubProgram(subProgramIdentifier.Substring(2));
				if (globalSubProgram != null)
				{
					AppState.lWutartRfUY().CreateOrEditGlobalSubProgram(globalSubProgram);
				}
			}
			else if (subProgramIdentifier.StartsWith("@@"))
			{
				AppHelper.TryOpenUrlOrFile(SubProgramHelper.GetNetSharedSubProgramLink(subProgramIdentifier));
			}
			else
			{
				EditInternalSubProgramByName(subProgramIdentifier);
			}
		}
		else
		{
			AppHelper.ShowWarning("子程序标识为空");
		}
	}

	public bool IsGlobalSubProgramUsedInCurrentAction(string identifier)
	{
		cIHLeV0myBR();
		return ResultActionItem.Data.IndexOf(identifier, StringComparison.Ordinal) >= 0;
	}

	private void cdZLesnOPgS(object sender, TextChangedEventArgs e)
	{
		if (base.IsLoaded)
		{
			rvmLYmTyAZG.Debounce(500, M94LYS19X8j);
		}
	}

	private void VrcLeHTQ8dn(string string_2)
	{
		TxtFilter.Text = string_2;
	}

	public void HighlightText(string text)
	{
		if (SubProgramEditor.IsVisible)
		{
			SubProgramEditor.TxtFilter.Text = text;
		}
		else
		{
			TxtFilter.Text = text;
		}
	}

	private void kAPLe1UXRa3(object sender, RoutedEventArgs e)
	{
		ActionStepsWrapper.ExpandAll();
	}

	private void OBVLebASgj6(object sender, RoutedEventArgs e)
	{
		ActionStepsWrapper.CollapseAll();
	}

	[AsyncStateMachine(typeof(_003CBtnRun_OnClick_003Ed__129))]
	private void PKMLe6xsFNZ(object sender, RoutedEventArgs e)
	{
		_003CBtnRun_OnClick_003Ed__129 stateMachine = default(_003CBtnRun_OnClick_003Ed__129);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnRun_OnMouseRightButtonUp_003Ed__130))]
	private void ovTLeXO3cZn(object sender, MouseButtonEventArgs e)
	{
		_003CBtnRun_OnMouseRightButtonUp_003Ed__130 stateMachine = default(_003CBtnRun_OnMouseRightButtonUp_003Ed__130);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private bool zgeLem9TWWQ()
	{
		if (!Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			return Keyboard.IsKeyDown(Key.RightCtrl);
		}
		return true;
	}

	[AsyncStateMachine(typeof(_003CRunAction_003Ed__132))]
	private Task RrfLeKkwhih(bool bool_6, bool bool_7, string string_2 = "")
	{
		_003CRunAction_003Ed__132 stateMachine = default(_003CRunAction_003Ed__132);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.debug = bool_6;
		stateMachine.minimize = bool_7;
		stateMachine.inputParam = string_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnNote_OnClick_003Ed__133))]
	private void E6fLexZZcp9(object sender, RoutedEventArgs e)
	{
		_003CBtnNote_OnClick_003Ed__133 stateMachine = default(_003CBtnNote_OnClick_003Ed__133);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CImportSharedSubProgramAsync_003Ed__134))]
	public Task ImportSharedSubProgramAsync(Guid id)
	{
		_003CImportSharedSubProgramAsync_003Ed__134 stateMachine = default(_003CImportSharedSubProgramAsync_003Ed__134);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.id = id;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CConvertNetworkSharedSubprogramToInternalSp_003Ed__135))]
	public Task ConvertNetworkSharedSubprogramToInternalSp(string spIdentifier)
	{
		_003CConvertNetworkSharedSubprogramToInternalSp_003Ed__135 stateMachine = default(_003CConvertNetworkSharedSubprogramToInternalSp_003Ed__135);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.spIdentifier = spIdentifier;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void CopyGlobalSubProgramToInternal(SubProgram subProgram)
	{
		_003C_003Ec__DisplayClass136_0 _003C_003Ec__DisplayClass136_ = new _003C_003Ec__DisplayClass136_0();
		_003C_003Ec__DisplayClass136_.dM0STf1Buwb = AppHelper.Clone(subProgram);
		_003C_003Ec__DisplayClass136_.dM0STf1Buwb.Id = Guid.NewGuid().ToString();
		_003C_003Ec__DisplayClass136_.dM0STf1Buwb.CreateTimeUtc = DateTime.UtcNow;
		int num = 0;
		if (KApZprFO3YcWUGFN2FTE != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		_003C_003Ec__DisplayClass136_.dM0STf1Buwb.Name = _003C_003Ec__DisplayClass136_.dM0STf1Buwb.Name + "(动作内副本)";
		_003C_003Ec__DisplayClass136_.dM0STf1Buwb.SharedId = "";
		_003C_003Ec__DisplayClass136_.dM0STf1Buwb.ShareTimeUtc = null;
		if (SubPrograms.Any(_003C_003Ec__DisplayClass136_.ePtST3ThOo5))
		{
			AppHelper.ShowWarning("子程序名称已存在：" + _003C_003Ec__DisplayClass136_.dM0STf1Buwb.Name);
			return;
		}
		SubPrograms.Add(_003C_003Ec__DisplayClass136_.dM0STf1Buwb);
		ToolTab.SelectedIndex = 1;
	}

	public void FindStep(string stepPath)
	{
		if (!string.IsNullOrEmpty(stepPath))
		{
			if (SubProgramEditor.IsVisible)
			{
				SubProgramEditor.TxtFilter.Text = "step:" + stepPath;
			}
			else
			{
				TxtFilter.Text = "step:" + stepPath;
			}
		}
	}

	private void rh1LerMRNp9()
	{
		if (de7LYxe05on == null)
		{
			de7LYxe05on = new ActionAutoBackup(EditingActionItem);
		}
	}

	private void ehALepw77di(string string_2, string string_3)
	{
		_003C_003Ec__DisplayClass141_0 _003C_003Ec__DisplayClass141_ = new _003C_003Ec__DisplayClass141_0();
		_003C_003Ec__DisplayClass141_.lKUSMtrDBE6 = this;
		_003C_003Ec__DisplayClass141_.Y4ESMgGMDYW = string_2;
		if (AppState.HHxtaMaoqJr().EnableAutoBackupActionsWhenEditing)
		{
			if (de7LYxe05on == null)
			{
				rh1LerMRNp9();
			}
			wyuLYKjCpLB.Throttle(60000, _003C_003Ec__DisplayClass141_.ntVSTzCvrAv);
		}
	}

	private void nwKLeBwDMKD(string string_2, string string_3)
	{
		_003C_003Ec__DisplayClass142_0 _003C_003Ec__DisplayClass142_ = new _003C_003Ec__DisplayClass142_0();
		_003C_003Ec__DisplayClass142_.tE8SMS4gira = this;
		_003C_003Ec__DisplayClass142_.e9jSM25P15o = string_2;
		_003C_003Ec__DisplayClass142_.wshSMuMExcK = string_3;
		rh1LerMRNp9();
		Task.Run((Action)_003C_003Ec__DisplayClass142_.YyWSMvmAcZI);
	}

	private void BLqLeQdUYDi(object sender, RoutedEventArgs e)
	{
		ActionStepsWrapper.ExpandByHighlight();
	}

	[SpecialName]
	[CompilerGenerated]
	internal SmartCollection<SubProgramNavItem> LtbLYEgb25a()
	{
		return TjILYrsRh5t;
	}

	private void jjSLejv5Z2s(SubProgram subProgram_0)
	{
		_003C_003Ec__DisplayClass147_0 _003C_003Ec__DisplayClass147_ = new _003C_003Ec__DisplayClass147_0();
		_003C_003Ec__DisplayClass147_.pH2SMJ0YCVL = subProgram_0;
		SubProgramNavItem subProgramNavItem = LtbLYEgb25a().FirstOrDefault(_003C_003Ec__DisplayClass147_.mCTSMNdugVL);
		if (subProgramNavItem == null)
		{
			SubProgramNavItem subProgramNavItem2 = new SubProgramNavItem();
			subProgramNavItem2.IsMain = false;
			subProgramNavItem2.Icon = "";
			subProgramNavItem2.Name = _003C_003Ec__DisplayClass147_.pH2SMJ0YCVL.Name;
			subProgramNavItem2.Description = _003C_003Ec__DisplayClass147_.pH2SMJ0YCVL.Description;
			subProgramNavItem2.Key = _003C_003Ec__DisplayClass147_.pH2SMJ0YCVL.Name;
			subProgramNavItem2.Uw7LYFHq947(new WeakReference<SubProgram>(_003C_003Ec__DisplayClass147_.pH2SMJ0YCVL));
			subProgramNavItem = subProgramNavItem2;
			LtbLYEgb25a().Add(subProgramNavItem);
			int num = 0;
			if (KApZprFO3YcWUGFN2FTE != null)
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
			subProgramNavItem.Uw7LYFHq947(new WeakReference<SubProgram>(_003C_003Ec__DisplayClass147_.pH2SMJ0YCVL));
		}
		HZnLYp34bkM = true;
		try
		{
			LbSubProgramNav.SelectedItem = subProgramNavItem;
		}
		finally
		{
			HZnLYp34bkM = false;
		}
	}

	private void e25LenL85SN(object sender, SelectionChangedEventArgs e)
	{
		if (!HZnLYp34bkM && LbSubProgramNav.SelectedItem is SubProgramNavItem subProgramNavItem)
		{
			if (!subProgramNavItem.IsMain)
			{
				fCrLeWhopXg(subProgramNavItem.Name);
			}
			else
			{
				CgOLeI11p5l();
			}
		}
	}

	private void lOcLe40oMsY(SubProgram subProgram_0)
	{
		_003C_003Ec__DisplayClass150_0 _003C_003Ec__DisplayClass150_ = new _003C_003Ec__DisplayClass150_0();
		_003C_003Ec__DisplayClass150_.Ab6SMCMurGf = subProgram_0;
		SubProgramNavItem subProgramNavItem = LtbLYEgb25a().FirstOrDefault(_003C_003Ec__DisplayClass150_.fp9SM0qns1T);
		if (subProgramNavItem != null)
		{
			string value = (subProgramNavItem.Name = _003C_003Ec__DisplayClass150_.Ab6SMCMurGf.Name);
			subProgramNavItem.Key = value;
			subProgramNavItem.Description = _003C_003Ec__DisplayClass150_.Ab6SMCMurGf.Description;
			LbSubProgramNav.Items.Refresh();
		}
		else
		{
			nLFLY8VGHEV.Warn("未在导航栏找到对应的子程序");
		}
	}

	private void DDPLe55Q9AK()
	{
		HZnLYp34bkM = true;
		try
		{
			LbSubProgramNav.SelectedIndex = 0;
		}
		finally
		{
			HZnLYp34bkM = false;
		}
	}

	private void AggLeDe1AaL(object sender, RoutedEventArgs e)
	{
		if ((sender as System.Windows.Controls.Button).Tag is SubProgramNavItem subProgramNavItem)
		{
			if (subProgramNavItem == LbSubProgramNav.SelectedItem)
			{
				CgOLeI11p5l();
				LtbLYEgb25a().Remove(subProgramNavItem);
			}
			else
			{
				LtbLYEgb25a().Remove(subProgramNavItem);
			}
		}
	}

	private void BtnMenu_OnMouseWheel(object sender, MouseWheelEventArgs e)
	{
		if (e.Delta > 0)
		{
			if (base.FontSize < 20.0)
			{
				base.FontSize += 0.5;
			}
		}
		else if (base.FontSize > 8.0)
		{
			base.FontSize -= 0.5;
		}
	}

	private void dN5LedyhMGu(object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == Key.Return && !string.IsNullOrEmpty(TxtFilter.Text))
		{
			AppHelper.TriggerButtonClick(BtnExpandByHightlight);
		}
	}

	[AsyncStateMachine(typeof(_003CMenuDebug_OnClick_003Ed__155))]
	private void uv9LeoLsZ3X(object sender, RoutedEventArgs e)
	{
		_003CMenuDebug_OnClick_003Ed__155 stateMachine = default(_003CMenuDebug_OnClick_003Ed__155);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CMenuDebugWithParam_OnClick_003Ed__157))]
	private void CpGLeTiU5HM(object sender, RoutedEventArgs e)
	{
		_003CMenuDebugWithParam_OnClick_003Ed__157 stateMachine = default(_003CMenuDebugWithParam_OnClick_003Ed__157);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CMenuRunWithParam_OnClick_003Ed__158))]
	private void dPDLeM23ZrX(object sender, RoutedEventArgs e)
	{
		_003CMenuRunWithParam_OnClick_003Ed__158 stateMachine = default(_003CMenuRunWithParam_OnClick_003Ed__158);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void AAwLeAZMMYx(object sender, RoutedEventArgs e)
	{
		CgOLeI11p5l();
		for (int num = LtbLYEgb25a().Count - 1; num > 0; num--)
		{
			LtbLYEgb25a().RemoveAt(num);
		}
	}

	private void QZ1LeOvFmQ0(object sender, RoutedEventArgs e)
	{
		SubProgramNavItem item = (sender as System.Windows.Controls.MenuItem).Tag as SubProgramNavItem;
		int num = LtbLYEgb25a().IndexOf(item);
		if (num >= 0)
		{
			for (int num2 = LtbLYEgb25a().Count - 1; num2 > num; num2--)
			{
				LtbLYEgb25a().RemoveAt(num2);
			}
		}
	}

	private void QDNLeFYtiTT(object sender, RoutedEventArgs e)
	{
		if ((sender as System.Windows.Controls.MenuItem).Tag is SubProgramNavItem item)
		{
			_003C_003Ec__DisplayClass161_0 _003C_003Ec__DisplayClass161_ = new _003C_003Ec__DisplayClass161_0();
			_003C_003Ec__DisplayClass161_.OUnSMEFurUO = LtbLYEgb25a().IndexOf(item);
			LtbLYEgb25a().Where(_003C_003Ec__DisplayClass161_.do8SMPVY3QC).ToList().ForEach(VJMLYNW3mru);
		}
	}

	private void TkYLeU3h4DR(object sender, RoutedEventArgs e)
	{
		if ((sender as System.Windows.Controls.MenuItem).Tag is SubProgramNavItem item)
		{
			_003C_003Ec__DisplayClass162_0 _003C_003Ec__DisplayClass162_ = new _003C_003Ec__DisplayClass162_0();
			_003C_003Ec__DisplayClass162_.yLYSM8knRLy = LtbLYEgb25a().IndexOf(item);
			LtbLYEgb25a().Where(_003C_003Ec__DisplayClass162_.pqHSMyt0sZw).ToList().ForEach(zxVLYJI8MKW);
		}
	}

	[AsyncStateMachine(typeof(_003CPasteSubProgramAsync_003Ed__163))]
	public Task PasteSubProgramAsync(SubProgram sp)
	{
		_003CPasteSubProgramAsync_003Ed__163 stateMachine = default(_003CPasteSubProgramAsync_003Ed__163);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sp = sp;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void uouLel5F0HD(object sender, RoutedEventArgs e)
	{
		List<string> list = new List<string>();
		list.Add("常规：\r\n\r\nF1：显示本提示窗；\r\nCtrl+F：定位到模块筛选框\r\nh：高亮相关的步骤\r\n\r\nCtrl+Z：撤销\r\nCtrl+Y：重做");
		list.Add("步骤列表：\r\n\r\ne：编辑选中步骤；\r\nd 或 delete：删除选中步骤；\r\n/：在选择的步骤前面快速插入注释模块；\r\nCtrl+G：将选择的步骤放入“步骤组”；\r\nCtrl+I：将选择的步骤放入“如果/否则”；\r\nCtrl+Shift+I：将选择的步骤放入“如果”；\r\nCtrl+R：将选择的步骤放入“重复”；\r\nAlt+↑：将选中的步骤上移一行；\r\nAlt+↓：将选中的步骤下移一行；\r\nCtrl+C：复制选中步骤；\r\nCtrl+V：在选择的模块后面粘贴；\r\nCtrl+X：剪切；");
		list.Add("调试与运行：\r\n\r\nF5：延迟2秒后调试运行动作（自动最小化编辑窗口）；\r\nCtrl+F5：延迟2秒后运行动作（自动最小化编辑窗口）；\r\nF6：立即调试运行动作；\r\nCtrl+F6：立即运行动作；\r\n\r\nCtrl+点击▷：立即执行动作（不等待，也不最小化编辑器窗口）；\r\nShift+点击▷：调试运行动作（等待时间并最小化编辑窗口）；\r\nCtrl+右键点击▷：立即以调试模式运行动作，不等待时间也不最小化编辑器窗口；");
		PowerKeyHintWindow powerKeyHintWindow = new PowerKeyHintWindow("动作设计窗口快捷操作提示", list, ShowWindowLocation.CenterScreen);
		powerKeyHintWindow.CloseAfterDeactivated = true;
		powerKeyHintWindow.Show();
		powerKeyHintWindow.Activate();
	}

	private void bukLeiSSYZ6(object sender, ContextMenuEventArgs e)
	{
		System.Windows.Controls.ContextMenu contextMenu = (sender as System.Windows.Controls.Button)?.ContextMenu;
		if (contextMenu == null)
		{
			return;
		}
		System.Windows.Controls.MenuItem menuItem = contextMenu.Items.OfType<System.Windows.Controls.MenuItem>().FirstOrDefault(_003C_003Ec.mBqST6D6TnW ?? (_003C_003Ec.mBqST6D6TnW = _003C_003Ec.shESTGYWHrB.AZkSTkZpvbJ));
		string text = ActionOptionsEditor.TxtContextMenuData.Text;
		if (string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (!FDCl2ZFOEAbTn1aciuNR())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (menuItem != null)
			{
				menuItem.Visibility = Visibility.Collapsed;
			}
		}
		else if (menuItem != null)
		{
			menuItem.Visibility = Visibility.Visible;
			menuItem.Items.Clear();
			IList<CommonOperationItem> list = CommonOperationItem.ParseLinesWithSubItems(text, true);
			if (!list.HasData())
			{
				menuItem.Visibility = Visibility.Collapsed;
			}
			else
			{
				ActionEditMgr.qDOtrodjUqk(contextMenu, menuItem.Items, list, 16.0, lgULY04MHfM);
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ncALYQImwZ6)
		{
			ncALYQImwZ6 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/actiondesignerwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			DesignerWindow = (ActionDesignerWindow)target;
			DesignerWindow.PreviewKeyDown += hSiLea9QP4i;
			break;
		case 2:
			ToolTab = (System.Windows.Controls.TabControl)target;
			break;
		case 3:
			ToolContent = (ContentControl)target;
			num = 0;
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				goto IL_047d;
			}
			goto IL_0481;
		case 4:
			InternalSubProgramListControl = (InternalSubProgramListControl)target;
			num = 1;
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				goto IL_047d;
			}
			goto IL_0481;
		case 5:
			GlobalSubProgramsList = (GlobalSubProgramListControl)target;
			break;
		case 6:
			LbSubProgramNav = (System.Windows.Controls.ListBox)target;
			LbSubProgramNav.SelectionChanged += e25LenL85SN;
			break;
		default:
			ncALYQImwZ6 = true;
			break;
		case 12:
			GridMain = (Grid)target;
			break;
		case 13:
			TxtFilter = (System.Windows.Controls.TextBox)target;
			TxtFilter.KeyDown += dN5LedyhMGu;
			TxtFilter.TextChanged += cdZLesnOPgS;
			break;
		case 14:
			BtnExpandByHightlight = (System.Windows.Controls.Button)target;
			BtnExpandByHightlight.Click += BLqLeQdUYDi;
			break;
		case 15:
			((System.Windows.Controls.Button)target).Click += JlOLeqx4Mkh;
			break;
		case 16:
			((System.Windows.Controls.Button)target).Click += uouLel5F0HD;
			break;
		case 17:
			BtnRun = (System.Windows.Controls.Button)target;
			BtnRun.Click += PKMLe6xsFNZ;
			num = 2;
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				goto IL_047d;
			}
			goto IL_0481;
		case 18:
			MenuDebug = (System.Windows.Controls.MenuItem)target;
			MenuDebug.Click += uv9LeoLsZ3X;
			break;
		case 19:
			MenuDebugWithParam = (System.Windows.Controls.MenuItem)target;
			goto IL_04d4;
		case 20:
			MenuDebugWithContextMenuParam = (System.Windows.Controls.MenuItem)target;
			break;
		case 21:
			MenuRunWithParam = (System.Windows.Controls.MenuItem)target;
			MenuRunWithParam.Click += dPDLeM23ZrX;
			break;
		case 22:
			BtnUndo = (System.Windows.Controls.Button)target;
			break;
		case 23:
			BtnRedo = (System.Windows.Controls.Button)target;
			break;
		case 24:
			BtnSaveVersion = (System.Windows.Controls.Button)target;
			BtnSaveVersion.Click += sHgLe7sAQiD;
			break;
		case 25:
			BtnLoadHistoryVersion = (System.Windows.Controls.Button)target;
			BtnLoadHistoryVersion.Click += T6KLeRoG8TW;
			break;
		case 26:
			BtnNote = (System.Windows.Controls.Button)target;
			BtnNote.Click += E6fLexZZcp9;
			break;
		case 27:
			BtnMenu = (DropDownButton)target;
			break;
		case 28:
			MainContextMenu1 = (System.Windows.Controls.ContextMenu)target;
			break;
		case 29:
			MenuExport = (System.Windows.Controls.MenuItem)target;
			MenuExport.Click += DvbLeZAqXnF;
			break;
		case 30:
			MenuImport = (System.Windows.Controls.MenuItem)target;
			MenuImport.Click += eeqLe9psn1H;
			break;
		case 31:
			MenuClearAction = (System.Windows.Controls.MenuItem)target;
			MenuClearAction.Click += q61Lehyi9mj;
			break;
		case 32:
			MenuFloatAction = (System.Windows.Controls.MenuItem)target;
			MenuFloatAction.Click += Ed1LeeocQjM;
			break;
		case 33:
			MenuExpandAll = (System.Windows.Controls.MenuItem)target;
			MenuExpandAll.Click += kAPLe1UXRa3;
			break;
		case 34:
			MenuCollapseAll = (System.Windows.Controls.MenuItem)target;
			MenuCollapseAll.Click += OBVLebASgj6;
			break;
		case 35:
			ActionStepsWrapper = (ActionStepsWrapper)target;
			break;
		case 36:
			VariableListControl = (VariableListControl)target;
			break;
		case 37:
			UiEditor = (ActionUIEditor)target;
			break;
		case 38:
			TabOptions = (System.Windows.Controls.TabItem)target;
			break;
		case 39:
			ActionOptionsEditor = (ActionOptionsControl)target;
			break;
		case 40:
			TabAssociations = (System.Windows.Controls.TabItem)target;
			num = 4;
			if (KApZprFO3YcWUGFN2FTE != null)
			{
				goto IL_047d;
			}
			goto IL_0481;
		case 41:
			ActionAssociationsEditor = (ActionAssociationControl)target;
			break;
		case 42:
			TabSubProgram = (System.Windows.Controls.TabItem)target;
			break;
		case 43:
			TxtSummaryExpression = (TextBoxWithToolsControl)target;
			break;
		case 44:
			BtnSave = (System.Windows.Controls.Button)target;
			BtnSave.Click += s68LeCPPklA;
			break;
		case 45:
			BtnCancel = (System.Windows.Controls.Button)target;
			BtnCancel.Click += PZMLe0ZAlPN;
			break;
		case 46:
			{
				SubProgramEditor = (SubProgramEditor)target;
				break;
			}
			IL_047d:
			num = num2;
			goto IL_0481;
			IL_0481:
			switch (num)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				BtnRun.ContextMenuOpening += bukLeiSSYZ6;
				goto case 3;
			case 3:
				BtnRun.PreviewMouseRightButtonDown += ovTLeXO3cZn;
				return;
			case 4:
				return;
			case 5:
				break;
			case 6:
				return;
			}
			goto IL_04d4;
			IL_04d4:
			MenuDebugWithParam.Click += CpGLeTiU5HM;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 7:
			((System.Windows.Controls.MenuItem)target).Click += QDNLeFYtiTT;
			break;
		case 8:
			((System.Windows.Controls.MenuItem)target).Click += TkYLeU3h4DR;
			break;
		case 9:
			((System.Windows.Controls.MenuItem)target).Click += QZ1LeOvFmQ0;
			break;
		case 10:
			((System.Windows.Controls.MenuItem)target).Click += AAwLeAZMMYx;
			break;
		case 11:
			((System.Windows.Controls.Button)target).Click += AggLeDe1AaL;
			break;
		}
	}

	static ActionDesignerWindow()
	{
		nLFLY8VGHEV = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		ActionProperty = DependencyProperty.RegisterAttached("Action", typeof(global::Quicker.Domain.Actions.X.XAction), typeof(ActionDesignerWindow), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
	}

	[CompilerGenerated]
	private string B7lLe3OAAaD(string string_2)
	{
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
		_003C_003Ec__DisplayClass63_.WQwSMsbI2Hp = string_2;
		if (Action.SubPrograms.Any(_003C_003Ec__DisplayClass63_.ugRSMGiNsA5))
		{
			return "此名称已存在。";
		}
		return null;
	}

	[CompilerGenerated]
	private void fPLLefS7uRl(object object_0)
	{
		JPcLhiV5eLj();
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CInitializeCommands_003Eb__78_0_003Ed))]
	private void rRcLezdZ92i(object sender, ExecutedRoutedEventArgs e)
	{
		_003C_003CInitializeCommands_003Eb__78_0_003Ed stateMachine = default(_003C_003CInitializeCommands_003Eb__78_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003CInitializeCommands_003Eb__78_1_003Ed))]
	[CompilerGenerated]
	private void mrdLYwQSkmw(object sender, ExecutedRoutedEventArgs e)
	{
		_003C_003CInitializeCommands_003Eb__78_1_003Ed stateMachine = default(_003C_003CInitializeCommands_003Eb__78_1_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003CInitializeCommands_003Eb__78_2_003Ed))]
	[CompilerGenerated]
	private void B7bLYtOU6f1(object sender, ExecutedRoutedEventArgs e)
	{
		_003C_003CInitializeCommands_003Eb__78_2_003Ed stateMachine = default(_003C_003CInitializeCommands_003Eb__78_2_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003CInitializeCommands_003Eb__78_3_003Ed))]
	[CompilerGenerated]
	private void Rb9LYgQhRaP(object sender, ExecutedRoutedEventArgs e)
	{
		_003C_003CInitializeCommands_003Eb__78_3_003Ed stateMachine = default(_003C_003CInitializeCommands_003Eb__78_3_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003CCbSearchOnExecuted_003Eb__83_0_003Ed))]
	[CompilerGenerated]
	private Task xlkLYLRVVki()
	{
		_003C_003CCbSearchOnExecuted_003Eb__83_0_003Ed stateMachine = default(_003C_003CCbSearchOnExecuted_003Eb__83_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private void PI2LYvhycF4()
	{
		TheToolbox.FocusSearch();
	}

	[CompilerGenerated]
	private void M94LYS19X8j(object object_0)
	{
		base.Dispatcher.InvokeAsync(bmHLY2PEaI8);
	}

	[CompilerGenerated]
	private void bmHLY2PEaI8()
	{
		ActionStepsWrapper.DoFilter(TxtFilter.Text);
	}

	[CompilerGenerated]
	private string akPLYu6XMOu(string string_2)
	{
		_003C_003Ec__DisplayClass135_1 _003C_003Ec__DisplayClass135_ = new _003C_003Ec__DisplayClass135_1();
		_003C_003Ec__DisplayClass135_.PEnSTiyUfXA = string_2;
		if (!Action.SubPrograms.Any(_003C_003Ec__DisplayClass135_.ypkSTlQlmlU))
		{
			return null;
		}
		return "此名称已存在。";
	}

	[CompilerGenerated]
	private void VJMLYNW3mru(SubProgramNavItem subProgramNavItem_0)
	{
		LtbLYEgb25a().Remove(subProgramNavItem_0);
	}

	[CompilerGenerated]
	private void zxVLYJI8MKW(SubProgramNavItem subProgramNavItem_0)
	{
		LtbLYEgb25a().Remove(subProgramNavItem_0);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CBtnRun_OnContextMenuOpening_003Eb__165_1_003Ed))]
	private void lgULY04MHfM(CommonOperationItem commonOperationItem_0, object object_0, System.Windows.Controls.ContextMenu contextMenu_0)
	{
		_003C_003CBtnRun_OnContextMenuOpening_003Eb__165_1_003Ed stateMachine = default(_003C_003CBtnRun_OnContextMenuOpening_003Eb__165_1_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = commonOperationItem_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	internal static bool FDCl2ZFOEAbTn1aciuNR()
	{
		return KApZprFO3YcWUGFN2FTE == null;
	}
}
