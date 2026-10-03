using System.Security.Cryptography;

namespace Qiniu.Util;

public class LabMD5
{
	private sealed class GP0IjMdFATMZOGXifnB
	{
		public uint A;

		public uint YyCv77BQaDE;

		public uint ys0v7RJiNfn;

		public uint MVqv7qSGeQb;

		internal static GP0IjMdFATMZOGXifnB nuhkVJcdOXwYenl4Ux2A;

		public GP0IjMdFATMZOGXifnB()
		{
			A = 1732584193u;
			YyCv77BQaDE = 4023233417u;
			ys0v7RJiNfn = 2562383102u;
			MVqv7qSGeQb = 271733878u;
		}

		public override string ToString()
		{
			return aEad0idvYk3cQ03rDXb.e9Lv7VDKd7J(A).ToString("x8") + aEad0idvYk3cQ03rDXb.e9Lv7VDKd7J(YyCv77BQaDE).ToString("x8") + aEad0idvYk3cQ03rDXb.e9Lv7VDKd7J(ys0v7RJiNfn).ToString("x8") + aEad0idvYk3cQ03rDXb.e9Lv7VDKd7J(MVqv7qSGeQb).ToString("x8");
		}

		internal static bool NvYULCcdJFyCUtiiRljB()
		{
			return nuhkVJcdOXwYenl4Ux2A == null;
		}
	}

	private static class aEad0idvYk3cQ03rDXb
	{
		internal static object jeWJbdcdaU6RbwOj6U4Y;

		public static uint othv7cCVOVO(uint uint_0, ushort ushort_0)
		{
			return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
		}

		public static uint e9Lv7VDKd7J(uint uint_0)
		{
			return ((uint_0 & 0xFF) << 24) | (uint_0 >> 24) | ((uint_0 & 0xFF0000) >> 8) | ((uint_0 & 0xFF00) << 8);
		}

		internal static bool Ejh0wVcdrZM5ixgV5FEv()
		{
			return jeWJbdcdaU6RbwOj6U4Y == null;
		}
	}

	private static readonly uint[] uMueVZ23we;

	private uint[] X = new uint[16];

	internal static LabMD5 j2YrmmLAmXXeFBlFEj5;

	public string ComputeHash(byte[] bytes)
	{
		GP0IjMdFATMZOGXifnB gP0IjMdFATMZOGXifnB = new GP0IjMdFATMZOGXifnB();
		byte[] array = RiIeaMHKg6(bytes);
		uint num = (uint)(array.Length * 8) / 32u;
		for (uint num2 = 0u; num2 < num / 16; num2++)
		{
			oW5e7CaDVY(array, num2);
			Ibwe8PY6Cm(ref gP0IjMdFATMZOGXifnB.A, ref gP0IjMdFATMZOGXifnB.YyCv77BQaDE, ref gP0IjMdFATMZOGXifnB.ys0v7RJiNfn, ref gP0IjMdFATMZOGXifnB.MVqv7qSGeQb);
		}
		return gP0IjMdFATMZOGXifnB.ToString();
	}

