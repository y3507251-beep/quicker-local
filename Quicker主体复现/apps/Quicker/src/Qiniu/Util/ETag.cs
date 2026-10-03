using System;
using System.IO;

namespace Qiniu.Util;

public class ETag
{
	private static int uu2eyaTsib;

	internal static ETag M6UkOYLF31L87HgZmVn;

	public static string CalcHash(string filePath)
	{
		string result = "";
		try
		{
			using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			long length = fileStream.Length;
			int num = 1;
			int num3 = default(int);
			byte[] array = default(byte[]);
			byte[] array3 = default(byte[]);
			byte[] array2 = default(byte[]);
			if (M6UkOYLF31L87HgZmVn == null)
			{
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 2:
						if (length <= 4194304L)
						{
							num3 = fileStream.Read(array, 0, 4194304);
							array3 = new byte[num3];
							num = 0;
							if (!io3M5mLcppZLawdQ9PX())
							{
								num = num2;
							}
							continue;
						}
						goto IL_00ca;
					case 1:
						array = new byte[4194304];
						array2 = new byte[uu2eyaTsib + 1];
						num2 = 2;
						goto case 2;
					}
					break;
				}
			}
			Array.Copy(array, array3, num3);
			byte[] array4 = Hashing.CalcSHA1(array3);
			array2[0] = 22;
			Array.Copy(array4, 0, array2, 1, array4.Length);
			goto IL_0186;
			IL_00ca:
			long num4 = ((length % 4194304L == 0L) ? (length / 4194304L) : (length / 4194304L + 1L));
			byte[] array5 = new byte[uu2eyaTsib * num4];
			for (int i = 0; i < num4; i++)
			{
				int num5 = fileStream.Read(array, 0, 4194304);
				byte[] array6 = new byte[num5];
				Array.Copy(array, array6, num5);
				byte[] array7 = Hashing.CalcSHA1(array6);
				Array.Copy(array7, 0, array5, i * uu2eyaTsib, array7.Length);
			}
			byte[] array8 = Hashing.CalcSHA1(array5);
			array2[0] = 150;
			Array.Copy(array8, 0, array2, 1, array8.Length);
			goto IL_0186;
			IL_0186:
			result = Base64.UrlSafeBase64Encode(array2);
		}
		catch (Exception)
		{
		}
		return result;
	}

	static ETag()
	{
		uu2eyaTsib = 20;
	}

	internal static bool io3M5mLcppZLawdQ9PX()
	{
		return M6UkOYLF31L87HgZmVn == null;
	}
}
