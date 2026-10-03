using System;
using System.Collections.Generic;

namespace CW;

public struct Range<T> : IEquatable<Range<T>>
{
	private T YyE0sDe1ke;

	private T nb10HM72wS;

	private bool Bwi01PLsPa;

	private bool qdK0bH0cAt;

	private IComparer<T> m0A06xtORs;

	public T LowerBound
	{
		get
		{
			return YyE0sDe1ke;
		}
		set
		{
			YyE0sDe1ke = value;
		}
	}

	public T UpperBound
	{
		get
		{
			return nb10HM72wS;
		}
		set
		{
			nb10HM72wS = value;
		}
	}

	public bool IsExcludingLowerBound
	{
		get
		{
			return Bwi01PLsPa;
		}
		set
		{
			Bwi01PLsPa = value;
		}
	}

	public bool IsExcludingUpperBound
	{
		get
		{
			return qdK0bH0cAt;
		}
		set
		{
			qdK0bH0cAt = value;
		}
	}

	public Range(T lower, T upper)
		: this(lower, upper, false, false, Comparer<T>.Default)
	{
	}

	public Range(T lower, T upper, bool excludeLower, bool excludeUpper)
		: this(lower, upper, false, false, Comparer<T>.Default)
	{
	}

	public Range(T lower, T upper, bool excludeLower, bool excludeUpper, IComparer<T> comparer)
	{
		YyE0sDe1ke = lower;
		nb10HM72wS = upper;
		Bwi01PLsPa = excludeLower;
		qdK0bH0cAt = excludeUpper;
		m0A06xtORs = comparer;
	}

	public bool Contains(T value)
	{
		return (YyE0sDe1ke == null || (Bwi01PLsPa ? (m0A06xtORs.Compare(YyE0sDe1ke, value) < 0) : (m0A06xtORs.Compare(YyE0sDe1ke, value) <= 0))) & (nb10HM72wS == null || (qdK0bH0cAt ? (m0A06xtORs.Compare(nb10HM72wS, value) > 0) : (m0A06xtORs.Compare(nb10HM72wS, value) >= 0)));
	}

	public bool Equals(Range<T> other)
	{
		ref T reference = ref nb10HM72wS;
		object obj = other.nb10HM72wS;
		if (reference.Equals(obj))
		{
			ref T yyE0sDe1ke = ref YyE0sDe1ke;
			object obj2 = other.YyE0sDe1ke;
			if (yyE0sDe1ke.Equals(obj2) && Bwi01PLsPa.Equals(other.Bwi01PLsPa))
			{
				return qdK0bH0cAt.Equals(other.qdK0bH0cAt);
			}
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Range<T>))
		{
			return false;
		}
		return Equals((Range<T>)obj);
	}

	public override int GetHashCode()
	{
		return nb10HM72wS.GetHashCode() ^ YyE0sDe1ke.GetHashCode() ^ Bwi01PLsPa.GetHashCode() ^ qdK0bH0cAt.GetHashCode();
	}

	public static bool operator ==(Range<T> a, Range<T> b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Range<T> a, Range<T> b)
	{
		return !a.Equals(b);
	}

	public bool IsIntersetWith(Range<T> range)
	{
		if (!Contains(range.YyE0sDe1ke) && !Contains(range.nb10HM72wS) && !range.Contains(YyE0sDe1ke))
		{
			return range.Contains(nb10HM72wS);
		}
		return true;
	}
}
