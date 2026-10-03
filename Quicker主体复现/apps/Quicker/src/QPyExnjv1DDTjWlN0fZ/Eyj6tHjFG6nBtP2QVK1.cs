using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Threading;
using Quicker.Utilities.UI;

namespace QPyExnjv1DDTjWlN0fZ;

internal class Eyj6tHjFG6nBtP2QVK1
{
	private static Eyj6tHjFG6nBtP2QVK1 jdttkN3SGhK;

	private static readonly object q77tkJu2LSM;

	private Dispatcher Xu6tk0F13OS;

	internal static Eyj6tHjFG6nBtP2QVK1 cNwP5fQJHUhucRrNwiLG;

	private Eyj6tHjFG6nBtP2QVK1()
	{
		Xu6tk0F13OS = DispatcherBuilder.Build("SecondaryDispatcher");
	}

	[SpecialName]
	public static Eyj6tHjFG6nBtP2QVK1 EGItkvvs4RQ()
	{
		if (jdttkN3SGhK == null)
		{
			lock (q77tkJu2LSM)
			{
				if (jdttkN3SGhK == null)
				{
					jdttkN3SGhK = new Eyj6tHjFG6nBtP2QVK1();
				}
			}
		}
		return jdttkN3SGhK;
	}

	[SpecialName]
	private Dispatcher Thttk2JQyKC()
	{
		return Xu6tk0F13OS;
	}

	public void Invoke(Action action)
	{
		if (Xu6tk0F13OS.CheckAccess())
		{
			action();
		}
		else
		{
			Xu6tk0F13OS.Invoke(action);
		}
	}

	public DispatcherOperation z1EtktydB9E(Action action_0)
	{
		return Xu6tk0F13OS.InvokeAsync(action_0);
	}

	public DispatcherOperation dIPtkgBLvYb(Action action_0, DispatcherPriority dispatcherPriority_0)
	{
		return Xu6tk0F13OS.InvokeAsync(action_0, dispatcherPriority_0);
	}

	public Task<DRXmSdjN78Fc04HGhaD> GNGtkLxOIk7<DRXmSdjN78Fc04HGhaD>(Func<DRXmSdjN78Fc04HGhaD> func_0)
	{
		return Xu6tk0F13OS.InvokeAsync(func_0).Task;
	}

	static Eyj6tHjFG6nBtP2QVK1()
	{
		q77tkJu2LSM = new object();
	}

	internal static bool H3phnoQJzI2TUJ5ceJSJ()
	{
		return cNwP5fQJHUhucRrNwiLG == null;
	}

	internal static void GwuAyVQkQ55k72PouLmJ()
	{
	}
}
