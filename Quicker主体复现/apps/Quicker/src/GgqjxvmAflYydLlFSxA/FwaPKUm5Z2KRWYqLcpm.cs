using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NDyVL2iQCoEgScBbqCd;
using Quicker.Pinyin;
using Quicker.Utilities.Pinyin;
using s1H993mqNCkpDdM1vC5;

namespace GgqjxvmAflYydLlFSxA;

internal abstract class FwaPKUm5Z2KRWYqLcpm : IJ4vWZmlHsi92DoGSsc
{
	[CompilerGenerated]
	private sealed class _003CTryMatchContains_003Ed__4 : IDisposable, IEnumerable, IEnumerator, IEnumerable<e1YYLUiBPWxe4nF4maA>, IEnumerator<e1YYLUiBPWxe4nF4maA>
	{
		private int _003C_003E1__state;

		private e1YYLUiBPWxe4nF4maA _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int posInPattern;

		public int _003C_003E3__posInPattern;

		private string text;

		public string _003C_003E3__text;

		public FwaPKUm5Z2KRWYqLcpm _003C_003E4__this;

		private string pattern;

		public string _003C_003E3__pattern;

		private bool allowEmptyMatch;

		public bool _003C_003E3__allowEmptyMatch;

		private static _003CTryMatchContains_003Ed__4 Jf4xHmyad9cf4BUVpfB0;

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
		public _003CTryMatchContains_003Ed__4(int _003C_003E1__state)
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
			FwaPKUm5Z2KRWYqLcpm fwaPKUm5Z2KRWYqLcpm = _003C_003E4__this;
			BitVector64 bitVector64_;
			int num3;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				bitVector64_ = default(BitVector64);
				int num2 = posInPattern;
				for (int i = 0; i < fwaPKUm5Z2KRWYqLcpm.NQNvJrv1l91(); i++)
				{
					if (posInPattern >= pattern.Length)
					{
						break;
					}
					if (Helper.IsSameOrUpper(text[fwaPKUm5Z2KRWYqLcpm.JncvJbVan3F() + i], pattern[posInPattern]))
					{
						posInPattern++;
						bitVector64_.Set(fwaPKUm5Z2KRWYqLcpm.JncvJbVan3F() + i);
					}
				}
				if (bitVector64_.Data > 0L)
				{
					_003C_003E2__current = new e1YYLUiBPWxe4nF4maA(posInPattern - num2, bitVector64_);
					_003C_003E1__state = 1;
					return true;
				}
				if (allowEmptyMatch)
				{
					num3 = 1;
					if (Jf4xHmyad9cf4BUVpfB0 == null)
					{
						goto IL_00fc;
					}
					goto IL_0122;
				}
				return false;
			}
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00fc:
				_003C_003E2__current = new e1YYLUiBPWxe4nF4maA(0, bitVector64_);
				_003C_003E1__state = 2;
				num3 = 0;
				if (!UNBb0fyaO5iXpxkQceJa())
				{
					int num4 = default(int);
					num3 = num4;
				}
				goto IL_0122;
				IL_0122:
				switch (num3)
				{
				case 1:
					break;
				default:
					return true;
				}
				goto IL_00fc;
			}
			return false;
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
			_003CTryMatchContains_003Ed__4 _003CTryMatchContains_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CTryMatchContains_003Ed__ = this;
			}
			else
			{
				_003CTryMatchContains_003Ed__ = new _003CTryMatchContains_003Ed__4(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CTryMatchContains_003Ed__.text = _003C_003E3__text;
			_003CTryMatchContains_003Ed__.pattern = _003C_003E3__pattern;
			_003CTryMatchContains_003Ed__.posInPattern = _003C_003E3__posInPattern;
			_003CTryMatchContains_003Ed__.allowEmptyMatch = _003C_003E3__allowEmptyMatch;
			return _003CTryMatchContains_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<e1YYLUiBPWxe4nF4maA>)this).GetEnumerator();
		}

		internal static bool UNBb0fyaO5iXpxkQceJa()
		{
			return Jf4xHmyad9cf4BUVpfB0 == null;
		}
	}

	[CompilerGenerated]
	private short ffMvJQ1AthR;

	internal static FwaPKUm5Z2KRWYqLcpm qZpqojcFAoDcACUfJb66;

	[SpecialName]
	[CompilerGenerated]
	public short NQNvJrv1l91()
	{
		return ffMvJQ1AthR;
	}

	[SpecialName]
	[CompilerGenerated]
	public void RfIvJp2CZFS(short short_2)
	{
		ffMvJQ1AthR = short_2;
	}

	[IteratorStateMachine(typeof(_003CTryMatchContains_003Ed__4))]
	public IEnumerable<e1YYLUiBPWxe4nF4maA> wKlvJKc6pra(string string_0, string string_1, int int_0, bool bool_0)
	{
		return new _003CTryMatchContains_003Ed__4(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__text = string_0,
			_003C_003E3__pattern = string_1,
			_003C_003E3__posInPattern = int_0,
			_003C_003E3__allowEmptyMatch = bool_0
		};
	}

	public int TvBvJxh1DtU(string string_0, string string_1, int int_0)
	{
		BitVector64 bitVector = default(BitVector64);
		int num = int_0;
		int num2 = NQNvJrv1l91() - 1;
		if (!OviM6vcFnM1CoytG6G1w())
		{
			switch (0)
			{
			}
		}
		while (num2 >= 0 && num >= 0)
		{
			if (Helper.IsSameOrUpper(string_0[JncvJbVan3F() + num2], string_1[num]))
			{
				bitVector.Set(JncvJbVan3F() + num2);
				num--;
			}
			num2--;
		}
		if (num == int_0)
		{
			return 0;
		}
		return int_0 - num;
	}

	internal static bool OviM6vcFnM1CoytG6G1w()
	{
		return qZpqojcFAoDcACUfJb66 == null;
	}
}
