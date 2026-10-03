using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CW;

public static class Seq
{
	private class HPboCMdXasgZL9oPam8<oZ5F5ydoUGV0CSrWx7k> : IEnumerable<oZ5F5ydoUGV0CSrWx7k>, IDisposable, IEnumerable
	{
		private class HH0MA4HeVc9viBX6HeC : IEnumerator<oZ5F5ydoUGV0CSrWx7k>, IDisposable, IEnumerator
		{
			private readonly HPboCMdXasgZL9oPam8<oZ5F5ydoUGV0CSrWx7k> puS284kaOEW;

			private int bQV285FYaDn = -1;

			[CompilerGenerated]
			private oZ5F5ydoUGV0CSrWx7k vmX28D3t7Zs;

			private static object Qti2lpy99tiy6Bx1acbK;

			public oZ5F5ydoUGV0CSrWx7k Current
			{
				[CompilerGenerated]
				get
				{
					return vmX28D3t7Zs;
				}
				[CompilerGenerated]
				private set
				{
					vmX28D3t7Zs = value;
				}
			}

			object IEnumerator.Current => Current;

			public HH0MA4HeVc9viBX6HeC(HPboCMdXasgZL9oPam8<oZ5F5ydoUGV0CSrWx7k> hpboCMdXasgZL9oPam8_1)
			{
				puS284kaOEW = hpboCMdXasgZL9oPam8_1;
			}

			public bool MoveNext()
			{
				bool result = true;
				bQV285FYaDn++;
				if (bQV285FYaDn >= puS284kaOEW.colvy8tQC2N.Count)
				{
					if (result = !puS284kaOEW.u3lvyPuksOp() && puS284kaOEW.kLCvyaYg3HJ.MoveNext())
					{
						Current = puS284kaOEW.kLCvyaYg3HJ.Current;
						puS284kaOEW.colvy8tQC2N.Add(puS284kaOEW.kLCvyaYg3HJ.Current);
					}
					else
					{
						puS284kaOEW.so0vyEnufIM(true);
						puS284kaOEW.kLCvyaYg3HJ.Dispose();
					}
				}
				else
				{
					Current = puS284kaOEW.colvy8tQC2N[bQV285FYaDn];
				}
				return result;
			}

			public void Reset()
			{
				bQV285FYaDn = -1;
			}

			public void Dispose()
			{
			}

			internal static bool OSpcoXy9Lh3A1gLtDXpG()
			{
				return Qti2lpy99tiy6Bx1acbK == null;
			}
		}

		private readonly IList<oZ5F5ydoUGV0CSrWx7k> colvy8tQC2N;

		private IEnumerator<oZ5F5ydoUGV0CSrWx7k> kLCvyaYg3HJ;

		[CompilerGenerated]
		private bool zPYvy7mn1iL;

		private static object t1lLyxcDjvZwXkdURSju;

		[SpecialName]
		[CompilerGenerated]
		public bool u3lvyPuksOp()
		{
			return zPYvy7mn1iL;
		}

		[SpecialName]
		[CompilerGenerated]
		private void so0vyEnufIM(bool bool_1)
		{
			zPYvy7mn1iL = bool_1;
		}

		public HPboCMdXasgZL9oPam8(IEnumerable<oZ5F5ydoUGV0CSrWx7k> ienumerable_0)
		{
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("source");
			}
			colvy8tQC2N = ienumerable_0 as IList<oZ5F5ydoUGV0CSrWx7k>;
			if (colvy8tQC2N == null)
			{
				colvy8tQC2N = new List<oZ5F5ydoUGV0CSrWx7k>();
				kLCvyaYg3HJ = ienumerable_0.GetEnumerator();
			}
			else
			{
				kLCvyaYg3HJ = Enumerable.Empty<oZ5F5ydoUGV0CSrWx7k>().GetEnumerator();
			}
		}

