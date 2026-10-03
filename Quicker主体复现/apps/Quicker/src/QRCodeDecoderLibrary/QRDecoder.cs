using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using P0ed87qoqGEvdR1eF7B;
using ROyF57qMbQ7TBunLAQ1;
using toYeTKqj1kJE6NDRBqr;
using yADxuyq6eyZRBn9ENUn;

namespace QRCodeDecoderLibrary;

public class QRDecoder
{
	public const string VersionNumber = "Rev 2.1.0 - 2019-07-22";

	[CompilerGenerated]
	private int JLPykrXpon;

	[CompilerGenerated]
	private int QNOyGmWKR0;

	[CompilerGenerated]
	private ErrorCorrection TM3yspuTcP;

	public int[] ErrCorrPercent = new int[4] { 7, 15, 25, 30 };

	[CompilerGenerated]
	private int CNOyHKMTNX;

	[CompilerGenerated]
	private int ephy1Q1253;

	internal int DvPybQhRnC;

	internal int x24y6moT4o;

	internal bool[,] H2xyXe0i0r;

	internal List<j1cYGqqXSFBHoqF8odI> Dfqym3PaUr;

	internal List<j1cYGqqXSFBHoqF8odI> dbVyKKKPXr;

	internal List<byte[]> tKlyxrmuGb;

	internal int aUlyrqkb9n;

	internal int kHMypDeaUk;

	internal int NSIyB5SNLj;

	internal int XkiyQ8Wpy2;

	internal int a4QyjwqajX;

	internal int iriynkUjrt;

	internal int YIpy4WAmWR;

	internal int Eygy5vDVyN;

	internal byte[] fmcyDr2w72;

	internal int rSAydKyYuN;

	internal uint C49yoWOmgx;

	internal int g62yTm5CsU;

	internal byte[,] BI4yMH5Eed;

	internal byte[,] EIRyAaAkUU;

	internal bool kCuyOjlkKQ;

	internal double ou5yFIFGdn;

	internal double RORyUPRZly;

	internal double PxBylHdR0U;

	internal double ILwyiEf6qr;

	internal double rTay3jWtwY;

	internal double blWyfOGlhO;

	internal double hfDyzqtNlN;

	internal double iaA8wimFax;

	internal double h6w8tTin7p;

	internal double SF48gLZg64;

	internal double MXm8LTWJwA;

	internal double Woh8vJGWuG;

	internal double HQF8S77dvq;

	internal double nLN82tTQb2;

	internal static QRDecoder YrtZmSvz1yu8l2aa4d8;

	public int QRCodeVersion
	{
		[CompilerGenerated]
		get
		{
			return JLPykrXpon;
		}
		[CompilerGenerated]
		internal set
		{
			JLPykrXpon = value;
		}
	}

	public int QRCodeDimension
	{
		[CompilerGenerated]
		get
		{
			return QNOyGmWKR0;
		}
		[CompilerGenerated]
		internal set
		{
			QNOyGmWKR0 = value;
		}
	}

	public ErrorCorrection ErrorCorrection
	{
		[CompilerGenerated]
		get
		{
			return TM3yspuTcP;
		}
		[CompilerGenerated]
		internal set
		{
			TM3yspuTcP = value;
		}
	}

	public int MaskCode
	{
		[CompilerGenerated]
		get
		{
			return CNOyHKMTNX;
		}
		[CompilerGenerated]
		internal set
		{
			CNOyHKMTNX = value;
		}
	}

	public int ECIAssignValue
	{
		[CompilerGenerated]
		get
		{
			return ephy1Q1253;
		}
		[CompilerGenerated]
		internal set
		{
			ephy1Q1253 = value;
		}
	}

	public static string ByteArrayToStr(byte[] DataArray)
	{
		Decoder decoder = Encoding.UTF8.GetDecoder();
		char[] array = new char[decoder.GetCharCount(DataArray, 0, DataArray.Length)];
		decoder.GetChars(DataArray, 0, DataArray.Length, array, 0);
		return new string(array);
	}

	public byte[][] ImageDecoder(Bitmap InputImage)
	{
		byte[][] result;
		try
		{
			tKlyxrmuGb = new List<byte[]>();
			DvPybQhRnC = InputImage.Width;
			x24y6moT4o = InputImage.Height;
			if (!YXyEndagBR(InputImage))
			{
				result = null;
				int num = 0;
				if (!UbKA2idV83X3ED1PEXX())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				goto IL_0211;
			}
			if (!Ta5E4v4NRj())
			{
				result = null;
				goto IL_0211;
			}
			a5VEDWOEP7();
			if (!CfvEoy42nU())
			{
				result = null;
				goto IL_0211;
			}
		}
		catch
		{
			result = null;
			goto IL_0211;
		}
		int num3 = Dfqym3PaUr.Count - 2;
		int num4 = Dfqym3PaUr.Count - 1;
		int num5 = 0;
		if (YrtZmSvz1yu8l2aa4d8 == null)
		{
			goto IL_00ac;
		}
		goto IL_01d6;
		IL_0211:
		return result;
		IL_01d6:
		int num6 = default(int);
		num5 = num6;
		goto IL_00ac;
		IL_00ac:
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int count = default(int);
		do
		{
			switch (num5)
			{
			case 1:
				try
				{
					HTCp0Jq21QRYbQRdE5p hTCp0Jq21QRYbQRdE5p = HTCp0Jq21QRYbQRdE5p.ndvEZ1Ixwb(Dfqym3PaUr[num7], Dfqym3PaUr[num8], Dfqym3PaUr[num9]);
					if (hTCp0Jq21QRYbQRdE5p != null && TdGEFSnvKd(hTCp0Jq21QRYbQRdE5p))
					{
						if (Ba0EU3LQI5(hTCp0Jq21QRYbQRdE5p))
						{
							if (UbKA2idV83X3ED1PEXX())
							{
								switch (0)
								{
								}
							}
						}
						else if (QRCodeVersion != 1 && HYIEfOIhqB(hTCp0Jq21QRYbQRdE5p))
						{
							foreach (j1cYGqqXSFBHoqF8odI item in dbVyKKKPXr)
							{
								AcDEz6sMM3(hTCp0Jq21QRYbQRdE5p, item.BcTE6fcxKT, item.SSbExSXL80);
								if (Ba0EU3LQI5(hTCp0Jq21QRYbQRdE5p))
								{
									break;
								}
							}
						}
					}
				}
				catch
				{
				}
				num9++;
				goto IL_01c0;
			default:
				{
					count = Dfqym3PaUr.Count;
					num7 = 0;
					goto IL_01ad;
				}
				IL_01b7:
				if (num8 >= num4)
				{
					num7++;
					goto IL_01ad;
				}
				num9 = num8 + 1;
				goto IL_01c0;
				IL_01c0:
				if (num9 < count)
				{
					break;
				}
				num8++;
				goto IL_01b7;
				IL_01ad:
				if (num7 < num3)
				{
					num8 = num7 + 1;
					goto IL_01b7;
				}
				if (tKlyxrmuGb.Count == 0)
				{
					return null;
				}
				return tKlyxrmuGb.ToArray();
			}
			num5 = 1;
		}
		while (UbKA2idV83X3ED1PEXX());
		goto IL_01d6;
	}

