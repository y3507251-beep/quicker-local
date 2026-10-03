using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CW;

public class DisposableLazy<T> : ResetLazy<T>, IDisposable where T : IDisposable
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<T> _003C0_003E__CreateInstance;
	}

	private static object EkpY6g38aPFuSZgOwdj;

	public DisposableLazy()
		: base(LazyThreadSafetyMode.ExecutionAndPublication)
	{
	}

	public DisposableLazy(Func<T> valueFactory)
		: base(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication)
	{
	}

	public DisposableLazy(bool isThreadSafe)
		: base(_003C_003EO._003C0_003E__CreateInstance ?? (_003C_003EO._003C0_003E__CreateInstance = Activator.CreateInstance<T>), isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
	{
	}

	public DisposableLazy(Func<T> valueFactory, bool isThreadSafe)
		: base(valueFactory, isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
	{
	}

	public DisposableLazy(LazyThreadSafetyMode mode)
		: base(_003C_003EO._003C0_003E__CreateInstance ?? (_003C_003EO._003C0_003E__CreateInstance = Activator.CreateInstance<T>), mode)
	{
	}

	public DisposableLazy(Func<T> valueFactory, LazyThreadSafetyMode mode)
		: base(valueFactory, mode)
	{
	}

	public void Dispose()
	{
		if (base.IsValueCreated)
		{
			base.Value.Dispose();
		}
		GC.SuppressFinalize(this);
	}

	~DisposableLazy()
	{
		Dispose();
	}

	internal static bool i7qKrA3R6xyUg69DN4B()
	{
		return EkpY6g38aPFuSZgOwdj == null;
	}
}
