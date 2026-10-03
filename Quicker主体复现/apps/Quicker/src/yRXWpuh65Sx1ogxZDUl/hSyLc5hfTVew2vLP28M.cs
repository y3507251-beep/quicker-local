using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace yRXWpuh65Sx1ogxZDUl;

internal class hSyLc5hfTVew2vLP28M
{
	private delegate void BZAOngh7u4ajJARZSRb(object o);

	internal class mo3pfAhifnsSpM9tlbk : Attribute
	{
		internal class tKkI82hmLeLDTEjpvL8<lu9XtChdwHA8kmluu3f>
		{
			internal static object nubU09yiTY9jOwrT7jIQ;

			internal static bool tLZ2G4yiml9cYQhA9oPS()
			{
				return nubU09yiTY9jOwrT7jIQ == null;
			}
		}

		[mo3pfAhifnsSpM9tlbk(typeof(tKkI82hmLeLDTEjpvL8<Object>[]))]
		public mo3pfAhifnsSpM9tlbk(object object_0)
		{
		}
	}

	internal class MAkiwRhuDmOu0e1aVl6
	{
		[mo3pfAhifnsSpM9tlbk(typeof(mo3pfAhifnsSpM9tlbk.tKkI82hmLeLDTEjpvL8<Object>[]))]
		internal static string yrc2hAWlSmW(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = C2v29xhIWx4(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Fwu29mirCUe();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint RsaBwdhDRITJB4UGPNp(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr WH0fiChHNaAiFAkJ86g();

	internal struct esj6TXhkuTLMIFe9b2K
	{
		internal bool t892hOpv3OJ;

		internal byte[] BOs2hFKErfe;
	}

	internal class fikEZWhhTCvCeJ5W2UV
	{
		private BinaryReader oQD2hffH9vM;

		public fikEZWhhTCvCeJ5W2UV(Stream stream_0)
		{
			oQD2hffH9vM = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return oQD2hffH9vM.BaseStream;
		}

		internal byte[] zBA2hUd35Ca(int int_0)
		{
			return oQD2hffH9vM.ReadBytes(int_0);
		}

		internal int CS42hlOrvFM(byte[] byte_0, int int_0, int int_1)
		{
			return oQD2hffH9vM.Read(byte_0, int_0, int_1);
		}

		internal int ylt2hiCUAXy()
		{
			return oQD2hffH9vM.ReadInt32();
		}

		internal void tnZ2h3c98Gj()
		{
			oQD2hffH9vM.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr GFfYU7h85WkeueTakSW(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr vFA2ouhbWDTuSP2cFVa(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int hMfBiMhe7ZDvrqWLAni(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int EFGlR8h1Z7itmjAGVdU(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr vN8eyHhct7IPFF1JOiH(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int vu7lJ7h9orsfiBw5kTI(IntPtr ptr);

	[Flags]
	private enum Bwamp3hPQmCqWO9c96A
	{

	}

	private static uint[] b2I2hReuDa3;

	private static int Rrd2hsTJHS9;

	private static IntPtr yqH2hQsY3rD;

	private static EFGlR8h1Z7itmjAGVdU JGH2hdJfCdn;

	internal static Assembly GU52h7mINJQ;

	private static byte[] brs2hVa9NBa;

	internal static RsaBwdhDRITJB4UGPNp hoV2hX5tU45;

	private static vN8eyHhct7IPFF1JOiH LDj2ho4pnZ2;

	private static bool Ymb2hpQKRPJ;

	private static bool M1O2hHAekPF;

	private static bool KnG2hr09xCH;

	internal static Hashtable L8l2hndofpl;

	private static GFfYU7h85WkeueTakSW oAg2h4ELLvb;

	private static string[] FvG2hkOfFxc;

	private static long oMk2h6PpwEY;

	private static hMfBiMhe7ZDvrqWLAni tHx2hDEBkFj;

	internal static RSACryptoServiceProvider xUR2hZ32IVL;

	private static IntPtr i7Z2hIdqt6t;

	private static bool fh22hcSJkTc;

	private static int qJi2hbBOWs9;

	private static SortedList FwR2h11tEAc;

	private static byte[] jWA2heE5I9S;

	private static vu7lJ7h9orsfiBw5kTI rqx2hT1snkN;

	internal static RsaBwdhDRITJB4UGPNp aaP2hmWEu9J;

	private static IntPtr OI72hMlnf0n;

	private static bool c4w2hqcYFjT;

	[mo3pfAhifnsSpM9tlbk(typeof(mo3pfAhifnsSpM9tlbk.tKkI82hmLeLDTEjpvL8<Object>[]))]
	private static bool qNa2hjLMOyN;

	private static IntPtr qWv2hWtJREk;

	private static bool cvO2hata14K;

	private static Dictionary<int, int> WoW2h9xYxDf;

	private static int ybH2hxsxCse;

	private static byte[] kx02hYfFLai;

	private static int[] QOt2hGr5A1S;

	private static int yUM2hBvRGo0;

	private static long qEE2hKKI9te;

	private static object nu12hhBNor0;

	private static vFA2ouhbWDTuSP2cFVa v1q2h5IakSc;

	static hSyLc5hfTVew2vLP28M()
	{
		cvO2hata14K = false;
		GU52h7mINJQ = typeof(hSyLc5hfTVew2vLP28M).Assembly;
		b2I2hReuDa3 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		c4w2hqcYFjT = false;
		fh22hcSJkTc = false;
		brs2hVa9NBa = new byte[0];
		xUR2hZ32IVL = null;
		WoW2h9xYxDf = null;
		nu12hhBNor0 = new object();
		jWA2heE5I9S = new byte[0];
		kx02hYfFLai = new byte[0];
		i7Z2hIdqt6t = IntPtr.Zero;
		qWv2hWtJREk = IntPtr.Zero;
		FvG2hkOfFxc = new string[0];
		QOt2hGr5A1S = new int[0];
		Rrd2hsTJHS9 = 1;
		M1O2hHAekPF = false;
		FwR2h11tEAc = new SortedList();
		qJi2hbBOWs9 = 0;
		oMk2h6PpwEY = 0L;
		hoV2hX5tU45 = null;
		aaP2hmWEu9J = null;
		qEE2hKKI9te = 0L;
		ybH2hxsxCse = 0;
		KnG2hr09xCH = false;
		Ymb2hpQKRPJ = false;
		yUM2hBvRGo0 = 0;
		yqH2hQsY3rD = IntPtr.Zero;
		qNa2hjLMOyN = false;
		L8l2hndofpl = new Hashtable();
		oAg2h4ELLvb = null;
		v1q2h5IakSc = null;
		tHx2hDEBkFj = null;
		JGH2hdJfCdn = null;
		LDj2ho4pnZ2 = null;
		rqx2hT1snkN = null;
		OI72hMlnf0n = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void wFMSnsTWFOAn5()
	{
	}

	internal static byte[] By529G9npPu(byte[] byte_3)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_3.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(byte_3.Length + num2 / 8 + 8L);
		ulong num4 = (ulong)(byte_3.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_3.Length; i++)
		{
			array2[i] = byte_3[i];
		}
		array2[byte_3.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFFL);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num7 = 0u; num7 < num6 / 16; num7++)
		{
			uint num8 = num7 << 6;
			for (uint num9 = 0u; num9 < 61; num9 += 4)
			{
				array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
			}
			uint num10 = uint_;
			uint num11 = uint_2;
			uint num12 = uint_3;
			uint num13 = uint_4;
			pXD29sVSp7Q(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			pXD29sVSp7Q(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			pXD29sVSp7Q(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			pXD29sVSp7Q(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			pXD29sVSp7Q(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			pXD29sVSp7Q(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			pXD29sVSp7Q(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			pXD29sVSp7Q(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			pXD29sVSp7Q(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			pXD29sVSp7Q(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			pXD29sVSp7Q(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			pXD29sVSp7Q(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			pXD29sVSp7Q(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			pXD29sVSp7Q(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			pXD29sVSp7Q(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			pXD29sVSp7Q(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			JMp29HQ0Wj4(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			JMp29HQ0Wj4(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			JMp29HQ0Wj4(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			JMp29HQ0Wj4(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			JMp29HQ0Wj4(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			JMp29HQ0Wj4(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			JMp29HQ0Wj4(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			JMp29HQ0Wj4(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			JMp29HQ0Wj4(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			JMp29HQ0Wj4(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			JMp29HQ0Wj4(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			JMp29HQ0Wj4(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			JMp29HQ0Wj4(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			JMp29HQ0Wj4(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			JMp29HQ0Wj4(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			JMp29HQ0Wj4(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			eNn2918QoJ6(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			eNn2918QoJ6(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			eNn2918QoJ6(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			eNn2918QoJ6(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			eNn2918QoJ6(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			eNn2918QoJ6(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			eNn2918QoJ6(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			eNn2918QoJ6(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			eNn2918QoJ6(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			eNn2918QoJ6(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			eNn2918QoJ6(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			eNn2918QoJ6(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			eNn2918QoJ6(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			eNn2918QoJ6(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			eNn2918QoJ6(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			eNn2918QoJ6(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			sRL29bUFS1Z(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			sRL29bUFS1Z(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			sRL29bUFS1Z(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			sRL29bUFS1Z(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			sRL29bUFS1Z(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			sRL29bUFS1Z(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			sRL29bUFS1Z(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			sRL29bUFS1Z(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			sRL29bUFS1Z(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			sRL29bUFS1Z(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			sRL29bUFS1Z(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			sRL29bUFS1Z(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			sRL29bUFS1Z(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			sRL29bUFS1Z(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			sRL29bUFS1Z(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			sRL29bUFS1Z(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void pXD29sVSp7Q(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + ygN2965EVEf(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[uint_5] + b2I2hReuDa3[uint_6 - 1], ushort_0);
	}

	private static void JMp29HQ0Wj4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + ygN2965EVEf(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[uint_5] + b2I2hReuDa3[uint_6 - 1], ushort_0);
	}

	private static void eNn2918QoJ6(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + ygN2965EVEf(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[uint_5] + b2I2hReuDa3[uint_6 - 1], ushort_0);
	}

	private static void sRL29bUFS1Z(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + ygN2965EVEf(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[uint_5] + b2I2hReuDa3[uint_6 - 1], ushort_0);
	}

	private static uint ygN2965EVEf(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> 32 - ushort_0) | (uint_1 << (int)ushort_0);
	}

	internal static bool h1329XvJg18()
	{
		if (!c4w2hqcYFjT)
		{
			LHJ29KQw9ac();
			c4w2hqcYFjT = true;
		}
		return fh22hcSJkTc;
	}

	internal static SymmetricAlgorithm Fwu29mirCUe()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (h1329XvJg18())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	internal static void LHJ29KQw9ac()
	{
		try
		{
			fh22hcSJkTc = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] C2v29xhIWx4(byte[] byte_3)
	{
		if (!h1329XvJg18())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_3);
		}
		return By529G9npPu(byte_3);
	}

	internal static void rxj29rDUy4b(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_3)
	{
		while (uint_1 != 0)
		{
			int num = ((uint_1 > (uint)byte_3.Length) ? byte_3.Length : ((int)uint_1));
			stream_0.Read(byte_3, 0, num);
			PSc29pDKxpL(hashAlgorithm_0, byte_3, 0, num);
			uint_1 -= (uint)num;
		}
	}

	internal static void PSc29pDKxpL(HashAlgorithm hashAlgorithm_0, byte[] byte_3, int int_5, int int_6)
	{
		hashAlgorithm_0.TransformBlock(byte_3, int_5, int_6, byte_3, int_5);
	}

	internal static uint M1129BCHCGO(uint uint_1, int int_5, long long_2, BinaryReader binaryReader_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_5)
			{
				binaryReader_0.BaseStream.Position = long_2 + (num * 40 + 8);
				uint num2 = binaryReader_0.ReadUInt32();
				num3 = binaryReader_0.ReadUInt32();
				binaryReader_0.ReadUInt32();
				num4 = binaryReader_0.ReadUInt32();
				if (num3 <= uint_1 && uint_1 < num3 + num2)
				{
					break;
				}
				num++;
				continue;
			}
			return 0u;
		}
		return num4 + uint_1 - num3;
	}

	[mo3pfAhifnsSpM9tlbk(typeof(mo3pfAhifnsSpM9tlbk.tKkI82hmLeLDTEjpvL8<Object>[]))]
	internal static void kKl29QJ49Lt()
	{
	}

	public static void Qh329jDRqmW(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (WoW2h9xYxDf == null)
			{
				lock (nu12hhBNor0)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(hSyLc5hfTVew2vLP28M).Assembly.GetManifestResourceStream("7kaiik7jAEFpspZBIH.kHCxVxV4QvujHY1QSS"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - ((1 + j))];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += 0;
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFF);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						fikEZWhhTCvCeJ5W2UV fikEZWhhTCvCeJ5W2UV = new fikEZWhhTCvCeJ5W2UV(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = fikEZWhhTCvCeJ5W2UV.ylt2hiCUAXy();
							int value = fikEZWhhTCvCeJ5W2UV.ylt2hiCUAXy();
							dictionary.Add(key, value);
						}
						fikEZWhhTCvCeJ5W2UV.tnZ2h3c98Gj();
					}
					WoW2h9xYxDf = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = WoW2h9xYxDf[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(hSyLc5hfTVew2vLP28M).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num13 = parameters.Length + 1;
				Type[] array3 = new Type[num13];
				if (methodInfo.DeclaringType.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType.MakeByRefType();
				}
				else
				{
					array3[0] = typeof(object);
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num14 = 0; num14 < num13; num14++)
				{
					switch (num14)
					{
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num14);
						break;
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint afx29nWJZoF(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	internal static void Itk29DYiUZR()
	{
	}

	[mo3pfAhifnsSpM9tlbk(typeof(mo3pfAhifnsSpM9tlbk.tKkI82hmLeLDTEjpvL8<Object>[]))]
	internal static string wwG29dpJCui(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	internal static uint rNh29o42HZv(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_7, ref uint uint_2)
	{
		IntPtr ptr = intptr_6;
		if (cvO2hata14K)
		{
			ptr = intptr_5;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = L8l2hndofpl[num];
		if (obj != null)
		{
			esj6TXhkuTLMIFe9b2K esj6TXhkuTLMIFe9b2K = (esj6TXhkuTLMIFe9b2K)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(esj6TXhkuTLMIFe9b2K.BOs2hFKErfe.Length);
			Marshal.Copy(esj6TXhkuTLMIFe9b2K.BOs2hFKErfe, 0, intPtr, esj6TXhkuTLMIFe9b2K.BOs2hFKErfe.Length);
			if (esj6TXhkuTLMIFe9b2K.t892hOpv3OJ)
			{
				intptr_7 = intPtr;
				uint_2 = (uint)esj6TXhkuTLMIFe9b2K.BOs2hFKErfe.Length;
				ihv29zTZawt(intptr_7, esj6TXhkuTLMIFe9b2K.BOs2hFKErfe.Length, 64, ref yUM2hBvRGo0);
				return 0u;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, esj6TXhkuTLMIFe9b2K.BOs2hFKErfe.Length);
			uint result = 0u;
			if (uint_1 == 216669565 && !qNa2hjLMOyN)
			{
				qNa2hjLMOyN = true;
			}
			else
			{
				result = hoV2hX5tU45(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
			}
			return result;
		}
		return hoV2hX5tU45(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
	}

	private static void Asl29Mm5Us3()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate Q2J29A50nN7(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { intptr_4, type_0 });
	}

	internal static void bvG29OXc6EI()
	{
	}

	internal static object ztQ29Fp3weP(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(assembly_1.Location))
			{
				return assembly_1.Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return assembly_1.GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
				.ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr vvD29U9Yt5P(string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr rkH29lEmpvt(IntPtr intptr_4, string string_1);

	private static IntPtr aTr29ijINFE(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (oAg2h4ELLvb == null)
		{
			IntPtr ptr = rkH29lEmpvt(umLocehuEC(), "Find ".Trim() + "ResourceA");
			oAg2h4ELLvb = (GFfYU7h85WkeueTakSW)Marshal.GetDelegateForFunctionPointer(ptr, typeof(GFfYU7h85WkeueTakSW));
		}
		return oAg2h4ELLvb(intptr_4, string_1, uint_1);
	}

	private static IntPtr kWE293Wxl87(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (v1q2h5IakSc == null)
		{
			IntPtr ptr = rkH29lEmpvt(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			v1q2h5IakSc = (vFA2ouhbWDTuSP2cFVa)Marshal.GetDelegateForFunctionPointer(ptr, typeof(vFA2ouhbWDTuSP2cFVa));
		}
		return v1q2h5IakSc(intptr_4, uint_1, uint_2, uint_3);
	}

	private static int Eos29fuguv5(IntPtr intptr_4, IntPtr intptr_5, [In][Out] byte[] byte_3, uint uint_1, out IntPtr intptr_6)
	{
		if (tHx2hDEBkFj == null)
		{
			IntPtr ptr = rkH29lEmpvt(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			tHx2hDEBkFj = (hMfBiMhe7ZDvrqWLAni)Marshal.GetDelegateForFunctionPointer(ptr, typeof(hMfBiMhe7ZDvrqWLAni));
		}
		return tHx2hDEBkFj(intptr_4, intptr_5, byte_3, uint_1, out intptr_6);
	}

	private static int ihv29zTZawt(IntPtr intptr_4, int int_5, int int_6, ref int int_7)
	{
		if (JGH2hdJfCdn == null)
		{
			IntPtr ptr = rkH29lEmpvt(umLocehuEC(), "Virtual ".Trim() + "Protect");
			JGH2hdJfCdn = (EFGlR8h1Z7itmjAGVdU)Marshal.GetDelegateForFunctionPointer(ptr, typeof(EFGlR8h1Z7itmjAGVdU));
		}
		return JGH2hdJfCdn(intptr_4, int_5, int_6, ref int_7);
	}

	private static IntPtr h0h2hwKIU49(uint uint_1, int int_5, uint uint_2)
	{
		if (LDj2ho4pnZ2 == null)
		{
			IntPtr ptr = rkH29lEmpvt(umLocehuEC(), "Open ".Trim() + "Process");
			LDj2ho4pnZ2 = (vN8eyHhct7IPFF1JOiH)Marshal.GetDelegateForFunctionPointer(ptr, typeof(vN8eyHhct7IPFF1JOiH));
		}
		return LDj2ho4pnZ2(uint_1, int_5, uint_2);
	}

	private static int iIt2htwYD1H(IntPtr intptr_4)
	{
		if (rqx2hT1snkN == null)
		{
			IntPtr ptr = rkH29lEmpvt(umLocehuEC(), "Close ".Trim() + "Handle");
			rqx2hT1snkN = (vu7lJ7h9orsfiBw5kTI)Marshal.GetDelegateForFunctionPointer(ptr, typeof(vu7lJ7h9orsfiBw5kTI));
		}
		return rqx2hT1snkN(intptr_4);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (OI72hMlnf0n == IntPtr.Zero)
		{
			OI72hMlnf0n = vvD29U9Yt5P("kernel ".Trim() + "32.dll");
		}
		return OI72hMlnf0n;
	}

	[mo3pfAhifnsSpM9tlbk(typeof(mo3pfAhifnsSpM9tlbk.tKkI82hmLeLDTEjpvL8<Object>[]))]
	private static byte[] SKa2hgf1aud(string string_1)
	{
		using FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream VZW2hLgUQTd()
	{
		return new MemoryStream();
	}

	internal static byte[] x8s2hvEvXur(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[mo3pfAhifnsSpM9tlbk(typeof(mo3pfAhifnsSpM9tlbk.tKkI82hmLeLDTEjpvL8<Object>[]))]
	private static byte[] z0f2hSaAZMx(byte[] byte_3)
	{
		Stream stream = VZW2hLgUQTd();
		SymmetricAlgorithm symmetricAlgorithm = Fwu29mirCUe();
		symmetricAlgorithm.Key = new byte[32]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_3, 0, byte_3.Length);
		cryptoStream.Close();
		return x8s2hvEvXur(stream);
	}

	private byte[] hon2h2mUOPB()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] YmP2huwEPck()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] AvX2hNWok3O()
	{
		return null;
	}

	private byte[] h4v2hJsOyQ8()
	{
		return null;
	}

	private byte[] d0a2h0yCu6O()
	{
		return null;
	}

	private byte[] myC2hCS62qr()
	{
		return null;
	}

	internal byte[] XQ62hP2fS71()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] x3j2hEuug65()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Ib02hyrQJfr()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] ahE2h8hFeV9()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static void MT8Jm9RILPQBWlOdds()
	{
	}

	internal static bool ebE87K9a2A8DrtuJBk()
	{
		return (object)null == null;
	}

	internal static void v0GEgSXWKaf97reEHm()
	{
	}

	internal static bool qISosQYGssBx8AUBXE()
	{
		return (object)null == null;
	}
}
