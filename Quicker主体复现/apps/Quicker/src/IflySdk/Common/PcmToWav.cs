using System;
using System.IO;
using System.Runtime.InteropServices;

namespace IflySdk.Common;

public class PcmToWav
{
	public struct Header
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] fccID;

		public uint dwSize;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] fccType;
	}

	public struct FMT
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] fccID;

		public uint dwSize;

		public ushort wFormatTag;

		public ushort wChannels;

		public uint dwSamplesPerSec;

		public uint dwAvgBytesPerSec;

		public ushort wBlockAlign;

		public ushort uiBitsPerSample;
	}

	public struct DATA
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] fccID;

		public uint dwSize;
	}

	private Header njwh5wpqqV;

	private FMT Q2yhDy8ovY;

	private DATA riqhddm9bh;

	private int ToChoCGkoj;

	private int nCqhTrHtMY;

	private int rGNhM9T24h;

	public ushort PCM_CHANNEL_NUM = 1;

	public uint PCM_SAMPLE_RATE = 16000u;

	public ushort PCM_SAMPLE_BITS = 16;

	internal static PcmToWav iiWfOJ9OtbG39KnUwLj;

	public string ConverterToWav(string pcmPath, string wavPath = null)
	{
        FileStream fileStream = default;
		FileInfo fileInfo = new FileInfo(pcmPath);
		if (!fileInfo.Exists)
		{
			return null;
		}
		if (fileInfo.Extension != ".pcm")
		{
			return null;
		}
		int num;
		if (string.IsNullOrEmpty(wavPath))
		{
			num = 1;
			if (iiWfOJ9OtbG39KnUwLj != null)
			{
				goto IL_00d1;
			}
			goto IL_0229;
		}
		goto IL_026e;
		IL_026e:
		if (File.Exists(wavPath))
		{
			new FileInfo(wavPath).Delete();
		}
		fileStream = new FileStream(wavPath, FileMode.Create);
		num = 0;
		if (iiWfOJ9OtbG39KnUwLj != null)
		{
			goto IL_00da;
		}
		goto IL_0229;
		IL_00da:
		njwh5wpqqV.fccID = new byte[4]
		{
			Convert.ToByte('R'),
			Convert.ToByte('I'),
			Convert.ToByte('F'),
			Convert.ToByte('F')
		};
		njwh5wpqqV.fccType = new byte[4]
		{
			Convert.ToByte('W'),
			Convert.ToByte('A'),
			Convert.ToByte('V'),
			Convert.ToByte('E')
		};
		ToChoCGkoj = Marshal.SizeOf(njwh5wpqqV);
		fileStream.Seek(ToChoCGkoj, SeekOrigin.Begin);
		Q2yhDy8ovY.fccID = new byte[4]
		{
			Convert.ToByte('f'),
			Convert.ToByte('m'),
			Convert.ToByte('t'),
			32
		};
		Q2yhDy8ovY.dwSize = 16u;
		Q2yhDy8ovY.wFormatTag = 1;
		Q2yhDy8ovY.uiBitsPerSample = PCM_SAMPLE_BITS;
		Q2yhDy8ovY.dwSamplesPerSec = PCM_SAMPLE_RATE;
		Q2yhDy8ovY.wChannels = PCM_CHANNEL_NUM;
		Q2yhDy8ovY.dwAvgBytesPerSec = Q2yhDy8ovY.dwSamplesPerSec * Q2yhDy8ovY.wChannels * Q2yhDy8ovY.uiBitsPerSample / 8;
		num = 3;
		if (Yy5qGk9Jus2RDTykoWv())
		{
			goto IL_0229;
		}
		goto IL_0244;
		IL_0244:
		wavPath = fileInfo.FullName.Replace(".pcm", ".wav");
		goto IL_026e;
		IL_00d1:
		int num2 = default(int);
		num = num2;
		goto IL_0229;
		IL_0229:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				goto end_IL_0229;
			case 1:
				goto IL_0244;
			case 2:
			{
				riqhddm9bh.fccID = new byte[4]
				{
					Convert.ToByte('d'),
					Convert.ToByte('a'),
					Convert.ToByte('t'),
					Convert.ToByte('a')
				};
				rGNhM9T24h = Marshal.SizeOf(riqhddm9bh);
				fileStream.Seek(rGNhM9T24h, SeekOrigin.Current);
				using (FileStream fileStream2 = new FileStream(pcmPath, FileMode.Open, FileAccess.Read))
				{
					byte[] buffer = new byte[fileStream2.Length];
					fileStream2.Seek(0L, SeekOrigin.Begin);
					fileStream2.Read(buffer, 0, Convert.ToInt32(fileStream2.Length));
					fileStream.Write(buffer, 0, Convert.ToInt32(fileStream2.Length));
					riqhddm9bh.dwSize = Convert.ToUInt32(fileStream2.Length);
				}
				njwh5wpqqV.dwSize = 36 + riqhddm9bh.dwSize;
				fileStream.Seek(0L, SeekOrigin.Begin);
				ToChoCGkoj = Marshal.SizeOf(njwh5wpqqV);
				byte[] buffer2 = StructToBytes(njwh5wpqqV, ToChoCGkoj);
				fileStream.Write(buffer2, 0, ToChoCGkoj);
				fileStream.Seek(nCqhTrHtMY, SeekOrigin.Current);
				byte[] buffer3 = StructToBytes(riqhddm9bh, rGNhM9T24h);
				fileStream.Write(buffer3, 0, rGNhM9T24h);
				fileStream.Close();
				return wavPath;
			}
			}
			Q2yhDy8ovY.wBlockAlign = (ushort)(Q2yhDy8ovY.uiBitsPerSample * Q2yhDy8ovY.wChannels / 8);
			nCqhTrHtMY = Marshal.SizeOf(Q2yhDy8ovY);
			byte[] buffer4 = StructToBytes(Q2yhDy8ovY, nCqhTrHtMY);
			fileStream.Write(buffer4, 0, nCqhTrHtMY);
			num = 2;
			if (iiWfOJ9OtbG39KnUwLj == null)
			{
				continue;
			}
			goto IL_00d1;
			continue;
			end_IL_0229:
			break;
		}
		goto IL_00da;
	}

	public static byte[] StructToBytes(object structObj, int size)
	{
		byte[] array = new byte[size];
		IntPtr intPtr = Marshal.AllocHGlobal(size);
		Marshal.StructureToPtr(structObj, intPtr, false);
		Marshal.Copy(intPtr, array, 0, size);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	public static object ByteToStruct(byte[] bytes, Type type)
	{
		int num = Marshal.SizeOf(type);
		if (num > bytes.Length)
		{
			return null;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.Copy(bytes, 0, intPtr, num);
		object result = Marshal.PtrToStructure(intPtr, type);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	internal static bool Yy5qGk9Jus2RDTykoWv()
	{
		return iiWfOJ9OtbG39KnUwLj == null;
	}

	internal static void VgACut9u3hbVqjuF5Xm()
	{
	}
}
