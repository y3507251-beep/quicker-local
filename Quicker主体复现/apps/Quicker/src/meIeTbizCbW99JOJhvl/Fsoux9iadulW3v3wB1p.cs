using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GgqjxvmAflYydLlFSxA;
using NDyVL2iQCoEgScBbqCd;
using Quicker.Pinyin;
using Quicker.Utilities.Pinyin;

namespace meIeTbizCbW99JOJhvl;

internal class Fsoux9iadulW3v3wB1p : FwaPKUm5Z2KRWYqLcpm
{
	[CompilerGenerated]
	private sealed class _003CTryMatch_003Ed__1 : IDisposable, IEnumerable, IEnumerator, IEnumerable<e1YYLUiBPWxe4nF4maA>, IEnumerator<e1YYLUiBPWxe4nF4maA>
	{
		private int _003C_003E1__state;

		private e1YYLUiBPWxe4nF4maA _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string pattern;

		public string _003C_003E3__pattern;

		private int posInPattern;

		public int _003C_003E3__posInPattern;

		private string text;

		public string _003C_003E3__text;

		public Fsoux9iadulW3v3wB1p _003C_003E4__this;

		private int _003Ci_003E5__2;

		private static _003CTryMatch_003Ed__1 KiS0Q3ya12ieNCLnZSZm;

		e1YYLUiBPWxe4nF4maA IEnumerator<e1YYLUiBPWxe4nF4maA>.Current
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
		public _003CTryMatch_003Ed__1(int _003C_003E1__state)
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
			Fsoux9iadulW3v3wB1p fsoux9iadulW3v3wB1p = _003C_003E4__this;
			int num2;
			int num3;
			int num4 = default(int);
			BitVector64 bitVector64_2 = default(BitVector64);
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				num2 = 0;
				if (gOnb7LyaKsGDFpyA0r8X())
				{
					goto IL_00ab;
				}
				goto IL_00d1;
			case 1:
				_003C_003E1__state = -1;
				return false;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0182;
			case 3:
				{
					_003C_003E1__state = -1;
					_003Ci_003E5__2--;
					goto IL_0176;
				}
				IL_00ab:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_00d1;
				case 3:
					goto IL_0176;
				case 2:
					goto end_IL_0012;
				}
				goto IL_00c2;
				IL_00d1:
				num3 = -1;
				if (char.IsLetter(pattern[posInPattern]))
				{
					for (int i = 0; i < fsoux9iadulW3v3wB1p.NQNvJrv1l91() && posInPattern + i < pattern.Length && Helper.IsSameOrUpper(text[fsoux9iadulW3v3wB1p.JncvJbVan3F() + i], pattern[posInPattern + i]); i++)
					{
						num3 = i;
					}
					if (num3 != -1)
					{
						if (num3 < pattern.Length - posInPattern - 1)
						{
							_003Ci_003E5__2 = num3;
							goto IL_0176;
						}
						BitVector64 bitVector64_ = default(BitVector64);
						for (int j = 0; j <= num3; j++)
						{
							bitVector64_.Set(fsoux9iadulW3v3wB1p.JncvJbVan3F() + j);
						}
						_003C_003E2__current = new e1YYLUiBPWxe4nF4maA(num3 + 1, bitVector64_);
						_003C_003E1__state = 2;
						return true;
					}
					return false;
				}
				_003C_003E2__current = new e1YYLUiBPWxe4nF4maA();
				_003C_003E1__state = 1;
				return true;
				IL_00c2:
				if (num4 <= _003Ci_003E5__2)
				{
					bitVector64_2.Set(fsoux9iadulW3v3wB1p.JncvJbVan3F() + num4);
					num4++;
					num2 = 1;
					if (!gOnb7LyaKsGDFpyA0r8X())
					{
						int num5 = default(int);
						num2 = num5;
					}
					goto IL_00ab;
				}
				_003C_003E2__current = new e1YYLUiBPWxe4nF4maA(_003Ci_003E5__2 + 1, bitVector64_2);
				break;
				IL_0176:
				if (_003Ci_003E5__2 >= 0)
				{
					bitVector64_2 = default(BitVector64);
					num4 = 0;
					goto IL_00c2;
				}
				goto IL_0182;
				IL_0182:
				return false;
				end_IL_0012:
				break;
			}
			_003C_003E1__state = 3;
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
		IEnumerator<e1YYLUiBPWxe4nF4maA> IEnumerable<e1YYLUiBPWxe4nF4maA>.GetEnumerator()
		{
			_003CTryMatch_003Ed__1 _003CTryMatch_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CTryMatch_003Ed__ = this;
			}
			else
			{
				_003CTryMatch_003Ed__ = new _003CTryMatch_003Ed__1(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CTryMatch_003Ed__.text = _003C_003E3__text;
			_003CTryMatch_003Ed__.pattern = _003C_003E3__pattern;
			_003CTryMatch_003Ed__.posInPattern = _003C_003E3__posInPattern;
			return _003CTryMatch_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<e1YYLUiBPWxe4nF4maA>)this).GetEnumerator();
		}

		internal static bool gOnb7LyaKsGDFpyA0r8X()
		{
			return KiS0Q3ya12ieNCLnZSZm == null;
		}
	}

	internal static Fsoux9iadulW3v3wB1p KMeLETcFc8715jshXt0H;

	public Fsoux9iadulW3v3wB1p(short short_2, short short_3)
	{
		bj3vJ6wIJC1(short_2);
		RfIvJp2CZFS(short_3);
	}

	[IteratorStateMachine(typeof(_003CTryMatch_003Ed__1))]
	public override IEnumerable<e1YYLUiBPWxe4nF4maA> TryMatch(string string_0, string string_1, int int_0, bool bool_0)
	{
		return new _003CTryMatch_003Ed__1(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__text = string_0,
			_003C_003E3__pattern = string_1,
			_003C_003E3__posInPattern = int_0
		};
	}

	public override int UKQMIPtUO33(string string_0, string string_1, int int_0, bool bool_0)
	{
		return TvBvJxh1DtU(string_0, string_1, int_0);
	}

	internal static bool mDUO7VcFW54FPLQwKVBq()
	{
		return KMeLETcFc8715jshXt0H == null;
	}
}