	private void Ibwe8PY6Cm(ref uint uint_1, ref uint uint_2, ref uint uint_3, ref uint uint_4)
	{
		uint num = uint_1;
		uint num2 = uint_2;
		int num3 = 6;
		while (true)
		{
			uint num4 = uint_3;
			uint num5 = uint_4;
			HGreRtvFDg(ref uint_1, uint_2, uint_3, uint_4, 0u, 7, 1u);
			while (true)
			{
				IL_04b9:
				HGreRtvFDg(ref uint_4, uint_1, uint_2, uint_3, 1u, 12, 2u);
				HGreRtvFDg(ref uint_3, uint_4, uint_1, uint_2, 2u, 17, 3u);
				int num6 = 1;
				if (!QHdEWVLnA7TE9mbNV8T())
				{
					goto IL_046f;
				}
				goto IL_0492;
				IL_0492:
				while (true)
				{
					switch (num6)
					{
					case 7:
						break;
					case 4:
						goto IL_0028;
					case 3:
						G(ref uint_3, uint_4, uint_1, uint_2, 11u, 14, 19u);
						G(ref uint_2, uint_3, uint_4, uint_1, 0u, 20, 20u);
						G(ref uint_1, uint_2, uint_3, uint_4, 5u, 5, 21u);
						G(ref uint_4, uint_1, uint_2, uint_3, 10u, 9, 22u);
						G(ref uint_3, uint_4, uint_1, uint_2, 15u, 14, 23u);
						G(ref uint_2, uint_3, uint_4, uint_1, 4u, 20, 24u);
						G(ref uint_1, uint_2, uint_3, uint_4, 9u, 5, 25u);
						G(ref uint_4, uint_1, uint_2, uint_3, 14u, 9, 26u);
						G(ref uint_3, uint_4, uint_1, uint_2, 3u, 14, 27u);
						G(ref uint_2, uint_3, uint_4, uint_1, 8u, 20, 28u);
						G(ref uint_1, uint_2, uint_3, uint_4, 13u, 5, 29u);
						G(ref uint_4, uint_1, uint_2, uint_3, 2u, 9, 30u);
						G(ref uint_3, uint_4, uint_1, uint_2, 7u, 14, 31u);
						G(ref uint_2, uint_3, uint_4, uint_1, 12u, 20, 32u);
						Xckeq3TSWP(ref uint_1, uint_2, uint_3, uint_4, 5u, 4, 33u);
						Xckeq3TSWP(ref uint_4, uint_1, uint_2, uint_3, 8u, 11, 34u);
						Xckeq3TSWP(ref uint_3, uint_4, uint_1, uint_2, 11u, 16, 35u);
						Xckeq3TSWP(ref uint_2, uint_3, uint_4, uint_1, 14u, 23, 36u);
						Xckeq3TSWP(ref uint_1, uint_2, uint_3, uint_4, 1u, 4, 37u);
						Xckeq3TSWP(ref uint_4, uint_1, uint_2, uint_3, 4u, 11, 38u);
						Xckeq3TSWP(ref uint_3, uint_4, uint_1, uint_2, 7u, 16, 39u);
						Xckeq3TSWP(ref uint_2, uint_3, uint_4, uint_1, 10u, 23, 40u);
						Xckeq3TSWP(ref uint_1, uint_2, uint_3, uint_4, 13u, 4, 41u);
						Xckeq3TSWP(ref uint_4, uint_1, uint_2, uint_3, 0u, 11, 42u);
						Xckeq3TSWP(ref uint_3, uint_4, uint_1, uint_2, 3u, 16, 43u);
						Xckeq3TSWP(ref uint_2, uint_3, uint_4, uint_1, 6u, 23, 44u);
						Xckeq3TSWP(ref uint_1, uint_2, uint_3, uint_4, 9u, 4, 45u);
						Xckeq3TSWP(ref uint_4, uint_1, uint_2, uint_3, 12u, 11, 46u);
						Xckeq3TSWP(ref uint_3, uint_4, uint_1, uint_2, 15u, 16, 47u);
						Xckeq3TSWP(ref uint_2, uint_3, uint_4, uint_1, 2u, 23, 48u);
						ukpecflyos(ref uint_1, uint_2, uint_3, uint_4, 0u, 6, 49u);
						ukpecflyos(ref uint_4, uint_1, uint_2, uint_3, 7u, 10, 50u);
						ukpecflyos(ref uint_3, uint_4, uint_1, uint_2, 14u, 15, 51u);
						ukpecflyos(ref uint_2, uint_3, uint_4, uint_1, 5u, 21, 52u);
						ukpecflyos(ref uint_1, uint_2, uint_3, uint_4, 12u, 6, 53u);
						ukpecflyos(ref uint_4, uint_1, uint_2, uint_3, 3u, 10, 54u);
						ukpecflyos(ref uint_3, uint_4, uint_1, uint_2, 10u, 15, 55u);
						ukpecflyos(ref uint_2, uint_3, uint_4, uint_1, 1u, 21, 56u);
						ukpecflyos(ref uint_1, uint_2, uint_3, uint_4, 8u, 6, 57u);
						ukpecflyos(ref uint_4, uint_1, uint_2, uint_3, 15u, 10, 58u);
						ukpecflyos(ref uint_3, uint_4, uint_1, uint_2, 6u, 15, 59u);
						num6 = 0;
						if (!QHdEWVLnA7TE9mbNV8T())
						{
							continue;
						}
						goto case 5;
					case 1:
						goto IL_044b;
					default:
						goto IL_046f;
					case 2:
						goto IL_04b9;
					case 6:
						goto end_IL_04b9;
					case 5:
						ukpecflyos(ref uint_2, uint_3, uint_4, uint_1, 13u, 21, 60u);
						ukpecflyos(ref uint_1, uint_2, uint_3, uint_4, 4u, 6, 61u);
						ukpecflyos(ref uint_4, uint_1, uint_2, uint_3, 11u, 10, 62u);
						ukpecflyos(ref uint_3, uint_4, uint_1, uint_2, 2u, 15, 63u);
						ukpecflyos(ref uint_2, uint_3, uint_4, uint_1, 9u, 21, 64u);
						uint_1 += num;
						uint_2 += num2;
						uint_3 += num4;
						uint_4 += num5;
						return;
					}
					break;
					IL_044b:
					HGreRtvFDg(ref uint_2, uint_3, uint_4, uint_1, 3u, 22, 4u);
					num6 = 0;
					if (QHdEWVLnA7TE9mbNV8T())
					{
						continue;
					}
					goto IL_011e;
				}
				goto IL_0016;
				IL_046f:
				HGreRtvFDg(ref uint_1, uint_2, uint_3, uint_4, 4u, 7, 5u);
				num6 = 5;
				if (QHdEWVLnA7TE9mbNV8T())
				{
					goto IL_0016;
				}
				goto IL_0492;
				IL_0016:
				HGreRtvFDg(ref uint_4, uint_1, uint_2, uint_3, 5u, 12, 6u);
				goto IL_0028;
				IL_0028:
				HGreRtvFDg(ref uint_3, uint_4, uint_1, uint_2, 6u, 17, 7u);
				HGreRtvFDg(ref uint_2, uint_3, uint_4, uint_1, 7u, 22, 8u);
				HGreRtvFDg(ref uint_1, uint_2, uint_3, uint_4, 8u, 7, 9u);
				HGreRtvFDg(ref uint_4, uint_1, uint_2, uint_3, 9u, 12, 10u);
				HGreRtvFDg(ref uint_3, uint_4, uint_1, uint_2, 10u, 17, 11u);
				HGreRtvFDg(ref uint_2, uint_3, uint_4, uint_1, 11u, 22, 12u);
				HGreRtvFDg(ref uint_1, uint_2, uint_3, uint_4, 12u, 7, 13u);
				HGreRtvFDg(ref uint_4, uint_1, uint_2, uint_3, 13u, 12, 14u);
				HGreRtvFDg(ref uint_3, uint_4, uint_1, uint_2, 14u, 17, 15u);
				HGreRtvFDg(ref uint_2, uint_3, uint_4, uint_1, 15u, 22, 16u);
				G(ref uint_1, uint_2, uint_3, uint_4, 1u, 5, 17u);
				G(ref uint_4, uint_1, uint_2, uint_3, 6u, 9, 18u);
				num6 = 3;
				if (!QHdEWVLnA7TE9mbNV8T())
				{
					goto IL_011e;
				}
				goto IL_0492;
				IL_011e:
				num6 = num3;
				goto IL_0492;
				continue;
				end_IL_04b9:
				break;
			}
		}
	}

