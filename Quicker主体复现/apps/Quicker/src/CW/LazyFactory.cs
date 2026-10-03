using System;
using System.Threading;

namespace CW;

public static class LazyFactory
{
	public static ILazy<T> Create<T>()
	{
		return new ResetLazy<T>();
	}

	public static ILazy<T> Create<T>(Func<T> valueFactory)
	{
		return new ResetLazy<T>(valueFactory);
	}

	public static ILazy<T> Create<T>(bool isThreadSafe)
	{
		return new ResetLazy<T>(isThreadSafe);
	}

	public static ILazy<T> Create<T>(Func<T> valueFactory, bool isThreadSafe)
	{
		return new ResetLazy<T>(valueFactory, isThreadSafe);
	}

	public static ILazy<T> Create<T>(LazyThreadSafetyMode mode)
	{
		return new ResetLazy<T>(mode);
	}

	public static ILazy<T> Create<T>(Func<T> valueFactory, LazyThreadSafetyMode mode)
	{
		return new ResetLazy<T>(valueFactory, mode);
	}

	static LazyFactory()
	{
	}

	internal static void Jgb3aNEpCuyvP2Je2AV()
	{
	}
}