	internal bool YXyEndagBR(Bitmap bitmap_0)
	{
        int i = default;
        int num9 = default;
        byte[,] array2 = default;
        int num4 = default;
        int num8 = default;
        int num5 = default;
        int num3 = default;
        int[] array3 = default;
        int num10 = default;
        int num7 = default;
        int num6 = default;
		BitmapData bitmapData = bitmap_0.LockBits(new Rectangle(0, 0, DvPybQhRnC, x24y6moT4o), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
		IntPtr scan = bitmapData.Scan0;
		int stride = bitmapData.Stride;
		if (stride < 0)
		{
			return false;
		}
		int num = stride * x24y6moT4o;
		byte[] array = new byte[num];
		int num2 = 0;
		if (YrtZmSvz1yu8l2aa4d8 == null)
		{
			goto IL_018f;
		}
		goto IL_01d7;
		IL_006f:
		num3 = num3 + 1;
		i = default(int);
		num4 = default(int);
		num5 = default(int);
		if (num3 - i >= 2)
		{
			num4 = (i + num3) / 2;
			H2xyXe0i0r = new bool[x24y6moT4o, DvPybQhRnC];
			num5 = 0;
			goto IL_00e9;
		}
		return false;
		IL_018f:
		Marshal.Copy(scan, array, 0, num);
		bitmap_0.UnlockBits(bitmapData);
		array2 = new byte[x24y6moT4o, DvPybQhRnC];
		array3 = new int[256];
		num6 = stride - 3 * DvPybQhRnC;
		num7 = 0;
		num8 = 0;
		goto IL_0104;
		IL_0104:
		num9 = default(int);
		if (num8 < x24y6moT4o)
		{
			num9 = 0;
			goto IL_0111;
		}
		for (i = 0; i < 256 && array3[i] == 0; i++)
		{
		}
		num3 = 255;
		goto IL_0069;
		IL_00e9:
		num10 = default(int);
		if (num5 < x24y6moT4o)
		{
			num10 = 0;
			goto IL_00db;
		}
		return true;
		IL_00db:
		if (num10 < DvPybQhRnC)
		{
			H2xyXe0i0r[num5, num10] = array2[num5, num10] < num4;
			num2 = 0;
			if (YrtZmSvz1yu8l2aa4d8 == null)
			{
				goto IL_00d5;
			}
			goto IL_01d7;
		}
		num5++;
		goto IL_00e9;
		IL_00d5:
		num10++;
		goto IL_00db;
		IL_01d7:
		switch (num2)
		{
		case 4:
			break;
		case 3:
			goto IL_006f;
		case 1:
			goto IL_00d5;
		case 2:
			goto IL_015a;
		default:
			goto IL_018f;
		}
		goto IL_0069;
		IL_0111:
		if (num9 >= DvPybQhRnC)
		{
			num7 += num6;
			num8++;
			goto IL_0104;
		}
		int num11 = (30 * array[num7] + 59 * array[num7 + 1] + 11 * array[num7 + 2]) / 100;
		array3[num11]++;
		array2[num8, num9] = (byte)num11;
		goto IL_015a;
		IL_0069:
		while (num3 >= i && array3[num3] == 0)
		{
			num3--;
		}
		goto IL_006f;
		IL_015a:
		num7 += 3;
		num9++;
		goto IL_0111;
	}

	internal bool Ta5E4v4NRj()
	{
		Dfqym3PaUr = new List<j1cYGqqXSFBHoqF8odI>();
		int[] array = new int[DvPybQhRnC + 1];
		int num = 0;
		int num2 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		double double_ = default(double);
		for (int i = 0; i < x24y6moT4o; i++)
		{
			int j;
			for (j = 0; j < DvPybQhRnC && !H2xyXe0i0r[i, j]; j++)
			{
			}
			if (j == DvPybQhRnC)
			{
				continue;
			}
			num = 0;
			num = 1;
			array[0] = j;
			while (true)
			{
				if (j >= DvPybQhRnC || !H2xyXe0i0r[i, j])
				{
					array[num++] = j;
					if (j == DvPybQhRnC)
					{
						goto IL_0082;
					}
					goto IL_0182;
				}
				goto IL_019c;
				IL_015e:
				j++;
				goto IL_0182;
				IL_014f:
				if (j != DvPybQhRnC)
				{
					array[num++] = j;
					continue;
				}
				goto IL_0082;
				IL_0182:
				if (j < DvPybQhRnC)
				{
					if (!H2xyXe0i0r[i, j])
					{
						goto IL_015e;
					}
					num2 = 3;
				}
				goto IL_014f;
				IL_0082:
				if (num < 6)
				{
					break;
				}
				int num3 = num - 1;
				int[] array2 = new int[num3];
				int num4 = 0;
				while (true)
				{
					int num5;
					if (num4 < num3)
					{
						array2[num4] = array[num4 + 1] - array[num4];
						num5 = 0;
						if (!UbKA2idV83X3ED1PEXX())
						{
							goto IL_0114;
						}
						goto IL_0118;
					}
					num6 = num - 5;
					num7 = 0;
					goto IL_00e6;
					IL_00ff:
					num7 += 2;
					goto IL_00e6;
					IL_00e6:
					if (num7 >= num6)
					{
						goto end_IL_01ba;
					}
					if (!yD3EMUjj6H(array, array2, num7, out double_))
					{
						goto IL_00ff;
					}
					num5 = 1;
					if (YrtZmSvz1yu8l2aa4d8 != null)
					{
						goto IL_0114;
					}
					goto IL_0118;
					IL_0118:
					switch (num5)
					{
					case 1:
						break;
					default:
						goto IL_0131;
					case 3:
						goto end_IL_0144;
					case 4:
						goto IL_015e;
					case 2:
						goto IL_019c;
					}
					Dfqym3PaUr.Add(new j1cYGqqXSFBHoqF8odI(i, array[num7 + 2], array[num7 + 3], double_));
					goto IL_00ff;
					IL_0131:
					num4++;
					continue;
					IL_0114:
					num5 = num2;
					goto IL_0118;
					continue;
					end_IL_0144:
					break;
				}
				goto IL_014f;
				IL_019c:
				j++;
				continue;
				end_IL_01ba:
				break;
			}
		}
		if (Dfqym3PaUr.Count < 3)
		{
			return false;
		}
		return true;
	}

	internal bool icwE5Ox70x(int int_15, int int_16, int int_17, int int_18)
	{
		dbVyKKKPXr = new List<j1cYGqqXSFBHoqF8odI>();
		int[] array = new int[int_17 + 1];
		int num = 0;
		int num2 = int_15 + int_17;
		int num3 = int_16 + int_18;
		while (true)
		{
			int num4 = int_16;
			while (true)
			{
				IL_015c:
				if (num4 < num3)
				{
					while (true)
					{
						int i;
						for (i = int_15; i < num2 && !H2xyXe0i0r[num4, i]; i++)
						{
						}
						if (i != num2)
						{
							num = 0;
							if (!UbKA2idV83X3ED1PEXX())
							{
								switch (0)
								{
								case 1:
									break;
								default:
									goto IL_0077;
								case 3:
									goto IL_00b6;
								case 4:
									goto IL_00cb;
								case 2:
									goto end_IL_0071;
								}
								continue;
							}
							goto IL_0077;
						}
						goto IL_0156;
						IL_00cb:
						if (!H2xyXe0i0r[num4, i])
						{
							i++;
							goto IL_00c6;
						}
						goto IL_008a;
						IL_00de:
						if (num >= 6)
						{
							int num5 = num - 1;
							int[] array2 = new int[num5];
							for (int j = 0; j < num5; j++)
							{
								array2[j] = array[j + 1] - array[j];
							}
							int num6 = num - 5;
							for (int k = 0; k < num6; k += 2)
							{
								if (BYDEAce2UW(array, array2, k, out var double_))
								{
									dbVyKKKPXr.Add(new j1cYGqqXSFBHoqF8odI(num4, array[k + 2], array[k + 3], double_));
								}
							}
						}
						goto IL_0156;
						IL_008a:
						if (i != num2)
						{
							array[num++] = i;
							goto IL_00b1;
						}
						goto IL_00de;
						IL_0156:
						num4++;
						goto IL_015c;
						IL_0077:
						array[num++] = i;
						goto IL_00b1;
						IL_00b1:
						for (; i < num2 && H2xyXe0i0r[num4, i]; i++)
						{
						}
						goto IL_00b6;
						IL_00b6:
						array[num++] = i;
						if (i != num2)
						{
							goto IL_00c6;
						}
						goto IL_00de;
						IL_00c6:
						if (i >= num2)
						{
							goto IL_008a;
						}
						goto IL_00cb;
						continue;
						end_IL_0071:
						break;
					}
					break;
				}
				return dbVyKKKPXr.Count != 0;
			}
		}
	}

	internal void a5VEDWOEP7()
	{
		bool[] array = new bool[DvPybQhRnC];
		foreach (j1cYGqqXSFBHoqF8odI item in Dfqym3PaUr)
		{
			for (int i = item.uTZEXSplS1; i < item.S54EmgVu6H; i++)
			{
				array[i] = true;
			}
		}
		int[] array2 = new int[x24y6moT4o + 1];
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		int[] array3 = default(int[]);
		int num5 = default(int);
		for (int j = 0; j < DvPybQhRnC; j++)
		{
			if (!array[j])
			{
				continue;
			}
			int k;
			for (k = 0; k < x24y6moT4o && !H2xyXe0i0r[k, j]; k++)
			{
			}
			if (k == DvPybQhRnC)
			{
				continue;
			}
			num = 0;
			num = 1;
			array2[0] = k;
			while (true)
			{
				if (k >= x24y6moT4o || !H2xyXe0i0r[k, j])
				{
					array2[num++] = k;
					if (k == x24y6moT4o)
					{
						goto IL_0107;
					}
					for (; k < x24y6moT4o && !H2xyXe0i0r[k, j]; k++)
					{
					}
					goto IL_017b;
				}
				goto IL_0196;
				IL_0165:
				int num4;
				if (num2 < num3)
				{
					array3[num2] = array2[num2 + 1] - array2[num2];
					num4 = 0;
					if (!UbKA2idV83X3ED1PEXX())
					{
						num4 = num5;
					}
					goto IL_0146;
				}
				int num6 = num - 5;
				for (int l = 0; l < num6; l += 2)
				{
					if (!yD3EMUjj6H(array2, array3, l, out var double_))
					{
						continue;
					}
					foreach (j1cYGqqXSFBHoqF8odI item2 in Dfqym3PaUr)
					{
						item2.pUTE1JT7U2(j, array2[l + 2], array2[l + 3], double_);
					}
				}
				break;
				IL_0146:
				switch (num4)
				{
				case 3:
					goto IL_017b;
				case 1:
					goto IL_0188;
				case 4:
					goto IL_0196;
				case 2:
					goto end_IL_01b4;
				}
				num2++;
				goto IL_0165;
				IL_0188:
				array2[num++] = k;
				continue;
				IL_017b:
				if (k == x24y6moT4o)
				{
					goto IL_0107;
				}
				num4 = 1;
				if (YrtZmSvz1yu8l2aa4d8 == null)
				{
					goto IL_0146;
				}
				goto IL_0188;
				IL_0196:
				k++;
				continue;
				IL_0107:
				if (num < 6)
				{
					break;
				}
				num3 = num - 1;
				array3 = new int[num3];
				num2 = 0;
				goto IL_0165;
				continue;
				end_IL_01b4:
				break;
			}
		}
	}

	internal void FmUEd2Iiw8(int int_15, int int_16, int int_17, int int_18)
	{
        int k = default;
        int num8 = default;
        int l = default;
        int[] array3 = default;
        int num6 = default;
		bool[] array = new bool[int_17];
		foreach (j1cYGqqXSFBHoqF8odI item in dbVyKKKPXr)
		{
			for (int i = item.uTZEXSplS1; i < item.S54EmgVu6H; i++)
			{
				array[i - int_15] = true;
			}
		}
		int[] array2 = new int[int_18 + 1];
		int num = 0;
		int num2 = int_15 + int_17;
		int num3 = int_16 + int_18;
		int num4 = 1;
		if (YrtZmSvz1yu8l2aa4d8 == null)
		{
			goto IL_0215;
		}
		goto IL_021d;
		IL_0162:
		int j = default(int);
		int num5 = default(int);
		array3 = default(int[]);
		num6 = default(int);
		for (; j < num5; j += 2)
		{
			if (!BYDEAce2UW(array2, array3, j, out var double_))
			{
				continue;
			}
			foreach (j1cYGqqXSFBHoqF8odI item2 in dbVyKKKPXr)
			{
				item2.pUTE1JT7U2(num6, array2[j + 2], array2[j + 3], double_);
			}
		}
		goto IL_01a6;
		IL_0215:
		num6 = int_15;
		goto IL_016a;
		IL_016a:
		k = default(int);
		if (num6 < num2)
		{
			if (array[num6 - int_15])
			{
				for (k = int_16; k < num3 && !H2xyXe0i0r[k, num6]; k++)
				{
				}
				if (k != num3)
				{
					num = 0;
					num = 1;
					array2[0] = k;
					goto IL_01d3;
				}
			}
			goto IL_01a6;
		}
		num4 = 0;
		if (YrtZmSvz1yu8l2aa4d8 != null)
		{
			int num7 = default(int);
			num4 = num7;
		}
		goto IL_021d;
		IL_021d:
		switch (num4)
		{
		case 2:
			break;
		case 3:
			goto IL_0162;
		case 4:
			goto IL_01e8;
		case 1:
			goto IL_0215;
		default:
			return;
		}
		goto IL_00f4;
		IL_01e8:
		array2[num++] = k;
		if (k != num3)
		{
			for (; k < num3 && !H2xyXe0i0r[k, num6]; k++)
			{
			}
			if (k != num3)
			{
				array2[num++] = k;
				goto IL_01d3;
			}
		}
		num8 = default(int);
		l = default(int);
		if (num >= 6)
		{
			num8 = num - 1;
			array3 = new int[num8];
			l = 0;
			goto IL_00f4;
		}
		goto IL_01a6;
		IL_01db:
		num4 = 3;
		if (UbKA2idV83X3ED1PEXX())
		{
			goto IL_01e8;
		}
		goto IL_021d;
		IL_01d3:
		while (k < num3)
		{
			if (H2xyXe0i0r[k, num6])
			{
				k++;
				continue;
			}
			goto IL_01db;
		}
		goto IL_01e8;
		IL_00f4:
		for (; l < num8; l++)
		{
			array3[l] = array2[l + 1] - array2[l];
		}
		num5 = num - 5;
		j = 0;
		goto IL_0162;
		IL_01a6:
		num6++;
		goto IL_016a;
	}

	internal bool CfvEoy42nU()
	{
		int num = 2;
		while (true)
		{
			int num2 = 0;
			int num3 = 1;
			if (YrtZmSvz1yu8l2aa4d8 != null)
			{
				num3 = num;
			}
			switch (num3)
			{
			case 2:
				break;
			case 1:
				if (num2 >= Dfqym3PaUr.Count)
				{
					if (Dfqym3PaUr.Count < 3)
					{
						return false;
					}
					for (int i = 0; i < Dfqym3PaUr.Count; i++)
					{
						j1cYGqqXSFBHoqF8odI j1cYGqqXSFBHoqF8odI = Dfqym3PaUr[i];
						for (int j = i + 1; j < Dfqym3PaUr.Count; j++)
						{
							j1cYGqqXSFBHoqF8odI j1cYGqqXSFBHoqF8odI2 = Dfqym3PaUr[j];
							if (j1cYGqqXSFBHoqF8odI.hXXEbCKt0d(j1cYGqqXSFBHoqF8odI2))
							{
								if (j1cYGqqXSFBHoqF8odI2.oaZEQyuWRM < j1cYGqqXSFBHoqF8odI.oaZEQyuWRM)
								{
									j1cYGqqXSFBHoqF8odI = j1cYGqqXSFBHoqF8odI2;
									Dfqym3PaUr[i] = j1cYGqqXSFBHoqF8odI;
								}
								Dfqym3PaUr.RemoveAt(j);
								j--;
							}
						}
					}
					if (Dfqym3PaUr.Count < 3)
					{
						return false;
					}
					return true;
				}
				goto default;
			default:
				if (Dfqym3PaUr[num2].oaZEQyuWRM == double.MaxValue)
				{
					Dfqym3PaUr.RemoveAt(num2);
					num2--;
				}
				num2++;
				goto case 1;
			}
		}
	}

	internal bool TbFETNFh0Q()
	{
		for (int i = 0; i < dbVyKKKPXr.Count; i++)
		{
			if (dbVyKKKPXr[i].oaZEQyuWRM == double.MaxValue)
			{
				dbVyKKKPXr.RemoveAt(i);
				i--;
			}
		}
		int num3 = default(int);
		for (int j = 0; j < dbVyKKKPXr.Count; j++)
		{
			j1cYGqqXSFBHoqF8odI j1cYGqqXSFBHoqF8odI = dbVyKKKPXr[j];
			int num = j + 1;
			while (true)
			{
				int num2;
				if (num < dbVyKKKPXr.Count)
				{
					j1cYGqqXSFBHoqF8odI j1cYGqqXSFBHoqF8odI2 = dbVyKKKPXr[num];
					if (!j1cYGqqXSFBHoqF8odI.hXXEbCKt0d(j1cYGqqXSFBHoqF8odI2))
					{
						goto IL_00dc;
					}
					if (j1cYGqqXSFBHoqF8odI2.oaZEQyuWRM < j1cYGqqXSFBHoqF8odI.oaZEQyuWRM)
					{
						j1cYGqqXSFBHoqF8odI = j1cYGqqXSFBHoqF8odI2;
						dbVyKKKPXr[j] = j1cYGqqXSFBHoqF8odI;
					}
					dbVyKKKPXr.RemoveAt(num);
					num--;
					num2 = 1;
					if (YrtZmSvz1yu8l2aa4d8 != null)
					{
						goto IL_00c9;
					}
				}
				else
				{
					num2 = 0;
					if (YrtZmSvz1yu8l2aa4d8 != null)
					{
						goto IL_00c9;
					}
				}
				goto IL_00cd;
				IL_00dc:
				num++;
				continue;
				IL_00cd:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto end_IL_00f3;
				}
				goto IL_00dc;
				IL_00c9:
				num2 = num3;
				goto IL_00cd;
				continue;
				end_IL_00f3:
				break;
			}
		}
		return dbVyKKKPXr.Count != 0;
	}

