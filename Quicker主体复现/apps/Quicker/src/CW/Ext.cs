using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CW;

public static class Ext
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__35<T>
	{
		public static readonly _003C_003Ec__35<T> _003C_003E9;

		public static Func<T, string> _003C_003E9__35_0;

		internal static object lATqfTcEa2nDS2aLRmwc;

		static _003C_003Ec__35()
		{
			_003C_003E9 = new _003C_003Ec__35<T>();
		}

		internal string cQxvyYY21Cw(T o)
		{
			return o.ToString();
		}

		internal static bool PsZXrlcErEWMSvEl7rk5()
		{
			return lATqfTcEa2nDS2aLRmwc == null;
		}
	}

	private static object OUh0B43tE01jOOa24pj;

	public static void ThrowIfNull(this object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException();
		}
	}

	public static void ThrowIfNull(this object obj, string message)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(message);
		}
	}

	public static void ThrowIfNull(this IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			throw new ArgumentNullException();
		}
	}

	public static void ThrowIfNull(this IntPtr obj, string message)
	{
		if (obj == IntPtr.Zero)
		{
			throw new ArgumentNullException(message);
		}
	}

	public static void ThrowIfOutOfRange(this int n, int min, int max)
	{
		if (n < min || max < n)
		{
			throw new ArgumentOutOfRangeException();
		}
	}

	public static void ThrowIfOutOfRange(this int n, int min, int max, string message)
	{
		if (n < min || max < n)
		{
			throw new ArgumentOutOfRangeException(message);
		}
	}

	public static void ThrowIfOutOfRange(this int n, int min)
	{
		if (n < min)
		{
			throw new ArgumentOutOfRangeException();
		}
	}

	public static void ThrowIfOutOfRange(this int n, int min, string message)
	{
		if (n < min)
		{
			throw new ArgumentOutOfRangeException(message);
		}
	}

	public static void ThrowIfOutOfRange(this double n, double min, double max)
	{
		if (n < min || max < n)
		{
			throw new ArgumentOutOfRangeException();
		}
	}

	public static void ThrowIfOutOfRange(this double n, double min, double max, string message)
	{
		if (n < min || max < n)
		{
			throw new ArgumentOutOfRangeException(message);
		}
	}

	public static void ThrowIfOutOfRange(this double n, double min)
	{
		if (n < min)
		{
			throw new ArgumentOutOfRangeException();
		}
	}

	public static void ThrowIfOutOfRange(this double n, double min, string message)
	{
		if (n < min)
		{
			throw new ArgumentOutOfRangeException(message);
		}
	}

	public static void ThrowIfOutOfRange(this long n, long min, long max)
	{
		if (n < min || max < n)
		{
			throw new ArgumentOutOfRangeException();
		}
	}

	public static void ThrowIfOutOfRange(this long n, long min, long max, string message)
	{
		if (n < min || max < n)
		{
			throw new ArgumentOutOfRangeException(message);
		}
	}

	public static void ThrowIfOutOfRange(this long n, long min)
	{
		if (n < min)
		{
			throw new ArgumentOutOfRangeException();
		}
	}

	public static void ThrowIfOutOfRange(this long n, long min, string message)
	{
		if (n < min)
		{
			throw new ArgumentOutOfRangeException(message);
		}
	}

	public static void ThrowIfNullOrEmpty(this string str, string message)
	{
		if (str == null)
		{
			throw new ArgumentNullException(message);
		}
		if (str == "")
		{
			throw new ArgumentException(message);
		}
	}

	public static string GetInformationalVersion(this Assembly asm)
	{
		return asm.GetCustomAttributes().OfType<AssemblyInformationalVersionAttribute>().FirstOrDefault()?.InformationalVersion;
	}

	public static Version GetVersion(this Assembly asm)
	{
		return asm.GetName().Version;
	}

	public static string GetCopyright(this Assembly asm)
	{
		return asm.GetCustomAttributes().OfType<AssemblyCopyrightAttribute>().FirstOrDefault()?.Copyright;
	}

	public static string GetDescription(this Assembly asm)
	{
		return asm.GetCustomAttributes().OfType<AssemblyDescriptionAttribute>().FirstOrDefault()?.Description;
	}

	public static bool IsNullOrEmpty(this string str)
	{
		return string.IsNullOrEmpty(str);
	}

	public static bool IsNullOrWhitespace(this string str)
	{
		return string.IsNullOrWhiteSpace(str);
	}

	public static int IndexOfRegex(this string str, string pattern)
	{
		return str.IndexOfRegex(pattern, 0, RegexOptions.None);
	}

	public static int IndexOfRegex(this string str, string pattern, int start)
	{
		return str.IndexOfRegex(pattern, start, RegexOptions.None);
	}

	public static int IndexOfRegex(this string str, string pattern, int start, RegexOptions options)
	{
		Match match = new Regex(pattern).Match(str, start);
		if (!match.Success)
		{
			return match.Index;
		}
		return match.Index;
	}

	public static string ReplaceRegex(this string str, string pattern, string replacement)
	{
		return Regex.Replace(str, pattern, replacement);
	}

	public static string ReplaceRegex(this string str, string pattern, string replacement, RegexOptions option)
	{
		return Regex.Replace(str, pattern, replacement, option);
	}

	public static string ReplaceRegex(this string str, string pattern, MatchEvaluator eval)
	{
		return Regex.Replace(str, pattern, eval);
	}

	public static string ReplaceRegex(this string str, string pattern, MatchEvaluator eval, RegexOptions option)
	{
		return Regex.Replace(str, pattern, eval, option);
	}

	public static string Replace(this string str, string[] oldValues, string newValue)
	{
		foreach (string oldValue in oldValues)
		{
			str = str.Replace(oldValue, newValue);
		}
		return str;
	}

	public static Match Match(this string str, string pattern)
	{
		return Regex.Match(str, pattern);
	}

	public static Match Match(this string str, string pattern, RegexOptions options)
	{
		return Regex.Match(str, pattern, options);
	}

	public static Match MatchIgnoreCase(this string str, string pattern, RegexOptions options)
	{
		return Regex.Match(str, pattern, RegexOptions.IgnoreCase);
	}

	public static string Join(this IEnumerable<string> source, string separator)
	{
		return string.Join(separator, source.ToArray());
	}

	public static string Join<T>(this IEnumerable<T> source, string separator)
	{
		return string.Join(separator, source.Select(_003C_003Ec__35<T>._003C_003E9__35_0 ?? (_003C_003Ec__35<T>._003C_003E9__35_0 = _003C_003Ec__35<T>._003C_003E9.cQxvyYY21Cw)).ToArray());
	}

	public static bool IsDecimalNumber(this char c)
	{
		if ('0' > c)
		{
			return false;
		}
		return c <= '9';
	}

	public static bool IsSmallAlphabet(this char c)
	{
		if ('a' <= c)
		{
			return c <= 'z';
		}
		return false;
	}

	public static bool IsLargeAlphabet(this char c)
	{
		if ('A' <= c)
		{
			return c <= 'Z';
		}
		return false;
	}

	public static bool IsHiragana(this char c)
	{
		if ('\u3040' <= c)
		{
			return c <= 'ゟ';
		}
		return false;
	}

	public static bool IsKatakana(this char c)
	{
		if ('ァ' <= c)
		{
			return c <= 'ヺ';
		}
		return false;
	}

	public static bool IsKanji(this char c)
	{
		if ('一' <= c)
		{
			return c <= '鿿';
		}
		return false;
	}

	public static void Shuffle<T>(T[] array)
	{
		int num = array.Length;
		Random random = new Random();
		while (num > 1)
		{
			int num2 = random.Next(num);
			num--;
			T val = array[num];
			array[num] = array[num2];
			array[num2] = val;
		}
	}

	public static void StableSort<T>(this T[] array)
	{
		array.MergeSort(Comparer<T>.Default);
	}

	public static void StableSort<T>(this T[] array, IComparer<T> comparer)
	{
		array.MergeSort(comparer);
	}

	public static void MergeSort<T>(this T[] array)
	{
		array.MergeSort(Comparer<T>.Default);
	}

	public static void MergeSort<T>(this T[] array, IComparer<T> comparer)
	{
		array.zA30v5s42a(comparer, 0, array.Length, new T[array.Length]);
	}

	private static void zA30v5s42a<RIbPhbzI7bOD0QEYIm>(this RIbPhbzI7bOD0QEYIm[] gparam_0, IComparer<RIbPhbzI7bOD0QEYIm> icomparer_0, int int_0, int int_1, RIbPhbzI7bOD0QEYIm[] gparam_1)
	{
		if (int_0 < int_1 - 1)
		{
			if (int_1 - int_0 <= 16)
			{
				gparam_0.vF10SKI6c6(icomparer_0, int_0, int_1);
				return;
			}
			int num = int_0 + int_1 >> 1;
			gparam_0.zA30v5s42a(icomparer_0, int_0, num, gparam_1);
			gparam_0.zA30v5s42a(icomparer_0, num, int_1, gparam_1);
			gparam_0.Merge(icomparer_0, int_0, num, int_1, gparam_1);
		}
	}

	private static void Merge<T>(this T[] array, IComparer<T> comparer, int left, int middle, int right, T[] temp)
	{
		Array.Copy(array, left, temp, left, middle - left);
		int num = middle;
		int num2 = right - 1;
		while (num < right)
		{
			temp[num] = array[num2];
			num++;
			num2--;
		}
		num = left;
		num2 = right - 1;
		for (int i = left; i < right; i++)
		{
			if (comparer.Compare(temp[num], temp[num2]) < 0)
			{
				array[i] = temp[num++];
			}
			else
			{
				array[i] = temp[num2--];
			}
		}
	}

	public static void InsertSort<T>(this T[] array)
	{
		array.vF10SKI6c6(Comparer<T>.Default, 0, array.Length);
	}

	private static void vF10SKI6c6<ciIAx5qlX3LGREC2LT0>(this ciIAx5qlX3LGREC2LT0[] gparam_0, IComparer<ciIAx5qlX3LGREC2LT0> icomparer_0, int int_0, int int_1)
	{
		for (int i = int_0 + 1; i < int_1; i++)
		{
			int num = i;
			while (num >= int_0 + 1 && icomparer_0.Compare(gparam_0[num - 1], gparam_0[num]) > 0)
			{
				sZv0uBB0OU(ref gparam_0[num], ref gparam_0[num - 1]);
				num--;
			}
		}
	}

	public static void ShellSort<T>(this T[] array)
	{
		array.rgL028NESJ(Comparer<T>.Default, 0, array.Length);
	}

	private static void rgL028NESJ<baIigyqqlhUUSRmtGYm>(this baIigyqqlhUUSRmtGYm[] gparam_0, IComparer<baIigyqqlhUUSRmtGYm> icomparer_0, int int_0, int int_1)
	{
		int num;
		for (num = int_0 + 1; num < int_1; num = num * 3 + 1)
		{
		}
		int num2 = int_0 + 1;
		while (num > num2)
		{
			num /= 3;
			for (int i = num; i < int_1; i++)
			{
				baIigyqqlhUUSRmtGYm val = gparam_0[i];
				int num3 = i - num;
				while (icomparer_0.Compare(val, gparam_0[num3]) < 0)
				{
					gparam_0[num3 + num] = gparam_0[num3];
					num3 -= num;
					if (num3 < int_0)
					{
						break;
					}
				}
				gparam_0[num3 + num] = val;
			}
		}
	}

	private static void sZv0uBB0OU<Jpd4HCq5DlHlCrw4Tdp>(ref Jpd4HCq5DlHlCrw4Tdp gparam_0, ref Jpd4HCq5DlHlCrw4Tdp gparam_1)
	{
		Jpd4HCq5DlHlCrw4Tdp val = gparam_0;
		gparam_0 = gparam_1;
		gparam_1 = val;
	}

	public static void HeapSort<T>(this T[] array)
	{
		array.I2B0N25dVf(Comparer<T>.Default, 0, array.Length);
	}

	private static void I2B0N25dVf<DbbUJWqAVkx2Mb5DAGr>(this DbbUJWqAVkx2Mb5DAGr[] gparam_0, IComparer<DbbUJWqAVkx2Mb5DAGr> icomparer_0, int int_0, int int_1)
	{
		int num = int_1 - 1;
		for (int num2 = num - 1 >> 1; num2 >= int_0; num2--)
		{
			gparam_0.gu70JTQ9FO(icomparer_0, num2, num);
		}
		for (int num3 = num; num3 > int_0; num3--)
		{
			sZv0uBB0OU(ref gparam_0[int_0], ref gparam_0[num3]);
			gparam_0.gu70JTQ9FO(icomparer_0, int_0, num3 - 1);
		}
	}

	private static void gu70JTQ9FO<As7XabqwI4JK16gNgU0>(this As7XabqwI4JK16gNgU0[] gparam_0, IComparer<As7XabqwI4JK16gNgU0> icomparer_0, int int_0, int int_1)
	{
		As7XabqwI4JK16gNgU0 val = gparam_0[int_0];
		while (true)
		{
			int num = (int_0 << 1) + 1;
			if (num > int_1)
			{
				break;
			}
			if (num != int_1 && icomparer_0.Compare(gparam_0[num + 1], gparam_0[num]) > 0)
			{
				num++;
			}
			if (icomparer_0.Compare(val, gparam_0[num]) >= 0)
			{
				break;
			}
			gparam_0[int_0] = gparam_0[num];
			int_0 = num;
		}
		gparam_0[int_0] = val;
	}

	public static void Raise(this Delegate handler, params object[] args)
	{
		handler?.DynamicInvoke(args);
	}

	public static bool IsAlive<T>(this WeakReference<T> reference) where T : class
	{
		reference.ThrowIfNull("reference");
		T target;
		return reference.TryGetTarget(out target);
	}

	static Ext()
	{
	}

	internal static bool nYQVRH3ShRroV0bb2T3()
	{
		return OUh0B43tE01jOOa24pj == null;
	}

	internal static void m2YZ7d3mF7drSuK3FEL()
	{
	}
}
