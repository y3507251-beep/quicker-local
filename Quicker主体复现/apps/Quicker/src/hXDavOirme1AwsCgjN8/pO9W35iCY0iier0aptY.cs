using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NDyVL2iQCoEgScBbqCd;
using qgnh0JiJCUj4XCaowwH;
using Quicker.Pinyin;
using Quicker.Utilities.Pinyin;
using s1H993mqNCkpDdM1vC5;

namespace hXDavOirme1AwsCgjN8;

internal class pO9W35iCY0iier0aptY : IJ4vWZmlHsi92DoGSsc
{
	[CompilerGenerated]
	private sealed class _003CTryMatch_003Ed__4 : IDisposable, IEnumerable, IEnumerator, IEnumerable<e1YYLUiBPWxe4nF4maA>, IEnumerator<e1YYLUiBPWxe4nF4maA>
	{
		private int _003C_003E1__state;

		private e1YYLUiBPWxe4nF4maA _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string pattern;

		public string _003C_003E3__pattern;

		private int posInPattern;

		public int _003C_003E3__posInPattern;

		public pO9W35iCY0iier0aptY _003C_003E4__this;

		private bool onlyFirstChar;

		public bool _003C_003E3__onlyFirstChar;

		private bool _003CfirstCharMatched_003E5__2;

		private int _003Cindex_003E5__3;

		private static _003CTryMatch_003Ed__4 c7g1R6yaeobgBmrZ4teB;

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
		public _003CTryMatch_003Ed__4(int _003C_003E1__state)
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
			pO9W35iCY0iier0aptY pO9W35iCY0iier0aptY2 = _003C_003E4__this;
			int num2 = 5;
			string text = default(string);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num3;
				e1YYLUiBPWxe4nF4maA e1YYLUiBPWxe4nF4maA3;
				switch (num)
				{
				case 5:
					_003C_003E1__state = -1;
					goto IL_0154;
				case 4:
					_003C_003E1__state = -1;
					goto IL_011f;
				case 1:
					_003C_003E1__state = -1;
					goto IL_0178;
				case 0:
					_003C_003E1__state = -1;
					if (!pattern[posInPattern].IsLower())
					{
						_003C_003E2__current = e1YYLUiBPWxe4nF4maA.Empty;
						_003C_003E1__state = 1;
						return true;
					}
					goto IL_0178;
				default:
					return false;
				case 2:
					_003C_003E1__state = -1;
					return false;
				case 3:
					{
						_003C_003E1__state = -1;
						return false;
					}
					IL_00df:
					for (int i = 0; i < pO9W35iCY0iier0aptY2.GU9vJHWZ0Le.Length; i++)
					{
						if (pattern[posInPattern] == pO9W35iCY0iier0aptY2.GU9vJHWZ0Le[i][0])
						{
							_003CfirstCharMatched_003E5__2 = true;
							e1YYLUiBPWxe4nF4maA e1YYLUiBPWxe4nF4maA = new e1YYLUiBPWxe4nF4maA();
							e1YYLUiBPWxe4nF4maA.R4lvJvaZsjL(1);
							e1YYLUiBPWxe4nF4maA.QC1vJNCNW8Y = new BitVector64(pO9W35iCY0iier0aptY2.JncvJbVan3F());
							_003C_003E2__current = e1YYLUiBPWxe4nF4maA;
							_003C_003E1__state = 4;
							return true;
						}
					}
					goto IL_011f;
					IL_0178:
					if (pattern[posInPattern] != pO9W35iCY0iier0aptY2.w20vJ13fA7X)
					{
						if (onlyFirstChar)
						{
							for (int j = 0; j < pO9W35iCY0iier0aptY2.GU9vJHWZ0Le.Length; j++)
							{
								if (pattern[posInPattern] == pO9W35iCY0iier0aptY2.GU9vJHWZ0Le[j][0])
								{
									e1YYLUiBPWxe4nF4maA e1YYLUiBPWxe4nF4maA2 = new e1YYLUiBPWxe4nF4maA();
									e1YYLUiBPWxe4nF4maA2.R4lvJvaZsjL(1);
									e1YYLUiBPWxe4nF4maA2.QC1vJNCNW8Y = new BitVector64(pO9W35iCY0iier0aptY2.JncvJbVan3F());
									_003C_003E2__current = e1YYLUiBPWxe4nF4maA2;
									_003C_003E1__state = 3;
									return true;
								}
							}
							num3 = 0;
							if (c7g1R6yaeobgBmrZ4teB != null)
							{
								goto IL_00ad;
							}
							goto IL_02c7;
						}
						_003CfirstCharMatched_003E5__2 = false;
						goto IL_00df;
					}
					e1YYLUiBPWxe4nF4maA3 = new e1YYLUiBPWxe4nF4maA();
					e1YYLUiBPWxe4nF4maA3.R4lvJvaZsjL(1);
					e1YYLUiBPWxe4nF4maA3.QC1vJNCNW8Y = new BitVector64(pO9W35iCY0iier0aptY2.JncvJbVan3F());
					_003C_003E2__current = e1YYLUiBPWxe4nF4maA3;
					_003C_003E1__state = 2;
					goto IL_02c9;
					IL_00d2:
					while (num4 < text.Length && posInPattern + num4 < pattern.Length)
					{
						if (pattern[posInPattern + num4] == text[num4])
						{
							num4++;
							continue;
						}
						goto IL_009c;
					}
					goto IL_014d;
					IL_009c:
					num3 = 0;
					if (!DLyxt0yajPBml4BbOxCp())
					{
						num3 = num2;
					}
					goto IL_00ad;
					IL_011f:
					if (_003CfirstCharMatched_003E5__2)
					{
						_003Cindex_003E5__3 = 0;
						goto IL_0131;
					}
					return false;
					IL_02c9:
					return true;
					IL_02c7:
					return false;
					IL_00ad:
					switch (num3)
					{
					case 4:
						break;
					case 3:
						goto IL_00df;
					default:
						goto IL_014a;
					case 5:
						goto end_IL_0225;
					case 1:
						goto IL_02c7;
					case 2:
						goto IL_02c9;
					}
					goto IL_00d2;
					IL_0154:
					_003Cindex_003E5__3++;
					goto IL_0131;
					IL_0131:
					if (_003Cindex_003E5__3 < pO9W35iCY0iier0aptY2.GU9vJHWZ0Le.Length)
					{
						text = pO9W35iCY0iier0aptY2.GU9vJHWZ0Le[_003Cindex_003E5__3];
						flag = true;
						num4 = 0;
						if (posInPattern != 0 || pattern.Length >= text.Length)
						{
							num4 = 0;
							goto IL_00d2;
						}
						goto IL_0154;
					}
					goto IL_02c7;
					IL_014a:
					flag = false;
					goto IL_014d;
					IL_014d:
					if (flag)
					{
						e1YYLUiBPWxe4nF4maA e1YYLUiBPWxe4nF4maA4 = new e1YYLUiBPWxe4nF4maA();
						e1YYLUiBPWxe4nF4maA4.R4lvJvaZsjL(num4);
						e1YYLUiBPWxe4nF4maA4.QC1vJNCNW8Y = new BitVector64(pO9W35iCY0iier0aptY2.JncvJbVan3F());
						_003C_003E2__current = e1YYLUiBPWxe4nF4maA4;
						_003C_003E1__state = 5;
						return true;
					}
					goto IL_0154;
					end_IL_0225:
					break;
				}
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
		IEnumerator<e1YYLUiBPWxe4nF4maA> IEnumerable<e1YYLUiBPWxe4nF4maA>.GetEnumerator()
		{
			_003CTryMatch_003Ed__4 _003CTryMatch_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CTryMatch_003Ed__ = this;
			}
			else
			{
				_003CTryMatch_003Ed__ = new _003CTryMatch_003Ed__4(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CTryMatch_003Ed__.pattern = _003C_003E3__pattern;
			_003CTryMatch_003Ed__.posInPattern = _003C_003E3__posInPattern;
			_003CTryMatch_003Ed__.onlyFirstChar = _003C_003E3__onlyFirstChar;
			return _003CTryMatch_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<e1YYLUiBPWxe4nF4maA>)this).GetEnumerator();
		}