	private byte[] RiIeaMHKg6(byte[] byte_0)
	{
        uint num3 = default;
		uint num = (uint)((448 - byte_0.Length * 8 % 512 + 512) % 512);
		if (num != 0)
		{
			goto IL_0046;
		}
		num = 512u;
		int num2 = 0;
		if (QHdEWVLnA7TE9mbNV8T())
		{
			goto IL_0039;
		}
		goto IL_006a;
		IL_0046:
		num3 = (uint)(byte_0.Length + num / 8 + 8L);
		num2 = 1;
		if (QHdEWVLnA7TE9mbNV8T())
		{
			goto IL_0039;
		}
		goto IL_006a;
		IL_006a:
		int num4 = default(int);
		num2 = num4;
		goto IL_0039;
		IL_0039:
		switch (num2)
		{
		case 1:
		{
			ulong num5 = (ulong)(byte_0.Length * 8L);
			byte[] array = new byte[num3];
			for (int i = 0; i < byte_0.Length; i++)
			{
				array[i] = byte_0[i];
			}
			array[byte_0.Length] |= 128;
			for (int num6 = 8; num6 > 0; num6--)
			{
				array[num3 - num6] = (byte)((num5 >> (8 - num6) * 8) & 0xFFL);
			}
			return array;
		}
		}
		goto IL_0046;
	}

	private void oW5e7CaDVY(byte[] byte_0, uint uint_1)
	{
		uint_1 <<= 6;
		for (uint num = 0u; num < 61; num += 4)
		{
			X[num >> 2] = (uint)((byte_0[uint_1 + num + 3] << 24) | (byte_0[uint_1 + num + 2] << 16) | (byte_0[uint_1 + num + 1] << 8) | byte_0[uint_1 + num]);
		}
	}

	private void HGreRtvFDg(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6)
	{
		uint_1 = uint_2 + aEad0idvYk3cQ03rDXb.othv7cCVOVO(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + X[uint_5] + uMueVZ23we[uint_6 - 1], ushort_0);
	}

	private void G(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
	{
		a = b + aEad0idvYk3cQ03rDXb.othv7cCVOVO(a + ((b & d) | (c & ~d)) + X[k] + uMueVZ23we[i - 1], s);
	}

	private void Xckeq3TSWP(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6)
	{
		uint_1 = uint_2 + aEad0idvYk3cQ03rDXb.othv7cCVOVO(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + X[uint_5] + uMueVZ23we[uint_6 - 1], ushort_0);
	}

	private void ukpecflyos(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6)
	{
		uint_1 = uint_2 + aEad0idvYk3cQ03rDXb.othv7cCVOVO(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + X[uint_5] + uMueVZ23we[uint_6 - 1], ushort_0);
	}

	public static string GenerateMD5(byte[] data)
	{
		byte[] array = MD5.Create().ComputeHash(data);
		string text = null;
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	static LabMD5()
	{
		uMueVZ23we = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
	}

	internal static bool QHdEWVLnA7TE9mbNV8T()
	{
		return j2YrmmLAmXXeFBlFEj5 == null;
	}
}
