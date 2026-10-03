using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CW;

public class ResetLazy<T> : ILazy<T>, ILazy
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<T> _003C0_003E__CreateInstance;
	}

	private Func<T> KFZ0mNsA0L;

	private LazyThreadSafetyMode aPo0KPA9I3;

	private Lazy<T> CLF0xePd5w;

	internal static object v1EJC8Edc1swB6x7g0F;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public T Value => CLF0xePd5w.Value;

	public bool IsValueCreated => CLF0xePd5w.IsValueCreated;

	object ILazy.Value => CLF0xePd5w.Value;

	public ResetLazy()
		: this(LazyThreadSafetyMode.ExecutionAndPublication)
	{
	}

	public ResetLazy(Func<T> valueFactory)
		: this(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication)
	{
	}

	public ResetLazy(bool isThreadSafe)
		: this(_003C_003EO._003C0_003E__CreateInstance ?? (_003C_003EO._003C0_003E__CreateInstance = Activator.CreateInstance<T>), isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
	{
	}

	public ResetLazy(Func<T> valueFactory, bool isThreadSafe)
		: this(valueFactory, isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
	{
	}

	public ResetLazy(LazyThreadSafetyMode mode)
		: this(_003C_003EO._003C0_003E__CreateInstance ?? (_003C_003EO._003C0_003E__CreateInstance = Activator.CreateInstance<T>), mode)
	{
	}

	public ResetLazy(Func<T> valueFactory, LazyThreadSafetyMode mode)
	{
		KFZ0mNsA0L = valueFactory;
		aPo0KPA9I3 = mode;
		N070XCo9IT();
	}

	private void N070XCo9IT()
	{
		CLF0xePd5w = new Lazy<T>(KFZ0mNsA0L, aPo0KPA9I3);
	}

	public void Reset()
	{
		if (CLF0xePd5w.IsValueCreated)
		{
			if (CLF0xePd5w.Value is IDisposable disposable)
			{
				disposable.Dispose();
			}
			N070XCo9IT();
		}
	}

	public override string ToString()
	{
		return CLF0xePd5w.ToString();
	}

	internal static bool gfIAJJEORh0OQb6tJLP()
	{
		return v1EJC8Edc1swB6x7g0F == null;
	}
}
