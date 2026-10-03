using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CW;

public static class IDisposableExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec dVuvykG1biu;

		public static Func<IDisposable, bool> v9hvyGNXhNb;

		public static Action<IDisposable> ldFvysN5Fvh;

		internal static _003C_003Ec YRMoxhcE9vwvPxjFBbyK;

		static _003C_003Ec()
		{
			dVuvykG1biu = new _003C_003Ec();
		}

		internal bool Kv3vyIWAkIa(IDisposable _)
		{
			return _ != null;
		}

		internal void zuZvyWKwlQK(IDisposable _)
		{
			_.Dispose();
		}

		internal static void zI9sJpcEo48QYEUVyP5Y()
		{
		}

		internal static bool krfNmUcEL8H4KknQdIg0()
		{
			return YRMoxhcE9vwvPxjFBbyK == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__1<T>
	{
		public static readonly _003C_003Ec__1<T> _003C_003E9;

		public static Func<T, bool> _003C_003E9__1_0;

		public static Func<T, bool> _003C_003E9__1_1;

		public static Action<T> _003C_003E9__1_2;

		private static object Mf9AbjcEfmSfINmR8rg7;

		static _003C_003Ec__1()
		{
			_003C_003E9 = new _003C_003Ec__1<T>();
		}

		internal bool UttvyHxxjkh(T _)
		{
			return _ != null;
		}

		internal bool Bsvvy1pMmBf(T _)
		{
			dynamic val = _;
			return val.IsValueCreated;
		}

		internal void PTfvyb0n6bk(T _)
		{
			dynamic val = _;
			val.Value.Dispose();
		}

		internal static bool Dmlw3McEb8jf01GrKQGs()
		{
			return Mf9AbjcEfmSfINmR8rg7 == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003Eo__1<T>
	{
		public static CallSite<Func<CallSite, object, object>> _003C_003Ep__0;

		public static CallSite<Func<CallSite, object, bool>> _003C_003Ep__1;

		public static CallSite<Func<CallSite, object, object>> _003C_003Ep__2;

		public static CallSite<Action<CallSite, object>> _003C_003Ep__3;
	}

	public static void Dispose(this IEnumerable<IDisposable> source)
	{
		source.ThrowIfNull("source");
		source.Where(_003C_003Ec.v9hvyGNXhNb ?? (_003C_003Ec.v9hvyGNXhNb = _003C_003Ec.dVuvykG1biu.Kv3vyIWAkIa)).ForEach(_003C_003Ec.ldFvysN5Fvh ?? (_003C_003Ec.ldFvysN5Fvh = _003C_003Ec.dVuvykG1biu.zuZvyWKwlQK));
	}

	public static void DisposeLazy<T>(this IEnumerable<T> source)
	{
		source.ThrowIfNull("source");
		source.Where(_003C_003Ec__1<T>._003C_003E9__1_0 ?? (_003C_003Ec__1<T>._003C_003E9__1_0 = _003C_003Ec__1<T>._003C_003E9.UttvyHxxjkh)).Where(_003C_003Ec__1<T>._003C_003E9__1_1 ?? (_003C_003Ec__1<T>._003C_003E9__1_1 = _003C_003Ec__1<T>._003C_003E9.Bsvvy1pMmBf)).ForEach(_003C_003Ec__1<T>._003C_003E9__1_2 ?? (_003C_003Ec__1<T>._003C_003E9__1_2 = _003C_003Ec__1<T>._003C_003E9.PTfvyb0n6bk));
	}

	static IDisposableExtensions()
	{
	}

	internal static void ECKX6E34I7XmSenY4Y4()
	{
	}
}