	internal bool yD3EMUjj6H(int[] int_15, int[] int_16, int int_17, out double double_14)
	{
		double_14 = (double)(int_15[int_17 + 5] - int_15[int_17]) / 7.0;
		double num = 0.25 * double_14;
		if (Math.Abs((double)int_16[int_17] - double_14) > num)
		{
			return false;
		}
		if (Math.Abs((double)int_16[int_17 + 1] - double_14) > num)
		{
			return false;
		}
		if (Math.Abs((double)int_16[int_17 + 2] - 3.0 * double_14) > num)
		{
			return false;
		}
		if (Math.Abs((double)int_16[int_17 + 3] - double_14) > num)
		{
			return false;
		}
		if (Math.Abs((double)int_16[int_17 + 4] - double_14) > num)
		{
			return false;
		}
		return true;
	}

	internal bool BYDEAce2UW(int[] int_15, int[] int_16, int int_17, out double double_14)
	{
		double_14 = (double)(int_15[int_17 + 4] - int_15[int_17 + 1]) / 3.0;
		double num = 0.25 * double_14;
		if ((double)int_16[int_17] < double_14 - num)
		{
			return false;
		}
		if (Math.Abs((double)int_16[int_17 + 1] - double_14) > num)
		{
			return false;
		}
		if (Math.Abs((double)int_16[int_17 + 2] - double_14) > num)
		{
			return false;
		}
		if (Math.Abs((double)int_16[int_17 + 3] - double_14) > num)
		{
			return false;
		}
		if ((double)int_16[int_17 + 4] < double_14 - num)
		{
			return false;
		}
		return true;
	}

	internal List<HTCp0Jq21QRYbQRdE5p> ShIEOxFQb9()
	{
		List<HTCp0Jq21QRYbQRdE5p> list = new List<HTCp0Jq21QRYbQRdE5p>();
		int num = Dfqym3PaUr.Count - 2;
		int num2 = Dfqym3PaUr.Count - 1;
		int count = Dfqym3PaUr.Count;
		for (int i = 0; i < num; i++)
		{
			for (int j = i + 1; j < num2; j++)
			{
				for (int k = j + 1; k < count; k++)
				{
					HTCp0Jq21QRYbQRdE5p hTCp0Jq21QRYbQRdE5p = HTCp0Jq21QRYbQRdE5p.ndvEZ1Ixwb(Dfqym3PaUr[i], Dfqym3PaUr[j], Dfqym3PaUr[k]);
					if (hTCp0Jq21QRYbQRdE5p != null)
					{
						list.Add(hTCp0Jq21QRYbQRdE5p);
					}
				}
			}
		}
		if (list.Count != 0)
		{
			return list;
		}
		return null;
	}

