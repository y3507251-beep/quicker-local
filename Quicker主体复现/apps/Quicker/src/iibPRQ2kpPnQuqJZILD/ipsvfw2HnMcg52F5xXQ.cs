using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace iibPRQ2kpPnQuqJZILD;

internal static class ipsvfw2HnMcg52F5xXQ
{
	[CompilerGenerated]
	private sealed class _003CSafeWalk_003Ed__0<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private IEnumerator<T> _003Cenumerator_003E5__2;

		private bool? _003ChasCurrent_003E5__3;

		private static object kXi3w4cMLcvD258nnhOT;

		T IEnumerator<T>.Current
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
		public _003CSafeWalk_003Ed__0(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003Cenumerator_003E5__2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_0065;
			}
			_003C_003E1__state = -1;
			_003Cenumerator_003E5__2 = source.GetEnumerator();
			_003ChasCurrent_003E5__3 = null;
			goto IL_003e;
			IL_0065:
			if (!(_003ChasCurrent_003E5__3 ?? true))
			{
				return false;
			}
			goto IL_003e;
			IL_003e:
			try
			{
				_003ChasCurrent_003E5__3 = _003Cenumerator_003E5__2.MoveNext();
			}
			catch
			{
				_003ChasCurrent_003E5__3 = null;
			}
			if (_003ChasCurrent_003E5__3 != true)
			{
				goto IL_0065;
			}
			_003C_003E2__current = _003Cenumerator_003E5__2.Current;
			_003C_003E1__state = 1;
			if (p97eXAcMoQ55G9VqdCgF() == null)
			{
				switch (0)
				{
				}
			}
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CSafeWalk_003Ed__0<T> _003CSafeWalk_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CSafeWalk_003Ed__ = this;
			}
			else
			{
				_003CSafeWalk_003Ed__ = new _003CSafeWalk_003Ed__0<T>(0);
			}
			_003CSafeWalk_003Ed__.source = _003C_003E3__source;
			return _003CSafeWalk_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool efqNRqcMuNW4HYYSbiUG()
		{
			return kXi3w4cMLcvD258nnhOT == null;
		}

		internal static object p97eXAcMoQ55G9VqdCgF()
		{
			return kXi3w4cMLcvD258nnhOT;
		}
	}

	[IteratorStateMachine(typeof(_003CSafeWalk_003Ed__0<>))]
	public static IEnumerable<wg5rR92hjRJxJx3XJhK> orLtCg0Q9sT<wg5rR92hjRJxJx3XJhK>(this IEnumerable<wg5rR92hjRJxJx3XJhK> ienumerable_0)
	{
		return new _003CSafeWalk_003Ed__0<wg5rR92hjRJxJx3XJhK>(-2)
		{
			_003C_003E3__source = ienumerable_0
		};
	}
}
