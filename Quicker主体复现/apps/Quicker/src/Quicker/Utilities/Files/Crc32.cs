using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Quicker.Utilities.Files;

public sealed class Crc32 : HashAlgorithm
{
	public const uint DefaultPolynomial = 79764919u;

	public const uint DefaultSeed = uint.MaxValue;

	private static uint[] OTxvwrCqopY;

	private readonly uint q07vwpSAdrt;

	private readonly uint[] WTyvwBBmSnN;

	private uint MXOvwQpditA;

	private uint QrYvwjqLbO3 = uint.MaxValue;

	private bool bwfvwn4g06f = true;

	private bool M6jvw47fyyF = true;

	internal static Crc32 g4gI7TFseAvjjFIDokmv;

	public override int HashSize => 32;

	public Crc32()
		: this(79764919u, uint.MaxValue)
	{
	}

	public Crc32(uint polynomial, uint seed, uint XorOut = uint.MaxValue, bool refIn = true, bool refOut = true)
	{
		if (!BitConverter.IsLittleEndian)
		{
			throw new PlatformNotSupportedException("Not supported on Big Endian processors");
		}
		WTyvwBBmSnN = uFavwmBdbvK(polynomial, refIn);
		q07vwpSAdrt = (MXOvwQpditA = seed);
		QrYvwjqLbO3 = XorOut;
		bwfvwn4g06f = refIn;
		M6jvw47fyyF = refOut;
	}

	public override void Initialize()
	{
		MXOvwQpditA = q07vwpSAdrt;
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		MXOvwQpditA = uLivwKsnxm3(WTyvwBBmSnN, MXOvwQpditA, array, ibStart, cbSize, QrYvwjqLbO3, bwfvwn4g06f, M6jvw47fyyF);
	}

	protected override byte[] HashFinal()
	{
		return HashValue = U7OvwxZfaHO(MXOvwQpditA ^ QrYvwjqLbO3);
	}

	public static uint Compute(byte[] buffer)
	{
		return Compute(uint.MaxValue, buffer);
	}

	public static uint Compute(uint seed, byte[] buffer)
	{
		return Compute(79764919u, seed, buffer);
	}

	public static uint Compute(uint polynomial, uint seed, byte[] buffer)
	{
		return ~uLivwKsnxm3(uFavwmBdbvK(polynomial), seed, buffer, 0, buffer.Length);
	}

	private static uint[] uFavwmBdbvK(uint uint_5, bool bool_2 = true)
	{
		if (uint_5 == 79764919 && OTxvwrCqopY != null && bool_2)
		{
			return OTxvwrCqopY;
		}
		uint[] array = new uint[256];
		int num = 0;
		int num3 = default(int);
		while (true)
		{
			if (num >= 256)
			{
				int num2 = 1;
				if (g4gI7TFseAvjjFIDokmv != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				case 1:
					if (uint_5 == 79764919 && bool_2)
					{
						OTxvwrCqopY = array;
					}
					return array;
				}
			}
			uint num4 = (bool_2 ? reflect((uint)num, 8) : ((uint)num));
			num4 <<= 24;
			for (int i = 0; i < 8; i++)
			{
				int num5 = (int)num4 & int.MinValue;
				num4 <<= 1;
				if (num5 != 0)
				{
					num4 ^= uint_5;
				}
			}
			if (bool_2)
			{
				num4 = reflect(num4, 32);
			}
			array[num] = num4;
			num++;
		}
	}

	private static uint uLivwKsnxm3(uint[] uint_5, uint uint_6, IList<byte> ilist_0, int int_0, int int_1, uint uint_7 = uint.MaxValue, bool bool_2 = true, bool bool_3 = true)
	{
		uint num = uint_6;
		if (bool_2)
		{
			for (int i = int_0; i < int_0 + int_1; i++)
			{
				num = (num >> 8) ^ uint_5[ilist_0[i] ^ (num & 0xFF)];
			}
		}
		else
		{
			for (int j = int_0; j < int_0 + int_1; j++)
			{
				num = (num << 8) ^ uint_5[ilist_0[j] ^ ((num >> 24) & 0xFF)];
			}
		}
		if (bool_2 ^ bool_3)
		{
			num = reflect(num, 32);
		}
		return num;
	}

	private static byte[] U7OvwxZfaHO(uint uint_5)
	{
		byte[] bytes = BitConverter.GetBytes(uint_5);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	public static uint reflect(uint crc, int bitnum)
	{
		int num = 1;
		while (true)
		{
			uint num2 = 1u;
			int num3 = 0;
			if (g4gI7TFseAvjjFIDokmv != null)
			{
				num3 = num;
			}
			switch (num3)
			{
			case 1:
				continue;
			}
			uint num4 = 0u;
			for (uint num5 = (uint)(1 << bitnum - 1); num5 != 0; num5 >>= 1)
			{
				if ((crc & num5) != 0)
				{
					num4 |= num2;
				}
				num2 <<= 1;
			}
			return num4;
		}
	}

	internal static bool Svc08XFsj6noVHGtNVq8()
	{
		return g4gI7TFseAvjjFIDokmv == null;
	}
}