		internal static void cSu7MPya3KQWq3p6Wc2N()
		{
		}

		internal static bool DLyxt0yajPBml4BbOxCp()
		{
			return c7g1R6yaeobgBmrZ4teB == null;
		}
	}

	private string[] GU9vJHWZ0Le;

	private char w20vJ13fA7X;

	private static pO9W35iCY0iier0aptY ul4W3HcQCR5grYx7NoD7;

	public pO9W35iCY0iier0aptY(string string_1, short short_1)
	{
		bj3vJ6wIJC1(short_1);
		w20vJ13fA7X = string_1[short_1];
		GU9vJHWZ0Le = XRlL56iKFaTMc4ji9eS.bjDvN5ExdKB(string_1, short_1) ?? Array.Empty<string>();
	}

	public bool DwpvJGSiqoD(char char_1)
	{
		string[] gU9vJHWZ0Le = GU9vJHWZ0Le;
		int num = 0;
		while (true)
		{
			if (num < gU9vJHWZ0Le.Length)
			{
				if (gU9vJHWZ0Le[num][0] == char_1)
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

	[IteratorStateMachine(typeof(_003CTryMatch_003Ed__4))]
	public override IEnumerable<e1YYLUiBPWxe4nF4maA> TryMatch(string string_1, string string_2, int int_0, bool bool_0)
	{
		return new _003CTryMatch_003Ed__4(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__pattern = string_2,
			_003C_003E3__posInPattern = int_0,
			_003C_003E3__onlyFirstChar = bool_0
		};
	}

	public override int UKQMIPtUO33(string string_1, string string_2, int int_0, bool bool_0)
	{
		if (string_2[int_0] == w20vJ13fA7X)
		{
			return 1;
		}
		if (bool_0)
		{
			int num = 0;
			while (true)
			{
				if (num < GU9vJHWZ0Le.Length)
				{
					if (string_2[int_0] == GU9vJHWZ0Le[num][0])
					{
						break;
					}
					num++;
					continue;
				}
				return 0;
			}
			int num2 = 0;
			if (!K3KFnWcQ7ByE4FmnkXLw())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			default:
				default(BitVector64).Set(JncvJbVan3F());
				return 1;
			}
		}
		int num4 = 0;
		for (int i = 0; i < GU9vJHWZ0Le.Length; i++)
		{
			int num5 = adwvJsxvqUs(GU9vJHWZ0Le[i], string_2, int_0);
			if (num5 > num4)
			{
				num4 = num5;
			}
		}
		return num4;
	}

	private int adwvJsxvqUs(string string_1, string string_2, int int_0)
	{
		int num = int_0;
		int num2 = string_1.Length - 1;
		while (num2 >= 0 && num >= 0)
		{
			if (string_1[num2] == string_2[num])
			{
				num--;
			}
			num2--;
		}
		return int_0 - num;
	}

	internal static bool K3KFnWcQ7ByE4FmnkXLw()
	{
		return ul4W3HcQCR5grYx7NoD7 == null;
	}
}
