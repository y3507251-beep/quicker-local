using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Public.Searching;

namespace Quicker.Pinyin;

[Obsolete("请使用Mixed.Matcher")]
public class FullMatcher
{
	[CompilerGenerated]
	private sealed class _003CExtractRanges_003Ed__15 : IDisposable, IEnumerable, IEnumerator, IEnumerable<MatchRange>, IEnumerator<MatchRange>
	{
		private int _003C_003E1__state;

		private MatchRange _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private bool[] array;

		public bool[] _003C_003E3__array;

		private int _003Ci_003E5__2;

		private static _003CExtractRanges_003Ed__15 TlAaIGyaLL7ts01AMPdI;

		MatchRange IEnumerator<MatchRange>.Current
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
		public _003CExtractRanges_003Ed__15(int _003C_003E1__state)
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
			MatchRange matchRange;
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				matchRange = null;
				_003Ci_003E5__2 = 0;
				goto IL_007f;
			case 1:
				_003C_003E1__state = -1;
				matchRange = null;
				goto IL_006d;
			case 2:
				{
					_003C_003E1__state = -1;
					matchRange = null;
					int num = 0;
					if (!KbDWYLyau3KuFKgfsDA2())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						goto end_IL_000a;
					}
					goto IL_00b9;
				}
				IL_00b9:
				if (!array[_003Ci_003E5__2])
				{
					if (matchRange != null)
					{
						_003C_003E2__current = matchRange;
						_003C_003E1__state = 1;
						return true;
					}
				}
				else if (matchRange == null)
				{
					matchRange = new MatchRange(_003Ci_003E5__2, _003Ci_003E5__2);
				}
				else
				{
					matchRange.End = _003Ci_003E5__2;
				}
				goto IL_006d;
				IL_006d:
				_003Ci_003E5__2++;
				goto IL_007f;
				IL_007f:
				if (_003Ci_003E5__2 >= array.Length)
				{
					if (matchRange != null)
					{
						_003C_003E2__current = matchRange;
						_003C_003E1__state = 2;
						return true;
					}
					break;
				}
				goto IL_00b9;
				end_IL_000a:
				break;
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
		IEnumerator<MatchRange> IEnumerable<MatchRange>.GetEnumerator()
		{
			_003CExtractRanges_003Ed__15 _003CExtractRanges_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CExtractRanges_003Ed__ = this;
			}
			else
			{
				_003CExtractRanges_003Ed__ = new _003CExtractRanges_003Ed__15(0);
			}
			_003CExtractRanges_003Ed__.array = _003C_003E3__array;
			return _003CExtractRanges_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<MatchRange>)this).GetEnumerator();
		}

		internal static bool KbDWYLyau3KuFKgfsDA2()
		{
			return TlAaIGyaLL7ts01AMPdI == null;
		}
	}

	[CompilerGenerated]
	private static bool B1pvJzV5plL;

	[CompilerGenerated]
	private static FullMatcher d0pv0w7QoYh;

	private IDictionary<string, HashSet<string>> dfkv0tpbqbJ = new Dictionary<string, HashSet<string>>();

	internal static FullMatcher TNUSf5cFrKHIbAC155aZ;

	public static bool OnlyFirstChar
	{
		[CompilerGenerated]
		get
		{
			return B1pvJzV5plL;
		}
		[CompilerGenerated]
		set
		{
			B1pvJzV5plL = value;
		}
	}

	public static FullMatcher Default
	{
		[CompilerGenerated]
		get
		{
			return d0pv0w7QoYh;
		}
		[CompilerGenerated]
		private set
		{
			d0pv0w7QoYh = value;
		}
	}

	public FullMatcher(bool onlyFirstChar = true)
	{
		OnlyFirstChar = onlyFirstChar;
	}

	public MatchResult TryMatchWithCache(string text, string query)
	{
		string key = query.Substring(0, query.Length - 1);
		if (dfkv0tpbqbJ.ContainsKey(key))
		{
			if (dfkv0tpbqbJ[key].Contains(text))
			{
				MatchResult matchResult = TryMatch(text, query);
				if (matchResult != null)
				{
					fXMvJAuPGTC(query, text);
				}
				return matchResult;
			}
			return null;
		}
		MatchResult matchResult2 = TryMatch(text, query);
		if (matchResult2 != null)
		{
			fXMvJAuPGTC(query, text);
		}
		return matchResult2;
	}

	private void fXMvJAuPGTC(string string_0, string string_1)
	{
		if (!dfkv0tpbqbJ.ContainsKey(string_0))
		{
			dfkv0tpbqbJ[string_0] = new HashSet<string>();
		}
		dfkv0tpbqbJ[string_0].Add(string_1);
	}

	[Obsolete]
	public bool IsMatch(string text, string query)
	{
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(query))
		{
			if (text.IndexOf(query, StringComparison.OrdinalIgnoreCase) < 0)
			{
				return TryMatch(text, query) != null;
			}
			return true;
		}
		return false;
	}

	public MatchResult TryMatch(string text, string query, bool supportMultiple = true)
	{
		int num = 1;
		MatchResult matchResult = default(MatchResult);
		string[] array2 = default(string[]);
		int num3 = default(int);
		while (supportMultiple)
		{
			int num2 = 0;
			if (!KouabxcFNNkc8rCygjVO())
			{
				goto IL_006a;
			}
			goto IL_006e;
			IL_006a:
			num2 = num;
			goto IL_006e;
			IL_006e:
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto end_IL_006e;
				case 2:
					goto IL_0105;
				}
				if (!query.Contains(" ") || query.StartsWith(" "))
				{
					goto end_IL_0081;
				}
				string[] array = query.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length != 0)
				{
					matchResult = null;
					array2 = array;
					num3 = 0;
					num2 = 2;
					if (KouabxcFNNkc8rCygjVO())
					{
						continue;
					}
					goto IL_006a;
				}
				return null;
				continue;
				end_IL_006e:
				break;
			}
			continue;
			IL_0105:
			while (true)
			{
				if (num3 < array2.Length)
				{
					string query2 = array2[num3];
					MatchResult matchResult2 = TryMatchOneWord(text, query2);
					if (matchResult2 == null)
					{
						break;
					}
					if (matchResult == null)
					{
						matchResult = matchResult2;
					}
					else
					{
						matchResult.Score += matchResult2.Score;
						foreach (MatchRange matchRange in matchResult2.MatchRanges)
						{
							matchResult.MatchRanges.Add(matchRange);
						}
					}
					num3++;
					continue;
				}
				fR0vJOuQerf(text.Length, matchResult);
				return matchResult;
			}
			return null;
			continue;
			end_IL_0081:
			break;
		}
		return TryMatchOneWord(text, query);
	}

	private static void fR0vJOuQerf(int int_0, MatchResult matchResult_0)
	{
		bool[] array = new bool[int_0];
		foreach (MatchRange matchRange in matchResult_0.MatchRanges)
		{
			for (int i = matchRange.Start; i <= matchRange.End; i++)
			{
				array[i] = true;
			}
		}
		matchResult_0.MatchRanges = tsyvJFo8mni(array).ToList();
	}

	[IteratorStateMachine(typeof(_003CExtractRanges_003Ed__15))]
	private static IEnumerable<MatchRange> tsyvJFo8mni(bool[] bool_1)
	{
		return new _003CExtractRanges_003Ed__15(-2)
		{
			_003C_003E3__array = bool_1
		};
	}

	public MatchResult TryMatchOneWord(string text, string query)
	{
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(query))
		{
			MatchResult matchResult = xAVvJ3oN3n1(text, query);
			if (matchResult != null)
			{
				return matchResult;
			}
			IList<Word> list = SentenceSplitter.SplitSentence(text);
			int num = 0;
			int num2;
			while (true)
			{
				if (num < list.Count)
				{
					num2 = 0;
					num2 = ((!B1pvJzV5plL) ? eBpvJlJqoJV(text, list, num, query, 0) : i5CvJUyjMh1(text, list, num, query));
					if (num2 > 0)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return new MatchResult
			{
				Score = ((num != 0) ? (200 - num) : ((list.Count == num2) ? 500 : 300)),
				MatchRanges = new List<MatchRange>
				{
					new MatchRange(list[num].StartIndex, list[num + num2 - 1].StartIndex + list[num + num2 - 1].Length - 1)
				}
			};
		}
		return null;
	}

	private static int i5CvJUyjMh1(string string_0, IList<Word> ilist_0, int int_0, string string_1)
	{
		if (string_1.Length > ilist_0.Count - int_0)
		{
			return -1;
		}
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				if (!ilist_0[num + int_0].IsFirstCharMatch(string_0, string_1[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return string_1.Length;
		}
		return -1;
	}

	private static int eBpvJlJqoJV(string string_0, IList<Word> ilist_0, int int_0, string string_1, int int_1)
	{
		foreach (int item in ilist_0[int_0].Match(string_0, string_1, int_1))
		{
			if (int_1 + item < string_1.Length)
			{
				if (int_0 != ilist_0.Count - 1)
				{
					int num = eBpvJlJqoJV(string_0, ilist_0, int_0 + 1, string_1, int_1 + item);
					if (num > 0)
					{
						return num + 1;
					}
					continue;
				}
				return -1;
			}
			return 1;
		}
		return -1;
	}

	private static MatchResult DJevJiLomqC(string string_0, IList<Word> ilist_0, string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < ilist_0.Count)
			{
				if (ilist_0[num].IsFirstCharMatch(string_0, string_1[0]))
				{
					bool flag = true;
					for (int i = 0; i < string_1.Length; i++)
					{
						if (num + i >= ilist_0.Count || !ilist_0[num + i].IsFirstCharMatch(string_0, string_1[i]))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return new MatchResult
		{
			Score = ((num != 0) ? 200 : ((ilist_0.Count == string_1.Length) ? 500 : 300)),
			MatchRanges = new List<MatchRange>
			{
				new MatchRange(ilist_0[num].StartIndex, ilist_0[num + string_1.Length - 1].StartIndex)
			}
		};
	}

	private static MatchResult xAVvJ3oN3n1(string string_0, string string_1)
	{
		int num = string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase);
		if (num >= 0)
		{
			if (num == 0)
			{
				if (string_1.Length == string_0.Length)
				{
					return new MatchResult
					{
						Score = 500,
						MatchRanges = new List<MatchRange>
						{
							new MatchRange(0, string_1.Length - 1)
						}
					};
				}
				return new MatchResult
				{
					Score = 300,
					MatchRanges = new List<MatchRange>
					{
						new MatchRange(0, string_1.Length - 1)
					}
				};
			}
			bool flag = false;
			CharType charType = string_0[num - 1].GetCharType();
			if (charType != CharType.LowerChar)
			{
				int num2 = 0;
				if (!KouabxcFNNkc8rCygjVO())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (charType != CharType.UpperChar)
				{
					flag = true;
				}
			}
			else if (string_0[num].GetCharType() == CharType.UpperChar)
			{
				flag = true;
			}
			if (flag)
			{
				return new MatchResult
				{
					Score = 200,
					MatchRanges = new List<MatchRange>
					{
						new MatchRange(num, num + string_1.Length - 1)
					}
				};
			}
		}
		return null;
	}

	static FullMatcher()
	{
		B1pvJzV5plL = true;
		d0pv0w7QoYh = new FullMatcher(false);
	}

	internal static bool KouabxcFNNkc8rCygjVO()
	{
		return TNUSf5cFrKHIbAC155aZ == null;
	}

	internal static void aVc9UscFf6kX91xjKrPD()
	{
	}
}
