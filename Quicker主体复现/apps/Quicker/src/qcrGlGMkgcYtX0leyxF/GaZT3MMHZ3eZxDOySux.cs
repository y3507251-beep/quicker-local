using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using log4net;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Utilities.UI;

namespace qcrGlGMkgcYtX0leyxF;

internal static class GaZT3MMHZ3eZxDOySux
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public Action Xl12gBP5aG8;

		public TaskCompletionSource<object> KQ92gQO5GB2;

		internal static _003C_003Ec__DisplayClass1_0 plhif7yD9Q6Y4y7nGbiu;

		internal void E852gpeGSL1()
		{
			try
			{
				Xl12gBP5aG8();
				KQ92gQO5GB2.SetResult(null);
			}
			catch (Exception exception)
			{
				KQ92gQO5GB2.SetException(exception);
			}
		}

		internal static bool FLXnYEyDLNgM52Lvm76b()
		{
			return plhif7yD9Q6Y4y7nGbiu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0<TResult>
	{
		public TaskCompletionSource<TResult> source;

		public Func<TResult> function;

		private static object TVknaiyDfdN7lBt58d2U;

		internal void IH32gj3AQsQ()
		{
			try
			{
				source.SetResult(function());
			}
			catch (Exception exception)
			{
				source.SetException(exception);
			}
		}

		internal static bool K9gab8yDbDWC2mOxhACN()
		{
			return TVknaiyDfdN7lBt58d2U == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public Action RCu2g4gTZ8W;

		internal static _003C_003Ec__DisplayClass3_0 NaPxTKyDisrgvmbPXtj6;

		internal void fxr2gnV8sYw()
		{
			RCu2g4gTZ8W();
		}

		internal static bool RBWSB6yDlYNNNAP6qcvY()
		{
			return NaPxTKyDisrgvmbPXtj6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public Action zkP2gDIOBC7;

		public TaskCompletionSource<object> SLb2gd5hnmD;

		private static _003C_003Ec__DisplayClass7_0 Stsk6fyD58CL1p7Mmkyf;

		internal void pV92g5P9Gxy()
		{
			try
			{
				zkP2gDIOBC7();
				SLb2gd5hnmD.SetResult(null);
			}
			catch (Exception exception)
			{
				SLb2gd5hnmD.SetException(exception);
			}
		}

		internal static bool o5OofFyDY2vRxctVInAV()
		{
			return Stsk6fyD58CL1p7Mmkyf == null;
		}
	}

	private static readonly ILog AqALMf68bE7;

	internal static object RtXlJkFgWDsQnlDRH2al;

	public static Task UmrLMAuavWB(Action action_0)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.Xl12gBP5aG8 = action_0;
		_003C_003Ec__DisplayClass1_.KQ92gQO5GB2 = new TaskCompletionSource<object>();
		Thread thread = new Thread(_003C_003Ec__DisplayClass1_.E852gpeGSL1);
		thread.IsBackground = true;
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		return _003C_003Ec__DisplayClass1_.KQ92gQO5GB2.Task;
	}

	public static Task<NA3Lr0MhuHuVJoRwFnK> CrALMOVaWOa<NA3Lr0MhuHuVJoRwFnK>(Func<NA3Lr0MhuHuVJoRwFnK> func_0)
	{
		_003C_003Ec__DisplayClass2_0<NA3Lr0MhuHuVJoRwFnK> _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0<NA3Lr0MhuHuVJoRwFnK>();
		_003C_003Ec__DisplayClass2_.function = func_0;
		_003C_003Ec__DisplayClass2_.source = new TaskCompletionSource<NA3Lr0MhuHuVJoRwFnK>();
		Thread thread = new Thread(_003C_003Ec__DisplayClass2_.IH32gj3AQsQ);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		return _003C_003Ec__DisplayClass2_.source.Task;
	}

	public static void x1VLMFjodna(Action action_0, bool bool_0, string string_0 = null)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.RCu2g4gTZ8W = action_0;
		if (!bool_0 && Thread.CurrentThread.GetApartmentState() == ApartmentState.STA)
		{
			_003C_003Ec__DisplayClass3_.RCu2g4gTZ8W();
			return;
		}
		Thread thread = new Thread(_003C_003Ec__DisplayClass3_.fxr2gnV8sYw);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Name = string_0;
		thread.Start();
		thread.Join();
	}

	public static void QcLLMUD9rhr(Action action_0, string string_0)
	{
		Dispatcher dispatcher = DispatcherBuilder.Build(string_0);
		dispatcher.Invoke(action_0);
		dispatcher.BeginInvokeShutdown(DispatcherPriority.Normal);
	}

	public static void sL2LMlMVkZs(Action action_0)
	{
		Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(action_0);
	}

	public static void P3MLMiy0jjJ()
	{
	}

	public static Task ReZLM3wimyT(Action action_0, string string_0 = null)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.zkP2gDIOBC7 = action_0;
		_003C_003Ec__DisplayClass7_.SLb2gd5hnmD = new TaskCompletionSource<object>();
		Thread thread = new Thread(_003C_003Ec__DisplayClass7_.pV92g5P9Gxy)
		{
			IsBackground = true
		};
		if (thread.Name == null && string_0 != null)
		{
			thread.Name = string_0;
		}
		thread.Start();
		return _003C_003Ec__DisplayClass7_.SLb2gd5hnmD.Task;
	}

	static GaZT3MMHZ3eZxDOySux()
	{
		AqALMf68bE7 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool uFps67Fgy2N6UiLy4ePY()
	{
		return RtXlJkFgWDsQnlDRH2al == null;
	}
}
