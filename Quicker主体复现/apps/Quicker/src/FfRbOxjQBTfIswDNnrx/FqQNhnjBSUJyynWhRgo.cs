using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FfRbOxjQBTfIswDNnrx;

internal class FqQNhnjBSUJyynWhRgo
{
	[CompilerGenerated]
	private static readonly IDictionary<int, long> kOxtGLGhCtK;

	private static FqQNhnjBSUJyynWhRgo icJ48eQkr1cuXdeBKMx7;

	[SpecialName]
	[CompilerGenerated]
	public static IDictionary<int, long> qjYtkzieV5U()
	{
		return kOxtGLGhCtK;
	}

	public static long NYctklW6TK8(int int_0, int int_1 = 1)
	{
		long num = UGMtkiVKyee(int_0) + int_1;
		kOxtGLGhCtK[int_0] = num;
		return num;
	}

	public static long UGMtkiVKyee(int int_0)
	{
		if (!kOxtGLGhCtK.TryGetValue(int_0, out var value))
		{
			return 0L;
		}
		return value;
	}

	[SpecialName]
	public static long PRBtGteJEgc()
	{
		return UGMtkiVKyee(1000);
	}

	public static void KRCtk3Mv9Y2()
	{
		NYctklW6TK8(1000);
	}

	public static void fmJtkftCEOK(int int_0)
	{
		NYctklW6TK8(int_0);
	}

	static FqQNhnjBSUJyynWhRgo()
	{
		kOxtGLGhCtK = new ConcurrentDictionary<int, long>();
	}

	internal static bool NgruU4QkNIhRL3lRhotY()
	{
		return icJ48eQkr1cuXdeBKMx7 == null;
	}
}
