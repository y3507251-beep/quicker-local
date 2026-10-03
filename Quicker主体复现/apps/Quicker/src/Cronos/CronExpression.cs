using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Ev8palqkaJqojgU3k6P;
using GFNWUBqDcrb64B51JaA;
using HRsUaFqi0vlCpe3W5OE;
using kNv55DqdF5Jd8ZS0HRd;

namespace Cronos;

public sealed class CronExpression : IEquatable<CronExpression>
{
	[CompilerGenerated]
	private sealed class _003CGetOccurrences_003Ed__27 : IDisposable, IEnumerable<DateTime>, IEnumerator<DateTime>, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private DateTime _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DateTime fromUtc;

		public DateTime _003C_003E3__fromUtc;

		private DateTime toUtc;

		public DateTime _003C_003E3__toUtc;

		public CronExpression _003C_003E4__this;

		private bool fromInclusive;

		public bool _003C_003E3__fromInclusive;

		private bool toInclusive;

		public bool _003C_003E3__toInclusive;

		private DateTime? _003Coccurrence_003E5__2;

		internal static _003CGetOccurrences_003Ed__27 KUElvBcGaLtSgj0MOJXK;

		DateTime IEnumerator<DateTime>.Current
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
		public _003CGetOccurrences_003Ed__27(int _003C_003E1__state)
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
			CronExpression cronExpression = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				_003Coccurrence_003E5__2 = cronExpression.GetNextOccurrence(_003Coccurrence_003E5__2.Value);
				break;
			case 0:
				_003C_003E1__state = -1;
				if (fromUtc > toUtc)
				{
					HfX722b9R4("fromUtc", "toUtc");
				}
				_003Coccurrence_003E5__2 = cronExpression.GetNextOccurrence(fromUtc, fromInclusive);
				break;
			}
			int num2;
			if (!(_003Coccurrence_003E5__2 < toUtc))
			{
				num2 = 1;
				if (rQv89JcGrH9Pebc4ihjN())
				{
					goto IL_00ba;
				}
				goto IL_00c9;
			}
			goto IL_00fc;
			IL_00c9:
			if (!((_003Coccurrence_003E5__2 == toUtc) & toInclusive))
			{
				return false;
			}
			goto IL_00fc;
			IL_00ba:
			switch (num2)
			{
			case 1:
				break;
			default:
				return true;
			}
			goto IL_00c9;
			IL_00fc:
			_003C_003E2__current = _003Coccurrence_003E5__2.Value;
			_003C_003E1__state = 1;
			num2 = 0;
			if (KUElvBcGaLtSgj0MOJXK != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			goto IL_00ba;
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
		IEnumerator<DateTime> IEnumerable<DateTime>.GetEnumerator()
		{
			_003CGetOccurrences_003Ed__27 _003CGetOccurrences_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetOccurrences_003Ed__ = this;
			}
			else
			{
				_003CGetOccurrences_003Ed__ = new _003CGetOccurrences_003Ed__27(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CGetOccurrences_003Ed__.fromUtc = _003C_003E3__fromUtc;
			_003CGetOccurrences_003Ed__.toUtc = _003C_003E3__toUtc;
			_003CGetOccurrences_003Ed__.fromInclusive = _003C_003E3__fromInclusive;
			_003CGetOccurrences_003Ed__.toInclusive = _003C_003E3__toInclusive;
			return _003CGetOccurrences_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DateTime>)this).GetEnumerator();
		}

		internal static bool rQv89JcGrH9Pebc4ihjN()
		{
			return KUElvBcGaLtSgj0MOJXK == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetOccurrences_003Ed__29 : IDisposable, IEnumerable<DateTime>, IEnumerator<DateTime>, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private DateTime _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DateTime fromUtc;

		public DateTime _003C_003E3__fromUtc;

		private DateTime toUtc;

		public DateTime _003C_003E3__toUtc;

		public CronExpression _003C_003E4__this;

		private TimeZoneInfo zone;

		public TimeZoneInfo _003C_003E3__zone;

		private bool fromInclusive;

		public bool _003C_003E3__fromInclusive;

		private bool toInclusive;

		public bool _003C_003E3__toInclusive;

		private DateTime? _003Coccurrence_003E5__2;

		private static _003CGetOccurrences_003Ed__29 U5eMhucG95RJic5nJ5IN;

		DateTime IEnumerator<DateTime>.Current
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
		public _003CGetOccurrences_003Ed__29(int _003C_003E1__state)
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
			CronExpression cronExpression = _003C_003E4__this;
			int num2 = 0;
			if (!RXnAJgcGLBK6fvq16fbk())
			{
				int num3 = default(int);
				num2 = num3;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					switch (num)
					{
					case 1:
						goto IL_002e;
					default:
						return false;
					case 0:
						break;
					}
					_003C_003E1__state = -1;
					if (fromUtc > toUtc)
					{
						HfX722b9R4("fromUtc", "toUtc");
					}
					_003Coccurrence_003E5__2 = cronExpression.GetNextOccurrence(fromUtc, zone, fromInclusive);
					break;
				case 1:
					{
						_003Coccurrence_003E5__2 = cronExpression.GetNextOccurrence(_003Coccurrence_003E5__2.Value, zone);
						break;
					}
					IL_002e:
					_003C_003E1__state = -1;
					num2 = 0;
					if (!RXnAJgcGLBK6fvq16fbk())
					{
						continue;
					}
					goto case 1;
				}
				break;
			}
			if (!(_003Coccurrence_003E5__2 < toUtc) && !((_003Coccurrence_003E5__2 == toUtc) & toInclusive))
			{
				return false;
			}
			_003C_003E2__current = _003Coccurrence_003E5__2.Value;
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
		IEnumerator<DateTime> IEnumerable<DateTime>.GetEnumerator()
		{
			_003CGetOccurrences_003Ed__29 _003CGetOccurrences_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetOccurrences_003Ed__ = this;
			}
			else
			{
				_003CGetOccurrences_003Ed__ = new _003CGetOccurrences_003Ed__29(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CGetOccurrences_003Ed__.fromUtc = _003C_003E3__fromUtc;
			_003CGetOccurrences_003Ed__.toUtc = _003C_003E3__toUtc;
			_003CGetOccurrences_003Ed__.zone = _003C_003E3__zone;
			_003CGetOccurrences_003Ed__.fromInclusive = _003C_003E3__fromInclusive;
			_003CGetOccurrences_003Ed__.toInclusive = _003C_003E3__toInclusive;
			return _003CGetOccurrences_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DateTime>)this).GetEnumerator();
		}

		internal static void XfooxycGoUamiUJjQQMk()
		{
		}

		internal static bool RXnAJgcGLBK6fvq16fbk()
		{
			return U5eMhucG95RJic5nJ5IN == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetOccurrences_003Ed__31 : IDisposable, IEnumerable<DateTimeOffset>, IEnumerator<DateTimeOffset>, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private DateTimeOffset _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DateTimeOffset from;

		public DateTimeOffset _003C_003E3__from;

		private DateTimeOffset to;

		public DateTimeOffset _003C_003E3__to;

		public CronExpression _003C_003E4__this;

		private TimeZoneInfo zone;

		public TimeZoneInfo _003C_003E3__zone;

		private bool fromInclusive;

		public bool _003C_003E3__fromInclusive;

		private bool toInclusive;

		public bool _003C_003E3__toInclusive;

		private DateTimeOffset? _003Coccurrence_003E5__2;

		private static _003CGetOccurrences_003Ed__31 jFQIDbcGqiFrLWFO0OjF;

		DateTimeOffset IEnumerator<DateTimeOffset>.Current
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
		public _003CGetOccurrences_003Ed__31(int _003C_003E1__state)
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
			CronExpression cronExpression = _003C_003E4__this;
			if (num == 0)
			{
				_003C_003E1__state = -1;
				if (from > to)
				{
					HfX722b9R4("from", "to");
				}
				_003Coccurrence_003E5__2 = cronExpression.GetNextOccurrence(from, zone, fromInclusive);
			}
			else
			{
				while (true)
				{
					if (num == 1)
					{
						_003C_003E1__state = -1;
						_003Coccurrence_003E5__2 = cronExpression.GetNextOccurrence(_003Coccurrence_003E5__2.Value, zone);
						if (rk7tPNcGiq4rEGbky9ie())
						{
							switch (0)
							{
							case 1:
								continue;
							}
						}
						break;
					}
					return false;
				}
			}
			if (!(_003Coccurrence_003E5__2 < to) && !((_003Coccurrence_003E5__2 == to) & toInclusive))
			{
				return false;
			}
			_003C_003E2__current = _003Coccurrence_003E5__2.Value;
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
		IEnumerator<DateTimeOffset> IEnumerable<DateTimeOffset>.GetEnumerator()
		{
			_003CGetOccurrences_003Ed__31 _003CGetOccurrences_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetOccurrences_003Ed__ = this;
			}
			else
			{
				_003CGetOccurrences_003Ed__ = new _003CGetOccurrences_003Ed__31(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CGetOccurrences_003Ed__.from = _003C_003E3__from;
			_003CGetOccurrences_003Ed__.to = _003C_003E3__to;
			_003CGetOccurrences_003Ed__.zone = _003C_003E3__zone;
			_003CGetOccurrences_003Ed__.fromInclusive = _003C_003E3__fromInclusive;
			_003CGetOccurrences_003Ed__.toInclusive = _003C_003E3__toInclusive;
			return _003CGetOccurrences_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DateTimeOffset>)this).GetEnumerator();
		}

		internal static bool rk7tPNcGiq4rEGbky9ie()
		{
			return jFQIDbcGqiFrLWFO0OjF == null;
		}
	}

	private static readonly TimeZoneInfo QFq7abs3Gj;

	private static readonly CronExpression sMo77eWDXr;

	private static readonly CronExpression IdJ7RYFnq7;

	private static readonly CronExpression S1o7qLbCsi;

	private static readonly CronExpression seB7cXD1E8;

	private static readonly CronExpression q3y7VZb2HM;

	private static readonly CronExpression MmA7Z6Wdg3;

	private static readonly CronExpression bN179gVry2;

	private static readonly int[] b9w7hqwkcN;

	private long YXZ7euQNml;

	private long jkO7Yn6rTg;

	private int BJd7I0ti50;

	private int WJM7WAwuGy;

	private short glb7klvxsQ;

	private byte v197Ggqshj;

	private byte iNp7sNUaYf;

	private byte hLk7HN7QSv;

	private qikJSyqmXwVpjhqK3IJ n7U71KhVLI;

	internal static CronExpression RnpEUkdxK1oJ0uSMf9N;

	private CronExpression()
	{
	}

	public static CronExpression Parse(string expression)
	{
		return Parse(expression, CronFormat.Standard);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static CronExpression Parse(string expression, CronFormat format)
	{
		if (string.IsNullOrEmpty(expression))
		{
			throw new ArgumentNullException("expression");
		}
		fixed (char* text = expression)
		{
			char* pChar_;
			CronExpression cronExpression;
			int num2 = default(int);
			while (true)
			{
				char* ptr = text;
				pChar_ = ptr;
				vuNar4VL2l(ref pChar_);
				int num;
				if (kMuaOIVyPO(ref pChar_, '@'))
				{
					cronExpression = n3SaQDC06c(ref pChar_);
					vuNar4VL2l(ref pChar_);
					if (cronExpression == null)
					{
						goto IL_00e1;
					}
					if (po270X60h0(*pChar_))
					{
						goto IL_010c;
					}
					num = 1;
					if ((object)RnpEUkdxK1oJ0uSMf9N != null)
					{
						num = num2;
					}
				}
				else
				{
					cronExpression = new CronExpression();
					if (format != CronFormat.IncludeSeconds)
					{
						rvf7JJoXqG(ref cronExpression.YXZ7euQNml, baoDAOquqn075oekDES.LTU7Q6bsUP.fIs7jDR3FN);
						break;
					}
					num = 0;
					if (FDlN2mdIX1x3EPxrOKQ())
					{
						goto IL_00b9;
					}
				}
				switch (num)
				{
				case 2:
					break;
				default:
					goto IL_00b9;
				case 1:
					goto IL_00e1;
				}
				continue;
				IL_00e1:
				XpY7SJvWeg("Macro: Unexpected character '{0}' on position {1}.", *pChar_, pChar_ - ptr);
				goto IL_010c;
				IL_010c:
				return cronExpression;
				IL_00b9:
				cronExpression.YXZ7euQNml = jYpajZWwfM(baoDAOquqn075oekDES.LTU7Q6bsUP, ref pChar_, ref cronExpression.n7U71KhVLI);
				SymapHVA0G(baoDAOquqn075oekDES.LTU7Q6bsUP, ref pChar_);
				break;
			}
			cronExpression.jkO7Yn6rTg = jYpajZWwfM(baoDAOquqn075oekDES.QTg7BdFJ0W, ref pChar_, ref cronExpression.n7U71KhVLI);
			SymapHVA0G(baoDAOquqn075oekDES.QTg7BdFJ0W, ref pChar_);
			cronExpression.BJd7I0ti50 = (int)jYpajZWwfM(baoDAOquqn075oekDES.Xp37pX2Jeo, ref pChar_, ref cronExpression.n7U71KhVLI);
			SymapHVA0G(baoDAOquqn075oekDES.Xp37pX2Jeo, ref pChar_);
			cronExpression.WJM7WAwuGy = (int)mmYan2x1dd(ref pChar_, ref cronExpression.n7U71KhVLI, ref cronExpression.hLk7HN7QSv);
			SymapHVA0G(baoDAOquqn075oekDES.RL07r5DtNH, ref pChar_);
			cronExpression.glb7klvxsQ = (short)jYpajZWwfM(baoDAOquqn075oekDES.Vfd7xO8SSM, ref pChar_, ref cronExpression.n7U71KhVLI);
			SymapHVA0G(baoDAOquqn075oekDES.Vfd7xO8SSM, ref pChar_);
			cronExpression.v197Ggqshj = (byte)Ubra4ffqpF(ref pChar_, ref cronExpression.n7U71KhVLI, ref cronExpression.iNp7sNUaYf);
			SNCaBOvnKV(ref pChar_);
			if ((cronExpression.v197Ggqshj & 0x81) != 0)
			{
				cronExpression.v197Ggqshj |= 129;
			}
			return cronExpression;
		}
	}

	public DateTime? GetNextOccurrence(DateTime fromUtc, bool inclusive = false)
	{
		if (fromUtc.Kind != DateTimeKind.Utc)
		{
			Vd17u2NOSF("fromUtc");
		}
		long num = JUkabS5IZO(fromUtc.Ticks, inclusive);
		if (num == 0L)
		{
			return null;
		}
		return new DateTime(num, DateTimeKind.Utc);
	}

	[IteratorStateMachine(typeof(_003CGetOccurrences_003Ed__27))]
	public IEnumerable<DateTime> GetOccurrences(DateTime fromUtc, DateTime toUtc, bool fromInclusive = true, bool toInclusive = false)
	{
		return new _003CGetOccurrences_003Ed__27(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__fromUtc = fromUtc,
			_003C_003E3__toUtc = toUtc,
			_003C_003E3__fromInclusive = fromInclusive,
			_003C_003E3__toInclusive = toInclusive
		};
	}

	public DateTime? GetNextOccurrence(DateTime fromUtc, TimeZoneInfo zone, bool inclusive = false)
	{
		if (fromUtc.Kind != DateTimeKind.Utc)
		{
			Vd17u2NOSF("fromUtc");
		}
		if (zone == QFq7abs3Gj)
		{
			long num = JUkabS5IZO(fromUtc.Ticks, inclusive);
			if (num == 0L)
			{
				return null;
			}
			return new DateTime(num, DateTimeKind.Utc);
		}
		DateTime dateTime = TimeZoneInfo.ConvertTime(fromUtc, zone);
		DateTimeOffset dateTimeOffset_ = new DateTimeOffset(dateTime, dateTime - fromUtc);
		return llEaHCnrL0(dateTimeOffset_, zone, inclusive)?.UtcDateTime;
	}

	[IteratorStateMachine(typeof(_003CGetOccurrences_003Ed__29))]
	public IEnumerable<DateTime> GetOccurrences(DateTime fromUtc, DateTime toUtc, TimeZoneInfo zone, bool fromInclusive = true, bool toInclusive = false)
	{
		return new _003CGetOccurrences_003Ed__29(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__fromUtc = fromUtc,
			_003C_003E3__toUtc = toUtc,
			_003C_003E3__zone = zone,
			_003C_003E3__fromInclusive = fromInclusive,
			_003C_003E3__toInclusive = toInclusive
		};
	}

	public DateTimeOffset? GetNextOccurrence(DateTimeOffset from, TimeZoneInfo zone, bool inclusive = false)
	{
		if (zone == QFq7abs3Gj)
		{
			long num = JUkabS5IZO(from.UtcTicks, inclusive);
			if (num == 0L)
			{
				return null;
			}
			return new DateTimeOffset(num, TimeSpan.Zero);
		}
		DateTimeOffset dateTimeOffset_ = TimeZoneInfo.ConvertTime(from, zone);
		return llEaHCnrL0(dateTimeOffset_, zone, inclusive);
	}

	[IteratorStateMachine(typeof(_003CGetOccurrences_003Ed__31))]
	public IEnumerable<DateTimeOffset> GetOccurrences(DateTimeOffset from, DateTimeOffset to, TimeZoneInfo zone, bool fromInclusive = true, bool toInclusive = false)
	{
		return new _003CGetOccurrences_003Ed__31(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__from = from,
			_003C_003E3__to = to,
			_003C_003E3__zone = zone,
			_003C_003E3__fromInclusive = fromInclusive,
			_003C_003E3__toInclusive = toInclusive
		};
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		R9Sai3XdVX(stringBuilder, baoDAOquqn075oekDES.LTU7Q6bsUP, YXZ7euQNml).Append(' ');
		R9Sai3XdVX(stringBuilder, baoDAOquqn075oekDES.QTg7BdFJ0W, jkO7Yn6rTg).Append(' ');
		R9Sai3XdVX(stringBuilder, baoDAOquqn075oekDES.Xp37pX2Jeo, BJd7I0ti50).Append(' ');
		INOa3IZi9V(stringBuilder, WJM7WAwuGy).Append(' ');
		R9Sai3XdVX(stringBuilder, baoDAOquqn075oekDES.Vfd7xO8SSM, glb7klvxsQ).Append(' ');
		Gg5af1r3c0(stringBuilder, v197Ggqshj);
		return stringBuilder.ToString();
	}

	public bool Equals(CronExpression other)
	{
		if (other == null)
		{
			return false;
		}
		if (YXZ7euQNml == other.YXZ7euQNml && jkO7Yn6rTg == other.jkO7Yn6rTg)
		{
			int num = 0;
			if (!FDlN2mdIX1x3EPxrOKQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (BJd7I0ti50 == other.BJd7I0ti50 && WJM7WAwuGy == other.WJM7WAwuGy && glb7klvxsQ == other.glb7klvxsQ && v197Ggqshj == other.v197Ggqshj && iNp7sNUaYf == other.iNp7sNUaYf && hLk7HN7QSv == other.hLk7HN7QSv)
			{
				return n7U71KhVLI == other.n7U71KhVLI;
			}
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as CronExpression);
	}

	public override int GetHashCode()
	{
		return (((((((((((((((YXZ7euQNml.GetHashCode() * 397) ^ jkO7Yn6rTg.GetHashCode()) * 397) ^ BJd7I0ti50) * 397) ^ WJM7WAwuGy) * 397) ^ glb7klvxsQ.GetHashCode()) * 397) ^ v197Ggqshj.GetHashCode()) * 397) ^ iNp7sNUaYf.GetHashCode()) * 397) ^ hLk7HN7QSv.GetHashCode()) * 397) ^ (int)n7U71KhVLI;
	}

	public static bool operator ==(CronExpression left, CronExpression right)
	{
		return object.Equals(left, right);
	}

	public static bool operator !=(CronExpression left, CronExpression right)
	{
		return !object.Equals(left, right);
	}

	private DateTimeOffset? llEaHCnrL0(DateTimeOffset dateTimeOffset_0, TimeZoneInfo timeZoneInfo_1, bool bool_0)
	{
		DateTime dateTime_ = dateTimeOffset_0.DateTime;
		if (hCuaeeqHT3C7vfC2UUK.reY7dXL7B1(timeZoneInfo_1, dateTime_))
		{
			TimeSpan offset = dateTimeOffset_0.Offset;
			TimeSpan baseUtcOffset = timeZoneInfo_1.BaseUtcOffset;
			if (baseUtcOffset != offset)
			{
				TimeSpan timeSpan = hCuaeeqHT3C7vfC2UUK.Rqo7oY8Muh(timeZoneInfo_1, dateTime_);
				DateTime dateTime = hCuaeeqHT3C7vfC2UUK.wY97OV0MHc(timeZoneInfo_1, dateTime_, timeSpan).DateTime;
				long num = OpUa1FUbWK(dateTime_.Ticks, dateTime.Ticks, bool_0);
				if (num != 0L)
				{
					return new DateTimeOffset(num, timeSpan);
				}
				dateTime_ = hCuaeeqHT3C7vfC2UUK.mQJ7MquE92(timeZoneInfo_1, dateTime_, timeSpan).DateTime;
				bool_0 = true;
			}
			DateTime dateTime2 = hCuaeeqHT3C7vfC2UUK.soM7AAI83D(timeZoneInfo_1, dateTime_).DateTime;
			if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)4))
			{
				long num2 = OpUa1FUbWK(dateTime_.Ticks, dateTime2.Ticks - 1L, bool_0);
				if (num2 != 0L)
				{
					return new DateTimeOffset(num2, baseUtcOffset);
				}
			}
			dateTime_ = dateTime2;
			bool_0 = true;
		}
		long num3 = JUkabS5IZO(dateTime_.Ticks, bool_0);
		if (num3 == 0L)
		{
			return null;
		}
		DateTime dateTime3 = new DateTime(num3);
		if (timeZoneInfo_1.IsInvalidTime(dateTime3))
		{
			return hCuaeeqHT3C7vfC2UUK.ycC7TeSpuo(timeZoneInfo_1, dateTime3);
		}
		if (hCuaeeqHT3C7vfC2UUK.reY7dXL7B1(timeZoneInfo_1, dateTime3))
		{
			TimeSpan offset2 = hCuaeeqHT3C7vfC2UUK.Rqo7oY8Muh(timeZoneInfo_1, dateTime3);
			return new DateTimeOffset(dateTime3, offset2);
		}
		return new DateTimeOffset(dateTime3, timeZoneInfo_1.GetUtcOffset(dateTime3));
	}

	private long OpUa1FUbWK(long long_2, long long_3, bool bool_0)
	{
		long num = JUkabS5IZO(long_2, bool_0);
		if (num != 0L && num <= long_3)
		{
			return num;
		}
		return 0L;
	}

	private long JUkabS5IZO(long long_2, bool bool_0)
	{
        int int_7 = default;
        int int_8 = default;
        int num3 = default;
        int int_ = default;
        int num4 = default;
        int int_4 = default;
        int num2 = default;
        int int_9 = default;
        int int_5 = default;
        int int_6 = default;
        int int_11 = default;
        int int_3 = default;
        int int_10 = default;
		int num;
		if (!bool_0)
		{
			long_2++;
			num = 0;
			if ((object)RnpEUkdxK1oJ0uSMf9N == null)
			{
				goto IL_01d7;
			}
		}
		goto IL_0217;
		IL_00ef:
		int_ = default(int);
		num2 = int_;
		if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)8))
		{
			goto IL_00fc;
		}
		goto IL_0109;
		IL_0217:
		int_3 = default(int);
		int_4 = default(int);
		int_5 = default(int);
		int_6 = default(int);
		int_7 = default(int);
		yoSTsVq770v3KF5xolx.mEPa9wRHJQ(long_2, out var int_2, out int_3, out int_4, out int_5, out int_6, out int_7);
		num3 = x17aKpMUv6(WJM7WAwuGy);
		int_8 = int_2;
		int_9 = int_3;
		int_10 = int_4;
		int_ = int_5;
		int_11 = int_6;
		num4 = int_7;
		if (ywD7NDBKa1(YXZ7euQNml, int_8) || Fnda6KyCeu(YXZ7euQNml, ref int_8))
		{
			goto IL_0028;
		}
		num = 1;
		if (!FDlN2mdIX1x3EPxrOKQ())
		{
			int num5 = default(int);
			num = num5;
		}
		goto IL_01d7;
		IL_0109:
		if (kBkamiirZj(num4, int_11, int_))
		{
			if (yoSTsVq770v3KF5xolx.WdSaVXAQKP(num4, int_11, int_, int_7, int_6, int_5))
			{
				int_10 = x17aKpMUv6(BJd7I0ti50);
			}
			else if (int_10 <= int_4)
			{
				if (int_9 > int_3)
				{
					goto IL_0155;
				}
				goto IL_0162;
			}
			int_9 = x17aKpMUv6(jkO7Yn6rTg);
			goto IL_0155;
		}
		goto IL_017d;
		IL_00bc:
		if (int_ > JsWaX1ijO3(num4, int_11))
		{
			goto IL_00a5;
		}
		if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)1))
		{
			int_ = JsWaX1ijO3(num4, int_11);
			num = 2;
			if ((object)RnpEUkdxK1oJ0uSMf9N != null)
			{
				goto IL_01d7;
			}
		}
		goto IL_00ef;
		IL_0162:
		long num6 = yoSTsVq770v3KF5xolx.OLraZ4wxK2(num4, int_11, int_, int_10, int_9, int_8);
		if (num6 >= long_2)
		{
			return num6;
		}
		goto IL_017d;
		IL_01d7:
		switch (num)
		{
		case 2:
			break;
		case 4:
			goto IL_00fc;
		case 3:
			goto IL_0155;
		case 1:
			goto IL_01af;
		default:
			goto IL_0217;
		}
		goto IL_00ef;
		IL_01af:
		int_9++;
		goto IL_0028;
		IL_0028:
		if (!ywD7NDBKa1(jkO7Yn6rTg, int_9) && !Fnda6KyCeu(jkO7Yn6rTg, ref int_9))
		{
			int_10++;
		}
		if (!ywD7NDBKa1(BJd7I0ti50, int_10) && !Fnda6KyCeu(BJd7I0ti50, ref int_10))
		{
			int_++;
		}
		if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)8))
		{
			int_ = baoDAOquqn075oekDES.RL07r5DtNH.fIs7jDR3FN;
		}
		if ((!ywD7NDBKa1(WJM7WAwuGy, int_) && !Fnda6KyCeu(WJM7WAwuGy, ref int_)) || !ywD7NDBKa1(glb7klvxsQ, int_11))
		{
			goto IL_00a5;
		}
		goto IL_00bc;
		IL_00a5:
		if (Fnda6KyCeu(glb7klvxsQ, ref int_11) || ++num4 < 2099)
		{
			int_ = num3;
			goto IL_00bc;
		}
		return 0L;
		IL_00fc:
		int_ = yoSTsVq770v3KF5xolx.mYsaY7BrCb(num4, int_11, int_);
		goto IL_0109;
		IL_0155:
		int_8 = x17aKpMUv6(YXZ7euQNml);
		goto IL_0162;
		IL_017d:
		int_ = num2;
		if (!Fnda6KyCeu(WJM7WAwuGy, ref int_))
		{
			goto IL_00a5;
		}
		goto IL_00bc;
	}

	private static bool Fnda6KyCeu(long long_2, ref int int_3)
	{
		if (long_2 >> ++int_3 == 0L)
		{
			int_3 = x17aKpMUv6(long_2);
			return false;
		}
		int_3 += x17aKpMUv6(long_2 >> int_3);
		return true;
	}

	private int JsWaX1ijO3(int int_3, int int_4)
	{
		return yoSTsVq770v3KF5xolx.cycae15GqA(int_3, int_4) - hLk7HN7QSv;
	}

	private bool kBkamiirZj(int int_3, int int_4, int int_5)
	{
		if ((EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)2) && !yoSTsVq770v3KF5xolx.x21aWR76b8(int_3, int_4, int_5)) || (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)16) && !yoSTsVq770v3KF5xolx.gKPaIfRlUo(int_5, iNp7sNUaYf)))
		{
			return false;
		}
		if (v197Ggqshj == baoDAOquqn075oekDES.KD87K8jk8S.E8A7Dp1h8d)
		{
			return true;
		}
		DayOfWeek dayOfWeek = yoSTsVq770v3KF5xolx.N6JahWMRji(int_3, int_4, int_5);
		return ((v197Ggqshj >> (int)dayOfWeek) & 1) != 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int x17aKpMUv6(long long_2)
	{
		ulong num = (ulong)((long_2 & -long_2) * 157587932685088877L) >> 58;
		return b9w7hqwkcN[num];
	}

	private bool EyVaxahxLo(qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1)
	{
		return (n7U71KhVLI & qikJSyqmXwVpjhqK3IJ_1) != 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void vuNar4VL2l(ref char* pChar_0)
	{
		while (mC57C21l7k(*pChar_0))
		{
			pChar_0++;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void SymapHVA0G(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0)
	{
		if (!mC57C21l7k(*pChar_0))
		{
			vQD7vWhFBM(baoDAOquqn075oekDES_0, "Unexpected character '{0}'.", *pChar_0);
		}
		vuNar4VL2l(ref pChar_0);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void SNCaBOvnKV(ref char* pChar_0)
	{
		if (!mC57C21l7k(*pChar_0) && !po270X60h0(*pChar_0))
		{
			vQD7vWhFBM(baoDAOquqn075oekDES.KD87K8jk8S, "Unexpected character '{0}'.", *pChar_0);
		}
		vuNar4VL2l(ref pChar_0);
		if (!po270X60h0(*pChar_0))
		{
			XpY7SJvWeg("Unexpected character '{0}'.", *pChar_0);
		}
	}

	private unsafe static CronExpression n3SaQDC06c(ref char* pChar_0)
	{
		int num;
		int num2 = default(int);
		switch (nPH7841qhM(*(pChar_0++)))
		{
		case 72:
			if (HBJaFQdAi8(ref pChar_0, 'O') && HBJaFQdAi8(ref pChar_0, 'U') && HBJaFQdAi8(ref pChar_0, 'R') && HBJaFQdAi8(ref pChar_0, 'L') && HBJaFQdAi8(ref pChar_0, 'Y'))
			{
				return q3y7VZb2HM;
			}
			return null;
		case 65:
			if (HBJaFQdAi8(ref pChar_0, 'N') && HBJaFQdAi8(ref pChar_0, 'N') && HBJaFQdAi8(ref pChar_0, 'U'))
			{
				goto IL_0231;
			}
			goto IL_025f;
		case 68:
			if (HBJaFQdAi8(ref pChar_0, 'A') && HBJaFQdAi8(ref pChar_0, 'I') && HBJaFQdAi8(ref pChar_0, 'L') && HBJaFQdAi8(ref pChar_0, 'Y'))
			{
				return seB7cXD1E8;
			}
			return null;
		case 69:
			if (HBJaFQdAi8(ref pChar_0, 'V') && HBJaFQdAi8(ref pChar_0, 'E') && HBJaFQdAi8(ref pChar_0, 'R') && HBJaFQdAi8(ref pChar_0, 'Y'))
			{
				num = 6;
				if (!FDlN2mdIX1x3EPxrOKQ())
				{
					goto IL_01ab;
				}
				goto IL_01af;
			}
			goto IL_0305;
		case 89:
			if (HBJaFQdAi8(ref pChar_0, 'E') && HBJaFQdAi8(ref pChar_0, 'A'))
			{
				goto IL_0307;
			}
			goto IL_032b;
		case 87:
			if (HBJaFQdAi8(ref pChar_0, 'E'))
			{
				num = 1;
				if ((object)RnpEUkdxK1oJ0uSMf9N != null)
				{
					goto IL_01ab;
				}
				goto IL_01af;
			}
			goto IL_022f;
		case 77:
			if (!HBJaFQdAi8(ref pChar_0, 'O') || !HBJaFQdAi8(ref pChar_0, 'N') || !HBJaFQdAi8(ref pChar_0, 'T'))
			{
				break;
			}
			num = 0;
			if ((object)RnpEUkdxK1oJ0uSMf9N != null)
			{
				goto IL_01ab;
			}
			goto IL_01af;
		default:
			goto IL_0261;
			IL_032b:
			return null;
			IL_0269:
			if (kMuaOIVyPO(ref pChar_0, '_'))
			{
				if (HBJaFQdAi8(ref pChar_0, 'M') && HBJaFQdAi8(ref pChar_0, 'I') && HBJaFQdAi8(ref pChar_0, 'N') && HBJaFQdAi8(ref pChar_0, 'U') && HBJaFQdAi8(ref pChar_0, 'T') && HBJaFQdAi8(ref pChar_0, 'E'))
				{
					return MmA7Z6Wdg3;
				}
				if (*(pChar_0 - 1) != '_')
				{
					return null;
				}
				if (HBJaFQdAi8(ref pChar_0, 'S') && HBJaFQdAi8(ref pChar_0, 'E') && HBJaFQdAi8(ref pChar_0, 'C') && HBJaFQdAi8(ref pChar_0, 'O') && HBJaFQdAi8(ref pChar_0, 'N') && HBJaFQdAi8(ref pChar_0, 'D'))
				{
					return bN179gVry2;
				}
			}
			goto IL_0305;
			IL_022f:
			return null;
			IL_025f:
			return null;
			IL_0261:
			pChar_0--;
			return null;
			IL_0201:
			if (HBJaFQdAi8(ref pChar_0, 'E') && HBJaFQdAi8(ref pChar_0, 'K') && HBJaFQdAi8(ref pChar_0, 'L') && HBJaFQdAi8(ref pChar_0, 'Y'))
			{
				return IdJ7RYFnq7;
			}
			goto IL_022f;
			IL_0305:
			return null;
			IL_01ab:
			num = num2;
			goto IL_01af;
			IL_01af:
			switch (num)
			{
			case 1:
				goto IL_0201;
			case 3:
				goto IL_0231;
			case 2:
				goto IL_025f;
			case 5:
				goto IL_0261;
			case 6:
				goto IL_0269;
			case 7:
				goto IL_0307;
			case 4:
				goto IL_0325;
			}
			if (HBJaFQdAi8(ref pChar_0, 'H') && HBJaFQdAi8(ref pChar_0, 'L') && HBJaFQdAi8(ref pChar_0, 'Y'))
			{
				return S1o7qLbCsi;
			}
			break;
			IL_0307:
			if (HBJaFQdAi8(ref pChar_0, 'R') && HBJaFQdAi8(ref pChar_0, 'L') && HBJaFQdAi8(ref pChar_0, 'Y'))
			{
				goto IL_0325;
			}
			goto IL_032b;
			IL_0231:
			if (HBJaFQdAi8(ref pChar_0, 'A') && HBJaFQdAi8(ref pChar_0, 'L') && HBJaFQdAi8(ref pChar_0, 'L') && HBJaFQdAi8(ref pChar_0, 'Y'))
			{
				return sMo77eWDXr;
			}
			goto IL_025f;
			IL_0325:
			return sMo77eWDXr;
		}
		if (nPH7841qhM(*(pChar_0 - 1)) == 77 && HBJaFQdAi8(ref pChar_0, 'I') && HBJaFQdAi8(ref pChar_0, 'D') && HBJaFQdAi8(ref pChar_0, 'N') && HBJaFQdAi8(ref pChar_0, 'I') && HBJaFQdAi8(ref pChar_0, 'G') && HBJaFQdAi8(ref pChar_0, 'H') && HBJaFQdAi8(ref pChar_0, 'T'))
		{
			return seB7cXD1E8;
		}
		return null;
	}

	private unsafe static long jYpajZWwfM(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1)
	{
		if (!kMuaOIVyPO(ref pChar_0, '*') && !kMuaOIVyPO(ref pChar_0, '?'))
		{
			int int_ = jSCal8JbmB(baoDAOquqn075oekDES_0, ref pChar_0);
			long num = ANhadWLO0i(baoDAOquqn075oekDES_0, ref pChar_0, int_, ref qikJSyqmXwVpjhqK3IJ_1);
			if (kMuaOIVyPO(ref pChar_0, ','))
			{
				num |= EwaaD6OcAY(baoDAOquqn075oekDES_0, ref pChar_0, ref qikJSyqmXwVpjhqK3IJ_1);
			}
			return num;
		}
		if (baoDAOquqn075oekDES_0.zqF75xRmGP)
		{
			qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)4;
		}
		return Saua5w8qpS(baoDAOquqn075oekDES_0, ref pChar_0);
	}

	private unsafe static long mmYan2x1dd(ref char* pChar_0, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1, ref byte byte_3)
	{
		baoDAOquqn075oekDES rL07r5DtNH = baoDAOquqn075oekDES.RL07r5DtNH;
		if (!kMuaOIVyPO(ref pChar_0, '*'))
		{
			if (!kMuaOIVyPO(ref pChar_0, '?'))
			{
				if (HBJaFQdAi8(ref pChar_0, 'L'))
				{
					return yoWaTPVUyi(rL07r5DtNH, ref pChar_0, ref qikJSyqmXwVpjhqK3IJ_1, ref byte_3);
				}
				int int_ = jSCal8JbmB(rL07r5DtNH, ref pChar_0);
				if (HBJaFQdAi8(ref pChar_0, 'W'))
				{
					qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)8;
					return x7u7gucQce(int_);
				}
				long num = ANhadWLO0i(rL07r5DtNH, ref pChar_0, int_, ref qikJSyqmXwVpjhqK3IJ_1);
				if (kMuaOIVyPO(ref pChar_0, ','))
				{
					num |= EwaaD6OcAY(rL07r5DtNH, ref pChar_0, ref qikJSyqmXwVpjhqK3IJ_1);
				}
				return num;
			}
			int num2 = 0;
			if ((object)RnpEUkdxK1oJ0uSMf9N != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return Saua5w8qpS(rL07r5DtNH, ref pChar_0);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static long Ubra4ffqpF(ref char* pChar_0, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1, ref byte byte_3)
	{
		baoDAOquqn075oekDES kD87K8jk8S = baoDAOquqn075oekDES.KD87K8jk8S;
		if (!kMuaOIVyPO(ref pChar_0, '*') && !kMuaOIVyPO(ref pChar_0, '?'))
		{
			int int_ = jSCal8JbmB(kD87K8jk8S, ref pChar_0);
			if (FDlN2mdIX1x3EPxrOKQ())
			{
				switch (0)
				{
				}
			}
			if (HBJaFQdAi8(ref pChar_0, 'L'))
			{
				return fFpaAHONnR(int_, ref qikJSyqmXwVpjhqK3IJ_1);
			}
			if (kMuaOIVyPO(ref pChar_0, '#'))
			{
				return uDXaMwSngM(kD87K8jk8S, ref pChar_0, int_, ref qikJSyqmXwVpjhqK3IJ_1, out byte_3);
			}
			long num = ANhadWLO0i(kD87K8jk8S, ref pChar_0, int_, ref qikJSyqmXwVpjhqK3IJ_1);
			if (kMuaOIVyPO(ref pChar_0, ','))
			{
				num |= EwaaD6OcAY(kD87K8jk8S, ref pChar_0, ref qikJSyqmXwVpjhqK3IJ_1);
			}
			return num;
		}
		return Saua5w8qpS(kD87K8jk8S, ref pChar_0);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static long Saua5w8qpS(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0)
	{
		if (!kMuaOIVyPO(ref pChar_0, '/'))
		{
			return baoDAOquqn075oekDES_0.E8A7Dp1h8d;
		}
		return hqLaoQb0Ce(baoDAOquqn075oekDES_0, ref pChar_0, baoDAOquqn075oekDES_0.fIs7jDR3FN, baoDAOquqn075oekDES_0.SMS7nqVeCd);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static long EwaaD6OcAY(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1)
	{
		int int_ = jSCal8JbmB(baoDAOquqn075oekDES_0, ref pChar_0);
		long num = ANhadWLO0i(baoDAOquqn075oekDES_0, ref pChar_0, int_, ref qikJSyqmXwVpjhqK3IJ_1);
		while (kMuaOIVyPO(ref pChar_0, ','))
		{
			num |= EwaaD6OcAY(baoDAOquqn075oekDES_0, ref pChar_0, ref qikJSyqmXwVpjhqK3IJ_1);
		}
		return num;
	}

	private unsafe static long ANhadWLO0i(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0, int int_3, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1)
	{
		if (!kMuaOIVyPO(ref pChar_0, '-'))
		{
			if (!kMuaOIVyPO(ref pChar_0, '/'))
			{
				return x7u7gucQce(int_3);
			}
			if (baoDAOquqn075oekDES_0.zqF75xRmGP)
			{
				qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)4;
			}
			return hqLaoQb0Ce(baoDAOquqn075oekDES_0, ref pChar_0, int_3, baoDAOquqn075oekDES_0.SMS7nqVeCd);
		}
		if (baoDAOquqn075oekDES_0.zqF75xRmGP)
		{
			qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)4;
		}
		int int_4 = jSCal8JbmB(baoDAOquqn075oekDES_0, ref pChar_0);
		if (kMuaOIVyPO(ref pChar_0, '/'))
		{
			return hqLaoQb0Ce(baoDAOquqn075oekDES_0, ref pChar_0, int_3, int_4);
		}
		return VC7azFLjcG(baoDAOquqn075oekDES_0, int_3, int_4, 1);
	}

	private unsafe static long hqLaoQb0Ce(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0, int int_3, int int_4)
	{
		int int_5 = EbbaUjt7rs(baoDAOquqn075oekDES_0, ref pChar_0, 1, baoDAOquqn075oekDES_0.SMS7nqVeCd);
		return VC7azFLjcG(baoDAOquqn075oekDES_0, int_3, int_4, int_5);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static long yoWaTPVUyi(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1, ref byte byte_3)
	{
		qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)1;
		if (kMuaOIVyPO(ref pChar_0, '-'))
		{
			byte_3 = (byte)EbbaUjt7rs(baoDAOquqn075oekDES_0, ref pChar_0, 0, baoDAOquqn075oekDES_0.SMS7nqVeCd - 1);
		}
		if (HBJaFQdAi8(ref pChar_0, 'W'))
		{
			qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)8;
		}
		return baoDAOquqn075oekDES_0.E8A7Dp1h8d;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static long uDXaMwSngM(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0, int int_3, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1, out byte byte_3)
	{
		byte_3 = (byte)EbbaUjt7rs(baoDAOquqn075oekDES_0, ref pChar_0, 1, 5);
		qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)16;
		return x7u7gucQce(int_3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long fFpaAHONnR(int int_3, ref qikJSyqmXwVpjhqK3IJ qikJSyqmXwVpjhqK3IJ_1)
	{
		qikJSyqmXwVpjhqK3IJ_1 |= (qikJSyqmXwVpjhqK3IJ)2;
		return x7u7gucQce(int_3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static bool kMuaOIVyPO(ref char* pChar_0, char char_0)
	{
		if (*pChar_0 == char_0)
		{
			pChar_0++;
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static bool HBJaFQdAi8(ref char* pChar_0, char char_0)
	{
		if (nPH7841qhM(*pChar_0) == char_0)
		{
			pChar_0++;
			return true;
		}
		return false;
	}

	private unsafe static int EbbaUjt7rs(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0, int int_3, int int_4)
	{
		int num = rvm7L8YOBg(ref pChar_0, null);
		if (num == -1 || num < int_3 || num > int_4)
		{
			vQD7vWhFBM(baoDAOquqn075oekDES_0, "Value must be a number between {0} and {1} (all inclusive).", int_3, int_4);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static int jSCal8JbmB(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, ref char* pChar_0)
	{
		int num = rvm7L8YOBg(ref pChar_0, baoDAOquqn075oekDES_0.MMj74A29g9);
		if (num == -1 || num < baoDAOquqn075oekDES_0.fIs7jDR3FN || num > baoDAOquqn075oekDES_0.SMS7nqVeCd)
		{
			vQD7vWhFBM(baoDAOquqn075oekDES_0, "Value must be a number between {0} and {1} (all inclusive).", baoDAOquqn075oekDES_0.fIs7jDR3FN, baoDAOquqn075oekDES_0.SMS7nqVeCd);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static StringBuilder R9Sai3XdVX(StringBuilder stringBuilder_0, baoDAOquqn075oekDES baoDAOquqn075oekDES_0, long long_2)
	{
		if (baoDAOquqn075oekDES_0.E8A7Dp1h8d == long_2)
		{
			return stringBuilder_0.Append('*');
		}
		if (baoDAOquqn075oekDES_0 == baoDAOquqn075oekDES.KD87K8jk8S)
		{
			long_2 &= ~(1 << baoDAOquqn075oekDES_0.SMS7nqVeCd);
		}
		int num = x17aKpMUv6(long_2);
		int num3 = default(int);
		while (true)
		{
			stringBuilder_0.Append(num);
			if (long_2 >> ++num == 0L)
			{
				break;
			}
			int num2 = 0;
			if (!FDlN2mdIX1x3EPxrOKQ())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			stringBuilder_0.Append(',');
			num = x17aKpMUv6(long_2 >> num << num);
		}
		return stringBuilder_0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private StringBuilder INOa3IZi9V(StringBuilder stringBuilder_0, int int_3)
	{
		if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)1))
		{
			stringBuilder_0.Append('L');
			if (hLk7HN7QSv != 0)
			{
				stringBuilder_0.Append($"-{hLk7HN7QSv}");
			}
		}
		else
		{
			R9Sai3XdVX(stringBuilder_0, baoDAOquqn075oekDES.RL07r5DtNH, (uint)int_3);
		}
		if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)8))
		{
			stringBuilder_0.Append('W');
		}
		return stringBuilder_0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Gg5af1r3c0(StringBuilder stringBuilder_0, int int_3)
	{
		R9Sai3XdVX(stringBuilder_0, baoDAOquqn075oekDES.KD87K8jk8S, int_3);
		if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)2))
		{
			stringBuilder_0.Append('L');
		}
		else if (EyVaxahxLo((qikJSyqmXwVpjhqK3IJ)16))
		{
			stringBuilder_0.Append($"#{iNp7sNUaYf}");
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long VC7azFLjcG(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, int int_3, int int_4, int int_5)
	{
		if (int_4 < int_3)
		{
			return UHk7tRAOxY(baoDAOquqn075oekDES_0, int_3, int_4, int_5);
		}
		if (int_5 == 1)
		{
			return (1L << int_4 + 1) - (1L << int_3);
		}
		return m6g7wTkKY8(int_3, int_4, int_5);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long m6g7wTkKY8(int int_3, int int_4, int int_5)
	{
		long long_ = 0L;
		for (int i = int_3; i <= int_4; i += int_5)
		{
			rvf7JJoXqG(ref long_, i);
		}
		return long_;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long UHk7tRAOxY(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, int int_3, int int_4, int int_5)
	{
		int num = baoDAOquqn075oekDES_0.SMS7nqVeCd;
		if (baoDAOquqn075oekDES_0 == baoDAOquqn075oekDES.KD87K8jk8S)
		{
			num--;
		}
		long num2 = m6g7wTkKY8(int_3, num, int_5);
		int_3 = baoDAOquqn075oekDES_0.fIs7jDR3FN + int_5 - (num - int_3) % int_5 - 1;
		return num2 | m6g7wTkKY8(int_3, int_4, int_5);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long x7u7gucQce(int int_3)
	{
		return 1L << int_3;
	}

	private unsafe static int rvm7L8YOBg(ref char* pChar_0, int[] int_3)
	{
		char* ptr;
		int num = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5;
		if (!g987PEWw0u(*pChar_0))
		{
			if (int_3 == null)
			{
				return -1;
			}
			if (!OQY7ESi2wo(*pChar_0))
			{
				return -1;
			}
			num = nPH7841qhM(*(pChar_0++));
			if (!OQY7ESi2wo(*pChar_0))
			{
				return -1;
			}
			num |= nPH7841qhM(*(pChar_0++)) << 8;
			if (!OQY7ESi2wo(*pChar_0))
			{
				return -1;
			}
			int num2 = num;
			ptr = pChar_0++;
			num = num2 | (nPH7841qhM(*ptr) << 16);
			num3 = int_3.Length;
			num4 = 0;
			num5 = 1;
			if (!FDlN2mdIX1x3EPxrOKQ())
			{
				int num6 = default(int);
				num5 = num6;
			}
		}
		else
		{
			ptr = pChar_0++;
			num5 = 0;
			if ((object)RnpEUkdxK1oJ0uSMf9N == null)
			{
				goto IL_00be;
			}
		}
		switch (num5)
		{
		case 1:
			while (true)
			{
				if (num4 < num3)
				{
					if (num == int_3[num4])
					{
						break;
					}
					num4++;
					continue;
				}
				return -1;
			}
			return num4;
		}
		goto IL_00be;
		IL_00be:
		int num7 = pkU7y7Wg4k(*ptr);
		if (!g987PEWw0u(*pChar_0))
		{
			return num7;
		}
		num7 = num7 * 10 + pkU7y7Wg4k(*(pChar_0++));
		if (g987PEWw0u(*pChar_0))
		{
			return -1;
		}
		return num7;
	}

	private static void vQD7vWhFBM(baoDAOquqn075oekDES baoDAOquqn075oekDES_0, string string_0, params object[] args)
	{
		throw new CronFormatException(baoDAOquqn075oekDES_0, string.Format(string_0, args));
	}

	private static void XpY7SJvWeg(string string_0, params object[] args)
	{
		throw new CronFormatException(string.Format(string_0, args));
	}

	private static void HfX722b9R4(string string_0, string string_1)
	{
		throw new ArgumentException("The value of the " + string_0 + " argument should be less than the value of the " + string_1 + " argument.", string_0);
	}

	private static void Vd17u2NOSF(string string_0)
	{
		throw new ArgumentException("The supplied DateTime must have the Kind property set to Utc", string_0);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool ywD7NDBKa1(long long_2, int int_3)
	{
		return (ulong)(long_2 & (1L << int_3)) > 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void rvf7JJoXqG(ref long long_2, int int_3)
	{
		long_2 |= 1L << int_3;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool po270X60h0(int int_3)
	{
		return int_3 == 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool mC57C21l7k(int int_3)
	{
		if (int_3 != 9)
		{
			return int_3 == 32;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool g987PEWw0u(int int_3)
	{
		if (int_3 >= 48)
		{
			return int_3 <= 57;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool OQY7ESi2wo(int int_3)
	{
		if (int_3 >= 65 && int_3 <= 90)
		{
			return true;
		}
		if (int_3 >= 97)
		{
			return int_3 <= 122;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int pkU7y7Wg4k(int int_3)
	{
		return int_3 - 48;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int nPH7841qhM(int int_3)
	{
		if (int_3 >= 97 && int_3 <= 122)
		{
			return int_3 - 32;
		}
		return int_3;
	}

	static CronExpression()
	{
		QFq7abs3Gj = TimeZoneInfo.Utc;
		sMo77eWDXr = Parse("0 0 1 1 *");
		IdJ7RYFnq7 = Parse("0 0 * * 0");
		S1o7qLbCsi = Parse("0 0 1 * *");
		seB7cXD1E8 = Parse("0 0 * * *");
		q3y7VZb2HM = Parse("0 * * * *");
		MmA7Z6Wdg3 = Parse("* * * * *");
		bN179gVry2 = Parse("* * * * * *", CronFormat.IncludeSeconds);
		b9w7hqwkcN = new int[64]
		{
			0, 1, 2, 53, 3, 7, 54, 27, 4, 38,
			41, 8, 34, 55, 48, 28, 62, 5, 39, 46,
			44, 42, 22, 9, 24, 35, 59, 56, 49, 18,
			29, 11, 63, 52, 6, 26, 37, 40, 33, 47,
			61, 45, 43, 21, 23, 58, 17, 10, 51, 25,
			36, 32, 60, 20, 57, 16, 50, 31, 19, 15,
			30, 14, 13, 12
		};
	}

	internal static bool FDlN2mdIX1x3EPxrOKQ()
	{
		return (object)RnpEUkdxK1oJ0uSMf9N == null;
	}
}
