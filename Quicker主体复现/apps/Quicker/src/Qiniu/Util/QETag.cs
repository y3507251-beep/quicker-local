using System;
using System.IO;

namespace Qiniu.Util;

public class QETag
{
	private static int OLVehkW626;

	internal static QETag cgHRFvLEQDYu4G394G1;

	public static string calcHash(string filePath)
	{
		string result = "";
		try
		{
        byte[] array3 = default;
        int num2 = default;
        long num3 = default;
			using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			long length = fileStream.Length;
			byte[] array = new byte[4194304];
			byte[] array2 = new byte[OLVehkW626 + 1];
			int num = 1;
			if (cgHRFvLEQDYu4G394G1 == null)
			{
				goto IL_003c;
			}
			goto IL_0063;
			IL_003c:
			num2 = default(int);
			if (length <= 4194304L)
			{
				num2 = fileStream.Read(array, 0, 4194304);
				num = 0;
				if (g98PglLG7tHC0ArtOi8())
				{
					goto IL_0063;
				}
				goto IL_00bb;
			}
			num3 = ((length % 4194304L == 0L) ? (length / 4194304L) : (length / 4194304L + 1L));
			array3 = new byte[OLVehkW626 * num3];
			goto IL_00ee;
			IL_0063:
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_00bb;
			case 2:
				goto IL_00ee;
			}
			goto IL_003c;
			IL_0162:
			result = Base64.UrlSafeBase64Encode(array2);
			goto end_IL_000f;
			IL_00bb:
			byte[] array4 = new byte[num2];
			Array.Copy(array, array4, num2);
			byte[] array5 = Hashing.CalcSHA1(array4);
			array2[0] = 22;
			Array.Copy(array5, 0, array2, 1, array5.Length);
			goto IL_0162;
			IL_00ee:
			for (int i = 0; i < num3; i++)
			{
				int num4 = fileStream.Read(array, 0, 4194304);
				byte[] array6 = new byte[num4];
				Array.Copy(array, array6, num4);
				byte[] array7 = Hashing.CalcSHA1(array6);
				Array.Copy(array7, 0, array3, i * OLVehkW626, array7.Length);
			}
			byte[] array8 = Hashing.CalcSHA1(array3);
			array2[0] = 150;
			Array.Copy(array8, 0, array2, 1, array8.Length);
			goto IL_0162;
			end_IL_000f:;
		}
		catch (Exception)
		{
		}
		return result;
	}

	static QETag()
	{
		OLVehkW626 = 20;
	}

	internal static bool g98PglLG7tHC0ArtOi8()
	{
		return cgHRFvLEQDYu4G394G1 == null;
	}
}
