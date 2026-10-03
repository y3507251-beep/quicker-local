using System;
using System.Runtime.CompilerServices;

namespace VPh96vmMmNBh7tRTu2x;

internal static class DTDwRSmYd2lQpCxsGYx
{
	public ref struct cpWZu9H8me9MJNag5ZP
	{
		private ReadOnlySpan<char> TOf28X5oJqm;

		[CompilerGenerated]
		private hUI7jmHb9V9frxko7tr dK528mCfj7H;

		internal static object RtxnCCyatRnQRq1wvngG;

		public hUI7jmHb9V9frxko7tr Current
		{
			[CompilerGenerated]
			readonly get
			{
				return dK528mCfj7H;
			}
			[CompilerGenerated]
			private set
			{
				dK528mCfj7H = value;
			}
		}

		public cpWZu9H8me9MJNag5ZP(ReadOnlySpan<char> readOnlySpan_1)
		{
			TOf28X5oJqm = readOnlySpan_1;
			Current = default(hUI7jmHb9V9frxko7tr);
		}

		public cpWZu9H8me9MJNag5ZP CNg28HcjZqB()
		{
			return this;
		}

		public bool tEN281HFjRD()
		{
			ReadOnlySpan<char> tOf28X5oJqm = TOf28X5oJqm;
			if (tOf28X5oJqm.Length == 0)
			{
				return false;
			}
			int num = tOf28X5oJqm.IndexOfAny('\r', '\n');
			if (num == -1)
			{
				TOf28X5oJqm = ReadOnlySpan<char>.Empty;
				Current = new hUI7jmHb9V9frxko7tr(tOf28X5oJqm, ReadOnlySpan<char>.Empty);
				if (!bcjpoGyaSpIeYQLc8aFT())
				{
					switch (0)
					{
					}
				}
				return true;
			}
			if (num < tOf28X5oJqm.Length - 1 && tOf28X5oJqm[num] == '\r' && tOf28X5oJqm[num + 1] == '\n')
			{
				Current = new hUI7jmHb9V9frxko7tr(tOf28X5oJqm.Slice(0, num), tOf28X5oJqm.Slice(num, 2));
				TOf28X5oJqm = tOf28X5oJqm.Slice(num + 2);
				return true;
			}
			Current = new hUI7jmHb9V9frxko7tr(tOf28X5oJqm.Slice(0, num), tOf28X5oJqm.Slice(num, 1));
			TOf28X5oJqm = tOf28X5oJqm.Slice(num + 1);
			return true;
		}

		internal static bool bcjpoGyaSpIeYQLc8aFT()
		{
			return RtxnCCyatRnQRq1wvngG == null;
		}
	}

	public readonly ref struct hUI7jmHb9V9frxko7tr
	{
		[CompilerGenerated]
		private readonly ReadOnlySpan<char> D2428QLMsy8;

		[CompilerGenerated]
		private readonly ReadOnlySpan<char> Iq428jQjrSG;

		private static object rG3hI7yaTSqW58Ex0jQf;

		public hUI7jmHb9V9frxko7tr(ReadOnlySpan<char> readOnlySpan_2, ReadOnlySpan<char> readOnlySpan_3)
		{
			D2428QLMsy8 = readOnlySpan_2;
			Iq428jQjrSG = readOnlySpan_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public ReadOnlySpan<char> L4O28xq0r0e()
		{
			return D2428QLMsy8;
		}

		[SpecialName]
		[CompilerGenerated]
		public ReadOnlySpan<char> ooM28pipRw4()
		{
			return Iq428jQjrSG;
		}

		public void Acg28KVZnBQ(out ReadOnlySpan<char> readOnlySpan_2, out ReadOnlySpan<char> readOnlySpan_3)
		{
			readOnlySpan_2 = L4O28xq0r0e();
			readOnlySpan_3 = ooM28pipRw4();
		}

		public static implicit operator ReadOnlySpan<char>(hUI7jmHb9V9frxko7tr hUI7jmHb9V9frxko7tr_0)
		{
			return hUI7jmHb9V9frxko7tr_0.L4O28xq0r0e();
		}

		internal static bool ER63CkyamxXxBiItsgC5()
		{
			return rG3hI7yaTSqW58Ex0jQf == null;
		}
	}

	private static object Usm4sDcc3Nr5iA7Yfk4O;

	public static cpWZu9H8me9MJNag5ZP cKLv0nQCQtv(this string string_0)
	{
		return new cpWZu9H8me9MJNag5ZP(string_0.AsSpan());
	}

	public static int gqUv04BOxqL(this ReadOnlySpan<char> readOnlySpan_0)
	{
		int num = 0;
		ReadOnlySpan<char> readOnlySpan = readOnlySpan_0;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			char c = readOnlySpan[i];
			num = num * 10 + (c - 48);
		}
		return num;
	}

	internal static bool LPAwWrccEnRnyZZsjiDv()
	{
		return Usm4sDcc3Nr5iA7Yfk4O == null;
	}
}
