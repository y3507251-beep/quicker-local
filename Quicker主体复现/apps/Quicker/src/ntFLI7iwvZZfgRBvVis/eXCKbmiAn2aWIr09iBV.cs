using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Quicker.Utilities.Files;

namespace ntFLI7iwvZZfgRBvVis;

internal static class eXCKbmiAn2aWIr09iBV
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public byte[] g4w2JKN4T6r;

		internal static _003C_003Ec__DisplayClass0_0 neaOl4yvmuqqWY5Ea8cg;

		internal void zyM2JmFBdsd(HashAlgorithm algorithm)
		{
			algorithm.TransformFinalBlock(g4w2JKN4T6r, 0, 0);
		}

		internal static void zunMxCyv7gPAHQ41KODl()
		{
		}

		internal static bool dK7F7byvsEo6CwvLftAa()
		{
			return neaOl4yvmuqqWY5Ea8cg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_1
	{
		public int Spo2JrBmPAx;

		public _003C_003Ec__DisplayClass0_0 L0c2JpT8xTe;

		internal static _003C_003Ec__DisplayClass0_1 nEMuqXyv4NtQhlpAYMr2;

		internal void iYj2JxHA4Vg(HashAlgorithm algorithm)
		{
			algorithm.TransformBlock(L0c2JpT8xTe.g4w2JKN4T6r, 0, Spo2JrBmPAx, null, 0);
		}

		internal static void Fpu8O1yvzAiTxJU9FUAR()
		{
		}

		internal static bool RBSjcPyvhTto2aUsoHQj()
		{
			return nEMuqXyv4NtQhlpAYMr2 == null;
		}
	}

	private static object jeSqKbFsXMNOC7TFH3xL;

	public static (string md5, string sha1, string sha256, string crc32Hash) ObIvwbMjsBM(string string_0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.g4w2JKN4T6r = new byte[819200];
		using FileStream fileStream = File.OpenRead(string_0);
		using MD5 mD = MD5.Create();
		using SHA1 sHA = SHA1.Create();
		using SHA256 sHA2 = SHA256.Create();
		using Crc32 crc = new Crc32();
		HashAlgorithm[] source = new HashAlgorithm[4] { mD, sHA, sHA2, crc };
		int spo2JrBmPAx;
		while ((spo2JrBmPAx = fileStream.Read(_003C_003Ec__DisplayClass0_.g4w2JKN4T6r, 0, _003C_003Ec__DisplayClass0_.g4w2JKN4T6r.Length)) > 0)
		{
			_003C_003Ec__DisplayClass0_1 _003C_003Ec__DisplayClass0_2 = new _003C_003Ec__DisplayClass0_1();
			_003C_003Ec__DisplayClass0_2.L0c2JpT8xTe = _003C_003Ec__DisplayClass0_;
			_003C_003Ec__DisplayClass0_2.Spo2JrBmPAx = spo2JrBmPAx;
			Parallel.ForEach(source, _003C_003Ec__DisplayClass0_2.iYj2JxHA4Vg);
		}
		Parallel.ForEach(source, _003C_003Ec__DisplayClass0_.zyM2JmFBdsd);
		string item = mORvw6Ffxh3(mD.Hash);
		string item2 = mORvw6Ffxh3(sHA.Hash);
		string item3 = mORvw6Ffxh3(sHA2.Hash);
		string item4 = mORvw6Ffxh3(crc.Hash);
		return (md5: item, sha1: item2, sha256: item3, crc32Hash: item4);
	}

	private static string mORvw6Ffxh3(byte[] byte_0)
	{
		string text = "";
		foreach (byte b in byte_0)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	internal static string SAdvwX6aEsP(string string_0)
	{
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(string_0);
		return mORvw6Ffxh3(mD.ComputeHash(inputStream));
	}

	internal static bool D8a7xHFs2bNOnYBvWPcJ()
	{
		return jeSqKbFsXMNOC7TFH3xL == null;
	}
}
