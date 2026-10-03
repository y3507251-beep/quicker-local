using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Quicker.Modules.Searching.History;

public static class Helper
{
	[CompilerGenerated]
	private sealed class _003CDistinctBy_003Ed__0<TSource, TKey> : IEnumerable<TSource>, IEnumerator<TSource>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private TSource _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<TSource> source;

		public IEnumerable<TSource> _003C_003E3__source;

		private Func<TSource, TKey> keySelector;

		public Func<TSource, TKey> _003C_003E3__keySelector;

		private HashSet<TKey> _003CseenKeys_003E5__2;

		private IEnumerator<TSource> _003C_003E7__wrap2;

		private static object AHiONDcPdVSkfy1WqHMs;

		TSource IEnumerator<TSource>.Current
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
		public _003CDistinctBy_003Ed__0(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003CseenKeys_003E5__2 = null;
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_003C_003E1__state = -3;
					goto IL_0070;
				}
				_003C_003E1__state = -1;
				_003CseenKeys_003E5__2 = new HashSet<TKey>();
				int num2 = 0;
				if (!b5yavZcPOgFc2RLaF4h9())
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_00ab;
				IL_0070:
				while (_003C_003E7__wrap2.MoveNext())
				{
					TSource current = _003C_003E7__wrap2.Current;
					if (_003CseenKeys_003E5__2.Add(keySelector(current)))
					{
						_003C_003E2__current = current;
						_003C_003E1__state = 1;
						return true;
					}
				}
				_003C_003Em__Finally1();
				num2 = 1;
				if (CDNc1ncPJfIiTPygqTn2() != null)
				{
					goto IL_0090;
				}
				goto IL_00ab;
				IL_00ab:
				switch (num2)
				{
				case 1:
					_003C_003E7__wrap2 = null;
					return false;
				}
				goto IL_0090;
				IL_0090:
				_003C_003E7__wrap2 = source.GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_0070;
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
		IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
		{
			_003CDistinctBy_003Ed__0<TSource, TKey> _003CDistinctBy_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CDistinctBy_003Ed__ = this;
			}
			else
			{
				_003CDistinctBy_003Ed__ = new _003CDistinctBy_003Ed__0<TSource, TKey>(0);
			}
			_003CDistinctBy_003Ed__.source = _003C_003E3__source;
			_003CDistinctBy_003Ed__.keySelector = _003C_003E3__keySelector;
			return _003CDistinctBy_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TSource>)this).GetEnumerator();
		}

		internal static bool b5yavZcPOgFc2RLaF4h9()
		{
			return AHiONDcPdVSkfy1WqHMs == null;
		}

		internal static object CDNc1ncPJfIiTPygqTn2()
		{
			return AHiONDcPdVSkfy1WqHMs;
		}
	}

	[IteratorStateMachine(typeof(_003CDistinctBy_003Ed__0<, >))]
	public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return new _003CDistinctBy_003Ed__0<TSource, TKey>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__keySelector = keySelector
		};
	}
}