	internal bool TdGEFSnvKd(HTCp0Jq21QRYbQRdE5p htcp0Jq21QRYbQRdE5p_0)
	{
		try
		{
			QRCodeVersion = htcp0Jq21QRYbQRdE5p_0.O8fE9EQRLa();
			QRCodeDimension = 17 + 4 * QRCodeVersion;
			Mj5ElLxKq6(htcp0Jq21QRYbQRdE5p_0);
			int num2;
			if (QRCodeVersion >= 7)
			{
				int num = gTQyw5EPdh();
				if (num == 0)
				{
					num = hnxytoesvK();
					if (num == 0)
					{
						return false;
					}
				}
				if (num != QRCodeVersion)
				{
					QRCodeVersion = num;
					num2 = 0;
					if (YrtZmSvz1yu8l2aa4d8 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_009c;
				}
			}
			goto IL_00d2;
			IL_00d2:
			int num4 = GetFormatInfoOne();
			if (num4 < 0)
			{
				num4 = IenyLAhrrF();
				if (num4 < 0)
				{
					return false;
				}
			}
			ErrorCorrection = qbbyEjE2RE(num4 >> 3);
			MaskCode = num4 & 7;
			num2 = 1;
			if (UbKA2idV83X3ED1PEXX())
			{
				goto IL_009c;
			}
			goto IL_00e7;
			IL_009c:
			switch (num2)
			{
			case 1:
				goto IL_00e7;
			}
			QRCodeDimension = 17 + 4 * QRCodeVersion;
			Mj5ElLxKq6(htcp0Jq21QRYbQRdE5p_0);
			goto IL_00d2;
			IL_00e7:
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal bool Ba0EU3LQI5(HTCp0Jq21QRYbQRdE5p htcp0Jq21QRYbQRdE5p_0)
	{
		try
		{
			fNhyyP8ouZ();
			if (!UbKA2idV83X3ED1PEXX())
			{
				switch (0)
				{
				}
			}
			am9y2aatr4();
			GpoyPZu8Tc();
			E5Qy8UYIeZ(MaskCode);
			pshyuAgiCi();
			eNdyNiu721();
			CalculateErrorCorrection();
			byte[] item = jA5yJMXdE3();
			tKlyxrmuGb.Add(item);
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal void Mj5ElLxKq6(HTCp0Jq21QRYbQRdE5p htcp0Jq21QRYbQRdE5p_0)
	{
		int num = 2;
		double[,] array = default(double[,]);
		double[,] array2 = default(double[,]);
		while (true)
		{
			int num2 = QRCodeDimension - 4;
			int num3 = 1;
			if (!UbKA2idV83X3ED1PEXX())
			{
				goto IL_0126;
			}
			goto IL_01f5;
			IL_01f5:
			while (true)
			{
				switch (num3)
				{
				case 4:
					break;
				case 1:
					goto IL_012f;
				case 2:
					goto end_IL_01f5;
				default:
					yX5Eim5LCZ(array);
					ou5yFIFGdn = array[0, 3];
					PxBylHdR0U = array[1, 3];
					rTay3jWtwY = array[2, 3];
					yX5Eim5LCZ(array2);
					RORyUPRZly = array2[0, 3];
					ILwyiEf6qr = array2[1, 3];
					num = 3;
					goto case 3;
				case 3:
					blWyfOGlhO = array2[2, 3];
					kCuyOjlkKQ = false;
					return;
				}
				array[2, 1] = num2;
				array[2, 2] = 1.0;
				array[2, 3] = htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.SSbExSXL80;
				array2[0, 0] = 3.0;
				array2[0, 1] = 3.0;
				array2[0, 2] = 1.0;
				array2[0, 3] = htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.BcTE6fcxKT;
				array2[1, 0] = num2;
				array2[1, 1] = 3.0;
				array2[1, 2] = 1.0;
				array2[1, 3] = htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.BcTE6fcxKT;
				array2[2, 0] = 3.0;
				array2[2, 1] = num2;
				array2[2, 2] = 1.0;
				array2[2, 3] = htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.BcTE6fcxKT;
				num3 = 0;
				if (YrtZmSvz1yu8l2aa4d8 == null)
				{
					continue;
				}
				goto IL_0126;
				IL_012f:
				array = new double[3, 4];
				array2 = new double[3, 4];
				array[0, 0] = 3.0;
				array[0, 1] = 3.0;
				array[0, 2] = 1.0;
				array[0, 3] = htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.SSbExSXL80;
				array[1, 0] = num2;
				array[1, 1] = 3.0;
				array[1, 2] = 1.0;
				array[1, 3] = htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.SSbExSXL80;
				array[2, 0] = 3.0;
				num3 = 4;
				if (UbKA2idV83X3ED1PEXX())
				{
					continue;
				}
				goto IL_0126;
				continue;
				end_IL_01f5:
				break;
			}
			continue;
			IL_0126:
			num3 = num;
			goto IL_01f5;
		}
	}

	internal void yX5Eim5LCZ(double[,] double_14)
	{
		int num = 0;
		int num2 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			if (num < 3)
			{
				if (double_14[num, num] == 0.0)
				{
					int i;
					for (i = num + 1; i < 3 && double_14[i, num] == 0.0; i++)
					{
					}
					if (i == 3)
					{
						break;
					}
					for (int j = num; j < 4; j++)
					{
						double_14[num, j] += double_14[i, j];
					}
				}
				num2 = 3;
				goto IL_011c;
			}
			double_14[1, 3] -= double_14[1, 2] * double_14[2, 3];
			int num3 = 2;
			if (!UbKA2idV83X3ED1PEXX())
			{
				goto IL_00f5;
			}
			goto IL_00f9;
			IL_00f5:
			num3 = num4;
			goto IL_00f9;
			IL_011c:
			if (num2 > num)
			{
				double_14[num, num2] /= double_14[num, num];
				num3 = 0;
				if (!UbKA2idV83X3ED1PEXX())
				{
					goto IL_00f9;
				}
				goto IL_010c;
			}
			num5 = num + 1;
			goto IL_00b7;
			IL_00bf:
			if (num6 <= num)
			{
				num5++;
				goto IL_00b7;
			}
			double_14[num5, num6] -= double_14[num, num6] * double_14[num5, num];
			num3 = 0;
			if (!UbKA2idV83X3ED1PEXX())
			{
				goto IL_00f5;
			}
			goto IL_00f9;
			IL_00b7:
			if (num5 < 3)
			{
				num6 = 3;
				goto IL_00bf;
			}
			num++;
			continue;
			IL_00f9:
			switch (num3)
			{
			case 1:
				goto IL_010c;
			case 2:
				double_14[0, 3] -= double_14[0, 2] * double_14[2, 3];
				double_14[0, 3] -= double_14[0, 1] * double_14[1, 3];
				return;
			}
			num6--;
			goto IL_00bf;
			IL_010c:
			num2--;
			goto IL_011c;
		}
		throw new ApplicationException("Solve linear equations failed");
	}

	internal bool jJTE3aT8Qa(int int_15, int int_16)
	{
		if (!kCuyOjlkKQ)
		{
			int num = (int)Math.Round(ou5yFIFGdn * (double)int_16 + PxBylHdR0U * (double)int_15 + rTay3jWtwY, 0, MidpointRounding.AwayFromZero);
			int num2 = (int)Math.Round(RORyUPRZly * (double)int_16 + ILwyiEf6qr * (double)int_15 + blWyfOGlhO, 0, MidpointRounding.AwayFromZero);
			return H2xyXe0i0r[num2, num];
		}
		double num3 = HQF8S77dvq * (double)int_16 + nLN82tTQb2 * (double)int_15 + 1.0;
		int num4 = (int)Math.Round((hfDyzqtNlN * (double)int_16 + iaA8wimFax * (double)int_15 + h6w8tTin7p) / num3, 0, MidpointRounding.AwayFromZero);
		int num5 = (int)Math.Round((SF48gLZg64 * (double)int_16 + MXm8LTWJwA * (double)int_15 + Woh8vJGWuG) / num3, 0, MidpointRounding.AwayFromZero);
		return H2xyXe0i0r[num5, num4];
	}

	internal bool HYIEfOIhqB(HTCp0Jq21QRYbQRdE5p htcp0Jq21QRYbQRdE5p_0)
	{
		int num = QRCodeDimension - 7;
		int num2 = QRCodeDimension - 7;
		int num3 = (int)Math.Round(ou5yFIFGdn * (double)num2 + PxBylHdR0U * (double)num + rTay3jWtwY, 0, MidpointRounding.AwayFromZero);
		int num4 = (int)Math.Round(RORyUPRZly * (double)num2 + ILwyiEf6qr * (double)num + blWyfOGlhO, 0, MidpointRounding.AwayFromZero);
		int num5 = (int)Math.Round(0.3 * (htcp0Jq21QRYbQRdE5p_0.cUUEkSQ8pl + htcp0Jq21QRYbQRdE5p_0.eZrEHYMshw), 0, MidpointRounding.AwayFromZero);
		int int_ = num3 - num5 / 2;
		int int_2 = num4 - num5 / 2;
		if (YrtZmSvz1yu8l2aa4d8 != null)
		{
			switch (0)
			{
			}
		}
		int int_3 = num5;
		int int_4 = num5;
		if (!icwE5Ox70x(int_, int_2, int_3, int_4))
		{
			return false;
		}
		FmUEd2Iiw8(int_, int_2, int_3, int_4);
		if (!TbFETNFh0Q())
		{
			return false;
		}
		return true;
	}

	internal void AcDEz6sMM3(HTCp0Jq21QRYbQRdE5p htcp0Jq21QRYbQRdE5p_0, double double_14, double double_15)
	{
		int num = QRCodeDimension - 4;
		int num2 = QRCodeDimension - 7;
		int num3 = 3;
		int num5 = default(int);
		int i = default(int);
		int j = default(int);
		int num8 = default(int);
		while (true)
		{
			IL_04ce:
			double[,] array = new double[8, 9];
			array[0, 0] = 3.0;
			array[0, 1] = 3.0;
			array[0, 2] = 1.0;
			array[0, 6] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.SSbExSXL80;
			array[0, 7] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.SSbExSXL80;
			array[0, 8] = htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.SSbExSXL80;
			array[1, 0] = num;
			int num4 = 1;
			if (!UbKA2idV83X3ED1PEXX())
			{
				goto IL_0339;
			}
			goto IL_0498;
			IL_0498:
			while (true)
			{
				switch (num4)
				{
				case 10:
					break;
				case 9:
					goto IL_007c;
				case 8:
					goto IL_00e9;
				case 4:
					goto IL_013c;
				case 2:
					goto IL_016c;
				case 7:
					goto IL_01a3;
				case 6:
					array[3, 1] = num2;
					array[3, 2] = 1.0;
					array[3, 6] = (double)(-num2) * double_15;
					array[3, 7] = (double)(-num2) * double_15;
					array[3, 8] = double_15;
					array[4, 3] = 3.0;
					array[4, 4] = 3.0;
					array[4, 5] = 1.0;
					array[4, 6] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.BcTE6fcxKT;
					array[4, 7] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.BcTE6fcxKT;
					array[4, 8] = htcp0Jq21QRYbQRdE5p_0.Jx6EhCEDpq.BcTE6fcxKT;
					array[5, 3] = num;
					array[5, 4] = 3.0;
					array[5, 5] = 1.0;
					array[5, 6] = -num * htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.BcTE6fcxKT;
					num4 = 0;
					if (!UbKA2idV83X3ED1PEXX())
					{
						continue;
					}
					goto IL_0339;
				default:
					goto IL_0339;
				case 1:
					array[1, 1] = 3.0;
					array[1, 2] = 1.0;
					array[1, 6] = -num * htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.SSbExSXL80;
					array[1, 7] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.SSbExSXL80;
					array[1, 8] = htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.SSbExSXL80;
					array[2, 0] = 3.0;
					array[2, 1] = num;
					array[2, 2] = 1.0;
					array[2, 6] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.SSbExSXL80;
					array[2, 7] = -num * htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.SSbExSXL80;
					array[2, 8] = htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.SSbExSXL80;
					array[3, 0] = num2;
					goto case 6;
				case 3:
					goto IL_04ce;
				case 5:
					return;
				}
				break;
			}
			goto IL_0022;
			IL_0339:
			array[5, 7] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.BcTE6fcxKT;
			array[5, 8] = htcp0Jq21QRYbQRdE5p_0.VwWEeVK88h.BcTE6fcxKT;
			array[6, 3] = 3.0;
			array[6, 4] = num;
			num3 = 10;
			goto IL_0022;
			IL_0022:
			array[6, 5] = 1.0;
			array[6, 6] = -3.0 * (double)htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.BcTE6fcxKT;
			array[6, 7] = -num * htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.BcTE6fcxKT;
			num4 = 7;
			if (YrtZmSvz1yu8l2aa4d8 == null)
			{
				goto IL_007c;
			}
			goto IL_0498;
			IL_007c:
			array[6, 8] = htcp0Jq21QRYbQRdE5p_0.o6NEYg3KUk.BcTE6fcxKT;
			array[7, 3] = num2;
			array[7, 4] = num2;
			array[7, 5] = 1.0;
			array[7, 6] = (double)(-num2) * double_14;
			array[7, 7] = (double)(-num2) * double_14;
			num4 = 0;
			if (UbKA2idV83X3ED1PEXX())
			{
				goto IL_00e9;
			}
			goto IL_0498;
			IL_00e9:
			array[7, 8] = double_14;
			num5 = 0;
			goto IL_01ae;
			IL_01ae:
			if (num5 < 8)
			{
				if (array[num5, num5] == 0.0)
				{
					for (i = num5 + 1; i < 8 && array[i, num5] == 0.0; i++)
					{
					}
					goto IL_013c;
				}
				goto IL_0172;
			}
			for (int num6 = 7; num6 > 0; num6--)
			{
				for (int num7 = num6 - 1; num7 >= 0; num7--)
				{
					array[num7, 8] -= array[num7, num6] * array[num6, 8];
				}
			}
			hfDyzqtNlN = array[0, 8];
			iaA8wimFax = array[1, 8];
			h6w8tTin7p = array[2, 8];
			SF48gLZg64 = array[3, 8];
			MXm8LTWJwA = array[4, 8];
			Woh8vJGWuG = array[5, 8];
			HQF8S77dvq = array[6, 8];
			nLN82tTQb2 = array[7, 8];
			kCuyOjlkKQ = true;
			return;
			IL_016c:
			for (; j < 9; j++)
			{
				array[num5, j] += array[i, j];
			}
			goto IL_0172;
			IL_013c:
			if (i == 8)
			{
				break;
			}
			j = num5;
			goto IL_016c;
			IL_01a3:
			if (num8 >= 8)
			{
				num5++;
				goto IL_01ae;
			}
			for (int num9 = 8; num9 > num5; num9--)
			{
				array[num8, num9] -= array[num5, num9] * array[num8, num5];
			}
			num8++;
			num4 = 7;
			if (!UbKA2idV83X3ED1PEXX())
			{
				num4 = num3;
			}
			goto IL_0498;
			IL_0172:
			for (int num10 = 8; num10 > num5; num10--)
			{
				array[num5, num10] /= array[num5, num5];
			}
			num8 = num5 + 1;
			goto IL_01a3;
		}
		throw new ApplicationException("Solve linear equations failed");
	}

	internal int gTQyw5EPdh()
	{
		int num = 0;
		for (int i = 0; i < 18; i++)
		{
			if (jJTE3aT8Qa(i / 3, QRCodeDimension - 11 + i % 3))
			{
				num |= 1 << i;
			}
		}
		return HAIygsIIBo(num);
	}

	internal int hnxytoesvK()
	{
		int num = 0;
		for (int i = 0; i < 18; i++)
		{
			if (jJTE3aT8Qa(QRCodeDimension - 11 + i % 3, i / 3))
			{
				num |= 1 << i;
			}
		}
		return HAIygsIIBo(num);
	}

	internal int HAIygsIIBo(int int_15)
	{
		int num = int_15 >> 12;
		if (num >= 7 && num <= 40 && kABJLxqfUqMnVsvsSHh.EGf8z74CRE[num - 7] == int_15)
		{
			return num;
		}
		int num2 = 0;
		int num3 = int.MaxValue;
		int num4 = 0;
		int num8 = default(int);
		while (true)
		{
			int num7;
			if (num4 < 34)
			{
				int num5 = kABJLxqfUqMnVsvsSHh.EGf8z74CRE[num4] ^ int_15;
				if (num5 == 0)
				{
					return int_15 >> 12;
				}
				int num6 = LjBySdg5RD(num5);
				if (num6 >= num3)
				{
					goto IL_0078;
				}
				num3 = num6;
				num2 = num4;
				num7 = 1;
				if (!UbKA2idV83X3ED1PEXX())
				{
					num7 = num8;
				}
			}
			else
			{
				if (num3 > 3)
				{
					return 0;
				}
				num7 = 0;
				if (UbKA2idV83X3ED1PEXX())
				{
					break;
				}
			}
			switch (num7)
			{
			case 1:
				goto IL_0078;
			}
			break;
			IL_0078:
			num4++;
		}
		return num2 + 7;
	}

	public int GetFormatInfoOne()
	{
		int num = 0;
		for (int i = 0; i < 15; i++)
		{
			if (jJTE3aT8Qa(kABJLxqfUqMnVsvsSHh.TvN83PQULX[i, 0], kABJLxqfUqMnVsvsSHh.TvN83PQULX[i, 1]))
			{
				num |= 1 << i;
			}
		}
		return FDgyvDakox(num);
	}

	internal int IenyLAhrrF()
	{
		int num = 0;
		int num4 = default(int);
		for (int i = 0; i < 15; i++)
		{
			int num2 = kABJLxqfUqMnVsvsSHh.nDA8fr8m4P[i, 0];
			if (num2 < 0)
			{
				int num3 = 0;
				if (!UbKA2idV83X3ED1PEXX())
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
				num2 += QRCodeDimension;
			}
			int num5 = kABJLxqfUqMnVsvsSHh.nDA8fr8m4P[i, 1];
			if (num5 < 0)
			{
				num5 += QRCodeDimension;
			}
			if (jJTE3aT8Qa(num2, num5))
			{
				num |= 1 << i;
			}
		}
		return FDgyvDakox(num);
	}

	internal int FDgyvDakox(int int_15)
	{
		int num = (int_15 ^ 0x5412) >> 10;
		if (kABJLxqfUqMnVsvsSHh.Jhi8ihpmX7[num] == int_15)
		{
			return num;
		}
		int result = 0;
		int num2 = int.MaxValue;
		for (int i = 0; i < 32; i++)
		{
			int num3 = LjBySdg5RD(kABJLxqfUqMnVsvsSHh.Jhi8ihpmX7[i] ^ int_15);
			if (num3 < num2)
			{
				num2 = num3;
				result = i;
			}
		}
		if (num2 > 3)
		{
			return -1;
		}
		return result;
	}

	internal int LjBySdg5RD(int int_15)
	{
		int num = 0;
		for (int num2 = 16384; num2 != 0; num2 >>= 1)
		{
			if ((int_15 & num2) != 0)
			{
				num++;
			}
		}
		return num;
	}

	internal void am9y2aatr4()
	{
		int num = 0;
		int num2 = 0;
		int num4 = default(int);
		for (int i = 0; i < QRCodeDimension; i++)
		{
			while (true)
			{
				IL_00a6:
				for (int j = 0; j < QRCodeDimension; j++)
				{
					if ((BI4yMH5Eed[i, j] & 4) == 0)
					{
						if (jJTE3aT8Qa(i, j))
						{
							int num3 = 1;
							if (YrtZmSvz1yu8l2aa4d8 != null)
							{
								num3 = num4;
							}
							switch (num3)
							{
							case 1:
								BI4yMH5Eed[i, j] |= 1;
								continue;
							}
							goto IL_00a6;
						}
					}
					else
					{
						num++;
						if ((jJTE3aT8Qa(i, j) ? 1 : 0) != (BI4yMH5Eed[i, j] & 1))
						{
							num2++;
						}
					}
				}
				break;
			}
		}
		if (num2 > num * ErrCorrPercent[(int)ErrorCorrection] / 100)
		{
			throw new ApplicationException("Fixed modules error");
		}
	}

	internal void pshyuAgiCi()
	{
		int num = 0;
		int num2 = 8 * aUlyrqkb9n;
		fmcyDr2w72 = new byte[aUlyrqkb9n];
		int num3 = QRCodeDimension - 1;
		int num4 = QRCodeDimension - 1;
		int num5 = 0;
		while (true)
		{
			if ((EIRyAaAkUU[num3, num4] & 2) != 0)
			{
				if (num4 == 6)
				{
					num4--;
				}
			}
			else
			{
				if ((EIRyAaAkUU[num3, num4] & 1) != 0)
				{
					fmcyDr2w72[num >> 3] |= (byte)(1 << 7 - (num & 7));
				}
				if (++num == num2)
				{
					break;
				}
			}
			switch (num5)
			{
			default:
				if (YrtZmSvz1yu8l2aa4d8 != null)
				{
					continue;
				}
				switch (0)
				{
				case 1:
					break;
				case 3:
					goto IL_00c3;
				case 2:
					goto end_IL_0040;
				default:
					continue;
				}
				goto IL_009e;
			case 0:
				num4--;
				num5 = 1;
				continue;
			case 1:
				num4++;
				num3--;
				if (num3 >= 0)
				{
					num5 = 0;
					continue;
				}
				goto IL_009e;
			case 2:
				num4--;
				num5 = 3;
				continue;
			case 3:
				{
					num4++;
					num3++;
					if (num3 >= QRCodeDimension)
					{
						num4 -= 2;
						break;
					}
					goto IL_00c3;
				}
				IL_009e:
				num4 -= 2;
				num3 = 0;
				num5 = 2;
				continue;
				IL_00c3:
				num5 = 2;
				continue;
				end_IL_0040:
				break;
			}
			num3 = QRCodeDimension - 1;
			num5 = 0;
		}
	}

	internal void eNdyNiu721()
	{
		byte[] array = new byte[aUlyrqkb9n];
		int num = a4QyjwqajX + YIpy4WAmWR;
		int[] array2 = new int[num];
		for (int i = 1; i < num; i++)
		{
			array2[i] = array2[i - 1] + ((i <= a4QyjwqajX) ? iriynkUjrt : Eygy5vDVyN);
		}
		int num5 = default(int);
		while (true)
		{
			int num2 = iriynkUjrt * num;
			int num3 = 0;
			int j = 0;
			while (true)
			{
				if (j >= num2)
				{
					if (Eygy5vDVyN > iriynkUjrt)
					{
						num2 = kHMypDeaUk;
						num3 = a4QyjwqajX;
						for (; j < num2; j++)
						{
							array[array2[num3]] = fmcyDr2w72[j];
							array2[num3]++;
							num3++;
							if (num3 == num)
							{
								num3 = a4QyjwqajX;
							}
						}
					}
					array2[0] = kHMypDeaUk;
					for (int k = 1; k < num; k++)
					{
						array2[k] = array2[k - 1] + XkiyQ8Wpy2;
					}
					goto IL_0161;
				}
				array[array2[num3]] = fmcyDr2w72[j];
				array2[num3]++;
				int num4 = 0;
				if (YrtZmSvz1yu8l2aa4d8 != null)
				{
					goto IL_013a;
				}
				goto IL_013e;
				IL_0161:
				num2 = aUlyrqkb9n;
				num3 = 0;
				goto IL_0159;
				IL_0159:
				if (j < num2)
				{
					goto IL_00ef;
				}
				fmcyDr2w72 = array;
				num4 = 4;
				if (YrtZmSvz1yu8l2aa4d8 != null)
				{
					goto IL_013a;
				}
				goto IL_013e;
				IL_013a:
				num4 = num5;
				goto IL_013e;
				IL_013e:
				switch (num4)
				{
				case 1:
					break;
				case 2:
					goto IL_0161;
				default:
					goto IL_016e;
				case 3:
					goto end_IL_01b3;
				case 4:
					return;
				}
				goto IL_00ef;
				IL_00ef:
				array[array2[num3]] = fmcyDr2w72[j];
				array2[num3]++;
				num3++;
				if (num3 == num)
				{
					num3 = 0;
				}
				j++;
				goto IL_0159;
				IL_016e:
				num3++;
				if (num3 == num)
				{
					num3 = 0;
				}
				j++;
				continue;
				end_IL_01b3:
				break;
			}
		}
	}

	protected void CalculateErrorCorrection()
	{
		int num = 2;
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int eygy5vDVyN = default(int);
		int int_ = default(int);
		int num7 = default(int);
		byte[] array = default(byte[]);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			int num2 = 0;
			int num3 = 1;
			if (YrtZmSvz1yu8l2aa4d8 != null)
			{
				goto IL_017a;
			}
			goto IL_017e;
			IL_017e:
			while (true)
			{
				byte[] array2;
				int i;
				switch (num3)
				{
				case 3:
					num4 = kHMypDeaUk;
					num5 = a4QyjwqajX + YIpy4WAmWR;
					num6 = 0;
					goto IL_0028;
				default:
					eygy5vDVyN = Eygy5vDVyN;
					int_ = eygy5vDVyN + XkiyQ8Wpy2;
					goto IL_0050;
				case 1:
					break;
				case 2:
					goto end_IL_017e;
					IL_0028:
					if (num6 < num5)
					{
						if (num6 != a4QyjwqajX)
						{
							goto IL_0050;
						}
						num3 = 0;
						if (UbKA2idV83X3ED1PEXX())
						{
							continue;
						}
						goto default;
					}
					return;
					IL_0050:
					Array.Copy(fmcyDr2w72, num7, array, 0, eygy5vDVyN);
					Array.Copy(fmcyDr2w72, num4, array, eygy5vDVyN, XkiyQ8Wpy2);
					array2 = (byte[])array.Clone();
					uiNYvdqYlcc0O7o4d4I.f2p8PeL1e9(array, int_, byte_, XkiyQ8Wpy2);
					for (i = 0; i < XkiyQ8Wpy2 && array[eygy5vDVyN + i] == 0; i++)
					{
					}
					if (i < XkiyQ8Wpy2)
					{
						int num8 = uiNYvdqYlcc0O7o4d4I.uLT8uWb1YQ(array2, int_, XkiyQ8Wpy2);
						if (num8 <= 0)
						{
							throw new ApplicationException("Data is damaged. Error correction failed");
						}
						num2 += num8;
						Array.Copy(array2, 0, fmcyDr2w72, num7, eygy5vDVyN);
					}
					num7 += eygy5vDVyN;
					num4 += XkiyQ8Wpy2;
					num6++;
					goto IL_0028;
				}
				byte_ = kABJLxqfUqMnVsvsSHh.xN58FcD7PF[XkiyQ8Wpy2 - 7];
				array = new byte[Math.Max(iriynkUjrt, Eygy5vDVyN) + XkiyQ8Wpy2];
				eygy5vDVyN = iriynkUjrt;
				int_ = eygy5vDVyN + XkiyQ8Wpy2;
				num7 = 0;
				num3 = 3;
				if (UbKA2idV83X3ED1PEXX())
				{
					continue;
				}
				goto IL_017a;
				continue;
				end_IL_017e:
				break;
			}
			continue;
			IL_017a:
			num3 = num;
			goto IL_017e;
		}
	}

	internal byte[] jA5yJMXdE3()
	{
		C49yoWOmgx = (uint)((fmcyDr2w72[0] << 24) | (fmcyDr2w72[1] << 16) | (fmcyDr2w72[2] << 8) | fmcyDr2w72[3]);
		g62yTm5CsU = 32;
		rSAydKyYuN = 4;
		List<byte> list = new List<byte>();
		ECIAssignValue = -1;
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num9 = default(int);
		int num12 = default(int);
		while (true)
		{
			EncodingMode encodingMode = (EncodingMode)lwNy06MElV(4);
			if (encodingMode <= EncodingMode.Terminator)
			{
				break;
			}
			if (encodingMode == EncodingMode.ECI)
			{
				ECIAssignValue = lwNy06MElV(8);
				if ((ECIAssignValue & 0x80) == 0)
				{
					continue;
				}
				ECIAssignValue = (ECIAssignValue << 8) | lwNy06MElV(8);
				if ((ECIAssignValue & 0x4000) == 0)
				{
					ECIAssignValue &= 16383;
					continue;
				}
				ECIAssignValue = (ECIAssignValue << 8) | lwNy06MElV(8);
			}
			else
			{
				int num = lwNy06MElV(acbyCgf4Fl(encodingMode));
				if (num < 0)
				{
					throw new ApplicationException("Premature end of data (DataLengh)");
				}
				int count = list.Count;
				int num7;
				int num8;
				switch (encodingMode)
				{
				default:
					num7 = 2;
					if (YrtZmSvz1yu8l2aa4d8 != null)
					{
						goto IL_0201;
					}
					goto IL_0205;
				case EncodingMode.Numeric:
					num5 = num / 3 * 3;
					num6 = 0;
					goto IL_0183;
				case EncodingMode.AlphaNumeric:
					num3 = num / 2 * 2;
					num4 = 0;
					goto IL_022e;
				case EncodingMode.Byte:
				{
					for (int i = 0; i < num; i++)
					{
						int num2 = lwNy06MElV(8);
						if (num2 >= 0)
						{
							list.Add((byte)num2);
							continue;
						}
						throw new ApplicationException("Premature end of data (byte mode)");
					}
					goto IL_031f;
				}
				case EncodingMode.Append:
					goto IL_0395;
					IL_03b2:
					throw new ApplicationException("Data encoding length in error");
					IL_0205:
					switch (num7)
					{
					case 1:
						break;
					case 4:
						goto IL_0228;
					default:
						goto IL_0267;
					case 5:
						goto end_IL_00f1;
					case 3:
						continue;
					case 2:
						goto IL_0395;
					case 6:
						goto IL_03b2;
					}
					goto IL_01ba;
					IL_0395:
					throw new ApplicationException($"Encoding mode not supported {encodingMode.ToString()}");
					IL_0267:
					num8 = lwNy06MElV(4);
					if (num8 >= 0)
					{
						list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num8]);
						goto IL_031f;
					}
					throw new ApplicationException("Premature end of data (Numeric 2)");
					IL_031f:
					if (num == list.Count - count)
					{
						continue;
					}
					goto IL_03b2;
					IL_01ba:
					list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num9 % 100 / 10]);
					list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num9 % 10]);
					num6 += 3;
					goto IL_0183;
					IL_0228:
					num4 += 2;
					goto IL_022e;
					IL_022e:
					if (num4 < num3)
					{
						int num10 = lwNy06MElV(11);
						if (num10 >= 0)
						{
							list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num10 / 45]);
							list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num10 % 45]);
							num7 = 4;
							if (UbKA2idV83X3ED1PEXX())
							{
								goto IL_0205;
							}
							goto IL_0228;
						}
						throw new ApplicationException("Premature end of data (Alpha Numeric 1)");
					}
					if (num - num3 == 1)
					{
						int num11 = lwNy06MElV(6);
						if (num11 < 0)
						{
							throw new ApplicationException("Premature end of data (Alpha Numeric 2)");
						}
						list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num11]);
					}
					goto IL_031f;
					IL_0201:
					num7 = num12;
					goto IL_0205;
					IL_0183:
					if (num6 < num5)
					{
						num9 = lwNy06MElV(10);
						if (num9 < 0)
						{
							throw new ApplicationException("Premature end of data (Numeric 1)");
						}
						list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num9 / 100]);
						num7 = 1;
						if (!UbKA2idV83X3ED1PEXX())
						{
							goto IL_01ba;
						}
					}
					else
					{
						if (num - num5 != 1)
						{
							if (num - num5 == 2)
							{
								int num13 = lwNy06MElV(7);
								if (num13 < 0)
								{
									throw new ApplicationException("Premature end of data (Numeric 3)");
								}
								list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num13 / 10]);
								list.Add(kABJLxqfUqMnVsvsSHh.MqR8ZBw6Br[num13 % 10]);
							}
							goto IL_031f;
						}
						num7 = 0;
						if (YrtZmSvz1yu8l2aa4d8 != null)
						{
							goto IL_0201;
						}
					}
					goto IL_0205;
					end_IL_00f1:
					break;
				}
			}
			if ((ECIAssignValue & 0x200000) == 0)
			{
				ECIAssignValue &= 2097151;
				continue;
			}
			throw new ApplicationException("ECI encoding assinment number in error");
		}
		return list.ToArray();
	}

	internal int lwNy06MElV(int int_15)
	{
		while (int_15 > g62yTm5CsU)
		{
			if (YrtZmSvz1yu8l2aa4d8 != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			return -1;
		}
		int result = (int)(C49yoWOmgx >> 32 - int_15);
		C49yoWOmgx <<= int_15;
		g62yTm5CsU -= int_15;
		while (g62yTm5CsU <= 24 && rSAydKyYuN < kHMypDeaUk)
		{
			C49yoWOmgx |= (uint)(fmcyDr2w72[rSAydKyYuN++] << 24 - g62yTm5CsU);
			g62yTm5CsU += 8;
		}
		return result;
	}

	internal int acbyCgf4Fl(EncodingMode encodingMode_0)
	{
		switch (encodingMode_0)
		{
		case EncodingMode.Numeric:
			if (QRCodeVersion >= 10)
			{
				if (QRCodeVersion >= 27)
				{
					return 14;
				}
				return 12;
			}
			return 10;
		case EncodingMode.AlphaNumeric:
			if (QRCodeVersion >= 10)
			{
				if (QRCodeVersion >= 27)
				{
					return 13;
				}
				return 11;
			}
			return 9;
		default:
			throw new ApplicationException("Unsupported encoding mode " + encodingMode_0);
		case EncodingMode.Byte:
			if (QRCodeVersion >= 10)
			{
				return 16;
			}
			return 8;
		}
	}

	internal void GpoyPZu8Tc()
	{
		int num = (int)((QRCodeVersion - 1) * 4 + ErrorCorrection);
		a4QyjwqajX = kABJLxqfUqMnVsvsSHh.GOt89C4rTT[num, 0];
		iriynkUjrt = kABJLxqfUqMnVsvsSHh.GOt89C4rTT[num, 1];
		YIpy4WAmWR = kABJLxqfUqMnVsvsSHh.GOt89C4rTT[num, 2];
		Eygy5vDVyN = kABJLxqfUqMnVsvsSHh.GOt89C4rTT[num, 3];
		kHMypDeaUk = a4QyjwqajX * iriynkUjrt + YIpy4WAmWR * Eygy5vDVyN;
		NSIyB5SNLj = 8 * kHMypDeaUk;
		if (YrtZmSvz1yu8l2aa4d8 != null)
		{
			switch (0)
			{
			}
		}
		aUlyrqkb9n = kABJLxqfUqMnVsvsSHh.V2G8cZI4N0[QRCodeVersion];
		XkiyQ8Wpy2 = (aUlyrqkb9n - kHMypDeaUk) / (a4QyjwqajX + YIpy4WAmWR);
	}

	internal ErrorCorrection qbbyEjE2RE(int int_15)
	{
		return (ErrorCorrection)(int_15 ^ 1);
	}

	internal void fNhyyP8ouZ()
	{
		BI4yMH5Eed = new byte[QRCodeDimension + 5, QRCodeDimension + 5];
		int num = 0;
		int num4 = default(int);
		int num5 = default(int);
		byte[] array = default(byte[]);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		while (true)
		{
			if (num < 9)
			{
				goto IL_0023;
			}
			int num2 = QRCodeDimension - 8;
			int i = 0;
			int num3 = 5;
			if (!UbKA2idV83X3ED1PEXX())
			{
				goto IL_016b;
			}
			goto IL_0219;
			IL_00dc:
			if (num4 < 3)
			{
				goto IL_00af;
			}
			num5++;
			goto IL_00e7;
			IL_0219:
			switch (num3)
			{
			case 7:
				break;
			case 8:
				goto IL_007e;
			case 3:
				goto IL_00af;
			case 2:
				goto IL_00dc;
			case 4:
				goto IL_00ec;
			case 6:
				goto IL_00fa;
			default:
				goto IL_0108;
			case 5:
				goto IL_016b;
			case 1:
				goto IL_0273;
			}
			goto IL_0023;
			IL_016b:
			for (; i < 9; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					BI4yMH5Eed[i, num2 + j] = kABJLxqfUqMnVsvsSHh.oMpat4Esab[i, j];
				}
			}
			for (int k = 0; k < 8; k++)
			{
				for (int l = 0; l < 9; l++)
				{
					BI4yMH5Eed[num2 + k, l] = kABJLxqfUqMnVsvsSHh.HZ9agYaD80[k, l];
				}
			}
			for (int m = 8; m < QRCodeDimension - 8; m++)
			{
				BI4yMH5Eed[m, 6] = (BI4yMH5Eed[6, m] = (byte)(((m & 1) == 0) ? 7 : 6));
			}
			if (QRCodeVersion > 1)
			{
				array = kABJLxqfUqMnVsvsSHh.CIT8qivlcq[QRCodeVersion];
				num6 = array.Length;
				num7 = 0;
				goto IL_00fa;
			}
			goto IL_0255;
			IL_0255:
			if (QRCodeVersion >= 7)
			{
				num2 = QRCodeDimension - 11;
				num8 = 0;
				goto IL_0297;
			}
			break;
			IL_0023:
			for (int n = 0; n < 9; n++)
			{
				BI4yMH5Eed[num, n] = kABJLxqfUqMnVsvsSHh.NCAawA88uH[num, n];
			}
			num++;
			continue;
			IL_0297:
			if (num8 < 6)
			{
				num9 = 0;
				goto IL_028c;
			}
			for (int num10 = 0; num10 < 6; num10++)
			{
				for (int num11 = 0; num11 < 3; num11++)
				{
					BI4yMH5Eed[num2 + num11, num10] = 2;
				}
			}
			break;
			IL_0108:
			num12 = array[num7];
			num13 = array[num14];
			num5 = -2;
			goto IL_00e7;
			IL_00e7:
			if (num5 < 3)
			{
				num4 = -2;
				goto IL_00dc;
			}
			goto IL_00ec;
			IL_00ec:
			num14++;
			goto IL_0081;
			IL_007e:
			num14 = 0;
			goto IL_0081;
			IL_0081:
			if (num14 < num6)
			{
				if ((num14 != 0 || num7 != 0) && (num14 != num6 - 1 || num7 != 0))
				{
					if (num14 != 0)
					{
						goto IL_0108;
					}
					if (num7 != num6 - 1)
					{
						num3 = 0;
						if (YrtZmSvz1yu8l2aa4d8 != null)
						{
							num3 = num15;
						}
						goto IL_0219;
					}
				}
				goto IL_00ec;
			}
			num7++;
			goto IL_00fa;
			IL_028c:
			if (num9 < 3)
			{
				goto IL_0273;
			}
			num8++;
			goto IL_0297;
			IL_00af:
			BI4yMH5Eed[num12 + num5, num13 + num4] = kABJLxqfUqMnVsvsSHh.ab9aLgAou5[num5 + 2, num4 + 2];
			num4++;
			goto IL_00dc;
			IL_0273:
			BI4yMH5Eed[num8, num2 + num9] = 2;
			num9++;
			goto IL_028c;
			IL_00fa:
			if (num7 < num6)
			{
				goto IL_007e;
			}
			goto IL_0255;
		}
	}

	internal void E5Qy8UYIeZ(int int_15)
	{
		EIRyAaAkUU = (byte[,])BI4yMH5Eed.Clone();
		switch (int_15)
		{
		case 0:
			XqWya4D6T0();
			break;
		case 1:
			Xtxy7LF6Jp();
			break;
		case 2:
			LLCyRPJNFV();
			break;
		case 3:
			TZPyq8PNuu();
			break;
		case 4:
			Bheyc9ctav();
			break;
		case 5:
			BB7yVmZ6Y4();
			if (!UbKA2idV83X3ED1PEXX())
			{
				switch (0)
				{
				}
			}
			break;
		case 6:
			efVyZ3NeiD();
			break;
		case 7:
			Vgky9PD9d7();
			break;
		}
	}

	internal void XqWya4D6T0()
	{
		for (int i = 0; i < QRCodeDimension; i += 2)
		{
			for (int j = 0; j < QRCodeDimension; j += 2)
			{
				if ((EIRyAaAkUU[i, j] & 2) == 0)
				{
					EIRyAaAkUU[i, j] ^= 1;
				}
				if ((EIRyAaAkUU[i + 1, j + 1] & 2) == 0)
				{
					EIRyAaAkUU[i + 1, j + 1] ^= 1;
				}
			}
		}
	}

	internal void Xtxy7LF6Jp()
	{
		for (int i = 0; i < QRCodeDimension; i += 2)
		{
			for (int j = 0; j < QRCodeDimension; j++)
			{
				if ((EIRyAaAkUU[i, j] & 2) == 0)
				{
					EIRyAaAkUU[i, j] ^= 1;
				}
			}
		}
		if (YrtZmSvz1yu8l2aa4d8 != null)
		{
			switch (0)
			{
			}
		}
	}

	internal void LLCyRPJNFV()
	{
		for (int i = 0; i < QRCodeDimension; i++)
		{
			for (int j = 0; j < QRCodeDimension; j += 3)
			{
				if ((EIRyAaAkUU[i, j] & 2) == 0)
				{
					EIRyAaAkUU[i, j] ^= 1;
				}
			}
		}
		if (YrtZmSvz1yu8l2aa4d8 == null)
		{
			switch (0)
			{
			}
		}
	}

	internal void TZPyq8PNuu()
	{
		for (int i = 0; i < QRCodeDimension; i += 3)
		{
			for (int j = 0; j < QRCodeDimension; j += 3)
			{
				if ((EIRyAaAkUU[i, j] & 2) == 0)
				{
					EIRyAaAkUU[i, j] ^= 1;
				}
				if ((EIRyAaAkUU[i + 1, j + 2] & 2) == 0)
				{
					EIRyAaAkUU[i + 1, j + 2] ^= 1;
				}
				if ((EIRyAaAkUU[i + 2, j + 1] & 2) == 0)
				{
					EIRyAaAkUU[i + 2, j + 1] ^= 1;
				}
			}
			if (YrtZmSvz1yu8l2aa4d8 == null)
			{
				switch (0)
				{
				}
			}
		}
	}

	internal void Bheyc9ctav()
	{
		int num = 1;
		int num4 = default(int);
		while (true)
		{
			int num2 = 0;
			int num3 = 0;
			if (YrtZmSvz1yu8l2aa4d8 == null)
			{
				goto IL_024c;
			}
			goto IL_0285;
			IL_0285:
			switch (num3)
			{
			case 3:
				break;
			case 2:
				goto IL_0028;
			default:
				goto IL_024c;
			case 1:
				continue;
			}
			goto IL_000e;
			IL_000e:
			if ((EIRyAaAkUU[num2 + 2, num4 + 5] & 2) != 0)
			{
				goto IL_0028;
			}
			EIRyAaAkUU[num2 + 2, num4 + 5] ^= 1;
			num3 = 2;
			if (!UbKA2idV83X3ED1PEXX())
			{
				num3 = num;
			}
			goto IL_0285;
			IL_0028:
			if ((EIRyAaAkUU[num2 + 3, num4 + 3] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 3, num4 + 3] ^= 1;
			}
			if ((EIRyAaAkUU[num2 + 3, num4 + 4] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 3, num4 + 4] ^= 1;
			}
			if ((EIRyAaAkUU[num2 + 3, num4 + 5] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 3, num4 + 5] ^= 1;
			}
			num4 += 6;
			goto IL_00be;
			IL_024c:
			if (num2 < QRCodeDimension)
			{
				num4 = 0;
				goto IL_00be;
			}
			break;
			IL_00be:
			if (num4 >= QRCodeDimension)
			{
				num2 += 4;
				goto IL_024c;
			}
			if ((EIRyAaAkUU[num2, num4] & 2) == 0)
			{
				EIRyAaAkUU[num2, num4] ^= 1;
			}
			if ((EIRyAaAkUU[num2, num4 + 1] & 2) == 0)
			{
				EIRyAaAkUU[num2, num4 + 1] ^= 1;
			}
			if ((EIRyAaAkUU[num2, num4 + 2] & 2) == 0)
			{
				EIRyAaAkUU[num2, num4 + 2] ^= 1;
			}
			if ((EIRyAaAkUU[num2 + 1, num4] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 1, num4] ^= 1;
			}
			if ((EIRyAaAkUU[num2 + 1, num4 + 1] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 1, num4 + 1] ^= 1;
			}
			if ((EIRyAaAkUU[num2 + 1, num4 + 2] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 1, num4 + 2] ^= 1;
			}
			if ((EIRyAaAkUU[num2 + 2, num4 + 3] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 2, num4 + 3] ^= 1;
			}
			if ((EIRyAaAkUU[num2 + 2, num4 + 4] & 2) == 0)
			{
				EIRyAaAkUU[num2 + 2, num4 + 4] ^= 1;
			}
			goto IL_000e;
		}
	}

	internal void BB7yVmZ6Y4()
	{
		int num2 = default(int);
		int num4 = default(int);
		for (int i = 0; i < QRCodeDimension; i += 6)
		{
			int num = 0;
			while (true)
			{
				if (num < QRCodeDimension)
				{
					for (int j = 0; j < 6; j++)
					{
						if ((EIRyAaAkUU[i, num + j] & 2) == 0)
						{
							EIRyAaAkUU[i, num + j] ^= 1;
						}
					}
					num2 = 1;
					goto IL_0143;
				}
				int num3 = 0;
				if (YrtZmSvz1yu8l2aa4d8 == null)
				{
					break;
				}
				goto IL_0130;
				IL_0150:
				if ((EIRyAaAkUU[i + 4, num + 3] & 2) == 0)
				{
					EIRyAaAkUU[i + 4, num + 3] ^= 1;
				}
				num += 6;
				continue;
				IL_0130:
				switch (num3)
				{
				case 2:
					break;
				default:
					goto IL_0150;
				case 1:
					goto end_IL_0196;
				}
				goto IL_006c;
				IL_006c:
				EIRyAaAkUU[i + num2, num] ^= 1;
				goto IL_0084;
				IL_0084:
				num2++;
				goto IL_0143;
				IL_0143:
				if (num2 < 6)
				{
					if ((EIRyAaAkUU[i + num2, num] & 2) == 0)
					{
						goto IL_006c;
					}
					goto IL_0084;
				}
				if ((EIRyAaAkUU[i + 2, num + 3] & 2) == 0)
				{
					EIRyAaAkUU[i + 2, num + 3] ^= 1;
				}
				if ((EIRyAaAkUU[i + 3, num + 2] & 2) == 0)
				{
					EIRyAaAkUU[i + 3, num + 2] ^= 1;
				}
				if ((EIRyAaAkUU[i + 3, num + 4] & 2) == 0)
				{
					EIRyAaAkUU[i + 3, num + 4] ^= 1;
					num3 = 0;
					if (!UbKA2idV83X3ED1PEXX())
					{
						num3 = num4;
					}
					goto IL_0130;
				}
				goto IL_0150;
				continue;
				end_IL_0196:
				break;
			}
		}
	}

	internal void efVyZ3NeiD()
	{
		int num3 = default(int);
		for (int i = 0; i < QRCodeDimension; i += 6)
		{
			for (int j = 0; j < QRCodeDimension; j += 6)
			{
				int num = 0;
				while (true)
				{
					if (num >= 6)
					{
						for (int k = 1; k < 6; k++)
						{
							if ((EIRyAaAkUU[i + k, j] & 2) == 0)
							{
								EIRyAaAkUU[i + k, j] ^= 1;
							}
						}
						int num2 = 2;
						if (!UbKA2idV83X3ED1PEXX())
						{
							goto IL_026f;
						}
						while (true)
						{
							switch (num2)
							{
							case 3:
								if ((EIRyAaAkUU[i + 2, j + 4] & 2) == 0)
								{
									EIRyAaAkUU[i + 2, j + 4] ^= 1;
								}
								if ((EIRyAaAkUU[i + 3, j + 2] & 2) == 0)
								{
									EIRyAaAkUU[i + 3, j + 2] ^= 1;
								}
								if ((EIRyAaAkUU[i + 3, j + 4] & 2) == 0)
								{
									EIRyAaAkUU[i + 3, j + 4] ^= 1;
								}
								if ((EIRyAaAkUU[i + 4, j + 2] & 2) == 0)
								{
									EIRyAaAkUU[i + 4, j + 2] ^= 1;
									num2 = 1;
									if (!UbKA2idV83X3ED1PEXX())
									{
										num2 = num3;
									}
									continue;
								}
								goto IL_026f;
							case 2:
								if ((EIRyAaAkUU[i + 1, j + 1] & 2) == 0)
								{
									EIRyAaAkUU[i + 1, j + 1] ^= 1;
								}
								if ((EIRyAaAkUU[i + 1, j + 2] & 2) == 0)
								{
									EIRyAaAkUU[i + 1, j + 2] ^= 1;
								}
								if ((EIRyAaAkUU[i + 2, j + 1] & 2) == 0)
								{
									EIRyAaAkUU[i + 2, j + 1] ^= 1;
								}
								if ((EIRyAaAkUU[i + 2, j + 3] & 2) == 0)
								{
									EIRyAaAkUU[i + 2, j + 3] ^= 1;
									num3 = 3;
								}
								goto case 3;
							case 1:
								goto IL_026f;
							case 4:
								goto IL_0286;
							}
							break;
						}
					}
					if ((EIRyAaAkUU[i, j + num] & 2) == 0)
					{
						EIRyAaAkUU[i, j + num] ^= 1;
					}
					num++;
					continue;
					IL_026f:
					if ((EIRyAaAkUU[i + 4, j + 3] & 2) != 0)
					{
						break;
					}
					goto IL_0286;
					IL_0286:
					EIRyAaAkUU[i + 4, j + 3] ^= 1;
					break;
				}
				if ((EIRyAaAkUU[i + 4, j + 5] & 2) == 0)
				{
					EIRyAaAkUU[i + 4, j + 5] ^= 1;
				}
				if ((EIRyAaAkUU[i + 5, j + 4] & 2) == 0)
				{
					EIRyAaAkUU[i + 5, j + 4] ^= 1;
				}
				if ((EIRyAaAkUU[i + 5, j + 5] & 2) == 0)
				{
					EIRyAaAkUU[i + 5, j + 5] ^= 1;
				}
			}
		}
	}

	internal void Vgky9PD9d7()
	{
		int num3 = default(int);
		for (int i = 0; i < QRCodeDimension; i += 6)
		{
			while (true)
			{
				IL_03d8:
				for (int num = 0; num < QRCodeDimension; num += 6)
				{
					int num2;
					if ((EIRyAaAkUU[i, num] & 2) == 0)
					{
						EIRyAaAkUU[i, num] ^= 1;
						num2 = 0;
						if (UbKA2idV83X3ED1PEXX())
						{
							goto IL_0254;
						}
					}
					goto IL_0300;
					IL_02cb:
					if ((EIRyAaAkUU[i + 4, num + 1] & 2) == 0)
					{
						EIRyAaAkUU[i + 4, num + 1] ^= 1;
						num3 = 4;
					}
					goto IL_0272;
					IL_0254:
					switch (num2)
					{
					case 4:
						break;
					case 2:
						goto IL_028e;
					default:
						goto IL_0300;
					case 1:
						goto IL_031a;
					case 3:
						goto IL_03d8;
					}
					goto IL_0272;
					IL_0300:
					if ((EIRyAaAkUU[i, num + 2] & 2) == 0)
					{
						EIRyAaAkUU[i, num + 2] ^= 1;
					}
					if ((EIRyAaAkUU[i, num + 4] & 2) == 0)
					{
						EIRyAaAkUU[i, num + 4] ^= 1;
					}
					if ((EIRyAaAkUU[i + 1, num + 3] & 2) == 0)
					{
						EIRyAaAkUU[i + 1, num + 3] ^= 1;
					}
					if ((EIRyAaAkUU[i + 1, num + 4] & 2) == 0)
					{
						EIRyAaAkUU[i + 1, num + 4] ^= 1;
					}
					if ((EIRyAaAkUU[i + 1, num + 5] & 2) == 0)
					{
						EIRyAaAkUU[i + 1, num + 5] ^= 1;
					}
					if ((EIRyAaAkUU[i + 2, num] & 2) == 0)
					{
						EIRyAaAkUU[i + 2, num] ^= 1;
					}
					if ((EIRyAaAkUU[i + 2, num + 4] & 2) == 0)
					{
						EIRyAaAkUU[i + 2, num + 4] ^= 1;
					}
					if ((EIRyAaAkUU[i + 2, num + 5] & 2) == 0)
					{
						EIRyAaAkUU[i + 2, num + 5] ^= 1;
					}
					if ((EIRyAaAkUU[i + 3, num + 1] & 2) == 0)
					{
						EIRyAaAkUU[i + 3, num + 1] ^= 1;
					}
					if ((EIRyAaAkUU[i + 3, num + 3] & 2) == 0)
					{
						EIRyAaAkUU[i + 3, num + 3] ^= 1;
					}
					if ((EIRyAaAkUU[i + 3, num + 5] & 2) == 0)
					{
						EIRyAaAkUU[i + 3, num + 5] ^= 1;
					}
					if ((EIRyAaAkUU[i + 4, num] & 2) == 0)
					{
						num3 = 2;
						goto IL_028e;
					}
					goto IL_02cb;
					IL_031a:
					EIRyAaAkUU[i + 4, num + 2] ^= 1;
					goto IL_0333;
					IL_0272:
					if ((EIRyAaAkUU[i + 4, num + 2] & 2) == 0)
					{
						num2 = 1;
						if (YrtZmSvz1yu8l2aa4d8 != null)
						{
							num2 = num3;
						}
						goto IL_0254;
					}
					goto IL_0333;
					IL_028e:
					EIRyAaAkUU[i + 4, num] ^= 1;
					goto IL_02cb;
					IL_0333:
					if ((EIRyAaAkUU[i + 5, num + 1] & 2) == 0)
					{
						EIRyAaAkUU[i + 5, num + 1] ^= 1;
					}
					if ((EIRyAaAkUU[i + 5, num + 2] & 2) == 0)
					{
						EIRyAaAkUU[i + 5, num + 2] ^= 1;
					}
					if ((EIRyAaAkUU[i + 5, num + 3] & 2) == 0)
					{
						EIRyAaAkUU[i + 5, num + 3] ^= 1;
					}
				}
				break;
			}
		}
	}

	internal static bool UbKA2idV83X3ED1PEXX()
	{
		return YrtZmSvz1yu8l2aa4d8 == null;
	}
}
