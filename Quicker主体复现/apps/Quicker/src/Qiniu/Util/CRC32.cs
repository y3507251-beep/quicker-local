using System.IO;

namespace Qiniu.Util;

public class CRC32
{
	public const uint IEEE = 3988292384u;

	private uint[] eEJeEi1qxF;

	private uint Value;

	private static CRC32 GqbskI9zxtwQgskUaJP;

	public CRC32()
	{
		Value = 0u;
		eEJeEi1qxF = cyyePEpdEc(3988292384u);
	}

	public void Write(byte[] p, int offset, int count)
	{
		Value = Update(Value, eEJeEi1qxF, p, offset, count);
	}

	public uint Sum()
	{
		return Value;
	}

	private static uint[] cyyePEpdEc(uint uint_1)
	{
		uint[] array = new uint[256];
		for (int i = 0; i < 256; i++)
		{
			uint num = (uint)i;
			int num2 = 0;
			while (num2 < 8)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ uint_1));
				num2++;
				if (GqbskI9zxtwQgskUaJP == null)
				{
					switch (0)
					{
					}
				}
			}
			array[i] = num;
		}
		return array;
	}

	public static uint Update(uint crc, uint[] table, byte[] p, int offset, int count)
	{
		crc = ~crc;
		for (int i = 0; i < count; i++)
		{
			crc = table[(byte)crc ^ p[offset + i]] ^ (crc >> 8);
		}
		return ~crc;
	}

	public static uint CheckSumBytes(byte[] data)
	{
		CRC32 cRC = new CRC32();
		cRC.Write(data, 0, data.Length);
		return cRC.Sum();
	}

	public static uint CheckSumSlice(byte[] data, int offset, int count)
	{
		CRC32 cRC = new CRC32();
		cRC.Write(data, offset, count);
		return cRC.Sum();
	}

	public static uint checkSumFile(string filePath)
	{
		CRC32 cRC = new CRC32();
		int num = 32768;
		using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
		{
			byte[] array = new byte[num];
			while (true)
			{
				int num2 = fileStream.Read(array, 0, num);
				if (num2 != 0)
				{
					cRC.Write(array, 0, num2);
					continue;
				}
				break;
			}
		}
		return cRC.Sum();
	}

	internal static bool V3eBlILVAfykUPvOSvN()
	{
		return GqbskI9zxtwQgskUaJP == null;
	}
}
