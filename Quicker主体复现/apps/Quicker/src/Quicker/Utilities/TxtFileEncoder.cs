using System;
using System.IO;
using System.Text;

namespace Quicker.Utilities;

public static class TxtFileEncoder
{
	private static object TBHYSQF5ziyOsyBXn5HE;

	public static Encoding GetEncoding(string path)
	{
		Encoding result = Encoding.Default;
		if (File.Exists(path))
		{
			return eGdLoQtPMBL(File.ReadAllBytes(path));
		}
		return result;
	}

	private static Encoding eGdLoQtPMBL(byte[] byte_0)
	{
		if (byte_0.Length >= 3 && byte_0[0] == 239 && byte_0[1] == 187 && byte_0[2] == 191)
		{
			return Encoding.UTF8;
		}
		int num;
		if (byte_0.Length >= 2)
		{
			num = 0;
			if (!HdHjNaFYVN4xZPUO9PyF())
			{
				goto IL_009b;
			}
			goto IL_00a8;
		}
		goto IL_00da;
		IL_010f:
		if (I1FLojVTIKG(byte_0))
		{
			return Encoding.UTF8;
		}
		return Encoding.Default;
		IL_00da:
		if (byte_0.Length < 2 || byte_0[0] != 254 || byte_0[1] != byte.MaxValue)
		{
			if (byte_0.Length < 4 || byte_0[0] != byte.MaxValue || byte_0[1] != 254 || byte_0[2] != 0 || byte_0[3] != 0)
			{
				if (byte_0.Length >= 4 && byte_0[0] == 0 && byte_0[1] == 0 && byte_0[2] == 254)
				{
					num = 1;
					if (!HdHjNaFYVN4xZPUO9PyF())
					{
						goto IL_009b;
					}
					goto IL_00fa;
				}
				goto IL_010f;
			}
			return Encoding.UTF32;
		}
		return Encoding.BigEndianUnicode;
		IL_009b:
		switch (num)
		{
		case 1:
			goto IL_00fa;
		}
		goto IL_00a8;
		IL_00a8:
		if (byte_0[0] == byte.MaxValue && byte_0[1] == 254)
		{
			return Encoding.Unicode;
		}
		goto IL_00da;
		IL_00fa:
		if (byte_0[3] == byte.MaxValue)
		{
			return Encoding.GetEncoding("utf-32BE");
		}
		goto IL_010f;
	}

	private static bool I1FLojVTIKG(byte[] byte_0)
	{
		int num = byte_0.Length;
		int num2 = 0;
		int num5 = default(int);
		while (true)
		{
			int num4;
			if (num2 < num)
			{
				byte b = byte_0[num2];
				if (b >= 128)
				{
					if (b < 194 || b > 244)
					{
						break;
					}
					int num3 = ((b < 224) ? 1 : ((b >= 240) ? 3 : 2));
					if (num2 + num3 >= num)
					{
						return false;
					}
					while (num3-- > 0)
					{
						num2++;
						b = byte_0[num2];
						if (b < 128 || b > 191)
						{
							return false;
						}
					}
					num4 = 0;
					if (TBHYSQF5ziyOsyBXn5HE == null)
					{
						goto IL_0098;
					}
				}
				goto IL_00a5;
			}
			return true;
			IL_0098:
			switch (num4)
			{
			case 1:
				continue;
			}
			goto IL_00a5;
			IL_00a5:
			num2++;
			num4 = 1;
			if (!HdHjNaFYVN4xZPUO9PyF())
			{
				num4 = num5;
			}
			goto IL_0098;
		}
		return false;
	}

	public static Encoding GetEncoding(Stream fs)
	{
		return eGdLoQtPMBL(new BinaryReader(fs, Encoding.Default).ReadBytes((int)Math.Min(4000L, fs.Length)));
	}

	private static bool Yt0Lon5cbfl(byte[] byte_0)
	{
		int num = 1;
		int num2 = 0;
		int num4 = default(int);
		while (true)
		{
			if (num2 < byte_0.Length)
			{
				byte b = byte_0[num2];
				if (num == 1)
				{
					if (b >= 128)
					{
						while (((b <<= 1) & 0x80) != 0)
						{
							num++;
						}
						if (num == 1 || num > 6)
						{
							return false;
						}
						int num3 = 0;
						if (!HdHjNaFYVN4xZPUO9PyF())
						{
							num3 = num4;
						}
						switch (num3)
						{
						}
					}
				}
				else
				{
					if ((b & 0xC0) != 128)
					{
						break;
					}
					num--;
				}
				num2++;
				continue;
			}
			if (num > 1)
			{
				throw new Exception("非预期的byte格式!");
			}
			return true;
		}
		return false;
	}

	internal static bool HdHjNaFYVN4xZPUO9PyF()
	{
		return TBHYSQF5ziyOsyBXn5HE == null;
	}
}
