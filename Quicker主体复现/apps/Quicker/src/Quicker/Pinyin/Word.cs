using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using qgnh0JiJCUj4XCaowwH;

namespace Quicker.Pinyin;

public class Word
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass26_0
	{
		public string bVt28kgc5eV;

		public string YNt28GOs3u6;

		public int oMe28sFYKZx;
	}

	[CompilerGenerated]
	private sealed class _003CGetPossibleMatchLengthOfEnglishWord_003Ed__28 : IEnumerable<int>, IEnumerator<int>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int posInQuery;

		public int _003C_003E3__posInQuery;

		private string query;

		public string _003C_003E3__query;

		public Word _003C_003E4__this;

		private string text;

		public string _003C_003E3__text;

		private int _003CleftInQuery_003E5__2;

		private int _003CfullMatchLength_003E5__3;

		internal static _003CGetPossibleMatchLengthOfEnglishWord_003Ed__28 dZGqeRya5JcVnRdUsmem;

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
		public _003CGetPossibleMatchLengthOfEnglishWord_003Ed__28(int _003C_003E1__state)
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
			Word word = _003C_003E4__this;
			int num3;
			bool flag = default(bool);
			int num2 = default(int);
			switch (num)
			{
			default:
				num3 = 2;
				if (dZGqeRya5JcVnRdUsmem != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				goto IL_00f7;
			case 0:
				_003C_003E1__state = -1;
				if (posInQuery >= query.Length)
				{
					return false;
				}
				_003CleftInQuery_003E5__2 = query.Length - posInQuery;
				_003CfullMatchLength_003E5__3 = Math.Min(_003CleftInQuery_003E5__2, word.Length);
				flag = true;
				num2 = 0;
				goto IL_0092;
			case 1:
				_003C_003E1__state = -1;
				if (_003CleftInQuery_003E5__2 > _003CfullMatchLength_003E5__3)
				{
					_003C_003E2__current = 1;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0167;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0167;
			case 3:
				{
					_003C_003E1__state = -1;
					return false;
				}
				IL_0124:
				_003C_003E2__current = _003CfullMatchLength_003E5__3;
				_003C_003E1__state = 1;
				return true;
				IL_0167:
				return false;
				IL_00f7:
				switch (num3)
				{
				case 1:
					goto IL_0124;
				case 2:
					return false;
				}
				goto IL_0092;
				IL_0092:
				while (num2 < _003CfullMatchLength_003E5__3)
				{
					if (!RGYv0JXj75E(text[num2 + word.StartIndex], query[posInQuery + num2], true))
					{
						flag = false;
						break;
					}
					num2++;
					num3 = 0;
					if (dZGqeRya5JcVnRdUsmem == null)
					{
						continue;
					}
					goto IL_00f7;
				}
				if (flag)
				{
					num3 = 1;
					if (wTKkyuyaYwkFuajDyUnN())
					{
						goto IL_00f7;
					}
					goto IL_0124;
				}
				if (num2 > 0)
				{
					_003C_003E2__current = 1;
					_003C_003E1__state = 3;
					return true;
				}
				return false;
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
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			_003CGetPossibleMatchLengthOfEnglishWord_003Ed__28 _003CGetPossibleMatchLengthOfEnglishWord_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetPossibleMatchLengthOfEnglishWord_003Ed__ = this;
			}
			else
			{
				_003CGetPossibleMatchLengthOfEnglishWord_003Ed__ = new _003CGetPossibleMatchLengthOfEnglishWord_003Ed__28(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CGetPossibleMatchLengthOfEnglishWord_003Ed__.text = _003C_003E3__text;
			_003CGetPossibleMatchLengthOfEnglishWord_003Ed__.query = _003C_003E3__query;
			_003CGetPossibleMatchLengthOfEnglishWord_003Ed__.posInQuery = _003C_003E3__posInQuery;
			return _003CGetPossibleMatchLengthOfEnglishWord_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<int>)this).GetEnumerator();
		}

		static _003CGetPossibleMatchLengthOfEnglishWord_003Ed__28()
		{
		}

		internal static bool wTKkyuyaYwkFuajDyUnN()
		{
			return dZGqeRya5JcVnRdUsmem == null;
		}

		internal static void hf0p3PyaMi2ejYkkH4NM()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetPossibleMatchLengthOfPinyin_003Ed__25 : IEnumerable<int>, IEnumerator<int>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private char hanzi;

		public char _003C_003E3__hanzi;

		private string query;

		public string _003C_003E3__query;

		private int posInQuery;

		public int _003C_003E3__posInQuery;

		private bool[] _003CmatchPoints_003E5__2;

		private int _003Ci_003E5__3;

		internal static _003CGetPossibleMatchLengthOfPinyin_003Ed__25 o8tFouyaUegqXSm7DvmV;

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
		public _003CGetPossibleMatchLengthOfPinyin_003Ed__25(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003CmatchPoints_003E5__2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
        int num2 = default;
        bool flag = default;
        string text = default;
        int length = default;
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_0159;
			}
			_003C_003E1__state = -1;
			text = XRlL56iKFaTMc4ji9eS.v2rvNxu3DgM(hanzi);
			length = query.Length - posInQuery;
			_003CmatchPoints_003E5__2 = new bool[16];
			flag = true;
			num2 = 0;
			goto IL_0199;
			IL_01ae:
			return true;
			IL_0125:
			int num3;
			while (true)
			{
				switch (num3)
				{
				case 1:
					goto end_IL_0125;
				case 2:
					goto IL_01ae;
				}
				num2++;
				num3 = 1;
				if (p2QHcCyax769Hpdolp9a())
				{
					continue;
				}
				goto IL_0121;
				continue;
				end_IL_0125:
				break;
			}
			goto IL_0199;
			IL_0199:
			if (num2 < text.Length)
			{
				if (flag)
				{
					(bool, int) tuple = IsFullMatch(text, num2, query, posInQuery, length);
					if (tuple.Item1)
					{
						_003CmatchPoints_003E5__2[tuple.Item2 - 1] = true;
						_003CmatchPoints_003E5__2[0] = true;
					}
					if (!_003CmatchPoints_003E5__2[1] && tuple.Item2 > 1 && (text[num2 + 1] == 'h' || text[num2 + 1] == 'H'))
					{
						_003CmatchPoints_003E5__2[1] = true;
					}
					if (tuple.Item2 > 0)
					{
						_003CmatchPoints_003E5__2[0] = true;
					}
				}
				flag = text[num2] == ' ';
				num3 = 0;
				if (o8tFouyaUegqXSm7DvmV != null)
				{
					goto IL_0121;
				}
				goto IL_0125;
			}
			_003Ci_003E5__3 = _003CmatchPoints_003E5__2.Length - 1;
			goto IL_016b;
			IL_0159:
			_003Ci_003E5__3--;
			goto IL_016b;
			IL_016b:
			if (_003Ci_003E5__3 >= 0)
			{
				if (!_003CmatchPoints_003E5__2[_003Ci_003E5__3])
				{
					goto IL_0159;
				}
				_003C_003E2__current = _003Ci_003E5__3 + 1;
				_003C_003E1__state = 1;
				num3 = 2;
				if (o8tFouyaUegqXSm7DvmV == null)
				{
					goto IL_0125;
				}
				goto IL_01ae;
			}
			return false;
			IL_0121:
			int num4 = default(int);
			num3 = num4;
			goto IL_0125;
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
			_003CGetPossibleMatchLengthOfPinyin_003Ed__25 _003CGetPossibleMatchLengthOfPinyin_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetPossibleMatchLengthOfPinyin_003Ed__ = this;
			}
			else
			{
				_003CGetPossibleMatchLengthOfPinyin_003Ed__ = new _003CGetPossibleMatchLengthOfPinyin_003Ed__25(0);
			}
			_003CGetPossibleMatchLengthOfPinyin_003Ed__.hanzi = _003C_003E3__hanzi;
			_003CGetPossibleMatchLengthOfPinyin_003Ed__.query = _003C_003E3__query;
			_003CGetPossibleMatchLengthOfPinyin_003Ed__.posInQuery = _003C_003E3__posInQuery;
			return _003CGetPossibleMatchLengthOfPinyin_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<int>)this).GetEnumerator();
		}

		internal static bool p2QHcCyax769Hpdolp9a()
		{
			return o8tFouyaUegqXSm7DvmV == null;
		}
	}

	[CompilerGenerated]
	private int lOQv0E4mKXC;

	[CompilerGenerated]
	private int NmYv0yZ0qyD;

	[CompilerGenerated]
	private bool o7sv08ixt2j;

	[CompilerGenerated]
	private string fgTv0aq5Asn;

	[CompilerGenerated]
	private IList<string> ksvv078J3Bs;

	private static int VZYv0RVY1KO;

	private static Word Mk8nAocFUn041FmjoAVe;

	public int StartIndex
	{
		[CompilerGenerated]
		get
		{
			return lOQv0E4mKXC;
		}
		[CompilerGenerated]
		set
		{
			lOQv0E4mKXC = value;
		}
	}

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return NmYv0yZ0qyD;
		}
		[CompilerGenerated]
		set
		{
			NmYv0yZ0qyD = value;
		}
	}

	public bool IsCn
	{
		[CompilerGenerated]
		get
		{
			return o7sv08ixt2j;
		}
		[CompilerGenerated]
		set
		{
			o7sv08ixt2j = value;
		}
	}

	public string OriginText
	{
		[CompilerGenerated]
		get
		{
			return fgTv0aq5Asn;
		}
		[CompilerGenerated]
		set
		{
			fgTv0aq5Asn = value;
		}
	}

	public IList<string> MatchList
	{
		[CompilerGenerated]
		get
		{
			return ksvv078J3Bs;
		}
		[CompilerGenerated]
		set
		{
			ksvv078J3Bs = value;
		}
	}

	public Word(int startIndex, int length, bool isCn, string text)
	{
		StartIndex = startIndex;
		Length = length;
		IsCn = isCn;
		OriginText = text;
	}

	public string GetOriginWord(string text)
	{
		return text.Substring(StartIndex, Length);
	}

	public int TryMatch(string text, string query, int posInQuery)
	{
		if (Length == 1)
		{
			char c = text[StartIndex];
			if (RGYv0JXj75E(c, query[posInQuery], true))
			{
				return 1;
			}
			if (IsCn)
			{
				return GetMaxPinyinMatchLength(c, query, posInQuery);
			}
			return 0;
		}
		return jaTv0NsMIgj(text, query, posInQuery);
	}

	public IEnumerable<int> Match(string text, string query, int posInQuery)
	{
		if (Length == 1)
		{
			char c = text[StartIndex];
			if (RGYv0JXj75E(c, query[posInQuery], true))
			{
				return new int[1] { 1 };
			}
			if (IsCn)
			{
				return GetPossibleMatchLengthOfPinyin(c, query, posInQuery);
			}
			return Array.Empty<int>();
		}
		return GetPossibleMatchLengthOfEnglishWord(text, query, posInQuery);
	}

	private int jaTv0NsMIgj(string string_1, string string_2, int int_3)
	{
		if (int_3 >= string_2.Length)
		{
			return 0;
		}
		int num = 0;
		for (num = 0; num < Length && num < string_2.Length - int_3; num++)
		{
			if (!RGYv0JXj75E(string_1[StartIndex + num], string_2[int_3 + num], true))
			{
				return num;
			}
		}
		return num;
	}

	[IteratorStateMachine(typeof(_003CGetPossibleMatchLengthOfPinyin_003Ed__25))]
	public static IEnumerable<int> GetPossibleMatchLengthOfPinyin(char hanzi, string query, int posInQuery)
	{
		return new _003CGetPossibleMatchLengthOfPinyin_003Ed__25(-2)
		{
			_003C_003E3__hanzi = hanzi,
			_003C_003E3__query = query,
			_003C_003E3__posInQuery = posInQuery
		};
	}

	public static int GetMaxPinyinMatchLength(char hanzi, string query, int posInQuery)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_0_ = default(_003C_003Ec__DisplayClass26_0);
		_003C_003Ec__DisplayClass26_0_.YNt28GOs3u6 = query;
		_003C_003Ec__DisplayClass26_0_.oMe28sFYKZx = posInQuery;
		_003C_003Ec__DisplayClass26_0_.bVt28kgc5eV = XRlL56iKFaTMc4ji9eS.v2rvNxu3DgM(hanzi);
		int num = 0;
		bool flag = true;
		int num3 = default(int);
		for (int i = 0; i < _003C_003Ec__DisplayClass26_0_.bVt28kgc5eV.Length; i++)
		{
			if (flag)
			{
				int num2 = 0;
				if (Mk8nAocFUn041FmjoAVe != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				default:
				{
					int num4 = r6Pv0PHv3N8(i, ref _003C_003Ec__DisplayClass26_0_);
					if (num4 > num)
					{
						num = num4;
					}
					break;
				}
				}
			}
			flag = _003C_003Ec__DisplayClass26_0_.bVt28kgc5eV[i] == ' ';
		}
		return num;
	}

	public static (bool isFullMatch, int lastMatchPos) IsFullMatch(string text, int textPos, string query, int queryPos, int length)
	{
		if (length <= 0)
		{
			return (isFullMatch: false, lastMatchPos: 0);
		}
		bool item = true;
		int i;
		for (i = 0; i < length && textPos + i < text.Length && text[textPos + i] != ' '; i++)
		{
			if (!RGYv0JXj75E(text[textPos + i], query[queryPos + i], true))
			{
				item = false;
				break;
			}
		}
		return (isFullMatch: item, lastMatchPos: i);
	}

	[IteratorStateMachine(typeof(_003CGetPossibleMatchLengthOfEnglishWord_003Ed__28))]
	public IEnumerable<int> GetPossibleMatchLengthOfEnglishWord(string text, string query, int posInQuery)
	{
		return new _003CGetPossibleMatchLengthOfEnglishWord_003Ed__28(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__text = text,
			_003C_003E3__query = query,
			_003C_003E3__posInQuery = posInQuery
		};
	}

	public bool IsFirstCharMatch(string text, char ch)
	{
		if (IsCn)
		{
			return XRlL56iKFaTMc4ji9eS.GmHvNpLOZ3b(text[StartIndex]).IndexOf(ch, 0) >= 0;
		}
		return RGYv0JXj75E(text[StartIndex], ch, true);
	}

	private static bool RGYv0JXj75E(char char_0, char char_1, bool bool_1)
	{
		if (bool_1 && Evgv006b7OC(char_0))
		{
			int num = Math.Abs(char_0 - char_1);
			if (num != 0)
			{
				return num == VZYv0RVY1KO;
			}
			return true;
		}
		return char_0 == char_1;
	}

	private static bool Evgv006b7OC(char char_0)
	{
		if (char_0 >= 'a' && char_0 <= 'z')
		{
			return true;
		}
		if (char_0 >= 'A')
		{
			return char_0 <= 'Z';
		}
		return false;
	}

	private static bool DMgv0CpBEG8(string string_1, char char_0)
	{
		bool flag = true;
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				if (flag && RGYv0JXj75E(string_1[num], char_0, true))
				{
					break;
				}
				flag = string_1[num] == ' ';
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	static Word()
	{
		VZYv0RVY1KO = Math.Abs(-32);
	}

	[CompilerGenerated]
	internal static int r6Pv0PHv3N8(int int_3, ref _003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_0_0)
	{
		int num = 0;
		for (num = 0; num < _003C_003Ec__DisplayClass26_0_0.bVt28kgc5eV.Length - int_3 && num < _003C_003Ec__DisplayClass26_0_0.YNt28GOs3u6.Length - _003C_003Ec__DisplayClass26_0_0.oMe28sFYKZx; num++)
		{
			if (!RGYv0JXj75E(_003C_003Ec__DisplayClass26_0_0.bVt28kgc5eV[int_3 + num], _003C_003Ec__DisplayClass26_0_0.YNt28GOs3u6[_003C_003Ec__DisplayClass26_0_0.oMe28sFYKZx + num], true))
			{
				return num;
			}
		}
		return num;
	}

	internal static bool Xg9CcpcFxE3qHcjYEAFu()
	{
		return Mk8nAocFUn041FmjoAVe == null;
	}
}