		public IEnumerator<oZ5F5ydoUGV0CSrWx7k> GetEnumerator()
		{
			if (!u3lvyPuksOp())
			{
				return new HH0MA4HeVc9viBX6HeC(this);
			}
			return colvy8tQC2N.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~HPboCMdXasgZL9oPam8()
		{
			Dispose(false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing && kLCvyaYg3HJ != null)
			{
				kLCvyaYg3HJ.Dispose();
				kLCvyaYg3HJ = null;
			}
		}

		internal static bool OwVmjGcDDfZO4GO54lgv()
		{
			return t1lLyxcDjvZwXkdURSju == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__35<T>
	{
		public static readonly _003C_003Ec__35<T> _003C_003E9;

		public static Func<T, int, Tuple<T, int>> _003C_003E9__35_0;

		internal static object MmWdkScDEwnPERIjBNDL;

		static _003C_003Ec__35()
		{
			_003C_003E9 = new _003C_003Ec__35<T>();
		}

		internal Tuple<T, int> L0FvyRvvZnq(T item, int count)
		{
			return Tuple.Create(item, count);
		}

		internal static bool QKPIDKcDG5mnMdmlLbnF()
		{
			return MmWdkScDEwnPERIjBNDL == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__37<T>
	{
		public static readonly _003C_003Ec__37<T> _003C_003E9;

		public static Func<T, long, Tuple<T, long>> _003C_003E9__37_0;

		private static object F8fXiFcD1A2w5VNMZMx1;

		static _003C_003Ec__37()
		{
			_003C_003E9 = new _003C_003Ec__37<T>();
		}

		internal Tuple<T, long> Qu5vyqkEFkP(T item, long count)
		{
			return Tuple.Create(item, count);
		}

		internal static bool mdfjN4cDKKOQtCJH35P4()
		{
			return F8fXiFcD1A2w5VNMZMx1 == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__52<TKey, TValue> where TValue : class
	{
		public static readonly _003C_003Ec__52<TKey, TValue> _003C_003E9;

		public static Func<KeyValuePair<TKey, WeakReference<TValue>>, bool> _003C_003E9__52_0;

		public static Func<KeyValuePair<TKey, WeakReference<TValue>>, TKey> _003C_003E9__52_1;

		internal static object cU095DcDv0wvrtX0FSln;

		static _003C_003Ec__52()
		{
			_003C_003E9 = new _003C_003Ec__52<TKey, TValue>();
		}

		internal bool En1vyc9a4qO(KeyValuePair<TKey, WeakReference<TValue>> ent)
		{
			return !ent.Value.IsAlive();
		}

		internal TKey D7GvyV0Tg0s(KeyValuePair<TKey, WeakReference<TValue>> ent)
		{
			return ent.Key;
		}

		internal static bool vrZSKycDdlVJmnMyIXrk()
		{
			return cU095DcDv0wvrtX0FSln == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__56<T>
	{
		public static readonly _003C_003Ec__56<T> _003C_003E9;

		public static Predicate<T> _003C_003E9__56_0;

		private static object uxKGHZcDJF2tbEOMH4PC;

		static _003C_003Ec__56()
		{
			_003C_003E9 = new _003C_003Ec__56<T>();
		}

		internal bool eT2vyZWTd5q(T cond)
		{
			return cond != null;
		}

		internal static bool tFtk0bcDk50ffxUomm69()
		{
			return uxKGHZcDJF2tbEOMH4PC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0<T>
	{
		public int start;

		private static object PqMAUCcDrGyjPJY00bHq;

		internal bool K8yvy9px29f(T v, int i)
		{
			return i >= start;
		}

		internal static bool NFhUKncDND3PKAvMn0vM()
		{
			return PqMAUCcDrGyjPJY00bHq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass43_0<T>
	{
		public int start;

		public int end;

		internal static object aR5QLkcDLPYC2fBWjcGF;

		internal bool juhvyhLCTeP(T v, int i)
		{
			return i >= start;
		}

		internal bool GqAvyeNC4rp(T v, int i)
		{
			return i < end;
		}

		internal static bool zUxAqNcDuWfayaULOyIA()
		{
			return aR5QLkcDLPYC2fBWjcGF == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAlternate_003Ed__7<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source1;

		public IEnumerable<T> _003C_003E3__source1;

		private IEnumerable<T> source2;

		public IEnumerable<T> _003C_003E3__source2;

		private IEnumerator<T> _003Cenumerator1_003E5__2;

		private IEnumerator<T> _003Cenumerator2_003E5__3;

		private static object PPSwDqcDfklC77MSih6d;

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
		public _003CAlternate_003Ed__7(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || (uint)(num - 1) <= 1u)
			{
				try
				{
					if (num == -4 || (uint)(num - 1) <= 1u)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003Cenumerator1_003E5__2 = null;
			_003Cenumerator2_003E5__3 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			bool result;
			try
			{
				int num;
				int num2 = default(int);
				switch (_003C_003E1__state)
				{
				default:
					result = false;
					goto end_IL_0001;
				case 0:
					_003C_003E1__state = -1;
					source1.ThrowIfNull("source1");
					source2.ThrowIfNull("source2");
					_003Cenumerator1_003E5__2 = source1.GetEnumerator();
					_003C_003E1__state = -3;
					_003Cenumerator2_003E5__3 = source2.GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_00cb;
				case 1:
					_003C_003E1__state = -4;
					if (_003Cenumerator2_003E5__3.MoveNext())
					{
						_003C_003E2__current = _003Cenumerator2_003E5__3.Current;
						_003C_003E1__state = 2;
						result = true;
						num = 2;
						if (!uPJmpTcDbGuMIaprbrR8())
						{
							goto IL_00ee;
						}
						goto IL_00f2;
					}
					result = false;
					goto IL_00db;
				case 2:
					{
						_003C_003E1__state = -4;
						goto IL_00cb;
					}
					IL_00ee:
					num = num2;
					goto IL_00f2;
					IL_00f2:
					switch (num)
					{
					case 1:
						_003C_003Em__Finally1();
						goto end_IL_0001;
					case 2:
						goto end_IL_0001;
					}
					break;
					IL_00cb:
					if (_003Cenumerator1_003E5__2.MoveNext())
					{
						break;
					}
					result = false;
					goto IL_00db;
					IL_00db:
					_003C_003Em__Finally2();
					num = 1;
					if (mCVBLicDq1MAQdAGfqDc() != null)
					{
						goto IL_00ee;
					}
					goto IL_00f2;
				}
				_003C_003E2__current = _003Cenumerator1_003E5__2.Current;
				_003C_003E1__state = 1;
				result = true;
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003Cenumerator1_003E5__2 != null)
			{
				_003Cenumerator1_003E5__2.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003Cenumerator2_003E5__3 != null)
			{
				_003Cenumerator2_003E5__3.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CAlternate_003Ed__7<T> _003CAlternate_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CAlternate_003Ed__ = this;
			}
			else
			{
				_003CAlternate_003Ed__ = new _003CAlternate_003Ed__7<T>(0);
			}
			_003CAlternate_003Ed__.source1 = _003C_003E3__source1;
			_003CAlternate_003Ed__.source2 = _003C_003E3__source2;
			return _003CAlternate_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool uPJmpTcDbGuMIaprbrR8()
		{
			return PPSwDqcDfklC77MSih6d == null;
		}

		internal static object mCVBLicDq1MAQdAGfqDc()
		{
			return PPSwDqcDfklC77MSih6d;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCombinationImpl_003Ed__16<T> : IEnumerable<T[]>, IEnumerator<T[]>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T[] _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int n;

		public int _003C_003E3__n;

		private T[] source;

		public T[] _003C_003E3__source;

		private T[] _003Cret_003E5__2;

		private int _003CN_003E5__3;

		private int _003CR_003E5__4;

		private int[] _003Ccurrent_003E5__5;

		internal static object bYCfWVcDiMbuqvaa0XSj;

		T[] IEnumerator<T[]>.Current
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
		public _003CCombinationImpl_003Ed__16(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003Cret_003E5__2 = null;
			_003Ccurrent_003E5__5 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			int num;
			int num3 = default(int);
			int num2 = default(int);
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				num = 0;
				if (!XFLCQecDleeBxiR6P8rJ())
				{
					goto IL_0078;
				}
				goto IL_00bf;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00bf:
				do
				{
					switch (num)
					{
					case 1:
						_003Cret_003E5__2[num2] = source[num2];
						num2++;
						break;
					default:
						_003Cret_003E5__2 = new T[n];
						_003CN_003E5__3 = source.Length;
						_003CR_003E5__4 = n;
						_003Ccurrent_003E5__5 = new int[n];
						num2 = 0;
						break;
					}
					if (num2 < _003CR_003E5__4)
					{
						_003Ccurrent_003E5__5[num2] = num2;
						num = 1;
						continue;
					}
					_003C_003E2__current = _003Cret_003E5__2;
					_003C_003E1__state = 1;
					return true;
				}
				while (XFLCQecDleeBxiR6P8rJ());
				goto IL_0078;
				IL_0078:
				num = num3;
				goto IL_00bf;
			}
			if (!dm20gWZ0Ih(_003CN_003E5__3, _003CR_003E5__4, _003Ccurrent_003E5__5))
			{
				return false;
			}
			for (num2 = 0; num2 < _003CR_003E5__4; num2++)
			{
				_003Cret_003E5__2[num2] = source[_003Ccurrent_003E5__5[num2]];
			}
			_003C_003E2__current = _003Cret_003E5__2;
			_003C_003E1__state = 2;
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
		IEnumerator<T[]> IEnumerable<T[]>.GetEnumerator()
		{
			_003CCombinationImpl_003Ed__16<T> _003CCombinationImpl_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CCombinationImpl_003Ed__ = this;
			}
			else
			{
				_003CCombinationImpl_003Ed__ = new _003CCombinationImpl_003Ed__16<T>(0);
			}
			_003CCombinationImpl_003Ed__.source = _003C_003E3__source;
			_003CCombinationImpl_003Ed__.n = _003C_003E3__n;
			return _003CCombinationImpl_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T[]>)this).GetEnumerator();
		}

		internal static bool XFLCQecDleeBxiR6P8rJ()
		{
			return bYCfWVcDiMbuqvaa0XSj == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCycle_003Ed__10<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private IEnumerator<T> _003C_003E7__wrap1;

		private static object IuxMy0cD5GfLW7WDTcNE;

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
		public _003CCycle_003Ed__10(int _003C_003E1__state)
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
			_003C_003E7__wrap1 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (!Jk3MAPcDY1O8GGwyAe0l())
				{
					switch (1)
					{
					case 1:
						break;
					default:
						goto IL_0031;
					}
				}
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					goto IL_0031;
				}
				_003C_003E1__state = -1;
				source.ThrowIfNull("source");
				goto IL_006e;
				IL_0031:
				_003C_003E1__state = -3;
				goto IL_0054;
				IL_0054:
				if (!_003C_003E7__wrap1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = null;
					goto IL_006e;
				}
				T current = _003C_003E7__wrap1.Current;
				_003C_003E2__current = current;
				_003C_003E1__state = 1;
				return true;
				IL_006e:
				_003C_003E7__wrap1 = source.GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_0054;
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
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CCycle_003Ed__10<T> _003CCycle_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CCycle_003Ed__ = this;
			}
			else
			{
				_003CCycle_003Ed__ = new _003CCycle_003Ed__10<T>(0);
			}
			_003CCycle_003Ed__.source = _003C_003E3__source;
			return _003CCycle_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool Jk3MAPcDY1O8GGwyAe0l()
		{
			return IuxMy0cD5GfLW7WDTcNE == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCycle_003Ed__11<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private T item1;

		public T _003C_003E3__item1;

		private T item2;

		public T _003C_003E3__item2;

		internal static object TllV0ScDRwI9Xt04e1y6;

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
		public _003CCycle_003Ed__11(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
			{
				_003C_003E1__state = -1;
				int num = 0;
				if (!PMNAhBcDgwMiqXLcYGDK())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					_003C_003E2__current = item2;
					_003C_003E1__state = 2;
					return true;
				}
			}
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = item1;
			_003C_003E1__state = 1;
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
			_003CCycle_003Ed__11<T> _003CCycle_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CCycle_003Ed__ = this;
			}
			else
			{
				_003CCycle_003Ed__ = new _003CCycle_003Ed__11<T>(0);
			}
			_003CCycle_003Ed__.item1 = _003C_003E3__item1;
			_003CCycle_003Ed__.item2 = _003C_003E3__item2;
			return _003CCycle_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool PMNAhBcDgwMiqXLcYGDK()
		{
			return TllV0ScDRwI9Xt04e1y6 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCycle_003Ed__12<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private T item1;

		public T _003C_003E3__item1;

		private T item2;

		public T _003C_003E3__item2;

		private T item3;

		public T _003C_003E3__item3;

		internal static object pIQ4WHcDMutSWdINS7sM;

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
		public _003CCycle_003Ed__12(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = item2;
				_003C_003E1__state = 2;
				return true;
			case 2:
			{
				_003C_003E1__state = -1;
				_003C_003E2__current = item3;
				int num = 0;
				if (z1SFSacDxn47koIeHW5D() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					_003C_003E1__state = 3;
					return true;
				}
			}
			case 3:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = item1;
			_003C_003E1__state = 1;
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
			_003CCycle_003Ed__12<T> _003CCycle_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CCycle_003Ed__ = this;
			}
			else
			{
				_003CCycle_003Ed__ = new _003CCycle_003Ed__12<T>(0);
			}
			_003CCycle_003Ed__.item1 = _003C_003E3__item1;
			_003CCycle_003Ed__.item2 = _003C_003E3__item2;
			_003CCycle_003Ed__.item3 = _003C_003E3__item3;
			return _003CCycle_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool rGhXtHcDU9r6CFV1BWO4()
		{
			return pIQ4WHcDMutSWdINS7sM == null;
		}

		internal static object z1SFSacDxn47koIeHW5D()
		{
			return pIQ4WHcDMutSWdINS7sM;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCycle_003Ed__13<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private T item1;

		public T _003C_003E3__item1;

		private T item2;

		public T _003C_003E3__item2;

		private T item3;

		public T _003C_003E3__item3;

		private T item4;

		public T _003C_003E3__item4;

		internal static object J2KpSLcDIfyB5ZqCYZs7;

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
		public _003CCycle_003Ed__13(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = item2;
				_003C_003E1__state = 2;
				return true;
			case 2:
			{
				_003C_003E1__state = -1;
				_003C_003E2__current = item3;
				_003C_003E1__state = 3;
				int num = 0;
				if (!BRcZZPcD6NJUk3Y2cSxW())
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => true, 
				};
			}
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = item4;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = item1;
			_003C_003E1__state = 1;
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
			_003CCycle_003Ed__13<T> _003CCycle_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CCycle_003Ed__ = this;
			}
			else
			{
				_003CCycle_003Ed__ = new _003CCycle_003Ed__13<T>(0);
			}
			_003CCycle_003Ed__.item1 = _003C_003E3__item1;
			_003CCycle_003Ed__.item2 = _003C_003E3__item2;
			_003CCycle_003Ed__.item3 = _003C_003E3__item3;
			_003CCycle_003Ed__.item4 = _003C_003E3__item4;
			return _003CCycle_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool BRcZZPcD6NJUk3Y2cSxW()
		{
			return J2KpSLcDIfyB5ZqCYZs7 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDefer_003Ed__54<TResult> : IEnumerable<TResult>, IEnumerator<TResult>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private TResult _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Func<IEnumerable<TResult>> enumerableFactory;

		public Func<IEnumerable<TResult>> _003C_003E3__enumerableFactory;

		private IEnumerator<TResult> _003C_003E7__wrap1;

		internal static object rMa8oIcDSULtYn3mtyAx;

		TResult IEnumerator<TResult>.Current
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
		public _003CDefer_003Ed__54(int _003C_003E1__state)
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
			_003C_003E7__wrap1 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				switch (_003C_003E1__state)
				{
				default:
					result = false;
					goto end_IL_0001;
				case 1:
					_003C_003E1__state = -3;
					break;
				case 0:
					_003C_003E1__state = -1;
					enumerableFactory.ThrowIfNull("enumerableFactory");
					_003C_003E7__wrap1 = enumerableFactory().GetEnumerator();
					_003C_003E1__state = -3;
					break;
				}
				if (!_003C_003E7__wrap1.MoveNext())
				{
					_003C_003Em__Finally1();
					int num = 1;
					if (pjXmZFcDwLEJ1CvfbNti())
					{
						while (true)
						{
							switch (num)
							{
							case 1:
								_003C_003E7__wrap1 = null;
								result = false;
								num = 0;
								if (!pjXmZFcDwLEJ1CvfbNti())
								{
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				}
				else
				{
					TResult current = _003C_003E7__wrap1.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 1;
					result = true;
				}
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
		{
			_003CDefer_003Ed__54<TResult> _003CDefer_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CDefer_003Ed__ = this;
			}
			else
			{
				_003CDefer_003Ed__ = new _003CDefer_003Ed__54<TResult>(0);
			}
			_003CDefer_003Ed__.enumerableFactory = _003C_003E3__enumerableFactory;
			return _003CDefer_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TResult>)this).GetEnumerator();
		}

		internal static bool pjXmZFcDwLEJ1CvfbNti()
		{
			return rMa8oIcDSULtYn3mtyAx == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDistinct_003Ed__5<T, TKey> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private Func<T, TKey> keySelector;

		public Func<T, TKey> _003C_003E3__keySelector;

		private HashSet<TKey> _003Chash_003E5__2;

		private IEnumerator<T> _003C_003E7__wrap2;

		internal static object JoiYjxcDmXPh8hjIMX8S;

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
		public _003CDistinct_003Ed__5(int _003C_003E1__state)
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
			_003Chash_003E5__2 = null;
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				int num2;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_003C_003E1__state = -3;
					num2 = 0;
					if (CqwPrWcDCLlT9m0OTFNb() == null)
					{
						goto IL_00be;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					source.ThrowIfNull("source");
					keySelector.ThrowIfNull("keySelector");
					_003Chash_003E5__2 = new HashSet<TKey>();
					_003C_003E7__wrap2 = source.GetEnumerator();
					_003C_003E1__state = -3;
				}
				goto IL_00cb;
				IL_00cb:
				while (_003C_003E7__wrap2.MoveNext())
				{
					T current = _003C_003E7__wrap2.Current;
					if (!_003Chash_003E5__2.Add(keySelector(current)))
					{
						continue;
					}
					_003C_003E2__current = current;
					_003C_003E1__state = 1;
					return true;
				}
				num2 = 1;
				if (CqwPrWcDCLlT9m0OTFNb() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_00be;
				IL_00be:
				switch (num2)
				{
				case 1:
					_003C_003Em__Finally1();
					_003C_003E7__wrap2 = null;
					return false;
				}
				goto IL_00cb;
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
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CDistinct_003Ed__5<T, TKey> _003CDistinct_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CDistinct_003Ed__ = this;
			}
			else
			{
				_003CDistinct_003Ed__ = new _003CDistinct_003Ed__5<T, TKey>(0);
			}
			_003CDistinct_003Ed__.source = _003C_003E3__source;
			_003CDistinct_003Ed__.keySelector = _003C_003E3__keySelector;
			return _003CDistinct_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool JCWunjcDsC8BKKCMUqAV()
		{
			return JoiYjxcDmXPh8hjIMX8S == null;
		}

		internal static object CqwPrWcDCLlT9m0OTFNb()
		{
			return JoiYjxcDmXPh8hjIMX8S;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownTo_003Ed__29 : IEnumerable<int>, IEnumerator<int>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int from;

		public int _003C_003E3__from;

		private int to;

		public int _003C_003E3__to;

		private static _003CDownTo_003Ed__29 SvEoKVcD7Rsg0cHO89H0;

		int IEnumerator<int>.Current
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
		public _003CDownTo_003Ed__29(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
			{
				int num = 0;
				if (SvEoKVcD7Rsg0cHO89H0 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => false, 
				};
			}
			case 1:
				_003C_003E1__state = -1;
				from--;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			if (from < to)
			{
				return false;
			}
			_003C_003E2__current = from;
			_003C_003E1__state = 1;
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
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			_003CDownTo_003Ed__29 _003CDownTo_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CDownTo_003Ed__ = this;
			}
			else
			{
				_003CDownTo_003Ed__ = new _003CDownTo_003Ed__29(0);
			}
			_003CDownTo_003Ed__.from = _003C_003E3__from;
			_003CDownTo_003Ed__.to = _003C_003E3__to;
			return _003CDownTo_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<int>)this).GetEnumerator();
		}

		internal static bool JNQgopcD4fqTyha5nNDU()
		{
			return SvEoKVcD7Rsg0cHO89H0 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownTo_003Ed__30 : IEnumerable<long>, IEnumerator<long>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private long _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private long from;

		public long _003C_003E3__from;

		private long to;

		public long _003C_003E3__to;

		internal static _003CDownTo_003Ed__30 isVHqAcDHLLgTQ6iIH2Z;

		long IEnumerator<long>.Current
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
		public _003CDownTo_003Ed__30(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				if (isVHqAcDHLLgTQ6iIH2Z == null)
				{
					switch (0)
					{
					}
				}
				from--;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			if (from < to)
			{
				return false;
			}
			_003C_003E2__current = from;
			_003C_003E1__state = 1;
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
		IEnumerator<long> IEnumerable<long>.GetEnumerator()
		{
			_003CDownTo_003Ed__30 _003CDownTo_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CDownTo_003Ed__ = this;
			}
			else
			{
				_003CDownTo_003Ed__ = new _003CDownTo_003Ed__30(0);
			}
			_003CDownTo_003Ed__.from = _003C_003E3__from;
			_003CDownTo_003Ed__.to = _003C_003E3__to;
			return _003CDownTo_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<long>)this).GetEnumerator();
		}

		static _003CDownTo_003Ed__30()
		{
		}

		internal static bool deEh2VcDzRHPoIBu97Zj()
		{
			return isVHqAcDHLLgTQ6iIH2Z == null;
		}

		internal static void e938i8c3Q0HcjaYmNcLj()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownTo_003Ed__31 : IEnumerable<decimal>, IEnumerator<decimal>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private decimal _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private decimal from;

		public decimal _003C_003E3__from;

		private decimal to;

		public decimal _003C_003E3__to;

		private static _003CDownTo_003Ed__31 jN3u1cc3FpZL6ICqFr8T;

		decimal IEnumerator<decimal>.Current
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
		public _003CDownTo_003Ed__31(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				from--;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			if (!(from >= to))
			{
				return false;
			}
			_003C_003E2__current = from;
			if (fpogitc3cNnvBk2pdWIv())
			{
				switch (0)
				{
				}
			}
			_003C_003E1__state = 1;
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
		IEnumerator<decimal> IEnumerable<decimal>.GetEnumerator()
		{
			_003CDownTo_003Ed__31 _003CDownTo_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CDownTo_003Ed__ = this;
			}
			else
			{
				_003CDownTo_003Ed__ = new _003CDownTo_003Ed__31(0);
			}
			_003CDownTo_003Ed__.from = _003C_003E3__from;
			_003CDownTo_003Ed__.to = _003C_003E3__to;
			return _003CDownTo_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<decimal>)this).GetEnumerator();
		}

		internal static void bEtTe7c3yCjbhQ4WRpDQ()
		{
		}

		internal static bool fpogitc3cNnvBk2pdWIv()
		{
			return jN3u1cc3FpZL6ICqFr8T == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPairwise_003Ed__6<T> : IEnumerable<Tuple<T, T>>, IEnumerator<Tuple<T, T>>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private Tuple<T, T> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private IEnumerator<T> _003Cenumerator_003E5__2;

		private static object G7y7nFc3pvbaniEfg451;

		Tuple<T, T> IEnumerator<Tuple<T, T>>.Current
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
		public _003CPairwise_003Ed__6(int _003C_003E1__state)
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
			T current;
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				current = _003Cenumerator_003E5__2.Current;
				goto IL_0085;
			case 0:
				{
					_003C_003E1__state = -1;
					source.ThrowIfNull("source");
					int num = 0;
					if (WycPZbc32gEXW3t2QiPh() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					_003Cenumerator_003E5__2 = source.GetEnumerator();
					if (_003Cenumerator_003E5__2.MoveNext())
					{
						current = _003Cenumerator_003E5__2.Current;
						goto IL_0085;
					}
					return false;
				}
				IL_0085:
				if (!_003Cenumerator_003E5__2.MoveNext())
				{
					return false;
				}
				_003C_003E2__current = new Tuple<T, T>(current, _003Cenumerator_003E5__2.Current);
				_003C_003E1__state = 1;
				return true;
			}
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
		IEnumerator<Tuple<T, T>> IEnumerable<Tuple<T, T>>.GetEnumerator()
		{
			_003CPairwise_003Ed__6<T> _003CPairwise_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CPairwise_003Ed__ = this;
			}
			else
			{
				_003CPairwise_003Ed__ = new _003CPairwise_003Ed__6<T>(0);
			}
			_003CPairwise_003Ed__.source = _003C_003E3__source;
			return _003CPairwise_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Tuple<T, T>>)this).GetEnumerator();
		}

		internal static bool BhIWcSc3XtACY4VRTXAq()
		{
			return G7y7nFc3pvbaniEfg451 == null;
		}

		internal static object WycPZbc32gEXW3t2QiPh()
		{
			return G7y7nFc3pvbaniEfg451;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPermutation_003Ed__18<T> : IEnumerable<T[]>, IEnumerator<T[]>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T[] _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private int n;

		public int _003C_003E3__n;

		private IEnumerator<T[]> _003C_003E7__wrap1;

		private IEnumerator<T[]> _003C_003E7__wrap2;

		internal static object j9pYysc3AEmbL465RByc;

		T[] IEnumerator<T[]>.Current
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
		public _003CPermutation_003Ed__18(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || num == 1)
			{
				try
				{
					if (num == -4 || num == 1)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = null;
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
					_003C_003E1__state = -4;
					goto IL_008a;
				}
				_003C_003E1__state = -1;
				source.ThrowIfNull("source");
				_003C_003E7__wrap1 = source.Combination(n).GetEnumerator();
				int num2 = 2;
				if (lsODbGc3eSeAvS34SigQ() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_0106;
				IL_0106:
				switch (num2)
				{
				case 2:
					break;
				default:
					goto IL_00a6;
				case 1:
					goto IL_012c;
				}
				_003C_003E1__state = -3;
				goto IL_0078;
				IL_00a6:
				T[] current = _003C_003E7__wrap1.Current;
				_003C_003E7__wrap2 = R5X0Lq9rEh(new LinkedList<T>(current), new T[current.Length], 0).GetEnumerator();
				_003C_003E1__state = -4;
				goto IL_008a;
				IL_012c:
				return true;
				IL_0078:
				if (!_003C_003E7__wrap1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = null;
					return false;
				}
				goto IL_00a6;
				IL_008a:
				if (!_003C_003E7__wrap2.MoveNext())
				{
					_003C_003Em__Finally2();
					_003C_003E7__wrap2 = null;
					goto IL_0078;
				}
				T[] current2 = _003C_003E7__wrap2.Current;
				_003C_003E2__current = current2;
				_003C_003E1__state = 1;
				num2 = 1;
				if (lsODbGc3eSeAvS34SigQ() == null)
				{
					goto IL_0106;
				}
				goto IL_012c;
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
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
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
		IEnumerator<T[]> IEnumerable<T[]>.GetEnumerator()
		{
			_003CPermutation_003Ed__18<T> _003CPermutation_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CPermutation_003Ed__ = this;
			}
			else
			{
				_003CPermutation_003Ed__ = new _003CPermutation_003Ed__18<T>(0);
			}
			_003CPermutation_003Ed__.source = _003C_003E3__source;
			_003CPermutation_003Ed__.n = _003C_003E3__n;
			return _003CPermutation_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T[]>)this).GetEnumerator();
		}

		internal static bool qsOgirc3nm5efA8g7Yly()
		{
			return j9pYysc3AEmbL465RByc == null;
		}

		internal static object lsODbGc3eSeAvS34SigQ()
		{
			return j9pYysc3AEmbL465RByc;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPermutationImpl_003Ed__20<T> : IEnumerable<T[]>, IEnumerator<T[]>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T[] _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private LinkedList<T> source;

		public LinkedList<T> _003C_003E3__source;

		private T[] part;

		public T[] _003C_003E3__part;

		private int index;

		public int _003C_003E3__index;

		private LinkedListNode<T> _003Cnode_003E5__2;

		private LinkedListNode<T> _003Clast_003E5__3;

		private IEnumerator<T[]> _003C_003E7__wrap3;

		internal static object KVL3JIc3jeSvjbTVHUIp;

		T[] IEnumerator<T[]>.Current
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
		public _003CPermutationImpl_003Ed__20(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num != -3)
			{
				if (ICGMaDc3DCPbOhIaPy9I())
				{
					switch (0)
					{
					}
				}
				if (num != 1)
				{
					goto IL_0032;
				}
			}
			try
			{
			}
			finally
			{
				_003C_003Em__Finally1();
			}
			goto IL_0032;
			IL_0032:
			_003Cnode_003E5__2 = null;
			_003Clast_003E5__3 = null;
			_003C_003E7__wrap3 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num;
				T[] current;
				int num2 = default(int);
				switch (_003C_003E1__state)
				{
				default:
					result = false;
					goto end_IL_0001;
				case 0:
					_003C_003E1__state = -1;
					if (source.Count > 0)
					{
						_003Cnode_003E5__2 = source.First;
						_003Clast_003E5__3 = null;
						goto IL_00ea;
					}
					_003C_003E2__current = part;
					_003C_003E1__state = 2;
					result = true;
					goto end_IL_0001;
				case 1:
					_003C_003E1__state = -3;
					num = 3;
					if (!ICGMaDc3DCPbOhIaPy9I())
					{
						goto IL_0198;
					}
					goto IL_019c;
				case 2:
					{
						_003C_003E1__state = -1;
						break;
					}
					IL_014b:
					if (!_003C_003E7__wrap3.MoveNext())
					{
						_003C_003Em__Finally1();
						_003C_003E7__wrap3 = null;
						if (_003Clast_003E5__3 != null)
						{
							source.AddAfter(_003Clast_003E5__3, _003Cnode_003E5__2);
						}
						else
						{
							source.AddFirst(_003Cnode_003E5__2);
						}
						_003Clast_003E5__3 = _003Cnode_003E5__2;
						_003Cnode_003E5__2 = _003Cnode_003E5__2.Next;
						goto IL_00ea;
					}
					current = _003C_003E7__wrap3.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 1;
					result = true;
					num = 0;
					if (!ICGMaDc3DCPbOhIaPy9I())
					{
						goto IL_0198;
					}
					goto IL_019c;
					IL_00ea:
					if (_003Cnode_003E5__2 != null)
					{
						part[index] = _003Cnode_003E5__2.Value;
						source.Remove(_003Cnode_003E5__2);
						_003C_003E7__wrap3 = R5X0Lq9rEh(source, part, index + 1).GetEnumerator();
						_003C_003E1__state = -3;
						goto IL_014b;
					}
					num = 1;
					if (!ICGMaDc3DCPbOhIaPy9I())
					{
						goto IL_0198;
					}
					goto IL_019c;
					IL_0198:
					num = num2;
					goto IL_019c;
					IL_019c:
					switch (num)
					{
					case 3:
						break;
					default:
						goto end_IL_0001;
					case 1:
						goto IL_01b3;
					case 2:
						goto end_IL_0001;
					}
					goto IL_014b;
					IL_01b3:
					_003Cnode_003E5__2 = null;
					_003Clast_003E5__3 = null;
					break;
				}
				result = false;
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap3 != null)
			{
				_003C_003E7__wrap3.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T[]> IEnumerable<T[]>.GetEnumerator()
		{
			_003CPermutationImpl_003Ed__20<T> _003CPermutationImpl_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CPermutationImpl_003Ed__ = this;
			}
			else
			{
				_003CPermutationImpl_003Ed__ = new _003CPermutationImpl_003Ed__20<T>(0);
			}
			_003CPermutationImpl_003Ed__.source = _003C_003E3__source;
			_003CPermutationImpl_003Ed__.part = _003C_003E3__part;
			_003CPermutationImpl_003Ed__.index = _003C_003E3__index;
			return _003CPermutationImpl_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T[]>)this).GetEnumerator();
		}

		internal static bool ICGMaDc3DCPbOhIaPy9I()
		{
			return KVL3JIc3jeSvjbTVHUIp == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRepeat_003Ed__1<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private T value;

		public T _003C_003E3__value;

		internal static object AjxQO9c3EadJwsT7yaSX;

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
		public _003CRepeat_003Ed__1(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = value;
			_003C_003E1__state = 1;
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
			_003CRepeat_003Ed__1<T> _003CRepeat_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CRepeat_003Ed__ = this;
			}
			else
			{
				_003CRepeat_003Ed__ = new _003CRepeat_003Ed__1<T>(0);
			}
			_003CRepeat_003Ed__.value = _003C_003E3__value;
			return _003CRepeat_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool Fa8Ivjc3GsZjQdPbxeIV()
		{
			return AjxQO9c3EadJwsT7yaSX == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRepeat_003Ed__2<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Func<T> init;

		public Func<T> _003C_003E3__init;

		private T _003Cv_003E5__2;

		private static object mI4EHkc31Mp6pZ6m8Fin;

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
		public _003CRepeat_003Ed__2(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003Cv_003E5__2 = default(T);
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				init.ThrowIfNull("init");
				_003Cv_003E5__2 = init();
				break;
			}
			_003C_003E2__current = _003Cv_003E5__2;
			if (Dq3sIxc3KAf6cgWTI7Hn())
			{
				switch (0)
				{
				}
			}
			_003C_003E1__state = 1;
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
			_003CRepeat_003Ed__2<T> _003CRepeat_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CRepeat_003Ed__ = this;
			}
			else
			{
				_003CRepeat_003Ed__ = new _003CRepeat_003Ed__2<T>(0);
			}
			_003CRepeat_003Ed__.init = _003C_003E3__init;
			return _003CRepeat_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool Dq3sIxc3KAf6cgWTI7Hn()
		{
			return mI4EHkc31Mp6pZ6m8Fin == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRepeat_003Ed__3<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Func<T, T> func;

		public Func<T, T> _003C_003E3__func;

		private T value;

		public T _003C_003E3__value;

		private static object EQUHUMc3vQuk2LZe83Fd;

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
		public _003CRepeat_003Ed__3(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (LtTPb5c3Ok6BD3HArGTD() != null)
				{
					switch (0)
					{
					}
				}
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				value = func(value);
			}
			else
			{
				_003C_003E1__state = -1;
				func.ThrowIfNull("func");
			}
			_003C_003E2__current = value;
			_003C_003E1__state = 1;
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
			_003CRepeat_003Ed__3<T> _003CRepeat_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CRepeat_003Ed__ = this;
			}
			else
			{
				_003CRepeat_003Ed__ = new _003CRepeat_003Ed__3<T>(0);
			}
			_003CRepeat_003Ed__.value = _003C_003E3__value;
			_003CRepeat_003Ed__.func = _003C_003E3__func;
			return _003CRepeat_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool q03Rd9c3dZoItf3VXLJi()
		{
			return EQUHUMc3vQuk2LZe83Fd == null;
		}

		internal static object LtTPb5c3Ok6BD3HArGTD()
		{
			return EQUHUMc3vQuk2LZe83Fd;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRunLength_003Ed__36<T, TResult> : IEnumerable<TResult>, IEnumerator<TResult>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private TResult _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private Func<T, int, TResult> resultSelector;

		public Func<T, int, TResult> _003C_003E3__resultSelector;

		private IEnumerator<T> _003Cenumerator_003E5__2;

		private EqualityComparer<T> _003Ceq_003E5__3;

		private T _003Ccur_003E5__4;

		private static object rAJV0Dc3JVXxPmhBYodn;

		TResult IEnumerator<TResult>.Current
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
		public _003CRunLength_003Ed__36(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || (uint)(num - 1) <= 1u)
			{
				int num2 = 0;
				if (Vt9q4Hc3aVIMZG7JgNgu() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003Cenumerator_003E5__2 = null;
			_003Ceq_003E5__3 = null;
			_003Ccur_003E5__4 = default(T);
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num2;
				T val;
				int num;
				switch (_003C_003E1__state)
				{
				default:
					num2 = 3;
					if (!cCdhQBc3khrfb8advoti())
					{
						break;
					}
					goto IL_00c7;
				case 0:
					_003C_003E1__state = -1;
					source.ThrowIfNull("source");
					resultSelector.ThrowIfNull("resultSelector");
					_003Cenumerator_003E5__2 = source.GetEnumerator();
					_003C_003E1__state = -3;
					if (_003Cenumerator_003E5__2.MoveNext())
					{
						goto IL_00dc;
					}
					result = false;
					_003C_003Em__Finally1();
					goto end_IL_0001;
				case 1:
					_003C_003E1__state = -3;
					val = _003Ccur_003E5__4;
					num = 1;
					goto IL_012b;
				case 2:
					{
						_003C_003E1__state = -3;
						_003Ceq_003E5__3 = null;
						break;
					}
					IL_012b:
					_003Ccur_003E5__4 = default(T);
					goto IL_00f5;
					IL_00c7:
					switch (num2)
					{
					case 1:
						goto end_IL_0001;
					case 3:
						result = false;
						goto end_IL_0001;
					case 2:
						goto end_IL_0009;
					}
					goto IL_00dc;
					IL_00dc:
					_003Ceq_003E5__3 = EqualityComparer<T>.Default;
					num = 1;
					val = _003Cenumerator_003E5__2.Current;
					goto IL_00f5;
					IL_00f5:
					if (!_003Cenumerator_003E5__2.MoveNext())
					{
						_003C_003E2__current = resultSelector(val, num);
						_003C_003E1__state = 2;
						result = true;
						num2 = 0;
						if (Vt9q4Hc3aVIMZG7JgNgu() != null)
						{
							goto IL_00c7;
						}
					}
					else
					{
						_003Ccur_003E5__4 = _003Cenumerator_003E5__2.Current;
						if (_003Ceq_003E5__3.Equals(val, _003Ccur_003E5__4))
						{
							num = checked(num + 1);
							goto IL_012b;
						}
						_003C_003E2__current = resultSelector(val, num);
						_003C_003E1__state = 1;
						result = true;
					}
					goto end_IL_0001;
					end_IL_0009:
					break;
				}
				_003C_003Em__Finally1();
				_003Cenumerator_003E5__2 = null;
				result = false;
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003Cenumerator_003E5__2 != null)
			{
				_003Cenumerator_003E5__2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
		{
			_003CRunLength_003Ed__36<T, TResult> _003CRunLength_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CRunLength_003Ed__ = this;
			}
			else
			{
				_003CRunLength_003Ed__ = new _003CRunLength_003Ed__36<T, TResult>(0);
			}
			_003CRunLength_003Ed__.source = _003C_003E3__source;
			_003CRunLength_003Ed__.resultSelector = _003C_003E3__resultSelector;
			return _003CRunLength_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TResult>)this).GetEnumerator();
		}

		internal static bool cCdhQBc3khrfb8advoti()
		{
			return rAJV0Dc3JVXxPmhBYodn == null;
		}

		internal static object Vt9q4Hc3aVIMZG7JgNgu()
		{
			return rAJV0Dc3JVXxPmhBYodn;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRunLengthLong_003Ed__38<T, TResult> : IEnumerable<TResult>, IEnumerator<TResult>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private TResult _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private Func<T, long, TResult> resultSelector;

		public Func<T, long, TResult> _003C_003E3__resultSelector;

		private IEnumerator<T> _003Cenumerator_003E5__2;

		private EqualityComparer<T> _003Ceq_003E5__3;

		private T _003Ccur_003E5__4;

		private static object hgvKmnc3r26MkQfNpZZ7;

		TResult IEnumerator<TResult>.Current
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
		public _003CRunLengthLong_003Ed__38(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || (uint)(num - 1) <= 1u)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003Cenumerator_003E5__2 = null;
			_003Ceq_003E5__3 = null;
			_003Ccur_003E5__4 = default(T);
			_003C_003E1__state = -2;
			int num2 = 0;
			if (!cNxOS1c3NlWuRcTjamc3())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}

		private bool MoveNext()
		{
			bool result;
			try
			{
				int num;
				T val = default(T);
				int num3;
				switch (_003C_003E1__state)
				{
				default:
					result = false;
					goto end_IL_0001;
				case 0:
					_003C_003E1__state = -1;
					source.ThrowIfNull("source");
					resultSelector.ThrowIfNull("resultSelector");
					num = 1;
					if (kDEosEc39DxCV7hLWBai() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_007d;
				case 1:
					_003C_003E1__state = -3;
					val = _003Ccur_003E5__4;
					num = 0;
					if (!cNxOS1c3NlWuRcTjamc3())
					{
						goto IL_007d;
					}
					goto IL_0092;
				case 2:
					{
						_003C_003E1__state = -3;
						break;
					}
					IL_007d:
					switch (num)
					{
					case 1:
						_003Cenumerator_003E5__2 = source.GetEnumerator();
						_003C_003E1__state = -3;
						if (_003Cenumerator_003E5__2.MoveNext())
						{
							goto IL_00cb;
						}
						result = false;
						_003C_003Em__Finally1();
						goto end_IL_0001;
					case 2:
						goto IL_00cb;
					case 3:
						goto end_IL_000b;
					}
					goto IL_0092;
					IL_00cb:
					_003Ceq_003E5__3 = EqualityComparer<T>.Default;
					num3 = 1;
					val = _003Cenumerator_003E5__2.Current;
					goto IL_0120;
					IL_0092:
					num3 = 1;
					goto IL_0114;
					IL_0114:
					_003Ccur_003E5__4 = default(T);
					goto IL_0120;
					IL_0120:
					if (_003Cenumerator_003E5__2.MoveNext())
					{
						_003Ccur_003E5__4 = _003Cenumerator_003E5__2.Current;
						if (_003Ceq_003E5__3.Equals(val, _003Ccur_003E5__4))
						{
							num3 = checked(num3 + 1);
							goto IL_0114;
						}
						_003C_003E2__current = resultSelector(val, num3);
						_003C_003E1__state = 1;
						result = true;
					}
					else
					{
						_003C_003E2__current = resultSelector(val, num3);
						_003C_003E1__state = 2;
						result = true;
					}
					goto end_IL_0001;
					end_IL_000b:
					break;
				}
				_003Ceq_003E5__3 = null;
				_003C_003Em__Finally1();
				_003Cenumerator_003E5__2 = null;
				result = false;
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003Cenumerator_003E5__2 != null)
			{
				_003Cenumerator_003E5__2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
		{
			_003CRunLengthLong_003Ed__38<T, TResult> _003CRunLengthLong_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CRunLengthLong_003Ed__ = this;
			}
			else
			{
				_003CRunLengthLong_003Ed__ = new _003CRunLengthLong_003Ed__38<T, TResult>(0);
			}
			_003CRunLengthLong_003Ed__.source = _003C_003E3__source;
			_003CRunLengthLong_003Ed__.resultSelector = _003C_003E3__resultSelector;
			return _003CRunLengthLong_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TResult>)this).GetEnumerator();
		}

		internal static bool cNxOS1c3NlWuRcTjamc3()
		{
			return hgvKmnc3r26MkQfNpZZ7 == null;
		}

		internal static object kDEosEc39DxCV7hLWBai()
		{
			return hgvKmnc3r26MkQfNpZZ7;
		}
	}

	[CompilerGenerated]
	private sealed class _003CScan_003Ed__40<T, R> : IEnumerable<R>, IEnumerator<R>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private R _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private Func<R, T, R> func;

		public Func<R, T, R> _003C_003E3__func;

		private R initial;

		public R _003C_003E3__initial;

		private IEnumerator<T> _003C_003E7__wrap1;

		internal static object gLfOd5c3LO1RvqCeI9vR;

		R IEnumerator<R>.Current
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
		public _003CScan_003Ed__40(int _003C_003E1__state)
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
			_003C_003E7__wrap1 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				int num2;
				if (num != 0)
				{
					if (num != 1)
					{
						num2 = 1;
						if (!VgRo1fc3uxQqcIcbgux3())
						{
							goto IL_0085;
						}
						goto IL_0089;
					}
					_003C_003E1__state = -3;
				}
				else
				{
					_003C_003E1__state = -1;
					source.ThrowIfNull("source");
					func.ThrowIfNull("func");
					_003C_003E7__wrap1 = source.GetEnumerator();
					_003C_003E1__state = -3;
				}
				if (!_003C_003E7__wrap1.MoveNext())
				{
					num2 = 0;
					if (!VgRo1fc3uxQqcIcbgux3())
					{
						goto IL_0085;
					}
					goto IL_0089;
				}
				T current = _003C_003E7__wrap1.Current;
				initial = func(initial, current);
				_003C_003E2__current = initial;
				_003C_003E1__state = 1;
				return true;
				IL_0089:
				switch (num2)
				{
				default:
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = null;
					return false;
				case 1:
					return false;
				}
				IL_0085:
				int num3 = default(int);
				num2 = num3;
				goto IL_0089;
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
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<R> IEnumerable<R>.GetEnumerator()
		{
			_003CScan_003Ed__40<T, R> _003CScan_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CScan_003Ed__ = this;
			}
			else
			{
				_003CScan_003Ed__ = new _003CScan_003Ed__40<T, R>(0);
			}
			_003CScan_003Ed__.source = _003C_003E3__source;
			_003CScan_003Ed__.initial = _003C_003E3__initial;
			_003CScan_003Ed__.func = _003C_003E3__func;
			return _003CScan_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<R>)this).GetEnumerator();
		}

		internal static bool VgRo1fc3uxQqcIcbgux3()
		{
			return gLfOd5c3LO1RvqCeI9vR == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CToNodes_003Ed__47<T> : IEnumerable<LinkedListNode<T>>, IEnumerator<LinkedListNode<T>>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private LinkedListNode<T> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private LinkedList<T> list;

		public LinkedList<T> _003C_003E3__list;

		private LinkedListNode<T> _003Cnode_003E5__2;

		private static object WqX8Mac3fYvxmfcP5H0N;

		LinkedListNode<T> IEnumerator<LinkedListNode<T>>.Current
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
		public _003CToNodes_003Ed__47(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003Cnode_003E5__2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				_003Cnode_003E5__2 = _003Cnode_003E5__2.Next;
				break;
			case 0:
				_003C_003E1__state = -1;
				_003Cnode_003E5__2 = list.First;
				break;
			}
			if (_003Cnode_003E5__2 == null)
			{
				return false;
			}
			_003C_003E2__current = _003Cnode_003E5__2;
			_003C_003E1__state = 1;
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
		IEnumerator<LinkedListNode<T>> IEnumerable<LinkedListNode<T>>.GetEnumerator()
		{
			_003CToNodes_003Ed__47<T> _003CToNodes_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CToNodes_003Ed__ = this;
			}
			else
			{
				_003CToNodes_003Ed__ = new _003CToNodes_003Ed__47<T>(0);
			}
			_003CToNodes_003Ed__.list = _003C_003E3__list;
			return _003CToNodes_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<LinkedListNode<T>>)this).GetEnumerator();
		}

		internal static bool culaiLc3by181D6mR08t()
		{
			return WqX8Mac3fYvxmfcP5H0N == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CToSequence_003Ed__44<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerator<T> input;

		public IEnumerator<T> _003C_003E3__input;

		internal static object ccvvWoc3iB17QEubOqZB;

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
		public _003CToSequence_003Ed__44(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			case 0:
			{
				int num = 0;
				if (!dXGnSAc3lwq984Uy1LGR())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				_003C_003E1__state = -1;
				break;
			}
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (!input.MoveNext())
			{
				return false;
			}
			_003C_003E2__current = input.Current;
			_003C_003E1__state = 1;
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
			_003CToSequence_003Ed__44<T> _003CToSequence_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CToSequence_003Ed__ = this;
			}
			else
			{
				_003CToSequence_003Ed__ = new _003CToSequence_003Ed__44<T>(0);
			}
			_003CToSequence_003Ed__.input = _003C_003E3__input;
			return _003CToSequence_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool dXGnSAc3lwq984Uy1LGR()
		{
			return ccvvWoc3iB17QEubOqZB == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CToSequence_003Ed__45 : IEnumerable<object>, IEnumerator<object>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerator input;

		public IEnumerator _003C_003E3__input;

		private static _003CToSequence_003Ed__45 aYEuZ3c35w78fc7jKbjJ;

		object IEnumerator<object>.Current
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
		public _003CToSequence_003Ed__45(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			if (!input.MoveNext())
			{
				return false;
			}
			_003C_003E2__current = input.Current;
			_003C_003E1__state = 1;
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
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			_003CToSequence_003Ed__45 _003CToSequence_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CToSequence_003Ed__ = this;
			}
			else
			{
				_003CToSequence_003Ed__ = new _003CToSequence_003Ed__45(0);
			}
			_003CToSequence_003Ed__.input = _003C_003E3__input;
			return _003CToSequence_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<object>)this).GetEnumerator();
		}

		static _003CToSequence_003Ed__45()
		{
		}

		internal static bool BiIDOHc3YmPlNKCxiCc8()
		{
			return aYEuZ3c35w78fc7jKbjJ == null;
		}

		internal static void f6nJGkc3RkrdMhSXvKi2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUnfold_003Ed__8<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Func<T, T> func;

		public Func<T, T> _003C_003E3__func;

		private T initial;

		public T _003C_003E3__initial;

		private static object ARKCiCc3g96ullnav3Mr;

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
		public _003CUnfold_003Ed__8(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				func.ThrowIfNull("func");
				_003C_003E2__current = initial;
				_003C_003E1__state = 1;
				int num = 0;
				if (nTo4yCc3MS5KhK4wEKud() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => true, 
				};
			}
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = (initial = func(initial));
			_003C_003E1__state = 2;
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
			_003CUnfold_003Ed__8<T> _003CUnfold_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUnfold_003Ed__ = this;
			}
			else
			{
				_003CUnfold_003Ed__ = new _003CUnfold_003Ed__8<T>(0);
			}
			_003CUnfold_003Ed__.initial = _003C_003E3__initial;
			_003CUnfold_003Ed__.func = _003C_003E3__func;
			return _003CUnfold_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool bCjyPlc3PpZpIZut2HVN()
		{
			return ARKCiCc3g96ullnav3Mr == null;
		}

		internal static object nTo4yCc3MS5KhK4wEKud()
		{
			return ARKCiCc3g96ullnav3Mr;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpTo_003Ed__23 : IEnumerable<int>, IEnumerator<int>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int from;

		public int _003C_003E3__from;

		private int to;

		public int _003C_003E3__to;

		private static _003CUpTo_003Ed__23 MNIcQtc3UorWpvvxnaQ3;

		int IEnumerator<int>.Current
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
		public _003CUpTo_003Ed__23(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				if (!MhDftDc3xTiXlkt3QNIZ())
				{
					switch (0)
					{
					}
				}
				return false;
			case 1:
				_003C_003E1__state = -1;
				from++;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			if (from > to)
			{
				return false;
			}
			_003C_003E2__current = from;
			_003C_003E1__state = 1;
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
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			_003CUpTo_003Ed__23 _003CUpTo_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpTo_003Ed__ = this;
			}
			else
			{
				_003CUpTo_003Ed__ = new _003CUpTo_003Ed__23(0);
			}
			_003CUpTo_003Ed__.from = _003C_003E3__from;
			_003CUpTo_003Ed__.to = _003C_003E3__to;
			return _003CUpTo_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<int>)this).GetEnumerator();
		}

		internal static bool MhDftDc3xTiXlkt3QNIZ()
		{
			return MNIcQtc3UorWpvvxnaQ3 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpTo_003Ed__24 : IEnumerable<long>, IEnumerator<long>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private long _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private long from;

		public long _003C_003E3__from;

		private long to;

		public long _003C_003E3__to;

		private static _003CUpTo_003Ed__24 W7flbDc36u5WM3rUut2w;

		long IEnumerator<long>.Current
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
		public _003CUpTo_003Ed__24(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				from++;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			if (from > to)
			{
				if (W7flbDc36u5WM3rUut2w == null)
				{
					switch (0)
					{
					}
				}
				return false;
			}
			_003C_003E2__current = from;
			_003C_003E1__state = 1;
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
		IEnumerator<long> IEnumerable<long>.GetEnumerator()
		{
			_003CUpTo_003Ed__24 _003CUpTo_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpTo_003Ed__ = this;
			}
			else
			{
				_003CUpTo_003Ed__ = new _003CUpTo_003Ed__24(0);
			}
			_003CUpTo_003Ed__.from = _003C_003E3__from;
			_003CUpTo_003Ed__.to = _003C_003E3__to;
			return _003CUpTo_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<long>)this).GetEnumerator();
		}

		internal static bool SHvBawc3tRZut55QsXtp()
		{
			return W7flbDc36u5WM3rUut2w == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpTo_003Ed__25 : IEnumerable<decimal>, IEnumerator<decimal>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private decimal _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private decimal from;

		public decimal _003C_003E3__from;

		private decimal to;

		public decimal _003C_003E3__to;

		private static _003CUpTo_003Ed__25 Hcmsllc3wqMlYytUMTeB;

		decimal IEnumerator<decimal>.Current
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
		public _003CUpTo_003Ed__25(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				from++;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			if (!(from <= to))
			{
				int num = 0;
				if (Hcmsllc3wqMlYytUMTeB != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => false, 
				};
			}
			_003C_003E2__current = from;
			_003C_003E1__state = 1;
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
		IEnumerator<decimal> IEnumerable<decimal>.GetEnumerator()
		{
			_003CUpTo_003Ed__25 _003CUpTo_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpTo_003Ed__ = this;
			}
			else
			{
				_003CUpTo_003Ed__ = new _003CUpTo_003Ed__25(0);
			}
			_003CUpTo_003Ed__.from = _003C_003E3__from;
			_003CUpTo_003Ed__.to = _003C_003E3__to;
			return _003CUpTo_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<decimal>)this).GetEnumerator();
		}

		internal static bool JlL8SAc3Tswwul3xFyKk()
		{
			return Hcmsllc3wqMlYytUMTeB == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpToInfinity_003Ed__26 : IEnumerable<int>, IEnumerator<int>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int from;

		public int _003C_003E3__from;

		internal static _003CUpToInfinity_003Ed__26 uX3S7Wc3s7MTpFX7Xh1t;

		int IEnumerator<int>.Current
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
		public _003CUpToInfinity_003Ed__26(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = from++;
			_003C_003E1__state = 1;
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
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			_003CUpToInfinity_003Ed__26 _003CUpToInfinity_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpToInfinity_003Ed__ = this;
			}
			else
			{
				_003CUpToInfinity_003Ed__ = new _003CUpToInfinity_003Ed__26(0);
			}
			_003CUpToInfinity_003Ed__.from = _003C_003E3__from;
			return _003CUpToInfinity_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<int>)this).GetEnumerator();
		}

		internal static bool S5LZfCc3CFwNIJMagsKO()
		{
			return uX3S7Wc3s7MTpFX7Xh1t == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpToInfinity_003Ed__27 : IEnumerable<long>, IEnumerator<long>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private long _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private long from;

		public long _003C_003E3__from;

		internal static _003CUpToInfinity_003Ed__27 RGnqFEc34H3uFbKjxxFp;

		long IEnumerator<long>.Current
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
		public _003CUpToInfinity_003Ed__27(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = from++;
			_003C_003E1__state = 1;
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
		IEnumerator<long> IEnumerable<long>.GetEnumerator()
		{
			_003CUpToInfinity_003Ed__27 _003CUpToInfinity_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpToInfinity_003Ed__ = this;
			}
			else
			{
				_003CUpToInfinity_003Ed__ = new _003CUpToInfinity_003Ed__27(0);
			}
			_003CUpToInfinity_003Ed__.from = _003C_003E3__from;
			return _003CUpToInfinity_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<long>)this).GetEnumerator();
		}

		internal static bool FHQXaQc3hPRIMSi2WZco()
		{
			return RGnqFEc34H3uFbKjxxFp == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpToInfinity_003Ed__28 : IEnumerable<decimal>, IEnumerator<decimal>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private decimal _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private decimal from;

		public decimal _003C_003E3__from;

		private static _003CUpToInfinity_003Ed__28 kYDjyDc3z6vimpxqW2rk;

		decimal IEnumerator<decimal>.Current
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
		public _003CUpToInfinity_003Ed__28(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = from++;
			_003C_003E1__state = 1;
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
		IEnumerator<decimal> IEnumerable<decimal>.GetEnumerator()
		{
			_003CUpToInfinity_003Ed__28 _003CUpToInfinity_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpToInfinity_003Ed__ = this;
			}
			else
			{
				_003CUpToInfinity_003Ed__ = new _003CUpToInfinity_003Ed__28(0);
			}
			_003CUpToInfinity_003Ed__.from = _003C_003E3__from;
			return _003CUpToInfinity_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<decimal>)this).GetEnumerator();
		}

		internal static bool tMyUS3cEVVyavNLaMDx6()
		{
			return kYDjyDc3z6vimpxqW2rk == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpToNegativeInfinity_003Ed__32 : IEnumerable<int>, IEnumerator<int>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int from;

		public int _003C_003E3__from;

		private static _003CUpToNegativeInfinity_003Ed__32 nt7p3McEFmrkD84QPAK3;

		int IEnumerator<int>.Current
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
		public _003CUpToNegativeInfinity_003Ed__32(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = from--;
			_003C_003E1__state = 1;
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
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			_003CUpToNegativeInfinity_003Ed__32 _003CUpToNegativeInfinity_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpToNegativeInfinity_003Ed__ = this;
			}
			else
			{
				_003CUpToNegativeInfinity_003Ed__ = new _003CUpToNegativeInfinity_003Ed__32(0);
			}
			_003CUpToNegativeInfinity_003Ed__.from = _003C_003E3__from;
			return _003CUpToNegativeInfinity_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<int>)this).GetEnumerator();
		}

		static _003CUpToNegativeInfinity_003Ed__32()
		{
		}

		internal static void kVCqOUcEyHROyKujo79L()
		{
		}

		internal static bool qNX678cEcpbwVlOFVngN()
		{
			return nt7p3McEFmrkD84QPAK3 == null;
		}

		internal static void mCihvFcEp2Pgg6mNSks9()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpToNegativeInfinity_003Ed__33 : IEnumerable<long>, IEnumerator<long>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private long _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private long from;

		public long _003C_003E3__from;

		private static _003CUpToNegativeInfinity_003Ed__33 bqeq2pcEXH5LZl0YMLtZ;

		long IEnumerator<long>.Current
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
		public _003CUpToNegativeInfinity_003Ed__33(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = from--;
			_003C_003E1__state = 1;
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
		IEnumerator<long> IEnumerable<long>.GetEnumerator()
		{
			_003CUpToNegativeInfinity_003Ed__33 _003CUpToNegativeInfinity_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpToNegativeInfinity_003Ed__ = this;
			}
			else
			{
				_003CUpToNegativeInfinity_003Ed__ = new _003CUpToNegativeInfinity_003Ed__33(0);
			}
			_003CUpToNegativeInfinity_003Ed__.from = _003C_003E3__from;
			return _003CUpToNegativeInfinity_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<long>)this).GetEnumerator();
		}

		internal static bool TxHcBbcE2PhSdY4YANL9()
		{
			return bqeq2pcEXH5LZl0YMLtZ == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpToNegativeInfinity_003Ed__34 : IEnumerable<decimal>, IEnumerator<decimal>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private decimal _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private decimal from;

		public decimal _003C_003E3__from;

		private static _003CUpToNegativeInfinity_003Ed__34 pqWvwwcEexvjIiaJtmd7;

		decimal IEnumerator<decimal>.Current
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
		public _003CUpToNegativeInfinity_003Ed__34(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			case 0:
				_003C_003E1__state = -1;
				break;
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			_003C_003E2__current = from--;
			_003C_003E1__state = 1;
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
		IEnumerator<decimal> IEnumerable<decimal>.GetEnumerator()
		{
			_003CUpToNegativeInfinity_003Ed__34 _003CUpToNegativeInfinity_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUpToNegativeInfinity_003Ed__ = this;
			}
			else
			{
				_003CUpToNegativeInfinity_003Ed__ = new _003CUpToNegativeInfinity_003Ed__34(0);
			}
			_003CUpToNegativeInfinity_003Ed__.from = _003C_003E3__from;
			return _003CUpToNegativeInfinity_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<decimal>)this).GetEnumerator();
		}

		internal static bool eEmhfUcEjhZbXg8VMqUA()
		{
			return pqWvwwcEexvjIiaJtmd7 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CUsing_003Ed__55<TSource, T> : IEnumerable<TSource>, IEnumerator<TSource>, IDisposable, IEnumerable, IEnumerator where T : IDisposable
	{
		private int _003C_003E1__state;

		private TSource _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Func<T> resourceFactory;

		public Func<T> _003C_003E3__resourceFactory;

		private Func<T, IEnumerable<TSource>> enumerableFactory;

		public Func<T, IEnumerable<TSource>> _003C_003E3__enumerableFactory;

		private T _003Cres_003E5__2;

		private IEnumerator<TSource> _003C_003E7__wrap2;

		private static object qr9BdOcE3n7MaFt7nb5r;

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
		public _003CUsing_003Ed__55(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || num == 1)
			{
				try
				{
					if (num == -4 || num == 1)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003Cres_003E5__2 = default(T);
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						_003C_003E1__state = -4;
						goto IL_00b3;
					}
					num2 = 1;
					if (ekdmvjcEGXIxdA6r6Cc8() != null)
					{
						goto IL_00a2;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					resourceFactory.ThrowIfNull("resourceFactory");
					enumerableFactory.ThrowIfNull("enumerableFactory");
					_003Cres_003E5__2 = resourceFactory();
					_003C_003E1__state = -3;
					_003C_003E7__wrap2 = enumerableFactory(_003Cres_003E5__2).GetEnumerator();
					_003C_003E1__state = -4;
					num2 = 0;
					if (ekdmvjcEGXIxdA6r6Cc8() != null)
					{
						goto IL_00a2;
					}
				}
				goto IL_00a6;
				IL_00a2:
				int num3 = default(int);
				num2 = num3;
				goto IL_00a6;
				IL_00a6:
				switch (num2)
				{
				case 1:
					return false;
				}
				goto IL_00b3;
				IL_00b3:
				if (!_003C_003E7__wrap2.MoveNext())
				{
					_003C_003Em__Finally2();
					_003C_003E7__wrap2 = null;
					_003C_003Em__Finally1();
					_003Cres_003E5__2 = default(T);
					return false;
				}
				TSource current = _003C_003E7__wrap2.Current;
				_003C_003E2__current = current;
				_003C_003E1__state = 1;
				return true;
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
			if (_003Cres_003E5__2 != null)
			{
				_003Cres_003E5__2.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
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
			_003CUsing_003Ed__55<TSource, T> _003CUsing_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CUsing_003Ed__ = this;
			}
			else
			{
				_003CUsing_003Ed__ = new _003CUsing_003Ed__55<TSource, T>(0);
			}
			_003CUsing_003Ed__.resourceFactory = _003C_003E3__resourceFactory;
			_003CUsing_003Ed__.enumerableFactory = _003C_003E3__enumerableFactory;
			return _003CUsing_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TSource>)this).GetEnumerator();
		}

		internal static bool XOdYfHcEEafJrGiLjpAL()
		{
			return qr9BdOcE3n7MaFt7nb5r == null;
		}

		internal static object ekdmvjcEGXIxdA6r6Cc8()
		{
			return qr9BdOcE3n7MaFt7nb5r;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWalk_003Ed__57<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private T obj;

		public T _003C_003E3__obj;

		private Func<T, T> selector;

		public Func<T, T> _003C_003E3__selector;

		private Predicate<T> cond;

		public Predicate<T> _003C_003E3__cond;

		private T _003Ccurrent_003E5__2;

		internal static object FRVYI8cE0YlJXuHHd3nL;

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
		public _003CWalk_003Ed__57(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003Ccurrent_003E5__2 = default(T);
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
			{
				_003C_003E1__state = -1;
				int num = 0;
				if (GePFcHcEKNelsMf8PBOC() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				_003Ccurrent_003E5__2 = selector(_003Ccurrent_003E5__2);
				break;
			}
			case 0:
				_003C_003E1__state = -1;
				_003Ccurrent_003E5__2 = obj;
				break;
			}
			if (!cond(_003Ccurrent_003E5__2))
			{
				return false;
			}
			_003C_003E2__current = _003Ccurrent_003E5__2;
			_003C_003E1__state = 1;
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
			_003CWalk_003Ed__57<T> _003CWalk_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CWalk_003Ed__ = this;
			}
			else
			{
				_003CWalk_003Ed__ = new _003CWalk_003Ed__57<T>(0);
			}
			_003CWalk_003Ed__.obj = _003C_003E3__obj;
			_003CWalk_003Ed__.selector = _003C_003E3__selector;
			_003CWalk_003Ed__.cond = _003C_003E3__cond;
			return _003CWalk_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool kN4N0ncE1pJF2XSveZbA()
		{
			return FRVYI8cE0YlJXuHHd3nL == null;
		}

		internal static object GePFcHcEKNelsMf8PBOC()
		{
			return FRVYI8cE0YlJXuHHd3nL;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWalk_003Ed__58<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private T obj;

		public T _003C_003E3__obj;

		private Func<T, IEnumerable<T>> selector;

		public Func<T, IEnumerable<T>> _003C_003E3__selector;

		private IEnumerator<T> _003C_003E7__wrap1;

		private IEnumerator<T> _003C_003E7__wrap2;

		internal static object pj6QjacEB0lci2hrGGMR;

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
		public _003CWalk_003Ed__58(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || num == 2)
			{
				try
				{
					if (num == -4 || num == 2)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = null;
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num;
				T current;
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
				{
					_003C_003E1__state = -1;
					T val = obj;
					_003C_003E2__current = val;
					_003C_003E1__state = 1;
					return true;
				}
				case 1:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = selector(obj).GetEnumerator();
					goto IL_00a4;
				case 2:
					{
						_003C_003E1__state = -4;
						goto IL_0123;
					}
					IL_00a4:
					_003C_003E1__state = -3;
					goto IL_00ac;
					IL_00ac:
					if (!_003C_003E7__wrap1.MoveNext())
					{
						_003C_003Em__Finally1();
						_003C_003E7__wrap1 = null;
						num = 1;
						if (!VKaMvycEvuVNDRtUFu30())
						{
							break;
						}
						goto IL_00d2;
					}
					current = _003C_003E7__wrap1.Current;
					_003C_003E7__wrap2 = current.Walk(selector).GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_0123;
					IL_0123:
					if (_003C_003E7__wrap2.MoveNext())
					{
						T current2 = _003C_003E7__wrap2.Current;
						_003C_003E2__current = current2;
						num = 0;
						if (bhmbVacEdpavhSydNOdp() != null)
						{
							int num2 = default(int);
							num = num2;
						}
						goto IL_00d2;
					}
					_003C_003Em__Finally2();
					_003C_003E7__wrap2 = null;
					goto IL_00ac;
					IL_00d2:
					switch (num)
					{
					case 2:
						break;
					case 1:
						return false;
					default:
						goto end_IL_000b;
					}
					goto IL_00a4;
					end_IL_000b:
					break;
				}
				_003C_003E1__state = 2;
				return true;
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
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
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
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CWalk_003Ed__58<T> _003CWalk_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CWalk_003Ed__ = this;
			}
			else
			{
				_003CWalk_003Ed__ = new _003CWalk_003Ed__58<T>(0);
			}
			_003CWalk_003Ed__.obj = _003C_003E3__obj;
			_003CWalk_003Ed__.selector = _003C_003E3__selector;
			return _003CWalk_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool VKaMvycEvuVNDRtUFu30()
		{
			return pj6QjacEB0lci2hrGGMR == null;
		}

		internal static object bhmbVacEdpavhSydNOdp()
		{
			return pj6QjacEB0lci2hrGGMR;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWithCancellation_003Ed__46<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<T> input;

		public IEnumerable<T> _003C_003E3__input;

		private CancellationToken token;

		public CancellationToken _003C_003E3__token;

		private IEnumerator<T> _003C_003E7__wrap1;

		private static object Cl0xyecEOMN475dkuXpm;

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
		public _003CWithCancellation_003Ed__46(int _003C_003E1__state)
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
			_003C_003E7__wrap1 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _003C_003E1__state;
				int num2;
				if (num != 0)
				{
					if (num != 1)
					{
						result = false;
						num2 = 0;
						if (!SwiAiPcEJcfTOhYqcKnX())
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_007b;
					}
					_003C_003E1__state = -3;
				}
				else
				{
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = input.GetEnumerator();
					_003C_003E1__state = -3;
				}
				if (!_003C_003E7__wrap1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = null;
					num2 = 0;
					if (xCDTqPcEkkvoiSYi39hm() != null)
					{
						goto IL_007b;
					}
					goto IL_008a;
				}
				T current = _003C_003E7__wrap1.Current;
				token.ThrowIfCancellationRequested();
				_003C_003E2__current = current;
				_003C_003E1__state = 1;
				result = true;
				goto end_IL_0001;
				IL_008a:
				result = false;
				goto end_IL_0001;
				IL_007b:
				switch (num2)
				{
				default:
					goto end_IL_0001;
				case 1:
					break;
				}
				goto IL_008a;
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CWithCancellation_003Ed__46<T> _003CWithCancellation_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CWithCancellation_003Ed__ = this;
			}
			else
			{
				_003CWithCancellation_003Ed__ = new _003CWithCancellation_003Ed__46<T>(0);
			}
			_003CWithCancellation_003Ed__.input = _003C_003E3__input;
			_003CWithCancellation_003Ed__.token = _003C_003E3__token;
			return _003CWithCancellation_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool SwiAiPcEJcfTOhYqcKnX()
		{
			return Cl0xyecEOMN475dkuXpm == null;
		}

		internal static object xCDTqPcEkkvoiSYi39hm()
		{
			return Cl0xyecEOMN475dkuXpm;
		}
	}

	internal static object HgAZJY3x11nuGHgBEhC;

	public static IEnumerable<T> Make<T>(params T[] values)
	{
		return values;
	}

	[IteratorStateMachine(typeof(_003CRepeat_003Ed__1<>))]
	public static IEnumerable<T> Repeat<T>(T value)
	{
		return new _003CRepeat_003Ed__1<T>(-2)
		{
			_003C_003E3__value = value
		};
	}

	[IteratorStateMachine(typeof(_003CRepeat_003Ed__2<>))]
	public static IEnumerable<T> Repeat<T>(Func<T> init)
	{
		return new _003CRepeat_003Ed__2<T>(-2)
		{
			_003C_003E3__init = init
		};
	}

	[IteratorStateMachine(typeof(_003CRepeat_003Ed__3<>))]
	public static IEnumerable<T> Repeat<T>(T value, Func<T, T> func)
	{
		return new _003CRepeat_003Ed__3<T>(-2)
		{
			_003C_003E3__value = value,
			_003C_003E3__func = func
		};
	}

	public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source)
	{
		return source ?? new T[0];
	}

	[IteratorStateMachine(typeof(_003CDistinct_003Ed__5<, >))]
	public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		return new _003CDistinct_003Ed__5<T, TKey>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__keySelector = keySelector
		};
	}

	[IteratorStateMachine(typeof(_003CPairwise_003Ed__6<>))]
	public static IEnumerable<Tuple<T, T>> Pairwise<T>(this IEnumerable<T> source)
	{
		return new _003CPairwise_003Ed__6<T>(-2)
		{
			_003C_003E3__source = source
		};
	}

	[IteratorStateMachine(typeof(_003CAlternate_003Ed__7<>))]
	public static IEnumerable<T> Alternate<T>(IEnumerable<T> source1, IEnumerable<T> source2)
	{
		return new _003CAlternate_003Ed__7<T>(-2)
		{
			_003C_003E3__source1 = source1,
			_003C_003E3__source2 = source2
		};
	}

	[IteratorStateMachine(typeof(_003CUnfold_003Ed__8<>))]
	public static IEnumerable<T> Unfold<T>(this T initial, Func<T, T> func)
	{
		return new _003CUnfold_003Ed__8<T>(-2)
		{
			_003C_003E3__initial = initial,
			_003C_003E3__func = func
		};
	}

	public static R Let<T, R>(this T var, Func<T, R> func)
	{
		func.ThrowIfNull("func");
		return func(var);
	}

	[IteratorStateMachine(typeof(_003CCycle_003Ed__10<>))]
	public static IEnumerable<T> Cycle<T>(this IEnumerable<T> source)
	{
		return new _003CCycle_003Ed__10<T>(-2)
		{
			_003C_003E3__source = source
		};
	}

	[IteratorStateMachine(typeof(_003CCycle_003Ed__11<>))]
	public static IEnumerable<T> Cycle<T>(T item1, T item2)
	{
		return new _003CCycle_003Ed__11<T>(-2)
		{
			_003C_003E3__item1 = item1,
			_003C_003E3__item2 = item2
		};
	}

	[IteratorStateMachine(typeof(_003CCycle_003Ed__12<>))]
	public static IEnumerable<T> Cycle<T>(T item1, T item2, T item3)
	{
		return new _003CCycle_003Ed__12<T>(-2)
		{
			_003C_003E3__item1 = item1,
			_003C_003E3__item2 = item2,
			_003C_003E3__item3 = item3
		};
	}

	[IteratorStateMachine(typeof(_003CCycle_003Ed__13<>))]
	public static IEnumerable<T> Cycle<T>(T item1, T item2, T item3, T item4)
	{
		return new _003CCycle_003Ed__13<T>(-2)
		{
			_003C_003E3__item1 = item1,
			_003C_003E3__item2 = item2,
			_003C_003E3__item3 = item3,
			_003C_003E3__item4 = item4
		};
	}

	public static IEnumerable<T[]> Combination<T>(this IEnumerable<T> source)
	{
		source.ThrowIfNull("source");
		T[] array = source.ToArray();
		int int_ = array.Length;
		return cEN0tpqOg5(array, int_);
	}

	public static IEnumerable<T[]> Combination<T>(this IEnumerable<T> source, int n)
	{
		source.ThrowIfNull("source");
		if (n < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return cEN0tpqOg5(source.ToArray(), n);
	}

	[IteratorStateMachine(typeof(_003CCombinationImpl_003Ed__16<>))]
	private static IEnumerable<DspJPxpymFrcPDvGXu[]> cEN0tpqOg5<DspJPxpymFrcPDvGXu>(DspJPxpymFrcPDvGXu[] gparam_0, int int_0)
	{
		return new _003CCombinationImpl_003Ed__16<DspJPxpymFrcPDvGXu>(-2)
		{
			_003C_003E3__source = gparam_0,
			_003C_003E3__n = int_0
		};
	}

	private static bool dm20gWZ0Ih(int int_0, int int_1, int[] int_2)
	{
		int num = int_1 - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (int_2[num] >= int_0 - int_1 + num)
				{
					if (num == 0)
					{
						break;
					}
					num--;
					continue;
				}
				int_2[num]++;
				for (int i = 1; num + i < int_1; i++)
				{
					int_2[num + i] = int_2[num] + i;
					if (!yd9Y5Z3I2hpRFhOKT8b())
					{
						switch (0)
						{
						}
					}
				}
			}
			return true;
		}
		return false;
	}

	[IteratorStateMachine(typeof(_003CPermutation_003Ed__18<>))]
	public static IEnumerable<T[]> Permutation<T>(this IEnumerable<T> source, int n)
	{
		return new _003CPermutation_003Ed__18<T>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__n = n
		};
	}

	public static IEnumerable<T[]> Permutation<T>(this IEnumerable<T> source)
	{
		source.ThrowIfNull("source");
		LinkedList<T> linkedList = new LinkedList<T>(source);
		return R5X0Lq9rEh(linkedList, new T[linkedList.Count], 0);
	}

	[IteratorStateMachine(typeof(_003CPermutationImpl_003Ed__20<>))]
	private static IEnumerable<dn52K9adtX4l9M1t8i[]> R5X0Lq9rEh<dn52K9adtX4l9M1t8i>(LinkedList<dn52K9adtX4l9M1t8i> linkedList_0, dn52K9adtX4l9M1t8i[] gparam_0, int int_0)
	{
		return new _003CPermutationImpl_003Ed__20<dn52K9adtX4l9M1t8i>(-2)
		{
			_003C_003E3__source = linkedList_0,
			_003C_003E3__part = gparam_0,
			_003C_003E3__index = int_0
		};
	}

	public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
	{
		source.ThrowIfNull("source");
		action.ThrowIfNull("action");
		foreach (T item in source)
		{
			action(item);
		}
	}

	public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
	{
		source.ThrowIfNull("source");
		action.ThrowIfNull("action");
		int num = 0;
		foreach (T item in source)
		{
			action(item, num++);
		}
	}

	[IteratorStateMachine(typeof(_003CUpTo_003Ed__23))]
	public static IEnumerable<int> UpTo(this int from, int to)
	{
		return new _003CUpTo_003Ed__23(-2)
		{
			_003C_003E3__from = from,
			_003C_003E3__to = to
		};
	}

	[IteratorStateMachine(typeof(_003CUpTo_003Ed__24))]
	public static IEnumerable<long> UpTo(this long from, long to)
	{
		return new _003CUpTo_003Ed__24(-2)
		{
			_003C_003E3__from = from,
			_003C_003E3__to = to
		};
	}

	[IteratorStateMachine(typeof(_003CUpTo_003Ed__25))]
	public static IEnumerable<decimal> UpTo(this decimal from, decimal to)
	{
		return new _003CUpTo_003Ed__25(-2)
		{
			_003C_003E3__from = from,
			_003C_003E3__to = to
		};
	}

	[IteratorStateMachine(typeof(_003CUpToInfinity_003Ed__26))]
	public static IEnumerable<int> UpToInfinity(this int from)
	{
		return new _003CUpToInfinity_003Ed__26(-2)
		{
			_003C_003E3__from = from
		};
	}

	[IteratorStateMachine(typeof(_003CUpToInfinity_003Ed__27))]
	public static IEnumerable<long> UpToInfinity(this long from)
	{
		return new _003CUpToInfinity_003Ed__27(-2)
		{
			_003C_003E3__from = from
		};
	}

	[IteratorStateMachine(typeof(_003CUpToInfinity_003Ed__28))]
	public static IEnumerable<decimal> UpToInfinity(this decimal from)
	{
		return new _003CUpToInfinity_003Ed__28(-2)
		{
			_003C_003E3__from = from
		};
	}

	[IteratorStateMachine(typeof(_003CDownTo_003Ed__29))]
	public static IEnumerable<int> DownTo(this int from, int to)
	{
		return new _003CDownTo_003Ed__29(-2)
		{
			_003C_003E3__from = from,
			_003C_003E3__to = to
		};
	}

	[IteratorStateMachine(typeof(_003CDownTo_003Ed__30))]
	public static IEnumerable<long> DownTo(this long from, long to)
	{
		return new _003CDownTo_003Ed__30(-2)
		{
			_003C_003E3__from = from,
			_003C_003E3__to = to
		};
	}

	[IteratorStateMachine(typeof(_003CDownTo_003Ed__31))]
	public static IEnumerable<decimal> DownTo(this decimal from, decimal to)
	{
		return new _003CDownTo_003Ed__31(-2)
		{
			_003C_003E3__from = from,
			_003C_003E3__to = to
		};
	}

	[IteratorStateMachine(typeof(_003CUpToNegativeInfinity_003Ed__32))]
	public static IEnumerable<int> UpToNegativeInfinity(this int from)
	{
		return new _003CUpToNegativeInfinity_003Ed__32(-2)
		{
			_003C_003E3__from = from
		};
	}

	[IteratorStateMachine(typeof(_003CUpToNegativeInfinity_003Ed__33))]
	public static IEnumerable<long> UpToNegativeInfinity(this long from)
	{
		return new _003CUpToNegativeInfinity_003Ed__33(-2)
		{
			_003C_003E3__from = from
		};
	}

	[IteratorStateMachine(typeof(_003CUpToNegativeInfinity_003Ed__34))]
	public static IEnumerable<decimal> UpToNegativeInfinity(this decimal from)
	{
		return new _003CUpToNegativeInfinity_003Ed__34(-2)
		{
			_003C_003E3__from = from
		};
	}

	public static IEnumerable<Tuple<T, int>> RunLength<T>(this IEnumerable<T> source)
	{
		return source.RunLength(_003C_003Ec__35<T>._003C_003E9__35_0 ?? (_003C_003Ec__35<T>._003C_003E9__35_0 = _003C_003Ec__35<T>._003C_003E9.L0FvyRvvZnq));
	}

	[IteratorStateMachine(typeof(_003CRunLength_003Ed__36<, >))]
	public static IEnumerable<TResult> RunLength<T, TResult>(this IEnumerable<T> source, Func<T, int, TResult> resultSelector)
	{
		return new _003CRunLength_003Ed__36<T, TResult>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__resultSelector = resultSelector
		};
	}

	public static IEnumerable<Tuple<T, long>> RunLengthLong<T>(this IEnumerable<T> source)
	{
		return source.RunLengthLong(_003C_003Ec__37<T>._003C_003E9__37_0 ?? (_003C_003Ec__37<T>._003C_003E9__37_0 = _003C_003Ec__37<T>._003C_003E9.Qu5vyqkEFkP));
	}

	[IteratorStateMachine(typeof(_003CRunLengthLong_003Ed__38<, >))]
	public static IEnumerable<TResult> RunLengthLong<T, TResult>(this IEnumerable<T> source, Func<T, long, TResult> resultSelector)
	{
		return new _003CRunLengthLong_003Ed__38<T, TResult>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__resultSelector = resultSelector
		};
	}

	public static IEnumerable<R> Scan<T, R>(this IEnumerable<T> source, Func<R, T, R> func)
	{
		return source.Scan(default(R), func);
	}

	[IteratorStateMachine(typeof(_003CScan_003Ed__40<, >))]
	public static IEnumerable<R> Scan<T, R>(this IEnumerable<T> source, R initial, Func<R, T, R> func)
	{
		return new _003CScan_003Ed__40<T, R>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__initial = initial,
			_003C_003E3__func = func
		};
	}

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
	{
		source.ThrowIfNull("source");
		T[] array = source.ToArray();
		Ext.Shuffle(array);
		return array;
	}

	public static IEnumerable<T> Slice<T>(this IEnumerable<T> source, int start)
	{
		_003C_003Ec__DisplayClass42_0<T> _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0<T>();
		_003C_003Ec__DisplayClass42_.start = start;
		source.ThrowIfNull("source");
		return source.Where(_003C_003Ec__DisplayClass42_.K8yvy9px29f);
	}

	public static IEnumerable<T> Slice<T>(this IEnumerable<T> source, int start, int count)
	{
		_003C_003Ec__DisplayClass43_0<T> _003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0<T>();
		_003C_003Ec__DisplayClass43_.start = start;
		source.ThrowIfNull("source");
		_003C_003Ec__DisplayClass43_.end = _003C_003Ec__DisplayClass43_.start + count;
		return source.Where(_003C_003Ec__DisplayClass43_.juhvyhLCTeP).Where(_003C_003Ec__DisplayClass43_.GqAvyeNC4rp);
	}

	[IteratorStateMachine(typeof(_003CToSequence_003Ed__44<>))]
	public static IEnumerable<T> ToSequence<T>(this IEnumerator<T> input)
	{
		return new _003CToSequence_003Ed__44<T>(-2)
		{
			_003C_003E3__input = input
		};
	}

	[IteratorStateMachine(typeof(_003CToSequence_003Ed__45))]
	public static IEnumerable ToSequence(this IEnumerator input)
	{
		return new _003CToSequence_003Ed__45(-2)
		{
			_003C_003E3__input = input
		};
	}

	[IteratorStateMachine(typeof(_003CWithCancellation_003Ed__46<>))]
	public static IEnumerable<T> WithCancellation<T>(this IEnumerable<T> input, CancellationToken token)
	{
		return new _003CWithCancellation_003Ed__46<T>(-2)
		{
			_003C_003E3__input = input,
			_003C_003E3__token = token
		};
	}

	[IteratorStateMachine(typeof(_003CToNodes_003Ed__47<>))]
	public static IEnumerable<LinkedListNode<T>> ToNodes<T>(this LinkedList<T> list)
	{
		return new _003CToNodes_003Ed__47<T>(-2)
		{
			_003C_003E3__list = list
		};
	}

	public static IEnumerable<T> Memoize<T>(this IEnumerable<T> list)
	{
		list.ThrowIfNull("list");
		return new HPboCMdXasgZL9oPam8<T>(list);
	}

	public static TValue GetOrCreateWeakReference<TKey, TValue>(this IDictionary<TKey, WeakReference<TValue>> dict, TKey key, Func<TValue> valueFactory) where TValue : class
	{
		dict.ThrowIfNull("dict");
		valueFactory.ThrowIfNull("valueFactory");
		if (dict.TryGetValue(key, out var value) && value.TryGetTarget(out var target))
		{
			return target;
		}
		target = valueFactory();
		dict[key] = new WeakReference<TValue>(target);
		return target;
	}

	public static TValue GetOrCreateWeakReference<TKey, TValue>(this IDictionary<TKey, WeakReference<TValue>> dict, TKey key, Func<TValue> valueFactory, int limit) where TValue : class
	{
		TValue orCreateWeakReference = dict.GetOrCreateWeakReference(key, valueFactory);
		if (dict.Count > limit)
		{
			dict.CleanWeakReferences();
		}
		return orCreateWeakReference;
	}

	public static void CleanWeakReferences<TKey, TValue>(this IDictionary<TKey, WeakReference<TValue>> dict) where TValue : class
	{
		TKey[] array = dict.Where(_003C_003Ec__52<TKey, TValue>._003C_003E9__52_0 ?? (_003C_003Ec__52<TKey, TValue>._003C_003E9__52_0 = _003C_003Ec__52<TKey, TValue>._003C_003E9.En1vyc9a4qO)).Select(_003C_003Ec__52<TKey, TValue>._003C_003E9__52_1 ?? (_003C_003Ec__52<TKey, TValue>._003C_003E9__52_1 = _003C_003Ec__52<TKey, TValue>._003C_003E9.D7GvyV0Tg0s)).ToArray();
		foreach (TKey key in array)
		{
			dict.Remove(key);
		}
	}

	public static TValue GetOrCreateWeakReference<TKey, TValue>(this LinkedList<KeyValuePair<WeakReference<TKey>, TValue>> list, TKey key, Func<TValue> valueFactory) where TKey : class
	{
		list.ThrowIfNull("list");
		key.ThrowIfNull("key");
		valueFactory.ThrowIfNull("valueFactory");
		LinkedListNode<KeyValuePair<WeakReference<TKey>, TValue>> linkedListNode = list.First;
		KeyValuePair<WeakReference<TKey>, TValue> value;
		while (true)
		{
			if (linkedListNode != null)
			{
				value = linkedListNode.Value;
				if (value.Key.TryGetTarget(out var target))
				{
					if (target.Equals(key))
					{
						break;
					}
				}
				else
				{
					list.Remove(linkedListNode);
				}
				linkedListNode = linkedListNode.Next;
				continue;
			}
			TValue val = valueFactory();
			list.AddFirst(new KeyValuePair<WeakReference<TKey>, TValue>(new WeakReference<TKey>(key), val));
			return val;
		}
		return value.Value;
	}

	[IteratorStateMachine(typeof(_003CDefer_003Ed__54<>))]
	public static IEnumerable<TResult> Defer<TResult>(Func<IEnumerable<TResult>> enumerableFactory)
	{
		return new _003CDefer_003Ed__54<TResult>(-2)
		{
			_003C_003E3__enumerableFactory = enumerableFactory
		};
	}

	[IteratorStateMachine(typeof(_003CUsing_003Ed__55<, >))]
	public static IEnumerable<TSource> Using<TSource, T>(Func<T> resourceFactory, Func<T, IEnumerable<TSource>> enumerableFactory) where T : IDisposable
	{
		return new _003CUsing_003Ed__55<TSource, T>(-2)
		{
			_003C_003E3__resourceFactory = resourceFactory,
			_003C_003E3__enumerableFactory = enumerableFactory
		};
	}

	public static IEnumerable<T> Walk<T>(this T obj, Func<T, T> selector)
	{
		return obj.Walk(selector, _003C_003Ec__56<T>._003C_003E9__56_0 ?? (_003C_003Ec__56<T>._003C_003E9__56_0 = _003C_003Ec__56<T>._003C_003E9.eT2vyZWTd5q));
	}

	[IteratorStateMachine(typeof(_003CWalk_003Ed__57<>))]
	public static IEnumerable<T> Walk<T>(this T obj, Func<T, T> selector, Predicate<T> cond)
	{
		return new _003CWalk_003Ed__57<T>(-2)
		{
			_003C_003E3__obj = obj,
			_003C_003E3__selector = selector,
			_003C_003E3__cond = cond
		};
	}

	[IteratorStateMachine(typeof(_003CWalk_003Ed__58<>))]
	public static IEnumerable<T> Walk<T>(this T obj, Func<T, IEnumerable<T>> selector)
	{
		return new _003CWalk_003Ed__58<T>(-2)
		{
			_003C_003E3__obj = obj,
			_003C_003E3__selector = selector
		};
	}

	internal static bool yd9Y5Z3I2hpRFhOKT8b()
	{
		return HgAZJY3x11nuGHgBEhC == null;
	}
}
