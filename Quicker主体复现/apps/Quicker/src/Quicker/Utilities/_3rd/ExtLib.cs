using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dacb8Bf4APoDBO4mOND;
using hRtxFbf8C9FUgPbnFhr;
using NWgFv1fei1X1gnrcJmi;
using QRWYUofkLNlbGpuahna;
using Quicker.Utilities.Ext.Exceptions;
using Quicker.Utilities.Ext.Types;
using udMOyRfpKdaiiFE2m0y;
using VLuB5IfOZTeMSu1JRJg;
using YjG3wWfcqfmIAf5IIew;

namespace Quicker.Utilities._3rd;

public static class ExtLib
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<char, bool> SWv2N4PFcnx;

		public static Func<char, bool> bTv2N5TLjrQ;

		public static Func<char, bool> M142NDbGhaq;

		public static Func<string, bool> Jeh2NdQPDji;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec fSN2NAJP35L;

		public static Func<XAttribute, bool> qWX2NO3pkAP;

		public static Func<XAttribute, bool> Xc72NFWFa4r;

		public static Func<XAttribute, XAttribute> xWV2NUYb5o0;

		internal static _003C_003Ec SraINQyBt3AQAd9j6eDe;

		static _003C_003Ec()
		{
			fSN2NAJP35L = new _003C_003Ec();
		}

		internal bool iaP2NovyTCP(XAttribute a)
		{
			return !a.IsNamespaceDeclaration;
		}

		internal bool MVO2NToKPeY(XAttribute a)
		{
			if (a.Name.Namespace != XNamespace.Xml)
			{
				return a.Name.Namespace != XNamespace.Xmlns;
			}
			return false;
		}

		internal XAttribute g3B2NMh1kAQ(XAttribute a)
		{
			return new XAttribute(XNamespace.None.GetName(a.Name.LocalName), a.Value);
		}

		internal static bool FLGNYEyBSJ1xtnOYr4tr()
		{
			return SraINQyBt3AQAd9j6eDe == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__7<T>
	{
		public static readonly _003C_003Ec__7<T> _003C_003E9;

		public static Func<T, int> _003C_003E9__7_0;

		public static Func<int, int> _003C_003E9__7_1;

		private static object T3232RyBs0NC0CTX2de6;

		static _003C_003Ec__7()
		{
			_003C_003E9 = new _003C_003Ec__7<T>();
		}

		internal int DYR2NlnY8Oo(T i)
		{
			return i?.GetHashCode() ?? 0;
		}

		internal int asA2NiAQh9f(int i)
		{
			return i;
		}

		internal static bool IuPkmbyBCwVAIpWuDl0S()
		{
			return T3232RyBs0NC0CTX2de6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0<T>
	{
		public IList<T> list;

		internal static object qQgyA6yB4Tw3DH0HIpMJ;

		internal void pcL2N3moKan()
		{
			list.RemoveAt(0);
		}

		internal void xXM2Nfdc6CU()
		{
			list.RemoveAt(list.Count - 1);
		}

		internal void yZX2NzgEDqn()
		{
			list.RemoveAt(jxKc3JfHvFtxrsKKy81.Random.Next(0, list.Count));
		}

		internal static bool UfPi0cyBh3OMXoAklJ6i()
		{
			return qQgyA6yB4Tw3DH0HIpMJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0<T>
	{
		public IEqualityComparer<T> comparer;

		public T obj;

		private static object O37g1SyBzPNGiTbYmiAL;

		internal bool HKO2JwcfmLk(T other)
		{
			return comparer.Equals(obj, other);
		}

		internal static bool K6tjGbyvVspXcGX2Spjg()
		{
			return O37g1SyBzPNGiTbYmiAL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0<T, TKey>
	{
		public IEqualityComparer<TKey> keyComparer;

		public Func<T, TKey> keySelector;

		private static object FZ9WxUyvFq82GPwPq6VJ;

		internal bool RMm2JtEnCTo(T x, T y)
		{
			return keyComparer.Equals(keySelector(x), keySelector(y));
		}

		internal int m2Q2Jg9T94p(T obj)
		{
			return keySelector(obj).GetHashCode();
		}

		internal static bool HAw36UyvcC39R1LfKsaC()
		{
			return FZ9WxUyvFq82GPwPq6VJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0<T>
	{
		public IEqualityComparer<T> comparer;

		public T value;

		private static object vMsFiOyvyoH5Rqf2Du06;

		internal bool mga2JLCD7UG(T i)
		{
			return !comparer.Equals(i, value);
		}

		internal static bool MY0bIOyvplAwUvAWX2kn()
		{
			return vMsFiOyvyoH5Rqf2Du06 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass94_0<T>
	{
		public Action<T> action;

		private static object qR349syv26jEc3827d3y;

		internal Task hJ92Jv2ev0N(T i)
		{
			return Task.Run((Action)new _003C_003Ec__DisplayClass94_1<T>
			{
				CS_0024_003C_003E8__locals1 = this,
				i = i
			}.aP42JSiPOGD);
		}

		internal static bool zRqjddyvAyYx79VX1Z9N()
		{
			return qR349syv26jEc3827d3y == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass94_1<T>
	{
		public T i;

		public _003C_003Ec__DisplayClass94_0<T> CS_0024_003C_003E8__locals1;

		private static object SKKeAkyveer2CoqckfsX;

		internal void aP42JSiPOGD()
		{
			CS_0024_003C_003E8__locals1.action(i);
		}

		internal static bool nNj5EpyvjCZfpuSsKaKM()
		{
			return SKKeAkyveer2CoqckfsX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass96_0<T, TResult>
	{
		public Func<T, TResult> func;

		private static object JLJpaRyv3LY8jl90PVHm;

		internal Task<TResult> N6b2J2rPhn7(T i)
		{
			return Task.Run((Func<TResult>)new _003C_003Ec__DisplayClass96_1<T, TResult>
			{
				CS_0024_003C_003E8__locals1 = this,
				i = i
			}.McK2Ju6vLIG);
		}

		internal static bool mE5r3VyvEDRhti2CkRxD()
		{
			return JLJpaRyv3LY8jl90PVHm == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass96_1<T, TResult>
	{
		public T i;

		public _003C_003Ec__DisplayClass96_0<T, TResult> CS_0024_003C_003E8__locals1;

		internal static object BxfsIhyv0N399iHtetnb;

		internal TResult McK2Ju6vLIG()
		{
			return CS_0024_003C_003E8__locals1.func(i);
		}

		internal static bool BEL1hJyv1vB3wpyE0bEu()
		{
			return BxfsIhyv0N399iHtetnb == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParallelForEachAsync_003Ed__93<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IEnumerable<T> enumerable;

		public Func<T, Task> task;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (enumerable == null)
					{
						throw new ArgumentNullException("enumerable");
					}
					if (task == null)
					{
						throw new ArgumentNullException("task");
					}
					awaiter = Task.WhenAll(enumerable.Select(task)).ConfigureAwait(false).GetAwaiter();
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParallelSelectAsync_003Ed__95<T, TResult> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IEnumerable<TResult>> _003C_003Et__builder;

		public IEnumerable<T> enumerable;

		public Func<T, Task<TResult>> task;

		private ConfiguredTaskAwaitable<TResult[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IEnumerable<TResult> result;
			try
			{
				ConfiguredTaskAwaitable<TResult[]>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (enumerable == null)
					{
						throw new ArgumentNullException("enumerable");
					}
					if (task == null)
					{
						throw new ArgumentNullException("task");
					}
					awaiter = Task.WhenAll(enumerable.Select(task)).ConfigureAwait(false).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<TResult[]>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
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
	}

	internal static object EhGZpRFm00VswrqU3PnH;

	[ELnurNfnARP5HMHMimc("enumerable:null => false")]
	[cT5o3WfLNbx9gFBsqxP]
	public static bool NotNullAndAny<T>([ms79yjfhVOxH0jjfcQZ] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, bool> predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return enumerable?.Any(predicate) ?? false;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[ELnurNfnARP5HMHMimc("enumerable:null => false")]
	public static bool NotNullAndAny<T>([ms79yjfhVOxH0jjfcQZ] this IEnumerable<T> enumerable)
	{
		return enumerable?.Any() ?? false;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static T GetRandom<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		IList<T> list = (enumerable as IList<T>) ?? enumerable.ToArray();
		if (!list.Any())
		{
			throw new Exception("No items in enumerable");
		}
		if (list.Count > 1)
		{
			return list[jxKc3JfHvFtxrsKKy81.Random.Next(0, list.Count)];
		}
		return list.First();
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static T GetRandomOrDefault<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, T defaultValue = default(T))
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		IList<T> list = (enumerable as IList<T>) ?? enumerable.ToArray();
		if (!list.Any())
		{
			return defaultValue;
		}
		return list.GetRandom();
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static IEnumerable<T> EmptyIfNull<T>([ms79yjfhVOxH0jjfcQZ] this IEnumerable<T> enumerable)
	{
		return enumerable ?? Enumerable.Empty<T>();
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static IEnumerable<T> Distinct<T, TKey>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, TKey> keySelector, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<TKey> keyComparer)
	{
		_003C_003Ec__DisplayClass5_0<T, TKey> _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0<T, TKey>();
		_003C_003Ec__DisplayClass5_.keyComparer = keyComparer;
		_003C_003Ec__DisplayClass5_.keySelector = keySelector;
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (_003C_003Ec__DisplayClass5_.keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		if (_003C_003Ec__DisplayClass5_.keyComparer == null)
		{
			throw new ArgumentNullException("keyComparer");
		}
		return enumerable.Distinct(new DelegateEqualityComparer<T>(_003C_003Ec__DisplayClass5_.RMm2JtEnCTo, _003C_003Ec__DisplayClass5_.m2Q2Jg9T94p));
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static IEnumerable<TSource> Distinct<TSource, TKey>([vfInGIfbsoYlQBMjtrM] this IEnumerable<TSource> enumerable, [vfInGIfbsoYlQBMjtrM] Func<TSource, TKey> keySelector)
	{
		return enumerable.Distinct(keySelector, EqualityComparer<TKey>.Default);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int SequenceHashCode<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, bool ignoreOrder = false)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		IEnumerable<int> enumerable2 = enumerable.Select(_003C_003Ec__7<T>._003C_003E9__7_0 ?? (_003C_003Ec__7<T>._003C_003E9__7_0 = _003C_003Ec__7<T>._003C_003E9.DYR2NlnY8Oo));
		if (ignoreOrder)
		{
			enumerable2 = enumerable2.OrderBy(_003C_003Ec__7<T>._003C_003E9__7_1 ?? (_003C_003Ec__7<T>._003C_003E9__7_1 = _003C_003Ec__7<T>._003C_003E9.asA2NiAQh9f));
		}
		int num = 19;
		foreach (int item in enumerable2)
		{
			num = num * 31 + item;
		}
		return num;
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static IEnumerable<T> Except<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, T value, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<T> comparer)
	{
		_003C_003Ec__DisplayClass8_0<T> _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0<T>();
		_003C_003Ec__DisplayClass8_.comparer = comparer;
		_003C_003Ec__DisplayClass8_.value = value;
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (_003C_003Ec__DisplayClass8_.comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		return enumerable.Where(_003C_003Ec__DisplayClass8_.mga2JLCD7UG);
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static IEnumerable<T> Except<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, T value)
	{
		return enumerable.Except(value, EqualityComparer<T>.Default);
	}

	[vfInGIfbsoYlQBMjtrM]
	[Mo0Y3Lf1VtlbG7qst0Z]
	[cT5o3WfLNbx9gFBsqxP]
	public static IEnumerable<T> ExceptDefault<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable)
	{
		return enumerable.Except(default(T));
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static IEnumerable<T> TakeLast<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, int count)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count != 0)
		{
			return enumerable.Reverse().Take(count).Reverse();
		}
		return Enumerable.Empty<T>();
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static IEnumerable<T> SkipLast<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, int count)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count != 0)
		{
			return enumerable.Reverse().Skip(count).Reverse();
		}
		return enumerable;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static IEnumerable<T> TakeLastWhile<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, bool> predicate)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return enumerable.Reverse().TakeWhile(predicate).Reverse();
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static IEnumerable<T> SkipLastWhile<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, bool> predicate)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return enumerable.Reverse().SkipWhile(predicate).Reverse();
	}

	public static void ForEach<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Action<T> action)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		foreach (T item in enumerable)
		{
			action(item);
		}
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static HashSet<T> ToHashSet<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<T> comparer)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		return new HashSet<T>(enumerable, comparer);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static HashSet<T> ToHashSet<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable)
	{
		return enumerable.ToHashSet(EqualityComparer<T>.Default);
	}

	public static bool AddIfDistinct<T>([vfInGIfbsoYlQBMjtrM] this ICollection<T> collection, T obj, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<T> comparer)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		bool num = !collection.Contains(obj, comparer);
		if (num)
		{
			collection.Add(obj);
		}
		return num;
	}

	public static bool AddIfDistinct<T>([vfInGIfbsoYlQBMjtrM] this ICollection<T> collection, T obj)
	{
		return collection.AddIfDistinct(obj, EqualityComparer<T>.Default);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int IndexOf<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, T element, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<T> comparer)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		int num = 0;
		foreach (T item in enumerable)
		{
			if (!comparer.Equals(item, element))
			{
				num++;
				continue;
			}
			return num;
		}
		return -1;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int IndexOf<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, T element)
	{
		return enumerable.IndexOf(element, EqualityComparer<T>.Default);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int IndexOf<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, bool> predicate)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		int num = 0;
		foreach (T item in enumerable)
		{
			if (!predicate(item))
			{
				num++;
				continue;
			}
			return num;
		}
		return -1;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndexOf<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, T element, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<T> comparer)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		int result = -1;
		int num = 0;
		foreach (T item in enumerable)
		{
			if (comparer.Equals(item, element))
			{
				result = num;
			}
			num++;
		}
		return result;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndexOf<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, T element)
	{
		return enumerable.LastIndexOf(element, EqualityComparer<T>.Default);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndexOf<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, bool> predicate)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		int result = -1;
		int num = 0;
		foreach (T item in enumerable)
		{
			if (predicate(item))
			{
				result = num;
			}
			num++;
		}
		return result;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndexOf<T>([vfInGIfbsoYlQBMjtrM] this IList<T> list, T element, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<T> comparer)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		int num = list.Count - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (comparer.Equals(list[num], element))
				{
					break;
				}
				num--;
				continue;
			}
			return -1;
		}
		return num;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndexOf<T>([vfInGIfbsoYlQBMjtrM] this IList<T> list, T element)
	{
		return list.LastIndexOf(element, EqualityComparer<T>.Default);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndexOf<T>([vfInGIfbsoYlQBMjtrM] this IList<T> list, [vfInGIfbsoYlQBMjtrM] Func<T, bool> predicate)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		int num = list.Count - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (predicate(list[num]))
				{
					break;
				}
				num--;
				continue;
			}
			return -1;
		}
		return num;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndex<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		return enumerable.Count() - 1;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int LastIndex([vfInGIfbsoYlQBMjtrM] this Array array, int dimension = 0)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (dimension < 0)
		{
			throw new ArgumentOutOfRangeException("dimension");
		}
		if (dimension > array.Rank - 1)
		{
			return -1;
		}
		return array.GetUpperBound(dimension);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static TValue GetOrDefault<TKey, TValue>([vfInGIfbsoYlQBMjtrM] this IDictionary<TKey, TValue> dic, TKey key, TValue defaultValue = default(TValue))
	{
		if (dic == null)
		{
			throw new ArgumentNullException("dic");
		}
		if (!dic.TryGetValue(key, out var value))
		{
			return defaultValue;
		}
		return value;
	}

	public static void Fill<T>([vfInGIfbsoYlQBMjtrM] this IList<T> list, T value, int startIndex, int count)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		if (startIndex >= 0 && startIndex < list.Count)
		{
			if (count >= 0 && count <= list.Count - startIndex)
			{
				if (count != 0)
				{
					for (int i = startIndex; i < startIndex + count; i++)
					{
						list[i] = value;
					}
				}
				return;
			}
			throw new ArgumentOutOfRangeException("count");
		}
		throw new ArgumentOutOfRangeException("startIndex");
	}

	public static void Fill<T>([vfInGIfbsoYlQBMjtrM] this IList<T> list, T value, int startIndex)
	{
		list.Fill(value, startIndex, list.Count - startIndex);
	}

	public static void Fill<T>([vfInGIfbsoYlQBMjtrM] this IList<T> list, T value)
	{
		list.Fill(value, 0, list.Count);
	}

	public static void EnsureMaxCount<T>([vfInGIfbsoYlQBMjtrM] this IList<T> list, int count, EnsureMaxCountMode mode = EnsureMaxCountMode.DeleteFirst)
	{
		_003C_003Ec__DisplayClass35_0<T> _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0<T>();
		_003C_003Ec__DisplayClass35_.list = list;
		if (_003C_003Ec__DisplayClass35_.list == null)
		{
			throw new ArgumentNullException("list");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		Action action = mode switch
		{
			EnsureMaxCountMode.DeleteFirst => _003C_003Ec__DisplayClass35_.pcL2N3moKan, 
			EnsureMaxCountMode.DeleteLast => _003C_003Ec__DisplayClass35_.xXM2Nfdc6CU, 
			EnsureMaxCountMode.DeleteRandom => _003C_003Ec__DisplayClass35_.yZX2NzgEDqn, 
			EnsureMaxCountMode.DeleteAll => _003C_003Ec__DisplayClass35_.list.Clear, 
			_ => throw new ArgumentOutOfRangeException("mode", mode, null), 
		};
		while (_003C_003Ec__DisplayClass35_.list.Count > count && _003C_003Ec__DisplayClass35_.list.Count > 0)
		{
			action();
		}
	}

	public static bool SetOrAdd<TKey, TValue>([vfInGIfbsoYlQBMjtrM] this IDictionary<TKey, TValue> dic, TKey key, TValue value)
	{
		if (dic == null)
		{
			throw new ArgumentNullException("dic");
		}
		if (dic.ContainsKey(key))
		{
			dic[key] = value;
			return true;
		}
		dic.Add(key, value);
		return false;
	}

	public static bool ContainsAny<T>([vfInGIfbsoYlQBMjtrM] this ICollection<T> collection, params T[] items)
	{
		int num = 0;
		while (true)
		{
			if (num < items.Length)
			{
				T item = items[num];
				if (collection.Contains(item))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static string GetString(this byte[] data, Encoding encoding)
	{
		return encoding.GetString(data, 0, data.Length);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static string GetString(this byte[] data)
	{
		return data.GetString(Encoding.Unicode);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static byte[] GetBytes(this string str, Encoding encoding)
	{
		return encoding.GetBytes(str);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static byte[] GetBytes(this string str)
	{
		return str.GetBytes(Encoding.Unicode);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static string ToBase64(this byte[] bytes)
	{
		return Convert.ToBase64String(bytes);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static byte[] FromBase64(this string str)
	{
		return Convert.FromBase64String(str);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static TEnum ParseEnum<TEnum>([vfInGIfbsoYlQBMjtrM] this string str, bool ignoreCase = true) where TEnum : struct
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return (TEnum)Enum.Parse(typeof(TEnum), str, ignoreCase);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static TEnum ParseEnumOrDefault<TEnum>([ms79yjfhVOxH0jjfcQZ] this string str, bool ignoreCase = true, TEnum defaultValue = default(TEnum)) where TEnum : struct
	{
		if (!Enum.TryParse<TEnum>(str, ignoreCase, out var result))
		{
			return defaultValue;
		}
		return result;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static TEnum RandomEnum<TEnum>() where TEnum : struct
	{
		return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().GetRandom();
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static T ConvertTo<T>(this object obj)
	{
		return (T)Convert.ChangeType(obj, typeof(T));
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static T ConvertToOrDefault<T>(this object obj, T defaultValue = default(T))
	{
		try
		{
			return obj.ConvertTo<T>();
		}
		catch
		{
			return defaultValue;
		}
	}

	[cT5o3WfLNbx9gFBsqxP]
	[Obsolete("耗费内存太大")]
	public static bool IsEither<T>(this T obj, [vfInGIfbsoYlQBMjtrM] IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] IEqualityComparer<T> comparer)
	{
		_003C_003Ec__DisplayClass49_0<T> _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0<T>();
		_003C_003Ec__DisplayClass49_.comparer = comparer;
		_003C_003Ec__DisplayClass49_.obj = obj;
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (_003C_003Ec__DisplayClass49_.comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		return enumerable.Any(_003C_003Ec__DisplayClass49_.HKO2JwcfmLk);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool IsEither<T>(this T obj, [vfInGIfbsoYlQBMjtrM] IEnumerable<T> enumerable)
	{
		return obj.IsEither(enumerable, EqualityComparer<T>.Default);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool IsEither<T>(this T obj, params T[] objs)
	{
		int num = 0;
		while (true)
		{
			if (num < objs.Length)
			{
				T val = objs[num];
				if (val.Equals(obj))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool IsInRange<T>([vfInGIfbsoYlQBMjtrM] this T value, [vfInGIfbsoYlQBMjtrM] T min, [vfInGIfbsoYlQBMjtrM] T max) where T : IComparable<T>
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (min == null)
		{
			throw new ArgumentNullException("min");
		}
		if (max == null)
		{
			throw new ArgumentNullException("max");
		}
		if (value.CompareTo(min) >= 0)
		{
			return value.CompareTo(max) <= 0;
		}
		return false;
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static T Clamp<T>([vfInGIfbsoYlQBMjtrM] this T value, [vfInGIfbsoYlQBMjtrM] T min, [vfInGIfbsoYlQBMjtrM] T max) where T : IComparable<T>
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (min == null)
		{
			throw new ArgumentNullException("min");
		}
		if (max == null)
		{
			throw new ArgumentNullException("max");
		}
		if (value.CompareTo(min) > 0)
		{
			if (value.CompareTo(max) < 0)
			{
				return value;
			}
			return max;
		}
		return min;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static T ClampMin<T>([vfInGIfbsoYlQBMjtrM] this T value, [vfInGIfbsoYlQBMjtrM] T min) where T : IComparable<T>
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (min == null)
		{
			throw new ArgumentNullException("min");
		}
		if (value.CompareTo(min) > 0)
		{
			return value;
		}
		return min;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static T ClampMax<T>([vfInGIfbsoYlQBMjtrM] this T value, [vfInGIfbsoYlQBMjtrM] T max) where T : IComparable<T>
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (max == null)
		{
			throw new ArgumentNullException("max");
		}
		if (value.CompareTo(max) < 0)
		{
			return value;
		}
		return max;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int RandomInt(int minValue, int maxValue)
	{
		return jxKc3JfHvFtxrsKKy81.Random.Next(minValue, maxValue + 1);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int RandomInt(int maxValue)
	{
		return jxKc3JfHvFtxrsKKy81.Random.Next(maxValue + 1);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static int RandomInt()
	{
		return jxKc3JfHvFtxrsKKy81.Random.Next();
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static double RandomDouble(double minValue, double maxValue)
	{
		return jxKc3JfHvFtxrsKKy81.Random.NextDouble() * (maxValue - minValue) + minValue;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static double RandomDouble(double maxValue)
	{
		return RandomDouble(double.MinValue, maxValue);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static double RandomDouble()
	{
		return RandomDouble(double.MinValue, double.MaxValue);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool RandomBool(double probability)
	{
		if (probability <= 0.0)
		{
			return false;
		}
		if (probability >= 1.0)
		{
			return true;
		}
		return RandomDouble(0.0, 1.0) <= probability;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool RandomBool()
	{
		return RandomInt(0, 1) == 1;
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string GetManifestResourceString([vfInGIfbsoYlQBMjtrM] this Assembly assembly, [vfInGIfbsoYlQBMjtrM] string resourceName)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		using StreamReader streamReader = new StreamReader(assembly.GetManifestResourceStream(resourceName) ?? throw new MissingManifestResourceException("Could not find resource [" + resourceName + "]."));
		return streamReader.ReadToEnd();
	}

	[cT5o3WfLNbx9gFBsqxP]
	[ELnurNfnARP5HMHMimc("str:null => true")]
	public static bool IsBlank([ms79yjfhVOxH0jjfcQZ] this string str)
	{
		return string.IsNullOrWhiteSpace(str);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[ELnurNfnARP5HMHMimc("str:null => false")]
	public static bool IsNotBlank([ms79yjfhVOxH0jjfcQZ] this string str)
	{
		return !string.IsNullOrWhiteSpace(str);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool IsNumeric([vfInGIfbsoYlQBMjtrM] this string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return str.ToCharArray().All(_003C_003EO.SWv2N4PFcnx ?? (_003C_003EO.SWv2N4PFcnx = char.IsDigit));
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool IsAlphabetic([vfInGIfbsoYlQBMjtrM] this string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return str.ToCharArray().All(_003C_003EO.bTv2N5TLjrQ ?? (_003C_003EO.bTv2N5TLjrQ = char.IsLetter));
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static bool IsAlphanumeric([vfInGIfbsoYlQBMjtrM] this string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return str.ToCharArray().All(_003C_003EO.M142NDbGhaq ?? (_003C_003EO.M142NDbGhaq = char.IsLetterOrDigit));
	}

	[ELnurNfnARP5HMHMimc("str:null => null")]
	[cT5o3WfLNbx9gFBsqxP]
	[ms79yjfhVOxH0jjfcQZ]
	public static string NullIfBlank([ms79yjfhVOxH0jjfcQZ] this string str)
	{
		if (!string.IsNullOrWhiteSpace(str))
		{
			return str;
		}
		return null;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string EmptyIfNull([ms79yjfhVOxH0jjfcQZ] this string str)
	{
		return str ?? string.Empty;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string EmptyIfBlank([ms79yjfhVOxH0jjfcQZ] this string str)
	{
		if (!string.IsNullOrWhiteSpace(str))
		{
			return str;
		}
		return string.Empty;
	}

	[R1esOKfyFfEXas9wHrG("str")]
	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string Format([vfInGIfbsoYlQBMjtrM] this string str, params object[] args)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return string.Format(CultureInfo.InvariantCulture, str, args);
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string TrimStart([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str != null)
		{
			if (sub == null)
			{
				throw new ArgumentNullException("sub");
			}
			while (str.StartsWith(sub, comparison))
			{
				str = str.Substring(sub.Length);
			}
			return str;
		}
		throw new ArgumentNullException("str");
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string TrimEnd([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (sub == null)
		{
			throw new ArgumentNullException("sub");
		}
		while (str.EndsWith(sub, comparison))
		{
			str = str.Substring(0, str.Length - sub.Length);
		}
		return str;
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string Trim([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (sub == null)
		{
			throw new ArgumentNullException("sub");
		}
		return str.TrimStart(sub, comparison).TrimEnd(sub, comparison);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string Reverse([vfInGIfbsoYlQBMjtrM] this string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (str.Length <= 1)
		{
			return str;
		}
		StringBuilder stringBuilder = new StringBuilder(str.Length);
		for (int num = str.Length - 1; num >= 0; num--)
		{
			stringBuilder.Append(str[num]);
		}
		return stringBuilder.ToString();
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string Repeat([vfInGIfbsoYlQBMjtrM] this string str, int count)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		switch (count)
		{
		case 0:
			return string.Empty;
		case 1:
			return str;
		case 2:
			return str + str;
		case 3:
			return str + str + str;
		default:
		{
			StringBuilder stringBuilder = new StringBuilder(str, str.Length * count);
			for (int i = 2; i <= count; i++)
			{
				if (!ll9e3tFm1toH3J16M1jk())
				{
					switch (0)
					{
					}
				}
				stringBuilder.Append(str);
			}
			return stringBuilder.ToString();
		}
		}
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string Repeat(this char c, int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return string.Empty;
		}
		return new string(c, count);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string Replace([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string oldValue, [vfInGIfbsoYlQBMjtrM] string newValue, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (oldValue == null)
		{
			throw new ArgumentNullException("oldValue");
		}
		if (newValue == null)
		{
			throw new ArgumentNullException("newValue");
		}
		int num3 = default(int);
		for (int num = str.IndexOf(oldValue, comparison); num >= 0; num = str.IndexOf(oldValue, comparison))
		{
			str = str.Remove(num, oldValue.Length);
			str = str.Insert(num, newValue);
			int num2 = 0;
			if (!ll9e3tFm1toH3J16M1jk())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return str;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string Replace([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] IEnumerable<char> oldChars, char newChar)
	{
		if (string.IsNullOrEmpty(str))
		{
			return str;
		}
		foreach (char oldChar in oldChars)
		{
			str = str.Replace(oldChar, newChar);
		}
		return str;
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string EnsureStartsWith([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (sub != null)
		{
			if (!str.StartsWith(sub, comparison))
			{
				return sub + str;
			}
			return str;
		}
		throw new ArgumentNullException("sub");
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string EnsureEndsWith([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (sub == null)
		{
			throw new ArgumentNullException("sub");
		}
		if (!str.EndsWith(sub, comparison))
		{
			return str + sub;
		}
		return str;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string SubstringUntil([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str != null)
		{
			if (sub == null)
			{
				throw new ArgumentNullException("sub");
			}
			int num = str.IndexOf(sub, comparison);
			if (num < 0)
			{
				return str;
			}
			return str.Substring(0, num);
		}
		throw new ArgumentNullException("str");
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string SubstringAfter([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparison = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (sub == null)
		{
			throw new ArgumentNullException("sub");
		}
		int num = str.IndexOf(sub, comparison);
		if (num < 0)
		{
			return string.Empty;
		}
		return str.Substring(num + sub.Length, str.Length - num - sub.Length);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string SubstringUntilLast([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparsion = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (sub == null)
		{
			throw new ArgumentNullException("sub");
		}
		int num = str.LastIndexOf(sub, comparsion);
		if (num < 0)
		{
			return str;
		}
		return str.Substring(0, num);
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string SubstringAfterLast([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] string sub, StringComparison comparsion = StringComparison.Ordinal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (sub == null)
		{
			throw new ArgumentNullException("sub");
		}
		int num = str.LastIndexOf(sub, comparsion);
		if (num < 0)
		{
			return string.Empty;
		}
		return str.Substring(num + sub.Length, str.Length - num - sub.Length);
	}

	[Mo0Y3Lf1VtlbG7qst0Z]
	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static IEnumerable<string> ExceptBlank([vfInGIfbsoYlQBMjtrM] this IEnumerable<string> enumerable)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		return enumerable.Where(_003C_003EO.Jeh2NdQPDji ?? (_003C_003EO.Jeh2NdQPDji = IsNotBlank));
	}

	[Mo0Y3Lf1VtlbG7qst0Z]
	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string[] Split([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] params string[] separators)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (separators == null)
		{
			throw new ArgumentNullException("separators");
		}
		return str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	[Mo0Y3Lf1VtlbG7qst0Z]
	public static string[] Split([vfInGIfbsoYlQBMjtrM] this string str, [vfInGIfbsoYlQBMjtrM] params char[] separators)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (separators == null)
		{
			throw new ArgumentNullException("separators");
		}
		return str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
	}

	public static bool ContainsIgnoreCase(this string value, string filter)
	{
		if (string.IsNullOrEmpty(value))
		{
			return false;
		}
		return value.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0;
	}

	public static void Forget(this Task task)
	{
	}

	[AsyncStateMachine(typeof(_003CParallelForEachAsync_003Ed__93<>))]
	public static Task ParallelForEachAsync<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, Task> task)
	{
		_003CParallelForEachAsync_003Ed__93<T> stateMachine = default(_003CParallelForEachAsync_003Ed__93<T>);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.enumerable = enumerable;
		stateMachine.task = task;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static Task ParallelForEachAsync<T>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Action<T> action)
	{
		_003C_003Ec__DisplayClass94_0<T> _003C_003Ec__DisplayClass94_ = new _003C_003Ec__DisplayClass94_0<T>();
		_003C_003Ec__DisplayClass94_.action = action;
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (_003C_003Ec__DisplayClass94_.action == null)
		{
			throw new ArgumentNullException("action");
		}
		return enumerable.ParallelForEachAsync((Func<T, Task>)_003C_003Ec__DisplayClass94_.hJ92Jv2ev0N);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[AsyncStateMachine(typeof(_003CParallelSelectAsync_003Ed__95<, >))]
	public static Task<IEnumerable<TResult>> ParallelSelectAsync<T, TResult>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, Task<TResult>> task)
	{
		_003CParallelSelectAsync_003Ed__95<T, TResult> stateMachine = default(_003CParallelSelectAsync_003Ed__95<T, TResult>);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<TResult>>.Create();
		stateMachine.enumerable = enumerable;
		stateMachine.task = task;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static Task<IEnumerable<TResult>> ParallelSelectAsync<T, TResult>([vfInGIfbsoYlQBMjtrM] this IEnumerable<T> enumerable, [vfInGIfbsoYlQBMjtrM] Func<T, TResult> func)
	{
		_003C_003Ec__DisplayClass96_0<T, TResult> _003C_003Ec__DisplayClass96_ = new _003C_003Ec__DisplayClass96_0<T, TResult>();
		_003C_003Ec__DisplayClass96_.func = func;
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		if (_003C_003Ec__DisplayClass96_.func == null)
		{
			throw new ArgumentNullException("func");
		}
		return enumerable.ParallelSelectAsync(_003C_003Ec__DisplayClass96_.N6b2J2rPhn7);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static TimeSpan Multiply(this TimeSpan timeSpan, double multiplier)
	{
		return TimeSpan.FromMilliseconds(timeSpan.TotalMilliseconds * multiplier);
	}

	[cT5o3WfLNbx9gFBsqxP]
	public static TimeSpan Divide(this TimeSpan timeSpan, double divider)
	{
		return TimeSpan.FromMilliseconds(timeSpan.TotalMilliseconds / divider);
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static Uri ToUri([vfInGIfbsoYlQBMjtrM] this string uri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		return new UriBuilder(uri).Uri;
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static Uri ToUri([vfInGIfbsoYlQBMjtrM] this string uri, [vfInGIfbsoYlQBMjtrM] string baseUri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (baseUri == null)
		{
			throw new ArgumentNullException("baseUri");
		}
		return new Uri(baseUri.ToUri(), new Uri(uri, UriKind.Relative));
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static Uri ToUri([vfInGIfbsoYlQBMjtrM] this string uri, [vfInGIfbsoYlQBMjtrM] Uri baseUri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (baseUri == null)
		{
			throw new ArgumentNullException("baseUri");
		}
		return new Uri(baseUri, new Uri(uri, UriKind.Relative));
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string UrlEncode([vfInGIfbsoYlQBMjtrM] this string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return WebUtility.UrlEncode(data);
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static string UrlDecode([vfInGIfbsoYlQBMjtrM] this string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return WebUtility.UrlDecode(data);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static string SetQueryParameter([vfInGIfbsoYlQBMjtrM] this string uri, [vfInGIfbsoYlQBMjtrM] string key, [ms79yjfhVOxH0jjfcQZ] string value)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (value == null)
		{
			value = string.Empty;
		}
		Match match = Regex.Match(uri, "[?&](" + Regex.Escape(key) + "=?.*?)(?:&|/|$)");
		if (match.Success)
		{
			Group obj = match.Groups[1];
			uri = uri.Remove(obj.Index, obj.Length);
			uri = uri.Insert(obj.Index, key + "=" + value);
			return uri;
		}
		int num3;
		if (uri.IndexOf('?') < 0)
		{
			int num = 0;
			if (EhGZpRFm00VswrqU3PnH != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			num3 = 63;
		}
		else
		{
			num3 = 38;
		}
		char c = (char)num3;
		return uri + c + key + "=" + value;
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static Uri SetQueryParameter([vfInGIfbsoYlQBMjtrM] this Uri uri, [vfInGIfbsoYlQBMjtrM] string key, [ms79yjfhVOxH0jjfcQZ] string value)
	{
		return uri.ToString().SetQueryParameter(key, value).ToUri();
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static XElement StripNamespaces([vfInGIfbsoYlQBMjtrM] this XElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		XElement xElement = new XElement(element);
		foreach (XElement item in xElement.DescendantsAndSelf())
		{
			item.Name = XNamespace.None.GetName(item.Name.LocalName);
			IEnumerable<XAttribute> content = item.Attributes().Where(_003C_003Ec.qWX2NO3pkAP ?? (_003C_003Ec.qWX2NO3pkAP = _003C_003Ec.fSN2NAJP35L.iaP2NovyTCP)).Where(_003C_003Ec.Xc72NFWFa4r ?? (_003C_003Ec.Xc72NFWFa4r = _003C_003Ec.fSN2NAJP35L.MVO2NToKPeY))
				.Select(_003C_003Ec.xWV2NUYb5o0 ?? (_003C_003Ec.xWV2NUYb5o0 = _003C_003Ec.fSN2NAJP35L.g3B2NMh1kAQ));
			item.ReplaceAttributes(content);
		}
		return xElement;
	}

	[cT5o3WfLNbx9gFBsqxP]
	[ms79yjfhVOxH0jjfcQZ]
	public static XElement Descendant([vfInGIfbsoYlQBMjtrM] this XElement element, [vfInGIfbsoYlQBMjtrM] XName name)
	{
		if (element != null)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return element.Descendants(name).FirstOrDefault();
		}
		throw new ArgumentNullException("element");
	}

	[vfInGIfbsoYlQBMjtrM]
	[cT5o3WfLNbx9gFBsqxP]
	public static XElement DescendantStrict([vfInGIfbsoYlQBMjtrM] this XElement element, [vfInGIfbsoYlQBMjtrM] XName name)
	{
		if (element != null)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return element.Descendant(name) ?? throw new XmlElementNotFoundException(name);
		}
		throw new ArgumentNullException("element");
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static XElement ElementStrict([vfInGIfbsoYlQBMjtrM] this XElement element, [vfInGIfbsoYlQBMjtrM] XName name)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return element.Element(name) ?? throw new XmlElementNotFoundException(name);
	}

	[cT5o3WfLNbx9gFBsqxP]
	[vfInGIfbsoYlQBMjtrM]
	public static XAttribute AttributeStrict([vfInGIfbsoYlQBMjtrM] this XElement element, [vfInGIfbsoYlQBMjtrM] XName name)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return element.Attribute(name) ?? throw new XmlElementNotFoundException(name);
	}

	internal static bool ll9e3tFm1toH3J16M1jk()
	{
		return EhGZpRFm00VswrqU3PnH == null;
	}
}
