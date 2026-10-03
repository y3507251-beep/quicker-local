using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NWgFv1fei1X1gnrcJmi;

namespace Quicker.Utilities.Ext.Types;

public class DelegateEqualityComparer<T> : IEqualityComparer<T>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<T, T, bool> _003C_003E9__3_0;

		public static Func<T, int> _003C_003E9__3_1;

		private static object nPtuGkyBeWw7F4RmnKkb;

		static _003C_003Ec()
		{
			_003C_003E9 = new _003C_003Ec();
		}

		internal bool sxo2NRhZkpp(T x, T y)
		{
			return object.Equals(x, y);
		}

		internal int Cqd2NqAvggr(T o)
		{
			return o.GetHashCode();
		}

		internal static bool nLlpwFyBjrE4uJu7bJJI()
		{
			return nPtuGkyBeWw7F4RmnKkb == null;
		}
	}

	private readonly Func<T, T, bool> EMYLi4KXkfr;

	private readonly Func<T, int> m8cLi5Z5bjK;

	internal static object VRvfL7F6VkpOcpWpbQhO;

	public DelegateEqualityComparer([vfInGIfbsoYlQBMjtrM] Func<T, T, bool> comparer, [vfInGIfbsoYlQBMjtrM] Func<T, int> hashGenerator)
	{
		EMYLi4KXkfr = comparer ?? throw new ArgumentNullException("comparer");
		m8cLi5Z5bjK = hashGenerator ?? throw new ArgumentNullException("hashGenerator");
	}

	public DelegateEqualityComparer()
		: this(_003C_003Ec._003C_003E9__3_0 ?? (_003C_003Ec._003C_003E9__3_0 = _003C_003Ec._003C_003E9.sxo2NRhZkpp), _003C_003Ec._003C_003E9__3_1 ?? (_003C_003Ec._003C_003E9__3_1 = _003C_003Ec._003C_003E9.Cqd2NqAvggr))
	{
	}

	public bool Equals(T x, T y)
	{
		return EMYLi4KXkfr(x, y);
	}

	public int GetHashCode(T obj)
	{
		return m8cLi5Z5bjK(obj);
	}

	internal static bool tcvObJF6QkXcg2RY9gDO()
	{
		return VRvfL7F6VkpOcpWpbQhO == null;
	}
}
