using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using s8bMSlmWCjFvbMSO8SX;

namespace Quicker.Pinyin;

public struct BitVector64 : IEnumerable<int>, IEnumerable, ICloneable
{
	private static readonly ulong[] LIXvJDTaHXN;

	private static readonly byte[] wX2vJdwYIUl;

	private ulong BnxvJoHygOF;

	private static object i9bywMcFBsjKhayYYOLe;

	public ulong Data => BnxvJoHygOF;

	public BitVector64(ulong data = 0uL)
	{
		BnxvJoHygOF = data;
	}

	public BitVector64(int setPosition)
	{
		BnxvJoHygOF = 0uL;
		Set(setPosition);
	}

	public BitVector64(BitVector64 value)
	{
		BnxvJoHygOF = value.Data;
	}

	public BitVector64(bool[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (value.Length != 0 && value.Length <= 64)
		{
			BnxvJoHygOF = 0uL;
			for (int i = 0; i < value.Length; i++)
			{
				if (value[i])
				{
					Set(i);
				}
			}
			return;
		}
		throw new IndexOutOfRangeException("The array provided sould be bound to the lenght between [1,64].");
	}

	public override bool Equals(object o)
	{
		if (!(o is BitVector64))
		{
			return false;
		}
		return BnxvJoHygOF == ((BitVector64)o).Data;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public bool Get(int index)
	{
		if (index < 0 || index > 63)
		{
			throw new IndexOutOfRangeException($"Index should be bount to [0-63] values, actual Index :{index}");
		}
		return (BnxvJoHygOF & LIXvJDTaHXN[index]) > 0L;
	}

	public BitVector64 Set(int index)
	{
		if (index < 0 || index > 63)
		{
			throw new IndexOutOfRangeException($"Index should be bount to [0-63] values, actual Index :{index}");
		}
		BnxvJoHygOF |= LIXvJDTaHXN[index];
		return this;
	}

	public BitVector64 Unset(int index)
	{
		if (index < 0 || index > 63)
		{
			throw new IndexOutOfRangeException($"Index should be bount to [0-63] values, actual Index :{index}");
		}
		BnxvJoHygOF &= ~LIXvJDTaHXN[index];
		return this;
	}

	public BitVector64 Apply(int index, bool status)
	{
		if (!status)
		{
			return Unset(index);
		}
		return Set(index);
	}

	public IEnumerator<int> GetEnumerator()
	{
		return new UEon6Kmwaw9obg65fby(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		ulong num = BnxvJoHygOF;
		for (int i = 0; i < 64; i++)
		{
			if ((num & 1L) != 0L)
			{
				stringBuilder.Append("1");
			}
			else
			{
				stringBuilder.Append("0");
			}
			num >>= 1;
		}
		return stringBuilder.ToString();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string StringFormatted()
	{
		char[] source = ToString().ToCharArray();
		List<char> list = source.ToList();
		list.Reverse();
		source = list.ToArray();
		string[] array = new string[8];
		for (int num = 7; num >= 0; num--)
		{
			array[7 - num] = string.Join(" ", source.Skip(num * 8).Take(8));
		}
		return "Actual Layout :\r\n ===============================================================================================================================================\r\n║        7        |        6        |        5        |        4        |        3        |        2        |        1        |        0        ║\r\n║ 7 6 5 4 3 2 1 0 | 7 6 5 4 3 2 1 0 | 7 6 5 4 3 2 1 0 | 7 6 5 4 3 2 1 0 | 7 6 5 4 3 2 1 0 | 7 6 5 4 3 2 1 0 | 7 6 5 4 3 2 1 0 | 7 6 5 4 3 2 1 0 ║\r\n║_________________|_________________|_________________|_________________|_________________|_________________|_________________|_________________║\r\n║                 |                 |                 |                 |                 |                 |                 |                 ║\r\n║ " + array[7] + " | " + array[6] + " | " + array[5] + " | " + array[4] + " | " + array[3] + " | " + array[2] + " | " + array[1] + " | " + array[0] + " ║\r\n ===============================================================================================================================================\r\n        ";
	}

	public BitVector64 InsertBits(ulong bits, int bitVectorApplyPoint, int bitsLength)
	{
		if (bitVectorApplyPoint >= 0 && bitVectorApplyPoint <= 63)
		{
			if (bitsLength >= 1 && bitsLength <= 64)
			{
				ulong num = 0uL;
				int num2 = 0;
				int num3 = 64 - bitsLength;
				int num4 = 0;
				if (bitVectorApplyPoint > 0)
				{
					num2 = 64 - bitVectorApplyPoint;
					num = BnxvJoHygOF << num2 >> num2;
				}
				num3 = 64 - bitsLength;
				num |= bits << num3 >> num3 << bitVectorApplyPoint;
				num4 = bitVectorApplyPoint + num3;
				if (num4 < 64)
				{
					num |= BnxvJoHygOF >> num4 << num4;
				}
				BnxvJoHygOF = num;
				int num5 = 0;
				if (i9bywMcFBsjKhayYYOLe != null)
				{
					int num6 = default(int);
					num5 = num6;
				}
				return num5 switch
				{
					_ => this, 
				};
			}
			throw new IndexOutOfRangeException($"BitsLength should be bount to [1,64] values, actual Value :{bitsLength}");
		}
		throw new IndexOutOfRangeException($"BitVectorApplyPoint should be bount to [0,63] values, actual Value :{bitVectorApplyPoint}");
	}

	public BitVector64 Reverse()
	{
		ulong num = BnxvJoHygOF & 0xFFL;
		ulong num2 = BnxvJoHygOF & 0xFF00L;
		int num3 = 1;
		if (!GGmfyBcFvkSR0JStBPYH())
		{
			int num4 = default(int);
			num3 = num4;
		}
		ulong num5 = default(ulong);
		ulong num6 = default(ulong);
		ulong num7 = default(ulong);
		ulong num8 = default(ulong);
		ulong num9 = default(ulong);
		ulong num10 = default(ulong);
		do
		{
			switch (num3)
			{
			case 1:
				goto IL_003d;
			}
			break;
			IL_003d:
			num5 = BnxvJoHygOF & 0xFF0000L;
			num6 = BnxvJoHygOF & 0xFF000000L;
			num7 = BnxvJoHygOF & 0xFF00000000L;
			num8 = BnxvJoHygOF & 0xFF0000000000L;
			num9 = BnxvJoHygOF & 0xFF000000000000L;
			num10 = BnxvJoHygOF & 0xFF00000000000000uL;
			num = wX2vJdwYIUl[num];
			num3 = 0;
		}
		while (!GGmfyBcFvkSR0JStBPYH());
		num2 = wX2vJdwYIUl[num2 >> 8];
		num5 = wX2vJdwYIUl[num5 >> 16];
		num6 = wX2vJdwYIUl[num6 >> 24];
		num7 = wX2vJdwYIUl[num7 >> 32];
		num8 = wX2vJdwYIUl[num8 >> 40];
		num9 = wX2vJdwYIUl[num9 >> 48];
		num10 = wX2vJdwYIUl[num10 >> 56];
		BnxvJoHygOF = 0uL;
		BnxvJoHygOF |= (num << 56) | (num2 << 48) | (num5 << 40) | (num6 << 32) | (num7 << 24) | (num8 << 16) | (num9 << 8) | num10;
		return this;
	}

	public BitVector64 Rotate(int bits)
	{
		if (bits < -256 || bits > 256)
		{
			throw new IndexOutOfRangeException($"Bits should be bount to [-256,256] values, actual Value :{bits}");
		}
		BnxvJoHygOF = (BnxvJoHygOF << bits) | (BnxvJoHygOF >> 64 - bits);
		return this;
	}

	public BitVector64 Shift(int bits)
	{
		if (bits < -63 || bits > 63)
		{
			throw new IndexOutOfRangeException($"Bits should be bount to [-63,63] values, actual Value :{bits}");
		}
		BnxvJoHygOF = ((bits > 0) ? (BnxvJoHygOF << bits) : (BnxvJoHygOF >> -bits));
		return this;
	}

	public BitVector64 Union(BitVector64 vector)
	{
		BnxvJoHygOF |= vector.Data;
		return this;
	}

	public BitVector64 Intersect(BitVector64 vector)
	{
		BnxvJoHygOF &= vector.Data;
		return this;
	}

	public BitVector64 Negate()
	{
		BnxvJoHygOF = ~BnxvJoHygOF;
		return this;
	}

	public BitVector64 ExclusiveUnion(BitVector64 vector)
	{
		BnxvJoHygOF ^= vector.Data;
		return this;
	}

	public BitVector64 Left(BitVector64 vector)
	{
		BnxvJoHygOF |= vector.Data;
		BnxvJoHygOF &= ~vector.Data;
		return this;
	}

	public BitVector64 Right(BitVector64 vector)
	{
		ulong bnxvJoHygOF = BnxvJoHygOF;
		BnxvJoHygOF |= vector.Data;
		BnxvJoHygOF &= ~bnxvJoHygOF;
		return this;
	}

	public BitVector64 SubsetAtoB(ushort subsetStart, ushort subsetEnd)
	{
		if (subsetStart < 0 || subsetStart > 63 || subsetEnd < 0 || subsetEnd > 63)
		{
			throw new IndexOutOfRangeException($"Boundaries must be in the range [0,63] , actual : [{subsetStart},[{subsetEnd}]");
		}
		return new BitVector64(BnxvJoHygOF << 63 - subsetEnd >> subsetStart + (63 - subsetEnd));
	}

	public BitVector64 SubsetATillLength(ushort subsetStart, short subsetLength = 0)
	{
		int num;
		int num2;
		while (true)
		{
			if (subsetStart >= 0)
			{
				if (!GGmfyBcFvkSR0JStBPYH())
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				if (subsetStart <= 63)
				{
					if (subsetLength == 0)
					{
						subsetLength = (short)(63 - subsetStart);
					}
					num = subsetStart;
					num2 = subsetStart + subsetLength + ((subsetLength <= 0) ? 1 : (-1));
					if (num > num2)
					{
						int num3 = num2;
						num2 = num;
						num = num3;
					}
					if (num >= 0 && num <= 63 && num2 >= 0 && num2 <= 63)
					{
						break;
					}
					throw new IndexOutOfRangeException($"Boundaries must be in the range [0,63] , actual : [{num},[{num2}]");
				}
			}
			throw new IndexOutOfRangeException($"SubsetStart must be in the range [0,63] , actual : {subsetStart}");
		}
		return SubsetAtoB((ushort)num, (ushort)num2);
	}

	public object Clone()
	{
		return new BitVector64(BnxvJoHygOF);
	}

	static BitVector64()
	{
		LIXvJDTaHXN = new ulong[64]
		{
			1uL, 2uL, 4uL, 8uL, 16uL, 32uL, 64uL, 128uL, 256uL, 512uL,
			1024uL, 2048uL, 4096uL, 8192uL, 16384uL, 32768uL, 65536uL, 131072uL, 262144uL, 524288uL,
			1048576uL, 2097152uL, 4194304uL, 8388608uL, 16777216uL, 33554432uL, 67108864uL, 134217728uL, 268435456uL, 536870912uL,
			1073741824uL, 2147483648uL, 4294967296uL, 8589934592uL, 17179869184uL, 34359738368uL, 68719476736uL, 137438953472uL, 274877906944uL, 549755813888uL,
			1099511627776uL, 2199023255552uL, 4398046511104uL, 8796093022208uL, 17592186044416uL, 35184372088832uL, 70368744177664uL, 140737488355328uL, 281474976710656uL, 562949953421312uL,
			1125899906842624uL, 2251799813685248uL, 4503599627370496uL, 9007199254740992uL, 18014398509481984uL, 36028797018963968uL, 72057594037927936uL, 144115188075855872uL, 288230376151711744uL, 576460752303423488uL,
			1152921504606846976uL, 2305843009213693952uL, 4611686018427387904uL, 9223372036854775808uL
		};
		wX2vJdwYIUl = new byte[256]
		{
			0, 128, 64, 192, 32, 160, 96, 224, 16, 144,
			80, 208, 48, 176, 112, 240, 8, 136, 72, 200,
			40, 168, 104, 232, 24, 152, 88, 216, 56, 184,
			120, 248, 4, 132, 68, 196, 36, 164, 100, 228,
			20, 148, 84, 212, 52, 180, 116, 244, 12, 140,
			76, 204, 44, 172, 108, 236, 28, 156, 92, 220,
			60, 188, 124, 252, 2, 130, 66, 194, 34, 162,
			98, 226, 18, 146, 82, 210, 50, 178, 114, 242,
			10, 138, 74, 202, 42, 170, 106, 234, 26, 154,
			90, 218, 58, 186, 122, 250, 6, 134, 70, 198,
			38, 166, 102, 230, 22, 150, 86, 214, 54, 182,
			118, 246, 14, 142, 78, 206, 46, 174, 110, 238,
			30, 158, 94, 222, 62, 190, 126, 254, 1, 129,
			65, 193, 33, 161, 97, 225, 17, 145, 81, 209,
			49, 177, 113, 241, 9, 137, 73, 201, 41, 169,
			105, 233, 25, 153, 89, 217, 57, 185, 121, 249,
			5, 133, 69, 197, 37, 165, 101, 229, 21, 149,
			85, 213, 53, 181, 117, 245, 13, 141, 77, 205,
			45, 173, 109, 237, 29, 157, 93, 221, 61, 189,
			125, 253, 3, 131, 67, 195, 35, 163, 99, 227,
			19, 147, 83, 211, 51, 179, 115, 243, 11, 139,
			75, 203, 43, 171, 107, 235, 27, 155, 91, 219,
			59, 187, 123, 251, 7, 135, 71, 199, 39, 167,
			103, 231, 23, 151, 87, 215, 55, 183, 119, 247,
			15, 143, 79, 207, 47, 175, 111, 239, 31, 159,
			95, 223, 63, 191, 127, 255
		};
	}

	internal static bool GGmfyBcFvkSR0JStBPYH()
	{
		return i9bywMcFBsjKhayYYOLe == null;
	}
}
